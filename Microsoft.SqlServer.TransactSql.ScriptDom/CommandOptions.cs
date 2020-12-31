using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000081 RID: 129
	[Flags]
	public enum CommandOptions
	{
		// Token: 0x040007F2 RID: 2034
		None = 0,
		// Token: 0x040007F3 RID: 2035
		CreateDatabase = 1,
		// Token: 0x040007F4 RID: 2036
		CreateDefault = 2,
		// Token: 0x040007F5 RID: 2037
		CreateProcedure = 4,
		// Token: 0x040007F6 RID: 2038
		CreateFunction = 8,
		// Token: 0x040007F7 RID: 2039
		CreateRule = 16,
		// Token: 0x040007F8 RID: 2040
		CreateTable = 32,
		// Token: 0x040007F9 RID: 2041
		CreateView = 64,
		// Token: 0x040007FA RID: 2042
		BackupDatabase = 128,
		// Token: 0x040007FB RID: 2043
		BackupLog = 256
	}
}
