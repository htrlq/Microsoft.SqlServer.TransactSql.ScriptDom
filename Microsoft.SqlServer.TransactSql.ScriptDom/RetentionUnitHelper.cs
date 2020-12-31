using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000131 RID: 305
	[Serializable]
	internal class RetentionUnitHelper : OptionsHelper<TimeUnit>
	{
		// Token: 0x060002E4 RID: 740 RVA: 0x0000957F File Offset: 0x0000777F
		private RetentionUnitHelper()
		{
			base.AddOptionMapping(TimeUnit.Days, "DAYS");
			base.AddOptionMapping(TimeUnit.Hours, "HOURS");
			base.AddOptionMapping(TimeUnit.Minutes, "MINUTES");
		}

		// Token: 0x04000D08 RID: 3336
		internal static readonly RetentionUnitHelper Instance = new RetentionUnitHelper();
	}
}
