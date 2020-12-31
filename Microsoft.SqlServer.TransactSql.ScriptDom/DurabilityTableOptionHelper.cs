using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000A3 RID: 163
	internal class DurabilityTableOptionHelper : OptionsHelper<DurabilityTableOptionKind>
	{
		// Token: 0x06000220 RID: 544 RVA: 0x00007D17 File Offset: 0x00005F17
		private DurabilityTableOptionHelper()
		{
			base.AddOptionMapping(DurabilityTableOptionKind.SchemaOnly, "SCHEMA_ONLY");
			base.AddOptionMapping(DurabilityTableOptionKind.SchemaAndData, "SCHEMA_AND_DATA");
		}

		// Token: 0x0400092E RID: 2350
		internal static readonly DurabilityTableOptionHelper Instance = new DurabilityTableOptionHelper();
	}
}
