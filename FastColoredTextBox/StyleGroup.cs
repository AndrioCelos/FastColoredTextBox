using System;
using System.Collections.Generic;
using System.Text;

namespace FastColoredTextBoxNS {
	public class StyleGroup {
		public int Bits { get; }
		public Style[] Styles { get; }

		public StyleGroup(int length) {
			this.Styles = new Style[length];

			int bits = 0;
			while ((1 << bits) - 1 < length) ++bits;
			this.Bits = bits;
		}

		public StyleGroup(Style[] styles) {
			this.Styles = styles;

			int bits = 0;
			while ((1 << bits) - 1 < styles.Length) ++bits;
			this.Bits = bits;
		}

		public int IndexOf(Style style) => Array.IndexOf(this.Styles, style);
	}
}
