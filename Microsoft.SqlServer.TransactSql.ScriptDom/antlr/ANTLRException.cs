using System;
using System.Runtime.Serialization;

namespace antlr
{
	// Token: 0x02000004 RID: 4
	[Serializable]
	internal class ANTLRException : Exception
	{
		// Token: 0x0600002D RID: 45 RVA: 0x000029BB File Offset: 0x00000BBB
		public ANTLRException()
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000029C3 File Offset: 0x00000BC3
		public ANTLRException(string s) : base(s)
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000029CC File Offset: 0x00000BCC
		public ANTLRException(string s, Exception inner) : base(s, inner)
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000029D6 File Offset: 0x00000BD6
		protected ANTLRException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
