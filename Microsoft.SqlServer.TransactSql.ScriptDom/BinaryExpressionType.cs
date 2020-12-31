using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200006A RID: 106
	[Serializable]
	public enum BinaryExpressionType
	{
		// Token: 0x040001F8 RID: 504
		Add,
		// Token: 0x040001F9 RID: 505
		Subtract,
		// Token: 0x040001FA RID: 506
		Multiply,
		// Token: 0x040001FB RID: 507
		Divide,
		// Token: 0x040001FC RID: 508
		Modulo,
		// Token: 0x040001FD RID: 509
		BitwiseAnd,
		// Token: 0x040001FE RID: 510
		BitwiseOr,
		// Token: 0x040001FF RID: 511
		BitwiseXor
	}
}
