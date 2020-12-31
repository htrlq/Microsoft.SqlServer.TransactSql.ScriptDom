using System;
using antlr;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200011A RID: 282
	[Serializable]
	internal class ProcedureOptionHelper : OptionsHelper<ProcedureOptionKind>
	{
		// Token: 0x060002D1 RID: 721 RVA: 0x000090CB File Offset: 0x000072CB
		private ProcedureOptionHelper()
		{
			base.AddOptionMapping(ProcedureOptionKind.Encryption, "ENCRYPTION");
			base.AddOptionMapping(ProcedureOptionKind.Recompile, "RECOMPILE");
			base.AddOptionMapping(ProcedureOptionKind.NativeCompilation, "NATIVE_COMPILATION", SqlVersionFlags.TSql120);
			base.AddOptionMapping(ProcedureOptionKind.SchemaBinding, "SCHEMABINDING", SqlVersionFlags.TSql120);
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00009108 File Offset: 0x00007308
		protected override TSqlParseErrorException GetMatchingException(IToken token)
		{
			return new TSqlParseErrorException(TSql80ParserBaseInternal.CreateParseError("SQL46006", token, TSqlParserResource.SQL46006Message, new string[]
			{
				token.getText()
			}));
		}

		// Token: 0x04000C88 RID: 3208
		internal static readonly ProcedureOptionHelper Instance = new ProcedureOptionHelper();
	}
}
