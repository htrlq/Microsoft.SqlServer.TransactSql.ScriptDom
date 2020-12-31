using System;
using System.Runtime.Serialization;
using System.Text;
using antlr.collections.impl;

namespace antlr
{
	// Token: 0x0200001B RID: 27
	[Serializable]
	internal class MismatchedCharException : RecognitionException
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00004340 File Offset: 0x00002540
		public override string Message
		{
			get
			{
				StringBuilder stringBuilder = new StringBuilder();
				switch (this.mismatchType)
				{
				case MismatchedCharException.CharTypeEnum.CharType:
					stringBuilder.Append("expecting ");
					MismatchedCharException.appendCharName(stringBuilder, this.expecting);
					stringBuilder.Append(", found ");
					MismatchedCharException.appendCharName(stringBuilder, this.foundChar);
					break;
				case MismatchedCharException.CharTypeEnum.NotCharType:
					stringBuilder.Append("expecting anything but '");
					MismatchedCharException.appendCharName(stringBuilder, this.expecting);
					stringBuilder.Append("'; got it anyway");
					break;
				case MismatchedCharException.CharTypeEnum.RangeType:
				case MismatchedCharException.CharTypeEnum.NotRangeType:
					stringBuilder.Append("expecting token ");
					if (this.mismatchType == MismatchedCharException.CharTypeEnum.NotRangeType)
					{
						stringBuilder.Append("NOT ");
					}
					stringBuilder.Append("in range: ");
					MismatchedCharException.appendCharName(stringBuilder, this.expecting);
					stringBuilder.Append("..");
					MismatchedCharException.appendCharName(stringBuilder, this.upper);
					stringBuilder.Append(", found ");
					MismatchedCharException.appendCharName(stringBuilder, this.foundChar);
					break;
				case MismatchedCharException.CharTypeEnum.SetType:
				case MismatchedCharException.CharTypeEnum.NotSetType:
				{
					stringBuilder.Append("expecting " + ((this.mismatchType == MismatchedCharException.CharTypeEnum.NotSetType) ? "NOT " : "") + "one of (");
					int[] array = this.bset.toArray();
					for (int i = 0; i < array.Length; i++)
					{
						MismatchedCharException.appendCharName(stringBuilder, array[i]);
					}
					stringBuilder.Append("), found ");
					MismatchedCharException.appendCharName(stringBuilder, this.foundChar);
					break;
				}
				default:
					stringBuilder.Append(base.Message);
					break;
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000044C3 File Offset: 0x000026C3
		public MismatchedCharException() : base("Mismatched char")
		{
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000044D0 File Offset: 0x000026D0
		public MismatchedCharException(char c, char lower, char upper_, bool matchNot, CharScanner scanner_) : base("Mismatched char", scanner_.getFilename(), scanner_.getLine(), scanner_.getColumn())
		{
			this.mismatchType = (matchNot ? MismatchedCharException.CharTypeEnum.NotRangeType : MismatchedCharException.CharTypeEnum.RangeType);
			this.foundChar = (int)c;
			this.expecting = (int)lower;
			this.upper = (int)upper_;
			this.scanner = scanner_;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00004528 File Offset: 0x00002728
		public MismatchedCharException(char c, char expecting_, bool matchNot, CharScanner scanner_) : base("Mismatched char", scanner_.getFilename(), scanner_.getLine(), scanner_.getColumn())
		{
			this.mismatchType = (matchNot ? MismatchedCharException.CharTypeEnum.NotCharType : MismatchedCharException.CharTypeEnum.CharType);
			this.foundChar = (int)c;
			this.expecting = (int)expecting_;
			this.scanner = scanner_;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00004578 File Offset: 0x00002778
		public MismatchedCharException(char c, BitSet set_, bool matchNot, CharScanner scanner_) : base("Mismatched char", scanner_.getFilename(), scanner_.getLine(), scanner_.getColumn())
		{
			this.mismatchType = (matchNot ? MismatchedCharException.CharTypeEnum.NotSetType : MismatchedCharException.CharTypeEnum.SetType);
			this.foundChar = (int)c;
			this.bset = set_;
			this.scanner = scanner_;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x000045C8 File Offset: 0x000027C8
		protected MismatchedCharException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000045D4 File Offset: 0x000027D4
		private static void appendCharName(StringBuilder sb, int c)
		{
			switch (c)
			{
			case 9:
				sb.Append("'\\t'");
				return;
			case 10:
				sb.Append("'\\n'");
				return;
			case 11:
			case 12:
				break;
			case 13:
				sb.Append("'\\r'");
				return;
			default:
				if (c == 65535)
				{
					sb.Append("'<EOF>'");
					return;
				}
				break;
			}
			sb.Append('\'');
			sb.Append((char)c);
			sb.Append('\'');
		}

		// Token: 0x04000084 RID: 132
		public MismatchedCharException.CharTypeEnum mismatchType;

		// Token: 0x04000085 RID: 133
		public int foundChar;

		// Token: 0x04000086 RID: 134
		public int expecting;

		// Token: 0x04000087 RID: 135
		public int upper;

		// Token: 0x04000088 RID: 136
		public BitSet bset;

		// Token: 0x04000089 RID: 137
		public CharScanner scanner;

		// Token: 0x0200001C RID: 28
		internal enum CharTypeEnum
		{
			// Token: 0x0400008B RID: 139
			CharType = 1,
			// Token: 0x0400008C RID: 140
			NotCharType,
			// Token: 0x0400008D RID: 141
			RangeType,
			// Token: 0x0400008E RID: 142
			NotRangeType,
			// Token: 0x0400008F RID: 143
			SetType,
			// Token: 0x04000090 RID: 144
			NotSetType
		}
	}
}
