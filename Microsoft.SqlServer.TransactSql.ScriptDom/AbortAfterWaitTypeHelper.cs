using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000036 RID: 54
	internal class AbortAfterWaitTypeHelper : OptionsHelper<AbortAfterWaitType>
	{
		// Token: 0x060001B1 RID: 433 RVA: 0x00005D62 File Offset: 0x00003F62
		private AbortAfterWaitTypeHelper()
		{
			base.AddOptionMapping(AbortAfterWaitType.None, "NONE");
			base.AddOptionMapping(AbortAfterWaitType.Blockers, "BLOCKERS");
			base.AddOptionMapping(AbortAfterWaitType.Self, "SELF");
		}

		// Token: 0x040000CF RID: 207
		public static readonly AbortAfterWaitTypeHelper Instance = new AbortAfterWaitTypeHelper();
	}
}
