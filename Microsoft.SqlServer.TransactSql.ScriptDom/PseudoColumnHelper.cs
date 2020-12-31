using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200011D RID: 285
	internal class PseudoColumnHelper : OptionsHelper<ColumnType>
	{
		// Token: 0x060002D4 RID: 724 RVA: 0x00009147 File Offset: 0x00007347
		private PseudoColumnHelper()
		{
			base.AddOptionMapping(ColumnType.PseudoColumnIdentity, "$IDENTITY", SqlVersionFlags.TSqlAll);
			base.AddOptionMapping(ColumnType.PseudoColumnRowGuid, "$ROWGUID", SqlVersionFlags.TSqlAll);
			base.AddOptionMapping(ColumnType.PseudoColumnAction, "$ACTION", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(ColumnType.PseudoColumnCuid, "$CUID", SqlVersionFlags.TSql100AndAbove);
		}

		// Token: 0x04000C93 RID: 3219
		internal static readonly PseudoColumnHelper Instance = new PseudoColumnHelper();
	}
}
