using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200017E RID: 382
	public static class TSqlTriggerEventTypeHelper
	{
		// Token: 0x06000B3E RID: 2878 RVA: 0x0001F91F File Offset: 0x0001DB1F
		public static bool TryParseOption(string input, SqlVersion version, out EventNotificationEventType returnValue)
		{
			return TSqlTriggerEventTypeHelper.HelperInstance.TryParseOption(input, TSqlTriggerEventTypeHelper.HelperInstance.MapSqlVersionToSqlVersionFlags(version), out returnValue);
		}

		// Token: 0x04000F81 RID: 3969
		private static readonly TriggerEventTypeHelper HelperInstance = TriggerEventTypeHelper.Instance;
	}
}
