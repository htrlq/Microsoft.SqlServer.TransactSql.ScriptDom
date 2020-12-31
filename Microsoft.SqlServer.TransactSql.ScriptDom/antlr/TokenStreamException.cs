using System;
using System.Runtime.Serialization;

namespace antlr
{
	// Token: 0x02000027 RID: 39
	[Serializable]
	internal class TokenStreamException : ANTLRException
	{
		// Token: 0x06000140 RID: 320 RVA: 0x00004F86 File Offset: 0x00003186
		public TokenStreamException()
		{
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00004F8E File Offset: 0x0000318E
		public TokenStreamException(string s) : base(s)
		{
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00004F97 File Offset: 0x00003197
		protected TokenStreamException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
