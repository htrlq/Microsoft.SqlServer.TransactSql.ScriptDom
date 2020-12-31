using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000146 RID: 326
	[Serializable]
	internal class SimpleDbOptionsHelper : OptionsHelper<DatabaseOptionKind>
	{
		// Token: 0x060002F4 RID: 756 RVA: 0x00009954 File Offset: 0x00007B54
		private SimpleDbOptionsHelper()
		{
			base.AddOptionMapping(DatabaseOptionKind.Online, "ONLINE", SqlVersionFlags.TSqlAll);
			base.AddOptionMapping(DatabaseOptionKind.Offline, "OFFLINE", SqlVersionFlags.TSqlAll);
			base.AddOptionMapping(DatabaseOptionKind.SingleUser, "SINGLE_USER", SqlVersionFlags.TSqlAll);
			base.AddOptionMapping(DatabaseOptionKind.RestrictedUser, "RESTRICTED_USER", SqlVersionFlags.TSqlAll);
			base.AddOptionMapping(DatabaseOptionKind.MultiUser, "MULTI_USER", SqlVersionFlags.TSqlAll);
			base.AddOptionMapping(DatabaseOptionKind.ReadOnly, "READ_ONLY", SqlVersionFlags.TSqlAll);
			base.AddOptionMapping(DatabaseOptionKind.ReadWrite, "READ_WRITE", SqlVersionFlags.TSqlAll);
			base.AddOptionMapping(DatabaseOptionKind.Emergency, "EMERGENCY", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(DatabaseOptionKind.EnableBroker, "ENABLE_BROKER", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(DatabaseOptionKind.DisableBroker, "DISABLE_BROKER", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(DatabaseOptionKind.NewBroker, "NEW_BROKER", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(DatabaseOptionKind.ErrorBrokerConversations, "ERROR_BROKER_CONVERSATIONS", SqlVersionFlags.TSql90AndAbove);
		}

		// Token: 0x04000D93 RID: 3475
		internal static readonly SimpleDbOptionsHelper Instance = new SimpleDbOptionsHelper();
	}
}
