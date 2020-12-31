using System;
using System.Collections.Generic;
using antlr;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200017B RID: 379
	internal class TSqlWhitespaceTokenFilter : TokenStream
	{
		// Token: 0x06000B2A RID: 2858 RVA: 0x0001F6D8 File Offset: 0x0001D8D8
		public TSqlWhitespaceTokenFilter(bool quotedIdentifier, IList<TSqlParserToken> streamToFilter)
		{
			this._quotedIdentifier = quotedIdentifier;
			this._streamToFilter = streamToFilter;
			this._currentTokenIndex = 0;
			if (streamToFilter.Count > 0)
			{
				this._lastToken = streamToFilter[0];
			}
			else
			{
				this._lastToken = new TSqlParserToken(TSqlTokenType.EndOfFile, null);
			}
			this._streamLength = streamToFilter.Count;
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x0001F734 File Offset: 0x0001D934
		public IToken nextToken()
		{
			TSqlParserToken tsqlParserToken = null;
			int index = -1;
			while (this._currentTokenIndex < this._streamLength)
			{
				tsqlParserToken = this._streamToFilter[this._currentTokenIndex];
				index = this._currentTokenIndex;
				this._currentTokenIndex++;
				if (tsqlParserToken.TokenType != TSqlTokenType.SingleLineComment && tsqlParserToken.TokenType != TSqlTokenType.MultilineComment && tsqlParserToken.TokenType != TSqlTokenType.WhiteSpace)
				{
					break;
				}
			}
			if (tsqlParserToken == null)
			{
				if (this._streamLength != 0)
				{
					TSqlParserToken tsqlParserToken2 = this._streamToFilter[this._streamToFilter.Count - 1];
					int num = (tsqlParserToken2.Text == null) ? 0 : tsqlParserToken2.Text.Length;
					tsqlParserToken = new TSqlParserToken(TSqlTokenType.EndOfFile, tsqlParserToken2.Offset + num, null, tsqlParserToken2.Line, tsqlParserToken2.Column + num);
				}
				else
				{
					tsqlParserToken = new TSqlParserToken(TSqlTokenType.EndOfFile, null);
				}
			}
			else if (tsqlParserToken.TokenType == TSqlTokenType.AsciiStringOrQuotedIdentifier)
			{
				tsqlParserToken.ConvertStringToIdentifier = this._quotedIdentifier;
			}
			this._lastToken = tsqlParserToken;
			return new TSqlWhitespaceTokenFilter.TSqlParserTokenProxyWithIndex(tsqlParserToken, index);
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000B2C RID: 2860 RVA: 0x0001F82F File Offset: 0x0001DA2F
		public TSqlParserToken LastToken
		{
			get
			{
				return this._lastToken;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000B2D RID: 2861 RVA: 0x0001F837 File Offset: 0x0001DA37
		// (set) Token: 0x06000B2E RID: 2862 RVA: 0x0001F83F File Offset: 0x0001DA3F
		public bool QuotedIdentifier
		{
			get
			{
				return this._quotedIdentifier;
			}
			set
			{
				this._quotedIdentifier = value;
			}
		}

		// Token: 0x04000F79 RID: 3961
		private bool _quotedIdentifier;

		// Token: 0x04000F7A RID: 3962
		private IList<TSqlParserToken> _streamToFilter;

		// Token: 0x04000F7B RID: 3963
		private int _currentTokenIndex;

		// Token: 0x04000F7C RID: 3964
		private int _streamLength;

		// Token: 0x04000F7D RID: 3965
		private TSqlParserToken _lastToken;

		// Token: 0x0200017C RID: 380
		internal class TSqlParserTokenProxyWithIndex : IToken
		{
			// Token: 0x06000B2F RID: 2863 RVA: 0x0001F848 File Offset: 0x0001DA48
			public TSqlParserTokenProxyWithIndex(TSqlParserToken token, int index)
			{
				this._token = token;
				this._index = index;
			}

			// Token: 0x17000053 RID: 83
			// (get) Token: 0x06000B30 RID: 2864 RVA: 0x0001F85E File Offset: 0x0001DA5E
			public TSqlParserToken Token
			{
				get
				{
					return (TSqlParserToken)this._token;
				}
			}

			// Token: 0x17000054 RID: 84
			// (get) Token: 0x06000B31 RID: 2865 RVA: 0x0001F86B File Offset: 0x0001DA6B
			public int TokenIndex
			{
				get
				{
					return this._index;
				}
			}

			// Token: 0x06000B32 RID: 2866 RVA: 0x0001F873 File Offset: 0x0001DA73
			public int getColumn()
			{
				return this._token.getColumn();
			}

			// Token: 0x06000B33 RID: 2867 RVA: 0x0001F880 File Offset: 0x0001DA80
			public void setColumn(int c)
			{
				this._token.setColumn(c);
			}

			// Token: 0x06000B34 RID: 2868 RVA: 0x0001F88E File Offset: 0x0001DA8E
			public int getLine()
			{
				return this._token.getLine();
			}

			// Token: 0x06000B35 RID: 2869 RVA: 0x0001F89B File Offset: 0x0001DA9B
			public void setLine(int l)
			{
				this._token.setLine(l);
			}

			// Token: 0x06000B36 RID: 2870 RVA: 0x0001F8A9 File Offset: 0x0001DAA9
			public string getFilename()
			{
				return this._token.getFilename();
			}

			// Token: 0x06000B37 RID: 2871 RVA: 0x0001F8B6 File Offset: 0x0001DAB6
			public void setFilename(string name)
			{
				this._token.setFilename(name);
			}

			// Token: 0x06000B38 RID: 2872 RVA: 0x0001F8C4 File Offset: 0x0001DAC4
			public string getText()
			{
				return this._token.getText();
			}

			// Token: 0x06000B39 RID: 2873 RVA: 0x0001F8D1 File Offset: 0x0001DAD1
			public void setText(string t)
			{
				this._token.setText(t);
			}

			// Token: 0x17000055 RID: 85
			// (get) Token: 0x06000B3A RID: 2874 RVA: 0x0001F8DF File Offset: 0x0001DADF
			// (set) Token: 0x06000B3B RID: 2875 RVA: 0x0001F8EC File Offset: 0x0001DAEC
			public int Type
			{
				get
				{
					return this._token.Type;
				}
				set
				{
					this._token.Type = value;
				}
			}

			// Token: 0x04000F7E RID: 3966
			private IToken _token;

			// Token: 0x04000F7F RID: 3967
			private int _index;
		}
	}
}
