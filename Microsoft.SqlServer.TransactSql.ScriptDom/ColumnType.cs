using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000080 RID: 128
	public enum ColumnType
	{
		// Token: 0x040007E9 RID: 2025
		Regular,
		// Token: 0x040007EA RID: 2026
		IdentityCol,
		// Token: 0x040007EB RID: 2027
		RowGuidCol,
		// Token: 0x040007EC RID: 2028
		Wildcard,
		// Token: 0x040007ED RID: 2029
		PseudoColumnIdentity,
		// Token: 0x040007EE RID: 2030
		PseudoColumnRowGuid,
		// Token: 0x040007EF RID: 2031
		PseudoColumnAction,
		// Token: 0x040007F0 RID: 2032
		PseudoColumnCuid
	}
}
