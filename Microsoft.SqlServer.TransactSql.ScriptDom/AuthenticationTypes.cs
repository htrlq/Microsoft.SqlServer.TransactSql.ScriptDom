using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000060 RID: 96
	[Flags]
	public enum AuthenticationTypes
	{
		// Token: 0x040001B1 RID: 433
		None = 0,
		// Token: 0x040001B2 RID: 434
		Basic = 1,
		// Token: 0x040001B3 RID: 435
		Digest = 2,
		// Token: 0x040001B4 RID: 436
		Integrated = 4,
		// Token: 0x040001B5 RID: 437
		Ntlm = 8,
		// Token: 0x040001B6 RID: 438
		Kerberos = 16
	}
}
