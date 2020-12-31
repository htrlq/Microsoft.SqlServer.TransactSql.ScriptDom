using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000143 RID: 323
	[Serializable]
	internal class SetStatisticsOptionsHelper : OptionsHelper<SetStatisticsOptions>
	{
		// Token: 0x060002F2 RID: 754 RVA: 0x00009905 File Offset: 0x00007B05
		private SetStatisticsOptionsHelper()
		{
			base.AddOptionMapping(SetStatisticsOptions.IO, "IO", SqlVersionFlags.TSqlAll);
			base.AddOptionMapping(SetStatisticsOptions.Profile, "PROFILE", SqlVersionFlags.TSqlAll);
			base.AddOptionMapping(SetStatisticsOptions.Time, "TIME", SqlVersionFlags.TSqlAll);
			base.AddOptionMapping(SetStatisticsOptions.Xml, "XML", SqlVersionFlags.TSql90AndAbove);
		}

		// Token: 0x04000D80 RID: 3456
		internal static readonly SetStatisticsOptionsHelper Instance = new SetStatisticsOptionsHelper();
	}
}
