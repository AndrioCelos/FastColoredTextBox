using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using FastColoredTextBoxNS;

namespace Tester
{
    public partial class StyleGroupSample : Form
    {
		ShortcutStyle shortCutStyle = new ShortcutStyle(Pens.Maroon);
		WavyLineStyle underlineStyle = new WavyLineStyle(255, Color.Black);
		TextStyle[] styles = new TextStyle[128];
		// This takes 8 bits to represent because a zero value (for no style) is needed along with a value for each style in the group.

		public StyleGroupSample() {
            InitializeComponent();
        }

		private void fctb_Load(object sender, System.EventArgs e) {
			fctb.AddStyle(shortCutStyle);

			for (int i = 0; i < 128; ++i) {
				styles[i] = new TextStyle(new SolidBrush(Color.FromArgb((127 - i) * 2, i * 2, 0)), null, FontStyle.Regular);
			}

			fctb.AddStyleGroup(new StyleGroup(styles));

			for (int i = 0; i < 128; ++i) {
				fctb.AppendText(i.ToString("000") + " ", styles[i]);
			}
		}

		private void fctb_SelectionChangedDelayed(object sender, EventArgs e) {
			//here we draw shortcut for selection area
			Range selection = fctb.Selection;
			//clear previous shortcuts
			fctb.VisibleRange.ClearStyle(shortCutStyle);
			//create shortcuts
			if (!selection.IsEmpty)//user selected one or more chars?
			{
				//find last char
				var r = selection.Clone();
				r.Normalize();
				r.Start = r.End;//go to last char
				r.GoLeft(true);//select last char
							   //apply ShortCutStyle
				r.SetStyle(shortCutStyle);
			}
		}

		private void fctb_VisualMarkerClick(object sender, VisualMarkerEventArgs e) {
			//is it our style ?
			if (e.Style == shortCutStyle) {
				//show popup menu
				cmMark.Show(fctb.PointToScreen(e.Location));
			}
		}

		private void setUnderlineStyleToolStripMenuItem_Click(object sender, EventArgs e) {
			fctb.Selection.SetStyle(underlineStyle);
			// This style is independent of the text color styles.
		}

		private void setBrownStyleToolStripMenuItem_Click(object sender, EventArgs e) {
			fctb.Selection.SetStyle(styles[64]);
			// This style is mutually exclusive with the text color styles. Setting it will erase any other one of them from the range.
		}
	}
}
