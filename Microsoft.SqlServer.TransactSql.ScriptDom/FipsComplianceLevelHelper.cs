using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000C5 RID: 197
	internal class FipsComplianceLevelHelper : OptionsHelper<FipsComplianceLevel>
	{
		// Token: 0x06000238 RID: 568 RVA: 0x000080D7 File Offset: 0x000062D7
		private FipsComplianceLevelHelper()
		{
			base.AddOptionMapping(FipsComplianceLevel.Off, TSqlTokenType.Off);
			base.AddOptionMapping(FipsComplianceLevel.Entry, "'ENTRY'");
			base.AddOptionMapping(FipsComplianceLevel.Intermediate, "'INTERMEDIATE'");
			base.AddOptionMapping(FipsComplianceLevel.Full, "'FULL'");
		}

		// Token: 0x04000B31 RID: 2865
		internal static readonly FipsComplianceLevelHelper Instance = new FipsComplianceLevelHelper();
	}
}
