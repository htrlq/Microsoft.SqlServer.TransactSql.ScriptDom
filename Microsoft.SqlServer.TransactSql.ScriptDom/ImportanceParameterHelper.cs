using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000DA RID: 218
	[Serializable]
	internal class ImportanceParameterHelper : OptionsHelper<ImportanceParameterType>
	{
		// Token: 0x0600026E RID: 622 RVA: 0x000085EF File Offset: 0x000067EF
		private ImportanceParameterHelper()
		{
			base.AddOptionMapping(ImportanceParameterType.Low, "LOW");
			base.AddOptionMapping(ImportanceParameterType.High, "HIGH");
			base.AddOptionMapping(ImportanceParameterType.Medium, "MEDIUM");
		}

		// Token: 0x04000B6C RID: 2924
		internal static readonly ImportanceParameterHelper Instance = new ImportanceParameterHelper();
	}
}
