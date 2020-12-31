using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200010F RID: 271
	[Serializable]
	internal class PermissionSetOptionHelper : OptionsHelper<PermissionSetOption>
	{
		// Token: 0x060002C1 RID: 705 RVA: 0x00008DCD File Offset: 0x00006FCD
		private PermissionSetOptionHelper()
		{
			base.AddOptionMapping(PermissionSetOption.Safe, "SAFE");
			base.AddOptionMapping(PermissionSetOption.ExternalAccess, "EXTERNAL_ACCESS");
			base.AddOptionMapping(PermissionSetOption.Unsafe, "UNSAFE");
		}

		// Token: 0x04000C66 RID: 3174
		internal static readonly PermissionSetOptionHelper Instance = new PermissionSetOptionHelper();
	}
}
