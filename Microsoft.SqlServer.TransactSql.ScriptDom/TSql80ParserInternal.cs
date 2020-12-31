using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using antlr;
using antlr.collections.impl;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001B8 RID: 440
	internal class TSql80ParserInternal : TSql80ParserBaseInternal
	{
		// Token: 0x06001216 RID: 4630 RVA: 0x0004B16F File Offset: 0x0004936F
		public TSql80ParserInternal(bool initialQuotedIdentifiersOn) : base(initialQuotedIdentifiersOn)
		{
			this.initialize();
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x0004B17E File Offset: 0x0004937E
		protected void initialize()
		{
			this.tokenNames = TSql80ParserInternal.tokenNames_;
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x0004B18B File Offset: 0x0004938B
		protected TSql80ParserInternal(TokenBuffer tokenBuf, int k) : base(tokenBuf, k)
		{
			this.initialize();
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x0004B19B File Offset: 0x0004939B
		public TSql80ParserInternal(TokenBuffer tokenBuf) : this(tokenBuf, 2)
		{
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x0004B1A5 File Offset: 0x000493A5
		protected TSql80ParserInternal(TokenStream lexer, int k) : base(lexer, k)
		{
			this.initialize();
		}

		// Token: 0x0600121B RID: 4635 RVA: 0x0004B1B5 File Offset: 0x000493B5
		public TSql80ParserInternal(TokenStream lexer) : this(lexer, 2)
		{
		}

		// Token: 0x0600121C RID: 4636 RVA: 0x0004B1BF File Offset: 0x000493BF
		public TSql80ParserInternal(ParserSharedInputState state) : base(state, 2)
		{
			this.initialize();
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x0004B1D0 File Offset: 0x000493D0
		public ChildObjectName entryPointChildObjectName()
		{
			ChildObjectName result = this.childObjectNameWithThreePrefixes();
			this.match(1);
			return result;
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x0004B1F0 File Offset: 0x000493F0
		public ChildObjectName childObjectNameWithThreePrefixes()
		{
			ChildObjectName childObjectName = base.FragmentFactory.CreateFragment<ChildObjectName>();
			List<Identifier> otherCollection = this.identifierList(4);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<Identifier>(childObjectName, childObjectName.Identifiers, otherCollection);
			}
			return childObjectName;
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x0004B22C File Offset: 0x0004942C
		public SchemaObjectName entryPointSchemaObjectName()
		{
			SchemaObjectName result = this.schemaObjectFourPartName();
			this.match(1);
			return result;
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x0004B24C File Offset: 0x0004944C
		public SchemaObjectName schemaObjectFourPartName()
		{
			SchemaObjectName schemaObjectName = base.FragmentFactory.CreateFragment<SchemaObjectName>();
			List<Identifier> otherCollection = this.identifierList(4);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<Identifier>(schemaObjectName, schemaObjectName.Identifiers, otherCollection);
			}
			return schemaObjectName;
		}

		// Token: 0x06001221 RID: 4641 RVA: 0x0004B288 File Offset: 0x00049488
		public DataTypeReference entryPointScalarDataType()
		{
			DataTypeReference result = this.scalarDataType();
			this.match(1);
			return result;
		}

		// Token: 0x06001222 RID: 4642 RVA: 0x0004B2A8 File Offset: 0x000494A8
		public DataTypeReference scalarDataType()
		{
			SchemaObjectName schemaObjectName = null;
			SqlDataTypeOption sqlDataTypeOption = SqlDataTypeOption.None;
			int num = this.LA(1);
			DataTypeReference result;
			if (num != 53)
			{
				if (num != 96)
				{
					switch (num)
					{
					case 232:
					case 233:
					{
						Identifier identifier = this.identifier();
						if (this.inputState.guessing == 0)
						{
							schemaObjectName = base.FragmentFactory.CreateFragment<SchemaObjectName>();
							TSql80ParserBaseInternal.AddAndUpdateTokenInfo<Identifier>(schemaObjectName, schemaObjectName.Identifiers, identifier);
							sqlDataTypeOption = TSql80ParserBaseInternal.ParseDataType(identifier.Value);
						}
						if (TSql80ParserInternal.tokenSet_0_.member(this.LA(1)) && TSql80ParserInternal.tokenSet_1_.member(this.LA(2)) && sqlDataTypeOption != SqlDataTypeOption.None)
						{
							result = this.sqlDataTypeWithoutNational(schemaObjectName, sqlDataTypeOption);
						}
						else
						{
							if (!TSql80ParserInternal.tokenSet_2_.member(this.LA(1)) || !TSql80ParserInternal.tokenSet_1_.member(this.LA(2)))
							{
								throw new NoViableAltException(this.LT(1), this.getFilename());
							}
							result = this.userDataType(schemaObjectName);
						}
						break;
					}
					default:
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
				}
				else
				{
					result = this.sqlDataTypeWithNational();
				}
			}
			else
			{
				result = this.doubleDataType();
			}
			return result;
		}

		// Token: 0x06001223 RID: 4643 RVA: 0x0004B3C8 File Offset: 0x000495C8
		public ScalarExpression entryPointExpression()
		{
			ScalarExpression result = this.expression();
			this.match(1);
			return result;
		}

		// Token: 0x06001224 RID: 4644 RVA: 0x0004B3E8 File Offset: 0x000495E8
		public ScalarExpression expression()
		{
			return this.expressionWithFlags(ExpressionFlags.None);
		}

		// Token: 0x06001225 RID: 4645 RVA: 0x0004B400 File Offset: 0x00049600
		public BooleanExpression entryPointBooleanExpression()
		{
			BooleanExpression result = this.booleanExpression();
			this.match(1);
			return result;
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x0004B420 File Offset: 0x00049620
		public BooleanExpression booleanExpression()
		{
			return this.booleanExpressionWithFlags(ExpressionFlags.None);
		}

		// Token: 0x06001227 RID: 4647 RVA: 0x0004B438 File Offset: 0x00049638
		public StatementList entryPointStatementList()
		{
			bool flag = false;
			StatementList result = this.statementList(ref flag);
			if (this.inputState.guessing == 0 && flag)
			{
				result = null;
			}
			this.match(1);
			return result;
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x0004B46C File Offset: 0x0004966C
		public StatementList statementList(ref bool vParseErrorOccurred)
		{
			StatementList statementList = base.FragmentFactory.CreateFragment<StatementList>();
			int num = 0;
			while (TSql80ParserInternal.tokenSet_3_.member(this.LA(1)))
			{
				TSqlStatement tsqlStatement = this.statementOptSemi();
				if (this.inputState.guessing == 0)
				{
					if (tsqlStatement != null)
					{
						TSql80ParserBaseInternal.AddAndUpdateTokenInfo<TSqlStatement>(statementList, statementList.Statements, tsqlStatement);
					}
					else
					{
						vParseErrorOccurred = true;
					}
				}
				num++;
			}
			if (num < 1)
			{
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			return statementList;
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x0004B4E4 File Offset: 0x000496E4
		public SelectStatement entryPointSubqueryExpressionWithOptionalCTE()
		{
			SelectStatement result = this.subqueryExpressionAsStatement();
			this.match(1);
			return result;
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x0004B504 File Offset: 0x00049704
		public SelectStatement subqueryExpressionAsStatement()
		{
			SelectStatement selectStatement = base.FragmentFactory.CreateFragment<SelectStatement>();
			QueryExpression queryExpression = this.subqueryExpression();
			if (this.inputState.guessing == 0)
			{
				selectStatement.QueryExpression = queryExpression;
			}
			return selectStatement;
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x0004B53C File Offset: 0x0004973C
		public TSqlFragment entryPointConstantOrIdentifier()
		{
			TSqlFragment result = this.possibleNegativeConstantOrIdentifier();
			this.match(1);
			return result;
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x0004B55C File Offset: 0x0004975C
		public ScalarExpression possibleNegativeConstantOrIdentifier()
		{
			int num = this.LA(1);
			if (num <= 193)
			{
				if (num != 100 && num != 193)
				{
					goto IL_7F;
				}
			}
			else if (num != 199)
			{
				switch (num)
				{
				case 221:
				case 222:
				case 223:
				case 224:
				case 225:
				case 230:
				case 231:
				case 234:
					break;
				case 226:
				case 227:
				case 228:
				case 229:
					goto IL_7F;
				case 232:
				case 233:
					return this.identifierLiteral();
				default:
					goto IL_7F;
				}
			}
			return this.possibleNegativeConstant();
			IL_7F:
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x0004B5FC File Offset: 0x000497FC
		public TSqlFragment entryPointConstantOrIdentifierWithDefault()
		{
			TSqlFragment result = this.possibleNegativeConstantOrIdentifierWithDefault();
			this.match(1);
			return result;
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x0004B61C File Offset: 0x0004981C
		public ScalarExpression possibleNegativeConstantOrIdentifierWithDefault()
		{
			int num = this.LA(1);
			if (num <= 100)
			{
				if (num == 47)
				{
					return this.defaultLiteral();
				}
				if (num != 100)
				{
					goto IL_81;
				}
			}
			else if (num != 193 && num != 199)
			{
				switch (num)
				{
				case 221:
				case 222:
				case 223:
				case 224:
				case 225:
				case 230:
				case 231:
				case 232:
				case 233:
				case 234:
					break;
				case 226:
				case 227:
				case 228:
				case 229:
					goto IL_81;
				default:
					goto IL_81;
				}
			}
			return this.possibleNegativeConstantOrIdentifier();
			IL_81:
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x0004B6C0 File Offset: 0x000498C0
		public TSqlScript script()
		{
			TSqlScript tsqlScript = base.FragmentFactory.CreateFragment<TSqlScript>();
			if (tsqlScript.ScriptTokenStream != null && tsqlScript.ScriptTokenStream.Count > 0)
			{
				tsqlScript.UpdateTokenInfo(0, tsqlScript.ScriptTokenStream.Count - 1);
			}
			TSqlBatch tsqlBatch = this.batch();
			if (this.inputState.guessing == 0 && tsqlBatch != null)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<TSqlBatch>(tsqlScript, tsqlScript.Batches, tsqlBatch);
			}
			while (this.LA(1) == 219)
			{
				this.match(219);
				if (this.inputState.guessing == 0)
				{
					base.ResetQuotedIdentifiersSettingToInitial();
					base.ThrowPartialAstIfPhaseOne(null);
				}
				tsqlBatch = this.batch();
				if (this.inputState.guessing == 0 && tsqlBatch != null)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<TSqlBatch>(tsqlScript, tsqlScript.Batches, tsqlBatch);
				}
			}
			IToken token = this.LT(1);
			this.match(1);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(tsqlScript, token);
			}
			return tsqlScript;
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x0004B7A8 File Offset: 0x000499A8
		public TSqlBatch batch()
		{
			TSqlBatch tsqlBatch = null;
			try
			{
				bool flag = false;
				if ((this.LA(1) == 6 || this.LA(1) == 35) && TSql80ParserInternal.tokenSet_4_.member(this.LA(2)))
				{
					int pos = this.mark();
					flag = true;
					this.inputState.guessing++;
					try
					{
						int num = this.LA(1);
						if (num == 6)
						{
							this.match(6);
							int num2 = this.LA(1);
							if (num2 <= 121)
							{
								if (num2 == 73)
								{
									this.match(73);
									goto IL_1FB;
								}
								switch (num2)
								{
								case 120:
									this.match(120);
									goto IL_1FB;
								case 121:
									this.match(121);
									goto IL_1FB;
								}
							}
							else
							{
								if (num2 == 155)
								{
									this.match(155);
									goto IL_1FB;
								}
								if (num2 == 166)
								{
									this.match(166);
									goto IL_1FB;
								}
							}
							throw new NoViableAltException(this.LT(1), this.getFilename());
						}
						if (num == 35)
						{
							this.match(35);
							int num3 = this.LA(1);
							if (num3 <= 121)
							{
								if (num3 == 47)
								{
									this.match(47);
									goto IL_1FB;
								}
								if (num3 == 73)
								{
									this.match(73);
									goto IL_1FB;
								}
								switch (num3)
								{
								case 120:
									this.match(120);
									goto IL_1FB;
								case 121:
									this.match(121);
									goto IL_1FB;
								}
							}
							else
							{
								switch (num3)
								{
								case 137:
									this.match(137);
									goto IL_1FB;
								case 138:
									break;
								case 139:
									this.match(139);
									goto IL_1FB;
								default:
									if (num3 == 155)
									{
										this.match(155);
										goto IL_1FB;
									}
									if (num3 == 166)
									{
										this.match(166);
										goto IL_1FB;
									}
									break;
								}
							}
							throw new NoViableAltException(this.LT(1), this.getFilename());
						}
						throw new NoViableAltException(this.LT(1), this.getFilename());
						IL_1FB:;
					}
					catch (RecognitionException)
					{
						flag = false;
					}
					this.rewind(pos);
					this.inputState.guessing--;
				}
				if (flag)
				{
					TSqlStatement tsqlStatement = this.lastStatement();
					if (this.inputState.guessing == 0 && tsqlStatement != null)
					{
						if (tsqlBatch == null)
						{
							tsqlBatch = base.FragmentFactory.CreateFragment<TSqlBatch>();
						}
						TSql80ParserBaseInternal.AddAndUpdateTokenInfo<TSqlStatement>(tsqlBatch, tsqlBatch.Statements, tsqlStatement);
					}
				}
				else
				{
					if (!TSql80ParserInternal.tokenSet_5_.member(this.LA(1)) || !TSql80ParserInternal.tokenSet_6_.member(this.LA(2)))
					{
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
					TSqlStatement tsqlStatement = this.optSimpleExecute();
					if (this.inputState.guessing == 0 && tsqlStatement != null)
					{
						base.ThrowPartialAstIfPhaseOne(tsqlStatement);
						if (tsqlBatch == null)
						{
							tsqlBatch = base.FragmentFactory.CreateFragment<TSqlBatch>();
						}
						TSql80ParserBaseInternal.AddAndUpdateTokenInfo<TSqlStatement>(tsqlBatch, tsqlBatch.Statements, tsqlStatement);
					}
					while (TSql80ParserInternal.tokenSet_3_.member(this.LA(1)))
					{
						tsqlStatement = this.statementOptSemi();
						if (this.inputState.guessing == 0 && tsqlStatement != null)
						{
							if (tsqlBatch == null)
							{
								tsqlBatch = base.FragmentFactory.CreateFragment<TSqlBatch>();
							}
							TSql80ParserBaseInternal.AddAndUpdateTokenInfo<TSqlStatement>(tsqlBatch, tsqlBatch.Statements, tsqlStatement);
						}
					}
				}
			}
			catch (TSqlParseErrorException ex)
			{
				if (this.inputState.guessing != 0)
				{
					throw;
				}
				if (!ex.DoNotLog)
				{
					base.AddParseError(ex.ParseError);
				}
				base.RecoverAtBatchLevel();
			}
			catch (NoViableAltException ex2)
			{
				if (this.inputState.guessing != 0)
				{
					throw;
				}
				ParseError faultTolerantUnexpectedTokenError = TSql80ParserBaseInternal.GetFaultTolerantUnexpectedTokenError(ex2.token, ex2, this._tokenSource.LastToken.Offset);
				base.AddParseError(faultTolerantUnexpectedTokenError);
				base.RecoverAtBatchLevel();
			}
			catch (MismatchedTokenException ex3)
			{
				if (this.inputState.guessing != 0)
				{
					throw;
				}
				ParseError faultTolerantUnexpectedTokenError2 = TSql80ParserBaseInternal.GetFaultTolerantUnexpectedTokenError(ex3.token, ex3, this._tokenSource.LastToken.Offset);
				base.AddParseError(faultTolerantUnexpectedTokenError2);
				base.RecoverAtBatchLevel();
			}
			catch (RecognitionException)
			{
				if (this.inputState.guessing != 0)
				{
					throw;
				}
				ParseError unexpectedTokenError = base.GetUnexpectedTokenError();
				base.AddParseError(unexpectedTokenError);
				base.RecoverAtBatchLevel();
			}
			catch (TokenStreamRecognitionException exception)
			{
				if (this.inputState.guessing != 0)
				{
					throw;
				}
				ParseError parseError = TSql80ParserBaseInternal.ProcessTokenStreamRecognitionException(exception, this._tokenSource.LastToken.Offset);
				base.AddParseError(parseError);
				base.RecoverAtBatchLevel();
			}
			catch (ANTLRException exception2)
			{
				if (this.inputState.guessing != 0)
				{
					throw;
				}
				base.CreateInternalError("batch", exception2);
			}
			return tsqlBatch;
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x0004BCD0 File Offset: 0x00049ED0
		public TSqlStatement lastStatement()
		{
			TSqlStatement result;
			if (this.LA(1) == 35 && (this.LA(2) == 120 || this.LA(2) == 121))
			{
				result = this.createProcedureStatement();
			}
			else if (this.LA(1) == 6 && (this.LA(2) == 120 || this.LA(2) == 121))
			{
				result = this.alterProcedureStatement();
			}
			else if (this.LA(1) == 35 && this.LA(2) == 155)
			{
				result = this.createTriggerStatement();
			}
			else if (this.LA(1) == 6 && this.LA(2) == 155)
			{
				result = this.alterTriggerStatement();
			}
			else if (this.LA(1) == 35 && this.LA(2) == 47)
			{
				result = this.createDefaultStatement();
			}
			else if (this.LA(1) == 35 && this.LA(2) == 137)
			{
				result = this.createRuleStatement();
			}
			else if (this.LA(1) == 35 && this.LA(2) == 166)
			{
				result = this.createViewStatement();
			}
			else if (this.LA(1) == 6 && this.LA(2) == 166)
			{
				result = this.alterViewStatement();
			}
			else if (this.LA(1) == 35 && this.LA(2) == 73)
			{
				result = this.createFunctionStatement();
			}
			else if (this.LA(1) == 6 && this.LA(2) == 73)
			{
				result = this.alterFunctionStatement();
			}
			else
			{
				if (this.LA(1) != 35 || this.LA(2) != 139)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				result = this.createSchemaStatement();
			}
			return result;
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x0004BE84 File Offset: 0x0004A084
		public ExecuteStatement optSimpleExecute()
		{
			ExecuteStatement executeStatement = null;
			int num = this.LA(1);
			if (num <= 92)
			{
				if (num <= 35)
				{
					if (num <= 17)
					{
						if (num == 1 || num == 6)
						{
							return executeStatement;
						}
						switch (num)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							return executeStatement;
						}
					}
					else
					{
						switch (num)
						{
						case 22:
						case 23:
							return executeStatement;
						default:
							if (num == 28)
							{
								return executeStatement;
							}
							switch (num)
							{
							case 33:
							case 35:
								return executeStatement;
							}
							break;
						}
					}
				}
				else if (num <= 75)
				{
					switch (num)
					{
					case 44:
					case 45:
					case 46:
					case 48:
					case 49:
					case 54:
						return executeStatement;
					case 47:
					case 50:
					case 51:
					case 52:
					case 53:
						break;
					default:
						switch (num)
						{
						case 60:
						case 61:
						case 64:
							return executeStatement;
						case 62:
						case 63:
							break;
						default:
							switch (num)
							{
							case 74:
							case 75:
								return executeStatement;
							}
							break;
						}
						break;
					}
				}
				else if (num == 82 || num == 86 || num == 92)
				{
					return executeStatement;
				}
			}
			else if (num <= 173)
			{
				if (num <= 119)
				{
					if (num == 95 || num == 106 || num == 119)
					{
						return executeStatement;
					}
				}
				else
				{
					switch (num)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return executeStatement;
					case 124:
					case 127:
					case 128:
					case 130:
					case 133:
					case 135:
					case 136:
					case 137:
					case 139:
					case 141:
						break;
					default:
						switch (num)
						{
						case 156:
						case 160:
						case 161:
						case 162:
							return executeStatement;
						case 157:
						case 158:
						case 159:
							break;
						default:
							switch (num)
							{
							case 167:
							case 170:
							case 172:
							case 173:
								return executeStatement;
							}
							break;
						}
						break;
					}
				}
			}
			else
			{
				if (num > 191)
				{
					if (num != 200)
					{
						switch (num)
						{
						case 219:
						case 220:
							return executeStatement;
						default:
							switch (num)
							{
							case 232:
							case 233:
							case 234:
								break;
							default:
								goto IL_29D;
							}
							break;
						}
					}
					ExecutableProcedureReference executableEntity = this.execProc();
					if (this.inputState.guessing == 0)
					{
						executeStatement = base.FragmentFactory.CreateFragment<ExecuteStatement>();
						ExecuteSpecification executeSpecification = base.FragmentFactory.CreateFragment<ExecuteSpecification>();
						executeSpecification.ExecutableEntity = executableEntity;
						executeStatement.ExecuteSpecification = executeSpecification;
					}
					this.optSingleSemicolon(executeStatement);
					return executeStatement;
				}
				if (num == 176)
				{
					return executeStatement;
				}
				switch (num)
				{
				case 180:
				case 181:
					return executeStatement;
				default:
					if (num == 191)
					{
						return executeStatement;
					}
					break;
				}
			}
			IL_29D:
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x0004C144 File Offset: 0x0004A344
		public TSqlStatement statementOptSemi()
		{
			TSqlStatement tsqlStatement = this.statement();
			this.optSingleSemicolon(tsqlStatement);
			return tsqlStatement;
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x0004C164 File Offset: 0x0004A364
		public TSqlStatement statement()
		{
			TSqlStatement result = null;
			int line = this.LT(1).getLine();
			int column = this.LT(1).getColumn();
			try
			{
				int num = this.LA(1);
				if (num > 95)
				{
					if (num <= 162)
					{
						if (num <= 119)
						{
							if (num == 106)
							{
								result = this.openCursorStatement();
								goto IL_5D4;
							}
							if (num != 119)
							{
								goto IL_451;
							}
							result = this.printStatement();
							goto IL_5D4;
						}
						else
						{
							switch (num)
							{
							case 123:
								result = this.raiseErrorStatements();
								goto IL_5D4;
							case 124:
							case 127:
							case 128:
							case 130:
							case 133:
							case 135:
							case 136:
							case 137:
							case 139:
							case 141:
								goto IL_451;
							case 125:
								result = this.readTextStatement();
								goto IL_5D4;
							case 126:
								result = this.reconfigureStatement();
								goto IL_5D4;
							case 129:
								break;
							case 131:
								result = this.returnStatement();
								goto IL_5D4;
							case 132:
								result = this.revokeStatement80();
								goto IL_5D4;
							case 134:
								result = this.rollbackTransactionStatement();
								goto IL_5D4;
							case 138:
								result = this.saveTransactionStatement();
								goto IL_5D4;
							case 140:
								goto IL_2F5;
							case 142:
								result = this.setStatements();
								goto IL_5D4;
							case 143:
								result = this.setUserStatement();
								goto IL_5D4;
							case 144:
								result = this.shutdownStatement();
								goto IL_5D4;
							default:
								if (num == 156)
								{
									result = this.truncateTableStatement();
									goto IL_5D4;
								}
								switch (num)
								{
								case 161:
									result = this.updateTextStatement();
									goto IL_5D4;
								case 162:
									result = this.useStatement();
									goto IL_5D4;
								default:
									goto IL_451;
								}
								break;
							}
						}
					}
					else if (num <= 176)
					{
						switch (num)
						{
						case 167:
							result = this.waitForStatement();
							goto IL_5D4;
						case 168:
						case 169:
						case 171:
							goto IL_451;
						case 170:
							result = this.whileStatement();
							goto IL_5D4;
						case 172:
							result = this.writeTextStatement();
							goto IL_5D4;
						case 173:
							result = this.diskStatement();
							goto IL_5D4;
						default:
							if (num != 176)
							{
								goto IL_451;
							}
							result = this.revertStatement();
							goto IL_5D4;
						}
					}
					else
					{
						switch (num)
						{
						case 180:
							goto IL_2A1;
						case 181:
							break;
						default:
							if (num == 191)
							{
								goto IL_2F5;
							}
							if (num != 220)
							{
								goto IL_451;
							}
							result = this.labelStatement();
							goto IL_5D4;
						}
					}
					result = this.restoreStatement();
					goto IL_5D4;
					IL_2F5:
					result = this.select();
					goto IL_5D4;
				}
				if (num <= 54)
				{
					if (num <= 23)
					{
						switch (num)
						{
						case 12:
							break;
						case 13:
							result = this.beginStatements();
							goto IL_5D4;
						case 14:
						case 16:
							goto IL_451;
						case 15:
							result = this.breakStatement();
							goto IL_5D4;
						case 17:
							result = this.bulkInsertStatement();
							goto IL_5D4;
						default:
							switch (num)
							{
							case 22:
								result = this.checkpointStatement();
								goto IL_5D4;
							case 23:
								result = this.closeCursorStatement();
								goto IL_5D4;
							default:
								goto IL_451;
							}
							break;
						}
					}
					else
					{
						if (num == 28)
						{
							result = this.commitTransactionStatement();
							goto IL_5D4;
						}
						if (num == 33)
						{
							result = this.continueStatement();
							goto IL_5D4;
						}
						switch (num)
						{
						case 44:
							result = this.dbccStatement();
							goto IL_5D4;
						case 45:
							result = this.deallocateCursorStatement();
							goto IL_5D4;
						case 46:
							result = this.declareStatements();
							goto IL_5D4;
						case 47:
						case 50:
						case 51:
						case 52:
						case 53:
							goto IL_451;
						case 48:
							result = this.deleteStatement();
							goto IL_5D4;
						case 49:
							result = this.denyStatement80();
							goto IL_5D4;
						case 54:
							result = this.dropStatements();
							goto IL_5D4;
						default:
							goto IL_451;
						}
					}
				}
				else if (num <= 75)
				{
					switch (num)
					{
					case 60:
					case 61:
						result = this.executeStatement();
						goto IL_5D4;
					case 62:
					case 63:
						goto IL_451;
					case 64:
						result = this.fetchCursorStatement();
						goto IL_5D4;
					default:
						switch (num)
						{
						case 74:
							result = this.gotoStatement();
							goto IL_5D4;
						case 75:
							result = this.grantStatement80();
							goto IL_5D4;
						default:
							goto IL_451;
						}
						break;
					}
				}
				else
				{
					if (num == 82)
					{
						result = this.ifStatement();
						goto IL_5D4;
					}
					if (num == 92)
					{
						result = this.killStatement();
						goto IL_5D4;
					}
					if (num != 95)
					{
						goto IL_451;
					}
					result = this.lineNoStatement();
					goto IL_5D4;
				}
				IL_2A1:
				result = this.backupStatement();
				goto IL_5D4;
				IL_451:
				if (this.LA(1) == 35 && this.LA(2) == 148)
				{
					result = this.createTableStatement();
				}
				else if (this.LA(1) == 6 && this.LA(2) == 148)
				{
					result = this.alterTableStatement();
				}
				else if (this.LA(1) == 35 && TSql80ParserInternal.tokenSet_7_.member(this.LA(2)))
				{
					result = this.createIndexStatement();
				}
				else if (this.LA(1) == 35 && this.LA(2) == 146)
				{
					result = this.createStatisticsStatement();
				}
				else if (this.LA(1) == 160 && this.LA(2) == 146)
				{
					result = this.updateStatisticsStatement();
				}
				else if (this.LA(1) == 6 && this.LA(2) == 43)
				{
					result = this.alterDatabaseStatements();
				}
				else if (this.LA(1) == 86 && TSql80ParserInternal.tokenSet_8_.member(this.LA(2)))
				{
					result = this.insertStatement();
				}
				else if (this.LA(1) == 160 && TSql80ParserInternal.tokenSet_9_.member(this.LA(2)))
				{
					result = this.updateStatement();
				}
				else if (this.LA(1) == 35 && this.LA(2) == 43)
				{
					result = this.createDatabaseStatement();
				}
				else
				{
					if (this.LA(1) != 86 || this.LA(2) != 17)
					{
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
					result = this.insertBulkStatement();
				}
				IL_5D4:;
			}
			catch (TSqlParseErrorException ex)
			{
				if (this.inputState.guessing != 0)
				{
					throw;
				}
				if (!ex.DoNotLog)
				{
					base.AddParseError(ex.ParseError);
				}
				base.RecoverAtStatementLevel(line, column);
			}
			catch (NoViableAltException ex2)
			{
				if (this.inputState.guessing != 0)
				{
					throw;
				}
				ParseError faultTolerantUnexpectedTokenError = TSql80ParserBaseInternal.GetFaultTolerantUnexpectedTokenError(ex2.token, ex2, this._tokenSource.LastToken.Offset);
				base.AddParseError(faultTolerantUnexpectedTokenError);
				base.RecoverAtStatementLevel(line, column);
			}
			catch (MismatchedTokenException ex3)
			{
				if (this.inputState.guessing != 0)
				{
					throw;
				}
				ParseError faultTolerantUnexpectedTokenError2 = TSql80ParserBaseInternal.GetFaultTolerantUnexpectedTokenError(ex3.token, ex3, this._tokenSource.LastToken.Offset);
				base.AddParseError(faultTolerantUnexpectedTokenError2);
				base.RecoverAtStatementLevel(line, column);
			}
			catch (RecognitionException)
			{
				if (this.inputState.guessing != 0)
				{
					throw;
				}
				ParseError unexpectedTokenError = base.GetUnexpectedTokenError();
				base.AddParseError(unexpectedTokenError);
				base.RecoverAtStatementLevel(line, column);
			}
			catch (TokenStreamRecognitionException exception)
			{
				if (this.inputState.guessing != 0)
				{
					throw;
				}
				ParseError parseError = TSql80ParserBaseInternal.ProcessTokenStreamRecognitionException(exception, this._tokenSource.LastToken.Offset);
				base.AddParseError(parseError);
				base.RecoverAtStatementLevel(line, column);
			}
			catch (ANTLRException exception2)
			{
				if (this.inputState.guessing != 0)
				{
					throw;
				}
				base.CreateInternalError("statement", exception2);
			}
			return result;
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x0004C930 File Offset: 0x0004AB30
		public void optSingleSemicolon(TSqlStatement vParent)
		{
			if (this.LA(1) == 204 && TSql80ParserInternal.tokenSet_10_.member(this.LA(2)))
			{
				IToken token = this.LT(1);
				this.match(204);
				if (this.inputState.guessing == 0 && vParent != null)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token);
					return;
				}
				return;
			}
			else
			{
				if (TSql80ParserInternal.tokenSet_10_.member(this.LA(1)) && TSql80ParserInternal.tokenSet_11_.member(this.LA(2)))
				{
					return;
				}
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x0004C9C8 File Offset: 0x0004ABC8
		public ExecutableProcedureReference execProc()
		{
			ExecutableProcedureReference executableProcedureReference = base.FragmentFactory.CreateFragment<ExecutableProcedureReference>();
			int num = this.LA(1);
			ProcedureReferenceName procedureReference;
			if (num != 200)
			{
				switch (num)
				{
				case 232:
				case 233:
					break;
				case 234:
					procedureReference = this.varObjectReference();
					goto IL_5B;
				default:
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
			}
			procedureReference = this.procObjectReference();
			IL_5B:
			if (this.inputState.guessing == 0)
			{
				executableProcedureReference.ProcedureReference = procedureReference;
			}
			int num2 = this.LA(1);
			if (num2 <= 92)
			{
				if (num2 <= 28)
				{
					if (num2 <= 6)
					{
						if (num2 != 1 && num2 != 6)
						{
							goto IL_326;
						}
						return executableProcedureReference;
					}
					else
					{
						switch (num2)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							return executableProcedureReference;
						case 14:
						case 16:
							goto IL_326;
						default:
							switch (num2)
							{
							case 22:
							case 23:
								return executableProcedureReference;
							default:
								if (num2 != 28)
								{
									goto IL_326;
								}
								return executableProcedureReference;
							}
							break;
						}
					}
				}
				else if (num2 <= 75)
				{
					switch (num2)
					{
					case 33:
					case 35:
						return executableProcedureReference;
					case 34:
						goto IL_326;
					default:
						switch (num2)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							return executableProcedureReference;
						case 47:
							break;
						case 50:
						case 51:
						case 52:
						case 53:
						case 57:
						case 58:
						case 59:
						case 62:
						case 63:
							goto IL_326;
						default:
							switch (num2)
							{
							case 74:
							case 75:
								return executableProcedureReference;
							default:
								goto IL_326;
							}
							break;
						}
						break;
					}
				}
				else
				{
					if (num2 != 82 && num2 != 86 && num2 != 92)
					{
						goto IL_326;
					}
					return executableProcedureReference;
				}
			}
			else if (num2 <= 144)
			{
				if (num2 <= 106)
				{
					if (num2 == 95)
					{
						return executableProcedureReference;
					}
					if (num2 != 100)
					{
						if (num2 != 106)
						{
							goto IL_326;
						}
						return executableProcedureReference;
					}
				}
				else
				{
					if (num2 == 111 || num2 == 119)
					{
						return executableProcedureReference;
					}
					switch (num2)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return executableProcedureReference;
					case 124:
					case 127:
					case 128:
					case 130:
					case 133:
					case 135:
					case 136:
					case 137:
					case 139:
					case 141:
						goto IL_326;
					default:
						goto IL_326;
					}
				}
			}
			else if (num2 <= 193)
			{
				switch (num2)
				{
				case 156:
				case 160:
				case 161:
				case 162:
					return executableProcedureReference;
				case 157:
				case 158:
				case 159:
					goto IL_326;
				default:
					switch (num2)
					{
					case 167:
					case 170:
					case 171:
					case 172:
					case 173:
					case 176:
					case 180:
					case 181:
						return executableProcedureReference;
					case 168:
					case 169:
					case 174:
					case 175:
					case 177:
					case 178:
					case 179:
						goto IL_326;
					default:
						switch (num2)
						{
						case 191:
							return executableProcedureReference;
						case 192:
							goto IL_326;
						case 193:
							break;
						default:
							goto IL_326;
						}
						break;
					}
					break;
				}
			}
			else if (num2 != 199)
			{
				if (num2 == 204)
				{
					return executableProcedureReference;
				}
				switch (num2)
				{
				case 219:
				case 220:
					return executableProcedureReference;
				case 221:
				case 222:
				case 223:
				case 224:
				case 225:
				case 230:
				case 231:
				case 232:
				case 233:
				case 234:
					break;
				case 226:
				case 227:
				case 228:
				case 229:
					goto IL_326;
				default:
					goto IL_326;
				}
			}
			this.setParamList(executableProcedureReference);
			return executableProcedureReference;
			IL_326:
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x0004CD10 File Offset: 0x0004AF10
		public CreateTableStatement createTableStatement()
		{
			CreateTableStatement createTableStatement = base.FragmentFactory.CreateFragment<CreateTableStatement>();
			IToken token = this.LT(1);
			this.match(35);
			this.match(148);
			SchemaObjectName schemaObjectName = this.schemaObjectThreePartName();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(createTableStatement, token);
				createTableStatement.SchemaObjectName = schemaObjectName;
				base.ThrowPartialAstIfPhaseOne(createTableStatement);
			}
			this.match(191);
			TableDefinition definition = this.tableDefinitionCreateTable();
			if (this.inputState.guessing == 0)
			{
				createTableStatement.Definition = definition;
			}
			IToken token2 = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(createTableStatement, token2);
			}
			int num = this.LA(1);
			if (num <= 92)
			{
				if (num <= 28)
				{
					if (num <= 6)
					{
						if (num == 1 || num == 6)
						{
							goto IL_35B;
						}
					}
					else
					{
						switch (num)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							goto IL_35B;
						case 14:
						case 16:
							break;
						default:
							switch (num)
							{
							case 22:
							case 23:
								goto IL_35B;
							default:
								if (num == 28)
								{
									goto IL_35B;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num <= 75)
				{
					switch (num)
					{
					case 33:
					case 35:
						goto IL_35B;
					case 34:
						break;
					default:
						switch (num)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							goto IL_35B;
						case 47:
						case 50:
						case 51:
						case 52:
						case 53:
						case 57:
						case 58:
						case 59:
						case 62:
						case 63:
							break;
						default:
							switch (num)
							{
							case 74:
							case 75:
								goto IL_35B;
							}
							break;
						}
						break;
					}
				}
				else if (num == 82 || num == 86 || num == 92)
				{
					goto IL_35B;
				}
			}
			else if (num <= 173)
			{
				if (num <= 119)
				{
					if (num == 95)
					{
						goto IL_35B;
					}
					switch (num)
					{
					case 105:
					{
						this.match(105);
						FileGroupOrPartitionScheme onFileGroupOrPartitionScheme = this.filegroupOrPartitionScheme();
						if (this.inputState.guessing == 0)
						{
							createTableStatement.OnFileGroupOrPartitionScheme = onFileGroupOrPartitionScheme;
							goto IL_35B;
						}
						goto IL_35B;
					}
					case 106:
						goto IL_35B;
					default:
						if (num == 119)
						{
							goto IL_35B;
						}
						break;
					}
				}
				else
				{
					switch (num)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						goto IL_35B;
					case 124:
					case 127:
					case 128:
					case 130:
					case 133:
					case 135:
					case 136:
					case 137:
					case 139:
					case 141:
						break;
					default:
						switch (num)
						{
						case 156:
						case 160:
						case 161:
						case 162:
							goto IL_35B;
						case 157:
						case 158:
						case 159:
							break;
						default:
							switch (num)
							{
							case 167:
							case 170:
							case 172:
							case 173:
								goto IL_35B;
							}
							break;
						}
						break;
					}
				}
			}
			else if (num <= 191)
			{
				if (num == 176)
				{
					goto IL_35B;
				}
				switch (num)
				{
				case 180:
				case 181:
					goto IL_35B;
				default:
					if (num == 191)
					{
						goto IL_35B;
					}
					break;
				}
			}
			else
			{
				if (num == 204)
				{
					goto IL_35B;
				}
				switch (num)
				{
				case 219:
				case 220:
					goto IL_35B;
				default:
					if (num == 232)
					{
						goto IL_35B;
					}
					break;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_35B:
			int num2 = this.LA(1);
			if (num2 <= 92)
			{
				if (num2 <= 28)
				{
					if (num2 <= 6)
					{
						if (num2 == 1 || num2 == 6)
						{
							return createTableStatement;
						}
					}
					else
					{
						switch (num2)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							return createTableStatement;
						case 14:
						case 16:
							break;
						default:
							switch (num2)
							{
							case 22:
							case 23:
								return createTableStatement;
							default:
								if (num2 == 28)
								{
									return createTableStatement;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num2 <= 75)
				{
					switch (num2)
					{
					case 33:
					case 35:
						return createTableStatement;
					case 34:
						break;
					default:
						switch (num2)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							return createTableStatement;
						case 47:
						case 50:
						case 51:
						case 52:
						case 53:
						case 57:
						case 58:
						case 59:
						case 62:
						case 63:
							break;
						default:
							switch (num2)
							{
							case 74:
							case 75:
								return createTableStatement;
							}
							break;
						}
						break;
					}
				}
				else if (num2 == 82 || num2 == 86 || num2 == 92)
				{
					return createTableStatement;
				}
			}
			else if (num2 <= 173)
			{
				if (num2 <= 119)
				{
					if (num2 == 95 || num2 == 106 || num2 == 119)
					{
						return createTableStatement;
					}
				}
				else
				{
					switch (num2)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return createTableStatement;
					case 124:
					case 127:
					case 128:
					case 130:
					case 133:
					case 135:
					case 136:
					case 137:
					case 139:
					case 141:
						break;
					default:
						switch (num2)
						{
						case 156:
						case 160:
						case 161:
						case 162:
							return createTableStatement;
						case 157:
						case 158:
						case 159:
							break;
						default:
							switch (num2)
							{
							case 167:
							case 170:
							case 172:
							case 173:
								return createTableStatement;
							}
							break;
						}
						break;
					}
				}
			}
			else if (num2 <= 191)
			{
				if (num2 == 176)
				{
					return createTableStatement;
				}
				switch (num2)
				{
				case 180:
				case 181:
					return createTableStatement;
				default:
					if (num2 == 191)
					{
						return createTableStatement;
					}
					break;
				}
			}
			else
			{
				if (num2 == 204)
				{
					return createTableStatement;
				}
				switch (num2)
				{
				case 219:
				case 220:
					return createTableStatement;
				default:
					if (num2 == 232)
					{
						IToken token3 = this.LT(1);
						this.match(232);
						IdentifierOrValueExpression textImageOn = this.stringOrIdentifier();
						if (this.inputState.guessing == 0)
						{
							TSql80ParserBaseInternal.Match(token3, "TEXTIMAGE_ON");
							createTableStatement.TextImageOn = textImageOn;
							return createTableStatement;
						}
						return createTableStatement;
					}
					break;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x0004D338 File Offset: 0x0004B538
		public AlterTableStatement alterTableStatement()
		{
			AlterTableStatement alterTableStatement = null;
			IToken token = null;
			SchemaObjectName schemaObjectName = null;
			ConstraintEnforcement vExistingRowsCheck = ConstraintEnforcement.NotSpecified;
			try
			{
				token = this.LT(1);
				this.match(6);
				this.match(148);
				schemaObjectName = this.schemaObjectThreePartName();
				int num = this.LA(1);
				if (num <= 54)
				{
					switch (num)
					{
					case 4:
						break;
					case 5:
						goto IL_134;
					case 6:
						alterTableStatement = this.alterTableAlterColumnStatement();
						goto IL_147;
					default:
						if (num != 21)
						{
							if (num != 54)
							{
								goto IL_134;
							}
							alterTableStatement = this.alterTableDropTableElementStatement();
							goto IL_147;
						}
						break;
					}
				}
				else if (num != 97 && num != 171)
				{
					if (num != 232)
					{
						goto IL_134;
					}
					alterTableStatement = this.alterTableTriggerModificationStatement();
					goto IL_147;
				}
				int num2 = this.LA(1);
				if (num2 <= 21)
				{
					if (num2 == 4 || num2 == 21)
					{
						goto IL_F1;
					}
				}
				else
				{
					if (num2 == 97)
					{
						goto IL_F1;
					}
					if (num2 == 171)
					{
						this.match(171);
						vExistingRowsCheck = this.constraintEnforcement();
						goto IL_F1;
					}
				}
				throw new NoViableAltException(this.LT(1), this.getFilename());
				IL_F1:
				int num3 = this.LA(1);
				if (num3 == 4)
				{
					alterTableStatement = this.alterTableAddTableElementStatement(vExistingRowsCheck);
					goto IL_147;
				}
				if (num3 != 21 && num3 != 97)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				alterTableStatement = this.alterTableConstraintModificationStatement(vExistingRowsCheck);
				goto IL_147;
				IL_134:
				throw new NoViableAltException(this.LT(1), this.getFilename());
				IL_147:
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(alterTableStatement, token);
					alterTableStatement.SchemaObjectName = schemaObjectName;
				}
			}
			catch (PhaseOnePartialAstException ex)
			{
				if (this.inputState.guessing == 0)
				{
					AlterTableStatement alterTableStatement2 = ex.Statement as AlterTableStatement;
					TSql80ParserBaseInternal.UpdateTokenInfo(alterTableStatement2, token);
					alterTableStatement2.SchemaObjectName = schemaObjectName;
					throw;
				}
				throw;
			}
			return alterTableStatement;
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x0004D4F8 File Offset: 0x0004B6F8
		public CreateIndexStatement createIndexStatement()
		{
			CreateIndexStatement createIndexStatement = base.FragmentFactory.CreateFragment<CreateIndexStatement>();
			IToken token = this.LT(1);
			this.match(35);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(createIndexStatement, token);
			}
			int num = this.LA(1);
			if (num <= 84)
			{
				if (num == 24 || num == 84)
				{
					goto IL_94;
				}
			}
			else
			{
				if (num == 98)
				{
					goto IL_94;
				}
				if (num == 159)
				{
					this.match(159);
					if (this.inputState.guessing == 0)
					{
						createIndexStatement.Unique = true;
						goto IL_94;
					}
					goto IL_94;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_94:
			int num2 = this.LA(1);
			if (num2 != 24)
			{
				if (num2 != 84)
				{
					if (num2 != 98)
					{
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
					this.match(98);
					if (this.inputState.guessing == 0)
					{
						createIndexStatement.Clustered = new bool?(false);
					}
				}
			}
			else
			{
				this.match(24);
				if (this.inputState.guessing == 0)
				{
					createIndexStatement.Clustered = new bool?(true);
				}
			}
			this.match(84);
			Identifier name = this.identifier();
			if (this.inputState.guessing == 0)
			{
				createIndexStatement.Name = name;
			}
			this.match(105);
			SchemaObjectName onName = this.schemaObjectThreePartName();
			if (this.inputState.guessing == 0)
			{
				createIndexStatement.OnName = onName;
				base.ThrowPartialAstIfPhaseOne(createIndexStatement);
			}
			this.match(191);
			ColumnWithSortOrder item = this.columnWithSortOrder();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ColumnWithSortOrder>(createIndexStatement, createIndexStatement.Columns, item);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				item = this.columnWithSortOrder();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ColumnWithSortOrder>(createIndexStatement, createIndexStatement.Columns, item);
				}
			}
			IToken token2 = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(createIndexStatement, token2);
			}
			int num3 = this.LA(1);
			if (num3 <= 86)
			{
				if (num3 <= 28)
				{
					if (num3 <= 6)
					{
						if (num3 == 1 || num3 == 6)
						{
							goto IL_494;
						}
					}
					else
					{
						switch (num3)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							goto IL_494;
						case 14:
						case 16:
							break;
						default:
							switch (num3)
							{
							case 22:
							case 23:
								goto IL_494;
							default:
								if (num3 == 28)
								{
									goto IL_494;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num3 <= 64)
				{
					switch (num3)
					{
					case 33:
					case 35:
						goto IL_494;
					case 34:
						break;
					default:
						switch (num3)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							goto IL_494;
						}
						break;
					}
				}
				else
				{
					switch (num3)
					{
					case 74:
					case 75:
						goto IL_494;
					default:
						if (num3 == 82 || num3 == 86)
						{
							goto IL_494;
						}
						break;
					}
				}
			}
			else if (num3 <= 144)
			{
				if (num3 <= 95)
				{
					if (num3 == 92 || num3 == 95)
					{
						goto IL_494;
					}
				}
				else
				{
					switch (num3)
					{
					case 105:
					case 106:
						goto IL_494;
					default:
						if (num3 == 119)
						{
							goto IL_494;
						}
						switch (num3)
						{
						case 123:
						case 125:
						case 126:
						case 129:
						case 131:
						case 132:
						case 134:
						case 138:
						case 140:
						case 142:
						case 143:
						case 144:
							goto IL_494;
						}
						break;
					}
				}
			}
			else if (num3 <= 181)
			{
				switch (num3)
				{
				case 156:
				case 160:
				case 161:
				case 162:
					goto IL_494;
				case 157:
				case 158:
				case 159:
					break;
				default:
					switch (num3)
					{
					case 167:
					case 170:
					case 172:
					case 173:
					case 176:
					case 180:
					case 181:
						goto IL_494;
					case 171:
						this.match(171);
						this.indexLegacyOptionList(createIndexStatement);
						if (this.inputState.guessing == 0)
						{
							createIndexStatement.Translated80SyntaxTo90 = true;
							goto IL_494;
						}
						goto IL_494;
					}
					break;
				}
			}
			else
			{
				if (num3 == 191 || num3 == 204)
				{
					goto IL_494;
				}
				switch (num3)
				{
				case 219:
				case 220:
					goto IL_494;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_494:
			int num4 = this.LA(1);
			if (num4 <= 92)
			{
				if (num4 <= 28)
				{
					if (num4 <= 6)
					{
						if (num4 == 1 || num4 == 6)
						{
							return createIndexStatement;
						}
					}
					else
					{
						switch (num4)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							return createIndexStatement;
						case 14:
						case 16:
							break;
						default:
							switch (num4)
							{
							case 22:
							case 23:
								return createIndexStatement;
							default:
								if (num4 == 28)
								{
									return createIndexStatement;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num4 <= 75)
				{
					switch (num4)
					{
					case 33:
					case 35:
						return createIndexStatement;
					case 34:
						break;
					default:
						switch (num4)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							return createIndexStatement;
						case 47:
						case 50:
						case 51:
						case 52:
						case 53:
						case 57:
						case 58:
						case 59:
						case 62:
						case 63:
							break;
						default:
							switch (num4)
							{
							case 74:
							case 75:
								return createIndexStatement;
							}
							break;
						}
						break;
					}
				}
				else if (num4 == 82 || num4 == 86 || num4 == 92)
				{
					return createIndexStatement;
				}
			}
			else if (num4 <= 162)
			{
				if (num4 <= 106)
				{
					if (num4 == 95)
					{
						return createIndexStatement;
					}
					switch (num4)
					{
					case 105:
					{
						this.match(105);
						FileGroupOrPartitionScheme onFileGroupOrPartitionScheme = this.filegroupOrPartitionScheme();
						if (this.inputState.guessing == 0)
						{
							createIndexStatement.OnFileGroupOrPartitionScheme = onFileGroupOrPartitionScheme;
							return createIndexStatement;
						}
						return createIndexStatement;
					}
					case 106:
						return createIndexStatement;
					}
				}
				else
				{
					if (num4 == 119)
					{
						return createIndexStatement;
					}
					switch (num4)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return createIndexStatement;
					case 124:
					case 127:
					case 128:
					case 130:
					case 133:
					case 135:
					case 136:
					case 137:
					case 139:
					case 141:
						break;
					default:
						switch (num4)
						{
						case 156:
						case 160:
						case 161:
						case 162:
							return createIndexStatement;
						}
						break;
					}
				}
			}
			else if (num4 <= 181)
			{
				switch (num4)
				{
				case 167:
				case 170:
				case 172:
				case 173:
					return createIndexStatement;
				case 168:
				case 169:
				case 171:
					break;
				default:
					if (num4 == 176)
					{
						return createIndexStatement;
					}
					switch (num4)
					{
					case 180:
					case 181:
						return createIndexStatement;
					}
					break;
				}
			}
			else
			{
				if (num4 == 191 || num4 == 204)
				{
					return createIndexStatement;
				}
				switch (num4)
				{
				case 219:
				case 220:
					return createIndexStatement;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x0004DC44 File Offset: 0x0004BE44
		public TSqlStatement declareStatements()
		{
			TSqlStatement tsqlStatement = null;
			IToken token = null;
			token = this.LT(1);
			this.match(46);
			bool flag = false;
			if (this.LA(1) == 234 && this.LA(2) == 148)
			{
				int pos = this.mark();
				flag = true;
				this.inputState.guessing++;
				try
				{
					this.match(234);
					int num = this.LA(1);
					if (num != 9)
					{
						if (num != 148)
						{
							throw new NoViableAltException(this.LT(1), this.getFilename());
						}
					}
					else
					{
						this.match(9);
					}
					this.match(148);
				}
				catch (RecognitionException)
				{
					flag = false;
				}
				this.rewind(pos);
				this.inputState.guessing--;
			}
			if (flag)
			{
				DeclareTableVariableBody body = this.declareTableBody(IndexAffectingStatement.DeclareTableVariable);
				if (this.inputState.guessing == 0)
				{
					DeclareTableVariableStatement declareTableVariableStatement = base.FragmentFactory.CreateFragment<DeclareTableVariableStatement>();
					declareTableVariableStatement.Body = body;
					tsqlStatement = declareTableVariableStatement;
				}
			}
			else if (this.LA(1) == 234 && TSql80ParserInternal.tokenSet_12_.member(this.LA(2)))
			{
				tsqlStatement = this.declareVariableStatement();
			}
			else
			{
				if (this.LA(1) != 232 && this.LA(1) != 233)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				tsqlStatement = this.declareCursorStatement();
			}
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(tsqlStatement, token);
			}
			return tsqlStatement;
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x0004DDD0 File Offset: 0x0004BFD0
		public TSqlStatement setStatements()
		{
			IToken token = this.LT(1);
			this.match(142);
			int num = this.LA(1);
			TSqlStatement tsqlStatement;
			if (num <= 135)
			{
				if (num <= 80)
				{
					if (num == 57)
					{
						tsqlStatement = this.setErrorLevelStatement();
						goto IL_16E;
					}
					if (num == 80)
					{
						tsqlStatement = this.setIdentityInsertStatement();
						goto IL_16E;
					}
				}
				else
				{
					if (num == 104)
					{
						tsqlStatement = this.setOffsetsStatement();
						goto IL_16E;
					}
					if (num == 135)
					{
						tsqlStatement = this.setRowcountStatement();
						goto IL_16E;
					}
				}
			}
			else if (num <= 149)
			{
				if (num == 146)
				{
					tsqlStatement = this.setStatisticsStatement();
					goto IL_16E;
				}
				if (num == 149)
				{
					tsqlStatement = this.setTextSizeStatement();
					goto IL_16E;
				}
			}
			else
			{
				switch (num)
				{
				case 153:
				case 154:
					tsqlStatement = this.setTransactionIsolationLevelStatement();
					goto IL_16E;
				default:
					if (num == 234)
					{
						tsqlStatement = this.setVariableStatement();
						goto IL_16E;
					}
					break;
				}
			}
			if (this.LA(1) == 232 && (this.LA(2) == 103 || this.LA(2) == 105 || this.LA(2) == 198) && !base.NextTokenMatches("FIPS_FLAGGER"))
			{
				tsqlStatement = this.predicateSetStatement();
			}
			else
			{
				if (this.LA(1) != 232 || !TSql80ParserInternal.tokenSet_13_.member(this.LA(2)))
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				tsqlStatement = this.setCommandStatement();
			}
			IL_16E:
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(tsqlStatement, token);
			}
			return tsqlStatement;
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x0004DF60 File Offset: 0x0004C160
		public TSqlStatement beginStatements()
		{
			bool flag = false;
			if (this.LA(1) == 13 && (this.LA(2) == 52 || this.LA(2) == 153 || this.LA(2) == 154))
			{
				int pos = this.mark();
				flag = true;
				this.inputState.guessing++;
				try
				{
					this.match(13);
					int num = this.LA(1);
					if (num != 52)
					{
						switch (num)
						{
						case 153:
						case 154:
							break;
						default:
							throw new NoViableAltException(this.LT(1), this.getFilename());
						}
					}
					else
					{
						this.match(52);
					}
					switch (this.LA(1))
					{
					case 153:
						this.match(153);
						break;
					case 154:
						this.match(154);
						break;
					default:
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
				}
				catch (RecognitionException)
				{
					flag = false;
				}
				this.rewind(pos);
				this.inputState.guessing--;
			}
			TSqlStatement result;
			if (flag)
			{
				result = this.beginTransactionStatement();
			}
			else
			{
				if (this.LA(1) != 13 || !TSql80ParserInternal.tokenSet_3_.member(this.LA(2)))
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				result = this.beginEndBlockStatement();
			}
			return result;
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x0004E0D4 File Offset: 0x0004C2D4
		public BreakStatement breakStatement()
		{
			BreakStatement breakStatement = base.FragmentFactory.CreateFragment<BreakStatement>();
			IToken token = this.LT(1);
			this.match(15);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(breakStatement, token);
			}
			return breakStatement;
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x0004E114 File Offset: 0x0004C314
		public ContinueStatement continueStatement()
		{
			ContinueStatement continueStatement = base.FragmentFactory.CreateFragment<ContinueStatement>();
			IToken token = this.LT(1);
			this.match(33);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(continueStatement, token);
			}
			return continueStatement;
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x0004E154 File Offset: 0x0004C354
		public IfStatement ifStatement()
		{
			IfStatement ifStatement = base.FragmentFactory.CreateFragment<IfStatement>();
			bool flag = false;
			IToken token = this.LT(1);
			this.match(82);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(ifStatement, token);
			}
			BooleanExpression predicate = this.booleanExpression();
			if (this.inputState.guessing == 0)
			{
				ifStatement.Predicate = predicate;
			}
			TSqlStatement tsqlStatement = this.statementOptSemi();
			if (this.inputState.guessing == 0)
			{
				if (tsqlStatement == null)
				{
					flag = true;
				}
				else
				{
					ifStatement.ThenStatement = tsqlStatement;
				}
			}
			if (this.LA(1) == 55 && TSql80ParserInternal.tokenSet_3_.member(this.LA(2)))
			{
				this.match(55);
				tsqlStatement = this.statementOptSemi();
				if (this.inputState.guessing == 0)
				{
					if (tsqlStatement == null)
					{
						flag = true;
					}
					else
					{
						ifStatement.ElseStatement = tsqlStatement;
					}
				}
			}
			else if (!TSql80ParserInternal.tokenSet_10_.member(this.LA(1)) || !TSql80ParserInternal.tokenSet_11_.member(this.LA(2)))
			{
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			if (this.inputState.guessing == 0 && flag)
			{
				ifStatement = null;
			}
			return ifStatement;
		}

		// Token: 0x06001240 RID: 4672 RVA: 0x0004E26C File Offset: 0x0004C46C
		public WhileStatement whileStatement()
		{
			WhileStatement whileStatement = base.FragmentFactory.CreateFragment<WhileStatement>();
			IToken token = this.LT(1);
			this.match(170);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(whileStatement, token);
			}
			BooleanExpression predicate = this.booleanExpression();
			if (this.inputState.guessing == 0)
			{
				whileStatement.Predicate = predicate;
			}
			TSqlStatement tsqlStatement = this.statementOptSemi();
			if (this.inputState.guessing == 0)
			{
				if (tsqlStatement == null)
				{
					whileStatement = null;
				}
				else
				{
					whileStatement.Statement = tsqlStatement;
				}
			}
			return whileStatement;
		}

		// Token: 0x06001241 RID: 4673 RVA: 0x0004E2EC File Offset: 0x0004C4EC
		public LabelStatement labelStatement()
		{
			LabelStatement labelStatement = base.FragmentFactory.CreateFragment<LabelStatement>();
			IToken token = this.LT(1);
			this.match(220);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(labelStatement, token);
				labelStatement.Value = token.getText();
			}
			return labelStatement;
		}

		// Token: 0x06001242 RID: 4674 RVA: 0x0004E33C File Offset: 0x0004C53C
		public BackupStatement backupStatement()
		{
			IToken token = this.backupStart();
			BackupStatement backupStatement = this.backupMain();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(backupStatement, token);
			}
			int num = this.LA(1);
			if (num <= 86)
			{
				if (num <= 28)
				{
					if (num <= 6)
					{
						if (num == 1 || num == 6)
						{
							goto IL_2A2;
						}
					}
					else
					{
						switch (num)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							goto IL_2A2;
						case 14:
						case 16:
							break;
						default:
							switch (num)
							{
							case 22:
							case 23:
								goto IL_2A2;
							default:
								if (num == 28)
								{
									goto IL_2A2;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num <= 64)
				{
					switch (num)
					{
					case 33:
					case 35:
						goto IL_2A2;
					case 34:
						break;
					default:
						switch (num)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							goto IL_2A2;
						}
						break;
					}
				}
				else
				{
					switch (num)
					{
					case 74:
					case 75:
						goto IL_2A2;
					default:
						if (num == 82 || num == 86)
						{
							goto IL_2A2;
						}
						break;
					}
				}
			}
			else if (num <= 144)
			{
				if (num <= 95)
				{
					if (num == 92 || num == 95)
					{
						goto IL_2A2;
					}
				}
				else
				{
					if (num == 106 || num == 119)
					{
						goto IL_2A2;
					}
					switch (num)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						goto IL_2A2;
					}
				}
			}
			else if (num <= 181)
			{
				if (num == 151)
				{
					this.match(151);
					this.devList(backupStatement, backupStatement.Devices);
					goto IL_2A2;
				}
				switch (num)
				{
				case 156:
				case 160:
				case 161:
				case 162:
					goto IL_2A2;
				case 157:
				case 158:
				case 159:
					break;
				default:
					switch (num)
					{
					case 167:
					case 170:
					case 171:
					case 172:
					case 173:
					case 176:
					case 180:
					case 181:
						goto IL_2A2;
					}
					break;
				}
			}
			else
			{
				if (num == 191 || num == 204)
				{
					goto IL_2A2;
				}
				switch (num)
				{
				case 219:
				case 220:
					goto IL_2A2;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_2A2:
			int num2 = this.LA(1);
			if (num2 <= 86)
			{
				if (num2 <= 28)
				{
					if (num2 <= 6)
					{
						if (num2 == 1 || num2 == 6)
						{
							return backupStatement;
						}
					}
					else
					{
						switch (num2)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							return backupStatement;
						case 14:
						case 16:
							break;
						default:
							switch (num2)
							{
							case 22:
							case 23:
								return backupStatement;
							default:
								if (num2 == 28)
								{
									return backupStatement;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num2 <= 64)
				{
					switch (num2)
					{
					case 33:
					case 35:
						return backupStatement;
					case 34:
						break;
					default:
						switch (num2)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							return backupStatement;
						}
						break;
					}
				}
				else
				{
					switch (num2)
					{
					case 74:
					case 75:
						return backupStatement;
					default:
						if (num2 == 82 || num2 == 86)
						{
							return backupStatement;
						}
						break;
					}
				}
			}
			else if (num2 <= 144)
			{
				if (num2 <= 95)
				{
					if (num2 == 92 || num2 == 95)
					{
						return backupStatement;
					}
				}
				else
				{
					if (num2 == 106 || num2 == 119)
					{
						return backupStatement;
					}
					switch (num2)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return backupStatement;
					}
				}
			}
			else if (num2 <= 181)
			{
				switch (num2)
				{
				case 156:
				case 160:
				case 161:
				case 162:
					return backupStatement;
				case 157:
				case 158:
				case 159:
					break;
				default:
					switch (num2)
					{
					case 167:
					case 170:
					case 172:
					case 173:
					case 176:
					case 180:
					case 181:
						return backupStatement;
					case 171:
						this.backupOptions(backupStatement);
						return backupStatement;
					}
					break;
				}
			}
			else
			{
				if (num2 == 191 || num2 == 204)
				{
					return backupStatement;
				}
				switch (num2)
				{
				case 219:
				case 220:
					return backupStatement;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x0004E850 File Offset: 0x0004CA50
		public RestoreStatement restoreStatement()
		{
			RestoreStatement restoreStatement = base.FragmentFactory.CreateFragment<RestoreStatement>();
			IToken token = this.restoreStart();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(restoreStatement, token);
			}
			if (TSql80ParserInternal.tokenSet_14_.member(this.LA(1)) && this.LA(2) >= 232 && this.LA(2) <= 234)
			{
				this.restoreMain(restoreStatement);
				int num = this.LA(1);
				if (num <= 86)
				{
					if (num <= 28)
					{
						if (num <= 6)
						{
							if (num == 1 || num == 6)
							{
								goto IL_363;
							}
						}
						else
						{
							switch (num)
							{
							case 12:
							case 13:
							case 15:
							case 17:
								goto IL_363;
							case 14:
							case 16:
								break;
							default:
								switch (num)
								{
								case 22:
								case 23:
									goto IL_363;
								default:
									if (num == 28)
									{
										goto IL_363;
									}
									break;
								}
								break;
							}
						}
					}
					else if (num <= 64)
					{
						switch (num)
						{
						case 33:
						case 35:
							goto IL_363;
						case 34:
							break;
						default:
							switch (num)
							{
							case 44:
							case 45:
							case 46:
							case 48:
							case 49:
							case 54:
							case 55:
							case 56:
							case 60:
							case 61:
							case 64:
								goto IL_363;
							}
							break;
						}
					}
					else
					{
						switch (num)
						{
						case 71:
							this.match(71);
							this.devList(restoreStatement, restoreStatement.Devices);
							goto IL_363;
						case 72:
						case 73:
							break;
						case 74:
						case 75:
							goto IL_363;
						default:
							if (num == 82 || num == 86)
							{
								goto IL_363;
							}
							break;
						}
					}
				}
				else if (num <= 144)
				{
					if (num <= 95)
					{
						if (num == 92 || num == 95)
						{
							goto IL_363;
						}
					}
					else
					{
						if (num == 106 || num == 119)
						{
							goto IL_363;
						}
						switch (num)
						{
						case 123:
						case 125:
						case 126:
						case 129:
						case 131:
						case 132:
						case 134:
						case 138:
						case 140:
						case 142:
						case 143:
						case 144:
							goto IL_363;
						}
					}
				}
				else if (num <= 181)
				{
					switch (num)
					{
					case 156:
					case 160:
					case 161:
					case 162:
						goto IL_363;
					case 157:
					case 158:
					case 159:
						break;
					default:
						switch (num)
						{
						case 167:
						case 170:
						case 171:
						case 172:
						case 173:
						case 176:
						case 180:
						case 181:
							goto IL_363;
						}
						break;
					}
				}
				else
				{
					if (num == 191 || num == 204)
					{
						goto IL_363;
					}
					switch (num)
					{
					case 219:
					case 220:
						goto IL_363;
					}
				}
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			if (this.LA(1) != 232 || this.LA(2) != 71)
			{
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			IToken token2 = this.LT(1);
			this.match(232);
			this.match(71);
			this.devList(restoreStatement, restoreStatement.Devices);
			if (this.inputState.guessing == 0)
			{
				restoreStatement.Kind = RestoreStatementKindsHelper.Instance.ParseOption(token2);
			}
			IL_363:
			int num2 = this.LA(1);
			if (num2 <= 86)
			{
				if (num2 <= 28)
				{
					if (num2 <= 6)
					{
						if (num2 == 1 || num2 == 6)
						{
							return restoreStatement;
						}
					}
					else
					{
						switch (num2)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							return restoreStatement;
						case 14:
						case 16:
							break;
						default:
							switch (num2)
							{
							case 22:
							case 23:
								return restoreStatement;
							default:
								if (num2 == 28)
								{
									return restoreStatement;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num2 <= 64)
				{
					switch (num2)
					{
					case 33:
					case 35:
						return restoreStatement;
					case 34:
						break;
					default:
						switch (num2)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							return restoreStatement;
						}
						break;
					}
				}
				else
				{
					switch (num2)
					{
					case 74:
					case 75:
						return restoreStatement;
					default:
						if (num2 == 82 || num2 == 86)
						{
							return restoreStatement;
						}
						break;
					}
				}
			}
			else if (num2 <= 144)
			{
				if (num2 <= 95)
				{
					if (num2 == 92 || num2 == 95)
					{
						return restoreStatement;
					}
				}
				else
				{
					if (num2 == 106 || num2 == 119)
					{
						return restoreStatement;
					}
					switch (num2)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return restoreStatement;
					}
				}
			}
			else if (num2 <= 181)
			{
				switch (num2)
				{
				case 156:
				case 160:
				case 161:
				case 162:
					return restoreStatement;
				case 157:
				case 158:
				case 159:
					break;
				default:
					switch (num2)
					{
					case 167:
					case 170:
					case 172:
					case 173:
					case 176:
					case 180:
					case 181:
						return restoreStatement;
					case 171:
						this.restoreOptions(restoreStatement);
						return restoreStatement;
					}
					break;
				}
			}
			else
			{
				if (num2 == 191 || num2 == 204)
				{
					return restoreStatement;
				}
				switch (num2)
				{
				case 219:
				case 220:
					return restoreStatement;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x06001244 RID: 4676 RVA: 0x0004EE44 File Offset: 0x0004D044
		public GoToStatement gotoStatement()
		{
			GoToStatement goToStatement = base.FragmentFactory.CreateFragment<GoToStatement>();
			IToken token = this.LT(1);
			this.match(74);
			Identifier labelName = this.nonQuotedIdentifier();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(goToStatement, token);
				goToStatement.LabelName = labelName;
			}
			return goToStatement;
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x0004EE94 File Offset: 0x0004D094
		public SaveTransactionStatement saveTransactionStatement()
		{
			SaveTransactionStatement saveTransactionStatement = base.FragmentFactory.CreateFragment<SaveTransactionStatement>();
			IToken token = this.LT(1);
			this.match(138);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(saveTransactionStatement, token);
			}
			switch (this.LA(1))
			{
			case 153:
				this.match(153);
				break;
			case 154:
				this.match(154);
				break;
			default:
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			this.transactionName(saveTransactionStatement);
			return saveTransactionStatement;
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x0004EF2C File Offset: 0x0004D12C
		public RollbackTransactionStatement rollbackTransactionStatement()
		{
			RollbackTransactionStatement rollbackTransactionStatement = base.FragmentFactory.CreateFragment<RollbackTransactionStatement>();
			IToken token = this.LT(1);
			this.match(134);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(rollbackTransactionStatement, token);
			}
			int num = this.LA(1);
			if (num <= 92)
			{
				if (num <= 28)
				{
					if (num <= 6)
					{
						if (num == 1 || num == 6)
						{
							return rollbackTransactionStatement;
						}
					}
					else
					{
						switch (num)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							return rollbackTransactionStatement;
						case 14:
						case 16:
							break;
						default:
							switch (num)
							{
							case 22:
							case 23:
								return rollbackTransactionStatement;
							default:
								if (num == 28)
								{
									return rollbackTransactionStatement;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num <= 75)
				{
					switch (num)
					{
					case 33:
					case 35:
						return rollbackTransactionStatement;
					case 34:
						break;
					default:
						switch (num)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							return rollbackTransactionStatement;
						case 47:
						case 50:
						case 51:
						case 52:
						case 53:
						case 57:
						case 58:
						case 59:
						case 62:
						case 63:
							break;
						default:
							switch (num)
							{
							case 74:
							case 75:
								return rollbackTransactionStatement;
							}
							break;
						}
						break;
					}
				}
				else if (num == 82 || num == 86 || num == 92)
				{
					return rollbackTransactionStatement;
				}
			}
			else if (num <= 173)
			{
				if (num <= 119)
				{
					if (num == 95 || num == 106 || num == 119)
					{
						return rollbackTransactionStatement;
					}
				}
				else
				{
					switch (num)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return rollbackTransactionStatement;
					case 124:
					case 127:
					case 128:
					case 130:
					case 133:
					case 135:
					case 136:
					case 137:
					case 139:
					case 141:
						break;
					default:
						switch (num)
						{
						case 153:
						case 154:
						{
							switch (this.LA(1))
							{
							case 153:
							{
								IToken token2 = this.LT(1);
								this.match(153);
								if (this.inputState.guessing == 0)
								{
									TSql80ParserBaseInternal.UpdateTokenInfo(rollbackTransactionStatement, token2);
								}
								break;
							}
							case 154:
							{
								IToken token3 = this.LT(1);
								this.match(154);
								if (this.inputState.guessing == 0)
								{
									TSql80ParserBaseInternal.UpdateTokenInfo(rollbackTransactionStatement, token3);
								}
								break;
							}
							default:
								throw new NoViableAltException(this.LT(1), this.getFilename());
							}
							int num2 = this.LA(1);
							if (num2 <= 95)
							{
								if (num2 <= 35)
								{
									if (num2 <= 17)
									{
										if (num2 == 1 || num2 == 6)
										{
											return rollbackTransactionStatement;
										}
										switch (num2)
										{
										case 12:
										case 13:
										case 15:
										case 17:
											return rollbackTransactionStatement;
										}
									}
									else
									{
										switch (num2)
										{
										case 22:
										case 23:
											return rollbackTransactionStatement;
										default:
											if (num2 == 28)
											{
												return rollbackTransactionStatement;
											}
											switch (num2)
											{
											case 33:
											case 35:
												return rollbackTransactionStatement;
											}
											break;
										}
									}
								}
								else if (num2 <= 82)
								{
									switch (num2)
									{
									case 44:
									case 45:
									case 46:
									case 48:
									case 49:
									case 54:
									case 55:
									case 56:
									case 60:
									case 61:
									case 64:
										return rollbackTransactionStatement;
									case 47:
									case 50:
									case 51:
									case 52:
									case 53:
									case 57:
									case 58:
									case 59:
									case 62:
									case 63:
										break;
									default:
										switch (num2)
										{
										case 74:
										case 75:
											return rollbackTransactionStatement;
										default:
											if (num2 == 82)
											{
												return rollbackTransactionStatement;
											}
											break;
										}
										break;
									}
								}
								else if (num2 == 86 || num2 == 92 || num2 == 95)
								{
									return rollbackTransactionStatement;
								}
							}
							else
							{
								if (num2 > 176)
								{
									if (num2 <= 199)
									{
										switch (num2)
										{
										case 180:
										case 181:
											return rollbackTransactionStatement;
										default:
											if (num2 == 191)
											{
												return rollbackTransactionStatement;
											}
											if (num2 != 199)
											{
												goto IL_612;
											}
											break;
										}
									}
									else
									{
										if (num2 == 204)
										{
											return rollbackTransactionStatement;
										}
										switch (num2)
										{
										case 219:
										case 220:
											return rollbackTransactionStatement;
										case 221:
											break;
										default:
											switch (num2)
											{
											case 232:
											case 233:
											case 234:
												break;
											default:
												goto IL_612;
											}
											break;
										}
									}
									this.transactionName(rollbackTransactionStatement);
									return rollbackTransactionStatement;
								}
								if (num2 <= 144)
								{
									if (num2 == 106 || num2 == 119)
									{
										return rollbackTransactionStatement;
									}
									switch (num2)
									{
									case 123:
									case 125:
									case 126:
									case 129:
									case 131:
									case 132:
									case 134:
									case 138:
									case 140:
									case 142:
									case 143:
									case 144:
										return rollbackTransactionStatement;
									}
								}
								else
								{
									switch (num2)
									{
									case 156:
									case 160:
									case 161:
									case 162:
										return rollbackTransactionStatement;
									case 157:
									case 158:
									case 159:
										break;
									default:
										switch (num2)
										{
										case 167:
										case 170:
										case 172:
										case 173:
											return rollbackTransactionStatement;
										case 168:
										case 169:
										case 171:
											break;
										default:
											if (num2 == 176)
											{
												return rollbackTransactionStatement;
											}
											break;
										}
										break;
									}
								}
							}
							IL_612:
							throw new NoViableAltException(this.LT(1), this.getFilename());
						}
						case 155:
						case 157:
						case 158:
						case 159:
							break;
						case 156:
						case 160:
						case 161:
						case 162:
							return rollbackTransactionStatement;
						default:
							switch (num)
							{
							case 167:
							case 170:
							case 172:
							case 173:
								return rollbackTransactionStatement;
							}
							break;
						}
						break;
					}
				}
			}
			else if (num <= 191)
			{
				if (num == 176)
				{
					return rollbackTransactionStatement;
				}
				switch (num)
				{
				case 180:
				case 181:
					return rollbackTransactionStatement;
				default:
					if (num == 191)
					{
						return rollbackTransactionStatement;
					}
					break;
				}
			}
			else
			{
				if (num == 204)
				{
					return rollbackTransactionStatement;
				}
				switch (num)
				{
				case 219:
				case 220:
					return rollbackTransactionStatement;
				default:
					if (num == 232)
					{
						IToken token4 = this.LT(1);
						this.match(232);
						if (this.inputState.guessing == 0)
						{
							TSql80ParserBaseInternal.Match(token4, "WORK");
							return rollbackTransactionStatement;
						}
						return rollbackTransactionStatement;
					}
					break;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x0004F574 File Offset: 0x0004D774
		public CommitTransactionStatement commitTransactionStatement()
		{
			CommitTransactionStatement commitTransactionStatement = base.FragmentFactory.CreateFragment<CommitTransactionStatement>();
			IToken token = this.LT(1);
			this.match(28);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(commitTransactionStatement, token);
			}
			int num = this.LA(1);
			if (num <= 92)
			{
				if (num <= 28)
				{
					if (num <= 6)
					{
						if (num == 1 || num == 6)
						{
							return commitTransactionStatement;
						}
					}
					else
					{
						switch (num)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							return commitTransactionStatement;
						case 14:
						case 16:
							break;
						default:
							switch (num)
							{
							case 22:
							case 23:
								return commitTransactionStatement;
							default:
								if (num == 28)
								{
									return commitTransactionStatement;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num <= 75)
				{
					switch (num)
					{
					case 33:
					case 35:
						return commitTransactionStatement;
					case 34:
						break;
					default:
						switch (num)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							return commitTransactionStatement;
						case 47:
						case 50:
						case 51:
						case 52:
						case 53:
						case 57:
						case 58:
						case 59:
						case 62:
						case 63:
							break;
						default:
							switch (num)
							{
							case 74:
							case 75:
								return commitTransactionStatement;
							}
							break;
						}
						break;
					}
				}
				else if (num == 82 || num == 86 || num == 92)
				{
					return commitTransactionStatement;
				}
			}
			else if (num <= 173)
			{
				if (num <= 119)
				{
					if (num == 95 || num == 106 || num == 119)
					{
						return commitTransactionStatement;
					}
				}
				else
				{
					switch (num)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return commitTransactionStatement;
					case 124:
					case 127:
					case 128:
					case 130:
					case 133:
					case 135:
					case 136:
					case 137:
					case 139:
					case 141:
						break;
					default:
						switch (num)
						{
						case 153:
						case 154:
						{
							switch (this.LA(1))
							{
							case 153:
							{
								IToken token2 = this.LT(1);
								this.match(153);
								if (this.inputState.guessing == 0)
								{
									TSql80ParserBaseInternal.UpdateTokenInfo(commitTransactionStatement, token2);
								}
								break;
							}
							case 154:
							{
								IToken token3 = this.LT(1);
								this.match(154);
								if (this.inputState.guessing == 0)
								{
									TSql80ParserBaseInternal.UpdateTokenInfo(commitTransactionStatement, token3);
								}
								break;
							}
							default:
								throw new NoViableAltException(this.LT(1), this.getFilename());
							}
							int num2 = this.LA(1);
							if (num2 <= 95)
							{
								if (num2 <= 35)
								{
									if (num2 <= 17)
									{
										if (num2 == 1 || num2 == 6)
										{
											return commitTransactionStatement;
										}
										switch (num2)
										{
										case 12:
										case 13:
										case 15:
										case 17:
											return commitTransactionStatement;
										}
									}
									else
									{
										switch (num2)
										{
										case 22:
										case 23:
											return commitTransactionStatement;
										default:
											if (num2 == 28)
											{
												return commitTransactionStatement;
											}
											switch (num2)
											{
											case 33:
											case 35:
												return commitTransactionStatement;
											}
											break;
										}
									}
								}
								else if (num2 <= 82)
								{
									switch (num2)
									{
									case 44:
									case 45:
									case 46:
									case 48:
									case 49:
									case 54:
									case 55:
									case 56:
									case 60:
									case 61:
									case 64:
										return commitTransactionStatement;
									case 47:
									case 50:
									case 51:
									case 52:
									case 53:
									case 57:
									case 58:
									case 59:
									case 62:
									case 63:
										break;
									default:
										switch (num2)
										{
										case 74:
										case 75:
											return commitTransactionStatement;
										default:
											if (num2 == 82)
											{
												return commitTransactionStatement;
											}
											break;
										}
										break;
									}
								}
								else if (num2 == 86 || num2 == 92 || num2 == 95)
								{
									return commitTransactionStatement;
								}
							}
							else
							{
								if (num2 > 176)
								{
									if (num2 <= 199)
									{
										switch (num2)
										{
										case 180:
										case 181:
											return commitTransactionStatement;
										default:
											if (num2 == 191)
											{
												return commitTransactionStatement;
											}
											if (num2 != 199)
											{
												goto IL_60F;
											}
											break;
										}
									}
									else
									{
										if (num2 == 204)
										{
											return commitTransactionStatement;
										}
										switch (num2)
										{
										case 219:
										case 220:
											return commitTransactionStatement;
										case 221:
											break;
										default:
											switch (num2)
											{
											case 232:
											case 233:
											case 234:
												break;
											default:
												goto IL_60F;
											}
											break;
										}
									}
									this.transactionName(commitTransactionStatement);
									return commitTransactionStatement;
								}
								if (num2 <= 144)
								{
									if (num2 == 106 || num2 == 119)
									{
										return commitTransactionStatement;
									}
									switch (num2)
									{
									case 123:
									case 125:
									case 126:
									case 129:
									case 131:
									case 132:
									case 134:
									case 138:
									case 140:
									case 142:
									case 143:
									case 144:
										return commitTransactionStatement;
									}
								}
								else
								{
									switch (num2)
									{
									case 156:
									case 160:
									case 161:
									case 162:
										return commitTransactionStatement;
									case 157:
									case 158:
									case 159:
										break;
									default:
										switch (num2)
										{
										case 167:
										case 170:
										case 172:
										case 173:
											return commitTransactionStatement;
										case 168:
										case 169:
										case 171:
											break;
										default:
											if (num2 == 176)
											{
												return commitTransactionStatement;
											}
											break;
										}
										break;
									}
								}
							}
							IL_60F:
							throw new NoViableAltException(this.LT(1), this.getFilename());
						}
						case 155:
						case 157:
						case 158:
						case 159:
							break;
						case 156:
						case 160:
						case 161:
						case 162:
							return commitTransactionStatement;
						default:
							switch (num)
							{
							case 167:
							case 170:
							case 172:
							case 173:
								return commitTransactionStatement;
							}
							break;
						}
						break;
					}
				}
			}
			else if (num <= 191)
			{
				if (num == 176)
				{
					return commitTransactionStatement;
				}
				switch (num)
				{
				case 180:
				case 181:
					return commitTransactionStatement;
				default:
					if (num == 191)
					{
						return commitTransactionStatement;
					}
					break;
				}
			}
			else
			{
				if (num == 204)
				{
					return commitTransactionStatement;
				}
				switch (num)
				{
				case 219:
				case 220:
					return commitTransactionStatement;
				default:
					if (num == 232)
					{
						IToken token4 = this.LT(1);
						this.match(232);
						if (this.inputState.guessing == 0)
						{
							TSql80ParserBaseInternal.Match(token4, "WORK");
							return commitTransactionStatement;
						}
						return commitTransactionStatement;
					}
					break;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x0004FBB8 File Offset: 0x0004DDB8
		public CreateStatisticsStatement createStatisticsStatement()
		{
			CreateStatisticsStatement createStatisticsStatement = base.FragmentFactory.CreateFragment<CreateStatisticsStatement>();
			bool flag = false;
			IToken token = this.LT(1);
			this.match(35);
			IToken token2 = this.LT(1);
			this.match(146);
			Identifier name = this.identifier();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(createStatisticsStatement, token);
				TSql80ParserBaseInternal.UpdateTokenInfo(createStatisticsStatement, token2);
				createStatisticsStatement.Name = name;
			}
			this.match(105);
			SchemaObjectName onName = this.schemaObjectThreePartName();
			if (this.inputState.guessing == 0)
			{
				createStatisticsStatement.OnName = onName;
				base.ThrowPartialAstIfPhaseOne(createStatisticsStatement);
			}
			this.identifierColumnList(createStatisticsStatement, createStatisticsStatement.Columns);
			int num = this.LA(1);
			if (num <= 86)
			{
				if (num <= 28)
				{
					if (num <= 6)
					{
						if (num == 1 || num == 6)
						{
							return createStatisticsStatement;
						}
					}
					else
					{
						switch (num)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							return createStatisticsStatement;
						case 14:
						case 16:
							break;
						default:
							switch (num)
							{
							case 22:
							case 23:
								return createStatisticsStatement;
							default:
								if (num == 28)
								{
									return createStatisticsStatement;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num <= 64)
				{
					switch (num)
					{
					case 33:
					case 35:
						return createStatisticsStatement;
					case 34:
						break;
					default:
						switch (num)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							return createStatisticsStatement;
						}
						break;
					}
				}
				else
				{
					switch (num)
					{
					case 74:
					case 75:
						return createStatisticsStatement;
					default:
						if (num == 82 || num == 86)
						{
							return createStatisticsStatement;
						}
						break;
					}
				}
			}
			else if (num <= 144)
			{
				if (num <= 95)
				{
					if (num == 92 || num == 95)
					{
						return createStatisticsStatement;
					}
				}
				else
				{
					if (num == 106 || num == 119)
					{
						return createStatisticsStatement;
					}
					switch (num)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return createStatisticsStatement;
					}
				}
			}
			else if (num <= 181)
			{
				switch (num)
				{
				case 156:
				case 160:
				case 161:
				case 162:
					return createStatisticsStatement;
				case 157:
				case 158:
				case 159:
					break;
				default:
					switch (num)
					{
					case 167:
					case 170:
					case 172:
					case 173:
					case 176:
					case 180:
					case 181:
						return createStatisticsStatement;
					case 171:
					{
						this.match(171);
						StatisticsOption item = this.createStatisticsStatementWithOption(ref flag);
						if (this.inputState.guessing == 0)
						{
							TSql80ParserBaseInternal.AddAndUpdateTokenInfo<StatisticsOption>(createStatisticsStatement, createStatisticsStatement.StatisticsOptions, item);
						}
						while (this.LA(1) == 198)
						{
							this.match(198);
							item = this.createStatisticsStatementWithOption(ref flag);
							if (this.inputState.guessing == 0)
							{
								TSql80ParserBaseInternal.AddAndUpdateTokenInfo<StatisticsOption>(createStatisticsStatement, createStatisticsStatement.StatisticsOptions, item);
							}
						}
						return createStatisticsStatement;
					}
					}
					break;
				}
			}
			else
			{
				if (num == 191 || num == 204)
				{
					return createStatisticsStatement;
				}
				switch (num)
				{
				case 219:
				case 220:
					return createStatisticsStatement;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x0004FF50 File Offset: 0x0004E150
		public UpdateStatisticsStatement updateStatisticsStatement()
		{
			UpdateStatisticsStatement updateStatisticsStatement = base.FragmentFactory.CreateFragment<UpdateStatisticsStatement>();
			bool flag = false;
			IToken token = this.LT(1);
			this.match(160);
			IToken token2 = this.LT(1);
			this.match(146);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(updateStatisticsStatement, token);
				TSql80ParserBaseInternal.UpdateTokenInfo(updateStatisticsStatement, token2);
			}
			SchemaObjectName schemaObjectName = this.schemaObjectThreePartName();
			if (this.inputState.guessing == 0)
			{
				updateStatisticsStatement.SchemaObjectName = schemaObjectName;
			}
			bool flag2 = false;
			if (this.LA(1) == 191 && (this.LA(2) == 232 || this.LA(2) == 233))
			{
				int pos = this.mark();
				flag2 = true;
				this.inputState.guessing++;
				try
				{
					this.match(191);
					this.identifier();
				}
				catch (RecognitionException)
				{
					flag2 = false;
				}
				this.rewind(pos);
				this.inputState.guessing--;
			}
			if (flag2)
			{
				this.columnNameList(updateStatisticsStatement, updateStatisticsStatement.SubElements);
			}
			else if (this.LA(1) == 232 || this.LA(1) == 233)
			{
				Identifier item = this.identifier();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<Identifier>(updateStatisticsStatement, updateStatisticsStatement.SubElements, item);
				}
			}
			else if (!TSql80ParserInternal.tokenSet_15_.member(this.LA(1)) || !TSql80ParserInternal.tokenSet_11_.member(this.LA(2)))
			{
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			int num = this.LA(1);
			if (num <= 86)
			{
				if (num <= 28)
				{
					if (num <= 6)
					{
						if (num == 1 || num == 6)
						{
							return updateStatisticsStatement;
						}
					}
					else
					{
						switch (num)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							return updateStatisticsStatement;
						case 14:
						case 16:
							break;
						default:
							switch (num)
							{
							case 22:
							case 23:
								return updateStatisticsStatement;
							default:
								if (num == 28)
								{
									return updateStatisticsStatement;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num <= 64)
				{
					switch (num)
					{
					case 33:
					case 35:
						return updateStatisticsStatement;
					case 34:
						break;
					default:
						switch (num)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							return updateStatisticsStatement;
						}
						break;
					}
				}
				else
				{
					switch (num)
					{
					case 74:
					case 75:
						return updateStatisticsStatement;
					default:
						if (num == 82 || num == 86)
						{
							return updateStatisticsStatement;
						}
						break;
					}
				}
			}
			else if (num <= 144)
			{
				if (num <= 95)
				{
					if (num == 92 || num == 95)
					{
						return updateStatisticsStatement;
					}
				}
				else
				{
					if (num == 106 || num == 119)
					{
						return updateStatisticsStatement;
					}
					switch (num)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return updateStatisticsStatement;
					}
				}
			}
			else if (num <= 181)
			{
				switch (num)
				{
				case 156:
				case 160:
				case 161:
				case 162:
					return updateStatisticsStatement;
				case 157:
				case 158:
				case 159:
					break;
				default:
					switch (num)
					{
					case 167:
					case 170:
					case 172:
					case 173:
					case 176:
					case 180:
					case 181:
						return updateStatisticsStatement;
					case 171:
					{
						this.match(171);
						StatisticsOption item2 = this.updateStatisticsStatementWithOption(ref flag);
						if (this.inputState.guessing == 0)
						{
							TSql80ParserBaseInternal.AddAndUpdateTokenInfo<StatisticsOption>(updateStatisticsStatement, updateStatisticsStatement.StatisticsOptions, item2);
						}
						while (this.LA(1) == 198)
						{
							this.match(198);
							item2 = this.updateStatisticsStatementWithOption(ref flag);
							if (this.inputState.guessing == 0)
							{
								TSql80ParserBaseInternal.AddAndUpdateTokenInfo<StatisticsOption>(updateStatisticsStatement, updateStatisticsStatement.StatisticsOptions, item2);
							}
						}
						return updateStatisticsStatement;
					}
					}
					break;
				}
			}
			else
			{
				if (num == 191 || num == 204)
				{
					return updateStatisticsStatement;
				}
				switch (num)
				{
				case 219:
				case 220:
					return updateStatisticsStatement;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x000503DC File Offset: 0x0004E5DC
		public AlterDatabaseStatement alterDatabaseStatements()
		{
			AlterDatabaseStatement alterDatabaseStatement = null;
			IToken token = null;
			Identifier databaseName = null;
			try
			{
				token = this.LT(1);
				this.match(6);
				this.match(43);
				int num = this.LA(1);
				if (num != 226)
				{
					switch (num)
					{
					case 232:
					case 233:
						databaseName = this.identifier();
						break;
					default:
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
				}
				else
				{
					databaseName = this.sqlCommandIdentifier();
				}
				int num2 = this.LA(1);
				if (num2 != 4)
				{
					if (num2 != 26)
					{
						if (num2 != 142)
						{
							if (this.LA(1) == 232 && (this.LA(2) == 65 || this.LA(2) == 232) && base.NextTokenMatches("REMOVE"))
							{
								alterDatabaseStatement = this.alterDbRemove();
							}
							else
							{
								if (this.LA(1) != 232 || (this.LA(2) != 65 && this.LA(2) != 232) || !base.NextTokenMatches("MODIFY"))
								{
									throw new NoViableAltException(this.LT(1), this.getFilename());
								}
								alterDatabaseStatement = this.alterDbModify();
							}
						}
						else
						{
							alterDatabaseStatement = this.alterDbSet();
						}
					}
					else
					{
						alterDatabaseStatement = this.alterDbCollate();
					}
				}
				else
				{
					alterDatabaseStatement = this.alterDbAdd();
				}
				if (this.inputState.guessing == 0)
				{
					alterDatabaseStatement.DatabaseName = databaseName;
					TSql80ParserBaseInternal.UpdateTokenInfo(alterDatabaseStatement, token);
					base.ThrowPartialAstIfPhaseOne(alterDatabaseStatement);
				}
			}
			catch (PhaseOnePartialAstException ex)
			{
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(ex.Statement, token);
					(ex.Statement as AlterDatabaseStatement).DatabaseName = databaseName;
					throw;
				}
				throw;
			}
			return alterDatabaseStatement;
		}

		// Token: 0x0600124B RID: 4683 RVA: 0x00050594 File Offset: 0x0004E794
		public ExecuteStatement executeStatement()
		{
			ExecuteStatement executeStatement = base.FragmentFactory.CreateFragment<ExecuteStatement>();
			ExecuteSpecification executeSpecification = this.executeSpecification();
			if (this.inputState.guessing == 0)
			{
				executeStatement.ExecuteSpecification = executeSpecification;
				base.ThrowPartialAstIfPhaseOne(executeStatement);
			}
			int num = this.LA(1);
			if (num <= 86)
			{
				if (num <= 28)
				{
					if (num <= 6)
					{
						if (num == 1 || num == 6)
						{
							return executeStatement;
						}
					}
					else
					{
						switch (num)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							return executeStatement;
						case 14:
						case 16:
							break;
						default:
							switch (num)
							{
							case 22:
							case 23:
								return executeStatement;
							default:
								if (num == 28)
								{
									return executeStatement;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num <= 64)
				{
					switch (num)
					{
					case 33:
					case 35:
						return executeStatement;
					case 34:
						break;
					default:
						switch (num)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							return executeStatement;
						}
						break;
					}
				}
				else
				{
					switch (num)
					{
					case 74:
					case 75:
						return executeStatement;
					default:
						if (num == 82 || num == 86)
						{
							return executeStatement;
						}
						break;
					}
				}
			}
			else if (num <= 144)
			{
				if (num <= 95)
				{
					if (num == 92 || num == 95)
					{
						return executeStatement;
					}
				}
				else
				{
					if (num == 106 || num == 119)
					{
						return executeStatement;
					}
					switch (num)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return executeStatement;
					}
				}
			}
			else if (num <= 181)
			{
				switch (num)
				{
				case 156:
				case 160:
				case 161:
				case 162:
					return executeStatement;
				case 157:
				case 158:
				case 159:
					break;
				default:
					switch (num)
					{
					case 167:
					case 170:
					case 172:
					case 173:
					case 176:
					case 180:
					case 181:
						return executeStatement;
					case 171:
					{
						this.match(171);
						ExecuteOption item = this.executeOption();
						if (this.inputState.guessing == 0)
						{
							TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ExecuteOption>(executeStatement, executeStatement.Options, item);
							return executeStatement;
						}
						return executeStatement;
					}
					}
					break;
				}
			}
			else
			{
				if (num == 191 || num == 204)
				{
					return executeStatement;
				}
				switch (num)
				{
				case 219:
				case 220:
					return executeStatement;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x0600124C RID: 4684 RVA: 0x0005085C File Offset: 0x0004EA5C
		public SelectStatement select()
		{
			SelectStatement selectStatement = base.FragmentFactory.CreateFragment<SelectStatement>();
			QueryExpression queryExpression = this.queryExpression(selectStatement);
			int num = this.LA(1);
			if (num <= 92)
			{
				if (num <= 35)
				{
					if (num <= 17)
					{
						if (num != 1 && num != 6)
						{
							switch (num)
							{
							case 12:
							case 13:
							case 15:
							case 17:
								break;
							case 14:
							case 16:
								goto IL_2BC;
							default:
								goto IL_2BC;
							}
						}
					}
					else
					{
						switch (num)
						{
						case 22:
						case 23:
							break;
						default:
							switch (num)
							{
							case 28:
							case 29:
								break;
							default:
								switch (num)
								{
								case 33:
								case 35:
									break;
								case 34:
									goto IL_2BC;
								default:
									goto IL_2BC;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num <= 75)
				{
					switch (num)
					{
					case 44:
					case 45:
					case 46:
					case 48:
					case 49:
					case 54:
					case 55:
					case 56:
					case 60:
					case 61:
					case 64:
						break;
					case 47:
					case 50:
					case 51:
					case 52:
					case 53:
					case 57:
					case 58:
					case 59:
					case 62:
					case 63:
						goto IL_2BC;
					default:
						if (num != 67)
						{
							switch (num)
							{
							case 74:
							case 75:
								break;
							default:
								goto IL_2BC;
							}
						}
						break;
					}
				}
				else if (num != 82 && num != 86 && num != 92)
				{
					goto IL_2BC;
				}
			}
			else if (num <= 162)
			{
				if (num <= 113)
				{
					if (num != 95 && num != 106)
					{
						switch (num)
						{
						case 111:
							break;
						case 112:
							goto IL_2BC;
						case 113:
						{
							OrderByClause orderByClause = this.orderByClause();
							if (this.inputState.guessing == 0)
							{
								queryExpression.OrderByClause = orderByClause;
							}
							break;
						}
						default:
							goto IL_2BC;
						}
					}
				}
				else if (num != 119)
				{
					switch (num)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						break;
					case 124:
					case 127:
					case 128:
					case 130:
					case 133:
					case 135:
					case 136:
					case 137:
					case 139:
					case 141:
						goto IL_2BC;
					default:
						switch (num)
						{
						case 156:
						case 160:
						case 161:
						case 162:
							break;
						case 157:
						case 158:
						case 159:
							goto IL_2BC;
						default:
							goto IL_2BC;
						}
						break;
					}
				}
			}
			else if (num <= 181)
			{
				switch (num)
				{
				case 167:
				case 170:
				case 172:
				case 173:
					break;
				case 168:
				case 169:
				case 171:
					goto IL_2BC;
				default:
					if (num != 176)
					{
						switch (num)
						{
						case 180:
						case 181:
							break;
						default:
							goto IL_2BC;
						}
					}
					break;
				}
			}
			else if (num != 191 && num != 204)
			{
				switch (num)
				{
				case 219:
				case 220:
					break;
				default:
					goto IL_2BC;
				}
			}
			while (this.LA(1) == 29)
			{
				ComputeClause item = this.computeClause();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ComputeClause>(selectStatement, selectStatement.ComputeClauses, item);
				}
			}
			int num2 = this.LA(1);
			if (num2 <= 92)
			{
				if (num2 <= 35)
				{
					if (num2 <= 17)
					{
						if (num2 == 1 || num2 == 6)
						{
							goto IL_5A4;
						}
						switch (num2)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							goto IL_5A4;
						}
					}
					else
					{
						switch (num2)
						{
						case 22:
						case 23:
							goto IL_5A4;
						default:
							if (num2 == 28)
							{
								goto IL_5A4;
							}
							switch (num2)
							{
							case 33:
							case 35:
								goto IL_5A4;
							}
							break;
						}
					}
				}
				else if (num2 <= 75)
				{
					switch (num2)
					{
					case 44:
					case 45:
					case 46:
					case 48:
					case 49:
					case 54:
					case 55:
					case 56:
					case 60:
					case 61:
					case 64:
						goto IL_5A4;
					case 47:
					case 50:
					case 51:
					case 52:
					case 53:
					case 57:
					case 58:
					case 59:
					case 62:
					case 63:
						break;
					default:
						if (num2 != 67)
						{
							switch (num2)
							{
							case 74:
							case 75:
								goto IL_5A4;
							}
						}
						else
						{
							ForClause forClause = this.forClause();
							if (this.inputState.guessing == 0)
							{
								queryExpression.ForClause = forClause;
								goto IL_5A4;
							}
							goto IL_5A4;
						}
						break;
					}
				}
				else if (num2 == 82 || num2 == 86 || num2 == 92)
				{
					goto IL_5A4;
				}
			}
			else if (num2 <= 162)
			{
				if (num2 <= 111)
				{
					if (num2 == 95 || num2 == 106 || num2 == 111)
					{
						goto IL_5A4;
					}
				}
				else
				{
					if (num2 == 119)
					{
						goto IL_5A4;
					}
					switch (num2)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						goto IL_5A4;
					case 124:
					case 127:
					case 128:
					case 130:
					case 133:
					case 135:
					case 136:
					case 137:
					case 139:
					case 141:
						break;
					default:
						switch (num2)
						{
						case 156:
						case 160:
						case 161:
						case 162:
							goto IL_5A4;
						}
						break;
					}
				}
			}
			else if (num2 <= 181)
			{
				switch (num2)
				{
				case 167:
				case 170:
				case 172:
				case 173:
					goto IL_5A4;
				case 168:
				case 169:
				case 171:
					break;
				default:
					if (num2 == 176)
					{
						goto IL_5A4;
					}
					switch (num2)
					{
					case 180:
					case 181:
						goto IL_5A4;
					}
					break;
				}
			}
			else
			{
				if (num2 == 191 || num2 == 204)
				{
					goto IL_5A4;
				}
				switch (num2)
				{
				case 219:
				case 220:
					goto IL_5A4;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_5A4:
			int num3 = this.LA(1);
			if (num3 <= 92)
			{
				if (num3 <= 28)
				{
					if (num3 <= 6)
					{
						if (num3 == 1 || num3 == 6)
						{
							goto IL_834;
						}
					}
					else
					{
						switch (num3)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							goto IL_834;
						case 14:
						case 16:
							break;
						default:
							switch (num3)
							{
							case 22:
							case 23:
								goto IL_834;
							default:
								if (num3 == 28)
								{
									goto IL_834;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num3 <= 75)
				{
					switch (num3)
					{
					case 33:
					case 35:
						goto IL_834;
					case 34:
						break;
					default:
						switch (num3)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							goto IL_834;
						case 47:
						case 50:
						case 51:
						case 52:
						case 53:
						case 57:
						case 58:
						case 59:
						case 62:
						case 63:
							break;
						default:
							switch (num3)
							{
							case 74:
							case 75:
								goto IL_834;
							}
							break;
						}
						break;
					}
				}
				else if (num3 == 82 || num3 == 86 || num3 == 92)
				{
					goto IL_834;
				}
			}
			else if (num3 <= 162)
			{
				if (num3 <= 111)
				{
					if (num3 == 95 || num3 == 106)
					{
						goto IL_834;
					}
					if (num3 == 111)
					{
						this.optimizerHints(selectStatement, selectStatement.OptimizerHints);
						goto IL_834;
					}
				}
				else
				{
					if (num3 == 119)
					{
						goto IL_834;
					}
					switch (num3)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						goto IL_834;
					case 124:
					case 127:
					case 128:
					case 130:
					case 133:
					case 135:
					case 136:
					case 137:
					case 139:
					case 141:
						break;
					default:
						switch (num3)
						{
						case 156:
						case 160:
						case 161:
						case 162:
							goto IL_834;
						}
						break;
					}
				}
			}
			else if (num3 <= 181)
			{
				switch (num3)
				{
				case 167:
				case 170:
				case 172:
				case 173:
					goto IL_834;
				case 168:
				case 169:
				case 171:
					break;
				default:
					if (num3 == 176)
					{
						goto IL_834;
					}
					switch (num3)
					{
					case 180:
					case 181:
						goto IL_834;
					}
					break;
				}
			}
			else
			{
				if (num3 == 191 || num3 == 204)
				{
					goto IL_834;
				}
				switch (num3)
				{
				case 219:
				case 220:
					goto IL_834;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_834:
			if (this.inputState.guessing == 0)
			{
				selectStatement.QueryExpression = queryExpression;
			}
			return selectStatement;
			IL_2BC:
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x000510B4 File Offset: 0x0004F2B4
		public DeleteStatement deleteStatement()
		{
			DeleteStatement deleteStatement = base.FragmentFactory.CreateFragment<DeleteStatement>();
			DeleteSpecification deleteSpecification = this.deleteSpecification();
			if (this.inputState.guessing == 0)
			{
				deleteStatement.DeleteSpecification = deleteSpecification;
			}
			int num = this.LA(1);
			if (num <= 92)
			{
				if (num <= 28)
				{
					if (num <= 6)
					{
						if (num == 1 || num == 6)
						{
							return deleteStatement;
						}
					}
					else
					{
						switch (num)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							return deleteStatement;
						case 14:
						case 16:
							break;
						default:
							switch (num)
							{
							case 22:
							case 23:
								return deleteStatement;
							default:
								if (num == 28)
								{
									return deleteStatement;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num <= 75)
				{
					switch (num)
					{
					case 33:
					case 35:
						return deleteStatement;
					case 34:
						break;
					default:
						switch (num)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							return deleteStatement;
						case 47:
						case 50:
						case 51:
						case 52:
						case 53:
						case 57:
						case 58:
						case 59:
						case 62:
						case 63:
							break;
						default:
							switch (num)
							{
							case 74:
							case 75:
								return deleteStatement;
							}
							break;
						}
						break;
					}
				}
				else if (num == 82 || num == 86 || num == 92)
				{
					return deleteStatement;
				}
			}
			else if (num <= 162)
			{
				if (num <= 111)
				{
					if (num == 95 || num == 106)
					{
						return deleteStatement;
					}
					if (num == 111)
					{
						this.optimizerHints(deleteStatement, deleteStatement.OptimizerHints);
						return deleteStatement;
					}
				}
				else
				{
					if (num == 119)
					{
						return deleteStatement;
					}
					switch (num)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return deleteStatement;
					case 124:
					case 127:
					case 128:
					case 130:
					case 133:
					case 135:
					case 136:
					case 137:
					case 139:
					case 141:
						break;
					default:
						switch (num)
						{
						case 156:
						case 160:
						case 161:
						case 162:
							return deleteStatement;
						}
						break;
					}
				}
			}
			else if (num <= 181)
			{
				switch (num)
				{
				case 167:
				case 170:
				case 172:
				case 173:
					return deleteStatement;
				case 168:
				case 169:
				case 171:
					break;
				default:
					if (num == 176)
					{
						return deleteStatement;
					}
					switch (num)
					{
					case 180:
					case 181:
						return deleteStatement;
					}
					break;
				}
			}
			else
			{
				if (num == 191 || num == 204)
				{
					return deleteStatement;
				}
				switch (num)
				{
				case 219:
				case 220:
					return deleteStatement;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x0005135C File Offset: 0x0004F55C
		public InsertStatement insertStatement()
		{
			InsertStatement insertStatement = base.FragmentFactory.CreateFragment<InsertStatement>();
			InsertSpecification insertSpecification = this.insertSpecification();
			if (this.inputState.guessing == 0)
			{
				insertStatement.InsertSpecification = insertSpecification;
			}
			int num = this.LA(1);
			if (num <= 92)
			{
				if (num <= 28)
				{
					if (num <= 6)
					{
						if (num == 1 || num == 6)
						{
							return insertStatement;
						}
					}
					else
					{
						switch (num)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							return insertStatement;
						case 14:
						case 16:
							break;
						default:
							switch (num)
							{
							case 22:
							case 23:
								return insertStatement;
							default:
								if (num == 28)
								{
									return insertStatement;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num <= 75)
				{
					switch (num)
					{
					case 33:
					case 35:
						return insertStatement;
					case 34:
						break;
					default:
						switch (num)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							return insertStatement;
						case 47:
						case 50:
						case 51:
						case 52:
						case 53:
						case 57:
						case 58:
						case 59:
						case 62:
						case 63:
							break;
						default:
							switch (num)
							{
							case 74:
							case 75:
								return insertStatement;
							}
							break;
						}
						break;
					}
				}
				else if (num == 82 || num == 86 || num == 92)
				{
					return insertStatement;
				}
			}
			else if (num <= 162)
			{
				if (num <= 111)
				{
					if (num == 95 || num == 106)
					{
						return insertStatement;
					}
					if (num == 111)
					{
						this.optimizerHints(insertStatement, insertStatement.OptimizerHints);
						return insertStatement;
					}
				}
				else
				{
					if (num == 119)
					{
						return insertStatement;
					}
					switch (num)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return insertStatement;
					case 124:
					case 127:
					case 128:
					case 130:
					case 133:
					case 135:
					case 136:
					case 137:
					case 139:
					case 141:
						break;
					default:
						switch (num)
						{
						case 156:
						case 160:
						case 161:
						case 162:
							return insertStatement;
						}
						break;
					}
				}
			}
			else if (num <= 181)
			{
				switch (num)
				{
				case 167:
				case 170:
				case 172:
				case 173:
					return insertStatement;
				case 168:
				case 169:
				case 171:
					break;
				default:
					if (num == 176)
					{
						return insertStatement;
					}
					switch (num)
					{
					case 180:
					case 181:
						return insertStatement;
					}
					break;
				}
			}
			else
			{
				if (num == 191 || num == 204)
				{
					return insertStatement;
				}
				switch (num)
				{
				case 219:
				case 220:
					return insertStatement;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x00051604 File Offset: 0x0004F804
		public UpdateStatement updateStatement()
		{
			UpdateStatement updateStatement = base.FragmentFactory.CreateFragment<UpdateStatement>();
			UpdateSpecification updateSpecification = this.updateSpecification();
			if (this.inputState.guessing == 0)
			{
				updateStatement.UpdateSpecification = updateSpecification;
			}
			int num = this.LA(1);
			if (num <= 92)
			{
				if (num <= 28)
				{
					if (num <= 6)
					{
						if (num == 1 || num == 6)
						{
							return updateStatement;
						}
					}
					else
					{
						switch (num)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							return updateStatement;
						case 14:
						case 16:
							break;
						default:
							switch (num)
							{
							case 22:
							case 23:
								return updateStatement;
							default:
								if (num == 28)
								{
									return updateStatement;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num <= 75)
				{
					switch (num)
					{
					case 33:
					case 35:
						return updateStatement;
					case 34:
						break;
					default:
						switch (num)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							return updateStatement;
						case 47:
						case 50:
						case 51:
						case 52:
						case 53:
						case 57:
						case 58:
						case 59:
						case 62:
						case 63:
							break;
						default:
							switch (num)
							{
							case 74:
							case 75:
								return updateStatement;
							}
							break;
						}
						break;
					}
				}
				else if (num == 82 || num == 86 || num == 92)
				{
					return updateStatement;
				}
			}
			else if (num <= 162)
			{
				if (num <= 111)
				{
					if (num == 95 || num == 106)
					{
						return updateStatement;
					}
					if (num == 111)
					{
						this.optimizerHints(updateStatement, updateStatement.OptimizerHints);
						return updateStatement;
					}
				}
				else
				{
					if (num == 119)
					{
						return updateStatement;
					}
					switch (num)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return updateStatement;
					case 124:
					case 127:
					case 128:
					case 130:
					case 133:
					case 135:
					case 136:
					case 137:
					case 139:
					case 141:
						break;
					default:
						switch (num)
						{
						case 156:
						case 160:
						case 161:
						case 162:
							return updateStatement;
						}
						break;
					}
				}
			}
			else if (num <= 181)
			{
				switch (num)
				{
				case 167:
				case 170:
				case 172:
				case 173:
					return updateStatement;
				case 168:
				case 169:
				case 171:
					break;
				default:
					if (num == 176)
					{
						return updateStatement;
					}
					switch (num)
					{
					case 180:
					case 181:
						return updateStatement;
					}
					break;
				}
			}
			else
			{
				if (num == 191 || num == 204)
				{
					return updateStatement;
				}
				switch (num)
				{
				case 219:
				case 220:
					return updateStatement;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x000518AC File Offset: 0x0004FAAC
		public TSqlStatement raiseErrorStatements()
		{
			IToken token = this.LT(1);
			this.match(123);
			int num = this.LA(1);
			TSqlStatement tsqlStatement;
			if (num <= 199)
			{
				if (num == 191)
				{
					tsqlStatement = this.raiseErrorStatement();
					goto IL_6D;
				}
				if (num != 199)
				{
					goto IL_5A;
				}
			}
			else if (num != 221 && num != 234)
			{
				goto IL_5A;
			}
			tsqlStatement = this.raiseErrorLegacyStatement();
			goto IL_6D;
			IL_5A:
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_6D:
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(tsqlStatement, token);
			}
			return tsqlStatement;
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x0005193C File Offset: 0x0004FB3C
		public CreateDatabaseStatement createDatabaseStatement()
		{
			CreateDatabaseStatement createDatabaseStatement = base.FragmentFactory.CreateFragment<CreateDatabaseStatement>();
			IToken token = this.LT(1);
			this.match(35);
			this.match(43);
			Identifier databaseName = this.identifier();
			if (this.inputState.guessing == 0)
			{
				createDatabaseStatement.DatabaseName = databaseName;
				TSql80ParserBaseInternal.UpdateTokenInfo(createDatabaseStatement, token);
				base.ThrowPartialAstIfPhaseOne(createDatabaseStatement);
			}
			this.recoveryUnitList(createDatabaseStatement);
			this.collationOpt(createDatabaseStatement);
			int num = this.LA(1);
			if (num <= 86)
			{
				if (num <= 28)
				{
					if (num <= 6)
					{
						if (num == 1 || num == 6)
						{
							return createDatabaseStatement;
						}
					}
					else
					{
						switch (num)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							return createDatabaseStatement;
						case 14:
						case 16:
							break;
						default:
							switch (num)
							{
							case 22:
							case 23:
								return createDatabaseStatement;
							default:
								if (num == 28)
								{
									return createDatabaseStatement;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num <= 67)
				{
					switch (num)
					{
					case 33:
					case 35:
						return createDatabaseStatement;
					case 34:
						break;
					default:
						switch (num)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							return createDatabaseStatement;
						case 47:
						case 50:
						case 51:
						case 52:
						case 53:
						case 57:
						case 58:
						case 59:
						case 62:
						case 63:
							break;
						default:
							if (num == 67)
							{
								this.dbAddendums(createDatabaseStatement);
								return createDatabaseStatement;
							}
							break;
						}
						break;
					}
				}
				else
				{
					switch (num)
					{
					case 74:
					case 75:
						return createDatabaseStatement;
					default:
						if (num == 82 || num == 86)
						{
							return createDatabaseStatement;
						}
						break;
					}
				}
			}
			else if (num <= 162)
			{
				if (num <= 106)
				{
					if (num == 92 || num == 95 || num == 106)
					{
						return createDatabaseStatement;
					}
				}
				else
				{
					if (num == 119)
					{
						return createDatabaseStatement;
					}
					switch (num)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return createDatabaseStatement;
					case 124:
					case 127:
					case 128:
					case 130:
					case 133:
					case 135:
					case 136:
					case 137:
					case 139:
					case 141:
						break;
					default:
						switch (num)
						{
						case 156:
						case 160:
						case 161:
						case 162:
							return createDatabaseStatement;
						}
						break;
					}
				}
			}
			else if (num <= 181)
			{
				switch (num)
				{
				case 167:
				case 170:
				case 172:
				case 173:
					return createDatabaseStatement;
				case 168:
				case 169:
				case 171:
					break;
				default:
					if (num == 176)
					{
						return createDatabaseStatement;
					}
					switch (num)
					{
					case 180:
					case 181:
						return createDatabaseStatement;
					}
					break;
				}
			}
			else
			{
				if (num == 191 || num == 204)
				{
					return createDatabaseStatement;
				}
				switch (num)
				{
				case 219:
				case 220:
					return createDatabaseStatement;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x00051C0C File Offset: 0x0004FE0C
		public PrintStatement printStatement()
		{
			PrintStatement printStatement = base.FragmentFactory.CreateFragment<PrintStatement>();
			IToken token = this.LT(1);
			this.match(119);
			ScalarExpression expression = this.expression();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(printStatement, token);
				printStatement.Expression = expression;
			}
			return printStatement;
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x00051C5C File Offset: 0x0004FE5C
		public WaitForStatement waitForStatement()
		{
			WaitForStatement waitForStatement = base.FragmentFactory.CreateFragment<WaitForStatement>();
			IToken token = this.LT(1);
			this.match(167);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(waitForStatement, token);
			}
			IToken token2 = this.LT(1);
			this.match(232);
			ValueExpression parameter = this.stringOrVariable();
			if (this.inputState.guessing == 0)
			{
				waitForStatement.WaitForOption = WaitForOptionHelper.Instance.ParseOption(token2);
				waitForStatement.Parameter = parameter;
			}
			return waitForStatement;
		}

		// Token: 0x06001254 RID: 4692 RVA: 0x00051CE0 File Offset: 0x0004FEE0
		public ReadTextStatement readTextStatement()
		{
			ReadTextStatement readTextStatement = base.FragmentFactory.CreateFragment<ReadTextStatement>();
			IToken token = this.LT(1);
			this.match(125);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(readTextStatement, token);
			}
			ColumnReferenceExpression column = this.column();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.CheckTableNameExistsForColumn(column, true);
				readTextStatement.Column = column;
			}
			ValueExpression valueExpression = this.binaryOrVariable();
			if (this.inputState.guessing == 0)
			{
				readTextStatement.TextPointer = valueExpression;
			}
			valueExpression = this.integerOrVariable();
			if (this.inputState.guessing == 0)
			{
				readTextStatement.Offset = valueExpression;
			}
			valueExpression = this.integerOrVariable();
			if (this.inputState.guessing == 0)
			{
				readTextStatement.Size = valueExpression;
			}
			int num = this.LA(1);
			if (num <= 92)
			{
				if (num <= 28)
				{
					if (num <= 6)
					{
						if (num == 1 || num == 6)
						{
							return readTextStatement;
						}
					}
					else
					{
						switch (num)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							return readTextStatement;
						case 14:
						case 16:
							break;
						default:
							switch (num)
							{
							case 22:
							case 23:
								return readTextStatement;
							default:
								if (num == 28)
								{
									return readTextStatement;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num <= 78)
				{
					switch (num)
					{
					case 33:
					case 35:
						return readTextStatement;
					case 34:
						break;
					default:
						switch (num)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							return readTextStatement;
						case 47:
						case 50:
						case 51:
						case 52:
						case 53:
						case 57:
						case 58:
						case 59:
						case 62:
						case 63:
							break;
						default:
							switch (num)
							{
							case 74:
							case 75:
								return readTextStatement;
							case 78:
							{
								IToken token2 = this.LT(1);
								this.match(78);
								if (this.inputState.guessing == 0)
								{
									TSql80ParserBaseInternal.UpdateTokenInfo(readTextStatement, token2);
									readTextStatement.HoldLock = true;
									return readTextStatement;
								}
								return readTextStatement;
							}
							}
							break;
						}
						break;
					}
				}
				else if (num == 82 || num == 86 || num == 92)
				{
					return readTextStatement;
				}
			}
			else if (num <= 162)
			{
				if (num <= 106)
				{
					if (num == 95 || num == 106)
					{
						return readTextStatement;
					}
				}
				else
				{
					if (num == 119)
					{
						return readTextStatement;
					}
					switch (num)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return readTextStatement;
					case 124:
					case 127:
					case 128:
					case 130:
					case 133:
					case 135:
					case 136:
					case 137:
					case 139:
					case 141:
						break;
					default:
						switch (num)
						{
						case 156:
						case 160:
						case 161:
						case 162:
							return readTextStatement;
						}
						break;
					}
				}
			}
			else if (num <= 181)
			{
				switch (num)
				{
				case 167:
				case 170:
				case 172:
				case 173:
					return readTextStatement;
				case 168:
				case 169:
				case 171:
					break;
				default:
					if (num == 176)
					{
						return readTextStatement;
					}
					switch (num)
					{
					case 180:
					case 181:
						return readTextStatement;
					}
					break;
				}
			}
			else
			{
				if (num == 191 || num == 204)
				{
					return readTextStatement;
				}
				switch (num)
				{
				case 219:
				case 220:
					return readTextStatement;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x06001255 RID: 4693 RVA: 0x00052050 File Offset: 0x00050250
		public UpdateTextStatement updateTextStatement()
		{
			UpdateTextStatement updateTextStatement = base.FragmentFactory.CreateFragment<UpdateTextStatement>();
			IToken token = this.LT(1);
			this.match(161);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(updateTextStatement, token);
			}
			this.modificationTextStatement(updateTextStatement);
			ScalarExpression scalarExpression = this.signedIntegerOrVariableOrNull();
			if (this.inputState.guessing == 0)
			{
				updateTextStatement.InsertOffset = scalarExpression;
			}
			scalarExpression = this.signedIntegerOrVariableOrNull();
			if (this.inputState.guessing == 0)
			{
				updateTextStatement.DeleteLength = scalarExpression;
			}
			int num = this.LA(1);
			if (num <= 86)
			{
				if (num <= 28)
				{
					if (num <= 6)
					{
						if (num == 1 || num == 6)
						{
							goto IL_350;
						}
					}
					else
					{
						switch (num)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							goto IL_350;
						case 14:
						case 16:
							break;
						default:
							switch (num)
							{
							case 22:
							case 23:
								goto IL_350;
							default:
								if (num == 28)
								{
									goto IL_350;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num <= 64)
				{
					switch (num)
					{
					case 33:
					case 35:
						goto IL_350;
					case 34:
						break;
					default:
						switch (num)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							goto IL_350;
						}
						break;
					}
				}
				else
				{
					switch (num)
					{
					case 74:
					case 75:
						goto IL_350;
					default:
						switch (num)
						{
						case 81:
						case 82:
							goto IL_350;
						default:
							if (num == 86)
							{
								goto IL_350;
							}
							break;
						}
						break;
					}
				}
			}
			else if (num <= 144)
			{
				if (num <= 95)
				{
					if (num == 92 || num == 95)
					{
						goto IL_350;
					}
				}
				else
				{
					if (num == 100 || num == 106)
					{
						goto IL_350;
					}
					switch (num)
					{
					case 119:
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 136:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						goto IL_350;
					}
				}
			}
			else if (num <= 191)
			{
				switch (num)
				{
				case 156:
				case 160:
				case 161:
				case 162:
					goto IL_350;
				case 157:
				case 158:
				case 159:
					break;
				default:
					switch (num)
					{
					case 167:
					case 170:
					case 172:
					case 173:
					case 176:
					case 180:
					case 181:
						goto IL_350;
					case 168:
					case 169:
					case 174:
					case 175:
					case 177:
					case 178:
					case 179:
						break;
					case 171:
						this.modificationTextStatementWithLog(updateTextStatement);
						goto IL_350;
					default:
						if (num == 191)
						{
							goto IL_350;
						}
						break;
					}
					break;
				}
			}
			else
			{
				if (num == 200 || num == 204)
				{
					goto IL_350;
				}
				switch (num)
				{
				case 219:
				case 220:
				case 224:
				case 227:
				case 230:
				case 231:
				case 232:
				case 233:
				case 234:
					goto IL_350;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_350:
			int num2 = this.LA(1);
			ValueExpression sourceParameter;
			if (num2 <= 92)
			{
				if (num2 <= 28)
				{
					if (num2 <= 6)
					{
						if (num2 != 1 && num2 != 6)
						{
							goto IL_677;
						}
						return updateTextStatement;
					}
					else
					{
						switch (num2)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							return updateTextStatement;
						case 14:
						case 16:
							goto IL_677;
						default:
							switch (num2)
							{
							case 22:
							case 23:
								return updateTextStatement;
							default:
								if (num2 != 28)
								{
									goto IL_677;
								}
								return updateTextStatement;
							}
							break;
						}
					}
				}
				else if (num2 <= 75)
				{
					switch (num2)
					{
					case 33:
					case 35:
						return updateTextStatement;
					case 34:
						goto IL_677;
					default:
						switch (num2)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							return updateTextStatement;
						case 47:
						case 50:
						case 51:
						case 52:
						case 53:
						case 57:
						case 58:
						case 59:
						case 62:
						case 63:
							goto IL_677;
						default:
							switch (num2)
							{
							case 74:
							case 75:
								return updateTextStatement;
							default:
								goto IL_677;
							}
							break;
						}
						break;
					}
				}
				else
				{
					switch (num2)
					{
					case 81:
						break;
					case 82:
						return updateTextStatement;
					default:
						if (num2 != 86 && num2 != 92)
						{
							goto IL_677;
						}
						return updateTextStatement;
					}
				}
			}
			else
			{
				if (num2 <= 173)
				{
					if (num2 <= 106)
					{
						if (num2 == 95)
						{
							return updateTextStatement;
						}
						if (num2 != 100)
						{
							if (num2 != 106)
							{
								goto IL_677;
							}
							return updateTextStatement;
						}
					}
					else
					{
						switch (num2)
						{
						case 119:
						case 123:
						case 125:
						case 126:
						case 129:
						case 131:
						case 132:
						case 134:
						case 138:
						case 140:
						case 142:
						case 143:
						case 144:
							return updateTextStatement;
						case 120:
						case 121:
						case 122:
						case 124:
						case 127:
						case 128:
						case 130:
						case 133:
						case 135:
						case 137:
						case 139:
						case 141:
							goto IL_677;
						case 136:
							goto IL_61B;
						default:
							switch (num2)
							{
							case 156:
							case 160:
							case 161:
							case 162:
								return updateTextStatement;
							case 157:
							case 158:
							case 159:
								goto IL_677;
							default:
								switch (num2)
								{
								case 167:
								case 170:
								case 172:
								case 173:
									return updateTextStatement;
								case 168:
								case 169:
								case 171:
									goto IL_677;
								default:
									goto IL_677;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num2 <= 191)
				{
					if (num2 == 176)
					{
						return updateTextStatement;
					}
					switch (num2)
					{
					case 180:
					case 181:
						return updateTextStatement;
					default:
						if (num2 != 191)
						{
							goto IL_677;
						}
						return updateTextStatement;
					}
				}
				else
				{
					if (num2 == 200)
					{
						goto IL_61B;
					}
					if (num2 == 204)
					{
						return updateTextStatement;
					}
					switch (num2)
					{
					case 219:
					case 220:
						return updateTextStatement;
					case 221:
					case 222:
					case 223:
					case 225:
					case 226:
					case 228:
					case 229:
						goto IL_677;
					case 224:
					case 230:
					case 231:
					case 234:
						break;
					case 227:
					case 232:
					case 233:
						goto IL_61B;
					default:
						goto IL_677;
					}
				}
				sourceParameter = this.writeString();
				if (this.inputState.guessing == 0)
				{
					updateTextStatement.SourceParameter = sourceParameter;
					return updateTextStatement;
				}
				return updateTextStatement;
			}
			IL_61B:
			ColumnReferenceExpression columnReferenceExpression = this.column();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.CheckTableNameExistsForColumn(columnReferenceExpression, true);
				updateTextStatement.SourceColumn = columnReferenceExpression;
			}
			sourceParameter = this.binaryOrVariable();
			if (this.inputState.guessing == 0)
			{
				updateTextStatement.SourceParameter = sourceParameter;
				return updateTextStatement;
			}
			return updateTextStatement;
			IL_677:
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x000526E8 File Offset: 0x000508E8
		public WriteTextStatement writeTextStatement()
		{
			WriteTextStatement writeTextStatement = base.FragmentFactory.CreateFragment<WriteTextStatement>();
			IToken token = this.LT(1);
			this.match(172);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(writeTextStatement, token);
			}
			this.modificationTextStatement(writeTextStatement);
			int num = this.LA(1);
			if (num <= 171)
			{
				if (num == 100)
				{
					goto IL_A1;
				}
				if (num == 171)
				{
					this.modificationTextStatementWithLog(writeTextStatement);
					goto IL_A1;
				}
			}
			else
			{
				if (num == 224)
				{
					goto IL_A1;
				}
				switch (num)
				{
				case 230:
				case 231:
				case 234:
					goto IL_A1;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_A1:
			ValueExpression sourceParameter = this.writeString();
			if (this.inputState.guessing == 0)
			{
				writeTextStatement.SourceParameter = sourceParameter;
			}
			return writeTextStatement;
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x000527B4 File Offset: 0x000509B4
		public LineNoStatement lineNoStatement()
		{
			LineNoStatement lineNoStatement = base.FragmentFactory.CreateFragment<LineNoStatement>();
			IToken token = this.LT(1);
			this.match(95);
			IntegerLiteral lineNo = this.integer();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(lineNoStatement, token);
				lineNoStatement.LineNo = lineNo;
			}
			return lineNoStatement;
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x00052804 File Offset: 0x00050A04
		public UseStatement useStatement()
		{
			UseStatement useStatement = base.FragmentFactory.CreateFragment<UseStatement>();
			IToken token = this.LT(1);
			this.match(162);
			Identifier databaseName = this.identifier();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(useStatement, token);
				useStatement.DatabaseName = databaseName;
			}
			return useStatement;
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x00052858 File Offset: 0x00050A58
		public KillStatement killStatement()
		{
			KillStatement killStatement = base.FragmentFactory.CreateFragment<KillStatement>();
			IToken token = this.LT(1);
			this.match(92);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(killStatement, token);
			}
			int num = this.LA(1);
			ScalarExpression parameter;
			if (num != 199 && num != 221)
			{
				switch (num)
				{
				case 230:
				case 231:
					parameter = this.stringLiteral();
					break;
				default:
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
			}
			else
			{
				parameter = this.signedInteger();
			}
			if (this.inputState.guessing == 0)
			{
				killStatement.Parameter = parameter;
			}
			int num2 = this.LA(1);
			if (num2 <= 86)
			{
				if (num2 <= 28)
				{
					if (num2 <= 6)
					{
						if (num2 == 1 || num2 == 6)
						{
							return killStatement;
						}
					}
					else
					{
						switch (num2)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							return killStatement;
						case 14:
						case 16:
							break;
						default:
							switch (num2)
							{
							case 22:
							case 23:
								return killStatement;
							default:
								if (num2 == 28)
								{
									return killStatement;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num2 <= 64)
				{
					switch (num2)
					{
					case 33:
					case 35:
						return killStatement;
					case 34:
						break;
					default:
						switch (num2)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							return killStatement;
						}
						break;
					}
				}
				else
				{
					switch (num2)
					{
					case 74:
					case 75:
						return killStatement;
					default:
						if (num2 == 82 || num2 == 86)
						{
							return killStatement;
						}
						break;
					}
				}
			}
			else if (num2 <= 144)
			{
				if (num2 <= 95)
				{
					if (num2 == 92 || num2 == 95)
					{
						return killStatement;
					}
				}
				else
				{
					if (num2 == 106 || num2 == 119)
					{
						return killStatement;
					}
					switch (num2)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return killStatement;
					}
				}
			}
			else if (num2 <= 181)
			{
				switch (num2)
				{
				case 156:
				case 160:
				case 161:
				case 162:
					return killStatement;
				case 157:
				case 158:
				case 159:
					break;
				default:
					switch (num2)
					{
					case 167:
					case 170:
					case 172:
					case 173:
					case 176:
					case 180:
					case 181:
						return killStatement;
					case 171:
					{
						this.match(171);
						IToken token2 = this.LT(1);
						this.match(232);
						if (this.inputState.guessing == 0)
						{
							TSql80ParserBaseInternal.Match(token2, "STATUSONLY");
							killStatement.WithStatusOnly = true;
							TSql80ParserBaseInternal.UpdateTokenInfo(killStatement, token2);
							return killStatement;
						}
						return killStatement;
					}
					}
					break;
				}
			}
			else
			{
				if (num2 == 191 || num2 == 204)
				{
					return killStatement;
				}
				switch (num2)
				{
				case 219:
				case 220:
					return killStatement;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x00052BC4 File Offset: 0x00050DC4
		public BulkInsertStatement bulkInsertStatement()
		{
			BulkInsertStatement bulkInsertStatement = base.FragmentFactory.CreateFragment<BulkInsertStatement>();
			IToken token = this.LT(1);
			this.match(17);
			this.match(86);
			SchemaObjectName to = this.schemaObjectThreePartName();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(bulkInsertStatement, token);
				bulkInsertStatement.To = to;
				base.ThrowPartialAstIfPhaseOne(bulkInsertStatement);
			}
			this.match(71);
			IdentifierOrValueExpression from = this.bulkInsertFrom();
			if (this.inputState.guessing == 0)
			{
				bulkInsertStatement.From = from;
			}
			int num = this.LA(1);
			if (num <= 86)
			{
				if (num <= 28)
				{
					if (num <= 6)
					{
						if (num == 1 || num == 6)
						{
							return bulkInsertStatement;
						}
					}
					else
					{
						switch (num)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							return bulkInsertStatement;
						case 14:
						case 16:
							break;
						default:
							switch (num)
							{
							case 22:
							case 23:
								return bulkInsertStatement;
							default:
								if (num == 28)
								{
									return bulkInsertStatement;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num <= 64)
				{
					switch (num)
					{
					case 33:
					case 35:
						return bulkInsertStatement;
					case 34:
						break;
					default:
						switch (num)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							return bulkInsertStatement;
						}
						break;
					}
				}
				else
				{
					switch (num)
					{
					case 74:
					case 75:
						return bulkInsertStatement;
					default:
						if (num == 82 || num == 86)
						{
							return bulkInsertStatement;
						}
						break;
					}
				}
			}
			else if (num <= 144)
			{
				if (num <= 95)
				{
					if (num == 92 || num == 95)
					{
						return bulkInsertStatement;
					}
				}
				else
				{
					if (num == 106 || num == 119)
					{
						return bulkInsertStatement;
					}
					switch (num)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return bulkInsertStatement;
					}
				}
			}
			else if (num <= 181)
			{
				switch (num)
				{
				case 156:
				case 160:
				case 161:
				case 162:
					return bulkInsertStatement;
				case 157:
				case 158:
				case 159:
					break;
				default:
					switch (num)
					{
					case 167:
					case 170:
					case 172:
					case 173:
					case 176:
					case 180:
					case 181:
						return bulkInsertStatement;
					case 171:
						this.bulkInsertOptions(bulkInsertStatement);
						return bulkInsertStatement;
					}
					break;
				}
			}
			else
			{
				if (num == 191 || num == 204)
				{
					return bulkInsertStatement;
				}
				switch (num)
				{
				case 219:
				case 220:
					return bulkInsertStatement;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x00052EC4 File Offset: 0x000510C4
		public InsertBulkStatement insertBulkStatement()
		{
			InsertBulkStatement insertBulkStatement = base.FragmentFactory.CreateFragment<InsertBulkStatement>();
			IToken token = this.LT(1);
			this.match(86);
			this.match(17);
			SchemaObjectName to = this.schemaObjectThreePartName();
			if (this.inputState.guessing == 0)
			{
				insertBulkStatement.To = to;
				TSql80ParserBaseInternal.UpdateTokenInfo(insertBulkStatement, token);
				base.ThrowPartialAstIfPhaseOne(insertBulkStatement);
			}
			if (this.LA(1) == 191 && (this.LA(2) == 232 || this.LA(2) == 233))
			{
				this.coldefList(insertBulkStatement);
			}
			else if (!TSql80ParserInternal.tokenSet_15_.member(this.LA(1)) || !TSql80ParserInternal.tokenSet_11_.member(this.LA(2)))
			{
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			int num = this.LA(1);
			if (num <= 86)
			{
				if (num <= 28)
				{
					if (num <= 6)
					{
						if (num == 1 || num == 6)
						{
							return insertBulkStatement;
						}
					}
					else
					{
						switch (num)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							return insertBulkStatement;
						case 14:
						case 16:
							break;
						default:
							switch (num)
							{
							case 22:
							case 23:
								return insertBulkStatement;
							default:
								if (num == 28)
								{
									return insertBulkStatement;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num <= 64)
				{
					switch (num)
					{
					case 33:
					case 35:
						return insertBulkStatement;
					case 34:
						break;
					default:
						switch (num)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							return insertBulkStatement;
						}
						break;
					}
				}
				else
				{
					switch (num)
					{
					case 74:
					case 75:
						return insertBulkStatement;
					default:
						if (num == 82 || num == 86)
						{
							return insertBulkStatement;
						}
						break;
					}
				}
			}
			else if (num <= 144)
			{
				if (num <= 95)
				{
					if (num == 92 || num == 95)
					{
						return insertBulkStatement;
					}
				}
				else
				{
					if (num == 106 || num == 119)
					{
						return insertBulkStatement;
					}
					switch (num)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return insertBulkStatement;
					}
				}
			}
			else if (num <= 181)
			{
				switch (num)
				{
				case 156:
				case 160:
				case 161:
				case 162:
					return insertBulkStatement;
				case 157:
				case 158:
				case 159:
					break;
				default:
					switch (num)
					{
					case 167:
					case 170:
					case 172:
					case 173:
					case 176:
					case 180:
					case 181:
						return insertBulkStatement;
					case 171:
						this.insertBulkOptions(insertBulkStatement);
						return insertBulkStatement;
					}
					break;
				}
			}
			else
			{
				if (num == 191 || num == 204)
				{
					return insertBulkStatement;
				}
				switch (num)
				{
				case 219:
				case 220:
					return insertBulkStatement;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x000531F4 File Offset: 0x000513F4
		public CheckpointStatement checkpointStatement()
		{
			CheckpointStatement checkpointStatement = base.FragmentFactory.CreateFragment<CheckpointStatement>();
			IToken token = this.LT(1);
			this.match(22);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(checkpointStatement, token);
			}
			return checkpointStatement;
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x00053234 File Offset: 0x00051434
		public ReconfigureStatement reconfigureStatement()
		{
			ReconfigureStatement reconfigureStatement = base.FragmentFactory.CreateFragment<ReconfigureStatement>();
			IToken token = this.LT(1);
			this.match(126);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(reconfigureStatement, token);
			}
			int num = this.LA(1);
			if (num <= 86)
			{
				if (num <= 28)
				{
					if (num <= 6)
					{
						if (num == 1 || num == 6)
						{
							return reconfigureStatement;
						}
					}
					else
					{
						switch (num)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							return reconfigureStatement;
						case 14:
						case 16:
							break;
						default:
							switch (num)
							{
							case 22:
							case 23:
								return reconfigureStatement;
							default:
								if (num == 28)
								{
									return reconfigureStatement;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num <= 64)
				{
					switch (num)
					{
					case 33:
					case 35:
						return reconfigureStatement;
					case 34:
						break;
					default:
						switch (num)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							return reconfigureStatement;
						}
						break;
					}
				}
				else
				{
					switch (num)
					{
					case 74:
					case 75:
						return reconfigureStatement;
					default:
						if (num == 82 || num == 86)
						{
							return reconfigureStatement;
						}
						break;
					}
				}
			}
			else if (num <= 144)
			{
				if (num <= 95)
				{
					if (num == 92 || num == 95)
					{
						return reconfigureStatement;
					}
				}
				else
				{
					if (num == 106 || num == 119)
					{
						return reconfigureStatement;
					}
					switch (num)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return reconfigureStatement;
					}
				}
			}
			else if (num <= 181)
			{
				switch (num)
				{
				case 156:
				case 160:
				case 161:
				case 162:
					return reconfigureStatement;
				case 157:
				case 158:
				case 159:
					break;
				default:
					switch (num)
					{
					case 167:
					case 170:
					case 172:
					case 173:
					case 176:
					case 180:
					case 181:
						return reconfigureStatement;
					case 171:
					{
						this.match(171);
						IToken token2 = this.LT(1);
						this.match(232);
						if (this.inputState.guessing == 0)
						{
							TSql80ParserBaseInternal.Match(token2, "OVERRIDE");
							reconfigureStatement.WithOverride = true;
							TSql80ParserBaseInternal.UpdateTokenInfo(reconfigureStatement, token2);
							return reconfigureStatement;
						}
						return reconfigureStatement;
					}
					}
					break;
				}
			}
			else
			{
				if (num == 191 || num == 204)
				{
					return reconfigureStatement;
				}
				switch (num)
				{
				case 219:
				case 220:
					return reconfigureStatement;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x00053518 File Offset: 0x00051718
		public ShutdownStatement shutdownStatement()
		{
			ShutdownStatement shutdownStatement = base.FragmentFactory.CreateFragment<ShutdownStatement>();
			IToken token = this.LT(1);
			this.match(144);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(shutdownStatement, token);
			}
			int num = this.LA(1);
			if (num <= 86)
			{
				if (num <= 28)
				{
					if (num <= 6)
					{
						if (num == 1 || num == 6)
						{
							return shutdownStatement;
						}
					}
					else
					{
						switch (num)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							return shutdownStatement;
						case 14:
						case 16:
							break;
						default:
							switch (num)
							{
							case 22:
							case 23:
								return shutdownStatement;
							default:
								if (num == 28)
								{
									return shutdownStatement;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num <= 64)
				{
					switch (num)
					{
					case 33:
					case 35:
						return shutdownStatement;
					case 34:
						break;
					default:
						switch (num)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							return shutdownStatement;
						}
						break;
					}
				}
				else
				{
					switch (num)
					{
					case 74:
					case 75:
						return shutdownStatement;
					default:
						if (num == 82 || num == 86)
						{
							return shutdownStatement;
						}
						break;
					}
				}
			}
			else if (num <= 144)
			{
				if (num <= 95)
				{
					if (num == 92 || num == 95)
					{
						return shutdownStatement;
					}
				}
				else
				{
					if (num == 106 || num == 119)
					{
						return shutdownStatement;
					}
					switch (num)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return shutdownStatement;
					}
				}
			}
			else if (num <= 181)
			{
				switch (num)
				{
				case 156:
				case 160:
				case 161:
				case 162:
					return shutdownStatement;
				case 157:
				case 158:
				case 159:
					break;
				default:
					switch (num)
					{
					case 167:
					case 170:
					case 172:
					case 173:
					case 176:
					case 180:
					case 181:
						return shutdownStatement;
					case 171:
					{
						this.match(171);
						IToken token2 = this.LT(1);
						this.match(232);
						if (this.inputState.guessing == 0)
						{
							TSql80ParserBaseInternal.Match(token2, "NOWAIT");
							shutdownStatement.WithNoWait = true;
							TSql80ParserBaseInternal.UpdateTokenInfo(shutdownStatement, token2);
							return shutdownStatement;
						}
						return shutdownStatement;
					}
					}
					break;
				}
			}
			else
			{
				if (num == 191 || num == 204)
				{
					return shutdownStatement;
				}
				switch (num)
				{
				case 219:
				case 220:
					return shutdownStatement;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x00053800 File Offset: 0x00051A00
		public SetUserStatement setUserStatement()
		{
			SetUserStatement setUserStatement = base.FragmentFactory.CreateFragment<SetUserStatement>();
			IToken token = this.LT(1);
			this.match(143);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(setUserStatement, token);
			}
			int num = this.LA(1);
			if (num <= 92)
			{
				if (num <= 28)
				{
					if (num <= 6)
					{
						if (num == 1 || num == 6)
						{
							return setUserStatement;
						}
					}
					else
					{
						switch (num)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							return setUserStatement;
						case 14:
						case 16:
							break;
						default:
							switch (num)
							{
							case 22:
							case 23:
								return setUserStatement;
							default:
								if (num == 28)
								{
									return setUserStatement;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num <= 75)
				{
					switch (num)
					{
					case 33:
					case 35:
						return setUserStatement;
					case 34:
						break;
					default:
						switch (num)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							return setUserStatement;
						case 47:
						case 50:
						case 51:
						case 52:
						case 53:
						case 57:
						case 58:
						case 59:
						case 62:
						case 63:
							break;
						default:
							switch (num)
							{
							case 74:
							case 75:
								return setUserStatement;
							}
							break;
						}
						break;
					}
				}
				else if (num == 82 || num == 86 || num == 92)
				{
					return setUserStatement;
				}
			}
			else if (num <= 173)
			{
				if (num <= 119)
				{
					if (num == 95 || num == 106 || num == 119)
					{
						return setUserStatement;
					}
				}
				else
				{
					switch (num)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return setUserStatement;
					case 124:
					case 127:
					case 128:
					case 130:
					case 133:
					case 135:
					case 136:
					case 137:
					case 139:
					case 141:
						break;
					default:
						switch (num)
						{
						case 156:
						case 160:
						case 161:
						case 162:
							return setUserStatement;
						case 157:
						case 158:
						case 159:
							break;
						default:
							switch (num)
							{
							case 167:
							case 170:
							case 172:
							case 173:
								return setUserStatement;
							}
							break;
						}
						break;
					}
				}
			}
			else if (num <= 191)
			{
				if (num == 176)
				{
					return setUserStatement;
				}
				switch (num)
				{
				case 180:
				case 181:
					return setUserStatement;
				default:
					if (num == 191)
					{
						return setUserStatement;
					}
					break;
				}
			}
			else
			{
				if (num == 204)
				{
					return setUserStatement;
				}
				switch (num)
				{
				case 219:
				case 220:
					return setUserStatement;
				default:
					switch (num)
					{
					case 230:
					case 231:
					case 234:
					{
						ValueExpression userName = this.stringOrVariable();
						if (this.inputState.guessing == 0)
						{
							setUserStatement.UserName = userName;
						}
						int num2 = this.LA(1);
						if (num2 <= 86)
						{
							if (num2 <= 28)
							{
								if (num2 <= 6)
								{
									if (num2 == 1 || num2 == 6)
									{
										return setUserStatement;
									}
								}
								else
								{
									switch (num2)
									{
									case 12:
									case 13:
									case 15:
									case 17:
										return setUserStatement;
									case 14:
									case 16:
										break;
									default:
										switch (num2)
										{
										case 22:
										case 23:
											return setUserStatement;
										default:
											if (num2 == 28)
											{
												return setUserStatement;
											}
											break;
										}
										break;
									}
								}
							}
							else if (num2 <= 64)
							{
								switch (num2)
								{
								case 33:
								case 35:
									return setUserStatement;
								case 34:
									break;
								default:
									switch (num2)
									{
									case 44:
									case 45:
									case 46:
									case 48:
									case 49:
									case 54:
									case 55:
									case 56:
									case 60:
									case 61:
									case 64:
										return setUserStatement;
									}
									break;
								}
							}
							else
							{
								switch (num2)
								{
								case 74:
								case 75:
									return setUserStatement;
								default:
									if (num2 == 82 || num2 == 86)
									{
										return setUserStatement;
									}
									break;
								}
							}
						}
						else if (num2 <= 144)
						{
							if (num2 <= 95)
							{
								if (num2 == 92 || num2 == 95)
								{
									return setUserStatement;
								}
							}
							else
							{
								if (num2 == 106 || num2 == 119)
								{
									return setUserStatement;
								}
								switch (num2)
								{
								case 123:
								case 125:
								case 126:
								case 129:
								case 131:
								case 132:
								case 134:
								case 138:
								case 140:
								case 142:
								case 143:
								case 144:
									return setUserStatement;
								}
							}
						}
						else if (num2 <= 181)
						{
							switch (num2)
							{
							case 156:
							case 160:
							case 161:
							case 162:
								return setUserStatement;
							case 157:
							case 158:
							case 159:
								break;
							default:
								switch (num2)
								{
								case 167:
								case 170:
								case 172:
								case 173:
								case 176:
								case 180:
								case 181:
									return setUserStatement;
								case 171:
								{
									this.match(171);
									IToken token2 = this.LT(1);
									this.match(232);
									if (this.inputState.guessing == 0)
									{
										TSql80ParserBaseInternal.Match(token2, "NORESET");
										setUserStatement.WithNoReset = true;
										TSql80ParserBaseInternal.UpdateTokenInfo(setUserStatement, token2);
										return setUserStatement;
									}
									return setUserStatement;
								}
								}
								break;
							}
						}
						else
						{
							if (num2 == 191 || num2 == 204)
							{
								return setUserStatement;
							}
							switch (num2)
							{
							case 219:
							case 220:
								return setUserStatement;
							}
						}
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
					}
					break;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x00053DCC File Offset: 0x00051FCC
		public TruncateTableStatement truncateTableStatement()
		{
			TruncateTableStatement truncateTableStatement = base.FragmentFactory.CreateFragment<TruncateTableStatement>();
			IToken token = this.LT(1);
			this.match(156);
			this.match(148);
			SchemaObjectName tableName = this.schemaObjectThreePartName();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(truncateTableStatement, token);
				truncateTableStatement.TableName = tableName;
			}
			return truncateTableStatement;
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x00053E28 File Offset: 0x00052028
		public GrantStatement80 grantStatement80()
		{
			GrantStatement80 grantStatement = base.FragmentFactory.CreateFragment<GrantStatement80>();
			IToken token = this.LT(1);
			this.match(75);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(grantStatement, token);
			}
			SecurityElement80 securityElement = this.securityElement80();
			if (this.inputState.guessing == 0)
			{
				grantStatement.SecurityElement80 = securityElement;
			}
			this.match(151);
			SecurityUserClause80 securityUserClause = this.securityUserClause80();
			if (this.inputState.guessing == 0)
			{
				grantStatement.SecurityUserClause80 = securityUserClause;
			}
			int num = this.LA(1);
			if (num <= 86)
			{
				if (num <= 28)
				{
					if (num <= 6)
					{
						if (num == 1 || num == 6)
						{
							goto IL_33A;
						}
					}
					else
					{
						switch (num)
						{
						case 9:
						case 12:
						case 13:
						case 15:
						case 17:
							goto IL_33A;
						case 10:
						case 11:
						case 14:
						case 16:
							break;
						default:
							switch (num)
							{
							case 22:
							case 23:
								goto IL_33A;
							default:
								if (num == 28)
								{
									goto IL_33A;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num <= 64)
				{
					switch (num)
					{
					case 33:
					case 35:
						goto IL_33A;
					case 34:
						break;
					default:
						switch (num)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							goto IL_33A;
						}
						break;
					}
				}
				else
				{
					switch (num)
					{
					case 74:
					case 75:
						goto IL_33A;
					default:
						if (num == 82 || num == 86)
						{
							goto IL_33A;
						}
						break;
					}
				}
			}
			else if (num <= 144)
			{
				if (num <= 95)
				{
					if (num == 92 || num == 95)
					{
						goto IL_33A;
					}
				}
				else
				{
					if (num == 106 || num == 119)
					{
						goto IL_33A;
					}
					switch (num)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						goto IL_33A;
					}
				}
			}
			else if (num <= 181)
			{
				switch (num)
				{
				case 156:
				case 160:
				case 161:
				case 162:
					goto IL_33A;
				case 157:
				case 158:
				case 159:
					break;
				default:
					switch (num)
					{
					case 167:
					case 170:
					case 172:
					case 173:
					case 176:
					case 180:
					case 181:
						goto IL_33A;
					case 171:
					{
						this.match(171);
						this.match(75);
						IToken token2 = this.LT(1);
						this.match(111);
						if (this.inputState.guessing == 0)
						{
							grantStatement.WithGrantOption = true;
							TSql80ParserBaseInternal.UpdateTokenInfo(grantStatement, token2);
							goto IL_33A;
						}
						goto IL_33A;
					}
					}
					break;
				}
			}
			else
			{
				if (num == 191 || num == 204)
				{
					goto IL_33A;
				}
				switch (num)
				{
				case 219:
				case 220:
					goto IL_33A;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_33A:
			int num2 = this.LA(1);
			if (num2 <= 92)
			{
				if (num2 <= 28)
				{
					if (num2 <= 6)
					{
						if (num2 == 1 || num2 == 6)
						{
							return grantStatement;
						}
					}
					else
					{
						switch (num2)
						{
						case 9:
						{
							this.match(9);
							Identifier asClause = this.identifier();
							if (this.inputState.guessing == 0)
							{
								grantStatement.AsClause = asClause;
								return grantStatement;
							}
							return grantStatement;
						}
						case 10:
						case 11:
						case 14:
						case 16:
							break;
						case 12:
						case 13:
						case 15:
						case 17:
							return grantStatement;
						default:
							switch (num2)
							{
							case 22:
							case 23:
								return grantStatement;
							default:
								if (num2 == 28)
								{
									return grantStatement;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num2 <= 75)
				{
					switch (num2)
					{
					case 33:
					case 35:
						return grantStatement;
					case 34:
						break;
					default:
						switch (num2)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							return grantStatement;
						case 47:
						case 50:
						case 51:
						case 52:
						case 53:
						case 57:
						case 58:
						case 59:
						case 62:
						case 63:
							break;
						default:
							switch (num2)
							{
							case 74:
							case 75:
								return grantStatement;
							}
							break;
						}
						break;
					}
				}
				else if (num2 == 82 || num2 == 86 || num2 == 92)
				{
					return grantStatement;
				}
			}
			else if (num2 <= 162)
			{
				if (num2 <= 106)
				{
					if (num2 == 95 || num2 == 106)
					{
						return grantStatement;
					}
				}
				else
				{
					if (num2 == 119)
					{
						return grantStatement;
					}
					switch (num2)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return grantStatement;
					case 124:
					case 127:
					case 128:
					case 130:
					case 133:
					case 135:
					case 136:
					case 137:
					case 139:
					case 141:
						break;
					default:
						switch (num2)
						{
						case 156:
						case 160:
						case 161:
						case 162:
							return grantStatement;
						}
						break;
					}
				}
			}
			else if (num2 <= 181)
			{
				switch (num2)
				{
				case 167:
				case 170:
				case 172:
				case 173:
					return grantStatement;
				case 168:
				case 169:
				case 171:
					break;
				default:
					if (num2 == 176)
					{
						return grantStatement;
					}
					switch (num2)
					{
					case 180:
					case 181:
						return grantStatement;
					}
					break;
				}
			}
			else
			{
				if (num2 == 191 || num2 == 204)
				{
					return grantStatement;
				}
				switch (num2)
				{
				case 219:
				case 220:
					return grantStatement;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x0005441C File Offset: 0x0005261C
		public DenyStatement80 denyStatement80()
		{
			DenyStatement80 denyStatement = base.FragmentFactory.CreateFragment<DenyStatement80>();
			IToken token = this.LT(1);
			this.match(49);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(denyStatement, token);
			}
			SecurityElement80 securityElement = this.securityElement80();
			if (this.inputState.guessing == 0)
			{
				denyStatement.SecurityElement80 = securityElement;
			}
			this.match(151);
			SecurityUserClause80 securityUserClause = this.securityUserClause80();
			if (this.inputState.guessing == 0)
			{
				denyStatement.SecurityUserClause80 = securityUserClause;
			}
			int num = this.LA(1);
			if (num <= 92)
			{
				if (num <= 35)
				{
					if (num <= 6)
					{
						if (num == 1 || num == 6)
						{
							return denyStatement;
						}
					}
					else
					{
						switch (num)
						{
						case 12:
						case 13:
						case 15:
						case 17:
						case 22:
						case 23:
							return denyStatement;
						case 14:
						case 16:
						case 18:
						case 20:
						case 21:
							break;
						case 19:
						{
							IToken token2 = this.LT(1);
							this.match(19);
							if (this.inputState.guessing == 0)
							{
								denyStatement.CascadeOption = true;
								TSql80ParserBaseInternal.UpdateTokenInfo(denyStatement, token2);
								return denyStatement;
							}
							return denyStatement;
						}
						default:
							if (num == 28)
							{
								return denyStatement;
							}
							switch (num)
							{
							case 33:
							case 35:
								return denyStatement;
							}
							break;
						}
					}
				}
				else if (num <= 75)
				{
					switch (num)
					{
					case 44:
					case 45:
					case 46:
					case 48:
					case 49:
					case 54:
					case 55:
					case 56:
					case 60:
					case 61:
					case 64:
						return denyStatement;
					case 47:
					case 50:
					case 51:
					case 52:
					case 53:
					case 57:
					case 58:
					case 59:
					case 62:
					case 63:
						break;
					default:
						switch (num)
						{
						case 74:
						case 75:
							return denyStatement;
						}
						break;
					}
				}
				else if (num == 82 || num == 86 || num == 92)
				{
					return denyStatement;
				}
			}
			else if (num <= 162)
			{
				if (num <= 106)
				{
					if (num == 95 || num == 106)
					{
						return denyStatement;
					}
				}
				else
				{
					if (num == 119)
					{
						return denyStatement;
					}
					switch (num)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return denyStatement;
					case 124:
					case 127:
					case 128:
					case 130:
					case 133:
					case 135:
					case 136:
					case 137:
					case 139:
					case 141:
						break;
					default:
						switch (num)
						{
						case 156:
						case 160:
						case 161:
						case 162:
							return denyStatement;
						}
						break;
					}
				}
			}
			else if (num <= 181)
			{
				switch (num)
				{
				case 167:
				case 170:
				case 172:
				case 173:
					return denyStatement;
				case 168:
				case 169:
				case 171:
					break;
				default:
					if (num == 176)
					{
						return denyStatement;
					}
					switch (num)
					{
					case 180:
					case 181:
						return denyStatement;
					}
					break;
				}
			}
			else
			{
				if (num == 191 || num == 204)
				{
					return denyStatement;
				}
				switch (num)
				{
				case 219:
				case 220:
					return denyStatement;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x0005474C File Offset: 0x0005294C
		public RevokeStatement80 revokeStatement80()
		{
			RevokeStatement80 revokeStatement = base.FragmentFactory.CreateFragment<RevokeStatement80>();
			IToken token = this.LT(1);
			this.match(132);
			int num = this.LA(1);
			if (num <= 61)
			{
				if (num <= 12)
				{
					if (num == 5 || num == 12)
					{
						goto IL_E3;
					}
				}
				else
				{
					if (num == 35 || num == 48)
					{
						goto IL_E3;
					}
					switch (num)
					{
					case 60:
					case 61:
						goto IL_E3;
					}
				}
			}
			else if (num <= 86)
			{
				if (num != 75)
				{
					if (num == 86)
					{
						goto IL_E3;
					}
				}
				else
				{
					this.match(75);
					this.match(111);
					this.match(67);
					if (this.inputState.guessing == 0)
					{
						revokeStatement.GrantOptionFor = true;
						goto IL_E3;
					}
					goto IL_E3;
				}
			}
			else if (num == 127 || num == 140 || num == 160)
			{
				goto IL_E3;
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_E3:
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(revokeStatement, token);
			}
			SecurityElement80 securityElement = this.securityElement80();
			if (this.inputState.guessing == 0)
			{
				revokeStatement.SecurityElement80 = securityElement;
			}
			int num2 = this.LA(1);
			if (num2 != 71)
			{
				if (num2 != 151)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				this.match(151);
			}
			else
			{
				this.match(71);
			}
			SecurityUserClause80 securityUserClause = this.securityUserClause80();
			if (this.inputState.guessing == 0)
			{
				revokeStatement.SecurityUserClause80 = securityUserClause;
			}
			int num3 = this.LA(1);
			if (num3 <= 92)
			{
				if (num3 <= 35)
				{
					if (num3 <= 6)
					{
						if (num3 == 1 || num3 == 6)
						{
							goto IL_42B;
						}
					}
					else
					{
						switch (num3)
						{
						case 9:
						case 12:
						case 13:
						case 15:
						case 17:
						case 22:
						case 23:
							goto IL_42B;
						case 10:
						case 11:
						case 14:
						case 16:
						case 18:
						case 20:
						case 21:
							break;
						case 19:
						{
							IToken token2 = this.LT(1);
							this.match(19);
							if (this.inputState.guessing == 0)
							{
								revokeStatement.CascadeOption = true;
								TSql80ParserBaseInternal.UpdateTokenInfo(revokeStatement, token2);
								goto IL_42B;
							}
							goto IL_42B;
						}
						default:
							if (num3 == 28)
							{
								goto IL_42B;
							}
							switch (num3)
							{
							case 33:
							case 35:
								goto IL_42B;
							}
							break;
						}
					}
				}
				else if (num3 <= 75)
				{
					switch (num3)
					{
					case 44:
					case 45:
					case 46:
					case 48:
					case 49:
					case 54:
					case 55:
					case 56:
					case 60:
					case 61:
					case 64:
						goto IL_42B;
					case 47:
					case 50:
					case 51:
					case 52:
					case 53:
					case 57:
					case 58:
					case 59:
					case 62:
					case 63:
						break;
					default:
						switch (num3)
						{
						case 74:
						case 75:
							goto IL_42B;
						}
						break;
					}
				}
				else if (num3 == 82 || num3 == 86 || num3 == 92)
				{
					goto IL_42B;
				}
			}
			else if (num3 <= 162)
			{
				if (num3 <= 106)
				{
					if (num3 == 95 || num3 == 106)
					{
						goto IL_42B;
					}
				}
				else
				{
					if (num3 == 119)
					{
						goto IL_42B;
					}
					switch (num3)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						goto IL_42B;
					case 124:
					case 127:
					case 128:
					case 130:
					case 133:
					case 135:
					case 136:
					case 137:
					case 139:
					case 141:
						break;
					default:
						switch (num3)
						{
						case 156:
						case 160:
						case 161:
						case 162:
							goto IL_42B;
						}
						break;
					}
				}
			}
			else if (num3 <= 181)
			{
				switch (num3)
				{
				case 167:
				case 170:
				case 172:
				case 173:
					goto IL_42B;
				case 168:
				case 169:
				case 171:
					break;
				default:
					if (num3 == 176)
					{
						goto IL_42B;
					}
					switch (num3)
					{
					case 180:
					case 181:
						goto IL_42B;
					}
					break;
				}
			}
			else
			{
				if (num3 == 191 || num3 == 204)
				{
					goto IL_42B;
				}
				switch (num3)
				{
				case 219:
				case 220:
					goto IL_42B;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_42B:
			int num4 = this.LA(1);
			if (num4 <= 92)
			{
				if (num4 <= 28)
				{
					if (num4 <= 6)
					{
						if (num4 == 1 || num4 == 6)
						{
							return revokeStatement;
						}
					}
					else
					{
						switch (num4)
						{
						case 9:
						{
							this.match(9);
							Identifier asClause = this.identifier();
							if (this.inputState.guessing == 0)
							{
								revokeStatement.AsClause = asClause;
								return revokeStatement;
							}
							return revokeStatement;
						}
						case 10:
						case 11:
						case 14:
						case 16:
							break;
						case 12:
						case 13:
						case 15:
						case 17:
							return revokeStatement;
						default:
							switch (num4)
							{
							case 22:
							case 23:
								return revokeStatement;
							default:
								if (num4 == 28)
								{
									return revokeStatement;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num4 <= 75)
				{
					switch (num4)
					{
					case 33:
					case 35:
						return revokeStatement;
					case 34:
						break;
					default:
						switch (num4)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							return revokeStatement;
						case 47:
						case 50:
						case 51:
						case 52:
						case 53:
						case 57:
						case 58:
						case 59:
						case 62:
						case 63:
							break;
						default:
							switch (num4)
							{
							case 74:
							case 75:
								return revokeStatement;
							}
							break;
						}
						break;
					}
				}
				else if (num4 == 82 || num4 == 86 || num4 == 92)
				{
					return revokeStatement;
				}
			}
			else if (num4 <= 162)
			{
				if (num4 <= 106)
				{
					if (num4 == 95 || num4 == 106)
					{
						return revokeStatement;
					}
				}
				else
				{
					if (num4 == 119)
					{
						return revokeStatement;
					}
					switch (num4)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return revokeStatement;
					case 124:
					case 127:
					case 128:
					case 130:
					case 133:
					case 135:
					case 136:
					case 137:
					case 139:
					case 141:
						break;
					default:
						switch (num4)
						{
						case 156:
						case 160:
						case 161:
						case 162:
							return revokeStatement;
						}
						break;
					}
				}
			}
			else if (num4 <= 181)
			{
				switch (num4)
				{
				case 167:
				case 170:
				case 172:
				case 173:
					return revokeStatement;
				case 168:
				case 169:
				case 171:
					break;
				default:
					if (num4 == 176)
					{
						return revokeStatement;
					}
					switch (num4)
					{
					case 180:
					case 181:
						return revokeStatement;
					}
					break;
				}
			}
			else
			{
				if (num4 == 191 || num4 == 204)
				{
					return revokeStatement;
				}
				switch (num4)
				{
				case 219:
				case 220:
					return revokeStatement;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x00054E30 File Offset: 0x00053030
		public ReturnStatement returnStatement()
		{
			ReturnStatement returnStatement = base.FragmentFactory.CreateFragment<ReturnStatement>();
			IToken token = this.LT(1);
			this.match(131);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(returnStatement, token);
			}
			bool flag = false;
			if (TSql80ParserInternal.tokenSet_16_.member(this.LA(1)) && TSql80ParserInternal.tokenSet_17_.member(this.LA(2)))
			{
				int pos = this.mark();
				flag = true;
				this.inputState.guessing++;
				try
				{
					this.expression();
				}
				catch (RecognitionException)
				{
					flag = false;
				}
				this.rewind(pos);
				this.inputState.guessing--;
			}
			if (flag)
			{
				ScalarExpression expression = this.expression();
				if (this.inputState.guessing == 0)
				{
					returnStatement.Expression = expression;
				}
			}
			else if (!TSql80ParserInternal.tokenSet_10_.member(this.LA(1)) || !TSql80ParserInternal.tokenSet_11_.member(this.LA(2)))
			{
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			return returnStatement;
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x00054F4C File Offset: 0x0005314C
		public OpenCursorStatement openCursorStatement()
		{
			OpenCursorStatement openCursorStatement = base.FragmentFactory.CreateFragment<OpenCursorStatement>();
			IToken token = this.LT(1);
			this.match(106);
			CursorId cursor = this.cursorId();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(openCursorStatement, token);
				openCursorStatement.Cursor = cursor;
			}
			return openCursorStatement;
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x00054F9C File Offset: 0x0005319C
		public CloseCursorStatement closeCursorStatement()
		{
			CloseCursorStatement closeCursorStatement = base.FragmentFactory.CreateFragment<CloseCursorStatement>();
			IToken token = this.LT(1);
			this.match(23);
			CursorId cursor = this.cursorId();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(closeCursorStatement, token);
				closeCursorStatement.Cursor = cursor;
			}
			return closeCursorStatement;
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x00054FEC File Offset: 0x000531EC
		public DeallocateCursorStatement deallocateCursorStatement()
		{
			DeallocateCursorStatement deallocateCursorStatement = base.FragmentFactory.CreateFragment<DeallocateCursorStatement>();
			IToken token = this.LT(1);
			this.match(45);
			CursorId cursor = this.cursorId();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(deallocateCursorStatement, token);
				deallocateCursorStatement.Cursor = cursor;
			}
			return deallocateCursorStatement;
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x0005503C File Offset: 0x0005323C
		public FetchCursorStatement fetchCursorStatement()
		{
			IToken token = this.LT(1);
			this.match(64);
			FetchCursorStatement fetchCursorStatement = this.rowSelector();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(fetchCursorStatement, token);
			}
			int num = this.LA(1);
			if (num <= 92)
			{
				if (num <= 28)
				{
					if (num <= 6)
					{
						if (num == 1 || num == 6)
						{
							return fetchCursorStatement;
						}
					}
					else
					{
						switch (num)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							return fetchCursorStatement;
						case 14:
						case 16:
							break;
						default:
							switch (num)
							{
							case 22:
							case 23:
								return fetchCursorStatement;
							default:
								if (num == 28)
								{
									return fetchCursorStatement;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num <= 75)
				{
					switch (num)
					{
					case 33:
					case 35:
						return fetchCursorStatement;
					case 34:
						break;
					default:
						switch (num)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							return fetchCursorStatement;
						case 47:
						case 50:
						case 51:
						case 52:
						case 53:
						case 57:
						case 58:
						case 59:
						case 62:
						case 63:
							break;
						default:
							switch (num)
							{
							case 74:
							case 75:
								return fetchCursorStatement;
							}
							break;
						}
						break;
					}
				}
				else
				{
					if (num == 82)
					{
						return fetchCursorStatement;
					}
					switch (num)
					{
					case 86:
						return fetchCursorStatement;
					case 87:
						break;
					case 88:
					{
						this.match(88);
						VariableReference item = this.variable();
						if (this.inputState.guessing == 0)
						{
							TSql80ParserBaseInternal.AddAndUpdateTokenInfo<VariableReference>(fetchCursorStatement, fetchCursorStatement.IntoVariables, item);
						}
						while (this.LA(1) == 198)
						{
							this.match(198);
							item = this.variable();
							if (this.inputState.guessing == 0)
							{
								TSql80ParserBaseInternal.AddAndUpdateTokenInfo<VariableReference>(fetchCursorStatement, fetchCursorStatement.IntoVariables, item);
							}
						}
						return fetchCursorStatement;
					}
					default:
						if (num == 92)
						{
							return fetchCursorStatement;
						}
						break;
					}
				}
			}
			else if (num <= 162)
			{
				if (num <= 106)
				{
					if (num == 95 || num == 106)
					{
						return fetchCursorStatement;
					}
				}
				else
				{
					if (num == 119)
					{
						return fetchCursorStatement;
					}
					switch (num)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return fetchCursorStatement;
					case 124:
					case 127:
					case 128:
					case 130:
					case 133:
					case 135:
					case 136:
					case 137:
					case 139:
					case 141:
						break;
					default:
						switch (num)
						{
						case 156:
						case 160:
						case 161:
						case 162:
							return fetchCursorStatement;
						}
						break;
					}
				}
			}
			else if (num <= 181)
			{
				switch (num)
				{
				case 167:
				case 170:
				case 172:
				case 173:
					return fetchCursorStatement;
				case 168:
				case 169:
				case 171:
					break;
				default:
					if (num == 176)
					{
						return fetchCursorStatement;
					}
					switch (num)
					{
					case 180:
					case 181:
						return fetchCursorStatement;
					}
					break;
				}
			}
			else
			{
				if (num == 191 || num == 204)
				{
					return fetchCursorStatement;
				}
				switch (num)
				{
				case 219:
				case 220:
					return fetchCursorStatement;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x00055350 File Offset: 0x00053550
		public TSqlStatement dropStatements()
		{
			IToken token = this.LT(1);
			this.match(54);
			int num = this.LA(1);
			TSqlStatement tsqlStatement;
			if (num <= 84)
			{
				if (num <= 47)
				{
					if (num == 43)
					{
						tsqlStatement = this.dropDatabaseStatement();
						goto IL_105;
					}
					if (num == 47)
					{
						tsqlStatement = this.dropDefaultStatement();
						goto IL_105;
					}
				}
				else
				{
					if (num == 73)
					{
						tsqlStatement = this.dropFunctionStatement();
						goto IL_105;
					}
					if (num == 84)
					{
						tsqlStatement = this.dropIndexStatement();
						goto IL_105;
					}
				}
			}
			else if (num <= 137)
			{
				switch (num)
				{
				case 120:
				case 121:
					tsqlStatement = this.dropProcedureStatement();
					goto IL_105;
				default:
					if (num == 137)
					{
						tsqlStatement = this.dropRuleStatement();
						goto IL_105;
					}
					break;
				}
			}
			else
			{
				switch (num)
				{
				case 146:
					tsqlStatement = this.dropStatisticsStatement();
					goto IL_105;
				case 147:
					break;
				case 148:
					tsqlStatement = this.dropTableStatement();
					goto IL_105;
				default:
					if (num == 155)
					{
						tsqlStatement = this.dropTriggerStatement();
						goto IL_105;
					}
					if (num == 166)
					{
						tsqlStatement = this.dropViewStatement();
						goto IL_105;
					}
					break;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_105:
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(tsqlStatement, token);
			}
			return tsqlStatement;
		}

		// Token: 0x0600126A RID: 4714 RVA: 0x00055478 File Offset: 0x00053678
		public DbccStatement dbccStatement()
		{
			DbccStatement dbccStatement = base.FragmentFactory.CreateFragment<DbccStatement>();
			IToken token = this.LT(1);
			this.match(44);
			IToken token2 = this.LT(1);
			this.match(232);
			if (this.inputState.guessing == 0)
			{
				DbccCommand command;
				if (DbccCommandsHelper.Instance.TryParseOption(token2, out command))
				{
					dbccStatement.Command = command;
				}
				else
				{
					dbccStatement.Command = DbccCommand.Free;
					dbccStatement.DllName = token2.getText();
				}
				TSql80ParserBaseInternal.UpdateTokenInfo(dbccStatement, token);
				TSql80ParserBaseInternal.UpdateTokenInfo(dbccStatement, token2);
			}
			if (this.LA(1) == 191 && TSql80ParserInternal.tokenSet_18_.member(this.LA(2)))
			{
				this.dbccNamedLiteralList(dbccStatement);
			}
			else if (!TSql80ParserInternal.tokenSet_15_.member(this.LA(1)) || !TSql80ParserInternal.tokenSet_11_.member(this.LA(2)))
			{
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			int num = this.LA(1);
			if (num <= 86)
			{
				if (num <= 28)
				{
					if (num <= 6)
					{
						if (num == 1 || num == 6)
						{
							return dbccStatement;
						}
					}
					else
					{
						switch (num)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							return dbccStatement;
						case 14:
						case 16:
							break;
						default:
							switch (num)
							{
							case 22:
							case 23:
								return dbccStatement;
							default:
								if (num == 28)
								{
									return dbccStatement;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num <= 64)
				{
					switch (num)
					{
					case 33:
					case 35:
						return dbccStatement;
					case 34:
						break;
					default:
						switch (num)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							return dbccStatement;
						}
						break;
					}
				}
				else
				{
					switch (num)
					{
					case 74:
					case 75:
						return dbccStatement;
					default:
						if (num == 82 || num == 86)
						{
							return dbccStatement;
						}
						break;
					}
				}
			}
			else if (num <= 144)
			{
				if (num <= 95)
				{
					if (num == 92 || num == 95)
					{
						return dbccStatement;
					}
				}
				else
				{
					if (num == 106 || num == 119)
					{
						return dbccStatement;
					}
					switch (num)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return dbccStatement;
					}
				}
			}
			else if (num <= 181)
			{
				switch (num)
				{
				case 156:
				case 160:
				case 161:
				case 162:
					return dbccStatement;
				case 157:
				case 158:
				case 159:
					break;
				default:
					switch (num)
					{
					case 167:
					case 170:
					case 172:
					case 173:
					case 176:
					case 180:
					case 181:
						return dbccStatement;
					case 171:
						this.dbccOptions(dbccStatement);
						return dbccStatement;
					}
					break;
				}
			}
			else
			{
				if (num == 191 || num == 204)
				{
					return dbccStatement;
				}
				switch (num)
				{
				case 219:
				case 220:
					return dbccStatement;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x000557E4 File Offset: 0x000539E4
		public RevertStatement revertStatement()
		{
			RevertStatement revertStatement = base.FragmentFactory.CreateFragment<RevertStatement>();
			IToken token = this.LT(1);
			this.match(176);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(revertStatement, token);
			}
			int num = this.LA(1);
			if (num <= 86)
			{
				if (num <= 28)
				{
					if (num <= 6)
					{
						if (num == 1 || num == 6)
						{
							return revertStatement;
						}
					}
					else
					{
						switch (num)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							return revertStatement;
						case 14:
						case 16:
							break;
						default:
							switch (num)
							{
							case 22:
							case 23:
								return revertStatement;
							default:
								if (num == 28)
								{
									return revertStatement;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num <= 64)
				{
					switch (num)
					{
					case 33:
					case 35:
						return revertStatement;
					case 34:
						break;
					default:
						switch (num)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							return revertStatement;
						}
						break;
					}
				}
				else
				{
					switch (num)
					{
					case 74:
					case 75:
						return revertStatement;
					default:
						if (num == 82 || num == 86)
						{
							return revertStatement;
						}
						break;
					}
				}
			}
			else if (num <= 144)
			{
				if (num <= 95)
				{
					if (num == 92 || num == 95)
					{
						return revertStatement;
					}
				}
				else
				{
					if (num == 106 || num == 119)
					{
						return revertStatement;
					}
					switch (num)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return revertStatement;
					}
				}
			}
			else if (num <= 181)
			{
				switch (num)
				{
				case 156:
				case 160:
				case 161:
				case 162:
					return revertStatement;
				case 157:
				case 158:
				case 159:
					break;
				default:
					switch (num)
					{
					case 167:
					case 170:
					case 172:
					case 173:
					case 176:
					case 180:
					case 181:
						return revertStatement;
					case 171:
					{
						this.match(171);
						IToken token2 = this.LT(1);
						this.match(232);
						this.match(206);
						ScalarExpression cookie = this.expression();
						if (this.inputState.guessing == 0)
						{
							TSql80ParserBaseInternal.Match(token2, "COOKIE");
							revertStatement.Cookie = cookie;
							return revertStatement;
						}
						return revertStatement;
					}
					}
					break;
				}
			}
			else
			{
				if (num == 191 || num == 204)
				{
					return revertStatement;
				}
				switch (num)
				{
				case 219:
				case 220:
					return revertStatement;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x00055AF4 File Offset: 0x00053CF4
		public DiskStatement diskStatement()
		{
			DiskStatement diskStatement = base.FragmentFactory.CreateFragment<DiskStatement>();
			IToken token = this.LT(1);
			this.match(173);
			IToken token2 = this.LT(1);
			this.match(232);
			if (this.inputState.guessing == 0)
			{
				if (TSql80ParserBaseInternal.TryMatch(token2, "INIT"))
				{
					diskStatement.DiskStatementType = DiskStatementType.Init;
				}
				else
				{
					TSql80ParserBaseInternal.Match(token2, "RESIZE");
					diskStatement.DiskStatementType = DiskStatementType.Resize;
				}
				TSql80ParserBaseInternal.UpdateTokenInfo(diskStatement, token);
			}
			DiskStatementOption item = this.diskStatementOption();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<DiskStatementOption>(diskStatement, diskStatement.Options, item);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				item = this.diskStatementOption();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<DiskStatementOption>(diskStatement, diskStatement.Options, item);
				}
			}
			return diskStatement;
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x00055BD4 File Offset: 0x00053DD4
		public CreateProcedureStatement createProcedureStatement()
		{
			CreateProcedureStatement createProcedureStatement = base.FragmentFactory.CreateFragment<CreateProcedureStatement>();
			bool flag = false;
			IToken token = this.LT(1);
			this.match(35);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(createProcedureStatement, token);
			}
			this.procedureStatementBody(createProcedureStatement, out flag);
			if (this.inputState.guessing == 0 && flag)
			{
				createProcedureStatement = null;
			}
			return createProcedureStatement;
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x00055C34 File Offset: 0x00053E34
		public AlterProcedureStatement alterProcedureStatement()
		{
			AlterProcedureStatement alterProcedureStatement = base.FragmentFactory.CreateFragment<AlterProcedureStatement>();
			bool flag = false;
			IToken token = this.LT(1);
			this.match(6);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(alterProcedureStatement, token);
			}
			this.procedureStatementBody(alterProcedureStatement, out flag);
			if (this.inputState.guessing == 0 && flag)
			{
				alterProcedureStatement = null;
			}
			return alterProcedureStatement;
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x00055C90 File Offset: 0x00053E90
		public CreateTriggerStatement createTriggerStatement()
		{
			CreateTriggerStatement createTriggerStatement = base.FragmentFactory.CreateFragment<CreateTriggerStatement>();
			bool flag = false;
			IToken token = this.LT(1);
			this.match(35);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(createTriggerStatement, token);
			}
			this.triggerStatementBody(createTriggerStatement, out flag);
			if (this.inputState.guessing == 0 && flag)
			{
				createTriggerStatement = null;
			}
			return createTriggerStatement;
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x00055CF0 File Offset: 0x00053EF0
		public AlterTriggerStatement alterTriggerStatement()
		{
			AlterTriggerStatement alterTriggerStatement = base.FragmentFactory.CreateFragment<AlterTriggerStatement>();
			bool flag = false;
			IToken token = this.LT(1);
			this.match(6);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(alterTriggerStatement, token);
			}
			this.triggerStatementBody(alterTriggerStatement, out flag);
			if (this.inputState.guessing == 0 && flag)
			{
				alterTriggerStatement = null;
			}
			return alterTriggerStatement;
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x00055D4C File Offset: 0x00053F4C
		public CreateDefaultStatement createDefaultStatement()
		{
			CreateDefaultStatement createDefaultStatement = base.FragmentFactory.CreateFragment<CreateDefaultStatement>();
			IToken token = this.LT(1);
			this.match(35);
			this.match(47);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(createDefaultStatement, token);
			}
			SchemaObjectName name = this.schemaObjectThreePartName();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.CheckTwoPartNameForSchemaObjectName(name, "DEFAULT");
				createDefaultStatement.Name = name;
				base.ThrowPartialAstIfPhaseOne(createDefaultStatement);
			}
			this.match(9);
			ScalarExpression expression = this.expression();
			if (this.inputState.guessing == 0)
			{
				createDefaultStatement.Expression = expression;
			}
			return createDefaultStatement;
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x00055DE4 File Offset: 0x00053FE4
		public CreateRuleStatement createRuleStatement()
		{
			CreateRuleStatement createRuleStatement = base.FragmentFactory.CreateFragment<CreateRuleStatement>();
			IToken token = this.LT(1);
			this.match(35);
			this.match(137);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(createRuleStatement, token);
			}
			SchemaObjectName name = this.schemaObjectThreePartName();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.CheckTwoPartNameForSchemaObjectName(name, "RULE");
				createRuleStatement.Name = name;
				base.ThrowPartialAstIfPhaseOne(createRuleStatement);
			}
			this.match(9);
			BooleanExpression expression = this.booleanExpression();
			if (this.inputState.guessing == 0)
			{
				createRuleStatement.Expression = expression;
			}
			return createRuleStatement;
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x00055E80 File Offset: 0x00054080
		public CreateViewStatement createViewStatement()
		{
			CreateViewStatement createViewStatement = base.FragmentFactory.CreateFragment<CreateViewStatement>();
			IToken token = this.LT(1);
			this.match(35);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(createViewStatement, token);
			}
			this.viewStatementBody(createViewStatement);
			return createViewStatement;
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x00055EC8 File Offset: 0x000540C8
		public AlterViewStatement alterViewStatement()
		{
			AlterViewStatement alterViewStatement = base.FragmentFactory.CreateFragment<AlterViewStatement>();
			IToken token = this.LT(1);
			this.match(6);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(alterViewStatement, token);
			}
			this.viewStatementBody(alterViewStatement);
			return alterViewStatement;
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x00055F10 File Offset: 0x00054110
		public CreateFunctionStatement createFunctionStatement()
		{
			CreateFunctionStatement createFunctionStatement = base.FragmentFactory.CreateFragment<CreateFunctionStatement>();
			bool flag = false;
			IToken token = this.LT(1);
			this.match(35);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(createFunctionStatement, token);
			}
			this.functionStatementBody(createFunctionStatement, out flag);
			if (this.inputState.guessing == 0 && flag)
			{
				createFunctionStatement = null;
			}
			return createFunctionStatement;
		}

		// Token: 0x06001276 RID: 4726 RVA: 0x00055F70 File Offset: 0x00054170
		public AlterFunctionStatement alterFunctionStatement()
		{
			AlterFunctionStatement alterFunctionStatement = base.FragmentFactory.CreateFragment<AlterFunctionStatement>();
			bool flag = false;
			IToken token = this.LT(1);
			this.match(6);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(alterFunctionStatement, token);
			}
			this.functionStatementBody(alterFunctionStatement, out flag);
			if (this.inputState.guessing == 0 && flag)
			{
				alterFunctionStatement = null;
			}
			return alterFunctionStatement;
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x00055FCC File Offset: 0x000541CC
		public CreateSchemaStatement createSchemaStatement()
		{
			CreateSchemaStatement createSchemaStatement = base.FragmentFactory.CreateFragment<CreateSchemaStatement>();
			IToken token = this.LT(1);
			this.match(35);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(createSchemaStatement, token);
			}
			this.match(139);
			int num = this.LA(1);
			if (num != 11)
			{
				switch (num)
				{
				case 232:
				case 233:
				{
					Identifier name = this.identifier();
					if (this.inputState.guessing == 0)
					{
						createSchemaStatement.Name = name;
					}
					this.authorizationOpt(createSchemaStatement);
					break;
				}
				default:
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
			}
			else
			{
				this.authorization(createSchemaStatement);
			}
			if (this.inputState.guessing == 0)
			{
				base.ThrowPartialAstIfPhaseOne(createSchemaStatement);
			}
			StatementList statementList = this.createSchemaElementList();
			if (this.inputState.guessing == 0)
			{
				createSchemaStatement.StatementList = statementList;
			}
			return createSchemaStatement;
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x000560AC File Offset: 0x000542AC
		public Identifier identifier()
		{
			Identifier identifier = base.FragmentFactory.CreateFragment<Identifier>();
			switch (this.LA(1))
			{
			case 232:
			{
				IToken token = this.LT(1);
				this.match(232);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(identifier, token);
					identifier.SetUnquotedIdentifier(token.getText());
					TSql80ParserBaseInternal.CheckIdentifierLength(identifier);
				}
				break;
			}
			case 233:
			{
				IToken token2 = this.LT(1);
				this.match(233);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(identifier, token2);
					identifier.SetIdentifier(token2.getText());
					TSql80ParserBaseInternal.CheckIdentifierLength(identifier);
				}
				break;
			}
			default:
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			return identifier;
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x00056174 File Offset: 0x00054374
		public SqlCommandIdentifier sqlCommandIdentifier()
		{
			SqlCommandIdentifier sqlCommandIdentifier = base.FragmentFactory.CreateFragment<SqlCommandIdentifier>();
			IToken token = this.LT(1);
			this.match(226);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(sqlCommandIdentifier, token);
				sqlCommandIdentifier.SetUnquotedIdentifier(token.getText());
			}
			return sqlCommandIdentifier;
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x000561C4 File Offset: 0x000543C4
		public AlterDatabaseStatement alterDbAdd()
		{
			this.match(4);
			AlterDatabaseStatement result;
			if ((this.LA(1) == 65 || this.LA(1) == 232) && (this.LA(2) == 65 || this.LA(2) == 191))
			{
				result = this.alterDbAddFile();
			}
			else
			{
				if (this.LA(1) != 232 || (this.LA(2) != 232 && this.LA(2) != 233))
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				result = this.alterDbAddFilegroup();
			}
			return result;
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x0005625C File Offset: 0x0005445C
		public AlterDatabaseStatement alterDbRemove()
		{
			AlterDatabaseStatement result = null;
			IToken token = this.LT(1);
			this.match(232);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.Match(token, "REMOVE");
			}
			int num = this.LA(1);
			if (num != 65)
			{
				if (num != 232)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				IToken token2 = this.LT(1);
				this.match(232);
				Identifier identifier = this.identifier();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.Match(token2, "FILEGROUP");
					AlterDatabaseRemoveFileGroupStatement alterDatabaseRemoveFileGroupStatement = base.FragmentFactory.CreateFragment<AlterDatabaseRemoveFileGroupStatement>();
					alterDatabaseRemoveFileGroupStatement.FileGroup = identifier;
					result = alterDatabaseRemoveFileGroupStatement;
				}
			}
			else
			{
				this.match(65);
				Identifier identifier = this.identifier();
				if (this.inputState.guessing == 0)
				{
					AlterDatabaseRemoveFileStatement alterDatabaseRemoveFileStatement = base.FragmentFactory.CreateFragment<AlterDatabaseRemoveFileStatement>();
					alterDatabaseRemoveFileStatement.File = identifier;
					result = alterDatabaseRemoveFileStatement;
				}
			}
			return result;
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x00056350 File Offset: 0x00054550
		public AlterDatabaseStatement alterDbModify()
		{
			AlterDatabaseStatement result = null;
			IToken token = this.LT(1);
			this.match(232);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.Match(token, "MODIFY");
			}
			if (this.LA(1) == 232 && this.LA(2) == 206 && base.NextTokenMatches("NAME"))
			{
				IToken token2 = this.LT(1);
				this.match(232);
				this.match(206);
				Identifier newDatabaseName = this.identifier();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.Match(token2, "NAME");
					AlterDatabaseModifyNameStatement alterDatabaseModifyNameStatement = base.FragmentFactory.CreateFragment<AlterDatabaseModifyNameStatement>();
					alterDatabaseModifyNameStatement.NewDatabaseName = newDatabaseName;
					result = alterDatabaseModifyNameStatement;
				}
			}
			else if (this.LA(1) == 232 && (this.LA(2) == 232 || this.LA(2) == 233))
			{
				IToken token3 = this.LT(1);
				this.match(232);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.Match(token3, "FILEGROUP");
				}
				result = this.alterDbModifyFilegroup();
			}
			else
			{
				if (this.LA(1) != 65)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				result = this.alterDbModifyFile();
			}
			return result;
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x000564A0 File Offset: 0x000546A0
		public AlterDatabaseSetStatement alterDbSet()
		{
			this.match(142);
			AlterDatabaseSetStatement alterDatabaseSetStatement = this.dbOptionStateList();
			int num = this.LA(1);
			if (num <= 86)
			{
				if (num <= 28)
				{
					if (num <= 6)
					{
						if (num == 1 || num == 6)
						{
							return alterDatabaseSetStatement;
						}
					}
					else
					{
						switch (num)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							return alterDatabaseSetStatement;
						case 14:
						case 16:
							break;
						default:
							switch (num)
							{
							case 22:
							case 23:
								return alterDatabaseSetStatement;
							default:
								if (num == 28)
								{
									return alterDatabaseSetStatement;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num <= 64)
				{
					switch (num)
					{
					case 33:
					case 35:
						return alterDatabaseSetStatement;
					case 34:
						break;
					default:
						switch (num)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							return alterDatabaseSetStatement;
						}
						break;
					}
				}
				else
				{
					switch (num)
					{
					case 74:
					case 75:
						return alterDatabaseSetStatement;
					default:
						if (num == 82 || num == 86)
						{
							return alterDatabaseSetStatement;
						}
						break;
					}
				}
			}
			else if (num <= 144)
			{
				if (num <= 95)
				{
					if (num == 92 || num == 95)
					{
						return alterDatabaseSetStatement;
					}
				}
				else
				{
					if (num == 106 || num == 119)
					{
						return alterDatabaseSetStatement;
					}
					switch (num)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return alterDatabaseSetStatement;
					}
				}
			}
			else if (num <= 181)
			{
				switch (num)
				{
				case 156:
				case 160:
				case 161:
				case 162:
					return alterDatabaseSetStatement;
				case 157:
				case 158:
				case 159:
					break;
				default:
					switch (num)
					{
					case 167:
					case 170:
					case 172:
					case 173:
					case 176:
					case 180:
					case 181:
						return alterDatabaseSetStatement;
					case 171:
					{
						AlterDatabaseTermination termination = this.xactTermination();
						if (this.inputState.guessing == 0)
						{
							alterDatabaseSetStatement.Termination = termination;
							return alterDatabaseSetStatement;
						}
						return alterDatabaseSetStatement;
					}
					}
					break;
				}
			}
			else
			{
				if (num == 191 || num == 204)
				{
					return alterDatabaseSetStatement;
				}
				switch (num)
				{
				case 219:
				case 220:
					return alterDatabaseSetStatement;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x00056738 File Offset: 0x00054938
		public AlterDatabaseCollateStatement alterDbCollate()
		{
			AlterDatabaseCollateStatement alterDatabaseCollateStatement = base.FragmentFactory.CreateFragment<AlterDatabaseCollateStatement>();
			this.collation(alterDatabaseCollateStatement);
			return alterDatabaseCollateStatement;
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x0005675C File Offset: 0x0005495C
		public void collation(ICollationSetter vParent)
		{
			this.match(26);
			Identifier collation = this.nonQuotedIdentifier();
			if (this.inputState.guessing == 0)
			{
				vParent.Collation = collation;
			}
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x0005678C File Offset: 0x0005498C
		public AlterDatabaseAddFileStatement alterDbAddFile()
		{
			AlterDatabaseAddFileStatement alterDatabaseAddFileStatement = base.FragmentFactory.CreateFragment<AlterDatabaseAddFileStatement>();
			int num = this.LA(1);
			if (num != 65)
			{
				if (num != 232)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				IToken token = this.LT(1);
				this.match(232);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.Match(token, "LOG");
					alterDatabaseAddFileStatement.IsLog = true;
				}
			}
			this.match(65);
			if (this.inputState.guessing == 0)
			{
				base.ThrowPartialAstIfPhaseOne(alterDatabaseAddFileStatement);
			}
			this.fileDeclBodyList(alterDatabaseAddFileStatement, alterDatabaseAddFileStatement.FileDeclarations);
			int num2 = this.LA(1);
			if (num2 <= 92)
			{
				if (num2 <= 28)
				{
					if (num2 <= 6)
					{
						if (num2 == 1 || num2 == 6)
						{
							return alterDatabaseAddFileStatement;
						}
					}
					else
					{
						switch (num2)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							return alterDatabaseAddFileStatement;
						case 14:
						case 16:
							break;
						default:
							switch (num2)
							{
							case 22:
							case 23:
								return alterDatabaseAddFileStatement;
							default:
								if (num2 == 28)
								{
									return alterDatabaseAddFileStatement;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num2 <= 75)
				{
					switch (num2)
					{
					case 33:
					case 35:
						return alterDatabaseAddFileStatement;
					case 34:
						break;
					default:
						switch (num2)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							return alterDatabaseAddFileStatement;
						case 47:
						case 50:
						case 51:
						case 52:
						case 53:
						case 57:
						case 58:
						case 59:
						case 62:
						case 63:
							break;
						default:
							switch (num2)
							{
							case 74:
							case 75:
								return alterDatabaseAddFileStatement;
							}
							break;
						}
						break;
					}
				}
				else if (num2 == 82 || num2 == 86 || num2 == 92)
				{
					return alterDatabaseAddFileStatement;
				}
			}
			else if (num2 <= 162)
			{
				if (num2 <= 119)
				{
					if (num2 == 95 || num2 == 106 || num2 == 119)
					{
						return alterDatabaseAddFileStatement;
					}
				}
				else
				{
					switch (num2)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return alterDatabaseAddFileStatement;
					case 124:
					case 127:
					case 128:
					case 130:
					case 133:
					case 135:
					case 136:
					case 137:
					case 139:
					case 141:
						break;
					default:
						if (num2 != 151)
						{
							switch (num2)
							{
							case 156:
							case 160:
							case 161:
							case 162:
								return alterDatabaseAddFileStatement;
							}
						}
						else
						{
							Identifier identifier = this.toFilegroup();
							if (this.inputState.guessing != 0)
							{
								return alterDatabaseAddFileStatement;
							}
							if (alterDatabaseAddFileStatement.IsLog)
							{
								throw TSql80ParserBaseInternal.GetUnexpectedTokenErrorException(identifier);
							}
							alterDatabaseAddFileStatement.FileGroup = identifier;
							return alterDatabaseAddFileStatement;
						}
						break;
					}
				}
			}
			else if (num2 <= 181)
			{
				switch (num2)
				{
				case 167:
				case 170:
				case 172:
				case 173:
					return alterDatabaseAddFileStatement;
				case 168:
				case 169:
				case 171:
					break;
				default:
					if (num2 == 176)
					{
						return alterDatabaseAddFileStatement;
					}
					switch (num2)
					{
					case 180:
					case 181:
						return alterDatabaseAddFileStatement;
					}
					break;
				}
			}
			else
			{
				if (num2 == 191 || num2 == 204)
				{
					return alterDatabaseAddFileStatement;
				}
				switch (num2)
				{
				case 219:
				case 220:
					return alterDatabaseAddFileStatement;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x00056AE0 File Offset: 0x00054CE0
		public AlterDatabaseAddFileGroupStatement alterDbAddFilegroup()
		{
			AlterDatabaseAddFileGroupStatement alterDatabaseAddFileGroupStatement = base.FragmentFactory.CreateFragment<AlterDatabaseAddFileGroupStatement>();
			IToken token = this.LT(1);
			this.match(232);
			Identifier fileGroup = this.identifier();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.Match(token, "FILEGROUP");
				alterDatabaseAddFileGroupStatement.FileGroup = fileGroup;
			}
			return alterDatabaseAddFileGroupStatement;
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x00056B38 File Offset: 0x00054D38
		public void fileDeclBodyList(TSqlFragment vParent, IList<FileDeclaration> fileDeclarations)
		{
			FileDeclaration item = this.fileDeclBody(false);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<FileDeclaration>(vParent, fileDeclarations, item);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				item = this.fileDeclBody(false);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<FileDeclaration>(vParent, fileDeclarations, item);
				}
			}
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x00056B9C File Offset: 0x00054D9C
		public Identifier toFilegroup()
		{
			this.match(151);
			IToken token = this.LT(1);
			this.match(232);
			Identifier result = this.identifier();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.Match(token, "FILEGROUP");
			}
			return result;
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x00056BEC File Offset: 0x00054DEC
		public AlterDatabaseModifyFileGroupStatement alterDbModifyFilegroup()
		{
			AlterDatabaseModifyFileGroupStatement alterDatabaseModifyFileGroupStatement = base.FragmentFactory.CreateFragment<AlterDatabaseModifyFileGroupStatement>();
			Identifier fileGroup = this.identifier();
			if (this.inputState.guessing == 0)
			{
				alterDatabaseModifyFileGroupStatement.FileGroup = fileGroup;
			}
			if (this.LA(1) == 232 && this.LA(2) == 206)
			{
				IToken token = this.LT(1);
				this.match(232);
				this.match(206);
				Identifier newFileGroupName = this.identifier();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.Match(token, "NAME");
					alterDatabaseModifyFileGroupStatement.NewFileGroupName = newFileGroupName;
					base.ThrowPartialAstIfPhaseOne(alterDatabaseModifyFileGroupStatement);
				}
			}
			else if (this.LA(1) == 47)
			{
				IToken token2 = this.LT(1);
				this.match(47);
				if (this.inputState.guessing == 0)
				{
					alterDatabaseModifyFileGroupStatement.MakeDefault = true;
					TSql80ParserBaseInternal.UpdateTokenInfo(alterDatabaseModifyFileGroupStatement, token2);
				}
			}
			else
			{
				if (this.LA(1) != 232 || !TSql80ParserInternal.tokenSet_10_.member(this.LA(2)))
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				IToken token3 = this.LT(1);
				this.match(232);
				if (this.inputState.guessing == 0)
				{
					base.ThrowPartialAstIfPhaseOne(alterDatabaseModifyFileGroupStatement);
					alterDatabaseModifyFileGroupStatement.UpdatabilityOption = ModifyFilegroupOptionsHelper.Instance.ParseOption(token3);
					TSql80ParserBaseInternal.UpdateTokenInfo(alterDatabaseModifyFileGroupStatement, token3);
				}
			}
			return alterDatabaseModifyFileGroupStatement;
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x00056D4C File Offset: 0x00054F4C
		public AlterDatabaseModifyFileStatement alterDbModifyFile()
		{
			AlterDatabaseModifyFileStatement alterDatabaseModifyFileStatement = base.FragmentFactory.CreateFragment<AlterDatabaseModifyFileStatement>();
			this.match(65);
			if (this.inputState.guessing == 0)
			{
				base.ThrowPartialAstIfPhaseOne(alterDatabaseModifyFileStatement);
			}
			FileDeclaration fileDeclaration = this.fileDecl(true);
			if (this.inputState.guessing == 0)
			{
				alterDatabaseModifyFileStatement.FileDeclaration = fileDeclaration;
			}
			return alterDatabaseModifyFileStatement;
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x00056DA0 File Offset: 0x00054FA0
		public FileDeclaration fileDecl(bool isAlterDbModifyFileStatement)
		{
			int num = this.LA(1);
			FileDeclaration fileDeclaration;
			if (num != 118)
			{
				if (num != 191)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				fileDeclaration = this.fileDeclBody(isAlterDbModifyFileStatement);
			}
			else
			{
				IToken token = this.LT(1);
				this.match(118);
				fileDeclaration = this.fileDeclBody(isAlterDbModifyFileStatement);
				if (this.inputState.guessing == 0)
				{
					fileDeclaration.IsPrimary = true;
					TSql80ParserBaseInternal.UpdateTokenInfo(fileDeclaration, token);
				}
			}
			return fileDeclaration;
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x00056E1C File Offset: 0x0005501C
		public AlterDatabaseSetStatement dbOptionStateList()
		{
			AlterDatabaseSetStatement alterDatabaseSetStatement = base.FragmentFactory.CreateFragment<AlterDatabaseSetStatement>();
			DatabaseOption item = this.dbOptionStateItem();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<DatabaseOption>(alterDatabaseSetStatement, alterDatabaseSetStatement.Options, item);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				item = this.dbOptionStateItem();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<DatabaseOption>(alterDatabaseSetStatement, alterDatabaseSetStatement.Options, item);
				}
			}
			return alterDatabaseSetStatement;
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x00056E94 File Offset: 0x00055094
		public AlterDatabaseTermination xactTermination()
		{
			AlterDatabaseTermination alterDatabaseTermination = base.FragmentFactory.CreateFragment<AlterDatabaseTermination>();
			IToken token = this.LT(1);
			this.match(171);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(alterDatabaseTermination, token);
			}
			int num = this.LA(1);
			if (num != 134)
			{
				if (num != 232)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				IToken token2 = this.LT(1);
				this.match(232);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.Match(token2, "NO_WAIT");
					TSql80ParserBaseInternal.UpdateTokenInfo(alterDatabaseTermination, token2);
					alterDatabaseTermination.NoWait = true;
				}
			}
			else
			{
				this.match(134);
				if (this.LA(1) == 232 && this.LA(2) == 221)
				{
					IToken token3 = this.LT(1);
					this.match(232);
					Literal rollbackAfter = this.integer();
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.Match(token3, "AFTER");
						alterDatabaseTermination.RollbackAfter = rollbackAfter;
					}
					int num2 = this.LA(1);
					if (num2 <= 92)
					{
						if (num2 <= 28)
						{
							if (num2 <= 6)
							{
								if (num2 == 1 || num2 == 6)
								{
									return alterDatabaseTermination;
								}
							}
							else
							{
								switch (num2)
								{
								case 12:
								case 13:
								case 15:
								case 17:
									return alterDatabaseTermination;
								case 14:
								case 16:
									break;
								default:
									switch (num2)
									{
									case 22:
									case 23:
										return alterDatabaseTermination;
									default:
										if (num2 == 28)
										{
											return alterDatabaseTermination;
										}
										break;
									}
									break;
								}
							}
						}
						else if (num2 <= 75)
						{
							switch (num2)
							{
							case 33:
							case 35:
								return alterDatabaseTermination;
							case 34:
								break;
							default:
								switch (num2)
								{
								case 44:
								case 45:
								case 46:
								case 48:
								case 49:
								case 54:
								case 55:
								case 56:
								case 60:
								case 61:
								case 64:
									return alterDatabaseTermination;
								case 47:
								case 50:
								case 51:
								case 52:
								case 53:
								case 57:
								case 58:
								case 59:
								case 62:
								case 63:
									break;
								default:
									switch (num2)
									{
									case 74:
									case 75:
										return alterDatabaseTermination;
									}
									break;
								}
								break;
							}
						}
						else if (num2 == 82 || num2 == 86 || num2 == 92)
						{
							return alterDatabaseTermination;
						}
					}
					else if (num2 <= 173)
					{
						if (num2 <= 119)
						{
							if (num2 == 95 || num2 == 106 || num2 == 119)
							{
								return alterDatabaseTermination;
							}
						}
						else
						{
							switch (num2)
							{
							case 123:
							case 125:
							case 126:
							case 129:
							case 131:
							case 132:
							case 134:
							case 138:
							case 140:
							case 142:
							case 143:
							case 144:
								return alterDatabaseTermination;
							case 124:
							case 127:
							case 128:
							case 130:
							case 133:
							case 135:
							case 136:
							case 137:
							case 139:
							case 141:
								break;
							default:
								switch (num2)
								{
								case 156:
								case 160:
								case 161:
								case 162:
									return alterDatabaseTermination;
								case 157:
								case 158:
								case 159:
									break;
								default:
									switch (num2)
									{
									case 167:
									case 170:
									case 172:
									case 173:
										return alterDatabaseTermination;
									}
									break;
								}
								break;
							}
						}
					}
					else if (num2 <= 191)
					{
						if (num2 == 176)
						{
							return alterDatabaseTermination;
						}
						switch (num2)
						{
						case 180:
						case 181:
							return alterDatabaseTermination;
						default:
							if (num2 == 191)
							{
								return alterDatabaseTermination;
							}
							break;
						}
					}
					else
					{
						if (num2 == 204)
						{
							return alterDatabaseTermination;
						}
						switch (num2)
						{
						case 219:
						case 220:
							return alterDatabaseTermination;
						default:
							if (num2 == 232)
							{
								IToken token4 = this.LT(1);
								this.match(232);
								if (this.inputState.guessing == 0)
								{
									TSql80ParserBaseInternal.Match(token4, "SECONDS");
									TSql80ParserBaseInternal.UpdateTokenInfo(alterDatabaseTermination, token4);
									return alterDatabaseTermination;
								}
								return alterDatabaseTermination;
							}
							break;
						}
					}
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				if (this.LA(1) != 232 || !TSql80ParserInternal.tokenSet_10_.member(this.LA(2)))
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				IToken token5 = this.LT(1);
				this.match(232);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.Match(token5, "IMMEDIATE");
					TSql80ParserBaseInternal.UpdateTokenInfo(alterDatabaseTermination, token5);
					alterDatabaseTermination.ImmediateRollback = true;
				}
			}
			return alterDatabaseTermination;
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x000572F4 File Offset: 0x000554F4
		public IntegerLiteral integer()
		{
			IntegerLiteral integerLiteral = base.FragmentFactory.CreateFragment<IntegerLiteral>();
			IToken token = this.LT(1);
			this.match(221);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(integerLiteral, token);
				integerLiteral.Value = token.getText();
			}
			return integerLiteral;
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x00057344 File Offset: 0x00055544
		public DatabaseOption dbOptionStateItem()
		{
			DatabaseOption result;
			if (this.LA(1) == 232 && this.LA(2) == 232 && base.NextTokenMatches("CURSOR_DEFAULT"))
			{
				result = this.cursorDefaultDbOption();
			}
			else if (this.LA(1) == 232 && (this.LA(2) == 72 || this.LA(2) == 232) && base.NextTokenMatches("RECOVERY"))
			{
				result = this.recoveryDbOption();
			}
			else if (this.LA(1) == 232 && TSql80ParserInternal.tokenSet_19_.member(this.LA(2)))
			{
				result = this.dbSingleIdentOption();
			}
			else
			{
				if (this.LA(1) != 232 || (this.LA(2) != 103 && this.LA(2) != 105))
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				result = this.alterDbOnOffOption();
			}
			return result;
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x00057430 File Offset: 0x00055630
		public CursorDefaultDatabaseOption cursorDefaultDbOption()
		{
			CursorDefaultDatabaseOption cursorDefaultDatabaseOption = base.FragmentFactory.CreateFragment<CursorDefaultDatabaseOption>();
			IToken token = this.LT(1);
			this.match(232);
			IToken token2 = this.LT(1);
			this.match(232);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.Match(token, "CURSOR_DEFAULT");
				cursorDefaultDatabaseOption.OptionKind = DatabaseOptionKind.CursorDefault;
				if (TSql80ParserBaseInternal.TryMatch(token2, "LOCAL"))
				{
					cursorDefaultDatabaseOption.IsLocal = true;
				}
				else
				{
					TSql80ParserBaseInternal.Match(token2, "GLOBAL");
					cursorDefaultDatabaseOption.IsLocal = false;
				}
				TSql80ParserBaseInternal.UpdateTokenInfo(cursorDefaultDatabaseOption, token2);
			}
			return cursorDefaultDatabaseOption;
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x000574C4 File Offset: 0x000556C4
		public RecoveryDatabaseOption recoveryDbOption()
		{
			RecoveryDatabaseOption recoveryDatabaseOption = base.FragmentFactory.CreateFragment<RecoveryDatabaseOption>();
			IToken token = this.LT(1);
			this.match(232);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.Match(token, "RECOVERY");
				recoveryDatabaseOption.OptionKind = DatabaseOptionKind.Recovery;
			}
			int num = this.LA(1);
			if (num != 72)
			{
				if (num != 232)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				IToken token2 = this.LT(1);
				this.match(232);
				if (this.inputState.guessing == 0)
				{
					recoveryDatabaseOption.Value = RecoveryDbOptionsHelper.Instance.ParseOption(token2);
					TSql80ParserBaseInternal.UpdateTokenInfo(recoveryDatabaseOption, token2);
				}
			}
			else
			{
				IToken token3 = this.LT(1);
				this.match(72);
				if (this.inputState.guessing == 0)
				{
					recoveryDatabaseOption.Value = RecoveryDatabaseOptionKind.Full;
					TSql80ParserBaseInternal.UpdateTokenInfo(recoveryDatabaseOption, token3);
				}
			}
			return recoveryDatabaseOption;
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x000575AC File Offset: 0x000557AC
		public DatabaseOption dbSingleIdentOption()
		{
			DatabaseOption databaseOption = base.FragmentFactory.CreateFragment<DatabaseOption>();
			IToken token = this.LT(1);
			this.match(232);
			if (this.inputState.guessing == 0)
			{
				databaseOption.OptionKind = SimpleDbOptionsHelper.Instance.ParseOption(token, SqlVersionFlags.TSql80);
				TSql80ParserBaseInternal.UpdateTokenInfo(databaseOption, token);
			}
			return databaseOption;
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x00057604 File Offset: 0x00055804
		public OnOffDatabaseOption alterDbOnOffOption()
		{
			OnOffDatabaseOption onOffDatabaseOption = base.FragmentFactory.CreateFragment<OnOffDatabaseOption>();
			IToken token = this.LT(1);
			this.match(232);
			OptionState optionState = this.optionOnOff(onOffDatabaseOption);
			if (this.inputState.guessing == 0)
			{
				onOffDatabaseOption.OptionKind = OnOffSimpleDbOptionsHelper.Instance.ParseOption(token, SqlVersionFlags.TSql80);
				onOffDatabaseOption.OptionState = optionState;
			}
			return onOffDatabaseOption;
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x00057664 File Offset: 0x00055864
		public OptionState optionOnOff(TSqlFragment vParent)
		{
			OptionState result = OptionState.NotSet;
			switch (this.LA(1))
			{
			case 103:
			{
				IToken token = this.LT(1);
				this.match(103);
				if (this.inputState.guessing == 0)
				{
					result = OptionState.Off;
					TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token);
					return result;
				}
				return result;
			}
			case 105:
			{
				IToken token2 = this.LT(1);
				this.match(105);
				if (this.inputState.guessing == 0)
				{
					result = OptionState.On;
					TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token2);
					return result;
				}
				return result;
			}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x000576FC File Offset: 0x000558FC
		public void recoveryUnitList(CreateDatabaseStatement vParent)
		{
			int num = this.LA(1);
			if (num <= 92)
			{
				if (num <= 35)
				{
					if (num <= 6)
					{
						if (num == 1 || num == 6)
						{
							goto IL_284;
						}
					}
					else
					{
						switch (num)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							goto IL_284;
						case 14:
						case 16:
							break;
						default:
							switch (num)
							{
							case 22:
							case 23:
							case 26:
							case 28:
								goto IL_284;
							case 24:
							case 25:
							case 27:
								break;
							default:
								switch (num)
								{
								case 33:
								case 35:
									goto IL_284;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num <= 75)
				{
					switch (num)
					{
					case 44:
					case 45:
					case 46:
					case 48:
					case 49:
					case 54:
					case 55:
					case 56:
					case 60:
					case 61:
					case 64:
						goto IL_284;
					case 47:
					case 50:
					case 51:
					case 52:
					case 53:
					case 57:
					case 58:
					case 59:
					case 62:
					case 63:
						break;
					default:
						if (num == 67)
						{
							goto IL_284;
						}
						switch (num)
						{
						case 74:
						case 75:
							goto IL_284;
						}
						break;
					}
				}
				else if (num == 82 || num == 86 || num == 92)
				{
					goto IL_284;
				}
			}
			else if (num <= 173)
			{
				if (num <= 119)
				{
					if (num == 95)
					{
						goto IL_284;
					}
					switch (num)
					{
					case 105:
						this.onDisk(vParent);
						goto IL_284;
					case 106:
						goto IL_284;
					default:
						if (num == 119)
						{
							goto IL_284;
						}
						break;
					}
				}
				else
				{
					switch (num)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						goto IL_284;
					case 124:
					case 127:
					case 128:
					case 130:
					case 133:
					case 135:
					case 136:
					case 137:
					case 139:
					case 141:
						break;
					default:
						switch (num)
						{
						case 156:
						case 160:
						case 161:
						case 162:
							goto IL_284;
						case 157:
						case 158:
						case 159:
							break;
						default:
							switch (num)
							{
							case 167:
							case 170:
							case 172:
							case 173:
								goto IL_284;
							}
							break;
						}
						break;
					}
				}
			}
			else if (num <= 191)
			{
				if (num == 176)
				{
					goto IL_284;
				}
				switch (num)
				{
				case 180:
				case 181:
					goto IL_284;
				default:
					if (num == 191)
					{
						goto IL_284;
					}
					break;
				}
			}
			else
			{
				if (num == 204)
				{
					goto IL_284;
				}
				switch (num)
				{
				case 219:
				case 220:
					goto IL_284;
				default:
					if (num == 232)
					{
						goto IL_284;
					}
					break;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_284:
			if (this.LA(1) == 232 && base.NextTokenMatches("LOG"))
			{
				IToken token = this.LT(1);
				this.match(232);
				this.match(105);
				this.fileDeclBodyList(vParent, vParent.LogOn);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.Match(token, "LOG");
					return;
				}
				return;
			}
			else
			{
				if (TSql80ParserInternal.tokenSet_20_.member(this.LA(1)))
				{
					return;
				}
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x00057A10 File Offset: 0x00055C10
		public void collationOpt(ICollationSetter vParent)
		{
			switch (this.LA(1))
			{
			case 1:
			case 6:
			case 7:
			case 9:
			case 10:
			case 12:
			case 13:
			case 14:
			case 15:
			case 17:
			case 21:
			case 22:
			case 23:
			case 28:
			case 29:
			case 30:
			case 33:
			case 35:
			case 36:
			case 44:
			case 45:
			case 46:
			case 47:
			case 48:
			case 49:
			case 50:
			case 54:
			case 55:
			case 56:
			case 58:
			case 59:
			case 60:
			case 61:
			case 64:
			case 67:
			case 68:
			case 71:
			case 72:
			case 74:
			case 75:
			case 76:
			case 77:
			case 79:
			case 82:
			case 83:
			case 85:
			case 86:
			case 87:
			case 88:
			case 89:
			case 90:
			case 92:
			case 93:
			case 94:
			case 95:
			case 99:
			case 100:
			case 105:
			case 106:
			case 111:
			case 112:
			case 113:
			case 114:
			case 118:
			case 119:
			case 123:
			case 125:
			case 126:
			case 127:
			case 129:
			case 131:
			case 132:
			case 133:
			case 134:
			case 136:
			case 138:
			case 140:
			case 142:
			case 143:
			case 144:
			case 150:
			case 156:
			case 158:
			case 159:
			case 160:
			case 161:
			case 162:
			case 167:
			case 168:
			case 169:
			case 170:
			case 171:
			case 172:
			case 173:
			case 176:
			case 180:
			case 181:
			case 188:
			case 189:
			case 190:
			case 191:
			case 192:
			case 193:
			case 194:
			case 195:
			case 196:
			case 197:
			case 198:
			case 199:
			case 201:
			case 204:
			case 205:
			case 206:
			case 207:
			case 208:
			case 209:
			case 210:
			case 219:
			case 220:
			case 230:
			case 231:
			case 232:
			case 233:
			case 234:
				return;
			case 26:
				this.collation(vParent);
				return;
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x00057DF4 File Offset: 0x00055FF4
		public void dbAddendums(CreateDatabaseStatement vParent)
		{
			this.match(67);
			int num = this.LA(1);
			if (num != 181)
			{
				if (num != 232)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				IToken token = this.LT(1);
				this.match(232);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.Match(token, "ATTACH");
					vParent.AttachMode = AttachMode.Attach;
					TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token);
				}
			}
			else
			{
				IToken token2 = this.LT(1);
				this.match(181);
				if (this.inputState.guessing == 0)
				{
					vParent.AttachMode = AttachMode.Load;
					TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token2);
				}
			}
			int num2 = this.LA(1);
			if (num2 <= 92)
			{
				if (num2 <= 28)
				{
					if (num2 <= 6)
					{
						if (num2 == 1 || num2 == 6)
						{
							return;
						}
					}
					else
					{
						switch (num2)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							return;
						case 14:
						case 16:
							break;
						default:
							switch (num2)
							{
							case 22:
							case 23:
								return;
							default:
								if (num2 == 28)
								{
									return;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num2 <= 75)
				{
					switch (num2)
					{
					case 33:
					case 35:
						return;
					case 34:
						break;
					default:
						switch (num2)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							return;
						case 47:
						case 50:
						case 51:
						case 52:
						case 53:
						case 57:
						case 58:
						case 59:
						case 62:
						case 63:
							break;
						default:
							switch (num2)
							{
							case 74:
							case 75:
								return;
							}
							break;
						}
						break;
					}
				}
				else if (num2 == 82 || num2 == 86 || num2 == 92)
				{
					return;
				}
			}
			else if (num2 <= 173)
			{
				if (num2 <= 119)
				{
					if (num2 == 95 || num2 == 106 || num2 == 119)
					{
						return;
					}
				}
				else
				{
					switch (num2)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return;
					case 124:
					case 127:
					case 128:
					case 130:
					case 133:
					case 135:
					case 136:
					case 137:
					case 139:
					case 141:
						break;
					default:
						switch (num2)
						{
						case 156:
						case 160:
						case 161:
						case 162:
							return;
						case 157:
						case 158:
						case 159:
							break;
						default:
							switch (num2)
							{
							case 167:
							case 170:
							case 172:
							case 173:
								return;
							}
							break;
						}
						break;
					}
				}
			}
			else if (num2 <= 191)
			{
				if (num2 == 176)
				{
					return;
				}
				switch (num2)
				{
				case 180:
				case 181:
					return;
				default:
					if (num2 == 191)
					{
						return;
					}
					break;
				}
			}
			else
			{
				if (num2 == 204)
				{
					return;
				}
				switch (num2)
				{
				case 219:
				case 220:
					return;
				default:
					if (num2 == 232)
					{
						this.match(232);
						return;
					}
					break;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x0005810C File Offset: 0x0005630C
		public void onDisk(CreateDatabaseStatement vParent)
		{
			FileGroupDefinition fileGroupDefinition = base.FragmentFactory.CreateFragment<FileGroupDefinition>();
			vParent.FileGroups.Add(fileGroupDefinition);
			this.match(105);
			FileDeclaration fileDeclaration = this.fileDecl(false);
			if (this.inputState.guessing == 0)
			{
				fileGroupDefinition.FileDeclarations.Add(fileDeclaration);
				vParent.UpdateTokenInfo(fileDeclaration);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				int num = this.LA(1);
				if (num != 118 && num != 191)
				{
					if (num != 232)
					{
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
					FileGroupDefinition fileGroupDefinition2 = this.fileGroupDecl();
					if (this.inputState.guessing == 0)
					{
						fileGroupDefinition = fileGroupDefinition2;
						TSql80ParserBaseInternal.AddAndUpdateTokenInfo<FileGroupDefinition>(vParent, vParent.FileGroups, fileGroupDefinition);
					}
				}
				else
				{
					fileDeclaration = this.fileDecl(false);
					if (this.inputState.guessing == 0)
					{
						fileGroupDefinition.FileDeclarations.Add(fileDeclaration);
						vParent.UpdateTokenInfo(fileDeclaration);
					}
				}
			}
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x00058204 File Offset: 0x00056404
		public FileGroupDefinition fileGroupDecl()
		{
			FileGroupDefinition fileGroupDefinition = base.FragmentFactory.CreateFragment<FileGroupDefinition>();
			IToken token = this.LT(1);
			this.match(232);
			Identifier name = this.identifier();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.Match(token, "FILEGROUP");
				TSql80ParserBaseInternal.UpdateTokenInfo(fileGroupDefinition, token);
				fileGroupDefinition.Name = name;
			}
			int num = this.LA(1);
			if (num != 47)
			{
				if (num != 191)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
			}
			else
			{
				this.match(47);
				if (this.inputState.guessing == 0)
				{
					fileGroupDefinition.IsDefault = true;
				}
			}
			FileDeclaration item = this.fileDeclBody(false);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<FileDeclaration>(fileGroupDefinition, fileGroupDefinition.FileDeclarations, item);
			}
			return fileGroupDefinition;
		}

		// Token: 0x06001295 RID: 4757 RVA: 0x000582D0 File Offset: 0x000564D0
		public FileDeclaration fileDeclBody(bool isAlterDbModifyFileStatement)
		{
			FileDeclaration fileDeclaration = base.FragmentFactory.CreateFragment<FileDeclaration>();
			int num = 0;
			IToken token = this.LT(1);
			this.match(191);
			FileDeclarationOption fileDeclarationOption = this.fileOption(isAlterDbModifyFileStatement);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(fileDeclaration, token);
				TSql80ParserBaseInternal.CheckOptionDuplication(ref num, (int)fileDeclarationOption.OptionKind, fileDeclarationOption);
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<FileDeclarationOption>(fileDeclaration, fileDeclaration.Options, fileDeclarationOption);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				fileDeclarationOption = this.fileOption(isAlterDbModifyFileStatement);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.CheckOptionDuplication(ref num, (int)fileDeclarationOption.OptionKind, fileDeclarationOption);
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<FileDeclarationOption>(fileDeclaration, fileDeclaration.Options, fileDeclarationOption);
				}
			}
			IToken token2 = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(fileDeclaration, token2);
				if (!isAlterDbModifyFileStatement && (num & 8) == 0)
				{
					TSql80ParserBaseInternal.ThrowParseErrorException("SQL46065", fileDeclaration, TSqlParserResource.SQL46065Message, new string[0]);
				}
			}
			return fileDeclaration;
		}

		// Token: 0x06001296 RID: 4758 RVA: 0x000583CC File Offset: 0x000565CC
		public FileDeclarationOption fileOption(bool newNameAllowed)
		{
			FileDeclarationOption fileDeclarationOption;
			if (this.LA(1) == 232 && this.LA(2) == 206 && base.NextTokenMatches("NAME"))
			{
				fileDeclarationOption = this.nameFileOption();
			}
			else if (this.LA(1) == 232 && this.LA(2) == 206 && base.NextTokenMatches("FILENAME"))
			{
				fileDeclarationOption = this.fileNameFileOption();
			}
			else if (this.LA(1) == 232 && this.LA(2) == 206 && base.NextTokenMatches("SIZE"))
			{
				fileDeclarationOption = this.sizeFileOption();
			}
			else if (this.LA(1) == 232 && this.LA(2) == 206 && base.NextTokenMatches("MAXSIZE"))
			{
				fileDeclarationOption = this.maxSizeFileOption();
			}
			else if (this.LA(1) == 232 && this.LA(2) == 206 && base.NextTokenMatches("FILEGROWTH"))
			{
				fileDeclarationOption = this.fileGrowthFileOption();
			}
			else
			{
				if (this.LA(1) != 232 || this.LA(2) != 206 || !base.NextTokenMatches("NEWNAME"))
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				fileDeclarationOption = this.newNameFileOption();
				if (this.inputState.guessing == 0 && !newNameAllowed)
				{
					TSql80ParserBaseInternal.ThrowParseErrorException("SQL46062", fileDeclarationOption, TSqlParserResource.SQL46062Message, new string[0]);
				}
			}
			return fileDeclarationOption;
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x00058550 File Offset: 0x00056750
		public NameFileDeclarationOption nameFileOption()
		{
			NameFileDeclarationOption nameFileDeclarationOption = base.FragmentFactory.CreateFragment<NameFileDeclarationOption>();
			IToken token = this.LT(1);
			this.match(232);
			this.match(206);
			IdentifierOrValueExpression logicalFileName = this.nonEmptyStringOrIdentifier();
			if (this.inputState.guessing == 0)
			{
				nameFileDeclarationOption.OptionKind = FileDeclarationOptionKind.Name;
				TSql80ParserBaseInternal.Match(token, "NAME");
				TSql80ParserBaseInternal.UpdateTokenInfo(nameFileDeclarationOption, token);
				nameFileDeclarationOption.LogicalFileName = logicalFileName;
				nameFileDeclarationOption.IsNewName = false;
			}
			return nameFileDeclarationOption;
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x000585C8 File Offset: 0x000567C8
		public FileNameFileDeclarationOption fileNameFileOption()
		{
			FileNameFileDeclarationOption fileNameFileDeclarationOption = base.FragmentFactory.CreateFragment<FileNameFileDeclarationOption>();
			IToken token = this.LT(1);
			this.match(232);
			this.match(206);
			Literal osfileName = this.nonEmptyString();
			if (this.inputState.guessing == 0)
			{
				fileNameFileDeclarationOption.OptionKind = FileDeclarationOptionKind.FileName;
				TSql80ParserBaseInternal.Match(token, "FILENAME");
				TSql80ParserBaseInternal.UpdateTokenInfo(fileNameFileDeclarationOption, token);
				fileNameFileDeclarationOption.OSFileName = osfileName;
			}
			return fileNameFileDeclarationOption;
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x00058638 File Offset: 0x00056838
		public SizeFileDeclarationOption sizeFileOption()
		{
			SizeFileDeclarationOption sizeFileDeclarationOption = base.FragmentFactory.CreateFragment<SizeFileDeclarationOption>();
			IToken token = this.LT(1);
			this.match(232);
			this.match(206);
			Literal size = this.integer();
			if (this.inputState.guessing == 0)
			{
				sizeFileDeclarationOption.OptionKind = FileDeclarationOptionKind.Size;
				TSql80ParserBaseInternal.Match(token, "SIZE");
				TSql80ParserBaseInternal.UpdateTokenInfo(sizeFileDeclarationOption, token);
				sizeFileDeclarationOption.Size = size;
			}
			int num = this.LA(1);
			if (num != 192 && num != 198)
			{
				if (num != 232)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				MemoryUnit units = this.memUnit();
				if (this.inputState.guessing == 0)
				{
					sizeFileDeclarationOption.Units = units;
				}
			}
			return sizeFileDeclarationOption;
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x000586FC File Offset: 0x000568FC
		public MaxSizeFileDeclarationOption maxSizeFileOption()
		{
			MaxSizeFileDeclarationOption maxSizeFileDeclarationOption = base.FragmentFactory.CreateFragment<MaxSizeFileDeclarationOption>();
			IToken token = this.LT(1);
			this.match(232);
			this.match(206);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.Match(token, "MAXSIZE");
				maxSizeFileDeclarationOption.OptionKind = FileDeclarationOptionKind.MaxSize;
				TSql80ParserBaseInternal.UpdateTokenInfo(maxSizeFileDeclarationOption, token);
			}
			int num = this.LA(1);
			if (num != 221)
			{
				if (num != 232)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				IToken token2 = this.LT(1);
				this.match(232);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.Match(token2, "UNLIMITED");
					maxSizeFileDeclarationOption.Unlimited = true;
				}
			}
			else
			{
				Literal maxSize = this.integer();
				if (this.inputState.guessing == 0)
				{
					maxSizeFileDeclarationOption.MaxSize = maxSize;
				}
				int num2 = this.LA(1);
				if (num2 != 192 && num2 != 198)
				{
					if (num2 != 232)
					{
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
					MemoryUnit units = this.memUnit();
					if (this.inputState.guessing == 0)
					{
						maxSizeFileDeclarationOption.Units = units;
					}
				}
			}
			return maxSizeFileDeclarationOption;
		}

		// Token: 0x0600129B RID: 4763 RVA: 0x0005883C File Offset: 0x00056A3C
		public FileGrowthFileDeclarationOption fileGrowthFileOption()
		{
			FileGrowthFileDeclarationOption fileGrowthFileDeclarationOption = base.FragmentFactory.CreateFragment<FileGrowthFileDeclarationOption>();
			IToken token = this.LT(1);
			this.match(232);
			this.match(206);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.Match(token, "FILEGROWTH");
				fileGrowthFileDeclarationOption.OptionKind = FileDeclarationOptionKind.FileGrowth;
				TSql80ParserBaseInternal.UpdateTokenInfo(fileGrowthFileDeclarationOption, token);
			}
			Literal growthIncrement = this.integer();
			if (this.inputState.guessing == 0)
			{
				fileGrowthFileDeclarationOption.GrowthIncrement = growthIncrement;
			}
			int num = this.LA(1);
			if (num <= 192)
			{
				if (num != 189)
				{
					if (num == 192)
					{
						return fileGrowthFileDeclarationOption;
					}
				}
				else
				{
					IToken token2 = this.LT(1);
					this.match(189);
					if (this.inputState.guessing == 0)
					{
						fileGrowthFileDeclarationOption.Units = MemoryUnit.Percent;
						TSql80ParserBaseInternal.UpdateTokenInfo(fileGrowthFileDeclarationOption, token2);
						return fileGrowthFileDeclarationOption;
					}
					return fileGrowthFileDeclarationOption;
				}
			}
			else
			{
				if (num == 198)
				{
					return fileGrowthFileDeclarationOption;
				}
				if (num == 232)
				{
					MemoryUnit units = this.memUnit();
					if (this.inputState.guessing == 0)
					{
						fileGrowthFileDeclarationOption.Units = units;
						return fileGrowthFileDeclarationOption;
					}
					return fileGrowthFileDeclarationOption;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x00058954 File Offset: 0x00056B54
		public NameFileDeclarationOption newNameFileOption()
		{
			NameFileDeclarationOption nameFileDeclarationOption = base.FragmentFactory.CreateFragment<NameFileDeclarationOption>();
			IToken token = this.LT(1);
			this.match(232);
			this.match(206);
			IdentifierOrValueExpression logicalFileName = this.nonEmptyStringOrIdentifier();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.Match(token, "NEWNAME");
				nameFileDeclarationOption.OptionKind = FileDeclarationOptionKind.NewName;
				TSql80ParserBaseInternal.UpdateTokenInfo(nameFileDeclarationOption, token);
				nameFileDeclarationOption.LogicalFileName = logicalFileName;
				nameFileDeclarationOption.IsNewName = true;
			}
			return nameFileDeclarationOption;
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x000589CC File Offset: 0x00056BCC
		public IdentifierOrValueExpression nonEmptyStringOrIdentifier()
		{
			IdentifierOrValueExpression identifierOrValueExpression = base.FragmentFactory.CreateFragment<IdentifierOrValueExpression>();
			switch (this.LA(1))
			{
			case 230:
			case 231:
			{
				Literal valueExpression = this.nonEmptyString();
				if (this.inputState.guessing == 0)
				{
					identifierOrValueExpression.ValueExpression = valueExpression;
				}
				break;
			}
			case 232:
			case 233:
			{
				Identifier identifier = this.identifier();
				if (this.inputState.guessing == 0)
				{
					identifierOrValueExpression.Identifier = identifier;
				}
				break;
			}
			default:
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			return identifierOrValueExpression;
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x00058A5C File Offset: 0x00056C5C
		public StringLiteral nonEmptyString()
		{
			StringLiteral stringLiteral = this.stringLiteral();
			if (this.inputState.guessing == 0 && (stringLiteral.Value == null || stringLiteral.Value.Length == 0))
			{
				TSql80ParserBaseInternal.ThrowParseErrorException("SQL46063", stringLiteral, TSqlParserResource.SQL46063Message, new string[0]);
			}
			return stringLiteral;
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x00058AAC File Offset: 0x00056CAC
		public MemoryUnit memUnit()
		{
			MemoryUnit result = MemoryUnit.Unspecified;
			IToken token = this.LT(1);
			this.match(232);
			if (this.inputState.guessing == 0)
			{
				result = MemoryUnitsHelper.Instance.ParseOption(token);
			}
			return result;
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x00058AEC File Offset: 0x00056CEC
		public IToken backupStart()
		{
			IToken result = null;
			int num = this.LA(1);
			if (num != 12)
			{
				if (num != 180)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				IToken token = this.LT(1);
				this.match(180);
				if (this.inputState.guessing == 0)
				{
					result = token;
				}
			}
			else
			{
				IToken token2 = this.LT(1);
				this.match(12);
				if (this.inputState.guessing == 0)
				{
					result = token2;
				}
			}
			return result;
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x00058B70 File Offset: 0x00056D70
		public BackupStatement backupMain()
		{
			int num = this.LA(1);
			BackupStatement result;
			if (num != 43)
			{
				switch (num)
				{
				case 153:
				case 154:
					break;
				default:
					if (num != 232)
					{
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
					break;
				}
				result = this.backupTransactionLog();
			}
			else
			{
				result = this.backupDatabase();
			}
			return result;
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x00058BD0 File Offset: 0x00056DD0
		public void devList(TSqlFragment vParent, IList<DeviceInfo> deviceInfos)
		{
			DeviceInfo item = this.deviceInfo();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<DeviceInfo>(vParent, deviceInfos, item);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				item = this.deviceInfo();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<DeviceInfo>(vParent, deviceInfos, item);
				}
			}
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x00058C30 File Offset: 0x00056E30
		public void backupOptions(BackupStatement vParent)
		{
			this.match(171);
			BackupOption item = this.backupOption();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<BackupOption>(vParent, vParent.Options, item);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				item = this.backupOption();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<BackupOption>(vParent, vParent.Options, item);
				}
			}
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x00058CA8 File Offset: 0x00056EA8
		public IToken restoreStart()
		{
			IToken result = null;
			int num = this.LA(1);
			if (num != 129)
			{
				if (num != 181)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				IToken token = this.LT(1);
				this.match(181);
				if (this.inputState.guessing == 0)
				{
					result = token;
				}
			}
			else
			{
				IToken token2 = this.LT(1);
				this.match(129);
				if (this.inputState.guessing == 0)
				{
					result = token2;
				}
			}
			return result;
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x00058D34 File Offset: 0x00056F34
		public void restoreMain(RestoreStatement vParent)
		{
			int num = this.LA(1);
			if (num == 43)
			{
				this.match(43);
				IdentifierOrValueExpression databaseName = this.identifierOrVariable();
				if (this.inputState.guessing == 0)
				{
					vParent.DatabaseName = databaseName;
					vParent.Kind = RestoreStatementKind.Database;
					base.ThrowPartialAstIfPhaseOne(vParent);
				}
				this.restoreFileListOpt(vParent);
				return;
			}
			switch (num)
			{
			case 153:
			case 154:
			{
				switch (this.LA(1))
				{
				case 153:
					this.match(153);
					break;
				case 154:
					this.match(154);
					break;
				default:
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				IdentifierOrValueExpression databaseName = this.identifierOrVariable();
				if (this.inputState.guessing == 0)
				{
					vParent.DatabaseName = databaseName;
					vParent.Kind = RestoreStatementKind.TransactionLog;
					base.ThrowPartialAstIfPhaseOne(vParent);
					return;
				}
				return;
			}
			default:
			{
				if (num != 232)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				IToken token = this.LT(1);
				this.match(232);
				IdentifierOrValueExpression databaseName = this.identifierOrVariable();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.Match(token, "LOG");
					vParent.DatabaseName = databaseName;
					vParent.Kind = RestoreStatementKind.TransactionLog;
					base.ThrowPartialAstIfPhaseOne(vParent);
				}
				this.restoreFileListOpt(vParent);
				return;
			}
			}
		}

		// Token: 0x060012A6 RID: 4774 RVA: 0x00058E84 File Offset: 0x00057084
		public void restoreOptions(RestoreStatement vParent)
		{
			this.match(171);
			this.restoreOptionsList(vParent);
		}

		// Token: 0x060012A7 RID: 4775 RVA: 0x00058E98 File Offset: 0x00057098
		public BackupDatabaseStatement backupDatabase()
		{
			BackupDatabaseStatement backupDatabaseStatement = base.FragmentFactory.CreateFragment<BackupDatabaseStatement>();
			this.match(43);
			IdentifierOrValueExpression databaseName = this.identifierOrVariable();
			if (this.inputState.guessing == 0)
			{
				backupDatabaseStatement.DatabaseName = databaseName;
				base.ThrowPartialAstIfPhaseOne(backupDatabaseStatement);
			}
			this.backupFileListOpt(backupDatabaseStatement);
			return backupDatabaseStatement;
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x00058EE4 File Offset: 0x000570E4
		public BackupTransactionLogStatement backupTransactionLog()
		{
			BackupTransactionLogStatement backupTransactionLogStatement = base.FragmentFactory.CreateFragment<BackupTransactionLogStatement>();
			int num = this.LA(1);
			switch (num)
			{
			case 153:
				this.match(153);
				break;
			case 154:
				this.match(154);
				break;
			default:
			{
				if (num != 232)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				IToken token = this.LT(1);
				this.match(232);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.Match(token, "LOG");
				}
				break;
			}
			}
			IdentifierOrValueExpression databaseName = this.identifierOrVariable();
			if (this.inputState.guessing == 0)
			{
				backupTransactionLogStatement.DatabaseName = databaseName;
				base.ThrowPartialAstIfPhaseOne(backupTransactionLogStatement);
			}
			return backupTransactionLogStatement;
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x00058FA4 File Offset: 0x000571A4
		public IdentifierOrValueExpression identifierOrVariable()
		{
			IdentifierOrValueExpression identifierOrValueExpression = base.FragmentFactory.CreateFragment<IdentifierOrValueExpression>();
			switch (this.LA(1))
			{
			case 232:
			case 233:
			{
				Identifier identifier = this.identifier();
				if (this.inputState.guessing == 0)
				{
					identifierOrValueExpression.Identifier = identifier;
				}
				break;
			}
			case 234:
			{
				ValueExpression valueExpression = this.variable();
				if (this.inputState.guessing == 0)
				{
					identifierOrValueExpression.ValueExpression = valueExpression;
				}
				break;
			}
			default:
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			return identifierOrValueExpression;
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x00059030 File Offset: 0x00057230
		public void backupFileListOpt(BackupDatabaseStatement vParent)
		{
			int num = this.LA(1);
			if (num <= 92)
			{
				if (num <= 28)
				{
					if (num <= 6)
					{
						if (num != 1 && num != 6)
						{
							goto IL_2C9;
						}
						return;
					}
					else
					{
						switch (num)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							return;
						case 14:
						case 16:
							goto IL_2C9;
						default:
							switch (num)
							{
							case 22:
							case 23:
								return;
							default:
								if (num != 28)
								{
									goto IL_2C9;
								}
								return;
							}
							break;
						}
					}
				}
				else if (num <= 75)
				{
					switch (num)
					{
					case 33:
					case 35:
						return;
					case 34:
						goto IL_2C9;
					default:
						switch (num)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							return;
						case 47:
						case 50:
						case 51:
						case 52:
						case 53:
						case 57:
						case 58:
						case 59:
						case 62:
						case 63:
							goto IL_2C9;
						case 65:
							break;
						default:
							switch (num)
							{
							case 74:
							case 75:
								return;
							default:
								goto IL_2C9;
							}
							break;
						}
						break;
					}
				}
				else
				{
					if (num != 82 && num != 86 && num != 92)
					{
						goto IL_2C9;
					}
					return;
				}
			}
			else if (num <= 151)
			{
				if (num <= 106)
				{
					if (num != 95 && num != 106)
					{
						goto IL_2C9;
					}
					return;
				}
				else
				{
					if (num == 119)
					{
						return;
					}
					switch (num)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return;
					case 124:
					case 127:
					case 128:
					case 130:
					case 133:
					case 135:
					case 136:
					case 137:
					case 139:
					case 141:
						goto IL_2C9;
					default:
						if (num != 151)
						{
							goto IL_2C9;
						}
						return;
					}
				}
			}
			else if (num <= 191)
			{
				switch (num)
				{
				case 156:
				case 160:
				case 161:
				case 162:
					return;
				case 157:
				case 158:
				case 159:
					goto IL_2C9;
				default:
					switch (num)
					{
					case 167:
					case 170:
					case 171:
					case 172:
					case 173:
					case 176:
					case 180:
					case 181:
						return;
					case 168:
					case 169:
					case 174:
					case 175:
					case 177:
					case 178:
					case 179:
						goto IL_2C9;
					default:
						if (num != 191)
						{
							goto IL_2C9;
						}
						return;
					}
					break;
				}
			}
			else
			{
				if (num == 204)
				{
					return;
				}
				switch (num)
				{
				case 219:
				case 220:
					return;
				default:
					if (num != 232)
					{
						goto IL_2C9;
					}
					break;
				}
			}
			BackupRestoreFileInfo item = this.backupRestoreFile();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<BackupRestoreFileInfo>(vParent, vParent.Files, item);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				item = this.backupRestoreFile();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<BackupRestoreFileInfo>(vParent, vParent.Files, item);
				}
			}
			return;
			IL_2C9:
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x0005931C File Offset: 0x0005751C
		public BackupRestoreFileInfo backupRestoreFile()
		{
			BackupRestoreFileInfo backupRestoreFileInfo = base.FragmentFactory.CreateFragment<BackupRestoreFileInfo>();
			int num = this.LA(1);
			if (num != 65)
			{
				if (num != 232)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				IToken token = this.LT(1);
				this.match(232);
				this.match(206);
				int num2 = this.LA(1);
				if (num2 != 191)
				{
					switch (num2)
					{
					case 230:
					case 231:
					case 234:
					{
						ValueExpression item = this.stringOrVariable();
						if (this.inputState.guessing == 0)
						{
							if (TSql80ParserBaseInternal.TryMatch(token, "PAGE"))
							{
								backupRestoreFileInfo.ItemKind = BackupRestoreItemKind.Page;
							}
							else
							{
								TSql80ParserBaseInternal.Match(token, "FILEGROUP");
								backupRestoreFileInfo.ItemKind = BackupRestoreItemKind.FileGroups;
							}
							TSql80ParserBaseInternal.UpdateTokenInfo(backupRestoreFileInfo, token);
							TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ValueExpression>(backupRestoreFileInfo, backupRestoreFileInfo.Items, item);
							return backupRestoreFileInfo;
						}
						return backupRestoreFileInfo;
					}
					}
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				this.backupRestoreFileNameList(backupRestoreFileInfo);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.Match(token, "FILEGROUP");
					backupRestoreFileInfo.ItemKind = BackupRestoreItemKind.FileGroups;
				}
			}
			else
			{
				this.LT(1);
				this.match(65);
				this.match(206);
				if (this.inputState.guessing == 0)
				{
					backupRestoreFileInfo.ItemKind = BackupRestoreItemKind.Files;
				}
				int num3 = this.LA(1);
				if (num3 != 191)
				{
					switch (num3)
					{
					case 230:
					case 231:
					case 234:
					{
						ValueExpression item = this.stringOrVariable();
						if (this.inputState.guessing == 0)
						{
							TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ValueExpression>(backupRestoreFileInfo, backupRestoreFileInfo.Items, item);
							return backupRestoreFileInfo;
						}
						return backupRestoreFileInfo;
					}
					}
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				this.backupRestoreFileNameList(backupRestoreFileInfo);
			}
			return backupRestoreFileInfo;
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x000594F8 File Offset: 0x000576F8
		public void restoreFileListOpt(RestoreStatement vParent)
		{
			int num = this.LA(1);
			if (num <= 86)
			{
				if (num <= 28)
				{
					if (num <= 6)
					{
						if (num != 1 && num != 6)
						{
							goto IL_2C7;
						}
						return;
					}
					else
					{
						switch (num)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							return;
						case 14:
						case 16:
							goto IL_2C7;
						default:
							switch (num)
							{
							case 22:
							case 23:
								return;
							default:
								if (num != 28)
								{
									goto IL_2C7;
								}
								return;
							}
							break;
						}
					}
				}
				else if (num <= 65)
				{
					switch (num)
					{
					case 33:
					case 35:
						return;
					case 34:
						goto IL_2C7;
					default:
						switch (num)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							return;
						case 47:
						case 50:
						case 51:
						case 52:
						case 53:
						case 57:
						case 58:
						case 59:
						case 62:
						case 63:
							goto IL_2C7;
						case 65:
							break;
						default:
							goto IL_2C7;
						}
						break;
					}
				}
				else
				{
					switch (num)
					{
					case 71:
					case 74:
					case 75:
						return;
					case 72:
					case 73:
						goto IL_2C7;
					default:
						if (num != 82 && num != 86)
						{
							goto IL_2C7;
						}
						return;
					}
				}
			}
			else if (num <= 144)
			{
				if (num <= 95)
				{
					if (num != 92 && num != 95)
					{
						goto IL_2C7;
					}
					return;
				}
				else
				{
					if (num == 106 || num == 119)
					{
						return;
					}
					switch (num)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return;
					case 124:
					case 127:
					case 128:
					case 130:
					case 133:
					case 135:
					case 136:
					case 137:
					case 139:
					case 141:
						goto IL_2C7;
					default:
						goto IL_2C7;
					}
				}
			}
			else if (num <= 191)
			{
				switch (num)
				{
				case 156:
				case 160:
				case 161:
				case 162:
					return;
				case 157:
				case 158:
				case 159:
					goto IL_2C7;
				default:
					switch (num)
					{
					case 167:
					case 170:
					case 171:
					case 172:
					case 173:
					case 176:
					case 180:
					case 181:
						return;
					case 168:
					case 169:
					case 174:
					case 175:
					case 177:
					case 178:
					case 179:
						goto IL_2C7;
					default:
						if (num != 191)
						{
							goto IL_2C7;
						}
						return;
					}
					break;
				}
			}
			else
			{
				if (num == 204)
				{
					return;
				}
				switch (num)
				{
				case 219:
				case 220:
					return;
				default:
					if (num != 232)
					{
						goto IL_2C7;
					}
					break;
				}
			}
			BackupRestoreFileInfo item = this.backupRestoreFile();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<BackupRestoreFileInfo>(vParent, vParent.Files, item);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				item = this.backupRestoreFile();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<BackupRestoreFileInfo>(vParent, vParent.Files, item);
				}
			}
			return;
			IL_2C7:
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x060012AD RID: 4781 RVA: 0x000597E0 File Offset: 0x000579E0
		public ValueExpression stringOrVariable()
		{
			switch (this.LA(1))
			{
			case 230:
			case 231:
				return this.stringLiteral();
			case 234:
				return this.variable();
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x00059840 File Offset: 0x00057A40
		public void backupRestoreFileNameList(BackupRestoreFileInfo vParent)
		{
			this.LT(1);
			this.match(191);
			ValueExpression item = this.stringOrVariable();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ValueExpression>(vParent, vParent.Items, item);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				item = this.stringOrVariable();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ValueExpression>(vParent, vParent.Items, item);
				}
			}
			IToken token = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token);
			}
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x000598E8 File Offset: 0x00057AE8
		public DeviceInfo deviceInfo()
		{
			DeviceInfo deviceInfo = base.FragmentFactory.CreateFragment<DeviceInfo>();
			if (this.LA(1) >= 232 && this.LA(1) <= 234 && TSql80ParserInternal.tokenSet_19_.member(this.LA(2)))
			{
				IdentifierOrValueExpression logicalDevice = this.identifierOrVariable();
				if (this.inputState.guessing == 0)
				{
					deviceInfo.LogicalDevice = logicalDevice;
				}
			}
			else
			{
				if ((this.LA(1) != 173 && this.LA(1) != 232) || this.LA(2) != 206)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				int num = this.LA(1);
				if (num != 173)
				{
					if (num != 232)
					{
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
					IToken token = this.LT(1);
					this.match(232);
					if (this.inputState.guessing == 0)
					{
						deviceInfo.DeviceType = DeviceTypesHelper.Instance.ParseOption(token);
					}
				}
				else
				{
					this.match(173);
					if (this.inputState.guessing == 0)
					{
						deviceInfo.DeviceType = DeviceType.Disk;
					}
				}
				this.match(206);
				ValueExpression physicalDevice = this.stringOrVariable();
				if (this.inputState.guessing == 0)
				{
					deviceInfo.PhysicalDevice = physicalDevice;
				}
			}
			return deviceInfo;
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x00059A44 File Offset: 0x00057C44
		public BackupOption backupOption()
		{
			BackupOption backupOption = base.FragmentFactory.CreateFragment<BackupOption>();
			if (this.LA(1) == 232 && TSql80ParserInternal.tokenSet_21_.member(this.LA(2)))
			{
				IToken token = this.LT(1);
				this.match(232);
				if (this.inputState.guessing == 0)
				{
					backupOption.OptionKind = BackupOptionsNoValueHelper.Instance.ParseOption(token, SqlVersionFlags.TSql80);
					TSql80ParserBaseInternal.UpdateTokenInfo(backupOption, token);
				}
			}
			else
			{
				if (this.LA(1) != 232 || this.LA(2) != 206)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				IToken token2 = this.LT(1);
				this.match(232);
				this.match(206);
				int num = this.LA(1);
				ScalarExpression value;
				if (num != 199 && num != 221)
				{
					switch (num)
					{
					case 230:
					case 231:
						value = this.stringLiteral();
						goto IL_115;
					case 234:
						goto IL_F0;
					}
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				IL_F0:
				value = this.signedIntegerOrVariable();
				IL_115:
				if (this.inputState.guessing == 0)
				{
					backupOption.OptionKind = BackupOptionsWithValueHelper.Instance.ParseOption(token2, SqlVersionFlags.TSql80);
					backupOption.Value = value;
				}
			}
			return backupOption;
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x00059BA4 File Offset: 0x00057DA4
		public ScalarExpression signedIntegerOrVariable()
		{
			int num = this.LA(1);
			ScalarExpression result;
			if (num != 199 && num != 221)
			{
				if (num != 234)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				result = this.variable();
			}
			else
			{
				result = this.signedInteger();
			}
			return result;
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x00059BFC File Offset: 0x00057DFC
		public StringLiteral stringLiteral()
		{
			StringLiteral stringLiteral = base.FragmentFactory.CreateFragment<StringLiteral>();
			switch (this.LA(1))
			{
			case 230:
			{
				IToken token = this.LT(1);
				this.match(230);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(stringLiteral, token);
					stringLiteral.Value = TSql80ParserBaseInternal.DecodeAsciiStringLiteral(token.getText());
					stringLiteral.IsLargeObject = TSql80ParserBaseInternal.IsAsciiStringLob(stringLiteral.Value);
				}
				break;
			}
			case 231:
			{
				IToken token2 = this.LT(1);
				this.match(231);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(stringLiteral, token2);
					stringLiteral.IsNational = true;
					stringLiteral.Value = TSql80ParserBaseInternal.DecodeUnicodeStringLiteral(token2.getText());
					stringLiteral.IsLargeObject = TSql80ParserBaseInternal.IsUnicodeStringLob(stringLiteral.Value);
				}
				break;
			}
			default:
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			return stringLiteral;
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x00059CF0 File Offset: 0x00057EF0
		public void restoreOptionsList(RestoreStatement vParent)
		{
			RestoreOption item = this.restoreOption();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<RestoreOption>(vParent, vParent.Options, item);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				item = this.restoreOption();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<RestoreOption>(vParent, vParent.Options, item);
				}
			}
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x00059D5C File Offset: 0x00057F5C
		public RestoreOption restoreOption()
		{
			RestoreOption result = null;
			if (this.LA(1) == 232 && TSql80ParserInternal.tokenSet_21_.member(this.LA(2)))
			{
				result = this.simpleRestoreOption();
			}
			else if (this.LA(1) == 232 && this.LA(2) == 206)
			{
				IToken token = this.LT(1);
				this.match(232);
				this.match(206);
				if ((this.LA(1) == 230 || this.LA(1) == 231 || this.LA(1) == 234) && this.LA(2) == 232 && TSql80ParserBaseInternal.IsStopAtBeforeMarkRestoreOption(token))
				{
					ValueExpression valueExpression = this.stringOrVariable();
					ValueExpression afterClause = this.afterClause();
					if (this.inputState.guessing == 0)
					{
						result = base.CreateStopRestoreOption(token, valueExpression, afterClause);
					}
				}
				else if (this.LA(1) == 199 || this.LA(1) == 221)
				{
					ScalarExpression optionValue = this.signedInteger();
					if (this.inputState.guessing == 0)
					{
						result = base.CreateSimpleRestoreOptionWithValue(token, optionValue);
					}
				}
				else
				{
					if ((this.LA(1) != 230 && this.LA(1) != 231 && this.LA(1) != 234) || !TSql80ParserInternal.tokenSet_21_.member(this.LA(2)))
					{
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
					ValueExpression valueExpression = this.stringOrVariable();
					if (this.inputState.guessing == 0)
					{
						if (TSql80ParserBaseInternal.IsStopAtBeforeMarkRestoreOption(token))
						{
							result = base.CreateStopRestoreOption(token, valueExpression, null);
						}
						else
						{
							result = base.CreateSimpleRestoreOptionWithValue(token, valueExpression);
						}
					}
				}
			}
			else if (this.LA(1) == 232 && (this.LA(2) == 230 || this.LA(2) == 231 || this.LA(2) == 234))
			{
				result = this.moveRestoreOption();
			}
			else
			{
				if (this.LA(1) != 65)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				result = this.fileRestoreOption();
			}
			return result;
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x00059F7C File Offset: 0x0005817C
		public RestoreOption simpleRestoreOption()
		{
			RestoreOption restoreOption = base.FragmentFactory.CreateFragment<RestoreOption>();
			IToken token = this.LT(1);
			this.match(232);
			if (this.inputState.guessing == 0)
			{
				restoreOption.OptionKind = RestoreOptionNoValueHelper.Instance.ParseOption(token, SqlVersionFlags.TSql80);
				TSql80ParserBaseInternal.UpdateTokenInfo(restoreOption, token);
			}
			return restoreOption;
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x00059FD4 File Offset: 0x000581D4
		public ValueExpression afterClause()
		{
			IToken token = this.LT(1);
			this.match(232);
			ValueExpression result = this.stringOrVariable();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.Match(token, "AFTER");
			}
			return result;
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x0005A018 File Offset: 0x00058218
		public ScalarExpression signedInteger()
		{
			ScalarExpression result = null;
			UnaryExpression unaryExpression = null;
			int num = this.LA(1);
			if (num != 199)
			{
				if (num != 221)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
			}
			else
			{
				IToken token = this.LT(1);
				this.match(199);
				if (this.inputState.guessing == 0)
				{
					unaryExpression = base.FragmentFactory.CreateFragment<UnaryExpression>();
					TSql80ParserBaseInternal.UpdateTokenInfo(unaryExpression, token);
					unaryExpression.UnaryExpressionType = UnaryExpressionType.Negative;
				}
			}
			Literal literal = this.integer();
			if (this.inputState.guessing == 0)
			{
				if (unaryExpression == null)
				{
					result = literal;
				}
				else
				{
					unaryExpression.Expression = literal;
					result = unaryExpression;
				}
			}
			return result;
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x0005A0BC File Offset: 0x000582BC
		public MoveRestoreOption moveRestoreOption()
		{
			MoveRestoreOption moveRestoreOption = base.FragmentFactory.CreateFragment<MoveRestoreOption>();
			IToken token = this.LT(1);
			this.match(232);
			ValueExpression logicalFileName = this.stringOrVariable();
			this.match(151);
			ValueExpression osfileName = this.stringOrVariable();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.Match(token, "MOVE");
				moveRestoreOption.OptionKind = RestoreOptionKind.Move;
				moveRestoreOption.LogicalFileName = logicalFileName;
				moveRestoreOption.OSFileName = osfileName;
			}
			return moveRestoreOption;
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x0005A134 File Offset: 0x00058334
		public ScalarExpressionRestoreOption fileRestoreOption()
		{
			ScalarExpressionRestoreOption scalarExpressionRestoreOption = base.FragmentFactory.CreateFragment<ScalarExpressionRestoreOption>();
			this.match(65);
			this.match(206);
			ScalarExpression value = this.signedIntegerOrVariable();
			if (this.inputState.guessing == 0)
			{
				scalarExpressionRestoreOption.OptionKind = RestoreOptionKind.File;
				scalarExpressionRestoreOption.Value = value;
			}
			return scalarExpressionRestoreOption;
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x0005A184 File Offset: 0x00058384
		public SchemaObjectName schemaObjectThreePartName()
		{
			SchemaObjectName schemaObjectName = base.FragmentFactory.CreateFragment<SchemaObjectName>();
			List<Identifier> otherCollection = this.identifierList(3);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<Identifier>(schemaObjectName, schemaObjectName.Identifiers, otherCollection);
			}
			return schemaObjectName;
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x0005A1C0 File Offset: 0x000583C0
		public IdentifierOrValueExpression bulkInsertFrom()
		{
			IdentifierOrValueExpression result = null;
			int num = this.LA(1);
			if (num != 221)
			{
				switch (num)
				{
				case 230:
				case 231:
				case 232:
				case 233:
					result = this.stringOrIdentifier();
					break;
				default:
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
			}
			else
			{
				Literal valueExpression = this.integer();
				if (this.inputState.guessing == 0)
				{
					result = base.IdentifierOrValueExpression(valueExpression);
				}
			}
			return result;
		}

		// Token: 0x060012BC RID: 4796 RVA: 0x0005A238 File Offset: 0x00058438
		public void bulkInsertOptions(BulkInsertStatement vParent)
		{
			int num = 0;
			this.match(171);
			this.match(191);
			BulkInsertOption bulkInsertOption = this.bulkInsertOption();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.CheckOptionDuplication(ref num, (int)bulkInsertOption.OptionKind, bulkInsertOption);
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<BulkInsertOption>(vParent, vParent.Options, bulkInsertOption);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				bulkInsertOption = this.bulkInsertOption();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.CheckOptionDuplication(ref num, (int)bulkInsertOption.OptionKind, bulkInsertOption);
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<BulkInsertOption>(vParent, vParent.Options, bulkInsertOption);
				}
			}
			IToken token = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token);
			}
		}

		// Token: 0x060012BD RID: 4797 RVA: 0x0005A300 File Offset: 0x00058500
		public IdentifierOrValueExpression stringOrIdentifier()
		{
			IdentifierOrValueExpression identifierOrValueExpression = base.FragmentFactory.CreateFragment<IdentifierOrValueExpression>();
			switch (this.LA(1))
			{
			case 230:
			case 231:
			{
				Literal valueExpression = this.stringLiteral();
				if (this.inputState.guessing == 0)
				{
					identifierOrValueExpression.ValueExpression = valueExpression;
				}
				break;
			}
			case 232:
			case 233:
			{
				Identifier identifier = this.identifier();
				if (this.inputState.guessing == 0)
				{
					identifierOrValueExpression.Identifier = identifier;
				}
				break;
			}
			default:
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			return identifierOrValueExpression;
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x0005A390 File Offset: 0x00058590
		public BulkInsertOption bulkInsertOption()
		{
			BulkInsertOption result;
			if (this.LA(1) == 113)
			{
				result = this.bulkInsertSortOrderOption();
			}
			else if (this.LA(1) == 232 && this.LA(2) == 206)
			{
				result = this.simpleBulkInsertOptionWithValue();
			}
			else
			{
				if (this.LA(1) != 232 || (this.LA(2) != 192 && this.LA(2) != 198))
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				result = this.simpleBulkInsertOptionNoValue();
			}
			return result;
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x0005A420 File Offset: 0x00058620
		public OrderBulkInsertOption bulkInsertSortOrderOption()
		{
			OrderBulkInsertOption orderBulkInsertOption = base.FragmentFactory.CreateFragment<OrderBulkInsertOption>();
			IToken token = this.LT(1);
			this.match(113);
			this.match(191);
			ColumnWithSortOrder item = this.columnWithSortOrder();
			if (this.inputState.guessing == 0)
			{
				orderBulkInsertOption.OptionKind = BulkInsertOptionKind.Order;
				TSql80ParserBaseInternal.UpdateTokenInfo(orderBulkInsertOption, token);
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ColumnWithSortOrder>(orderBulkInsertOption, orderBulkInsertOption.Columns, item);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				item = this.columnWithSortOrder();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ColumnWithSortOrder>(orderBulkInsertOption, orderBulkInsertOption.Columns, item);
				}
			}
			IToken token2 = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(orderBulkInsertOption, token2);
			}
			return orderBulkInsertOption;
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x0005A4EC File Offset: 0x000586EC
		public LiteralBulkInsertOption simpleBulkInsertOptionWithValue()
		{
			LiteralBulkInsertOption literalBulkInsertOption = base.FragmentFactory.CreateFragment<LiteralBulkInsertOption>();
			IToken token = this.LT(1);
			this.match(232);
			this.match(206);
			int num = this.LA(1);
			switch (num)
			{
			case 221:
			case 222:
			{
				Literal literal = this.integerOrNumeric();
				if (this.inputState.guessing == 0)
				{
					literalBulkInsertOption.OptionKind = BulkInsertIntOptionsHelper.Instance.ParseOption(token);
					TSql80ParserBaseInternal.UpdateTokenInfo(literalBulkInsertOption, token);
					literalBulkInsertOption.Value = literal;
				}
				break;
			}
			default:
				switch (num)
				{
				case 230:
				case 231:
				{
					Literal literal = this.stringLiteral();
					if (this.inputState.guessing == 0)
					{
						literalBulkInsertOption.OptionKind = BulkInsertStringOptionsHelper.Instance.ParseOption(token);
						if (literalBulkInsertOption.OptionKind == BulkInsertOptionKind.CodePage)
						{
							TSql80ParserBaseInternal.MatchString(literal, new string[]
							{
								"ACP",
								"OEM",
								"RAW"
							});
						}
						else if (literalBulkInsertOption.OptionKind == BulkInsertOptionKind.DataFileType)
						{
							TSql80ParserBaseInternal.MatchString(literal, new string[]
							{
								"CHAR",
								"NATIVE",
								"WIDECHAR",
								"WIDENATIVE",
								"WIDECHAR_ANSI",
								"DTS_BUFFERS"
							});
						}
						TSql80ParserBaseInternal.UpdateTokenInfo(literalBulkInsertOption, token);
						literalBulkInsertOption.Value = literal;
					}
					break;
				}
				default:
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				break;
			}
			return literalBulkInsertOption;
		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x0005A668 File Offset: 0x00058868
		public BulkInsertOption simpleBulkInsertOptionNoValue()
		{
			BulkInsertOption bulkInsertOption = base.FragmentFactory.CreateFragment<BulkInsertOption>();
			IToken token = this.LT(1);
			this.match(232);
			if (this.inputState.guessing == 0)
			{
				bulkInsertOption.OptionKind = BulkInsertFlagOptionsHelper.Instance.ParseOption(token);
				TSql80ParserBaseInternal.UpdateTokenInfo(bulkInsertOption, token);
			}
			return bulkInsertOption;
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x0005A6BC File Offset: 0x000588BC
		public BulkInsertOption insertBulkOption()
		{
			int num = this.LA(1);
			BulkInsertOption result;
			if (num != 113)
			{
				if (num != 232)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				result = this.simpleInsertBulkOption();
			}
			else
			{
				result = this.bulkInsertSortOrderOption();
			}
			return result;
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x0005A708 File Offset: 0x00058908
		public BulkInsertOption simpleInsertBulkOption()
		{
			BulkInsertOption bulkInsertOption = null;
			IToken token = this.LT(1);
			this.match(232);
			int num = this.LA(1);
			if (num != 192 && num != 198)
			{
				if (num != 206)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				this.match(206);
				Literal value = this.integerOrNumeric();
				if (this.inputState.guessing == 0)
				{
					LiteralBulkInsertOption literalBulkInsertOption = base.FragmentFactory.CreateFragment<LiteralBulkInsertOption>();
					TSql80ParserBaseInternal.UpdateTokenInfo(literalBulkInsertOption, token);
					if (TSql80ParserBaseInternal.TryMatch(token, "ROWS_PER_BATCH"))
					{
						literalBulkInsertOption.OptionKind = BulkInsertOptionKind.RowsPerBatch;
					}
					else
					{
						TSql80ParserBaseInternal.Match(token, "KILOBYTES_PER_BATCH");
						literalBulkInsertOption.OptionKind = BulkInsertOptionKind.KilobytesPerBatch;
					}
					literalBulkInsertOption.Value = value;
					bulkInsertOption = literalBulkInsertOption;
				}
			}
			else if (this.inputState.guessing == 0)
			{
				bulkInsertOption = base.FragmentFactory.CreateFragment<BulkInsertOption>();
				bulkInsertOption.OptionKind = BulkInsertFlagOptionsHelper.Instance.ParseOption(token);
				TSql80ParserBaseInternal.UpdateTokenInfo(bulkInsertOption, token);
				if (bulkInsertOption.OptionKind == BulkInsertOptionKind.KeepIdentity)
				{
					throw TSql80ParserBaseInternal.GetUnexpectedTokenErrorException(token);
				}
			}
			return bulkInsertOption;
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x0005A814 File Offset: 0x00058A14
		public Literal integerOrNumeric()
		{
			Literal result;
			switch (this.LA(1))
			{
			case 221:
				result = this.integer();
				break;
			case 222:
				result = this.numeric();
				break;
			default:
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			return result;
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x0005A868 File Offset: 0x00058A68
		public void coldefList(InsertBulkStatement vParent)
		{
			this.match(191);
			InsertBulkColumnDefinition item = this.coldefItem();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<InsertBulkColumnDefinition>(vParent, vParent.ColumnDefinitions, item);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				item = this.coldefItem();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<InsertBulkColumnDefinition>(vParent, vParent.ColumnDefinitions, item);
				}
			}
			IToken token = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token);
			}
		}

		// Token: 0x060012C6 RID: 4806 RVA: 0x0005A908 File Offset: 0x00058B08
		public void insertBulkOptions(InsertBulkStatement vParent)
		{
			int num = 0;
			this.match(171);
			this.match(191);
			BulkInsertOption bulkInsertOption = this.insertBulkOption();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.CheckOptionDuplication(ref num, (int)bulkInsertOption.OptionKind, bulkInsertOption);
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<BulkInsertOption>(vParent, vParent.Options, bulkInsertOption);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				bulkInsertOption = this.insertBulkOption();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.CheckOptionDuplication(ref num, (int)bulkInsertOption.OptionKind, bulkInsertOption);
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<BulkInsertOption>(vParent, vParent.Options, bulkInsertOption);
				}
			}
			IToken token = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token);
			}
		}

		// Token: 0x060012C7 RID: 4807 RVA: 0x0005A9D0 File Offset: 0x00058BD0
		public InsertBulkColumnDefinition coldefItem()
		{
			InsertBulkColumnDefinition insertBulkColumnDefinition = base.FragmentFactory.CreateFragment<InsertBulkColumnDefinition>();
			ColumnDefinitionBase column = this.columnDefinitionEx();
			if (this.inputState.guessing == 0)
			{
				insertBulkColumnDefinition.Column = column;
			}
			int num = this.LA(1);
			switch (num)
			{
			case 99:
			case 100:
			{
				bool flag = this.nullNotNull(insertBulkColumnDefinition);
				if (this.inputState.guessing == 0)
				{
					insertBulkColumnDefinition.NullNotNull = (flag ? NullNotNull.Null : NullNotNull.NotNull);
				}
				break;
			}
			default:
				if (num != 192 && num != 198)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				break;
			}
			return insertBulkColumnDefinition;
		}

		// Token: 0x060012C8 RID: 4808 RVA: 0x0005AA68 File Offset: 0x00058C68
		public ColumnDefinitionBase columnDefinitionEx()
		{
			ColumnDefinitionBase columnDefinitionBase = null;
			if ((this.LA(1) == 232 || this.LA(1) == 233) && TSql80ParserInternal.tokenSet_22_.member(this.LA(2)))
			{
				columnDefinitionBase = this.columnDefinitionBasic();
			}
			else
			{
				if (this.LA(1) != 232 || !TSql80ParserInternal.tokenSet_23_.member(this.LA(2)))
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				IToken token = this.LT(1);
				this.match(232);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.Match(token, "TIMESTAMP");
					columnDefinitionBase = base.FragmentFactory.CreateFragment<ColumnDefinitionBase>();
					Identifier identifier = base.FragmentFactory.CreateFragment<Identifier>();
					TSql80ParserBaseInternal.UpdateTokenInfo(identifier, token);
					identifier.SetUnquotedIdentifier("TIMESTAMP");
					columnDefinitionBase.ColumnIdentifier = identifier;
				}
			}
			return columnDefinitionBase;
		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x0005AB48 File Offset: 0x00058D48
		public bool nullNotNull(TSqlFragment vParent)
		{
			bool result = true;
			switch (this.LA(1))
			{
			case 99:
			{
				IToken token = this.LT(1);
				this.match(99);
				if (this.inputState.guessing == 0)
				{
					result = false;
					TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token);
				}
				break;
			}
			case 100:
				break;
			default:
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			IToken token2 = this.LT(1);
			this.match(100);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token2);
			}
			return result;
		}

		// Token: 0x060012CA RID: 4810 RVA: 0x0005ABD8 File Offset: 0x00058DD8
		public ColumnWithSortOrder columnWithSortOrder()
		{
			ColumnWithSortOrder columnWithSortOrder = base.FragmentFactory.CreateFragment<ColumnWithSortOrder>();
			ColumnReferenceExpression column = this.identifierColumnReferenceExpression();
			if (this.inputState.guessing == 0)
			{
				columnWithSortOrder.Column = column;
			}
			int num = this.LA(1);
			if (num <= 50)
			{
				if (num == 10 || num == 50)
				{
					SortOrder sortOrder = this.orderByOption(columnWithSortOrder);
					if (this.inputState.guessing == 0)
					{
						columnWithSortOrder.SortOrder = sortOrder;
						return columnWithSortOrder;
					}
					return columnWithSortOrder;
				}
			}
			else if (num == 192 || num == 198)
			{
				return columnWithSortOrder;
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x060012CB RID: 4811 RVA: 0x0005AC6C File Offset: 0x00058E6C
		public void dbccNamedLiteralList(DbccStatement vParent)
		{
			IToken token = this.LT(1);
			this.match(191);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token);
			}
			int num = this.LA(1);
			if (num <= 193)
			{
				if (num != 100)
				{
					switch (num)
					{
					case 192:
						if (this.inputState.guessing == 0)
						{
							vParent.ParenthesisRequired = true;
							goto IL_12D;
						}
						goto IL_12D;
					case 193:
						break;
					default:
						goto IL_11A;
					}
				}
			}
			else if (num != 199)
			{
				switch (num)
				{
				case 221:
				case 222:
				case 223:
				case 224:
				case 225:
				case 230:
				case 231:
				case 232:
				case 233:
				case 234:
					break;
				case 226:
				case 227:
				case 228:
				case 229:
					goto IL_11A;
				default:
					goto IL_11A;
				}
			}
			DbccNamedLiteral item = this.dbccNamedLiteral();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<DbccNamedLiteral>(vParent, vParent.Literals, item);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				item = this.dbccNamedLiteral();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<DbccNamedLiteral>(vParent, vParent.Literals, item);
				}
			}
			goto IL_12D;
			IL_11A:
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_12D:
			IToken token2 = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token2);
			}
		}

		// Token: 0x060012CC RID: 4812 RVA: 0x0005ADCD File Offset: 0x00058FCD
		public void dbccOptions(DbccStatement vParent)
		{
			this.match(171);
			this.dbccOptionsList(vParent);
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x0005ADE4 File Offset: 0x00058FE4
		public void dbccOptionsList(DbccStatement vParent)
		{
			if (this.LA(1) == 232 && TSql80ParserInternal.tokenSet_21_.member(this.LA(2)))
			{
				this.dbccOptionsListItems(vParent);
				return;
			}
			if (this.LA(1) == 232 && this.LA(2) == 90)
			{
				this.dbccOptionsJoin(vParent);
				return;
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x0005AE50 File Offset: 0x00059050
		public void dbccOptionsListItems(DbccStatement vParent)
		{
			DbccOption item = this.dbccOption();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<DbccOption>(vParent, vParent.Options, item);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				item = this.dbccOption();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<DbccOption>(vParent, vParent.Options, item);
				}
			}
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x0005AEBC File Offset: 0x000590BC
		public void dbccOptionsJoin(DbccStatement vParent)
		{
			DbccOption item = this.dbccJoinOption();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<DbccOption>(vParent, vParent.Options, item);
			}
			int num = 0;
			while (this.LA(1) == 90)
			{
				this.match(90);
				item = this.dbccJoinOption();
				if (this.inputState.guessing == 0)
				{
					vParent.OptionsUseJoin = true;
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<DbccOption>(vParent, vParent.Options, item);
				}
				num++;
			}
			if (num >= 1)
			{
				return;
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x0005AF48 File Offset: 0x00059148
		public DbccOption dbccOption()
		{
			DbccOption dbccOption = base.FragmentFactory.CreateFragment<DbccOption>();
			IToken token = this.LT(1);
			this.match(232);
			if (this.inputState.guessing == 0)
			{
				dbccOption.OptionKind = DbccOptionsHelper.Instance.ParseOption(token, SqlVersionFlags.TSql80);
				TSql80ParserBaseInternal.UpdateTokenInfo(dbccOption, token);
			}
			return dbccOption;
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x0005AFA0 File Offset: 0x000591A0
		public DbccOption dbccJoinOption()
		{
			DbccOption dbccOption = base.FragmentFactory.CreateFragment<DbccOption>();
			IToken token = this.LT(1);
			this.match(232);
			if (this.inputState.guessing == 0)
			{
				dbccOption.OptionKind = DbccJoinOptionsHelper.Instance.ParseOption(token);
				TSql80ParserBaseInternal.UpdateTokenInfo(dbccOption, token);
			}
			return dbccOption;
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x0005AFF4 File Offset: 0x000591F4
		public DbccNamedLiteral dbccNamedLiteral()
		{
			DbccNamedLiteral dbccNamedLiteral = base.FragmentFactory.CreateFragment<DbccNamedLiteral>();
			if (this.LA(1) == 232 && this.LA(2) == 206)
			{
				IToken token = this.LT(1);
				this.match(232);
				this.match(206);
				if (this.inputState.guessing == 0)
				{
					dbccNamedLiteral.Name = token.getText();
					TSql80ParserBaseInternal.UpdateTokenInfo(dbccNamedLiteral, token);
				}
			}
			else if (!TSql80ParserInternal.tokenSet_24_.member(this.LA(1)) || !TSql80ParserInternal.tokenSet_25_.member(this.LA(2)))
			{
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			ScalarExpression value = this.possibleNegativeConstantOrIdentifier();
			if (this.inputState.guessing == 0)
			{
				dbccNamedLiteral.Value = value;
			}
			return dbccNamedLiteral;
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x0005B0C0 File Offset: 0x000592C0
		public void authorizationOpt(IAuthorization vParent)
		{
			int num = this.LA(1);
			if (num <= 11)
			{
				if (num == 1)
				{
					return;
				}
				if (num == 11)
				{
					this.authorization(vParent);
					return;
				}
			}
			else if (num == 35 || num == 75 || num == 219)
			{
				return;
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x0005B114 File Offset: 0x00059314
		public void authorization(IAuthorization vParent)
		{
			this.match(11);
			Identifier owner = this.identifier();
			if (this.inputState.guessing == 0)
			{
				vParent.Owner = owner;
			}
		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x0005B144 File Offset: 0x00059344
		public StatementList createSchemaElementList()
		{
			StatementList statementList = base.FragmentFactory.CreateFragment<StatementList>();
			while (this.LA(1) == 35 || this.LA(1) == 75)
			{
				TSqlStatement item = this.createSchemaElement();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<TSqlStatement>(statementList, statementList.Statements, item);
				}
			}
			return statementList;
		}

		// Token: 0x060012D6 RID: 4822 RVA: 0x0005B198 File Offset: 0x00059398
		public TSqlStatement createSchemaElement()
		{
			TSqlStatement result;
			if (this.LA(1) == 35 && this.LA(2) == 166)
			{
				result = this.createViewStatement();
			}
			else if (this.LA(1) == 35 && this.LA(2) == 148)
			{
				result = this.createTableStatement();
			}
			else
			{
				if (this.LA(1) != 75)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				result = this.grantStatement80();
			}
			return result;
		}

		// Token: 0x060012D7 RID: 4823 RVA: 0x0005B214 File Offset: 0x00059414
		public void functionStatementBody(FunctionStatementBody vResult, out bool vParseErrorOccurred)
		{
			this.match(73);
			SchemaObjectName name = this.schemaObjectThreePartName();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.CheckTwoPartNameForSchemaObjectName(name, "TRIGGER");
				vResult.Name = name;
				TSql80ParserBaseInternal.CheckForTemporaryFunction(name);
				base.ThrowPartialAstIfPhaseOne(vResult);
			}
			this.match(191);
			int num = this.LA(1);
			if (num != 192)
			{
				if (num != 234)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				this.functionParameterList(vResult);
			}
			this.match(192);
			IToken token = this.LT(1);
			this.match(232);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.Match(token, "RETURNS");
			}
			this.functionReturnTypeAndBody(vResult, out vParseErrorOccurred);
		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x0005B2DC File Offset: 0x000594DC
		public void functionParameterList(FunctionStatementBody vResult)
		{
			ProcedureParameter item = this.functionParameter();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ProcedureParameter>(vResult, vResult.Parameters, item);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				item = this.functionParameter();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ProcedureParameter>(vResult, vResult.Parameters, item);
				}
			}
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x0005B348 File Offset: 0x00059548
		public void functionReturnTypeAndBody(FunctionStatementBody vParent, out bool vParseErrorOccurred)
		{
			vParseErrorOccurred = false;
			int num = this.LA(1);
			BeginEndBlockStatement beginEndBlockStatement;
			if (num <= 96)
			{
				if (num != 53 && num != 96)
				{
					goto IL_27F;
				}
			}
			else if (num != 148)
			{
				switch (num)
				{
				case 232:
				case 233:
					break;
				case 234:
				{
					DeclareTableVariableBody declareTableVariableBody = this.declareTableBody(IndexAffectingStatement.CreateOrAlterFunction);
					if (this.inputState.guessing == 0)
					{
						TableValuedFunctionReturnType tableValuedFunctionReturnType = base.FragmentFactory.CreateFragment<TableValuedFunctionReturnType>();
						tableValuedFunctionReturnType.DeclareTableVariableBody = declareTableVariableBody;
						vParent.ReturnType = tableValuedFunctionReturnType;
					}
					int num2 = this.LA(1);
					if (num2 != 9 && num2 != 13)
					{
						if (num2 != 171)
						{
							throw new NoViableAltException(this.LT(1), this.getFilename());
						}
						this.functionAttributes(vParent);
					}
					int num3 = this.LA(1);
					if (num3 != 9)
					{
						if (num3 != 13)
						{
							throw new NoViableAltException(this.LT(1), this.getFilename());
						}
					}
					else
					{
						this.match(9);
					}
					beginEndBlockStatement = this.beginEndBlockStatement();
					if (this.inputState.guessing == 0)
					{
						base.SetFunctionBodyStatement(vParent, beginEndBlockStatement);
						vParseErrorOccurred = (beginEndBlockStatement == null);
						return;
					}
					return;
				}
				default:
					goto IL_27F;
				}
			}
			else
			{
				this.match(148);
				int num4 = this.LA(1);
				if (num4 != 9 && num4 != 131)
				{
					if (num4 != 171)
					{
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
					this.functionAttributes(vParent);
				}
				int num5 = this.LA(1);
				if (num5 != 9)
				{
					if (num5 != 131)
					{
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
				}
				else
				{
					this.match(9);
				}
				this.match(131);
				SelectFunctionReturnType returnType = this.functionReturnClauseRelational();
				if (this.inputState.guessing == 0)
				{
					vParent.ReturnType = returnType;
					return;
				}
				return;
			}
			DataTypeReference dataType = this.scalarDataType();
			if (this.inputState.guessing == 0)
			{
				ScalarFunctionReturnType scalarFunctionReturnType = base.FragmentFactory.CreateFragment<ScalarFunctionReturnType>();
				scalarFunctionReturnType.DataType = dataType;
				vParent.ReturnType = scalarFunctionReturnType;
			}
			int num6 = this.LA(1);
			if (num6 != 9 && num6 != 13)
			{
				if (num6 != 171)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				this.functionAttributes(vParent);
			}
			int num7 = this.LA(1);
			if (num7 != 9)
			{
				if (num7 != 13)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
			}
			else
			{
				this.match(9);
			}
			beginEndBlockStatement = this.beginEndBlockStatement();
			if (this.inputState.guessing == 0)
			{
				base.SetFunctionBodyStatement(vParent, beginEndBlockStatement);
				vParseErrorOccurred = (beginEndBlockStatement == null);
				return;
			}
			return;
			IL_27F:
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x0005B5E8 File Offset: 0x000597E8
		public ProcedureParameter functionParameter()
		{
			ProcedureParameter procedureParameter = base.FragmentFactory.CreateFragment<ProcedureParameter>();
			Identifier variableName = this.identifierVariable();
			int num = this.LA(1);
			if (num <= 53)
			{
				if (num == 9)
				{
					this.match(9);
					goto IL_64;
				}
				if (num == 53)
				{
					goto IL_64;
				}
			}
			else
			{
				if (num == 96)
				{
					goto IL_64;
				}
				switch (num)
				{
				case 232:
				case 233:
					goto IL_64;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_64:
			if (this.inputState.guessing == 0)
			{
				procedureParameter.VariableName = variableName;
			}
			this.scalarProcedureParameter(procedureParameter, false);
			return procedureParameter;
		}

		// Token: 0x060012DB RID: 4827 RVA: 0x0005B678 File Offset: 0x00059878
		public Identifier identifierVariable()
		{
			Identifier identifier = base.FragmentFactory.CreateFragment<Identifier>();
			IToken token = this.LT(1);
			this.match(234);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(identifier, token);
				identifier.SetIdentifier(token.getText());
			}
			return identifier;
		}

		// Token: 0x060012DC RID: 4828 RVA: 0x0005B6C8 File Offset: 0x000598C8
		public void scalarProcedureParameter(ProcedureParameter vParent, bool outputAllowed)
		{
			DataTypeReference dataType = this.scalarDataType();
			if (this.inputState.guessing == 0)
			{
				vParent.DataType = dataType;
			}
			int num = this.LA(1);
			if (num <= 171)
			{
				if (num == 9 || num == 67 || num == 171)
				{
					goto IL_A8;
				}
			}
			else if (num <= 198)
			{
				if (num == 192 || num == 198)
				{
					goto IL_A8;
				}
			}
			else if (num != 206)
			{
				if (num == 232)
				{
					goto IL_A8;
				}
			}
			else
			{
				this.match(206);
				ScalarExpression value = this.possibleNegativeConstantOrIdentifierWithDefault();
				if (this.inputState.guessing == 0)
				{
					vParent.Value = value;
					goto IL_A8;
				}
				goto IL_A8;
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_A8:
			int num2 = this.LA(1);
			if (num2 <= 171)
			{
				if (num2 == 9 || num2 == 67 || num2 == 171)
				{
					return;
				}
			}
			else
			{
				if (num2 == 192 || num2 == 198)
				{
					return;
				}
				if (num2 == 232)
				{
					IToken token = this.LT(1);
					this.match(232);
					if (this.inputState.guessing != 0)
					{
						return;
					}
					TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token);
					TSql80ParserBaseInternal.Match(token, "OUTPUT", "OUT");
					if (outputAllowed)
					{
						vParent.Modifier = ParameterModifier.Output;
						return;
					}
					TSql80ParserBaseInternal.ThrowParseErrorException("SQL46039", token, TSqlParserResource.SQL46039Message, new string[0]);
					return;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x0005B838 File Offset: 0x00059A38
		public void functionAttributes(FunctionStatementBody vParent)
		{
			int num = 0;
			this.match(171);
			FunctionOption functionOption = this.functionAttribute();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.CheckOptionDuplication(ref num, (int)functionOption.OptionKind, functionOption);
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<FunctionOption>(vParent, vParent.Options, functionOption);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				functionOption = this.functionAttribute();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.CheckOptionDuplication(ref num, (int)functionOption.OptionKind, functionOption);
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<FunctionOption>(vParent, vParent.Options, functionOption);
				}
			}
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x0005B8CC File Offset: 0x00059ACC
		public BeginEndBlockStatement beginEndBlockStatement()
		{
			BeginEndBlockStatement beginEndBlockStatement = base.FragmentFactory.CreateFragment<BeginEndBlockStatement>();
			bool flag = false;
			StatementList statementList = base.FragmentFactory.CreateFragment<StatementList>();
			IToken token = this.LT(1);
			this.match(13);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(beginEndBlockStatement, token);
			}
			int num = 0;
			while (TSql80ParserInternal.tokenSet_3_.member(this.LA(1)))
			{
				TSqlStatement tsqlStatement = this.statementOptSemi();
				if (this.inputState.guessing == 0)
				{
					if (tsqlStatement != null)
					{
						TSql80ParserBaseInternal.AddAndUpdateTokenInfo<TSqlStatement>(statementList, statementList.Statements, tsqlStatement);
					}
					else
					{
						flag = true;
						base.ThrowIfEndOfFileOrBatch();
					}
				}
				num++;
			}
			if (num < 1)
			{
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			IToken token2 = this.LT(1);
			this.match(56);
			if (this.inputState.guessing == 0)
			{
				beginEndBlockStatement.StatementList = statementList;
				TSql80ParserBaseInternal.UpdateTokenInfo(beginEndBlockStatement, token2);
				if (flag)
				{
					beginEndBlockStatement = null;
				}
			}
			return beginEndBlockStatement;
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x0005B9BC File Offset: 0x00059BBC
		public SelectFunctionReturnType functionReturnClauseRelational()
		{
			SelectFunctionReturnType selectFunctionReturnType = base.FragmentFactory.CreateFragment<SelectFunctionReturnType>();
			SelectStatement selectStatement = this.subqueryExpressionAsStatement();
			if (this.inputState.guessing == 0)
			{
				selectFunctionReturnType.SelectStatement = selectStatement;
			}
			return selectFunctionReturnType;
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x0005B9F4 File Offset: 0x00059BF4
		public DeclareTableVariableBody declareTableBody(IndexAffectingStatement statementType)
		{
			bool asDefined = false;
			Identifier variableName = this.identifierVariable();
			this.match(148);
			DeclareTableVariableBody declareTableVariableBody = this.declareTableBodyMain(statementType);
			if (this.inputState.guessing == 0)
			{
				declareTableVariableBody.VariableName = variableName;
				declareTableVariableBody.AsDefined = asDefined;
			}
			return declareTableVariableBody;
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x0005BA3C File Offset: 0x00059C3C
		public FunctionOption functionAttribute()
		{
			FunctionOption functionOption = base.FragmentFactory.CreateFragment<FunctionOption>();
			if (this.LA(1) == 232 && TSql80ParserInternal.tokenSet_26_.member(this.LA(2)))
			{
				IToken token = this.LT(1);
				this.match(232);
				if (this.inputState.guessing == 0)
				{
					functionOption.OptionKind = TSql80ParserBaseInternal.ParseAlterCreateFunctionWithOption(token);
					TSql80ParserBaseInternal.UpdateTokenInfo(functionOption, token);
				}
			}
			else if (this.LA(1) == 232 && this.LA(2) == 100)
			{
				IToken token2 = this.LT(1);
				this.match(232);
				this.match(100);
				this.match(105);
				this.match(100);
				IToken token3 = this.LT(1);
				this.match(232);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.Match(token2, "RETURNS");
					TSql80ParserBaseInternal.Match(token3, "INPUT");
					functionOption.OptionKind = FunctionOptionKind.ReturnsNullOnNullInput;
					TSql80ParserBaseInternal.UpdateTokenInfo(functionOption, token3);
				}
			}
			else
			{
				if (this.LA(1) != 232 || this.LA(2) != 105)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				IToken token4 = this.LT(1);
				this.match(232);
				this.match(105);
				this.match(100);
				IToken token5 = this.LT(1);
				this.match(232);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.Match(token4, "CALLED");
					TSql80ParserBaseInternal.Match(token5, "INPUT");
					functionOption.OptionKind = FunctionOptionKind.CalledOnNullInput;
					TSql80ParserBaseInternal.UpdateTokenInfo(functionOption, token5);
				}
			}
			return functionOption;
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x0005BBEC File Offset: 0x00059DEC
		public void identifierColumnList(TSqlFragment vParent, IList<ColumnReferenceExpression> columns)
		{
			this.match(191);
			ColumnReferenceExpression item = this.identifierColumnReferenceExpression();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ColumnReferenceExpression>(vParent, columns, item);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				item = this.identifierColumnReferenceExpression();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ColumnReferenceExpression>(vParent, columns, item);
				}
			}
			IToken token = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token);
			}
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x0005BC80 File Offset: 0x00059E80
		public StatisticsOption createStatisticsStatementWithOption(ref bool isConflictingOption)
		{
			StatisticsOption result;
			if (this.LA(1) == 232 && this.LA(2) == 221)
			{
				result = this.sampleStatisticsOption(ref isConflictingOption);
			}
			else
			{
				if (this.LA(1) != 232 || !TSql80ParserInternal.tokenSet_21_.member(this.LA(2)))
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				result = this.simpleStatisticsOption(ref isConflictingOption);
			}
			return result;
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x0005BCF4 File Offset: 0x00059EF4
		public LiteralStatisticsOption sampleStatisticsOption(ref bool isConflictingOption)
		{
			LiteralStatisticsOption literalStatisticsOption = base.FragmentFactory.CreateFragment<LiteralStatisticsOption>();
			IToken token = this.LT(1);
			this.match(232);
			Literal literal = this.integer();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.Match(token, "SAMPLE");
				if (isConflictingOption)
				{
					TSql80ParserBaseInternal.ThrowParseErrorException("SQL46071", token, TSqlParserResource.SQL46071Message, new string[0]);
				}
				else
				{
					isConflictingOption = true;
				}
				literalStatisticsOption.Literal = literal;
			}
			int num = this.LA(1);
			if (num != 116)
			{
				if (num != 232)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				IToken token2 = this.LT(1);
				this.match(232);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(literalStatisticsOption, token2);
					literalStatisticsOption.OptionKind = TSql80ParserBaseInternal.ParseSampleOptionsWithOption(token2);
				}
			}
			else
			{
				IToken token3 = this.LT(1);
				this.match(116);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(literalStatisticsOption, token3);
					literalStatisticsOption.OptionKind = StatisticsOptionKind.SamplePercent;
				}
			}
			return literalStatisticsOption;
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x0005BDFC File Offset: 0x00059FFC
		public StatisticsOption simpleStatisticsOption(ref bool isConflictingOption)
		{
			StatisticsOption statisticsOption = base.FragmentFactory.CreateFragment<StatisticsOption>();
			IToken token = this.LT(1);
			this.match(232);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(statisticsOption, token);
				if (TSql80ParserBaseInternal.TryMatch(token, "ROWS"))
				{
					statisticsOption.OptionKind = StatisticsOptionKind.Rows;
					if (isConflictingOption)
					{
						TSql80ParserBaseInternal.ThrowParseErrorException("SQL46071", token, TSqlParserResource.SQL46071Message, new string[0]);
					}
					else
					{
						isConflictingOption = true;
					}
				}
				else
				{
					if (TSql80ParserBaseInternal.TryMatch(token, "FULLSCAN"))
					{
						if (isConflictingOption)
						{
							TSql80ParserBaseInternal.ThrowParseErrorException("SQL46071", token, TSqlParserResource.SQL46071Message, new string[0]);
						}
						else
						{
							isConflictingOption = true;
						}
					}
					statisticsOption.OptionKind = TSql80ParserBaseInternal.ParseCreateStatisticsWithOption(token);
				}
			}
			return statisticsOption;
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x0005BEB0 File Offset: 0x0005A0B0
		public void columnNameList(TSqlFragment vParent, IList<Identifier> columnNames)
		{
			this.match(191);
			Identifier item = this.identifier();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<Identifier>(vParent, columnNames, item);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				item = this.identifier();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<Identifier>(vParent, columnNames, item);
				}
			}
			IToken token = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token);
			}
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x0005BF44 File Offset: 0x0005A144
		public StatisticsOption updateStatisticsStatementWithOption(ref bool isConflictingOption)
		{
			StatisticsOption result;
			if (this.LA(1) == 232 && this.LA(2) == 221)
			{
				result = this.sampleStatisticsOption(ref isConflictingOption);
			}
			else if ((this.LA(1) == 135 || this.LA(1) == 232) && this.LA(2) == 206)
			{
				result = this.updateStatisticsLiteralOption();
			}
			else
			{
				if ((this.LA(1) != 5 && this.LA(1) != 84 && this.LA(1) != 232) || !TSql80ParserInternal.tokenSet_21_.member(this.LA(2)))
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				result = this.updateStatisticsSimpleOption(ref isConflictingOption);
			}
			return result;
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x0005C004 File Offset: 0x0005A204
		public LiteralStatisticsOption updateStatisticsLiteralOption()
		{
			LiteralStatisticsOption literalStatisticsOption = base.FragmentFactory.CreateFragment<LiteralStatisticsOption>();
			int num = this.LA(1);
			if (num != 135)
			{
				if (num != 232)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				IToken token = this.LT(1);
				this.match(232);
				this.match(206);
				Literal literal = this.integer();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.Match(token, "PAGECOUNT");
					literalStatisticsOption.OptionKind = StatisticsOptionKind.PageCount;
					TSql80ParserBaseInternal.UpdateTokenInfo(literalStatisticsOption, token);
					literalStatisticsOption.Literal = literal;
				}
			}
			else
			{
				IToken token2 = this.LT(1);
				this.match(135);
				this.match(206);
				Literal literal = this.integer();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(literalStatisticsOption, token2);
					literalStatisticsOption.OptionKind = StatisticsOptionKind.RowCount;
					literalStatisticsOption.Literal = literal;
				}
			}
			return literalStatisticsOption;
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x0005C0F0 File Offset: 0x0005A2F0
		public StatisticsOption updateStatisticsSimpleOption(ref bool isConflictingOption)
		{
			StatisticsOption statisticsOption = base.FragmentFactory.CreateFragment<StatisticsOption>();
			int num = this.LA(1);
			if (num != 5)
			{
				if (num != 84)
				{
					if (num != 232)
					{
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
					IToken token = this.LT(1);
					this.match(232);
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.UpdateTokenInfo(statisticsOption, token);
						if (TSql80ParserBaseInternal.TryMatch(token, "ROWS"))
						{
							statisticsOption.OptionKind = StatisticsOptionKind.Rows;
							if (isConflictingOption)
							{
								TSql80ParserBaseInternal.ThrowParseErrorException("SQL46071", token, TSqlParserResource.SQL46071Message, new string[0]);
							}
							else
							{
								isConflictingOption = true;
							}
						}
						else
						{
							if (TSql80ParserBaseInternal.TryMatch(token, "FULLSCAN"))
							{
								if (isConflictingOption)
								{
									TSql80ParserBaseInternal.ThrowParseErrorException("SQL46071", token, TSqlParserResource.SQL46071Message, new string[0]);
								}
								else
								{
									isConflictingOption = true;
								}
							}
							statisticsOption.OptionKind = StatisticsOptionHelper.Instance.ParseOption(token);
						}
					}
				}
				else
				{
					IToken token2 = this.LT(1);
					this.match(84);
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.UpdateTokenInfo(statisticsOption, token2);
						statisticsOption.OptionKind = StatisticsOptionKind.Index;
					}
				}
			}
			else
			{
				IToken token3 = this.LT(1);
				this.match(5);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(statisticsOption, token3);
					statisticsOption.OptionKind = StatisticsOptionKind.All;
				}
			}
			return statisticsOption;
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x0005C248 File Offset: 0x0005A448
		public SecurityElement80 securityElement80()
		{
			SecurityElement80 result;
			if (this.LA(1) == 5 && (this.LA(2) == 71 || this.LA(2) == 151))
			{
				result = this.commandSecurityElementAll80();
			}
			else if (this.LA(1) == 12 || this.LA(1) == 35)
			{
				result = this.commandSecurityElement80();
			}
			else
			{
				if (!TSql80ParserInternal.tokenSet_27_.member(this.LA(1)) || !TSql80ParserInternal.tokenSet_28_.member(this.LA(2)))
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				result = this.privilegeSecurityElement80();
			}
			return result;
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x0005C2E8 File Offset: 0x0005A4E8
		public SecurityUserClause80 securityUserClause80()
		{
			SecurityUserClause80 securityUserClause = base.FragmentFactory.CreateFragment<SecurityUserClause80>();
			int num = this.LA(1);
			if (num != 100)
			{
				if (num != 122)
				{
					switch (num)
					{
					case 232:
					case 233:
					{
						Identifier item = this.identifier();
						if (this.inputState.guessing == 0)
						{
							securityUserClause.UserType80 = UserType80.Users;
							TSql80ParserBaseInternal.AddAndUpdateTokenInfo<Identifier>(securityUserClause, securityUserClause.Users, item);
						}
						while (this.LA(1) == 198)
						{
							this.match(198);
							item = this.identifier();
							if (this.inputState.guessing == 0)
							{
								TSql80ParserBaseInternal.AddAndUpdateTokenInfo<Identifier>(securityUserClause, securityUserClause.Users, item);
							}
						}
						break;
					}
					default:
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
				}
				else
				{
					IToken token = this.LT(1);
					this.match(122);
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.UpdateTokenInfo(securityUserClause, token);
						securityUserClause.UserType80 = UserType80.Public;
					}
				}
			}
			else
			{
				IToken token2 = this.LT(1);
				this.match(100);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(securityUserClause, token2);
					securityUserClause.UserType80 = UserType80.Null;
				}
			}
			return securityUserClause;
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x0005C410 File Offset: 0x0005A610
		public CommandSecurityElement80 commandSecurityElementAll80()
		{
			CommandSecurityElement80 commandSecurityElement = base.FragmentFactory.CreateFragment<CommandSecurityElement80>();
			IToken token = this.LT(1);
			this.match(5);
			if (this.inputState.guessing == 0)
			{
				commandSecurityElement.All = true;
				TSql80ParserBaseInternal.UpdateTokenInfo(commandSecurityElement, token);
			}
			return commandSecurityElement;
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x0005C458 File Offset: 0x0005A658
		public CommandSecurityElement80 commandSecurityElement80()
		{
			CommandSecurityElement80 commandSecurityElement = base.FragmentFactory.CreateFragment<CommandSecurityElement80>();
			this.command80(commandSecurityElement);
			while (this.LA(1) == 198)
			{
				this.match(198);
				this.command80(commandSecurityElement);
			}
			return commandSecurityElement;
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x0005C49C File Offset: 0x0005A69C
		public PrivilegeSecurityElement80 privilegeSecurityElement80()
		{
			PrivilegeSecurityElement80 privilegeSecurityElement = base.FragmentFactory.CreateFragment<PrivilegeSecurityElement80>();
			Privilege80 item = this.privilege80();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<Privilege80>(privilegeSecurityElement, privilegeSecurityElement.Privileges, item);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				item = this.privilege80();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<Privilege80>(privilegeSecurityElement, privilegeSecurityElement.Privileges, item);
				}
			}
			this.match(105);
			SchemaObjectName schemaObjectName = this.schemaObjectThreePartName();
			if (this.inputState.guessing == 0)
			{
				privilegeSecurityElement.SchemaObjectName = schemaObjectName;
			}
			int num = this.LA(1);
			if (num != 71 && num != 151)
			{
				if (num != 191)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				this.columnNameList(privilegeSecurityElement, privilegeSecurityElement.Columns);
			}
			return privilegeSecurityElement;
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x0005C578 File Offset: 0x0005A778
		public void command80(CommandSecurityElement80 vParent)
		{
			int num = this.LA(1);
			if (num != 12)
			{
				if (num == 35)
				{
					IToken token = this.LT(1);
					this.match(35);
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token);
					}
					int num2 = this.LA(1);
					if (num2 <= 73)
					{
						if (num2 != 43)
						{
							if (num2 != 47)
							{
								if (num2 == 73)
								{
									IToken token2 = this.LT(1);
									this.match(73);
									if (this.inputState.guessing == 0)
									{
										TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token2);
										vParent.CommandOptions |= CommandOptions.CreateFunction;
										return;
									}
									return;
								}
							}
							else
							{
								IToken token3 = this.LT(1);
								this.match(47);
								if (this.inputState.guessing == 0)
								{
									TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token3);
									vParent.CommandOptions |= CommandOptions.CreateDefault;
									return;
								}
								return;
							}
						}
						else
						{
							IToken token4 = this.LT(1);
							this.match(43);
							if (this.inputState.guessing == 0)
							{
								TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token4);
								vParent.CommandOptions |= CommandOptions.CreateDatabase;
								return;
							}
							return;
						}
					}
					else if (num2 <= 137)
					{
						switch (num2)
						{
						case 120:
						{
							IToken token5 = this.LT(1);
							this.match(120);
							if (this.inputState.guessing == 0)
							{
								TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token5);
								vParent.CommandOptions |= CommandOptions.CreateProcedure;
								return;
							}
							return;
						}
						case 121:
						{
							IToken token6 = this.LT(1);
							this.match(121);
							if (this.inputState.guessing == 0)
							{
								TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token6);
								vParent.CommandOptions |= CommandOptions.CreateProcedure;
								return;
							}
							return;
						}
						default:
							if (num2 == 137)
							{
								IToken token7 = this.LT(1);
								this.match(137);
								if (this.inputState.guessing == 0)
								{
									TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token7);
									vParent.CommandOptions |= CommandOptions.CreateRule;
									return;
								}
								return;
							}
							break;
						}
					}
					else if (num2 != 148)
					{
						if (num2 == 166)
						{
							IToken token8 = this.LT(1);
							this.match(166);
							if (this.inputState.guessing == 0)
							{
								TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token8);
								vParent.CommandOptions |= CommandOptions.CreateView;
								return;
							}
							return;
						}
					}
					else
					{
						IToken token9 = this.LT(1);
						this.match(148);
						if (this.inputState.guessing == 0)
						{
							TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token9);
							vParent.CommandOptions |= CommandOptions.CreateTable;
							return;
						}
						return;
					}
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			else
			{
				IToken token10 = this.LT(1);
				this.match(12);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token10);
				}
				int num3 = this.LA(1);
				if (num3 != 43)
				{
					if (num3 != 232)
					{
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
					IToken token11 = this.LT(1);
					this.match(232);
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token11);
						TSql80ParserBaseInternal.Match(token11, "LOG");
						vParent.CommandOptions |= CommandOptions.BackupLog;
						return;
					}
				}
				else
				{
					IToken token12 = this.LT(1);
					this.match(43);
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token12);
						vParent.CommandOptions |= CommandOptions.BackupDatabase;
						return;
					}
				}
			}
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x0005C920 File Offset: 0x0005AB20
		public Privilege80 privilege80()
		{
			Privilege80 privilege = base.FragmentFactory.CreateFragment<Privilege80>();
			int num = this.LA(1);
			if (num <= 61)
			{
				if (num == 5)
				{
					IToken token = this.LT(1);
					this.match(5);
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.UpdateTokenInfo(privilege, token);
						privilege.PrivilegeType80 = PrivilegeType80.All;
					}
					int num2 = this.LA(1);
					if (num2 <= 191)
					{
						if (num2 == 105 || num2 == 191)
						{
							goto IL_2C2;
						}
					}
					else
					{
						if (num2 == 198)
						{
							goto IL_2C2;
						}
						if (num2 == 232)
						{
							IToken token2 = this.LT(1);
							this.match(232);
							if (this.inputState.guessing == 0)
							{
								TSql80ParserBaseInternal.Match(token2, "PRIVILEGES");
								TSql80ParserBaseInternal.UpdateTokenInfo(privilege, token2);
								goto IL_2C2;
							}
							goto IL_2C2;
						}
					}
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				if (num != 48)
				{
					switch (num)
					{
					case 60:
					{
						IToken token3 = this.LT(1);
						this.match(60);
						if (this.inputState.guessing == 0)
						{
							TSql80ParserBaseInternal.UpdateTokenInfo(privilege, token3);
							privilege.PrivilegeType80 = PrivilegeType80.Execute;
							goto IL_2C2;
						}
						goto IL_2C2;
					}
					case 61:
					{
						IToken token4 = this.LT(1);
						this.match(61);
						if (this.inputState.guessing == 0)
						{
							TSql80ParserBaseInternal.UpdateTokenInfo(privilege, token4);
							privilege.PrivilegeType80 = PrivilegeType80.Execute;
							goto IL_2C2;
						}
						goto IL_2C2;
					}
					}
				}
				else
				{
					IToken token5 = this.LT(1);
					this.match(48);
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.UpdateTokenInfo(privilege, token5);
						privilege.PrivilegeType80 = PrivilegeType80.Delete;
						goto IL_2C2;
					}
					goto IL_2C2;
				}
			}
			else if (num <= 127)
			{
				if (num != 86)
				{
					if (num == 127)
					{
						IToken token6 = this.LT(1);
						this.match(127);
						if (this.inputState.guessing == 0)
						{
							TSql80ParserBaseInternal.UpdateTokenInfo(privilege, token6);
							privilege.PrivilegeType80 = PrivilegeType80.References;
							goto IL_2C2;
						}
						goto IL_2C2;
					}
				}
				else
				{
					IToken token7 = this.LT(1);
					this.match(86);
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.UpdateTokenInfo(privilege, token7);
						privilege.PrivilegeType80 = PrivilegeType80.Insert;
						goto IL_2C2;
					}
					goto IL_2C2;
				}
			}
			else if (num != 140)
			{
				if (num == 160)
				{
					IToken token8 = this.LT(1);
					this.match(160);
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.UpdateTokenInfo(privilege, token8);
						privilege.PrivilegeType80 = PrivilegeType80.Update;
						goto IL_2C2;
					}
					goto IL_2C2;
				}
			}
			else
			{
				IToken token9 = this.LT(1);
				this.match(140);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(privilege, token9);
					privilege.PrivilegeType80 = PrivilegeType80.Select;
					goto IL_2C2;
				}
				goto IL_2C2;
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_2C2:
			int num3 = this.LA(1);
			if (num3 != 105)
			{
				if (num3 != 191)
				{
					if (num3 != 198)
					{
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
				}
				else
				{
					this.columnNameList(privilege, privilege.Columns);
				}
			}
			return privilege;
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x0005CC38 File Offset: 0x0005AE38
		public ColumnReferenceExpression column()
		{
			ColumnReferenceExpression columnReferenceExpression = base.FragmentFactory.CreateFragment<ColumnReferenceExpression>();
			columnReferenceExpression.ColumnType = ColumnType.Regular;
			int num = this.LA(1);
			if (num > 136)
			{
				if (num != 200)
				{
					if (num == 227)
					{
						goto IL_340;
					}
					switch (num)
					{
					case 232:
					case 233:
						break;
					default:
						goto IL_349;
					}
				}
				MultiPartIdentifier multiPartIdentifier = this.multiPartIdentifier(-1);
				if (this.inputState.guessing == 0)
				{
					columnReferenceExpression.MultiPartIdentifier = multiPartIdentifier;
				}
				int num2 = this.LA(1);
				if (num2 <= 95)
				{
					if (num2 <= 35)
					{
						if (num2 <= 17)
						{
							if (num2 == 1 || num2 == 6)
							{
								goto IL_35C;
							}
							switch (num2)
							{
							case 12:
							case 13:
							case 15:
							case 17:
								goto IL_35C;
							}
						}
						else
						{
							switch (num2)
							{
							case 22:
							case 23:
								goto IL_35C;
							default:
								if (num2 == 28)
								{
									goto IL_35C;
								}
								switch (num2)
								{
								case 33:
								case 35:
									goto IL_35C;
								}
								break;
							}
						}
					}
					else if (num2 <= 82)
					{
						switch (num2)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							goto IL_35C;
						case 47:
						case 50:
						case 51:
						case 52:
						case 53:
						case 57:
						case 58:
						case 59:
						case 62:
						case 63:
							break;
						default:
							switch (num2)
							{
							case 74:
							case 75:
								goto IL_35C;
							default:
								if (num2 == 82)
								{
									goto IL_35C;
								}
								break;
							}
							break;
						}
					}
					else if (num2 == 86 || num2 == 92 || num2 == 95)
					{
						goto IL_35C;
					}
				}
				else if (num2 <= 173)
				{
					if (num2 <= 119)
					{
						if (num2 == 106 || num2 == 111 || num2 == 119)
						{
							goto IL_35C;
						}
					}
					else
					{
						switch (num2)
						{
						case 123:
						case 125:
						case 126:
						case 129:
						case 131:
						case 132:
						case 134:
						case 138:
						case 140:
						case 142:
						case 143:
						case 144:
							goto IL_35C;
						case 124:
						case 127:
						case 128:
						case 130:
						case 133:
						case 135:
						case 136:
						case 137:
						case 139:
						case 141:
							break;
						default:
							switch (num2)
							{
							case 156:
							case 160:
							case 161:
							case 162:
								goto IL_35C;
							case 157:
							case 158:
							case 159:
								break;
							default:
								switch (num2)
								{
								case 167:
								case 170:
								case 172:
								case 173:
									goto IL_35C;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num2 <= 192)
				{
					if (num2 == 176)
					{
						goto IL_35C;
					}
					switch (num2)
					{
					case 180:
					case 181:
						goto IL_35C;
					default:
						switch (num2)
						{
						case 191:
						case 192:
							goto IL_35C;
						}
						break;
					}
				}
				else if (num2 <= 204)
				{
					switch (num2)
					{
					case 198:
						goto IL_35C;
					case 199:
						break;
					case 200:
						this.match(200);
						this.specialColumn(columnReferenceExpression);
						goto IL_35C;
					default:
						if (num2 == 204)
						{
							goto IL_35C;
						}
						break;
					}
				}
				else
				{
					switch (num2)
					{
					case 219:
					case 220:
					case 221:
					case 224:
						goto IL_35C;
					case 222:
					case 223:
						break;
					default:
						if (num2 == 234)
						{
							goto IL_35C;
						}
						break;
					}
				}
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			if (num != 81 && num != 136)
			{
				goto IL_349;
			}
			IL_340:
			this.specialColumn(columnReferenceExpression);
			goto IL_35C;
			IL_349:
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_35C:
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.CheckSpecialColumn(columnReferenceExpression);
				TSql80ParserBaseInternal.CheckTableNameExistsForColumn(columnReferenceExpression, false);
			}
			return columnReferenceExpression;
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x0005CFBC File Offset: 0x0005B1BC
		public ValueExpression binaryOrVariable()
		{
			int num = this.LA(1);
			ValueExpression result;
			if (num != 224)
			{
				if (num != 234)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				result = this.variable();
			}
			else
			{
				result = this.binary();
			}
			return result;
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x0005D00C File Offset: 0x0005B20C
		public ValueExpression integerOrVariable()
		{
			int num = this.LA(1);
			ValueExpression result;
			if (num != 221)
			{
				if (num != 234)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				result = this.variable();
			}
			else
			{
				result = this.integer();
			}
			return result;
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x0005D05C File Offset: 0x0005B25C
		public void modificationTextStatement(TextModificationStatement vParent)
		{
			int num = this.LA(1);
			if (num <= 136)
			{
				if (num != 17)
				{
					if (num == 81 || num == 136)
					{
						goto IL_85;
					}
				}
				else
				{
					this.match(17);
					if (this.inputState.guessing == 0)
					{
						vParent.Bulk = true;
						goto IL_85;
					}
					goto IL_85;
				}
			}
			else
			{
				if (num == 200 || num == 227)
				{
					goto IL_85;
				}
				switch (num)
				{
				case 232:
				case 233:
					goto IL_85;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_85:
			ColumnReferenceExpression column = this.column();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.CheckTableNameExistsForColumn(column, true);
				vParent.Column = column;
			}
			int num2 = this.LA(1);
			ValueExpression textId;
			if (num2 != 221)
			{
				if (num2 != 224 && num2 != 234)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				textId = this.binaryOrVariable();
			}
			else
			{
				textId = this.integer();
			}
			if (this.inputState.guessing == 0)
			{
				vParent.TextId = textId;
			}
			int num3 = this.LA(1);
			if (num3 <= 199)
			{
				if (num3 == 100 || num3 == 171 || num3 == 199)
				{
					return;
				}
			}
			else
			{
				if (num3 == 221 || num3 == 224)
				{
					return;
				}
				switch (num3)
				{
				case 230:
				case 231:
				case 234:
					return;
				case 232:
				{
					IToken token = this.LT(1);
					this.match(232);
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.Match(token, "TIMESTAMP");
					}
					this.match(206);
					Literal timestamp = this.binary();
					if (this.inputState.guessing == 0)
					{
						vParent.Timestamp = timestamp;
						return;
					}
					return;
				}
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x0005D248 File Offset: 0x0005B448
		public ScalarExpression signedIntegerOrVariableOrNull()
		{
			int num = this.LA(1);
			if (num <= 199)
			{
				if (num == 100)
				{
					return this.nullLiteral();
				}
				if (num != 199)
				{
					goto IL_41;
				}
			}
			else if (num != 221 && num != 234)
			{
				goto IL_41;
			}
			return this.signedIntegerOrVariable();
			IL_41:
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x0005D2AC File Offset: 0x0005B4AC
		public void modificationTextStatementWithLog(TextModificationStatement vParent)
		{
			this.match(171);
			IToken token = this.LT(1);
			this.match(232);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.Match(token, "LOG");
				TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token);
				vParent.WithLog = true;
			}
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x0005D300 File Offset: 0x0005B500
		public ValueExpression writeString()
		{
			int num = this.LA(1);
			ValueExpression result;
			if (num != 100)
			{
				if (num != 224)
				{
					switch (num)
					{
					case 230:
					case 231:
						return this.stringLiteral();
					case 234:
						return this.variable();
					}
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				result = this.binary();
			}
			else
			{
				result = this.nullLiteral();
			}
			return result;
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x0005D37C File Offset: 0x0005B57C
		public BinaryLiteral binary()
		{
			BinaryLiteral binaryLiteral = base.FragmentFactory.CreateFragment<BinaryLiteral>();
			IToken token = this.LT(1);
			this.match(224);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(binaryLiteral, token);
				binaryLiteral.Value = token.getText();
				binaryLiteral.IsLargeObject = TSql80ParserBaseInternal.IsBinaryLiteralLob(binaryLiteral.Value);
			}
			return binaryLiteral;
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x0005D3DC File Offset: 0x0005B5DC
		public NullLiteral nullLiteral()
		{
			NullLiteral nullLiteral = base.FragmentFactory.CreateFragment<NullLiteral>();
			IToken token = this.LT(1);
			this.match(100);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(nullLiteral, token);
				nullLiteral.Value = token.getText();
			}
			return nullLiteral;
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x0005D428 File Offset: 0x0005B628
		public VariableReference variable()
		{
			VariableReference variableReference = base.FragmentFactory.CreateFragment<VariableReference>();
			IToken token = this.LT(1);
			this.match(234);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(variableReference, token);
				variableReference.Name = token.getText();
			}
			return variableReference;
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x0005D478 File Offset: 0x0005B678
		public CursorId cursorId()
		{
			CursorId cursorId = base.FragmentFactory.CreateFragment<CursorId>();
			if (this.LA(1) == 232 && (this.LA(2) == 232 || this.LA(2) == 233) && base.NextTokenMatches("GLOBAL"))
			{
				IToken token = this.LT(1);
				this.match(232);
				Identifier identifier = this.identifier();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.Match(token, "GLOBAL");
					cursorId.Name = base.IdentifierOrValueExpression(identifier);
					cursorId.IsGlobal = true;
				}
			}
			else
			{
				if (this.LA(1) < 232 || this.LA(1) > 234 || !TSql80ParserInternal.tokenSet_29_.member(this.LA(2)))
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				IdentifierOrValueExpression name = this.identifierOrVariable();
				if (this.inputState.guessing == 0)
				{
					cursorId.Name = name;
					cursorId.IsGlobal = false;
				}
			}
			return cursorId;
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x0005D57C File Offset: 0x0005B77C
		public FetchCursorStatement rowSelector()
		{
			FetchCursorStatement fetchCursorStatement = base.FragmentFactory.CreateFragment<FetchCursorStatement>();
			if (this.LA(1) >= 232 && this.LA(1) <= 234 && TSql80ParserInternal.tokenSet_30_.member(this.LA(2)))
			{
				CursorId cursor = this.cursorId();
				if (this.inputState.guessing == 0)
				{
					fetchCursorStatement.Cursor = cursor;
				}
			}
			else if (this.LA(1) == 232 && TSql80ParserInternal.tokenSet_31_.member(this.LA(2)))
			{
				FetchType fetchType = this.fetchType();
				this.match(71);
				CursorId cursor = this.cursorId();
				if (this.inputState.guessing == 0)
				{
					fetchCursorStatement.Cursor = cursor;
					fetchCursorStatement.FetchType = fetchType;
				}
			}
			else
			{
				if (this.LA(1) != 71)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				this.match(71);
				CursorId cursor = this.cursorId();
				if (this.inputState.guessing == 0)
				{
					fetchCursorStatement.Cursor = cursor;
				}
			}
			return fetchCursorStatement;
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x0005D680 File Offset: 0x0005B880
		public FetchType fetchType()
		{
			FetchType fetchType = base.FragmentFactory.CreateFragment<FetchType>();
			IToken token = this.LT(1);
			this.match(232);
			if (this.inputState.guessing == 0)
			{
				fetchType.Orientation = FetchOrientationHelper.Instance.ParseOption(token);
			}
			int num = this.LA(1);
			ScalarExpression rowOffset;
			if (num <= 199)
			{
				if (num != 71)
				{
					if (num != 199)
					{
						goto IL_10E;
					}
				}
				else
				{
					if (this.inputState.guessing == 0 && (fetchType.Orientation == FetchOrientation.Relative || fetchType.Orientation == FetchOrientation.Absolute))
					{
						throw TSql80ParserBaseInternal.GetUnexpectedTokenErrorException(token);
					}
					return fetchType;
				}
			}
			else if (num != 221)
			{
				if (num != 234)
				{
					goto IL_10E;
				}
				rowOffset = this.variable();
				if (this.inputState.guessing != 0)
				{
					return fetchType;
				}
				if (fetchType.Orientation != FetchOrientation.Relative && fetchType.Orientation != FetchOrientation.Absolute)
				{
					throw TSql80ParserBaseInternal.GetUnexpectedTokenErrorException(token);
				}
				fetchType.RowOffset = rowOffset;
				return fetchType;
			}
			rowOffset = this.signedInteger();
			if (this.inputState.guessing != 0)
			{
				return fetchType;
			}
			if (fetchType.Orientation != FetchOrientation.Relative && fetchType.Orientation != FetchOrientation.Absolute)
			{
				throw TSql80ParserBaseInternal.GetUnexpectedTokenErrorException(token);
			}
			fetchType.RowOffset = rowOffset;
			return fetchType;
			IL_10E:
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x0005D7B0 File Offset: 0x0005B9B0
		public DropDatabaseStatement dropDatabaseStatement()
		{
			DropDatabaseStatement dropDatabaseStatement = base.FragmentFactory.CreateFragment<DropDatabaseStatement>();
			this.match(43);
			Identifier item = this.identifier();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<Identifier>(dropDatabaseStatement, dropDatabaseStatement.Databases, item);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				item = this.identifier();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<Identifier>(dropDatabaseStatement, dropDatabaseStatement.Databases, item);
				}
			}
			return dropDatabaseStatement;
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x0005D830 File Offset: 0x0005BA30
		public DropIndexStatement dropIndexStatement()
		{
			DropIndexStatement dropIndexStatement = base.FragmentFactory.CreateFragment<DropIndexStatement>();
			this.match(84);
			DropIndexClauseBase item = this.indexDropObject();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<DropIndexClauseBase>(dropIndexStatement, dropIndexStatement.DropIndexClauses, item);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				item = this.indexDropObject();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<DropIndexClauseBase>(dropIndexStatement, dropIndexStatement.DropIndexClauses, item);
				}
			}
			return dropIndexStatement;
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x0005D8B0 File Offset: 0x0005BAB0
		public DropStatisticsStatement dropStatisticsStatement()
		{
			DropStatisticsStatement dropStatisticsStatement = base.FragmentFactory.CreateFragment<DropStatisticsStatement>();
			this.match(146);
			ChildObjectName item = this.statisticsDropObject();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ChildObjectName>(dropStatisticsStatement, dropStatisticsStatement.Objects, item);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				item = this.statisticsDropObject();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ChildObjectName>(dropStatisticsStatement, dropStatisticsStatement.Objects, item);
				}
			}
			return dropStatisticsStatement;
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x0005D934 File Offset: 0x0005BB34
		public DropTableStatement dropTableStatement()
		{
			DropTableStatement dropTableStatement = base.FragmentFactory.CreateFragment<DropTableStatement>();
			this.match(148);
			this.dropObjectList(dropTableStatement, false);
			return dropTableStatement;
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x0005D964 File Offset: 0x0005BB64
		public DropProcedureStatement dropProcedureStatement()
		{
			DropProcedureStatement dropProcedureStatement = base.FragmentFactory.CreateFragment<DropProcedureStatement>();
			switch (this.LA(1))
			{
			case 120:
				this.match(120);
				break;
			case 121:
				this.match(121);
				break;
			default:
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			this.dropObjectList(dropProcedureStatement, true);
			return dropProcedureStatement;
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x0005D9C8 File Offset: 0x0005BBC8
		public DropFunctionStatement dropFunctionStatement()
		{
			DropFunctionStatement dropFunctionStatement = base.FragmentFactory.CreateFragment<DropFunctionStatement>();
			this.match(73);
			this.dropObjectList(dropFunctionStatement, true);
			return dropFunctionStatement;
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x0005D9F4 File Offset: 0x0005BBF4
		public DropViewStatement dropViewStatement()
		{
			DropViewStatement dropViewStatement = base.FragmentFactory.CreateFragment<DropViewStatement>();
			this.match(166);
			this.dropObjectList(dropViewStatement, true);
			return dropViewStatement;
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x0005DA24 File Offset: 0x0005BC24
		public DropDefaultStatement dropDefaultStatement()
		{
			DropDefaultStatement dropDefaultStatement = base.FragmentFactory.CreateFragment<DropDefaultStatement>();
			this.match(47);
			this.dropObjectList(dropDefaultStatement, true);
			return dropDefaultStatement;
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x0005DA50 File Offset: 0x0005BC50
		public DropRuleStatement dropRuleStatement()
		{
			DropRuleStatement dropRuleStatement = base.FragmentFactory.CreateFragment<DropRuleStatement>();
			this.match(137);
			this.dropObjectList(dropRuleStatement, true);
			return dropRuleStatement;
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x0005DA80 File Offset: 0x0005BC80
		public DropTriggerStatement dropTriggerStatement()
		{
			DropTriggerStatement dropTriggerStatement = base.FragmentFactory.CreateFragment<DropTriggerStatement>();
			this.match(155);
			this.dropObjectList(dropTriggerStatement, true);
			return dropTriggerStatement;
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x0005DAB0 File Offset: 0x0005BCB0
		public BackwardsCompatibleDropIndexClause indexDropObject()
		{
			BackwardsCompatibleDropIndexClause backwardsCompatibleDropIndexClause = base.FragmentFactory.CreateFragment<BackwardsCompatibleDropIndexClause>();
			ChildObjectName childObjectName = this.childObjectNameWithThreePrefixes();
			if (this.inputState.guessing == 0)
			{
				if (childObjectName.BaseIdentifier == null)
				{
					TSql80ParserBaseInternal.ThrowParseErrorException("SQL46027", childObjectName, TSqlParserResource.SQL46027Message, new string[0]);
				}
				backwardsCompatibleDropIndexClause.Index = childObjectName;
			}
			return backwardsCompatibleDropIndexClause;
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x0005DB04 File Offset: 0x0005BD04
		public ChildObjectName statisticsDropObject()
		{
			ChildObjectName childObjectName = this.childObjectNameWithThreePrefixes();
			if (this.inputState.guessing == 0 && childObjectName.BaseIdentifier == null)
			{
				TSql80ParserBaseInternal.ThrowParseErrorException("SQL46038", childObjectName, TSqlParserResource.SQL46038Message, new string[0]);
			}
			return childObjectName;
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x0005DB44 File Offset: 0x0005BD44
		public List<Identifier> identifierList(int vMaxNumber)
		{
			List<Identifier> list = new List<Identifier>();
			int num = this.LA(1);
			if (num != 200)
			{
				switch (num)
				{
				case 232:
				case 233:
				{
					Identifier item = this.identifier();
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.AddIdentifierToListWithCheck(list, item, vMaxNumber);
					}
					while (this.LA(1) == 200 && (this.LA(2) == 200 || this.LA(2) == 232 || this.LA(2) == 233))
					{
						this.identifierListElement(list, vMaxNumber, false);
					}
					break;
				}
				default:
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
			}
			else
			{
				this.identifierListElement(list, vMaxNumber, true);
				while (this.LA(1) == 200 && (this.LA(2) == 200 || this.LA(2) == 232 || this.LA(2) == 233))
				{
					this.identifierListElement(list, vMaxNumber, false);
				}
			}
			return list;
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x0005DC44 File Offset: 0x0005BE44
		public void dropObjectList(DropObjectsStatement vParent, bool onlyTwoPartNames)
		{
			SchemaObjectName item = this.dropObject(onlyTwoPartNames);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<SchemaObjectName>(vParent, vParent.Objects, item);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				item = this.dropObject(onlyTwoPartNames);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<SchemaObjectName>(vParent, vParent.Objects, item);
				}
			}
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x0005DCB0 File Offset: 0x0005BEB0
		public SchemaObjectName dropObject(bool onlyTwoPartNames)
		{
			SchemaObjectName schemaObjectName = this.schemaObjectThreePartName();
			if (this.inputState.guessing == 0 && onlyTwoPartNames)
			{
				TSql80ParserBaseInternal.CheckTwoPartNameForSchemaObjectName(schemaObjectName, "DROP");
			}
			return schemaObjectName;
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x0005DCE0 File Offset: 0x0005BEE0
		public Identifier nonQuotedIdentifier()
		{
			Identifier identifier = base.FragmentFactory.CreateFragment<Identifier>();
			IToken token = this.LT(1);
			this.match(232);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(identifier, token);
				identifier.SetUnquotedIdentifier(token.getText());
			}
			return identifier;
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x0005DD30 File Offset: 0x0005BF30
		public BeginTransactionStatement beginTransactionStatement()
		{
			BeginTransactionStatement beginTransactionStatement = base.FragmentFactory.CreateFragment<BeginTransactionStatement>();
			IToken token = this.LT(1);
			this.match(13);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(beginTransactionStatement, token);
			}
			int num = this.LA(1);
			if (num != 52)
			{
				switch (num)
				{
				case 153:
				case 154:
					break;
				default:
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
			}
			else
			{
				this.match(52);
				if (this.inputState.guessing == 0)
				{
					beginTransactionStatement.Distributed = true;
				}
			}
			switch (this.LA(1))
			{
			case 153:
			{
				IToken token2 = this.LT(1);
				this.match(153);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(beginTransactionStatement, token2);
				}
				break;
			}
			case 154:
			{
				IToken token3 = this.LT(1);
				this.match(154);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(beginTransactionStatement, token3);
				}
				break;
			}
			default:
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			int num2 = this.LA(1);
			if (num2 <= 92)
			{
				if (num2 <= 28)
				{
					if (num2 <= 6)
					{
						if (num2 == 1 || num2 == 6)
						{
							goto IL_3BE;
						}
					}
					else
					{
						switch (num2)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							goto IL_3BE;
						case 14:
						case 16:
							break;
						default:
							switch (num2)
							{
							case 22:
							case 23:
								goto IL_3BE;
							default:
								if (num2 == 28)
								{
									goto IL_3BE;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num2 <= 75)
				{
					switch (num2)
					{
					case 33:
					case 35:
						goto IL_3BE;
					case 34:
						break;
					default:
						switch (num2)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							goto IL_3BE;
						case 47:
						case 50:
						case 51:
						case 52:
						case 53:
						case 57:
						case 58:
						case 59:
						case 62:
						case 63:
							break;
						default:
							switch (num2)
							{
							case 74:
							case 75:
								goto IL_3BE;
							}
							break;
						}
						break;
					}
				}
				else if (num2 == 82 || num2 == 86 || num2 == 92)
				{
					goto IL_3BE;
				}
			}
			else
			{
				if (num2 > 162)
				{
					if (num2 <= 199)
					{
						switch (num2)
						{
						case 167:
						case 170:
						case 171:
						case 172:
						case 173:
						case 176:
						case 180:
						case 181:
							goto IL_3BE;
						case 168:
						case 169:
						case 174:
						case 175:
						case 177:
						case 178:
						case 179:
							goto IL_3AB;
						default:
							if (num2 == 191)
							{
								goto IL_3BE;
							}
							if (num2 != 199)
							{
								goto IL_3AB;
							}
							break;
						}
					}
					else
					{
						if (num2 == 204)
						{
							goto IL_3BE;
						}
						switch (num2)
						{
						case 219:
						case 220:
							goto IL_3BE;
						case 221:
							break;
						default:
							switch (num2)
							{
							case 232:
							case 233:
							case 234:
								break;
							default:
								goto IL_3AB;
							}
							break;
						}
					}
					this.transactionName(beginTransactionStatement);
					goto IL_3BE;
				}
				if (num2 <= 106)
				{
					if (num2 == 95 || num2 == 106)
					{
						goto IL_3BE;
					}
				}
				else
				{
					if (num2 == 119)
					{
						goto IL_3BE;
					}
					switch (num2)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						goto IL_3BE;
					case 124:
					case 127:
					case 128:
					case 130:
					case 133:
					case 135:
					case 136:
					case 137:
					case 139:
					case 141:
						break;
					default:
						switch (num2)
						{
						case 156:
						case 160:
						case 161:
						case 162:
							goto IL_3BE;
						}
						break;
					}
				}
			}
			IL_3AB:
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_3BE:
			int num3 = this.LA(1);
			if (num3 <= 86)
			{
				if (num3 <= 28)
				{
					if (num3 <= 6)
					{
						if (num3 == 1 || num3 == 6)
						{
							return beginTransactionStatement;
						}
					}
					else
					{
						switch (num3)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							return beginTransactionStatement;
						case 14:
						case 16:
							break;
						default:
							switch (num3)
							{
							case 22:
							case 23:
								return beginTransactionStatement;
							default:
								if (num3 == 28)
								{
									return beginTransactionStatement;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num3 <= 64)
				{
					switch (num3)
					{
					case 33:
					case 35:
						return beginTransactionStatement;
					case 34:
						break;
					default:
						switch (num3)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							return beginTransactionStatement;
						}
						break;
					}
				}
				else
				{
					switch (num3)
					{
					case 74:
					case 75:
						return beginTransactionStatement;
					default:
						if (num3 == 82 || num3 == 86)
						{
							return beginTransactionStatement;
						}
						break;
					}
				}
			}
			else if (num3 <= 144)
			{
				if (num3 <= 95)
				{
					if (num3 == 92 || num3 == 95)
					{
						return beginTransactionStatement;
					}
				}
				else
				{
					if (num3 == 106 || num3 == 119)
					{
						return beginTransactionStatement;
					}
					switch (num3)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return beginTransactionStatement;
					}
				}
			}
			else if (num3 <= 181)
			{
				switch (num3)
				{
				case 156:
				case 160:
				case 161:
				case 162:
					return beginTransactionStatement;
				case 157:
				case 158:
				case 159:
					break;
				default:
					switch (num3)
					{
					case 167:
					case 170:
					case 172:
					case 173:
					case 176:
					case 180:
					case 181:
						return beginTransactionStatement;
					case 171:
					{
						this.match(171);
						IToken token4 = this.LT(1);
						this.match(232);
						if (this.inputState.guessing == 0)
						{
							TSql80ParserBaseInternal.Match(token4, "MARK");
							TSql80ParserBaseInternal.UpdateTokenInfo(beginTransactionStatement, token4);
							beginTransactionStatement.MarkDefined = true;
						}
						int num4 = this.LA(1);
						if (num4 <= 92)
						{
							if (num4 <= 28)
							{
								if (num4 <= 6)
								{
									if (num4 == 1 || num4 == 6)
									{
										return beginTransactionStatement;
									}
								}
								else
								{
									switch (num4)
									{
									case 12:
									case 13:
									case 15:
									case 17:
										return beginTransactionStatement;
									case 14:
									case 16:
										break;
									default:
										switch (num4)
										{
										case 22:
										case 23:
											return beginTransactionStatement;
										default:
											if (num4 == 28)
											{
												return beginTransactionStatement;
											}
											break;
										}
										break;
									}
								}
							}
							else if (num4 <= 75)
							{
								switch (num4)
								{
								case 33:
								case 35:
									return beginTransactionStatement;
								case 34:
									break;
								default:
									switch (num4)
									{
									case 44:
									case 45:
									case 46:
									case 48:
									case 49:
									case 54:
									case 55:
									case 56:
									case 60:
									case 61:
									case 64:
										return beginTransactionStatement;
									case 47:
									case 50:
									case 51:
									case 52:
									case 53:
									case 57:
									case 58:
									case 59:
									case 62:
									case 63:
										break;
									default:
										switch (num4)
										{
										case 74:
										case 75:
											return beginTransactionStatement;
										}
										break;
									}
									break;
								}
							}
							else if (num4 == 82 || num4 == 86 || num4 == 92)
							{
								return beginTransactionStatement;
							}
						}
						else if (num4 <= 173)
						{
							if (num4 <= 119)
							{
								if (num4 == 95 || num4 == 106 || num4 == 119)
								{
									return beginTransactionStatement;
								}
							}
							else
							{
								switch (num4)
								{
								case 123:
								case 125:
								case 126:
								case 129:
								case 131:
								case 132:
								case 134:
								case 138:
								case 140:
								case 142:
								case 143:
								case 144:
									return beginTransactionStatement;
								case 124:
								case 127:
								case 128:
								case 130:
								case 133:
								case 135:
								case 136:
								case 137:
								case 139:
								case 141:
									break;
								default:
									switch (num4)
									{
									case 156:
									case 160:
									case 161:
									case 162:
										return beginTransactionStatement;
									case 157:
									case 158:
									case 159:
										break;
									default:
										switch (num4)
										{
										case 167:
										case 170:
										case 172:
										case 173:
											return beginTransactionStatement;
										}
										break;
									}
									break;
								}
							}
						}
						else if (num4 <= 191)
						{
							if (num4 == 176)
							{
								return beginTransactionStatement;
							}
							switch (num4)
							{
							case 180:
							case 181:
								return beginTransactionStatement;
							default:
								if (num4 == 191)
								{
									return beginTransactionStatement;
								}
								break;
							}
						}
						else
						{
							if (num4 == 204)
							{
								return beginTransactionStatement;
							}
							switch (num4)
							{
							case 219:
							case 220:
								return beginTransactionStatement;
							default:
								switch (num4)
								{
								case 230:
								case 231:
								case 234:
								{
									ValueExpression markDescription = this.stringOrVariable();
									if (this.inputState.guessing == 0)
									{
										beginTransactionStatement.MarkDescription = markDescription;
										return beginTransactionStatement;
									}
									return beginTransactionStatement;
								}
								}
								break;
							}
						}
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
					}
					break;
				}
			}
			else
			{
				if (num3 == 191 || num3 == 204)
				{
					return beginTransactionStatement;
				}
				switch (num3)
				{
				case 219:
				case 220:
					return beginTransactionStatement;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x0005E684 File Offset: 0x0005C884
		public void transactionName(TransactionStatement vParent)
		{
			int num = this.LA(1);
			if (num != 199 && num != 221)
			{
				switch (num)
				{
				case 232:
				case 233:
				case 234:
				{
					IdentifierOrValueExpression name = this.identifierOrVariable();
					if (this.inputState.guessing == 0)
					{
						vParent.Name = name;
						return;
					}
					break;
				}
				default:
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
			}
			else
			{
				Identifier identifier = this.weirdTransactionName();
				if (this.inputState.guessing == 0)
				{
					vParent.Name = base.IdentifierOrValueExpression(identifier);
					return;
				}
			}
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x0005E714 File Offset: 0x0005C914
		public Identifier weirdTransactionName()
		{
			Identifier identifier = base.FragmentFactory.CreateFragment<Identifier>();
			StringBuilder stringBuilder = new StringBuilder();
			int num = this.LA(1);
			if (num != 199)
			{
				if (num != 221)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
			}
			else
			{
				IToken token = this.LT(1);
				this.match(199);
				if (this.inputState.guessing == 0)
				{
					stringBuilder.Append(token.getText());
					TSql80ParserBaseInternal.UpdateTokenInfo(identifier, token);
				}
			}
			IToken token2 = this.LT(1);
			this.match(221);
			IToken token3 = this.LT(1);
			this.match(202);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(identifier, token2);
				stringBuilder.Append(token2.getText());
				stringBuilder.Append(token3.getText());
			}
			this.tranIdentifier(stringBuilder, identifier);
			IToken token4 = this.LT(1);
			this.match(200);
			if (this.inputState.guessing == 0)
			{
				stringBuilder.Append(token4.getText());
			}
			this.tranIdentifier(stringBuilder, identifier);
			if (this.inputState.guessing == 0)
			{
				identifier.Value = stringBuilder.ToString();
			}
			return identifier;
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x0005E858 File Offset: 0x0005CA58
		public void tranIdentifier(StringBuilder vStringBuilder, TSqlFragment vParent)
		{
			switch (this.LA(1))
			{
			case 232:
			{
				IToken token = this.LT(1);
				this.match(232);
				if (this.inputState.guessing == 0)
				{
					vStringBuilder.Append(token.getText());
					TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token);
					return;
				}
				break;
			}
			case 233:
			{
				IToken token2 = this.LT(1);
				this.match(233);
				if (this.inputState.guessing == 0)
				{
					vStringBuilder.Append(token2.getText());
					TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token2);
					return;
				}
				break;
			}
			default:
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x0005E904 File Offset: 0x0005CB04
		public DeclareVariableElement declareVariableElement()
		{
			DeclareVariableElement declareVariableElement = base.FragmentFactory.CreateFragment<DeclareVariableElement>();
			Identifier variableName = this.identifierVariable();
			int num = this.LA(1);
			if (num <= 42)
			{
				if (num == 9)
				{
					this.match(9);
					goto IL_69;
				}
				if (num == 42)
				{
					goto IL_69;
				}
			}
			else
			{
				if (num == 53 || num == 96)
				{
					goto IL_69;
				}
				switch (num)
				{
				case 232:
				case 233:
					goto IL_69;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_69:
			int num2 = this.LA(1);
			DataTypeReference dataType;
			if (num2 <= 53)
			{
				if (num2 == 42)
				{
					dataType = this.cursorDataType();
					goto IL_C8;
				}
				if (num2 != 53)
				{
					goto IL_B5;
				}
			}
			else if (num2 != 96)
			{
				switch (num2)
				{
				case 232:
				case 233:
					break;
				default:
					goto IL_B5;
				}
			}
			dataType = this.scalarDataType();
			goto IL_C8;
			IL_B5:
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_C8:
			if (this.inputState.guessing == 0)
			{
				declareVariableElement.VariableName = variableName;
				declareVariableElement.DataType = dataType;
			}
			return declareVariableElement;
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x0005E9F8 File Offset: 0x0005CBF8
		public SqlDataTypeReference cursorDataType()
		{
			SqlDataTypeReference sqlDataTypeReference = base.FragmentFactory.CreateFragment<SqlDataTypeReference>();
			IToken token = this.LT(1);
			this.match(42);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(sqlDataTypeReference, token);
				sqlDataTypeReference.SqlDataTypeOption = SqlDataTypeOption.Cursor;
			}
			return sqlDataTypeReference;
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x0005EA40 File Offset: 0x0005CC40
		public DeclareVariableStatement declareVariableStatement()
		{
			DeclareVariableStatement declareVariableStatement = base.FragmentFactory.CreateFragment<DeclareVariableStatement>();
			DeclareVariableElement item = this.declareVariableElement();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<DeclareVariableElement>(declareVariableStatement, declareVariableStatement.Declarations, item);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				item = this.declareVariableElement();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<DeclareVariableElement>(declareVariableStatement, declareVariableStatement.Declarations, item);
				}
			}
			return declareVariableStatement;
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x0005EAB8 File Offset: 0x0005CCB8
		public DeclareCursorStatement declareCursorStatement()
		{
			DeclareCursorStatement declareCursorStatement = base.FragmentFactory.CreateFragment<DeclareCursorStatement>();
			List<CursorOption> vOptions = new List<CursorOption>();
			Identifier name = this.identifier();
			this.cursorOpts(true, vOptions);
			CursorDefinition cursorDefinition = this.cursorDefinitionOptions(vOptions);
			if (this.inputState.guessing == 0)
			{
				declareCursorStatement.Name = name;
				declareCursorStatement.CursorDefinition = cursorDefinition;
			}
			return declareCursorStatement;
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x0005EB0C File Offset: 0x0005CD0C
		public PredicateSetStatement predicateSetStatement()
		{
			PredicateSetStatement predicateSetStatement = base.FragmentFactory.CreateFragment<PredicateSetStatement>();
			IToken token = this.LT(1);
			this.match(232);
			if (this.inputState.guessing == 0)
			{
				predicateSetStatement.Options = PredicateSetOptionsHelper.Instance.ParseOption(token, SqlVersionFlags.TSql80);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				IToken token2 = this.LT(1);
				this.match(232);
				if (this.inputState.guessing == 0)
				{
					predicateSetStatement.Options |= PredicateSetOptionsHelper.Instance.ParseOption(token2, SqlVersionFlags.TSql80);
				}
			}
			this.setOnOff(predicateSetStatement);
			if (this.inputState.guessing == 0 && (predicateSetStatement.Options & SetOptions.QuotedIdentifier) == SetOptions.QuotedIdentifier)
			{
				this._tokenSource.QuotedIdentifier = predicateSetStatement.IsOn;
			}
			return predicateSetStatement;
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x0005EBE0 File Offset: 0x0005CDE0
		public SetVariableStatement setVariableStatement()
		{
			SetVariableStatement setVariableStatement = base.FragmentFactory.CreateFragment<SetVariableStatement>();
			VariableReference variable = this.variable();
			if (this.inputState.guessing == 0)
			{
				setVariableStatement.Variable = variable;
			}
			this.match(206);
			int num = this.LA(1);
			if (num <= 101)
			{
				if (num <= 34)
				{
					if (num != 20 && num != 25 && num != 34)
					{
						goto IL_1FA;
					}
				}
				else if (num <= 81)
				{
					switch (num)
					{
					case 40:
					case 41:
						break;
					case 42:
					{
						CursorDefinition cursorDefinition = this.cursorDefinition();
						if (this.inputState.guessing == 0)
						{
							setVariableStatement.CursorDefinition = cursorDefinition;
							return setVariableStatement;
						}
						return setVariableStatement;
					}
					default:
						if (num != 81)
						{
							goto IL_1FA;
						}
						break;
					}
				}
				else if (num != 93)
				{
					switch (num)
					{
					case 100:
					case 101:
						break;
					default:
						goto IL_1FA;
					}
				}
			}
			else if (num <= 147)
			{
				if (num <= 136)
				{
					if (num != 133 && num != 136)
					{
						goto IL_1FA;
					}
				}
				else if (num != 141 && num != 147)
				{
					goto IL_1FA;
				}
			}
			else if (num <= 193)
			{
				if (num != 163)
				{
					switch (num)
					{
					case 191:
					case 193:
						break;
					case 192:
						goto IL_1FA;
					default:
						goto IL_1FA;
					}
				}
			}
			else
			{
				switch (num)
				{
				case 197:
				case 199:
				case 200:
					break;
				case 198:
					goto IL_1FA;
				default:
					switch (num)
					{
					case 211:
					case 221:
					case 222:
					case 223:
					case 224:
					case 225:
					case 227:
					case 228:
					case 230:
					case 231:
					case 232:
					case 233:
					case 234:
					case 235:
						break;
					case 212:
					case 213:
					case 214:
					case 215:
					case 216:
					case 217:
					case 218:
					case 219:
					case 220:
					case 226:
					case 229:
						goto IL_1FA;
					default:
						goto IL_1FA;
					}
					break;
				}
			}
			ScalarExpression expression = this.expression();
			if (this.inputState.guessing == 0)
			{
				setVariableStatement.Expression = expression;
				return setVariableStatement;
			}
			return setVariableStatement;
			IL_1FA:
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x0005EDFC File Offset: 0x0005CFFC
		public SetStatisticsStatement setStatisticsStatement()
		{
			SetStatisticsStatement setStatisticsStatement = base.FragmentFactory.CreateFragment<SetStatisticsStatement>();
			this.match(146);
			IToken token = this.LT(1);
			this.match(232);
			if (this.inputState.guessing == 0)
			{
				setStatisticsStatement.Options = SetStatisticsOptionsHelper.Instance.ParseOption(token, SqlVersionFlags.TSql80);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				IToken token2 = this.LT(1);
				this.match(232);
				if (this.inputState.guessing == 0)
				{
					setStatisticsStatement.Options |= SetStatisticsOptionsHelper.Instance.ParseOption(token2, SqlVersionFlags.TSql80);
				}
			}
			this.setOnOff(setStatisticsStatement);
			return setStatisticsStatement;
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x0005EEB4 File Offset: 0x0005D0B4
		public SetRowCountStatement setRowcountStatement()
		{
			SetRowCountStatement setRowCountStatement = base.FragmentFactory.CreateFragment<SetRowCountStatement>();
			this.match(135);
			ValueExpression numberRows = this.integerOrVariable();
			if (this.inputState.guessing == 0)
			{
				setRowCountStatement.NumberRows = numberRows;
			}
			return setRowCountStatement;
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x0005EEF4 File Offset: 0x0005D0F4
		public SetOffsetsStatement setOffsetsStatement()
		{
			SetOffsetsStatement setOffsetsStatement = base.FragmentFactory.CreateFragment<SetOffsetsStatement>();
			this.match(104);
			SetOffsets setOffsets = this.offsetItem();
			if (this.inputState.guessing == 0)
			{
				setOffsetsStatement.Options = setOffsets;
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				setOffsets = this.offsetItem();
				if (this.inputState.guessing == 0)
				{
					setOffsetsStatement.Options |= setOffsets;
				}
			}
			this.setOnOff(setOffsetsStatement);
			return setOffsetsStatement;
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x0005EF78 File Offset: 0x0005D178
		public SetCommandStatement setCommandStatement()
		{
			SetCommandStatement setCommandStatement = base.FragmentFactory.CreateFragment<SetCommandStatement>();
			SetCommand item = this.setCommand();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<SetCommand>(setCommandStatement, setCommandStatement.Commands, item);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				item = this.setCommand();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<SetCommand>(setCommandStatement, setCommandStatement.Commands, item);
				}
			}
			return setCommandStatement;
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x0005EFF0 File Offset: 0x0005D1F0
		public SetTransactionIsolationLevelStatement setTransactionIsolationLevelStatement()
		{
			SetTransactionIsolationLevelStatement setTransactionIsolationLevelStatement = base.FragmentFactory.CreateFragment<SetTransactionIsolationLevelStatement>();
			switch (this.LA(1))
			{
			case 153:
				this.match(153);
				break;
			case 154:
				this.match(154);
				break;
			default:
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			IToken token = this.LT(1);
			this.match(232);
			IToken token2 = this.LT(1);
			this.match(232);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.Match(token, "ISOLATION");
				TSql80ParserBaseInternal.Match(token2, "LEVEL");
			}
			if (this.LA(1) == 124)
			{
				this.match(124);
				IToken token3 = this.LT(1);
				this.match(232);
				if (this.inputState.guessing == 0)
				{
					if (TSql80ParserBaseInternal.TryMatch(token3, "COMMITTED"))
					{
						setTransactionIsolationLevelStatement.Level = IsolationLevel.ReadCommitted;
					}
					else
					{
						TSql80ParserBaseInternal.Match(token3, "UNCOMMITTED");
						setTransactionIsolationLevelStatement.Level = IsolationLevel.ReadUncommitted;
					}
					TSql80ParserBaseInternal.UpdateTokenInfo(setTransactionIsolationLevelStatement, token3);
				}
			}
			else if (this.LA(1) == 232 && this.LA(2) == 124)
			{
				IToken token4 = this.LT(1);
				this.match(232);
				IToken token5 = this.LT(1);
				this.match(124);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.Match(token4, "REPEATABLE");
					setTransactionIsolationLevelStatement.Level = IsolationLevel.RepeatableRead;
					TSql80ParserBaseInternal.UpdateTokenInfo(setTransactionIsolationLevelStatement, token5);
				}
			}
			else
			{
				if (this.LA(1) != 232 || !TSql80ParserInternal.tokenSet_10_.member(this.LA(2)))
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				IToken token6 = this.LT(1);
				this.match(232);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.Match(token6, "SERIALIZABLE");
					setTransactionIsolationLevelStatement.Level = IsolationLevel.Serializable;
					TSql80ParserBaseInternal.UpdateTokenInfo(setTransactionIsolationLevelStatement, token6);
				}
			}
			return setTransactionIsolationLevelStatement;
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x0005F1F8 File Offset: 0x0005D3F8
		public SetTextSizeStatement setTextSizeStatement()
		{
			SetTextSizeStatement setTextSizeStatement = base.FragmentFactory.CreateFragment<SetTextSizeStatement>();
			this.match(149);
			ScalarExpression textSize = this.signedInteger();
			if (this.inputState.guessing == 0)
			{
				setTextSizeStatement.TextSize = textSize;
			}
			return setTextSizeStatement;
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x0005F238 File Offset: 0x0005D438
		public SetIdentityInsertStatement setIdentityInsertStatement()
		{
			SetIdentityInsertStatement setIdentityInsertStatement = base.FragmentFactory.CreateFragment<SetIdentityInsertStatement>();
			this.match(80);
			SchemaObjectName table = this.schemaObjectThreePartName();
			if (this.inputState.guessing == 0)
			{
				setIdentityInsertStatement.Table = table;
			}
			this.setOnOff(setIdentityInsertStatement);
			return setIdentityInsertStatement;
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x0005F27C File Offset: 0x0005D47C
		public SetErrorLevelStatement setErrorLevelStatement()
		{
			SetErrorLevelStatement setErrorLevelStatement = base.FragmentFactory.CreateFragment<SetErrorLevelStatement>();
			this.match(57);
			ScalarExpression level = this.signedInteger();
			if (this.inputState.guessing == 0)
			{
				setErrorLevelStatement.Level = level;
			}
			return setErrorLevelStatement;
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x0005F2BC File Offset: 0x0005D4BC
		public CursorDefinition cursorDefinition()
		{
			List<CursorOption> vOptions = new List<CursorOption>();
			return this.cursorDefinitionOptions(vOptions);
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x0005F2D8 File Offset: 0x0005D4D8
		public void setOnOff(SetOnOffStatement vParent)
		{
			switch (this.LA(1))
			{
			case 103:
			{
				IToken token = this.LT(1);
				this.match(103);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token);
					vParent.IsOn = false;
					return;
				}
				return;
			}
			case 105:
			{
				IToken token2 = this.LT(1);
				this.match(105);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token2);
					vParent.IsOn = true;
					return;
				}
				return;
			}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x0005F374 File Offset: 0x0005D574
		public SetOffsets offsetItem()
		{
			SetOffsets result = SetOffsets.None;
			int num = this.LA(1);
			if (num <= 113)
			{
				if (num <= 61)
				{
					if (num != 29)
					{
						switch (num)
						{
						case 60:
						case 61:
							switch (this.LA(1))
							{
							case 60:
								this.match(60);
								break;
							case 61:
								this.match(61);
								break;
							default:
								throw new NoViableAltException(this.LT(1), this.getFilename());
							}
							if (this.inputState.guessing == 0)
							{
								return SetOffsets.Execute;
							}
							return result;
						}
					}
					else
					{
						this.match(29);
						if (this.inputState.guessing == 0)
						{
							return SetOffsets.Compute;
						}
						return result;
					}
				}
				else if (num != 71)
				{
					if (num == 113)
					{
						this.match(113);
						if (this.inputState.guessing == 0)
						{
							return SetOffsets.Order;
						}
						return result;
					}
				}
				else
				{
					this.match(71);
					if (this.inputState.guessing == 0)
					{
						return SetOffsets.From;
					}
					return result;
				}
			}
			else if (num <= 140)
			{
				switch (num)
				{
				case 120:
				case 121:
					switch (this.LA(1))
					{
					case 120:
						this.match(120);
						break;
					case 121:
						this.match(121);
						break;
					default:
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
					if (this.inputState.guessing == 0)
					{
						return SetOffsets.Procedure;
					}
					return result;
				default:
					if (num == 140)
					{
						this.match(140);
						if (this.inputState.guessing == 0)
						{
							return SetOffsets.Select;
						}
						return result;
					}
					break;
				}
			}
			else if (num != 148)
			{
				if (num == 232)
				{
					IToken token = this.LT(1);
					this.match(232);
					if (this.inputState.guessing != 0)
					{
						return result;
					}
					if (TSql80ParserBaseInternal.TryMatch(token, "STATEMENT"))
					{
						return SetOffsets.Statement;
					}
					TSql80ParserBaseInternal.Match(token, "PARAM");
					return SetOffsets.Param;
				}
			}
			else
			{
				this.match(148);
				if (this.inputState.guessing == 0)
				{
					return SetOffsets.Table;
				}
				return result;
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x0005F5B8 File Offset: 0x0005D7B8
		public SetCommand setCommand()
		{
			SetCommand result = null;
			if (this.LA(1) == 232 && (this.LA(2) == 103 || this.LA(2) == 230 || this.LA(2) == 231) && base.NextTokenMatches("FIPS_FLAGGER"))
			{
				this.LT(1);
				this.match(232);
				result = this.fipsFlaggerLevel();
			}
			else
			{
				if (this.LA(1) != 232 || !TSql80ParserInternal.tokenSet_24_.member(this.LA(2)))
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				IToken token = this.LT(1);
				this.match(232);
				ScalarExpression parameter = this.possibleNegativeConstantOrIdentifier();
				if (this.inputState.guessing == 0)
				{
					GeneralSetCommand generalSetCommand = base.FragmentFactory.CreateFragment<GeneralSetCommand>();
					generalSetCommand.CommandType = GeneralSetCommandTypeHelper.Instance.ParseOption(token);
					generalSetCommand.Parameter = parameter;
					result = generalSetCommand;
				}
			}
			return result;
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x0005F6B0 File Offset: 0x0005D8B0
		public SetFipsFlaggerCommand fipsFlaggerLevel()
		{
			SetFipsFlaggerCommand setFipsFlaggerCommand = base.FragmentFactory.CreateFragment<SetFipsFlaggerCommand>();
			int num = this.LA(1);
			if (num != 103)
			{
				switch (num)
				{
				case 230:
				case 231:
				{
					StringLiteral fragment = this.stringLiteral();
					if (this.inputState.guessing == 0)
					{
						setFipsFlaggerCommand.ComplianceLevel = FipsComplianceLevelHelper.Instance.ParseOption(TSql80ParserBaseInternal.GetFirstToken(fragment));
						setFipsFlaggerCommand.UpdateTokenInfo(fragment);
					}
					break;
				}
				default:
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
			}
			else
			{
				IToken token = this.LT(1);
				this.match(103);
				if (this.inputState.guessing == 0)
				{
					setFipsFlaggerCommand.ComplianceLevel = FipsComplianceLevel.Off;
					TSql80ParserBaseInternal.UpdateTokenInfo(setFipsFlaggerCommand, token);
				}
			}
			return setFipsFlaggerCommand;
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x0005F764 File Offset: 0x0005D964
		public DeclareTableVariableBody declareTableBodyMain(IndexAffectingStatement statementType)
		{
			DeclareTableVariableBody declareTableVariableBody = base.FragmentFactory.CreateFragment<DeclareTableVariableBody>();
			this.match(191);
			TableDefinition definition = this.tableDefinition(statementType, null);
			if (this.inputState.guessing == 0)
			{
				declareTableVariableBody.Definition = definition;
			}
			IToken token = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(declareTableVariableBody, token);
			}
			return declareTableVariableBody;
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x0005F7D0 File Offset: 0x0005D9D0
		public TableDefinition tableDefinition(IndexAffectingStatement statementType, AlterTableAddTableElementStatement vStatement)
		{
			TableDefinition tableDefinition = base.FragmentFactory.CreateFragment<TableDefinition>();
			if (base.PhaseOne && vStatement != null)
			{
				vStatement.Definition = tableDefinition;
			}
			this.tableElement(statementType, tableDefinition, vStatement);
			while (this.LA(1) == 198)
			{
				this.match(198);
				this.tableElement(statementType, tableDefinition, vStatement);
			}
			return tableDefinition;
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x0005F82C File Offset: 0x0005DA2C
		public void tableElement(IndexAffectingStatement statementType, TableDefinition vParent, AlterTableAddTableElementStatement vStatement)
		{
			int num = this.LA(1);
			if (num <= 47)
			{
				if (num != 21 && num != 30 && num != 47)
				{
					goto IL_95;
				}
			}
			else if (num <= 118)
			{
				if (num != 68 && num != 118)
				{
					goto IL_95;
				}
			}
			else if (num != 159)
			{
				switch (num)
				{
				case 232:
				case 233:
				{
					ColumnDefinition item = this.columnDefinition(statementType, vStatement);
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ColumnDefinition>(vParent, vParent.ColumnDefinitions, item);
						return;
					}
					return;
				}
				default:
					goto IL_95;
				}
			}
			ConstraintDefinition item2 = this.tableConstraint(statementType, vStatement);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ConstraintDefinition>(vParent, vParent.TableConstraints, item2);
				return;
			}
			return;
			IL_95:
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x0005F8E4 File Offset: 0x0005DAE4
		public void cursorOpts(bool oldSyntax, IList<CursorOption> vOptions)
		{
			while (this.LA(1) == 232)
			{
				CursorOption cursorOption = this.cursorOption();
				if (this.inputState.guessing == 0)
				{
					if (oldSyntax)
					{
						if (cursorOption.OptionKind != CursorOptionKind.Insensitive && cursorOption.OptionKind != CursorOptionKind.Scroll)
						{
							TSql80ParserBaseInternal.ThrowIncorrectSyntaxErrorException(cursorOption);
						}
					}
					else if (cursorOption.OptionKind == CursorOptionKind.Insensitive)
					{
						TSql80ParserBaseInternal.ThrowIncorrectSyntaxErrorException(cursorOption);
					}
					vOptions.Add(cursorOption);
				}
			}
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x0005F948 File Offset: 0x0005DB48
		public CursorDefinition cursorDefinitionOptions(IList<CursorOption> vOptions)
		{
			CursorDefinition cursorDefinition = base.FragmentFactory.CreateFragment<CursorDefinition>();
			this.match(42);
			this.cursorOpts(false, vOptions);
			this.match(67);
			SelectStatement select = this.selectStatement();
			if (this.inputState.guessing == 0)
			{
				cursorDefinition.Select = select;
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<CursorOption>(cursorDefinition, cursorDefinition.Options, vOptions);
			}
			return cursorDefinition;
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x0005F9A4 File Offset: 0x0005DBA4
		public SelectStatement selectStatement()
		{
			return this.select();
		}

		// Token: 0x0600132B RID: 4907 RVA: 0x0005F9BC File Offset: 0x0005DBBC
		public CursorOption cursorOption()
		{
			CursorOption cursorOption = base.FragmentFactory.CreateFragment<CursorOption>();
			IToken token = this.LT(1);
			this.match(232);
			if (this.inputState.guessing == 0)
			{
				cursorOption.OptionKind = CursorOptionsHelper.Instance.ParseOption(token);
			}
			return cursorOption;
		}

		// Token: 0x0600132C RID: 4908 RVA: 0x0005FA0C File Offset: 0x0005DC0C
		public void indexLegacyOptionList(CreateIndexStatement vParent)
		{
			IndexOption indexOption = this.indexLegacyOption();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.VerifyAllowedIndexOption(IndexAffectingStatement.CreateIndex, indexOption);
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<IndexOption>(vParent, vParent.IndexOptions, indexOption);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				indexOption = this.indexLegacyOption();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.VerifyAllowedIndexOption(IndexAffectingStatement.CreateIndex, indexOption);
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<IndexOption>(vParent, vParent.IndexOptions, indexOption);
				}
			}
		}

		// Token: 0x0600132D RID: 4909 RVA: 0x0005FA84 File Offset: 0x0005DC84
		public FileGroupOrPartitionScheme filegroupOrPartitionScheme()
		{
			FileGroupOrPartitionScheme fileGroupOrPartitionScheme = base.FragmentFactory.CreateFragment<FileGroupOrPartitionScheme>();
			IdentifierOrValueExpression name = this.stringOrIdentifier();
			if (this.inputState.guessing == 0)
			{
				fileGroupOrPartitionScheme.Name = name;
			}
			return fileGroupOrPartitionScheme;
		}

		// Token: 0x0600132E RID: 4910 RVA: 0x0005FABC File Offset: 0x0005DCBC
		public IndexOption indexLegacyOption()
		{
			IndexOption result = null;
			int num = this.LA(1);
			if (num != 66)
			{
				if (num != 232)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				IToken token = this.LT(1);
				this.match(232);
				if (this.inputState.guessing == 0)
				{
					IndexStateOption indexStateOption = base.FragmentFactory.CreateFragment<IndexStateOption>();
					result = indexStateOption;
					indexStateOption.OptionKind = TSql80ParserBaseInternal.ParseIndexLegacyWithOption(token);
					TSql80ParserBaseInternal.UpdateTokenInfo(indexStateOption, token);
					indexStateOption.OptionState = OptionState.On;
				}
			}
			else
			{
				result = this.fillFactorOption();
			}
			return result;
		}

		// Token: 0x0600132F RID: 4911 RVA: 0x0005FB4C File Offset: 0x0005DD4C
		public IndexExpressionOption fillFactorOption()
		{
			IndexExpressionOption indexExpressionOption = base.FragmentFactory.CreateFragment<IndexExpressionOption>();
			IToken token = this.LT(1);
			this.match(66);
			this.match(206);
			Literal literal = this.integer();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.CheckFillFactorRange(literal);
				indexExpressionOption.OptionKind = IndexOptionKind.FillFactor;
				indexExpressionOption.Expression = literal;
				TSql80ParserBaseInternal.UpdateTokenInfo(indexExpressionOption, token);
			}
			return indexExpressionOption;
		}

		// Token: 0x06001330 RID: 4912 RVA: 0x0005FBB4 File Offset: 0x0005DDB4
		public QueryExpression subqueryExpression()
		{
			BinaryQueryExpression binaryQueryExpression = null;
			QueryExpression queryExpression = this.subqueryExpressionUnit();
			while (this.LA(1) == 59 || this.LA(1) == 87 || this.LA(1) == 158)
			{
				if (this.inputState.guessing == 0)
				{
					binaryQueryExpression = base.FragmentFactory.CreateFragment<BinaryQueryExpression>();
					binaryQueryExpression.FirstQueryExpression = queryExpression;
				}
				int num = this.LA(1);
				if (num != 59)
				{
					if (num != 87)
					{
						if (num != 158)
						{
							throw new NoViableAltException(this.LT(1), this.getFilename());
						}
						this.match(158);
						if (this.inputState.guessing == 0)
						{
							binaryQueryExpression.BinaryQueryExpressionType = BinaryQueryExpressionType.Union;
						}
					}
					else
					{
						this.match(87);
						if (this.inputState.guessing == 0)
						{
							binaryQueryExpression.BinaryQueryExpressionType = BinaryQueryExpressionType.Intersect;
						}
					}
				}
				else
				{
					this.match(59);
					if (this.inputState.guessing == 0)
					{
						binaryQueryExpression.BinaryQueryExpressionType = BinaryQueryExpressionType.Except;
					}
				}
				int num2 = this.LA(1);
				if (num2 != 5)
				{
					if (num2 != 140 && num2 != 191)
					{
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
				}
				else
				{
					this.match(5);
					if (this.inputState.guessing == 0)
					{
						binaryQueryExpression.All = true;
					}
				}
				queryExpression = this.subqueryExpressionUnit();
				if (this.inputState.guessing == 0)
				{
					binaryQueryExpression.SecondQueryExpression = queryExpression;
					queryExpression = binaryQueryExpression;
				}
			}
			return queryExpression;
		}

		// Token: 0x06001331 RID: 4913 RVA: 0x0005FD14 File Offset: 0x0005DF14
		public QueryExpression queryExpression(SelectStatement vSelectStatement)
		{
			BinaryQueryExpression binaryQueryExpression = null;
			QueryExpression queryExpression = this.queryExpressionUnit(vSelectStatement);
			while (this.LA(1) == 59 || this.LA(1) == 87 || this.LA(1) == 158)
			{
				if (this.inputState.guessing == 0)
				{
					binaryQueryExpression = base.FragmentFactory.CreateFragment<BinaryQueryExpression>();
					binaryQueryExpression.FirstQueryExpression = queryExpression;
				}
				int num = this.LA(1);
				if (num != 59)
				{
					if (num != 87)
					{
						if (num != 158)
						{
							throw new NoViableAltException(this.LT(1), this.getFilename());
						}
						this.match(158);
						if (this.inputState.guessing == 0)
						{
							binaryQueryExpression.BinaryQueryExpressionType = BinaryQueryExpressionType.Union;
						}
					}
					else
					{
						this.match(87);
						if (this.inputState.guessing == 0)
						{
							binaryQueryExpression.BinaryQueryExpressionType = BinaryQueryExpressionType.Intersect;
						}
					}
				}
				else
				{
					this.match(59);
					if (this.inputState.guessing == 0)
					{
						binaryQueryExpression.BinaryQueryExpressionType = BinaryQueryExpressionType.Except;
					}
				}
				int num2 = this.LA(1);
				if (num2 != 5)
				{
					if (num2 != 140 && num2 != 191)
					{
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
				}
				else
				{
					this.match(5);
					if (this.inputState.guessing == 0)
					{
						binaryQueryExpression.All = true;
					}
				}
				queryExpression = this.queryExpressionUnit(null);
				if (this.inputState.guessing == 0)
				{
					binaryQueryExpression.SecondQueryExpression = queryExpression;
					queryExpression = binaryQueryExpression;
				}
			}
			return queryExpression;
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x0005FE74 File Offset: 0x0005E074
		public OrderByClause orderByClause()
		{
			OrderByClause orderByClause = base.FragmentFactory.CreateFragment<OrderByClause>();
			IToken token = this.LT(1);
			this.match(113);
			this.match(18);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(orderByClause, token);
			}
			ExpressionWithSortOrder item = this.expressionWithSortOrder();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ExpressionWithSortOrder>(orderByClause, orderByClause.OrderByElements, item);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				item = this.expressionWithSortOrder();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ExpressionWithSortOrder>(orderByClause, orderByClause.OrderByElements, item);
				}
			}
			return orderByClause;
		}

		// Token: 0x06001333 RID: 4915 RVA: 0x0005FF1C File Offset: 0x0005E11C
		public ComputeClause computeClause()
		{
			ComputeClause computeClause = base.FragmentFactory.CreateFragment<ComputeClause>();
			IToken token = this.LT(1);
			this.match(29);
			ComputeFunction item = this.computeFunction();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(computeClause, token);
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ComputeFunction>(computeClause, computeClause.ComputeFunctions, item);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				item = this.computeFunction();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ComputeFunction>(computeClause, computeClause.ComputeFunctions, item);
				}
			}
			int num = this.LA(1);
			if (num <= 92)
			{
				if (num <= 35)
				{
					if (num <= 6)
					{
						if (num == 1 || num == 6)
						{
							return computeClause;
						}
					}
					else
					{
						switch (num)
						{
						case 12:
						case 13:
						case 15:
						case 17:
						case 22:
						case 23:
							return computeClause;
						case 14:
						case 16:
						case 19:
						case 20:
						case 21:
							break;
						case 18:
							this.match(18);
							this.expressionList(computeClause, computeClause.ByExpressions);
							return computeClause;
						default:
							switch (num)
							{
							case 28:
							case 29:
								return computeClause;
							default:
								switch (num)
								{
								case 33:
								case 35:
									return computeClause;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num <= 75)
				{
					switch (num)
					{
					case 44:
					case 45:
					case 46:
					case 48:
					case 49:
					case 54:
					case 55:
					case 56:
					case 60:
					case 61:
					case 64:
						return computeClause;
					case 47:
					case 50:
					case 51:
					case 52:
					case 53:
					case 57:
					case 58:
					case 59:
					case 62:
					case 63:
						break;
					default:
						if (num == 67)
						{
							return computeClause;
						}
						switch (num)
						{
						case 74:
						case 75:
							return computeClause;
						}
						break;
					}
				}
				else if (num == 82 || num == 86 || num == 92)
				{
					return computeClause;
				}
			}
			else if (num <= 162)
			{
				if (num <= 111)
				{
					if (num == 95 || num == 106 || num == 111)
					{
						return computeClause;
					}
				}
				else
				{
					if (num == 119)
					{
						return computeClause;
					}
					switch (num)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return computeClause;
					case 124:
					case 127:
					case 128:
					case 130:
					case 133:
					case 135:
					case 136:
					case 137:
					case 139:
					case 141:
						break;
					default:
						switch (num)
						{
						case 156:
						case 160:
						case 161:
						case 162:
							return computeClause;
						}
						break;
					}
				}
			}
			else if (num <= 181)
			{
				switch (num)
				{
				case 167:
				case 170:
				case 172:
				case 173:
					return computeClause;
				case 168:
				case 169:
				case 171:
					break;
				default:
					if (num == 176)
					{
						return computeClause;
					}
					switch (num)
					{
					case 180:
					case 181:
						return computeClause;
					}
					break;
				}
			}
			else
			{
				if (num == 191 || num == 204)
				{
					return computeClause;
				}
				switch (num)
				{
				case 219:
				case 220:
					return computeClause;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x0006023C File Offset: 0x0005E43C
		public ForClause forClause()
		{
			ForClause forClause = null;
			IToken token = this.LT(1);
			this.match(67);
			int num = this.LA(1);
			if (num <= 124)
			{
				if (num != 16)
				{
					if (num == 124)
					{
						this.match(124);
						IToken token2 = this.LT(1);
						this.match(232);
						if (this.inputState.guessing == 0)
						{
							TSql80ParserBaseInternal.Match(token2, "ONLY");
							forClause = base.FragmentFactory.CreateFragment<ReadOnlyForClause>();
							TSql80ParserBaseInternal.UpdateTokenInfo(forClause, token2);
							return forClause;
						}
						return forClause;
					}
				}
				else
				{
					forClause = this.browseForClause();
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.UpdateTokenInfo(forClause, token);
						return forClause;
					}
					return forClause;
				}
			}
			else if (num != 160)
			{
				if (num == 232)
				{
					forClause = this.xmlForClause();
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.UpdateTokenInfo(forClause, token);
						return forClause;
					}
					return forClause;
				}
			}
			else
			{
				forClause = this.updateForClause();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(forClause, token);
					return forClause;
				}
				return forClause;
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x0006034C File Offset: 0x0005E54C
		public void optimizerHints(TSqlFragment vParent, IList<OptimizerHint> hintsCollection)
		{
			IToken token = this.LT(1);
			this.match(111);
			this.match(191);
			OptimizerHint item = this.hint();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token);
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<OptimizerHint>(vParent, hintsCollection, item);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				item = this.hint();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<OptimizerHint>(vParent, hintsCollection, item);
				}
			}
			IToken token2 = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token2);
			}
		}

		// Token: 0x06001336 RID: 4918 RVA: 0x000603FC File Offset: 0x0005E5FC
		public QueryDerivedTable derivedTable()
		{
			QueryDerivedTable queryDerivedTable = base.FragmentFactory.CreateFragment<QueryDerivedTable>();
			IToken token = this.LT(1);
			this.match(191);
			QueryExpression queryExpression = this.subqueryExpression();
			IToken token2 = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				queryDerivedTable.QueryExpression = queryExpression;
				TSql80ParserBaseInternal.UpdateTokenInfo(queryDerivedTable, token);
				TSql80ParserBaseInternal.UpdateTokenInfo(queryDerivedTable, token2);
			}
			this.simpleTableReferenceAlias(queryDerivedTable);
			if (this.LA(1) == 191 && (this.LA(2) == 232 || this.LA(2) == 233))
			{
				this.columnNameList(queryDerivedTable, queryDerivedTable.Columns);
			}
			else if (!TSql80ParserInternal.tokenSet_32_.member(this.LA(1)) || !TSql80ParserInternal.tokenSet_33_.member(this.LA(2)))
			{
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			return queryDerivedTable;
		}

		// Token: 0x06001337 RID: 4919 RVA: 0x000604E4 File Offset: 0x0005E6E4
		public void simpleTableReferenceAlias(TableReferenceWithAlias vParent)
		{
			int num = this.LA(1);
			if (num != 9)
			{
				switch (num)
				{
				case 232:
				case 233:
					break;
				default:
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
			}
			else
			{
				this.match(9);
			}
			Identifier alias = this.identifier();
			if (this.inputState.guessing == 0)
			{
				vParent.Alias = alias;
			}
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x0006054C File Offset: 0x0005E74C
		public ScalarSubquery subquery(ExpressionFlags expressionFlags)
		{
			ScalarSubquery scalarSubquery = base.FragmentFactory.CreateFragment<ScalarSubquery>();
			IToken token = this.LT(1);
			this.match(191);
			QueryExpression queryExpression = this.subqueryExpression();
			IToken token2 = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				if (ExpressionFlags.ScalarSubqueriesDisallowed == (expressionFlags & ExpressionFlags.ScalarSubqueriesDisallowed))
				{
					TSql80ParserBaseInternal.ThrowParseErrorException("SQL46098", queryExpression, TSqlParserResource.SQL46098Message, new string[0]);
				}
				scalarSubquery.QueryExpression = queryExpression;
				TSql80ParserBaseInternal.UpdateTokenInfo(scalarSubquery, token);
				TSql80ParserBaseInternal.UpdateTokenInfo(scalarSubquery, token2);
			}
			return scalarSubquery;
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x000605D8 File Offset: 0x0005E7D8
		public QueryExpression subqueryExpressionUnit()
		{
			int num = this.LA(1);
			QueryExpression result;
			if (num != 140)
			{
				if (num != 191)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				result = this.subqueryParenthesis();
			}
			else
			{
				result = this.subquerySpecification();
			}
			return result;
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x00060628 File Offset: 0x0005E828
		public QuerySpecification subquerySpecification()
		{
			QuerySpecification querySpecification = base.FragmentFactory.CreateFragment<QuerySpecification>();
			IToken token = this.LT(1);
			this.match(140);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(querySpecification, token);
			}
			int num = this.LA(1);
			if (num <= 93)
			{
				if (num <= 34)
				{
					if (num <= 20)
					{
						if (num != 5)
						{
							if (num != 20)
							{
								goto IL_213;
							}
							goto IL_226;
						}
					}
					else
					{
						if (num != 25 && num != 34)
						{
							goto IL_213;
						}
						goto IL_226;
					}
				}
				else if (num <= 51)
				{
					switch (num)
					{
					case 40:
					case 41:
						goto IL_226;
					default:
						if (num != 51)
						{
							goto IL_213;
						}
						break;
					}
				}
				else
				{
					switch (num)
					{
					case 79:
					case 81:
						goto IL_226;
					case 80:
						goto IL_213;
					default:
						if (num != 93)
						{
							goto IL_213;
						}
						goto IL_226;
					}
				}
				UniqueRowFilter uniqueRowFilter = this.uniqueRowFilter();
				if (this.inputState.guessing == 0)
				{
					querySpecification.UniqueRowFilter = uniqueRowFilter;
					goto IL_226;
				}
				goto IL_226;
			}
			else if (num <= 141)
			{
				if (num <= 133)
				{
					switch (num)
					{
					case 100:
					case 101:
						goto IL_226;
					default:
						if (num == 133)
						{
							goto IL_226;
						}
						break;
					}
				}
				else if (num == 136 || num == 141)
				{
					goto IL_226;
				}
			}
			else if (num <= 152)
			{
				if (num == 147 || num == 152)
				{
					goto IL_226;
				}
			}
			else
			{
				if (num == 163)
				{
					goto IL_226;
				}
				switch (num)
				{
				case 191:
				case 193:
				case 195:
				case 197:
				case 199:
				case 200:
					goto IL_226;
				case 192:
				case 194:
				case 196:
				case 198:
					break;
				default:
					switch (num)
					{
					case 211:
					case 221:
					case 222:
					case 223:
					case 224:
					case 225:
					case 227:
					case 228:
					case 230:
					case 231:
					case 232:
					case 233:
					case 234:
					case 235:
						goto IL_226;
					}
					break;
				}
			}
			IL_213:
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_226:
			int num2 = this.LA(1);
			if (num2 <= 101)
			{
				if (num2 <= 34)
				{
					if (num2 == 20 || num2 == 25 || num2 == 34)
					{
						goto IL_3F8;
					}
				}
				else if (num2 <= 81)
				{
					switch (num2)
					{
					case 40:
					case 41:
						goto IL_3F8;
					default:
						switch (num2)
						{
						case 79:
						case 81:
							goto IL_3F8;
						}
						break;
					}
				}
				else
				{
					if (num2 == 93)
					{
						goto IL_3F8;
					}
					switch (num2)
					{
					case 100:
					case 101:
						goto IL_3F8;
					}
				}
			}
			else if (num2 <= 147)
			{
				if (num2 <= 136)
				{
					if (num2 == 133 || num2 == 136)
					{
						goto IL_3F8;
					}
				}
				else if (num2 == 141 || num2 == 147)
				{
					goto IL_3F8;
				}
			}
			else if (num2 <= 163)
			{
				if (num2 != 152)
				{
					if (num2 == 163)
					{
						goto IL_3F8;
					}
				}
				else
				{
					TopRowFilter topRowFilter = this.topRowFilter();
					if (this.inputState.guessing == 0)
					{
						querySpecification.TopRowFilter = topRowFilter;
						goto IL_3F8;
					}
					goto IL_3F8;
				}
			}
			else
			{
				switch (num2)
				{
				case 191:
				case 193:
				case 195:
				case 197:
				case 199:
				case 200:
					goto IL_3F8;
				case 192:
				case 194:
				case 196:
				case 198:
					break;
				default:
					switch (num2)
					{
					case 211:
					case 221:
					case 222:
					case 223:
					case 224:
					case 225:
					case 227:
					case 228:
					case 230:
					case 231:
					case 232:
					case 233:
					case 234:
					case 235:
						goto IL_3F8;
					}
					break;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_3F8:
			SelectElement item = this.selectColumnOrStarExpression();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<SelectElement>(querySpecification, querySpecification.SelectElements, item);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				item = this.selectColumnOrStarExpression();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<SelectElement>(querySpecification, querySpecification.SelectElements, item);
				}
			}
			FromClause fromClause = this.fromClauseOpt();
			if (this.inputState.guessing == 0)
			{
				querySpecification.FromClause = fromClause;
			}
			int num3 = this.LA(1);
			if (num3 <= 77)
			{
				if (num3 <= 35)
				{
					if (num3 == 1 || num3 == 35)
					{
						goto IL_54A;
					}
				}
				else
				{
					if (num3 == 59 || num3 == 67)
					{
						goto IL_54A;
					}
					switch (num3)
					{
					case 75:
					case 76:
					case 77:
						goto IL_54A;
					}
				}
			}
			else if (num3 <= 158)
			{
				if (num3 == 87 || num3 == 113 || num3 == 158)
				{
					goto IL_54A;
				}
			}
			else
			{
				switch (num3)
				{
				case 169:
				{
					WhereClause whereClause = this.whereClause();
					if (this.inputState.guessing == 0)
					{
						querySpecification.WhereClause = whereClause;
						goto IL_54A;
					}
					goto IL_54A;
				}
				case 170:
					break;
				case 171:
					goto IL_54A;
				default:
					if (num3 == 192 || num3 == 219)
					{
						goto IL_54A;
					}
					break;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_54A:
			int num4 = this.LA(1);
			if (num4 <= 77)
			{
				if (num4 <= 35)
				{
					if (num4 == 1 || num4 == 35)
					{
						goto IL_60E;
					}
				}
				else
				{
					if (num4 == 59 || num4 == 67)
					{
						goto IL_60E;
					}
					switch (num4)
					{
					case 75:
					case 77:
						goto IL_60E;
					case 76:
					{
						GroupByClause groupByClause = this.groupByClause();
						if (this.inputState.guessing == 0)
						{
							querySpecification.GroupByClause = groupByClause;
							goto IL_60E;
						}
						goto IL_60E;
					}
					}
				}
			}
			else if (num4 <= 158)
			{
				if (num4 == 87 || num4 == 113 || num4 == 158)
				{
					goto IL_60E;
				}
			}
			else if (num4 == 171 || num4 == 192 || num4 == 219)
			{
				goto IL_60E;
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_60E:
			int num5 = this.LA(1);
			if (num5 <= 77)
			{
				if (num5 <= 35)
				{
					if (num5 == 1 || num5 == 35)
					{
						goto IL_6D2;
					}
				}
				else
				{
					if (num5 == 59 || num5 == 67)
					{
						goto IL_6D2;
					}
					switch (num5)
					{
					case 75:
						goto IL_6D2;
					case 77:
					{
						HavingClause havingClause = this.havingClause();
						if (this.inputState.guessing == 0)
						{
							querySpecification.HavingClause = havingClause;
							goto IL_6D2;
						}
						goto IL_6D2;
					}
					}
				}
			}
			else if (num5 <= 158)
			{
				if (num5 == 87 || num5 == 113 || num5 == 158)
				{
					goto IL_6D2;
				}
			}
			else if (num5 == 171 || num5 == 192 || num5 == 219)
			{
				goto IL_6D2;
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_6D2:
			int num6 = this.LA(1);
			if (num6 <= 75)
			{
				if (num6 <= 35)
				{
					if (num6 == 1 || num6 == 35)
					{
						goto IL_77D;
					}
				}
				else if (num6 == 59 || num6 == 67 || num6 == 75)
				{
					goto IL_77D;
				}
			}
			else if (num6 <= 158)
			{
				if (num6 == 87)
				{
					goto IL_77D;
				}
				if (num6 != 113)
				{
					if (num6 == 158)
					{
						goto IL_77D;
					}
				}
				else
				{
					OrderByClause orderByClause = this.orderByClause();
					if (this.inputState.guessing == 0)
					{
						querySpecification.OrderByClause = orderByClause;
						goto IL_77D;
					}
					goto IL_77D;
				}
			}
			else if (num6 == 171 || num6 == 192 || num6 == 219)
			{
				goto IL_77D;
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_77D:
			if (this.LA(1) == 67 && this.LA(1) == 67 && this.LA(2) == 16)
			{
				this.match(67);
				BrowseForClause forClause = this.browseForClause();
				if (this.inputState.guessing == 0)
				{
					querySpecification.ForClause = forClause;
				}
			}
			else if (!TSql80ParserInternal.tokenSet_34_.member(this.LA(1)))
			{
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			if (this.inputState.guessing == 0)
			{
				if (querySpecification.OrderByClause != null && querySpecification.TopRowFilter == null)
				{
					TSql80ParserBaseInternal.ThrowParseErrorException("SQL46047", querySpecification, TSqlParserResource.SQL46047Message, new string[0]);
				}
				if (querySpecification.TopRowFilter != null && querySpecification.TopRowFilter.WithTies && querySpecification.OrderByClause == null)
				{
					TSql80ParserBaseInternal.ThrowParseErrorException("SQL46048", querySpecification, TSqlParserResource.SQL46048Message, new string[0]);
				}
			}
			return querySpecification;
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x00060E88 File Offset: 0x0005F088
		public QueryParenthesisExpression subqueryParenthesis()
		{
			QueryParenthesisExpression queryParenthesisExpression = base.FragmentFactory.CreateFragment<QueryParenthesisExpression>();
			IToken token = this.LT(1);
			this.match(191);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(queryParenthesisExpression, token);
			}
			QueryExpression queryExpression = this.subqueryExpression();
			if (this.inputState.guessing == 0)
			{
				queryParenthesisExpression.QueryExpression = queryExpression;
			}
			IToken token2 = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(queryParenthesisExpression, token2);
			}
			return queryParenthesisExpression;
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x00060F10 File Offset: 0x0005F110
		public QueryExpression queryExpressionUnit(SelectStatement vSelectStatement)
		{
			int num = this.LA(1);
			QueryExpression result;
			if (num != 140)
			{
				if (num != 191)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				result = this.queryParenthesis(vSelectStatement);
			}
			else
			{
				result = this.querySpecification(vSelectStatement);
			}
			return result;
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x00060F64 File Offset: 0x0005F164
		public QuerySpecification querySpecification(SelectStatement vSelectStatement)
		{
			QuerySpecification querySpecification = base.FragmentFactory.CreateFragment<QuerySpecification>();
			IToken token = this.LT(1);
			this.match(140);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(querySpecification, token);
			}
			int num = this.LA(1);
			if (num <= 93)
			{
				if (num <= 34)
				{
					if (num <= 20)
					{
						if (num != 5)
						{
							if (num != 20)
							{
								goto IL_217;
							}
							goto IL_22A;
						}
					}
					else
					{
						if (num != 25 && num != 34)
						{
							goto IL_217;
						}
						goto IL_22A;
					}
				}
				else if (num <= 51)
				{
					switch (num)
					{
					case 40:
					case 41:
						goto IL_22A;
					default:
						if (num != 51)
						{
							goto IL_217;
						}
						break;
					}
				}
				else
				{
					switch (num)
					{
					case 79:
					case 81:
						goto IL_22A;
					case 80:
						goto IL_217;
					default:
						if (num != 93)
						{
							goto IL_217;
						}
						goto IL_22A;
					}
				}
				UniqueRowFilter uniqueRowFilter = this.uniqueRowFilter();
				if (this.inputState.guessing == 0)
				{
					querySpecification.UniqueRowFilter = uniqueRowFilter;
					goto IL_22A;
				}
				goto IL_22A;
			}
			else if (num <= 141)
			{
				if (num <= 133)
				{
					switch (num)
					{
					case 100:
					case 101:
						goto IL_22A;
					default:
						if (num == 133)
						{
							goto IL_22A;
						}
						break;
					}
				}
				else if (num == 136 || num == 141)
				{
					goto IL_22A;
				}
			}
			else if (num <= 152)
			{
				if (num == 147 || num == 152)
				{
					goto IL_22A;
				}
			}
			else
			{
				if (num == 163)
				{
					goto IL_22A;
				}
				switch (num)
				{
				case 191:
				case 193:
				case 195:
				case 197:
				case 199:
				case 200:
					goto IL_22A;
				case 192:
				case 194:
				case 196:
				case 198:
					break;
				default:
					switch (num)
					{
					case 211:
					case 221:
					case 222:
					case 223:
					case 224:
					case 225:
					case 227:
					case 228:
					case 230:
					case 231:
					case 232:
					case 233:
					case 234:
					case 235:
						goto IL_22A;
					}
					break;
				}
			}
			IL_217:
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_22A:
			int num2 = this.LA(1);
			if (num2 <= 101)
			{
				if (num2 <= 34)
				{
					if (num2 == 20 || num2 == 25 || num2 == 34)
					{
						goto IL_3FC;
					}
				}
				else if (num2 <= 81)
				{
					switch (num2)
					{
					case 40:
					case 41:
						goto IL_3FC;
					default:
						switch (num2)
						{
						case 79:
						case 81:
							goto IL_3FC;
						}
						break;
					}
				}
				else
				{
					if (num2 == 93)
					{
						goto IL_3FC;
					}
					switch (num2)
					{
					case 100:
					case 101:
						goto IL_3FC;
					}
				}
			}
			else if (num2 <= 147)
			{
				if (num2 <= 136)
				{
					if (num2 == 133 || num2 == 136)
					{
						goto IL_3FC;
					}
				}
				else if (num2 == 141 || num2 == 147)
				{
					goto IL_3FC;
				}
			}
			else if (num2 <= 163)
			{
				if (num2 != 152)
				{
					if (num2 == 163)
					{
						goto IL_3FC;
					}
				}
				else
				{
					TopRowFilter topRowFilter = this.topRowFilter();
					if (this.inputState.guessing == 0)
					{
						querySpecification.TopRowFilter = topRowFilter;
						goto IL_3FC;
					}
					goto IL_3FC;
				}
			}
			else
			{
				switch (num2)
				{
				case 191:
				case 193:
				case 195:
				case 197:
				case 199:
				case 200:
					goto IL_3FC;
				case 192:
				case 194:
				case 196:
				case 198:
					break;
				default:
					switch (num2)
					{
					case 211:
					case 221:
					case 222:
					case 223:
					case 224:
					case 225:
					case 227:
					case 228:
					case 230:
					case 231:
					case 232:
					case 233:
					case 234:
					case 235:
						goto IL_3FC;
					}
					break;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_3FC:
			this.selectExpression(querySpecification);
			while (this.LA(1) == 198)
			{
				this.match(198);
				this.selectExpression(querySpecification);
			}
			int num3 = this.LA(1);
			if (num3 <= 92)
			{
				if (num3 <= 23)
				{
					if (num3 <= 6)
					{
						if (num3 == 1 || num3 == 6)
						{
							goto IL_739;
						}
					}
					else
					{
						switch (num3)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							goto IL_739;
						case 14:
						case 16:
							break;
						default:
							switch (num3)
							{
							case 22:
							case 23:
								goto IL_739;
							}
							break;
						}
					}
				}
				else if (num3 <= 35)
				{
					switch (num3)
					{
					case 28:
					case 29:
						goto IL_739;
					default:
						switch (num3)
						{
						case 33:
						case 35:
							goto IL_739;
						}
						break;
					}
				}
				else
				{
					switch (num3)
					{
					case 44:
					case 45:
					case 46:
					case 48:
					case 49:
					case 54:
					case 55:
					case 56:
					case 59:
					case 60:
					case 61:
					case 64:
					case 67:
					case 71:
					case 74:
					case 75:
					case 76:
					case 77:
						goto IL_739;
					case 47:
					case 50:
					case 51:
					case 52:
					case 53:
					case 57:
					case 58:
					case 62:
					case 63:
					case 65:
					case 66:
					case 68:
					case 69:
					case 70:
					case 72:
					case 73:
						break;
					default:
						switch (num3)
						{
						case 82:
						case 86:
						case 87:
							goto IL_739;
						case 83:
						case 84:
						case 85:
							break;
						case 88:
						{
							IToken token2 = this.LT(1);
							this.match(88);
							SchemaObjectName into = this.schemaObjectThreePartName();
							if (this.inputState.guessing == 0)
							{
								if (vSelectStatement == null)
								{
									TSql80ParserBaseInternal.ThrowIncorrectSyntaxErrorException(token2);
								}
								vSelectStatement.Into = into;
								goto IL_739;
							}
							goto IL_739;
						}
						default:
							if (num3 == 92)
							{
								goto IL_739;
							}
							break;
						}
						break;
					}
				}
			}
			else if (num3 <= 144)
			{
				if (num3 <= 106)
				{
					if (num3 == 95 || num3 == 106)
					{
						goto IL_739;
					}
				}
				else
				{
					switch (num3)
					{
					case 111:
					case 113:
						goto IL_739;
					case 112:
						break;
					default:
						if (num3 == 119)
						{
							goto IL_739;
						}
						switch (num3)
						{
						case 123:
						case 125:
						case 126:
						case 129:
						case 131:
						case 132:
						case 134:
						case 138:
						case 140:
						case 142:
						case 143:
						case 144:
							goto IL_739;
						}
						break;
					}
				}
			}
			else if (num3 <= 181)
			{
				switch (num3)
				{
				case 156:
				case 158:
				case 160:
				case 161:
				case 162:
				case 167:
				case 169:
				case 170:
				case 172:
				case 173:
				case 176:
					goto IL_739;
				case 157:
				case 159:
				case 163:
				case 164:
				case 165:
				case 166:
				case 168:
				case 171:
				case 174:
				case 175:
					break;
				default:
					switch (num3)
					{
					case 180:
					case 181:
						goto IL_739;
					}
					break;
				}
			}
			else
			{
				switch (num3)
				{
				case 191:
				case 192:
					goto IL_739;
				default:
					if (num3 == 204)
					{
						goto IL_739;
					}
					switch (num3)
					{
					case 219:
					case 220:
						goto IL_739;
					}
					break;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_739:
			FromClause fromClause = this.fromClauseOpt();
			if (this.inputState.guessing == 0)
			{
				querySpecification.FromClause = fromClause;
			}
			int num4 = this.LA(1);
			if (num4 <= 92)
			{
				if (num4 <= 29)
				{
					if (num4 <= 6)
					{
						if (num4 == 1 || num4 == 6)
						{
							goto IL_A46;
						}
					}
					else
					{
						switch (num4)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							goto IL_A46;
						case 14:
						case 16:
							break;
						default:
							switch (num4)
							{
							case 22:
							case 23:
								goto IL_A46;
							default:
								switch (num4)
								{
								case 28:
								case 29:
									goto IL_A46;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num4 <= 67)
				{
					switch (num4)
					{
					case 33:
					case 35:
						goto IL_A46;
					case 34:
						break;
					default:
						switch (num4)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 59:
						case 60:
						case 61:
						case 64:
						case 67:
							goto IL_A46;
						}
						break;
					}
				}
				else
				{
					switch (num4)
					{
					case 74:
					case 75:
					case 76:
					case 77:
					case 82:
						goto IL_A46;
					case 78:
					case 79:
					case 80:
					case 81:
						break;
					default:
						switch (num4)
						{
						case 86:
						case 87:
							goto IL_A46;
						default:
							if (num4 == 92)
							{
								goto IL_A46;
							}
							break;
						}
						break;
					}
				}
			}
			else if (num4 <= 144)
			{
				if (num4 <= 106)
				{
					if (num4 == 95 || num4 == 106)
					{
						goto IL_A46;
					}
				}
				else
				{
					switch (num4)
					{
					case 111:
					case 113:
						goto IL_A46;
					case 112:
						break;
					default:
						if (num4 == 119)
						{
							goto IL_A46;
						}
						switch (num4)
						{
						case 123:
						case 125:
						case 126:
						case 129:
						case 131:
						case 132:
						case 134:
						case 138:
						case 140:
						case 142:
						case 143:
						case 144:
							goto IL_A46;
						}
						break;
					}
				}
			}
			else if (num4 <= 181)
			{
				switch (num4)
				{
				case 156:
				case 158:
				case 160:
				case 161:
				case 162:
				case 167:
				case 170:
				case 172:
				case 173:
				case 176:
					goto IL_A46;
				case 157:
				case 159:
				case 163:
				case 164:
				case 165:
				case 166:
				case 168:
				case 171:
				case 174:
				case 175:
					break;
				case 169:
				{
					WhereClause whereClause = this.whereClause();
					if (this.inputState.guessing == 0)
					{
						querySpecification.WhereClause = whereClause;
						goto IL_A46;
					}
					goto IL_A46;
				}
				default:
					switch (num4)
					{
					case 180:
					case 181:
						goto IL_A46;
					}
					break;
				}
			}
			else
			{
				switch (num4)
				{
				case 191:
				case 192:
					goto IL_A46;
				default:
					if (num4 == 204)
					{
						goto IL_A46;
					}
					switch (num4)
					{
					case 219:
					case 220:
						goto IL_A46;
					}
					break;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_A46:
			int num5 = this.LA(1);
			if (num5 <= 95)
			{
				if (num5 <= 29)
				{
					if (num5 <= 6)
					{
						if (num5 == 1 || num5 == 6)
						{
							goto IL_D30;
						}
					}
					else
					{
						switch (num5)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							goto IL_D30;
						case 14:
						case 16:
							break;
						default:
							switch (num5)
							{
							case 22:
							case 23:
								goto IL_D30;
							default:
								switch (num5)
								{
								case 28:
								case 29:
									goto IL_D30;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num5 <= 82)
				{
					switch (num5)
					{
					case 33:
					case 35:
						goto IL_D30;
					case 34:
						break;
					default:
						switch (num5)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 59:
						case 60:
						case 61:
						case 64:
						case 67:
							goto IL_D30;
						case 47:
						case 50:
						case 51:
						case 52:
						case 53:
						case 57:
						case 58:
						case 62:
						case 63:
						case 65:
						case 66:
							break;
						default:
							switch (num5)
							{
							case 74:
							case 75:
							case 77:
							case 82:
								goto IL_D30;
							case 76:
							{
								GroupByClause groupByClause = this.groupByClause();
								if (this.inputState.guessing == 0)
								{
									querySpecification.GroupByClause = groupByClause;
									goto IL_D30;
								}
								goto IL_D30;
							}
							}
							break;
						}
						break;
					}
				}
				else
				{
					switch (num5)
					{
					case 86:
					case 87:
						goto IL_D30;
					default:
						if (num5 == 92 || num5 == 95)
						{
							goto IL_D30;
						}
						break;
					}
				}
			}
			else if (num5 <= 162)
			{
				if (num5 <= 113)
				{
					if (num5 == 106)
					{
						goto IL_D30;
					}
					switch (num5)
					{
					case 111:
					case 113:
						goto IL_D30;
					}
				}
				else
				{
					if (num5 == 119)
					{
						goto IL_D30;
					}
					switch (num5)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						goto IL_D30;
					case 124:
					case 127:
					case 128:
					case 130:
					case 133:
					case 135:
					case 136:
					case 137:
					case 139:
					case 141:
						break;
					default:
						switch (num5)
						{
						case 156:
						case 158:
						case 160:
						case 161:
						case 162:
							goto IL_D30;
						}
						break;
					}
				}
			}
			else if (num5 <= 181)
			{
				switch (num5)
				{
				case 167:
				case 170:
				case 172:
				case 173:
					goto IL_D30;
				case 168:
				case 169:
				case 171:
					break;
				default:
					if (num5 == 176)
					{
						goto IL_D30;
					}
					switch (num5)
					{
					case 180:
					case 181:
						goto IL_D30;
					}
					break;
				}
			}
			else
			{
				switch (num5)
				{
				case 191:
				case 192:
					goto IL_D30;
				default:
					if (num5 == 204)
					{
						goto IL_D30;
					}
					switch (num5)
					{
					case 219:
					case 220:
						goto IL_D30;
					}
					break;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_D30:
			int num6 = this.LA(1);
			if (num6 <= 92)
			{
				if (num6 <= 29)
				{
					if (num6 <= 6)
					{
						if (num6 == 1 || num6 == 6)
						{
							return querySpecification;
						}
					}
					else
					{
						switch (num6)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							return querySpecification;
						case 14:
						case 16:
							break;
						default:
							switch (num6)
							{
							case 22:
							case 23:
								return querySpecification;
							default:
								switch (num6)
								{
								case 28:
								case 29:
									return querySpecification;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num6 <= 77)
				{
					switch (num6)
					{
					case 33:
					case 35:
						return querySpecification;
					case 34:
						break;
					default:
						switch (num6)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 59:
						case 60:
						case 61:
						case 64:
						case 67:
							return querySpecification;
						case 47:
						case 50:
						case 51:
						case 52:
						case 53:
						case 57:
						case 58:
						case 62:
						case 63:
						case 65:
						case 66:
							break;
						default:
							switch (num6)
							{
							case 74:
							case 75:
								return querySpecification;
							case 77:
							{
								HavingClause havingClause = this.havingClause();
								if (this.inputState.guessing == 0)
								{
									querySpecification.HavingClause = havingClause;
									return querySpecification;
								}
								return querySpecification;
							}
							}
							break;
						}
						break;
					}
				}
				else
				{
					if (num6 == 82)
					{
						return querySpecification;
					}
					switch (num6)
					{
					case 86:
					case 87:
						return querySpecification;
					default:
						if (num6 == 92)
						{
							return querySpecification;
						}
						break;
					}
				}
			}
			else if (num6 <= 162)
			{
				if (num6 <= 113)
				{
					if (num6 == 95 || num6 == 106)
					{
						return querySpecification;
					}
					switch (num6)
					{
					case 111:
					case 113:
						return querySpecification;
					}
				}
				else
				{
					if (num6 == 119)
					{
						return querySpecification;
					}
					switch (num6)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return querySpecification;
					case 124:
					case 127:
					case 128:
					case 130:
					case 133:
					case 135:
					case 136:
					case 137:
					case 139:
					case 141:
						break;
					default:
						switch (num6)
						{
						case 156:
						case 158:
						case 160:
						case 161:
						case 162:
							return querySpecification;
						}
						break;
					}
				}
			}
			else if (num6 <= 181)
			{
				switch (num6)
				{
				case 167:
				case 170:
				case 172:
				case 173:
					return querySpecification;
				case 168:
				case 169:
				case 171:
					break;
				default:
					if (num6 == 176)
					{
						return querySpecification;
					}
					switch (num6)
					{
					case 180:
					case 181:
						return querySpecification;
					}
					break;
				}
			}
			else
			{
				switch (num6)
				{
				case 191:
				case 192:
					return querySpecification;
				default:
					if (num6 == 204)
					{
						return querySpecification;
					}
					switch (num6)
					{
					case 219:
					case 220:
						return querySpecification;
					}
					break;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x00061F84 File Offset: 0x00060184
		public QueryParenthesisExpression queryParenthesis(SelectStatement vSelectStatement)
		{
			QueryParenthesisExpression queryParenthesisExpression = base.FragmentFactory.CreateFragment<QueryParenthesisExpression>();
			IToken token = this.LT(1);
			this.match(191);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(queryParenthesisExpression, token);
			}
			QueryExpression queryExpression = this.queryExpression(vSelectStatement);
			if (this.inputState.guessing == 0)
			{
				queryParenthesisExpression.QueryExpression = queryExpression;
			}
			IToken token2 = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(queryParenthesisExpression, token2);
			}
			return queryParenthesisExpression;
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x0006200C File Offset: 0x0006020C
		public UniqueRowFilter uniqueRowFilter()
		{
			UniqueRowFilter result = UniqueRowFilter.NotSpecified;
			int num = this.LA(1);
			if (num != 5)
			{
				if (num != 51)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				this.match(51);
				if (this.inputState.guessing == 0)
				{
					result = UniqueRowFilter.Distinct;
				}
			}
			else
			{
				this.match(5);
				if (this.inputState.guessing == 0)
				{
					result = UniqueRowFilter.All;
				}
			}
			return result;
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x00062074 File Offset: 0x00060274
		public TopRowFilter topRowFilter()
		{
			TopRowFilter topRowFilter = base.FragmentFactory.CreateFragment<TopRowFilter>();
			IToken token = this.LT(1);
			this.match(152);
			ScalarExpression scalarExpression = this.integerOrRealOrNumeric();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(topRowFilter, token);
				topRowFilter.Expression = scalarExpression;
			}
			int num = this.LA(1);
			if (num <= 116)
			{
				if (num <= 41)
				{
					if (num <= 25)
					{
						if (num == 20 || num == 25)
						{
							goto IL_249;
						}
					}
					else
					{
						if (num == 34)
						{
							goto IL_249;
						}
						switch (num)
						{
						case 40:
						case 41:
							goto IL_249;
						}
					}
				}
				else if (num <= 93)
				{
					switch (num)
					{
					case 79:
					case 81:
						goto IL_249;
					case 80:
						break;
					default:
						if (num == 93)
						{
							goto IL_249;
						}
						break;
					}
				}
				else
				{
					switch (num)
					{
					case 100:
					case 101:
						goto IL_249;
					default:
						if (num == 116)
						{
							IToken token2 = this.LT(1);
							this.match(116);
							if (this.inputState.guessing == 0)
							{
								TSql80ParserBaseInternal.ThrowIfPercentValueOutOfRange(scalarExpression);
								TSql80ParserBaseInternal.UpdateTokenInfo(topRowFilter, token2);
								topRowFilter.Percent = true;
								goto IL_249;
							}
							goto IL_249;
						}
						break;
					}
				}
			}
			else if (num <= 147)
			{
				if (num <= 136)
				{
					if (num == 133 || num == 136)
					{
						goto IL_249;
					}
				}
				else if (num == 141 || num == 147)
				{
					goto IL_249;
				}
			}
			else if (num <= 171)
			{
				if (num == 163 || num == 171)
				{
					goto IL_249;
				}
			}
			else
			{
				switch (num)
				{
				case 191:
				case 193:
				case 195:
				case 197:
				case 199:
				case 200:
					goto IL_249;
				case 192:
				case 194:
				case 196:
				case 198:
					break;
				default:
					switch (num)
					{
					case 211:
					case 221:
					case 222:
					case 223:
					case 224:
					case 225:
					case 227:
					case 228:
					case 230:
					case 231:
					case 232:
					case 233:
					case 234:
					case 235:
						goto IL_249;
					}
					break;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_249:
			int num2 = this.LA(1);
			if (num2 <= 101)
			{
				if (num2 <= 34)
				{
					if (num2 == 20 || num2 == 25 || num2 == 34)
					{
						return topRowFilter;
					}
				}
				else if (num2 <= 81)
				{
					switch (num2)
					{
					case 40:
					case 41:
						return topRowFilter;
					default:
						switch (num2)
						{
						case 79:
						case 81:
							return topRowFilter;
						}
						break;
					}
				}
				else
				{
					if (num2 == 93)
					{
						return topRowFilter;
					}
					switch (num2)
					{
					case 100:
					case 101:
						return topRowFilter;
					}
				}
			}
			else if (num2 <= 147)
			{
				if (num2 <= 136)
				{
					if (num2 == 133 || num2 == 136)
					{
						return topRowFilter;
					}
				}
				else if (num2 == 141 || num2 == 147)
				{
					return topRowFilter;
				}
			}
			else if (num2 <= 171)
			{
				if (num2 == 163)
				{
					return topRowFilter;
				}
				if (num2 == 171)
				{
					this.match(171);
					IToken token3 = this.LT(1);
					this.match(232);
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.Match(token3, "TIES");
						TSql80ParserBaseInternal.UpdateTokenInfo(topRowFilter, token3);
						topRowFilter.WithTies = true;
						return topRowFilter;
					}
					return topRowFilter;
				}
			}
			else
			{
				switch (num2)
				{
				case 191:
				case 193:
				case 195:
				case 197:
				case 199:
				case 200:
					return topRowFilter;
				case 192:
				case 194:
				case 196:
				case 198:
					break;
				default:
					switch (num2)
					{
					case 211:
					case 221:
					case 222:
					case 223:
					case 224:
					case 225:
					case 227:
					case 228:
					case 230:
					case 231:
					case 232:
					case 233:
					case 234:
					case 235:
						return topRowFilter;
					}
					break;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x000624C8 File Offset: 0x000606C8
		public SelectElement selectColumnOrStarExpression()
		{
			bool flag = false;
			if (TSql80ParserInternal.tokenSet_35_.member(this.LA(1)) && TSql80ParserInternal.tokenSet_36_.member(this.LA(2)))
			{
				int pos = this.mark();
				flag = true;
				this.inputState.guessing++;
				try
				{
					this.selectStarExpression();
				}
				catch (RecognitionException)
				{
					flag = false;
				}
				this.rewind(pos);
				this.inputState.guessing--;
			}
			SelectElement result;
			if (flag)
			{
				result = this.selectStarExpression();
			}
			else
			{
				if (!TSql80ParserInternal.tokenSet_37_.member(this.LA(1)) || !TSql80ParserInternal.tokenSet_38_.member(this.LA(2)))
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				result = this.selectColumn();
			}
			return result;
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x000625A0 File Offset: 0x000607A0
		public FromClause fromClauseOpt()
		{
			FromClause result = null;
			int num = this.LA(1);
			if (num <= 87)
			{
				if (num <= 23)
				{
					if (num <= 6)
					{
						if (num == 1 || num == 6)
						{
							return result;
						}
					}
					else
					{
						switch (num)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							return result;
						case 14:
						case 16:
							break;
						default:
							switch (num)
							{
							case 22:
							case 23:
								return result;
							}
							break;
						}
					}
				}
				else if (num <= 35)
				{
					switch (num)
					{
					case 28:
					case 29:
						return result;
					default:
						switch (num)
						{
						case 33:
						case 35:
							return result;
						}
						break;
					}
				}
				else
				{
					switch (num)
					{
					case 44:
					case 45:
					case 46:
					case 48:
					case 49:
					case 54:
					case 55:
					case 56:
					case 59:
					case 60:
					case 61:
					case 64:
					case 67:
					case 74:
					case 75:
					case 76:
					case 77:
						return result;
					case 47:
					case 50:
					case 51:
					case 52:
					case 53:
					case 57:
					case 58:
					case 62:
					case 63:
					case 65:
					case 66:
					case 68:
					case 69:
					case 70:
					case 72:
					case 73:
						break;
					case 71:
						return this.fromClause();
					default:
						if (num == 82)
						{
							return result;
						}
						switch (num)
						{
						case 86:
						case 87:
							return result;
						}
						break;
					}
				}
			}
			else if (num <= 119)
			{
				if (num <= 95)
				{
					if (num == 92 || num == 95)
					{
						return result;
					}
				}
				else
				{
					if (num == 106)
					{
						return result;
					}
					switch (num)
					{
					case 111:
					case 113:
						return result;
					case 112:
						break;
					default:
						if (num == 119)
						{
							return result;
						}
						break;
					}
				}
			}
			else if (num <= 181)
			{
				switch (num)
				{
				case 123:
				case 125:
				case 126:
				case 129:
				case 131:
				case 132:
				case 134:
				case 138:
				case 140:
				case 142:
				case 143:
				case 144:
					return result;
				case 124:
				case 127:
				case 128:
				case 130:
				case 133:
				case 135:
				case 136:
				case 137:
				case 139:
				case 141:
					break;
				default:
					switch (num)
					{
					case 156:
					case 158:
					case 160:
					case 161:
					case 162:
					case 167:
					case 169:
					case 170:
					case 171:
					case 172:
					case 173:
					case 176:
					case 180:
					case 181:
						return result;
					}
					break;
				}
			}
			else
			{
				switch (num)
				{
				case 191:
				case 192:
					return result;
				default:
					if (num == 204)
					{
						return result;
					}
					switch (num)
					{
					case 219:
					case 220:
						return result;
					}
					break;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x0006286C File Offset: 0x00060A6C
		public WhereClause whereClause()
		{
			WhereClause whereClause = base.FragmentFactory.CreateFragment<WhereClause>();
			IToken token = this.LT(1);
			this.match(169);
			BooleanExpression searchCondition = this.booleanExpression();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(whereClause, token);
				whereClause.SearchCondition = searchCondition;
			}
			return whereClause;
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x000628C0 File Offset: 0x00060AC0
		public GroupByClause groupByClause()
		{
			GroupByClause groupByClause = base.FragmentFactory.CreateFragment<GroupByClause>();
			IToken token = this.LT(1);
			this.match(76);
			this.match(18);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(groupByClause, token);
			}
			int num = this.LA(1);
			if (num <= 101)
			{
				if (num <= 34)
				{
					if (num <= 20)
					{
						if (num != 5)
						{
							if (num == 20)
							{
								goto IL_209;
							}
						}
						else
						{
							this.match(5);
							if (this.inputState.guessing == 0)
							{
								groupByClause.All = true;
								goto IL_209;
							}
							goto IL_209;
						}
					}
					else if (num == 25 || num == 34)
					{
						goto IL_209;
					}
				}
				else if (num <= 81)
				{
					switch (num)
					{
					case 40:
					case 41:
						goto IL_209;
					default:
						if (num == 81)
						{
							goto IL_209;
						}
						break;
					}
				}
				else
				{
					if (num == 93)
					{
						goto IL_209;
					}
					switch (num)
					{
					case 100:
					case 101:
						goto IL_209;
					}
				}
			}
			else if (num <= 147)
			{
				if (num <= 136)
				{
					if (num == 133 || num == 136)
					{
						goto IL_209;
					}
				}
				else if (num == 141 || num == 147)
				{
					goto IL_209;
				}
			}
			else if (num <= 193)
			{
				if (num == 163)
				{
					goto IL_209;
				}
				switch (num)
				{
				case 191:
				case 193:
					goto IL_209;
				}
			}
			else
			{
				switch (num)
				{
				case 197:
				case 199:
				case 200:
					goto IL_209;
				case 198:
					break;
				default:
					switch (num)
					{
					case 211:
					case 221:
					case 222:
					case 223:
					case 224:
					case 225:
					case 227:
					case 228:
					case 230:
					case 231:
					case 232:
					case 233:
					case 234:
					case 235:
						goto IL_209;
					}
					break;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_209:
			ExpressionGroupingSpecification item = this.simpleGroupByItem();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<GroupingSpecification>(groupByClause, groupByClause.GroupingSpecifications, item);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				item = this.simpleGroupByItem();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<GroupingSpecification>(groupByClause, groupByClause.GroupingSpecifications, item);
				}
			}
			bool flag = false;
			if (this.LA(1) == 171 && this.LA(2) == 232)
			{
				int pos = this.mark();
				flag = true;
				this.inputState.guessing++;
				try
				{
					this.match(171);
					this.match(232);
				}
				catch (RecognitionException)
				{
					flag = false;
				}
				this.rewind(pos);
				this.inputState.guessing--;
			}
			if (flag)
			{
				this.match(171);
				IToken token2 = this.LT(1);
				this.match(232);
				if (this.inputState.guessing == 0)
				{
					if (groupByClause.All)
					{
						TSql80ParserBaseInternal.ThrowParseErrorException("SQL46084", token2, TSqlParserResource.SQL46084Message, new string[0]);
					}
					TSql80ParserBaseInternal.UpdateTokenInfo(groupByClause, token2);
					groupByClause.GroupByOption = GroupByOptionHelper.Instance.ParseOption(token2);
				}
			}
			else if (!TSql80ParserInternal.tokenSet_39_.member(this.LA(1)) || !TSql80ParserInternal.tokenSet_40_.member(this.LA(2)))
			{
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			return groupByClause;
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x00062C5C File Offset: 0x00060E5C
		public HavingClause havingClause()
		{
			HavingClause havingClause = base.FragmentFactory.CreateFragment<HavingClause>();
			IToken token = this.LT(1);
			this.match(77);
			BooleanExpression searchCondition = this.booleanExpression();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(havingClause, token);
				havingClause.SearchCondition = searchCondition;
			}
			return havingClause;
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x00062CAC File Offset: 0x00060EAC
		public BrowseForClause browseForClause()
		{
			BrowseForClause browseForClause = base.FragmentFactory.CreateFragment<BrowseForClause>();
			IToken token = this.LT(1);
			this.match(16);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(browseForClause, token);
			}
			return browseForClause;
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x00062CEC File Offset: 0x00060EEC
		public void selectExpression(QuerySpecification vParent)
		{
			bool flag = false;
			if (this.LA(1) == 234 && this.LA(2) == 206)
			{
				int pos = this.mark();
				flag = true;
				this.inputState.guessing++;
				try
				{
					this.match(234);
					this.match(206);
				}
				catch (RecognitionException)
				{
					flag = false;
				}
				this.rewind(pos);
				this.inputState.guessing--;
			}
			if (flag)
			{
				SelectSetVariable item = this.selectSetVariable();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<SelectElement>(vParent, vParent.SelectElements, item);
					return;
				}
			}
			else
			{
				bool flag2 = false;
				if (TSql80ParserInternal.tokenSet_35_.member(this.LA(1)) && TSql80ParserInternal.tokenSet_41_.member(this.LA(2)))
				{
					int pos2 = this.mark();
					flag2 = true;
					this.inputState.guessing++;
					try
					{
						this.selectStarExpression();
					}
					catch (RecognitionException)
					{
						flag2 = false;
					}
					this.rewind(pos2);
					this.inputState.guessing--;
				}
				if (flag2)
				{
					SelectStarExpression item2 = this.selectStarExpression();
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.AddAndUpdateTokenInfo<SelectElement>(vParent, vParent.SelectElements, item2);
						return;
					}
				}
				else
				{
					if (!TSql80ParserInternal.tokenSet_37_.member(this.LA(1)) || !TSql80ParserInternal.tokenSet_42_.member(this.LA(2)))
					{
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
					SelectScalarExpression item3 = this.selectColumn();
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.AddAndUpdateTokenInfo<SelectElement>(vParent, vParent.SelectElements, item3);
						return;
					}
				}
			}
		}

		// Token: 0x06001348 RID: 4936 RVA: 0x00062EA4 File Offset: 0x000610A4
		public Literal integerOrRealOrNumeric()
		{
			Literal result;
			switch (this.LA(1))
			{
			case 221:
				result = this.integer();
				break;
			case 222:
				result = this.numeric();
				break;
			case 223:
				result = this.real();
				break;
			default:
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			return result;
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x00062F04 File Offset: 0x00061104
		public SelectSetVariable selectSetVariable()
		{
			SelectSetVariable selectSetVariable = base.FragmentFactory.CreateFragment<SelectSetVariable>();
			VariableReference variable = this.variable();
			this.match(206);
			ScalarExpression expression = this.expression();
			if (this.inputState.guessing == 0)
			{
				selectSetVariable.Variable = variable;
				selectSetVariable.Expression = expression;
			}
			return selectSetVariable;
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x00062F54 File Offset: 0x00061154
		public SelectStarExpression selectStarExpression()
		{
			SelectStarExpression selectStarExpression = base.FragmentFactory.CreateFragment<SelectStarExpression>();
			int num = this.LA(1);
			if (num != 195)
			{
				if (num != 200)
				{
					switch (num)
					{
					case 232:
					case 233:
						break;
					default:
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
				}
				MultiPartIdentifier qualifier = this.multiPartIdentifier(-1);
				if (this.inputState.guessing == 0)
				{
					selectStarExpression.Qualifier = qualifier;
				}
				this.match(200);
				IToken token = this.LT(1);
				this.match(195);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(selectStarExpression, token);
				}
			}
			else
			{
				IToken token2 = this.LT(1);
				this.match(195);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(selectStarExpression, token2);
				}
			}
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.CheckStarQualifier(selectStarExpression);
			}
			return selectStarExpression;
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x00063044 File Offset: 0x00061244
		public SelectScalarExpression selectColumn()
		{
			SelectScalarExpression selectScalarExpression = base.FragmentFactory.CreateFragment<SelectScalarExpression>();
			ScalarExpression expression;
			IdentifierOrValueExpression columnName;
			if (TSql80ParserInternal.tokenSet_37_.member(this.LA(1)) && TSql80ParserInternal.tokenSet_43_.member(this.LA(2)))
			{
				expression = this.selectColumnExpression();
				if (this.inputState.guessing == 0)
				{
					selectScalarExpression.Expression = expression;
				}
				int num = this.LA(1);
				if (num <= 95)
				{
					if (num <= 29)
					{
						if (num <= 6)
						{
							if (num != 1 && num != 6)
							{
								goto IL_3AB;
							}
							return selectScalarExpression;
						}
						else
						{
							switch (num)
							{
							case 9:
								break;
							case 10:
							case 11:
							case 14:
							case 16:
								goto IL_3AB;
							case 12:
							case 13:
							case 15:
							case 17:
								return selectScalarExpression;
							default:
								switch (num)
								{
								case 22:
								case 23:
									return selectScalarExpression;
								default:
									switch (num)
									{
									case 28:
									case 29:
										return selectScalarExpression;
									default:
										goto IL_3AB;
									}
									break;
								}
								break;
							}
						}
					}
					else if (num <= 77)
					{
						switch (num)
						{
						case 33:
						case 35:
							return selectScalarExpression;
						case 34:
							goto IL_3AB;
						default:
							switch (num)
							{
							case 44:
							case 45:
							case 46:
							case 48:
							case 49:
							case 54:
							case 55:
							case 56:
							case 59:
							case 60:
							case 61:
							case 64:
							case 67:
							case 71:
							case 74:
							case 75:
							case 76:
							case 77:
								return selectScalarExpression;
							case 47:
							case 50:
							case 51:
							case 52:
							case 53:
							case 57:
							case 58:
							case 62:
							case 63:
							case 65:
							case 66:
							case 68:
							case 69:
							case 70:
							case 72:
							case 73:
								goto IL_3AB;
							default:
								goto IL_3AB;
							}
							break;
						}
					}
					else
					{
						switch (num)
						{
						case 82:
						case 86:
						case 87:
						case 88:
							return selectScalarExpression;
						case 83:
						case 84:
						case 85:
							goto IL_3AB;
						default:
							if (num != 92 && num != 95)
							{
								goto IL_3AB;
							}
							return selectScalarExpression;
						}
					}
				}
				else if (num <= 181)
				{
					if (num <= 113)
					{
						if (num == 106)
						{
							return selectScalarExpression;
						}
						switch (num)
						{
						case 111:
						case 113:
							return selectScalarExpression;
						case 112:
							goto IL_3AB;
						default:
							goto IL_3AB;
						}
					}
					else
					{
						if (num == 119)
						{
							return selectScalarExpression;
						}
						switch (num)
						{
						case 123:
						case 125:
						case 126:
						case 129:
						case 131:
						case 132:
						case 134:
						case 138:
						case 140:
						case 142:
						case 143:
						case 144:
							return selectScalarExpression;
						case 124:
						case 127:
						case 128:
						case 130:
						case 133:
						case 135:
						case 136:
						case 137:
						case 139:
						case 141:
							goto IL_3AB;
						default:
							switch (num)
							{
							case 156:
							case 158:
							case 160:
							case 161:
							case 162:
							case 167:
							case 169:
							case 170:
							case 171:
							case 172:
							case 173:
							case 176:
							case 180:
							case 181:
								return selectScalarExpression;
							case 157:
							case 159:
							case 163:
							case 164:
							case 165:
							case 166:
							case 168:
							case 174:
							case 175:
							case 177:
							case 178:
							case 179:
								goto IL_3AB;
							default:
								goto IL_3AB;
							}
							break;
						}
					}
				}
				else if (num <= 198)
				{
					switch (num)
					{
					case 191:
					case 192:
						return selectScalarExpression;
					default:
						if (num != 198)
						{
							goto IL_3AB;
						}
						return selectScalarExpression;
					}
				}
				else
				{
					if (num == 204)
					{
						return selectScalarExpression;
					}
					switch (num)
					{
					case 219:
					case 220:
						return selectScalarExpression;
					default:
						switch (num)
						{
						case 230:
						case 231:
						case 232:
						case 233:
							break;
						default:
							goto IL_3AB;
						}
						break;
					}
				}
				int num2 = this.LA(1);
				if (num2 != 9)
				{
					switch (num2)
					{
					case 230:
					case 231:
					case 232:
					case 233:
						break;
					default:
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
				}
				else
				{
					this.match(9);
				}
				columnName = this.stringOrIdentifier();
				if (this.inputState.guessing == 0)
				{
					selectScalarExpression.ColumnName = columnName;
					return selectScalarExpression;
				}
				return selectScalarExpression;
				IL_3AB:
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			if (this.LA(1) < 230 || this.LA(1) > 233 || this.LA(2) != 206)
			{
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			columnName = this.stringOrIdentifier();
			if (this.inputState.guessing == 0)
			{
				selectScalarExpression.ColumnName = columnName;
			}
			this.match(206);
			expression = this.selectColumnExpression();
			if (this.inputState.guessing == 0)
			{
				selectScalarExpression.Expression = expression;
			}
			return selectScalarExpression;
		}

		// Token: 0x0600134C RID: 4940 RVA: 0x00063490 File Offset: 0x00061690
		public ScalarExpression selectColumnExpression()
		{
			int num = this.LA(1);
			if (num <= 101)
			{
				if (num <= 34)
				{
					if (num != 20 && num != 25 && num != 34)
					{
						goto IL_195;
					}
				}
				else if (num <= 81)
				{
					switch (num)
					{
					case 40:
					case 41:
						break;
					default:
						switch (num)
						{
						case 79:
							return this.identityFunction();
						case 80:
							goto IL_195;
						case 81:
							break;
						default:
							goto IL_195;
						}
						break;
					}
				}
				else if (num != 93)
				{
					switch (num)
					{
					case 100:
					case 101:
						break;
					default:
						goto IL_195;
					}
				}
			}
			else if (num <= 147)
			{
				if (num <= 136)
				{
					if (num != 133 && num != 136)
					{
						goto IL_195;
					}
				}
				else if (num != 141 && num != 147)
				{
					goto IL_195;
				}
			}
			else if (num <= 193)
			{
				if (num != 163)
				{
					switch (num)
					{
					case 191:
					case 193:
						break;
					case 192:
						goto IL_195;
					default:
						goto IL_195;
					}
				}
			}
			else
			{
				switch (num)
				{
				case 197:
				case 199:
				case 200:
					break;
				case 198:
					goto IL_195;
				default:
					switch (num)
					{
					case 211:
					case 221:
					case 222:
					case 223:
					case 224:
					case 225:
					case 227:
					case 228:
					case 230:
					case 231:
					case 232:
					case 233:
					case 234:
					case 235:
						break;
					case 212:
					case 213:
					case 214:
					case 215:
					case 216:
					case 217:
					case 218:
					case 219:
					case 220:
					case 226:
					case 229:
						goto IL_195;
					default:
						goto IL_195;
					}
					break;
				}
			}
			return this.expression();
			IL_195:
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x0600134D RID: 4941 RVA: 0x00063648 File Offset: 0x00061848
		public MultiPartIdentifier multiPartIdentifier(int vMaxNumber)
		{
			MultiPartIdentifier multiPartIdentifier = base.FragmentFactory.CreateFragment<MultiPartIdentifier>();
			List<Identifier> otherCollection = this.identifierList(vMaxNumber);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<Identifier>(multiPartIdentifier, multiPartIdentifier.Identifiers, otherCollection);
			}
			return multiPartIdentifier;
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x00063684 File Offset: 0x00061884
		public IdentityFunctionCall identityFunction()
		{
			IdentityFunctionCall identityFunctionCall = base.FragmentFactory.CreateFragment<IdentityFunctionCall>();
			IToken token = this.LT(1);
			this.match(79);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(identityFunctionCall, token);
			}
			this.match(191);
			DataTypeReference dataType = this.scalarDataType();
			if (this.inputState.guessing == 0)
			{
				identityFunctionCall.DataType = dataType;
			}
			int num = this.LA(1);
			if (num != 192)
			{
				if (num != 198)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				this.match(198);
				ScalarExpression scalarExpression = this.seedIncrement();
				if (this.inputState.guessing == 0)
				{
					identityFunctionCall.Seed = scalarExpression;
				}
				this.match(198);
				scalarExpression = this.seedIncrement();
				if (this.inputState.guessing == 0)
				{
					identityFunctionCall.Increment = scalarExpression;
				}
			}
			IToken token2 = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(identityFunctionCall, token2);
			}
			return identityFunctionCall;
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x00063794 File Offset: 0x00061994
		public ScalarExpression seedIncrement()
		{
			ScalarExpression result = null;
			UnaryExpression unaryExpression = null;
			int num = this.LA(1);
			switch (num)
			{
			case 197:
			{
				IToken token = this.LT(1);
				this.match(197);
				if (this.inputState.guessing == 0)
				{
					unaryExpression = base.FragmentFactory.CreateFragment<UnaryExpression>();
					TSql80ParserBaseInternal.UpdateTokenInfo(unaryExpression, token);
					unaryExpression.UnaryExpressionType = UnaryExpressionType.Positive;
					goto IL_D3;
				}
				goto IL_D3;
			}
			case 198:
				break;
			case 199:
			{
				IToken token2 = this.LT(1);
				this.match(199);
				if (this.inputState.guessing == 0)
				{
					unaryExpression = base.FragmentFactory.CreateFragment<UnaryExpression>();
					TSql80ParserBaseInternal.UpdateTokenInfo(unaryExpression, token2);
					unaryExpression.UnaryExpressionType = UnaryExpressionType.Negative;
					goto IL_D3;
				}
				goto IL_D3;
			}
			default:
				switch (num)
				{
				case 221:
				case 222:
					goto IL_D3;
				}
				break;
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_D3:
			Literal literal = this.integerOrNumeric();
			if (this.inputState.guessing == 0)
			{
				if (unaryExpression != null)
				{
					unaryExpression.Expression = literal;
					result = unaryExpression;
				}
				else
				{
					result = literal;
				}
			}
			return result;
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x0006389C File Offset: 0x00061A9C
		public FromClause fromClause()
		{
			FromClause fromClause = base.FragmentFactory.CreateFragment<FromClause>();
			IToken token = this.LT(1);
			this.match(71);
			TableReference item = this.selectTableReferenceWithOdbc();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(fromClause, token);
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<TableReference>(fromClause, fromClause.TableReferences, item);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				item = this.selectTableReferenceWithOdbc();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<TableReference>(fromClause, fromClause.TableReferences, item);
				}
			}
			return fromClause;
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x0006392C File Offset: 0x00061B2C
		public TableReference selectTableReferenceWithOdbc()
		{
			int num = this.LA(1);
			if (num > 110)
			{
				if (num <= 200)
				{
					switch (num)
					{
					case 191:
						goto IL_84;
					case 192:
						goto IL_96;
					case 193:
						break;
					default:
						if (num != 200)
						{
							goto IL_96;
						}
						goto IL_84;
					}
				}
				else
				{
					if (num == 203)
					{
						goto IL_84;
					}
					switch (num)
					{
					case 232:
					case 233:
					case 234:
						goto IL_84;
					case 235:
						break;
					default:
						goto IL_96;
					}
				}
				return this.odbcQualifiedJoin();
			}
			if (num != 32 && num != 70)
			{
				switch (num)
				{
				case 107:
				case 108:
				case 109:
				case 110:
					break;
				default:
					goto IL_96;
				}
			}
			IL_84:
			return this.selectTableReference();
			IL_96:
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x000639E4 File Offset: 0x00061BE4
		public TableReference selectTableReference()
		{
			TableReference result = null;
			result = this.selectTableReferenceElement();
			while (TSql80ParserInternal.tokenSet_44_.member(this.LA(1)))
			{
				this.joinElement(ref result);
			}
			return result;
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x00063A18 File Offset: 0x00061C18
		public OdbcQualifiedJoinTableReference odbcQualifiedJoin()
		{
			OdbcQualifiedJoinTableReference odbcQualifiedJoinTableReference = base.FragmentFactory.CreateFragment<OdbcQualifiedJoinTableReference>();
			IToken token = null;
			int num = this.LA(1);
			if (num != 193)
			{
				if (num != 235)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				this.odbcInitiator();
			}
			else
			{
				token = this.LT(1);
				this.match(193);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(odbcQualifiedJoinTableReference, token);
				}
			}
			IToken token2 = this.LT(1);
			this.match(232);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.Match(token2, "OJ");
			}
			int num2 = this.LA(1);
			TableReference tableReference;
			if (num2 > 110)
			{
				if (num2 <= 200)
				{
					switch (num2)
					{
					case 191:
						goto IL_13A;
					case 192:
						goto IL_170;
					case 193:
						break;
					default:
						if (num2 != 200)
						{
							goto IL_170;
						}
						goto IL_13A;
					}
				}
				else
				{
					if (num2 == 203)
					{
						goto IL_13A;
					}
					switch (num2)
					{
					case 232:
					case 233:
					case 234:
						goto IL_13A;
					case 235:
						break;
					default:
						goto IL_170;
					}
				}
				tableReference = this.odbcQualifiedJoin();
				goto IL_183;
			}
			if (num2 != 32 && num2 != 70)
			{
				switch (num2)
				{
				case 107:
				case 108:
				case 109:
				case 110:
					break;
				default:
					goto IL_170;
				}
			}
			IL_13A:
			tableReference = this.selectTableReference();
			if (this.inputState.guessing == 0 && !(tableReference is QualifiedJoin))
			{
				TSql80ParserBaseInternal.ThrowParseErrorException("SQL46035", token, TSqlParserResource.SQL46035Message, new string[0]);
				goto IL_183;
			}
			goto IL_183;
			IL_170:
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_183:
			if (this.inputState.guessing == 0)
			{
				odbcQualifiedJoinTableReference.TableReference = tableReference;
			}
			IToken token3 = this.LT(1);
			this.match(194);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(odbcQualifiedJoinTableReference, token3);
			}
			return odbcQualifiedJoinTableReference;
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x00063BE8 File Offset: 0x00061DE8
		public TableReference selectTableReferenceElement()
		{
			bool flag = false;
			if (this.LA(1) == 191 && TSql80ParserInternal.tokenSet_45_.member(this.LA(2)))
			{
				int pos = this.mark();
				flag = true;
				this.inputState.guessing++;
				try
				{
					this.joinParenthesis();
				}
				catch (RecognitionException)
				{
					flag = false;
				}
				this.rewind(pos);
				this.inputState.guessing--;
			}
			TableReference result;
			if (flag)
			{
				result = this.joinParenthesis();
			}
			else
			{
				if (!TSql80ParserInternal.tokenSet_45_.member(this.LA(1)) || !TSql80ParserInternal.tokenSet_46_.member(this.LA(2)))
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				result = this.selectTableReferenceElementWithOutJoinParenthesis();
			}
			return result;
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x00063CC0 File Offset: 0x00061EC0
		public void joinElement(ref TableReference vResult)
		{
			int num = this.LA(1);
			if (num <= 85)
			{
				if (num != 36)
				{
					if (num != 72 && num != 85)
					{
						goto IL_4E;
					}
					goto IL_46;
				}
			}
			else if (num <= 93)
			{
				if (num != 90 && num != 93)
				{
					goto IL_4E;
				}
				goto IL_46;
			}
			else if (num != 114)
			{
				if (num != 133)
				{
					goto IL_4E;
				}
				goto IL_46;
			}
			this.unqualifiedJoin(ref vResult);
			return;
			IL_46:
			this.qualifiedJoin(ref vResult);
			return;
			IL_4E:
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x00063D30 File Offset: 0x00061F30
		public void odbcInitiator()
		{
			IToken token = this.LT(1);
			this.match(235);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.ThrowParseErrorException("SQL46036", token, TSqlParserResource.SQL46036Message, new string[0]);
			}
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x00063D78 File Offset: 0x00061F78
		public OdbcConvertSpecification odbcConvertSpecification()
		{
			OdbcConvertSpecification odbcConvertSpecification = base.FragmentFactory.CreateFragment<OdbcConvertSpecification>();
			Identifier identifier = this.nonQuotedIdentifier();
			if (this.inputState.guessing == 0)
			{
				odbcConvertSpecification.Identifier = identifier;
			}
			return odbcConvertSpecification;
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x00063DB0 File Offset: 0x00061FB0
		public ExtractFromExpression extractFromExpression()
		{
			ExtractFromExpression extractFromExpression = base.FragmentFactory.CreateFragment<ExtractFromExpression>();
			IToken token = this.LT(1);
			this.match(232);
			this.match(191);
			Identifier extractedElement = this.identifier();
			this.match(71);
			ScalarExpression expression = this.expression();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.Match(token, "EXTRACT");
				extractFromExpression.Expression = expression;
				extractFromExpression.ExtractedElement = extractedElement;
			}
			this.match(192);
			return extractFromExpression;
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x00063E34 File Offset: 0x00062034
		public OdbcFunctionCall odbcFunctionCall()
		{
			OdbcFunctionCall odbcFunctionCall = base.FragmentFactory.CreateFragment<OdbcFunctionCall>();
			Identifier identifier = base.FragmentFactory.CreateFragment<Identifier>();
			odbcFunctionCall.ParametersUsed = true;
			IToken token = this.LT(1);
			this.match(193);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(odbcFunctionCall, token);
			}
			IToken token2 = this.LT(1);
			this.match(232);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.Match(token2, "FN");
			}
			if (this.inputState.guessing == 0 && this.LA(1) != 1)
			{
				identifier.SetUnquotedIdentifier(this.LT(1).getText());
				odbcFunctionCall.Name = identifier;
			}
			int num = this.LA(1);
			if (num <= 86)
			{
				switch (num)
				{
				case 34:
				{
					this.match(34);
					this.match(191);
					ScalarExpression item = this.expression();
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ScalarExpression>(odbcFunctionCall, odbcFunctionCall.Parameters, item);
					}
					this.match(198);
					item = this.odbcConvertSpecification();
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ScalarExpression>(odbcFunctionCall, odbcFunctionCall.Parameters, item);
					}
					this.match(192);
					goto IL_7A3;
				}
				case 35:
				case 36:
				case 37:
					goto IL_55A;
				case 38:
					break;
				case 39:
				case 40:
				{
					switch (this.LA(1))
					{
					case 39:
						this.match(39);
						break;
					case 40:
						this.match(40);
						break;
					default:
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
					int num2 = this.LA(1);
					if (num2 == 191)
					{
						this.match(191);
						int num3 = this.LA(1);
						if (num3 <= 101)
						{
							if (num3 <= 34)
							{
								if (num3 != 20 && num3 != 25 && num3 != 34)
								{
									goto IL_508;
								}
							}
							else if (num3 <= 81)
							{
								switch (num3)
								{
								case 40:
								case 41:
									break;
								default:
									if (num3 != 81)
									{
										goto IL_508;
									}
									break;
								}
							}
							else if (num3 != 93)
							{
								switch (num3)
								{
								case 100:
								case 101:
									break;
								default:
									goto IL_508;
								}
							}
						}
						else if (num3 <= 141)
						{
							if (num3 != 133 && num3 != 136 && num3 != 141)
							{
								goto IL_508;
							}
						}
						else if (num3 <= 163)
						{
							if (num3 != 147 && num3 != 163)
							{
								goto IL_508;
							}
						}
						else
						{
							switch (num3)
							{
							case 191:
							case 193:
							case 197:
							case 199:
							case 200:
								break;
							case 192:
								goto IL_51B;
							case 194:
							case 195:
							case 196:
							case 198:
								goto IL_508;
							default:
								switch (num3)
								{
								case 211:
								case 221:
								case 222:
								case 223:
								case 224:
								case 225:
								case 227:
								case 228:
								case 230:
								case 231:
								case 232:
								case 233:
								case 234:
								case 235:
									break;
								case 212:
								case 213:
								case 214:
								case 215:
								case 216:
								case 217:
								case 218:
								case 219:
								case 220:
								case 226:
								case 229:
									goto IL_508;
								default:
									goto IL_508;
								}
								break;
							}
						}
						this.expressionList(odbcFunctionCall, odbcFunctionCall.Parameters);
						goto IL_51B;
						IL_508:
						throw new NoViableAltException(this.LT(1), this.getFilename());
						IL_51B:
						this.match(192);
						goto IL_7A3;
					}
					if (num2 != 194)
					{
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
					if (this.inputState.guessing == 0)
					{
						odbcFunctionCall.ParametersUsed = false;
						goto IL_7A3;
					}
					goto IL_7A3;
				}
				default:
					if (num != 43)
					{
						if (num != 86)
						{
							goto IL_55A;
						}
						goto IL_290;
					}
					break;
				}
			}
			else if (num <= 133)
			{
				if (num != 93 && num != 133)
				{
					goto IL_55A;
				}
				goto IL_290;
			}
			else
			{
				if (num == 156)
				{
					this.match(156);
					this.match(191);
					ScalarExpression item = this.expression();
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ScalarExpression>(odbcFunctionCall, odbcFunctionCall.Parameters, item);
					}
					this.match(198);
					item = this.expression();
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ScalarExpression>(odbcFunctionCall, odbcFunctionCall.Parameters, item);
					}
					this.match(192);
					goto IL_7A3;
				}
				if (num != 163)
				{
					goto IL_55A;
				}
			}
			int num4 = this.LA(1);
			if (num4 != 38)
			{
				if (num4 != 43)
				{
					if (num4 != 163)
					{
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
					this.match(163);
				}
				else
				{
					this.match(43);
				}
			}
			else
			{
				this.match(38);
			}
			this.match(191);
			this.match(192);
			goto IL_7A3;
			IL_290:
			int num5 = this.LA(1);
			if (num5 != 86)
			{
				if (num5 != 93)
				{
					if (num5 != 133)
					{
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
					this.match(133);
				}
				else
				{
					this.match(93);
				}
			}
			else
			{
				this.match(86);
			}
			this.match(191);
			this.expressionList(odbcFunctionCall, odbcFunctionCall.Parameters);
			this.match(192);
			goto IL_7A3;
			IL_55A:
			if (this.LA(1) == 232 && this.LA(2) == 191 && base.NextTokenMatches("EXTRACT"))
			{
				ScalarExpression item = this.extractFromExpression();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ScalarExpression>(odbcFunctionCall, odbcFunctionCall.Parameters, item);
				}
			}
			else
			{
				if (this.LA(1) != 232 || this.LA(2) != 191)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				this.match(232);
				this.match(191);
				int num6 = this.LA(1);
				if (num6 <= 101)
				{
					if (num6 <= 34)
					{
						if (num6 != 20 && num6 != 25 && num6 != 34)
						{
							goto IL_770;
						}
					}
					else if (num6 <= 81)
					{
						switch (num6)
						{
						case 40:
						case 41:
							break;
						default:
							if (num6 != 81)
							{
								goto IL_770;
							}
							break;
						}
					}
					else if (num6 != 93)
					{
						switch (num6)
						{
						case 100:
						case 101:
							break;
						default:
							goto IL_770;
						}
					}
				}
				else if (num6 <= 141)
				{
					if (num6 != 133 && num6 != 136 && num6 != 141)
					{
						goto IL_770;
					}
				}
				else if (num6 <= 163)
				{
					if (num6 != 147 && num6 != 163)
					{
						goto IL_770;
					}
				}
				else
				{
					switch (num6)
					{
					case 191:
					case 193:
					case 197:
					case 199:
					case 200:
						break;
					case 192:
						goto IL_783;
					case 194:
					case 195:
					case 196:
					case 198:
						goto IL_770;
					default:
						switch (num6)
						{
						case 211:
						case 221:
						case 222:
						case 223:
						case 224:
						case 225:
						case 227:
						case 228:
						case 230:
						case 231:
						case 232:
						case 233:
						case 234:
						case 235:
							break;
						case 212:
						case 213:
						case 214:
						case 215:
						case 216:
						case 217:
						case 218:
						case 219:
						case 220:
						case 226:
						case 229:
							goto IL_770;
						default:
							goto IL_770;
						}
						break;
					}
				}
				this.expressionList(odbcFunctionCall, odbcFunctionCall.Parameters);
				goto IL_783;
				IL_770:
				throw new NoViableAltException(this.LT(1), this.getFilename());
				IL_783:
				this.match(192);
			}
			IL_7A3:
			IToken token3 = this.LT(1);
			this.match(194);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(odbcFunctionCall, token3);
			}
			return odbcFunctionCall;
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x0006460C File Offset: 0x0006280C
		public void expressionList(TSqlFragment vParent, IList<ScalarExpression> expressions)
		{
			ScalarExpression item = this.expression();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ScalarExpression>(vParent, expressions, item);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				item = this.expression();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ScalarExpression>(vParent, expressions, item);
				}
			}
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x0006466C File Offset: 0x0006286C
		public TableReference joinTableReference()
		{
			TableReference result = null;
			IToken marker = null;
			bool flag = false;
			if (this.LA(1) == 191 && TSql80ParserInternal.tokenSet_45_.member(this.LA(2)))
			{
				int pos = this.mark();
				flag = true;
				this.inputState.guessing++;
				try
				{
					if (!base.SkipGuessing(marker))
					{
						result = this.joinParenthesis();
					}
					base.SaveGuessing(out marker);
				}
				catch (RecognitionException)
				{
					flag = false;
				}
				this.rewind(pos);
				this.inputState.guessing--;
			}
			if (flag)
			{
				if (!base.SkipGuessing(marker))
				{
					result = this.joinParenthesis();
				}
				while (TSql80ParserInternal.tokenSet_44_.member(this.LA(1)))
				{
					this.joinElement(ref result);
				}
			}
			else
			{
				if (!TSql80ParserInternal.tokenSet_45_.member(this.LA(1)) || !TSql80ParserInternal.tokenSet_47_.member(this.LA(2)))
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				result = this.selectTableReferenceElementWithOutJoinParenthesis();
				int num = 0;
				while (TSql80ParserInternal.tokenSet_44_.member(this.LA(1)))
				{
					this.joinElement(ref result);
					num++;
				}
				if (num < 1)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
			}
			return result;
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x000647BC File Offset: 0x000629BC
		public JoinParenthesisTableReference joinParenthesis()
		{
			JoinParenthesisTableReference joinParenthesisTableReference = base.FragmentFactory.CreateFragment<JoinParenthesisTableReference>();
			IToken token = this.LT(1);
			this.match(191);
			TableReference join = this.joinTableReference();
			IToken token2 = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(joinParenthesisTableReference, token);
				joinParenthesisTableReference.Join = join;
				TSql80ParserBaseInternal.UpdateTokenInfo(joinParenthesisTableReference, token2);
			}
			return joinParenthesisTableReference;
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x0006482C File Offset: 0x00062A2C
		public TableReference selectTableReferenceElementWithOutJoinParenthesis()
		{
			int num = this.LA(1);
			if (num > 110)
			{
				if (num <= 200)
				{
					if (num == 191)
					{
						return this.derivedTable();
					}
					if (num != 200)
					{
						goto IL_B5;
					}
				}
				else
				{
					if (num == 203)
					{
						return this.builtInFunctionTableReference();
					}
					switch (num)
					{
					case 232:
					case 233:
						break;
					case 234:
						return this.variableTableReference();
					default:
						goto IL_B5;
					}
				}
				return this.schemaObjectOrFunctionTableReference();
			}
			if (num == 32 || num == 70)
			{
				return this.fulltextTableReference();
			}
			switch (num)
			{
			case 107:
			case 108:
			case 109:
				return this.openRowset();
			case 110:
				return this.openXmlTableReference();
			}
			IL_B5:
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x00064904 File Offset: 0x00062B04
		public void unqualifiedJoin(ref TableReference vResult)
		{
			UnqualifiedJoin unqualifiedJoin = base.FragmentFactory.CreateFragment<UnqualifiedJoin>();
			int num = this.LA(1);
			if (num != 36)
			{
				if (num != 114)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				this.match(114);
				IToken token = this.LT(1);
				this.match(232);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.Match(token, "APPLY");
					unqualifiedJoin.UnqualifiedJoinType = UnqualifiedJoinType.OuterApply;
				}
			}
			else
			{
				this.match(36);
				int num2 = this.LA(1);
				if (num2 != 90)
				{
					if (num2 != 232)
					{
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
					IToken token2 = this.LT(1);
					this.match(232);
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.Match(token2, "APPLY");
						unqualifiedJoin.UnqualifiedJoinType = UnqualifiedJoinType.CrossApply;
					}
				}
				else
				{
					this.match(90);
					if (this.inputState.guessing == 0)
					{
						unqualifiedJoin.UnqualifiedJoinType = UnqualifiedJoinType.CrossJoin;
					}
				}
			}
			TableReference secondTableReference = this.selectTableReferenceElement();
			if (this.inputState.guessing == 0)
			{
				unqualifiedJoin.FirstTableReference = vResult;
				unqualifiedJoin.SecondTableReference = secondTableReference;
				vResult = unqualifiedJoin;
			}
		}

		// Token: 0x0600135F RID: 4959 RVA: 0x00064A40 File Offset: 0x00062C40
		public void qualifiedJoin(ref TableReference vResult)
		{
			QualifiedJoin qualifiedJoin = base.FragmentFactory.CreateFragment<QualifiedJoin>();
			int num = this.LA(1);
			if (num <= 85)
			{
				if (num != 72 && num != 85)
				{
					goto IL_22C;
				}
			}
			else if (num != 90)
			{
				if (num != 93 && num != 133)
				{
					goto IL_22C;
				}
			}
			else
			{
				this.match(90);
				if (this.inputState.guessing == 0)
				{
					qualifiedJoin.QualifiedJoinType = QualifiedJoinType.Inner;
					goto IL_23F;
				}
				goto IL_23F;
			}
			int num2 = this.LA(1);
			if (num2 <= 85)
			{
				if (num2 != 72)
				{
					if (num2 == 85)
					{
						this.match(85);
						if (this.inputState.guessing == 0)
						{
							qualifiedJoin.QualifiedJoinType = QualifiedJoinType.Inner;
							goto IL_1EE;
						}
						goto IL_1EE;
					}
				}
				else
				{
					this.match(72);
					int num3 = this.LA(1);
					if (num3 != 90)
					{
						if (num3 != 114)
						{
							if (num3 != 232)
							{
								throw new NoViableAltException(this.LT(1), this.getFilename());
							}
						}
						else
						{
							this.match(114);
						}
					}
					if (this.inputState.guessing == 0)
					{
						qualifiedJoin.QualifiedJoinType = QualifiedJoinType.FullOuter;
						goto IL_1EE;
					}
					goto IL_1EE;
				}
			}
			else if (num2 != 93)
			{
				if (num2 == 133)
				{
					this.match(133);
					int num4 = this.LA(1);
					if (num4 != 90)
					{
						if (num4 != 114)
						{
							if (num4 != 232)
							{
								throw new NoViableAltException(this.LT(1), this.getFilename());
							}
						}
						else
						{
							this.match(114);
						}
					}
					if (this.inputState.guessing == 0)
					{
						qualifiedJoin.QualifiedJoinType = QualifiedJoinType.RightOuter;
						goto IL_1EE;
					}
					goto IL_1EE;
				}
			}
			else
			{
				this.match(93);
				int num5 = this.LA(1);
				if (num5 != 90)
				{
					if (num5 != 114)
					{
						if (num5 != 232)
						{
							throw new NoViableAltException(this.LT(1), this.getFilename());
						}
					}
					else
					{
						this.match(114);
					}
				}
				if (this.inputState.guessing == 0)
				{
					qualifiedJoin.QualifiedJoinType = QualifiedJoinType.LeftOuter;
					goto IL_1EE;
				}
				goto IL_1EE;
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_1EE:
			int num6 = this.LA(1);
			if (num6 != 90)
			{
				if (num6 != 232)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				this.joinHint(qualifiedJoin);
			}
			this.match(90);
			goto IL_23F;
			IL_22C:
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_23F:
			TableReference secondTableReference = this.selectTableReferenceWithOdbc();
			if (this.inputState.guessing == 0)
			{
				qualifiedJoin.FirstTableReference = vResult;
				qualifiedJoin.SecondTableReference = secondTableReference;
			}
			this.match(105);
			BooleanExpression searchCondition = this.booleanExpression();
			if (this.inputState.guessing == 0)
			{
				qualifiedJoin.SearchCondition = searchCondition;
				vResult = qualifiedJoin;
			}
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x00064CD8 File Offset: 0x00062ED8
		public TableReference schemaObjectOrFunctionTableReference()
		{
			SchemaObjectName vSchemaObjectName = this.schemaObjectFourPartName();
			TableReference result;
			if (TSql80ParserInternal.tokenSet_48_.member(this.LA(1)) && TSql80ParserInternal.tokenSet_49_.member(this.LA(2)) && base.IsTableReference(true))
			{
				result = this.schemaObjectTableReference(vSchemaObjectName);
			}
			else
			{
				if (this.LA(1) != 191 || !TSql80ParserInternal.tokenSet_50_.member(this.LA(2)))
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				result = this.schemaObjectFunctionTableReference(vSchemaObjectName);
			}
			return result;
		}

		// Token: 0x06001361 RID: 4961 RVA: 0x00064D64 File Offset: 0x00062F64
		public BuiltInFunctionTableReference builtInFunctionTableReference()
		{
			BuiltInFunctionTableReference builtInFunctionTableReference = base.FragmentFactory.CreateFragment<BuiltInFunctionTableReference>();
			IToken token = this.LT(1);
			this.match(203);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(builtInFunctionTableReference, token);
			}
			Identifier name = this.identifier();
			if (this.inputState.guessing == 0)
			{
				builtInFunctionTableReference.Name = name;
			}
			this.match(191);
			int num = this.LA(1);
			if (num <= 100)
			{
				if (num != 47 && num != 100)
				{
					goto IL_143;
				}
			}
			else
			{
				switch (num)
				{
				case 192:
					goto IL_156;
				case 193:
					break;
				default:
					if (num != 199)
					{
						switch (num)
						{
						case 221:
						case 222:
						case 223:
						case 224:
						case 225:
						case 230:
						case 231:
						case 234:
							break;
						case 226:
						case 227:
						case 228:
						case 229:
						case 232:
						case 233:
							goto IL_143;
						default:
							goto IL_143;
						}
					}
					break;
				}
			}
			ScalarExpression item = this.possibleNegativeConstantWithDefault();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ScalarExpression>(builtInFunctionTableReference, builtInFunctionTableReference.Parameters, item);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				item = this.possibleNegativeConstantWithDefault();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ScalarExpression>(builtInFunctionTableReference, builtInFunctionTableReference.Parameters, item);
				}
			}
			goto IL_156;
			IL_143:
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_156:
			IToken token2 = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(builtInFunctionTableReference, token2);
			}
			this.simpleTableReferenceAliasOpt(builtInFunctionTableReference);
			return builtInFunctionTableReference;
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x00064EF8 File Offset: 0x000630F8
		public VariableTableReference variableTableReference()
		{
			VariableTableReference variableTableReference = base.FragmentFactory.CreateFragment<VariableTableReference>();
			VariableReference variable = this.variable();
			if (this.inputState.guessing == 0)
			{
				variableTableReference.Variable = variable;
			}
			this.simpleTableReferenceAliasOpt(variableTableReference);
			return variableTableReference;
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x00064F34 File Offset: 0x00063134
		public TableReferenceWithAlias openRowset()
		{
			TableReferenceWithAlias tableReferenceWithAlias;
			switch (this.LA(1))
			{
			case 107:
				tableReferenceWithAlias = this.adhocRowset();
				this.simpleTableReferenceAliasOpt(tableReferenceWithAlias);
				break;
			case 108:
				tableReferenceWithAlias = this.openQueryRowset();
				this.simpleTableReferenceAliasOpt(tableReferenceWithAlias);
				break;
			case 109:
				tableReferenceWithAlias = this.openRowsetRowset();
				break;
			default:
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			return tableReferenceWithAlias;
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x00064FA0 File Offset: 0x000631A0
		public FullTextTableReference fulltextTableReference()
		{
			FullTextTableReference fullTextTableReference = base.FragmentFactory.CreateFragment<FullTextTableReference>();
			this.fullTextTable(fullTextTableReference);
			this.match(191);
			SchemaObjectName tableName = this.schemaObjectFourPartName();
			if (this.inputState.guessing == 0)
			{
				fullTextTableReference.TableName = tableName;
			}
			this.match(198);
			this.fulltextTableColumnList(fullTextTableReference);
			this.match(198);
			ValueExpression searchCondition = this.stringOrVariable();
			if (this.inputState.guessing == 0)
			{
				fullTextTableReference.SearchCondition = searchCondition;
			}
			int num = this.LA(1);
			if (num != 192)
			{
				if (num != 198)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				this.fulltextTableOptions(fullTextTableReference);
			}
			IToken token = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(fullTextTableReference, token);
			}
			this.simpleTableReferenceAliasOpt(fullTextTableReference);
			return fullTextTableReference;
		}

		// Token: 0x06001365 RID: 4965 RVA: 0x00065088 File Offset: 0x00063288
		public OpenXmlTableReference openXmlTableReference()
		{
			IToken token = this.LT(1);
			this.match(110);
			this.match(191);
			OpenXmlTableReference openXmlTableReference = this.openXmlParams();
			IToken token2 = this.LT(1);
			this.match(192);
			this.openXmlWithClauseOpt(openXmlTableReference);
			this.simpleTableReferenceAliasOpt(openXmlTableReference);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(openXmlTableReference, token);
				TSql80ParserBaseInternal.UpdateTokenInfo(openXmlTableReference, token2);
			}
			return openXmlTableReference;
		}

		// Token: 0x06001366 RID: 4966 RVA: 0x000650F8 File Offset: 0x000632F8
		public void joinHint(QualifiedJoin vParent)
		{
			IToken token = this.LT(1);
			this.match(232);
			int num = this.LA(1);
			if (num != 90)
			{
				if (num != 232)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				IToken token2 = this.LT(1);
				this.match(232);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.Match(token, "LOCAL");
					vParent.JoinHint = JoinHintHelper.Instance.ParseOption(token2);
					if (vParent.JoinHint == JoinHint.Remote)
					{
						TSql80ParserBaseInternal.ThrowIncorrectSyntaxErrorException(token2);
						return;
					}
				}
			}
			else if (this.inputState.guessing == 0)
			{
				vParent.JoinHint = JoinHintHelper.Instance.ParseOption(token);
				return;
			}
		}

		// Token: 0x06001367 RID: 4967 RVA: 0x000651B0 File Offset: 0x000633B0
		public ScalarExpression possibleNegativeConstantWithDefault()
		{
			int num = this.LA(1);
			if (num <= 100)
			{
				if (num == 47)
				{
					return this.defaultLiteral();
				}
				if (num != 100)
				{
					goto IL_83;
				}
			}
			else if (num != 193 && num != 199)
			{
				switch (num)
				{
				case 221:
				case 222:
				case 223:
				case 224:
				case 225:
				case 230:
				case 231:
				case 234:
					break;
				case 226:
				case 227:
				case 228:
				case 229:
				case 232:
				case 233:
					goto IL_83;
				default:
					goto IL_83;
				}
			}
			return this.possibleNegativeConstant();
			IL_83:
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x06001368 RID: 4968 RVA: 0x00065254 File Offset: 0x00063454
		public void simpleTableReferenceAliasOpt(TableReferenceWithAlias vParent)
		{
			int num = this.LA(1);
			if (num <= 106)
			{
				if (num <= 17)
				{
					if (num == 1 || num == 6)
					{
						return;
					}
					switch (num)
					{
					case 9:
						break;
					case 10:
					case 11:
					case 14:
					case 16:
						goto IL_30F;
					case 12:
					case 13:
					case 15:
					case 17:
						return;
					default:
						goto IL_30F;
					}
				}
				else if (num <= 36)
				{
					switch (num)
					{
					case 22:
					case 23:
						return;
					default:
						switch (num)
						{
						case 28:
						case 29:
						case 33:
						case 35:
						case 36:
							return;
						case 30:
						case 31:
						case 32:
						case 34:
							goto IL_30F;
						default:
							goto IL_30F;
						}
						break;
					}
				}
				else
				{
					switch (num)
					{
					case 44:
					case 45:
					case 46:
					case 47:
					case 48:
					case 49:
					case 54:
					case 55:
					case 56:
					case 59:
					case 60:
					case 61:
					case 64:
					case 67:
					case 71:
					case 72:
					case 74:
					case 75:
					case 76:
					case 77:
					case 82:
					case 85:
					case 86:
					case 87:
					case 90:
					case 92:
					case 93:
					case 95:
						return;
					case 50:
					case 51:
					case 52:
					case 53:
					case 57:
					case 58:
					case 62:
					case 63:
					case 65:
					case 66:
					case 68:
					case 69:
					case 70:
					case 73:
					case 78:
					case 79:
					case 80:
					case 81:
					case 83:
					case 84:
					case 88:
					case 89:
					case 91:
					case 94:
						goto IL_30F;
					default:
						switch (num)
						{
						case 105:
						case 106:
							return;
						default:
							goto IL_30F;
						}
						break;
					}
				}
			}
			else if (num <= 194)
			{
				if (num <= 144)
				{
					switch (num)
					{
					case 111:
					case 113:
					case 114:
						return;
					case 112:
						goto IL_30F;
					default:
						switch (num)
						{
						case 119:
						case 123:
						case 125:
						case 126:
						case 129:
						case 131:
						case 132:
						case 133:
						case 134:
						case 138:
						case 140:
						case 142:
						case 143:
						case 144:
							return;
						case 120:
						case 121:
						case 122:
						case 124:
						case 127:
						case 128:
						case 130:
						case 135:
						case 136:
						case 137:
						case 139:
						case 141:
							goto IL_30F;
						default:
							goto IL_30F;
						}
						break;
					}
				}
				else
				{
					switch (num)
					{
					case 156:
					case 158:
					case 160:
					case 161:
					case 162:
					case 164:
					case 167:
					case 169:
					case 170:
					case 171:
					case 172:
					case 173:
					case 176:
					case 180:
					case 181:
						return;
					case 157:
					case 159:
					case 163:
					case 165:
					case 166:
					case 168:
					case 174:
					case 175:
					case 177:
					case 178:
					case 179:
						goto IL_30F;
					default:
						switch (num)
						{
						case 191:
						case 192:
						case 194:
							return;
						case 193:
							goto IL_30F;
						default:
							goto IL_30F;
						}
						break;
					}
				}
			}
			else if (num <= 204)
			{
				if (num != 198 && num != 204)
				{
					goto IL_30F;
				}
				return;
			}
			else
			{
				switch (num)
				{
				case 219:
				case 220:
					return;
				default:
					switch (num)
					{
					case 232:
					case 233:
						break;
					default:
						goto IL_30F;
					}
					break;
				}
			}
			this.simpleTableReferenceAlias(vParent);
			return;
			IL_30F:
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x06001369 RID: 4969 RVA: 0x00065584 File Offset: 0x00063784
		public RaiseErrorStatement raiseErrorStatement()
		{
			RaiseErrorStatement raiseErrorStatement = base.FragmentFactory.CreateFragment<RaiseErrorStatement>();
			IToken token = this.LT(1);
			this.match(191);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(raiseErrorStatement, token);
			}
			ScalarExpression scalarExpression = this.signedIntegerOrStringOrVariable();
			if (this.inputState.guessing == 0)
			{
				raiseErrorStatement.FirstParameter = scalarExpression;
			}
			this.match(198);
			scalarExpression = this.signedIntegerOrVariable();
			if (this.inputState.guessing == 0)
			{
				raiseErrorStatement.SecondParameter = scalarExpression;
			}
			this.match(198);
			scalarExpression = this.signedIntegerOrVariable();
			if (this.inputState.guessing == 0)
			{
				raiseErrorStatement.ThirdParameter = scalarExpression;
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				scalarExpression = this.possibleNegativeConstant();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ScalarExpression>(raiseErrorStatement, raiseErrorStatement.OptionalParameters, scalarExpression);
				}
			}
			IToken token2 = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(raiseErrorStatement, token2);
			}
			int num = this.LA(1);
			if (num <= 86)
			{
				if (num <= 28)
				{
					if (num <= 6)
					{
						if (num == 1 || num == 6)
						{
							return raiseErrorStatement;
						}
					}
					else
					{
						switch (num)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							return raiseErrorStatement;
						case 14:
						case 16:
							break;
						default:
							switch (num)
							{
							case 22:
							case 23:
								return raiseErrorStatement;
							default:
								if (num == 28)
								{
									return raiseErrorStatement;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num <= 64)
				{
					switch (num)
					{
					case 33:
					case 35:
						return raiseErrorStatement;
					case 34:
						break;
					default:
						switch (num)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							return raiseErrorStatement;
						}
						break;
					}
				}
				else
				{
					switch (num)
					{
					case 74:
					case 75:
						return raiseErrorStatement;
					default:
						if (num == 82 || num == 86)
						{
							return raiseErrorStatement;
						}
						break;
					}
				}
			}
			else if (num <= 144)
			{
				if (num <= 95)
				{
					if (num == 92 || num == 95)
					{
						return raiseErrorStatement;
					}
				}
				else
				{
					if (num == 106 || num == 119)
					{
						return raiseErrorStatement;
					}
					switch (num)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return raiseErrorStatement;
					}
				}
			}
			else if (num <= 181)
			{
				switch (num)
				{
				case 156:
				case 160:
				case 161:
				case 162:
					return raiseErrorStatement;
				case 157:
				case 158:
				case 159:
					break;
				default:
					switch (num)
					{
					case 167:
					case 170:
					case 172:
					case 173:
					case 176:
					case 180:
					case 181:
						return raiseErrorStatement;
					case 171:
					{
						this.match(171);
						IToken token3 = this.LT(1);
						this.match(232);
						if (this.inputState.guessing == 0)
						{
							TSql80ParserBaseInternal.UpdateTokenInfo(raiseErrorStatement, token3);
							raiseErrorStatement.RaiseErrorOptions |= RaiseErrorOptionsHelper.Instance.ParseOption(token3);
						}
						while (this.LA(1) == 198)
						{
							this.match(198);
							IToken token4 = this.LT(1);
							this.match(232);
							if (this.inputState.guessing == 0)
							{
								TSql80ParserBaseInternal.UpdateTokenInfo(raiseErrorStatement, token4);
								raiseErrorStatement.RaiseErrorOptions |= RaiseErrorOptionsHelper.Instance.ParseOption(token4);
							}
						}
						return raiseErrorStatement;
					}
					}
					break;
				}
			}
			else
			{
				if (num == 191 || num == 204)
				{
					return raiseErrorStatement;
				}
				switch (num)
				{
				case 219:
				case 220:
					return raiseErrorStatement;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x0600136A RID: 4970 RVA: 0x000659CC File Offset: 0x00063BCC
		public RaiseErrorLegacyStatement raiseErrorLegacyStatement()
		{
			RaiseErrorLegacyStatement raiseErrorLegacyStatement = base.FragmentFactory.CreateFragment<RaiseErrorLegacyStatement>();
			ScalarExpression firstParameter = this.signedIntegerOrVariable();
			if (this.inputState.guessing == 0)
			{
				raiseErrorLegacyStatement.FirstParameter = firstParameter;
			}
			ValueExpression secondParameter = this.stringOrVariable();
			if (this.inputState.guessing == 0)
			{
				raiseErrorLegacyStatement.SecondParameter = secondParameter;
			}
			return raiseErrorLegacyStatement;
		}

		// Token: 0x0600136B RID: 4971 RVA: 0x00065A1C File Offset: 0x00063C1C
		public ScalarExpression signedIntegerOrStringOrVariable()
		{
			int num = this.LA(1);
			if (num != 199 && num != 221)
			{
				switch (num)
				{
				case 230:
				case 231:
				case 234:
					return this.stringOrVariable();
				}
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			return this.signedInteger();
		}

		// Token: 0x0600136C RID: 4972 RVA: 0x00065A8C File Offset: 0x00063C8C
		public ScalarExpression possibleNegativeConstant()
		{
			int num = this.LA(1);
			if (num <= 193)
			{
				if (num != 100 && num != 193)
				{
					goto IL_7F;
				}
			}
			else
			{
				if (num == 199)
				{
					return this.negativeConstant();
				}
				switch (num)
				{
				case 221:
				case 222:
				case 223:
				case 224:
				case 225:
				case 230:
				case 231:
				case 234:
					break;
				case 226:
				case 227:
				case 228:
				case 229:
				case 232:
				case 233:
					goto IL_7F;
				default:
					goto IL_7F;
				}
			}
			return this.literal();
			IL_7F:
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x0600136D RID: 4973 RVA: 0x00065B2C File Offset: 0x00063D2C
		public DeleteSpecification deleteSpecification()
		{
			DeleteSpecification deleteSpecification = base.FragmentFactory.CreateFragment<DeleteSpecification>();
			IToken token = this.LT(1);
			this.match(48);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(deleteSpecification, token);
			}
			int num = this.LA(1);
			if (num <= 109)
			{
				if (num == 71)
				{
					this.match(71);
					goto IL_A0;
				}
				switch (num)
				{
				case 107:
				case 108:
				case 109:
					goto IL_A0;
				}
			}
			else
			{
				if (num == 200)
				{
					goto IL_A0;
				}
				switch (num)
				{
				case 232:
				case 233:
				case 234:
					goto IL_A0;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_A0:
			TableReference target = this.dmlTarget();
			if (this.inputState.guessing == 0)
			{
				deleteSpecification.Target = target;
			}
			FromClause fromClause = this.fromClauseOpt();
			if (this.inputState.guessing == 0)
			{
				deleteSpecification.FromClause = fromClause;
			}
			int num2 = this.LA(1);
			if (num2 <= 86)
			{
				if (num2 <= 28)
				{
					if (num2 <= 6)
					{
						if (num2 == 1 || num2 == 6)
						{
							return deleteSpecification;
						}
					}
					else
					{
						switch (num2)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							return deleteSpecification;
						case 14:
						case 16:
							break;
						default:
							switch (num2)
							{
							case 22:
							case 23:
								return deleteSpecification;
							default:
								if (num2 == 28)
								{
									return deleteSpecification;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num2 <= 64)
				{
					switch (num2)
					{
					case 33:
					case 35:
						return deleteSpecification;
					case 34:
						break;
					default:
						switch (num2)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							return deleteSpecification;
						}
						break;
					}
				}
				else
				{
					switch (num2)
					{
					case 74:
					case 75:
						return deleteSpecification;
					default:
						if (num2 == 82 || num2 == 86)
						{
							return deleteSpecification;
						}
						break;
					}
				}
			}
			else if (num2 <= 119)
			{
				if (num2 <= 95)
				{
					if (num2 == 92 || num2 == 95)
					{
						return deleteSpecification;
					}
				}
				else if (num2 == 106 || num2 == 111 || num2 == 119)
				{
					return deleteSpecification;
				}
			}
			else if (num2 <= 181)
			{
				switch (num2)
				{
				case 123:
				case 125:
				case 126:
				case 129:
				case 131:
				case 132:
				case 134:
				case 138:
				case 140:
				case 142:
				case 143:
				case 144:
					return deleteSpecification;
				case 124:
				case 127:
				case 128:
				case 130:
				case 133:
				case 135:
				case 136:
				case 137:
				case 139:
				case 141:
					break;
				default:
					switch (num2)
					{
					case 156:
					case 160:
					case 161:
					case 162:
						return deleteSpecification;
					case 157:
					case 158:
					case 159:
						break;
					default:
						switch (num2)
						{
						case 167:
						case 170:
						case 172:
						case 173:
						case 176:
						case 180:
						case 181:
							return deleteSpecification;
						case 169:
						{
							WhereClause whereClause = this.dmlWhereClause();
							if (this.inputState.guessing == 0)
							{
								deleteSpecification.WhereClause = whereClause;
								return deleteSpecification;
							}
							return deleteSpecification;
						}
						}
						break;
					}
					break;
				}
			}
			else
			{
				if (num2 == 191 || num2 == 204)
				{
					return deleteSpecification;
				}
				switch (num2)
				{
				case 219:
				case 220:
					return deleteSpecification;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x0600136E RID: 4974 RVA: 0x00065EAC File Offset: 0x000640AC
		public TableReference dmlTarget()
		{
			int num = this.LA(1);
			TableReference result;
			switch (num)
			{
			case 107:
			case 108:
			case 109:
				result = this.openRowset();
				break;
			default:
				if (num != 200)
				{
					switch (num)
					{
					case 232:
					case 233:
						break;
					case 234:
						return this.variableDmlTarget();
					default:
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
				}
				result = this.schemaObjectDmlTarget();
				break;
			}
			return result;
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x00065F2C File Offset: 0x0006412C
		public WhereClause dmlWhereClause()
		{
			WhereClause result;
			if (this.LA(1) == 169 && TSql80ParserInternal.tokenSet_51_.member(this.LA(2)))
			{
				result = this.whereClause();
			}
			else
			{
				if (this.LA(1) != 169 || this.LA(2) != 37)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				result = this.whereCurrentOfCursorClause();
			}
			return result;
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x00065F9C File Offset: 0x0006419C
		public InsertSpecification insertSpecification()
		{
			InsertSpecification insertSpecification = base.FragmentFactory.CreateFragment<InsertSpecification>();
			IToken token = this.LT(1);
			this.match(86);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(insertSpecification, token);
			}
			int num = this.LA(1);
			if (num <= 109)
			{
				if (num != 88)
				{
					switch (num)
					{
					case 107:
					case 108:
					case 109:
						goto IL_DF;
					}
				}
				else
				{
					this.match(88);
					if (this.inputState.guessing == 0)
					{
						insertSpecification.InsertOption = InsertOption.Into;
						goto IL_DF;
					}
					goto IL_DF;
				}
			}
			else if (num != 115)
			{
				if (num == 200)
				{
					goto IL_DF;
				}
				switch (num)
				{
				case 232:
				case 233:
				case 234:
					goto IL_DF;
				}
			}
			else
			{
				this.match(115);
				if (this.inputState.guessing == 0)
				{
					insertSpecification.InsertOption = InsertOption.Over;
					goto IL_DF;
				}
				goto IL_DF;
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_DF:
			TableReference target = this.dmlTarget();
			if (this.inputState.guessing == 0)
			{
				insertSpecification.Target = target;
			}
			bool flag = false;
			if (this.LA(1) == 191 && (this.LA(2) == 200 || this.LA(2) == 232 || this.LA(2) == 233))
			{
				int pos = this.mark();
				flag = true;
				this.inputState.guessing++;
				try
				{
					this.match(191);
					int num2 = this.LA(1);
					if (num2 != 200)
					{
						switch (num2)
						{
						case 232:
							this.match(232);
							break;
						case 233:
							this.match(233);
							break;
						default:
							throw new NoViableAltException(this.LT(1), this.getFilename());
						}
					}
					else
					{
						this.match(200);
					}
				}
				catch (RecognitionException)
				{
					flag = false;
				}
				this.rewind(pos);
				this.inputState.guessing--;
			}
			if (flag)
			{
				IToken token2 = this.LT(1);
				this.match(191);
				ColumnReferenceExpression item = this.insertColumn();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(insertSpecification, token2);
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ColumnReferenceExpression>(insertSpecification, insertSpecification.Columns, item);
				}
				while (this.LA(1) == 198)
				{
					this.match(198);
					item = this.insertColumn();
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ColumnReferenceExpression>(insertSpecification, insertSpecification.Columns, item);
					}
				}
				IToken token3 = this.LT(1);
				this.match(192);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(insertSpecification, token3);
				}
			}
			else if (!TSql80ParserInternal.tokenSet_52_.member(this.LA(1)) || !TSql80ParserInternal.tokenSet_53_.member(this.LA(2)))
			{
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			int num3 = this.LA(1);
			InsertSource insertSource;
			if (num3 > 61)
			{
				if (num3 != 140)
				{
					if (num3 == 164)
					{
						goto IL_316;
					}
					if (num3 != 191)
					{
						goto IL_334;
					}
				}
				insertSource = this.selectInsertSource();
				goto IL_347;
			}
			if (num3 != 47)
			{
				switch (num3)
				{
				case 60:
				case 61:
					insertSource = this.executeInsertSource();
					goto IL_347;
				default:
					goto IL_334;
				}
			}
			IL_316:
			insertSource = this.valuesInsertSource();
			goto IL_347;
			IL_334:
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_347:
			if (this.inputState.guessing == 0)
			{
				insertSpecification.InsertSource = insertSource;
			}
			return insertSpecification;
		}

		// Token: 0x06001371 RID: 4977 RVA: 0x00066318 File Offset: 0x00064518
		public ColumnReferenceExpression insertColumn()
		{
			ColumnReferenceExpression columnReferenceExpression = base.FragmentFactory.CreateFragment<ColumnReferenceExpression>();
			MultiPartIdentifier multiPartIdentifier = this.multiPartIdentifier(-1);
			if (this.inputState.guessing == 0)
			{
				columnReferenceExpression.MultiPartIdentifier = multiPartIdentifier;
			}
			return columnReferenceExpression;
		}

		// Token: 0x06001372 RID: 4978 RVA: 0x00066350 File Offset: 0x00064550
		public ValuesInsertSource valuesInsertSource()
		{
			ValuesInsertSource valuesInsertSource = base.FragmentFactory.CreateFragment<ValuesInsertSource>();
			int num = this.LA(1);
			if (num != 47)
			{
				if (num != 164)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				IToken token = this.LT(1);
				this.match(164);
				RowValue item = this.rowValueExpressionWithDefault();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(valuesInsertSource, token);
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<RowValue>(valuesInsertSource, valuesInsertSource.RowValues, item);
				}
			}
			else
			{
				this.match(47);
				IToken token2 = this.LT(1);
				this.match(164);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(valuesInsertSource, token2);
					valuesInsertSource.IsDefaultValues = true;
				}
			}
			return valuesInsertSource;
		}

		// Token: 0x06001373 RID: 4979 RVA: 0x00066410 File Offset: 0x00064610
		public ExecuteInsertSource executeInsertSource()
		{
			ExecuteInsertSource executeInsertSource = base.FragmentFactory.CreateFragment<ExecuteInsertSource>();
			ExecuteSpecification execute = this.executeSpecification();
			if (this.inputState.guessing == 0)
			{
				executeInsertSource.Execute = execute;
			}
			return executeInsertSource;
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x00066448 File Offset: 0x00064648
		public SelectInsertSource selectInsertSource()
		{
			SelectInsertSource selectInsertSource = base.FragmentFactory.CreateFragment<SelectInsertSource>();
			QueryExpression queryExpression = this.queryExpression(null);
			int num = this.LA(1);
			if (num <= 92)
			{
				if (num <= 28)
				{
					if (num <= 6)
					{
						if (num == 1 || num == 6)
						{
							goto IL_2A0;
						}
					}
					else
					{
						switch (num)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							goto IL_2A0;
						case 14:
						case 16:
							break;
						default:
							switch (num)
							{
							case 22:
							case 23:
								goto IL_2A0;
							default:
								if (num == 28)
								{
									goto IL_2A0;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num <= 75)
				{
					switch (num)
					{
					case 33:
					case 35:
						goto IL_2A0;
					case 34:
						break;
					default:
						switch (num)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							goto IL_2A0;
						case 47:
						case 50:
						case 51:
						case 52:
						case 53:
						case 57:
						case 58:
						case 59:
						case 62:
						case 63:
							break;
						default:
							switch (num)
							{
							case 74:
							case 75:
								goto IL_2A0;
							}
							break;
						}
						break;
					}
				}
				else if (num == 82 || num == 86 || num == 92)
				{
					goto IL_2A0;
				}
			}
			else if (num <= 162)
			{
				if (num <= 113)
				{
					if (num == 95 || num == 106)
					{
						goto IL_2A0;
					}
					switch (num)
					{
					case 111:
						goto IL_2A0;
					case 113:
					{
						OrderByClause orderByClause = this.orderByClause();
						if (this.inputState.guessing == 0)
						{
							queryExpression.OrderByClause = orderByClause;
							goto IL_2A0;
						}
						goto IL_2A0;
					}
					}
				}
				else
				{
					if (num == 119)
					{
						goto IL_2A0;
					}
					switch (num)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						goto IL_2A0;
					case 124:
					case 127:
					case 128:
					case 130:
					case 133:
					case 135:
					case 136:
					case 137:
					case 139:
					case 141:
						break;
					default:
						switch (num)
						{
						case 156:
						case 160:
						case 161:
						case 162:
							goto IL_2A0;
						}
						break;
					}
				}
			}
			else if (num <= 181)
			{
				switch (num)
				{
				case 167:
				case 170:
				case 172:
				case 173:
					goto IL_2A0;
				case 168:
				case 169:
				case 171:
					break;
				default:
					if (num == 176)
					{
						goto IL_2A0;
					}
					switch (num)
					{
					case 180:
					case 181:
						goto IL_2A0;
					}
					break;
				}
			}
			else
			{
				if (num == 191 || num == 204)
				{
					goto IL_2A0;
				}
				switch (num)
				{
				case 219:
				case 220:
					goto IL_2A0;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_2A0:
			if (this.inputState.guessing == 0)
			{
				selectInsertSource.Select = queryExpression;
			}
			return selectInsertSource;
		}

		// Token: 0x06001375 RID: 4981 RVA: 0x0006670C File Offset: 0x0006490C
		public UpdateSpecification updateSpecification()
		{
			UpdateSpecification updateSpecification = base.FragmentFactory.CreateFragment<UpdateSpecification>();
			IToken token = this.LT(1);
			this.match(160);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(updateSpecification, token);
			}
			TableReference target = this.dmlTarget();
			if (this.inputState.guessing == 0)
			{
				updateSpecification.Target = target;
			}
			this.setClausesList(updateSpecification, updateSpecification.SetClauses);
			FromClause fromClause = this.fromClauseOpt();
			if (this.inputState.guessing == 0)
			{
				updateSpecification.FromClause = fromClause;
			}
			int num = this.LA(1);
			if (num <= 86)
			{
				if (num <= 28)
				{
					if (num <= 6)
					{
						if (num == 1 || num == 6)
						{
							return updateSpecification;
						}
					}
					else
					{
						switch (num)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							return updateSpecification;
						case 14:
						case 16:
							break;
						default:
							switch (num)
							{
							case 22:
							case 23:
								return updateSpecification;
							default:
								if (num == 28)
								{
									return updateSpecification;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num <= 64)
				{
					switch (num)
					{
					case 33:
					case 35:
						return updateSpecification;
					case 34:
						break;
					default:
						switch (num)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							return updateSpecification;
						}
						break;
					}
				}
				else
				{
					switch (num)
					{
					case 74:
					case 75:
						return updateSpecification;
					default:
						if (num == 82 || num == 86)
						{
							return updateSpecification;
						}
						break;
					}
				}
			}
			else if (num <= 119)
			{
				if (num <= 95)
				{
					if (num == 92 || num == 95)
					{
						return updateSpecification;
					}
				}
				else if (num == 106 || num == 111 || num == 119)
				{
					return updateSpecification;
				}
			}
			else if (num <= 181)
			{
				switch (num)
				{
				case 123:
				case 125:
				case 126:
				case 129:
				case 131:
				case 132:
				case 134:
				case 138:
				case 140:
				case 142:
				case 143:
				case 144:
					return updateSpecification;
				case 124:
				case 127:
				case 128:
				case 130:
				case 133:
				case 135:
				case 136:
				case 137:
				case 139:
				case 141:
					break;
				default:
					switch (num)
					{
					case 156:
					case 160:
					case 161:
					case 162:
						return updateSpecification;
					case 157:
					case 158:
					case 159:
						break;
					default:
						switch (num)
						{
						case 167:
						case 170:
						case 172:
						case 173:
						case 176:
						case 180:
						case 181:
							return updateSpecification;
						case 169:
						{
							WhereClause whereClause = this.dmlWhereClause();
							if (this.inputState.guessing == 0)
							{
								updateSpecification.WhereClause = whereClause;
								return updateSpecification;
							}
							return updateSpecification;
						}
						}
						break;
					}
					break;
				}
			}
			else
			{
				if (num == 191 || num == 204)
				{
					return updateSpecification;
				}
				switch (num)
				{
				case 219:
				case 220:
					return updateSpecification;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x06001376 RID: 4982 RVA: 0x00066A30 File Offset: 0x00064C30
		public void setClausesList(TSqlFragment vParent, IList<SetClause> setClauses)
		{
			IToken token = this.LT(1);
			this.match(142);
			SetClause item = this.setClause();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token);
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<SetClause>(vParent, setClauses, item);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				item = this.setClause();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<SetClause>(vParent, setClauses, item);
				}
			}
		}

		// Token: 0x06001377 RID: 4983 RVA: 0x00066AAC File Offset: 0x00064CAC
		public AssignmentSetClause setClause()
		{
			AssignmentSetClause assignmentSetClause = base.FragmentFactory.CreateFragment<AssignmentSetClause>();
			int num = this.LA(1);
			if (num != 200)
			{
				switch (num)
				{
				case 232:
				case 233:
					break;
				case 234:
				{
					VariableReference variable = this.variable();
					this.match(206);
					if (this.inputState.guessing == 0)
					{
						assignmentSetClause.Variable = variable;
					}
					bool flag = false;
					if ((this.LA(1) == 200 || this.LA(1) == 232 || this.LA(1) == 233) && TSql80ParserInternal.tokenSet_54_.member(this.LA(2)))
					{
						int pos = this.mark();
						flag = true;
						this.inputState.guessing++;
						try
						{
							this.identifierList(-1);
							this.match(206);
						}
						catch (RecognitionException)
						{
							flag = false;
						}
						this.rewind(pos);
						this.inputState.guessing--;
					}
					if (flag)
					{
						this.setClauseSubItem(assignmentSetClause);
						return assignmentSetClause;
					}
					if (!TSql80ParserInternal.tokenSet_16_.member(this.LA(1)) || !TSql80ParserInternal.tokenSet_55_.member(this.LA(2)))
					{
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
					ScalarExpression newValue = this.expression();
					if (this.inputState.guessing == 0)
					{
						assignmentSetClause.NewValue = newValue;
						return assignmentSetClause;
					}
					return assignmentSetClause;
				}
				default:
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
			}
			this.setClauseSubItem(assignmentSetClause);
			return assignmentSetClause;
		}

		// Token: 0x06001378 RID: 4984 RVA: 0x00066C40 File Offset: 0x00064E40
		public void setClauseSubItem(AssignmentSetClause vParent)
		{
			MultiPartIdentifier multiPartIdentifier = this.multiPartIdentifier(-1);
			if (this.inputState.guessing == 0)
			{
				base.CreateSetClauseColumn(vParent, multiPartIdentifier);
			}
			this.match(206);
			ScalarExpression newValue = this.expressionWithDefault();
			if (this.inputState.guessing == 0)
			{
				vParent.NewValue = newValue;
			}
		}

		// Token: 0x06001379 RID: 4985 RVA: 0x00066C90 File Offset: 0x00064E90
		public ScalarExpression expressionWithDefault()
		{
			int num = this.LA(1);
			if (num <= 101)
			{
				if (num <= 41)
				{
					if (num <= 25)
					{
						if (num != 20 && num != 25)
						{
							goto IL_198;
						}
					}
					else if (num != 34)
					{
						switch (num)
						{
						case 40:
						case 41:
							break;
						default:
							goto IL_198;
						}
					}
				}
				else if (num <= 81)
				{
					if (num == 47)
					{
						return this.defaultLiteral();
					}
					if (num != 81)
					{
						goto IL_198;
					}
				}
				else if (num != 93)
				{
					switch (num)
					{
					case 100:
					case 101:
						break;
					default:
						goto IL_198;
					}
				}
			}
			else if (num <= 147)
			{
				if (num <= 136)
				{
					if (num != 133 && num != 136)
					{
						goto IL_198;
					}
				}
				else if (num != 141 && num != 147)
				{
					goto IL_198;
				}
			}
			else if (num <= 193)
			{
				if (num != 163)
				{
					switch (num)
					{
					case 191:
					case 193:
						break;
					case 192:
						goto IL_198;
					default:
						goto IL_198;
					}
				}
			}
			else
			{
				switch (num)
				{
				case 197:
				case 199:
				case 200:
					break;
				case 198:
					goto IL_198;
				default:
					switch (num)
					{
					case 211:
					case 221:
					case 222:
					case 223:
					case 224:
					case 225:
					case 227:
					case 228:
					case 230:
					case 231:
					case 232:
					case 233:
					case 234:
					case 235:
						break;
					case 212:
					case 213:
					case 214:
					case 215:
					case 216:
					case 217:
					case 218:
					case 219:
					case 220:
					case 226:
					case 229:
						goto IL_198;
					default:
						goto IL_198;
					}
					break;
				}
			}
			return this.expression();
			IL_198:
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x0600137A RID: 4986 RVA: 0x00066E4C File Offset: 0x0006504C
		public ExecuteSpecification executeSpecification()
		{
			ExecuteSpecification executeSpecification = base.FragmentFactory.CreateFragment<ExecuteSpecification>();
			this.execStart(executeSpecification);
			this.execTypes(executeSpecification);
			return executeSpecification;
		}

		// Token: 0x0600137B RID: 4987 RVA: 0x00066E74 File Offset: 0x00065074
		public RowValue rowValueExpressionWithDefault()
		{
			RowValue rowValue = base.FragmentFactory.CreateFragment<RowValue>();
			IToken token = this.LT(1);
			this.match(191);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(rowValue, token);
			}
			this.expressionWithDefaultList(rowValue, rowValue.ColumnValues);
			IToken token2 = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(rowValue, token2);
			}
			return rowValue;
		}

		// Token: 0x0600137C RID: 4988 RVA: 0x00066EF0 File Offset: 0x000650F0
		public void expressionWithDefaultList(TSqlFragment vParent, IList<ScalarExpression> expressions)
		{
			ScalarExpression item = this.expressionWithDefault();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ScalarExpression>(vParent, expressions, item);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				item = this.expressionWithDefault();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ScalarExpression>(vParent, expressions, item);
				}
			}
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x00066F50 File Offset: 0x00065150
		public TableReferenceWithAlias schemaObjectDmlTarget()
		{
			bool flag = false;
			if ((this.LA(1) == 200 || this.LA(1) == 232 || this.LA(1) == 233) && TSql80ParserInternal.tokenSet_56_.member(this.LA(2)))
			{
				int pos = this.mark();
				flag = true;
				this.inputState.guessing++;
				try
				{
					this.schemaObjectFourPartName();
					this.match(191);
					int num = this.LA(1);
					if (num <= 100)
					{
						if (num != 47 && num != 100)
						{
							goto IL_106;
						}
					}
					else
					{
						switch (num)
						{
						case 192:
							this.match(192);
							goto IL_119;
						case 193:
							break;
						default:
							if (num != 199)
							{
								switch (num)
								{
								case 221:
								case 222:
								case 223:
								case 224:
								case 225:
								case 230:
								case 231:
								case 234:
									break;
								case 226:
								case 227:
								case 228:
								case 229:
								case 232:
								case 233:
									goto IL_106;
								default:
									goto IL_106;
								}
							}
							break;
						}
					}
					this.possibleNegativeConstantWithDefault();
					goto IL_119;
					IL_106:
					throw new NoViableAltException(this.LT(1), this.getFilename());
					IL_119:;
				}
				catch (RecognitionException)
				{
					flag = false;
				}
				this.rewind(pos);
				this.inputState.guessing--;
			}
			TableReferenceWithAlias result;
			if (flag)
			{
				result = this.schemaObjectFunctionDmlTarget();
			}
			else
			{
				if ((this.LA(1) != 200 && this.LA(1) != 232 && this.LA(1) != 233) || !TSql80ParserInternal.tokenSet_57_.member(this.LA(2)))
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				result = this.schemaObjectTableDmlTarget();
			}
			return result;
		}

		// Token: 0x0600137E RID: 4990 RVA: 0x00067110 File Offset: 0x00065310
		public VariableTableReference variableDmlTarget()
		{
			VariableTableReference variableTableReference = base.FragmentFactory.CreateFragment<VariableTableReference>();
			VariableReference variable = this.variable();
			if (this.inputState.guessing == 0)
			{
				variableTableReference.Variable = variable;
			}
			return variableTableReference;
		}

		// Token: 0x0600137F RID: 4991 RVA: 0x00067148 File Offset: 0x00065348
		public SchemaObjectFunctionTableReference schemaObjectFunctionDmlTarget()
		{
			SchemaObjectFunctionTableReference schemaObjectFunctionTableReference = base.FragmentFactory.CreateFragment<SchemaObjectFunctionTableReference>();
			SchemaObjectName schemaObject = this.schemaObjectFourPartName();
			if (this.inputState.guessing == 0)
			{
				schemaObjectFunctionTableReference.SchemaObject = schemaObject;
			}
			this.parenthesizedOptExpressionWithDefaultList(schemaObjectFunctionTableReference, schemaObjectFunctionTableReference.Parameters);
			return schemaObjectFunctionTableReference;
		}

		// Token: 0x06001380 RID: 4992 RVA: 0x0006718C File Offset: 0x0006538C
		public NamedTableReference schemaObjectTableDmlTarget()
		{
			NamedTableReference namedTableReference = base.FragmentFactory.CreateFragment<NamedTableReference>();
			SchemaObjectName schemaObject = this.schemaObjectFourPartName();
			if (this.inputState.guessing == 0)
			{
				namedTableReference.SchemaObject = schemaObject;
			}
			int num = this.LA(1);
			if (num <= 86)
			{
				if (num <= 28)
				{
					if (num <= 6)
					{
						if (num == 1 || num == 6)
						{
							return namedTableReference;
						}
					}
					else
					{
						switch (num)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							return namedTableReference;
						case 14:
						case 16:
							break;
						default:
							switch (num)
							{
							case 22:
							case 23:
								return namedTableReference;
							default:
								if (num == 28)
								{
									return namedTableReference;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num <= 64)
				{
					switch (num)
					{
					case 33:
					case 35:
						return namedTableReference;
					case 34:
						break;
					default:
						switch (num)
						{
						case 44:
						case 45:
						case 46:
						case 47:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							return namedTableReference;
						}
						break;
					}
				}
				else
				{
					switch (num)
					{
					case 71:
					case 74:
					case 75:
						return namedTableReference;
					case 72:
					case 73:
						break;
					default:
						if (num == 82 || num == 86)
						{
							return namedTableReference;
						}
						break;
					}
				}
			}
			else if (num <= 119)
			{
				if (num <= 95)
				{
					if (num == 92 || num == 95)
					{
						return namedTableReference;
					}
				}
				else if (num == 106 || num == 111 || num == 119)
				{
					return namedTableReference;
				}
			}
			else if (num <= 181)
			{
				switch (num)
				{
				case 123:
				case 125:
				case 126:
				case 129:
				case 131:
				case 132:
				case 134:
				case 138:
				case 140:
				case 142:
				case 143:
				case 144:
					return namedTableReference;
				case 124:
				case 127:
				case 128:
				case 130:
				case 133:
				case 135:
				case 136:
				case 137:
				case 139:
				case 141:
					break;
				default:
					switch (num)
					{
					case 156:
					case 160:
					case 161:
					case 162:
					case 164:
					case 167:
					case 169:
					case 170:
					case 172:
					case 173:
					case 176:
					case 180:
					case 181:
						return namedTableReference;
					case 171:
						this.match(171);
						this.tableHints(namedTableReference, namedTableReference.TableHints, false);
						return namedTableReference;
					}
					break;
				}
			}
			else
			{
				if (num == 191 || num == 204)
				{
					return namedTableReference;
				}
				switch (num)
				{
				case 219:
				case 220:
					return namedTableReference;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x0006744C File Offset: 0x0006564C
		public void parenthesizedOptExpressionWithDefaultList(TSqlFragment vParent, IList<ScalarExpression> expressions)
		{
			this.match(191);
			int num = this.LA(1);
			if (num <= 93)
			{
				if (num <= 34)
				{
					if (num != 20 && num != 25 && num != 34)
					{
						goto IL_193;
					}
				}
				else if (num <= 47)
				{
					switch (num)
					{
					case 40:
					case 41:
						break;
					default:
						if (num != 47)
						{
							goto IL_193;
						}
						break;
					}
				}
				else if (num != 81 && num != 93)
				{
					goto IL_193;
				}
			}
			else if (num <= 141)
			{
				if (num <= 133)
				{
					switch (num)
					{
					case 100:
					case 101:
						break;
					default:
						if (num != 133)
						{
							goto IL_193;
						}
						break;
					}
				}
				else if (num != 136 && num != 141)
				{
					goto IL_193;
				}
			}
			else if (num <= 163)
			{
				if (num != 147 && num != 163)
				{
					goto IL_193;
				}
			}
			else
			{
				switch (num)
				{
				case 191:
				case 193:
				case 197:
				case 199:
				case 200:
					break;
				case 192:
					goto IL_1A6;
				case 194:
				case 195:
				case 196:
				case 198:
					goto IL_193;
				default:
					switch (num)
					{
					case 211:
					case 221:
					case 222:
					case 223:
					case 224:
					case 225:
					case 227:
					case 228:
					case 230:
					case 231:
					case 232:
					case 233:
					case 234:
					case 235:
						break;
					case 212:
					case 213:
					case 214:
					case 215:
					case 216:
					case 217:
					case 218:
					case 219:
					case 220:
					case 226:
					case 229:
						goto IL_193;
					default:
						goto IL_193;
					}
					break;
				}
			}
			this.expressionWithDefaultList(vParent, expressions);
			goto IL_1A6;
			IL_193:
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_1A6:
			IToken token = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token);
			}
		}

		// Token: 0x06001382 RID: 4994 RVA: 0x00067628 File Offset: 0x00065828
		public void tableHints(TSqlFragment vParent, IList<TableHint> hints, bool indexHintAllowed)
		{
			IToken token = this.LT(1);
			this.match(191);
			TableHint item = this.tableHint(indexHintAllowed);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token);
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<TableHint>(vParent, hints, item);
			}
			while (TSql80ParserInternal.tokenSet_58_.member(this.LA(1)))
			{
				int num = this.LA(1);
				if (num <= 84)
				{
					if (num != 78 && num != 84)
					{
						goto IL_86;
					}
				}
				else if (num != 198)
				{
					if (num != 232)
					{
						goto IL_86;
					}
				}
				else
				{
					this.match(198);
				}
				item = this.tableHint(indexHintAllowed);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<TableHint>(vParent, hints, item);
					continue;
				}
				continue;
				IL_86:
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			IToken token2 = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token2);
			}
		}

		// Token: 0x06001383 RID: 4995 RVA: 0x00067714 File Offset: 0x00065914
		public NamedTableReference schemaObjectTableReference(SchemaObjectName vSchemaObjectName)
		{
			NamedTableReference namedTableReference = base.FragmentFactory.CreateFragment<NamedTableReference>();
			namedTableReference.SchemaObject = vSchemaObjectName;
			bool flag = false;
			if ((this.LA(1) == 78 || this.LA(1) == 171 || this.LA(1) == 191) && TSql80ParserInternal.tokenSet_59_.member(this.LA(2)))
			{
				this.nonParameterTableHints(namedTableReference, namedTableReference.TableHints, ref flag);
				int num = this.LA(1);
				if (num <= 106)
				{
					if (num <= 23)
					{
						if (num <= 6)
						{
							if (num != 1 && num != 6)
							{
								goto IL_3C9;
							}
							return namedTableReference;
						}
						else
						{
							switch (num)
							{
							case 9:
								break;
							case 10:
							case 11:
							case 14:
							case 16:
								goto IL_3C9;
							case 12:
							case 13:
							case 15:
							case 17:
								return namedTableReference;
							default:
								switch (num)
								{
								case 22:
								case 23:
									return namedTableReference;
								default:
									goto IL_3C9;
								}
								break;
							}
						}
					}
					else if (num <= 77)
					{
						switch (num)
						{
						case 28:
						case 29:
						case 33:
						case 35:
						case 36:
							return namedTableReference;
						case 30:
						case 31:
						case 32:
						case 34:
							goto IL_3C9;
						default:
							switch (num)
							{
							case 44:
							case 45:
							case 46:
							case 48:
							case 49:
							case 54:
							case 55:
							case 56:
							case 59:
							case 60:
							case 61:
							case 64:
							case 67:
							case 72:
							case 74:
							case 75:
							case 76:
							case 77:
								return namedTableReference;
							case 47:
							case 50:
							case 51:
							case 52:
							case 53:
							case 57:
							case 58:
							case 62:
							case 63:
							case 65:
							case 66:
							case 68:
							case 69:
							case 70:
							case 71:
							case 73:
								goto IL_3C9;
							default:
								goto IL_3C9;
							}
							break;
						}
					}
					else
					{
						switch (num)
						{
						case 82:
						case 85:
						case 86:
						case 87:
						case 90:
						case 92:
						case 93:
						case 95:
							return namedTableReference;
						case 83:
						case 84:
						case 88:
						case 89:
						case 91:
						case 94:
							goto IL_3C9;
						default:
							switch (num)
							{
							case 105:
							case 106:
								return namedTableReference;
							default:
								goto IL_3C9;
							}
							break;
						}
					}
				}
				else if (num <= 194)
				{
					if (num <= 144)
					{
						switch (num)
						{
						case 111:
						case 113:
						case 114:
							return namedTableReference;
						case 112:
							goto IL_3C9;
						default:
							switch (num)
							{
							case 119:
							case 123:
							case 125:
							case 126:
							case 129:
							case 131:
							case 132:
							case 133:
							case 134:
							case 138:
							case 140:
							case 142:
							case 143:
							case 144:
								return namedTableReference;
							case 120:
							case 121:
							case 122:
							case 124:
							case 127:
							case 128:
							case 130:
							case 135:
							case 136:
							case 137:
							case 139:
							case 141:
								goto IL_3C9;
							default:
								goto IL_3C9;
							}
							break;
						}
					}
					else
					{
						switch (num)
						{
						case 156:
						case 158:
						case 160:
						case 161:
						case 162:
						case 167:
						case 169:
						case 170:
						case 171:
						case 172:
						case 173:
						case 176:
						case 180:
						case 181:
							return namedTableReference;
						case 157:
						case 159:
						case 163:
						case 164:
						case 165:
						case 166:
						case 168:
						case 174:
						case 175:
						case 177:
						case 178:
						case 179:
							goto IL_3C9;
						default:
							switch (num)
							{
							case 191:
							case 192:
							case 194:
								return namedTableReference;
							case 193:
								goto IL_3C9;
							default:
								goto IL_3C9;
							}
							break;
						}
					}
				}
				else if (num <= 204)
				{
					if (num != 198 && num != 204)
					{
						goto IL_3C9;
					}
					return namedTableReference;
				}
				else
				{
					switch (num)
					{
					case 219:
					case 220:
						return namedTableReference;
					default:
						switch (num)
						{
						case 232:
						case 233:
							break;
						default:
							goto IL_3C9;
						}
						break;
					}
				}
				this.simpleTableReferenceAlias(namedTableReference);
				if (this.inputState.guessing == 0 && namedTableReference.Alias != null && flag)
				{
					TSql80ParserBaseInternal.ThrowIncorrectSyntaxErrorException(namedTableReference.Alias);
					return namedTableReference;
				}
				return namedTableReference;
				IL_3C9:
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			if (this.LA(1) == 9 || this.LA(1) == 232 || this.LA(1) == 233)
			{
				this.simpleTableReferenceAlias(namedTableReference);
				bool flag2 = false;
				if (this.LA(1) == 191 && this.LA(2) == 221)
				{
					int pos = this.mark();
					flag2 = true;
					this.inputState.guessing++;
					try
					{
						this.match(191);
						this.integer();
					}
					catch (RecognitionException)
					{
						flag2 = false;
					}
					this.rewind(pos);
					this.inputState.guessing--;
				}
				if (flag2)
				{
					IndexTableHint item = this.oldForceIndex();
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.AddAndUpdateTokenInfo<TableHint>(namedTableReference, namedTableReference.TableHints, item);
					}
				}
				else
				{
					bool flag3 = false;
					if ((this.LA(1) == 78 || this.LA(1) == 171 || this.LA(1) == 191) && TSql80ParserInternal.tokenSet_60_.member(this.LA(2)))
					{
						int pos2 = this.mark();
						flag3 = true;
						this.inputState.guessing++;
						try
						{
							int num2 = this.LA(1);
							if (num2 != 78)
							{
								if (num2 != 171)
								{
									if (num2 != 191)
									{
										throw new NoViableAltException(this.LT(1), this.getFilename());
									}
									this.match(191);
									int num3 = this.LA(1);
									if (num3 != 78)
									{
										if (num3 != 84)
										{
											switch (num3)
											{
											case 232:
											case 233:
												this.identifier();
												break;
											default:
												throw new NoViableAltException(this.LT(1), this.getFilename());
											}
										}
										else
										{
											this.match(84);
										}
									}
									else
									{
										this.match(78);
									}
								}
								else
								{
									this.match(171);
								}
							}
							else
							{
								this.match(78);
							}
						}
						catch (RecognitionException)
						{
							flag3 = false;
						}
						this.rewind(pos2);
						this.inputState.guessing--;
					}
					if (flag3)
					{
						this.nonParameterTableHints(namedTableReference, namedTableReference.TableHints, ref flag);
					}
					else if (!TSql80ParserInternal.tokenSet_32_.member(this.LA(1)) || !TSql80ParserInternal.tokenSet_33_.member(this.LA(2)))
					{
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
				}
			}
			else if (!TSql80ParserInternal.tokenSet_32_.member(this.LA(1)) || !TSql80ParserInternal.tokenSet_33_.member(this.LA(2)))
			{
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			return namedTableReference;
		}

		// Token: 0x06001384 RID: 4996 RVA: 0x00067DAC File Offset: 0x00065FAC
		public SchemaObjectFunctionTableReference schemaObjectFunctionTableReference(SchemaObjectName vSchemaObjectName)
		{
			SchemaObjectFunctionTableReference schemaObjectFunctionTableReference = base.FragmentFactory.CreateFragment<SchemaObjectFunctionTableReference>();
			schemaObjectFunctionTableReference.SchemaObject = vSchemaObjectName;
			this.parenthesizedOptExpressionWithDefaultList(schemaObjectFunctionTableReference, schemaObjectFunctionTableReference.Parameters);
			this.simpleTableReferenceAliasOpt(schemaObjectFunctionTableReference);
			if (this.LA(1) == 191 && (this.LA(2) == 232 || this.LA(2) == 233))
			{
				this.columnNameList(schemaObjectFunctionTableReference, schemaObjectFunctionTableReference.Columns);
			}
			else if (!TSql80ParserInternal.tokenSet_32_.member(this.LA(1)) || !TSql80ParserInternal.tokenSet_33_.member(this.LA(2)))
			{
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			return schemaObjectFunctionTableReference;
		}

		// Token: 0x06001385 RID: 4997 RVA: 0x00067E54 File Offset: 0x00066054
		public void nonParameterTableHints(TSqlFragment vParent, IList<TableHint> hints, ref bool withSpecified)
		{
			int num = this.LA(1);
			if (num != 78)
			{
				if (num != 171 && num != 191)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				this.simpleTableHints(vParent, hints, ref withSpecified);
				return;
			}
			else
			{
				IToken token = this.LT(1);
				this.match(78);
				if (this.inputState.guessing == 0)
				{
					TableHint tableHint = base.FragmentFactory.CreateFragment<TableHint>();
					TSql80ParserBaseInternal.UpdateTokenInfo(tableHint, token);
					tableHint.HintKind = TableHintKind.HoldLock;
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<TableHint>(vParent, hints, tableHint);
				}
				bool flag = false;
				if (this.LA(1) == 191 && this.LA(2) == 221)
				{
					int pos = this.mark();
					flag = true;
					this.inputState.guessing++;
					try
					{
						this.match(191);
						this.integer();
					}
					catch (RecognitionException)
					{
						flag = false;
					}
					this.rewind(pos);
					this.inputState.guessing--;
				}
				if (flag)
				{
					IndexTableHint item = this.oldForceIndex();
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.AddAndUpdateTokenInfo<TableHint>(vParent, hints, item);
						return;
					}
					return;
				}
				else
				{
					bool flag2 = false;
					if ((this.LA(1) == 171 || this.LA(1) == 191) && TSql80ParserInternal.tokenSet_61_.member(this.LA(2)))
					{
						int pos2 = this.mark();
						flag2 = true;
						this.inputState.guessing++;
						try
						{
							this.match(191);
							int num2 = this.LA(1);
							if (num2 != 84)
							{
								switch (num2)
								{
								case 232:
								case 233:
									this.identifier();
									break;
								default:
									throw new NoViableAltException(this.LT(1), this.getFilename());
								}
							}
							else
							{
								this.match(84);
							}
						}
						catch (RecognitionException)
						{
							flag2 = false;
						}
						this.rewind(pos2);
						this.inputState.guessing--;
					}
					if (flag2)
					{
						this.simpleTableHints(vParent, hints, ref withSpecified);
						return;
					}
					if (TSql80ParserInternal.tokenSet_62_.member(this.LA(1)) && TSql80ParserInternal.tokenSet_33_.member(this.LA(2)))
					{
						return;
					}
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
			}
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x000680B4 File Offset: 0x000662B4
		public IndexTableHint oldForceIndex()
		{
			IndexTableHint indexTableHint = base.FragmentFactory.CreateFragment<IndexTableHint>();
			IToken token = this.LT(1);
			this.match(191);
			Literal valueExpression = this.integer();
			IToken token2 = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(indexTableHint, token);
				indexTableHint.HintKind = TableHintKind.Index;
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<IdentifierOrValueExpression>(indexTableHint, indexTableHint.IndexValues, base.IdentifierOrValueExpression(valueExpression));
				TSql80ParserBaseInternal.UpdateTokenInfo(indexTableHint, token2);
			}
			return indexTableHint;
		}

		// Token: 0x06001387 RID: 4999 RVA: 0x00068138 File Offset: 0x00066338
		public void fullTextTable(FullTextTableReference vParent)
		{
			int num = this.LA(1);
			if (num != 32)
			{
				if (num != 70)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				IToken token = this.LT(1);
				this.match(70);
				if (this.inputState.guessing == 0)
				{
					vParent.FullTextFunctionType = FullTextFunctionType.FreeText;
					TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token);
					return;
				}
			}
			else
			{
				IToken token2 = this.LT(1);
				this.match(32);
				if (this.inputState.guessing == 0)
				{
					vParent.FullTextFunctionType = FullTextFunctionType.Contains;
					TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token2);
					return;
				}
			}
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x000681C8 File Offset: 0x000663C8
		public void fulltextTableColumnList(FullTextTableReference vParent)
		{
			int num = this.LA(1);
			if (num != 195)
			{
				ColumnReferenceExpression item;
				if (num != 200)
				{
					switch (num)
					{
					case 232:
					case 233:
						break;
					default:
						if (this.LA(1) == 191 && this.LA(2) == 195)
						{
							this.match(191);
							item = this.starColumnReferenceExpression();
							this.match(192);
							if (this.inputState.guessing == 0)
							{
								TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ColumnReferenceExpression>(vParent, vParent.Columns, item);
								return;
							}
							return;
						}
						else
						{
							if (this.LA(1) == 191 && (this.LA(2) == 200 || this.LA(2) == 232 || this.LA(2) == 233))
							{
								this.match(191);
								item = this.identifierColumnReferenceExpression();
								if (this.inputState.guessing == 0)
								{
									TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ColumnReferenceExpression>(vParent, vParent.Columns, item);
								}
								while (this.LA(1) == 198)
								{
									this.match(198);
									item = this.identifierColumnReferenceExpression();
									if (this.inputState.guessing == 0)
									{
										TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ColumnReferenceExpression>(vParent, vParent.Columns, item);
									}
								}
								this.match(192);
								return;
							}
							throw new NoViableAltException(this.LT(1), this.getFilename());
						}
						break;
					}
				}
				item = this.identifierColumnReferenceExpression();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ColumnReferenceExpression>(vParent, vParent.Columns, item);
					return;
				}
			}
			else
			{
				ColumnReferenceExpression item = this.starColumnReferenceExpression();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ColumnReferenceExpression>(vParent, vParent.Columns, item);
					return;
				}
			}
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x00068368 File Offset: 0x00066568
		public void fulltextTableOptions(FullTextTableReference vParent)
		{
			if (this.LA(1) == 198 && this.LA(2) == 232)
			{
				this.match(198);
				ValueExpression language = this.languageExpression();
				if (this.inputState.guessing == 0)
				{
					vParent.Language = language;
				}
				int num = this.LA(1);
				if (num != 192)
				{
					if (num != 198)
					{
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
					this.match(198);
					ValueExpression topN = this.unsignedInteger();
					if (this.inputState.guessing == 0)
					{
						vParent.TopN = topN;
						return;
					}
				}
			}
			else
			{
				if (this.LA(1) != 198 || (this.LA(2) != 221 && this.LA(2) != 234))
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				this.match(198);
				ValueExpression topN = this.unsignedInteger();
				if (this.inputState.guessing == 0)
				{
					vParent.TopN = topN;
				}
				int num2 = this.LA(1);
				if (num2 != 192)
				{
					if (num2 != 198)
					{
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
					this.match(198);
					ValueExpression language = this.languageExpression();
					if (this.inputState.guessing == 0)
					{
						vParent.Language = language;
						return;
					}
				}
			}
		}

		// Token: 0x0600138A RID: 5002 RVA: 0x000684CC File Offset: 0x000666CC
		public ColumnReferenceExpression identifierColumnReferenceExpression()
		{
			ColumnReferenceExpression columnReferenceExpression = base.FragmentFactory.CreateFragment<ColumnReferenceExpression>();
			MultiPartIdentifier multiPartIdentifier = this.multiPartIdentifier(1);
			if (this.inputState.guessing == 0)
			{
				columnReferenceExpression.ColumnType = ColumnType.Regular;
				columnReferenceExpression.MultiPartIdentifier = multiPartIdentifier;
			}
			return columnReferenceExpression;
		}

		// Token: 0x0600138B RID: 5003 RVA: 0x0006850C File Offset: 0x0006670C
		public ColumnReferenceExpression starColumnReferenceExpression()
		{
			ColumnReferenceExpression columnReferenceExpression = base.FragmentFactory.CreateFragment<ColumnReferenceExpression>();
			IToken token = this.LT(1);
			this.match(195);
			if (this.inputState.guessing == 0)
			{
				columnReferenceExpression.ColumnType = ColumnType.Wildcard;
				TSql80ParserBaseInternal.UpdateTokenInfo(columnReferenceExpression, token);
			}
			return columnReferenceExpression;
		}

		// Token: 0x0600138C RID: 5004 RVA: 0x00068558 File Offset: 0x00066758
		public ValueExpression languageExpression()
		{
			ValueExpression result = null;
			IToken token = this.LT(1);
			this.match(232);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.Match(token, "LANGUAGE");
			}
			ValueExpression valueExpression = this.binaryOrIntegerOrStringOrVariable();
			if (this.inputState.guessing == 0)
			{
				result = valueExpression;
			}
			return result;
		}

		// Token: 0x0600138D RID: 5005 RVA: 0x000685AC File Offset: 0x000667AC
		public ValueExpression unsignedInteger()
		{
			int num = this.LA(1);
			ValueExpression result;
			if (num != 221)
			{
				if (num != 234)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				result = this.variable();
			}
			else
			{
				result = this.integer();
			}
			return result;
		}

		// Token: 0x0600138E RID: 5006 RVA: 0x000685FC File Offset: 0x000667FC
		public ValueExpression binaryOrIntegerOrStringOrVariable()
		{
			int num = this.LA(1);
			ValueExpression result;
			if (num != 221)
			{
				if (num != 224)
				{
					switch (num)
					{
					case 230:
					case 231:
						return this.stringLiteral();
					case 234:
						return this.variable();
					}
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				result = this.binary();
			}
			else
			{
				result = this.integer();
			}
			return result;
		}

		// Token: 0x0600138F RID: 5007 RVA: 0x0006867C File Offset: 0x0006687C
		public OpenXmlTableReference openXmlParams()
		{
			OpenXmlTableReference openXmlTableReference = base.FragmentFactory.CreateFragment<OpenXmlTableReference>();
			VariableReference variable = this.variable();
			this.match(198);
			ValueExpression rowPattern = this.stringOrVariable();
			if (this.inputState.guessing == 0)
			{
				openXmlTableReference.Variable = variable;
				openXmlTableReference.RowPattern = rowPattern;
			}
			int num = this.LA(1);
			if (num != 192)
			{
				if (num != 198)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				this.match(198);
				ValueExpression flags = this.unsignedInteger();
				if (this.inputState.guessing == 0)
				{
					openXmlTableReference.Flags = flags;
				}
			}
			return openXmlTableReference;
		}

		// Token: 0x06001390 RID: 5008 RVA: 0x00068720 File Offset: 0x00066920
		public void openXmlWithClauseOpt(OpenXmlTableReference vParent)
		{
			bool flag = false;
			if (this.LA(1) == 171 && TSql80ParserInternal.tokenSet_56_.member(this.LA(2)))
			{
				int pos = this.mark();
				flag = true;
				this.inputState.guessing++;
				try
				{
					this.match(171);
				}
				catch (RecognitionException)
				{
					flag = false;
				}
				this.rewind(pos);
				this.inputState.guessing--;
			}
			if (flag)
			{
				if (this.LA(1) == 171 && this.LA(2) == 191)
				{
					this.match(171);
					this.match(191);
					this.openXmlSchemaItemList(vParent);
					IToken token = this.LT(1);
					this.match(192);
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token);
						return;
					}
				}
				else
				{
					if (this.LA(1) != 171 || (this.LA(2) != 200 && this.LA(2) != 232 && this.LA(2) != 233))
					{
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
					this.match(171);
					SchemaObjectName tableName = this.schemaObjectThreePartName();
					if (this.inputState.guessing == 0)
					{
						vParent.TableName = tableName;
						return;
					}
				}
				return;
			}
			if (TSql80ParserInternal.tokenSet_62_.member(this.LA(1)) && TSql80ParserInternal.tokenSet_33_.member(this.LA(2)))
			{
				return;
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x06001391 RID: 5009 RVA: 0x000688C0 File Offset: 0x00066AC0
		public void openXmlSchemaItemList(OpenXmlTableReference vParent)
		{
			SchemaDeclarationItem item = this.openXmlSchemaItem();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<SchemaDeclarationItem>(vParent, vParent.SchemaDeclarationItems, item);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				item = this.openXmlSchemaItem();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<SchemaDeclarationItem>(vParent, vParent.SchemaDeclarationItems, item);
				}
			}
		}

		// Token: 0x06001392 RID: 5010 RVA: 0x0006892C File Offset: 0x00066B2C
		public SchemaDeclarationItem openXmlSchemaItem()
		{
			SchemaDeclarationItem schemaDeclarationItem = base.FragmentFactory.CreateFragment<SchemaDeclarationItem>();
			ColumnDefinitionBase columnDefinition = this.columnDefinitionBasic();
			if (this.inputState.guessing == 0)
			{
				schemaDeclarationItem.ColumnDefinition = columnDefinition;
			}
			int num = this.LA(1);
			if (num != 192 && num != 198)
			{
				switch (num)
				{
				case 230:
				case 231:
				case 234:
				{
					ValueExpression mapping = this.stringOrVariable();
					if (this.inputState.guessing == 0)
					{
						schemaDeclarationItem.Mapping = mapping;
						return schemaDeclarationItem;
					}
					return schemaDeclarationItem;
				}
				}
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			return schemaDeclarationItem;
		}

		// Token: 0x06001393 RID: 5011 RVA: 0x000689CC File Offset: 0x00066BCC
		public ColumnDefinitionBase columnDefinitionBasic()
		{
			ColumnDefinitionBase columnDefinitionBase = base.FragmentFactory.CreateFragment<ColumnDefinitionBase>();
			Identifier columnIdentifier = this.identifier();
			DataTypeReference dataType = this.scalarDataType();
			if (this.inputState.guessing == 0)
			{
				columnDefinitionBase.ColumnIdentifier = columnIdentifier;
				columnDefinitionBase.DataType = dataType;
			}
			this.collationOpt(columnDefinitionBase);
			return columnDefinitionBase;
		}

		// Token: 0x06001394 RID: 5012 RVA: 0x00068A18 File Offset: 0x00066C18
		public TableReferenceWithAlias openRowsetRowset()
		{
			IToken token = this.LT(1);
			this.match(109);
			this.match(191);
			TableReferenceWithAlias tableReferenceWithAlias;
			switch (this.LA(1))
			{
			case 230:
			case 231:
				tableReferenceWithAlias = this.openRowsetParams();
				break;
			case 232:
			case 233:
				tableReferenceWithAlias = this.internalOpenRowsetArgs();
				break;
			default:
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(tableReferenceWithAlias, token);
			}
			return tableReferenceWithAlias;
		}

		// Token: 0x06001395 RID: 5013 RVA: 0x00068AA4 File Offset: 0x00066CA4
		public OpenQueryTableReference openQueryRowset()
		{
			OpenQueryTableReference openQueryTableReference = base.FragmentFactory.CreateFragment<OpenQueryTableReference>();
			IToken token = this.LT(1);
			this.match(108);
			this.match(191);
			Identifier linkedServer = this.identifier();
			this.match(198);
			StringLiteral query = this.stringLiteral();
			IToken token2 = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(openQueryTableReference, token);
				openQueryTableReference.LinkedServer = linkedServer;
				openQueryTableReference.Query = query;
				TSql80ParserBaseInternal.UpdateTokenInfo(openQueryTableReference, token2);
			}
			return openQueryTableReference;
		}

		// Token: 0x06001396 RID: 5014 RVA: 0x00068B34 File Offset: 0x00066D34
		public AdHocTableReference adhocRowset()
		{
			AdHocTableReference adHocTableReference = base.FragmentFactory.CreateFragment<AdHocTableReference>();
			AdHocDataSource dataSource = this.adhocDataSource();
			this.match(200);
			if (this.inputState.guessing == 0)
			{
				adHocTableReference.DataSource = dataSource;
			}
			SchemaObjectNameOrValueExpression @object = this.objectOrString();
			if (this.inputState.guessing == 0)
			{
				adHocTableReference.Object = @object;
			}
			return adHocTableReference;
		}

		// Token: 0x06001397 RID: 5015 RVA: 0x00068B90 File Offset: 0x00066D90
		public OpenRowsetTableReference openRowsetParams()
		{
			OpenRowsetTableReference openRowsetTableReference = base.FragmentFactory.CreateFragment<OpenRowsetTableReference>();
			StringLiteral providerName = this.stringLiteral();
			this.match(198);
			if (this.inputState.guessing == 0)
			{
				openRowsetTableReference.ProviderName = providerName;
			}
			if ((this.LA(1) == 230 || this.LA(1) == 231) && this.LA(2) == 204)
			{
				StringLiteral dataSource = this.stringLiteral();
				if (this.inputState.guessing == 0)
				{
					openRowsetTableReference.DataSource = dataSource;
				}
				this.match(204);
				int num = this.LA(1);
				if (num != 204)
				{
					switch (num)
					{
					case 230:
					case 231:
					{
						StringLiteral userId = this.stringLiteral();
						if (this.inputState.guessing == 0)
						{
							openRowsetTableReference.UserId = userId;
						}
						break;
					}
					default:
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
				}
				this.match(204);
				int num2 = this.LA(1);
				if (num2 != 198)
				{
					switch (num2)
					{
					case 230:
					case 231:
					{
						StringLiteral password = this.stringLiteral();
						if (this.inputState.guessing == 0)
						{
							openRowsetTableReference.Password = password;
						}
						break;
					}
					default:
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
				}
			}
			else
			{
				if ((this.LA(1) != 230 && this.LA(1) != 231) || this.LA(2) != 198)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				StringLiteral providerString = this.stringLiteral();
				if (this.inputState.guessing == 0)
				{
					openRowsetTableReference.ProviderString = providerString;
				}
			}
			this.match(198);
			int num3 = this.LA(1);
			if (num3 != 200)
			{
				switch (num3)
				{
				case 230:
				case 231:
				{
					StringLiteral query = this.stringLiteral();
					if (this.inputState.guessing == 0)
					{
						openRowsetTableReference.Query = query;
						goto IL_237;
					}
					goto IL_237;
				}
				case 232:
				case 233:
					break;
				default:
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
			}
			SchemaObjectName @object = this.schemaObjectThreePartName();
			if (this.inputState.guessing == 0)
			{
				openRowsetTableReference.Object = @object;
			}
			IL_237:
			IToken token = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(openRowsetTableReference, token);
			}
			this.simpleTableReferenceAliasOpt(openRowsetTableReference);
			return openRowsetTableReference;
		}

		// Token: 0x06001398 RID: 5016 RVA: 0x00068E04 File Offset: 0x00067004
		public InternalOpenRowset internalOpenRowsetArgs()
		{
			InternalOpenRowset internalOpenRowset = base.FragmentFactory.CreateFragment<InternalOpenRowset>();
			Identifier identifier = this.identifier();
			if (this.inputState.guessing == 0)
			{
				internalOpenRowset.Identifier = identifier;
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				ScalarExpression item = this.possibleNegativeConstant();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ScalarExpression>(internalOpenRowset, internalOpenRowset.VarArgs, item);
				}
			}
			IToken token = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(internalOpenRowset, token);
			}
			this.simpleTableReferenceAliasOpt(internalOpenRowset);
			return internalOpenRowset;
		}

		// Token: 0x06001399 RID: 5017 RVA: 0x00068EA8 File Offset: 0x000670A8
		public AdHocDataSource adhocDataSource()
		{
			AdHocDataSource adHocDataSource = base.FragmentFactory.CreateFragment<AdHocDataSource>();
			IToken token = this.LT(1);
			this.match(107);
			this.match(191);
			StringLiteral providerName = this.stringLiteral();
			this.match(198);
			StringLiteral initString = this.stringLiteral();
			IToken token2 = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(adHocDataSource, token);
				adHocDataSource.ProviderName = providerName;
				adHocDataSource.InitString = initString;
				TSql80ParserBaseInternal.UpdateTokenInfo(adHocDataSource, token2);
			}
			return adHocDataSource;
		}

		// Token: 0x0600139A RID: 5018 RVA: 0x00068F38 File Offset: 0x00067138
		public SchemaObjectNameOrValueExpression objectOrString()
		{
			SchemaObjectNameOrValueExpression schemaObjectNameOrValueExpression = base.FragmentFactory.CreateFragment<SchemaObjectNameOrValueExpression>();
			int num = this.LA(1);
			if (num != 200)
			{
				switch (num)
				{
				case 230:
				case 231:
				{
					Literal valueExpression = this.stringLiteral();
					if (this.inputState.guessing == 0)
					{
						schemaObjectNameOrValueExpression.ValueExpression = valueExpression;
						return schemaObjectNameOrValueExpression;
					}
					return schemaObjectNameOrValueExpression;
				}
				case 232:
				case 233:
					break;
				default:
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
			}
			SchemaObjectName schemaObjectName = this.schemaObjectThreePartName();
			if (this.inputState.guessing == 0)
			{
				schemaObjectNameOrValueExpression.SchemaObjectName = schemaObjectName;
			}
			return schemaObjectNameOrValueExpression;
		}

		// Token: 0x0600139B RID: 5019 RVA: 0x00068FD0 File Offset: 0x000671D0
		public void simpleTableHints(TSqlFragment vParent, IList<TableHint> hints, ref bool withSpecified)
		{
			int num = this.LA(1);
			if (num != 171)
			{
				if (num != 191)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				this.tableHints(vParent, hints, true);
				return;
			}
			else
			{
				IToken token = this.LT(1);
				this.match(171);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token);
					withSpecified = true;
				}
				if (this.LA(1) == 191 && this.LA(2) == 221)
				{
					IndexTableHint item = this.oldForceIndex();
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.AddAndUpdateTokenInfo<TableHint>(vParent, hints, item);
						return;
					}
					return;
				}
				else
				{
					if (this.LA(1) == 191 && (this.LA(2) == 78 || this.LA(2) == 84 || this.LA(2) == 232))
					{
						this.tableHints(vParent, hints, true);
						return;
					}
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
			}
		}

		// Token: 0x0600139C RID: 5020 RVA: 0x000690D0 File Offset: 0x000672D0
		public TableHint tableHint(bool indexHintAllowed)
		{
			int num = this.LA(1);
			if (num != 78)
			{
				if (num == 84)
				{
					return this.indexTableHint(indexHintAllowed);
				}
				if (num != 232)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
			}
			return this.simpleTableHint();
		}

		// Token: 0x0600139D RID: 5021 RVA: 0x00069120 File Offset: 0x00067320
		public TableHint simpleTableHint()
		{
			TableHint tableHint = base.FragmentFactory.CreateFragment<TableHint>();
			int num = this.LA(1);
			if (num != 78)
			{
				if (num != 232)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				IToken token = this.LT(1);
				this.match(232);
				if (this.inputState.guessing == 0)
				{
					tableHint.HintKind = TableHintOptionsHelper.Instance.ParseOption(token, SqlVersionFlags.TSql80);
					TSql80ParserBaseInternal.UpdateTokenInfo(tableHint, token);
				}
			}
			else
			{
				IToken token2 = this.LT(1);
				this.match(78);
				if (this.inputState.guessing == 0)
				{
					tableHint.HintKind = TableHintKind.HoldLock;
					TSql80ParserBaseInternal.UpdateTokenInfo(tableHint, token2);
				}
			}
			return tableHint;
		}

		// Token: 0x0600139E RID: 5022 RVA: 0x000691D0 File Offset: 0x000673D0
		public IndexTableHint indexTableHint(bool indexHintAllowed)
		{
			IndexTableHint indexTableHint = base.FragmentFactory.CreateFragment<IndexTableHint>();
			IToken token = this.LT(1);
			this.match(84);
			if (this.inputState.guessing == 0)
			{
				if (!indexHintAllowed)
				{
					TSql80ParserBaseInternal.ThrowParseErrorException("SQL46074", token, TSqlParserResource.SQL46074Message, new string[0]);
				}
				TSql80ParserBaseInternal.UpdateTokenInfo(indexTableHint, token);
				indexTableHint.HintKind = TableHintKind.Index;
			}
			int num = this.LA(1);
			if (num != 191)
			{
				if (num != 206)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				this.match(206);
				IdentifierOrValueExpression item = this.identifierOrInteger();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<IdentifierOrValueExpression>(indexTableHint, indexTableHint.IndexValues, item);
				}
			}
			else
			{
				this.match(191);
				IdentifierOrValueExpression item = this.identifierOrInteger();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<IdentifierOrValueExpression>(indexTableHint, indexTableHint.IndexValues, item);
				}
				while (this.LA(1) == 198)
				{
					this.match(198);
					item = this.identifierOrInteger();
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.AddAndUpdateTokenInfo<IdentifierOrValueExpression>(indexTableHint, indexTableHint.IndexValues, item);
					}
				}
				IToken token2 = this.LT(1);
				this.match(192);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(indexTableHint, token2);
				}
			}
			return indexTableHint;
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x0006932C File Offset: 0x0006752C
		public IdentifierOrValueExpression identifierOrInteger()
		{
			IdentifierOrValueExpression identifierOrValueExpression = base.FragmentFactory.CreateFragment<IdentifierOrValueExpression>();
			int num = this.LA(1);
			if (num != 221)
			{
				switch (num)
				{
				case 232:
				case 233:
				{
					Identifier identifier = this.identifier();
					if (this.inputState.guessing == 0)
					{
						identifierOrValueExpression.Identifier = identifier;
					}
					break;
				}
				default:
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
			}
			else
			{
				Literal valueExpression = this.integer();
				if (this.inputState.guessing == 0)
				{
					identifierOrValueExpression.ValueExpression = valueExpression;
				}
			}
			return identifierOrValueExpression;
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x000693BC File Offset: 0x000675BC
		public void singleOldStyleTableHint(TSqlFragment vParent, IList<TableHint> hints)
		{
			IToken token = this.LT(1);
			this.match(191);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token);
			}
			TableHint item = this.tableHint(true);
			IToken token2 = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<TableHint>(vParent, hints, item);
				TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token2);
			}
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x0006942C File Offset: 0x0006762C
		public WhereClause whereCurrentOfCursorClause()
		{
			WhereClause whereClause = base.FragmentFactory.CreateFragment<WhereClause>();
			IToken token = this.LT(1);
			this.match(169);
			this.match(37);
			this.match(102);
			CursorId cursor = this.cursorId();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(whereClause, token);
				whereClause.Cursor = cursor;
			}
			return whereClause;
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x00069490 File Offset: 0x00067690
		public ExpressionGroupingSpecification simpleGroupByItem()
		{
			ExpressionGroupingSpecification expressionGroupingSpecification = base.FragmentFactory.CreateFragment<ExpressionGroupingSpecification>();
			ScalarExpression expression = this.expression();
			if (this.inputState.guessing == 0)
			{
				expressionGroupingSpecification.Expression = expression;
			}
			return expressionGroupingSpecification;
		}

		// Token: 0x060013A3 RID: 5027 RVA: 0x000694C8 File Offset: 0x000676C8
		public ExpressionWithSortOrder expressionWithSortOrder()
		{
			ExpressionWithSortOrder expressionWithSortOrder = base.FragmentFactory.CreateFragment<ExpressionWithSortOrder>();
			ScalarExpression expression = this.expression();
			if (this.inputState.guessing == 0)
			{
				expressionWithSortOrder.Expression = expression;
			}
			int num = this.LA(1);
			if (num <= 92)
			{
				if (num <= 29)
				{
					if (num <= 6)
					{
						if (num != 1 && num != 6)
						{
							goto IL_2D9;
						}
						return expressionWithSortOrder;
					}
					else
					{
						switch (num)
						{
						case 10:
							break;
						case 11:
						case 14:
						case 16:
							goto IL_2D9;
						case 12:
						case 13:
						case 15:
						case 17:
							return expressionWithSortOrder;
						default:
							switch (num)
							{
							case 22:
							case 23:
								return expressionWithSortOrder;
							default:
								switch (num)
								{
								case 28:
								case 29:
									return expressionWithSortOrder;
								default:
									goto IL_2D9;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num <= 75)
				{
					switch (num)
					{
					case 33:
					case 35:
						return expressionWithSortOrder;
					case 34:
						goto IL_2D9;
					default:
						switch (num)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 59:
						case 60:
						case 61:
						case 64:
						case 67:
							return expressionWithSortOrder;
						case 47:
						case 51:
						case 52:
						case 53:
						case 57:
						case 58:
						case 62:
						case 63:
						case 65:
						case 66:
							goto IL_2D9;
						case 50:
							break;
						default:
							switch (num)
							{
							case 74:
							case 75:
								return expressionWithSortOrder;
							default:
								goto IL_2D9;
							}
							break;
						}
						break;
					}
				}
				else
				{
					if (num == 82)
					{
						return expressionWithSortOrder;
					}
					switch (num)
					{
					case 86:
					case 87:
						return expressionWithSortOrder;
					default:
						if (num != 92)
						{
							goto IL_2D9;
						}
						return expressionWithSortOrder;
					}
				}
				SortOrder sortOrder = this.orderByOption(expressionWithSortOrder);
				if (this.inputState.guessing == 0)
				{
					expressionWithSortOrder.SortOrder = sortOrder;
					return expressionWithSortOrder;
				}
				return expressionWithSortOrder;
			}
			else if (num <= 144)
			{
				if (num <= 106)
				{
					if (num == 95 || num == 106)
					{
						return expressionWithSortOrder;
					}
				}
				else
				{
					if (num == 111 || num == 119)
					{
						return expressionWithSortOrder;
					}
					switch (num)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return expressionWithSortOrder;
					}
				}
			}
			else if (num <= 192)
			{
				switch (num)
				{
				case 156:
				case 158:
				case 160:
				case 161:
				case 162:
				case 167:
				case 170:
				case 171:
				case 172:
				case 173:
				case 176:
					return expressionWithSortOrder;
				case 157:
				case 159:
				case 163:
				case 164:
				case 165:
				case 166:
				case 168:
				case 169:
				case 174:
				case 175:
					break;
				default:
					switch (num)
					{
					case 180:
					case 181:
						return expressionWithSortOrder;
					default:
						switch (num)
						{
						case 191:
						case 192:
							return expressionWithSortOrder;
						}
						break;
					}
					break;
				}
			}
			else
			{
				if (num == 198 || num == 204)
				{
					return expressionWithSortOrder;
				}
				switch (num)
				{
				case 219:
				case 220:
					return expressionWithSortOrder;
				}
			}
			IL_2D9:
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x000697C4 File Offset: 0x000679C4
		public ComputeFunction computeFunction()
		{
			ComputeFunction computeFunction = base.FragmentFactory.CreateFragment<ComputeFunction>();
			IToken token = this.LT(1);
			this.match(232);
			if (this.inputState.guessing == 0)
			{
				computeFunction.ComputeFunctionType = ComputeFunctionTypeHelper.Instance.ParseOption(token);
			}
			this.match(191);
			ScalarExpression expression = this.expression();
			if (this.inputState.guessing == 0)
			{
				computeFunction.Expression = expression;
			}
			IToken token2 = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(computeFunction, token2);
			}
			return computeFunction;
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x00069860 File Offset: 0x00067A60
		public SortOrder orderByOption(TSqlFragment vParent)
		{
			SortOrder result = SortOrder.NotSpecified;
			int num = this.LA(1);
			if (num != 10)
			{
				if (num != 50)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				IToken token = this.LT(1);
				this.match(50);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token);
					result = SortOrder.Descending;
				}
			}
			else
			{
				IToken token2 = this.LT(1);
				this.match(10);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token2);
					result = SortOrder.Ascending;
				}
			}
			return result;
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x000698EC File Offset: 0x00067AEC
		public XmlForClause xmlForClause()
		{
			XmlForClause xmlForClause = base.FragmentFactory.CreateFragment<XmlForClause>();
			XmlForClauseOptions xmlForClauseOptions = XmlForClauseOptions.None;
			IToken token = this.LT(1);
			this.match(232);
			XmlForClauseOption xmlForClauseOption = this.xmlForClauseMode();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.Match(token, "XML");
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<XmlForClauseOption>(xmlForClause, xmlForClause.Options, xmlForClauseOption);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				xmlForClauseOption = this.xmlParam(xmlForClauseOptions);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<XmlForClauseOption>(xmlForClause, xmlForClause.Options, xmlForClauseOption);
					xmlForClauseOptions |= xmlForClauseOption.OptionKind;
				}
			}
			return xmlForClause;
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x00069990 File Offset: 0x00067B90
		public UpdateForClause updateForClause()
		{
			UpdateForClause updateForClause = base.FragmentFactory.CreateFragment<UpdateForClause>();
			IToken token = this.LT(1);
			this.match(160);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(updateForClause, token);
			}
			int num = this.LA(1);
			if (num <= 95)
			{
				if (num <= 35)
				{
					if (num <= 17)
					{
						if (num == 1 || num == 6)
						{
							return updateForClause;
						}
						switch (num)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							return updateForClause;
						}
					}
					else
					{
						switch (num)
						{
						case 22:
						case 23:
							return updateForClause;
						default:
							if (num == 28)
							{
								return updateForClause;
							}
							switch (num)
							{
							case 33:
							case 35:
								return updateForClause;
							}
							break;
						}
					}
				}
				else if (num <= 82)
				{
					switch (num)
					{
					case 44:
					case 45:
					case 46:
					case 48:
					case 49:
					case 54:
					case 55:
					case 56:
					case 60:
					case 61:
					case 64:
						return updateForClause;
					case 47:
					case 50:
					case 51:
					case 52:
					case 53:
					case 57:
					case 58:
					case 59:
					case 62:
					case 63:
						break;
					default:
						switch (num)
						{
						case 74:
						case 75:
							return updateForClause;
						default:
							if (num == 82)
							{
								return updateForClause;
							}
							break;
						}
						break;
					}
				}
				else if (num == 86 || num == 92 || num == 95)
				{
					return updateForClause;
				}
			}
			else if (num <= 162)
			{
				if (num <= 111)
				{
					if (num == 102)
					{
						this.match(102);
						ColumnReferenceExpression item = this.column();
						if (this.inputState.guessing == 0)
						{
							TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ColumnReferenceExpression>(updateForClause, updateForClause.Columns, item);
						}
						while (this.LA(1) == 198)
						{
							this.match(198);
							item = this.column();
							if (this.inputState.guessing == 0)
							{
								TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ColumnReferenceExpression>(updateForClause, updateForClause.Columns, item);
							}
						}
						return updateForClause;
					}
					if (num == 106 || num == 111)
					{
						return updateForClause;
					}
				}
				else
				{
					if (num == 119)
					{
						return updateForClause;
					}
					switch (num)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return updateForClause;
					case 124:
					case 127:
					case 128:
					case 130:
					case 133:
					case 135:
					case 136:
					case 137:
					case 139:
					case 141:
						break;
					default:
						switch (num)
						{
						case 156:
						case 160:
						case 161:
						case 162:
							return updateForClause;
						}
						break;
					}
				}
			}
			else if (num <= 181)
			{
				switch (num)
				{
				case 167:
				case 170:
				case 172:
				case 173:
					return updateForClause;
				case 168:
				case 169:
				case 171:
					break;
				default:
					if (num == 176)
					{
						return updateForClause;
					}
					switch (num)
					{
					case 180:
					case 181:
						return updateForClause;
					}
					break;
				}
			}
			else
			{
				if (num == 191 || num == 204)
				{
					return updateForClause;
				}
				switch (num)
				{
				case 219:
				case 220:
					return updateForClause;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x060013A8 RID: 5032 RVA: 0x00069CAC File Offset: 0x00067EAC
		public XmlForClauseOption xmlForClauseMode()
		{
			XmlForClauseOption xmlForClauseOption = base.FragmentFactory.CreateFragment<XmlForClauseOption>();
			IToken token = this.LT(1);
			this.match(232);
			if (this.inputState.guessing == 0)
			{
				xmlForClauseOption.OptionKind = XmlForClauseModeHelper.Instance.ParseOption(token);
				TSql80ParserBaseInternal.UpdateTokenInfo(xmlForClauseOption, token);
			}
			if (this.LA(1) == 191 && (this.LA(2) == 230 || this.LA(2) == 231))
			{
				IToken token2 = this.LT(1);
				this.match(191);
				Literal value = this.stringLiteral();
				IToken token3 = this.LT(1);
				this.match(192);
				if (this.inputState.guessing == 0)
				{
					if (xmlForClauseOption.OptionKind == XmlForClauseOptions.Explicit || xmlForClauseOption.OptionKind == XmlForClauseOptions.Auto)
					{
						throw TSql80ParserBaseInternal.GetUnexpectedTokenErrorException(token2);
					}
					xmlForClauseOption.Value = value;
					TSql80ParserBaseInternal.UpdateTokenInfo(xmlForClauseOption, token3);
				}
			}
			else if (!TSql80ParserInternal.tokenSet_63_.member(this.LA(1)) || !TSql80ParserInternal.tokenSet_11_.member(this.LA(2)))
			{
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			return xmlForClauseOption;
		}

		// Token: 0x060013A9 RID: 5033 RVA: 0x00069DD0 File Offset: 0x00067FD0
		public XmlForClauseOption xmlParam(XmlForClauseOptions encountered)
		{
			XmlForClauseOption xmlForClauseOption = base.FragmentFactory.CreateFragment<XmlForClauseOption>();
			IToken token = this.LT(1);
			this.match(232);
			if (this.LA(1) == 191 && (this.LA(2) == 230 || this.LA(2) == 231))
			{
				IToken token2 = this.LT(1);
				this.match(191);
				Literal value = this.stringLiteral();
				IToken token3 = this.LT(1);
				this.match(192);
				if (this.inputState.guessing == 0)
				{
					if (!TSql80ParserBaseInternal.TryMatch(token, "XMLSCHEMA") && !TSql80ParserBaseInternal.TryMatch(token, "ROOT"))
					{
						throw TSql80ParserBaseInternal.GetUnexpectedTokenErrorException(token2);
					}
					xmlForClauseOption.Value = value;
					TSql80ParserBaseInternal.UpdateTokenInfo(xmlForClauseOption, token3);
				}
			}
			else if (this.LA(1) == 232)
			{
				IToken token4 = this.LT(1);
				this.match(232);
				if (this.inputState.guessing == 0)
				{
					if (TSql80ParserBaseInternal.TryMatch(token, "BINARY"))
					{
						TSql80ParserBaseInternal.Match(token4, "BASE64");
						xmlForClauseOption.OptionKind = XmlForClauseOptions.BinaryBase64;
					}
					else
					{
						TSql80ParserBaseInternal.Match(token, "ELEMENTS");
						if (TSql80ParserBaseInternal.TryMatch(token4, "XSINIL"))
						{
							xmlForClauseOption.OptionKind = XmlForClauseOptions.ElementsXsiNil;
						}
						else
						{
							TSql80ParserBaseInternal.Match(token4, "ABSENT");
							xmlForClauseOption.OptionKind = XmlForClauseOptions.ElementsAbsent;
						}
					}
					TSql80ParserBaseInternal.UpdateTokenInfo(xmlForClauseOption, token4);
				}
			}
			else if (!TSql80ParserInternal.tokenSet_63_.member(this.LA(1)) || !TSql80ParserInternal.tokenSet_11_.member(this.LA(2)))
			{
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			if (this.inputState.guessing == 0)
			{
				if (xmlForClauseOption.OptionKind == XmlForClauseOptions.None)
				{
					xmlForClauseOption.OptionKind = XmlForClauseOptionsHelper.Instance.ParseOption(token);
					TSql80ParserBaseInternal.UpdateTokenInfo(xmlForClauseOption, token);
				}
				TSql80ParserBaseInternal.CheckXmlForClauseOptionDuplication(encountered, xmlForClauseOption.OptionKind, token);
			}
			return xmlForClauseOption;
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x00069FBC File Offset: 0x000681BC
		public OptimizerHint hint()
		{
			OptimizerHint result;
			if ((this.LA(1) == 113 || this.LA(1) == 232) && TSql80ParserInternal.tokenSet_64_.member(this.LA(2)))
			{
				result = this.simpleOptimizerHint();
			}
			else
			{
				if (this.LA(1) != 232 || this.LA(2) != 221)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				result = this.literalOptimizerHint();
			}
			return result;
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x0006A038 File Offset: 0x00068238
		public OptimizerHint simpleOptimizerHint()
		{
			OptimizerHint optimizerHint = base.FragmentFactory.CreateFragment<OptimizerHint>();
			if (this.LA(1) == 232 && this.LA(2) == 90)
			{
				IToken token = this.LT(1);
				this.match(232);
				this.match(90);
				if (this.inputState.guessing == 0)
				{
					optimizerHint.HintKind = TSql80ParserBaseInternal.ParseJoinOptimizerHint(token);
				}
			}
			else if (this.LA(1) == 232 && this.LA(2) == 158)
			{
				IToken token2 = this.LT(1);
				this.match(232);
				this.match(158);
				if (this.inputState.guessing == 0)
				{
					optimizerHint.HintKind = TSql80ParserBaseInternal.ParseUnionOptimizerHint(token2);
				}
			}
			else if (this.LA(1) == 232 && this.LA(2) == 113)
			{
				IToken token3 = this.LT(1);
				this.match(232);
				this.match(113);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.Match(token3, "FORCE");
					optimizerHint.HintKind = OptimizerHintKind.ForceOrder;
				}
			}
			else if (this.LA(1) == 232 && this.LA(2) == 76)
			{
				IToken token4 = this.LT(1);
				this.match(232);
				this.match(76);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.Match(token4, "HASH");
					optimizerHint.HintKind = OptimizerHintKind.HashGroup;
				}
			}
			else if (this.LA(1) == 113)
			{
				this.LT(1);
				this.match(113);
				this.match(76);
				if (this.inputState.guessing == 0)
				{
					optimizerHint.HintKind = OptimizerHintKind.OrderGroup;
				}
			}
			else if (this.LA(1) == 232 && this.LA(2) == 117)
			{
				IToken token5 = this.LT(1);
				this.match(232);
				this.match(117);
				if (this.inputState.guessing == 0)
				{
					optimizerHint.HintKind = PlanOptimizerHintHelper.Instance.ParseOption(token5, SqlVersionFlags.TSql80);
				}
			}
			else
			{
				if (this.LA(1) != 232 || this.LA(2) != 232)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				IToken token6 = this.LT(1);
				this.match(232);
				IToken token7 = this.LT(1);
				this.match(232);
				if (this.inputState.guessing == 0)
				{
					if (TSql80ParserBaseInternal.TryMatch(token6, "EXPAND"))
					{
						TSql80ParserBaseInternal.Match(token7, "VIEWS");
						optimizerHint.HintKind = OptimizerHintKind.ExpandViews;
					}
					else
					{
						TSql80ParserBaseInternal.Match(token6, "BYPASS");
						TSql80ParserBaseInternal.Match(token7, "OPTIMIZER_QUEUE");
						optimizerHint.HintKind = OptimizerHintKind.BypassOptimizerQueue;
					}
				}
			}
			return optimizerHint;
		}

		// Token: 0x060013AC RID: 5036 RVA: 0x0006A318 File Offset: 0x00068518
		public LiteralOptimizerHint literalOptimizerHint()
		{
			LiteralOptimizerHint literalOptimizerHint = base.FragmentFactory.CreateFragment<LiteralOptimizerHint>();
			IToken token = this.LT(1);
			this.match(232);
			Literal value = this.integer();
			if (this.inputState.guessing == 0)
			{
				literalOptimizerHint.HintKind = IntegerOptimizerHintHelper.Instance.ParseOption(token, SqlVersionFlags.TSql80);
				literalOptimizerHint.Value = value;
			}
			return literalOptimizerHint;
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x0006A374 File Offset: 0x00068574
		public void viewStatementBody(ViewStatementBody vResult)
		{
			int num = 0;
			this.match(166);
			SchemaObjectName schemaObjectName = this.schemaObjectTwoPartName();
			if (this.inputState.guessing == 0)
			{
				vResult.SchemaObjectName = schemaObjectName;
				TSql80ParserBaseInternal.CheckForTemporaryView(schemaObjectName);
				base.ThrowPartialAstIfPhaseOne(vResult);
			}
			int num2 = this.LA(1);
			if (num2 != 9 && num2 != 171)
			{
				if (num2 != 191)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				this.columnNameList(vResult, vResult.Columns);
			}
			int num3 = this.LA(1);
			if (num3 != 9)
			{
				if (num3 != 171)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				this.match(171);
				ViewOption viewOption = this.viewOption();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.CheckOptionDuplication(ref num, (int)viewOption.OptionKind, viewOption);
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ViewOption>(vResult, vResult.ViewOptions, viewOption);
				}
				while (this.LA(1) == 198)
				{
					this.match(198);
					viewOption = this.viewOption();
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.CheckOptionDuplication(ref num, (int)viewOption.OptionKind, viewOption);
						TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ViewOption>(vResult, vResult.ViewOptions, viewOption);
					}
				}
			}
			IToken token = this.LT(1);
			this.match(9);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(vResult, token);
			}
			SelectStatement selectStatement = this.subqueryExpressionAsStatement();
			if (this.inputState.guessing == 0)
			{
				vResult.SelectStatement = selectStatement;
			}
			int num4 = this.LA(1);
			if (num4 <= 35)
			{
				if (num4 == 1 || num4 == 35)
				{
					return;
				}
			}
			else
			{
				if (num4 == 75)
				{
					return;
				}
				if (num4 != 171)
				{
					if (num4 == 219)
					{
						return;
					}
				}
				else
				{
					this.match(171);
					this.match(21);
					IToken token2 = this.LT(1);
					this.match(111);
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.UpdateTokenInfo(vResult, token2);
						vResult.WithCheckOption = true;
						return;
					}
					return;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x0006A584 File Offset: 0x00068784
		public SchemaObjectName schemaObjectTwoPartName()
		{
			SchemaObjectName schemaObjectName = base.FragmentFactory.CreateFragment<SchemaObjectName>();
			List<Identifier> otherCollection = this.identifierList(2);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<Identifier>(schemaObjectName, schemaObjectName.Identifiers, otherCollection);
			}
			return schemaObjectName;
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x0006A5C0 File Offset: 0x000687C0
		public ViewOption viewOption()
		{
			ViewOption viewOption = base.FragmentFactory.CreateFragment<ViewOption>();
			IToken token = this.LT(1);
			this.match(232);
			if (this.inputState.guessing == 0)
			{
				viewOption.OptionKind = ViewOptionHelper.Instance.ParseOption(token);
				TSql80ParserBaseInternal.UpdateTokenInfo(viewOption, token);
			}
			return viewOption;
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x0006A614 File Offset: 0x00068814
		public TriggerOption triggerOption()
		{
			TriggerOption triggerOption = base.FragmentFactory.CreateFragment<TriggerOption>();
			IToken token = this.LT(1);
			this.match(232);
			if (this.inputState.guessing == 0)
			{
				triggerOption.OptionKind = TriggerOptionHelper.Instance.ParseOption(token);
				TSql80ParserBaseInternal.UpdateTokenInfo(triggerOption, token);
			}
			return triggerOption;
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x0006A668 File Offset: 0x00068868
		public void procedureOptions(ProcedureStatementBody vParent)
		{
			int num = 0;
			this.match(171);
			ProcedureOption procedureOption = this.procedureOption();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.CheckOptionDuplication(ref num, (int)procedureOption.OptionKind, procedureOption);
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ProcedureOption>(vParent, vParent.Options, procedureOption);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				procedureOption = this.procedureOption();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.CheckOptionDuplication(ref num, (int)procedureOption.OptionKind, procedureOption);
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ProcedureOption>(vParent, vParent.Options, procedureOption);
				}
			}
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x0006A6FC File Offset: 0x000688FC
		public ProcedureOption procedureOption()
		{
			ProcedureOption procedureOption = base.FragmentFactory.CreateFragment<ProcedureOption>();
			IToken token = this.LT(1);
			this.match(232);
			if (this.inputState.guessing == 0)
			{
				procedureOption.OptionKind = ProcedureOptionHelper.Instance.ParseOption(token);
				TSql80ParserBaseInternal.UpdateTokenInfo(procedureOption, token);
			}
			return procedureOption;
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x0006A750 File Offset: 0x00068950
		public void procedureStatementBody(ProcedureStatementBody vResult, out bool vParseErrorOccurred)
		{
			vParseErrorOccurred = false;
			try
			{
				switch (this.LA(1))
				{
				case 120:
					this.match(120);
					break;
				case 121:
					this.match(121);
					break;
				default:
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				ProcedureReference procedureReference = this.procedureReference();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.CheckTwoPartNameForSchemaObjectName(procedureReference.Name, "PROCEDURE");
					vResult.ProcedureReference = procedureReference;
				}
				if (this.inputState.guessing == 0)
				{
					base.ThrowPartialAstIfPhaseOne(vResult);
				}
				this.procedureParameterListOptionalParen(vResult);
				int num = this.LA(1);
				if (num != 9 && num != 67)
				{
					if (num != 171)
					{
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
					this.procedureOptions(vResult);
				}
				int num2 = this.LA(1);
				if (num2 != 9)
				{
					if (num2 != 67)
					{
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
					this.match(67);
					this.match(128);
					if (this.inputState.guessing == 0)
					{
						vResult.IsForReplication = true;
					}
				}
				IToken token = this.LT(1);
				this.match(9);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(vResult, token);
				}
				int num3 = this.LA(1);
				if (num3 <= 86)
				{
					if (num3 <= 28)
					{
						if (num3 <= 6)
						{
							if (num3 == 1)
							{
								goto IL_3BC;
							}
							if (num3 != 6)
							{
								goto IL_3A9;
							}
						}
						else
						{
							switch (num3)
							{
							case 12:
							case 13:
							case 15:
							case 17:
								break;
							case 14:
							case 16:
								goto IL_3A9;
							default:
								switch (num3)
								{
								case 22:
								case 23:
									break;
								default:
									if (num3 != 28)
									{
										goto IL_3A9;
									}
									break;
								}
								break;
							}
						}
					}
					else if (num3 <= 64)
					{
						switch (num3)
						{
						case 33:
						case 35:
							break;
						case 34:
							goto IL_3A9;
						default:
							switch (num3)
							{
							case 44:
							case 45:
							case 46:
							case 48:
							case 49:
							case 54:
								break;
							case 47:
							case 50:
							case 51:
							case 52:
							case 53:
								goto IL_3A9;
							default:
								switch (num3)
								{
								case 60:
								case 61:
								case 64:
									break;
								case 62:
								case 63:
									goto IL_3A9;
								default:
									goto IL_3A9;
								}
								break;
							}
							break;
						}
					}
					else
					{
						switch (num3)
						{
						case 74:
						case 75:
							break;
						default:
							if (num3 != 82 && num3 != 86)
							{
								goto IL_3A9;
							}
							break;
						}
					}
				}
				else if (num3 <= 144)
				{
					if (num3 <= 95)
					{
						if (num3 != 92 && num3 != 95)
						{
							goto IL_3A9;
						}
					}
					else if (num3 != 106 && num3 != 119)
					{
						switch (num3)
						{
						case 123:
						case 125:
						case 126:
						case 129:
						case 131:
						case 132:
						case 134:
						case 138:
						case 140:
						case 142:
						case 143:
						case 144:
							break;
						case 124:
						case 127:
						case 128:
						case 130:
						case 133:
						case 135:
						case 136:
						case 137:
						case 139:
						case 141:
							goto IL_3A9;
						default:
							goto IL_3A9;
						}
					}
				}
				else if (num3 <= 176)
				{
					switch (num3)
					{
					case 156:
					case 160:
					case 161:
					case 162:
						break;
					case 157:
					case 158:
					case 159:
						goto IL_3A9;
					default:
						switch (num3)
						{
						case 167:
						case 170:
						case 172:
						case 173:
							break;
						case 168:
						case 169:
						case 171:
							goto IL_3A9;
						default:
							if (num3 != 176)
							{
								goto IL_3A9;
							}
							break;
						}
						break;
					}
				}
				else
				{
					switch (num3)
					{
					case 180:
					case 181:
						break;
					default:
						if (num3 != 191)
						{
							switch (num3)
							{
							case 219:
								goto IL_3BC;
							case 220:
								break;
							default:
								goto IL_3A9;
							}
						}
						break;
					}
				}
				StatementList statementList = this.statementList(ref vParseErrorOccurred);
				if (this.inputState.guessing == 0)
				{
					vResult.StatementList = statementList;
					goto IL_3BC;
				}
				goto IL_3BC;
				IL_3A9:
				throw new NoViableAltException(this.LT(1), this.getFilename());
				IL_3BC:;
			}
			catch (NoViableAltException)
			{
				if (this.inputState.guessing != 0)
				{
					throw;
				}
				if (!base.PhaseOne || vResult == null || vResult.ProcedureReference == null || vResult.ProcedureReference.Name == null)
				{
					throw;
				}
				base.ThrowPartialAstIfPhaseOne(vResult);
			}
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x0006AB74 File Offset: 0x00068D74
		public ProcedureReference procedureReference()
		{
			ProcedureReference procedureReference = base.FragmentFactory.CreateFragment<ProcedureReference>();
			SchemaObjectName name = this.schemaObjectFourPartName();
			Literal number = this.procNumOpt();
			if (this.inputState.guessing == 0)
			{
				procedureReference.Name = name;
				procedureReference.Number = number;
			}
			return procedureReference;
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x0006ABB8 File Offset: 0x00068DB8
		public void procedureParameterListOptionalParen(ProcedureStatementBodyBase vResult)
		{
			int num = this.LA(1);
			if (num <= 67)
			{
				if (num != 9 && num != 67)
				{
					goto IL_B6;
				}
			}
			else if (num != 171)
			{
				if (num != 191)
				{
					if (num != 234)
					{
						goto IL_B6;
					}
				}
				else
				{
					this.match(191);
					this.procedureParameterList(vResult);
					IToken token = this.LT(1);
					this.match(192);
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.UpdateTokenInfo(vResult, token);
						return;
					}
					return;
				}
			}
			int num2 = this.LA(1);
			if (num2 <= 67)
			{
				if (num2 == 9 || num2 == 67)
				{
					return;
				}
			}
			else
			{
				if (num2 == 171)
				{
					return;
				}
				if (num2 == 234)
				{
					this.procedureParameterList(vResult);
					return;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_B6:
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x0006AC90 File Offset: 0x00068E90
		public void procedureParameterList(ProcedureStatementBodyBase vResult)
		{
			ProcedureParameter item = this.procedureParameter();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ProcedureParameter>(vResult, vResult.Parameters, item);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				item = this.procedureParameter();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ProcedureParameter>(vResult, vResult.Parameters, item);
				}
			}
		}

		// Token: 0x060013B7 RID: 5047 RVA: 0x0006ACFC File Offset: 0x00068EFC
		public ProcedureParameter procedureParameter()
		{
			ProcedureParameter procedureParameter = base.FragmentFactory.CreateFragment<ProcedureParameter>();
			Identifier variableName = this.identifierVariable();
			int num = this.LA(1);
			if (num <= 42)
			{
				if (num == 9)
				{
					this.match(9);
					goto IL_69;
				}
				if (num == 42)
				{
					goto IL_69;
				}
			}
			else
			{
				if (num == 53 || num == 96)
				{
					goto IL_69;
				}
				switch (num)
				{
				case 232:
				case 233:
					goto IL_69;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_69:
			if (this.inputState.guessing == 0)
			{
				procedureParameter.VariableName = variableName;
			}
			int num2 = this.LA(1);
			if (num2 <= 53)
			{
				if (num2 == 42)
				{
					this.cursorProcedureParameter(procedureParameter);
					return procedureParameter;
				}
				if (num2 != 53)
				{
					goto IL_C4;
				}
			}
			else if (num2 != 96)
			{
				switch (num2)
				{
				case 232:
				case 233:
					break;
				default:
					goto IL_C4;
				}
			}
			this.scalarProcedureParameter(procedureParameter, true);
			return procedureParameter;
			IL_C4:
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x0006ADE4 File Offset: 0x00068FE4
		public void cursorProcedureParameter(ProcedureParameter vParent)
		{
			DataTypeReference dataType = this.cursorDataType();
			if (this.inputState.guessing == 0)
			{
				vParent.DataType = dataType;
			}
			IToken token = this.LT(1);
			this.match(165);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token);
				vParent.IsVarying = true;
			}
			IToken token2 = this.LT(1);
			this.match(232);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.Match(token2, "OUTPUT", "OUT");
				vParent.Modifier = ParameterModifier.Output;
				TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token2);
			}
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x0006AE7C File Offset: 0x0006907C
		public IdentifierLiteral identifierLiteral()
		{
			IdentifierLiteral identifierLiteral = base.FragmentFactory.CreateFragment<IdentifierLiteral>();
			switch (this.LA(1))
			{
			case 232:
			{
				IToken token = this.LT(1);
				this.match(232);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(identifierLiteral, token);
					identifierLiteral.SetUnquotedIdentifier(token.getText());
					TSql80ParserBaseInternal.CheckIdentifierLiteralLength(identifierLiteral);
				}
				break;
			}
			case 233:
			{
				IToken token2 = this.LT(1);
				this.match(233);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(identifierLiteral, token2);
					identifierLiteral.SetIdentifier(token2.getText());
					TSql80ParserBaseInternal.CheckIdentifierLiteralLength(identifierLiteral);
				}
				break;
			}
			default:
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			return identifierLiteral;
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x0006AF44 File Offset: 0x00069144
		public DefaultLiteral defaultLiteral()
		{
			DefaultLiteral defaultLiteral = base.FragmentFactory.CreateFragment<DefaultLiteral>();
			IToken token = this.LT(1);
			this.match(47);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(defaultLiteral, token);
				defaultLiteral.Value = token.getText();
			}
			return defaultLiteral;
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x0006AF90 File Offset: 0x00069190
		public ValueExpression literal()
		{
			int num = this.LA(1);
			ValueExpression result;
			if (num != 100)
			{
				if (num != 193)
				{
					switch (num)
					{
					case 221:
						return this.integer();
					case 222:
						return this.numeric();
					case 223:
						return this.real();
					case 224:
						return this.binary();
					case 225:
						return this.moneyLiteral();
					case 230:
					case 231:
						return this.stringLiteral();
					case 234:
						return this.globalVariableOrVariableReference();
					}
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				result = this.odbcLiteral();
			}
			else
			{
				result = this.nullLiteral();
			}
			return result;
		}

		// Token: 0x060013BC RID: 5052 RVA: 0x0006B064 File Offset: 0x00069264
		public UnaryExpression negativeConstant()
		{
			UnaryExpression unaryExpression = base.FragmentFactory.CreateFragment<UnaryExpression>();
			IToken token = this.LT(1);
			this.match(199);
			Literal expression = this.subroutineParameterLiteral();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(unaryExpression, token);
				unaryExpression.UnaryExpressionType = UnaryExpressionType.Negative;
				unaryExpression.Expression = expression;
			}
			return unaryExpression;
		}

		// Token: 0x060013BD RID: 5053 RVA: 0x0006B0BC File Offset: 0x000692BC
		public Literal subroutineParameterLiteral()
		{
			switch (this.LA(1))
			{
			case 221:
				return this.integer();
			case 222:
				return this.numeric();
			case 223:
				return this.real();
			case 225:
				return this.moneyLiteral();
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x0006B12C File Offset: 0x0006932C
		public void triggerStatementBody(TriggerStatementBody vResult, out bool vParseErrorOccurred)
		{
			vParseErrorOccurred = false;
			this.match(155);
			SchemaObjectName name = this.schemaObjectThreePartName();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.CheckTwoPartNameForSchemaObjectName(name, "TRIGGER");
				vResult.Name = name;
			}
			this.match(105);
			TriggerObject triggerObject = this.triggerObject();
			if (this.inputState.guessing == 0)
			{
				vResult.TriggerObject = triggerObject;
				base.ThrowPartialAstIfPhaseOne(vResult);
			}
			int num = this.LA(1);
			if (num != 67)
			{
				if (num != 171)
				{
					if (num != 232)
					{
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
				}
				else
				{
					this.match(171);
					TriggerOption item = this.triggerOption();
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.AddAndUpdateTokenInfo<TriggerOption>(vResult, vResult.Options, item);
					}
					while (this.LA(1) == 198)
					{
						this.match(198);
						item = this.triggerOption();
						if (this.inputState.guessing == 0)
						{
							TSql80ParserBaseInternal.AddAndUpdateTokenInfo<TriggerOption>(vResult, vResult.Options, item);
						}
					}
				}
			}
			this.dmlTriggerMidSection(vResult);
			IToken token = this.LT(1);
			this.match(9);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(vResult, token);
			}
			StatementList statementList = this.statementList(ref vParseErrorOccurred);
			if (this.inputState.guessing == 0)
			{
				vResult.StatementList = statementList;
			}
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x0006B288 File Offset: 0x00069488
		public TriggerObject triggerObject()
		{
			TriggerObject triggerObject = base.FragmentFactory.CreateFragment<TriggerObject>();
			SchemaObjectName name = this.schemaObjectThreePartName();
			if (this.inputState.guessing == 0)
			{
				triggerObject.Name = name;
				triggerObject.TriggerScope = TriggerScope.Normal;
			}
			return triggerObject;
		}

		// Token: 0x060013C0 RID: 5056 RVA: 0x0006B2C4 File Offset: 0x000694C4
		public void dmlTriggerMidSection(TriggerStatementBody vParent)
		{
			bool flag = false;
			int num = this.LA(1);
			if (num != 67)
			{
				if (num != 232)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				IToken token = this.LT(1);
				this.match(232);
				int num2 = this.LA(1);
				if (num2 <= 86)
				{
					if (num2 == 48 || num2 == 86)
					{
						goto IL_BC;
					}
				}
				else if (num2 != 102)
				{
					if (num2 == 160)
					{
						goto IL_BC;
					}
				}
				else
				{
					this.LT(1);
					this.match(102);
					if (this.inputState.guessing == 0)
					{
						flag = true;
						goto IL_BC;
					}
					goto IL_BC;
				}
				throw new NoViableAltException(this.LT(1), this.getFilename());
				IL_BC:
				if (this.inputState.guessing == 0)
				{
					if (flag)
					{
						TSql80ParserBaseInternal.Match(token, "INSTEAD");
						vParent.TriggerType = TriggerType.InsteadOf;
					}
					else
					{
						TSql80ParserBaseInternal.Match(token, "AFTER");
						vParent.TriggerType = TriggerType.After;
					}
				}
			}
			else
			{
				this.match(67);
				if (this.inputState.guessing == 0)
				{
					vParent.TriggerType = TriggerType.For;
				}
			}
			TriggerAction item = this.dmlTriggerAction();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<TriggerAction>(vParent, vParent.TriggerActions, item);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				item = this.dmlTriggerAction();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<TriggerAction>(vParent, vParent.TriggerActions, item);
				}
			}
			int num3 = this.LA(1);
			if (num3 != 9 && num3 != 99)
			{
				if (num3 != 171)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				this.match(171);
				IToken token2 = this.LT(1);
				this.match(232);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.Match(token2, "APPEND");
					vParent.WithAppend = true;
				}
			}
			int num4 = this.LA(1);
			if (num4 != 9)
			{
				if (num4 != 99)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				this.match(99);
				this.match(67);
				this.match(128);
				if (this.inputState.guessing == 0)
				{
					vParent.IsNotForReplication = true;
					return;
				}
			}
		}

		// Token: 0x060013C1 RID: 5057 RVA: 0x0006B500 File Offset: 0x00069700
		public TriggerAction dmlTriggerAction()
		{
			TriggerAction triggerAction = base.FragmentFactory.CreateFragment<TriggerAction>();
			int num = this.LA(1);
			if (num != 48)
			{
				if (num != 86)
				{
					if (num != 160)
					{
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
					IToken token = this.LT(1);
					this.match(160);
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.UpdateTokenInfo(triggerAction, token);
						triggerAction.TriggerActionType = TriggerActionType.Update;
					}
				}
				else
				{
					IToken token2 = this.LT(1);
					this.match(86);
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.UpdateTokenInfo(triggerAction, token2);
						triggerAction.TriggerActionType = TriggerActionType.Insert;
					}
				}
			}
			else
			{
				IToken token3 = this.LT(1);
				this.match(48);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(triggerAction, token3);
					triggerAction.TriggerActionType = TriggerActionType.Delete;
				}
			}
			return triggerAction;
		}

		// Token: 0x060013C2 RID: 5058 RVA: 0x0006B5E4 File Offset: 0x000697E4
		public ExecuteOption executeOption()
		{
			ExecuteOption executeOption = base.FragmentFactory.CreateFragment<ExecuteOption>();
			IToken token = this.LT(1);
			this.match(232);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.Match(token, "RECOMPILE");
				executeOption.OptionKind = ExecuteOptionKind.Recompile;
			}
			return executeOption;
		}

		// Token: 0x060013C3 RID: 5059 RVA: 0x0006B634 File Offset: 0x00069834
		public void execStart(TSqlFragment vParent)
		{
			switch (this.LA(1))
			{
			case 60:
			{
				IToken token = this.LT(1);
				this.match(60);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token);
					return;
				}
				break;
			}
			case 61:
			{
				IToken token2 = this.LT(1);
				this.match(61);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token2);
					return;
				}
				break;
			}
			default:
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x0006B6C0 File Offset: 0x000698C0
		public void execTypes(ExecuteSpecification vParent)
		{
			if (this.LA(1) == 191)
			{
				this.match(191);
				ExecutableEntity executableEntity = this.execStrTypes();
				IToken token = this.LT(1);
				this.match(192);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token);
					vParent.ExecutableEntity = executableEntity;
					return;
				}
			}
			else if (TSql80ParserInternal.tokenSet_65_.member(this.LA(1)) && TSql80ParserInternal.tokenSet_66_.member(this.LA(2)))
			{
				ExecutableEntity executableEntity = this.execProcEx();
				if (this.inputState.guessing == 0)
				{
					vParent.ExecutableEntity = executableEntity;
					return;
				}
			}
			else
			{
				if (this.LA(1) != 234 || this.LA(2) != 206)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				VariableReference variable = this.variable();
				this.match(206);
				ExecutableEntity executableEntity = this.execProcEx();
				if (this.inputState.guessing == 0)
				{
					vParent.Variable = variable;
					vParent.ExecutableEntity = executableEntity;
					return;
				}
			}
		}

		// Token: 0x060013C5 RID: 5061 RVA: 0x0006B7C8 File Offset: 0x000699C8
		public ExecutableEntity execStrTypes()
		{
			ExecutableEntity executableEntity = this.execSqlList();
			int num = this.LA(1);
			if (num != 192)
			{
				if (num != 198)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				this.match(198);
				this.setParamList(executableEntity);
			}
			return executableEntity;
		}

		// Token: 0x060013C6 RID: 5062 RVA: 0x0006B81C File Offset: 0x00069A1C
		public ExecutableProcedureReference execProcEx()
		{
			int num = this.LA(1);
			ExecutableProcedureReference result;
			if (num != 107)
			{
				if (num != 200)
				{
					switch (num)
					{
					case 232:
					case 233:
					case 234:
						break;
					default:
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
				}
				result = this.execProc();
			}
			else
			{
				result = this.adhocDataSourceExecproc();
			}
			return result;
		}

		// Token: 0x060013C7 RID: 5063 RVA: 0x0006B880 File Offset: 0x00069A80
		public ExecutableStringList execSqlList()
		{
			ExecutableStringList executableStringList = base.FragmentFactory.CreateFragment<ExecutableStringList>();
			ValueExpression item = this.stringOrGlobalVariableOrVariable();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ValueExpression>(executableStringList, executableStringList.Strings, item);
			}
			while (this.LA(1) == 197)
			{
				this.match(197);
				item = this.stringOrGlobalVariableOrVariable();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ValueExpression>(executableStringList, executableStringList.Strings, item);
				}
			}
			return executableStringList;
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x0006B8F8 File Offset: 0x00069AF8
		public void setParamList(ExecutableEntity vParent)
		{
			bool flag = false;
			int num = 0;
			ExecuteParameter item = this.setParam(ref flag, ref num);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ExecuteParameter>(vParent, vParent.Parameters, item);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				item = this.setParam(ref flag, ref num);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ExecuteParameter>(vParent, vParent.Parameters, item);
				}
			}
		}

		// Token: 0x060013C9 RID: 5065 RVA: 0x0006B970 File Offset: 0x00069B70
		public ExecutableProcedureReference adhocDataSourceExecproc()
		{
			ExecutableProcedureReference executableProcedureReference = base.FragmentFactory.CreateFragment<ExecutableProcedureReference>();
			AdHocDataSource adHocDataSource = this.adhocDataSource();
			this.match(200);
			ProcedureReferenceName procedureReference = this.procObjectReference();
			if (this.inputState.guessing == 0)
			{
				executableProcedureReference.AdHocDataSource = adHocDataSource;
				executableProcedureReference.ProcedureReference = procedureReference;
			}
			int num = this.LA(1);
			if (num <= 92)
			{
				if (num <= 28)
				{
					if (num <= 6)
					{
						if (num != 1 && num != 6)
						{
							goto IL_2F7;
						}
						return executableProcedureReference;
					}
					else
					{
						switch (num)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							return executableProcedureReference;
						case 14:
						case 16:
							goto IL_2F7;
						default:
							switch (num)
							{
							case 22:
							case 23:
								return executableProcedureReference;
							default:
								if (num != 28)
								{
									goto IL_2F7;
								}
								return executableProcedureReference;
							}
							break;
						}
					}
				}
				else if (num <= 75)
				{
					switch (num)
					{
					case 33:
					case 35:
						return executableProcedureReference;
					case 34:
						goto IL_2F7;
					default:
						switch (num)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							return executableProcedureReference;
						case 47:
							break;
						case 50:
						case 51:
						case 52:
						case 53:
						case 57:
						case 58:
						case 59:
						case 62:
						case 63:
							goto IL_2F7;
						default:
							switch (num)
							{
							case 74:
							case 75:
								return executableProcedureReference;
							default:
								goto IL_2F7;
							}
							break;
						}
						break;
					}
				}
				else
				{
					if (num != 82 && num != 86 && num != 92)
					{
						goto IL_2F7;
					}
					return executableProcedureReference;
				}
			}
			else if (num <= 144)
			{
				if (num <= 106)
				{
					if (num == 95)
					{
						return executableProcedureReference;
					}
					if (num != 100)
					{
						if (num != 106)
						{
							goto IL_2F7;
						}
						return executableProcedureReference;
					}
				}
				else
				{
					if (num == 111 || num == 119)
					{
						return executableProcedureReference;
					}
					switch (num)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return executableProcedureReference;
					case 124:
					case 127:
					case 128:
					case 130:
					case 133:
					case 135:
					case 136:
					case 137:
					case 139:
					case 141:
						goto IL_2F7;
					default:
						goto IL_2F7;
					}
				}
			}
			else if (num <= 193)
			{
				switch (num)
				{
				case 156:
				case 160:
				case 161:
				case 162:
					return executableProcedureReference;
				case 157:
				case 158:
				case 159:
					goto IL_2F7;
				default:
					switch (num)
					{
					case 167:
					case 170:
					case 171:
					case 172:
					case 173:
					case 176:
					case 180:
					case 181:
						return executableProcedureReference;
					case 168:
					case 169:
					case 174:
					case 175:
					case 177:
					case 178:
					case 179:
						goto IL_2F7;
					default:
						switch (num)
						{
						case 191:
							return executableProcedureReference;
						case 192:
							goto IL_2F7;
						case 193:
							break;
						default:
							goto IL_2F7;
						}
						break;
					}
					break;
				}
			}
			else if (num != 199)
			{
				if (num == 204)
				{
					return executableProcedureReference;
				}
				switch (num)
				{
				case 219:
				case 220:
					return executableProcedureReference;
				case 221:
				case 222:
				case 223:
				case 224:
				case 225:
				case 230:
				case 231:
				case 232:
				case 233:
				case 234:
					break;
				case 226:
				case 227:
				case 228:
				case 229:
					goto IL_2F7;
				default:
					goto IL_2F7;
				}
			}
			this.setParamList(executableProcedureReference);
			return executableProcedureReference;
			IL_2F7:
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x060013CA RID: 5066 RVA: 0x0006BC88 File Offset: 0x00069E88
		public ProcedureReferenceName procObjectReference()
		{
			ProcedureReferenceName procedureReferenceName = base.FragmentFactory.CreateFragment<ProcedureReferenceName>();
			ProcedureReference procedureReference = this.procedureReference();
			if (this.inputState.guessing == 0)
			{
				procedureReferenceName.ProcedureReference = procedureReference;
			}
			return procedureReferenceName;
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x0006BCC0 File Offset: 0x00069EC0
		public ProcedureReferenceName varObjectReference()
		{
			ProcedureReferenceName procedureReferenceName = base.FragmentFactory.CreateFragment<ProcedureReferenceName>();
			VariableReference procedureVariable = this.variable();
			if (this.inputState.guessing == 0)
			{
				procedureReferenceName.ProcedureVariable = procedureVariable;
			}
			return procedureReferenceName;
		}

		// Token: 0x060013CC RID: 5068 RVA: 0x0006BCF8 File Offset: 0x00069EF8
		public Literal procNumOpt()
		{
			Literal result = null;
			int num = this.LA(1);
			if (num <= 92)
			{
				if (num <= 28)
				{
					if (num <= 6)
					{
						if (num == 1 || num == 6)
						{
							return result;
						}
					}
					else
					{
						switch (num)
						{
						case 9:
						case 12:
						case 13:
						case 15:
						case 17:
							return result;
						case 10:
						case 11:
						case 14:
						case 16:
							break;
						default:
							switch (num)
							{
							case 22:
							case 23:
								return result;
							default:
								if (num == 28)
								{
									return result;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num <= 75)
				{
					switch (num)
					{
					case 33:
					case 35:
						return result;
					case 34:
						break;
					default:
						switch (num)
						{
						case 44:
						case 45:
						case 46:
						case 47:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
						case 67:
							return result;
						case 50:
						case 51:
						case 52:
						case 53:
						case 57:
						case 58:
						case 59:
						case 62:
						case 63:
						case 65:
						case 66:
							break;
						default:
							switch (num)
							{
							case 74:
							case 75:
								return result;
							}
							break;
						}
						break;
					}
				}
				else if (num == 82 || num == 86 || num == 92)
				{
					return result;
				}
			}
			else if (num <= 144)
			{
				if (num <= 106)
				{
					if (num == 95 || num == 100 || num == 106)
					{
						return result;
					}
				}
				else
				{
					if (num == 111 || num == 119)
					{
						return result;
					}
					switch (num)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return result;
					}
				}
			}
			else if (num <= 193)
			{
				switch (num)
				{
				case 156:
				case 160:
				case 161:
				case 162:
					return result;
				case 157:
				case 158:
				case 159:
					break;
				default:
					switch (num)
					{
					case 167:
					case 170:
					case 171:
					case 172:
					case 173:
					case 176:
					case 180:
					case 181:
						return result;
					case 168:
					case 169:
					case 174:
					case 175:
					case 177:
					case 178:
					case 179:
						break;
					default:
						switch (num)
						{
						case 191:
						case 193:
							return result;
						}
						break;
					}
					break;
				}
			}
			else
			{
				if (num == 199 || num == 204)
				{
					return result;
				}
				switch (num)
				{
				case 219:
				case 220:
				case 221:
				case 222:
				case 223:
				case 224:
				case 225:
				case 230:
				case 231:
				case 232:
				case 233:
				case 234:
					return result;
				case 236:
					this.match(236);
					return this.integer();
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x060013CD RID: 5069 RVA: 0x0006C000 File Offset: 0x0006A200
		public ValueExpression stringOrGlobalVariableOrVariable()
		{
			switch (this.LA(1))
			{
			case 230:
			case 231:
				return this.stringLiteral();
			case 234:
				return this.globalVariableOrVariableReference();
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x060013CE RID: 5070 RVA: 0x0006C060 File Offset: 0x0006A260
		public RealLiteral real()
		{
			RealLiteral realLiteral = base.FragmentFactory.CreateFragment<RealLiteral>();
			IToken token = this.LT(1);
			this.match(223);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(realLiteral, token);
				realLiteral.Value = token.getText();
			}
			return realLiteral;
		}

		// Token: 0x060013CF RID: 5071 RVA: 0x0006C0B0 File Offset: 0x0006A2B0
		public NumericLiteral numeric()
		{
			NumericLiteral numericLiteral = base.FragmentFactory.CreateFragment<NumericLiteral>();
			IToken token = this.LT(1);
			this.match(222);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(numericLiteral, token);
				numericLiteral.Value = token.getText();
			}
			return numericLiteral;
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x0006C100 File Offset: 0x0006A300
		public ExecuteParameter setParam(ref bool nameEqualsValueWasUsed, ref int parameterNumber)
		{
			ExecuteParameter executeParameter = base.FragmentFactory.CreateFragment<ExecuteParameter>();
			executeParameter.IsOutput = false;
			parameterNumber++;
			if (this.LA(1) == 234 && this.LA(2) == 206)
			{
				VariableReference variable = this.variable();
				this.match(206);
				if (this.inputState.guessing == 0)
				{
					executeParameter.Variable = variable;
				}
			}
			else if (!TSql80ParserInternal.tokenSet_67_.member(this.LA(1)) || !TSql80ParserInternal.tokenSet_68_.member(this.LA(2)))
			{
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			int num = this.LA(1);
			if (num <= 100)
			{
				if (num != 47)
				{
					if (num != 100)
					{
						goto IL_24D;
					}
				}
				else
				{
					Literal parameterValue = this.defaultLiteral();
					if (this.inputState.guessing == 0)
					{
						executeParameter.ParameterValue = parameterValue;
						return executeParameter;
					}
					return executeParameter;
				}
			}
			else if (num != 193 && num != 199)
			{
				switch (num)
				{
				case 221:
				case 222:
				case 223:
				case 224:
				case 225:
				case 230:
				case 231:
				case 232:
				case 233:
				case 234:
					break;
				case 226:
				case 227:
				case 228:
				case 229:
					goto IL_24D;
				default:
					goto IL_24D;
				}
			}
			ScalarExpression scalarExpression = this.possibleNegativeConstantOrIdentifier();
			if (this.inputState.guessing == 0)
			{
				executeParameter.ParameterValue = scalarExpression;
				if (executeParameter.Variable != null)
				{
					nameEqualsValueWasUsed = true;
				}
				else if (nameEqualsValueWasUsed)
				{
					TSql80ParserBaseInternal.ThrowParseErrorException("SQL46089", scalarExpression, TSqlParserResource.SQL46089Message, new string[]
					{
						parameterNumber.ToString(CultureInfo.CurrentCulture)
					});
				}
			}
			if (this.LA(1) == 232 && (base.NextTokenMatches("OUTPUT") || base.NextTokenMatches("OUT")))
			{
				IToken token = this.LT(1);
				this.match(232);
				if (this.inputState.guessing == 0)
				{
					VariableReference variableReference = scalarExpression as VariableReference;
					GlobalVariableExpression globalVariableExpression = scalarExpression as GlobalVariableExpression;
					if (variableReference == null && globalVariableExpression == null)
					{
						TSql80ParserBaseInternal.ThrowParseErrorException("SQL46088", token, TSqlParserResource.SQL46088Message, new string[0]);
					}
					TSql80ParserBaseInternal.Match(token, "OUTPUT", "OUT");
					executeParameter.IsOutput = true;
					TSql80ParserBaseInternal.UpdateTokenInfo(executeParameter, token);
					return executeParameter;
				}
				return executeParameter;
			}
			else
			{
				if (!TSql80ParserInternal.tokenSet_69_.member(this.LA(1)))
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				return executeParameter;
			}
			IL_24D:
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x060013D1 RID: 5073 RVA: 0x0006C370 File Offset: 0x0006A570
		public TableDefinition tableDefinitionCreateTable()
		{
			TableDefinition tableDefinition = base.FragmentFactory.CreateFragment<TableDefinition>();
			this.tableElement(IndexAffectingStatement.CreateTable, tableDefinition, null);
			while (this.LA(1) == 198 && TSql80ParserInternal.tokenSet_70_.member(this.LA(2)))
			{
				this.LT(1);
				this.match(198);
				this.tableElement(IndexAffectingStatement.CreateTable, tableDefinition, null);
			}
			int num = this.LA(1);
			if (num != 192)
			{
				if (num != 198)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				this.match(198);
			}
			return tableDefinition;
		}

		// Token: 0x060013D2 RID: 5074 RVA: 0x0006C40C File Offset: 0x0006A60C
		public AlterTableAlterColumnStatement alterTableAlterColumnStatement()
		{
			AlterTableAlterColumnStatement alterTableAlterColumnStatement = base.FragmentFactory.CreateFragment<AlterTableAlterColumnStatement>();
			bool flag = false;
			this.match(6);
			this.match(27);
			Identifier columnIdentifier = this.identifier();
			if (this.inputState.guessing == 0)
			{
				alterTableAlterColumnStatement.ColumnIdentifier = columnIdentifier;
				base.ThrowPartialAstIfPhaseOne(alterTableAlterColumnStatement);
			}
			int num = this.LA(1);
			if (num <= 54)
			{
				if (num != 4)
				{
					switch (num)
					{
					case 53:
						goto IL_92;
					case 54:
						break;
					default:
						goto IL_48C;
					}
				}
				int num2 = this.LA(1);
				if (num2 != 4)
				{
					if (num2 != 54)
					{
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
					this.match(54);
					if (this.inputState.guessing == 0)
					{
						flag = false;
					}
				}
				else
				{
					this.match(4);
					if (this.inputState.guessing == 0)
					{
						flag = true;
					}
				}
				int num3 = this.LA(1);
				if (num3 != 99)
				{
					if (num3 != 136)
					{
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
					IToken token = this.LT(1);
					this.match(136);
					if (this.inputState.guessing != 0)
					{
						return alterTableAlterColumnStatement;
					}
					TSql80ParserBaseInternal.UpdateTokenInfo(alterTableAlterColumnStatement, token);
					if (flag)
					{
						alterTableAlterColumnStatement.AlterTableAlterColumnOption = AlterTableAlterColumnOption.AddRowGuidCol;
						return alterTableAlterColumnStatement;
					}
					alterTableAlterColumnStatement.AlterTableAlterColumnOption = AlterTableAlterColumnOption.DropRowGuidCol;
					return alterTableAlterColumnStatement;
				}
				else
				{
					this.match(99);
					this.match(67);
					IToken token2 = this.LT(1);
					this.match(128);
					if (this.inputState.guessing != 0)
					{
						return alterTableAlterColumnStatement;
					}
					TSql80ParserBaseInternal.UpdateTokenInfo(alterTableAlterColumnStatement, token2);
					if (flag)
					{
						alterTableAlterColumnStatement.AlterTableAlterColumnOption = AlterTableAlterColumnOption.AddNotForReplication;
						return alterTableAlterColumnStatement;
					}
					alterTableAlterColumnStatement.AlterTableAlterColumnOption = AlterTableAlterColumnOption.DropNotForReplication;
					return alterTableAlterColumnStatement;
				}
			}
			else if (num != 96)
			{
				switch (num)
				{
				case 232:
				case 233:
					break;
				default:
					goto IL_48C;
				}
			}
			IL_92:
			DataTypeReference dataType = this.scalarDataType();
			if (this.inputState.guessing == 0)
			{
				alterTableAlterColumnStatement.DataType = dataType;
			}
			this.collationOpt(alterTableAlterColumnStatement);
			int num4 = this.LA(1);
			if (num4 <= 92)
			{
				if (num4 <= 28)
				{
					if (num4 <= 6)
					{
						if (num4 == 1 || num4 == 6)
						{
							return alterTableAlterColumnStatement;
						}
					}
					else
					{
						switch (num4)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							return alterTableAlterColumnStatement;
						case 14:
						case 16:
							break;
						default:
							switch (num4)
							{
							case 22:
							case 23:
								return alterTableAlterColumnStatement;
							default:
								if (num4 == 28)
								{
									return alterTableAlterColumnStatement;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num4 <= 75)
				{
					switch (num4)
					{
					case 33:
					case 35:
						return alterTableAlterColumnStatement;
					case 34:
						break;
					default:
						switch (num4)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							return alterTableAlterColumnStatement;
						case 47:
						case 50:
						case 51:
						case 52:
						case 53:
						case 57:
						case 58:
						case 59:
						case 62:
						case 63:
							break;
						default:
							switch (num4)
							{
							case 74:
							case 75:
								return alterTableAlterColumnStatement;
							}
							break;
						}
						break;
					}
				}
				else if (num4 == 82 || num4 == 86 || num4 == 92)
				{
					return alterTableAlterColumnStatement;
				}
			}
			else if (num4 <= 162)
			{
				if (num4 <= 106)
				{
					if (num4 == 95)
					{
						return alterTableAlterColumnStatement;
					}
					switch (num4)
					{
					case 99:
					case 100:
					{
						bool flag2 = this.nullNotNull(alterTableAlterColumnStatement);
						if (this.inputState.guessing == 0)
						{
							alterTableAlterColumnStatement.AlterTableAlterColumnOption = (flag2 ? AlterTableAlterColumnOption.Null : AlterTableAlterColumnOption.NotNull);
							return alterTableAlterColumnStatement;
						}
						return alterTableAlterColumnStatement;
					}
					default:
						if (num4 == 106)
						{
							return alterTableAlterColumnStatement;
						}
						break;
					}
				}
				else
				{
					if (num4 == 119)
					{
						return alterTableAlterColumnStatement;
					}
					switch (num4)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return alterTableAlterColumnStatement;
					case 124:
					case 127:
					case 128:
					case 130:
					case 133:
					case 135:
					case 136:
					case 137:
					case 139:
					case 141:
						break;
					default:
						switch (num4)
						{
						case 156:
						case 160:
						case 161:
						case 162:
							return alterTableAlterColumnStatement;
						}
						break;
					}
				}
			}
			else if (num4 <= 181)
			{
				switch (num4)
				{
				case 167:
				case 170:
				case 172:
				case 173:
					return alterTableAlterColumnStatement;
				case 168:
				case 169:
				case 171:
					break;
				default:
					if (num4 == 176)
					{
						return alterTableAlterColumnStatement;
					}
					switch (num4)
					{
					case 180:
					case 181:
						return alterTableAlterColumnStatement;
					}
					break;
				}
			}
			else
			{
				if (num4 == 191 || num4 == 204)
				{
					return alterTableAlterColumnStatement;
				}
				switch (num4)
				{
				case 219:
				case 220:
					return alterTableAlterColumnStatement;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_48C:
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x0006C8BC File Offset: 0x0006AABC
		public AlterTableTriggerModificationStatement alterTableTriggerModificationStatement()
		{
			AlterTableTriggerModificationStatement alterTableTriggerModificationStatement = base.FragmentFactory.CreateFragment<AlterTableTriggerModificationStatement>();
			IToken token = this.LT(1);
			this.match(232);
			if (this.inputState.guessing == 0)
			{
				alterTableTriggerModificationStatement.TriggerEnforcement = TSql80ParserBaseInternal.ParseTriggerEnforcement(token);
			}
			this.match(155);
			int num = this.LA(1);
			if (num != 5)
			{
				switch (num)
				{
				case 232:
				case 233:
				{
					Identifier item = this.identifier();
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.AddAndUpdateTokenInfo<Identifier>(alterTableTriggerModificationStatement, alterTableTriggerModificationStatement.TriggerNames, item);
					}
					while (this.LA(1) == 198)
					{
						this.match(198);
						item = this.identifier();
						if (this.inputState.guessing == 0)
						{
							TSql80ParserBaseInternal.AddAndUpdateTokenInfo<Identifier>(alterTableTriggerModificationStatement, alterTableTriggerModificationStatement.TriggerNames, item);
						}
					}
					break;
				}
				default:
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
			}
			else
			{
				IToken token2 = this.LT(1);
				this.match(5);
				if (this.inputState.guessing == 0)
				{
					alterTableTriggerModificationStatement.All = true;
					TSql80ParserBaseInternal.UpdateTokenInfo(alterTableTriggerModificationStatement, token2);
				}
			}
			if (this.inputState.guessing == 0)
			{
				base.ThrowPartialAstIfPhaseOne(alterTableTriggerModificationStatement);
			}
			return alterTableTriggerModificationStatement;
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x0006C9EC File Offset: 0x0006ABEC
		public AlterTableDropTableElementStatement alterTableDropTableElementStatement()
		{
			AlterTableDropTableElementStatement alterTableDropTableElementStatement = base.FragmentFactory.CreateFragment<AlterTableDropTableElementStatement>();
			this.match(54);
			AlterTableDropTableElement item = this.alterTableDropTableElement();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<AlterTableDropTableElement>(alterTableDropTableElementStatement, alterTableDropTableElementStatement.AlterTableDropTableElements, item);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				item = this.alterTableDropTableElement();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<AlterTableDropTableElement>(alterTableDropTableElementStatement, alterTableDropTableElementStatement.AlterTableDropTableElements, item);
				}
			}
			if (this.inputState.guessing == 0)
			{
				base.ThrowPartialAstIfPhaseOne(alterTableDropTableElementStatement);
			}
			return alterTableDropTableElementStatement;
		}

		// Token: 0x060013D5 RID: 5077 RVA: 0x0006CA80 File Offset: 0x0006AC80
		public ConstraintEnforcement constraintEnforcement()
		{
			ConstraintEnforcement result = ConstraintEnforcement.NotSpecified;
			int num = this.LA(1);
			if (num != 21)
			{
				if (num != 97)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				this.match(97);
				if (this.inputState.guessing == 0)
				{
					result = ConstraintEnforcement.NoCheck;
				}
			}
			else
			{
				this.match(21);
				if (this.inputState.guessing == 0)
				{
					result = ConstraintEnforcement.Check;
				}
			}
			return result;
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x0006CAEC File Offset: 0x0006ACEC
		public AlterTableAddTableElementStatement alterTableAddTableElementStatement(ConstraintEnforcement vExistingRowsCheck)
		{
			AlterTableAddTableElementStatement alterTableAddTableElementStatement = base.FragmentFactory.CreateFragment<AlterTableAddTableElementStatement>();
			alterTableAddTableElementStatement.ExistingRowsCheckEnforcement = vExistingRowsCheck;
			this.match(4);
			TableDefinition definition = this.tableDefinition(IndexAffectingStatement.AlterTableAddElement, alterTableAddTableElementStatement);
			if (this.inputState.guessing == 0)
			{
				alterTableAddTableElementStatement.Definition = definition;
			}
			return alterTableAddTableElementStatement;
		}

		// Token: 0x060013D7 RID: 5079 RVA: 0x0006CB34 File Offset: 0x0006AD34
		public AlterTableConstraintModificationStatement alterTableConstraintModificationStatement(ConstraintEnforcement vExistingRowsCheck)
		{
			AlterTableConstraintModificationStatement alterTableConstraintModificationStatement = base.FragmentFactory.CreateFragment<AlterTableConstraintModificationStatement>();
			alterTableConstraintModificationStatement.ExistingRowsCheckEnforcement = vExistingRowsCheck;
			ConstraintEnforcement constraintEnforcement = this.constraintEnforcement();
			this.match(30);
			if (this.inputState.guessing == 0)
			{
				alterTableConstraintModificationStatement.ConstraintEnforcement = constraintEnforcement;
			}
			int num = this.LA(1);
			if (num != 5)
			{
				switch (num)
				{
				case 232:
				case 233:
				{
					Identifier item = this.identifier();
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.AddAndUpdateTokenInfo<Identifier>(alterTableConstraintModificationStatement, alterTableConstraintModificationStatement.ConstraintNames, item);
					}
					while (this.LA(1) == 198)
					{
						this.match(198);
						item = this.identifier();
						if (this.inputState.guessing == 0)
						{
							TSql80ParserBaseInternal.AddAndUpdateTokenInfo<Identifier>(alterTableConstraintModificationStatement, alterTableConstraintModificationStatement.ConstraintNames, item);
						}
					}
					break;
				}
				default:
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
			}
			else
			{
				IToken token = this.LT(1);
				this.match(5);
				if (this.inputState.guessing == 0)
				{
					alterTableConstraintModificationStatement.All = true;
					TSql80ParserBaseInternal.UpdateTokenInfo(alterTableConstraintModificationStatement, token);
				}
			}
			if (this.inputState.guessing == 0)
			{
				base.ThrowPartialAstIfPhaseOne(alterTableConstraintModificationStatement);
			}
			return alterTableConstraintModificationStatement;
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x0006CC58 File Offset: 0x0006AE58
		public AlterTableDropTableElement alterTableDropTableElement()
		{
			AlterTableDropTableElement alterTableDropTableElement = base.FragmentFactory.CreateFragment<AlterTableDropTableElement>();
			int num = this.LA(1);
			if (num != 27)
			{
				if (num != 30)
				{
					switch (num)
					{
					case 232:
					case 233:
						break;
					default:
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
				}
				int num2 = this.LA(1);
				if (num2 != 30)
				{
					switch (num2)
					{
					case 232:
					case 233:
						break;
					default:
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
				}
				else
				{
					this.match(30);
					if (this.inputState.guessing == 0)
					{
						alterTableDropTableElement.TableElementType = TableElementType.Constraint;
					}
				}
				Identifier name = this.identifier();
				if (this.inputState.guessing == 0)
				{
					alterTableDropTableElement.Name = name;
				}
			}
			else
			{
				this.match(27);
				Identifier name = this.identifier();
				if (this.inputState.guessing == 0)
				{
					alterTableDropTableElement.TableElementType = TableElementType.Column;
					alterTableDropTableElement.Name = name;
				}
			}
			return alterTableDropTableElement;
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x0006CD50 File Offset: 0x0006AF50
		public ColumnDefinition columnDefinition(IndexAffectingStatement statementType, AlterTableAddTableElementStatement vStatement)
		{
			ColumnDefinition columnDefinition = base.FragmentFactory.CreateFragment<ColumnDefinition>();
			IToken token = null;
			Identifier identifier = null;
			Identifier columnIdentifier = this.identifier();
			if (this.inputState.guessing == 0)
			{
				columnDefinition.ColumnIdentifier = columnIdentifier;
				if (base.PhaseOne && vStatement != null)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ColumnDefinition>(vStatement, vStatement.Definition.ColumnDefinitions, columnDefinition);
					base.ThrowPartialAstIfPhaseOne(vStatement);
				}
			}
			int num = this.LA(1);
			if (num <= 100)
			{
				if (num <= 35)
				{
					if (num <= 6)
					{
						if (num != 1 && num != 6)
						{
							goto IL_6D8;
						}
					}
					else
					{
						switch (num)
						{
						case 9:
						{
							this.match(9);
							ScalarExpression computedColumnExpression = this.expressionWithFlags(ExpressionFlags.ScalarSubqueriesDisallowed);
							if (this.inputState.guessing == 0)
							{
								columnDefinition.ComputedColumnExpression = computedColumnExpression;
							}
							int num2 = this.LA(1);
							if (num2 <= 92)
							{
								if (num2 <= 30)
								{
									if (num2 <= 6)
									{
										if (num2 != 1 && num2 != 6)
										{
											goto IL_6B4;
										}
										return columnDefinition;
									}
									else
									{
										switch (num2)
										{
										case 12:
										case 13:
										case 15:
										case 17:
											return columnDefinition;
										case 14:
										case 16:
											goto IL_6B4;
										default:
											switch (num2)
											{
											case 22:
											case 23:
												return columnDefinition;
											default:
												switch (num2)
												{
												case 28:
													return columnDefinition;
												case 29:
													goto IL_6B4;
												case 30:
													break;
												default:
													goto IL_6B4;
												}
												break;
											}
											break;
										}
									}
								}
								else if (num2 <= 75)
								{
									switch (num2)
									{
									case 33:
									case 35:
										return columnDefinition;
									case 34:
										goto IL_6B4;
									default:
										switch (num2)
										{
										case 44:
										case 45:
										case 46:
										case 48:
										case 49:
										case 54:
										case 55:
										case 56:
										case 60:
										case 61:
										case 64:
											return columnDefinition;
										case 47:
										case 50:
										case 51:
										case 52:
										case 53:
										case 57:
										case 58:
										case 59:
										case 62:
										case 63:
											goto IL_6B4;
										default:
											switch (num2)
											{
											case 74:
											case 75:
												return columnDefinition;
											default:
												goto IL_6B4;
											}
											break;
										}
										break;
									}
								}
								else
								{
									if (num2 != 82 && num2 != 86 && num2 != 92)
									{
										goto IL_6B4;
									}
									return columnDefinition;
								}
							}
							else if (num2 <= 173)
							{
								if (num2 <= 106)
								{
									if (num2 != 95 && num2 != 106)
									{
										goto IL_6B4;
									}
									return columnDefinition;
								}
								else
								{
									switch (num2)
									{
									case 118:
										break;
									case 119:
									case 123:
									case 125:
									case 126:
									case 129:
									case 131:
									case 132:
									case 134:
									case 138:
									case 140:
									case 142:
									case 143:
									case 144:
										return columnDefinition;
									case 120:
									case 121:
									case 122:
									case 124:
									case 127:
									case 128:
									case 130:
									case 133:
									case 135:
									case 136:
									case 137:
									case 139:
									case 141:
										goto IL_6B4;
									default:
										switch (num2)
										{
										case 156:
										case 160:
										case 161:
										case 162:
											return columnDefinition;
										case 157:
										case 158:
											goto IL_6B4;
										case 159:
											break;
										default:
											switch (num2)
											{
											case 167:
											case 170:
											case 172:
											case 173:
												return columnDefinition;
											case 168:
											case 169:
											case 171:
												goto IL_6B4;
											default:
												goto IL_6B4;
											}
											break;
										}
										break;
									}
								}
							}
							else if (num2 <= 192)
							{
								if (num2 == 176)
								{
									return columnDefinition;
								}
								switch (num2)
								{
								case 180:
								case 181:
									return columnDefinition;
								default:
									switch (num2)
									{
									case 191:
									case 192:
										return columnDefinition;
									default:
										goto IL_6B4;
									}
									break;
								}
							}
							else
							{
								if (num2 == 198 || num2 == 204)
								{
									return columnDefinition;
								}
								switch (num2)
								{
								case 219:
								case 220:
									return columnDefinition;
								default:
									goto IL_6B4;
								}
							}
							int num3 = this.LA(1);
							if (num3 != 30)
							{
								if (num3 != 118 && num3 != 159)
								{
									throw new NoViableAltException(this.LT(1), this.getFilename());
								}
							}
							else
							{
								token = this.LT(1);
								this.match(30);
								identifier = this.identifier();
								if (this.inputState.guessing == 0)
								{
									TSql80ParserBaseInternal.ThrowSyntaxErrorIfNotCreateAlterTable(statementType, token);
								}
							}
							ConstraintDefinition constraintDefinition = this.uniqueColumnConstraint();
							if (this.inputState.guessing == 0)
							{
								if (identifier != null)
								{
									TSql80ParserBaseInternal.UpdateTokenInfo(constraintDefinition, token);
									constraintDefinition.ConstraintIdentifier = identifier;
								}
								TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ConstraintDefinition>(columnDefinition, columnDefinition.Constraints, constraintDefinition);
								return columnDefinition;
							}
							return columnDefinition;
							IL_6B4:
							throw new NoViableAltException(this.LT(1), this.getFilename());
						}
						case 10:
						case 11:
						case 14:
						case 16:
						case 18:
						case 19:
						case 20:
							goto IL_6D8;
						case 12:
						case 13:
						case 15:
						case 17:
						case 21:
						case 22:
						case 23:
							break;
						default:
							switch (num)
							{
							case 28:
							case 30:
								break;
							case 29:
								goto IL_6D8;
							default:
								switch (num)
								{
								case 33:
								case 35:
									break;
								case 34:
									goto IL_6D8;
								default:
									goto IL_6D8;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num <= 79)
				{
					switch (num)
					{
					case 44:
					case 45:
					case 46:
					case 47:
					case 48:
					case 49:
					case 53:
					case 54:
					case 55:
					case 56:
					case 60:
					case 61:
					case 64:
					case 68:
						break;
					case 50:
					case 51:
					case 52:
					case 57:
					case 58:
					case 59:
					case 62:
					case 63:
					case 65:
					case 66:
					case 67:
						goto IL_6D8;
					default:
						switch (num)
						{
						case 74:
						case 75:
							break;
						default:
							if (num != 79)
							{
								goto IL_6D8;
							}
							break;
						}
						break;
					}
				}
				else if (num != 82 && num != 86)
				{
					switch (num)
					{
					case 92:
					case 95:
					case 96:
					case 99:
					case 100:
						break;
					case 93:
					case 94:
					case 97:
					case 98:
						goto IL_6D8;
					default:
						goto IL_6D8;
					}
				}
			}
			else if (num <= 176)
			{
				if (num <= 144)
				{
					if (num != 106)
					{
						switch (num)
						{
						case 118:
						case 119:
						case 123:
						case 125:
						case 126:
						case 127:
						case 129:
						case 131:
						case 132:
						case 134:
						case 136:
						case 138:
						case 140:
						case 142:
						case 143:
						case 144:
							break;
						case 120:
						case 121:
						case 122:
						case 124:
						case 128:
						case 130:
						case 133:
						case 135:
						case 137:
						case 139:
						case 141:
							goto IL_6D8;
						default:
							goto IL_6D8;
						}
					}
				}
				else
				{
					switch (num)
					{
					case 156:
					case 159:
					case 160:
					case 161:
					case 162:
						break;
					case 157:
					case 158:
						goto IL_6D8;
					default:
						switch (num)
						{
						case 167:
						case 170:
						case 172:
						case 173:
							break;
						case 168:
						case 169:
						case 171:
							goto IL_6D8;
						default:
							if (num != 176)
							{
								goto IL_6D8;
							}
							break;
						}
						break;
					}
				}
			}
			else if (num <= 198)
			{
				switch (num)
				{
				case 180:
				case 181:
					break;
				default:
					switch (num)
					{
					case 191:
					case 192:
						break;
					default:
						if (num != 198)
						{
							goto IL_6D8;
						}
						break;
					}
					break;
				}
			}
			else if (num != 204)
			{
				switch (num)
				{
				case 219:
				case 220:
					break;
				default:
					switch (num)
					{
					case 232:
					case 233:
						break;
					default:
						goto IL_6D8;
					}
					break;
				}
			}
			this.regularColumnBody(columnDefinition);
			this.columnConstraintListOpt(statementType, columnDefinition);
			return columnDefinition;
			IL_6D8:
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x060013DA RID: 5082 RVA: 0x0006D44C File Offset: 0x0006B64C
		public ConstraintDefinition tableConstraint(IndexAffectingStatement statementType, AlterTableAddTableElementStatement vStatement)
		{
			ConstraintDefinition constraintDefinition = null;
			IToken token = null;
			Identifier identifier = null;
			try
			{
				int num = this.LA(1);
				if (num <= 47)
				{
					if (num == 21)
					{
						goto IL_80;
					}
					if (num != 30)
					{
						if (num == 47)
						{
							goto IL_80;
						}
					}
					else
					{
						token = this.LT(1);
						this.match(30);
						identifier = this.identifier();
						if (this.inputState.guessing == 0)
						{
							TSql80ParserBaseInternal.ThrowSyntaxErrorIfNotCreateAlterTable(statementType, token);
							goto IL_80;
						}
						goto IL_80;
					}
				}
				else if (num == 68 || num == 118 || num == 159)
				{
					goto IL_80;
				}
				throw new NoViableAltException(this.LT(1), this.getFilename());
				IL_80:
				int num2 = this.LA(1);
				if (num2 <= 47)
				{
					if (num2 == 21)
					{
						constraintDefinition = this.checkConstraint(statementType);
						goto IL_EC;
					}
					if (num2 == 47)
					{
						constraintDefinition = this.defaultTableConstraint(statementType);
						goto IL_EC;
					}
				}
				else
				{
					if (num2 == 68)
					{
						constraintDefinition = this.foreignKeyTableConstraint(statementType);
						goto IL_EC;
					}
					if (num2 == 118 || num2 == 159)
					{
						constraintDefinition = this.uniqueTableConstraint();
						goto IL_EC;
					}
				}
				throw new NoViableAltException(this.LT(1), this.getFilename());
				IL_EC:
				if (this.inputState.guessing == 0 && identifier != null)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(constraintDefinition, token);
					constraintDefinition.ConstraintIdentifier = identifier;
				}
			}
			catch (PhaseOneConstraintException ex)
			{
				if (this.inputState.guessing != 0)
				{
					throw;
				}
				if (identifier != null)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(ex.Constraint, token);
					ex.Constraint.ConstraintIdentifier = identifier;
				}
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ConstraintDefinition>(vStatement, vStatement.Definition.TableConstraints, ex.Constraint);
				base.ThrowPartialAstIfPhaseOne(vStatement);
			}
			return constraintDefinition;
		}

		// Token: 0x060013DB RID: 5083 RVA: 0x0006D5D0 File Offset: 0x0006B7D0
		public ScalarExpression expressionWithFlags(ExpressionFlags expressionFlags)
		{
			return this.expressionBinaryPri2(expressionFlags);
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x0006D5E8 File Offset: 0x0006B7E8
		public UniqueConstraintDefinition uniqueColumnConstraint()
		{
			UniqueConstraintDefinition uniqueConstraintDefinition = base.FragmentFactory.CreateFragment<UniqueConstraintDefinition>();
			this.uniqueConstraintHeader(uniqueConstraintDefinition, false);
			bool flag = false;
			if (this.LA(1) == 191 && (this.LA(2) == 200 || this.LA(2) == 232 || this.LA(2) == 233))
			{
				int pos = this.mark();
				flag = true;
				this.inputState.guessing++;
				try
				{
					this.match(191);
					this.columnWithSortOrder();
				}
				catch (RecognitionException)
				{
					flag = false;
				}
				this.rewind(pos);
				this.inputState.guessing--;
			}
			if (flag)
			{
				this.match(191);
				ColumnWithSortOrder item = this.columnWithSortOrder();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ColumnWithSortOrder>(uniqueConstraintDefinition, uniqueConstraintDefinition.Columns, item);
				}
				while (this.LA(1) == 198)
				{
					this.match(198);
					item = this.columnWithSortOrder();
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ColumnWithSortOrder>(uniqueConstraintDefinition, uniqueConstraintDefinition.Columns, item);
					}
				}
				IToken token = this.LT(1);
				this.match(192);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(uniqueConstraintDefinition, token);
				}
			}
			else if (!TSql80ParserInternal.tokenSet_71_.member(this.LA(1)) || !TSql80ParserInternal.tokenSet_72_.member(this.LA(2)))
			{
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			this.uniqueConstraintTailOpt(uniqueConstraintDefinition);
			return uniqueConstraintDefinition;
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x0006D780 File Offset: 0x0006B980
		public void regularColumnBody(ColumnDefinition vParent)
		{
			int num = this.LA(1);
			if (num <= 100)
			{
				if (num <= 35)
				{
					if (num <= 6)
					{
						if (num != 1 && num != 6)
						{
							goto IL_2F3;
						}
						goto IL_306;
					}
					else
					{
						switch (num)
						{
						case 12:
						case 13:
						case 15:
						case 17:
						case 21:
						case 22:
						case 23:
							goto IL_306;
						case 14:
						case 16:
						case 18:
						case 19:
						case 20:
							goto IL_2F3;
						default:
							switch (num)
							{
							case 28:
							case 30:
								goto IL_306;
							case 29:
								goto IL_2F3;
							default:
								switch (num)
								{
								case 33:
								case 35:
									goto IL_306;
								case 34:
									goto IL_2F3;
								default:
									goto IL_2F3;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num <= 79)
				{
					switch (num)
					{
					case 44:
					case 45:
					case 46:
					case 47:
					case 48:
					case 49:
					case 54:
					case 55:
					case 56:
					case 60:
					case 61:
					case 64:
					case 68:
						goto IL_306;
					case 50:
					case 51:
					case 52:
					case 57:
					case 58:
					case 59:
					case 62:
					case 63:
					case 65:
					case 66:
					case 67:
						goto IL_2F3;
					case 53:
						break;
					default:
						switch (num)
						{
						case 74:
						case 75:
							goto IL_306;
						default:
							if (num != 79)
							{
								goto IL_2F3;
							}
							goto IL_306;
						}
						break;
					}
				}
				else
				{
					if (num == 82 || num == 86)
					{
						goto IL_306;
					}
					switch (num)
					{
					case 92:
					case 95:
					case 99:
					case 100:
						goto IL_306;
					case 93:
					case 94:
					case 97:
					case 98:
						goto IL_2F3;
					case 96:
						break;
					default:
						goto IL_2F3;
					}
				}
			}
			else if (num <= 176)
			{
				if (num <= 144)
				{
					if (num == 106)
					{
						goto IL_306;
					}
					switch (num)
					{
					case 118:
					case 119:
					case 123:
					case 125:
					case 126:
					case 127:
					case 129:
					case 131:
					case 132:
					case 134:
					case 136:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						goto IL_306;
					case 120:
					case 121:
					case 122:
					case 124:
					case 128:
					case 130:
					case 133:
					case 135:
					case 137:
					case 139:
					case 141:
						goto IL_2F3;
					default:
						goto IL_2F3;
					}
				}
				else
				{
					switch (num)
					{
					case 156:
					case 159:
					case 160:
					case 161:
					case 162:
						goto IL_306;
					case 157:
					case 158:
						goto IL_2F3;
					default:
						switch (num)
						{
						case 167:
						case 170:
						case 172:
						case 173:
							goto IL_306;
						case 168:
						case 169:
						case 171:
							goto IL_2F3;
						default:
							if (num != 176)
							{
								goto IL_2F3;
							}
							goto IL_306;
						}
						break;
					}
				}
			}
			else if (num <= 198)
			{
				switch (num)
				{
				case 180:
				case 181:
					goto IL_306;
				default:
					switch (num)
					{
					case 191:
					case 192:
						goto IL_306;
					default:
						if (num != 198)
						{
							goto IL_2F3;
						}
						goto IL_306;
					}
					break;
				}
			}
			else
			{
				if (num == 204)
				{
					goto IL_306;
				}
				switch (num)
				{
				case 219:
				case 220:
					goto IL_306;
				default:
					switch (num)
					{
					case 232:
					case 233:
						break;
					default:
						goto IL_2F3;
					}
					break;
				}
			}
			DataTypeReference dataType = this.scalarDataType();
			if (this.inputState.guessing == 0)
			{
				vParent.DataType = dataType;
			}
			this.collationOpt(vParent);
			goto IL_306;
			IL_2F3:
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_306:
			if (this.inputState.guessing == 0)
			{
				base.VerifyColumnDataType(vParent);
			}
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x0006DAA8 File Offset: 0x0006BCA8
		public void columnConstraintListOpt(IndexAffectingStatement statementType, ColumnDefinition vResult)
		{
			for (;;)
			{
				int num = this.LA(1);
				if (num <= 79)
				{
					if (num <= 30)
					{
						if (num != 21 && num != 30)
						{
							break;
						}
					}
					else if (num != 47 && num != 68)
					{
						if (num != 79)
						{
							return;
						}
						IdentityOptions identityOptions = this.identityConstraint(statementType);
						if (this.inputState.guessing == 0)
						{
							if (vResult.IdentityOptions != null)
							{
								TSql80ParserBaseInternal.ThrowParseErrorException("SQL46043", identityOptions, TSqlParserResource.SQL46043Message, new string[0]);
							}
							vResult.IdentityOptions = identityOptions;
							continue;
						}
						continue;
					}
				}
				else if (num <= 118)
				{
					switch (num)
					{
					case 99:
					case 100:
						break;
					default:
						if (num != 118)
						{
							return;
						}
						break;
					}
				}
				else if (num != 127)
				{
					if (num == 136)
					{
						this.rowguidcolConstraint(vResult);
						continue;
					}
					if (num != 159)
					{
						return;
					}
				}
				ConstraintDefinition constraint = this.columnConstraint(statementType);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddConstraintToColumn(constraint, vResult);
				}
			}
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x0006DB90 File Offset: 0x0006BD90
		public void rowguidcolConstraint(ColumnDefinition vParent)
		{
			IToken token = this.LT(1);
			this.match(136);
			if (this.inputState.guessing == 0)
			{
				if (vParent.IsRowGuidCol)
				{
					TSql80ParserBaseInternal.ThrowParseErrorException("SQL46042", token, TSqlParserResource.SQL46042Message, new string[0]);
				}
				TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token);
				vParent.IsRowGuidCol = true;
			}
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x0006DBEC File Offset: 0x0006BDEC
		public IdentityOptions identityConstraint(IndexAffectingStatement statementType)
		{
			IdentityOptions identityOptions = base.FragmentFactory.CreateFragment<IdentityOptions>();
			IToken token = this.LT(1);
			this.match(79);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(identityOptions, token);
			}
			bool flag = false;
			if (this.LA(1) == 191 && TSql80ParserInternal.tokenSet_73_.member(this.LA(2)))
			{
				int pos = this.mark();
				flag = true;
				this.inputState.guessing++;
				try
				{
					this.match(191);
					this.seedIncrement();
				}
				catch (RecognitionException)
				{
					flag = false;
				}
				this.rewind(pos);
				this.inputState.guessing--;
			}
			if (flag)
			{
				this.match(191);
				ScalarExpression scalarExpression = this.seedIncrement();
				if (this.inputState.guessing == 0)
				{
					identityOptions.IdentitySeed = scalarExpression;
				}
				this.match(198);
				scalarExpression = this.seedIncrement();
				if (this.inputState.guessing == 0)
				{
					identityOptions.IdentityIncrement = scalarExpression;
				}
				IToken token2 = this.LT(1);
				this.match(192);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(identityOptions, token2);
				}
			}
			else if (!TSql80ParserInternal.tokenSet_74_.member(this.LA(1)) || !TSql80ParserInternal.tokenSet_75_.member(this.LA(2)))
			{
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			bool isIdentityNotForReplication = this.replicationClauseOpt(statementType, identityOptions);
			if (this.inputState.guessing == 0)
			{
				identityOptions.IsIdentityNotForReplication = isIdentityNotForReplication;
			}
			return identityOptions;
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x0006DD88 File Offset: 0x0006BF88
		public ConstraintDefinition columnConstraint(IndexAffectingStatement statementType)
		{
			ConstraintDefinition constraintDefinition = null;
			IToken token = null;
			Identifier identifier = null;
			try
			{
				int num = this.LA(1);
				if (num <= 68)
				{
					if (num <= 30)
					{
						if (num == 21)
						{
							goto IL_9C;
						}
						if (num == 30)
						{
							token = this.LT(1);
							this.match(30);
							identifier = this.identifier();
							if (this.inputState.guessing == 0)
							{
								TSql80ParserBaseInternal.ThrowSyntaxErrorIfNotCreateAlterTable(statementType, token);
								goto IL_9C;
							}
							goto IL_9C;
						}
					}
					else if (num == 47 || num == 68)
					{
						goto IL_9C;
					}
				}
				else if (num <= 118)
				{
					switch (num)
					{
					case 99:
					case 100:
						goto IL_9C;
					default:
						if (num == 118)
						{
							goto IL_9C;
						}
						break;
					}
				}
				else if (num == 127 || num == 159)
				{
					goto IL_9C;
				}
				throw new NoViableAltException(this.LT(1), this.getFilename());
				IL_9C:
				int num2 = this.LA(1);
				if (num2 > 68)
				{
					if (num2 <= 118)
					{
						switch (num2)
						{
						case 99:
						case 100:
							constraintDefinition = this.nullableConstraint();
							goto IL_133;
						default:
							if (num2 != 118)
							{
								goto IL_120;
							}
							break;
						}
					}
					else
					{
						if (num2 == 127)
						{
							goto IL_10C;
						}
						if (num2 != 159)
						{
							goto IL_120;
						}
					}
					constraintDefinition = this.uniqueColumnConstraint();
					goto IL_133;
				}
				if (num2 == 21)
				{
					constraintDefinition = this.checkConstraint(statementType);
					goto IL_133;
				}
				if (num2 == 47)
				{
					constraintDefinition = this.defaultColumnConstraint(statementType);
					goto IL_133;
				}
				if (num2 != 68)
				{
					goto IL_120;
				}
				IL_10C:
				constraintDefinition = this.foreignKeyColumnConstraint(statementType);
				goto IL_133;
				IL_120:
				throw new NoViableAltException(this.LT(1), this.getFilename());
				IL_133:
				if (this.inputState.guessing == 0 && identifier != null)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(constraintDefinition, token);
					constraintDefinition.ConstraintIdentifier = identifier;
				}
			}
			catch (PhaseOneConstraintException)
			{
				if (this.inputState.guessing != 0)
				{
					throw;
				}
			}
			return constraintDefinition;
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x0006DF18 File Offset: 0x0006C118
		public bool replicationClauseOpt(IndexAffectingStatement statementType, TSqlFragment vParent)
		{
			bool result = false;
			bool flag = false;
			if (this.LA(1) == 99 && this.LA(2) == 67)
			{
				int pos = this.mark();
				flag = true;
				this.inputState.guessing++;
				try
				{
					this.match(99);
					this.match(67);
				}
				catch (RecognitionException)
				{
					flag = false;
				}
				this.rewind(pos);
				this.inputState.guessing--;
			}
			if (flag)
			{
				IToken atToken = this.LT(1);
				this.match(99);
				this.match(67);
				IToken token = this.LT(1);
				this.match(128);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.ThrowSyntaxErrorIfNotCreateAlterTable(statementType, atToken);
					TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token);
					result = true;
				}
			}
			else if (!TSql80ParserInternal.tokenSet_74_.member(this.LA(1)) || !TSql80ParserInternal.tokenSet_76_.member(this.LA(2)))
			{
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			return result;
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x0006E02C File Offset: 0x0006C22C
		public NullableConstraintDefinition nullableConstraint()
		{
			NullableConstraintDefinition nullableConstraintDefinition = base.FragmentFactory.CreateFragment<NullableConstraintDefinition>();
			bool nullable = this.nullNotNull(nullableConstraintDefinition);
			if (this.inputState.guessing == 0)
			{
				nullableConstraintDefinition.Nullable = nullable;
			}
			return nullableConstraintDefinition;
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x0006E064 File Offset: 0x0006C264
		public DefaultConstraintDefinition defaultColumnConstraint(IndexAffectingStatement statementType)
		{
			DefaultConstraintDefinition defaultConstraintDefinition = base.FragmentFactory.CreateFragment<DefaultConstraintDefinition>();
			IToken token = this.LT(1);
			this.match(47);
			ScalarExpression expression = this.expressionWithFlags(ExpressionFlags.ScalarSubqueriesDisallowed);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(defaultConstraintDefinition, token);
				defaultConstraintDefinition.Expression = expression;
			}
			int num = this.LA(1);
			if (num <= 86)
			{
				if (num <= 35)
				{
					if (num <= 6)
					{
						if (num == 1 || num == 6)
						{
							return defaultConstraintDefinition;
						}
					}
					else
					{
						switch (num)
						{
						case 12:
						case 13:
						case 15:
						case 17:
						case 21:
						case 22:
						case 23:
							return defaultConstraintDefinition;
						case 14:
						case 16:
						case 18:
						case 19:
						case 20:
							break;
						default:
							switch (num)
							{
							case 28:
							case 30:
								return defaultConstraintDefinition;
							case 29:
								break;
							default:
								switch (num)
								{
								case 33:
								case 35:
									return defaultConstraintDefinition;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num <= 75)
				{
					switch (num)
					{
					case 44:
					case 45:
					case 46:
					case 47:
					case 48:
					case 49:
					case 54:
					case 55:
					case 56:
					case 60:
					case 61:
					case 64:
					case 68:
						return defaultConstraintDefinition;
					case 50:
					case 51:
					case 52:
					case 53:
					case 57:
					case 58:
					case 59:
					case 62:
					case 63:
					case 65:
					case 66:
					case 67:
						break;
					default:
						switch (num)
						{
						case 74:
						case 75:
							return defaultConstraintDefinition;
						}
						break;
					}
				}
				else if (num == 79 || num == 82 || num == 86)
				{
					return defaultConstraintDefinition;
				}
			}
			else if (num <= 144)
			{
				if (num <= 95)
				{
					if (num == 92 || num == 95)
					{
						return defaultConstraintDefinition;
					}
				}
				else
				{
					switch (num)
					{
					case 99:
					case 100:
						return defaultConstraintDefinition;
					default:
						if (num == 106)
						{
							return defaultConstraintDefinition;
						}
						switch (num)
						{
						case 118:
						case 119:
						case 123:
						case 125:
						case 126:
						case 127:
						case 129:
						case 131:
						case 132:
						case 134:
						case 136:
						case 138:
						case 140:
						case 142:
						case 143:
						case 144:
							return defaultConstraintDefinition;
						}
						break;
					}
				}
			}
			else if (num <= 192)
			{
				switch (num)
				{
				case 156:
				case 159:
				case 160:
				case 161:
				case 162:
				case 167:
				case 170:
				case 172:
				case 173:
				case 176:
					return defaultConstraintDefinition;
				case 157:
				case 158:
				case 163:
				case 164:
				case 165:
				case 166:
				case 168:
				case 169:
				case 174:
				case 175:
					break;
				case 171:
				{
					this.match(171);
					IToken token2 = this.LT(1);
					this.match(164);
					if (this.inputState.guessing == 0)
					{
						if (statementType != IndexAffectingStatement.AlterTableAddElement)
						{
							TSql80ParserBaseInternal.ThrowParseErrorException("SQL46013", token, TSqlParserResource.SQL46013Message, new string[0]);
						}
						TSql80ParserBaseInternal.UpdateTokenInfo(defaultConstraintDefinition, token2);
						defaultConstraintDefinition.WithValues = true;
						return defaultConstraintDefinition;
					}
					return defaultConstraintDefinition;
				}
				default:
					switch (num)
					{
					case 180:
					case 181:
						return defaultConstraintDefinition;
					default:
						switch (num)
						{
						case 191:
						case 192:
							return defaultConstraintDefinition;
						}
						break;
					}
					break;
				}
			}
			else
			{
				if (num == 198 || num == 204)
				{
					return defaultConstraintDefinition;
				}
				switch (num)
				{
				case 219:
				case 220:
					return defaultConstraintDefinition;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x0006E3F4 File Offset: 0x0006C5F4
		public ForeignKeyConstraintDefinition foreignKeyColumnConstraint(IndexAffectingStatement statementType)
		{
			ForeignKeyConstraintDefinition foreignKeyConstraintDefinition = base.FragmentFactory.CreateFragment<ForeignKeyConstraintDefinition>();
			int num = this.LA(1);
			if (num != 68)
			{
				if (num != 127)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
			}
			else
			{
				IToken token = this.LT(1);
				this.match(68);
				this.match(91);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.ThrowSyntaxErrorIfNotCreateAlterTable(statementType, token);
					TSql80ParserBaseInternal.UpdateTokenInfo(foreignKeyConstraintDefinition, token);
				}
				this.foreignConstraintColumnsOpt(foreignKeyConstraintDefinition);
			}
			this.foreignKeyConstraintCommonEnd(statementType, foreignKeyConstraintDefinition);
			return foreignKeyConstraintDefinition;
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x0006E47C File Offset: 0x0006C67C
		public CheckConstraintDefinition checkConstraint(IndexAffectingStatement statementType)
		{
			CheckConstraintDefinition checkConstraintDefinition = base.FragmentFactory.CreateFragment<CheckConstraintDefinition>();
			IToken token = this.LT(1);
			this.match(21);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(checkConstraintDefinition, token);
				base.ThrowConstraintIfPhaseOne(checkConstraintDefinition);
			}
			bool notForReplication = this.replicationClauseOpt(statementType, checkConstraintDefinition);
			if (this.inputState.guessing == 0)
			{
				checkConstraintDefinition.NotForReplication = notForReplication;
			}
			this.match(191);
			BooleanExpression checkCondition = this.booleanExpressionWithFlags(ExpressionFlags.ScalarSubqueriesDisallowed);
			if (this.inputState.guessing == 0)
			{
				checkConstraintDefinition.CheckCondition = checkCondition;
			}
			IToken token2 = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(checkConstraintDefinition, token2);
			}
			return checkConstraintDefinition;
		}

		// Token: 0x060013E7 RID: 5095 RVA: 0x0006E534 File Offset: 0x0006C734
		public UniqueConstraintDefinition uniqueTableConstraint()
		{
			UniqueConstraintDefinition uniqueConstraintDefinition = base.FragmentFactory.CreateFragment<UniqueConstraintDefinition>();
			this.uniqueConstraintHeader(uniqueConstraintDefinition, true);
			this.match(191);
			ColumnWithSortOrder item = this.columnWithSortOrder();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ColumnWithSortOrder>(uniqueConstraintDefinition, uniqueConstraintDefinition.Columns, item);
			}
			while (this.LA(1) == 198)
			{
				this.match(198);
				item = this.columnWithSortOrder();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ColumnWithSortOrder>(uniqueConstraintDefinition, uniqueConstraintDefinition.Columns, item);
				}
			}
			IToken token = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(uniqueConstraintDefinition, token);
			}
			this.uniqueConstraintTailOpt(uniqueConstraintDefinition);
			return uniqueConstraintDefinition;
		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x0006E5F0 File Offset: 0x0006C7F0
		public DefaultConstraintDefinition defaultTableConstraint(IndexAffectingStatement statementType)
		{
			DefaultConstraintDefinition defaultConstraintDefinition = base.FragmentFactory.CreateFragment<DefaultConstraintDefinition>();
			IToken token = this.LT(1);
			this.match(47);
			if (this.inputState.guessing == 0)
			{
				if (statementType != IndexAffectingStatement.AlterTableAddElement)
				{
					TSql80ParserBaseInternal.ThrowParseErrorException("SQL46014", token, TSqlParserResource.SQL46014Message, new string[0]);
				}
				TSql80ParserBaseInternal.UpdateTokenInfo(defaultConstraintDefinition, token);
				base.ThrowConstraintIfPhaseOne(defaultConstraintDefinition);
			}
			ScalarExpression expression = this.expressionWithFlags(ExpressionFlags.ScalarSubqueriesDisallowed);
			this.match(67);
			Identifier column = this.identifier();
			if (this.inputState.guessing == 0)
			{
				defaultConstraintDefinition.Expression = expression;
				defaultConstraintDefinition.Column = column;
			}
			int num = this.LA(1);
			if (num <= 86)
			{
				if (num <= 28)
				{
					if (num <= 6)
					{
						if (num == 1 || num == 6)
						{
							return defaultConstraintDefinition;
						}
					}
					else
					{
						switch (num)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							return defaultConstraintDefinition;
						case 14:
						case 16:
							break;
						default:
							switch (num)
							{
							case 22:
							case 23:
								return defaultConstraintDefinition;
							default:
								if (num == 28)
								{
									return defaultConstraintDefinition;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num <= 64)
				{
					switch (num)
					{
					case 33:
					case 35:
						return defaultConstraintDefinition;
					case 34:
						break;
					default:
						switch (num)
						{
						case 44:
						case 45:
						case 46:
						case 48:
						case 49:
						case 54:
						case 55:
						case 56:
						case 60:
						case 61:
						case 64:
							return defaultConstraintDefinition;
						}
						break;
					}
				}
				else
				{
					switch (num)
					{
					case 74:
					case 75:
						return defaultConstraintDefinition;
					default:
						if (num == 82 || num == 86)
						{
							return defaultConstraintDefinition;
						}
						break;
					}
				}
			}
			else if (num <= 144)
			{
				if (num <= 95)
				{
					if (num == 92 || num == 95)
					{
						return defaultConstraintDefinition;
					}
				}
				else
				{
					if (num == 106 || num == 119)
					{
						return defaultConstraintDefinition;
					}
					switch (num)
					{
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return defaultConstraintDefinition;
					}
				}
			}
			else if (num <= 192)
			{
				switch (num)
				{
				case 156:
				case 160:
				case 161:
				case 162:
					return defaultConstraintDefinition;
				case 157:
				case 158:
				case 159:
					break;
				default:
					switch (num)
					{
					case 167:
					case 170:
					case 172:
					case 173:
					case 176:
					case 180:
					case 181:
						return defaultConstraintDefinition;
					case 168:
					case 169:
					case 174:
					case 175:
					case 177:
					case 178:
					case 179:
						break;
					case 171:
					{
						this.match(171);
						IToken token2 = this.LT(1);
						this.match(164);
						if (this.inputState.guessing == 0)
						{
							TSql80ParserBaseInternal.UpdateTokenInfo(defaultConstraintDefinition, token2);
							defaultConstraintDefinition.WithValues = true;
							return defaultConstraintDefinition;
						}
						return defaultConstraintDefinition;
					}
					default:
						switch (num)
						{
						case 191:
						case 192:
							return defaultConstraintDefinition;
						}
						break;
					}
					break;
				}
			}
			else
			{
				if (num == 198 || num == 204)
				{
					return defaultConstraintDefinition;
				}
				switch (num)
				{
				case 219:
				case 220:
					return defaultConstraintDefinition;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x0006E950 File Offset: 0x0006CB50
		public ForeignKeyConstraintDefinition foreignKeyTableConstraint(IndexAffectingStatement statementType)
		{
			ForeignKeyConstraintDefinition foreignKeyConstraintDefinition = base.FragmentFactory.CreateFragment<ForeignKeyConstraintDefinition>();
			IToken token = this.LT(1);
			this.match(68);
			this.match(91);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.ThrowSyntaxErrorIfNotCreateAlterTable(statementType, token);
				TSql80ParserBaseInternal.UpdateTokenInfo(foreignKeyConstraintDefinition, token);
				base.ThrowConstraintIfPhaseOne(foreignKeyConstraintDefinition);
			}
			this.foreignConstraintColumnsOpt(foreignKeyConstraintDefinition);
			this.foreignKeyConstraintCommonEnd(statementType, foreignKeyConstraintDefinition);
			return foreignKeyConstraintDefinition;
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x0006E9B8 File Offset: 0x0006CBB8
		public void uniqueConstraintHeader(UniqueConstraintDefinition vParent, bool throwInPhaseOne)
		{
			int num = this.LA(1);
			if (num != 118)
			{
				if (num != 159)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				IToken token = this.LT(1);
				this.match(159);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token);
					vParent.IsPrimaryKey = false;
				}
			}
			else
			{
				IToken token2 = this.LT(1);
				this.match(118);
				IToken token3 = this.LT(1);
				this.match(91);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token2);
					TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token3);
					vParent.IsPrimaryKey = true;
				}
			}
			if (this.inputState.guessing == 0 && throwInPhaseOne)
			{
				base.ThrowConstraintIfPhaseOne(vParent);
			}
			int num2 = this.LA(1);
			if (num2 <= 86)
			{
				if (num2 <= 35)
				{
					if (num2 <= 6)
					{
						if (num2 == 1 || num2 == 6)
						{
							return;
						}
					}
					else
					{
						switch (num2)
						{
						case 12:
						case 13:
						case 15:
						case 17:
						case 21:
						case 22:
						case 23:
						case 28:
						case 30:
							return;
						case 14:
						case 16:
						case 18:
						case 19:
						case 20:
						case 25:
						case 26:
						case 27:
						case 29:
							break;
						case 24:
						{
							IToken token4 = this.LT(1);
							this.match(24);
							if (this.inputState.guessing == 0)
							{
								TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token4);
								vParent.Clustered = new bool?(true);
								return;
							}
							return;
						}
						default:
							switch (num2)
							{
							case 33:
							case 35:
								return;
							}
							break;
						}
					}
				}
				else if (num2 <= 75)
				{
					switch (num2)
					{
					case 44:
					case 45:
					case 46:
					case 47:
					case 48:
					case 49:
					case 54:
					case 55:
					case 56:
					case 60:
					case 61:
					case 64:
					case 68:
						return;
					case 50:
					case 51:
					case 52:
					case 53:
					case 57:
					case 58:
					case 59:
					case 62:
					case 63:
					case 65:
					case 66:
					case 67:
						break;
					default:
						switch (num2)
						{
						case 74:
						case 75:
							return;
						}
						break;
					}
				}
				else if (num2 == 79 || num2 == 82 || num2 == 86)
				{
					return;
				}
			}
			else if (num2 <= 176)
			{
				if (num2 <= 106)
				{
					switch (num2)
					{
					case 92:
					case 95:
					case 99:
					case 100:
						return;
					case 93:
					case 94:
					case 96:
					case 97:
						break;
					case 98:
					{
						IToken token5 = this.LT(1);
						this.match(98);
						if (this.inputState.guessing == 0)
						{
							TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token5);
							vParent.Clustered = new bool?(false);
							return;
						}
						return;
					}
					default:
						switch (num2)
						{
						case 105:
						case 106:
							return;
						}
						break;
					}
				}
				else
				{
					switch (num2)
					{
					case 118:
					case 119:
					case 123:
					case 125:
					case 126:
					case 127:
					case 129:
					case 131:
					case 132:
					case 134:
					case 136:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return;
					case 120:
					case 121:
					case 122:
					case 124:
					case 128:
					case 130:
					case 133:
					case 135:
					case 137:
					case 139:
					case 141:
						break;
					default:
						switch (num2)
						{
						case 156:
						case 159:
						case 160:
						case 161:
						case 162:
						case 167:
						case 170:
						case 171:
						case 172:
						case 173:
						case 176:
							return;
						}
						break;
					}
				}
			}
			else if (num2 <= 192)
			{
				switch (num2)
				{
				case 180:
				case 181:
					return;
				default:
					switch (num2)
					{
					case 191:
					case 192:
						return;
					}
					break;
				}
			}
			else
			{
				if (num2 == 198 || num2 == 204)
				{
					return;
				}
				switch (num2)
				{
				case 219:
				case 220:
					return;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x0006EDEC File Offset: 0x0006CFEC
		public void uniqueConstraintTailOpt(UniqueConstraintDefinition vParent)
		{
			this.uniqueConstraintIndexOptionsOpt(vParent);
			int num = this.LA(1);
			if (num <= 92)
			{
				if (num <= 35)
				{
					if (num <= 6)
					{
						if (num == 1 || num == 6)
						{
							return;
						}
					}
					else
					{
						switch (num)
						{
						case 12:
						case 13:
						case 15:
						case 17:
						case 21:
						case 22:
						case 23:
							return;
						case 14:
						case 16:
						case 18:
						case 19:
						case 20:
							break;
						default:
							switch (num)
							{
							case 28:
							case 30:
								return;
							case 29:
								break;
							default:
								switch (num)
								{
								case 33:
								case 35:
									return;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num <= 79)
				{
					switch (num)
					{
					case 44:
					case 45:
					case 46:
					case 47:
					case 48:
					case 49:
					case 54:
					case 55:
					case 56:
					case 60:
					case 61:
					case 64:
					case 68:
						return;
					case 50:
					case 51:
					case 52:
					case 53:
					case 57:
					case 58:
					case 59:
					case 62:
					case 63:
					case 65:
					case 66:
					case 67:
						break;
					default:
						switch (num)
						{
						case 74:
						case 75:
							return;
						default:
							if (num == 79)
							{
								return;
							}
							break;
						}
						break;
					}
				}
				else if (num == 82 || num == 86 || num == 92)
				{
					return;
				}
			}
			else if (num <= 173)
			{
				if (num <= 106)
				{
					if (num == 95)
					{
						return;
					}
					switch (num)
					{
					case 99:
					case 100:
						return;
					default:
						switch (num)
						{
						case 105:
						{
							this.LT(1);
							this.match(105);
							FileGroupOrPartitionScheme onFileGroupOrPartitionScheme = this.filegroupOrPartitionScheme();
							if (this.inputState.guessing == 0)
							{
								vParent.OnFileGroupOrPartitionScheme = onFileGroupOrPartitionScheme;
								return;
							}
							return;
						}
						case 106:
							return;
						}
						break;
					}
				}
				else
				{
					switch (num)
					{
					case 118:
					case 119:
					case 123:
					case 125:
					case 126:
					case 127:
					case 129:
					case 131:
					case 132:
					case 134:
					case 136:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return;
					case 120:
					case 121:
					case 122:
					case 124:
					case 128:
					case 130:
					case 133:
					case 135:
					case 137:
					case 139:
					case 141:
						break;
					default:
						switch (num)
						{
						case 156:
						case 159:
						case 160:
						case 161:
						case 162:
							return;
						case 157:
						case 158:
							break;
						default:
							switch (num)
							{
							case 167:
							case 170:
							case 172:
							case 173:
								return;
							}
							break;
						}
						break;
					}
				}
			}
			else if (num <= 192)
			{
				if (num == 176)
				{
					return;
				}
				switch (num)
				{
				case 180:
				case 181:
					return;
				default:
					switch (num)
					{
					case 191:
					case 192:
						return;
					}
					break;
				}
			}
			else
			{
				if (num == 198 || num == 204)
				{
					return;
				}
				switch (num)
				{
				case 219:
				case 220:
					return;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x0006F0F0 File Offset: 0x0006D2F0
		public void uniqueConstraintIndexOptionsOpt(UniqueConstraintDefinition vParent)
		{
			int num = this.LA(1);
			if (num <= 86)
			{
				if (num <= 35)
				{
					if (num <= 6)
					{
						if (num == 1 || num == 6)
						{
							return;
						}
					}
					else
					{
						switch (num)
						{
						case 12:
						case 13:
						case 15:
						case 17:
						case 21:
						case 22:
						case 23:
							return;
						case 14:
						case 16:
						case 18:
						case 19:
						case 20:
							break;
						default:
							switch (num)
							{
							case 28:
							case 30:
								return;
							case 29:
								break;
							default:
								switch (num)
								{
								case 33:
								case 35:
									return;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num <= 75)
				{
					switch (num)
					{
					case 44:
					case 45:
					case 46:
					case 47:
					case 48:
					case 49:
					case 54:
					case 55:
					case 56:
					case 60:
					case 61:
					case 64:
					case 68:
						return;
					case 50:
					case 51:
					case 52:
					case 53:
					case 57:
					case 58:
					case 59:
					case 62:
					case 63:
					case 65:
					case 66:
					case 67:
						break;
					default:
						switch (num)
						{
						case 74:
						case 75:
							return;
						}
						break;
					}
				}
				else if (num == 79 || num == 82 || num == 86)
				{
					return;
				}
			}
			else if (num <= 144)
			{
				if (num <= 95)
				{
					if (num == 92 || num == 95)
					{
						return;
					}
				}
				else
				{
					switch (num)
					{
					case 99:
					case 100:
						return;
					default:
						switch (num)
						{
						case 105:
						case 106:
							return;
						default:
							switch (num)
							{
							case 118:
							case 119:
							case 123:
							case 125:
							case 126:
							case 127:
							case 129:
							case 131:
							case 132:
							case 134:
							case 136:
							case 138:
							case 140:
							case 142:
							case 143:
							case 144:
								return;
							}
							break;
						}
						break;
					}
				}
			}
			else if (num <= 192)
			{
				switch (num)
				{
				case 156:
				case 159:
				case 160:
				case 161:
				case 162:
				case 167:
				case 170:
				case 172:
				case 173:
				case 176:
					return;
				case 157:
				case 158:
				case 163:
				case 164:
				case 165:
				case 166:
				case 168:
				case 169:
				case 174:
				case 175:
					break;
				case 171:
				{
					this.match(171);
					int num2 = this.LA(1);
					if (num2 != 66)
					{
						if (num2 != 232)
						{
							throw new NoViableAltException(this.LT(1), this.getFilename());
						}
						this.sortedDataOptions();
						int num3 = this.LA(1);
						if (num3 <= 92)
						{
							if (num3 <= 35)
							{
								if (num3 <= 6)
								{
									if (num3 == 1 || num3 == 6)
									{
										return;
									}
								}
								else
								{
									switch (num3)
									{
									case 12:
									case 13:
									case 15:
									case 17:
									case 21:
									case 22:
									case 23:
										return;
									case 14:
									case 16:
									case 18:
									case 19:
									case 20:
										break;
									default:
										switch (num3)
										{
										case 28:
										case 30:
											return;
										case 29:
											break;
										default:
											switch (num3)
											{
											case 33:
											case 35:
												return;
											}
											break;
										}
										break;
									}
								}
							}
							else if (num3 <= 79)
							{
								switch (num3)
								{
								case 44:
								case 45:
								case 46:
								case 47:
								case 48:
								case 49:
								case 54:
								case 55:
								case 56:
								case 60:
								case 61:
								case 64:
								case 68:
									return;
								case 50:
								case 51:
								case 52:
								case 53:
								case 57:
								case 58:
								case 59:
								case 62:
								case 63:
								case 65:
								case 67:
									break;
								case 66:
								{
									IndexOption item = this.fillFactorOption();
									if (this.inputState.guessing == 0)
									{
										TSql80ParserBaseInternal.AddAndUpdateTokenInfo<IndexOption>(vParent, vParent.IndexOptions, item);
										return;
									}
									return;
								}
								default:
									switch (num3)
									{
									case 74:
									case 75:
										return;
									default:
										if (num3 == 79)
										{
											return;
										}
										break;
									}
									break;
								}
							}
							else if (num3 == 82 || num3 == 86 || num3 == 92)
							{
								return;
							}
						}
						else if (num3 <= 173)
						{
							if (num3 <= 106)
							{
								if (num3 == 95)
								{
									return;
								}
								switch (num3)
								{
								case 99:
								case 100:
									return;
								default:
									switch (num3)
									{
									case 105:
									case 106:
										return;
									}
									break;
								}
							}
							else
							{
								switch (num3)
								{
								case 118:
								case 119:
								case 123:
								case 125:
								case 126:
								case 127:
								case 129:
								case 131:
								case 132:
								case 134:
								case 136:
								case 138:
								case 140:
								case 142:
								case 143:
								case 144:
									return;
								case 120:
								case 121:
								case 122:
								case 124:
								case 128:
								case 130:
								case 133:
								case 135:
								case 137:
								case 139:
								case 141:
									break;
								default:
									switch (num3)
									{
									case 156:
									case 159:
									case 160:
									case 161:
									case 162:
										return;
									case 157:
									case 158:
										break;
									default:
										switch (num3)
										{
										case 167:
										case 170:
										case 172:
										case 173:
											return;
										}
										break;
									}
									break;
								}
							}
						}
						else if (num3 <= 192)
						{
							if (num3 == 176)
							{
								return;
							}
							switch (num3)
							{
							case 180:
							case 181:
								return;
							default:
								switch (num3)
								{
								case 191:
								case 192:
									return;
								}
								break;
							}
						}
						else
						{
							if (num3 == 198 || num3 == 204)
							{
								return;
							}
							switch (num3)
							{
							case 219:
							case 220:
								return;
							}
						}
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
					else
					{
						IndexOption item = this.fillFactorOption();
						if (this.inputState.guessing == 0)
						{
							TSql80ParserBaseInternal.AddAndUpdateTokenInfo<IndexOption>(vParent, vParent.IndexOptions, item);
						}
						if (this.LA(1) == 232 && base.NextTokenMatchesOneOf(new string[]
						{
							"SORTED_DATA",
							"SORTED_DATA_REORG"
						}))
						{
							this.sortedDataOptions();
							return;
						}
						if (TSql80ParserInternal.tokenSet_77_.member(this.LA(1)))
						{
							return;
						}
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
					break;
				}
				default:
					switch (num)
					{
					case 180:
					case 181:
						return;
					default:
						switch (num)
						{
						case 191:
						case 192:
							return;
						}
						break;
					}
					break;
				}
			}
			else
			{
				if (num == 198 || num == 204)
				{
					return;
				}
				switch (num)
				{
				case 219:
				case 220:
					return;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x0006F79C File Offset: 0x0006D99C
		public void sortedDataOptions()
		{
			IToken token = this.LT(1);
			this.match(232);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.Match(token, "SORTED_DATA", "SORTED_DATA_REORG");
			}
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x0006F7DC File Offset: 0x0006D9DC
		public DeleteUpdateAction deleteUpdateAction(TSqlFragment vParent)
		{
			DeleteUpdateAction result = DeleteUpdateAction.NoAction;
			int num = this.LA(1);
			if (num != 19)
			{
				if (num != 142)
				{
					if (num != 232)
					{
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
					IToken token = this.LT(1);
					this.match(232);
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.Match(token, "NO");
					}
					IToken token2 = this.LT(1);
					this.match(232);
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token2);
						TSql80ParserBaseInternal.Match(token2, "ACTION");
					}
				}
				else
				{
					this.match(142);
					int num2 = this.LA(1);
					if (num2 != 47)
					{
						if (num2 != 100)
						{
							throw new NoViableAltException(this.LT(1), this.getFilename());
						}
						IToken token3 = this.LT(1);
						this.match(100);
						if (this.inputState.guessing == 0)
						{
							TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token3);
							result = DeleteUpdateAction.SetNull;
						}
					}
					else
					{
						IToken token4 = this.LT(1);
						this.match(47);
						if (this.inputState.guessing == 0)
						{
							TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token4);
							result = DeleteUpdateAction.SetDefault;
						}
					}
				}
			}
			else
			{
				IToken token5 = this.LT(1);
				this.match(19);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token5);
					result = DeleteUpdateAction.Cascade;
				}
			}
			return result;
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x0006F94C File Offset: 0x0006DB4C
		public void foreignKeyConstraintCommonEnd(IndexAffectingStatement statementType, ForeignKeyConstraintDefinition vParent)
		{
			bool flag = false;
			IToken token = this.LT(1);
			this.match(127);
			SchemaObjectName referenceTableName = this.schemaObjectThreePartName();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.ThrowSyntaxErrorIfNotCreateAlterTable(statementType, token);
				TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token);
				vParent.ReferenceTableName = referenceTableName;
			}
			bool flag2 = false;
			if (this.LA(1) == 191 && (this.LA(2) == 232 || this.LA(2) == 233))
			{
				int pos = this.mark();
				flag2 = true;
				this.inputState.guessing++;
				try
				{
					this.match(191);
					this.identifier();
				}
				catch (RecognitionException)
				{
					flag2 = false;
				}
				this.rewind(pos);
				this.inputState.guessing--;
			}
			if (flag2)
			{
				this.columnNameList(vParent, vParent.ReferencedTableColumns);
			}
			else if (!TSql80ParserInternal.tokenSet_77_.member(this.LA(1)) || !TSql80ParserInternal.tokenSet_75_.member(this.LA(2)))
			{
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			bool flag3 = false;
			if (this.LA(1) == 105 && this.LA(2) == 48)
			{
				int pos2 = this.mark();
				flag3 = true;
				this.inputState.guessing++;
				try
				{
					this.match(105);
					this.match(48);
				}
				catch (RecognitionException)
				{
					flag3 = false;
				}
				this.rewind(pos2);
				this.inputState.guessing--;
			}
			if (flag3)
			{
				this.match(105);
				this.match(48);
				DeleteUpdateAction deleteUpdateAction = this.deleteUpdateAction(vParent);
				if (this.inputState.guessing == 0)
				{
					vParent.DeleteAction = deleteUpdateAction;
					flag = true;
				}
			}
			else if (!TSql80ParserInternal.tokenSet_77_.member(this.LA(1)) || !TSql80ParserInternal.tokenSet_75_.member(this.LA(2)))
			{
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			int num = this.LA(1);
			if (num <= 92)
			{
				if (num <= 35)
				{
					if (num <= 6)
					{
						if (num == 1 || num == 6)
						{
							goto IL_82C;
						}
					}
					else
					{
						switch (num)
						{
						case 12:
						case 13:
						case 15:
						case 17:
						case 21:
						case 22:
						case 23:
							goto IL_82C;
						case 14:
						case 16:
						case 18:
						case 19:
						case 20:
							break;
						default:
							switch (num)
							{
							case 28:
							case 30:
								goto IL_82C;
							case 29:
								break;
							default:
								switch (num)
								{
								case 33:
								case 35:
									goto IL_82C;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num <= 79)
				{
					switch (num)
					{
					case 44:
					case 45:
					case 46:
					case 47:
					case 48:
					case 49:
					case 54:
					case 55:
					case 56:
					case 60:
					case 61:
					case 64:
					case 68:
						goto IL_82C;
					case 50:
					case 51:
					case 52:
					case 53:
					case 57:
					case 58:
					case 59:
					case 62:
					case 63:
					case 65:
					case 66:
					case 67:
						break;
					default:
						switch (num)
						{
						case 74:
						case 75:
							goto IL_82C;
						default:
							if (num == 79)
							{
								goto IL_82C;
							}
							break;
						}
						break;
					}
				}
				else if (num == 82 || num == 86 || num == 92)
				{
					goto IL_82C;
				}
			}
			else if (num <= 173)
			{
				if (num <= 106)
				{
					if (num == 95)
					{
						goto IL_82C;
					}
					switch (num)
					{
					case 99:
					case 100:
						goto IL_82C;
					default:
						switch (num)
						{
						case 105:
						{
							this.match(105);
							this.match(160);
							DeleteUpdateAction deleteUpdateAction = this.deleteUpdateAction(vParent);
							if (this.inputState.guessing == 0)
							{
								vParent.UpdateAction = deleteUpdateAction;
							}
							int num2 = this.LA(1);
							if (num2 <= 92)
							{
								if (num2 <= 35)
								{
									if (num2 <= 6)
									{
										if (num2 == 1 || num2 == 6)
										{
											goto IL_82C;
										}
									}
									else
									{
										switch (num2)
										{
										case 12:
										case 13:
										case 15:
										case 17:
										case 21:
										case 22:
										case 23:
											goto IL_82C;
										case 14:
										case 16:
										case 18:
										case 19:
										case 20:
											break;
										default:
											switch (num2)
											{
											case 28:
											case 30:
												goto IL_82C;
											case 29:
												break;
											default:
												switch (num2)
												{
												case 33:
												case 35:
													goto IL_82C;
												}
												break;
											}
											break;
										}
									}
								}
								else if (num2 <= 79)
								{
									switch (num2)
									{
									case 44:
									case 45:
									case 46:
									case 47:
									case 48:
									case 49:
									case 54:
									case 55:
									case 56:
									case 60:
									case 61:
									case 64:
									case 68:
										goto IL_82C;
									case 50:
									case 51:
									case 52:
									case 53:
									case 57:
									case 58:
									case 59:
									case 62:
									case 63:
									case 65:
									case 66:
									case 67:
										break;
									default:
										switch (num2)
										{
										case 74:
										case 75:
											goto IL_82C;
										default:
											if (num2 == 79)
											{
												goto IL_82C;
											}
											break;
										}
										break;
									}
								}
								else if (num2 == 82 || num2 == 86 || num2 == 92)
								{
									goto IL_82C;
								}
							}
							else if (num2 <= 173)
							{
								if (num2 <= 106)
								{
									if (num2 == 95)
									{
										goto IL_82C;
									}
									switch (num2)
									{
									case 99:
									case 100:
										goto IL_82C;
									default:
										switch (num2)
										{
										case 105:
										{
											IToken token2 = this.LT(1);
											this.match(105);
											this.match(48);
											deleteUpdateAction = this.deleteUpdateAction(vParent);
											if (this.inputState.guessing != 0)
											{
												goto IL_82C;
											}
											if (flag)
											{
												throw TSql80ParserBaseInternal.GetUnexpectedTokenErrorException(token2);
											}
											vParent.DeleteAction = deleteUpdateAction;
											goto IL_82C;
										}
										case 106:
											goto IL_82C;
										}
										break;
									}
								}
								else
								{
									switch (num2)
									{
									case 118:
									case 119:
									case 123:
									case 125:
									case 126:
									case 127:
									case 129:
									case 131:
									case 132:
									case 134:
									case 136:
									case 138:
									case 140:
									case 142:
									case 143:
									case 144:
										goto IL_82C;
									case 120:
									case 121:
									case 122:
									case 124:
									case 128:
									case 130:
									case 133:
									case 135:
									case 137:
									case 139:
									case 141:
										break;
									default:
										switch (num2)
										{
										case 156:
										case 159:
										case 160:
										case 161:
										case 162:
											goto IL_82C;
										case 157:
										case 158:
											break;
										default:
											switch (num2)
											{
											case 167:
											case 170:
											case 172:
											case 173:
												goto IL_82C;
											}
											break;
										}
										break;
									}
								}
							}
							else if (num2 <= 192)
							{
								if (num2 == 176)
								{
									goto IL_82C;
								}
								switch (num2)
								{
								case 180:
								case 181:
									goto IL_82C;
								default:
									switch (num2)
									{
									case 191:
									case 192:
										goto IL_82C;
									}
									break;
								}
							}
							else
							{
								if (num2 == 198 || num2 == 204)
								{
									goto IL_82C;
								}
								switch (num2)
								{
								case 219:
								case 220:
									goto IL_82C;
								}
							}
							throw new NoViableAltException(this.LT(1), this.getFilename());
						}
						case 106:
							goto IL_82C;
						}
						break;
					}
				}
				else
				{
					switch (num)
					{
					case 118:
					case 119:
					case 123:
					case 125:
					case 126:
					case 127:
					case 129:
					case 131:
					case 132:
					case 134:
					case 136:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						goto IL_82C;
					case 120:
					case 121:
					case 122:
					case 124:
					case 128:
					case 130:
					case 133:
					case 135:
					case 137:
					case 139:
					case 141:
						break;
					default:
						switch (num)
						{
						case 156:
						case 159:
						case 160:
						case 161:
						case 162:
							goto IL_82C;
						case 157:
						case 158:
							break;
						default:
							switch (num)
							{
							case 167:
							case 170:
							case 172:
							case 173:
								goto IL_82C;
							}
							break;
						}
						break;
					}
				}
			}
			else if (num <= 192)
			{
				if (num == 176)
				{
					goto IL_82C;
				}
				switch (num)
				{
				case 180:
				case 181:
					goto IL_82C;
				default:
					switch (num)
					{
					case 191:
					case 192:
						goto IL_82C;
					}
					break;
				}
			}
			else
			{
				if (num == 198 || num == 204)
				{
					goto IL_82C;
				}
				switch (num)
				{
				case 219:
				case 220:
					goto IL_82C;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_82C:
			bool notForReplication = this.replicationClauseOpt(statementType, vParent);
			if (this.inputState.guessing == 0)
			{
				vParent.NotForReplication = notForReplication;
			}
		}

		// Token: 0x060013F0 RID: 5104 RVA: 0x000701C0 File Offset: 0x0006E3C0
		public void foreignConstraintColumnsOpt(ForeignKeyConstraintDefinition vParent)
		{
			int num = this.LA(1);
			if (num == 127)
			{
				return;
			}
			if (num == 191)
			{
				this.columnNameList(vParent, vParent.Columns);
				return;
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x060013F1 RID: 5105 RVA: 0x00070204 File Offset: 0x0006E404
		public BooleanExpression booleanExpressionWithFlags(ExpressionFlags expressionFlags)
		{
			return this.booleanExpressionOr(expressionFlags);
		}

		// Token: 0x060013F2 RID: 5106 RVA: 0x0007021C File Offset: 0x0006E41C
		public SqlDataTypeReference sqlDataTypeWithoutNational(SchemaObjectName vName, SqlDataTypeOption vType)
		{
			SqlDataTypeReference sqlDataTypeReference = base.FragmentFactory.CreateFragment<SqlDataTypeReference>();
			sqlDataTypeReference.Name = vName;
			sqlDataTypeReference.SqlDataTypeOption = vType;
			sqlDataTypeReference.UpdateTokenInfo(vName);
			bool isVarying = false;
			int num = this.LA(1);
			if (num <= 86)
			{
				if (num <= 35)
				{
					if (num <= 6)
					{
						if (num == 1 || num == 6)
						{
							goto IL_35C;
						}
					}
					else
					{
						switch (num)
						{
						case 9:
						case 12:
						case 13:
						case 15:
						case 17:
						case 21:
						case 22:
						case 23:
							goto IL_35C;
						case 10:
						case 11:
						case 14:
						case 16:
						case 18:
						case 19:
						case 20:
							break;
						default:
							switch (num)
							{
							case 26:
							case 28:
							case 30:
								goto IL_35C;
							case 27:
							case 29:
								break;
							default:
								switch (num)
								{
								case 33:
								case 35:
									goto IL_35C;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num <= 75)
				{
					switch (num)
					{
					case 44:
					case 45:
					case 46:
					case 47:
					case 48:
					case 49:
					case 54:
					case 55:
					case 56:
					case 60:
					case 61:
					case 64:
					case 67:
					case 68:
						goto IL_35C;
					case 50:
					case 51:
					case 52:
					case 53:
					case 57:
					case 58:
					case 59:
					case 62:
					case 63:
					case 65:
					case 66:
						break;
					default:
						switch (num)
						{
						case 74:
						case 75:
							goto IL_35C;
						}
						break;
					}
				}
				else if (num == 79 || num == 82 || num == 86)
				{
					goto IL_35C;
				}
			}
			else if (num <= 144)
			{
				if (num <= 95)
				{
					if (num == 92 || num == 95)
					{
						goto IL_35C;
					}
				}
				else
				{
					switch (num)
					{
					case 99:
					case 100:
						goto IL_35C;
					default:
						if (num == 106)
						{
							goto IL_35C;
						}
						switch (num)
						{
						case 118:
						case 119:
						case 123:
						case 125:
						case 126:
						case 127:
						case 129:
						case 131:
						case 132:
						case 134:
						case 136:
						case 138:
						case 140:
						case 142:
						case 143:
						case 144:
							goto IL_35C;
						}
						break;
					}
				}
			}
			else if (num <= 198)
			{
				switch (num)
				{
				case 156:
				case 159:
				case 160:
				case 161:
				case 162:
				case 167:
				case 170:
				case 171:
				case 172:
				case 173:
				case 176:
				case 180:
				case 181:
					goto IL_35C;
				case 157:
				case 158:
				case 163:
				case 164:
				case 166:
				case 168:
				case 169:
				case 174:
				case 175:
				case 177:
				case 178:
				case 179:
					break;
				case 165:
				{
					IToken token = this.LT(1);
					this.match(165);
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.UpdateTokenInfo(sqlDataTypeReference, token);
						isVarying = true;
						goto IL_35C;
					}
					goto IL_35C;
				}
				default:
					switch (num)
					{
					case 191:
					case 192:
						goto IL_35C;
					default:
						if (num == 198)
						{
							goto IL_35C;
						}
						break;
					}
					break;
				}
			}
			else
			{
				switch (num)
				{
				case 204:
				case 206:
					goto IL_35C;
				case 205:
					break;
				default:
					switch (num)
					{
					case 219:
					case 220:
						goto IL_35C;
					default:
						switch (num)
						{
						case 230:
						case 231:
						case 232:
						case 234:
							goto IL_35C;
						}
						break;
					}
					break;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_35C:
			this.dataTypeParametersOpt(sqlDataTypeReference);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.ProcessNationalAndVarying(sqlDataTypeReference, null, isVarying);
				TSql80ParserBaseInternal.CheckSqlDataTypeParameters(sqlDataTypeReference);
			}
			return sqlDataTypeReference;
		}

		// Token: 0x060013F3 RID: 5107 RVA: 0x000705A8 File Offset: 0x0006E7A8
		public UserDataTypeReference userDataType(SchemaObjectName vName)
		{
			UserDataTypeReference userDataTypeReference = base.FragmentFactory.CreateFragment<UserDataTypeReference>();
			userDataTypeReference.Name = vName;
			userDataTypeReference.UpdateTokenInfo(vName);
			this.dataTypeParametersOpt(userDataTypeReference);
			return userDataTypeReference;
		}

		// Token: 0x060013F4 RID: 5108 RVA: 0x000705D8 File Offset: 0x0006E7D8
		public SqlDataTypeReference doubleDataType()
		{
			SqlDataTypeReference sqlDataTypeReference = base.FragmentFactory.CreateFragment<SqlDataTypeReference>();
			IToken doubleToken = this.LT(1);
			this.match(53);
			IToken precisionToken = this.LT(1);
			this.match(174);
			if (this.inputState.guessing == 0)
			{
				base.SetNameForDoublePrecisionType(sqlDataTypeReference, doubleToken, precisionToken);
				sqlDataTypeReference.SqlDataTypeOption = SqlDataTypeOption.Float;
			}
			bool flag = false;
			if (this.LA(1) == 191 && this.LA(2) == 221)
			{
				int pos = this.mark();
				flag = true;
				this.inputState.guessing++;
				try
				{
					this.match(191);
					int num = this.LA(1);
					if (num != 221)
					{
						if (num != 232)
						{
							throw new NoViableAltException(this.LT(1), this.getFilename());
						}
						this.match(232);
					}
					else
					{
						this.integer();
					}
				}
				catch (RecognitionException)
				{
					flag = false;
				}
				this.rewind(pos);
				this.inputState.guessing--;
			}
			if (flag)
			{
				this.match(191);
				Literal item = this.integer();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<Literal>(sqlDataTypeReference, sqlDataTypeReference.Parameters, item);
				}
				IToken token = this.LT(1);
				this.match(192);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(sqlDataTypeReference, token);
				}
			}
			else if (!TSql80ParserInternal.tokenSet_2_.member(this.LA(1)) || !TSql80ParserInternal.tokenSet_1_.member(this.LA(2)))
			{
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			return sqlDataTypeReference;
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x00070794 File Offset: 0x0006E994
		public SqlDataTypeReference sqlDataTypeWithNational()
		{
			SqlDataTypeReference sqlDataTypeReference = base.FragmentFactory.CreateFragment<SqlDataTypeReference>();
			bool isVarying = false;
			IToken token = this.LT(1);
			this.match(96);
			Identifier identifier = this.identifier();
			if (this.inputState.guessing == 0)
			{
				sqlDataTypeReference.SqlDataTypeOption = TSql80ParserBaseInternal.ParseDataType(identifier.Value);
				if (sqlDataTypeReference.SqlDataTypeOption == SqlDataTypeOption.None)
				{
					TSql80ParserBaseInternal.ThrowParseErrorException("SQL46003", token, TSqlParserResource.SQL46003Message, new string[]
					{
						TSqlParserResource.UserDefined
					});
				}
				sqlDataTypeReference.Name = base.FragmentFactory.CreateFragment<SchemaObjectName>();
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<Identifier>(sqlDataTypeReference.Name, sqlDataTypeReference.Name.Identifiers, identifier);
				TSql80ParserBaseInternal.UpdateTokenInfo(sqlDataTypeReference, token);
				sqlDataTypeReference.UpdateTokenInfo(identifier);
			}
			int num = this.LA(1);
			if (num <= 86)
			{
				if (num <= 35)
				{
					if (num <= 6)
					{
						if (num == 1 || num == 6)
						{
							goto IL_3FE;
						}
					}
					else
					{
						switch (num)
						{
						case 9:
						case 12:
						case 13:
						case 15:
						case 17:
						case 21:
						case 22:
						case 23:
							goto IL_3FE;
						case 10:
						case 11:
						case 14:
						case 16:
						case 18:
						case 19:
						case 20:
							break;
						default:
							switch (num)
							{
							case 26:
							case 28:
							case 30:
								goto IL_3FE;
							case 27:
							case 29:
								break;
							default:
								switch (num)
								{
								case 33:
								case 35:
									goto IL_3FE;
								}
								break;
							}
							break;
						}
					}
				}
				else if (num <= 75)
				{
					switch (num)
					{
					case 44:
					case 45:
					case 46:
					case 47:
					case 48:
					case 49:
					case 54:
					case 55:
					case 56:
					case 60:
					case 61:
					case 64:
					case 67:
					case 68:
						goto IL_3FE;
					case 50:
					case 51:
					case 52:
					case 53:
					case 57:
					case 58:
					case 59:
					case 62:
					case 63:
					case 65:
					case 66:
						break;
					default:
						switch (num)
						{
						case 74:
						case 75:
							goto IL_3FE;
						}
						break;
					}
				}
				else if (num == 79 || num == 82 || num == 86)
				{
					goto IL_3FE;
				}
			}
			else if (num <= 144)
			{
				if (num <= 95)
				{
					if (num == 92 || num == 95)
					{
						goto IL_3FE;
					}
				}
				else
				{
					switch (num)
					{
					case 99:
					case 100:
						goto IL_3FE;
					default:
						if (num == 106)
						{
							goto IL_3FE;
						}
						switch (num)
						{
						case 118:
						case 119:
						case 123:
						case 125:
						case 126:
						case 127:
						case 129:
						case 131:
						case 132:
						case 134:
						case 136:
						case 138:
						case 140:
						case 142:
						case 143:
						case 144:
							goto IL_3FE;
						}
						break;
					}
				}
			}
			else if (num <= 198)
			{
				switch (num)
				{
				case 156:
				case 159:
				case 160:
				case 161:
				case 162:
				case 167:
				case 170:
				case 171:
				case 172:
				case 173:
				case 176:
				case 180:
				case 181:
					goto IL_3FE;
				case 157:
				case 158:
				case 163:
				case 164:
				case 166:
				case 168:
				case 169:
				case 174:
				case 175:
				case 177:
				case 178:
				case 179:
					break;
				case 165:
				{
					IToken token2 = this.LT(1);
					this.match(165);
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.UpdateTokenInfo(sqlDataTypeReference, token2);
						isVarying = true;
						goto IL_3FE;
					}
					goto IL_3FE;
				}
				default:
					switch (num)
					{
					case 191:
					case 192:
						goto IL_3FE;
					default:
						if (num == 198)
						{
							goto IL_3FE;
						}
						break;
					}
					break;
				}
			}
			else
			{
				switch (num)
				{
				case 204:
				case 206:
					goto IL_3FE;
				case 205:
					break;
				default:
					switch (num)
					{
					case 219:
					case 220:
						goto IL_3FE;
					default:
						switch (num)
						{
						case 230:
						case 231:
						case 232:
						case 234:
							goto IL_3FE;
						}
						break;
					}
					break;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_3FE:
			this.dataTypeParametersOpt(sqlDataTypeReference);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.ProcessNationalAndVarying(sqlDataTypeReference, token, isVarying);
				TSql80ParserBaseInternal.CheckSqlDataTypeParameters(sqlDataTypeReference);
			}
			return sqlDataTypeReference;
		}

		// Token: 0x060013F6 RID: 5110 RVA: 0x00070BC4 File Offset: 0x0006EDC4
		public void dataTypeParametersOpt(ParameterizedDataTypeReference vParent)
		{
			bool flag = false;
			if (this.LA(1) == 191 && this.LA(2) == 221)
			{
				int pos = this.mark();
				flag = true;
				this.inputState.guessing++;
				try
				{
					this.match(191);
					this.integer();
				}
				catch (RecognitionException)
				{
					flag = false;
				}
				this.rewind(pos);
				this.inputState.guessing--;
			}
			if (flag)
			{
				this.match(191);
				Literal item = this.integer();
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<Literal>(vParent, vParent.Parameters, item);
				}
				int num = this.LA(1);
				if (num != 192)
				{
					if (num != 198)
					{
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
					this.match(198);
					item = this.integer();
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.AddAndUpdateTokenInfo<Literal>(vParent, vParent.Parameters, item);
					}
				}
				IToken token = this.LT(1);
				this.match(192);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token);
					return;
				}
				return;
			}
			else
			{
				if (TSql80ParserInternal.tokenSet_2_.member(this.LA(1)) && TSql80ParserInternal.tokenSet_1_.member(this.LA(2)))
				{
					return;
				}
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
		}

		// Token: 0x060013F7 RID: 5111 RVA: 0x00070D40 File Offset: 0x0006EF40
		public void identifierListElement(List<Identifier> vParent, int vMaxNumber, bool first)
		{
			IToken token = this.LT(1);
			this.match(200);
			Identifier item;
			if (this.inputState.guessing == 0 && first)
			{
				item = base.GetEmptyIdentifier(token);
				TSql80ParserBaseInternal.AddIdentifierToListWithCheck(vParent, item, vMaxNumber);
			}
			while (this.LA(1) == 200)
			{
				IToken token2 = this.LT(1);
				this.match(200);
				if (this.inputState.guessing == 0)
				{
					item = base.GetEmptyIdentifier(token2);
					TSql80ParserBaseInternal.AddIdentifierToListWithCheck(vParent, item, vMaxNumber);
				}
			}
			item = this.identifier();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddIdentifierToListWithCheck(vParent, item, vMaxNumber);
			}
		}

		// Token: 0x060013F8 RID: 5112 RVA: 0x00070DE0 File Offset: 0x0006EFE0
		public BooleanExpression booleanExpressionOr(ExpressionFlags expressionFlags)
		{
			BooleanExpression result = null;
			result = this.booleanExpressionAnd(expressionFlags);
			while (this.LA(1) == 112)
			{
				this.match(112);
				BooleanExpression expression = this.booleanExpressionAnd(expressionFlags);
				if (this.inputState.guessing == 0)
				{
					base.AddBinaryExpression(ref result, expression, BooleanBinaryExpressionType.Or);
				}
			}
			return result;
		}

		// Token: 0x060013F9 RID: 5113 RVA: 0x00070E2C File Offset: 0x0006F02C
		public BooleanExpression booleanExpressionAnd(ExpressionFlags expressionFlags)
		{
			BooleanExpression result = null;
			result = this.booleanExpressionUnary(expressionFlags);
			while (this.LA(1) == 7)
			{
				this.match(7);
				BooleanExpression expression = this.booleanExpressionUnary(expressionFlags);
				if (this.inputState.guessing == 0)
				{
					base.AddBinaryExpression(ref result, expression, BooleanBinaryExpressionType.And);
				}
			}
			return result;
		}

		// Token: 0x060013FA RID: 5114 RVA: 0x00070E78 File Offset: 0x0006F078
		public BooleanExpression booleanExpressionUnary(ExpressionFlags expressionFlags)
		{
			BooleanExpression result = null;
			int num = this.LA(1);
			if (num <= 101)
			{
				if (num <= 41)
				{
					if (num <= 25)
					{
						if (num != 20 && num != 25)
						{
							goto IL_220;
						}
					}
					else if (num != 31 && num != 34)
					{
						switch (num)
						{
						case 40:
						case 41:
							break;
						default:
							goto IL_220;
						}
					}
				}
				else if (num <= 69)
				{
					if (num != 62 && num != 69)
					{
						goto IL_220;
					}
				}
				else if (num != 81 && num != 93)
				{
					switch (num)
					{
					case 99:
					{
						IToken token = this.LT(1);
						this.match(99);
						BooleanExpression expression = this.booleanExpressionUnary(expressionFlags);
						if (this.inputState.guessing == 0)
						{
							BooleanNotExpression booleanNotExpression = base.FragmentFactory.CreateFragment<BooleanNotExpression>();
							result = booleanNotExpression;
							TSql80ParserBaseInternal.UpdateTokenInfo(booleanNotExpression, token);
							booleanNotExpression.Expression = expression;
							return result;
						}
						return result;
					}
					case 100:
					case 101:
						break;
					default:
						goto IL_220;
					}
				}
			}
			else if (num <= 157)
			{
				if (num <= 136)
				{
					if (num != 133 && num != 136)
					{
						goto IL_220;
					}
				}
				else if (num != 141 && num != 147 && num != 157)
				{
					goto IL_220;
				}
			}
			else if (num <= 163)
			{
				if (num != 160 && num != 163)
				{
					goto IL_220;
				}
			}
			else
			{
				switch (num)
				{
				case 191:
				case 193:
					break;
				case 192:
					goto IL_220;
				default:
					switch (num)
					{
					case 197:
					case 199:
					case 200:
						break;
					case 198:
						goto IL_220;
					default:
						switch (num)
						{
						case 211:
						case 221:
						case 222:
						case 223:
						case 224:
						case 225:
						case 227:
						case 228:
						case 230:
						case 231:
						case 232:
						case 233:
						case 234:
						case 235:
							break;
						case 212:
						case 213:
						case 214:
						case 215:
						case 216:
						case 217:
						case 218:
						case 219:
						case 220:
						case 226:
						case 229:
							goto IL_220;
						default:
							goto IL_220;
						}
						break;
					}
					break;
				}
			}
			return this.booleanExpressionPrimary(expressionFlags);
			IL_220:
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x060013FB RID: 5115 RVA: 0x000710BC File Offset: 0x0006F2BC
		public BooleanExpression booleanExpressionPrimary(ExpressionFlags expressionFlags)
		{
			IToken token = null;
			bool vNotDefined = false;
			BooleanComparisonType vType = BooleanComparisonType.Equals;
			int num = this.LA(1);
			if (num <= 62)
			{
				if (num != 31)
				{
					if (num != 62)
					{
						goto IL_71;
					}
					return this.existsPredicate(expressionFlags);
				}
			}
			else if (num != 69)
			{
				if (num == 157)
				{
					return this.tsEqualCall();
				}
				if (num != 160)
				{
					goto IL_71;
				}
				return this.updateCall();
			}
			return this.fulltextPredicate();
			IL_71:
			BooleanExpression booleanExpression;
			if (this.LA(1) == 191 && TSql80ParserInternal.tokenSet_51_.member(this.LA(2)) && base.IsNextRuleBooleanParenthesis())
			{
				booleanExpression = this.booleanExpressionParenthesis();
			}
			else
			{
				if (TSql80ParserInternal.tokenSet_16_.member(this.LA(1)) && TSql80ParserInternal.tokenSet_78_.member(this.LA(2)))
				{
					ScalarExpression vExpressionFirst = this.expressionWithFlags(expressionFlags);
					int num2 = this.LA(1);
					if (num2 > 94)
					{
						if (num2 > 188)
						{
							if (num2 != 196)
							{
								switch (num2)
								{
								case 205:
								case 206:
								case 208:
									goto IL_16B;
								case 207:
									break;
								default:
									goto IL_43E;
								}
							}
							return this.joinPredicate(vExpressionFirst, vType, expressionFlags);
						}
						if (num2 == 99)
						{
							goto IL_374;
						}
						if (num2 != 188)
						{
							goto IL_43E;
						}
						IL_16B:
						vType = this.comparisonOperator();
						int num3 = this.LA(1);
						if (num3 <= 93)
						{
							if (num3 <= 25)
							{
								if (num3 <= 8)
								{
									if (num3 != 5 && num3 != 8)
									{
										goto IL_344;
									}
									goto IL_334;
								}
								else if (num3 != 20 && num3 != 25)
								{
									goto IL_344;
								}
							}
							else if (num3 <= 41)
							{
								if (num3 != 34)
								{
									switch (num3)
									{
									case 40:
									case 41:
										break;
									default:
										goto IL_344;
									}
								}
							}
							else if (num3 != 81 && num3 != 93)
							{
								goto IL_344;
							}
						}
						else if (num3 <= 141)
						{
							if (num3 <= 133)
							{
								switch (num3)
								{
								case 100:
								case 101:
									break;
								default:
									if (num3 != 133)
									{
										goto IL_344;
									}
									break;
								}
							}
							else if (num3 != 136 && num3 != 141)
							{
								goto IL_344;
							}
						}
						else if (num3 <= 163)
						{
							switch (num3)
							{
							case 145:
								goto IL_334;
							case 146:
								goto IL_344;
							case 147:
								break;
							default:
								if (num3 != 163)
								{
									goto IL_344;
								}
								break;
							}
						}
						else
						{
							switch (num3)
							{
							case 191:
							case 193:
								break;
							case 192:
								goto IL_344;
							default:
								switch (num3)
								{
								case 197:
								case 199:
								case 200:
									break;
								case 198:
									goto IL_344;
								default:
									switch (num3)
									{
									case 211:
									case 221:
									case 222:
									case 223:
									case 224:
									case 225:
									case 227:
									case 228:
									case 230:
									case 231:
									case 232:
									case 233:
									case 234:
									case 235:
										break;
									case 212:
									case 213:
									case 214:
									case 215:
									case 216:
									case 217:
									case 218:
									case 219:
									case 220:
									case 226:
									case 229:
										goto IL_344;
									default:
										goto IL_344;
									}
									break;
								}
								break;
							}
						}
						return this.comparisonPredicate(vExpressionFirst, vType, expressionFlags);
						IL_334:
						return this.subqueryComparisonPredicate(vExpressionFirst, vType, expressionFlags);
						IL_344:
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
					if (num2 <= 83)
					{
						if (num2 != 14 && num2 != 83)
						{
							goto IL_43E;
						}
					}
					else
					{
						if (num2 == 89)
						{
							return this.isPredicate(vExpressionFirst);
						}
						if (num2 != 94)
						{
							goto IL_43E;
						}
					}
					IL_374:
					int num4 = this.LA(1);
					if (num4 <= 83)
					{
						if (num4 == 14 || num4 == 83)
						{
							goto IL_3D1;
						}
					}
					else
					{
						if (num4 == 94)
						{
							goto IL_3D1;
						}
						if (num4 == 99)
						{
							token = this.LT(1);
							this.match(99);
							if (this.inputState.guessing == 0)
							{
								vNotDefined = true;
								goto IL_3D1;
							}
							goto IL_3D1;
						}
					}
					throw new NoViableAltException(this.LT(1), this.getFilename());
					IL_3D1:
					int num5 = this.LA(1);
					if (num5 != 14)
					{
						if (num5 != 83)
						{
							if (num5 != 94)
							{
								throw new NoViableAltException(this.LT(1), this.getFilename());
							}
							booleanExpression = this.likePredicate(vExpressionFirst, vNotDefined, expressionFlags);
						}
						else
						{
							booleanExpression = this.inPredicate(vExpressionFirst, vNotDefined, expressionFlags);
						}
					}
					else
					{
						booleanExpression = this.betweenPredicate(vExpressionFirst, vNotDefined, expressionFlags);
					}
					if (this.inputState.guessing == 0 && token != null)
					{
						TSql80ParserBaseInternal.UpdateTokenInfo(booleanExpression, token);
						return booleanExpression;
					}
					return booleanExpression;
					IL_43E:
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			return booleanExpression;
		}

		// Token: 0x060013FC RID: 5116 RVA: 0x00071530 File Offset: 0x0006F730
		public BooleanParenthesisExpression booleanExpressionParenthesis()
		{
			BooleanParenthesisExpression booleanParenthesisExpression = base.FragmentFactory.CreateFragment<BooleanParenthesisExpression>();
			IToken token = this.LT(1);
			this.match(191);
			BooleanExpression expression = this.booleanExpression();
			IToken token2 = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(booleanParenthesisExpression, token);
				booleanParenthesisExpression.Expression = expression;
				TSql80ParserBaseInternal.UpdateTokenInfo(booleanParenthesisExpression, token2);
			}
			return booleanParenthesisExpression;
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x000715A0 File Offset: 0x0006F7A0
		public BooleanComparisonType comparisonOperator()
		{
			BooleanComparisonType result = BooleanComparisonType.Equals;
			int num = this.LA(1);
			if (num != 188)
			{
				switch (num)
				{
				case 205:
				{
					this.match(205);
					if (this.inputState.guessing == 0)
					{
						result = BooleanComparisonType.LessThan;
					}
					int num2 = this.LA(1);
					if (num2 <= 93)
					{
						if (num2 <= 25)
						{
							if (num2 <= 8)
							{
								if (num2 == 5 || num2 == 8)
								{
									return result;
								}
							}
							else if (num2 == 20 || num2 == 25)
							{
								return result;
							}
						}
						else if (num2 <= 41)
						{
							if (num2 == 34)
							{
								return result;
							}
							switch (num2)
							{
							case 40:
							case 41:
								return result;
							}
						}
						else if (num2 == 81 || num2 == 93)
						{
							return result;
						}
					}
					else if (num2 <= 141)
					{
						if (num2 <= 133)
						{
							switch (num2)
							{
							case 100:
							case 101:
								return result;
							default:
								if (num2 == 133)
								{
									return result;
								}
								break;
							}
						}
						else if (num2 == 136 || num2 == 141)
						{
							return result;
						}
					}
					else if (num2 <= 163)
					{
						switch (num2)
						{
						case 145:
						case 147:
							return result;
						case 146:
							break;
						default:
							if (num2 == 163)
							{
								return result;
							}
							break;
						}
					}
					else
					{
						switch (num2)
						{
						case 191:
						case 193:
							return result;
						case 192:
							break;
						default:
							switch (num2)
							{
							case 197:
							case 199:
							case 200:
								return result;
							case 198:
								break;
							default:
								switch (num2)
								{
								case 206:
									this.match(206);
									if (this.inputState.guessing == 0)
									{
										return BooleanComparisonType.LessThanOrEqualTo;
									}
									return result;
								case 208:
									this.match(208);
									if (this.inputState.guessing == 0)
									{
										return BooleanComparisonType.NotEqualToBrackets;
									}
									return result;
								case 211:
								case 221:
								case 222:
								case 223:
								case 224:
								case 225:
								case 227:
								case 228:
								case 230:
								case 231:
								case 232:
								case 233:
								case 234:
								case 235:
									return result;
								}
								break;
							}
							break;
						}
					}
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				case 206:
					this.match(206);
					if (this.inputState.guessing == 0)
					{
						return BooleanComparisonType.Equals;
					}
					return result;
				case 208:
				{
					this.match(208);
					if (this.inputState.guessing == 0)
					{
						result = BooleanComparisonType.GreaterThan;
					}
					int num3 = this.LA(1);
					if (num3 <= 101)
					{
						if (num3 <= 25)
						{
							if (num3 <= 8)
							{
								if (num3 == 5 || num3 == 8)
								{
									return result;
								}
							}
							else if (num3 == 20 || num3 == 25)
							{
								return result;
							}
						}
						else if (num3 <= 41)
						{
							if (num3 == 34)
							{
								return result;
							}
							switch (num3)
							{
							case 40:
							case 41:
								return result;
							}
						}
						else
						{
							if (num3 == 81 || num3 == 93)
							{
								return result;
							}
							switch (num3)
							{
							case 100:
							case 101:
								return result;
							}
						}
					}
					else if (num3 <= 147)
					{
						if (num3 <= 136)
						{
							if (num3 == 133 || num3 == 136)
							{
								return result;
							}
						}
						else
						{
							if (num3 == 141)
							{
								return result;
							}
							switch (num3)
							{
							case 145:
							case 147:
								return result;
							}
						}
					}
					else if (num3 <= 193)
					{
						if (num3 == 163)
						{
							return result;
						}
						switch (num3)
						{
						case 191:
						case 193:
							return result;
						}
					}
					else
					{
						switch (num3)
						{
						case 197:
						case 199:
						case 200:
							return result;
						case 198:
							break;
						default:
							if (num3 != 206)
							{
								switch (num3)
								{
								case 211:
								case 221:
								case 222:
								case 223:
								case 224:
								case 225:
								case 227:
								case 228:
								case 230:
								case 231:
								case 232:
								case 233:
								case 234:
								case 235:
									return result;
								}
							}
							else
							{
								this.match(206);
								if (this.inputState.guessing == 0)
								{
									return BooleanComparisonType.GreaterThanOrEqualTo;
								}
								return result;
							}
							break;
						}
					}
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				}
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			this.match(188);
			switch (this.LA(1))
			{
			case 205:
				this.match(205);
				if (this.inputState.guessing == 0)
				{
					return BooleanComparisonType.NotLessThan;
				}
				return result;
			case 206:
				this.match(206);
				if (this.inputState.guessing == 0)
				{
					return BooleanComparisonType.NotEqualToExclamation;
				}
				return result;
			case 208:
				this.match(208);
				if (this.inputState.guessing == 0)
				{
					return BooleanComparisonType.NotGreaterThan;
				}
				return result;
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x00071AC0 File Offset: 0x0006FCC0
		public BooleanComparisonExpression comparisonPredicate(ScalarExpression vExpressionFirst, BooleanComparisonType vType, ExpressionFlags expressionFlags)
		{
			BooleanComparisonExpression booleanComparisonExpression = base.FragmentFactory.CreateFragment<BooleanComparisonExpression>();
			ScalarExpression secondExpression = this.expressionWithFlags(expressionFlags);
			if (this.inputState.guessing == 0)
			{
				booleanComparisonExpression.ComparisonType = vType;
				booleanComparisonExpression.FirstExpression = vExpressionFirst;
				booleanComparisonExpression.SecondExpression = secondExpression;
			}
			return booleanComparisonExpression;
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x00071B04 File Offset: 0x0006FD04
		public SubqueryComparisonPredicate subqueryComparisonPredicate(ScalarExpression vExpressionFirst, BooleanComparisonType vType, ExpressionFlags expressionFlags)
		{
			SubqueryComparisonPredicate subqueryComparisonPredicate = base.FragmentFactory.CreateFragment<SubqueryComparisonPredicate>();
			SubqueryComparisonPredicateType subqueryComparisonPredicateType = this.subqueryComparisonPredicateType();
			ScalarSubquery subquery = this.subquery(expressionFlags);
			if (this.inputState.guessing == 0)
			{
				subqueryComparisonPredicate.ComparisonType = vType;
				subqueryComparisonPredicate.Expression = vExpressionFirst;
				subqueryComparisonPredicate.SubqueryComparisonPredicateType = subqueryComparisonPredicateType;
				subqueryComparisonPredicate.Subquery = subquery;
			}
			return subqueryComparisonPredicate;
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x00071B58 File Offset: 0x0006FD58
		public BooleanComparisonExpression joinPredicate(ScalarExpression vExpressionFirst, BooleanComparisonType vType, ExpressionFlags expressionFlags)
		{
			BooleanComparisonExpression booleanComparisonExpression = base.FragmentFactory.CreateFragment<BooleanComparisonExpression>();
			vType = this.joinOperator();
			ScalarExpression secondExpression = this.expression();
			if (this.inputState.guessing == 0)
			{
				booleanComparisonExpression.ComparisonType = vType;
				booleanComparisonExpression.FirstExpression = vExpressionFirst;
				booleanComparisonExpression.SecondExpression = secondExpression;
			}
			return booleanComparisonExpression;
		}

		// Token: 0x06001401 RID: 5121 RVA: 0x00071BA4 File Offset: 0x0006FDA4
		public BooleanIsNullExpression isPredicate(ScalarExpression vExpressionFirst)
		{
			BooleanIsNullExpression booleanIsNullExpression = base.FragmentFactory.CreateFragment<BooleanIsNullExpression>();
			this.match(89);
			bool flag = this.nullNotNull(booleanIsNullExpression);
			if (this.inputState.guessing == 0)
			{
				booleanIsNullExpression.Expression = vExpressionFirst;
				booleanIsNullExpression.IsNot = !flag;
			}
			return booleanIsNullExpression;
		}

		// Token: 0x06001402 RID: 5122 RVA: 0x00071BEC File Offset: 0x0006FDEC
		public InPredicate inPredicate(ScalarExpression vExpressionFirst, bool vNotDefined, ExpressionFlags expressionFlags)
		{
			InPredicate inPredicate = base.FragmentFactory.CreateFragment<InPredicate>();
			IToken token = this.LT(1);
			this.match(83);
			if (this.inputState.guessing == 0)
			{
				if (vNotDefined)
				{
					inPredicate.NotDefined = true;
				}
				TSql80ParserBaseInternal.UpdateTokenInfo(inPredicate, token);
				inPredicate.Expression = vExpressionFirst;
			}
			if (this.LA(1) == 191 && (this.LA(2) == 140 || this.LA(2) == 191) && base.IsNextRuleSelectParenthesis())
			{
				ScalarSubquery subquery = this.subquery(expressionFlags);
				if (this.inputState.guessing == 0)
				{
					inPredicate.Subquery = subquery;
				}
			}
			else
			{
				if (this.LA(1) != 191 || !TSql80ParserInternal.tokenSet_16_.member(this.LA(2)))
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				this.match(191);
				this.expressionList(inPredicate, inPredicate.Values);
				IToken token2 = this.LT(1);
				this.match(192);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(inPredicate, token2);
				}
			}
			return inPredicate;
		}

		// Token: 0x06001403 RID: 5123 RVA: 0x00071D04 File Offset: 0x0006FF04
		public BooleanTernaryExpression betweenPredicate(ScalarExpression vExpressionFirst, bool vNotDefined, ExpressionFlags expressionFlags)
		{
			BooleanTernaryExpression booleanTernaryExpression = base.FragmentFactory.CreateFragment<BooleanTernaryExpression>();
			IToken token = this.LT(1);
			this.match(14);
			ScalarExpression scalarExpression = this.expressionWithFlags(expressionFlags);
			if (this.inputState.guessing == 0)
			{
				booleanTernaryExpression.SecondExpression = scalarExpression;
			}
			this.match(7);
			scalarExpression = this.expressionWithFlags(expressionFlags);
			if (this.inputState.guessing == 0)
			{
				booleanTernaryExpression.ThirdExpression = scalarExpression;
				if (vNotDefined)
				{
					booleanTernaryExpression.TernaryExpressionType = BooleanTernaryExpressionType.NotBetween;
				}
				else
				{
					booleanTernaryExpression.TernaryExpressionType = BooleanTernaryExpressionType.Between;
				}
				TSql80ParserBaseInternal.UpdateTokenInfo(booleanTernaryExpression, token);
				booleanTernaryExpression.FirstExpression = vExpressionFirst;
			}
			return booleanTernaryExpression;
		}

		// Token: 0x06001404 RID: 5124 RVA: 0x00071D90 File Offset: 0x0006FF90
		public LikePredicate likePredicate(ScalarExpression vExpressionFirst, bool vNotDefined, ExpressionFlags expressionFlags)
		{
			LikePredicate likePredicate = base.FragmentFactory.CreateFragment<LikePredicate>();
			IToken token = this.LT(1);
			this.match(94);
			if (this.inputState.guessing == 0)
			{
				if (vNotDefined)
				{
					likePredicate.NotDefined = true;
				}
				TSql80ParserBaseInternal.UpdateTokenInfo(likePredicate, token);
				likePredicate.FirstExpression = vExpressionFirst;
			}
			ScalarExpression secondExpression = this.expressionWithFlags(expressionFlags);
			if (this.inputState.guessing == 0)
			{
				likePredicate.SecondExpression = secondExpression;
			}
			int num = this.LA(1);
			if (num <= 95)
			{
				if (num <= 17)
				{
					if (num == 1)
					{
						return likePredicate;
					}
					switch (num)
					{
					case 6:
					case 7:
						return likePredicate;
					default:
						switch (num)
						{
						case 12:
						case 13:
						case 15:
						case 17:
							return likePredicate;
						}
						break;
					}
				}
				else
				{
					switch (num)
					{
					case 22:
					case 23:
						return likePredicate;
					default:
						switch (num)
						{
						case 28:
						case 29:
						case 33:
						case 35:
						case 36:
							return likePredicate;
						case 30:
						case 31:
						case 32:
						case 34:
							break;
						default:
							switch (num)
							{
							case 44:
							case 45:
							case 46:
							case 48:
							case 49:
							case 54:
							case 55:
							case 56:
							case 59:
							case 60:
							case 61:
							case 64:
							case 67:
							case 72:
							case 74:
							case 75:
							case 76:
							case 77:
							case 82:
							case 85:
							case 86:
							case 87:
							case 90:
							case 92:
							case 93:
							case 95:
								return likePredicate;
							case 58:
								this.escapeExpression(likePredicate, expressionFlags);
								return likePredicate;
							}
							break;
						}
						break;
					}
				}
			}
			else if (num <= 150)
			{
				switch (num)
				{
				case 105:
				case 106:
				case 111:
				case 112:
				case 113:
				case 114:
					return likePredicate;
				case 107:
				case 108:
				case 109:
				case 110:
					break;
				default:
					switch (num)
					{
					case 119:
					case 123:
					case 125:
					case 126:
					case 129:
					case 131:
					case 132:
					case 133:
					case 134:
					case 138:
					case 140:
					case 142:
					case 143:
					case 144:
						return likePredicate;
					case 120:
					case 121:
					case 122:
					case 124:
					case 127:
					case 128:
					case 130:
					case 135:
					case 136:
					case 137:
					case 139:
					case 141:
						break;
					default:
						if (num == 150)
						{
							return likePredicate;
						}
						break;
					}
					break;
				}
			}
			else if (num <= 198)
			{
				switch (num)
				{
				case 156:
				case 158:
				case 160:
				case 161:
				case 162:
				case 167:
				case 169:
				case 170:
				case 171:
				case 172:
				case 173:
				case 176:
				case 180:
				case 181:
					return likePredicate;
				case 157:
				case 159:
				case 163:
				case 164:
				case 165:
				case 166:
				case 168:
				case 174:
				case 175:
				case 177:
				case 178:
				case 179:
					break;
				default:
					switch (num)
					{
					case 191:
					case 192:
					case 194:
					case 198:
						return likePredicate;
					case 193:
					{
						this.match(193);
						if (this.inputState.guessing == 0)
						{
							likePredicate.OdbcEscape = true;
						}
						this.escapeExpression(likePredicate, expressionFlags);
						IToken token2 = this.LT(1);
						this.match(194);
						if (this.inputState.guessing == 0)
						{
							TSql80ParserBaseInternal.UpdateTokenInfo(likePredicate, token2);
							return likePredicate;
						}
						return likePredicate;
					}
					}
					break;
				}
			}
			else
			{
				if (num == 204)
				{
					return likePredicate;
				}
				switch (num)
				{
				case 219:
				case 220:
					return likePredicate;
				}
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x06001405 RID: 5125 RVA: 0x00072178 File Offset: 0x00070378
		public FullTextPredicate fulltextPredicate()
		{
			FullTextPredicate fullTextPredicate = base.FragmentFactory.CreateFragment<FullTextPredicate>();
			int num = this.LA(1);
			if (num != 31)
			{
				if (num != 69)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				IToken token = this.LT(1);
				this.match(69);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(fullTextPredicate, token);
					fullTextPredicate.FullTextFunctionType = FullTextFunctionType.FreeText;
				}
			}
			else
			{
				IToken token2 = this.LT(1);
				this.match(31);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(fullTextPredicate, token2);
					fullTextPredicate.FullTextFunctionType = FullTextFunctionType.Contains;
				}
			}
			this.match(191);
			int num2 = this.LA(1);
			ColumnReferenceExpression item;
			if (num2 <= 191)
			{
				if (num2 != 81 && num2 != 136)
				{
					if (num2 != 191)
					{
						goto IL_290;
					}
					this.match(191);
					bool flag = false;
					if (TSql80ParserInternal.tokenSet_35_.member(this.LA(1)) && TSql80ParserInternal.tokenSet_79_.member(this.LA(2)))
					{
						int pos = this.mark();
						flag = true;
						this.inputState.guessing++;
						try
						{
							this.starColumn();
						}
						catch (RecognitionException)
						{
							flag = false;
						}
						this.rewind(pos);
						this.inputState.guessing--;
					}
					if (flag)
					{
						item = this.starColumn();
						if (this.inputState.guessing == 0)
						{
							TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ColumnReferenceExpression>(fullTextPredicate, fullTextPredicate.Columns, item);
						}
					}
					else
					{
						if (!TSql80ParserInternal.tokenSet_80_.member(this.LA(1)) || !TSql80ParserInternal.tokenSet_81_.member(this.LA(2)))
						{
							throw new NoViableAltException(this.LT(1), this.getFilename());
						}
						item = this.column();
						if (this.inputState.guessing == 0)
						{
							TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ColumnReferenceExpression>(fullTextPredicate, fullTextPredicate.Columns, item);
						}
						while (this.LA(1) == 198)
						{
							this.match(198);
							item = this.column();
							if (this.inputState.guessing == 0)
							{
								TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ColumnReferenceExpression>(fullTextPredicate, fullTextPredicate.Columns, item);
							}
						}
					}
					this.match(192);
					goto IL_2A3;
				}
			}
			else if (num2 <= 200)
			{
				if (num2 != 195 && num2 != 200)
				{
					goto IL_290;
				}
			}
			else if (num2 != 227)
			{
				switch (num2)
				{
				case 232:
				case 233:
					break;
				default:
					goto IL_290;
				}
			}
			item = this.fulltextColumn();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ColumnReferenceExpression>(fullTextPredicate, fullTextPredicate.Columns, item);
				goto IL_2A3;
			}
			goto IL_2A3;
			IL_290:
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_2A3:
			this.match(198);
			ValueExpression value = this.stringOrVariable();
			if (this.inputState.guessing == 0)
			{
				fullTextPredicate.Value = value;
			}
			int num3 = this.LA(1);
			if (num3 != 192)
			{
				if (num3 != 198)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				this.match(198);
				ValueExpression languageTerm = this.languageExpression();
				if (this.inputState.guessing == 0)
				{
					fullTextPredicate.LanguageTerm = languageTerm;
				}
			}
			IToken token3 = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(fullTextPredicate, token3);
			}
			return fullTextPredicate;
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x000724E0 File Offset: 0x000706E0
		public ExistsPredicate existsPredicate(ExpressionFlags expressionFlags)
		{
			ExistsPredicate existsPredicate = base.FragmentFactory.CreateFragment<ExistsPredicate>();
			this.match(62);
			ScalarSubquery subquery = this.subquery(expressionFlags);
			if (this.inputState.guessing == 0)
			{
				existsPredicate.Subquery = subquery;
			}
			return existsPredicate;
		}

		// Token: 0x06001407 RID: 5127 RVA: 0x00072520 File Offset: 0x00070720
		public TSEqualCall tsEqualCall()
		{
			TSEqualCall tsequalCall = base.FragmentFactory.CreateFragment<TSEqualCall>();
			IToken token = this.LT(1);
			this.match(157);
			this.match(191);
			ScalarExpression scalarExpression = this.expression();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(tsequalCall, token);
				tsequalCall.FirstExpression = scalarExpression;
			}
			this.match(198);
			scalarExpression = this.expression();
			IToken token2 = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				tsequalCall.SecondExpression = scalarExpression;
				TSql80ParserBaseInternal.UpdateTokenInfo(tsequalCall, token2);
			}
			return tsequalCall;
		}

		// Token: 0x06001408 RID: 5128 RVA: 0x000725C0 File Offset: 0x000707C0
		public UpdateCall updateCall()
		{
			UpdateCall updateCall = base.FragmentFactory.CreateFragment<UpdateCall>();
			IToken token = this.LT(1);
			this.match(160);
			this.match(191);
			Identifier identifier = this.identifier();
			IToken token2 = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(updateCall, token);
				updateCall.Identifier = identifier;
				TSql80ParserBaseInternal.UpdateTokenInfo(updateCall, token2);
			}
			return updateCall;
		}

		// Token: 0x06001409 RID: 5129 RVA: 0x00072638 File Offset: 0x00070838
		public ColumnReferenceExpression fulltextColumn()
		{
			bool flag = false;
			if (TSql80ParserInternal.tokenSet_35_.member(this.LA(1)) && TSql80ParserInternal.tokenSet_82_.member(this.LA(2)))
			{
				int pos = this.mark();
				flag = true;
				this.inputState.guessing++;
				try
				{
					this.starColumn();
				}
				catch (RecognitionException)
				{
					flag = false;
				}
				this.rewind(pos);
				this.inputState.guessing--;
			}
			ColumnReferenceExpression result;
			if (flag)
			{
				result = this.starColumn();
			}
			else
			{
				if (!TSql80ParserInternal.tokenSet_80_.member(this.LA(1)) || !TSql80ParserInternal.tokenSet_82_.member(this.LA(2)))
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				result = this.column();
			}
			return result;
		}

		// Token: 0x0600140A RID: 5130 RVA: 0x00072714 File Offset: 0x00070914
		public ColumnReferenceExpression starColumn()
		{
			ColumnReferenceExpression columnReferenceExpression = base.FragmentFactory.CreateFragment<ColumnReferenceExpression>();
			columnReferenceExpression.ColumnType = ColumnType.Wildcard;
			int num = this.LA(1);
			if (num != 195)
			{
				if (num != 200)
				{
					switch (num)
					{
					case 232:
					case 233:
						break;
					default:
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
				}
				MultiPartIdentifier multiPartIdentifier = this.multiPartIdentifier(-1);
				if (this.inputState.guessing == 0)
				{
					columnReferenceExpression.MultiPartIdentifier = multiPartIdentifier;
				}
				this.match(200);
				IToken token = this.LT(1);
				this.match(195);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(columnReferenceExpression, token);
					columnReferenceExpression.ColumnType = ColumnType.Wildcard;
				}
			}
			else
			{
				IToken token2 = this.LT(1);
				this.match(195);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(columnReferenceExpression, token2);
					columnReferenceExpression.ColumnType = ColumnType.Wildcard;
				}
			}
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.CheckSpecialColumn(columnReferenceExpression);
				TSql80ParserBaseInternal.CheckTableNameExistsForColumn(columnReferenceExpression, false);
			}
			return columnReferenceExpression;
		}

		// Token: 0x0600140B RID: 5131 RVA: 0x00072824 File Offset: 0x00070A24
		public BooleanComparisonType joinOperator()
		{
			BooleanComparisonType result = BooleanComparisonType.LeftOuterJoin;
			int num = this.LA(1);
			if (num != 196)
			{
				if (num != 207)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				this.match(207);
				if (this.inputState.guessing == 0)
				{
					result = BooleanComparisonType.RightOuterJoin;
				}
			}
			else
			{
				this.match(196);
				if (this.inputState.guessing == 0)
				{
					result = BooleanComparisonType.LeftOuterJoin;
				}
			}
			return result;
		}

		// Token: 0x0600140C RID: 5132 RVA: 0x0007289C File Offset: 0x00070A9C
		public SubqueryComparisonPredicateType subqueryComparisonPredicateType()
		{
			SubqueryComparisonPredicateType result = SubqueryComparisonPredicateType.None;
			int num = this.LA(1);
			if (num != 5)
			{
				if (num != 8)
				{
					if (num != 145)
					{
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
					this.match(145);
					if (this.inputState.guessing == 0)
					{
						result = SubqueryComparisonPredicateType.Any;
					}
				}
				else
				{
					this.match(8);
					if (this.inputState.guessing == 0)
					{
						result = SubqueryComparisonPredicateType.Any;
					}
				}
			}
			else
			{
				this.match(5);
				if (this.inputState.guessing == 0)
				{
					result = SubqueryComparisonPredicateType.All;
				}
			}
			return result;
		}

		// Token: 0x0600140D RID: 5133 RVA: 0x00072928 File Offset: 0x00070B28
		public void escapeExpression(LikePredicate vParent, ExpressionFlags expressionFlags)
		{
			this.match(58);
			ScalarExpression escapeExpression = this.expressionWithFlags(expressionFlags);
			if (this.inputState.guessing == 0)
			{
				vParent.EscapeExpression = escapeExpression;
			}
		}

		// Token: 0x0600140E RID: 5134 RVA: 0x0007295C File Offset: 0x00070B5C
		public ScalarExpression expressionBinaryPri2(ExpressionFlags expressionFlags)
		{
			ScalarExpression result = null;
			result = this.expressionBinaryPri1(expressionFlags);
			for (;;)
			{
				int num = this.LA(1);
				if (num != 190)
				{
					switch (num)
					{
					case 197:
					{
						this.match(197);
						ScalarExpression expression = this.expressionBinaryPri1(expressionFlags);
						if (this.inputState.guessing == 0)
						{
							base.AddBinaryExpression(ref result, expression, BinaryExpressionType.Add);
						}
						break;
					}
					case 198:
						return result;
					case 199:
					{
						this.match(199);
						ScalarExpression expression = this.expressionBinaryPri1(expressionFlags);
						if (this.inputState.guessing == 0)
						{
							base.AddBinaryExpression(ref result, expression, BinaryExpressionType.Subtract);
						}
						break;
					}
					default:
						switch (num)
						{
						case 209:
						{
							this.match(209);
							ScalarExpression expression = this.expressionBinaryPri1(expressionFlags);
							if (this.inputState.guessing == 0)
							{
								base.AddBinaryExpression(ref result, expression, BinaryExpressionType.BitwiseXor);
								continue;
							}
							continue;
						}
						case 210:
						{
							this.match(210);
							ScalarExpression expression = this.expressionBinaryPri1(expressionFlags);
							if (this.inputState.guessing == 0)
							{
								base.AddBinaryExpression(ref result, expression, BinaryExpressionType.BitwiseOr);
								continue;
							}
							continue;
						}
						}
						return result;
					}
				}
				else
				{
					this.match(190);
					ScalarExpression expression = this.expressionBinaryPri1(expressionFlags);
					if (this.inputState.guessing == 0)
					{
						base.AddBinaryExpression(ref result, expression, BinaryExpressionType.BitwiseAnd);
					}
				}
			}
			return result;
		}

		// Token: 0x0600140F RID: 5135 RVA: 0x00072AAC File Offset: 0x00070CAC
		public ScalarExpression expressionBinaryPri1(ExpressionFlags expressionFlags)
		{
			ScalarExpression result = null;
			result = this.expressionUnary(expressionFlags);
			for (;;)
			{
				int num = this.LA(1);
				if (num != 189)
				{
					if (num != 195)
					{
						if (num != 201)
						{
							break;
						}
						this.match(201);
						ScalarExpression expression = this.expressionUnary(expressionFlags);
						if (this.inputState.guessing == 0)
						{
							base.AddBinaryExpression(ref result, expression, BinaryExpressionType.Divide);
						}
					}
					else
					{
						this.match(195);
						ScalarExpression expression = this.expressionUnary(expressionFlags);
						if (this.inputState.guessing == 0)
						{
							base.AddBinaryExpression(ref result, expression, BinaryExpressionType.Multiply);
						}
					}
				}
				else
				{
					this.match(189);
					ScalarExpression expression = this.expressionUnary(expressionFlags);
					if (this.inputState.guessing == 0)
					{
						base.AddBinaryExpression(ref result, expression, BinaryExpressionType.Modulo);
					}
				}
			}
			return result;
		}

		// Token: 0x06001410 RID: 5136 RVA: 0x00072B74 File Offset: 0x00070D74
		public ScalarExpression expressionUnary(ExpressionFlags expressionFlags)
		{
			ScalarExpression result = null;
			UnaryExpression unaryExpression = null;
			int num = this.LA(1);
			if (num <= 101)
			{
				if (num <= 34)
				{
					if (num != 20 && num != 25 && num != 34)
					{
						goto IL_2D2;
					}
				}
				else if (num <= 81)
				{
					switch (num)
					{
					case 40:
					case 41:
						break;
					default:
						if (num != 81)
						{
							goto IL_2D2;
						}
						break;
					}
				}
				else if (num != 93)
				{
					switch (num)
					{
					case 100:
					case 101:
						break;
					default:
						goto IL_2D2;
					}
				}
			}
			else if (num <= 147)
			{
				if (num <= 136)
				{
					if (num != 133 && num != 136)
					{
						goto IL_2D2;
					}
				}
				else if (num != 141 && num != 147)
				{
					goto IL_2D2;
				}
			}
			else if (num <= 193)
			{
				if (num != 163)
				{
					switch (num)
					{
					case 191:
					case 193:
						break;
					case 192:
						goto IL_2D2;
					default:
						goto IL_2D2;
					}
				}
			}
			else
			{
				switch (num)
				{
				case 197:
				case 199:
					break;
				case 198:
					goto IL_2D2;
				case 200:
					goto IL_2C8;
				default:
					switch (num)
					{
					case 211:
						break;
					case 212:
					case 213:
					case 214:
					case 215:
					case 216:
					case 217:
					case 218:
					case 219:
					case 220:
					case 226:
					case 229:
						goto IL_2D2;
					case 221:
					case 222:
					case 223:
					case 224:
					case 225:
					case 227:
					case 228:
					case 230:
					case 231:
					case 232:
					case 233:
					case 234:
					case 235:
						goto IL_2C8;
					default:
						goto IL_2D2;
					}
					break;
				}
				int num2 = this.LA(1);
				switch (num2)
				{
				case 197:
				{
					IToken token = this.LT(1);
					this.match(197);
					if (this.inputState.guessing == 0)
					{
						unaryExpression = base.FragmentFactory.CreateFragment<UnaryExpression>();
						TSql80ParserBaseInternal.UpdateTokenInfo(unaryExpression, token);
						unaryExpression.UnaryExpressionType = UnaryExpressionType.Positive;
						goto IL_2A4;
					}
					goto IL_2A4;
				}
				case 198:
					break;
				case 199:
				{
					IToken token2 = this.LT(1);
					this.match(199);
					if (this.inputState.guessing == 0)
					{
						unaryExpression = base.FragmentFactory.CreateFragment<UnaryExpression>();
						TSql80ParserBaseInternal.UpdateTokenInfo(unaryExpression, token2);
						unaryExpression.UnaryExpressionType = UnaryExpressionType.Negative;
						goto IL_2A4;
					}
					goto IL_2A4;
				}
				default:
					if (num2 == 211)
					{
						IToken token3 = this.LT(1);
						this.match(211);
						if (this.inputState.guessing == 0)
						{
							unaryExpression = base.FragmentFactory.CreateFragment<UnaryExpression>();
							TSql80ParserBaseInternal.UpdateTokenInfo(unaryExpression, token3);
							unaryExpression.UnaryExpressionType = UnaryExpressionType.BitwiseNot;
							goto IL_2A4;
						}
						goto IL_2A4;
					}
					break;
				}
				throw new NoViableAltException(this.LT(1), this.getFilename());
				IL_2A4:
				ScalarExpression expression = this.expressionUnary(expressionFlags);
				if (this.inputState.guessing == 0)
				{
					result = unaryExpression;
					unaryExpression.Expression = expression;
					return result;
				}
				return result;
			}
			IL_2C8:
			return this.expressionPrimary(expressionFlags);
			IL_2D2:
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x06001411 RID: 5137 RVA: 0x00072E68 File Offset: 0x00071068
		public PrimaryExpression expressionPrimary(ExpressionFlags expressionFlags)
		{
			PrimaryExpression primaryExpression = null;
			int num = this.LA(1);
			if (num <= 101)
			{
				if (num <= 34)
				{
					if (num == 20)
					{
						primaryExpression = this.caseExpression(expressionFlags);
						goto IL_2FF;
					}
					if (num == 25)
					{
						primaryExpression = this.coalesceExpression(expressionFlags);
						goto IL_2FF;
					}
					if (num != 34)
					{
						goto IL_FD;
					}
					primaryExpression = this.convertCall();
					goto IL_2FF;
				}
				else
				{
					switch (num)
					{
					case 40:
					case 41:
						break;
					default:
						if (num == 93)
						{
							primaryExpression = this.leftFunctionCall();
							goto IL_2FF;
						}
						if (num != 101)
						{
							goto IL_FD;
						}
						primaryExpression = this.nullIfExpression(expressionFlags);
						goto IL_2FF;
					}
				}
			}
			else if (num <= 147)
			{
				if (num == 133)
				{
					primaryExpression = this.rightFunctionCall();
					goto IL_2FF;
				}
				if (num != 141 && num != 147)
				{
					goto IL_FD;
				}
			}
			else if (num != 163)
			{
				if (num == 191)
				{
					primaryExpression = this.paranthesisDisambiguatorForExpressions(expressionFlags);
					goto IL_2FF;
				}
				if (num == 235)
				{
					this.odbcInitiator();
					goto IL_2FF;
				}
				goto IL_FD;
			}
			primaryExpression = this.parameterlessCall();
			goto IL_2FF;
			IL_FD:
			if (this.LA(1) == 193 && this.LA(2) == 232 && this.LA(1) == 193 && base.NextTokenMatches("FN", 2))
			{
				primaryExpression = this.odbcFunctionCall();
			}
			else if (TSql80ParserInternal.tokenSet_83_.member(this.LA(1)) && TSql80ParserInternal.tokenSet_84_.member(this.LA(2)))
			{
				primaryExpression = this.literal();
			}
			else if (this.LA(1) == 232 && this.LA(2) == 191 && base.NextTokenMatches("CAST") && this.LA(2) == 191)
			{
				primaryExpression = this.castCall();
			}
			else
			{
				bool flag = false;
				if (this.LA(1) == 232 && this.LA(2) == 191)
				{
					int pos = this.mark();
					flag = true;
					this.inputState.guessing++;
					try
					{
						this.match(232);
						this.match(191);
					}
					catch (RecognitionException)
					{
						flag = false;
					}
					this.rewind(pos);
					this.inputState.guessing--;
				}
				if (flag)
				{
					primaryExpression = this.identifierBuiltInFunctionCall();
				}
				else if ((this.LA(1) == 228 || this.LA(1) == 232 || this.LA(1) == 233) && this.LA(2) == 200 && (((this.LA(1) == 232 || this.LA(1) == 233) && this.LA(2) == 200 && this.LA(3) == 228) || this.LA(1) == 228))
				{
					primaryExpression = this.partitionFunctionCall();
				}
				else
				{
					if (!TSql80ParserInternal.tokenSet_80_.member(this.LA(1)) || !TSql80ParserInternal.tokenSet_85_.member(this.LA(2)))
					{
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
					primaryExpression = this.columnOrFunctionCall();
				}
			}
			IL_2FF:
			this.collationOpt(primaryExpression);
			return primaryExpression;
		}

		// Token: 0x06001412 RID: 5138 RVA: 0x0007318C File Offset: 0x0007138C
		public CastCall castCall()
		{
			CastCall castCall = base.FragmentFactory.CreateFragment<CastCall>();
			IToken token = this.LT(1);
			this.match(232);
			this.match(191);
			ScalarExpression parameter = this.expression();
			this.match(9);
			DataTypeReference dataType = this.scalarDataType();
			IToken token2 = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.Match(token, "CAST");
				TSql80ParserBaseInternal.UpdateTokenInfo(castCall, token);
				castCall.DataType = dataType;
				castCall.Parameter = parameter;
				TSql80ParserBaseInternal.UpdateTokenInfo(castCall, token2);
			}
			return castCall;
		}

		// Token: 0x06001413 RID: 5139 RVA: 0x00073228 File Offset: 0x00071428
		public FunctionCall identifierBuiltInFunctionCall()
		{
			FunctionCall functionCall = base.FragmentFactory.CreateFragment<FunctionCall>();
			Identifier functionName = this.nonQuotedIdentifier();
			if (this.inputState.guessing == 0)
			{
				functionCall.FunctionName = functionName;
			}
			this.match(191);
			int num = this.LA(1);
			if (num <= 93)
			{
				if (num <= 34)
				{
					if (num <= 20)
					{
						if (num != 5)
						{
							if (num != 20)
							{
								goto IL_1D3;
							}
							goto IL_1C1;
						}
					}
					else
					{
						if (num != 25 && num != 34)
						{
							goto IL_1D3;
						}
						goto IL_1C1;
					}
				}
				else if (num <= 51)
				{
					switch (num)
					{
					case 40:
					case 41:
						goto IL_1C1;
					default:
						if (num != 51)
						{
							goto IL_1D3;
						}
						break;
					}
				}
				else
				{
					if (num != 81 && num != 93)
					{
						goto IL_1D3;
					}
					goto IL_1C1;
				}
				this.identifierBuiltInFunctionCallUniqueRowFilter(functionCall);
				goto IL_1E6;
			}
			if (num <= 141)
			{
				if (num <= 133)
				{
					switch (num)
					{
					case 100:
					case 101:
						break;
					default:
						if (num != 133)
						{
							goto IL_1D3;
						}
						break;
					}
				}
				else if (num != 136 && num != 141)
				{
					goto IL_1D3;
				}
			}
			else if (num <= 163)
			{
				if (num != 147 && num != 163)
				{
					goto IL_1D3;
				}
			}
			else
			{
				switch (num)
				{
				case 191:
				case 192:
				case 193:
				case 195:
				case 197:
				case 199:
				case 200:
					break;
				case 194:
				case 196:
				case 198:
					goto IL_1D3;
				default:
					switch (num)
					{
					case 211:
					case 221:
					case 222:
					case 223:
					case 224:
					case 225:
					case 227:
					case 228:
					case 230:
					case 231:
					case 232:
					case 233:
					case 234:
					case 235:
						break;
					case 212:
					case 213:
					case 214:
					case 215:
					case 216:
					case 217:
					case 218:
					case 219:
					case 220:
					case 226:
					case 229:
						goto IL_1D3;
					default:
						goto IL_1D3;
					}
					break;
				}
			}
			IL_1C1:
			this.identifierBuiltInFunctionCallDefaultParams(functionCall);
			goto IL_1E6;
			IL_1D3:
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_1E6:
			IToken token = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(functionCall, token);
			}
			return functionCall;
		}

		// Token: 0x06001414 RID: 5140 RVA: 0x00073444 File Offset: 0x00071644
		public LeftFunctionCall leftFunctionCall()
		{
			LeftFunctionCall leftFunctionCall = base.FragmentFactory.CreateFragment<LeftFunctionCall>();
			IToken token = this.LT(1);
			this.match(93);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(leftFunctionCall, token);
			}
			this.reservedBuiltInFunctionCallParameters(leftFunctionCall, leftFunctionCall.Parameters);
			return leftFunctionCall;
		}

		// Token: 0x06001415 RID: 5141 RVA: 0x00073494 File Offset: 0x00071694
		public RightFunctionCall rightFunctionCall()
		{
			RightFunctionCall rightFunctionCall = base.FragmentFactory.CreateFragment<RightFunctionCall>();
			IToken token = this.LT(1);
			this.match(133);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(rightFunctionCall, token);
			}
			this.reservedBuiltInFunctionCallParameters(rightFunctionCall, rightFunctionCall.Parameters);
			return rightFunctionCall;
		}

		// Token: 0x06001416 RID: 5142 RVA: 0x000734E4 File Offset: 0x000716E4
		public PartitionFunctionCall partitionFunctionCall()
		{
			PartitionFunctionCall partitionFunctionCall = base.FragmentFactory.CreateFragment<PartitionFunctionCall>();
			int num = this.LA(1);
			Identifier identifier;
			if (num != 228)
			{
				switch (num)
				{
				case 232:
				case 233:
					identifier = this.identifier();
					if (this.inputState.guessing == 0)
					{
						partitionFunctionCall.DatabaseName = identifier;
					}
					this.match(200);
					break;
				default:
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
			}
			IToken token = this.LT(1);
			this.match(228);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(partitionFunctionCall, token);
			}
			this.match(200);
			identifier = this.identifier();
			if (this.inputState.guessing == 0)
			{
				partitionFunctionCall.FunctionName = identifier;
			}
			this.match(191);
			this.expressionList(partitionFunctionCall, partitionFunctionCall.Parameters);
			IToken token2 = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(partitionFunctionCall, token2);
			}
			return partitionFunctionCall;
		}

		// Token: 0x06001417 RID: 5143 RVA: 0x000735F4 File Offset: 0x000717F4
		public PrimaryExpression columnOrFunctionCall()
		{
			PrimaryExpression primaryExpression = null;
			MultiPartIdentifier multiPartIdentifier = null;
			ColumnReferenceExpression columnReferenceExpression = null;
			int num = this.LA(1);
			if (num <= 136)
			{
				if (num != 81 && num != 136)
				{
					goto IL_126;
				}
			}
			else
			{
				if (num != 200)
				{
					if (num == 227)
					{
						goto IL_104;
					}
					switch (num)
					{
					case 232:
					case 233:
						break;
					default:
						goto IL_126;
					}
				}
				multiPartIdentifier = this.multiPartIdentifier(-1);
				if (this.LA(1) == 200)
				{
					if (this.inputState.guessing == 0)
					{
						columnReferenceExpression = base.FragmentFactory.CreateFragment<ColumnReferenceExpression>();
					}
					this.match(200);
					this.specialColumn(columnReferenceExpression);
					goto IL_139;
				}
				if (this.LA(1) == 191 && TSql80ParserInternal.tokenSet_86_.member(this.LA(2)))
				{
					primaryExpression = this.userFunctionCall(multiPartIdentifier);
					goto IL_139;
				}
				if (!TSql80ParserInternal.tokenSet_84_.member(this.LA(1)) || !TSql80ParserInternal.tokenSet_87_.member(this.LA(2)))
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				goto IL_139;
			}
			IL_104:
			if (this.inputState.guessing == 0)
			{
				columnReferenceExpression = base.FragmentFactory.CreateFragment<ColumnReferenceExpression>();
			}
			this.specialColumn(columnReferenceExpression);
			goto IL_139;
			IL_126:
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_139:
			if (this.inputState.guessing == 0 && (primaryExpression == null || primaryExpression is ColumnReferenceExpression))
			{
				if (columnReferenceExpression == null)
				{
					columnReferenceExpression = base.FragmentFactory.CreateFragment<ColumnReferenceExpression>();
				}
				columnReferenceExpression.MultiPartIdentifier = multiPartIdentifier;
				TSql80ParserBaseInternal.CheckSpecialColumn(columnReferenceExpression);
				TSql80ParserBaseInternal.CheckTableNameExistsForColumn(columnReferenceExpression, false);
				primaryExpression = columnReferenceExpression;
			}
			return primaryExpression;
		}

		// Token: 0x06001418 RID: 5144 RVA: 0x00073778 File Offset: 0x00071978
		public NullIfExpression nullIfExpression(ExpressionFlags expressionFlags)
		{
			NullIfExpression nullIfExpression = base.FragmentFactory.CreateFragment<NullIfExpression>();
			IToken token = this.LT(1);
			this.match(101);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(nullIfExpression, token);
			}
			this.match(191);
			ScalarExpression scalarExpression = this.expressionWithFlags(expressionFlags);
			if (this.inputState.guessing == 0)
			{
				nullIfExpression.FirstExpression = scalarExpression;
			}
			this.match(198);
			scalarExpression = this.expressionWithFlags(expressionFlags);
			if (this.inputState.guessing == 0)
			{
				nullIfExpression.SecondExpression = scalarExpression;
			}
			IToken token2 = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(nullIfExpression, token2);
			}
			return nullIfExpression;
		}

		// Token: 0x06001419 RID: 5145 RVA: 0x00073830 File Offset: 0x00071A30
		public CoalesceExpression coalesceExpression(ExpressionFlags expressionFlags)
		{
			CoalesceExpression coalesceExpression = base.FragmentFactory.CreateFragment<CoalesceExpression>();
			IToken token = this.LT(1);
			this.match(25);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(coalesceExpression, token);
			}
			this.match(191);
			ScalarExpression item = this.expressionWithFlags(expressionFlags);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ScalarExpression>(coalesceExpression, coalesceExpression.Expressions, item);
			}
			int num = 0;
			while (this.LA(1) == 198)
			{
				this.match(198);
				item = this.expressionWithFlags(expressionFlags);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ScalarExpression>(coalesceExpression, coalesceExpression.Expressions, item);
				}
				num++;
			}
			if (num < 1)
			{
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			IToken token2 = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(coalesceExpression, token2);
			}
			return coalesceExpression;
		}

		// Token: 0x0600141A RID: 5146 RVA: 0x00073928 File Offset: 0x00071B28
		public CaseExpression caseExpression(ExpressionFlags expressionFlags)
		{
			IToken token = this.LT(1);
			this.match(20);
			int num = this.LA(1);
			CaseExpression caseExpression;
			if (num <= 133)
			{
				if (num <= 41)
				{
					if (num <= 25)
					{
						if (num != 20 && num != 25)
						{
							goto IL_1DA;
						}
					}
					else if (num != 34)
					{
						switch (num)
						{
						case 40:
						case 41:
							break;
						default:
							goto IL_1DA;
						}
					}
				}
				else if (num <= 93)
				{
					if (num != 81 && num != 93)
					{
						goto IL_1DA;
					}
				}
				else
				{
					switch (num)
					{
					case 100:
					case 101:
						break;
					default:
						if (num != 133)
						{
							goto IL_1DA;
						}
						break;
					}
				}
			}
			else if (num <= 163)
			{
				if (num <= 141)
				{
					if (num != 136 && num != 141)
					{
						goto IL_1DA;
					}
				}
				else if (num != 147 && num != 163)
				{
					goto IL_1DA;
				}
			}
			else if (num <= 193)
			{
				if (num == 168)
				{
					caseExpression = this.searchedCaseExpression(expressionFlags);
					goto IL_1ED;
				}
				switch (num)
				{
				case 191:
				case 193:
					break;
				case 192:
					goto IL_1DA;
				default:
					goto IL_1DA;
				}
			}
			else
			{
				switch (num)
				{
				case 197:
				case 199:
				case 200:
					break;
				case 198:
					goto IL_1DA;
				default:
					switch (num)
					{
					case 211:
					case 221:
					case 222:
					case 223:
					case 224:
					case 225:
					case 227:
					case 228:
					case 230:
					case 231:
					case 232:
					case 233:
					case 234:
					case 235:
						break;
					case 212:
					case 213:
					case 214:
					case 215:
					case 216:
					case 217:
					case 218:
					case 219:
					case 220:
					case 226:
					case 229:
						goto IL_1DA;
					default:
						goto IL_1DA;
					}
					break;
				}
			}
			ScalarExpression scalarExpression = this.expressionWithFlags(expressionFlags);
			caseExpression = this.simpleCaseExpression(scalarExpression, expressionFlags);
			goto IL_1ED;
			IL_1DA:
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_1ED:
			switch (this.LA(1))
			{
			case 55:
				this.match(55);
				scalarExpression = this.expressionWithFlags(expressionFlags);
				if (this.inputState.guessing == 0)
				{
					caseExpression.ElseExpression = scalarExpression;
				}
				break;
			case 56:
				break;
			default:
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			IToken token2 = this.LT(1);
			this.match(56);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(caseExpression, token);
				TSql80ParserBaseInternal.UpdateTokenInfo(caseExpression, token2);
			}
			return caseExpression;
		}

		// Token: 0x0600141B RID: 5147 RVA: 0x00073BA4 File Offset: 0x00071DA4
		public ConvertCall convertCall()
		{
			ConvertCall convertCall = base.FragmentFactory.CreateFragment<ConvertCall>();
			IToken token = this.LT(1);
			this.match(34);
			this.match(191);
			DataTypeReference dataType = this.scalarDataType();
			this.match(198);
			ScalarExpression scalarExpression = this.expression();
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(convertCall, token);
				convertCall.DataType = dataType;
				convertCall.Parameter = scalarExpression;
			}
			int num = this.LA(1);
			if (num != 192)
			{
				if (num != 198)
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				this.match(198);
				scalarExpression = this.expression();
				if (this.inputState.guessing == 0)
				{
					convertCall.Style = scalarExpression;
				}
			}
			IToken token2 = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(convertCall, token2);
			}
			return convertCall;
		}

		// Token: 0x0600141C RID: 5148 RVA: 0x00073C9C File Offset: 0x00071E9C
		public ParameterlessCall parameterlessCall()
		{
			ParameterlessCall parameterlessCall = base.FragmentFactory.CreateFragment<ParameterlessCall>();
			int num = this.LA(1);
			if (num <= 141)
			{
				switch (num)
				{
				case 40:
				{
					IToken token = this.LT(1);
					this.match(40);
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.UpdateTokenInfo(parameterlessCall, token);
						parameterlessCall.ParameterlessCallType = ParameterlessCallType.CurrentTimestamp;
						return parameterlessCall;
					}
					return parameterlessCall;
				}
				case 41:
				{
					IToken token2 = this.LT(1);
					this.match(41);
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.UpdateTokenInfo(parameterlessCall, token2);
						parameterlessCall.ParameterlessCallType = ParameterlessCallType.CurrentUser;
						return parameterlessCall;
					}
					return parameterlessCall;
				}
				default:
					if (num == 141)
					{
						IToken token3 = this.LT(1);
						this.match(141);
						if (this.inputState.guessing == 0)
						{
							TSql80ParserBaseInternal.UpdateTokenInfo(parameterlessCall, token3);
							parameterlessCall.ParameterlessCallType = ParameterlessCallType.SessionUser;
							return parameterlessCall;
						}
						return parameterlessCall;
					}
					break;
				}
			}
			else if (num != 147)
			{
				if (num == 163)
				{
					IToken token4 = this.LT(1);
					this.match(163);
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.UpdateTokenInfo(parameterlessCall, token4);
						parameterlessCall.ParameterlessCallType = ParameterlessCallType.User;
						return parameterlessCall;
					}
					return parameterlessCall;
				}
			}
			else
			{
				IToken token5 = this.LT(1);
				this.match(147);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(parameterlessCall, token5);
					parameterlessCall.ParameterlessCallType = ParameterlessCallType.SystemUser;
					return parameterlessCall;
				}
				return parameterlessCall;
			}
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x0600141D RID: 5149 RVA: 0x00073E20 File Offset: 0x00072020
		public PrimaryExpression paranthesisDisambiguatorForExpressions(ExpressionFlags expressionFlags)
		{
			PrimaryExpression result;
			if (this.LA(1) == 191 && (this.LA(2) == 140 || this.LA(2) == 191) && base.IsNextRuleSelectParenthesis())
			{
				result = this.subquery(expressionFlags);
			}
			else
			{
				if (this.LA(1) != 191 || !TSql80ParserInternal.tokenSet_16_.member(this.LA(2)))
				{
					throw new NoViableAltException(this.LT(1), this.getFilename());
				}
				result = this.expressionParenthesis(expressionFlags);
			}
			return result;
		}

		// Token: 0x0600141E RID: 5150 RVA: 0x00073EAC File Offset: 0x000720AC
		public ParenthesisExpression expressionParenthesis(ExpressionFlags expressionFlags)
		{
			ParenthesisExpression parenthesisExpression = base.FragmentFactory.CreateFragment<ParenthesisExpression>();
			IToken token = this.LT(1);
			this.match(191);
			ScalarExpression expression = this.expressionWithFlags(expressionFlags);
			IToken token2 = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(parenthesisExpression, token);
				parenthesisExpression.Expression = expression;
				TSql80ParserBaseInternal.UpdateTokenInfo(parenthesisExpression, token2);
			}
			return parenthesisExpression;
		}

		// Token: 0x0600141F RID: 5151 RVA: 0x00073F1C File Offset: 0x0007211C
		public FunctionCall basicFunctionCall()
		{
			FunctionCall functionCall = base.FragmentFactory.CreateFragment<FunctionCall>();
			Identifier functionName = this.identifier();
			if (this.inputState.guessing == 0)
			{
				functionCall.FunctionName = functionName;
			}
			this.parenthesizedOptExpressionWithDefaultList(functionCall, functionCall.Parameters);
			return functionCall;
		}

		// Token: 0x06001420 RID: 5152 RVA: 0x00073F60 File Offset: 0x00072160
		public void identifierBuiltInFunctionCallDefaultParams(FunctionCall vParent)
		{
			int num = this.LA(1);
			if (num <= 101)
			{
				if (num <= 34)
				{
					if (num != 20 && num != 25 && num != 34)
					{
						goto IL_197;
					}
				}
				else if (num <= 81)
				{
					switch (num)
					{
					case 40:
					case 41:
						break;
					default:
						if (num != 81)
						{
							goto IL_197;
						}
						break;
					}
				}
				else if (num != 93)
				{
					switch (num)
					{
					case 100:
					case 101:
						break;
					default:
						goto IL_197;
					}
				}
			}
			else if (num <= 141)
			{
				if (num != 133 && num != 136 && num != 141)
				{
					goto IL_197;
				}
			}
			else
			{
				if (num > 163)
				{
					switch (num)
					{
					case 191:
					case 193:
					case 197:
					case 199:
					case 200:
						goto IL_167;
					case 192:
						break;
					case 194:
					case 196:
					case 198:
						goto IL_197;
					case 195:
					{
						ColumnReferenceExpression item = this.starColumnReferenceExpression();
						if (this.inputState.guessing == 0)
						{
							TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ScalarExpression>(vParent, vParent.Parameters, item);
							return;
						}
						break;
					}
					default:
						switch (num)
						{
						case 211:
						case 221:
						case 222:
						case 223:
						case 224:
						case 225:
						case 227:
						case 228:
						case 230:
						case 231:
						case 232:
						case 233:
						case 234:
						case 235:
							goto IL_167;
						case 212:
						case 213:
						case 214:
						case 215:
						case 216:
						case 217:
						case 218:
						case 219:
						case 220:
						case 226:
						case 229:
							goto IL_197;
						default:
							goto IL_197;
						}
						break;
					}
					return;
				}
				if (num != 147 && num != 163)
				{
					goto IL_197;
				}
			}
			IL_167:
			this.expressionList(vParent, vParent.Parameters);
			return;
			IL_197:
			throw new NoViableAltException(this.LT(1), this.getFilename());
		}

		// Token: 0x06001421 RID: 5153 RVA: 0x00074118 File Offset: 0x00072318
		public void identifierBuiltInFunctionCallUniqueRowFilter(FunctionCall vParent)
		{
			UniqueRowFilter uniqueRowFilter = this.uniqueRowFilter();
			ScalarExpression item = this.expression();
			if (this.inputState.guessing == 0)
			{
				vParent.UniqueRowFilter = uniqueRowFilter;
				TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ScalarExpression>(vParent, vParent.Parameters, item);
			}
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x00074154 File Offset: 0x00072354
		public void reservedBuiltInFunctionCallParameters(TSqlFragment vParent, IList<ScalarExpression> parameters)
		{
			this.match(191);
			int num = this.LA(1);
			if (num <= 101)
			{
				if (num <= 34)
				{
					if (num != 20 && num != 25 && num != 34)
					{
						goto IL_17E;
					}
				}
				else if (num <= 81)
				{
					switch (num)
					{
					case 40:
					case 41:
						break;
					default:
						if (num != 81)
						{
							goto IL_17E;
						}
						break;
					}
				}
				else if (num != 93)
				{
					switch (num)
					{
					case 100:
					case 101:
						break;
					default:
						goto IL_17E;
					}
				}
			}
			else if (num <= 141)
			{
				if (num != 133 && num != 136 && num != 141)
				{
					goto IL_17E;
				}
			}
			else if (num <= 163)
			{
				if (num != 147 && num != 163)
				{
					goto IL_17E;
				}
			}
			else
			{
				switch (num)
				{
				case 191:
				case 193:
				case 197:
				case 199:
				case 200:
					break;
				case 192:
					goto IL_191;
				case 194:
				case 195:
				case 196:
				case 198:
					goto IL_17E;
				default:
					switch (num)
					{
					case 211:
					case 221:
					case 222:
					case 223:
					case 224:
					case 225:
					case 227:
					case 228:
					case 230:
					case 231:
					case 232:
					case 233:
					case 234:
					case 235:
						break;
					case 212:
					case 213:
					case 214:
					case 215:
					case 216:
					case 217:
					case 218:
					case 219:
					case 220:
					case 226:
					case 229:
						goto IL_17E;
					default:
						goto IL_17E;
					}
					break;
				}
			}
			this.expressionList(vParent, parameters);
			goto IL_191;
			IL_17E:
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_191:
			IToken token = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(vParent, token);
			}
		}

		// Token: 0x06001423 RID: 5155 RVA: 0x0007431C File Offset: 0x0007251C
		public SimpleWhenClause simpleWhenClause(ExpressionFlags expressionFlags)
		{
			SimpleWhenClause simpleWhenClause = base.FragmentFactory.CreateFragment<SimpleWhenClause>();
			IToken token = this.LT(1);
			this.match(168);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(simpleWhenClause, token);
			}
			ScalarExpression scalarExpression = this.expressionWithFlags(expressionFlags);
			if (this.inputState.guessing == 0)
			{
				simpleWhenClause.WhenExpression = scalarExpression;
			}
			this.match(150);
			scalarExpression = this.expressionWithFlags(expressionFlags);
			if (this.inputState.guessing == 0)
			{
				simpleWhenClause.ThenExpression = scalarExpression;
			}
			return simpleWhenClause;
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x000743A4 File Offset: 0x000725A4
		public SearchedWhenClause searchedWhenClause(ExpressionFlags expressionFlags)
		{
			SearchedWhenClause searchedWhenClause = base.FragmentFactory.CreateFragment<SearchedWhenClause>();
			IToken token = this.LT(1);
			this.match(168);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(searchedWhenClause, token);
			}
			BooleanExpression whenExpression = this.booleanExpressionWithFlags(expressionFlags);
			if (this.inputState.guessing == 0)
			{
				searchedWhenClause.WhenExpression = whenExpression;
			}
			this.match(150);
			ScalarExpression thenExpression = this.expressionWithFlags(expressionFlags);
			if (this.inputState.guessing == 0)
			{
				searchedWhenClause.ThenExpression = thenExpression;
			}
			return searchedWhenClause;
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x00074430 File Offset: 0x00072630
		public SimpleCaseExpression simpleCaseExpression(ScalarExpression inputExpression, ExpressionFlags expressionFlags)
		{
			SimpleCaseExpression simpleCaseExpression = base.FragmentFactory.CreateFragment<SimpleCaseExpression>();
			simpleCaseExpression.InputExpression = inputExpression;
			int num = 0;
			while (this.LA(1) == 168)
			{
				SimpleWhenClause item = this.simpleWhenClause(expressionFlags);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<SimpleWhenClause>(simpleCaseExpression, simpleCaseExpression.WhenClauses, item);
				}
				num++;
			}
			if (num < 1)
			{
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			return simpleCaseExpression;
		}

		// Token: 0x06001426 RID: 5158 RVA: 0x000744A4 File Offset: 0x000726A4
		public SearchedCaseExpression searchedCaseExpression(ExpressionFlags expressionFlags)
		{
			SearchedCaseExpression searchedCaseExpression = base.FragmentFactory.CreateFragment<SearchedCaseExpression>();
			int num = 0;
			while (this.LA(1) == 168)
			{
				SearchedWhenClause item = this.searchedWhenClause(expressionFlags);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.AddAndUpdateTokenInfo<SearchedWhenClause>(searchedCaseExpression, searchedCaseExpression.WhenClauses, item);
				}
				num++;
			}
			if (num < 1)
			{
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			return searchedCaseExpression;
		}

		// Token: 0x06001427 RID: 5159 RVA: 0x00074510 File Offset: 0x00072710
		public void specialColumn(ColumnReferenceExpression vResult)
		{
			int num = this.LA(1);
			if (num != 81)
			{
				if (num != 136)
				{
					if (num != 227)
					{
						throw new NoViableAltException(this.LT(1), this.getFilename());
					}
					IToken token = this.LT(1);
					this.match(227);
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.UpdateTokenInfo(vResult, token);
						vResult.ColumnType = PseudoColumnHelper.Instance.ParseOption(token, SqlVersionFlags.TSql80);
						return;
					}
				}
				else
				{
					IToken token2 = this.LT(1);
					this.match(136);
					if (this.inputState.guessing == 0)
					{
						TSql80ParserBaseInternal.UpdateTokenInfo(vResult, token2);
						vResult.ColumnType = ColumnType.RowGuidCol;
						return;
					}
				}
			}
			else
			{
				IToken token3 = this.LT(1);
				this.match(81);
				if (this.inputState.guessing == 0)
				{
					TSql80ParserBaseInternal.UpdateTokenInfo(vResult, token3);
					vResult.ColumnType = ColumnType.IdentityCol;
					return;
				}
			}
		}

		// Token: 0x06001428 RID: 5160 RVA: 0x000745F0 File Offset: 0x000727F0
		public FunctionCall userFunctionCall(MultiPartIdentifier vIdentifiers)
		{
			FunctionCall functionCall = base.FragmentFactory.CreateFragment<FunctionCall>();
			this.match(191);
			int num = this.LA(1);
			if (num <= 81)
			{
				if (num <= 34)
				{
					if (num <= 20)
					{
						if (num != 5)
						{
							if (num != 20)
							{
								goto IL_355;
							}
							goto IL_1AE;
						}
					}
					else
					{
						if (num != 25 && num != 34)
						{
							goto IL_355;
						}
						goto IL_1AE;
					}
				}
				else if (num <= 47)
				{
					switch (num)
					{
					case 40:
					case 41:
						goto IL_1AE;
					default:
						if (num != 47)
						{
							goto IL_355;
						}
						goto IL_1AE;
					}
				}
				else if (num != 51)
				{
					if (num != 81)
					{
						goto IL_355;
					}
					goto IL_1AE;
				}
				this.identifierBuiltInFunctionCallUniqueRowFilter(functionCall);
				goto IL_368;
			}
			if (num <= 136)
			{
				if (num <= 101)
				{
					if (num != 93)
					{
						switch (num)
						{
						case 100:
						case 101:
							break;
						default:
							goto IL_355;
						}
					}
				}
				else if (num != 133 && num != 136)
				{
					goto IL_355;
				}
			}
			else if (num <= 147)
			{
				if (num != 141 && num != 147)
				{
					goto IL_355;
				}
			}
			else if (num != 163)
			{
				switch (num)
				{
				case 191:
				case 192:
				case 193:
				case 197:
				case 199:
				case 200:
					break;
				case 194:
				case 195:
				case 196:
				case 198:
					goto IL_355;
				default:
					switch (num)
					{
					case 211:
					case 221:
					case 222:
					case 223:
					case 224:
					case 225:
					case 227:
					case 228:
					case 230:
					case 231:
					case 232:
					case 233:
					case 234:
					case 235:
						break;
					case 212:
					case 213:
					case 214:
					case 215:
					case 216:
					case 217:
					case 218:
					case 219:
					case 220:
					case 226:
					case 229:
						goto IL_355;
					default:
						goto IL_355;
					}
					break;
				}
			}
			IL_1AE:
			int num2 = this.LA(1);
			if (num2 <= 93)
			{
				if (num2 <= 34)
				{
					if (num2 != 20 && num2 != 25 && num2 != 34)
					{
						goto IL_339;
					}
				}
				else if (num2 <= 47)
				{
					switch (num2)
					{
					case 40:
					case 41:
						break;
					default:
						if (num2 != 47)
						{
							goto IL_339;
						}
						break;
					}
				}
				else if (num2 != 81 && num2 != 93)
				{
					goto IL_339;
				}
			}
			else if (num2 <= 141)
			{
				if (num2 <= 133)
				{
					switch (num2)
					{
					case 100:
					case 101:
						break;
					default:
						if (num2 != 133)
						{
							goto IL_339;
						}
						break;
					}
				}
				else if (num2 != 136 && num2 != 141)
				{
					goto IL_339;
				}
			}
			else if (num2 <= 163)
			{
				if (num2 != 147 && num2 != 163)
				{
					goto IL_339;
				}
			}
			else
			{
				switch (num2)
				{
				case 191:
				case 193:
				case 197:
				case 199:
				case 200:
					break;
				case 192:
					goto IL_368;
				case 194:
				case 195:
				case 196:
				case 198:
					goto IL_339;
				default:
					switch (num2)
					{
					case 211:
					case 221:
					case 222:
					case 223:
					case 224:
					case 225:
					case 227:
					case 228:
					case 230:
					case 231:
					case 232:
					case 233:
					case 234:
					case 235:
						break;
					case 212:
					case 213:
					case 214:
					case 215:
					case 216:
					case 217:
					case 218:
					case 219:
					case 220:
					case 226:
					case 229:
						goto IL_339;
					default:
						goto IL_339;
					}
					break;
				}
			}
			this.expressionWithDefaultList(functionCall, functionCall.Parameters);
			goto IL_368;
			IL_339:
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_355:
			throw new NoViableAltException(this.LT(1), this.getFilename());
			IL_368:
			IToken token = this.LT(1);
			this.match(192);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(functionCall, token);
				base.PutIdentifiersIntoFunctionCall(functionCall, vIdentifiers);
			}
			return functionCall;
		}

		// Token: 0x06001429 RID: 5161 RVA: 0x00074998 File Offset: 0x00072B98
		public DiskStatementOption diskStatementOption()
		{
			DiskStatementOption diskStatementOption = base.FragmentFactory.CreateFragment<DiskStatementOption>();
			IToken token = this.LT(1);
			this.match(232);
			this.match(206);
			IdentifierOrValueExpression value = this.identifierOrValueExpression();
			if (this.inputState.guessing == 0)
			{
				diskStatementOption.OptionKind = DiskStatementOptionsHelper.Instance.ParseOption(token);
				diskStatementOption.Value = value;
			}
			return diskStatementOption;
		}

		// Token: 0x0600142A RID: 5162 RVA: 0x00074A00 File Offset: 0x00072C00
		public IdentifierOrValueExpression identifierOrValueExpression()
		{
			IdentifierOrValueExpression identifierOrValueExpression = base.FragmentFactory.CreateFragment<IdentifierOrValueExpression>();
			int num = this.LA(1);
			if (num != 100 && num != 193)
			{
				switch (num)
				{
				case 221:
				case 222:
				case 223:
				case 224:
				case 225:
				case 230:
				case 231:
				case 234:
					goto IL_84;
				case 232:
				case 233:
				{
					Identifier identifier = this.identifier();
					if (this.inputState.guessing == 0)
					{
						identifierOrValueExpression.Identifier = identifier;
						return identifierOrValueExpression;
					}
					return identifierOrValueExpression;
				}
				}
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			IL_84:
			ValueExpression valueExpression = this.literal();
			if (this.inputState.guessing == 0)
			{
				identifierOrValueExpression.ValueExpression = valueExpression;
			}
			return identifierOrValueExpression;
		}

		// Token: 0x0600142B RID: 5163 RVA: 0x00074AC4 File Offset: 0x00072CC4
		public ValueExpression globalVariableOrVariableReference()
		{
			ValueExpression valueExpression = null;
			IToken token = this.LT(1);
			this.match(234);
			if (this.inputState.guessing == 0)
			{
				if (token.getText().StartsWith("@@", StringComparison.Ordinal))
				{
					GlobalVariableExpression globalVariableExpression = base.FragmentFactory.CreateFragment<GlobalVariableExpression>();
					globalVariableExpression.Name = token.getText();
					valueExpression = globalVariableExpression;
				}
				else
				{
					VariableReference variableReference = base.FragmentFactory.CreateFragment<VariableReference>();
					variableReference.Name = token.getText();
					valueExpression = variableReference;
				}
				TSql80ParserBaseInternal.UpdateTokenInfo(valueExpression, token);
			}
			return valueExpression;
		}

		// Token: 0x0600142C RID: 5164 RVA: 0x00074B48 File Offset: 0x00072D48
		public MoneyLiteral moneyLiteral()
		{
			MoneyLiteral moneyLiteral = base.FragmentFactory.CreateFragment<MoneyLiteral>();
			IToken token = this.LT(1);
			this.match(225);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(moneyLiteral, token);
				moneyLiteral.Value = token.getText();
			}
			return moneyLiteral;
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x00074B98 File Offset: 0x00072D98
		public OdbcLiteral odbcLiteral()
		{
			OdbcLiteral odbcLiteral = base.FragmentFactory.CreateFragment<OdbcLiteral>();
			IToken token = this.LT(1);
			this.match(193);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(odbcLiteral, token);
			}
			IToken token2 = this.LT(1);
			this.match(232);
			switch (this.LA(1))
			{
			case 230:
			{
				IToken token3 = this.LT(1);
				this.match(230);
				if (this.inputState.guessing == 0)
				{
					odbcLiteral.OdbcLiteralType = TSql80ParserBaseInternal.ParseOdbcLiteralType(token2);
					TSql80ParserBaseInternal.UpdateTokenInfo(odbcLiteral, token3);
					odbcLiteral.Value = TSql80ParserBaseInternal.DecodeAsciiStringLiteral(token3.getText());
				}
				break;
			}
			case 231:
			{
				IToken token4 = this.LT(1);
				this.match(231);
				if (this.inputState.guessing == 0)
				{
					odbcLiteral.OdbcLiteralType = TSql80ParserBaseInternal.ParseOdbcLiteralType(token2);
					odbcLiteral.IsNational = true;
					TSql80ParserBaseInternal.UpdateTokenInfo(odbcLiteral, token4);
					odbcLiteral.Value = TSql80ParserBaseInternal.DecodeUnicodeStringLiteral(token4.getText());
				}
				break;
			}
			default:
				throw new NoViableAltException(this.LT(1), this.getFilename());
			}
			IToken token5 = this.LT(1);
			this.match(194);
			if (this.inputState.guessing == 0)
			{
				TSql80ParserBaseInternal.UpdateTokenInfo(odbcLiteral, token5);
			}
			return odbcLiteral;
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x00074CF0 File Offset: 0x00072EF0
		private void initializeFactory()
		{
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x00074CF4 File Offset: 0x00072EF4
		private static long[] mk_tokenSet_0_()
		{
			long[] array = new long[8];
			array[0] = 3585973655481528898L;
			array[1] = -1675334557835686887L;
			array[2] = -9209513072622709414L;
			array[3] = 6322594533441L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001430 RID: 5168 RVA: 0x00074D4C File Offset: 0x00072F4C
		private static long[] mk_tokenSet_1_()
		{
			long[] array = new long[8];
			array[0] = 9214359473050810082L;
			array[1] = -1454733885903487047L;
			array[2] = -1139059068170799109L;
			array[3] = 17437434049535L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x00074DA4 File Offset: 0x00072FA4
		private static long[] mk_tokenSet_2_()
		{
			long[] array = new long[8];
			array[0] = 3585973655481528898L;
			array[1] = -1675334557835686887L;
			array[2] = -9209513210061662886L;
			array[3] = 6322594533441L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x00074DFC File Offset: 0x00072FFC
		private static long[] mk_tokenSet_3_()
		{
			long[] array = new long[8];
			array[0] = 3477746525793333312L;
			array[1] = 7530022977430359041L;
			array[2] = -9209522008302168998L;
			array[3] = 268435456L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001433 RID: 5171 RVA: 0x00074E80 File Offset: 0x00073080
		private static long[] mk_tokenSet_4_()
		{
			return new long[]
			{
				140737488355328L,
				216172782113784320L,
				275012127232L,
				0L,
				0L,
				0L
			};
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x00074EA0 File Offset: 0x000730A0
		private static long[] mk_tokenSet_5_()
		{
			long[] array = new long[8];
			array[0] = 3477746525793333314L;
			array[1] = 7530022977430359041L;
			array[2] = -9209522008302168998L;
			array[3] = 7696984047872L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001435 RID: 5173 RVA: 0x00074EF8 File Offset: 0x000730F8
		private static long[] mk_tokenSet_6_()
		{
			long[] array = new long[8];
			array[0] = 8240455983232626786L;
			array[1] = -1474861547081199967L;
			array[2] = -9209512900031547398L;
			array[3] = 35029619577258L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x00074F80 File Offset: 0x00073180
		private static long[] mk_tokenSet_7_()
		{
			return new long[]
			{
				16777216L,
				17180917760L,
				2147483648L,
				0L,
				0L,
				0L
			};
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x00074FA0 File Offset: 0x000731A0
		private static long[] mk_tokenSet_8_()
		{
			long[] array = new long[8];
			array[0] = 0L;
			array[1] = 2313372481617920L;
			array[2] = 0L;
			array[3] = 7696581394688L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x00074FE8 File Offset: 0x000731E8
		private static long[] mk_tokenSet_9_()
		{
			long[] array = new long[8];
			array[0] = 0L;
			array[1] = 61572651155456L;
			array[2] = 0L;
			array[3] = 7696581394688L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x00075030 File Offset: 0x00073230
		private static long[] mk_tokenSet_10_()
		{
			long[] array = new long[8];
			array[0] = 3585832916850225218L;
			array[1] = 7530022977430359041L;
			array[2] = -9209522008302168998L;
			array[3] = 402657280L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x00075084 File Offset: 0x00073284
		private static long[] mk_tokenSet_11_()
		{
			long[] array = new long[8];
			array[0] = 8348542374289518690L;
			array[1] = -1474861547081199967L;
			array[2] = -9209512900031547398L;
			array[3] = 17437433532842L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x000750DC File Offset: 0x000732DC
		private static long[] mk_tokenSet_12_()
		{
			long[] array = new long[8];
			array[0] = 9011597301252608L;
			array[1] = 4294967296L;
			array[2] = 0L;
			array[3] = 3298534883328L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x0007512C File Offset: 0x0007332C
		private static long[] mk_tokenSet_13_()
		{
			long[] array = new long[8];
			array[0] = 0L;
			array[1] = 618475290624L;
			array[2] = 0L;
			array[3] = 8537858113666L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x00075174 File Offset: 0x00073374
		private static long[] mk_tokenSet_14_()
		{
			long[] array = new long[8];
			array[0] = 8796093022208L;
			array[1] = 0L;
			array[2] = 100663296L;
			array[3] = 1099511627776L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x000751C0 File Offset: 0x000733C0
		private static long[] mk_tokenSet_15_()
		{
			long[] array = new long[8];
			array[0] = 3585832916850225218L;
			array[1] = 7530022977430359041L;
			array[2] = -9209513212209146790L;
			array[3] = 402657280L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x00075214 File Offset: 0x00073414
		private static long[] mk_tokenSet_16_()
		{
			long[] array = new long[8];
			array[0] = 3315749355520L;
			array[1] = 206695432192L;
			array[2] = -9223372002494504672L;
			array[3] = 17437030875554L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x0007526C File Offset: 0x0007346C
		private static long[] mk_tokenSet_17_()
		{
			long[] array = new long[8];
			array[0] = 3585836232666689602L;
			array[1] = 7530023184125791233L;
			array[2] = -2291991846789188230L;
			array[3] = 17437433926570L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x000752C4 File Offset: 0x000734C4
		private static long[] mk_tokenSet_18_()
		{
			long[] array = new long[8];
			array[0] = 0L;
			array[1] = 68719476736L;
			array[2] = 0L;
			array[3] = 8537858113667L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x0007530C File Offset: 0x0007350C
		private static long[] mk_tokenSet_19_()
		{
			long[] array = new long[8];
			array[0] = 3585832916850225218L;
			array[1] = 7530022977430359041L;
			array[2] = -9209513212209146790L;
			array[3] = 402657344L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x00075360 File Offset: 0x00073560
		private static long[] mk_tokenSet_20_()
		{
			long[] array = new long[8];
			array[0] = 3585832916917334082L;
			array[1] = 7530022977430359049L;
			array[2] = -9209522008302168998L;
			array[3] = 402657280L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x000753B4 File Offset: 0x000735B4
		private static long[] mk_tokenSet_21_()
		{
			long[] array = new long[8];
			array[0] = 3585832916850225218L;
			array[1] = 7530022977430359041L;
			array[2] = -9209522008302168998L;
			array[3] = 402657344L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x00075408 File Offset: 0x00073608
		private static long[] mk_tokenSet_22_()
		{
			long[] array = new long[8];
			array[0] = 9007199254740992L;
			array[1] = 4294967296L;
			array[2] = 0L;
			array[3] = 3298534883328L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x00075458 File Offset: 0x00073658
		private static long[] mk_tokenSet_23_()
		{
			long[] array = new long[8];
			array[0] = 0L;
			array[1] = 103079215104L;
			array[2] = 0L;
			array[3] = 65L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x0007549C File Offset: 0x0007369C
		private static long[] mk_tokenSet_24_()
		{
			long[] array = new long[8];
			array[0] = 0L;
			array[1] = 68719476736L;
			array[2] = 0L;
			array[3] = 8537858113666L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x000754E4 File Offset: 0x000736E4
		private static long[] mk_tokenSet_25_()
		{
			long[] array = new long[8];
			for (int i = 0; i <= 2; i++)
			{
				array[i] = 0L;
			}
			array[3] = 1111859658817L;
			for (int j = 4; j <= 7; j++)
			{
				array[j] = 0L;
			}
			return array;
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x00075528 File Offset: 0x00073728
		private static long[] mk_tokenSet_26_()
		{
			long[] array = new long[8];
			array[0] = 8704L;
			array[1] = 0L;
			array[2] = 8L;
			array[3] = 64L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x00075598 File Offset: 0x00073798
		private static long[] mk_tokenSet_27_()
		{
			return new long[]
			{
				3459045988797251616L,
				-9223372036850581504L,
				4294971392L,
				0L,
				0L,
				0L
			};
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x000755B8 File Offset: 0x000737B8
		private static long[] mk_tokenSet_28_()
		{
			long[] array = new long[8];
			array[0] = 0L;
			array[1] = 2199023255552L;
			array[2] = long.MinValue;
			array[3] = 1099511627840L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x00075608 File Offset: 0x00073808
		private static long[] mk_tokenSet_29_()
		{
			long[] array = new long[8];
			array[0] = 3585832916850225218L;
			array[1] = 7530163714935491585L;
			array[2] = -9209522008302168998L;
			array[3] = 402657280L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x0600144D RID: 5197 RVA: 0x0007565C File Offset: 0x0007385C
		private static long[] mk_tokenSet_30_()
		{
			long[] array = new long[8];
			array[0] = 3585832916850225218L;
			array[1] = 7530022977447136257L;
			array[2] = -9209522008302168998L;
			array[3] = 3298937540608L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x000756B4 File Offset: 0x000738B4
		private static long[] mk_tokenSet_31_()
		{
			long[] array = new long[8];
			array[0] = 0L;
			array[1] = 128L;
			array[2] = 0L;
			array[3] = 4398583382144L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x000756FC File Offset: 0x000738FC
		private static long[] mk_tokenSet_32_()
		{
			long[] array = new long[8];
			array[0] = 4162293738409996354L;
			array[1] = 7531854764416711945L;
			array[2] = -9209511012112149382L;
			array[3] = 402657349L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x00075750 File Offset: 0x00073950
		private static long[] mk_tokenSet_33_()
		{
			long[] array = new long[8];
			array[0] = 9214359614785058530L;
			array[1] = -301742012686680071L;
			array[2] = -1139059068170799110L;
			array[3] = 17437434051583L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001451 RID: 5201 RVA: 0x000757A8 File Offset: 0x000739A8
		private static long[] mk_tokenSet_34_()
		{
			long[] array = new long[8];
			array[0] = 576460786663161858L;
			array[1] = 8390656L;
			array[2] = 8797166764032L;
			array[3] = 134217729L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x000757F8 File Offset: 0x000739F8
		private static long[] mk_tokenSet_35_()
		{
			long[] array = new long[8];
			for (int i = 0; i <= 2; i++)
			{
				array[i] = 0L;
			}
			array[3] = 3298534883592L;
			for (int j = 4; j <= 7; j++)
			{
				array[j] = 0L;
			}
			return array;
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x0007583C File Offset: 0x00073A3C
		private static long[] mk_tokenSet_36_()
		{
			long[] array = new long[8];
			array[0] = 576460786663161858L;
			array[1] = 562949961824392L;
			array[2] = 10996190019584L;
			array[3] = 3298669101377L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x00075894 File Offset: 0x00073A94
		private static long[] mk_tokenSet_37_()
		{
			long[] array = new long[8];
			array[0] = 3315749355520L;
			array[1] = 206695464960L;
			array[2] = -9223372002494504672L;
			array[3] = 17437030875554L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x000758EC File Offset: 0x00073AEC
		private static long[] mk_tokenSet_38_()
		{
			long[] array = new long[8];
			array[0] = 576464102479626754L;
			array[1] = 563156657256584L;
			array[2] = -2305830879151771360L;
			array[3] = 17437165503467L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x00075944 File Offset: 0x00073B44
		private static long[] mk_tokenSet_39_()
		{
			long[] array = new long[8];
			array[0] = 4162293669690519618L;
			array[1] = 7530726664880532489L;
			array[2] = -9209513211135404966L;
			array[3] = 402657281L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x00075998 File Offset: 0x00073B98
		private static long[] mk_tokenSet_40_()
		{
			long[] array = new long[8];
			array[0] = 9214359473051137762L;
			array[1] = -301812381430857799L;
			array[2] = -1139059068170799110L;
			array[3] = 17437434049535L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x000759F0 File Offset: 0x00073BF0
		private static long[] mk_tokenSet_41_()
		{
			long[] array = new long[8];
			array[0] = 4162293669690519618L;
			array[1] = 7530726664897313929L;
			array[2] = -9209519808205171622L;
			array[3] = 3298937540929L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x00075A48 File Offset: 0x00073C48
		private static long[] mk_tokenSet_42_()
		{
			long[] array = new long[8];
			array[0] = 4162296985506984514L;
			array[1] = 7530726871592746121L;
			array[2] = -2291989646692190854L;
			array[3] = 17437433943019L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x00075AA0 File Offset: 0x00073CA0
		private static long[] mk_tokenSet_43_()
		{
			long[] array = new long[8];
			array[0] = 4162296985506984514L;
			array[1] = 7530726871592746121L;
			array[2] = -2291980850599168646L;
			array[3] = 17437433926635L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x00075B28 File Offset: 0x00073D28
		private static long[] mk_tokenSet_44_()
		{
			return new long[]
			{
				68719476736L,
				1125900512919808L,
				32L,
				0L,
				0L,
				0L
			};
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x00075B48 File Offset: 0x00073D48
		private static long[] mk_tokenSet_45_()
		{
			long[] array = new long[8];
			array[0] = 4294967296L;
			array[1] = 131941395333184L;
			array[2] = long.MinValue;
			array[3] = 7696581396736L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x00075BA0 File Offset: 0x00073DA0
		private static long[] mk_tokenSet_46_()
		{
			long[] array = new long[8];
			array[0] = 4162293738409996866L;
			array[1] = 7531854764416728329L;
			array[2] = -9209511012112149382L;
			array[3] = 3298937540933L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x00075BF8 File Offset: 0x00073DF8
		private static long[] mk_tokenSet_47_()
		{
			long[] array = new long[8];
			array[0] = 68719477248L;
			array[1] = 1125900512936192L;
			array[2] = -9223363240761749472L;
			array[3] = 3298534883584L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x0600145F RID: 5215 RVA: 0x00075C50 File Offset: 0x00073E50
		private static long[] mk_tokenSet_48_()
		{
			long[] array = new long[8];
			array[0] = 4162293738409996866L;
			array[1] = 7531854764416728329L;
			array[2] = -9209511012112149382L;
			array[3] = 3298937540677L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x00075CA8 File Offset: 0x00073EA8
		private static long[] mk_tokenSet_49_()
		{
			long[] array = new long[8];
			array[0] = 9214359614785058530L;
			array[1] = -301742012686663687L;
			array[2] = -1139059068170799110L;
			array[3] = 17437434051583L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x00075D00 File Offset: 0x00073F00
		private static long[] mk_tokenSet_50_()
		{
			long[] array = new long[8];
			array[0] = 144053237710848L;
			array[1] = 206695432192L;
			array[2] = -9223372002494504672L;
			array[3] = 17437030875555L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x00075D58 File Offset: 0x00073F58
		private static long[] mk_tokenSet_51_()
		{
			long[] array = new long[8];
			array[0] = 4611689336324227072L;
			array[1] = 241055170592L;
			array[2] = -9223371997662666464L;
			array[3] = 17437030875554L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x00075DB0 File Offset: 0x00073FB0
		private static long[] mk_tokenSet_52_()
		{
			long[] array = new long[6];
			array[0] = 3458905251308896256L;
			array[2] = -9223371968135294976L;
			return array;
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x00075DE0 File Offset: 0x00073FE0
		private static long[] mk_tokenSet_53_()
		{
			long[] array = new long[8];
			array[0] = 2255115563040800L;
			array[1] = 9002788487168L;
			array[2] = -9223371933758246624L;
			array[3] = 17437030875562L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x00075E38 File Offset: 0x00074038
		private static long[] mk_tokenSet_54_()
		{
			long[] array = new long[8];
			for (int i = 0; i <= 2; i++)
			{
				array[i] = 0L;
			}
			array[3] = 3298534899968L;
			for (int j = 4; j <= 7; j++)
			{
				array[j] = 0L;
			}
			return array;
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x00075E7C File Offset: 0x0007407C
		private static long[] mk_tokenSet_55_()
		{
			long[] array = new long[8];
			array[0] = 3585836232666689602L;
			array[1] = 7530163921614146689L;
			array[2] = -2291989647765932678L;
			array[3] = 17437433926634L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x00075ED4 File Offset: 0x000740D4
		private static long[] mk_tokenSet_56_()
		{
			long[] array = new long[8];
			for (int i = 0; i <= 1; i++)
			{
				array[i] = 0L;
			}
			array[2] = long.MinValue;
			array[3] = 3298534883584L;
			for (int j = 4; j <= 7; j++)
			{
				array[j] = 0L;
			}
			return array;
		}

		// Token: 0x06001468 RID: 5224 RVA: 0x00075F24 File Offset: 0x00074124
		private static long[] mk_tokenSet_57_()
		{
			long[] array = new long[8];
			array[0] = 3585973654338580546L;
			array[1] = 7530163714918714497L;
			array[2] = -9209510944466414502L;
			array[3] = 3298937540864L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001469 RID: 5225 RVA: 0x00075F7C File Offset: 0x0007417C
		private static long[] mk_tokenSet_58_()
		{
			long[] array = new long[8];
			array[0] = 0L;
			array[1] = 1064960L;
			array[2] = 0L;
			array[3] = 1099511627840L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x0600146A RID: 5226 RVA: 0x00075FC4 File Offset: 0x000741C4
		private static long[] mk_tokenSet_59_()
		{
			long[] array = new long[8];
			array[0] = 4162293738409996866L;
			array[1] = 7531854764417776905L;
			array[2] = -9209511012112149382L;
			array[3] = 3298937540677L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x0600146B RID: 5227 RVA: 0x0007601C File Offset: 0x0007421C
		private static long[] mk_tokenSet_60_()
		{
			long[] array = new long[8];
			array[0] = 4162293738409996354L;
			array[1] = 7531854764417776905L;
			array[2] = -9209511012112149382L;
			array[3] = 1099914285125L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x00076074 File Offset: 0x00074274
		private static long[] mk_tokenSet_61_()
		{
			long[] array = new long[8];
			array[0] = 0L;
			array[1] = 1064960L;
			array[2] = long.MinValue;
			array[3] = 1099511627776L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x000760C0 File Offset: 0x000742C0
		private static long[] mk_tokenSet_62_()
		{
			long[] array = new long[8];
			array[0] = 4162293738409996866L;
			array[1] = 7531854764416711945L;
			array[2] = -9209511012112149382L;
			array[3] = 3298937540677L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x00076118 File Offset: 0x00074318
		private static long[] mk_tokenSet_63_()
		{
			long[] array = new long[8];
			array[0] = 3585832916850225218L;
			array[1] = 7530163714918714369L;
			array[2] = -9209522008302168998L;
			array[3] = 402657344L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x0600146F RID: 5231 RVA: 0x0007616C File Offset: 0x0007436C
		private static long[] mk_tokenSet_64_()
		{
			long[] array = new long[8];
			array[0] = 0L;
			array[1] = 9570149275275264L;
			array[2] = 1073741824L;
			array[3] = 1099511627776L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x000761B8 File Offset: 0x000743B8
		private static long[] mk_tokenSet_65_()
		{
			long[] array = new long[8];
			array[0] = 0L;
			array[1] = 8796093022208L;
			array[2] = 0L;
			array[3] = 7696581394688L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x00076200 File Offset: 0x00074400
		private static long[] mk_tokenSet_66_()
		{
			long[] array = new long[8];
			array[0] = 3585973654338580546L;
			array[1] = 7530163783638191105L;
			array[2] = -9209513212209146790L;
			array[3] = 26130446815618L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x00076258 File Offset: 0x00074458
		private static long[] mk_tokenSet_67_()
		{
			long[] array = new long[8];
			array[0] = 140737488355328L;
			array[1] = 68719476736L;
			array[2] = 0L;
			array[3] = 8537858113666L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x000762A8 File Offset: 0x000744A8
		private static long[] mk_tokenSet_68_()
		{
			long[] array = new long[8];
			array[0] = 3585832916850225218L;
			array[1] = 7530163714918714369L;
			array[2] = -9209513212209146790L;
			array[3] = 1112262316097L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001474 RID: 5236 RVA: 0x00076300 File Offset: 0x00074500
		private static long[] mk_tokenSet_69_()
		{
			long[] array = new long[8];
			array[0] = 3585832916850225218L;
			array[1] = 7530163714918714369L;
			array[2] = -9209513212209146790L;
			array[3] = 402657345L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001475 RID: 5237 RVA: 0x00076354 File Offset: 0x00074554
		private static long[] mk_tokenSet_70_()
		{
			long[] array = new long[8];
			array[0] = 140738564194304L;
			array[1] = 18014398509482000L;
			array[2] = (long)(int.MinValue);
			array[3] = 3298534883328L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001476 RID: 5238 RVA: 0x000763A8 File Offset: 0x000745A8
		private static long[] mk_tokenSet_71_()
		{
			long[] array = new long[8];
			array[0] = 3585973655414419522L;
			array[1] = -1675332358812431343L;
			array[2] = -9209513210061662886L;
			array[3] = 402657345L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x000763FC File Offset: 0x000745FC
		private static long[] mk_tokenSet_72_()
		{
			long[] array = new long[8];
			array[0] = 8348542375365358178L;
			array[1] = -1456844949414244683L;
			array[2] = -9209512900031547398L;
			array[3] = 17437433532907L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x00076454 File Offset: 0x00074654
		private static long[] mk_tokenSet_73_()
		{
			long[] array = new long[8];
			for (int i = 0; i <= 2; i++)
			{
				array[i] = 0L;
			}
			array[3] = 1610612896L;
			for (int j = 4; j <= 7; j++)
			{
				array[j] = 0L;
			}
			return array;
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x00076494 File Offset: 0x00074694
		private static long[] mk_tokenSet_74_()
		{
			long[] array = new long[8];
			array[0] = 3585973655414419522L;
			array[1] = -1675334557835686895L;
			array[2] = -9209522006154685094L;
			array[3] = 402657345L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x0600147A RID: 5242 RVA: 0x000764E8 File Offset: 0x000746E8
		private static long[] mk_tokenSet_75_()
		{
			long[] array = new long[8];
			array[0] = 8348542375365358178L;
			array[1] = -1456844949414244679L;
			array[2] = -9209512900031547398L;
			array[3] = 17437433532907L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x0600147B RID: 5243 RVA: 0x00076540 File Offset: 0x00074740
		private static long[] mk_tokenSet_76_()
		{
			long[] array = new long[8];
			array[0] = 8348542375365358178L;
			array[1] = -1456844949414244687L;
			array[2] = -9209512900031547398L;
			array[3] = 17437433532907L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x00076598 File Offset: 0x00074798
		private static long[] mk_tokenSet_77_()
		{
			long[] array = new long[8];
			array[0] = 3585973655414419522L;
			array[1] = -1675332358812431343L;
			array[2] = -9209522006154685094L;
			array[3] = 402657345L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x0600147D RID: 5245 RVA: 0x000765EC File Offset: 0x000747EC
		private static long[] mk_tokenSet_78_()
		{
			long[] array = new long[8];
			array[0] = 3315816480768L;
			array[1] = 242162991104L;
			array[2] = -1152920370734943968L;
			array[3] = 17437031392186L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x0600147E RID: 5246 RVA: 0x00076644 File Offset: 0x00074844
		private static long[] mk_tokenSet_79_()
		{
			long[] array = new long[8];
			for (int i = 0; i <= 2; i++)
			{
				array[i] = 0L;
			}
			array[3] = 3298534883585L;
			for (int j = 4; j <= 7; j++)
			{
				array[j] = 0L;
			}
			return array;
		}

		// Token: 0x0600147F RID: 5247 RVA: 0x00076688 File Offset: 0x00074888
		private static long[] mk_tokenSet_80_()
		{
			long[] array = new long[8];
			array[0] = 0L;
			array[1] = 131072L;
			array[2] = 256L;
			array[3] = 3332894621952L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x000766D4 File Offset: 0x000748D4
		private static long[] mk_tokenSet_81_()
		{
			long[] array = new long[8];
			for (int i = 0; i <= 2; i++)
			{
				array[i] = 0L;
			}
			array[3] = 3298534883649L;
			for (int j = 4; j <= 7; j++)
			{
				array[j] = 0L;
			}
			return array;
		}

		// Token: 0x06001481 RID: 5249 RVA: 0x00076718 File Offset: 0x00074918
		private static long[] mk_tokenSet_82_()
		{
			long[] array = new long[8];
			for (int i = 0; i <= 2; i++)
			{
				array[i] = 0L;
			}
			array[3] = 3298534883648L;
			for (int j = 4; j <= 7; j++)
			{
				array[j] = 0L;
			}
			return array;
		}

		// Token: 0x06001482 RID: 5250 RVA: 0x0007675C File Offset: 0x0007495C
		private static long[] mk_tokenSet_83_()
		{
			long[] array = new long[8];
			array[0] = 0L;
			array[1] = 68719476736L;
			array[2] = 0L;
			array[3] = 5239323230210L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001483 RID: 5251 RVA: 0x000767A4 File Offset: 0x000749A4
		private static long[] mk_tokenSet_84_()
		{
			long[] array = new long[8];
			array[0] = 4451790753099871938L;
			array[1] = -1673221294748025447L;
			array[2] = -1139059378200914566L;
			array[3] = 4123571778303L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001484 RID: 5252 RVA: 0x000767FC File Offset: 0x000749FC
		private static long[] mk_tokenSet_85_()
		{
			long[] array = new long[8];
			array[0] = 4451790753099871938L;
			array[1] = -1673221294748025447L;
			array[2] = -1139059378200914566L;
			array[3] = 4123571778559L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001485 RID: 5253 RVA: 0x00076854 File Offset: 0x00074A54
		private static long[] mk_tokenSet_86_()
		{
			long[] array = new long[8];
			array[0] = 2395853051396128L;
			array[1] = 206695432192L;
			array[2] = -9223372002494504672L;
			array[3] = 17437030875555L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x06001486 RID: 5254 RVA: 0x000768AC File Offset: 0x00074AAC
		private static long[] mk_tokenSet_87_()
		{
			long[] array = new long[8];
			array[0] = 9223366814039799778L;
			array[1] = -301742008257495047L;
			array[2] = -1139058999451191302L;
			array[3] = 17437434051583L;
			for (int i = 4; i <= 7; i++)
			{
				array[i] = 0L;
			}
			return array;
		}

		// Token: 0x0400158C RID: 5516
		public const int EOF = 1;

		// Token: 0x0400158D RID: 5517
		public const int NULL_TREE_LOOKAHEAD = 3;

		// Token: 0x0400158E RID: 5518
		public const int Add = 4;

		// Token: 0x0400158F RID: 5519
		public const int All = 5;

		// Token: 0x04001590 RID: 5520
		public const int Alter = 6;

		// Token: 0x04001591 RID: 5521
		public const int And = 7;

		// Token: 0x04001592 RID: 5522
		public const int Any = 8;

		// Token: 0x04001593 RID: 5523
		public const int As = 9;

		// Token: 0x04001594 RID: 5524
		public const int Asc = 10;

		// Token: 0x04001595 RID: 5525
		public const int Authorization = 11;

		// Token: 0x04001596 RID: 5526
		public const int Backup = 12;

		// Token: 0x04001597 RID: 5527
		public const int Begin = 13;

		// Token: 0x04001598 RID: 5528
		public const int Between = 14;

		// Token: 0x04001599 RID: 5529
		public const int Break = 15;

		// Token: 0x0400159A RID: 5530
		public const int Browse = 16;

		// Token: 0x0400159B RID: 5531
		public const int Bulk = 17;

		// Token: 0x0400159C RID: 5532
		public const int By = 18;

		// Token: 0x0400159D RID: 5533
		public const int Cascade = 19;

		// Token: 0x0400159E RID: 5534
		public const int Case = 20;

		// Token: 0x0400159F RID: 5535
		public const int Check = 21;

		// Token: 0x040015A0 RID: 5536
		public const int Checkpoint = 22;

		// Token: 0x040015A1 RID: 5537
		public const int Close = 23;

		// Token: 0x040015A2 RID: 5538
		public const int Clustered = 24;

		// Token: 0x040015A3 RID: 5539
		public const int Coalesce = 25;

		// Token: 0x040015A4 RID: 5540
		public const int Collate = 26;

		// Token: 0x040015A5 RID: 5541
		public const int Column = 27;

		// Token: 0x040015A6 RID: 5542
		public const int Commit = 28;

		// Token: 0x040015A7 RID: 5543
		public const int Compute = 29;

		// Token: 0x040015A8 RID: 5544
		public const int Constraint = 30;

		// Token: 0x040015A9 RID: 5545
		public const int Contains = 31;

		// Token: 0x040015AA RID: 5546
		public const int ContainsTable = 32;

		// Token: 0x040015AB RID: 5547
		public const int Continue = 33;

		// Token: 0x040015AC RID: 5548
		public const int Convert = 34;

		// Token: 0x040015AD RID: 5549
		public const int Create = 35;

		// Token: 0x040015AE RID: 5550
		public const int Cross = 36;

		// Token: 0x040015AF RID: 5551
		public const int Current = 37;

		// Token: 0x040015B0 RID: 5552
		public const int CurrentDate = 38;

		// Token: 0x040015B1 RID: 5553
		public const int CurrentTime = 39;

		// Token: 0x040015B2 RID: 5554
		public const int CurrentTimestamp = 40;

		// Token: 0x040015B3 RID: 5555
		public const int CurrentUser = 41;

		// Token: 0x040015B4 RID: 5556
		public const int Cursor = 42;

		// Token: 0x040015B5 RID: 5557
		public const int Database = 43;

		// Token: 0x040015B6 RID: 5558
		public const int Dbcc = 44;

		// Token: 0x040015B7 RID: 5559
		public const int Deallocate = 45;

		// Token: 0x040015B8 RID: 5560
		public const int Declare = 46;

		// Token: 0x040015B9 RID: 5561
		public const int Default = 47;

		// Token: 0x040015BA RID: 5562
		public const int Delete = 48;

		// Token: 0x040015BB RID: 5563
		public const int Deny = 49;

		// Token: 0x040015BC RID: 5564
		public const int Desc = 50;

		// Token: 0x040015BD RID: 5565
		public const int Distinct = 51;

		// Token: 0x040015BE RID: 5566
		public const int Distributed = 52;

		// Token: 0x040015BF RID: 5567
		public const int Double = 53;

		// Token: 0x040015C0 RID: 5568
		public const int Drop = 54;

		// Token: 0x040015C1 RID: 5569
		public const int Else = 55;

		// Token: 0x040015C2 RID: 5570
		public const int End = 56;

		// Token: 0x040015C3 RID: 5571
		public const int Errlvl = 57;

		// Token: 0x040015C4 RID: 5572
		public const int Escape = 58;

		// Token: 0x040015C5 RID: 5573
		public const int Except = 59;

		// Token: 0x040015C6 RID: 5574
		public const int Exec = 60;

		// Token: 0x040015C7 RID: 5575
		public const int Execute = 61;

		// Token: 0x040015C8 RID: 5576
		public const int Exists = 62;

		// Token: 0x040015C9 RID: 5577
		public const int Exit = 63;

		// Token: 0x040015CA RID: 5578
		public const int Fetch = 64;

		// Token: 0x040015CB RID: 5579
		public const int File = 65;

		// Token: 0x040015CC RID: 5580
		public const int FillFactor = 66;

		// Token: 0x040015CD RID: 5581
		public const int For = 67;

		// Token: 0x040015CE RID: 5582
		public const int Foreign = 68;

		// Token: 0x040015CF RID: 5583
		public const int FreeText = 69;

		// Token: 0x040015D0 RID: 5584
		public const int FreeTextTable = 70;

		// Token: 0x040015D1 RID: 5585
		public const int From = 71;

		// Token: 0x040015D2 RID: 5586
		public const int Full = 72;

		// Token: 0x040015D3 RID: 5587
		public const int Function = 73;

		// Token: 0x040015D4 RID: 5588
		public const int GoTo = 74;

		// Token: 0x040015D5 RID: 5589
		public const int Grant = 75;

		// Token: 0x040015D6 RID: 5590
		public const int Group = 76;

		// Token: 0x040015D7 RID: 5591
		public const int Having = 77;

		// Token: 0x040015D8 RID: 5592
		public const int HoldLock = 78;

		// Token: 0x040015D9 RID: 5593
		public const int Identity = 79;

		// Token: 0x040015DA RID: 5594
		public const int IdentityInsert = 80;

		// Token: 0x040015DB RID: 5595
		public const int IdentityColumn = 81;

		// Token: 0x040015DC RID: 5596
		public const int If = 82;

		// Token: 0x040015DD RID: 5597
		public const int In = 83;

		// Token: 0x040015DE RID: 5598
		public const int Index = 84;

		// Token: 0x040015DF RID: 5599
		public const int Inner = 85;

		// Token: 0x040015E0 RID: 5600
		public const int Insert = 86;

		// Token: 0x040015E1 RID: 5601
		public const int Intersect = 87;

		// Token: 0x040015E2 RID: 5602
		public const int Into = 88;

		// Token: 0x040015E3 RID: 5603
		public const int Is = 89;

		// Token: 0x040015E4 RID: 5604
		public const int Join = 90;

		// Token: 0x040015E5 RID: 5605
		public const int Key = 91;

		// Token: 0x040015E6 RID: 5606
		public const int Kill = 92;

		// Token: 0x040015E7 RID: 5607
		public const int Left = 93;

		// Token: 0x040015E8 RID: 5608
		public const int Like = 94;

		// Token: 0x040015E9 RID: 5609
		public const int LineNo = 95;

		// Token: 0x040015EA RID: 5610
		public const int National = 96;

		// Token: 0x040015EB RID: 5611
		public const int NoCheck = 97;

		// Token: 0x040015EC RID: 5612
		public const int NonClustered = 98;

		// Token: 0x040015ED RID: 5613
		public const int Not = 99;

		// Token: 0x040015EE RID: 5614
		public const int Null = 100;

		// Token: 0x040015EF RID: 5615
		public const int NullIf = 101;

		// Token: 0x040015F0 RID: 5616
		public const int Of = 102;

		// Token: 0x040015F1 RID: 5617
		public const int Off = 103;

		// Token: 0x040015F2 RID: 5618
		public const int Offsets = 104;

		// Token: 0x040015F3 RID: 5619
		public const int On = 105;

		// Token: 0x040015F4 RID: 5620
		public const int Open = 106;

		// Token: 0x040015F5 RID: 5621
		public const int OpenDataSource = 107;

		// Token: 0x040015F6 RID: 5622
		public const int OpenQuery = 108;

		// Token: 0x040015F7 RID: 5623
		public const int OpenRowSet = 109;

		// Token: 0x040015F8 RID: 5624
		public const int OpenXml = 110;

		// Token: 0x040015F9 RID: 5625
		public const int Option = 111;

		// Token: 0x040015FA RID: 5626
		public const int Or = 112;

		// Token: 0x040015FB RID: 5627
		public const int Order = 113;

		// Token: 0x040015FC RID: 5628
		public const int Outer = 114;

		// Token: 0x040015FD RID: 5629
		public const int Over = 115;

		// Token: 0x040015FE RID: 5630
		public const int Percent = 116;

		// Token: 0x040015FF RID: 5631
		public const int Plan = 117;

		// Token: 0x04001600 RID: 5632
		public const int Primary = 118;

		// Token: 0x04001601 RID: 5633
		public const int Print = 119;

		// Token: 0x04001602 RID: 5634
		public const int Proc = 120;

		// Token: 0x04001603 RID: 5635
		public const int Procedure = 121;

		// Token: 0x04001604 RID: 5636
		public const int Public = 122;

		// Token: 0x04001605 RID: 5637
		public const int Raiserror = 123;

		// Token: 0x04001606 RID: 5638
		public const int Read = 124;

		// Token: 0x04001607 RID: 5639
		public const int ReadText = 125;

		// Token: 0x04001608 RID: 5640
		public const int Reconfigure = 126;

		// Token: 0x04001609 RID: 5641
		public const int References = 127;

		// Token: 0x0400160A RID: 5642
		public const int Replication = 128;

		// Token: 0x0400160B RID: 5643
		public const int Restore = 129;

		// Token: 0x0400160C RID: 5644
		public const int Restrict = 130;

		// Token: 0x0400160D RID: 5645
		public const int Return = 131;

		// Token: 0x0400160E RID: 5646
		public const int Revoke = 132;

		// Token: 0x0400160F RID: 5647
		public const int Right = 133;

		// Token: 0x04001610 RID: 5648
		public const int Rollback = 134;

		// Token: 0x04001611 RID: 5649
		public const int RowCount = 135;

		// Token: 0x04001612 RID: 5650
		public const int RowGuidColumn = 136;

		// Token: 0x04001613 RID: 5651
		public const int Rule = 137;

		// Token: 0x04001614 RID: 5652
		public const int Save = 138;

		// Token: 0x04001615 RID: 5653
		public const int Schema = 139;

		// Token: 0x04001616 RID: 5654
		public const int Select = 140;

		// Token: 0x04001617 RID: 5655
		public const int SessionUser = 141;

		// Token: 0x04001618 RID: 5656
		public const int Set = 142;

		// Token: 0x04001619 RID: 5657
		public const int SetUser = 143;

		// Token: 0x0400161A RID: 5658
		public const int Shutdown = 144;

		// Token: 0x0400161B RID: 5659
		public const int Some = 145;

		// Token: 0x0400161C RID: 5660
		public const int Statistics = 146;

		// Token: 0x0400161D RID: 5661
		public const int SystemUser = 147;

		// Token: 0x0400161E RID: 5662
		public const int Table = 148;

		// Token: 0x0400161F RID: 5663
		public const int TextSize = 149;

		// Token: 0x04001620 RID: 5664
		public const int Then = 150;

		// Token: 0x04001621 RID: 5665
		public const int To = 151;

		// Token: 0x04001622 RID: 5666
		public const int Top = 152;

		// Token: 0x04001623 RID: 5667
		public const int Tran = 153;

		// Token: 0x04001624 RID: 5668
		public const int Transaction = 154;

		// Token: 0x04001625 RID: 5669
		public const int Trigger = 155;

		// Token: 0x04001626 RID: 5670
		public const int Truncate = 156;

		// Token: 0x04001627 RID: 5671
		public const int TSEqual = 157;

		// Token: 0x04001628 RID: 5672
		public const int Union = 158;

		// Token: 0x04001629 RID: 5673
		public const int Unique = 159;

		// Token: 0x0400162A RID: 5674
		public const int Update = 160;

		// Token: 0x0400162B RID: 5675
		public const int UpdateText = 161;

		// Token: 0x0400162C RID: 5676
		public const int Use = 162;

		// Token: 0x0400162D RID: 5677
		public const int User = 163;

		// Token: 0x0400162E RID: 5678
		public const int Values = 164;

		// Token: 0x0400162F RID: 5679
		public const int Varying = 165;

		// Token: 0x04001630 RID: 5680
		public const int View = 166;

		// Token: 0x04001631 RID: 5681
		public const int WaitFor = 167;

		// Token: 0x04001632 RID: 5682
		public const int When = 168;

		// Token: 0x04001633 RID: 5683
		public const int Where = 169;

		// Token: 0x04001634 RID: 5684
		public const int While = 170;

		// Token: 0x04001635 RID: 5685
		public const int With = 171;

		// Token: 0x04001636 RID: 5686
		public const int WriteText = 172;

		// Token: 0x04001637 RID: 5687
		public const int Disk = 173;

		// Token: 0x04001638 RID: 5688
		public const int Precision = 174;

		// Token: 0x04001639 RID: 5689
		public const int External = 175;

		// Token: 0x0400163A RID: 5690
		public const int Revert = 176;

		// Token: 0x0400163B RID: 5691
		public const int Pivot = 177;

		// Token: 0x0400163C RID: 5692
		public const int Unpivot = 178;

		// Token: 0x0400163D RID: 5693
		public const int TableSample = 179;

		// Token: 0x0400163E RID: 5694
		public const int Dump = 180;

		// Token: 0x0400163F RID: 5695
		public const int Load = 181;

		// Token: 0x04001640 RID: 5696
		public const int Merge = 182;

		// Token: 0x04001641 RID: 5697
		public const int StopList = 183;

		// Token: 0x04001642 RID: 5698
		public const int SemanticKeyPhraseTable = 184;

		// Token: 0x04001643 RID: 5699
		public const int SemanticSimilarityTable = 185;

		// Token: 0x04001644 RID: 5700
		public const int SemanticSimilarityDetailsTable = 186;

		// Token: 0x04001645 RID: 5701
		public const int TryConvert = 187;

		// Token: 0x04001646 RID: 5702
		public const int Bang = 188;

		// Token: 0x04001647 RID: 5703
		public const int PercentSign = 189;

		// Token: 0x04001648 RID: 5704
		public const int Ampersand = 190;

		// Token: 0x04001649 RID: 5705
		public const int LeftParenthesis = 191;

		// Token: 0x0400164A RID: 5706
		public const int RightParenthesis = 192;

		// Token: 0x0400164B RID: 5707
		public const int LeftCurly = 193;

		// Token: 0x0400164C RID: 5708
		public const int RightCurly = 194;

		// Token: 0x0400164D RID: 5709
		public const int Star = 195;

		// Token: 0x0400164E RID: 5710
		public const int MultiplyEquals = 196;

		// Token: 0x0400164F RID: 5711
		public const int Plus = 197;

		// Token: 0x04001650 RID: 5712
		public const int Comma = 198;

		// Token: 0x04001651 RID: 5713
		public const int Minus = 199;

		// Token: 0x04001652 RID: 5714
		public const int Dot = 200;

		// Token: 0x04001653 RID: 5715
		public const int Divide = 201;

		// Token: 0x04001654 RID: 5716
		public const int Colon = 202;

		// Token: 0x04001655 RID: 5717
		public const int DoubleColon = 203;

		// Token: 0x04001656 RID: 5718
		public const int Semicolon = 204;

		// Token: 0x04001657 RID: 5719
		public const int LessThan = 205;

		// Token: 0x04001658 RID: 5720
		public const int EqualsSign = 206;

		// Token: 0x04001659 RID: 5721
		public const int RightOuterJoin = 207;

		// Token: 0x0400165A RID: 5722
		public const int GreaterThan = 208;

		// Token: 0x0400165B RID: 5723
		public const int Circumflex = 209;

		// Token: 0x0400165C RID: 5724
		public const int VerticalLine = 210;

		// Token: 0x0400165D RID: 5725
		public const int Tilde = 211;

		// Token: 0x0400165E RID: 5726
		public const int AddEquals = 212;

		// Token: 0x0400165F RID: 5727
		public const int SubtractEquals = 213;

		// Token: 0x04001660 RID: 5728
		public const int DivideEquals = 214;

		// Token: 0x04001661 RID: 5729
		public const int ModEquals = 215;

		// Token: 0x04001662 RID: 5730
		public const int BitwiseAndEquals = 216;

		// Token: 0x04001663 RID: 5731
		public const int BitwiseOrEquals = 217;

		// Token: 0x04001664 RID: 5732
		public const int BitwiseXorEquals = 218;

		// Token: 0x04001665 RID: 5733
		public const int Go = 219;

		// Token: 0x04001666 RID: 5734
		public const int Label = 220;

		// Token: 0x04001667 RID: 5735
		public const int Integer = 221;

		// Token: 0x04001668 RID: 5736
		public const int Numeric = 222;

		// Token: 0x04001669 RID: 5737
		public const int Real = 223;

		// Token: 0x0400166A RID: 5738
		public const int HexLiteral = 224;

		// Token: 0x0400166B RID: 5739
		public const int Money = 225;

		// Token: 0x0400166C RID: 5740
		public const int SqlCommandIdentifier = 226;

		// Token: 0x0400166D RID: 5741
		public const int PseudoColumn = 227;

		// Token: 0x0400166E RID: 5742
		public const int DollarPartition = 228;

		// Token: 0x0400166F RID: 5743
		public const int AsciiStringOrQuotedIdentifier = 229;

		// Token: 0x04001670 RID: 5744
		public const int AsciiStringLiteral = 230;

		// Token: 0x04001671 RID: 5745
		public const int UnicodeStringLiteral = 231;

		// Token: 0x04001672 RID: 5746
		public const int Identifier = 232;

		// Token: 0x04001673 RID: 5747
		public const int QuotedIdentifier = 233;

		// Token: 0x04001674 RID: 5748
		public const int Variable = 234;

		// Token: 0x04001675 RID: 5749
		public const int OdbcInitiator = 235;

		// Token: 0x04001676 RID: 5750
		public const int ProcNameSemicolon = 236;

		// Token: 0x04001677 RID: 5751
		public const int SingleLineComment = 237;

		// Token: 0x04001678 RID: 5752
		public const int MultilineComment = 238;

		// Token: 0x04001679 RID: 5753
		public const int WhiteSpace = 239;

		// Token: 0x0400167A RID: 5754
		public static readonly string[] tokenNames_ = new string[]
		{
			"\"<0>\"",
			"\"EOF\"",
			"\"<2>\"",
			"\"NULL_TREE_LOOKAHEAD\"",
			"\"add\"",
			"\"all\"",
			"\"alter\"",
			"\"and\"",
			"\"any\"",
			"\"as\"",
			"\"asc\"",
			"\"authorization\"",
			"\"backup\"",
			"\"begin\"",
			"\"between\"",
			"\"break\"",
			"\"browse\"",
			"\"bulk\"",
			"\"by\"",
			"\"cascade\"",
			"\"case\"",
			"\"check\"",
			"\"checkpoint\"",
			"\"close\"",
			"\"clustered\"",
			"\"coalesce\"",
			"\"collate\"",
			"\"column\"",
			"\"commit\"",
			"\"compute\"",
			"\"constraint\"",
			"\"contains\"",
			"\"containstable\"",
			"\"continue\"",
			"\"convert\"",
			"\"create\"",
			"\"cross\"",
			"\"current\"",
			"\"current_date\"",
			"\"current_time\"",
			"\"current_timestamp\"",
			"\"current_user\"",
			"\"cursor\"",
			"\"database\"",
			"\"dbcc\"",
			"\"deallocate\"",
			"\"declare\"",
			"\"default\"",
			"\"delete\"",
			"\"deny\"",
			"\"desc\"",
			"\"distinct\"",
			"\"distributed\"",
			"\"double\"",
			"\"drop\"",
			"\"else\"",
			"\"end\"",
			"\"errlvl\"",
			"\"escape\"",
			"\"except\"",
			"\"exec\"",
			"\"execute\"",
			"\"exists\"",
			"\"exit\"",
			"\"fetch\"",
			"\"file\"",
			"\"fillfactor\"",
			"\"for\"",
			"\"foreign\"",
			"\"freetext\"",
			"\"freetexttable\"",
			"\"from\"",
			"\"full\"",
			"\"function\"",
			"\"goto\"",
			"\"grant\"",
			"\"group\"",
			"\"having\"",
			"\"holdlock\"",
			"\"identity\"",
			"\"identity_insert\"",
			"\"identitycol\"",
			"\"if\"",
			"\"in\"",
			"\"index\"",
			"\"inner\"",
			"\"insert\"",
			"\"intersect\"",
			"\"into\"",
			"\"is\"",
			"\"join\"",
			"\"key\"",
			"\"kill\"",
			"\"left\"",
			"\"like\"",
			"\"lineno\"",
			"\"national\"",
			"\"nocheck\"",
			"\"nonclustered\"",
			"\"not\"",
			"\"null\"",
			"\"nullif\"",
			"\"of\"",
			"\"off\"",
			"\"offsets\"",
			"\"on\"",
			"\"open\"",
			"\"opendatasource\"",
			"\"openquery\"",
			"\"openrowset\"",
			"\"openxml\"",
			"\"option\"",
			"\"or\"",
			"\"order\"",
			"\"outer\"",
			"\"over\"",
			"\"percent\"",
			"\"plan\"",
			"\"primary\"",
			"\"print\"",
			"\"proc\"",
			"\"procedure\"",
			"\"public\"",
			"\"raiserror\"",
			"\"read\"",
			"\"readtext\"",
			"\"reconfigure\"",
			"\"references\"",
			"\"replication\"",
			"\"restore\"",
			"\"restrict\"",
			"\"return\"",
			"\"revoke\"",
			"\"right\"",
			"\"rollback\"",
			"\"rowcount\"",
			"\"rowguidcol\"",
			"\"rule\"",
			"\"save\"",
			"\"schema\"",
			"\"select\"",
			"\"session_user\"",
			"\"set\"",
			"\"setuser\"",
			"\"shutdown\"",
			"\"some\"",
			"\"statistics\"",
			"\"system_user\"",
			"\"table\"",
			"\"textsize\"",
			"\"then\"",
			"\"to\"",
			"\"top\"",
			"\"tran\"",
			"\"transaction\"",
			"\"trigger\"",
			"\"truncate\"",
			"\"tsequal\"",
			"\"union\"",
			"\"unique\"",
			"\"update\"",
			"\"updatetext\"",
			"\"use\"",
			"\"user\"",
			"\"values\"",
			"\"varying\"",
			"\"view\"",
			"\"waitfor\"",
			"\"when\"",
			"\"where\"",
			"\"while\"",
			"\"with\"",
			"\"writetext\"",
			"\"Disk\"",
			"\"Precision\"",
			"\"External\"",
			"\"Revert\"",
			"\"Pivot\"",
			"\"Unpivot\"",
			"\"TableSample\"",
			"\"Dump\"",
			"\"Load\"",
			"\"Merge\"",
			"\"StopList\"",
			"\"SemanticKeyPhraseTable\"",
			"\"SemanticSimilarityTable\"",
			"\"SemanticSimilarityDetailsTable\"",
			"\"TryConvert\"",
			"\"Bang\"",
			"\"PercentSign\"",
			"\"Ampersand\"",
			"\"LeftParenthesis\"",
			"\"RightParenthesis\"",
			"\"LeftCurly\"",
			"\"RightCurly\"",
			"\"Star\"",
			"\"MultiplyEquals\"",
			"\"Plus\"",
			"\"Comma\"",
			"\"Minus\"",
			"\"Dot\"",
			"\"Divide\"",
			"\"Colon\"",
			"\"DoubleColon\"",
			"\"Semicolon\"",
			"\"LessThan\"",
			"\"EqualsSign\"",
			"\"RightOuterJoin\"",
			"\"GreaterThan\"",
			"\"Circumflex\"",
			"\"VerticalLine\"",
			"\"Tilde\"",
			"\"AddEquals\"",
			"\"SubtractEquals\"",
			"\"DivideEquals\"",
			"\"ModEquals\"",
			"\"BitwiseAndEquals\"",
			"\"BitwiseOrEquals\"",
			"\"BitwiseXorEquals\"",
			"\"Go\"",
			"\"Label\"",
			"\"Integer\"",
			"\"Numeric\"",
			"\"Real\"",
			"\"HexLiteral\"",
			"\"Money\"",
			"\"SqlCommandIdentifier\"",
			"\"PseudoColumn\"",
			"\"DollarPartition\"",
			"\"AsciiStringOrQuotedIdentifier\"",
			"\"AsciiStringLiteral\"",
			"\"UnicodeStringLiteral\"",
			"\"Identifier\"",
			"\"QuotedIdentifier\"",
			"\"Variable\"",
			"\"OdbcInitiator\"",
			"\"ProcNameSemicolon\"",
			"\"SingleLineComment\"",
			"\"MultilineComment\"",
			"\"WhiteSpace\""
		};

		// Token: 0x0400167B RID: 5755
		public static readonly BitSet tokenSet_0_ = new BitSet(TSql80ParserInternal.mk_tokenSet_0_());

		// Token: 0x0400167C RID: 5756
		public static readonly BitSet tokenSet_1_ = new BitSet(TSql80ParserInternal.mk_tokenSet_1_());

		// Token: 0x0400167D RID: 5757
		public static readonly BitSet tokenSet_2_ = new BitSet(TSql80ParserInternal.mk_tokenSet_2_());

		// Token: 0x0400167E RID: 5758
		public static readonly BitSet tokenSet_3_ = new BitSet(TSql80ParserInternal.mk_tokenSet_3_());

		// Token: 0x0400167F RID: 5759
		public static readonly BitSet tokenSet_4_ = new BitSet(TSql80ParserInternal.mk_tokenSet_4_());

		// Token: 0x04001680 RID: 5760
		public static readonly BitSet tokenSet_5_ = new BitSet(TSql80ParserInternal.mk_tokenSet_5_());

		// Token: 0x04001681 RID: 5761
		public static readonly BitSet tokenSet_6_ = new BitSet(TSql80ParserInternal.mk_tokenSet_6_());

		// Token: 0x04001682 RID: 5762
		public static readonly BitSet tokenSet_7_ = new BitSet(TSql80ParserInternal.mk_tokenSet_7_());

		// Token: 0x04001683 RID: 5763
		public static readonly BitSet tokenSet_8_ = new BitSet(TSql80ParserInternal.mk_tokenSet_8_());

		// Token: 0x04001684 RID: 5764
		public static readonly BitSet tokenSet_9_ = new BitSet(TSql80ParserInternal.mk_tokenSet_9_());

		// Token: 0x04001685 RID: 5765
		public static readonly BitSet tokenSet_10_ = new BitSet(TSql80ParserInternal.mk_tokenSet_10_());

		// Token: 0x04001686 RID: 5766
		public static readonly BitSet tokenSet_11_ = new BitSet(TSql80ParserInternal.mk_tokenSet_11_());

		// Token: 0x04001687 RID: 5767
		public static readonly BitSet tokenSet_12_ = new BitSet(TSql80ParserInternal.mk_tokenSet_12_());

		// Token: 0x04001688 RID: 5768
		public static readonly BitSet tokenSet_13_ = new BitSet(TSql80ParserInternal.mk_tokenSet_13_());

		// Token: 0x04001689 RID: 5769
		public static readonly BitSet tokenSet_14_ = new BitSet(TSql80ParserInternal.mk_tokenSet_14_());

		// Token: 0x0400168A RID: 5770
		public static readonly BitSet tokenSet_15_ = new BitSet(TSql80ParserInternal.mk_tokenSet_15_());

		// Token: 0x0400168B RID: 5771
		public static readonly BitSet tokenSet_16_ = new BitSet(TSql80ParserInternal.mk_tokenSet_16_());

		// Token: 0x0400168C RID: 5772
		public static readonly BitSet tokenSet_17_ = new BitSet(TSql80ParserInternal.mk_tokenSet_17_());

		// Token: 0x0400168D RID: 5773
		public static readonly BitSet tokenSet_18_ = new BitSet(TSql80ParserInternal.mk_tokenSet_18_());

		// Token: 0x0400168E RID: 5774
		public static readonly BitSet tokenSet_19_ = new BitSet(TSql80ParserInternal.mk_tokenSet_19_());

		// Token: 0x0400168F RID: 5775
		public static readonly BitSet tokenSet_20_ = new BitSet(TSql80ParserInternal.mk_tokenSet_20_());

		// Token: 0x04001690 RID: 5776
		public static readonly BitSet tokenSet_21_ = new BitSet(TSql80ParserInternal.mk_tokenSet_21_());

		// Token: 0x04001691 RID: 5777
		public static readonly BitSet tokenSet_22_ = new BitSet(TSql80ParserInternal.mk_tokenSet_22_());

		// Token: 0x04001692 RID: 5778
		public static readonly BitSet tokenSet_23_ = new BitSet(TSql80ParserInternal.mk_tokenSet_23_());

		// Token: 0x04001693 RID: 5779
		public static readonly BitSet tokenSet_24_ = new BitSet(TSql80ParserInternal.mk_tokenSet_24_());

		// Token: 0x04001694 RID: 5780
		public static readonly BitSet tokenSet_25_ = new BitSet(TSql80ParserInternal.mk_tokenSet_25_());

		// Token: 0x04001695 RID: 5781
		public static readonly BitSet tokenSet_26_ = new BitSet(TSql80ParserInternal.mk_tokenSet_26_());

		// Token: 0x04001696 RID: 5782
		public static readonly BitSet tokenSet_27_ = new BitSet(TSql80ParserInternal.mk_tokenSet_27_());

		// Token: 0x04001697 RID: 5783
		public static readonly BitSet tokenSet_28_ = new BitSet(TSql80ParserInternal.mk_tokenSet_28_());

		// Token: 0x04001698 RID: 5784
		public static readonly BitSet tokenSet_29_ = new BitSet(TSql80ParserInternal.mk_tokenSet_29_());

		// Token: 0x04001699 RID: 5785
		public static readonly BitSet tokenSet_30_ = new BitSet(TSql80ParserInternal.mk_tokenSet_30_());

		// Token: 0x0400169A RID: 5786
		public static readonly BitSet tokenSet_31_ = new BitSet(TSql80ParserInternal.mk_tokenSet_31_());

		// Token: 0x0400169B RID: 5787
		public static readonly BitSet tokenSet_32_ = new BitSet(TSql80ParserInternal.mk_tokenSet_32_());

		// Token: 0x0400169C RID: 5788
		public static readonly BitSet tokenSet_33_ = new BitSet(TSql80ParserInternal.mk_tokenSet_33_());

		// Token: 0x0400169D RID: 5789
		public static readonly BitSet tokenSet_34_ = new BitSet(TSql80ParserInternal.mk_tokenSet_34_());

		// Token: 0x0400169E RID: 5790
		public static readonly BitSet tokenSet_35_ = new BitSet(TSql80ParserInternal.mk_tokenSet_35_());

		// Token: 0x0400169F RID: 5791
		public static readonly BitSet tokenSet_36_ = new BitSet(TSql80ParserInternal.mk_tokenSet_36_());

		// Token: 0x040016A0 RID: 5792
		public static readonly BitSet tokenSet_37_ = new BitSet(TSql80ParserInternal.mk_tokenSet_37_());

		// Token: 0x040016A1 RID: 5793
		public static readonly BitSet tokenSet_38_ = new BitSet(TSql80ParserInternal.mk_tokenSet_38_());

		// Token: 0x040016A2 RID: 5794
		public static readonly BitSet tokenSet_39_ = new BitSet(TSql80ParserInternal.mk_tokenSet_39_());

		// Token: 0x040016A3 RID: 5795
		public static readonly BitSet tokenSet_40_ = new BitSet(TSql80ParserInternal.mk_tokenSet_40_());

		// Token: 0x040016A4 RID: 5796
		public static readonly BitSet tokenSet_41_ = new BitSet(TSql80ParserInternal.mk_tokenSet_41_());

		// Token: 0x040016A5 RID: 5797
		public static readonly BitSet tokenSet_42_ = new BitSet(TSql80ParserInternal.mk_tokenSet_42_());

		// Token: 0x040016A6 RID: 5798
		public static readonly BitSet tokenSet_43_ = new BitSet(TSql80ParserInternal.mk_tokenSet_43_());

		// Token: 0x040016A7 RID: 5799
		public static readonly BitSet tokenSet_44_ = new BitSet(TSql80ParserInternal.mk_tokenSet_44_());

		// Token: 0x040016A8 RID: 5800
		public static readonly BitSet tokenSet_45_ = new BitSet(TSql80ParserInternal.mk_tokenSet_45_());

		// Token: 0x040016A9 RID: 5801
		public static readonly BitSet tokenSet_46_ = new BitSet(TSql80ParserInternal.mk_tokenSet_46_());

		// Token: 0x040016AA RID: 5802
		public static readonly BitSet tokenSet_47_ = new BitSet(TSql80ParserInternal.mk_tokenSet_47_());

		// Token: 0x040016AB RID: 5803
		public static readonly BitSet tokenSet_48_ = new BitSet(TSql80ParserInternal.mk_tokenSet_48_());

		// Token: 0x040016AC RID: 5804
		public static readonly BitSet tokenSet_49_ = new BitSet(TSql80ParserInternal.mk_tokenSet_49_());

		// Token: 0x040016AD RID: 5805
		public static readonly BitSet tokenSet_50_ = new BitSet(TSql80ParserInternal.mk_tokenSet_50_());

		// Token: 0x040016AE RID: 5806
		public static readonly BitSet tokenSet_51_ = new BitSet(TSql80ParserInternal.mk_tokenSet_51_());

		// Token: 0x040016AF RID: 5807
		public static readonly BitSet tokenSet_52_ = new BitSet(TSql80ParserInternal.mk_tokenSet_52_());

		// Token: 0x040016B0 RID: 5808
		public static readonly BitSet tokenSet_53_ = new BitSet(TSql80ParserInternal.mk_tokenSet_53_());

		// Token: 0x040016B1 RID: 5809
		public static readonly BitSet tokenSet_54_ = new BitSet(TSql80ParserInternal.mk_tokenSet_54_());

		// Token: 0x040016B2 RID: 5810
		public static readonly BitSet tokenSet_55_ = new BitSet(TSql80ParserInternal.mk_tokenSet_55_());

		// Token: 0x040016B3 RID: 5811
		public static readonly BitSet tokenSet_56_ = new BitSet(TSql80ParserInternal.mk_tokenSet_56_());

		// Token: 0x040016B4 RID: 5812
		public static readonly BitSet tokenSet_57_ = new BitSet(TSql80ParserInternal.mk_tokenSet_57_());

		// Token: 0x040016B5 RID: 5813
		public static readonly BitSet tokenSet_58_ = new BitSet(TSql80ParserInternal.mk_tokenSet_58_());

		// Token: 0x040016B6 RID: 5814
		public static readonly BitSet tokenSet_59_ = new BitSet(TSql80ParserInternal.mk_tokenSet_59_());

		// Token: 0x040016B7 RID: 5815
		public static readonly BitSet tokenSet_60_ = new BitSet(TSql80ParserInternal.mk_tokenSet_60_());

		// Token: 0x040016B8 RID: 5816
		public static readonly BitSet tokenSet_61_ = new BitSet(TSql80ParserInternal.mk_tokenSet_61_());

		// Token: 0x040016B9 RID: 5817
		public static readonly BitSet tokenSet_62_ = new BitSet(TSql80ParserInternal.mk_tokenSet_62_());

		// Token: 0x040016BA RID: 5818
		public static readonly BitSet tokenSet_63_ = new BitSet(TSql80ParserInternal.mk_tokenSet_63_());

		// Token: 0x040016BB RID: 5819
		public static readonly BitSet tokenSet_64_ = new BitSet(TSql80ParserInternal.mk_tokenSet_64_());

		// Token: 0x040016BC RID: 5820
		public static readonly BitSet tokenSet_65_ = new BitSet(TSql80ParserInternal.mk_tokenSet_65_());

		// Token: 0x040016BD RID: 5821
		public static readonly BitSet tokenSet_66_ = new BitSet(TSql80ParserInternal.mk_tokenSet_66_());

		// Token: 0x040016BE RID: 5822
		public static readonly BitSet tokenSet_67_ = new BitSet(TSql80ParserInternal.mk_tokenSet_67_());

		// Token: 0x040016BF RID: 5823
		public static readonly BitSet tokenSet_68_ = new BitSet(TSql80ParserInternal.mk_tokenSet_68_());

		// Token: 0x040016C0 RID: 5824
		public static readonly BitSet tokenSet_69_ = new BitSet(TSql80ParserInternal.mk_tokenSet_69_());

		// Token: 0x040016C1 RID: 5825
		public static readonly BitSet tokenSet_70_ = new BitSet(TSql80ParserInternal.mk_tokenSet_70_());

		// Token: 0x040016C2 RID: 5826
		public static readonly BitSet tokenSet_71_ = new BitSet(TSql80ParserInternal.mk_tokenSet_71_());

		// Token: 0x040016C3 RID: 5827
		public static readonly BitSet tokenSet_72_ = new BitSet(TSql80ParserInternal.mk_tokenSet_72_());

		// Token: 0x040016C4 RID: 5828
		public static readonly BitSet tokenSet_73_ = new BitSet(TSql80ParserInternal.mk_tokenSet_73_());

		// Token: 0x040016C5 RID: 5829
		public static readonly BitSet tokenSet_74_ = new BitSet(TSql80ParserInternal.mk_tokenSet_74_());

		// Token: 0x040016C6 RID: 5830
		public static readonly BitSet tokenSet_75_ = new BitSet(TSql80ParserInternal.mk_tokenSet_75_());

		// Token: 0x040016C7 RID: 5831
		public static readonly BitSet tokenSet_76_ = new BitSet(TSql80ParserInternal.mk_tokenSet_76_());

		// Token: 0x040016C8 RID: 5832
		public static readonly BitSet tokenSet_77_ = new BitSet(TSql80ParserInternal.mk_tokenSet_77_());

		// Token: 0x040016C9 RID: 5833
		public static readonly BitSet tokenSet_78_ = new BitSet(TSql80ParserInternal.mk_tokenSet_78_());

		// Token: 0x040016CA RID: 5834
		public static readonly BitSet tokenSet_79_ = new BitSet(TSql80ParserInternal.mk_tokenSet_79_());

		// Token: 0x040016CB RID: 5835
		public static readonly BitSet tokenSet_80_ = new BitSet(TSql80ParserInternal.mk_tokenSet_80_());

		// Token: 0x040016CC RID: 5836
		public static readonly BitSet tokenSet_81_ = new BitSet(TSql80ParserInternal.mk_tokenSet_81_());

		// Token: 0x040016CD RID: 5837
		public static readonly BitSet tokenSet_82_ = new BitSet(TSql80ParserInternal.mk_tokenSet_82_());

		// Token: 0x040016CE RID: 5838
		public static readonly BitSet tokenSet_83_ = new BitSet(TSql80ParserInternal.mk_tokenSet_83_());

		// Token: 0x040016CF RID: 5839
		public static readonly BitSet tokenSet_84_ = new BitSet(TSql80ParserInternal.mk_tokenSet_84_());

		// Token: 0x040016D0 RID: 5840
		public static readonly BitSet tokenSet_85_ = new BitSet(TSql80ParserInternal.mk_tokenSet_85_());

		// Token: 0x040016D1 RID: 5841
		public static readonly BitSet tokenSet_86_ = new BitSet(TSql80ParserInternal.mk_tokenSet_86_());

		// Token: 0x040016D2 RID: 5842
		public static readonly BitSet tokenSet_87_ = new BitSet(TSql80ParserInternal.mk_tokenSet_87_());
	}
}
