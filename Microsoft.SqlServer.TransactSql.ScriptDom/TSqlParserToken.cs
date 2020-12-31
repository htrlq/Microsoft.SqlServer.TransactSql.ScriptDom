using System;
using antlr;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200017A RID: 378
	public sealed class TSqlParserToken : IToken
	{
		// Token: 0x06000B10 RID: 2832 RVA: 0x0001F599 File Offset: 0x0001D799
		public TSqlParserToken() : this(TSqlTokenType.None, 0, null, 1, 1)
		{
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x0001F5A6 File Offset: 0x0001D7A6
		public TSqlParserToken(TSqlTokenType type, string text) : this(type, 0, text, 1, 1)
		{
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x0001F5B3 File Offset: 0x0001D7B3
		public TSqlParserToken(TSqlTokenType type, int offset, string text, int line, int column)
		{
			this._text = text;
			this._tokenType = type;
			this._offset = offset;
			this._line = line;
			this._column = column;
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000B13 RID: 2835 RVA: 0x0001F5E0 File Offset: 0x0001D7E0
		// (set) Token: 0x06000B14 RID: 2836 RVA: 0x0001F5E8 File Offset: 0x0001D7E8
		public TSqlTokenType TokenType
		{
			get
			{
				return this._tokenType;
			}
			set
			{
				this._tokenType = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000B15 RID: 2837 RVA: 0x0001F5F1 File Offset: 0x0001D7F1
		// (set) Token: 0x06000B16 RID: 2838 RVA: 0x0001F5F9 File Offset: 0x0001D7F9
		internal bool ConvertStringToIdentifier
		{
			get
			{
				return this._convertStringToIdentifier;
			}
			set
			{
				this._convertStringToIdentifier = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000B17 RID: 2839 RVA: 0x0001F602 File Offset: 0x0001D802
		// (set) Token: 0x06000B18 RID: 2840 RVA: 0x0001F60A File Offset: 0x0001D80A
		public int Offset
		{
			get
			{
				return this._offset;
			}
			set
			{
				this._offset = value;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000B19 RID: 2841 RVA: 0x0001F613 File Offset: 0x0001D813
		// (set) Token: 0x06000B1A RID: 2842 RVA: 0x0001F61B File Offset: 0x0001D81B
		public int Line
		{
			get
			{
				return this._line;
			}
			set
			{
				this._line = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000B1B RID: 2843 RVA: 0x0001F624 File Offset: 0x0001D824
		// (set) Token: 0x06000B1C RID: 2844 RVA: 0x0001F62C File Offset: 0x0001D82C
		public int Column
		{
			get
			{
				return this._column;
			}
			set
			{
				this._column = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x0001F635 File Offset: 0x0001D835
		// (set) Token: 0x06000B1E RID: 2846 RVA: 0x0001F63D File Offset: 0x0001D83D
		public string Text
		{
			get
			{
				return this._text;
			}
			set
			{
				this._text = value;
			}
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x0001F646 File Offset: 0x0001D846
		public bool IsKeyword()
		{
			return this.TokenType > TSqlTokenType.EndOfFile && this.TokenType < TSqlTokenType.Bang;
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000B20 RID: 2848 RVA: 0x0001F660 File Offset: 0x0001D860
		// (set) Token: 0x06000B21 RID: 2849 RVA: 0x0001F689 File Offset: 0x0001D889
		int IToken.Type
		{
			get
			{
				if (this._tokenType != TSqlTokenType.AsciiStringOrQuotedIdentifier)
				{
					return (int)this._tokenType;
				}
				if (this._convertStringToIdentifier)
				{
					return 233;
				}
				return 230;
			}
			set
			{
				if (this._tokenType != TSqlTokenType.AsciiStringOrQuotedIdentifier)
				{
					this._tokenType = (TSqlTokenType)value;
				}
			}
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x0001F69F File Offset: 0x0001D89F
		int IToken.getColumn()
		{
			return this._column;
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x0001F6A7 File Offset: 0x0001D8A7
		void IToken.setColumn(int c)
		{
			this._column = c;
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x0001F6B0 File Offset: 0x0001D8B0
		int IToken.getLine()
		{
			return this._line;
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x0001F6B8 File Offset: 0x0001D8B8
		void IToken.setLine(int l)
		{
			this._line = l;
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x0001F6C1 File Offset: 0x0001D8C1
		string IToken.getFilename()
		{
			return null;
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x0001F6C4 File Offset: 0x0001D8C4
		void IToken.setFilename(string name)
		{
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x0001F6C6 File Offset: 0x0001D8C6
		string IToken.getText()
		{
			return this.Text;
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x0001F6CE File Offset: 0x0001D8CE
		void IToken.setText(string t)
		{
			this.Text = t;
		}

		// Token: 0x04000F73 RID: 3955
		private string _text;

		// Token: 0x04000F74 RID: 3956
		private int _offset;

		// Token: 0x04000F75 RID: 3957
		private int _line;

		// Token: 0x04000F76 RID: 3958
		private int _column;

		// Token: 0x04000F77 RID: 3959
		private TSqlTokenType _tokenType;

		// Token: 0x04000F78 RID: 3960
		private bool _convertStringToIdentifier;
	}
}
