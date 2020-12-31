using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200003E RID: 62
	[Serializable]
	public enum AlterCertificateStatementKind
	{
		// Token: 0x040000EF RID: 239
		None,
		// Token: 0x040000F0 RID: 240
		RemovePrivateKey,
		// Token: 0x040000F1 RID: 241
		RemoveAttestedOption,
		// Token: 0x040000F2 RID: 242
		WithPrivateKey,
		// Token: 0x040000F3 RID: 243
		WithActiveForBeginDialog,
		// Token: 0x040000F4 RID: 244
		AttestedBy
	}
}
