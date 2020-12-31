using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200018F RID: 399
	[Serializable]
	internal class XmlDataTypeOptionHelper : OptionsHelper<XmlDataTypeOption>
	{
		// Token: 0x06000B4B RID: 2891 RVA: 0x0001FAB9 File Offset: 0x0001DCB9
		private XmlDataTypeOptionHelper()
		{
			base.AddOptionMapping(XmlDataTypeOption.Content, "CONTENT");
			base.AddOptionMapping(XmlDataTypeOption.Document, "DOCUMENT");
		}

		// Token: 0x04000FB9 RID: 4025
		internal static readonly XmlDataTypeOptionHelper Instance = new XmlDataTypeOptionHelper();
	}
}
