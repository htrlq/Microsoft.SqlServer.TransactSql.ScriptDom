using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200010B RID: 267
	public enum PartnerDatabaseOptionKind
	{
		// Token: 0x04000C41 RID: 3137
		None,
		// Token: 0x04000C42 RID: 3138
		PartnerServer,
		// Token: 0x04000C43 RID: 3139
		Failover,
		// Token: 0x04000C44 RID: 3140
		ForceServiceAllowDataLoss,
		// Token: 0x04000C45 RID: 3141
		Off,
		// Token: 0x04000C46 RID: 3142
		Resume,
		// Token: 0x04000C47 RID: 3143
		SafetyFull,
		// Token: 0x04000C48 RID: 3144
		SafetyOff,
		// Token: 0x04000C49 RID: 3145
		Suspend,
		// Token: 0x04000C4A RID: 3146
		Timeout
	}
}
