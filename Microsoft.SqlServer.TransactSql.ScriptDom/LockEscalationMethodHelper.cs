using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000F2 RID: 242
	internal class LockEscalationMethodHelper : OptionsHelper<LockEscalationMethod>
	{
		// Token: 0x060002A8 RID: 680 RVA: 0x00008977 File Offset: 0x00006B77
		private LockEscalationMethodHelper()
		{
			base.AddOptionMapping(LockEscalationMethod.Auto, "AUTO");
			base.AddOptionMapping(LockEscalationMethod.Disable, "DISABLE");
			base.AddOptionMapping(LockEscalationMethod.Table, TSqlTokenType.Table);
		}

		// Token: 0x04000BC7 RID: 3015
		public static LockEscalationMethodHelper Instance = new LockEscalationMethodHelper();
	}
}
