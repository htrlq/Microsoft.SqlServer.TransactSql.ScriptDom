using System;
using System.Globalization;
using System.IO;
using antlr;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000171 RID: 369
	internal abstract class TSqlLexerBaseInternal : CharScanner
	{
		// Token: 0x06000A92 RID: 2706 RVA: 0x0001A4B7 File Offset: 0x000186B7
		protected TSqlLexerBaseInternal(LexerSharedInputState state) : base(state)
		{
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x0001A4C0 File Offset: 0x000186C0
		public void InitializeForNewInput(int startOffset, int startLine, int startColumn, TextReader input)
		{
			this.setTabSize(1);
			base.resetState(input);
			this.setColumn(startColumn);
			this.setLine(startLine);
			this._currentLineStartOffset = startOffset - (startColumn - 1);
			this._acceptableGoOffset = startOffset;
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000A94 RID: 2708 RVA: 0x0001A4F1 File Offset: 0x000186F1
		public int CurrentOffset
		{
			get
			{
				return this._currentLineStartOffset + this.getColumn() - 1;
			}
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x0001A502 File Offset: 0x00018702
		public override void newline()
		{
			this._currentLineStartOffset += this.getColumn() - 1;
			base.newline();
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x0001A51F File Offset: 0x0001871F
		protected internal override IToken makeToken(int t)
		{
			return new TSqlParserToken((TSqlTokenType)t, this.CurrentOffset - this.text.Length, null, this.inputState.tokenStartLine, this.inputState.tokenStartColumn);
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x0001A550 File Offset: 0x00018750
		protected void checkEOF(TSqlLexerBaseInternal.TokenKind currentToken)
		{
			if (this.LA(1) == CharScanner.EOF_CHAR)
			{
				this.uponEOF();
				ParseError parseError = null;
				switch (currentToken)
				{
				case TSqlLexerBaseInternal.TokenKind.String:
					parseError = TSql80ParserBaseInternal.CreateParseError("SQL46030", this._complexTokenStartOffset, this.inputState.tokenStartLine, this.inputState.tokenStartColumn, TSqlParserResource.SQL46030Message, new string[]
					{
						this.getText().TrimEnd(new char[]
						{
							CharScanner.EOF_CHAR
						})
					});
					break;
				case TSqlLexerBaseInternal.TokenKind.SqlCommandIdentifier:
					parseError = TSql80ParserBaseInternal.CreateParseError("SQL46033", this._complexTokenStartOffset, this.inputState.tokenStartLine, this.inputState.tokenStartColumn, TSqlParserResource.SQL46033Message, new string[]
					{
						this.getText().TrimEnd(new char[]
						{
							CharScanner.EOF_CHAR
						})
					});
					break;
				case TSqlLexerBaseInternal.TokenKind.QuotedIdentifier:
					parseError = TSql80ParserBaseInternal.CreateParseError("SQL46031", this._complexTokenStartOffset, this.inputState.tokenStartLine, this.inputState.tokenStartColumn, TSqlParserResource.SQL46031Message, new string[]
					{
						this.getText().TrimEnd(new char[]
						{
							CharScanner.EOF_CHAR
						})
					});
					break;
				case TSqlLexerBaseInternal.TokenKind.MultiLineComment:
					parseError = TSql80ParserBaseInternal.CreateParseError("SQL46032", this.CurrentOffset, this.getLine(), this.getColumn(), TSqlParserResource.SQL46032Message, new string[0]);
					break;
				}
				if (parseError != null)
				{
					throw new TSqlParseErrorException(parseError);
				}
			}
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x0001A6D7 File Offset: 0x000188D7
		protected void beginComplexToken()
		{
			this._complexTokenStartOffset = this.CurrentOffset;
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x0001A6E8 File Offset: 0x000188E8
		internal static bool IsValueTooLargeForTokenInteger(string source)
		{
			int length = source.Length;
			if (length > 11)
			{
				return true;
			}
			if (length >= 10)
			{
				long num = long.Parse(source, CultureInfo.InvariantCulture.NumberFormat);
				return num > 2147483647L;
			}
			return false;
		}

		// Token: 0x04000E62 RID: 3682
		private int _complexTokenStartOffset;

		// Token: 0x04000E63 RID: 3683
		protected int _currentLineStartOffset;

		// Token: 0x04000E64 RID: 3684
		protected int _acceptableGoOffset;

		// Token: 0x02000172 RID: 370
		protected enum TokenKind
		{
			// Token: 0x04000E66 RID: 3686
			Common,
			// Token: 0x04000E67 RID: 3687
			String,
			// Token: 0x04000E68 RID: 3688
			SqlCommandIdentifier,
			// Token: 0x04000E69 RID: 3689
			QuotedIdentifier,
			// Token: 0x04000E6A RID: 3690
			MultiLineComment
		}
	}
}
