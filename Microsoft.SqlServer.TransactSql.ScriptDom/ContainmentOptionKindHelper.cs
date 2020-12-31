using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000086 RID: 134
	internal class ContainmentOptionKindHelper : OptionsHelper<ContainmentOptionKind>
	{
		// Token: 0x06000208 RID: 520 RVA: 0x000071EF File Offset: 0x000053EF
		private ContainmentOptionKindHelper()
		{
			base.AddOptionMapping(ContainmentOptionKind.None, "NONE");
			base.AddOptionMapping(ContainmentOptionKind.Partial, "PARTIAL");
		}

		// Token: 0x04000811 RID: 2065
		internal static readonly ContainmentOptionKindHelper Instance = new ContainmentOptionKindHelper();
	}
}
