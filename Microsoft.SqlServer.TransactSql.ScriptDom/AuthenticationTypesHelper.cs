using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000061 RID: 97
	internal class AuthenticationTypesHelper : OptionsHelper<AuthenticationTypes>
	{
		// Token: 0x060001CB RID: 459 RVA: 0x00006908 File Offset: 0x00004B08
		private AuthenticationTypesHelper()
		{
			base.AddOptionMapping(AuthenticationTypes.Basic, "BASIC");
			base.AddOptionMapping(AuthenticationTypes.Digest, "DIGEST");
			base.AddOptionMapping(AuthenticationTypes.Integrated, "INTEGRATED");
			base.AddOptionMapping(AuthenticationTypes.Kerberos, "KERBEROS");
			base.AddOptionMapping(AuthenticationTypes.Ntlm, "NTLM");
		}

		// Token: 0x040001B7 RID: 439
		internal static readonly AuthenticationTypesHelper Instance = new AuthenticationTypesHelper();
	}
}
