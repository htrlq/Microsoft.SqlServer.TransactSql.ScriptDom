using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000135 RID: 309
	[Serializable]
	internal class SecondaryXmlIndexTypeHelper : OptionsHelper<SecondaryXmlIndexType>
	{
		// Token: 0x060002E8 RID: 744 RVA: 0x00009613 File Offset: 0x00007813
		private SecondaryXmlIndexTypeHelper()
		{
			base.AddOptionMapping(SecondaryXmlIndexType.Path, "PATH");
			base.AddOptionMapping(SecondaryXmlIndexType.Property, "PROPERTY");
			base.AddOptionMapping(SecondaryXmlIndexType.Value, "VALUE");
		}

		// Token: 0x04000D15 RID: 3349
		internal static readonly SecondaryXmlIndexTypeHelper Instance = new SecondaryXmlIndexTypeHelper();
	}
}
