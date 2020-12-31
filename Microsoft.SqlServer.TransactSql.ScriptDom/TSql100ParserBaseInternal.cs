using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using antlr;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200016C RID: 364
	internal abstract class TSql100ParserBaseInternal : TSql90ParserBaseInternal
	{
		// Token: 0x06000A51 RID: 2641 RVA: 0x000197E8 File Offset: 0x000179E8
		protected TSql100ParserBaseInternal(TokenBuffer tokenBuf, int k) : base(tokenBuf, k)
		{
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x000197F2 File Offset: 0x000179F2
		protected TSql100ParserBaseInternal(ParserSharedInputState state, int k) : base(state, k)
		{
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x000197FC File Offset: 0x000179FC
		protected TSql100ParserBaseInternal(TokenStream lexer, int k) : base(lexer, k)
		{
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x00019806 File Offset: 0x00017A06
		public TSql100ParserBaseInternal(bool initialQuotedIdentifiersOn) : base(initialQuotedIdentifiersOn)
		{
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x00019810 File Offset: 0x00017A10
		protected AutoCleanupChangeTrackingOptionDetail CreateAutoCleanupDetail(IToken firstToken, IToken lastToken, ref bool autoCleanupEncountered)
		{
			TSql80ParserBaseInternal.Match(firstToken, "AUTO_CLEANUP");
			if (autoCleanupEncountered)
			{
				TSql80ParserBaseInternal.ThrowParseErrorException("SQL46050", firstToken, TSqlParserResource.SQL46050Message, new string[]
				{
					firstToken.getText()
				});
			}
			autoCleanupEncountered = true;
			AutoCleanupChangeTrackingOptionDetail autoCleanupChangeTrackingOptionDetail = base.FragmentFactory.CreateFragment<AutoCleanupChangeTrackingOptionDetail>();
			TSql80ParserBaseInternal.UpdateTokenInfo(autoCleanupChangeTrackingOptionDetail, firstToken);
			TSql80ParserBaseInternal.UpdateTokenInfo(autoCleanupChangeTrackingOptionDetail, lastToken);
			autoCleanupChangeTrackingOptionDetail.IsOn = (lastToken.Type == 105);
			return autoCleanupChangeTrackingOptionDetail;
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x0001987C File Offset: 0x00017A7C
		protected static SqlDataTypeOption ParseDataType100(string token)
		{
			string a;
			if ((a = token.ToUpperInvariant()) != null)
			{
				if (a == "DATE")
				{
					return SqlDataTypeOption.Date;
				}
				if (a == "TIME")
				{
					return SqlDataTypeOption.Time;
				}
				if (a == "DATETIME2")
				{
					return SqlDataTypeOption.DateTime2;
				}
				if (a == "DATETIMEOFFSET")
				{
					return SqlDataTypeOption.DateTimeOffset;
				}
			}
			return TSql80ParserBaseInternal.ParseDataType(token);
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x000198DB File Offset: 0x00017ADB
		protected static void CheckBrokerPriorityParameterDuplication(int current, BrokerPriorityParameterType newOption, IToken token)
		{
			if ((current & 1 << (int)newOption) != 0)
			{
				TSql80ParserBaseInternal.ThrowIncorrectSyntaxErrorException(token);
			}
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x000198ED File Offset: 0x00017AED
		protected static void UpdateBrokerPriorityEncounteredOptions(ref int encountered, BrokerPriorityParameter vBrokerPriorityParameter)
		{
			encountered |= 1 << (int)vBrokerPriorityParameter.ParameterType;
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x000198FF File Offset: 0x00017AFF
		protected static void CheckBoundingBoxParameterDuplication(int current, BoundingBoxParameterType newOption, IToken token)
		{
			if ((current & 1 << (int)newOption) != 0)
			{
				TSql80ParserBaseInternal.ThrowIncorrectSyntaxErrorException(token);
			}
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x00019911 File Offset: 0x00017B11
		protected static void UpdateBoundingBoxParameterEncounteredOptions(ref int encountered, BoundingBoxParameter vBoundingBoxParameter)
		{
			encountered |= 1 << (int)vBoundingBoxParameter.Parameter;
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x00019924 File Offset: 0x00017B24
		protected static void CheckIfValidSpatialIndexOptionValue(IndexAffectingStatement statement, IndexOption option)
		{
			IndexStateOption indexStateOption = option as IndexStateOption;
			if (indexStateOption != null && indexStateOption.OptionKind == IndexOptionKind.IgnoreDupKey && indexStateOption.OptionState == OptionState.On)
			{
				TSql80ParserBaseInternal.ThrowWrongIndexOptionError(statement, indexStateOption);
			}
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x00019954 File Offset: 0x00017B54
		protected static void SetFileStreamStorageOption(ColumnStorageOptions storageOptions, IToken fileStreamToken, DataTypeReference columnType, IndexAffectingStatement statementType)
		{
			if (statementType != IndexAffectingStatement.AlterTableAddElement && statementType != IndexAffectingStatement.CreateTable)
			{
				TSql80ParserBaseInternal.ThrowIncorrectSyntaxErrorException(fileStreamToken);
				return;
			}
			SqlDataTypeReference sqlDataTypeReference = columnType as SqlDataTypeReference;
			if (sqlDataTypeReference != null && sqlDataTypeReference.SqlDataTypeOption == SqlDataTypeOption.VarBinary && sqlDataTypeReference.Parameters.Count == 1 && sqlDataTypeReference.Parameters[0].LiteralType == LiteralType.Max)
			{
				storageOptions.IsFileStream = true;
				return;
			}
			TSql80ParserBaseInternal.ThrowParseErrorException("SQL46051", fileStreamToken, TSqlParserResource.SQL46051Message, new string[0]);
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x000199C4 File Offset: 0x00017BC4
		protected static void SetSparseStorageOption(ColumnStorageOptions columnStorage, SparseColumnOption option, IToken token, IndexAffectingStatement statementType)
		{
			if (statementType != IndexAffectingStatement.AlterTableAddElement)
			{
				switch (statementType)
				{
				case IndexAffectingStatement.CreateTable:
				case IndexAffectingStatement.CreateOrAlterFunction:
				case IndexAffectingStatement.DeclareTableVariable:
					goto IL_25;
				}
				TSql80ParserBaseInternal.ThrowIncorrectSyntaxErrorException(token);
				return;
			}
			IL_25:
			if (statementType == IndexAffectingStatement.CreateOrAlterFunction && option == SparseColumnOption.ColumnSetForAllSparseColumns)
			{
				TSql80ParserBaseInternal.ThrowIncorrectSyntaxErrorException(token);
			}
			columnStorage.SparseOption = option;
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x00019A14 File Offset: 0x00017C14
		protected static void CheckComparisonOperandForIndexFilter(ScalarExpression rightOperand, bool convertAllowed)
		{
			UnaryExpression unaryExpression = rightOperand as UnaryExpression;
			if (unaryExpression != null)
			{
				TSql100ParserBaseInternal.CheckComparisonOperandForIndexFilter(unaryExpression.Expression, convertAllowed);
				return;
			}
			Literal literal = rightOperand as Literal;
			if (literal != null && literal.LiteralType != LiteralType.Max)
			{
				return;
			}
			ParenthesisExpression parenthesisExpression = rightOperand as ParenthesisExpression;
			if (parenthesisExpression != null)
			{
				TSql100ParserBaseInternal.CheckComparisonOperandForIndexFilter(parenthesisExpression.Expression, convertAllowed);
				return;
			}
			if (convertAllowed)
			{
				ConvertCall convertCall = rightOperand as ConvertCall;
				if (convertCall != null)
				{
					TSql100ParserBaseInternal.CheckComparisonOperandForIndexFilter(convertCall.Parameter, false);
					return;
				}
				CastCall castCall = rightOperand as CastCall;
				if (castCall != null)
				{
					TSql100ParserBaseInternal.CheckComparisonOperandForIndexFilter(castCall.Parameter, false);
					return;
				}
			}
			TSql80ParserBaseInternal.ThrowParseErrorException("SQL46059", rightOperand, TSqlParserResource.SQL46059Message, new string[0]);
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x00019AB0 File Offset: 0x00017CB0
		protected static void CheckPartitionAllSpecifiedForIndexRebuild(PartitionSpecifier partitionSpecifier, IList<IndexOption> indexOptions)
		{
			if (partitionSpecifier == null)
			{
				foreach (IndexOption indexOption in indexOptions)
				{
					DataCompressionOption dataCompressionOption = indexOption as DataCompressionOption;
					if (dataCompressionOption != null && dataCompressionOption.PartitionRanges.Count > 0)
					{
						TSql80ParserBaseInternal.ThrowParseErrorException("SQL46061", indexOption, TSqlParserResource.SQL46061Message, new string[0]);
					}
				}
			}
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x00019B24 File Offset: 0x00017D24
		protected static void ThrowIfWrongGuidFormat(Literal literal)
		{
			string pattern = "[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}";
			if (!Regex.IsMatch(literal.Value, pattern, RegexOptions.CultureInvariant))
			{
				TSql80ParserBaseInternal.ThrowParseErrorException("SQL46055", literal, TSqlParserResource.SQL46055Message, new string[0]);
			}
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x00019B60 File Offset: 0x00017D60
		protected static void ThrowIfTooLargeAuditFileSize(Literal size, int shift)
		{
			ulong num;
			if (!ulong.TryParse(size.Value, NumberStyles.Integer, CultureInfo.InvariantCulture, out num) || num > 18446744073709551615UL >> 20 + shift)
			{
				TSql80ParserBaseInternal.ThrowParseErrorException("SQL46054", size, TSqlParserResource.SQL46054Message, new string[0]);
			}
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x00019BA8 File Offset: 0x00017DA8
		protected static void CheckForCellsPerObjectValueRange(Literal value)
		{
			int num;
			if (!int.TryParse(value.Value, NumberStyles.Integer, CultureInfo.InvariantCulture, out num) || num < 1 || num > 8192)
			{
				TSql80ParserBaseInternal.ThrowParseErrorException("SQL46073", value, TSqlParserResource.SQL46073Message, new string[]
				{
					value.Value
				});
			}
		}
	}
}
