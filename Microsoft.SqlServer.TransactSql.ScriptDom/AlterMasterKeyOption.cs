using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000044 RID: 68
	[Serializable]
	public enum AlterMasterKeyOption
	{
		// Token: 0x04000110 RID: 272
		None,
		// Token: 0x04000111 RID: 273
		Regenerate,
		// Token: 0x04000112 RID: 274
		ForceRegenerate,
		// Token: 0x04000113 RID: 275
		AddEncryptionByServiceMasterKey,
		// Token: 0x04000114 RID: 276
		AddEncryptionByPassword,
		// Token: 0x04000115 RID: 277
		DropEncryptionByServiceMasterKey,
		// Token: 0x04000116 RID: 278
		DropEncryptionByPassword
	}
}
