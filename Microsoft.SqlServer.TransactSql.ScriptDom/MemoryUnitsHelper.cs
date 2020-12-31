using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000F6 RID: 246
	internal class MemoryUnitsHelper : OptionsHelper<MemoryUnit>
	{
		// Token: 0x060002AC RID: 684 RVA: 0x000089D0 File Offset: 0x00006BD0
		private MemoryUnitsHelper()
		{
			base.AddOptionMapping(MemoryUnit.KB, "KB");
			base.AddOptionMapping(MemoryUnit.MB, "MB");
			base.AddOptionMapping(MemoryUnit.GB, "GB");
			base.AddOptionMapping(MemoryUnit.TB, "TB");
			base.AddOptionMapping(MemoryUnit.Percent, TSqlTokenType.PercentSign);
		}

		// Token: 0x04000BD6 RID: 3030
		internal static readonly MemoryUnitsHelper Instance = new MemoryUnitsHelper();
	}
}
