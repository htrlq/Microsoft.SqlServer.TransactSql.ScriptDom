using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000F7 RID: 247
	public enum MergeCondition
	{
		// Token: 0x04000BD8 RID: 3032
		NotSpecified,
		// Token: 0x04000BD9 RID: 3033
		Matched,
		// Token: 0x04000BDA RID: 3034
		NotMatched,
		// Token: 0x04000BDB RID: 3035
		NotMatchedByTarget,
		// Token: 0x04000BDC RID: 3036
		NotMatchedBySource
	}
}
