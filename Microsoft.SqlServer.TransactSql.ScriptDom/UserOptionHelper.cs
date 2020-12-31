using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000184 RID: 388
	[Serializable]
	internal class UserOptionHelper : OptionsHelper<PrincipalOptionKind>
	{
		// Token: 0x06000B42 RID: 2882 RVA: 0x0001F970 File Offset: 0x0001DB70
		private UserOptionHelper()
		{
			base.AddOptionMapping(PrincipalOptionKind.DefaultSchema, "DEFAULT_SCHEMA");
			base.AddOptionMapping(PrincipalOptionKind.DefaultLanguage, "DEFAULT_LANGUAGE");
			base.AddOptionMapping(PrincipalOptionKind.Name, "NAME");
			base.AddOptionMapping(PrincipalOptionKind.Login, "LOGIN");
		}

		// Token: 0x04000F94 RID: 3988
		internal static readonly UserOptionHelper Instance = new UserOptionHelper();
	}
}
