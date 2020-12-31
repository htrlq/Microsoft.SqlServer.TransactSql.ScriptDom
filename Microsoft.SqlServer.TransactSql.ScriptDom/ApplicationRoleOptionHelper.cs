using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000050 RID: 80
	internal class ApplicationRoleOptionHelper : OptionsHelper<ApplicationRoleOptionKind>
	{
		// Token: 0x060001C1 RID: 449 RVA: 0x00005F67 File Offset: 0x00004167
		private ApplicationRoleOptionHelper()
		{
			base.AddOptionMapping(ApplicationRoleOptionKind.DefaultSchema, "DEFAULT_SCHEMA");
			base.AddOptionMapping(ApplicationRoleOptionKind.Password, "PASSWORD");
			base.AddOptionMapping(ApplicationRoleOptionKind.Name, "NAME");
			base.AddOptionMapping(ApplicationRoleOptionKind.Login, "LOGIN");
		}

		// Token: 0x04000149 RID: 329
		internal static readonly ApplicationRoleOptionHelper Instance = new ApplicationRoleOptionHelper();
	}
}
