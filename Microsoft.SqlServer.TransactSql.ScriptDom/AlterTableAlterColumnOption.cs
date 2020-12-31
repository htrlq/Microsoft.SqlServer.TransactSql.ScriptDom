using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200004F RID: 79
	public enum AlterTableAlterColumnOption
	{
		// Token: 0x0400013E RID: 318
		NoOptionDefined,
		// Token: 0x0400013F RID: 319
		AddRowGuidCol,
		// Token: 0x04000140 RID: 320
		DropRowGuidCol,
		// Token: 0x04000141 RID: 321
		Null,
		// Token: 0x04000142 RID: 322
		NotNull,
		// Token: 0x04000143 RID: 323
		AddPersisted,
		// Token: 0x04000144 RID: 324
		DropPersisted,
		// Token: 0x04000145 RID: 325
		AddNotForReplication,
		// Token: 0x04000146 RID: 326
		DropNotForReplication,
		// Token: 0x04000147 RID: 327
		AddSparse,
		// Token: 0x04000148 RID: 328
		DropSparse
	}
}
