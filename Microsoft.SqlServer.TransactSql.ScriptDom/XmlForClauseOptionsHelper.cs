using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000192 RID: 402
	internal class XmlForClauseOptionsHelper : OptionsHelper<XmlForClauseOptions>
	{
		// Token: 0x06000B4F RID: 2895 RVA: 0x0001FB2C File Offset: 0x0001DD2C
		private XmlForClauseOptionsHelper()
		{
			base.AddOptionMapping(XmlForClauseOptions.Elements, "ELEMENTS");
			base.AddOptionMapping(XmlForClauseOptions.Root, "ROOT");
			base.AddOptionMapping(XmlForClauseOptions.XmlSchema, "XMLSCHEMA");
			base.AddOptionMapping(XmlForClauseOptions.XmlData, "XMLDATA");
			base.AddOptionMapping(XmlForClauseOptions.Type, "TYPE");
		}

		// Token: 0x04000FCA RID: 4042
		internal static readonly XmlForClauseOptionsHelper Instance = new XmlForClauseOptionsHelper();
	}
}
