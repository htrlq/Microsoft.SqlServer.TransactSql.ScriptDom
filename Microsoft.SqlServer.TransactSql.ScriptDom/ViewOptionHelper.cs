using System;
using antlr;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000186 RID: 390
	internal class ViewOptionHelper : OptionsHelper<ViewOptionKind>
	{
		// Token: 0x06000B44 RID: 2884 RVA: 0x0001F9B5 File Offset: 0x0001DBB5
		private ViewOptionHelper()
		{
			base.AddOptionMapping(ViewOptionKind.Encryption, "ENCRYPTION");
			base.AddOptionMapping(ViewOptionKind.SchemaBinding, "SCHEMABINDING");
			base.AddOptionMapping(ViewOptionKind.ViewMetadata, "VIEW_METADATA");
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x0001F9E4 File Offset: 0x0001DBE4
		protected override TSqlParseErrorException GetMatchingException(IToken token)
		{
			return new TSqlParseErrorException(TSql80ParserBaseInternal.CreateParseError("SQL46025", token, TSqlParserResource.SQL46025Message, new string[]
			{
				token.getText()
			}));
		}

		// Token: 0x04000F99 RID: 3993
		internal static readonly ViewOptionHelper Instance = new ViewOptionHelper();
	}
}
