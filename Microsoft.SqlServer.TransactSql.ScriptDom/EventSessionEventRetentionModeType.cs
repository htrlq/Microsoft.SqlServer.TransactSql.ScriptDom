using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000B7 RID: 183
	[Serializable]
	public enum EventSessionEventRetentionModeType
	{
		// Token: 0x04000AFD RID: 2813
		Unknown,
		// Token: 0x04000AFE RID: 2814
		AllowSingleEventLoss,
		// Token: 0x04000AFF RID: 2815
		AllowMultipleEventLoss,
		// Token: 0x04000B00 RID: 2816
		NoEventLoss
	}
}
