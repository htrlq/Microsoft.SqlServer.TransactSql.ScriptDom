using System;
using System.Runtime.Serialization;

namespace antlr
{
	// Token: 0x0200001F RID: 31
	[Serializable]
	internal class NoViableAltException : RecognitionException
	{
		// Token: 0x06000119 RID: 281 RVA: 0x000049DC File Offset: 0x00002BDC
		public NoViableAltException(IToken t, string fileName_) : base("NoViableAlt", fileName_, t.getLine(), t.getColumn())
		{
			this.token = t;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000049FD File Offset: 0x00002BFD
		protected NoViableAltException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600011B RID: 283 RVA: 0x00004A07 File Offset: 0x00002C07
		public override string Message
		{
			get
			{
				if (this.token != null)
				{
					return "unexpected token: " + this.token.ToString();
				}
				return "unexpected token: (null)";
			}
		}

		// Token: 0x0400009F RID: 159
		public IToken token;
	}
}
