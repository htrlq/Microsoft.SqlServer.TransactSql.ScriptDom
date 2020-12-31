using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000190 RID: 400
	internal class XmlForClauseModeHelper : OptionsHelper<XmlForClauseOptions>
	{
		// Token: 0x06000B4D RID: 2893 RVA: 0x0001FAE5 File Offset: 0x0001DCE5
		private XmlForClauseModeHelper()
		{
			base.AddOptionMapping(XmlForClauseOptions.Auto, "AUTO");
			base.AddOptionMapping(XmlForClauseOptions.Raw, "RAW");
			base.AddOptionMapping(XmlForClauseOptions.Explicit, "EXPLICIT");
			base.AddOptionMapping(XmlForClauseOptions.Path, "PATH");
		}

		// Token: 0x04000FBA RID: 4026
		internal static readonly XmlForClauseModeHelper Instance = new XmlForClauseModeHelper();
	}
}
