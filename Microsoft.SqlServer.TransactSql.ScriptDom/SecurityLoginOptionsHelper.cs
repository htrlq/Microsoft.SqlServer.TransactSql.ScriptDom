using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000136 RID: 310
	internal class SecurityLoginOptionsHelper : OptionsHelper<PrincipalOptionKind>
	{
		// Token: 0x060002EA RID: 746 RVA: 0x0000964B File Offset: 0x0000784B
		private SecurityLoginOptionsHelper()
		{
			base.AddOptionMapping(PrincipalOptionKind.CheckExpiration, "CHECK_EXPIRATION");
			base.AddOptionMapping(PrincipalOptionKind.CheckPolicy, "CHECK_POLICY");
		}

		// Token: 0x04000D16 RID: 3350
		internal static readonly SecurityLoginOptionsHelper Instance = new SecurityLoginOptionsHelper();
	}
}
