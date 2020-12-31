using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000153 RID: 339
	[Flags]
	internal enum SubDmlFlags
	{
		// Token: 0x04000DF3 RID: 3571
		None = 0,
		// Token: 0x04000DF4 RID: 3572
		InsideSubDml = 1,
		// Token: 0x04000DF5 RID: 3573
		SelectNotForInsert = 2,
		// Token: 0x04000DF6 RID: 3574
		MergeUsing = 4,
		// Token: 0x04000DF7 RID: 3575
		UpdateDeleteFrom = 8
	}
}
