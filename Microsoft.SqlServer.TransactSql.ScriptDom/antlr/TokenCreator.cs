using System;

namespace antlr
{
	// Token: 0x0200000C RID: 12
	internal abstract class TokenCreator
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600008C RID: 140
		public abstract string TokenTypeName { get; }

		// Token: 0x0600008D RID: 141
		public abstract IToken Create();
	}
}
