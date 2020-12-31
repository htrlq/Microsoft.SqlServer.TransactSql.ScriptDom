using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200012A RID: 298
	[Serializable]
	public enum RestoreOptionKind
	{
		// Token: 0x04000CCA RID: 3274
		NoLog = 1,
		// Token: 0x04000CCB RID: 3275
		Checksum,
		// Token: 0x04000CCC RID: 3276
		NoChecksum,
		// Token: 0x04000CCD RID: 3277
		ContinueAfterError,
		// Token: 0x04000CCE RID: 3278
		StopOnError,
		// Token: 0x04000CCF RID: 3279
		Unload,
		// Token: 0x04000CD0 RID: 3280
		NoUnload,
		// Token: 0x04000CD1 RID: 3281
		Rewind,
		// Token: 0x04000CD2 RID: 3282
		NoRewind,
		// Token: 0x04000CD3 RID: 3283
		NoRecovery,
		// Token: 0x04000CD4 RID: 3284
		Recovery,
		// Token: 0x04000CD5 RID: 3285
		Replace,
		// Token: 0x04000CD6 RID: 3286
		Restart,
		// Token: 0x04000CD7 RID: 3287
		Verbose,
		// Token: 0x04000CD8 RID: 3288
		LoadHistory,
		// Token: 0x04000CD9 RID: 3289
		DboOnly,
		// Token: 0x04000CDA RID: 3290
		RestrictedUser,
		// Token: 0x04000CDB RID: 3291
		Partial,
		// Token: 0x04000CDC RID: 3292
		Snapshot,
		// Token: 0x04000CDD RID: 3293
		KeepReplication,
		// Token: 0x04000CDE RID: 3294
		Online,
		// Token: 0x04000CDF RID: 3295
		CommitDifferentialBase,
		// Token: 0x04000CE0 RID: 3296
		SnapshotImport,
		// Token: 0x04000CE1 RID: 3297
		EnableBroker,
		// Token: 0x04000CE2 RID: 3298
		NewBroker,
		// Token: 0x04000CE3 RID: 3299
		ErrorBrokerConversations,
		// Token: 0x04000CE4 RID: 3300
		Stats,
		// Token: 0x04000CE5 RID: 3301
		File,
		// Token: 0x04000CE6 RID: 3302
		StopAt,
		// Token: 0x04000CE7 RID: 3303
		MediaName,
		// Token: 0x04000CE8 RID: 3304
		MediaPassword,
		// Token: 0x04000CE9 RID: 3305
		Password,
		// Token: 0x04000CEA RID: 3306
		BlockSize,
		// Token: 0x04000CEB RID: 3307
		BufferCount,
		// Token: 0x04000CEC RID: 3308
		MaxTransferSize,
		// Token: 0x04000CED RID: 3309
		Standby,
		// Token: 0x04000CEE RID: 3310
		EnhancedIntegrity,
		// Token: 0x04000CEF RID: 3311
		SnapshotRestorePhase,
		// Token: 0x04000CF0 RID: 3312
		Move,
		// Token: 0x04000CF1 RID: 3313
		Stop,
		// Token: 0x04000CF2 RID: 3314
		FileStream = 50
	}
}
