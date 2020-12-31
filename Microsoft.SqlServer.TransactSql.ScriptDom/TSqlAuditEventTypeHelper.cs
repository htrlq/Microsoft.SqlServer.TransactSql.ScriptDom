using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000177 RID: 375
	public static class TSqlAuditEventTypeHelper
	{
		// Token: 0x06000B06 RID: 2822 RVA: 0x0001F502 File Offset: 0x0001D702
		public static bool TryParseOption(string input, SqlVersion version, out EventNotificationEventType returnValue)
		{
			return TSqlAuditEventTypeHelper.HelperInstance.TryParseOption(input, TSqlAuditEventTypeHelper.HelperInstance.MapSqlVersionToSqlVersionFlags(version), out returnValue);
		}

		// Token: 0x04000F6F RID: 3951
		private static readonly AuditEventTypeHelper HelperInstance = AuditEventTypeHelper.Instance;
	}
}
