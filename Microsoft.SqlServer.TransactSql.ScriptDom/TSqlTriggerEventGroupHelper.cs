using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200017D RID: 381
	public static class TSqlTriggerEventGroupHelper
	{
		// Token: 0x06000B3C RID: 2876 RVA: 0x0001F8FA File Offset: 0x0001DAFA
		public static bool TryParseOption(string input, SqlVersion version, out EventNotificationEventGroup returnValue)
		{
			return TSqlTriggerEventGroupHelper.HelperInstance.TryParseOption(input, TSqlTriggerEventGroupHelper.HelperInstance.MapSqlVersionToSqlVersionFlags(version), out returnValue);
		}

		// Token: 0x04000F80 RID: 3968
		private static readonly TriggerEventGroupHelper HelperInstance = TriggerEventGroupHelper.Instance;
	}
}
