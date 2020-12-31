using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000040 RID: 64
	[Serializable]
	public enum AlterFederationKind
	{
		// Token: 0x040000FF RID: 255
		Unknown,
		// Token: 0x04000100 RID: 256
		Split,
		// Token: 0x04000101 RID: 257
		DropLow,
		// Token: 0x04000102 RID: 258
		DropHigh
	}
}
