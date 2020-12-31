using System;
using antlr;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000161 RID: 353
	[Serializable]
	internal class TriggerOptionHelper : OptionsHelper<TriggerOptionKind>
	{
		// Token: 0x06000306 RID: 774 RVA: 0x0000AF6B File Offset: 0x0000916B
		private TriggerOptionHelper()
		{
			base.AddOptionMapping(TriggerOptionKind.Encryption, "ENCRYPTION");
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0000AF80 File Offset: 0x00009180
		protected override TSqlParseErrorException GetMatchingException(IToken token)
		{
			return new TSqlParseErrorException(TSql80ParserBaseInternal.CreateParseError("SQL46007", token, TSqlParserResource.SQL46007Message, new string[]
			{
				token.getText()
			}));
		}

		// Token: 0x04000E3F RID: 3647
		internal static readonly TriggerOptionHelper Instance = new TriggerOptionHelper();
	}
}
