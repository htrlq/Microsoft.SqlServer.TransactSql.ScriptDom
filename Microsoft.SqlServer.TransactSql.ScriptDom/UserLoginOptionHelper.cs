using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000182 RID: 386
	[Serializable]
	internal class UserLoginOptionHelper : OptionsHelper<UserLoginOptionType>
	{
		// Token: 0x06000B40 RID: 2880 RVA: 0x0001F944 File Offset: 0x0001DB44
		private UserLoginOptionHelper()
		{
			base.AddOptionMapping(UserLoginOptionType.Certificate, "CERTIFICATE");
			base.AddOptionMapping(UserLoginOptionType.Login, "LOGIN");
		}

		// Token: 0x04000F8E RID: 3982
		internal static readonly UserLoginOptionHelper Instance = new UserLoginOptionHelper();
	}
}
