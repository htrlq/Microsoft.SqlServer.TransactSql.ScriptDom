using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using antlr;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000165 RID: 357
	[Serializable]
	public abstract class TSqlParser
	{
		// Token: 0x06000309 RID: 777 RVA: 0x0000AFBF File Offset: 0x000091BF
		internal TSqlParser(bool quotedIdentifiersOn)
		{
			this._quotedIdentifier = quotedIdentifiersOn;
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0000AFD0 File Offset: 0x000091D0
		public TSqlParser Create(SqlVersion tsqlParserVersion, bool initialQuotedIdentifiers)
		{
			switch (tsqlParserVersion)
			{
			case SqlVersion.Sql90:
				return new TSql90Parser(initialQuotedIdentifiers);
			case SqlVersion.Sql80:
				return new TSql80Parser(initialQuotedIdentifiers);
			case SqlVersion.Sql100:
				return new TSql100Parser(initialQuotedIdentifiers);
			case SqlVersion.Sql110:
				return new TSql110Parser(initialQuotedIdentifiers);
			case SqlVersion.Sql120:
				return new TSql120Parser(initialQuotedIdentifiers);
			default:
				throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, SqlScriptGeneratorResource.UnknownEnumValue, new object[]
				{
					tsqlParserVersion,
					"TSqlParserVersion"
				}), "tsqlParserVersion");
			}
		}

		// Token: 0x0600030B RID: 779 RVA: 0x0000B050 File Offset: 0x00009250
		public TSqlFragment Parse(TextReader input, out IList<ParseError> errors)
		{
			return this.Parse(input, out errors, 0, 1, 1);
		}

		// Token: 0x0600030C RID: 780 RVA: 0x0000B060 File Offset: 0x00009260
		public TSqlFragment Parse(TextReader input, out IList<ParseError> errors, int startOffset, int startLine, int startColumn)
		{
			IList<TSqlParserToken> tokenStream = this.GetTokenStream(input, out errors, startOffset, startLine, startColumn);
			if (errors.Count > 0)
			{
				return new TSqlScript();
			}
			return this.Parse(tokenStream, out errors);
		}

		// Token: 0x0600030D RID: 781
		public abstract TSqlFragment Parse(IList<TSqlParserToken> tokens, out IList<ParseError> errors);

		// Token: 0x0600030E RID: 782
		public abstract ChildObjectName ParseChildObjectName(TextReader input, out IList<ParseError> errors, int startOffset, int startLine, int startColumn);

		// Token: 0x0600030F RID: 783 RVA: 0x0000B093 File Offset: 0x00009293
		public ChildObjectName ParseChildObjectName(TextReader input, out IList<ParseError> errors)
		{
			return this.ParseChildObjectName(input, out errors, 0, 1, 1);
		}

		// Token: 0x06000310 RID: 784
		public abstract SchemaObjectName ParseSchemaObjectName(TextReader input, out IList<ParseError> errors, int startOffset, int startLine, int startColumn);

		// Token: 0x06000311 RID: 785 RVA: 0x0000B0A0 File Offset: 0x000092A0
		public SchemaObjectName ParseSchemaObjectName(TextReader input, out IList<ParseError> errors)
		{
			return this.ParseSchemaObjectName(input, out errors, 0, 1, 1);
		}

		// Token: 0x06000312 RID: 786
		public abstract DataTypeReference ParseScalarDataType(TextReader input, out IList<ParseError> errors, int startOffset, int startLine, int startColumn);

		// Token: 0x06000313 RID: 787 RVA: 0x0000B0AD File Offset: 0x000092AD
		public DataTypeReference ParseScalarDataType(TextReader input, out IList<ParseError> errors)
		{
			return this.ParseScalarDataType(input, out errors, 0, 1, 1);
		}

		// Token: 0x06000314 RID: 788
		public abstract TSqlFragment ParseConstantOrIdentifier(TextReader input, out IList<ParseError> errors, int startOffset, int startLine, int startColumn);

		// Token: 0x06000315 RID: 789 RVA: 0x0000B0BA File Offset: 0x000092BA
		public TSqlFragment ParseConstantOrIdentifier(TextReader input, out IList<ParseError> errors)
		{
			return this.ParseConstantOrIdentifier(input, out errors, 0, 1, 1);
		}

		// Token: 0x06000316 RID: 790
		public abstract TSqlFragment ParseConstantOrIdentifierWithDefault(TextReader input, out IList<ParseError> errors, int startOffset, int startLine, int startColumn);

		// Token: 0x06000317 RID: 791 RVA: 0x0000B0C7 File Offset: 0x000092C7
		public TSqlFragment ParseConstantOrIdentifierWithDefault(TextReader input, out IList<ParseError> errors)
		{
			return this.ParseConstantOrIdentifierWithDefault(input, out errors, 0, 1, 1);
		}

		// Token: 0x06000318 RID: 792
		public abstract ScalarExpression ParseExpression(TextReader input, out IList<ParseError> errors, int startOffset, int startLine, int startColumn);

		// Token: 0x06000319 RID: 793 RVA: 0x0000B0D4 File Offset: 0x000092D4
		public ScalarExpression ParseExpression(TextReader input, out IList<ParseError> errors)
		{
			return this.ParseExpression(input, out errors, 0, 1, 1);
		}

		// Token: 0x0600031A RID: 794
		public abstract BooleanExpression ParseBooleanExpression(TextReader input, out IList<ParseError> errors, int startOffset, int startLine, int startColumn);

		// Token: 0x0600031B RID: 795 RVA: 0x0000B0E1 File Offset: 0x000092E1
		public BooleanExpression ParseBooleanExpression(TextReader input, out IList<ParseError> errors)
		{
			return this.ParseBooleanExpression(input, out errors, 0, 1, 1);
		}

		// Token: 0x0600031C RID: 796
		public abstract StatementList ParseStatementList(TextReader input, out IList<ParseError> errors, int startOffset, int startLine, int startColumn);

		// Token: 0x0600031D RID: 797 RVA: 0x0000B0EE File Offset: 0x000092EE
		public StatementList ParseStatementList(TextReader input, out IList<ParseError> errors)
		{
			return this.ParseStatementList(input, out errors, 0, 1, 1);
		}

		// Token: 0x0600031E RID: 798
		public abstract SelectStatement ParseSubQueryExpressionWithOptionalCTE(TextReader input, out IList<ParseError> errors, int startOffset, int startLine, int startColumn);

		// Token: 0x0600031F RID: 799 RVA: 0x0000B0FB File Offset: 0x000092FB
		public SelectStatement ParseSubQueryExpressionWithOptionalCTE(TextReader input, out IList<ParseError> errors)
		{
			return this.ParseSubQueryExpressionWithOptionalCTE(input, out errors, 0, 1, 1);
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0000B108 File Offset: 0x00009308
		public bool TryParseSqlModuleObjectName(TextReader input, out SchemaObjectName result)
		{
			TSqlStatement tsqlStatement = this.PhaseOneParse(input);
			TSqlParser.ExtractSchemaObjectNameVisitor extractSchemaObjectNameVisitor = new TSqlParser.ExtractSchemaObjectNameVisitor();
			result = null;
			if (tsqlStatement != null)
			{
				tsqlStatement.Accept(extractSchemaObjectNameVisitor);
				result = extractSchemaObjectNameVisitor.SchemaObjectName;
			}
			return result != null;
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0000B140 File Offset: 0x00009340
		public bool TryParseTriggerModule(TextReader input, out SchemaObjectName triggerName, out SchemaObjectName targetName)
		{
			TSqlStatement tsqlStatement = this.PhaseOneParse(input);
			TSqlParser.ExtractSchemaObjectNameVisitor extractSchemaObjectNameVisitor = new TSqlParser.ExtractSchemaObjectNameVisitor();
			triggerName = null;
			targetName = null;
			if (tsqlStatement != null)
			{
				tsqlStatement.Accept(extractSchemaObjectNameVisitor);
				triggerName = extractSchemaObjectNameVisitor.SchemaObjectName;
				targetName = extractSchemaObjectNameVisitor.TriggerTargetName;
			}
			return targetName != null;
		}

		// Token: 0x06000322 RID: 802
		internal abstract TSqlStatement PhaseOneParse(TextReader input);

		// Token: 0x06000323 RID: 803 RVA: 0x0000B183 File Offset: 0x00009383
		public IList<TSqlParserToken> GetTokenStream(TextReader input, out IList<ParseError> errors)
		{
			return this.GetTokenStream(input, out errors, 0, 1, 1);
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0000B190 File Offset: 0x00009390
		public IList<TSqlParserToken> GetTokenStream(TextReader input, out IList<ParseError> errors, int startOffset, int startLine, int startColumn)
		{
			errors = new List<ParseError>();
			Collection<TSqlParserToken> collection = new Collection<TSqlParserToken>();
			TSqlLexerBaseInternal newInternalLexer = this.GetNewInternalLexer();
			newInternalLexer.InitializeForNewInput(startOffset, startLine, startColumn, input);
			TSqlParserToken tsqlParserToken = null;
			do
			{
				try
				{
					tsqlParserToken = (TSqlParserToken)newInternalLexer.nextToken();
					collection.Add(tsqlParserToken);
				}
				catch (TokenStreamRecognitionException exception)
				{
					ParseError item = TSql80ParserBaseInternal.ProcessTokenStreamRecognitionException(exception, newInternalLexer.CurrentOffset);
					errors.Add(item);
					break;
				}
				catch (TSqlParseErrorException ex)
				{
					errors.Add(ex.ParseError);
				}
			}
			while (tsqlParserToken != null && tsqlParserToken.TokenType != TSqlTokenType.EndOfFile);
			return collection;
		}

		// Token: 0x06000325 RID: 805 RVA: 0x0000B22C File Offset: 0x0000942C
		public bool ValidateIdentifier(string name)
		{
			if (string.IsNullOrEmpty(name))
			{
				return false;
			}
			using (StringReader stringReader = new StringReader(name))
			{
				IList<ParseError> list;
				IList<TSqlParserToken> tokenStream = this.GetTokenStream(stringReader, out list, 0, 1, 1);
				if (tokenStream.Count == 2 && tokenStream[1].TokenType == TSqlTokenType.EndOfFile && (tokenStream[0].TokenType == TSqlTokenType.Identifier || tokenStream[0].TokenType == TSqlTokenType.QuotedIdentifier || tokenStream[0].TokenType == TSqlTokenType.AsciiStringOrQuotedIdentifier) && string.Equals(name, tokenStream[0].Text, StringComparison.Ordinal))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000326 RID: 806 RVA: 0x0000B2E0 File Offset: 0x000094E0
		public bool QuotedIdentifier
		{
			get
			{
				return this._quotedIdentifier;
			}
		}

		// Token: 0x06000327 RID: 807
		internal abstract TSqlLexerBaseInternal GetNewInternalLexer();

		// Token: 0x06000328 RID: 808 RVA: 0x0000B2E8 File Offset: 0x000094E8
		internal void InitializeInternalParserInput(TSql80ParserBaseInternal parser, TextReader input, out IList<ParseError> errors, int startOffset, int startLine, int startColumn)
		{
			IList<TSqlParserToken> tokenStream = this.GetTokenStream(input, out errors, startOffset, startLine, startColumn);
			parser.InitializeForNewInput(tokenStream, errors, false);
		}

		// Token: 0x06000329 RID: 809 RVA: 0x0000B310 File Offset: 0x00009510
		internal TSqlStatement PhaseOneParseImpl(TSql80ParserBaseInternal parser, TSql80ParserBaseInternal.ParserEntryPoint<TSqlScript> entryPoint, string entryPointName, TextReader input)
		{
			IList<ParseError> errors;
			IList<TSqlParserToken> tokenStream = this.GetTokenStream(input, out errors, 0, 1, 1);
			parser.InitializeForNewInput(tokenStream, errors, true);
			bool flag = true;
			while (flag)
			{
				flag = false;
				try
				{
					parser.ParseRuleWithStandardExceptionHandling<TSqlScript>(entryPoint, entryPointName);
				}
				catch (PhaseOnePartialAstException ex)
				{
					return ex.Statement;
				}
				catch (PhaseOneBatchException)
				{
					flag = true;
				}
			}
			return null;
		}

		// Token: 0x04000E4C RID: 3660
		internal const string ScriptEntryMethod = "script";

		// Token: 0x04000E4D RID: 3661
		private readonly bool _quotedIdentifier;

		// Token: 0x02000167 RID: 359
		private class ExtractSchemaObjectNameVisitor : TSqlFragmentVisitor
		{
			// Token: 0x17000043 RID: 67
			// (get) Token: 0x060009A6 RID: 2470 RVA: 0x0001686B File Offset: 0x00014A6B
			// (set) Token: 0x060009A7 RID: 2471 RVA: 0x00016873 File Offset: 0x00014A73
			public SchemaObjectName SchemaObjectName { get; private set; }

			// Token: 0x17000044 RID: 68
			// (get) Token: 0x060009A8 RID: 2472 RVA: 0x0001687C File Offset: 0x00014A7C
			// (set) Token: 0x060009A9 RID: 2473 RVA: 0x00016884 File Offset: 0x00014A84
			public SchemaObjectName TriggerTargetName { get; private set; }

			// Token: 0x060009AA RID: 2474 RVA: 0x0001688D File Offset: 0x00014A8D
			public override void Visit(ProcedureStatementBody node)
			{
				this.SchemaObjectName = node.ProcedureReference.Name;
			}

			// Token: 0x060009AB RID: 2475 RVA: 0x000168A0 File Offset: 0x00014AA0
			public override void Visit(ViewStatementBody node)
			{
				this.SchemaObjectName = node.SchemaObjectName;
			}

			// Token: 0x060009AC RID: 2476 RVA: 0x000168AE File Offset: 0x00014AAE
			public override void Visit(FunctionStatementBody node)
			{
				this.SchemaObjectName = node.Name;
			}

			// Token: 0x060009AD RID: 2477 RVA: 0x000168BC File Offset: 0x00014ABC
			public override void Visit(TriggerStatementBody node)
			{
				this.SchemaObjectName = node.Name;
				this.TriggerTargetName = node.TriggerObject.Name;
			}
		}
	}
}
