using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000141 RID: 321
	[Flags]
	[Serializable]
	public enum SetOptions
	{
		// Token: 0x04000D60 RID: 3424
		None = 0,
		// Token: 0x04000D61 RID: 3425
		QuotedIdentifier = 1,
		// Token: 0x04000D62 RID: 3426
		ConcatNullYieldsNull = 2,
		// Token: 0x04000D63 RID: 3427
		CursorCloseOnCommit = 4,
		// Token: 0x04000D64 RID: 3428
		ArithAbort = 8,
		// Token: 0x04000D65 RID: 3429
		ArithIgnore = 16,
		// Token: 0x04000D66 RID: 3430
		FmtOnly = 32,
		// Token: 0x04000D67 RID: 3431
		NoCount = 64,
		// Token: 0x04000D68 RID: 3432
		NoExec = 128,
		// Token: 0x04000D69 RID: 3433
		NumericRoundAbort = 256,
		// Token: 0x04000D6A RID: 3434
		ParseOnly = 512,
		// Token: 0x04000D6B RID: 3435
		AnsiDefaults = 1024,
		// Token: 0x04000D6C RID: 3436
		AnsiNullDfltOff = 2048,
		// Token: 0x04000D6D RID: 3437
		AnsiNullDfltOn = 4096,
		// Token: 0x04000D6E RID: 3438
		AnsiNulls = 8192,
		// Token: 0x04000D6F RID: 3439
		AnsiPadding = 16384,
		// Token: 0x04000D70 RID: 3440
		AnsiWarnings = 32768,
		// Token: 0x04000D71 RID: 3441
		ForcePlan = 65536,
		// Token: 0x04000D72 RID: 3442
		ShowPlanAll = 131072,
		// Token: 0x04000D73 RID: 3443
		ShowPlanText = 262144,
		// Token: 0x04000D74 RID: 3444
		ImplicitTransactions = 524288,
		// Token: 0x04000D75 RID: 3445
		RemoteProcTransactions = 1048576,
		// Token: 0x04000D76 RID: 3446
		XactAbort = 2097152,
		// Token: 0x04000D77 RID: 3447
		DisableDefCnstChk = 4194304,
		// Token: 0x04000D78 RID: 3448
		ShowPlanXml = 8388608,
		// Token: 0x04000D79 RID: 3449
		NoBrowsetable = 16777216
	}
}
