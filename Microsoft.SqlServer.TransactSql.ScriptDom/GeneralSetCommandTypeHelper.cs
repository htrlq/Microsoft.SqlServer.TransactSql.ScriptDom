using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000CB RID: 203
	internal class GeneralSetCommandTypeHelper : OptionsHelper<GeneralSetCommandType>
	{
		// Token: 0x0600023A RID: 570 RVA: 0x00008118 File Offset: 0x00006318
		private GeneralSetCommandTypeHelper()
		{
			base.AddOptionMapping(GeneralSetCommandType.Language, "LANGUAGE");
			base.AddOptionMapping(GeneralSetCommandType.DateFormat, "DATEFORMAT");
			base.AddOptionMapping(GeneralSetCommandType.DateFirst, "DATEFIRST");
			base.AddOptionMapping(GeneralSetCommandType.DeadlockPriority, "DEADLOCK_PRIORITY");
			base.AddOptionMapping(GeneralSetCommandType.LockTimeout, "LOCK_TIMEOUT");
			base.AddOptionMapping(GeneralSetCommandType.QueryGovernorCostLimit, "QUERY_GOVERNOR_COST_LIMIT");
			base.AddOptionMapping(GeneralSetCommandType.ContextInfo, "CONTEXT_INFO");
		}

		// Token: 0x04000B4B RID: 2891
		internal static readonly GeneralSetCommandTypeHelper Instance = new GeneralSetCommandTypeHelper();
	}
}
