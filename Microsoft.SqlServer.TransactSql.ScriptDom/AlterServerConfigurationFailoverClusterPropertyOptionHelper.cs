using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200004A RID: 74
	internal class AlterServerConfigurationFailoverClusterPropertyOptionHelper : OptionsHelper<AlterServerConfigurationFailoverClusterPropertyOptionKind>
	{
		// Token: 0x060001BD RID: 445 RVA: 0x00005EE0 File Offset: 0x000040E0
		private AlterServerConfigurationFailoverClusterPropertyOptionHelper()
		{
			base.AddOptionMapping(AlterServerConfigurationFailoverClusterPropertyOptionKind.VerboseLogging, "VerboseLogging");
			base.AddOptionMapping(AlterServerConfigurationFailoverClusterPropertyOptionKind.SqlDumperDumpFlags, "SqlDumperDumpFlags");
			base.AddOptionMapping(AlterServerConfigurationFailoverClusterPropertyOptionKind.SqlDumperDumpPath, "SqlDumperDumpPath");
			base.AddOptionMapping(AlterServerConfigurationFailoverClusterPropertyOptionKind.SqlDumperDumpTimeout, "SqlDumperDumpTimeout");
			base.AddOptionMapping(AlterServerConfigurationFailoverClusterPropertyOptionKind.FailureConditionLevel, "FailureConditionLevel");
			base.AddOptionMapping(AlterServerConfigurationFailoverClusterPropertyOptionKind.HealthCheckTimeout, "HealthCheckTimeout");
		}

		// Token: 0x0400012A RID: 298
		internal static readonly AlterServerConfigurationFailoverClusterPropertyOptionHelper Instance = new AlterServerConfigurationFailoverClusterPropertyOptionHelper();
	}
}
