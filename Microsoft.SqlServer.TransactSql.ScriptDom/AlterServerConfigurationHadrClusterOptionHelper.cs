using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200004C RID: 76
	internal class AlterServerConfigurationHadrClusterOptionHelper : OptionsHelper<AlterServerConfigurationHadrClusterOptionKind>
	{
		// Token: 0x060001BF RID: 447 RVA: 0x00005F47 File Offset: 0x00004147
		private AlterServerConfigurationHadrClusterOptionHelper()
		{
			base.AddOptionMapping(AlterServerConfigurationHadrClusterOptionKind.Context, "CONTEXT");
		}

		// Token: 0x04000133 RID: 307
		internal static readonly AlterServerConfigurationHadrClusterOptionHelper Instance = new AlterServerConfigurationHadrClusterOptionHelper();
	}
}
