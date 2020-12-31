using System;
using System.Runtime.Serialization;

namespace antlr
{
	// Token: 0x0200002A RID: 42
	[Serializable]
	internal class TokenStreamRetryException : TokenStreamException
	{
		// Token: 0x06000153 RID: 339 RVA: 0x000051CD File Offset: 0x000033CD
		public TokenStreamRetryException()
		{
		}

		// Token: 0x06000154 RID: 340 RVA: 0x000051D5 File Offset: 0x000033D5
		protected TokenStreamRetryException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
