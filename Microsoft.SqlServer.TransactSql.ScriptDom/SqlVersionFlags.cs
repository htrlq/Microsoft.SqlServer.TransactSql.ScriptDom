using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000150 RID: 336
	[Flags]
	internal enum SqlVersionFlags
	{
		// Token: 0x04000DD6 RID: 3542
		None = 0,
		// Token: 0x04000DD7 RID: 3543
		TSql80 = 1,
		// Token: 0x04000DD8 RID: 3544
		TSql90 = 2,
		// Token: 0x04000DD9 RID: 3545
		TSql100 = 4,
		// Token: 0x04000DDA RID: 3546
		TSql110 = 8,
		// Token: 0x04000DDB RID: 3547
		TSql120 = 16,
		// Token: 0x04000DDC RID: 3548
		TSqlAll = 31,
		// Token: 0x04000DDD RID: 3549
		TSql90AndAbove = 30,
		// Token: 0x04000DDE RID: 3550
		TSql100AndAbove = 28,
		// Token: 0x04000DDF RID: 3551
		TSql110AndAbove = 24,
		// Token: 0x04000DE0 RID: 3552
		TSql120AndAbove = 16,
		// Token: 0x04000DE1 RID: 3553
		TSqlUnder110 = 7,
		// Token: 0x04000DE2 RID: 3554
		TSqlUnder120 = 15
	}
}
