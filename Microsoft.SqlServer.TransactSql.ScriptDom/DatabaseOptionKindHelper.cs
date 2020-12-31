using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000090 RID: 144
	internal class DatabaseOptionKindHelper : OptionsHelper<DatabaseOptionKind>
	{
		// Token: 0x06000210 RID: 528 RVA: 0x000074A8 File Offset: 0x000056A8
		private DatabaseOptionKindHelper()
		{
			base.AddOptionMapping(DatabaseOptionKind.CompatibilityLevel, "COMPATIBILITY_LEVEL", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(DatabaseOptionKind.DefaultFullTextLanguage, "DEFAULT_FULLTEXT_LANGUAGE", SqlVersionFlags.TSql110AndAbove);
			base.AddOptionMapping(DatabaseOptionKind.DefaultLanguage, "DEFAULT_LANGUAGE", SqlVersionFlags.TSql110AndAbove);
			base.AddOptionMapping(DatabaseOptionKind.TwoDigitYearCutoff, "TWO_DIGIT_YEAR_CUTOFF", SqlVersionFlags.TSql110AndAbove);
			base.AddOptionMapping(DatabaseOptionKind.Edition, "EDITION", SqlVersionFlags.TSql110AndAbove);
		}

		// Token: 0x04000877 RID: 2167
		internal static readonly DatabaseOptionKindHelper Instance = new DatabaseOptionKindHelper();
	}
}
