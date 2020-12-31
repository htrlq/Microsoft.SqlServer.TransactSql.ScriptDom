using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text;

namespace antlr
{
	// Token: 0x02000020 RID: 32
	[Serializable]
	internal class NoViableAltForCharException : RecognitionException
	{
		// Token: 0x0600011C RID: 284 RVA: 0x00004A2C File Offset: 0x00002C2C
		public NoViableAltForCharException(char c, CharScanner scanner) : base("NoViableAlt", scanner.getFilename(), scanner.getLine(), scanner.getColumn())
		{
			this.foundChar = c;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00004A52 File Offset: 0x00002C52
		public NoViableAltForCharException(char c, string fileName, int line, int column) : base("NoViableAlt", fileName, line, column)
		{
			this.foundChar = c;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00004A6A File Offset: 0x00002C6A
		protected NoViableAltForCharException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00004A74 File Offset: 0x00002C74
		public override string Message
		{
			get
			{
				StringBuilder stringBuilder = new StringBuilder("unexpected char: ");
				if (this.foundChar >= ' ' && this.foundChar <= '~')
				{
					stringBuilder.Append('\'');
					stringBuilder.Append(this.foundChar);
					stringBuilder.Append('\'');
				}
				else
				{
					stringBuilder.Append("0x");
					StringBuilder stringBuilder2 = stringBuilder;
					int num = (int)this.foundChar;
					stringBuilder2.Append(num.ToString("X", CultureInfo.InvariantCulture));
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x040000A0 RID: 160
		public char foundChar;
	}
}
