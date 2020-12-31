using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001BF RID: 447
	internal interface IPasswordChangeOption
	{
		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06002910 RID: 10512
		// (set) Token: 0x06002911 RID: 10513
		Literal EncryptionPassword { get; set; }

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06002912 RID: 10514
		// (set) Token: 0x06002913 RID: 10515
		Literal DecryptionPassword { get; set; }
	}
}
