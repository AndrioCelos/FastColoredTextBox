namespace Tester
{
    partial class StyleGroupSample
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StyleGroupSample));
			this.label1 = new System.Windows.Forms.Label();
			this.fctb = new FastColoredTextBoxNS.FastColoredTextBox();
			this.cmMark = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.setUnderlineStyleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.setBrownStyleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.fctb)).BeginInit();
			this.cmMark.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(664, 86);
			this.label1.TabIndex = 1;
			this.label1.Text = resources.GetString("label1.Text");
			// 
			// fctb
			// 
			this.fctb.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
			this.fctb.AutoScrollMinSize = new System.Drawing.Size(0, 19);
			this.fctb.BackBrush = null;
			this.fctb.CharHeight = 19;
			this.fctb.CharWidth = 9;
			this.fctb.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.fctb.DescriptionFile = "";
			this.fctb.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.fctb.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fctb.Font = new System.Drawing.Font("Consolas", 9.75F);
			this.fctb.IsReplaceMode = false;
			this.fctb.Location = new System.Drawing.Point(0, 86);
			this.fctb.Margin = new System.Windows.Forms.Padding(4);
			this.fctb.Name = "fctb";
			this.fctb.Paddings = new System.Windows.Forms.Padding(0);
			this.fctb.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
			this.fctb.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctb.ServiceColors")));
			this.fctb.ShowLineNumbers = false;
			this.fctb.Size = new System.Drawing.Size(664, 235);
			this.fctb.TabIndex = 0;
			this.fctb.WordWrap = true;
			this.fctb.Zoom = 100;
			this.fctb.SelectionChangedDelayed += new System.EventHandler(this.fctb_SelectionChangedDelayed);
			this.fctb.VisualMarkerClick += new System.EventHandler<FastColoredTextBoxNS.VisualMarkerEventArgs>(this.fctb_VisualMarkerClick);
			this.fctb.Load += new System.EventHandler(this.fctb_Load);
			// 
			// cmMark
			// 
			this.cmMark.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.cmMark.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setUnderlineStyleToolStripMenuItem,
            this.setBrownStyleToolStripMenuItem});
			this.cmMark.Name = "contextMenuStrip1";
			this.cmMark.Size = new System.Drawing.Size(200, 52);
			// 
			// setUnderlineStyleToolStripMenuItem
			// 
			this.setUnderlineStyleToolStripMenuItem.Name = "setUnderlineStyleToolStripMenuItem";
			this.setUnderlineStyleToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
			this.setUnderlineStyleToolStripMenuItem.Text = "Set &underline style";
			this.setUnderlineStyleToolStripMenuItem.Click += new System.EventHandler(this.setUnderlineStyleToolStripMenuItem_Click);
			// 
			// setBrownStyleToolStripMenuItem
			// 
			this.setBrownStyleToolStripMenuItem.Name = "setBrownStyleToolStripMenuItem";
			this.setBrownStyleToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
			this.setBrownStyleToolStripMenuItem.Text = "Set b&rown style";
			this.setBrownStyleToolStripMenuItem.Click += new System.EventHandler(this.setBrownStyleToolStripMenuItem_Click);
			// 
			// StyleGroupSample
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(664, 321);
			this.Controls.Add(this.fctb);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "StyleGroupSample";
			this.Text = "StyleGroupSample";
			((System.ComponentModel.ISupportInitialize)(this.fctb)).EndInit();
			this.cmMark.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox fctb;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ContextMenuStrip cmMark;
		private System.Windows.Forms.ToolStripMenuItem setUnderlineStyleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem setBrownStyleToolStripMenuItem;
	}
}