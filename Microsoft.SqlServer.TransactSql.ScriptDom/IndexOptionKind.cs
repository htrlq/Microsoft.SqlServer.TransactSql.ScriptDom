using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000DE RID: 222
	public enum IndexOptionKind
	{
		// Token: 0x04000B85 RID: 2949
		PadIndex,
		// Token: 0x04000B86 RID: 2950
		FillFactor,
		// Token: 0x04000B87 RID: 2951
		SortInTempDB,
		// Token: 0x04000B88 RID: 2952
		IgnoreDupKey,
		// Token: 0x04000B89 RID: 2953
		StatisticsNoRecompute,
		// Token: 0x04000B8A RID: 2954
		DropExisting,
		// Token: 0x04000B8B RID: 2955
		Online,
		// Token: 0x04000B8C RID: 2956
		AllowRowLocks,
		// Token: 0x04000B8D RID: 2957
		AllowPageLocks,
		// Token: 0x04000B8E RID: 2958
		MaxDop,
		// Token: 0x04000B8F RID: 2959
		LobCompaction,
		// Token: 0x04000B90 RID: 2960
		FileStreamOn,
		// Token: 0x04000B91 RID: 2961
		DataCompression,
		// Token: 0x04000B92 RID: 2962
		MoveTo,
		// Token: 0x04000B93 RID: 2963
		BucketCount,
		// Token: 0x04000B94 RID: 2964
		StatisticsIncremental
	}
}
