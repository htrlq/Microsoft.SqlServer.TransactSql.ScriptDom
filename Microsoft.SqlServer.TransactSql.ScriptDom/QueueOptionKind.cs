using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200011F RID: 287
	[Serializable]
	public enum QueueOptionKind
	{
		// Token: 0x04000C9A RID: 3226
		Status,
		// Token: 0x04000C9B RID: 3227
		Retention,
		// Token: 0x04000C9C RID: 3228
		ActivationStatus,
		// Token: 0x04000C9D RID: 3229
		ActivationProcedureName,
		// Token: 0x04000C9E RID: 3230
		ActivationMaxQueueReaders,
		// Token: 0x04000C9F RID: 3231
		ActivationExecuteAs,
		// Token: 0x04000CA0 RID: 3232
		ActivationDrop,
		// Token: 0x04000CA1 RID: 3233
		PoisonMessageHandlingStatus
	}
}
