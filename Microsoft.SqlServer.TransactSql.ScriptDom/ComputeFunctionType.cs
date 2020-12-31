using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000082 RID: 130
	public enum ComputeFunctionType
	{
		// Token: 0x040007FD RID: 2045
		NotSpecified,
		// Token: 0x040007FE RID: 2046
		Avg,
		// Token: 0x040007FF RID: 2047
		Count,
		// Token: 0x04000800 RID: 2048
		Max,
		// Token: 0x04000801 RID: 2049
		Min,
		// Token: 0x04000802 RID: 2050
		Stdev,
		// Token: 0x04000803 RID: 2051
		Stdevp,
		// Token: 0x04000804 RID: 2052
		Var,
		// Token: 0x04000805 RID: 2053
		Varp,
		// Token: 0x04000806 RID: 2054
		Sum,
		// Token: 0x04000807 RID: 2055
		CountBig,
		// Token: 0x04000808 RID: 2056
		ChecksumAgg
	}
}
