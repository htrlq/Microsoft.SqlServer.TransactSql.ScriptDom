using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000115 RID: 277
	[Serializable]
	internal class PortTypesHelper : OptionsHelper<PortTypes>
	{
		// Token: 0x060002CD RID: 717 RVA: 0x00008ED5 File Offset: 0x000070D5
		private PortTypesHelper()
		{
			base.AddOptionMapping(PortTypes.Clear, "CLEAR");
			base.AddOptionMapping(PortTypes.Ssl, "SSL");
		}

		// Token: 0x04000C6E RID: 3182
		internal static readonly PortTypesHelper Instance = new PortTypesHelper();
	}
}
