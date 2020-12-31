using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000066 RID: 102
	public enum BackupOptionKind
	{
		// Token: 0x040001C7 RID: 455
		None,
		// Token: 0x040001C8 RID: 456
		NoRecovery,
		// Token: 0x040001C9 RID: 457
		TruncateOnly,
		// Token: 0x040001CA RID: 458
		NoLog,
		// Token: 0x040001CB RID: 459
		NoTruncate,
		// Token: 0x040001CC RID: 460
		Unload,
		// Token: 0x040001CD RID: 461
		NoUnload,
		// Token: 0x040001CE RID: 462
		Rewind,
		// Token: 0x040001CF RID: 463
		NoRewind,
		// Token: 0x040001D0 RID: 464
		Format,
		// Token: 0x040001D1 RID: 465
		NoFormat,
		// Token: 0x040001D2 RID: 466
		Init,
		// Token: 0x040001D3 RID: 467
		NoInit,
		// Token: 0x040001D4 RID: 468
		Skip,
		// Token: 0x040001D5 RID: 469
		NoSkip,
		// Token: 0x040001D6 RID: 470
		Restart,
		// Token: 0x040001D7 RID: 471
		Stats,
		// Token: 0x040001D8 RID: 472
		Differential,
		// Token: 0x040001D9 RID: 473
		Snapshot,
		// Token: 0x040001DA RID: 474
		Checksum,
		// Token: 0x040001DB RID: 475
		NoChecksum,
		// Token: 0x040001DC RID: 476
		ContinueAfterError,
		// Token: 0x040001DD RID: 477
		StopOnError,
		// Token: 0x040001DE RID: 478
		CopyOnly,
		// Token: 0x040001DF RID: 479
		Standby,
		// Token: 0x040001E0 RID: 480
		ExpireDate,
		// Token: 0x040001E1 RID: 481
		RetainDays,
		// Token: 0x040001E2 RID: 482
		Name,
		// Token: 0x040001E3 RID: 483
		Description,
		// Token: 0x040001E4 RID: 484
		Password,
		// Token: 0x040001E5 RID: 485
		MediaName,
		// Token: 0x040001E6 RID: 486
		MediaDescription,
		// Token: 0x040001E7 RID: 487
		MediaPassword,
		// Token: 0x040001E8 RID: 488
		BlockSize,
		// Token: 0x040001E9 RID: 489
		BufferCount,
		// Token: 0x040001EA RID: 490
		MaxTransferSize,
		// Token: 0x040001EB RID: 491
		EnhancedIntegrity,
		// Token: 0x040001EC RID: 492
		Compression,
		// Token: 0x040001ED RID: 493
		NoCompression,
		// Token: 0x040001EE RID: 494
		Encryption
	}
}
