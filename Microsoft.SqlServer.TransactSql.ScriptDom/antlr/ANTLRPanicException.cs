using System;
using System.Runtime.Serialization;

namespace antlr
{
	// Token: 0x02000005 RID: 5
	[Serializable]
	internal class ANTLRPanicException : ANTLRException
	{
		// Token: 0x06000031 RID: 49 RVA: 0x000029E0 File Offset: 0x00000BE0
		public ANTLRPanicException()
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000029E8 File Offset: 0x00000BE8
		public ANTLRPanicException(string s) : base(s)
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000029F1 File Offset: 0x00000BF1
		public ANTLRPanicException(string s, Exception inner) : base(s, inner)
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000029FB File Offset: 0x00000BFB
		protected ANTLRPanicException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
