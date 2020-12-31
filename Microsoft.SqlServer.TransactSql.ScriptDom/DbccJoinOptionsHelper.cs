using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000095 RID: 149
	internal class DbccJoinOptionsHelper : OptionsHelper<DbccOptionKind>
	{
		// Token: 0x06000216 RID: 534 RVA: 0x00007B03 File Offset: 0x00005D03
		private DbccJoinOptionsHelper()
		{
			base.AddOptionMapping(DbccOptionKind.StatHeader, "STAT_HEADER");
			base.AddOptionMapping(DbccOptionKind.DensityVector, "DENSITY_VECTOR");
		}

		// Token: 0x040008EF RID: 2287
		internal static readonly DbccJoinOptionsHelper Instance = new DbccJoinOptionsHelper();
	}
}
