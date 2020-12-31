using System;
using System.Globalization;
using antlr;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200016B RID: 363
	internal abstract class TSql90ParserBaseInternal : TSql80ParserBaseInternal
	{
		// Token: 0x06000A2E RID: 2606 RVA: 0x00018E9C File Offset: 0x0001709C
		protected TSql90ParserBaseInternal(TokenBuffer tokenBuf, int k) : base(tokenBuf, k)
		{
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x00018EA6 File Offset: 0x000170A6
		protected TSql90ParserBaseInternal(ParserSharedInputState state, int k) : base(state, k)
		{
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x00018EB0 File Offset: 0x000170B0
		protected TSql90ParserBaseInternal(TokenStream lexer, int k) : base(lexer, k)
		{
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x00018EBA File Offset: 0x000170BA
		public TSql90ParserBaseInternal(bool initialQuotedIdentifiersOn) : base(initialQuotedIdentifiersOn)
		{
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x00018EC4 File Offset: 0x000170C4
		protected static AuthenticationTypes AggregateAuthenticationType(AuthenticationTypes current, AuthenticationTypes newOption, IToken token)
		{
			AuthenticationTypes authenticationTypes = current | newOption;
			if (authenticationTypes == current)
			{
				throw TSql80ParserBaseInternal.GetUnexpectedTokenErrorException(token);
			}
			return authenticationTypes;
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x00018EE1 File Offset: 0x000170E1
		protected static void CheckForFormatFileOptionInOpenRowsetBulk(int encounteredOptions, TSqlFragment relatedFragment)
		{
			if ((encounteredOptions & 3670272) == 0)
			{
				TSql80ParserBaseInternal.ThrowParseErrorException("SQL46082", relatedFragment, TSqlParserResource.SQL46082Message, new string[0]);
			}
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x00018F04 File Offset: 0x00017104
		protected static PortTypes AggregatePortType(PortTypes current, PortTypes newOption, IToken token)
		{
			PortTypes portTypes = current | newOption;
			if (portTypes == current)
			{
				throw TSql80ParserBaseInternal.GetUnexpectedTokenErrorException(token);
			}
			return portTypes;
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x00018F21 File Offset: 0x00017121
		protected static void CheckCertificateOptionDupication(CertificateOptionKinds current, CertificateOptionKinds newOption, IToken token)
		{
			if ((current & newOption) == newOption)
			{
				throw TSql80ParserBaseInternal.GetUnexpectedTokenErrorException(token);
			}
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x00018F30 File Offset: 0x00017130
		protected static void CheckIfEndpointOptionAllowed(EndpointProtocolOptions current, EndpointProtocolOptions newOption, EndpointProtocol protocol, IToken token)
		{
			if ((current & newOption) == newOption)
			{
				throw TSql80ParserBaseInternal.GetUnexpectedTokenErrorException(token);
			}
			if ((protocol == EndpointProtocol.Tcp && (newOption & EndpointProtocolOptions.TcpOptions) != newOption) || (protocol == EndpointProtocol.Http && (newOption & EndpointProtocolOptions.HttpOptions) != newOption))
			{
				throw TSql80ParserBaseInternal.GetUnexpectedTokenErrorException(token);
			}
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x00018F64 File Offset: 0x00017164
		protected static void CheckIfPayloadOptionAllowed(PayloadOptionKinds current, PayloadOptionKinds newOption, EndpointType endpointType, IToken token)
		{
			if (endpointType == EndpointType.TSql)
			{
				throw TSql80ParserBaseInternal.GetUnexpectedTokenErrorException(token);
			}
			if ((endpointType == EndpointType.Soap && (newOption & PayloadOptionKinds.SoapOptions) != newOption) || (endpointType == EndpointType.DatabaseMirroring && (newOption & PayloadOptionKinds.DatabaseMirroringOptions) != newOption) || (endpointType == EndpointType.ServiceBroker && (newOption & PayloadOptionKinds.ServiceBrokerOptions) != newOption))
			{
				throw TSql80ParserBaseInternal.GetUnexpectedTokenErrorException(token);
			}
			if ((current & newOption) == newOption && newOption != PayloadOptionKinds.WebMethod)
			{
				throw TSql80ParserBaseInternal.GetUnexpectedTokenErrorException(token);
			}
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x00018FC0 File Offset: 0x000171C0
		protected static SecurityObjectKind ParseSecurityObjectKind(Identifier identifier)
		{
			string key;
			switch (key = identifier.Value.ToUpperInvariant())
			{
			case "ASSEMBLY":
				return SecurityObjectKind.Assembly;
			case "CERTIFICATE":
				return SecurityObjectKind.Certificate;
			case "CONTRACT":
				return SecurityObjectKind.Contract;
			case "DATABASE":
				return SecurityObjectKind.Database;
			case "ENDPOINT":
				return SecurityObjectKind.Endpoint;
			case "LOGIN":
				return SecurityObjectKind.Login;
			case "OBJECT":
				return SecurityObjectKind.Object;
			case "ROLE":
				return SecurityObjectKind.Role;
			case "ROUTE":
				return SecurityObjectKind.Route;
			case "SCHEMA":
				return SecurityObjectKind.Schema;
			case "SERVER":
				return SecurityObjectKind.Server;
			case "SERVICE":
				return SecurityObjectKind.Service;
			case "TYPE":
				return SecurityObjectKind.Type;
			case "USER":
				return SecurityObjectKind.User;
			}
			throw TSql80ParserBaseInternal.GetUnexpectedTokenErrorException(identifier);
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x00019124 File Offset: 0x00017324
		protected static SecurityObjectKind ParseSecurityObjectKind(Identifier identifier1, Identifier identifier2)
		{
			string key;
			switch (key = identifier1.Value.ToUpperInvariant())
			{
			case "APPLICATION":
				TSql80ParserBaseInternal.Match(identifier2, "ROLE");
				return SecurityObjectKind.ApplicationRole;
			case "ASYMMETRIC":
				TSql80ParserBaseInternal.Match(identifier2, "KEY");
				return SecurityObjectKind.AsymmetricKey;
			case "AVAILABILITY":
				TSql80ParserBaseInternal.Match(identifier2, "GROUP");
				return SecurityObjectKind.AvailabilityGroup;
			case "FULLTEXT":
				if (TSql80ParserBaseInternal.TryMatch(identifier2, "CATALOG"))
				{
					return SecurityObjectKind.FullTextCatalog;
				}
				TSql80ParserBaseInternal.Match(identifier2, "STOPLIST");
				return SecurityObjectKind.FullTextStopList;
			case "MESSAGE":
				TSql80ParserBaseInternal.Match(identifier2, "TYPE");
				return SecurityObjectKind.MessageType;
			case "SERVER":
				TSql80ParserBaseInternal.Match(identifier2, "ROLE");
				return SecurityObjectKind.ServerRole;
			case "SYMMETRIC":
				TSql80ParserBaseInternal.Match(identifier2, "KEY");
				return SecurityObjectKind.SymmetricKey;
			}
			throw TSql80ParserBaseInternal.GetUnexpectedTokenErrorException(identifier1);
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x0001925C File Offset: 0x0001745C
		protected static SecurityObjectKind ParseSecurityObjectKind(Identifier identifier1, Identifier identifier2, Identifier identifier3)
		{
			string a;
			if ((a = identifier1.Value.ToUpperInvariant()) != null)
			{
				if (a == "XML")
				{
					TSql80ParserBaseInternal.Match(identifier2, "SCHEMA");
					TSql80ParserBaseInternal.Match(identifier3, "COLLECTION");
					return SecurityObjectKind.XmlSchemaCollection;
				}
				if (a == "REMOTE")
				{
					TSql80ParserBaseInternal.Match(identifier2, "SERVICE");
					TSql80ParserBaseInternal.Match(identifier3, "BINDING");
					return SecurityObjectKind.RemoteServiceBinding;
				}
				if (a == "SEARCH")
				{
					TSql80ParserBaseInternal.Match(identifier2, "PROPERTY");
					TSql80ParserBaseInternal.Match(identifier3, "LIST");
					return SecurityObjectKind.SearchPropertyList;
				}
			}
			throw TSql80ParserBaseInternal.GetUnexpectedTokenErrorException(identifier1);
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x000192F2 File Offset: 0x000174F2
		protected static bool IsXml(Identifier identifier)
		{
			return string.Equals(identifier.Value, "XML", StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x00019305 File Offset: 0x00017505
		protected static bool IsSys(Identifier identifier)
		{
			return string.Equals(identifier.Value, "SYS", StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x00019318 File Offset: 0x00017518
		protected bool IsStatementIsNext()
		{
			return this.LA(1) != 56 || base.NextTokenMatches("CONVERSATION", 2);
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x00019334 File Offset: 0x00017534
		public static string Unquote(string value)
		{
			if (string.IsNullOrEmpty(value))
			{
				return value;
			}
			int num = value.IndexOf('\'');
			int num2 = value.LastIndexOf('\'');
			string result = value;
			if (num == -1 || num2 == num)
			{
				return result;
			}
			if (num < 2 && num2 != num && num2 == value.Length - 1)
			{
				if (num == 1)
				{
					if (value[0] == 'N')
					{
						result = value.Substring(num + 1, num2 - num - 1);
					}
				}
				else
				{
					result = value.Substring(num + 1, num2 - num);
				}
			}
			return result;
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x000193AC File Offset: 0x000175AC
		protected static EncryptionAlgorithmPreference RecognizeAesOrRc4(Identifier id, IToken tokenForError)
		{
			string a = TSql90ParserBaseInternal.Unquote(id.Value);
			if (string.Equals(a, "AES", StringComparison.OrdinalIgnoreCase))
			{
				return EncryptionAlgorithmPreference.Aes;
			}
			if (string.Equals(a, "RC4", StringComparison.OrdinalIgnoreCase))
			{
				return EncryptionAlgorithmPreference.Rc4;
			}
			throw new TSqlParseErrorException(TSql80ParserBaseInternal.GetUnexpectedTokenError(tokenForError));
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x000193F0 File Offset: 0x000175F0
		protected static AuthenticationProtocol RecognizeAuthenticationProtocol(Identifier id, IToken tokenForError)
		{
			string a = TSql90ParserBaseInternal.Unquote(id.Value);
			if (string.Equals(a, "NTLM", StringComparison.OrdinalIgnoreCase))
			{
				return AuthenticationProtocol.WindowsNtlm;
			}
			if (string.Equals(a, "KERBEROS", StringComparison.OrdinalIgnoreCase))
			{
				return AuthenticationProtocol.WindowsKerberos;
			}
			if (string.Equals(a, "NEGOTIATE", StringComparison.OrdinalIgnoreCase))
			{
				return AuthenticationProtocol.WindowsNegotiate;
			}
			throw new TSqlParseErrorException(TSql80ParserBaseInternal.GetUnexpectedTokenError(tokenForError));
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x00019444 File Offset: 0x00017644
		protected static void RecognizeAlterLoginSecAdminPasswordOption(IToken token, PasswordAlterPrincipalOption astNode)
		{
			if (TSql80ParserBaseInternal.TryMatch(token, "MUST_CHANGE"))
			{
				if (astNode.MustChange)
				{
					throw TSql80ParserBaseInternal.GetUnexpectedTokenErrorException(token);
				}
				astNode.MustChange = true;
			}
			else if (TSql80ParserBaseInternal.TryMatch(token, "HASHED"))
			{
				if (astNode.Hashed)
				{
					throw TSql80ParserBaseInternal.GetUnexpectedTokenErrorException(token);
				}
				astNode.Hashed = true;
			}
			else
			{
				TSql80ParserBaseInternal.Match(token, "UNLOCK");
				if (astNode.Unlock)
				{
					throw TSql80ParserBaseInternal.GetUnexpectedTokenErrorException(token);
				}
				astNode.Unlock = true;
			}
			TSql80ParserBaseInternal.UpdateTokenInfo(astNode, token);
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x000194C3 File Offset: 0x000176C3
		protected static TValue EnableDisableMatcher<TValue>(IToken token, TValue enableValue, TValue disableValue)
		{
			if (TSql80ParserBaseInternal.TryMatch(token, "ENABLE"))
			{
				return enableValue;
			}
			TSql80ParserBaseInternal.Match(token, "DISABLE");
			return disableValue;
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x000194E0 File Offset: 0x000176E0
		protected static void AddConstraintToComputedColumn(ConstraintDefinition constraint, ColumnDefinition column)
		{
			bool flag = false;
			if (constraint is NullableConstraintDefinition)
			{
				NullableConstraintDefinition nullableConstraintDefinition = (NullableConstraintDefinition)constraint;
				flag = nullableConstraintDefinition.Nullable;
			}
			if ((!column.IsPersisted && !(constraint is UniqueConstraintDefinition)) || (column.IsPersisted && flag))
			{
				TSql80ParserBaseInternal.ThrowParseErrorException("SQL46011", constraint, TSqlParserResource.SQL46011Message, new string[0]);
			}
			TSql80ParserBaseInternal.AddAndUpdateTokenInfo<ConstraintDefinition>(column, column.Constraints, constraint);
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x00019543 File Offset: 0x00017743
		protected static IndexAffectingStatement GetAlterIndexStatementKind(AlterIndexStatement alterIndex)
		{
			if (alterIndex.AlterIndexType == AlterIndexType.Reorganize)
			{
				return IndexAffectingStatement.AlterIndexReorganize;
			}
			if (alterIndex.Partition != null && !alterIndex.Partition.All)
			{
				return IndexAffectingStatement.AlterIndexRebuildOnePartition;
			}
			return IndexAffectingStatement.AlterIndexRebuildAllPartitions;
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x00019568 File Offset: 0x00017768
		protected static void CheckForDistinctInWindowedAggregate(FunctionCall functionCall, IToken distinctToken)
		{
			if (functionCall.UniqueRowFilter == UniqueRowFilter.Distinct && functionCall.OverClause != null && distinctToken != null)
			{
				TSql80ParserBaseInternal.ThrowParseErrorException("SQL46086", distinctToken, TSqlParserResource.SQL46086Message, new string[0]);
			}
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x00019594 File Offset: 0x00017794
		protected Literal CreateIntLiteralFromNumericToken(IToken token, int textOffset, int textLength)
		{
			IntegerLiteral integerLiteral = base.FragmentFactory.CreateFragment<IntegerLiteral>();
			TSql80ParserBaseInternal.UpdateTokenInfo(integerLiteral, token);
			integerLiteral.Value = token.getText().Substring(textOffset, textLength);
			return integerLiteral;
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x000195C8 File Offset: 0x000177C8
		protected bool SplitNumericIntoIpParts(IToken token, out Literal frag1, out Literal frag2)
		{
			string text = token.getText();
			int length = text.Length;
			int num = text.IndexOf('.');
			if (num == 0)
			{
				frag1 = null;
				frag2 = this.CreateIntLiteralFromNumericToken(token, 1, length - 1);
				return false;
			}
			if (num == length - 1)
			{
				frag1 = this.CreateIntLiteralFromNumericToken(token, 0, num);
				frag2 = null;
				return false;
			}
			frag1 = this.CreateIntLiteralFromNumericToken(token, 0, num);
			frag2 = this.CreateIntLiteralFromNumericToken(token, num + 1, length - num - 1);
			return true;
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x00019634 File Offset: 0x00017834
		protected Literal GetIPv4FragmentFromDotNumberNumeric(IToken token)
		{
			Literal literal;
			Literal literal2;
			this.SplitNumericIntoIpParts(token, out literal, out literal2);
			if (literal != null || literal2 == null)
			{
				throw TSql80ParserBaseInternal.GetUnexpectedTokenErrorException(token);
			}
			return literal2;
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x0001965C File Offset: 0x0001785C
		protected Literal GetIPv4FragmentFromNumberDotNumeric(IToken token)
		{
			Literal literal;
			Literal literal2;
			this.SplitNumericIntoIpParts(token, out literal, out literal2);
			if (literal == null || literal2 != null)
			{
				throw TSql80ParserBaseInternal.GetUnexpectedTokenErrorException(token);
			}
			return literal;
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x00019683 File Offset: 0x00017883
		protected void GetIPv4FragmentsFromNumberDotNumberNumeric(IToken token, out Literal frag1, out Literal frag2)
		{
			if (!this.SplitNumericIntoIpParts(token, out frag1, out frag2))
			{
				throw TSql80ParserBaseInternal.GetUnexpectedTokenErrorException(token);
			}
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x00019698 File Offset: 0x00017898
		protected static void CheckDmlTriggerActionDuplication(int current, TriggerAction vTriggerAction)
		{
			if ((current & 1 << (int)vTriggerAction.TriggerActionType) != 0)
			{
				TSql80ParserBaseInternal.ThrowParseErrorException("SQL46090", vTriggerAction, TSqlParserResource.SQL46090Message, new string[]
				{
					vTriggerAction.TriggerActionType.ToString()
				});
			}
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x000196DF File Offset: 0x000178DF
		protected static void UpdateDmlTriggerActionEncounteredOptions(ref int encountered, TriggerAction vTriggerAction)
		{
			encountered |= 1 << (int)vTriggerAction.TriggerActionType;
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x000196F4 File Offset: 0x000178F4
		protected static void ThrowIfInvalidListenerPortValue(Literal value)
		{
			int num;
			if (!int.TryParse(value.Value, NumberStyles.Integer, CultureInfo.InvariantCulture, out num) || num > 32767 || num < 1024)
			{
				TSql80ParserBaseInternal.ThrowParseErrorException("SQL46087", value, TSqlParserResource.SQL46087Message, new string[]
				{
					value.Value
				});
			}
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x00019748 File Offset: 0x00017948
		protected static void ThrowIfMaxdopValueOutOfRange(Literal value)
		{
			int num;
			if (!int.TryParse(value.Value, NumberStyles.Integer, CultureInfo.InvariantCulture, out num) || num > 32767 || num < 0)
			{
				TSql80ParserBaseInternal.ThrowParseErrorException("SQL46091", value, TSqlParserResource.SQL46091Message, new string[]
				{
					value.Value
				});
			}
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00019798 File Offset: 0x00017998
		protected EventTypeContainer CreateEventTypeContainer(EventNotificationEventType eventTypeValue, IToken token)
		{
			EventTypeContainer eventTypeContainer = base.FragmentFactory.CreateFragment<EventTypeContainer>();
			eventTypeContainer.EventType = eventTypeValue;
			TSql80ParserBaseInternal.UpdateTokenInfo(eventTypeContainer, token);
			return eventTypeContainer;
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x000197C0 File Offset: 0x000179C0
		protected EventGroupContainer CreateEventGroupContainer(EventNotificationEventGroup eventGroupValue, IToken token)
		{
			EventGroupContainer eventGroupContainer = base.FragmentFactory.CreateFragment<EventGroupContainer>();
			eventGroupContainer.EventGroup = eventGroupValue;
			TSql80ParserBaseInternal.UpdateTokenInfo(eventGroupContainer, token);
			return eventGroupContainer;
		}

		// Token: 0x04000E5F RID: 3679
		protected const int BulkInsertOptionsProhibitedInOpenRowset = 34866;

		// Token: 0x04000E60 RID: 3680
		private const int CheckForFormatFileOptionInOpenRowsetBulkMask = 3670272;
	}
}
