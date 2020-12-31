using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000176 RID: 374
	public static class TSqlAuditEventGroupHelper
	{
		// Token: 0x06000B04 RID: 2820 RVA: 0x0001F4DD File Offset: 0x0001D6DD
		public static bool TryParseOption(string input, SqlVersion version, out EventNotificationEventGroup returnValue)
		{
			return TSqlAuditEventGroupHelper.HelperInstance.TryParseOption(input, TSqlAuditEventGroupHelper.HelperInstance.MapSqlVersionToSqlVersionFlags(version), out returnValue);
		}

		// Token: 0x04000F6E RID: 3950
		private static readonly AuditEventGroupHelper HelperInstance = AuditEventGroupHelper.Instance;
	}
}
