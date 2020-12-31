using System;
using System.Collections.Generic;
using System.Globalization;
using antlr;
using antlr.collections.impl;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000169 RID: 361
	internal abstract class TSql80ParserBaseInternal : LLkParser
	{
		// Token: 0x060009BF RID: 2495 RVA: 0x00016B95 File Offset: 0x00014D95
		protected TSql80ParserBaseInternal(TokenBuffer tokenBuf, int k) : base(tokenBuf, k)
		{
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x00016BBF File Offset: 0x00014DBF
		protected TSql80ParserBaseInternal(ParserSharedInputState state, int k) : base(state, k)
		{
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x00016BE9 File Offset: 0x00014DE9
		protected TSql80ParserBaseInternal(TokenStream lexer, int k) : base(lexer, k)
		{
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x00016C13 File Offset: 0x00014E13
		public TSql80ParserBaseInternal(bool initialQuotedIdentifiersOn) : base(2)
		{
			this._initialQuotedIdentifiersOn = initialQuotedIdentifiersOn;
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x00016C44 File Offset: 0x00014E44
		public void InitializeForNewInput(IList<TSqlParserToken> tokens, IList<ParseError> errors, bool phaseOne)
		{
			this._tokenSource = new TSqlWhitespaceTokenFilter(this._initialQuotedIdentifiersOn, tokens);
			this._parseErrors = errors;
			this._fragmentFactory.SetTokenStream(tokens);
			this.PhaseOne = phaseOne;
			this.setTokenBuffer(new TokenBuffer(this._tokenSource));
			this.resetState();
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x00016C94 File Offset: 0x00014E94
		static TSql80ParserBaseInternal()
		{
			TSql80ParserBaseInternal._ddlStatementBeginnerTokens.add(35);
			TSql80ParserBaseInternal._ddlStatementBeginnerTokens.add(6);
			TSql80ParserBaseInternal._statementLevelRecoveryTokens.add(219);
			TSql80ParserBaseInternal._statementLevelRecoveryTokens.add(204);
			TSql80ParserBaseInternal._statementLevelRecoveryTokens.orInPlace(TSql80ParserBaseInternal._ddlStatementBeginnerTokens);
			TSql80ParserBaseInternal._phaseOneBatchLevelRecoveryTokens.add(219);
			TSql80ParserBaseInternal._phaseOneBatchLevelRecoveryTokens.orInPlace(TSql80ParserBaseInternal._ddlStatementBeginnerTokens);
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x00016E91 File Offset: 0x00015091
		protected void ResetQuotedIdentifiersSettingToInitial()
		{
			this._tokenSource.QuotedIdentifier = this._initialQuotedIdentifiersOn;
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x00016EA4 File Offset: 0x000150A4
		internal static void UpdateTokenInfo(TSqlFragment fragment, IToken token)
		{
			TSqlWhitespaceTokenFilter.TSqlParserTokenProxyWithIndex tsqlParserTokenProxyWithIndex = (TSqlWhitespaceTokenFilter.TSqlParserTokenProxyWithIndex)token;
			int tokenIndex = tsqlParserTokenProxyWithIndex.TokenIndex;
			if (tokenIndex != -1)
			{
				fragment.UpdateTokenInfo(tokenIndex, tokenIndex);
			}
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x00016ECB File Offset: 0x000150CB
		protected static void AddAndUpdateTokenInfo<TFragmentType>(TSqlFragment node, IList<TFragmentType> collection, TFragmentType item) where TFragmentType : TSqlFragment
		{
			collection.Add(item);
			node.UpdateTokenInfo(item);
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x00016EE0 File Offset: 0x000150E0
		protected static void AddAndUpdateTokenInfo<TFragmentType>(TSqlFragment node, IList<TFragmentType> collection, IList<TFragmentType> otherCollection) where TFragmentType : TSqlFragment
		{
			foreach (TFragmentType item in otherCollection)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<TFragmentType>(node, collection, item);
			}
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x00016F2C File Offset: 0x0001512C
		protected static string DecodeAsciiStringLiteral(string encodedValue)
		{
			int length = encodedValue.Length;
			string text = encodedValue.Substring(1, length - 2);
			if (encodedValue[0] == '"')
			{
				return text.Replace("\"\"", "\"");
			}
			return text.Replace("''", "'");
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x00016F78 File Offset: 0x00015178
		protected static string DecodeUnicodeStringLiteral(string encodedValue)
		{
			int length = encodedValue.Length;
			return encodedValue.Substring(2, length - 3).Replace("''", "'");
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x00016FA5 File Offset: 0x000151A5
		protected static bool IsAsciiStringLob(string asciiValue)
		{
			return asciiValue.Length > 8000;
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x00016FB4 File Offset: 0x000151B4
		protected static bool IsUnicodeStringLob(string unicodeValue)
		{
			return unicodeValue.Length > 8000;
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x00016FC3 File Offset: 0x000151C3
		protected static bool IsBinaryLiteralLob(string binaryValue)
		{
			return binaryValue.Length - 2 > 16000;
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060009CE RID: 2510 RVA: 0x00016FD4 File Offset: 0x000151D4
		public TSqlFragmentFactory FragmentFactory
		{
			get
			{
				return this._fragmentFactory;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060009CF RID: 2511 RVA: 0x00016FDC File Offset: 0x000151DC
		// (set) Token: 0x060009D0 RID: 2512 RVA: 0x00016FE4 File Offset: 0x000151E4
		public bool PhaseOne
		{
			get
			{
				return this._phaseOne;
			}
			set
			{
				this._phaseOne = value;
			}
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x00016FED File Offset: 0x000151ED
		protected void AddParseError(ParseError parseError)
		{
			this._parseErrors.Add(parseError);
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x00016FFC File Offset: 0x000151FC
		protected void RecoverAtStatementLevel(int statementStartLine, int statementStartColumn)
		{
			this.consumeUntil(TSql80ParserBaseInternal._statementLevelRecoveryTokens);
			int line = this.LT(1).getLine();
			int column = this.LT(1).getColumn();
			if (line == statementStartLine && column == statementStartColumn)
			{
				if (this.PhaseOne && this._phaseOnePreviousStatementLevelErrorLine != line && this._phaseOnePreviousStatementLevelErrorColumn != column)
				{
					this._phaseOnePreviousStatementLevelErrorLine = line;
					this._phaseOnePreviousStatementLevelErrorColumn = column;
					throw new PhaseOneBatchException();
				}
				this.consume();
			}
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x0001706A File Offset: 0x0001526A
		protected void SkipInitialDdlTokens()
		{
			if (TSql80ParserBaseInternal._ddlStatementBeginnerTokens.member(this.LA(1)))
			{
				this.consume();
			}
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x00017088 File Offset: 0x00015288
		protected void RecoverAtBatchLevel()
		{
			if (this.PhaseOne)
			{
				this.SkipInitialDdlTokens();
				this.consumeUntil(TSql80ParserBaseInternal._phaseOneBatchLevelRecoveryTokens);
				if (this.LA(1) != 219 && this.LA(1) != 1)
				{
					throw new PhaseOneBatchException();
				}
			}
			else
			{
				this.consumeUntil(219);
			}
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x000170D7 File Offset: 0x000152D7
		protected void ThrowPartialAstIfPhaseOne(TSqlStatement statement)
		{
			if (this.PhaseOne)
			{
				throw new PhaseOnePartialAstException(statement);
			}
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x000170E8 File Offset: 0x000152E8
		protected void ThrowConstraintIfPhaseOne(ConstraintDefinition constraint)
		{
			if (this.PhaseOne)
			{
				throw new PhaseOneConstraintException(constraint);
			}
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x000170F9 File Offset: 0x000152F9
		protected bool NextTokenMatches(string keyword)
		{
			return this.LA(1) != 1 && string.Equals(this.LT(1).getText(), keyword, StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x0001711A File Offset: 0x0001531A
		protected bool NextTokenMatches(string keyword, int which)
		{
			return this.LA(which) != 1 && string.Equals(this.LT(which).getText(), keyword, StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x0001713C File Offset: 0x0001533C
		protected bool NextTokenMatchesOneOf(params string[] keywords)
		{
			if (this.LA(1) == 1)
			{
				return false;
			}
			string text = this.LT(1).getText();
			foreach (string a in keywords)
			{
				if (string.Equals(a, text, StringComparison.OrdinalIgnoreCase))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x0001718C File Offset: 0x0001538C
		protected void ThrowIfEndOfFileOrBatch()
		{
			if (this.LA(1) == 1 || this.LA(1) == 219)
			{
				throw new TSqlParseErrorException(null, true);
			}
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x000171B0 File Offset: 0x000153B0
		protected void AddBinaryExpression(ref ScalarExpression result, ScalarExpression expression, BinaryExpressionType type)
		{
			BinaryExpression binaryExpression = this.FragmentFactory.CreateFragment<BinaryExpression>();
			binaryExpression.FirstExpression = result;
			binaryExpression.SecondExpression = expression;
			binaryExpression.BinaryExpressionType = type;
			result = binaryExpression;
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x000171E4 File Offset: 0x000153E4
		protected void AddBinaryExpression(ref BooleanExpression result, BooleanExpression expression, BooleanBinaryExpressionType type)
		{
			BooleanBinaryExpression booleanBinaryExpression = this.FragmentFactory.CreateFragment<BooleanBinaryExpression>();
			booleanBinaryExpression.FirstExpression = result;
			booleanBinaryExpression.SecondExpression = expression;
			booleanBinaryExpression.BinaryExpressionType = type;
			result = booleanBinaryExpression;
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x00017218 File Offset: 0x00015418
		protected Identifier GetEmptyIdentifier(IToken token)
		{
			Identifier identifier = this.FragmentFactory.CreateFragment<Identifier>();
			TSql80ParserBaseInternal.UpdateTokenInfo(identifier, token);
			identifier.SetIdentifier(string.Empty);
			return identifier;
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x00017244 File Offset: 0x00015444
		protected static void CheckXmlForClauseOptionDuplication(XmlForClauseOptions current, XmlForClauseOptions newOption, IToken token)
		{
			if ((current & newOption) != XmlForClauseOptions.None)
			{
				throw TSql80ParserBaseInternal.GetUnexpectedTokenErrorException(token);
			}
			if ((newOption & XmlForClauseOptions.ElementsAll) != XmlForClauseOptions.None && (current & XmlForClauseOptions.ElementsAll) != XmlForClauseOptions.None)
			{
				throw TSql80ParserBaseInternal.GetUnexpectedTokenErrorException(token);
			}
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x0001726B File Offset: 0x0001546B
		protected static void AddIdentifierToListWithCheck(List<Identifier> list, Identifier item, int max)
		{
			if (list.Count == max)
			{
				throw TSql80ParserBaseInternal.GetUnexpectedTokenErrorException(item);
			}
			list.Add(item);
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x00017284 File Offset: 0x00015484
		protected static void CheckOptionDuplication(ref int encountered, int newOption, TSqlFragment vOption)
		{
			TSql80ParserBaseInternal.CheckOptionDuplication(ref encountered, newOption, TSql80ParserBaseInternal.GetFirstToken(vOption));
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x00017294 File Offset: 0x00015494
		protected static void CheckOptionDuplication(ref int encountered, int newOption, IToken token)
		{
			int num = 1 << newOption;
			if ((encountered & num) == num)
			{
				TSql80ParserBaseInternal.ThrowParseErrorException("SQL46049", token, TSqlParserResource.SQL46049Message, new string[]
				{
					token.getText()
				});
			}
			encountered |= num;
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x000172D6 File Offset: 0x000154D6
		protected static void CheckOptionDuplication(ref ulong encountered, int newOption, TSqlFragment vOption)
		{
			TSql80ParserBaseInternal.CheckOptionDuplication(ref encountered, newOption, TSql80ParserBaseInternal.GetFirstToken(vOption));
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x000172E8 File Offset: 0x000154E8
		protected static void CheckOptionDuplication(ref ulong encountered, int newOption, IToken token)
		{
			ulong num = 1UL << newOption;
			if ((encountered & num) == num)
			{
				TSql80ParserBaseInternal.ThrowParseErrorException("SQL46049", token, TSqlParserResource.SQL46049Message, new string[]
				{
					token.getText()
				});
			}
			encountered |= num;
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x0001732C File Offset: 0x0001552C
		protected IdentifierOrValueExpression IdentifierOrValueExpression(Identifier identifier)
		{
			IdentifierOrValueExpression identifierOrValueExpression = this.FragmentFactory.CreateFragment<IdentifierOrValueExpression>();
			identifierOrValueExpression.Identifier = identifier;
			return identifierOrValueExpression;
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x00017350 File Offset: 0x00015550
		protected IdentifierOrValueExpression IdentifierOrValueExpression(ValueExpression valueExpression)
		{
			IdentifierOrValueExpression identifierOrValueExpression = this.FragmentFactory.CreateFragment<IdentifierOrValueExpression>();
			identifierOrValueExpression.ValueExpression = valueExpression;
			return identifierOrValueExpression;
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x00017374 File Offset: 0x00015574
		protected static OdbcLiteralType ParseOdbcLiteralType(IToken token)
		{
			if (TSql80ParserBaseInternal.TryMatch(token, "T"))
			{
				return OdbcLiteralType.Time;
			}
			if (TSql80ParserBaseInternal.TryMatch(token, "D"))
			{
				return OdbcLiteralType.Date;
			}
			if (TSql80ParserBaseInternal.TryMatch(token, "TS"))
			{
				return OdbcLiteralType.Timestamp;
			}
			if (TSql80ParserBaseInternal.TryMatch(token, "GUID"))
			{
				return OdbcLiteralType.Guid;
			}
			throw TSql80ParserBaseInternal.GetUnexpectedTokenErrorException(token);
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x000173C4 File Offset: 0x000155C4
		protected static OptimizerHintKind ParseJoinOptimizerHint(IToken token)
		{
			string a;
			if ((a = token.getText().ToUpperInvariant()) != null)
			{
				if (a == "MERGE")
				{
					return OptimizerHintKind.MergeJoin;
				}
				if (a == "HASH")
				{
					return OptimizerHintKind.HashJoin;
				}
				if (a == "LOOP")
				{
					return OptimizerHintKind.LoopJoin;
				}
			}
			throw TSql80ParserBaseInternal.GetUnexpectedTokenErrorException(token);
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x00017418 File Offset: 0x00015618
		protected static OptimizerHintKind ParseUnionOptimizerHint(IToken token)
		{
			string a;
			if ((a = token.getText().ToUpperInvariant()) != null)
			{
				if (a == "CONCAT")
				{
					return OptimizerHintKind.ConcatUnion;
				}
				if (a == "HASH")
				{
					return OptimizerHintKind.HashUnion;
				}
				if (a == "MERGE")
				{
					return OptimizerHintKind.MergeUnion;
				}
				if (a == "KEEP")
				{
					return OptimizerHintKind.KeepUnion;
				}
			}
			throw TSql80ParserBaseInternal.GetUnexpectedTokenErrorException(token);
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x0001747C File Offset: 0x0001567C
		protected bool IsNextRuleSelectParenthesis()
		{
			bool result = false;
			if (this.LA(1) == 191 && this.LA(2) == 140)
			{
				return true;
			}
			int pos = this.mark();
			this.consume();
			int num = 1;
			bool flag = true;
			while (flag)
			{
				int num2 = this.LA(1);
				if (num2 <= 72)
				{
					if (num2 <= 36)
					{
						if (num2 != 1)
						{
							if (num2 == 36)
							{
								goto IL_C5;
							}
						}
						else
						{
							flag = false;
						}
					}
					else if (num2 == 59 || num2 == 72)
					{
						goto IL_C5;
					}
				}
				else if (num2 <= 90)
				{
					switch (num2)
					{
					case 85:
					case 87:
						goto IL_C5;
					case 86:
						break;
					default:
						if (num2 == 90)
						{
							goto IL_C5;
						}
						break;
					}
				}
				else
				{
					if (num2 == 114 || num2 == 158)
					{
						goto IL_C5;
					}
					switch (num2)
					{
					case 191:
						num++;
						break;
					case 192:
						num--;
						if (num == 0)
						{
							flag = false;
						}
						break;
					}
				}
				IL_CD:
				this.consume();
				continue;
				IL_C5:
				if (num == 1)
				{
					result = true;
					flag = false;
					goto IL_CD;
				}
				goto IL_CD;
			}
			this.rewind(pos);
			return result;
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x0001756C File Offset: 0x0001576C
		protected bool IsNextRuleBooleanParenthesis()
		{
			if (this.LA(1) != 191)
			{
				return false;
			}
			bool result = false;
			int pos = this.mark();
			this.consume();
			int num = 1;
			int num2 = 0;
			int num3 = 0;
			bool flag = true;
			while (flag)
			{
				int num4 = this.LA(1);
				if (num4 <= 83)
				{
					if (num4 <= 20)
					{
						if (num4 <= 7)
						{
							if (num4 != 1)
							{
								if (num4 == 7)
								{
									goto IL_182;
								}
							}
							else
							{
								flag = false;
							}
						}
						else
						{
							if (num4 == 14)
							{
								goto IL_182;
							}
							if (num4 == 20)
							{
								num2++;
							}
						}
					}
					else if (num4 <= 56)
					{
						if (num4 == 31)
						{
							goto IL_182;
						}
						if (num4 == 56)
						{
							num2--;
						}
					}
					else if (num4 == 62 || num4 == 69 || num4 == 83)
					{
						goto IL_182;
					}
				}
				else if (num4 <= 140)
				{
					if (num4 <= 94)
					{
						if (num4 == 89 || num4 == 94)
						{
							goto IL_182;
						}
					}
					else
					{
						if (num4 == 99 || num4 == 112)
						{
							goto IL_182;
						}
						if (num4 == 140)
						{
							if (num3 == 0)
							{
								num3 = num;
							}
						}
					}
				}
				else if (num4 <= 160)
				{
					if (num4 == 157 || num4 == 160)
					{
						goto IL_182;
					}
				}
				else
				{
					switch (num4)
					{
					case 188:
						goto IL_182;
					case 189:
					case 190:
						break;
					case 191:
						num++;
						break;
					case 192:
						if (num == num3)
						{
							num3 = 0;
						}
						num--;
						if (num == 0)
						{
							flag = false;
						}
						break;
					default:
						if (num4 == 196)
						{
							goto IL_182;
						}
						switch (num4)
						{
						case 205:
						case 206:
						case 207:
						case 208:
							goto IL_182;
						}
						break;
					}
				}
				IL_1A3:
				this.consume();
				continue;
				IL_182:
				if (num2 == 0 && num3 == 0)
				{
					result = true;
					flag = false;
					goto IL_1A3;
				}
				goto IL_1A3;
			}
			this.rewind(pos);
			return result;
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x00017731 File Offset: 0x00015931
		protected bool SaveGuessing(out IToken marker)
		{
			marker = null;
			if (this.inputState.guessing == 0)
			{
				return false;
			}
			marker = this.LT(1);
			return true;
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x0001774F File Offset: 0x0001594F
		protected bool SkipGuessing(IToken marker)
		{
			if (marker == null)
			{
				return false;
			}
			if (this.inputState.guessing == 0)
			{
				return false;
			}
			while (this.LA(1) != 1 && this.LT(1) != marker)
			{
				this.consume();
			}
			return true;
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x00017780 File Offset: 0x00015980
		protected static void Match(IToken token, string keyword)
		{
			if (!string.Equals(token.getText(), keyword, StringComparison.OrdinalIgnoreCase))
			{
				TSql80ParserBaseInternal.ThrowParseErrorException("SQL46005", token, TSqlParserResource.SQL46005Message, new string[]
				{
					keyword,
					token.getText()
				});
			}
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x000177C1 File Offset: 0x000159C1
		protected static void Match(Identifier id, string constant)
		{
			if (!string.Equals(id.Value, constant, StringComparison.OrdinalIgnoreCase))
			{
				throw TSql80ParserBaseInternal.GetUnexpectedTokenErrorException(id);
			}
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x000177D9 File Offset: 0x000159D9
		protected static void Match(Identifier id, string constant, IToken tokenForError)
		{
			if (!string.Equals(id.Value, constant, StringComparison.OrdinalIgnoreCase))
			{
				throw TSql80ParserBaseInternal.GetUnexpectedTokenErrorException(tokenForError);
			}
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x000177F1 File Offset: 0x000159F1
		protected static void Match(IToken token, string keyword, string alternate)
		{
			if (!string.Equals(token.getText(), keyword, StringComparison.OrdinalIgnoreCase) && !string.Equals(token.getText(), alternate, StringComparison.OrdinalIgnoreCase))
			{
				throw TSql80ParserBaseInternal.GetUnexpectedTokenErrorException(token);
			}
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x00017818 File Offset: 0x00015A18
		protected static bool TryMatch(IToken token, string keyword)
		{
			return string.Equals(token.getText(), keyword, StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x00017827 File Offset: 0x00015A27
		protected static bool TryMatch(Identifier identifier, string keyword)
		{
			return string.Equals(identifier.Value, keyword, StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x00017838 File Offset: 0x00015A38
		protected static void MatchString(Literal literal, params string[] keywords)
		{
			string value = literal.Value;
			foreach (string b in keywords)
			{
				if (string.Equals(value, b, StringComparison.OrdinalIgnoreCase))
				{
					return;
				}
			}
			TSql80ParserBaseInternal.ThrowIncorrectSyntaxErrorException(TSql80ParserBaseInternal.GetFirstToken(literal));
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x00017878 File Offset: 0x00015A78
		protected static SqlDataTypeOption ParseDataType(string token)
		{
			string key;
			switch (key = token.ToUpperInvariant())
			{
			case "BIGINT":
				return SqlDataTypeOption.BigInt;
			case "INTEGER":
			case "INT":
				return SqlDataTypeOption.Int;
			case "SMALLINT":
				return SqlDataTypeOption.SmallInt;
			case "TINYINT":
				return SqlDataTypeOption.TinyInt;
			case "BIT":
				return SqlDataTypeOption.Bit;
			case "DEC":
			case "DECIMAL":
				return SqlDataTypeOption.Decimal;
			case "NUMERIC":
				return SqlDataTypeOption.Numeric;
			case "MONEY":
				return SqlDataTypeOption.Money;
			case "SMALLMONEY":
				return SqlDataTypeOption.SmallMoney;
			case "FLOAT":
				return SqlDataTypeOption.Float;
			case "REAL":
				return SqlDataTypeOption.Real;
			case "DATETIME":
				return SqlDataTypeOption.DateTime;
			case "SMALLDATETIME":
				return SqlDataTypeOption.SmallDateTime;
			case "CHARACTER":
			case "CHAR":
				return SqlDataTypeOption.Char;
			case "VARCHAR":
				return SqlDataTypeOption.VarChar;
			case "TEXT":
				return SqlDataTypeOption.Text;
			case "NCHAR":
			case "NCHARACTER":
				return SqlDataTypeOption.NChar;
			case "NVARCHAR":
				return SqlDataTypeOption.NVarChar;
			case "NTEXT":
				return SqlDataTypeOption.NText;
			case "BINARY":
				return SqlDataTypeOption.Binary;
			case "VARBINARY":
				return SqlDataTypeOption.VarBinary;
			case "IMAGE":
				return SqlDataTypeOption.Image;
			case "CURSOR":
				return SqlDataTypeOption.Cursor;
			case "SQL_VARIANT":
				return SqlDataTypeOption.Sql_Variant;
			case "TABLE":
				return SqlDataTypeOption.Table;
			case "ROWVERSION":
				return SqlDataTypeOption.Rowversion;
			case "TIMESTAMP":
				return SqlDataTypeOption.Timestamp;
			case "UNIQUEIDENTIFIER":
				return SqlDataTypeOption.UniqueIdentifier;
			}
			return SqlDataTypeOption.None;
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x00017B2C File Offset: 0x00015D2C
		protected static IndexOptionKind ParseIndexLegacyWithOption(IToken token)
		{
			IndexOptionKind result;
			if (!IndexOptionHelper.Instance.TryParseOption(token, SqlVersionFlags.TSql80, out result))
			{
				TSql80ParserBaseInternal.ThrowParseErrorException("SQL46015", token, TSqlParserResource.SQL46015Message, new string[]
				{
					token.getText()
				});
			}
			return result;
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x00017B6C File Offset: 0x00015D6C
		protected static void ThrowWrongIndexOptionError(IndexAffectingStatement statement, TSqlFragment option)
		{
			string text = string.Empty;
			if (option.FirstTokenIndex >= 0 && option.ScriptTokenStream != null && option.FirstTokenIndex < option.ScriptTokenStream.Count)
			{
				TSqlParserToken tsqlParserToken = option.ScriptTokenStream[option.FirstTokenIndex];
				text = tsqlParserToken.Text;
			}
			string empty;
			if (!TSql80ParserBaseInternal._indexOptionContainerStatementNames.TryGetValue(statement, out empty))
			{
				empty = string.Empty;
			}
			TSql80ParserBaseInternal.ThrowParseErrorException("SQL46057", option, TSqlParserResource.SQL46057Message, new string[]
			{
				text,
				empty
			});
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x00017BF4 File Offset: 0x00015DF4
		protected static void CheckFillFactorRange(Literal value)
		{
			int num;
			if (!int.TryParse(value.Value, NumberStyles.Integer, CultureInfo.InvariantCulture, out num) || num < 1 || num > 100)
			{
				TSql80ParserBaseInternal.ThrowParseErrorException("SQL46060", value, TSqlParserResource.SQL46060Message, new string[]
				{
					value.Value
				});
			}
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x00017C40 File Offset: 0x00015E40
		protected static void CheckIdentifierLength(Identifier value)
		{
			if (value.Value.Length > 128)
			{
				TSql80ParserBaseInternal.ThrowParseErrorException("SQL46095", value, TSqlParserResource.SQL46095Message, new string[]
				{
					value.Value.Substring(0, 128)
				});
			}
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x00017C8C File Offset: 0x00015E8C
		protected static void CheckIdentifierLiteralLength(IdentifierLiteral value)
		{
			if (value.Value.Length > 128)
			{
				TSql80ParserBaseInternal.ThrowParseErrorException("SQL46095", value, TSqlParserResource.SQL46095Message, new string[]
				{
					value.Value.Substring(0, 128)
				});
			}
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x00017CD8 File Offset: 0x00015ED8
		protected static void ThrowIfPercentValueOutOfRange(ScalarExpression expr)
		{
			if (expr is ParenthesisExpression)
			{
				ParenthesisExpression parenthesisExpression = expr as ParenthesisExpression;
				if (parenthesisExpression != null)
				{
					TSql80ParserBaseInternal.ThrowIfPercentValueOutOfRange(parenthesisExpression.Expression);
					return;
				}
			}
			else if (expr is UnaryExpression)
			{
				UnaryExpression unaryExpression = expr as UnaryExpression;
				if (unaryExpression != null)
				{
					if (unaryExpression.UnaryExpressionType == UnaryExpressionType.Negative)
					{
						TSql80ParserBaseInternal.ThrowParseErrorException("SQL46094", expr, TSqlParserResource.SQL46094Message, new string[0]);
						return;
					}
					TSql80ParserBaseInternal.ThrowIfPercentValueOutOfRange(unaryExpression.Expression);
					return;
				}
			}
			else
			{
				Literal literal = expr as Literal;
				double num;
				if (literal != null && (literal.LiteralType == LiteralType.Real || literal.LiteralType == LiteralType.Numeric || literal.LiteralType == LiteralType.Integer) && (!double.TryParse(literal.Value, NumberStyles.Float, CultureInfo.InvariantCulture, out num) || num < 0.0 || num > 100.0))
				{
					TSql80ParserBaseInternal.ThrowParseErrorException("SQL46094", expr, TSqlParserResource.SQL46094Message, new string[0]);
				}
			}
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x00017DB5 File Offset: 0x00015FB5
		protected static void VerifyAllowedIndexOption(IndexAffectingStatement statement, IndexOption option)
		{
			TSql80ParserBaseInternal.VerifyAllowedIndexOption(statement, option, SqlVersionFlags.None);
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x00017DC0 File Offset: 0x00015FC0
		protected static void VerifyAllowedIndexOption(IndexAffectingStatement statement, IndexOption option, SqlVersionFlags versionFlags)
		{
			bool flag = false;
			if (option.OptionKind == IndexOptionKind.FileStreamOn && statement != IndexAffectingStatement.AlterTableAddElement)
			{
				flag = true;
			}
			if (option.OptionKind == IndexOptionKind.BucketCount && !TSql80ParserBaseInternal.StatementsWithBucketCount.Contains(statement))
			{
				flag = true;
			}
			if (option.OptionKind == IndexOptionKind.DataCompression && (versionFlags & SqlVersionFlags.TSql120) == SqlVersionFlags.None)
			{
				DataCompressionOption dataCompressionOption = option as DataCompressionOption;
				if (dataCompressionOption.CompressionLevel == DataCompressionLevel.ColumnStore || dataCompressionOption.CompressionLevel == DataCompressionLevel.ColumnStoreArchive)
				{
					flag = true;
				}
			}
			switch (statement)
			{
			case IndexAffectingStatement.AlterTableAddElement:
				if (option.OptionKind == IndexOptionKind.DropExisting || option.OptionKind == IndexOptionKind.LobCompaction)
				{
					flag = true;
				}
				break;
			case IndexAffectingStatement.AlterTableRebuildOnePartition:
			case IndexAffectingStatement.AlterIndexRebuildOnePartition:
				if (option.OptionKind != IndexOptionKind.SortInTempDB && option.OptionKind != IndexOptionKind.MaxDop && option.OptionKind != IndexOptionKind.DataCompression && (option.OptionKind != IndexOptionKind.Online || (versionFlags & SqlVersionFlags.TSql120) == SqlVersionFlags.None))
				{
					flag = true;
				}
				break;
			case IndexAffectingStatement.AlterTableRebuildAllPartitions:
			case IndexAffectingStatement.AlterIndexRebuildAllPartitions:
				if (option.OptionKind == IndexOptionKind.DropExisting || option.OptionKind == IndexOptionKind.LobCompaction)
				{
					flag = true;
				}
				break;
			case IndexAffectingStatement.AlterIndexSet:
				if (option.OptionKind != IndexOptionKind.AllowRowLocks && option.OptionKind != IndexOptionKind.AllowPageLocks && option.OptionKind != IndexOptionKind.IgnoreDupKey && option.OptionKind != IndexOptionKind.StatisticsNoRecompute)
				{
					flag = true;
				}
				break;
			case IndexAffectingStatement.AlterIndexReorganize:
				if (option.OptionKind != IndexOptionKind.LobCompaction)
				{
					flag = true;
				}
				break;
			case IndexAffectingStatement.CreateColumnStoreIndex:
				if (option.OptionKind == IndexOptionKind.DataCompression)
				{
					DataCompressionOption dataCompressionOption2 = option as DataCompressionOption;
					if ((versionFlags & SqlVersionFlags.TSql120) == SqlVersionFlags.None || dataCompressionOption2.CompressionLevel == DataCompressionLevel.None || dataCompressionOption2.CompressionLevel == DataCompressionLevel.Row || dataCompressionOption2.CompressionLevel == DataCompressionLevel.Page)
					{
						flag = true;
					}
				}
				else if (option.OptionKind != IndexOptionKind.DropExisting && option.OptionKind != IndexOptionKind.MaxDop)
				{
					flag = true;
				}
				break;
			case IndexAffectingStatement.CreateIndex:
			case IndexAffectingStatement.CreateTableInlineIndex:
				if (option.OptionKind == IndexOptionKind.LobCompaction)
				{
					flag = true;
				}
				else if (option.OptionKind == IndexOptionKind.DataCompression)
				{
					DataCompressionOption dataCompressionOption3 = option as DataCompressionOption;
					if (dataCompressionOption3.CompressionLevel == DataCompressionLevel.ColumnStore || dataCompressionOption3.CompressionLevel == DataCompressionLevel.ColumnStoreArchive)
					{
						flag = true;
					}
				}
				break;
			case IndexAffectingStatement.CreateTable:
			case IndexAffectingStatement.CreateOrAlterFunction:
			case IndexAffectingStatement.DeclareTableVariable:
				if (option.OptionKind == IndexOptionKind.SortInTempDB || option.OptionKind == IndexOptionKind.Online || option.OptionKind == IndexOptionKind.MaxDop || option.OptionKind == IndexOptionKind.LobCompaction || option.OptionKind == IndexOptionKind.DropExisting)
				{
					flag = true;
				}
				else if (option.OptionKind == IndexOptionKind.DataCompression)
				{
					DataCompressionOption dataCompressionOption4 = option as DataCompressionOption;
					if (dataCompressionOption4.CompressionLevel == DataCompressionLevel.ColumnStore || dataCompressionOption4.CompressionLevel == DataCompressionLevel.ColumnStoreArchive)
					{
						flag = true;
					}
				}
				break;
			case IndexAffectingStatement.CreateType:
				if (option.OptionKind != IndexOptionKind.IgnoreDupKey && option.OptionKind != IndexOptionKind.BucketCount)
				{
					flag = true;
				}
				break;
			case IndexAffectingStatement.CreateXmlIndex:
				if (option.OptionKind == IndexOptionKind.DataCompression || option.OptionKind == IndexOptionKind.LobCompaction)
				{
					flag = true;
				}
				else if (option.OptionKind == IndexOptionKind.IgnoreDupKey)
				{
					IndexStateOption indexStateOption = option as IndexStateOption;
					if (indexStateOption != null)
					{
						flag = (indexStateOption.OptionState == OptionState.On);
					}
				}
				break;
			case IndexAffectingStatement.CreateSpatialIndex:
				if (option.OptionKind == IndexOptionKind.DataCompression)
				{
					DataCompressionOption dataCompressionOption5 = option as DataCompressionOption;
					if ((versionFlags & SqlVersionFlags.TSql110AndAbove) == SqlVersionFlags.None || dataCompressionOption5.CompressionLevel == DataCompressionLevel.ColumnStore || dataCompressionOption5.CompressionLevel == DataCompressionLevel.ColumnStoreArchive)
					{
						flag = true;
					}
				}
				else if (option.OptionKind == IndexOptionKind.LobCompaction || option.OptionKind == IndexOptionKind.FileStreamOn)
				{
					flag = true;
				}
				break;
			}
			if (flag)
			{
				TSql80ParserBaseInternal.ThrowWrongIndexOptionError(statement, option);
			}
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x000180E4 File Offset: 0x000162E4
		protected static void ThrowSyntaxErrorIfNotCreateAlterTable(IndexAffectingStatement statement, IToken atToken)
		{
			if (statement != IndexAffectingStatement.CreateTable && statement != IndexAffectingStatement.AlterTableAddElement)
			{
				TSql80ParserBaseInternal.ThrowIncorrectSyntaxErrorException(atToken);
			}
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x000180F4 File Offset: 0x000162F4
		protected static FunctionOptionKind ParseAlterCreateFunctionWithOption(IToken token)
		{
			string a;
			if ((a = token.getText().ToUpperInvariant()) != null)
			{
				if (a == "ENCRYPTION")
				{
					return FunctionOptionKind.Encryption;
				}
				if (a == "SCHEMABINDING")
				{
					return FunctionOptionKind.SchemaBinding;
				}
			}
			throw new TSqlParseErrorException(TSql80ParserBaseInternal.CreateParseError("SQL46026", token, TSqlParserResource.SQL46026Message, new string[]
			{
				token.getText()
			}));
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x00018158 File Offset: 0x00016358
		protected static StatisticsOptionKind ParseCreateStatisticsWithOption(IToken token)
		{
			string a;
			if ((a = token.getText().ToUpperInvariant()) != null)
			{
				if (a == "FULLSCAN")
				{
					return StatisticsOptionKind.FullScan;
				}
				if (a == "NORECOMPUTE")
				{
					return StatisticsOptionKind.NoRecompute;
				}
			}
			throw new TSqlParseErrorException(TSql80ParserBaseInternal.CreateParseError("SQL46018", token, TSqlParserResource.SQL46018Message, new string[]
			{
				token.getText()
			}));
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x000181BC File Offset: 0x000163BC
		protected static StatisticsOptionKind ParseSampleOptionsWithOption(IToken token)
		{
			if (string.Compare("ROWS", token.getText(), StringComparison.OrdinalIgnoreCase) == 0)
			{
				return StatisticsOptionKind.SampleRows;
			}
			throw new TSqlParseErrorException(TSql80ParserBaseInternal.CreateParseError("SQL46019", token, TSqlParserResource.SQL46019Message, new string[]
			{
				token.getText()
			}));
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x00018204 File Offset: 0x00016404
		protected static TriggerEnforcement ParseTriggerEnforcement(IToken token)
		{
			string a;
			if ((a = token.getText().ToUpperInvariant()) != null)
			{
				if (a == "ENABLE")
				{
					return TriggerEnforcement.Enable;
				}
				if (a == "DISABLE")
				{
					return TriggerEnforcement.Disable;
				}
			}
			throw new NoViableAltException(token, token.getFilename());
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x0001824C File Offset: 0x0001644C
		protected static void CheckSpecialColumn(ColumnReferenceExpression column)
		{
			if (column.ColumnType != ColumnType.Regular && column.MultiPartIdentifier != null && column.MultiPartIdentifier.Count >= 4)
			{
				throw new TSqlParseErrorException(TSql80ParserBaseInternal.CreateParseError("SQL46028", TSql80ParserBaseInternal.GetFirstToken(column), TSqlParserResource.SQL46028Message, new string[0]));
			}
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x00018298 File Offset: 0x00016498
		protected static void CheckStarQualifier(SelectStarExpression column)
		{
			if (column.Qualifier != null)
			{
				int count = column.Qualifier.Count;
				if (count >= 4)
				{
					throw new TSqlParseErrorException(TSql80ParserBaseInternal.CreateParseError("SQL46028", TSql80ParserBaseInternal.GetFirstToken(column), TSqlParserResource.SQL46028Message, new string[0]));
				}
				if (count == 0 || (count >= 1 && !string.IsNullOrEmpty(column.Qualifier[count - 1].Value)))
				{
					return;
				}
				TSql80ParserBaseInternal.ThrowParseErrorException("SQL46016", column, TSqlParserResource.SQL46016Message, new string[0]);
			}
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x00018318 File Offset: 0x00016518
		protected static void CheckTableNameExistsForColumn(ColumnReferenceExpression column, bool multiPartRequisite)
		{
			int num = (column.MultiPartIdentifier == null) ? 0 : column.MultiPartIdentifier.Count;
			if (!multiPartRequisite && ((column.ColumnType == ColumnType.Regular && num == 1) || (column.ColumnType != ColumnType.Regular && num == 0)))
			{
				return;
			}
			bool flag = false;
			if (column.ColumnType == ColumnType.Regular)
			{
				if (num >= 2 && !string.IsNullOrEmpty(column.MultiPartIdentifier[num - 2].Value))
				{
					flag = true;
				}
			}
			else if (num >= 1 && !string.IsNullOrEmpty(column.MultiPartIdentifier[num - 1].Value))
			{
				flag = true;
			}
			if (!flag)
			{
				TSql80ParserBaseInternal.ThrowParseErrorException("SQL46016", column, TSqlParserResource.SQL46016Message, new string[0]);
			}
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x000183BC File Offset: 0x000165BC
		protected static void CheckTwoPartNameForSchemaObjectName(SchemaObjectName name, string statementType)
		{
			if (name.DatabaseIdentifier != null && !string.IsNullOrEmpty(name.DatabaseIdentifier.Value))
			{
				throw new TSqlParseErrorException(TSql80ParserBaseInternal.CreateParseError("SQL46021", TSql80ParserBaseInternal.GetFirstToken(name), TSqlParserResource.SQL46021Message, new string[]
				{
					statementType
				}));
			}
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x0001840A File Offset: 0x0001660A
		protected static void CheckIfValidLanguageString(Literal inputString)
		{
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x0001840C File Offset: 0x0001660C
		protected static void CheckIfValidLanguageIdentifier(Identifier inputString)
		{
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x0001840E File Offset: 0x0001660E
		protected static void CheckIfValidLanguageInteger(Literal inputValue)
		{
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x00018410 File Offset: 0x00016610
		protected static void CheckIfValidLanguageHex(Literal inputValue)
		{
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x00018412 File Offset: 0x00016612
		protected static bool IsStopAtBeforeMarkRestoreOption(IToken token)
		{
			return TSql80ParserBaseInternal.TryMatch(token, "STOPATMARK") || TSql80ParserBaseInternal.TryMatch(token, "STOPBEFOREMARK");
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x00018430 File Offset: 0x00016630
		protected StopRestoreOption CreateStopRestoreOption(IToken optionBeginning, ValueExpression mark, ValueExpression afterClause)
		{
			StopRestoreOption stopRestoreOption = this.FragmentFactory.CreateFragment<StopRestoreOption>();
			if (TSql80ParserBaseInternal.TryMatch(optionBeginning, "STOPATMARK"))
			{
				stopRestoreOption.IsStopAt = true;
				stopRestoreOption.OptionKind = RestoreOptionKind.StopAt;
			}
			else
			{
				stopRestoreOption.OptionKind = RestoreOptionKind.Stop;
			}
			stopRestoreOption.Mark = mark;
			if (afterClause != null)
			{
				stopRestoreOption.After = afterClause;
			}
			return stopRestoreOption;
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x00018484 File Offset: 0x00016684
		protected ScalarExpressionRestoreOption CreateSimpleRestoreOptionWithValue(IToken optionBeginning, ScalarExpression optionValue)
		{
			ScalarExpressionRestoreOption scalarExpressionRestoreOption = this.FragmentFactory.CreateFragment<ScalarExpressionRestoreOption>();
			scalarExpressionRestoreOption.OptionKind = RestoreOptionWithValueHelper.Instance.ParseOption(optionBeginning);
			scalarExpressionRestoreOption.Value = optionValue;
			return scalarExpressionRestoreOption;
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x000184B8 File Offset: 0x000166B8
		protected void CreateInternalError(string entryPoint, Exception exception)
		{
			string sql46001Message = TSqlParserResource.SQL46001Message;
			ParseError parseError = new ParseError(46001, this._tokenSource.LastToken.Offset, this._tokenSource.LastToken.Line, this._tokenSource.LastToken.Column, sql46001Message);
			this.AddParseError(parseError);
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x00018510 File Offset: 0x00016710
		protected void SetFunctionBodyStatement(FunctionStatementBody parent, BeginEndBlockStatement compoundStatement)
		{
			if (compoundStatement != null)
			{
				StatementList statementList = this.FragmentFactory.CreateFragment<StatementList>();
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<TSqlStatement>(statementList, statementList.Statements, compoundStatement);
				parent.StatementList = statementList;
			}
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x00018540 File Offset: 0x00016740
		protected static void AddConstraintToColumn(ConstraintDefinition constraint, ColumnDefinition column)
		{
			DefaultConstraintDefinition defaultConstraintDefinition = constraint as DefaultConstraintDefinition;
			if (defaultConstraintDefinition != null)
			{
				if (column.DefaultConstraint != null)
				{
					TSql80ParserBaseInternal.ThrowParseErrorException("SQL46012", constraint, TSqlParserResource.SQL46012Message, new string[0]);
				}
				column.DefaultConstraint = defaultConstraintDefinition;
				return;
			}
			TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ConstraintDefinition>(column, column.Constraints, constraint);
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x0001858C File Offset: 0x0001678C
		protected void PutIdentifiersIntoFunctionCall(FunctionCall functionCall, MultiPartIdentifier identifiers)
		{
			int count = identifiers.Count;
			functionCall.FunctionName = identifiers[count - 1];
			if (count > 1)
			{
				MultiPartIdentifierCallTarget multiPartIdentifierCallTarget = this.FragmentFactory.CreateFragment<MultiPartIdentifierCallTarget>();
				MultiPartIdentifier multiPartIdentifier = this.FragmentFactory.CreateFragment<MultiPartIdentifier>();
				for (int i = 0; i < count - 1; i++)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<Identifier>(multiPartIdentifier, multiPartIdentifier.Identifiers, identifiers[i]);
				}
				multiPartIdentifierCallTarget.MultiPartIdentifier = multiPartIdentifier;
				functionCall.CallTarget = multiPartIdentifierCallTarget;
			}
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x000185FA File Offset: 0x000167FA
		protected void VerifyColumnDataType(ColumnDefinition column)
		{
			if (column.DataType == null && !string.Equals(column.ColumnIdentifier.Value, "TIMESTAMP", StringComparison.OrdinalIgnoreCase))
			{
				throw this.GetUnexpectedTokenErrorException();
			}
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x00018624 File Offset: 0x00016824
		protected void CreateSetClauseColumn(AssignmentSetClause setClause, MultiPartIdentifier multiPartIdentifier)
		{
			ColumnReferenceExpression columnReferenceExpression = this.FragmentFactory.CreateFragment<ColumnReferenceExpression>();
			columnReferenceExpression.ColumnType = ColumnType.Regular;
			columnReferenceExpression.MultiPartIdentifier = multiPartIdentifier;
			setClause.Column = columnReferenceExpression;
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x00018654 File Offset: 0x00016854
		protected static void ProcessNationalAndVarying(SqlDataTypeReference type, IToken nationalToken, bool isVarying)
		{
			if (nationalToken != null && isVarying)
			{
				if (type.SqlDataTypeOption == SqlDataTypeOption.Char)
				{
					type.SqlDataTypeOption = SqlDataTypeOption.NVarChar;
					return;
				}
				TSql80ParserBaseInternal.ThrowParseErrorException("SQL46002", nationalToken, TSqlParserResource.SQL46002Message, new string[]
				{
					TSql80ParserBaseInternal.GetSqlDataTypeName(type.SqlDataTypeOption)
				});
				return;
			}
			else
			{
				if (nationalToken != null)
				{
					switch (type.SqlDataTypeOption)
					{
					case SqlDataTypeOption.Char:
						type.SqlDataTypeOption = SqlDataTypeOption.NChar;
						return;
					case SqlDataTypeOption.Text:
						type.SqlDataTypeOption = SqlDataTypeOption.NText;
						return;
					}
					TSql80ParserBaseInternal.ThrowParseErrorException("SQL46003", nationalToken, TSqlParserResource.SQL46003Message, new string[]
					{
						TSql80ParserBaseInternal.GetSqlDataTypeName(type.SqlDataTypeOption)
					});
					return;
				}
				if (isVarying)
				{
					SqlDataTypeOption sqlDataTypeOption = type.SqlDataTypeOption;
					if (sqlDataTypeOption == SqlDataTypeOption.Char)
					{
						type.SqlDataTypeOption = SqlDataTypeOption.VarChar;
						return;
					}
					if (sqlDataTypeOption == SqlDataTypeOption.NChar)
					{
						type.SqlDataTypeOption = SqlDataTypeOption.NVarChar;
						return;
					}
					if (sqlDataTypeOption == SqlDataTypeOption.Binary)
					{
						type.SqlDataTypeOption = SqlDataTypeOption.VarBinary;
						return;
					}
					TSql80ParserBaseInternal.ThrowParseErrorException("SQL46004", type, TSqlParserResource.SQL46004Message, new string[]
					{
						TSql80ParserBaseInternal.GetSqlDataTypeName(type.SqlDataTypeOption)
					});
				}
				return;
			}
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x00018758 File Offset: 0x00016958
		protected static string GetSqlDataTypeName(SqlDataTypeOption type)
		{
			if (type == SqlDataTypeOption.None)
			{
				return TSqlParserResource.UserDefined;
			}
			return type.ToString();
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x00018770 File Offset: 0x00016970
		protected static void CheckSqlDataTypeParameters(SqlDataTypeReference dataType)
		{
			switch (dataType.Parameters.Count)
			{
			case 0:
				break;
			case 1:
				if (!TSql80ParserBaseInternal._possibleSingleParameterDataTypes.Contains(dataType.SqlDataTypeOption))
				{
					TSql80ParserBaseInternal.ThrowParseErrorException("SQL46008", dataType, TSqlParserResource.SQL46008Message, new string[]
					{
						dataType.SqlDataTypeOption.ToString()
					});
				}
				if (dataType.Parameters[0].LiteralType == LiteralType.Max && (dataType.SqlDataTypeOption == SqlDataTypeOption.Char || dataType.SqlDataTypeOption == SqlDataTypeOption.NChar || dataType.SqlDataTypeOption == SqlDataTypeOption.Binary))
				{
					TSql80ParserBaseInternal.ThrowIncorrectSyntaxErrorException(TSql80ParserBaseInternal.GetFirstToken(dataType.Parameters[0]));
					return;
				}
				break;
			case 2:
				if (dataType.SqlDataTypeOption != SqlDataTypeOption.Decimal && dataType.SqlDataTypeOption != SqlDataTypeOption.Numeric)
				{
					TSql80ParserBaseInternal.ThrowParseErrorException("SQL46009", dataType, TSqlParserResource.SQL46009Message, new string[]
					{
						dataType.SqlDataTypeOption.ToString()
					});
				}
				break;
			default:
				return;
			}
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x00018860 File Offset: 0x00016A60
		protected bool IsTableReference(bool allowMultipleTableHints)
		{
			if (this.LA(1) != 191)
			{
				return true;
			}
			int pos = this.mark();
			try
			{
				this.consume();
				if ((this.LA(1) == 232 || this.LA(1) == 78) && (this.LA(2) == 192 || allowMultipleTableHints))
				{
					QuoteType quoteType;
					string tokenString = Identifier.DecodeIdentifier(this.LT(1).getText(), out quoteType);
					TableHintKind tableHintKind;
					if (TableHintOptionsHelper.Instance.TryParseOption(tokenString, SqlVersionFlags.TSql80, out tableHintKind))
					{
						return true;
					}
				}
			}
			finally
			{
				this.rewind(pos);
			}
			return false;
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x000188FC File Offset: 0x00016AFC
		internal T ParseRuleWithStandardExceptionHandling<T>(TSql80ParserBaseInternal.ParserEntryPoint<T> entryPoint, string entryPointName) where T : TSqlFragment
		{
			T result = default(T);
			try
			{
				result = entryPoint();
			}
			catch (TSqlParseErrorException ex)
			{
				if (!ex.DoNotLog)
				{
					this.AddParseError(ex.ParseError);
				}
			}
			catch (NoViableAltException ex2)
			{
				ParseError faultTolerantUnexpectedTokenError = TSql80ParserBaseInternal.GetFaultTolerantUnexpectedTokenError(ex2.token, ex2, this._tokenSource.LastToken.Offset);
				this.AddParseError(faultTolerantUnexpectedTokenError);
			}
			catch (MismatchedTokenException ex3)
			{
				ParseError faultTolerantUnexpectedTokenError2 = TSql80ParserBaseInternal.GetFaultTolerantUnexpectedTokenError(ex3.token, ex3, this._tokenSource.LastToken.Offset);
				this.AddParseError(faultTolerantUnexpectedTokenError2);
			}
			catch (RecognitionException)
			{
				ParseError unexpectedTokenError = TSql80ParserBaseInternal.GetUnexpectedTokenError(this.LT(1));
				this.AddParseError(unexpectedTokenError);
			}
			catch (TokenStreamRecognitionException exception)
			{
				ParseError parseError = TSql80ParserBaseInternal.ProcessTokenStreamRecognitionException(exception, this._tokenSource.LastToken.Offset);
				this.AddParseError(parseError);
			}
			catch (ANTLRException exception2)
			{
				this.CreateInternalError(entryPointName, exception2);
			}
			catch (StackOverflowException exception3)
			{
				this.CreateInternalError(entryPointName, exception3);
			}
			catch (NullReferenceException exception4)
			{
				this.CreateInternalError(entryPointName, exception4);
			}
			catch (ArgumentException exception5)
			{
				this.CreateInternalError(entryPointName, exception5);
			}
			catch (IndexOutOfRangeException exception6)
			{
				this.CreateInternalError(entryPointName, exception6);
			}
			return result;
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x00018A8C File Offset: 0x00016C8C
		protected void SetNameForDoublePrecisionType(DataTypeReference dataType, IToken doubleToken, IToken precisionToken)
		{
			Identifier identifier = this.FragmentFactory.CreateFragment<Identifier>();
			identifier.Value = "FLOAT";
			TSql80ParserBaseInternal.UpdateTokenInfo(identifier, doubleToken);
			TSql80ParserBaseInternal.UpdateTokenInfo(identifier, precisionToken);
			dataType.Name = this.FragmentFactory.CreateFragment<SchemaObjectName>();
			TSql80ParserBaseInternal.AddAndUpdateTokenInfo<Identifier>(dataType.Name, dataType.Name.Identifiers, identifier);
			TSql80ParserBaseInternal.UpdateTokenInfo(dataType, doubleToken);
			TSql80ParserBaseInternal.UpdateTokenInfo(dataType, precisionToken);
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x00018AF4 File Offset: 0x00016CF4
		protected static void CheckForTemporaryFunction(SchemaObjectName name)
		{
			if (name.BaseIdentifier != null && name.BaseIdentifier.Value != null && name.BaseIdentifier.Value.StartsWith("#", StringComparison.Ordinal))
			{
				TSql80ParserBaseInternal.ThrowParseErrorException("SQL46093", name, TSqlParserResource.SQL46093Message, new string[]
				{
					name.BaseIdentifier.Value
				});
			}
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x00018B54 File Offset: 0x00016D54
		protected static void CheckForTemporaryView(SchemaObjectName name)
		{
			if (name.BaseIdentifier != null && name.BaseIdentifier.Value != null && name.BaseIdentifier.Value.StartsWith("#", StringComparison.Ordinal))
			{
				TSql80ParserBaseInternal.ThrowParseErrorException("SQL46092", name, TSqlParserResource.SQL46092Message, new string[]
				{
					name.BaseIdentifier.Value
				});
			}
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x00018BB4 File Offset: 0x00016DB4
		protected static IToken GetFirstToken(TSqlFragment fragment)
		{
			if (fragment.ScriptTokenStream != null && fragment.FirstTokenIndex != -1)
			{
				return fragment.ScriptTokenStream[fragment.FirstTokenIndex];
			}
			return null;
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x00018BDA File Offset: 0x00016DDA
		public static void ThrowParseErrorException(string identifier, TSqlFragment fragment, string messageTemplate, params string[] args)
		{
			TSql80ParserBaseInternal.ThrowParseErrorException(identifier, TSql80ParserBaseInternal.GetFirstToken(fragment), messageTemplate, args);
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x00018BEC File Offset: 0x00016DEC
		public static void ThrowParseErrorException(string identifier, IToken token, string messageTemplate, params string[] args)
		{
			ParseError error = TSql80ParserBaseInternal.CreateParseError(identifier, token, messageTemplate, args);
			throw new TSqlParseErrorException(error);
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x00018C0C File Offset: 0x00016E0C
		public static ParseError CreateParseError(string identifier, IToken token, string messageTemplate, params string[] args)
		{
			TSqlWhitespaceTokenFilter.TSqlParserTokenProxyWithIndex tsqlParserTokenProxyWithIndex = token as TSqlWhitespaceTokenFilter.TSqlParserTokenProxyWithIndex;
			int line;
			int column;
			int offset;
			if (tsqlParserTokenProxyWithIndex != null)
			{
				line = tsqlParserTokenProxyWithIndex.Token.Line;
				column = tsqlParserTokenProxyWithIndex.Token.Column;
				offset = tsqlParserTokenProxyWithIndex.Token.Offset;
			}
			else
			{
				TSqlParserToken tsqlParserToken = token as TSqlParserToken;
				if (tsqlParserToken != null)
				{
					line = tsqlParserToken.Line;
					column = tsqlParserToken.Column;
					offset = tsqlParserToken.Offset;
				}
				else
				{
					line = 1;
					column = 1;
					offset = 0;
				}
			}
			return TSql80ParserBaseInternal.CreateParseError(identifier, offset, line, column, messageTemplate, args);
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x00018C80 File Offset: 0x00016E80
		public static ParseError CreateParseError(string identifier, int offset, int line, int column, string messageTemplate, params string[] args)
		{
			return new ParseError(int.Parse(identifier.Substring(3), CultureInfo.InvariantCulture), offset, line, column, string.Format(CultureInfo.CurrentCulture, messageTemplate, args));
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x00018CAC File Offset: 0x00016EAC
		internal static ParseError ProcessTokenStreamRecognitionException(TokenStreamRecognitionException exception, int lastOffset)
		{
			NoViableAltException ex = exception.recog as NoViableAltException;
			if (ex != null)
			{
				return TSql80ParserBaseInternal.GetFaultTolerantUnexpectedTokenError(ex.token, ex, lastOffset);
			}
			MismatchedTokenException ex2 = exception.recog as MismatchedTokenException;
			if (ex2 != null)
			{
				return TSql80ParserBaseInternal.GetFaultTolerantUnexpectedTokenError(ex2.token, ex2, lastOffset);
			}
			NoViableAltForCharException ex3 = exception.recog as NoViableAltForCharException;
			if (ex3 != null)
			{
				return TSql80ParserBaseInternal.CreateParseError("SQL46010", lastOffset, ex3.getLine(), ex3.getColumn(), TSqlParserResource.SQL46010Message, new string[]
				{
					ex3.foundChar.ToString()
				});
			}
			return new ParseError(46001, lastOffset, exception.recog.getLine(), exception.recog.getColumn(), TSqlParserResource.SQL46001Message);
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x00018D5B File Offset: 0x00016F5B
		internal static ParseError GetFaultTolerantUnexpectedTokenError(IToken token, RecognitionException exception, int lastOffset)
		{
			if (token == null)
			{
				return new ParseError(46001, lastOffset, exception.getLine(), exception.getColumn(), TSqlParserResource.SQL46001Message);
			}
			return TSql80ParserBaseInternal.GetUnexpectedTokenError(token);
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x00018D84 File Offset: 0x00016F84
		public static ParseError GetIncorrectSyntaxError(IToken token)
		{
			return TSql80ParserBaseInternal.CreateParseError("SQL46010", token, TSqlParserResource.SQL46010Message, new string[]
			{
				token.getText()
			});
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x00018DB2 File Offset: 0x00016FB2
		public static void ThrowIncorrectSyntaxErrorException(TSqlFragment fragment)
		{
			TSql80ParserBaseInternal.ThrowIncorrectSyntaxErrorException(TSql80ParserBaseInternal.GetFirstToken(fragment));
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x00018DC0 File Offset: 0x00016FC0
		public static void ThrowIncorrectSyntaxErrorException(IToken token)
		{
			ParseError incorrectSyntaxError = TSql80ParserBaseInternal.GetIncorrectSyntaxError(token);
			throw new TSqlParseErrorException(incorrectSyntaxError);
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x00018DDA File Offset: 0x00016FDA
		protected TSqlParseErrorException GetUnexpectedTokenErrorException()
		{
			return TSql80ParserBaseInternal.GetUnexpectedTokenErrorException(this.LT(1));
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x00018DE8 File Offset: 0x00016FE8
		protected ParseError GetUnexpectedTokenError()
		{
			return TSql80ParserBaseInternal.GetUnexpectedTokenError(this.LT(1));
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x00018DF8 File Offset: 0x00016FF8
		internal static ParseError GetUnexpectedTokenError(IToken token)
		{
			ParseError result;
			if (token.Type == 1)
			{
				result = TSql80ParserBaseInternal.CreateParseError("SQL46029", token, TSqlParserResource.SQL46029Message, new string[0]);
			}
			else
			{
				result = TSql80ParserBaseInternal.GetIncorrectSyntaxError(token);
			}
			return result;
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x00018E30 File Offset: 0x00017030
		internal static TSqlParseErrorException GetUnexpectedTokenErrorException(IToken token)
		{
			ParseError unexpectedTokenError = TSql80ParserBaseInternal.GetUnexpectedTokenError(token);
			return new TSqlParseErrorException(unexpectedTokenError);
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x00018E4C File Offset: 0x0001704C
		protected static TSqlParseErrorException GetUnexpectedTokenErrorException(Identifier identifier)
		{
			string text;
			if (identifier.QuoteType != QuoteType.NotQuoted)
			{
				text = Identifier.EncodeIdentifier(identifier.Value);
			}
			else
			{
				text = identifier.Value;
			}
			return new TSqlParseErrorException(TSql80ParserBaseInternal.CreateParseError("SQL46010", TSql80ParserBaseInternal.GetFirstToken(identifier), TSqlParserResource.SQL46010Message, new string[]
			{
				text
			}));
		}

		// Token: 0x04000E51 RID: 3665
		private const int LookAhead = 2;

		// Token: 0x04000E52 RID: 3666
		private readonly TSqlFragmentFactory _fragmentFactory = new TSqlFragmentFactory();

		// Token: 0x04000E53 RID: 3667
		private IList<ParseError> _parseErrors;

		// Token: 0x04000E54 RID: 3668
		private bool _phaseOne;

		// Token: 0x04000E55 RID: 3669
		protected TSqlWhitespaceTokenFilter _tokenSource;

		// Token: 0x04000E56 RID: 3670
		private bool _initialQuotedIdentifiersOn = true;

		// Token: 0x04000E57 RID: 3671
		private int _phaseOnePreviousStatementLevelErrorLine = -1;

		// Token: 0x04000E58 RID: 3672
		private int _phaseOnePreviousStatementLevelErrorColumn = -1;

		// Token: 0x04000E59 RID: 3673
		private static readonly BitSet _statementLevelRecoveryTokens = new BitSet(4);

		// Token: 0x04000E5A RID: 3674
		private static readonly BitSet _phaseOneBatchLevelRecoveryTokens = new BitSet(3);

		// Token: 0x04000E5B RID: 3675
		private static readonly BitSet _ddlStatementBeginnerTokens = new BitSet(2);

		// Token: 0x04000E5C RID: 3676
		private static HashSet<SqlDataTypeOption> _possibleSingleParameterDataTypes = new HashSet<SqlDataTypeOption>
		{
			SqlDataTypeOption.Char,
			SqlDataTypeOption.VarChar,
			SqlDataTypeOption.NChar,
			SqlDataTypeOption.NVarChar,
			SqlDataTypeOption.Decimal,
			SqlDataTypeOption.Float,
			SqlDataTypeOption.Numeric,
			SqlDataTypeOption.Binary,
			SqlDataTypeOption.VarBinary,
			SqlDataTypeOption.Time,
			SqlDataTypeOption.DateTime2,
			SqlDataTypeOption.DateTimeOffset
		};

		// Token: 0x04000E5D RID: 3677
		private static Dictionary<IndexAffectingStatement, string> _indexOptionContainerStatementNames = new Dictionary<IndexAffectingStatement, string>
		{
			{
				IndexAffectingStatement.AlterTableAddElement,
				"ALTER TABLE"
			},
			{
				IndexAffectingStatement.AlterTableRebuildAllPartitions,
				"ALTER TABLE REBUILD PARTITION"
			},
			{
				IndexAffectingStatement.AlterTableRebuildOnePartition,
				"ALTER TABLE REBUILD PARTITION"
			},
			{
				IndexAffectingStatement.AlterIndexRebuildAllPartitions,
				"ALTER INDEX REBUILD PARTITION"
			},
			{
				IndexAffectingStatement.AlterIndexRebuildOnePartition,
				"ALTER INDEX REBUILD PARTITION"
			},
			{
				IndexAffectingStatement.AlterIndexSet,
				"ALTER INDEX"
			},
			{
				IndexAffectingStatement.AlterIndexReorganize,
				"ALTER INDEX REORGANIZE"
			},
			{
				IndexAffectingStatement.CreateColumnStoreIndex,
				"CREATE COLUMNSTORE INDEX"
			},
			{
				IndexAffectingStatement.CreateIndex,
				"CREATE INDEX"
			},
			{
				IndexAffectingStatement.CreateTable,
				"CREATE TABLE"
			},
			{
				IndexAffectingStatement.CreateTableInlineIndex,
				"CREATE TABLE (inline index)"
			},
			{
				IndexAffectingStatement.CreateType,
				"CREATE TYPE"
			},
			{
				IndexAffectingStatement.CreateXmlIndex,
				"CREATE XML INDEX"
			},
			{
				IndexAffectingStatement.CreateOrAlterFunction,
				"CREATE/ALTER FUNCTION"
			},
			{
				IndexAffectingStatement.DeclareTableVariable,
				"DECLARE"
			},
			{
				IndexAffectingStatement.CreateSpatialIndex,
				"CREATE SPATIAL INDEX"
			}
		};

		// Token: 0x04000E5E RID: 3678
		private static readonly List<IndexAffectingStatement> StatementsWithBucketCount = new List<IndexAffectingStatement>
		{
			IndexAffectingStatement.CreateTable,
			IndexAffectingStatement.CreateTableInlineIndex,
			IndexAffectingStatement.CreateType
		};

		// Token: 0x0200016A RID: 362
		// (Invoke) Token: 0x06000A2B RID: 2603
		internal delegate T ParserEntryPoint<T>() where T : TSqlFragment;
	}
}
