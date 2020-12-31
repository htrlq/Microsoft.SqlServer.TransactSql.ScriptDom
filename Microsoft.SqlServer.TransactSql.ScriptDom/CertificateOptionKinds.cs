using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000078 RID: 120
	[Flags]
	public enum CertificateOptionKinds
	{
		// Token: 0x04000244 RID: 580
		None = 0,
		// Token: 0x04000245 RID: 581
		Subject = 1,
		// Token: 0x04000246 RID: 582
		StartDate = 2,
		// Token: 0x04000247 RID: 583
		ExpiryDate = 4
	}
}
