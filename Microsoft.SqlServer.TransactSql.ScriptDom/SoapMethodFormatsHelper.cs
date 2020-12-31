using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000149 RID: 329
	[Serializable]
	internal class SoapMethodFormatsHelper : OptionsHelper<SoapMethodFormat>
	{
		// Token: 0x060002F6 RID: 758 RVA: 0x00009A1E File Offset: 0x00007C1E
		private SoapMethodFormatsHelper()
		{
			base.AddOptionMapping(SoapMethodFormat.AllResults, "ALL_RESULTS");
			base.AddOptionMapping(SoapMethodFormat.RowsetsOnly, "ROWSETS_ONLY");
			base.AddOptionMapping(SoapMethodFormat.None, "NONE");
		}

		// Token: 0x04000D9E RID: 3486
		internal static readonly SoapMethodFormatsHelper Instance = new SoapMethodFormatsHelper();
	}
}
