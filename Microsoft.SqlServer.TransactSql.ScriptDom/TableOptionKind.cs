using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000158 RID: 344
	public enum TableOptionKind
	{
		// Token: 0x04000E1E RID: 3614
		LockEscalation,
		// Token: 0x04000E1F RID: 3615
		FileStreamOn,
		// Token: 0x04000E20 RID: 3616
		DataCompression,
		// Token: 0x04000E21 RID: 3617
		FileTableDirectory,
		// Token: 0x04000E22 RID: 3618
		FileTableCollateFileName,
		// Token: 0x04000E23 RID: 3619
		FileTablePrimaryKeyConstraintName,
		// Token: 0x04000E24 RID: 3620
		FileTableStreamIdUniqueConstraintName,
		// Token: 0x04000E25 RID: 3621
		FileTableFullPathUniqueConstraintName,
		// Token: 0x04000E26 RID: 3622
		MemoryOptimized,
		// Token: 0x04000E27 RID: 3623
		Durability
	}
}
