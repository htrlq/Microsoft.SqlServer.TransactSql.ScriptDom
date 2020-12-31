using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000043 RID: 67
	internal class AlterIndexTypeHelper : OptionsHelper<AlterIndexType>
	{
		// Token: 0x060001B7 RID: 439 RVA: 0x00005E38 File Offset: 0x00004038
		private AlterIndexTypeHelper()
		{
			base.AddOptionMapping(AlterIndexType.Disable, "DISABLE");
			base.AddOptionMapping(AlterIndexType.Rebuild, "REBUILD");
			base.AddOptionMapping(AlterIndexType.Reorganize, "REORGANIZE");
			base.AddOptionMapping(AlterIndexType.Set, TSqlTokenType.Set);
		}

		// Token: 0x0400010E RID: 270
		internal static readonly AlterIndexTypeHelper Instance = new AlterIndexTypeHelper();
	}
}
