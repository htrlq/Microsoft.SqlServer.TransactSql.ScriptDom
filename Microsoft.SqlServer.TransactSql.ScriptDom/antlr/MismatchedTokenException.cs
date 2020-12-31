using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text;
using antlr.collections.impl;

namespace antlr
{
	// Token: 0x0200001D RID: 29
	[Serializable]
	internal class MismatchedTokenException : RecognitionException
	{
		// Token: 0x06000112 RID: 274 RVA: 0x00004657 File Offset: 0x00002857
		public MismatchedTokenException() : base("Mismatched Token: expecting any AST node", "<AST>", -1, -1)
		{
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0000466C File Offset: 0x0000286C
		public MismatchedTokenException(string[] tokenNames_, IToken token_, int lower, int upper_, bool matchNot, string fileName_) : base("Mismatched Token", fileName_, token_.getLine(), token_.getColumn())
		{
			this.tokenNames = tokenNames_;
			this.token = token_;
			this.tokenText = token_.getText();
			this.mismatchType = (matchNot ? MismatchedTokenException.TokenTypeEnum.NotRangeType : MismatchedTokenException.TokenTypeEnum.RangeType);
			this.expecting = lower;
			this.upper = upper_;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x000046CC File Offset: 0x000028CC
		public MismatchedTokenException(string[] tokenNames_, IToken token_, int expecting_, bool matchNot, string fileName_) : base("Mismatched Token", fileName_, token_.getLine(), token_.getColumn())
		{
			this.tokenNames = tokenNames_;
			this.token = token_;
			this.tokenText = token_.getText();
			this.mismatchType = (matchNot ? MismatchedTokenException.TokenTypeEnum.NotTokenType : MismatchedTokenException.TokenTypeEnum.TokenType);
			this.expecting = expecting_;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00004724 File Offset: 0x00002924
		public MismatchedTokenException(string[] tokenNames_, IToken token_, BitSet set_, bool matchNot, string fileName_) : base("Mismatched Token", fileName_, token_.getLine(), token_.getColumn())
		{
			this.tokenNames = tokenNames_;
			this.token = token_;
			this.tokenText = token_.getText();
			this.mismatchType = (matchNot ? MismatchedTokenException.TokenTypeEnum.NotSetType : MismatchedTokenException.TokenTypeEnum.SetType);
			this.bset = set_;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00004779 File Offset: 0x00002979
		protected MismatchedTokenException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000117 RID: 279 RVA: 0x00004784 File Offset: 0x00002984
		public override string Message
		{
			get
			{
				StringBuilder stringBuilder = new StringBuilder();
				switch (this.mismatchType)
				{
				case MismatchedTokenException.TokenTypeEnum.TokenType:
					stringBuilder.Append(string.Concat(new string[]
					{
						"expecting ",
						this.tokenName(this.expecting),
						", found '",
						this.tokenText,
						"'"
					}));
					break;
				case MismatchedTokenException.TokenTypeEnum.NotTokenType:
					stringBuilder.Append("expecting anything but " + this.tokenName(this.expecting) + "; got it anyway");
					break;
				case MismatchedTokenException.TokenTypeEnum.RangeType:
					stringBuilder.Append(string.Concat(new string[]
					{
						"expecting token in range: ",
						this.tokenName(this.expecting),
						"..",
						this.tokenName(this.upper),
						", found '",
						this.tokenText,
						"'"
					}));
					break;
				case MismatchedTokenException.TokenTypeEnum.NotRangeType:
					stringBuilder.Append(string.Concat(new string[]
					{
						"expecting token NOT in range: ",
						this.tokenName(this.expecting),
						"..",
						this.tokenName(this.upper),
						", found '",
						this.tokenText,
						"'"
					}));
					break;
				case MismatchedTokenException.TokenTypeEnum.SetType:
				case MismatchedTokenException.TokenTypeEnum.NotSetType:
				{
					stringBuilder.Append("expecting " + ((this.mismatchType == MismatchedTokenException.TokenTypeEnum.NotSetType) ? "NOT " : "") + "one of (");
					int[] array = this.bset.toArray();
					for (int i = 0; i < array.Length; i++)
					{
						stringBuilder.Append(" ");
						stringBuilder.Append(this.tokenName(array[i]));
					}
					stringBuilder.Append("), found '" + this.tokenText + "'");
					break;
				}
				default:
					stringBuilder.Append(base.Message);
					break;
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0000499E File Offset: 0x00002B9E
		private string tokenName(int tokenType)
		{
			if (tokenType == 0)
			{
				return "<Set of tokens>";
			}
			if (tokenType < 0 || tokenType >= this.tokenNames.Length)
			{
				return "<" + tokenType.ToString(CultureInfo.InvariantCulture) + ">";
			}
			return this.tokenNames[tokenType];
		}

		// Token: 0x04000091 RID: 145
		internal string[] tokenNames;

		// Token: 0x04000092 RID: 146
		public IToken token;

		// Token: 0x04000093 RID: 147
		internal string tokenText;

		// Token: 0x04000094 RID: 148
		public MismatchedTokenException.TokenTypeEnum mismatchType;

		// Token: 0x04000095 RID: 149
		public int expecting;

		// Token: 0x04000096 RID: 150
		public int upper;

		// Token: 0x04000097 RID: 151
		public BitSet bset;

		// Token: 0x0200001E RID: 30
		internal enum TokenTypeEnum
		{
			// Token: 0x04000099 RID: 153
			TokenType = 1,
			// Token: 0x0400009A RID: 154
			NotTokenType,
			// Token: 0x0400009B RID: 155
			RangeType,
			// Token: 0x0400009C RID: 156
			NotRangeType,
			// Token: 0x0400009D RID: 157
			SetType,
			// Token: 0x0400009E RID: 158
			NotSetType
		}
	}
}
