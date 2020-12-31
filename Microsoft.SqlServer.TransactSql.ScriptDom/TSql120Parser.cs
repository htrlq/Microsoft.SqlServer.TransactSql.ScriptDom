using System;
using System.Collections.Generic;
using System.IO;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200016F RID: 367
	[Serializable]
	public class TSql120Parser : TSqlParser
	{
		// Token: 0x06000A7C RID: 2684 RVA: 0x0001A106 File Offset: 0x00018306
		public TSql120Parser(bool initialQuotedIdentifiers) : base(initialQuotedIdentifiers)
		{
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x0001A10F File Offset: 0x0001830F
		internal override TSqlLexerBaseInternal GetNewInternalLexer()
		{
			return new TSql120LexerInternal();
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x0001A116 File Offset: 0x00018316
		private TSql120ParserInternal GetNewInternalParser()
		{
			return new TSql120ParserInternal(base.QuotedIdentifier);
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x0001A124 File Offset: 0x00018324
		private TSql120ParserInternal GetNewInternalParserForInput(TextReader input, out IList<ParseError> errors, int startOffset, int startLine, int startColumn)
		{
			TSql120ParserInternal newInternalParser = this.GetNewInternalParser();
			base.InitializeInternalParserInput(newInternalParser, input, out errors, startOffset, startLine, startColumn);
			return newInternalParser;
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x0001A148 File Offset: 0x00018348
		public override TSqlFragment Parse(IList<TSqlParserToken> tokens, out IList<ParseError> errors)
		{
			errors = new List<ParseError>();
			TSql120ParserInternal newInternalParser = this.GetNewInternalParser();
			newInternalParser.InitializeForNewInput(tokens, errors, false);
			return newInternalParser.ParseRuleWithStandardExceptionHandling<TSqlScript>(new TSql80ParserBaseInternal.ParserEntryPoint<TSqlScript>(newInternalParser.script), "script");
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x0001A184 File Offset: 0x00018384
		public override ChildObjectName ParseChildObjectName(TextReader input, out IList<ParseError> errors, int startOffset, int startLine, int startColumn)
		{
			TSql120ParserInternal newInternalParserForInput = this.GetNewInternalParserForInput(input, out errors, startOffset, startLine, startColumn);
			return newInternalParserForInput.ParseRuleWithStandardExceptionHandling<ChildObjectName>(new TSql80ParserBaseInternal.ParserEntryPoint<ChildObjectName>(newInternalParserForInput.entryPointChildObjectName), "entryPointChildObjectName");
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x0001A1B8 File Offset: 0x000183B8
		public override SchemaObjectName ParseSchemaObjectName(TextReader input, out IList<ParseError> errors, int startOffset, int startLine, int startColumn)
		{
			TSql120ParserInternal newInternalParserForInput = this.GetNewInternalParserForInput(input, out errors, startOffset, startLine, startColumn);
			return newInternalParserForInput.ParseRuleWithStandardExceptionHandling<SchemaObjectName>(new TSql80ParserBaseInternal.ParserEntryPoint<SchemaObjectName>(newInternalParserForInput.entryPointSchemaObjectName), "entryPointSchemaObjectName");
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x0001A1EC File Offset: 0x000183EC
		public override DataTypeReference ParseScalarDataType(TextReader input, out IList<ParseError> errors, int startOffset, int startLine, int startColumn)
		{
			TSql120ParserInternal newInternalParserForInput = this.GetNewInternalParserForInput(input, out errors, startOffset, startLine, startColumn);
			return newInternalParserForInput.ParseRuleWithStandardExceptionHandling<DataTypeReference>(new TSql80ParserBaseInternal.ParserEntryPoint<DataTypeReference>(newInternalParserForInput.entryPointScalarDataType), "entryPointScalarDataType");
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x0001A220 File Offset: 0x00018420
		public override ScalarExpression ParseExpression(TextReader input, out IList<ParseError> errors, int startOffset, int startLine, int startColumn)
		{
			TSql120ParserInternal newInternalParserForInput = this.GetNewInternalParserForInput(input, out errors, startOffset, startLine, startColumn);
			return newInternalParserForInput.ParseRuleWithStandardExceptionHandling<ScalarExpression>(new TSql80ParserBaseInternal.ParserEntryPoint<ScalarExpression>(newInternalParserForInput.entryPointExpression), "entryPointExpression");
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x0001A254 File Offset: 0x00018454
		public override BooleanExpression ParseBooleanExpression(TextReader input, out IList<ParseError> errors, int startOffset, int startLine, int startColumn)
		{
			TSql120ParserInternal newInternalParserForInput = this.GetNewInternalParserForInput(input, out errors, startOffset, startLine, startColumn);
			return newInternalParserForInput.ParseRuleWithStandardExceptionHandling<BooleanExpression>(new TSql80ParserBaseInternal.ParserEntryPoint<BooleanExpression>(newInternalParserForInput.entryPointBooleanExpression), "entryPointBooleanExpression");
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x0001A288 File Offset: 0x00018488
		public override StatementList ParseStatementList(TextReader input, out IList<ParseError> errors, int startOffset, int startLine, int startColumn)
		{
			TSql120ParserInternal newInternalParserForInput = this.GetNewInternalParserForInput(input, out errors, startOffset, startLine, startColumn);
			return newInternalParserForInput.ParseRuleWithStandardExceptionHandling<StatementList>(new TSql80ParserBaseInternal.ParserEntryPoint<StatementList>(newInternalParserForInput.entryPointStatementList), "entryPointStatementList");
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x0001A2BC File Offset: 0x000184BC
		public override SelectStatement ParseSubQueryExpressionWithOptionalCTE(TextReader input, out IList<ParseError> errors, int startOffset, int startLine, int startColumn)
		{
			TSql120ParserInternal newInternalParserForInput = this.GetNewInternalParserForInput(input, out errors, startOffset, startLine, startColumn);
			return newInternalParserForInput.ParseRuleWithStandardExceptionHandling<SelectStatement>(new TSql80ParserBaseInternal.ParserEntryPoint<SelectStatement>(newInternalParserForInput.entryPointSubqueryExpressionWithOptionalCTE), "entryPointSubqueryExpressionWithOptionalCTE");
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x0001A2F0 File Offset: 0x000184F0
		internal IPv4 ParseIPv4(TextReader input, out IList<ParseError> errors, int startOffset, int startLine, int startColumn)
		{
			TSql120ParserInternal newInternalParserForInput = this.GetNewInternalParserForInput(input, out errors, startOffset, startLine, startColumn);
			return newInternalParserForInput.ParseRuleWithStandardExceptionHandling<IPv4>(new TSql80ParserBaseInternal.ParserEntryPoint<IPv4>(newInternalParserForInput.entryPointIPv4Address), "entryPointIPv4Address");
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x0001A324 File Offset: 0x00018524
		public override TSqlFragment ParseConstantOrIdentifier(TextReader input, out IList<ParseError> errors, int startOffset, int startLine, int startColumn)
		{
			TSql120ParserInternal newInternalParserForInput = this.GetNewInternalParserForInput(input, out errors, startOffset, startLine, startColumn);
			return newInternalParserForInput.ParseRuleWithStandardExceptionHandling<TSqlFragment>(new TSql80ParserBaseInternal.ParserEntryPoint<TSqlFragment>(newInternalParserForInput.entryPointConstantOrIdentifier), "entryPointConstantOrIdentifier");
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x0001A358 File Offset: 0x00018558
		public override TSqlFragment ParseConstantOrIdentifierWithDefault(TextReader input, out IList<ParseError> errors, int startOffset, int startLine, int startColumn)
		{
			TSql120ParserInternal newInternalParserForInput = this.GetNewInternalParserForInput(input, out errors, startOffset, startLine, startColumn);
			return newInternalParserForInput.ParseRuleWithStandardExceptionHandling<TSqlFragment>(new TSql80ParserBaseInternal.ParserEntryPoint<TSqlFragment>(newInternalParserForInput.entryPointConstantOrIdentifierWithDefault), "entryPointConstantOrIdentifierWithDefault");
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x0001A38C File Offset: 0x0001858C
		internal override TSqlStatement PhaseOneParse(TextReader input)
		{
			TSql120ParserInternal newInternalParser = this.GetNewInternalParser();
			return base.PhaseOneParseImpl(newInternalParser, new TSql80ParserBaseInternal.ParserEntryPoint<TSqlScript>(newInternalParser.script), "script", input);
		}
	}
}
