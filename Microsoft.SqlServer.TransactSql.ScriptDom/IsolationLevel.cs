using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000E2 RID: 226
	public enum IsolationLevel
	{
		// Token: 0x04000B9F RID: 2975
		None,
		// Token: 0x04000BA0 RID: 2976
		ReadCommitted,
		// Token: 0x04000BA1 RID: 2977
		ReadUncommitted,
		// Token: 0x04000BA2 RID: 2978
		RepeatableRead,
		// Token: 0x04000BA3 RID: 2979
		Serializable,
		// Token: 0x04000BA4 RID: 2980
		Snapshot
	}
}
