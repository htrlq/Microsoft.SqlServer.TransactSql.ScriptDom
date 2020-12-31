using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200012D RID: 301
	[Serializable]
	public enum RestoreStatementKind
	{
		// Token: 0x04000CF6 RID: 3318
		None,
		// Token: 0x04000CF7 RID: 3319
		Database,
		// Token: 0x04000CF8 RID: 3320
		TransactionLog,
		// Token: 0x04000CF9 RID: 3321
		FileListOnly,
		// Token: 0x04000CFA RID: 3322
		VerifyOnly,
		// Token: 0x04000CFB RID: 3323
		LabelOnly,
		// Token: 0x04000CFC RID: 3324
		RewindOnly,
		// Token: 0x04000CFD RID: 3325
		HeaderOnly
	}
}
