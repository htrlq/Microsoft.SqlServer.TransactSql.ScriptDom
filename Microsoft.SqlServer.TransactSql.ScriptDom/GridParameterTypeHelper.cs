using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000CD RID: 205
	internal class GridParameterTypeHelper : OptionsHelper<GridParameterType>
	{
		// Token: 0x0600023C RID: 572 RVA: 0x0000818B File Offset: 0x0000638B
		private GridParameterTypeHelper()
		{
			base.AddOptionMapping(GridParameterType.Level1, "LEVEL_1");
			base.AddOptionMapping(GridParameterType.Level2, "LEVEL_2");
			base.AddOptionMapping(GridParameterType.Level3, "LEVEL_3");
			base.AddOptionMapping(GridParameterType.Level4, "LEVEL_4");
		}

		// Token: 0x04000B52 RID: 2898
		internal static readonly GridParameterTypeHelper Instance = new GridParameterTypeHelper();
	}
}
