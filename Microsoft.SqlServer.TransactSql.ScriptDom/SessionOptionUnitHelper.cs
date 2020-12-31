using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200013F RID: 319
	internal class SessionOptionUnitHelper : OptionsHelper<MemoryUnit>
	{
		// Token: 0x060002F0 RID: 752 RVA: 0x000098D9 File Offset: 0x00007AD9
		private SessionOptionUnitHelper()
		{
			base.AddOptionMapping(MemoryUnit.KB, "KB");
			base.AddOptionMapping(MemoryUnit.MB, "MB");
		}

		// Token: 0x04000D53 RID: 3411
		internal static readonly SessionOptionUnitHelper Instance = new SessionOptionUnitHelper();
	}
}
