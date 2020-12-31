using System;

namespace antlr
{
	// Token: 0x02000012 RID: 18
	internal interface IHiddenStreamToken : IToken
	{
		// Token: 0x060000BB RID: 187
		IHiddenStreamToken getHiddenAfter();

		// Token: 0x060000BC RID: 188
		void setHiddenAfter(IHiddenStreamToken t);

		// Token: 0x060000BD RID: 189
		IHiddenStreamToken getHiddenBefore();

		// Token: 0x060000BE RID: 190
		void setHiddenBefore(IHiddenStreamToken t);
	}
}
