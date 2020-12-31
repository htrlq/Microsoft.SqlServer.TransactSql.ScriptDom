using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200008B RID: 139
	public enum DatabaseAuditActionKind
	{
		// Token: 0x04000828 RID: 2088
		Select,
		// Token: 0x04000829 RID: 2089
		Update,
		// Token: 0x0400082A RID: 2090
		Insert,
		// Token: 0x0400082B RID: 2091
		Delete,
		// Token: 0x0400082C RID: 2092
		Execute,
		// Token: 0x0400082D RID: 2093
		Receive,
		// Token: 0x0400082E RID: 2094
		References
	}
}
