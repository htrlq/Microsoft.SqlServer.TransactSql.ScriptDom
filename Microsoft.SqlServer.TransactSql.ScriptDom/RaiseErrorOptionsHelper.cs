using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000122 RID: 290
	[Serializable]
	internal class RaiseErrorOptionsHelper : OptionsHelper<RaiseErrorOptions>
	{
		// Token: 0x060002D6 RID: 726 RVA: 0x00009193 File Offset: 0x00007393
		private RaiseErrorOptionsHelper()
		{
			base.AddOptionMapping(RaiseErrorOptions.Log, "LOG");
			base.AddOptionMapping(RaiseErrorOptions.NoWait, "NOWAIT");
			base.AddOptionMapping(RaiseErrorOptions.SetError, "SETERROR");
		}

		// Token: 0x04000CAB RID: 3243
		internal static readonly RaiseErrorOptionsHelper Instance = new RaiseErrorOptionsHelper();
	}
}
