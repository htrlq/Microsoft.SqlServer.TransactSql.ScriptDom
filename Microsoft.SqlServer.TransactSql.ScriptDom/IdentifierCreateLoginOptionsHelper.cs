using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000D2 RID: 210
	internal class IdentifierCreateLoginOptionsHelper : OptionsHelper<PrincipalOptionKind>
	{
		// Token: 0x0600024D RID: 589 RVA: 0x000083FD File Offset: 0x000065FD
		private IdentifierCreateLoginOptionsHelper()
		{
			base.AddOptionMapping(PrincipalOptionKind.DefaultDatabase, "DEFAULT_DATABASE");
			base.AddOptionMapping(PrincipalOptionKind.DefaultLanguage, "DEFAULT_LANGUAGE");
			base.AddOptionMapping(PrincipalOptionKind.Credential, "CREDENTIAL");
		}

		// Token: 0x04000B66 RID: 2918
		internal static readonly IdentifierCreateLoginOptionsHelper Instance = new IdentifierCreateLoginOptionsHelper();
	}
}
