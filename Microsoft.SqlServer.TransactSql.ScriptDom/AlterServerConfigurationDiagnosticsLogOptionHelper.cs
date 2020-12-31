using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000048 RID: 72
	internal class AlterServerConfigurationDiagnosticsLogOptionHelper : OptionsHelper<AlterServerConfigurationDiagnosticsLogOptionKind>
	{
		// Token: 0x060001BB RID: 443 RVA: 0x00005EA8 File Offset: 0x000040A8
		private AlterServerConfigurationDiagnosticsLogOptionHelper()
		{
			base.AddOptionMapping(AlterServerConfigurationDiagnosticsLogOptionKind.Path, "PATH");
			base.AddOptionMapping(AlterServerConfigurationDiagnosticsLogOptionKind.MaxSize, "MAX_SIZE");
			base.AddOptionMapping(AlterServerConfigurationDiagnosticsLogOptionKind.MaxFiles, "MAX_FILES");
		}

		// Token: 0x04000123 RID: 291
		internal static readonly AlterServerConfigurationDiagnosticsLogOptionHelper Instance = new AlterServerConfigurationDiagnosticsLogOptionHelper();
	}
}
