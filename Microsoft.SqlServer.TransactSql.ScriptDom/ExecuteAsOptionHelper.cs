using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000BC RID: 188
	internal class ExecuteAsOptionHelper : OptionsHelper<ExecuteAsOption>
	{
		// Token: 0x06000234 RID: 564 RVA: 0x00008036 File Offset: 0x00006236
		private ExecuteAsOptionHelper()
		{
			base.AddOptionMapping(ExecuteAsOption.Caller, "CALLER");
			base.AddOptionMapping(ExecuteAsOption.Self, "SELF");
			base.AddOptionMapping(ExecuteAsOption.Owner, "OWNER");
		}

		// Token: 0x04000B0F RID: 2831
		internal static readonly ExecuteAsOptionHelper Instance = new ExecuteAsOptionHelper();
	}
}
