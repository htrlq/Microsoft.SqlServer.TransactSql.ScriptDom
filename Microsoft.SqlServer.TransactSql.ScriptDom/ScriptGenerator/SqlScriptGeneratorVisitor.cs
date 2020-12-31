using System;
using System.Collections.Generic;
using System.Globalization;

namespace Microsoft.SqlServer.TransactSql.ScriptDom.ScriptGenerator
{
	// Token: 0x020001A1 RID: 417
	internal abstract class SqlScriptGeneratorVisitor : TSqlConcreteFragmentVisitor
	{
		// Token: 0x06000C6A RID: 3178 RVA: 0x000216D5 File Offset: 0x0001F8D5
		public override void ExplicitVisit(AddFileSpec node)
		{
			this.GenerateFragmentIfNotNull(node.File);
			if (node.FileName != null)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.As);
				this.GenerateSpaceAndFragmentIfNotNull(node.FileName);
			}
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x000216FF File Offset: 0x0001F8FF
		public override void ExplicitVisit(AddSignatureStatement node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.Add);
			this.GenerateCounterSignature(node);
			this.GenerateSpaceAndKeyword(TSqlTokenType.To);
			this.GenerateSpace();
			this.GenerateModule(node);
			this.NewLineAndIndent();
			this.GenerateCryptos(node);
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x00021734 File Offset: 0x0001F934
		public override void ExplicitVisit(AdHocDataSource node)
		{
			this.GenerateKeyword(TSqlTokenType.OpenDataSource);
			this.GenerateSpaceAndSymbol(TSqlTokenType.LeftParenthesis);
			this.GenerateFragmentIfNotNull(node.ProviderName);
			this.GenerateSymbolAndSpace(TSqlTokenType.Comma);
			this.GenerateFragmentIfNotNull(node.InitString);
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x00021782 File Offset: 0x0001F982
		public override void ExplicitVisit(AdHocTableReference node)
		{
			this.GenerateFragmentIfNotNull(node.DataSource);
			this.GenerateSymbol(TSqlTokenType.Dot);
			this.GenerateFragmentIfNotNull(node.Object);
			this.GenerateSpaceAndAlias(node.Alias);
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x000217B3 File Offset: 0x0001F9B3
		public override void ExplicitVisit(AlterApplicationRoleStatement node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.Alter);
			this.GenerateApplicationRoleStatementBase(node);
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x000217C4 File Offset: 0x0001F9C4
		public override void ExplicitVisit(AlterAssemblyStatement node)
		{
			this.GenerateSpaceSeparatedTokens(TSqlTokenType.Alter, new string[]
			{
				"ASSEMBLY"
			});
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			if (node.Parameters.Count > 0)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.From);
				this.GenerateSpaceAndFragmentIfNotNull(node.Parameters[0]);
			}
			this.GenerateAssemblyOptions(node.Options);
			if (node.IsDropAll || node.DropFiles.Count > 0)
			{
				this.NewLineAndIndent();
				this.GenerateSpaceSeparatedTokens(new TSqlTokenType[]
				{
					TSqlTokenType.Drop,
					TSqlTokenType.File
				});
				if (node.IsDropAll)
				{
					this.GenerateSpaceAndKeyword(TSqlTokenType.All);
				}
				else
				{
					this.GenerateSpace();
					this.GenerateCommaSeparatedList<Literal>(node.DropFiles);
				}
			}
			if (node.AddFiles.Count > 0)
			{
				this.NewLineAndIndent();
				this.GenerateSpaceSeparatedTokens(new TSqlTokenType[]
				{
					TSqlTokenType.Add,
					TSqlTokenType.File,
					TSqlTokenType.From
				});
				this.GenerateSpace();
				this.GenerateCommaSeparatedList<AddFileSpec>(node.AddFiles);
			}
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x000218C7 File Offset: 0x0001FAC7
		internal void GenerateAssemblyOptions(IList<AssemblyOption> options)
		{
			if (options != null && options.Count > 0)
			{
				this.NewLineAndIndent();
				this.GenerateKeywordAndSpace(TSqlTokenType.With);
				this.GenerateCommaSeparatedList<AssemblyOption>(options);
			}
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x000218F0 File Offset: 0x0001FAF0
		public override void ExplicitVisit(AssemblyOption node)
		{
			this.GenerateSpaceSeparatedTokens(new string[]
			{
				"UNCHECKED",
				"DATA"
			});
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x0002191C File Offset: 0x0001FB1C
		public override void ExplicitVisit(PermissionSetAssemblyOption node)
		{
			string valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<PermissionSetOption, string>(SqlScriptGeneratorVisitor._permissionSetOptionNames, node.PermissionSetOption);
			this.GenerateNameEqualsValue("PERMISSION_SET", valueForEnumKey);
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x00021946 File Offset: 0x0001FB46
		public override void ExplicitVisit(OnOffAssemblyOption node)
		{
			this.GenerateOptionStateWithEqualSign("VISIBILITY", node.OptionState);
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x0002195C File Offset: 0x0001FB5C
		public override void ExplicitVisit(AlterAuthorizationStatement node)
		{
			this.GenerateSpaceSeparatedTokens(new TSqlTokenType[]
			{
				TSqlTokenType.Alter,
				TSqlTokenType.Authorization
			});
			this.NewLineAndIndent();
			this.GenerateFragmentIfNotNull(node.SecurityTargetObject);
			this.NewLineAndIndent();
			this.GenerateKeywordAndSpace(TSqlTokenType.To);
			if (node.ToSchemaOwner)
			{
				this.GenerateSpaceSeparatedTokens(TSqlTokenType.Schema, new string[]
				{
					"OWNER"
				});
				return;
			}
			this.GenerateFragmentIfNotNull(node.PrincipalName);
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x000219D4 File Offset: 0x0001FBD4
		public override void ExplicitVisit(AlterAvailabilityGroupStatement node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.Alter);
			this.GenerateIdentifier("AVAILABILITY");
			this.GenerateSpaceAndKeyword(TSqlTokenType.Group);
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			switch (node.AlterAvailabilityGroupStatementType)
			{
			case AlterAvailabilityGroupStatementType.AddDatabase:
				this.GenerateSpaceAndKeyword(TSqlTokenType.Add);
				this.GenerateSpaceAndKeyword(TSqlTokenType.Database);
				this.GenerateSpace();
				this.GenerateCommaSeparatedList<Identifier>(node.Databases);
				return;
			case AlterAvailabilityGroupStatementType.RemoveDatabase:
				this.GenerateSpaceAndIdentifier("REMOVE");
				this.GenerateSpaceAndKeyword(TSqlTokenType.Database);
				this.GenerateSpace();
				this.GenerateCommaSeparatedList<Identifier>(node.Databases);
				return;
			case AlterAvailabilityGroupStatementType.AddReplica:
				this.GenerateSpaceAndKeyword(TSqlTokenType.Add);
				this.GenerateSpaceAndIdentifier("REPLICA");
				this.GenerateSpaceAndKeyword(TSqlTokenType.On);
				this.GenerateSpace();
				this.GenerateCommaSeparatedList<AvailabilityReplica>(node.Replicas);
				return;
			case AlterAvailabilityGroupStatementType.ModifyReplica:
				this.GenerateSpaceAndIdentifier("MODIFY");
				this.GenerateSpaceAndIdentifier("REPLICA");
				this.GenerateSpaceAndKeyword(TSqlTokenType.On);
				this.GenerateSpace();
				this.GenerateCommaSeparatedList<AvailabilityReplica>(node.Replicas);
				return;
			case AlterAvailabilityGroupStatementType.RemoveReplica:
				this.GenerateSpaceAndIdentifier("REMOVE");
				this.GenerateSpaceAndIdentifier("REPLICA");
				this.GenerateSpaceAndKeyword(TSqlTokenType.On);
				this.GenerateSpace();
				this.GenerateCommaSeparatedList<AvailabilityReplica>(node.Replicas);
				return;
			case AlterAvailabilityGroupStatementType.Set:
				this.GenerateSpaceAndKeyword(TSqlTokenType.Set);
				this.GenerateSpace();
				this.GenerateParenthesisedCommaSeparatedList<AvailabilityGroupOption>(node.Options);
				return;
			case AlterAvailabilityGroupStatementType.Action:
				this.GenerateSpaceAndFragmentIfNotNull(node.Action);
				return;
			default:
				return;
			}
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x00021B32 File Offset: 0x0001FD32
		public override void ExplicitVisit(AlterAvailabilityGroupAction node)
		{
			AlterAvailabilityGroupActionTypeHelper.Instance.GenerateSourceForOption(this._writer, node.ActionType);
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x00021B4A File Offset: 0x0001FD4A
		public override void ExplicitVisit(AlterAvailabilityGroupFailoverAction node)
		{
			this.GenerateIdentifier("FAILOVER");
			if (node.Options != null && node.Options.Count > 0)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.With);
				this.GenerateSpace();
				this.GenerateParenthesisedCommaSeparatedList<AlterAvailabilityGroupFailoverOption>(node.Options);
			}
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x00021B8A File Offset: 0x0001FD8A
		public override void ExplicitVisit(AlterAvailabilityGroupFailoverOption node)
		{
			this.GenerateNameEqualsValue("TARGET", node.Value);
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x00021B9D File Offset: 0x0001FD9D
		public override void ExplicitVisit(AlterBrokerPriorityStatement node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.Alter);
			this.GenerateBrokerPriorityStatementBody(node);
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x00021BB0 File Offset: 0x0001FDB0
		public override void ExplicitVisit(AlterCertificateStatement node)
		{
			this.GenerateSpaceSeparatedTokens(TSqlTokenType.Alter, new string[]
			{
				"CERTIFICATE"
			});
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.GenerateSpace();
			switch (node.Kind)
			{
			case AlterCertificateStatementKind.RemovePrivateKey:
				this.GenerateRemovePrivateKey();
				return;
			case AlterCertificateStatementKind.RemoveAttestedOption:
				this.GenerateRemoteAttestedOption();
				return;
			case AlterCertificateStatementKind.WithPrivateKey:
				this.GenerateWithPrivateKey(node.PrivateKeyPath, node.EncryptionPassword, node.DecryptionPassword);
				return;
			case AlterCertificateStatementKind.WithActiveForBeginDialog:
				this.GenerateKeyword(TSqlTokenType.With);
				this.GenerateSpaceAndIdentifier("ACTIVE");
				this.GenerateSpaceAndKeyword(TSqlTokenType.For);
				this.GenerateSpace();
				this.GenerateOptionStateWithEqualSign("BEGIN_DIALOG", node.ActiveForBeginDialog);
				return;
			case AlterCertificateStatementKind.AttestedBy:
				this.GenerateAttestedBy(node.AttestedBy);
				return;
			default:
				return;
			}
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x00021C74 File Offset: 0x0001FE74
		protected void GenerateEndpointBody(AlterCreateEndpointStatementBase node)
		{
			if (node.State != EndpointState.NotSpecified)
			{
				string valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<EndpointState, string>(SqlScriptGeneratorVisitor._endpointStateNames, node.State);
				if (valueForEnumKey != null)
				{
					this.NewLineAndIndent();
					this.GenerateNameEqualsValue("STATE", valueForEnumKey);
				}
			}
			if (node.Affinity != null)
			{
				if (node.State != EndpointState.NotSpecified)
				{
					this.GenerateSymbolAndSpace(TSqlTokenType.Comma);
				}
				this.NewLineAndIndent();
				this.GenerateFragmentIfNotNull(node.Affinity);
			}
			if (node.Protocol != EndpointProtocol.None)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.As);
				string valueForEnumKey2 = SqlScriptGeneratorVisitor.GetValueForEnumKey<EndpointProtocol, string>(SqlScriptGeneratorVisitor._endpointProtocolNames, node.Protocol);
				if (valueForEnumKey2 != null)
				{
					this.GenerateSpaceAndIdentifier(valueForEnumKey2);
				}
				this.GenerateAlignedParenthesizedOptionsWithMultipleIndent<EndpointProtocolOption>(node.ProtocolOptions, 3);
			}
			if (node.EndpointType != EndpointType.NotSpecified)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.For);
				string valueForEnumKey3 = SqlScriptGeneratorVisitor.GetValueForEnumKey<EndpointType, string>(SqlScriptGeneratorVisitor._endpointTypeNames, node.EndpointType);
				if (valueForEnumKey3 != null)
				{
					this.GenerateSpaceAndIdentifier(valueForEnumKey3);
				}
				this.GenerateAlignedParenthesizedOptionsWithMultipleIndent<PayloadOption>(node.PayloadOptions, 3);
			}
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x00021D58 File Offset: 0x0001FF58
		public override void ExplicitVisit(AlterCredentialStatement node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.Alter);
			this.GenerateCredentialStatementBody(node);
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x00021D68 File Offset: 0x0001FF68
		public override void ExplicitVisit(AlterDatabaseAddFileGroupStatement node)
		{
			this.GenerateAlterDbStatementHead(node);
			this.NewLineAndIndent();
			this.GenerateKeyword(TSqlTokenType.Add);
			this.GenerateSpaceAndIdentifier("FILEGROUP");
			this.GenerateSpaceAndFragmentIfNotNull(node.FileGroup);
			if (node.ContainsFileStream)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.Contains);
				this.GenerateSpaceAndIdentifier("FILESTREAM");
			}
			if (node.ContainsMemoryOptimizedData)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.Contains);
				this.GenerateSpaceAndIdentifier("MEMORY_OPTIMIZED_DATA");
			}
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x00021DD8 File Offset: 0x0001FFD8
		public override void ExplicitVisit(AlterDatabaseAddFileStatement node)
		{
			this.GenerateAlterDbStatementHead(node);
			this.NewLineAndIndent();
			this.GenerateKeyword(TSqlTokenType.Add);
			if (node.IsLog)
			{
				this.GenerateSpaceAndIdentifier("LOG");
			}
			this.GenerateSpaceAndKeyword(TSqlTokenType.File);
			this.GenerateSpace();
			this.GenerateCommaSeparatedList<FileDeclaration>(node.FileDeclarations);
			if (node.FileGroup != null)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.To);
				this.GenerateSpaceAndIdentifier("FILEGROUP");
				this.GenerateSpaceAndFragmentIfNotNull(node.FileGroup);
			}
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x00021E50 File Offset: 0x00020050
		public override void ExplicitVisit(AlterDatabaseCollateStatement node)
		{
			this.GenerateAlterDbStatementHead(node);
			this.GenerateSpaceAndCollation(node.Collation);
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x00021E68 File Offset: 0x00020068
		public override void ExplicitVisit(AlterDatabaseModifyFileGroupStatement node)
		{
			this.GenerateAlterDbStatementHead(node);
			this.NewLineAndIndent();
			this.GenerateIdentifier("MODIFY");
			this.GenerateSpaceAndIdentifier("FILEGROUP");
			this.GenerateSpaceAndFragmentIfNotNull(node.FileGroup);
			this.GenerateSpace();
			if (node.NewFileGroupName != null)
			{
				this.GenerateNameEqualsValue("NAME", node.NewFileGroupName);
				return;
			}
			if (node.MakeDefault)
			{
				this.GenerateKeyword(TSqlTokenType.Default);
				return;
			}
			if (node.UpdatabilityOption != ModifyFileGroupOption.None)
			{
				ModifyFilegroupOptionsHelper.Instance.GenerateSourceForOption(this._writer, node.UpdatabilityOption);
				this.GenerateSpaceAndFragmentIfNotNull(node.Termination);
			}
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x00021EFF File Offset: 0x000200FF
		public override void ExplicitVisit(AlterDatabaseModifyFileStatement node)
		{
			this.GenerateAlterDbStatementHead(node);
			this.NewLineAndIndent();
			this.GenerateIdentifier("MODIFY");
			this.GenerateSpaceAndKeyword(TSqlTokenType.File);
			this.GenerateSpaceAndFragmentIfNotNull(node.FileDeclaration);
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x00021F2D File Offset: 0x0002012D
		public override void ExplicitVisit(AlterDatabaseModifyNameStatement node)
		{
			this.GenerateAlterDbStatementHead(node);
			this.NewLineAndIndent();
			this.GenerateIdentifier("MODIFY");
			this.GenerateSpace();
			this.GenerateNameEqualsValue("NAME", node.NewDatabaseName);
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x00021F60 File Offset: 0x00020160
		public override void ExplicitVisit(AlterDatabaseRebuildLogStatement node)
		{
			this.GenerateAlterDbStatementHead(node);
			this.NewLineAndIndent();
			this.GenerateIdentifier("REBUILD");
			this.GenerateSpaceAndIdentifier("LOG");
			if (node.FileDeclaration != null)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.On);
				this.GenerateSpaceAndFragmentIfNotNull(node.FileDeclaration);
			}
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x00021FAC File Offset: 0x000201AC
		public override void ExplicitVisit(AlterDatabaseRemoveFileGroupStatement node)
		{
			this.GenerateAlterDbStatementHead(node);
			this.NewLineAndIndent();
			this.GenerateIdentifier("REMOVE");
			this.GenerateSpaceAndIdentifier("FILEGROUP");
			this.GenerateSpaceAndFragmentIfNotNull(node.FileGroup);
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x00021FDD File Offset: 0x000201DD
		public override void ExplicitVisit(AlterDatabaseRemoveFileStatement node)
		{
			this.GenerateAlterDbStatementHead(node);
			this.NewLineAndIndent();
			this.GenerateSpaceAndIdentifier("REMOVE");
			this.GenerateSpaceAndKeyword(TSqlTokenType.File);
			this.GenerateSpaceAndFragmentIfNotNull(node.File);
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x0002200C File Offset: 0x0002020C
		public override void ExplicitVisit(AlterDatabaseSetStatement node)
		{
			this.GenerateAlterDbStatementHead(node);
			this.NewLineAndIndent();
			bool flag = true;
			foreach (DatabaseOption databaseOption in node.Options)
			{
				if (databaseOption.OptionKind != DatabaseOptionKind.MaxSize && databaseOption.OptionKind != DatabaseOptionKind.Edition)
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				this.GenerateIdentifier("MODIFY");
				this.GenerateSpace();
				AlignmentPoint ap = new AlignmentPoint();
				this.MarkAndPushAlignmentPoint(ap);
				this.GenerateParenthesisedCommaSeparatedList<DatabaseOption>(node.Options, true);
				this.PopAlignmentPoint();
			}
			else
			{
				this.GenerateKeyword(TSqlTokenType.Set);
				this.GenerateSpace();
				AlignmentPoint ap2 = new AlignmentPoint();
				this.MarkAndPushAlignmentPoint(ap2);
				this.GenerateCommaSeparatedList<DatabaseOption>(node.Options, true);
				this.PopAlignmentPoint();
			}
			this.GenerateSpaceAndFragmentIfNotNull(node.Termination);
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x000220F4 File Offset: 0x000202F4
		protected void GenerateAlterDbStatementHead(AlterDatabaseStatement node)
		{
			this.GenerateSpaceSeparatedTokens(new TSqlTokenType[]
			{
				TSqlTokenType.Alter,
				TSqlTokenType.Database
			});
			if (node.UseCurrent)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.Current);
				return;
			}
			this.GenerateSpaceAndFragmentIfNotNull(node.DatabaseName);
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x00022138 File Offset: 0x00020338
		public override void ExplicitVisit(AlterDatabaseTermination node)
		{
			this.NewLineAndIndent();
			this.GenerateKeywordAndSpace(TSqlTokenType.With);
			if (node.ImmediateRollback)
			{
				this.GenerateKeyword(TSqlTokenType.Rollback);
				this.GenerateSpaceAndIdentifier("IMMEDIATE");
				return;
			}
			if (node.RollbackAfter != null)
			{
				this.GenerateKeyword(TSqlTokenType.Rollback);
				this.GenerateSpaceAndIdentifier("AFTER");
				this.GenerateSpaceAndFragmentIfNotNull(node.RollbackAfter);
				this.GenerateSpaceAndIdentifier("SECONDS");
				return;
			}
			if (node.NoWait)
			{
				this.GenerateIdentifier("NO_WAIT");
			}
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x000221BE File Offset: 0x000203BE
		public override void ExplicitVisit(AlterEndpointStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Alter);
			this.GenerateSpaceAndIdentifier("ENDPOINT");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.GenerateSpace();
			this.GenerateEndpointBody(node);
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x000221EC File Offset: 0x000203EC
		public override void ExplicitVisit(AlterFederationStatement node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.Alter);
			this.GenerateIdentifier("FEDERATION");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			switch (node.Kind)
			{
			case AlterFederationKind.Split:
				this.GenerateSpaceAndIdentifier("SPLIT");
				this.GenerateSpaceAndIdentifier("AT");
				this.GenerateSpaceAndSymbol(TSqlTokenType.LeftParenthesis);
				break;
			case AlterFederationKind.DropLow:
				this.GenerateSpaceAndKeyword(TSqlTokenType.Drop);
				this.GenerateSpaceAndIdentifier("AT");
				this.GenerateSpaceAndSymbol(TSqlTokenType.LeftParenthesis);
				this.GenerateIdentifier("LOW");
				this.GenerateSpace();
				break;
			case AlterFederationKind.DropHigh:
				this.GenerateSpaceAndKeyword(TSqlTokenType.Drop);
				this.GenerateSpaceAndIdentifier("AT");
				this.GenerateSpaceAndSymbol(TSqlTokenType.LeftParenthesis);
				this.GenerateIdentifier("HIGH");
				this.GenerateSpace();
				break;
			}
			this.GenerateFragmentIfNotNull(node.DistributionName);
			this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
			this.GenerateSpaceAndFragmentIfNotNull(node.Boundary);
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x000222E8 File Offset: 0x000204E8
		public override void ExplicitVisit(AlterFullTextCatalogStatement node)
		{
			this.GenerateSpaceSeparatedTokens(TSqlTokenType.Alter, new string[]
			{
				"FULLTEXT",
				"CATALOG"
			});
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.GenerateSpace();
			switch (node.Action)
			{
			case AlterFullTextCatalogAction.None:
				break;
			case AlterFullTextCatalogAction.Rebuild:
				this.GenerateIdentifier("REBUILD");
				if (node.Options != null && node.Options.Count > 0)
				{
					this.GenerateSpace();
					this.GenerateSymbolAndSpace(TSqlTokenType.With);
					this.GenerateCommaSeparatedList<FullTextCatalogOption>(node.Options);
					return;
				}
				break;
			case AlterFullTextCatalogAction.Reorganize:
				this.GenerateIdentifier("REORGANIZE");
				break;
			case AlterFullTextCatalogAction.AsDefault:
				this.GenerateSpaceSeparatedTokens(new TSqlTokenType[]
				{
					TSqlTokenType.As,
					TSqlTokenType.Default
				});
				return;
			default:
				return;
			}
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x000223A7 File Offset: 0x000205A7
		public override void ExplicitVisit(AlterFullTextIndexStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Alter);
			this.GenerateSpaceAndIdentifier("FULLTEXT");
			this.GenerateSpaceAndKeyword(TSqlTokenType.Index);
			this.GenerateSpaceAndKeyword(TSqlTokenType.On);
			this.GenerateSpaceAndFragmentIfNotNull(node.OnName);
			this.GenerateSpaceAndFragmentIfNotNull(node.Action);
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x000223E4 File Offset: 0x000205E4
		public override void ExplicitVisit(SimpleAlterFullTextIndexAction node)
		{
			List<TokenGenerator> valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<SimpleAlterFullTextIndexActionKind, List<TokenGenerator>>(SqlScriptGeneratorVisitor._simpleAlterFulltextIndexActionKindActions, node.ActionKind);
			if (valueForEnumKey != null)
			{
				this.GenerateTokenList(valueForEnumKey);
			}
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x0002240C File Offset: 0x0002060C
		public override void ExplicitVisit(SetStopListAlterFullTextIndexAction node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.Set);
			this.GenerateFragmentIfNotNull(node.StopListOption);
			this.GenerateWithNoPopulation(node.WithNoPopulation);
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x00022431 File Offset: 0x00020631
		public override void ExplicitVisit(SetSearchPropertyListAlterFullTextIndexAction node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.Set);
			this.GenerateFragmentIfNotNull(node.SearchPropertyListOption);
			this.GenerateWithNoPopulation(node.WithNoPopulation);
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x00022456 File Offset: 0x00020656
		public override void ExplicitVisit(DropAlterFullTextIndexAction node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.Drop);
			this.GenerateParenthesisedCommaSeparatedList<Identifier>(node.Columns);
			this.GenerateWithNoPopulation(node.WithNoPopulation);
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x00022478 File Offset: 0x00020678
		public override void ExplicitVisit(AddAlterFullTextIndexAction node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.Add);
			this.GenerateParenthesisedCommaSeparatedList<FullTextIndexColumn>(node.Columns);
			this.GenerateWithNoPopulation(node.WithNoPopulation);
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x0002249C File Offset: 0x0002069C
		public override void ExplicitVisit(AlterColumnAlterFullTextIndexAction node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.Alter);
			this.GenerateKeywordAndSpace(TSqlTokenType.Column);
			this.GenerateFragmentIfNotNull(node.Column.Name);
			if (node.Column.StatisticalSemantics)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.Add);
			}
			else
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.Drop);
			}
			this.GenerateSpaceAndIdentifier("STATISTICAL_SEMANTICS");
			this.GenerateWithNoPopulation(node.WithNoPopulation);
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x00022500 File Offset: 0x00020700
		protected void GenerateWithNoPopulation(bool withNoPopulation)
		{
			if (withNoPopulation)
			{
				this.GenerateSpace();
				this.GenerateSpaceSeparatedTokens(TSqlTokenType.With, new string[]
				{
					"NO",
					"POPULATION"
				});
			}
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x00022539 File Offset: 0x00020739
		public override void ExplicitVisit(AlterFullTextStopListStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Alter);
			this.GenerateSpaceAndIdentifier("FULLTEXT");
			this.GenerateSpaceAndKeyword(TSqlTokenType.StopList);
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.GenerateSpaceAndFragmentIfNotNull(node.Action);
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x00022570 File Offset: 0x00020770
		public override void ExplicitVisit(AlterFunctionStatement node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.Alter);
			this.GenerateFunctionStatementBody(node);
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x00022580 File Offset: 0x00020780
		public override void ExplicitVisit(AlterIndexStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Alter);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Index);
			if (node.All)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.All);
			}
			else
			{
				this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			}
			this.NewLineAndIndent();
			this.GenerateKeyword(TSqlTokenType.On);
			this.GenerateSpaceAndFragmentIfNotNull(node.OnName);
			this.GenerateSpace();
			if (node.AlterIndexType == AlterIndexType.Set)
			{
				this.GenerateKeywordAndSpace(TSqlTokenType.Set);
				this.GenerateParenthesisedCommaSeparatedList<IndexOption>(node.IndexOptions);
				return;
			}
			if (node.AlterIndexType == AlterIndexType.UpdateSelectiveXmlPaths)
			{
				if (node.XmlNamespaces != null)
				{
					this.NewLine();
					this.GenerateKeyword(TSqlTokenType.With);
					this.GenerateSpaceAndFragmentIfNotNull(node.XmlNamespaces);
				}
				this.NewLine();
				this.GenerateKeyword(TSqlTokenType.For);
				this.NewLine();
				this.GenerateSymbol(TSqlTokenType.LeftParenthesis);
				bool flag = true;
				foreach (SelectiveXmlIndexPromotedPath selectiveXmlIndexPromotedPath in node.PromotedPaths)
				{
					if (!flag)
					{
						this.GenerateSymbol(TSqlTokenType.Comma);
					}
					this.NewLineAndIndent();
					if (selectiveXmlIndexPromotedPath.Path == null)
					{
						this.GenerateSpaceAndIdentifier("REMOVE");
						this.GenerateSpace();
						this.GenerateSpaceAndFragmentIfNotNull(selectiveXmlIndexPromotedPath.Name);
					}
					else
					{
						this.GenerateSpaceAndKeyword(TSqlTokenType.Add);
						this.GenerateSpace();
						this.GenerateFragmentIfNotNull(selectiveXmlIndexPromotedPath);
					}
					flag = false;
				}
				this.NewLine();
				this.GenerateSymbol(TSqlTokenType.RightParenthesis);
				return;
			}
			AlterIndexTypeHelper.Instance.GenerateSourceForOption(this._writer, node.AlterIndexType);
			this.GenerateSpaceAndFragmentIfNotNull(node.Partition);
			if (node.IndexOptions.Count > 0)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.With);
				this.GenerateParenthesisedCommaSeparatedList<IndexOption>(node.IndexOptions);
			}
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x00022730 File Offset: 0x00020930
		public override void ExplicitVisit(AlterLoginEnableDisableStatement node)
		{
			this.GenerateAlterLoginHeader(node);
			this.GenerateIdentifier(node.IsEnable ? "ENABLE" : "DISABLE");
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x00022753 File Offset: 0x00020953
		public override void ExplicitVisit(AlterLoginOptionsStatement node)
		{
			this.GenerateAlterLoginHeader(node);
			this.GenerateKeywordAndSpace(TSqlTokenType.With);
			this.GenerateFragmentList<PrincipalOption>(node.Options);
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x00022773 File Offset: 0x00020973
		public override void ExplicitVisit(AlterLoginAddDropCredentialStatement node)
		{
			this.GenerateAlterLoginHeader(node);
			this.GenerateKeywordAndSpace(node.IsAdd ? TSqlTokenType.Add : TSqlTokenType.Drop);
			this.GenerateIdentifier("CREDENTIAL");
			this.GenerateSpaceAndFragmentIfNotNull(node.CredentialName);
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x000227A6 File Offset: 0x000209A6
		private void GenerateAlterLoginHeader(AlterLoginStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Alter);
			this.GenerateSpaceAndIdentifier("LOGIN");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.GenerateSpace();
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x000227CC File Offset: 0x000209CC
		public override void ExplicitVisit(AlterMasterKeyStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Alter);
			this.GenerateSpaceAndIdentifier("MASTER");
			this.GenerateSpaceAndKeyword(TSqlTokenType.Key);
			this.GenerateSpace();
			switch (node.Option)
			{
			case AlterMasterKeyOption.Regenerate:
				this.GenerateRegenerateOption(node.Password);
				return;
			case AlterMasterKeyOption.ForceRegenerate:
				this.GenerateIdentifier("FORCE");
				this.GenerateSpace();
				this.GenerateRegenerateOption(node.Password);
				return;
			case AlterMasterKeyOption.AddEncryptionByServiceMasterKey:
				this.GenerateKeywordAndSpace(TSqlTokenType.Add);
				this.GenerateEncyptionByServiceMasterKey();
				return;
			case AlterMasterKeyOption.AddEncryptionByPassword:
				this.GenerateKeywordAndSpace(TSqlTokenType.Add);
				this.GenerateEncryptionByPassword(node.Password);
				return;
			case AlterMasterKeyOption.DropEncryptionByServiceMasterKey:
				this.GenerateKeywordAndSpace(TSqlTokenType.Drop);
				this.GenerateEncyptionByServiceMasterKey();
				return;
			case AlterMasterKeyOption.DropEncryptionByPassword:
				this.GenerateKeywordAndSpace(TSqlTokenType.Drop);
				this.GenerateEncryptionByPassword(node.Password);
				return;
			default:
				return;
			}
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x00022891 File Offset: 0x00020A91
		private void GenerateRegenerateOption(Literal password)
		{
			this.GenerateIdentifier("REGENERATE");
			this.GenerateSpaceAndKeyword(TSqlTokenType.With);
			this.GenerateSpaceAndIdentifier("ENCRYPTION");
			this.GenerateSpaceAndKeyword(TSqlTokenType.By);
			this.GenerateSpace();
			this.GenerateNameEqualsValue("PASSWORD", password);
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x000228CE File Offset: 0x00020ACE
		private void GenerateEncyptionByServiceMasterKey()
		{
			this.GenerateIdentifier("ENCRYPTION");
			this.GenerateSpaceAndKeyword(TSqlTokenType.By);
			this.GenerateSpaceAndIdentifier("SERVICE");
			this.GenerateSpaceAndIdentifier("MASTER");
			this.GenerateSpaceAndKeyword(TSqlTokenType.Key);
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x00022901 File Offset: 0x00020B01
		public override void ExplicitVisit(AlterMessageTypeStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Alter);
			this.GenerateSpaceAndIdentifier("MESSAGE");
			this.GenerateSpaceAndIdentifier("TYPE");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.GenerateValidationMethod(node);
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x00022934 File Offset: 0x00020B34
		public override void ExplicitVisit(AlterPartitionFunctionStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Alter);
			this.GenerateSpaceAndIdentifier("PARTITION");
			this.GenerateSpaceAndKeyword(TSqlTokenType.Function);
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.GenerateSymbolAndSpace(TSqlTokenType.LeftParenthesis);
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			this.NewLineAndIndent();
			this.GenerateIdentifier(node.IsSplit ? "SPLIT" : "MERGE");
			if (node.Boundary != null)
			{
				this.GenerateSpaceAndIdentifier("RANGE");
				this.GenerateSpace();
				this.GenerateParenthesisedFragmentIfNotNull(node.Boundary);
			}
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x000229C4 File Offset: 0x00020BC4
		public override void ExplicitVisit(AlterPartitionSchemeStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Alter);
			this.GenerateSpaceAndIdentifier("PARTITION");
			this.GenerateSpaceAndIdentifier("SCHEME");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.GenerateSpaceAndIdentifier("NEXT");
			this.GenerateSpaceAndIdentifier("USED");
			this.GenerateSpaceAndFragmentIfNotNull(node.FileGroup);
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x00022A1C File Offset: 0x00020C1C
		public override void ExplicitVisit(AlterProcedureStatement node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.Alter);
			this.GenerateProcedureStatementBody(node);
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x00022A2C File Offset: 0x00020C2C
		public override void ExplicitVisit(AlterQueueStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Alter);
			this.GenerateSpaceAndIdentifier("QUEUE");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.NewLineAndIndent();
			this.GenerateKeywordAndSpace(TSqlTokenType.With);
			this.GenerateQueueOptions(node.QueueOptions);
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x00022A6C File Offset: 0x00020C6C
		public override void ExplicitVisit(AlterRemoteServiceBindingStatement node)
		{
			this.GenerateSpaceSeparatedTokens(TSqlTokenType.Alter, new string[]
			{
				"REMOTE",
				"SERVICE",
				"BINDING"
			});
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.GenerateBindingOptions(node.Options);
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x00022AB8 File Offset: 0x00020CB8
		public override void ExplicitVisit(AlterResourceGovernorStatement node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.Alter);
			this.GenerateIdentifier("RESOURCE");
			this.GenerateSpaceAndIdentifier("GOVERNOR");
			switch (node.Command)
			{
			case AlterResourceGovernorCommandType.Disable:
				this.GenerateSpaceAndIdentifier("DISABLE");
				return;
			case AlterResourceGovernorCommandType.Reconfigure:
				this.GenerateSpaceAndKeyword(TSqlTokenType.Reconfigure);
				return;
			case AlterResourceGovernorCommandType.ClassifierFunction:
				this.GenerateResourceGovernorClassifierFunction(node);
				return;
			case AlterResourceGovernorCommandType.ResetStatistics:
				this.GenerateSpaceAndIdentifier("RESET");
				this.GenerateSpaceAndKeyword(TSqlTokenType.Statistics);
				return;
			default:
				return;
			}
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x00022B38 File Offset: 0x00020D38
		public void GenerateResourceGovernorClassifierFunction(AlterResourceGovernorStatement node)
		{
			this.GenerateSpaceAndKeyword(TSqlTokenType.With);
			this.GenerateSpaceAndKeyword(TSqlTokenType.LeftParenthesis);
			this.GenerateIdentifier("CLASSIFIER_FUNCTION");
			this.GenerateSpaceAndKeyword(TSqlTokenType.EqualsSign);
			if (node.ClassifierFunction != null)
			{
				this.GenerateSpaceAndFragmentIfNotNull(node.ClassifierFunction);
			}
			else
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.Null);
			}
			this.GenerateKeyword(TSqlTokenType.RightParenthesis);
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x00022B9A File Offset: 0x00020D9A
		public override void ExplicitVisit(AlterResourcePoolStatement node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.Alter);
			this.GenerateResourcePoolStatementBody(node);
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x00022BAA File Offset: 0x00020DAA
		public override void ExplicitVisit(RenameAlterRoleAction node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.With);
			this.GenerateNameEqualsValue("NAME", node.NewName);
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x00022BC8 File Offset: 0x00020DC8
		public override void ExplicitVisit(AddMemberAlterRoleAction node)
		{
			this.GenerateSpaceSeparatedTokens(TSqlTokenType.Add, new string[]
			{
				"MEMBER"
			});
			this.GenerateSpaceAndFragmentIfNotNull(node.Member);
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x00022BF8 File Offset: 0x00020DF8
		public override void ExplicitVisit(DropMemberAlterRoleAction node)
		{
			this.GenerateSpaceSeparatedTokens(TSqlTokenType.Drop, new string[]
			{
				"MEMBER"
			});
			this.GenerateSpaceAndFragmentIfNotNull(node.Member);
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x00022C2C File Offset: 0x00020E2C
		public override void ExplicitVisit(AlterRoleStatement node)
		{
			this.GenerateSpaceSeparatedTokens(TSqlTokenType.Alter, new string[]
			{
				"ROLE"
			});
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.GenerateSpaceAndFragmentIfNotNull(node.Action);
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x00022C68 File Offset: 0x00020E68
		public override void ExplicitVisit(AlterRouteStatement node)
		{
			this.GenerateSpaceSeparatedTokens(TSqlTokenType.Alter, new string[]
			{
				"ROUTE"
			});
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.GenerateRouteOptions(node);
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x00022CA0 File Offset: 0x00020EA0
		public override void ExplicitVisit(AlterSchemaStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Alter);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Schema);
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.GenerateSpaceAndIdentifier("TRANSFER");
			if (node.ObjectKind != SecurityObjectKind.NotSpecified)
			{
				this.GenerateSpace();
				this.GenerateSourceForSecurityObjectKind(node.ObjectKind);
			}
			this.GenerateSpaceAndFragmentIfNotNull(node.ObjectName);
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x00022CFC File Offset: 0x00020EFC
		public override void ExplicitVisit(AlterSearchPropertyListStatement node)
		{
			this.GenerateSpaceSeparatedTokens(TSqlTokenType.Alter, new string[]
			{
				"SEARCH",
				"PROPERTY",
				"LIST"
			});
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.GenerateSpaceAndFragmentIfNotNull(node.Action);
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x00022D48 File Offset: 0x00020F48
		public override void ExplicitVisit(AlterSequenceStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Alter);
			this.GenerateSpaceAndIdentifier("SEQUENCE");
			this.GenerateSequenceStatementBody(node);
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x00022D64 File Offset: 0x00020F64
		public override void ExplicitVisit(AlterServerConfigurationSetBufferPoolExtensionStatement node)
		{
			this.GenerateSpaceSeparatedTokens(TSqlTokenType.Alter, new string[]
			{
				"SERVER",
				"CONFIGURATION"
			});
			this.GenerateSpace();
			this.GenerateSpaceSeparatedTokens(TSqlTokenType.Set, new string[]
			{
				"BUFFER",
				"POOL",
				"EXTENSION"
			});
			this.GenerateSpace();
			this.GenerateCommaSeparatedList<AlterServerConfigurationBufferPoolExtensionOption>(node.Options);
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x00022DD3 File Offset: 0x00020FD3
		public override void ExplicitVisit(AlterServerConfigurationBufferPoolExtensionContainerOption node)
		{
			this.GenerateFragmentIfNotNull(node.OptionValue);
			if (node.Suboptions.Count > 0)
			{
				this.GenerateSpace();
				this.GenerateParenthesisedCommaSeparatedList<AlterServerConfigurationBufferPoolExtensionOption>(node.Suboptions);
			}
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x00022E01 File Offset: 0x00021001
		public override void ExplicitVisit(AlterServerConfigurationBufferPoolExtensionOption node)
		{
			AlterServerConfigurationBufferPoolExtensionOptionHelper.Instance.GenerateSourceForOption(this._writer, node.OptionKind);
			this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
			this.GenerateSpaceAndFragmentIfNotNull(node.OptionValue);
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x00022E30 File Offset: 0x00021030
		public override void ExplicitVisit(AlterServerConfigurationBufferPoolExtensionSizeOption node)
		{
			AlterServerConfigurationBufferPoolExtensionOptionHelper.Instance.GenerateSourceForOption(this._writer, node.OptionKind);
			this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
			this.GenerateSpaceAndFragmentIfNotNull(node.OptionValue);
			this.GenerateSpace();
			MemoryUnitsHelper.Instance.GenerateSourceForOption(this._writer, node.SizeUnit);
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x00022E88 File Offset: 0x00021088
		public override void ExplicitVisit(AlterServerConfigurationSetDiagnosticsLogStatement node)
		{
			this.GenerateSpaceSeparatedTokens(TSqlTokenType.Alter, new string[]
			{
				"SERVER",
				"CONFIGURATION"
			});
			this.GenerateSpace();
			this.GenerateSpaceSeparatedTokens(TSqlTokenType.Set, new string[]
			{
				"DIAGNOSTICS",
				"LOG"
			});
			this.GenerateSpace();
			this.GenerateCommaSeparatedList<AlterServerConfigurationDiagnosticsLogOption>(node.Options);
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x00022EF0 File Offset: 0x000210F0
		public override void ExplicitVisit(AlterServerConfigurationDiagnosticsLogOption node)
		{
			if (node.OptionKind == AlterServerConfigurationDiagnosticsLogOptionKind.OnOff)
			{
				this.GenerateFragmentIfNotNull(node.OptionValue);
				return;
			}
			AlterServerConfigurationDiagnosticsLogOptionHelper.Instance.GenerateSourceForOption(this._writer, node.OptionKind);
			this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
			this.GenerateSpaceAndFragmentIfNotNull(node.OptionValue);
		}

		// Token: 0x06000CB5 RID: 3253 RVA: 0x00022F40 File Offset: 0x00021140
		public override void ExplicitVisit(AlterServerConfigurationDiagnosticsLogMaxSizeOption node)
		{
			AlterServerConfigurationDiagnosticsLogOptionKind optionKind = node.OptionKind;
			AlterServerConfigurationDiagnosticsLogOptionHelper.Instance.GenerateSourceForOption(this._writer, node.OptionKind);
			this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
			this.GenerateSpaceAndFragmentIfNotNull(node.OptionValue);
			if (node.SizeUnit != MemoryUnit.Unspecified)
			{
				this.GenerateSpace();
				MemoryUnitsHelper.Instance.GenerateSourceForOption(this._writer, node.SizeUnit);
			}
		}

		// Token: 0x06000CB6 RID: 3254 RVA: 0x00022FA8 File Offset: 0x000211A8
		public override void ExplicitVisit(AlterServerConfigurationSetFailoverClusterPropertyStatement node)
		{
			this.GenerateSpaceSeparatedTokens(TSqlTokenType.Alter, new string[]
			{
				"SERVER",
				"CONFIGURATION"
			});
			this.GenerateSpace();
			this.GenerateSpaceSeparatedTokens(TSqlTokenType.Set, new string[]
			{
				"FAILOVER",
				"CLUSTER",
				"PROPERTY"
			});
			this.GenerateSpace();
			this.GenerateCommaSeparatedList<AlterServerConfigurationFailoverClusterPropertyOption>(node.Options);
		}

		// Token: 0x06000CB7 RID: 3255 RVA: 0x00023017 File Offset: 0x00021217
		public override void ExplicitVisit(AlterServerConfigurationFailoverClusterPropertyOption node)
		{
			AlterServerConfigurationFailoverClusterPropertyOptionHelper.Instance.GenerateSourceForOption(this._writer, node.OptionKind);
			this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
			this.GenerateSpaceAndFragmentIfNotNull(node.OptionValue);
		}

		// Token: 0x06000CB8 RID: 3256 RVA: 0x00023048 File Offset: 0x00021248
		public override void ExplicitVisit(AlterServerConfigurationSetHadrClusterStatement node)
		{
			this.GenerateSpaceSeparatedTokens(TSqlTokenType.Alter, new string[]
			{
				"SERVER",
				"CONFIGURATION"
			});
			this.GenerateSpace();
			this.GenerateSpaceSeparatedTokens(TSqlTokenType.Set, new string[]
			{
				"HADR",
				"CLUSTER"
			});
			this.GenerateSpace();
			this.GenerateCommaSeparatedList<AlterServerConfigurationHadrClusterOption>(node.Options);
		}

		// Token: 0x06000CB9 RID: 3257 RVA: 0x000230B0 File Offset: 0x000212B0
		public override void ExplicitVisit(AlterServerConfigurationHadrClusterOption node)
		{
			AlterServerConfigurationHadrClusterOptionHelper.Instance.GenerateSourceForOption(this._writer, node.OptionKind);
			this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
			if (node.IsLocal)
			{
				this.GenerateSpaceAndIdentifier("LOCAL");
				return;
			}
			this.GenerateSpaceAndFragmentIfNotNull(node.OptionValue);
		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x00023100 File Offset: 0x00021300
		public override void ExplicitVisit(AlterServerConfigurationStatement node)
		{
			this.GenerateSpaceSeparatedTokens(TSqlTokenType.Alter, new string[]
			{
				"SERVER",
				"CONFIGURATION"
			});
			this.GenerateSpaceAndKeyword(TSqlTokenType.Set);
			this.GenerateSpaceAndIdentifier("PROCESS");
			this.GenerateSpaceAndIdentifier("AFFINITY");
			switch (node.ProcessAffinity)
			{
			case ProcessAffinityType.CpuAuto:
				this.GenerateSpaceAndIdentifier("CPU");
				this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
				this.GenerateSpaceAndIdentifier("AUTO");
				return;
			case ProcessAffinityType.Cpu:
				this.GenerateSpaceAndIdentifier("CPU");
				this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
				this.GenerateSpace();
				this.GenerateCommaSeparatedList<ProcessAffinityRange>(node.ProcessAffinityRanges);
				return;
			case ProcessAffinityType.NumaNode:
				this.GenerateSpaceAndIdentifier("NUMANODE");
				this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
				this.GenerateSpace();
				this.GenerateCommaSeparatedList<ProcessAffinityRange>(node.ProcessAffinityRanges);
				return;
			default:
				return;
			}
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x000231DA File Offset: 0x000213DA
		public override void ExplicitVisit(ProcessAffinityRange node)
		{
			this.GenerateFragmentIfNotNull(node.From);
			if (node.To != null)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.To);
				this.GenerateSpaceAndFragmentIfNotNull(node.To);
			}
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x00023208 File Offset: 0x00021408
		public override void ExplicitVisit(AlterServerRoleStatement node)
		{
			this.GenerateSpaceSeparatedTokens(TSqlTokenType.Alter, new string[]
			{
				"SERVER",
				"ROLE"
			});
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.GenerateSpaceAndFragmentIfNotNull(node.Action);
		}

		// Token: 0x06000CBD RID: 3261 RVA: 0x0002324C File Offset: 0x0002144C
		public override void ExplicitVisit(AlterServiceMasterKeyStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Alter);
			this.GenerateSpaceAndIdentifier("SERVICE");
			this.GenerateSpaceAndIdentifier("MASTER");
			this.GenerateSpaceAndKeyword(TSqlTokenType.Key);
			this.GenerateSpace();
			switch (node.Kind)
			{
			case AlterServiceMasterKeyOption.Regenerate:
				this.GenerateIdentifier("REGENERATE");
				return;
			case AlterServiceMasterKeyOption.ForceRegenerate:
				this.GenerateIdentifier("FORCE");
				this.GenerateSpaceAndIdentifier("REGENERATE");
				return;
			case AlterServiceMasterKeyOption.WithOldAccount:
				this.GenerateWithClause(node, "OLD_ACCOUNT", "OLD_PASSWORD");
				return;
			case AlterServiceMasterKeyOption.WithNewAccount:
				this.GenerateWithClause(node, "NEW_ACCOUNT", "NEW_PASSWORD");
				return;
			default:
				return;
			}
		}

		// Token: 0x06000CBE RID: 3262 RVA: 0x000232EA File Offset: 0x000214EA
		private void GenerateWithClause(AlterServiceMasterKeyStatement node, string accountTitle, string passwordTitle)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.With);
			this.GenerateNameEqualsValue(accountTitle, node.Account);
			this.GenerateSymbolAndSpace(TSqlTokenType.Comma);
			this.GenerateNameEqualsValue(passwordTitle, node.Password);
		}

		// Token: 0x06000CBF RID: 3263 RVA: 0x0002331C File Offset: 0x0002151C
		public override void ExplicitVisit(AlterServiceStatement node)
		{
			this.GenerateSpaceSeparatedTokens(TSqlTokenType.Alter, new string[]
			{
				"SERVICE"
			});
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			if (node.QueueName != null)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.On);
				this.GenerateSpaceAndIdentifier("QUEUE");
				this.GenerateSpaceAndFragmentIfNotNull(node.QueueName);
			}
			if (node.ServiceContracts.Count > 0)
			{
				this.GenerateSpace();
				this.GenerateParenthesisedCommaSeparatedList<ServiceContract>(node.ServiceContracts);
			}
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x00023394 File Offset: 0x00021594
		public override void ExplicitVisit(AlterTableAddTableElementStatement node)
		{
			AlignmentPoint ap = new AlignmentPoint();
			this.MarkAndPushAlignmentPoint(ap);
			this.GenerateAlterTableHead(node);
			if (node.ExistingRowsCheckEnforcement != ConstraintEnforcement.NotSpecified)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.With);
				this.GenerateSpace();
				this.GenerateConstraintEnforcement(node.ExistingRowsCheckEnforcement);
			}
			this.NewLineAndIndent();
			this.GenerateKeyword(TSqlTokenType.Add);
			this.GenerateSpace();
			AlignmentPoint ap2 = new AlignmentPoint();
			this.MarkAndPushAlignmentPoint(ap2);
			this.GenerateCommaSeparatedList<ColumnDefinition>(node.Definition.ColumnDefinitions, true);
			if (node.Definition.ColumnDefinitions.Count > 0 && node.Definition.TableConstraints.Count > 0)
			{
				this.GenerateSymbolAndSpace(TSqlTokenType.Comma);
				this.NewLine();
			}
			if (node.Definition.TableConstraints.Count > 0)
			{
				this.GenerateCommaSeparatedList<ConstraintDefinition>(node.Definition.TableConstraints, true);
			}
			this.PopAlignmentPoint();
			this.PopAlignmentPoint();
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x00023474 File Offset: 0x00021674
		public override void ExplicitVisit(AlterTableAlterColumnStatement node)
		{
			this.GenerateAlterTableHead(node);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Alter);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Column);
			this.GenerateSpaceAndFragmentIfNotNull(node.ColumnIdentifier);
			if (node.DataType != null)
			{
				this.GenerateSpaceAndFragmentIfNotNull(node.DataType);
				this.GenerateSpaceAndCollation(node.Collation);
				this.GenerateFragmentIfNotNull(node.StorageOptions);
				switch (node.AlterTableAlterColumnOption)
				{
				case AlterTableAlterColumnOption.NoOptionDefined:
				case AlterTableAlterColumnOption.AddRowGuidCol:
				case AlterTableAlterColumnOption.DropRowGuidCol:
					break;
				case AlterTableAlterColumnOption.Null:
					this.GenerateSpaceAndKeyword(TSqlTokenType.Null);
					return;
				case AlterTableAlterColumnOption.NotNull:
					this.GenerateSpaceAndKeyword(TSqlTokenType.Not);
					this.GenerateSpaceAndKeyword(TSqlTokenType.Null);
					return;
				default:
					return;
				}
			}
			else
			{
				List<TokenGenerator> valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<AlterTableAlterColumnOption, List<TokenGenerator>>(SqlScriptGeneratorVisitor._alterTableAlterColumnOptionNames, node.AlterTableAlterColumnOption);
				if (valueForEnumKey != null)
				{
					this.GenerateSpace();
					this.GenerateTokenList(valueForEnumKey);
				}
			}
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x0002352C File Offset: 0x0002172C
		public override void ExplicitVisit(AlterTableChangeTrackingModificationStatement node)
		{
			this.GenerateAlterTableHead(node);
			this.GenerateSpaceAndIdentifier(node.IsEnable ? "ENABLE" : "DISABLE");
			this.GenerateSpaceAndIdentifier("CHANGE_TRACKING");
			if (node.TrackColumnsUpdated != OptionState.NotSet)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.With);
				this.GenerateSpaceAndSymbol(TSqlTokenType.LeftParenthesis);
				this.GenerateOptionStateWithEqualSign("TRACK_COLUMNS_UPDATED", node.TrackColumnsUpdated);
				this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			}
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x000235A0 File Offset: 0x000217A0
		public override void ExplicitVisit(AlterTableConstraintModificationStatement node)
		{
			this.GenerateAlterTableHead(node);
			if (node.ExistingRowsCheckEnforcement != ConstraintEnforcement.NotSpecified)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.With);
				this.GenerateSpace();
				this.GenerateConstraintEnforcement(node.ExistingRowsCheckEnforcement);
			}
			this.GenerateSpace();
			this.GenerateConstraintEnforcement(node.ConstraintEnforcement);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Constraint);
			this.GenerateSpace();
			if (node.All)
			{
				this.GenerateKeyword(TSqlTokenType.All);
				return;
			}
			this.GenerateCommaSeparatedList<Identifier>(node.ConstraintNames);
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x00023618 File Offset: 0x00021818
		public override void ExplicitVisit(AlterTableDropTableElement node)
		{
			TokenGenerator valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<TableElementType, TokenGenerator>(SqlScriptGeneratorVisitor._tableElementTypeGenerators, node.TableElementType);
			if (valueForEnumKey != null)
			{
				this.GenerateToken(valueForEnumKey);
			}
			if (node.TableElementType != TableElementType.NotSpecified)
			{
				this.GenerateSpace();
			}
			this.GenerateFragmentIfNotNull(node.Name);
			if (node.DropClusteredConstraintOptions.Count > 0)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.With);
				this.GenerateSpace();
				this.GenerateParenthesisedCommaSeparatedList<DropClusteredConstraintOption>(node.DropClusteredConstraintOptions);
			}
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x0002368B File Offset: 0x0002188B
		public override void ExplicitVisit(AlterTableDropTableElementStatement node)
		{
			this.GenerateAlterTableHead(node);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Drop);
			this.GenerateSpace();
			this.GenerateCommaSeparatedList<AlterTableDropTableElement>(node.AlterTableDropTableElements);
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x000236AE File Offset: 0x000218AE
		public override void ExplicitVisit(AlterTableFileTableNamespaceStatement node)
		{
			this.GenerateAlterTableHead(node);
			this.GenerateSpaceAndIdentifier(node.IsEnable ? "ENABLE" : "DISABLE");
			this.GenerateSpaceAndIdentifier("FILETABLE_NAMESPACE");
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x000236DC File Offset: 0x000218DC
		public override void ExplicitVisit(AlterTableRebuildStatement node)
		{
			this.GenerateAlterTableHead(node);
			this.GenerateSpaceAndIdentifier("REBUILD");
			this.GenerateSpaceAndFragmentIfNotNull(node.Partition);
			if (node.IndexOptions.Count > 0)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.With);
				this.GenerateSpace();
				this.GenerateParenthesisedCommaSeparatedList<IndexOption>(node.IndexOptions);
			}
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x00023732 File Offset: 0x00021932
		public override void ExplicitVisit(AlterTableSetStatement node)
		{
			this.GenerateAlterTableHead(node);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Set);
			this.GenerateSpace();
			this.GenerateParenthesisedCommaSeparatedList<TableOption>(node.Options);
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x00023758 File Offset: 0x00021958
		protected void GenerateAlterTableHead(AlterTableStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Alter);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Table);
			this.GenerateSpaceAndFragmentIfNotNull(node.SchemaObjectName);
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x00023778 File Offset: 0x00021978
		protected void GenerateConstraintEnforcement(ConstraintEnforcement enforcement)
		{
			switch (enforcement)
			{
			case ConstraintEnforcement.NotSpecified:
				break;
			case ConstraintEnforcement.NoCheck:
				this.GenerateKeyword(TSqlTokenType.NoCheck);
				return;
			case ConstraintEnforcement.Check:
				this.GenerateKeyword(TSqlTokenType.Check);
				break;
			default:
				return;
			}
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x000237AC File Offset: 0x000219AC
		public override void ExplicitVisit(AlterTableSwitchStatement node)
		{
			this.GenerateAlterTableHead(node);
			this.GenerateSpaceAndIdentifier("SWITCH");
			this.GenerateForPartitionIfNotNull(node.SourcePartitionNumber);
			this.GenerateSpaceAndKeyword(TSqlTokenType.To);
			this.GenerateSpaceAndFragmentIfNotNull(node.TargetTable);
			this.GenerateForPartitionIfNotNull(node.TargetPartitionNumber);
			if (this._options.SqlVersion >= SqlVersion.Sql120 && node.Options.Count > 0)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.With);
				this.GenerateSpace();
				this.GenerateParenthesisedCommaSeparatedList<TableSwitchOption>(node.Options);
			}
		}

		// Token: 0x06000CCC RID: 3276 RVA: 0x00023833 File Offset: 0x00021A33
		private void GenerateForPartitionIfNotNull(ScalarExpression expression)
		{
			if (expression != null)
			{
				this.GenerateSpaceAndIdentifier("PARTITION");
				this.GenerateSpaceAndFragmentIfNotNull(expression);
			}
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x0002384C File Offset: 0x00021A4C
		public override void ExplicitVisit(AlterTableTriggerModificationStatement node)
		{
			this.GenerateAlterTableHead(node);
			this.GenerateSpace();
			this.GenerateTriggerEnforcement(node.TriggerEnforcement);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Trigger);
			this.GenerateSpace();
			if (node.All)
			{
				this.GenerateKeyword(TSqlTokenType.All);
				return;
			}
			this.GenerateCommaSeparatedList<Identifier>(node.TriggerNames);
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x0002389F File Offset: 0x00021A9F
		public override void ExplicitVisit(AlterTriggerStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Alter);
			this.GenerateSpace();
			this.GenerateTriggerStatementBody(node);
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x000238B8 File Offset: 0x00021AB8
		public override void ExplicitVisit(AlterUserStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Alter);
			this.GenerateSpaceAndKeyword(TSqlTokenType.User);
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.NewLineAndIndent();
			this.GenerateKeyword(TSqlTokenType.With);
			this.GenerateSpace();
			this.GenerateCommaSeparatedList<PrincipalOption>(node.UserOptions);
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x00023906 File Offset: 0x00021B06
		public override void ExplicitVisit(AlterViewStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Alter);
			this.GenerateSpace();
			this.GenerateViewStatementBody(node);
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x0002391C File Offset: 0x00021B1C
		public override void ExplicitVisit(AlterWorkloadGroupStatement node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.Alter);
			this.GenerateWorkloadGroupStatementBody(node);
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x0002392C File Offset: 0x00021B2C
		public override void ExplicitVisit(AlterXmlSchemaCollectionStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Alter);
			this.GenerateSpaceAndIdentifier("XML");
			this.GenerateSpaceAndKeyword(TSqlTokenType.Schema);
			this.GenerateSpaceAndIdentifier("COLLECTION");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Add);
			this.GenerateSpaceAndFragmentIfNotNull(node.Expression);
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x00023980 File Offset: 0x00021B80
		public override void ExplicitVisit(ApplicationRoleOption node)
		{
			ApplicationRoleOptionHelper.Instance.GenerateSourceForOption(this._writer, node.OptionKind);
			this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
			this.GenerateSpaceAndFragmentIfNotNull(node.Value);
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x000239B0 File Offset: 0x00021BB0
		protected void GenerateApplicationRoleStatementBase(ApplicationRoleStatement node)
		{
			this.GenerateIdentifier("APPLICATION");
			this.GenerateSpaceAndIdentifier("ROLE");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.NewLineAndIndent();
			this.GenerateKeyword(TSqlTokenType.With);
			this.GenerateSpace();
			this.GenerateCommaSeparatedList<ApplicationRoleOption>(node.ApplicationRoleOptions);
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x00023A02 File Offset: 0x00021C02
		public override void ExplicitVisit(AssemblyName node)
		{
			this.GenerateFragmentIfNotNull(node.Name);
			if (node.ClassName != null)
			{
				this.GenerateSymbol(TSqlTokenType.Dot);
				this.GenerateFragmentIfNotNull(node.ClassName);
			}
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x00023A2F File Offset: 0x00021C2F
		public override void ExplicitVisit(AsymmetricKeyCreateLoginSource node)
		{
			this.GenerateKeyword(TSqlTokenType.From);
			this.GenerateSpaceAndIdentifier("ASYMMETRIC");
			this.GenerateSpaceAndKeyword(TSqlTokenType.Key);
			this.GenerateSpaceAndFragmentIfNotNull(node.Key);
			this.GenerateCredential(node.Credential);
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x00023A64 File Offset: 0x00021C64
		public override void ExplicitVisit(CreateAsymmetricKeyStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Create);
			this.GenerateAsymmetricKeyName(node.Name);
			this.GenerateOwnerIfNotNull(node.Owner);
			if (node.KeySource != null)
			{
				this.NewLineAndIndent();
				this.GenerateSpaceAndKeyword(TSqlTokenType.From);
				this.GenerateSpaceAndFragmentIfNotNull(node.KeySource);
			}
			if (node.EncryptionAlgorithm != EncryptionAlgorithm.None)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.With);
				this.GenerateSpace();
				this.GenerateTokenAndEqualSign("ALGORITHM");
				this.GenerateSpace();
				EncryptionAlgorithmsHelper.Instance.GenerateSourceForOption(this._writer, node.EncryptionAlgorithm);
			}
			if (node.Password != null)
			{
				this.NewLineAndIndent();
				this.GenerateIdentifier("ENCRYPTION");
				this.GenerateSpaceAndKeyword(TSqlTokenType.By);
				this.GenerateSpace();
				this.GenerateNameEqualsValue("PASSWORD", node.Password);
			}
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x00023B34 File Offset: 0x00021D34
		public override void ExplicitVisit(AlterAsymmetricKeyStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Alter);
			this.GenerateAsymmetricKeyName(node.Name);
			this.GenerateSpace();
			switch (node.Kind)
			{
			case AlterCertificateStatementKind.RemovePrivateKey:
				this.GenerateRemovePrivateKey();
				return;
			case AlterCertificateStatementKind.RemoveAttestedOption:
				this.GenerateRemoteAttestedOption();
				return;
			case AlterCertificateStatementKind.WithPrivateKey:
				this.GenerateWithPrivateKey(null, node.EncryptionPassword, node.DecryptionPassword);
				break;
			case AlterCertificateStatementKind.WithActiveForBeginDialog:
				break;
			case AlterCertificateStatementKind.AttestedBy:
				this.GenerateAttestedBy(node.AttestedBy);
				return;
			default:
				return;
			}
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x00023BAC File Offset: 0x00021DAC
		public override void ExplicitVisit(DropAsymmetricKeyStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Drop);
			this.GenerateAsymmetricKeyName(node.Name);
			this.GenerateRemoveProviderKeyOpt(node.RemoveProviderKey);
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x00023BCE File Offset: 0x00021DCE
		private void GenerateRemoveProviderKeyOpt(bool generate)
		{
			if (generate)
			{
				this.GenerateSpaceAndIdentifier("REMOVE");
				this.GenerateSpaceAndIdentifier("PROVIDER");
				this.GenerateSpaceAndKeyword(TSqlTokenType.Key);
			}
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x00023BF1 File Offset: 0x00021DF1
		private void GenerateAsymmetricKeyName(Identifier name)
		{
			this.GenerateSpaceAndIdentifier("ASYMMETRIC");
			this.GenerateSpaceAndKeyword(TSqlTokenType.Key);
			this.GenerateSpaceAndFragmentIfNotNull(name);
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x00023C0D File Offset: 0x00021E0D
		public override void ExplicitVisit(AuditActionGroupReference node)
		{
			ServerAuditActionGroupHelper.Instance.GenerateSourceForOption(this._writer, node.Group);
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x00023C25 File Offset: 0x00021E25
		public override void ExplicitVisit(AuditActionSpecification node)
		{
			this.GenerateCommaSeparatedList<DatabaseAuditAction>(node.Actions);
			this.GenerateSpaceAndFragmentIfNotNull(node.TargetObject);
			this.GenerateSpaceAndKeyword(TSqlTokenType.By);
			this.GenerateSpace();
			this.GenerateCommaSeparatedList<SecurityPrincipal>(node.Principals);
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x00023C59 File Offset: 0x00021E59
		public override void ExplicitVisit(AuditSpecificationPart node)
		{
			this.GenerateKeywordAndSpace(node.IsDrop ? TSqlTokenType.Drop : TSqlTokenType.Add);
			this.GenerateSymbol(TSqlTokenType.LeftParenthesis);
			this.GenerateFragmentIfNotNull(node.Details);
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x00023CA4 File Offset: 0x00021EA4
		protected void GenerateAuditSpecificationStatement(AuditSpecificationStatement node)
		{
			this.GenerateIdentifier("AUDIT");
			this.GenerateSpaceAndIdentifier("SPECIFICATION");
			this.GenerateSpaceAndFragmentIfNotNull(node.SpecificationName);
			if (node.AuditName != null || node is CreateServerAuditSpecificationStatement || node is CreateDatabaseAuditSpecificationStatement)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.For);
				this.GenerateSpaceAndIdentifier("SERVER");
				this.GenerateSpaceAndIdentifier("AUDIT");
				this.GenerateSpaceAndFragmentIfNotNull(node.AuditName);
			}
			if (node.Parts.Count > 0)
			{
				this.NewLineAndIndent();
			}
			this.GenerateList<AuditSpecificationPart>(node.Parts, delegate
			{
				this.GenerateSymbol(TSqlTokenType.Comma);
				this.NewLineAndIndent();
			});
			if (node.AuditState != OptionState.NotSet)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.With);
				this.GenerateSymbol(TSqlTokenType.LeftParenthesis);
				this.GenerateOptionStateWithEqualSign("STATE", node.AuditState);
				this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			}
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x00023D88 File Offset: 0x00021F88
		public override void ExplicitVisit(AuditTarget node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.To);
			switch (node.TargetKind)
			{
			case AuditTargetKind.File:
				this.GenerateKeywordAndSpace(TSqlTokenType.File);
				this.GenerateParenthesisedCommaSeparatedList<AuditTargetOption>(node.TargetOptions);
				return;
			case AuditTargetKind.ApplicationLog:
				this.GenerateIdentifier("APPLICATION_LOG");
				return;
			case AuditTargetKind.SecurityLog:
				this.GenerateIdentifier("SECURITY_LOG");
				return;
			default:
				return;
			}
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x00023DE8 File Offset: 0x00021FE8
		public override void ExplicitVisit(MaxSizeAuditTargetOption node)
		{
			this.GenerateTokenAndEqualSign("MAXSIZE");
			if (node.IsUnlimited)
			{
				this.GenerateSpaceAndIdentifier("UNLIMITED");
				return;
			}
			this.GenerateSpaceAndFragmentIfNotNull(node.Size);
			this.GenerateSpace();
			MemoryUnitsHelper.Instance.GenerateSourceForOption(this._writer, node.Unit);
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x00023E3C File Offset: 0x0002203C
		public override void ExplicitVisit(MaxRolloverFilesAuditTargetOption node)
		{
			this.GenerateTokenAndEqualSign("MAX_ROLLOVER_FILES");
			if (node.IsUnlimited)
			{
				this.GenerateSpaceAndIdentifier("UNLIMITED");
				return;
			}
			this.GenerateSpaceAndFragmentIfNotNull(node.Value);
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x00023E6C File Offset: 0x0002206C
		public override void ExplicitVisit(LiteralAuditTargetOption node)
		{
			AuditTargetOptionKind optionKind = node.OptionKind;
			if (optionKind == AuditTargetOptionKind.FilePath)
			{
				this.GenerateNameEqualsValue("FILEPATH", node.Value);
				return;
			}
			if (optionKind != AuditTargetOptionKind.MaxFiles)
			{
				return;
			}
			this.GenerateNameEqualsValue("MAX_FILES", node.Value);
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x00023EAC File Offset: 0x000220AC
		public override void ExplicitVisit(OnOffAuditTargetOption node)
		{
			this.GenerateOptionStateWithEqualSign("RESERVE_DISK_SPACE", node.Value);
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x00023EBF File Offset: 0x000220BF
		public override void ExplicitVisit(AuthenticationEndpointProtocolOption node)
		{
			this.GenerateIdentifier("AUTHENTICATION");
			this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
			this.GenerateSpaceAndSymbol(TSqlTokenType.LeftParenthesis);
			this.GenerateCommaSeparatedFlagOpitons<AuthenticationTypes>(SqlScriptGeneratorVisitor._authenticationTypesGenerators, node.AuthenticationTypes);
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x00023F00 File Offset: 0x00022100
		public override void ExplicitVisit(AuthenticationPayloadOption node)
		{
			this.GenerateTokenAndEqualSign("AUTHENTICATION");
			this.GenerateCertificateForAuthenticationPayloadOption(node.TryCertificateFirst, node.Certificate);
			if (node.Protocol != AuthenticationProtocol.NotSpecified)
			{
				this.GenerateSpaceAndIdentifier("WINDOWS");
				if (node.Protocol != AuthenticationProtocol.Windows)
				{
					string valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<AuthenticationProtocol, string>(SqlScriptGeneratorVisitor._authenticationProtocolNames, node.Protocol);
					if (valueForEnumKey != null)
					{
						this.GenerateSpaceAndIdentifier(valueForEnumKey);
					}
				}
			}
			this.GenerateCertificateForAuthenticationPayloadOption(!node.TryCertificateFirst, node.Certificate);
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x00023F76 File Offset: 0x00022176
		protected void GenerateCertificateForAuthenticationPayloadOption(bool generate, Identifier certificateName)
		{
			if (generate && certificateName != null)
			{
				this.GenerateSpaceAndIdentifier("CERTIFICATE");
				this.GenerateSpaceAndFragmentIfNotNull(certificateName);
			}
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x00023F90 File Offset: 0x00022190
		public override void ExplicitVisit(AutoCleanupChangeTrackingOptionDetail node)
		{
			this.GenerateIdentifier("AUTO_CLEANUP");
			this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
			this.GenerateSpaceAndKeyword(node.IsOn ? TSqlTokenType.On : TSqlTokenType.Off);
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x00023FBC File Offset: 0x000221BC
		public override void ExplicitVisit(AutoCreateStatisticsDatabaseOption node)
		{
			OnOffSimpleDbOptionsHelper.Instance.GenerateSourceForOption(this._writer, node.OptionKind);
			this.GenerateSpace();
			this.GenerateOptionStateOnOff(node.OptionState);
			if (node.HasIncremental)
			{
				this.GenerateSymbol(TSqlTokenType.LeftParenthesis);
				this.GenerateIdentifier("INCREMENTAL");
				this.GenerateSpace();
				this.GenerateKeywordAndSpace(TSqlTokenType.EqualsSign);
				this.GenerateOptionStateOnOff(node.IncrementalState);
				this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			}
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x00024038 File Offset: 0x00022238
		public override void ExplicitVisit(AvailabilityReplica node)
		{
			this.GenerateFragmentIfNotNull(node.ServerName);
			if (node.Options != null && node.Options.Count > 0)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.With);
				this.GenerateSpace();
				this.GenerateParenthesisedCommaSeparatedList<AvailabilityReplicaOption>(node.Options);
			}
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x00024084 File Offset: 0x00022284
		public override void ExplicitVisit(AvailabilityModeReplicaOption node)
		{
			string value = (node.Value == AvailabilityModeOptionKind.AsynchronousCommit) ? "ASYNCHRONOUS_COMMIT" : "SYNCHRONOUS_COMMIT";
			this.GenerateNameEqualsValue("AVAILABILITY_MODE", value);
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x000240B4 File Offset: 0x000222B4
		public override void ExplicitVisit(FailoverModeReplicaOption node)
		{
			string value = (node.Value == FailoverModeOptionKind.Automatic) ? "AUTOMATIC" : "MANUAL";
			this.GenerateNameEqualsValue("FAILOVER_MODE", value);
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x000240E2 File Offset: 0x000222E2
		public override void ExplicitVisit(LiteralReplicaOption node)
		{
			AvailabilityReplicaOptionsHelper.Instance.GenerateSourceForOption(this._writer, node.OptionKind);
			this.GenerateSpaceAndKeyword(TSqlTokenType.EqualsSign);
			this.GenerateSpaceAndFragmentIfNotNull(node.Value);
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x00024114 File Offset: 0x00022314
		public override void ExplicitVisit(SecondaryRoleReplicaOption node)
		{
			this.GenerateIdentifier("SECONDARY_ROLE");
			this.GenerateSpaceAndKeyword(TSqlTokenType.LeftParenthesis);
			this.GenerateIdentifier("ALLOW_CONNECTIONS");
			this.GenerateSpaceAndKeyword(TSqlTokenType.EqualsSign);
			this.GenerateSpace();
			AllowConnectionsOptionsHelper.Instance.GenerateSourceForOption(this._writer, node.AllowConnections);
			this.GenerateKeyword(TSqlTokenType.RightParenthesis);
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x00024174 File Offset: 0x00022374
		public override void ExplicitVisit(PrimaryRoleReplicaOption node)
		{
			this.GenerateIdentifier("PRIMARY_ROLE");
			this.GenerateSpaceAndKeyword(TSqlTokenType.LeftParenthesis);
			this.GenerateIdentifier("ALLOW_CONNECTIONS");
			this.GenerateSpaceAndKeyword(TSqlTokenType.EqualsSign);
			this.GenerateSpace();
			AllowConnectionsOptionsHelper.Instance.GenerateSourceForOption(this._writer, node.AllowConnections);
			this.GenerateKeyword(TSqlTokenType.RightParenthesis);
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x000241D4 File Offset: 0x000223D4
		public override void ExplicitVisit(BackupCertificateStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Backup);
			this.GenerateSpaceAndIdentifier("CERTIFICATE");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.GenerateSpaceAndKeyword(TSqlTokenType.To);
			this.GenerateSpace();
			this.GenerateNameEqualsValue(TSqlTokenType.File, node.File);
			if (node.PrivateKeyPath != null || node.DecryptionPassword != null || node.EncryptionPassword != null)
			{
				this.NewLineAndIndent();
				this.GenerateWithPrivateKey(node.PrivateKeyPath, node.EncryptionPassword, node.DecryptionPassword);
			}
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x00024258 File Offset: 0x00022458
		public override void ExplicitVisit(BackupDatabaseStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Backup);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Database);
			this.GenerateSpaceAndFragmentIfNotNull(node.DatabaseName);
			if (node.Files != null && node.Files.Count > 0)
			{
				this.NewLineAndIndent();
				this.GenerateCommaSeparatedList<BackupRestoreFileInfo>(node.Files);
			}
			this.GenerateDeviceAndOption(node);
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x000242B0 File Offset: 0x000224B0
		public override void ExplicitVisit(BackupOption node)
		{
			if (BackupOptionsWithValueHelper.Instance.TryGenerateSourceForOption(this._writer, node.OptionKind))
			{
				if (node.Value != null)
				{
					this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
					this.GenerateSpaceAndFragmentIfNotNull(node.Value);
					return;
				}
			}
			else
			{
				BackupOptionsNoValueHelper.Instance.GenerateSourceForOption(this._writer, node.OptionKind);
			}
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x0002430C File Offset: 0x0002250C
		public override void ExplicitVisit(BackupEncryptionOption node)
		{
			if (this._options.SqlVersion < SqlVersion.Sql120)
			{
				return;
			}
			this.GenerateIdentifier("ENCRYPTION");
			this.GenerateSymbol(TSqlTokenType.LeftParenthesis);
			this.GenerateIdentifier("ALGORITHM");
			this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
			this.GenerateSpace();
			EncryptionAlgorithmsHelper.Instance.GenerateSourceForOption(this._writer, node.Algorithm);
			this.GenerateSymbol(TSqlTokenType.Comma);
			if (node.Encryptor != null)
			{
				this.GenerateSpaceAndIdentifier("SERVER");
				this.GenerateSpace();
				switch (node.Encryptor.CryptoMechanismType)
				{
				case CryptoMechanismType.Certificate:
					this.GenerateIdentifier("CERTIFICATE");
					break;
				case CryptoMechanismType.AsymmetricKey:
					this.GenerateIdentifier("ASYMMETRIC");
					this.GenerateSpaceAndKeyword(TSqlTokenType.Key);
					break;
				}
				this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
				this.GenerateSpaceAndFragmentIfNotNull(node.Encryptor.Identifier);
			}
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x000243F8 File Offset: 0x000225F8
		public override void ExplicitVisit(BackupMasterKeyStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Backup);
			this.GenerateSpaceAndIdentifier("MASTER");
			this.GenerateSpaceAndKeyword(TSqlTokenType.Key);
			this.GenerateSpaceAndKeyword(TSqlTokenType.To);
			this.GenerateSpace();
			this.GenerateNameEqualsValue(TSqlTokenType.File, node.File);
			this.GenerateSpace();
			this.GenerateEncryptionByPassword(node.Password);
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x00024454 File Offset: 0x00022654
		public override void ExplicitVisit(BackupRestoreFileInfo node)
		{
			switch (node.ItemKind)
			{
			case BackupRestoreItemKind.None:
				break;
			case BackupRestoreItemKind.Files:
				this.GenerateKeywordAndSpace(TSqlTokenType.File);
				this.GenerateItems(node.Items);
				return;
			case BackupRestoreItemKind.FileGroups:
				this.GenerateIdentifier("FILEGROUP");
				this.GenerateSpace();
				this.GenerateItems(node.Items);
				break;
			case BackupRestoreItemKind.Page:
				if (node.Items.Count == 1)
				{
					this.GenerateIdentifier("PAGE");
					this.GenerateSpace();
					this.GenerateItems(node.Items);
					return;
				}
				break;
			case BackupRestoreItemKind.ReadWriteFileGroups:
				this.GenerateIdentifier("READ_WRITE_FILEGROUPS");
				return;
			default:
				return;
			}
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x000244ED File Offset: 0x000226ED
		private void GenerateItems(IList<ValueExpression> items)
		{
			if (items != null)
			{
				this.GenerateSymbolAndSpace(TSqlTokenType.EqualsSign);
				if (items.Count == 1)
				{
					this.GenerateFragmentIfNotNull(items[0]);
					return;
				}
				this.GenerateParenthesisedCommaSeparatedList<ValueExpression>(items);
			}
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x0002451C File Offset: 0x0002271C
		protected void GenerateCommonRestorePart(BackupRestoreMasterKeyStatementBase node, bool isService)
		{
			this.GenerateKeyword(TSqlTokenType.Restore);
			if (isService)
			{
				this.GenerateSpaceAndIdentifier("SERVICE");
			}
			this.GenerateSpaceAndIdentifier("MASTER");
			this.GenerateSpaceAndKeyword(TSqlTokenType.Key);
			this.GenerateSpaceAndKeyword(TSqlTokenType.From);
			this.GenerateSpace();
			this.GenerateNameEqualsValue(TSqlTokenType.File, node.File);
			this.GenerateSpace();
			this.GenerateDecryptionByPassword(node.Password);
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x00024584 File Offset: 0x00022784
		public override void ExplicitVisit(BackupServiceMasterKeyStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Backup);
			this.GenerateSpaceAndIdentifier("SERVICE");
			this.GenerateSpaceAndIdentifier("MASTER");
			this.GenerateSpaceAndKeyword(TSqlTokenType.Key);
			this.GenerateSpaceAndKeyword(TSqlTokenType.To);
			this.GenerateSpace();
			this.GenerateNameEqualsValue(TSqlTokenType.File, node.File);
			this.GenerateSpace();
			this.GenerateEncryptionByPassword(node.Password);
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x000245E8 File Offset: 0x000227E8
		protected void GenerateDeviceAndOption(BackupStatement node)
		{
			if (node.Devices.Count > 0)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.To);
				this.GenerateSpace();
				this.GenerateCommaSeparatedList<DeviceInfo>(node.Devices);
				if (node.MirrorToClauses != null)
				{
					foreach (MirrorToClause fragment in node.MirrorToClauses)
					{
						this.NewLineAndIndent();
						this.GenerateFragmentIfNotNull(fragment);
					}
				}
			}
			if (node.Options.Count > 0)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.With);
				this.GenerateSpace();
				this.GenerateCommaSeparatedList<BackupOption>(node.Options);
			}
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x000246A8 File Offset: 0x000228A8
		public override void ExplicitVisit(BackupTransactionLogStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Backup);
			this.GenerateSpaceAndIdentifier("LOG");
			this.GenerateSpaceAndFragmentIfNotNull(node.DatabaseName);
			this.GenerateDeviceAndOption(node);
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x000246D0 File Offset: 0x000228D0
		public override void ExplicitVisit(BackwardsCompatibleDropIndexClause node)
		{
			this.GenerateFragmentIfNotNull(node.Index);
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x000246E0 File Offset: 0x000228E0
		public override void ExplicitVisit(BeginConversationTimerStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Begin);
			this.GenerateSpaceAndIdentifier("CONVERSATION");
			this.GenerateSpaceAndIdentifier("TIMER");
			this.GenerateSpace();
			this.GenerateParenthesisedFragmentIfNotNull(node.Handle);
			this.GenerateSpace();
			this.GenerateNameEqualsValue("TIMEOUT", node.Timeout);
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x00024734 File Offset: 0x00022934
		public override void ExplicitVisit(BeginDialogStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Begin);
			this.GenerateSpaceAndIdentifier("DIALOG");
			if (node.IsConversation)
			{
				this.GenerateSpaceAndIdentifier("CONVERSATION");
			}
			this.GenerateSpaceAndFragmentIfNotNull(node.Handle);
			this.NewLineAndIndent();
			this.GenerateKeyword(TSqlTokenType.From);
			this.GenerateSpaceAndIdentifier("SERVICE");
			this.GenerateSpaceAndFragmentIfNotNull(node.InitiatorServiceName);
			this.NewLineAndIndent();
			this.GenerateKeyword(TSqlTokenType.To);
			this.GenerateSpaceAndIdentifier("SERVICE");
			this.GenerateSpaceAndFragmentIfNotNull(node.TargetServiceName);
			if (node.InstanceSpec != null)
			{
				this.GenerateSymbol(TSqlTokenType.Comma);
				this.GenerateSpaceAndFragmentIfNotNull(node.InstanceSpec);
			}
			if (node.ContractName != null)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.On);
				this.GenerateSpaceAndIdentifier("CONTRACT");
				this.GenerateSpaceAndFragmentIfNotNull(node.ContractName);
			}
			this.GenerateDialogOptions(node.Options);
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x00024818 File Offset: 0x00022A18
		private void GenerateDialogOptions(IList<DialogOption> options)
		{
			if (options != null && options.Count > 0)
			{
				this.NewLineAndIndent();
				this.GenerateKeywordAndSpace(TSqlTokenType.With);
				this.GenerateCommaSeparatedList<DialogOption>(options);
			}
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x0002483E File Offset: 0x00022A3E
		public override void ExplicitVisit(OnOffDialogOption node)
		{
			this.GenerateOptionStateWithEqualSign("ENCRYPTION", node.OptionState);
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x00024854 File Offset: 0x00022A54
		public override void ExplicitVisit(ScalarExpressionDialogOption node)
		{
			string valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<DialogOptionKind, string>(SqlScriptGeneratorVisitor._dialogOptionNames, node.OptionKind);
			this.GenerateNameEqualsValue(valueForEnumKey, node.Value);
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x00024880 File Offset: 0x00022A80
		public override void ExplicitVisit(BeginEndBlockStatement node)
		{
			AlignmentPoint ap = new AlignmentPoint();
			this.GenerateKeyword(TSqlTokenType.Begin);
			this.NewLineAndIndent();
			this.MarkAndPushAlignmentPoint(ap);
			this.GenerateFragmentIfNotNull(node.StatementList);
			this.PopAlignmentPoint();
			this.NewLine();
			this.GenerateKeyword(TSqlTokenType.End);
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x000248C8 File Offset: 0x00022AC8
		public override void ExplicitVisit(BeginEndAtomicBlockStatement node)
		{
			AlignmentPoint ap = new AlignmentPoint();
			this.GenerateKeyword(TSqlTokenType.Begin);
			this.GenerateSpaceAndIdentifier("ATOMIC");
			this.GenerateCommaSeparatedWithClause<AtomicBlockOption>(node.Options, false, true);
			this.NewLineAndIndent();
			this.MarkAndPushAlignmentPoint(ap);
			this.GenerateFragmentIfNotNull(node.StatementList);
			this.PopAlignmentPoint();
			this.NewLine();
			this.GenerateKeyword(TSqlTokenType.End);
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x00024929 File Offset: 0x00022B29
		public override void ExplicitVisit(LiteralAtomicBlockOption node)
		{
			AtomicBlockOptionHelper.Instance.GenerateSourceForOption(this._writer, node.OptionKind);
			this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
			this.GenerateSpace();
			this.GenerateFragmentIfNotNull(node.Value);
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x0002495E File Offset: 0x00022B5E
		public override void ExplicitVisit(IdentifierAtomicBlockOption node)
		{
			if (node.Value != null)
			{
				AtomicBlockOptionHelper.Instance.GenerateSourceForOption(this._writer, node.OptionKind);
				this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
				this.GenerateSpaceAndIdentifier(node.Value.Value);
			}
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x0002499A File Offset: 0x00022B9A
		public override void ExplicitVisit(OnOffAtomicBlockOption node)
		{
			this.GenerateOptionStateWithEqualSign("DELAYED_DURABILITY", node.OptionState);
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x000249B0 File Offset: 0x00022BB0
		public override void ExplicitVisit(BeginTransactionStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Begin);
			if (node.Distributed)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.Distributed);
			}
			this.GenerateSpaceAndKeyword(TSqlTokenType.Transaction);
			if (node.Name != null)
			{
				this.GenerateSpace();
				this.GenerateTransactionName(node.Name);
			}
			if (node.MarkDefined)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.With);
				this.GenerateSpaceAndIdentifier("MARK");
				this.GenerateSpaceAndFragmentIfNotNull(node.MarkDescription);
			}
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x00024A2C File Offset: 0x00022C2C
		public override void ExplicitVisit(BinaryExpression node)
		{
			AlignmentPoint ap = new AlignmentPoint();
			this.MarkAndPushAlignmentPoint(ap);
			this.GenerateFragmentIfNotNull(node.FirstExpression);
			this.GenerateSpace();
			this.GenerateBinaryOperator(node.BinaryExpressionType);
			this.GenerateSpaceAndFragmentIfNotNull(node.SecondExpression);
			this.PopAlignmentPoint();
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x00024A78 File Offset: 0x00022C78
		public override void ExplicitVisit(BinaryQueryExpression node)
		{
			AlignmentPoint alignmentPointForFragment = this.GetAlignmentPointForFragment(node, "ClauseBody");
			this.GenerateBinaryQueryExpression(node, alignmentPointForFragment, null);
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x00024A9C File Offset: 0x00022C9C
		public void GenerateBinaryQueryExpression(BinaryQueryExpression node, AlignmentPoint clauseBody, SchemaObjectName intoClause)
		{
			AlignmentPoint ap = new AlignmentPoint();
			this.MarkAndPushAlignmentPoint(ap);
			this.GenerateQueryExpression(node.FirstQueryExpression, clauseBody, intoClause);
			TokenGenerator valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<BinaryQueryExpressionType, TokenGenerator>(SqlScriptGeneratorVisitor._binaryQueryExpressionTypeGenerators, node.BinaryQueryExpressionType);
			if (valueForEnumKey != null)
			{
				this.NewLine();
				this.GenerateToken(valueForEnumKey);
			}
			if (node.All)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.All);
			}
			if (node.SecondQueryExpression != null)
			{
				this.NewLine();
				AlignmentPoint ap2 = new AlignmentPoint();
				this.MarkAndPushAlignmentPoint(ap2);
				this.GenerateFragmentWithAlignmentPointIfNotNull(node.SecondQueryExpression, clauseBody);
				this.PopAlignmentPoint();
			}
			this.PopAlignmentPoint();
			if (node.OrderByClause != null)
			{
				this.GenerateSeparatorForOrderBy();
				this.GenerateFragmentWithAlignmentPointIfNotNull(node.OrderByClause, clauseBody);
			}
			if (node.OffsetClause != null)
			{
				this.GenerateSeparatorForOffsetClause();
				this.GenerateFragmentWithAlignmentPointIfNotNull(node.OffsetClause, clauseBody);
			}
			if (node.ForClause != null)
			{
				this.NewLine();
				this.GenerateKeyword(TSqlTokenType.For);
				this.MarkClauseBodyAlignmentWhenNecessary(true, clauseBody);
				this.GenerateSpace();
				AlignmentPoint ap3 = new AlignmentPoint();
				this.MarkAndPushAlignmentPoint(ap3);
				this.GenerateFragmentIfNotNull(node.ForClause);
				this.PopAlignmentPoint();
			}
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x00024BA4 File Offset: 0x00022DA4
		public override void ExplicitVisit(BooleanBinaryExpression node)
		{
			AlignmentPoint ap = new AlignmentPoint();
			this.MarkAndPushAlignmentPoint(ap);
			this.GenerateFragmentIfNotNull(node.FirstExpression);
			bool newline = this.RightPredicateOnNewline(node);
			this.GenerateNewLineOrSpace(newline);
			this.GenerateBinaryOperator(node.BinaryExpressionType);
			this.GenerateSpaceAndFragmentIfNotNull(node.SecondExpression);
			this.PopAlignmentPoint();
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x00024BF8 File Offset: 0x00022DF8
		private bool RightPredicateOnNewline(BooleanBinaryExpression node)
		{
			return this._options.MultilineWherePredicatesList && this._options.NewLineBeforeWhereClause && (node.BinaryExpressionType == BooleanBinaryExpressionType.And || node.BinaryExpressionType == BooleanBinaryExpressionType.Or);
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x00024C38 File Offset: 0x00022E38
		public override void ExplicitVisit(BooleanComparisonExpression node)
		{
			AlignmentPoint ap = new AlignmentPoint();
			this.MarkAndPushAlignmentPoint(ap);
			this.GenerateFragmentIfNotNull(node.FirstExpression);
			this.GenerateSpace();
			this.GenerateBinaryOperator(node.ComparisonType);
			this.GenerateSpaceAndFragmentIfNotNull(node.SecondExpression);
			this.PopAlignmentPoint();
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x00024C82 File Offset: 0x00022E82
		public override void ExplicitVisit(BooleanIsNullExpression node)
		{
			this.GenerateFragmentIfNotNull(node.Expression);
			this.GenerateSpace();
			this.GenerateKeywordAndSpace(TSqlTokenType.Is);
			if (node.IsNot)
			{
				this.GenerateKeywordAndSpace(TSqlTokenType.Not);
			}
			this.GenerateKeyword(TSqlTokenType.Null);
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x00024CB6 File Offset: 0x00022EB6
		public override void ExplicitVisit(BooleanNotExpression node)
		{
			this.GenerateToken(new KeywordGenerator(TSqlTokenType.Not));
			this.GenerateSpace();
			this.GenerateFragmentIfNotNull(node.Expression);
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x00024CD7 File Offset: 0x00022ED7
		public override void ExplicitVisit(BooleanParenthesisExpression node)
		{
			this.GenerateSymbol(TSqlTokenType.LeftParenthesis);
			this.GenerateFragmentIfNotNull(node.Expression);
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x00024CFC File Offset: 0x00022EFC
		public override void ExplicitVisit(BooleanTernaryExpression node)
		{
			this.GenerateFragmentIfNotNull(node.FirstExpression);
			List<TokenGenerator> valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<BooleanTernaryExpressionType, List<TokenGenerator>>(SqlScriptGeneratorVisitor._ternaryExpressionTypeGenerators, node.TernaryExpressionType);
			if (valueForEnumKey != null)
			{
				this.GenerateSpace();
				this.GenerateTokenList(valueForEnumKey);
			}
			this.GenerateSpaceAndFragmentIfNotNull(node.SecondExpression);
			this.GenerateSpaceAndKeyword(TSqlTokenType.And);
			this.GenerateSpaceAndFragmentIfNotNull(node.ThirdExpression);
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x00024D55 File Offset: 0x00022F55
		public override void ExplicitVisit(BreakStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Break);
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x00024D60 File Offset: 0x00022F60
		public override void ExplicitVisit(BrokerPriorityParameter node)
		{
			BrokerPriorityParameterHelper.Instance.GenerateSourceForOption(this._writer, node.ParameterType);
			this.GenerateSpaceAndKeyword(TSqlTokenType.EqualsSign);
			switch (node.IsDefaultOrAny)
			{
			case BrokerPriorityParameterSpecialType.None:
				this.GenerateSpaceAndFragmentIfNotNull(node.ParameterValue);
				return;
			case BrokerPriorityParameterSpecialType.Any:
				this.GenerateSpaceAndKeyword(TSqlTokenType.Any);
				return;
			case BrokerPriorityParameterSpecialType.Default:
				this.GenerateSpaceAndKeyword(TSqlTokenType.Default);
				return;
			default:
				return;
			}
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x00024DC8 File Offset: 0x00022FC8
		protected void GenerateBrokerPriorityStatementBody(BrokerPriorityStatement node)
		{
			AlignmentPoint ap = new AlignmentPoint();
			this.GenerateIdentifier("BROKER");
			this.GenerateSpaceAndIdentifier("PRIORITY");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.GenerateSpaceAndKeyword(TSqlTokenType.For);
			this.GenerateSpaceAndIdentifier("CONVERSATION");
			if (node.BrokerPriorityParameters != null && node.BrokerPriorityParameters.Count > 0)
			{
				this.NewLineAndIndent();
				this.MarkAndPushAlignmentPoint(ap);
				this.GenerateKeyword(TSqlTokenType.Set);
				this.GenerateSpace();
				this.GenerateAlignedParenthesizedOptionsWithMultipleIndent<BrokerPriorityParameter>(node.BrokerPriorityParameters, 2);
				this.PopAlignmentPoint();
			}
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x00024E57 File Offset: 0x00023057
		public override void ExplicitVisit(BrowseForClause node)
		{
			this.GenerateKeyword(TSqlTokenType.Browse);
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x00024E61 File Offset: 0x00023061
		public override void ExplicitVisit(BuiltInFunctionTableReference node)
		{
			this.GenerateSymbol(TSqlTokenType.DoubleColon);
			this.GenerateFragmentIfNotNull(node.Name);
			this.GenerateSpace();
			this.GenerateParenthesisedCommaSeparatedList<ScalarExpression>(node.Parameters, true);
			this.GenerateSpaceAndAlias(node.Alias);
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x00024E99 File Offset: 0x00023099
		protected void GenerateOption(BulkInsertBase node)
		{
			if (node.Options.Count > 0)
			{
				this.NewLineAndIndent();
				this.GenerateKeywordAndSpace(TSqlTokenType.With);
				this.GenerateParenthesisedCommaSeparatedList<BulkInsertOption>(node.Options);
			}
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x00024EC6 File Offset: 0x000230C6
		public override void ExplicitVisit(OrderBulkInsertOption node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.Order);
			this.GenerateParenthesisedCommaSeparatedList<ColumnWithSortOrder>(node.Columns);
			if (node.IsUnique)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.Unique);
			}
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x00024EEF File Offset: 0x000230EF
		public override void ExplicitVisit(BulkInsertOption node)
		{
			if (OpenRowsetBulkHintOptionsHelper.Instance.TryGenerateSourceForOption(this._writer, node.OptionKind))
			{
				return;
			}
			BulkInsertFlagOptionsHelper.Instance.GenerateSourceForOption(this._writer, node.OptionKind);
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x00024F20 File Offset: 0x00023120
		public override void ExplicitVisit(LiteralBulkInsertOption node)
		{
			if (BulkInsertIntOptionsHelper.Instance.TryGenerateSourceForOption(this._writer, node.OptionKind))
			{
				this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
				this.GenerateSpaceAndFragmentIfNotNull(node.Value);
				return;
			}
			if (BulkInsertStringOptionsHelper.Instance.TryGenerateSourceForOption(this._writer, node.OptionKind))
			{
				this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
				this.GenerateSpaceAndFragmentIfNotNull(node.Value);
			}
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x00024F8C File Offset: 0x0002318C
		public override void ExplicitVisit(BulkInsertStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Bulk);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Insert);
			this.GenerateSpaceAndFragmentIfNotNull(node.To);
			this.GenerateSpaceAndKeyword(TSqlTokenType.From);
			this.GenerateSpaceAndFragmentIfNotNull(node.From);
			this.GenerateOption(node);
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x00024FC8 File Offset: 0x000231C8
		public override void ExplicitVisit(BulkOpenRowset node)
		{
			this.GenerateKeyword(TSqlTokenType.OpenRowSet);
			this.GenerateSpaceAndSymbol(TSqlTokenType.LeftParenthesis);
			this.GenerateKeyword(TSqlTokenType.Bulk);
			this.GenerateSpaceAndFragmentIfNotNull(node.DataFile);
			if (node.Options.Count > 0)
			{
				this.GenerateSymbol(TSqlTokenType.Comma);
				this.GenerateSpace();
				this.GenerateCommaSeparatedList<BulkInsertOption>(node.Options);
			}
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			this.GenerateTableAndColumnAliases(node);
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x00025039 File Offset: 0x00023239
		public override void ExplicitVisit(ExpressionCallTarget node)
		{
			this.GenerateFragmentIfNotNull(node.Expression);
			this.GenerateSymbol(TSqlTokenType.Dot);
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x00025052 File Offset: 0x00023252
		public override void ExplicitVisit(MultiPartIdentifierCallTarget node)
		{
			this.GenerateFragmentIfNotNull(node.MultiPartIdentifier);
			this.GenerateSymbol(TSqlTokenType.Dot);
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x0002506B File Offset: 0x0002326B
		public override void ExplicitVisit(UserDefinedTypeCallTarget node)
		{
			this.GenerateFragmentIfNotNull(node.SchemaObjectName);
			this.GenerateSymbol(TSqlTokenType.DoubleColon);
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x00025084 File Offset: 0x00023284
		public override void ExplicitVisit(SimpleCaseExpression node)
		{
			this.GenerateKeyword(TSqlTokenType.Case);
			this.GenerateSpaceAndFragmentIfNotNull(node.InputExpression);
			foreach (SimpleWhenClause fragment in node.WhenClauses)
			{
				this.GenerateSpaceAndFragmentIfNotNull(fragment);
			}
			if (node.ElseExpression != null)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.Else);
				this.GenerateSpaceAndFragmentIfNotNull(node.ElseExpression);
			}
			this.GenerateSpaceAndKeyword(TSqlTokenType.End);
			this.GenerateSpaceAndCollation(node.Collation);
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x00025118 File Offset: 0x00023318
		public override void ExplicitVisit(SearchedCaseExpression node)
		{
			this.GenerateKeyword(TSqlTokenType.Case);
			foreach (SearchedWhenClause fragment in node.WhenClauses)
			{
				this.GenerateSpaceAndFragmentIfNotNull(fragment);
			}
			if (node.ElseExpression != null)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.Else);
				this.GenerateSpaceAndFragmentIfNotNull(node.ElseExpression);
			}
			this.GenerateSpaceAndKeyword(TSqlTokenType.End);
			this.GenerateSpaceAndCollation(node.Collation);
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x000251A0 File Offset: 0x000233A0
		public override void ExplicitVisit(CastCall node)
		{
			this.GenerateIdentifier("CAST");
			this.GenerateSpaceAndSymbol(TSqlTokenType.LeftParenthesis);
			this.GenerateFragmentIfNotNull(node.Parameter);
			this.GenerateSpaceAndKeyword(TSqlTokenType.As);
			this.GenerateSpaceAndFragmentIfNotNull(node.DataType);
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			this.GenerateSpaceAndCollation(node.Collation);
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x000251FA File Offset: 0x000233FA
		public override void ExplicitVisit(CertificateCreateLoginSource node)
		{
			this.GenerateKeyword(TSqlTokenType.From);
			this.GenerateSpaceAndIdentifier("CERTIFICATE");
			this.GenerateSpaceAndFragmentIfNotNull(node.Certificate);
			this.GenerateCredential(node.Credential);
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x00025228 File Offset: 0x00023428
		public override void ExplicitVisit(CertificateOption node)
		{
			string valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<CertificateOptionKinds, string>(SqlScriptGeneratorVisitor._certificateOptionNames, node.Kind);
			if (valueForEnumKey != null)
			{
				this.GenerateNameEqualsValue(valueForEnumKey, node.Value);
			}
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x00025258 File Offset: 0x00023458
		public override void ExplicitVisit(ChangeRetentionChangeTrackingOptionDetail node)
		{
			this.GenerateIdentifier("CHANGE_RETENTION");
			this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
			this.GenerateSpace();
			this.GenerateFragmentIfNotNull(node.RetentionPeriod);
			this.GenerateSpace();
			RetentionUnitHelper.Instance.GenerateSourceForOption(this._writer, node.Unit);
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x000252A9 File Offset: 0x000234A9
		protected void GenerateChangeTablePrefix(SchemaObjectName target, string changeTableKind)
		{
			this.GenerateIdentifier("CHANGETABLE");
			this.GenerateSymbol(TSqlTokenType.LeftParenthesis);
			this.GenerateIdentifier(changeTableKind);
			this.GenerateSpaceAndFragmentIfNotNull(target);
			this.GenerateSymbolAndSpace(TSqlTokenType.Comma);
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x000252DA File Offset: 0x000234DA
		public override void ExplicitVisit(ChangeTableChangesTableReference node)
		{
			this.GenerateChangeTablePrefix(node.Target, "CHANGES");
			this.GenerateFragmentIfNotNull(node.SinceVersion);
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			this.GenerateTableAndColumnAliases(node);
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x0002530C File Offset: 0x0002350C
		public override void ExplicitVisit(ChangeTableVersionTableReference node)
		{
			this.GenerateChangeTablePrefix(node.Target, "VERSION");
			this.GenerateParenthesisedCommaSeparatedList<Identifier>(node.PrimaryKeyColumns);
			this.GenerateSymbolAndSpace(TSqlTokenType.Comma);
			this.GenerateParenthesisedCommaSeparatedList<ScalarExpression>(node.PrimaryKeyValues);
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			this.GenerateTableAndColumnAliases(node);
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x00025360 File Offset: 0x00023560
		public override void ExplicitVisit(ChangeTrackingDatabaseOption node)
		{
			this.GenerateIdentifier("CHANGE_TRACKING");
			this.GenerateSpace();
			switch (node.OptionState)
			{
			case OptionState.On:
				this.GenerateSymbolAndSpace(TSqlTokenType.EqualsSign);
				this.GenerateKeyword(TSqlTokenType.On);
				this.GenerateParenthesisedCommaSeparatedList<ChangeTrackingOptionDetail>(node.Details);
				return;
			case OptionState.Off:
				this.GenerateSymbolAndSpace(TSqlTokenType.EqualsSign);
				this.GenerateKeyword(TSqlTokenType.Off);
				return;
			}
			this.GenerateParenthesisedCommaSeparatedList<ChangeTrackingOptionDetail>(node.Details);
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x000253D9 File Offset: 0x000235D9
		public override void ExplicitVisit(CharacterSetPayloadOption node)
		{
			this.GenerateNameEqualsValue("CHARACTER_SET", node.IsSql ? "SQL" : "XML");
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x000253FC File Offset: 0x000235FC
		public override void ExplicitVisit(CheckConstraintDefinition node)
		{
			AlignmentPoint ap = new AlignmentPoint();
			this.MarkAndPushAlignmentPoint(ap);
			this.GenerateConstraintHead(node);
			this.GenerateKeyword(TSqlTokenType.Check);
			if (node.NotForReplication)
			{
				this.GenerateSpace();
				this.GenerateNotForReplication();
			}
			this.GenerateSpace();
			this.GenerateParenthesisedFragmentIfNotNull(node.CheckCondition);
			this.PopAlignmentPoint();
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x00025451 File Offset: 0x00023651
		public override void ExplicitVisit(CheckpointStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Checkpoint);
			this.GenerateSpaceAndFragmentIfNotNull(node.Duration);
		}

		// Token: 0x06000D2C RID: 3372 RVA: 0x00025468 File Offset: 0x00023668
		public override void ExplicitVisit(ChildObjectName node)
		{
			if (node.ServerIdentifier != null)
			{
				this.GenerateFragmentIfNotNull(node.ServerIdentifier);
				this.GenerateSymbol(TSqlTokenType.Dot);
			}
			if (node.DatabaseIdentifier != null)
			{
				this.GenerateFragmentIfNotNull(node.DatabaseIdentifier);
				this.GenerateSymbol(TSqlTokenType.Dot);
			}
			if (node.SchemaIdentifier != null)
			{
				this.GenerateFragmentIfNotNull(node.SchemaIdentifier);
				this.GenerateSymbol(TSqlTokenType.Dot);
			}
			if (node.BaseIdentifier != null)
			{
				this.GenerateFragmentIfNotNull(node.BaseIdentifier);
				this.GenerateSymbol(TSqlTokenType.Dot);
			}
			this.GenerateFragmentIfNotNull(node.ChildIdentifier);
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x000254FD File Offset: 0x000236FD
		public override void ExplicitVisit(CloseCursorStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Close);
			this.GenerateSpaceAndFragmentIfNotNull(node.Cursor);
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x00025513 File Offset: 0x00023713
		public override void ExplicitVisit(CloseMasterKeyStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Close);
			this.GenerateSpaceAndIdentifier("MASTER");
			this.GenerateSpaceAndKeyword(TSqlTokenType.Key);
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x00025530 File Offset: 0x00023730
		public override void ExplicitVisit(CloseSymmetricKeyStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Close);
			if (node.All)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.All);
				this.GenerateSpaceAndIdentifier("SYMMETRIC");
				this.GenerateSpaceAndIdentifier("KEYS");
				return;
			}
			this.GenerateSpaceAndIdentifier("SYMMETRIC");
			this.GenerateSpaceAndKeyword(TSqlTokenType.Key);
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x0002558A File Offset: 0x0002378A
		public override void ExplicitVisit(CoalesceExpression node)
		{
			this.GenerateKeyword(TSqlTokenType.Coalesce);
			this.GenerateSpace();
			this.GenerateParenthesisedCommaSeparatedList<ScalarExpression>(node.Expressions);
			this.GenerateSpaceAndCollation(node.Collation);
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x000255B4 File Offset: 0x000237B4
		public override void ExplicitVisit(ColumnDefinition node)
		{
			this.MarkWhenNecessary("name");
			this.GenerateFragmentIfNotNull(node.ColumnIdentifier);
			bool flag = true;
			this.MarkWhenNecessary("type");
			if (node.ComputedColumnExpression != null)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.As);
				this.MarkForConstraintsWhenNecessary("constraint", ref flag);
				this.GenerateSpaceAndFragmentIfNotNull(node.ComputedColumnExpression);
			}
			else
			{
				this.GenerateSpaceAndFragmentIfNotNull(node.DataType);
				if (node.Collation != null)
				{
					this.MarkForConstraintsWhenNecessary("constraint", ref flag);
					this.GenerateSpaceAndCollation(node.Collation);
				}
				this.GenerateFragmentIfNotNull(node.StorageOptions);
				if (node.DefaultConstraint != null)
				{
					this.MarkForConstraintsWhenNecessary("constraint", ref flag);
					this.GenerateSpaceAndFragmentIfNotNull(node.DefaultConstraint);
				}
				this.GenerateIdentity(node.IdentityOptions, "constraint", ref flag);
				if (node.IsRowGuidCol)
				{
					this.MarkForConstraintsWhenNecessary("constraint", ref flag);
					this.GenerateSpaceAndKeyword(TSqlTokenType.RowGuidColumn);
				}
			}
			if (node.IsPersisted)
			{
				this.MarkForConstraintsWhenNecessary("constraint", ref flag);
				this.GenerateSpaceAndIdentifier("PERSISTED");
			}
			foreach (ConstraintDefinition fragment in node.Constraints)
			{
				this.MarkForConstraintsWhenNecessary("constraint", ref flag);
				this.GenerateSpaceAndFragmentIfNotNull(fragment);
			}
			if (node.Index != null)
			{
				this.MarkForConstraintsWhenNecessary("constraint", ref flag);
				this.GenerateSpaceAndFragmentIfNotNull(node.Index);
			}
			this.MarkForConstraintsWhenNecessary("constraint", ref flag);
		}

		// Token: 0x06000D32 RID: 3378 RVA: 0x0002573C File Offset: 0x0002393C
		public override void ExplicitVisit(ColumnStorageOptions node)
		{
			switch (node.SparseOption)
			{
			case SparseColumnOption.Sparse:
				this.GenerateSpaceAndIdentifier("SPARSE");
				break;
			case SparseColumnOption.ColumnSetForAllSparseColumns:
				this.GenerateSpaceAndIdentifier("COLUMN_SET");
				this.GenerateSpaceAndKeyword(TSqlTokenType.For);
				this.GenerateSpaceAndIdentifier("ALL_SPARSE_COLUMNS");
				break;
			}
			if (node.IsFileStream)
			{
				this.GenerateSpaceAndIdentifier("FILESTREAM");
			}
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x000257A4 File Offset: 0x000239A4
		private void GenerateIdentity(IdentityOptions node, string apName, ref bool firstConstraint)
		{
			if (node != null)
			{
				this.MarkForConstraintsWhenNecessary(apName, ref firstConstraint);
				this.GenerateSpaceAndKeyword(TSqlTokenType.Identity);
				if (node.IdentitySeed != null)
				{
					this.GenerateSpaceAndSymbol(TSqlTokenType.LeftParenthesis);
					this.GenerateFragmentIfNotNull(node.IdentitySeed);
					this.GenerateSymbolAndSpace(TSqlTokenType.Comma);
					this.GenerateFragmentIfNotNull(node.IdentityIncrement);
					this.GenerateSymbol(TSqlTokenType.RightParenthesis);
				}
				if (node.IsIdentityNotForReplication)
				{
					this.GenerateSpace();
					this.GenerateNotForReplication();
				}
			}
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x00025819 File Offset: 0x00023A19
		private void MarkForConstraintsWhenNecessary(string apName, ref bool firstConstraint)
		{
			if (firstConstraint)
			{
				this.MarkWhenNecessary(apName);
				firstConstraint = false;
			}
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x0002582C File Offset: 0x00023A2C
		private void MarkWhenNecessary(string apName)
		{
			if (this._options.AlignColumnDefinitionFields)
			{
				AlignmentPoint ap = this.FindOrCreateAlignmentPointByName(apName);
				this.Mark(ap);
			}
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x00025855 File Offset: 0x00023A55
		public override void ExplicitVisit(ColumnDefinitionBase node)
		{
			this.GenerateFragmentIfNotNull(node.ColumnIdentifier);
			this.GenerateSpaceAndFragmentIfNotNull(node.DataType);
			this.GenerateSpaceAndCollation(node.Collation);
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x0002587C File Offset: 0x00023A7C
		public override void ExplicitVisit(ColumnReferenceExpression node)
		{
			this.GenerateFragmentIfNotNull(node.MultiPartIdentifier);
			if (node.ColumnType != ColumnType.Regular)
			{
				if (node.MultiPartIdentifier != null && node.MultiPartIdentifier.Count > 0)
				{
					this.GenerateSymbol(TSqlTokenType.Dot);
				}
				switch (node.ColumnType)
				{
				case ColumnType.IdentityCol:
					this.GenerateKeyword(TSqlTokenType.IdentityColumn);
					break;
				case ColumnType.RowGuidCol:
					this.GenerateKeyword(TSqlTokenType.RowGuidColumn);
					break;
				case ColumnType.Wildcard:
					this.GenerateSymbol(TSqlTokenType.Star);
					break;
				case ColumnType.PseudoColumnIdentity:
					this.GenerateToken(TSqlTokenType.PseudoColumn, "$IDENTITY");
					break;
				case ColumnType.PseudoColumnRowGuid:
					this.GenerateToken(TSqlTokenType.PseudoColumn, "$ROWGUID");
					break;
				case ColumnType.PseudoColumnAction:
					this.GenerateToken(TSqlTokenType.PseudoColumn, "$ACTION");
					break;
				case ColumnType.PseudoColumnCuid:
					this.GenerateToken(TSqlTokenType.PseudoColumn, "$CUID");
					break;
				}
			}
			this.GenerateSpaceAndCollation(node.Collation);
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x00025968 File Offset: 0x00023B68
		public override void ExplicitVisit(ColumnWithSortOrder node)
		{
			this.GenerateFragmentIfNotNull(node.Column);
			switch (node.SortOrder)
			{
			case SortOrder.NotSpecified:
				break;
			case SortOrder.Ascending:
				this.GenerateSpaceAndKeyword(TSqlTokenType.Asc);
				return;
			case SortOrder.Descending:
				this.GenerateSpaceAndKeyword(TSqlTokenType.Desc);
				break;
			default:
				return;
			}
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x000259AC File Offset: 0x00023BAC
		public override void ExplicitVisit(CommandSecurityElement80 node)
		{
			if (node.All)
			{
				this.GenerateKeyword(TSqlTokenType.All);
				return;
			}
			bool flag = true;
			foreach (object obj in SqlScriptGeneratorVisitor._commandOptions)
			{
				CommandOptions commandOptions = (CommandOptions)obj;
				if (commandOptions != CommandOptions.None && (node.CommandOptions & commandOptions) == commandOptions)
				{
					if (flag)
					{
						flag = false;
					}
					else
					{
						this.GenerateSymbol(TSqlTokenType.Comma);
						this.GenerateSpace();
					}
					this.GenerateCommandOptions(commandOptions);
				}
			}
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x00025A3C File Offset: 0x00023C3C
		private void GenerateCommandOptions(CommandOptions option)
		{
			if (option <= CommandOptions.CreateRule)
			{
				switch (option)
				{
				case CommandOptions.CreateDatabase:
					this.GenerateKeyword(TSqlTokenType.Create);
					this.GenerateSpaceAndKeyword(TSqlTokenType.Database);
					return;
				case CommandOptions.CreateDefault:
					this.GenerateKeyword(TSqlTokenType.Create);
					this.GenerateSpaceAndKeyword(TSqlTokenType.Default);
					return;
				case CommandOptions.CreateDatabase | CommandOptions.CreateDefault:
					break;
				case CommandOptions.CreateProcedure:
					this.GenerateKeyword(TSqlTokenType.Create);
					this.GenerateSpaceAndKeyword(TSqlTokenType.Procedure);
					return;
				default:
					if (option == CommandOptions.CreateFunction)
					{
						this.GenerateKeyword(TSqlTokenType.Create);
						this.GenerateSpaceAndKeyword(TSqlTokenType.Function);
						return;
					}
					if (option != CommandOptions.CreateRule)
					{
						return;
					}
					this.GenerateKeyword(TSqlTokenType.Create);
					this.GenerateSpaceAndKeyword(TSqlTokenType.Rule);
					return;
				}
			}
			else if (option <= CommandOptions.CreateView)
			{
				if (option == CommandOptions.CreateTable)
				{
					this.GenerateKeyword(TSqlTokenType.Create);
					this.GenerateSpaceAndKeyword(TSqlTokenType.Table);
					return;
				}
				if (option != CommandOptions.CreateView)
				{
					return;
				}
				this.GenerateKeyword(TSqlTokenType.Create);
				this.GenerateSpaceAndKeyword(TSqlTokenType.View);
				return;
			}
			else
			{
				if (option == CommandOptions.BackupDatabase)
				{
					this.GenerateKeyword(TSqlTokenType.Backup);
					this.GenerateSpaceAndKeyword(TSqlTokenType.Database);
					return;
				}
				if (option != CommandOptions.BackupLog)
				{
					return;
				}
				this.GenerateKeyword(TSqlTokenType.Backup);
				this.GenerateSpaceAndIdentifier("LOG");
			}
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x00025B40 File Offset: 0x00023D40
		public override void ExplicitVisit(CommitTransactionStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Commit);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Transaction);
			if (node.Name != null)
			{
				this.GenerateSpace();
				this.GenerateTransactionName(node.Name);
			}
			if (node.DelayedDurabilityOption != OptionState.NotSet)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.With);
				this.GenerateSpace();
				this.GenerateSymbol(TSqlTokenType.LeftParenthesis);
				this.GenerateIdentifier("DELAYED_DURABILITY");
				this.GenerateSpace();
				this.GenerateSymbol(TSqlTokenType.EqualsSign);
				this.GenerateSpace();
				this.GenerateOptionStateOnOff(node.DelayedDurabilityOption);
				this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			}
		}

		// Token: 0x06000D3C RID: 3388 RVA: 0x00025BD7 File Offset: 0x00023DD7
		protected void GenerateSpaceAndMemoryUnit(MemoryUnit unit)
		{
			if (unit != MemoryUnit.Unspecified)
			{
				this.GenerateSpace();
				MemoryUnitsHelper.Instance.GenerateSourceForOption(this._writer, unit);
			}
		}

		// Token: 0x06000D3D RID: 3389 RVA: 0x00025BF3 File Offset: 0x00023DF3
		protected void GenerateOwnerIfNotNull(Identifier owner)
		{
			if (owner != null)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.Authorization);
				this.GenerateSpace();
				owner.Accept(this);
			}
		}

		// Token: 0x06000D3E RID: 3390 RVA: 0x00025C13 File Offset: 0x00023E13
		private void GenerateCredential(Identifier identifier)
		{
			if (identifier != null)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.With);
				this.GenerateSpace();
				this.GenerateNameEqualsValue("CREDENTIAL", identifier);
			}
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x00025C35 File Offset: 0x00023E35
		protected void GenerateRemovePrivateKey()
		{
			this.GenerateIdentifier("REMOVE");
			this.GenerateSpaceAndIdentifier("PRIVATE");
			this.GenerateSpaceAndKeyword(TSqlTokenType.Key);
		}

		// Token: 0x06000D40 RID: 3392 RVA: 0x00025C55 File Offset: 0x00023E55
		protected void GenerateAttestedBy(Literal attestedBy)
		{
			this.GenerateIdentifier("ATTESTED");
			this.GenerateSpaceAndKeyword(TSqlTokenType.By);
			this.GenerateSpaceAndFragmentIfNotNull(attestedBy);
		}

		// Token: 0x06000D41 RID: 3393 RVA: 0x00025C71 File Offset: 0x00023E71
		protected void GenerateRemoteAttestedOption()
		{
			this.GenerateIdentifier("REMOVE");
			this.GenerateSpaceAndIdentifier("ATTESTED");
			this.GenerateSpaceAndKeyword(TSqlTokenType.Option);
		}

		// Token: 0x06000D42 RID: 3394 RVA: 0x00025C94 File Offset: 0x00023E94
		internal void GenerateWithPrivateKey(Literal privateKeyPath, Literal encryptionPassword, Literal decryptionPassword)
		{
			this.GenerateKeyword(TSqlTokenType.With);
			this.GenerateSpaceAndIdentifier("PRIVATE");
			this.GenerateSpaceAndKeyword(TSqlTokenType.Key);
			this.GenerateSpaceAndSymbol(TSqlTokenType.LeftParenthesis);
			bool flag = true;
			if (privateKeyPath != null)
			{
				flag = false;
				this.GenerateNameEqualsValue(TSqlTokenType.File, privateKeyPath);
			}
			if (decryptionPassword != null)
			{
				if (!flag)
				{
					this.GenerateSymbolAndSpace(TSqlTokenType.Comma);
				}
				else
				{
					flag = false;
				}
				this.GenerateIdentifier("DECRYPTION");
				this.GenerateSpaceAndKeyword(TSqlTokenType.By);
				this.GenerateSpace();
				this.GenerateNameEqualsValue("PASSWORD", decryptionPassword);
			}
			if (encryptionPassword != null)
			{
				if (!flag)
				{
					this.GenerateSymbolAndSpace(TSqlTokenType.Comma);
				}
				this.GenerateIdentifier("ENCRYPTION");
				this.GenerateSpaceAndKeyword(TSqlTokenType.By);
				this.GenerateSpace();
				this.GenerateNameEqualsValue("PASSWORD", encryptionPassword);
			}
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x00025D59 File Offset: 0x00023F59
		protected void GenerateSpaceAndCollation(Identifier collation)
		{
			if (collation != null)
			{
				this.GenerateSpace();
				this.GenerateKeyword(TSqlTokenType.Collate);
				this.GenerateSpaceAndFragmentIfNotNull(collation);
			}
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x00025D74 File Offset: 0x00023F74
		protected void GenerateTriggerEnforcement(TriggerEnforcement triggerEnforcement)
		{
			switch (triggerEnforcement)
			{
			case TriggerEnforcement.Disable:
				this.GenerateIdentifier("DISABLE");
				return;
			case TriggerEnforcement.Enable:
				this.GenerateIdentifier("ENABLE");
				return;
			default:
				return;
			}
		}

		// Token: 0x06000D45 RID: 3397 RVA: 0x00025DAC File Offset: 0x00023FAC
		protected void GenerateNotForReplication()
		{
			this.GenerateSpaceSeparatedTokens(new TSqlTokenType[]
			{
				TSqlTokenType.Not,
				TSqlTokenType.For,
				TSqlTokenType.Replication
			});
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x00025DD9 File Offset: 0x00023FD9
		protected void GenerateDecryptionByPassword(Literal password)
		{
			this.GenerateIdentifier("DECRYPTION");
			this.GenerateSpace();
			this.GenerateByPassword(password);
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x00025DF3 File Offset: 0x00023FF3
		protected void GenerateEncryptionByPassword(Literal password)
		{
			this.GenerateIdentifier("ENCRYPTION");
			this.GenerateSpace();
			this.GenerateByPassword(password);
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x00025E0D File Offset: 0x0002400D
		protected void GenerateByPassword(Literal password)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.By);
			this.GenerateNameEqualsValue("PASSWORD", password);
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x00025E24 File Offset: 0x00024024
		protected void GenerateBinaryOperator(BinaryExpressionType operatorType)
		{
			List<TokenGenerator> valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<BinaryExpressionType, List<TokenGenerator>>(SqlScriptGeneratorVisitor._binaryExpressionTypeGenerators, operatorType);
			this.GenerateTokenList(valueForEnumKey);
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x00025E44 File Offset: 0x00024044
		protected void GenerateBinaryOperator(BooleanComparisonType operatorType)
		{
			List<TokenGenerator> valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<BooleanComparisonType, List<TokenGenerator>>(SqlScriptGeneratorVisitor._booleanComparisonTypeGenerators, operatorType);
			this.GenerateTokenList(valueForEnumKey);
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x00025E64 File Offset: 0x00024064
		protected void GenerateBinaryOperator(BooleanBinaryExpressionType operatorType)
		{
			List<TokenGenerator> valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<BooleanBinaryExpressionType, List<TokenGenerator>>(SqlScriptGeneratorVisitor._booleanBinaryExpressionTypeGenerators, operatorType);
			this.GenerateTokenList(valueForEnumKey);
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x00025E84 File Offset: 0x00024084
		protected void GenerateUniqueRowFilter(UniqueRowFilter uniqueRowFilter, bool spaceBefore)
		{
			if (uniqueRowFilter != UniqueRowFilter.NotSpecified)
			{
				if (spaceBefore)
				{
					this.GenerateSpace();
				}
				if (uniqueRowFilter == UniqueRowFilter.All)
				{
					this.GenerateKeyword(TSqlTokenType.All);
					return;
				}
				if (uniqueRowFilter == UniqueRowFilter.Distinct)
				{
					this.GenerateKeyword(TSqlTokenType.Distinct);
				}
			}
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x00025EAA File Offset: 0x000240AA
		protected void GenerateNewLineOrSpace(bool newline)
		{
			if (newline)
			{
				this.NewLine();
				return;
			}
			this.GenerateSpace();
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x00025EBC File Offset: 0x000240BC
		protected void MarkClauseBodyAlignmentWhenNecessary(bool newline, AlignmentPoint ap)
		{
			if (newline && this._options.AlignClauseBodies && ap != null)
			{
				this.Mark(ap);
			}
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x00025ED8 File Offset: 0x000240D8
		protected void MarkInsertColumnsAlignmentPointWhenNecessary(AlignmentPoint ap)
		{
			if (ap != null)
			{
				this.Mark(ap);
			}
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x00025EE4 File Offset: 0x000240E4
		protected void GenerateSeparatorForOrderBy()
		{
			this.GenerateNewLineOrSpace(this._options.NewLineBeforeOrderByClause);
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x00025EF7 File Offset: 0x000240F7
		protected void GenerateSeparatorForFromClause()
		{
			this.GenerateNewLineOrSpace(this._options.NewLineBeforeFromClause);
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x00025F0A File Offset: 0x0002410A
		protected void GenerateSeparatorForWhereClause()
		{
			this.GenerateNewLineOrSpace(this._options.NewLineBeforeWhereClause);
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x00025F1D File Offset: 0x0002411D
		protected void GenerateSeparatorForGroupByClause()
		{
			this.GenerateNewLineOrSpace(this._options.NewLineBeforeGroupByClause);
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x00025F30 File Offset: 0x00024130
		protected void GenerateSeparatorForHavingClause()
		{
			this.GenerateNewLineOrSpace(this._options.NewLineBeforeHavingClause);
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x00025F43 File Offset: 0x00024143
		protected void GenerateSeparatorForOutputClause()
		{
			this.GenerateNewLineOrSpace(this._options.NewLineBeforeOutputClause);
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x00025F56 File Offset: 0x00024156
		protected void GenerateSeparatorForOffsetClause()
		{
			this.GenerateNewLineOrSpace(this._options.NewLineBeforeOffsetClause);
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x00025F6C File Offset: 0x0002416C
		protected void GenerateQueryExpressionInParentheses(QueryExpression queryExpression)
		{
			this.GenerateSymbol(TSqlTokenType.LeftParenthesis);
			AlignmentPoint ap = new AlignmentPoint();
			this.MarkAndPushAlignmentPoint(ap);
			if (queryExpression != null)
			{
				AlignmentPoint ap2 = new AlignmentPoint("ClauseBody");
				this.GenerateFragmentWithAlignmentPointIfNotNull(queryExpression, ap2);
			}
			this.PopAlignmentPoint();
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x00025FB8 File Offset: 0x000241B8
		private void GenerateSelectElementsList(IList<SelectElement> selectElements)
		{
			if (!this._options.MultilineSelectElementsList)
			{
				this.GenerateCommaSeparatedList<SelectElement>(selectElements);
				return;
			}
			this.GenerateFragmentList<SelectElement>(selectElements, SqlScriptGeneratorVisitor.ListGenerationOption.MultipleLineSelectElementOption);
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x00025FDB File Offset: 0x000241DB
		protected void GenerateParameters(ParameterizedDataTypeReference node)
		{
			if (node.Parameters.Count > 0)
			{
				this.GenerateSpace();
				this.GenerateParenthesisedCommaSeparatedList<Literal>(node.Parameters);
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000D5A RID: 3418
		internal abstract HashSet<Type> StatementsThatCannotHaveSemiColon { get; }

		// Token: 0x06000D5B RID: 3419 RVA: 0x00025FFD File Offset: 0x000241FD
		protected void GenerateSemiColonWhenNecessary(TSqlStatement node)
		{
			if (node != null && this._generateSemiColon && !this.StatementsThatCannotHaveSemiColon.Contains(node.GetType()))
			{
				this.GenerateSymbol(TSqlTokenType.Semicolon);
			}
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x00026028 File Offset: 0x00024228
		protected void GenerateCommaSeparatedWithClause<T>(IList<T> fragments, bool indent, bool includeParentheses) where T : TSqlFragment
		{
			if (fragments != null && fragments.Count > 0)
			{
				this.NewLine();
				if (indent)
				{
					this.Indent();
				}
				this.GenerateKeywordAndSpace(TSqlTokenType.With);
				if (includeParentheses)
				{
					this.GenerateSymbol(TSqlTokenType.LeftParenthesis);
				}
				this.GenerateCommaSeparatedList<T>(fragments);
				if (includeParentheses)
				{
					this.GenerateSymbol(TSqlTokenType.RightParenthesis);
				}
			}
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x00026080 File Offset: 0x00024280
		public override void ExplicitVisit(CommonTableExpression node)
		{
			AlignmentPoint alignmentPointForFragment = this.GetAlignmentPointForFragment(node, "ClauseBody");
			this.MarkClauseBodyAlignmentWhenNecessary(true, alignmentPointForFragment);
			this.GenerateSpaceAndFragmentIfNotNull(node.ExpressionName);
			if (node.Columns.Count > 0)
			{
				this.GenerateSpace();
				this.GenerateParenthesisedCommaSeparatedList<Identifier>(node.Columns);
			}
			this.NewLine();
			this.GenerateKeyword(TSqlTokenType.As);
			this.MarkClauseBodyAlignmentWhenNecessary(true, alignmentPointForFragment);
			this.GenerateSpace();
			AlignmentPoint ap = new AlignmentPoint();
			this.MarkAndPushAlignmentPoint(ap);
			this.GenerateQueryExpressionInParentheses(node.QueryExpression);
			this.PopAlignmentPoint();
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x00026109 File Offset: 0x00024309
		public override void ExplicitVisit(CompressionEndpointProtocolOption node)
		{
			this.GenerateNameEqualsValue("COMPRESSION", node.IsEnabled ? "ENABLED" : "DISABLED");
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x0002612A File Offset: 0x0002432A
		public override void ExplicitVisit(CompressionPartitionRange node)
		{
			this.GenerateFragmentIfNotNull(node.From);
			if (node.To != null)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.To);
				this.GenerateSpaceAndFragmentIfNotNull(node.To);
			}
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x00026158 File Offset: 0x00024358
		public override void ExplicitVisit(ComputeClause node)
		{
			AlignmentPoint ap = new AlignmentPoint();
			this.MarkAndPushAlignmentPoint(ap);
			this.GenerateKeyword(TSqlTokenType.Compute);
			AlignmentPoint alignmentPointForFragment = this.GetAlignmentPointForFragment(node, "ClauseBody");
			this.MarkClauseBodyAlignmentWhenNecessary(true, alignmentPointForFragment);
			this.GenerateSpace();
			this.GenerateCommaSeparatedList<ComputeFunction>(node.ComputeFunctions);
			if (node.ByExpressions.Count > 0)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.By);
				this.GenerateSpace();
				this.GenerateCommaSeparatedList<ScalarExpression>(node.ByExpressions);
			}
			this.PopAlignmentPoint();
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x000261CF File Offset: 0x000243CF
		public override void ExplicitVisit(ComputeFunction node)
		{
			ComputeFunctionTypeHelper.Instance.GenerateSourceForOption(this._writer, node.ComputeFunctionType);
			this.GenerateParenthesisedFragmentIfNotNull(node.Expression);
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x000261F3 File Offset: 0x000243F3
		protected void GenerateConstraintHead(ConstraintDefinition node)
		{
			if (node.ConstraintIdentifier != null)
			{
				this.GenerateKeyword(TSqlTokenType.Constraint);
				this.GenerateSpaceAndFragmentIfNotNull(node.ConstraintIdentifier);
				this.GenerateSpace();
			}
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x00026218 File Offset: 0x00024418
		protected void GenerateDeleteUpdateAction(DeleteUpdateAction action)
		{
			List<TokenGenerator> valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<DeleteUpdateAction, List<TokenGenerator>>(SqlScriptGeneratorVisitor._deleteUpdateActionGenerators, action);
			if (valueForEnumKey != null)
			{
				this.GenerateTokenList(valueForEnumKey);
			}
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x0002623B File Offset: 0x0002443B
		public override void ExplicitVisit(ContainmentDatabaseOption node)
		{
			this.GenerateIdentifier("CONTAINMENT");
			this.GenerateSpace();
			this.GenerateSymbol(TSqlTokenType.EqualsSign);
			this.GenerateSpace();
			ContainmentOptionKindHelper.Instance.GenerateSourceForOption(this._writer, node.Value);
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x00026275 File Offset: 0x00024475
		public override void ExplicitVisit(ContinueStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Continue);
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x00026280 File Offset: 0x00024480
		public override void ExplicitVisit(ContractMessage node)
		{
			this.GenerateFragmentIfNotNull(node.Name);
			this.GenerateSpaceAndIdentifier("SENT");
			this.GenerateSpaceAndKeyword(TSqlTokenType.By);
			TokenGenerator valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<MessageSender, TokenGenerator>(SqlScriptGeneratorVisitor._messageSenderGenerators, node.SentBy);
			this.GenerateSpace();
			this.GenerateToken(valueForEnumKey);
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x000262CC File Offset: 0x000244CC
		public override void ExplicitVisit(ConvertCall node)
		{
			this.GenerateKeyword(TSqlTokenType.Convert);
			this.GenerateSpaceAndSymbol(TSqlTokenType.LeftParenthesis);
			this.GenerateFragmentIfNotNull(node.DataType);
			this.GenerateSymbol(TSqlTokenType.Comma);
			this.GenerateSpaceAndFragmentIfNotNull(node.Parameter);
			if (node.Style != null)
			{
				this.GenerateSymbol(TSqlTokenType.Comma);
				this.GenerateSpaceAndFragmentIfNotNull(node.Style);
			}
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			this.GenerateSpaceAndCollation(node.Collation);
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x00026348 File Offset: 0x00024548
		public override void ExplicitVisit(CreateAggregateStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Create);
			this.GenerateSpaceAndIdentifier("AGGREGATE");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.GenerateParenthesisedCommaSeparatedList<ProcedureParameter>(node.Parameters);
			this.NewLineAndIndent();
			this.GenerateIdentifier("RETURNS");
			this.GenerateSpaceAndFragmentIfNotNull(node.ReturnType);
			this.NewLineAndIndent();
			this.GenerateKeyword(TSqlTokenType.External);
			this.GenerateSpaceAndIdentifier("NAME");
			this.GenerateSpaceAndFragmentIfNotNull(node.AssemblyName);
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x000263C5 File Offset: 0x000245C5
		public override void ExplicitVisit(CreateApplicationRoleStatement node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.Create);
			this.GenerateApplicationRoleStatementBase(node);
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x000263D8 File Offset: 0x000245D8
		public override void ExplicitVisit(CreateAssemblyStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Create);
			this.GenerateSpaceAndIdentifier("ASSEMBLY");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.GenerateOwnerIfNotNull(node.Owner);
			this.NewLineAndIndent();
			this.GenerateKeyword(TSqlTokenType.From);
			this.GenerateSpace();
			this.GenerateCommaSeparatedList<ScalarExpression>(node.Parameters);
			this.GenerateAssemblyOptions(node.Options);
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x0002643C File Offset: 0x0002463C
		public override void ExplicitVisit(CreateAvailabilityGroupStatement node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.Create);
			this.GenerateIdentifier("AVAILABILITY");
			this.GenerateSpaceAndKeyword(TSqlTokenType.Group);
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.GenerateCommaSeparatedWithClause<AvailabilityGroupOption>(node.Options, false, true);
			this.NewLine();
			this.GenerateKeywordAndSpace(TSqlTokenType.For);
			if (node.Databases != null && node.Databases.Count > 0)
			{
				this.GenerateKeywordAndSpace(TSqlTokenType.Database);
				this.GenerateCommaSeparatedList<Identifier>(node.Databases);
				this.NewLine();
			}
			this.GenerateIdentifier("REPLICA");
			this.GenerateSpace();
			this.GenerateKeywordAndSpace(TSqlTokenType.On);
			this.GenerateCommaSeparatedList<AvailabilityReplica>(node.Replicas, true);
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x000264E2 File Offset: 0x000246E2
		public override void ExplicitVisit(LiteralAvailabilityGroupOption node)
		{
			this.GenerateNameEqualsValue("REQUIRED_COPIES_TO_COMMIT", node.Value);
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x000264F5 File Offset: 0x000246F5
		public override void ExplicitVisit(CreateBrokerPriorityStatement node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.Create);
			this.GenerateBrokerPriorityStatementBody(node);
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x00026508 File Offset: 0x00024708
		public override void ExplicitVisit(CreateCertificateStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Create);
			this.GenerateSpaceAndIdentifier("CERTIFICATE");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.GenerateOwnerIfNotNull(node.Owner);
			if (node.CertificateSource != null)
			{
				this.NewLineAndIndent();
				this.GenerateKeywordAndSpace(TSqlTokenType.From);
				this.GenerateFragmentIfNotNull(node.CertificateSource);
				if (node.PrivateKeyPath != null)
				{
					this.NewLineAndIndent();
					this.GenerateKeyword(TSqlTokenType.With);
					this.GenerateSpaceAndIdentifier("PRIVATE");
					this.GenerateSpaceAndKeyword(TSqlTokenType.Key);
					this.GenerateSpaceAndSymbol(TSqlTokenType.LeftParenthesis);
					this.GenerateNameEqualsValue(TSqlTokenType.File, node.PrivateKeyPath);
					if (node.DecryptionPassword != null)
					{
						this.GenerateSymbol(TSqlTokenType.Comma);
						this.GenerateSpaceAndIdentifier("DECRYPTION");
						this.GenerateSpaceAndKeyword(TSqlTokenType.By);
						this.GenerateSpace();
						this.GenerateNameEqualsValue("PASSWORD", node.DecryptionPassword);
					}
					if (node.EncryptionPassword != null)
					{
						this.GenerateSymbol(TSqlTokenType.Comma);
						this.GenerateSpace();
						this.GenerateEncryptionPassword(node.EncryptionPassword);
					}
					this.GenerateSymbol(TSqlTokenType.RightParenthesis);
				}
			}
			else
			{
				if (node.EncryptionPassword != null)
				{
					this.NewLineAndIndent();
					this.GenerateEncryptionPassword(node.EncryptionPassword);
				}
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.With);
				this.GenerateSpace();
				this.GenerateCommaSeparatedList<CertificateOption>(node.CertificateOptions);
			}
			if (node.ActiveForBeginDialog != OptionState.NotSet)
			{
				this.NewLineAndIndent();
				this.GenerateIdentifier("ACTIVE");
				this.GenerateSpaceAndKeyword(TSqlTokenType.For);
				this.GenerateSpace();
				this.GenerateOptionStateWithEqualSign("BEGIN_DIALOG", node.ActiveForBeginDialog);
			}
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x00026691 File Offset: 0x00024891
		private void GenerateEncryptionPassword(Literal password)
		{
			if (password != null)
			{
				this.GenerateIdentifier("ENCRYPTION");
				this.GenerateSpaceAndKeyword(TSqlTokenType.By);
				this.GenerateSpace();
				this.GenerateNameEqualsValue("PASSWORD", password);
			}
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x000266BC File Offset: 0x000248BC
		public override void ExplicitVisit(CreateColumnStoreIndexStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Create);
			if (node.Clustered != null)
			{
				this.GenerateSpaceAndKeyword(node.Clustered.Value ? TSqlTokenType.Clustered : TSqlTokenType.NonClustered);
			}
			this.GenerateSpaceAndIdentifier("COLUMNSTORE");
			this.GenerateSpaceAndKeyword(TSqlTokenType.Index);
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.NewLineAndIndent();
			this.GenerateKeyword(TSqlTokenType.On);
			this.GenerateSpaceAndFragmentIfNotNull(node.OnName);
			if (!node.Clustered.GetValueOrDefault() && node.Columns != null && node.Columns.Count > 0)
			{
				this.GenerateParenthesisedCommaSeparatedList<ColumnReferenceExpression>(node.Columns);
			}
			this.GenerateIndexOptions(node.IndexOptions);
			if (node.OnFileGroupOrPartitionScheme != null)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.On);
				this.GenerateSpaceAndFragmentIfNotNull(node.OnFileGroupOrPartitionScheme);
			}
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x00026796 File Offset: 0x00024996
		public override void ExplicitVisit(CreateContractStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Create);
			this.GenerateSpaceAndIdentifier("CONTRACT");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.GenerateOwnerIfNotNull(node.Owner);
			this.NewLineAndIndent();
			this.GenerateParenthesisedCommaSeparatedList<ContractMessage>(node.Messages);
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x000267D8 File Offset: 0x000249D8
		public override void ExplicitVisit(CreateCredentialStatement node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.Create);
			this.GenerateCredentialStatementBody(node);
			if (node.CryptographicProviderName != null)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.For);
				this.GenerateSpaceAndIdentifier("CRYPTOGRAPHIC");
				this.GenerateSpaceAndIdentifier("PROVIDER");
				this.GenerateSpaceAndFragmentIfNotNull(node.CryptographicProviderName);
			}
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x00026828 File Offset: 0x00024A28
		public override void ExplicitVisit(CreateDatabaseStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Create);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Database);
			this.GenerateSpaceAndFragmentIfNotNull(node.DatabaseName);
			this.GenerateSpaceAndFragmentIfNotNull(node.Containment);
			if (node.FileGroups != null && node.FileGroups.Count > 0)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.On);
				this.GenerateSpace();
				this.GenerateCommaSeparatedList<FileGroupDefinition>(node.FileGroups);
			}
			if (node.LogOn.Count > 0)
			{
				this.NewLineAndIndent();
				this.GenerateIdentifier("LOG");
				this.GenerateSpaceAndKeyword(TSqlTokenType.On);
				this.GenerateSpace();
				this.GenerateCommaSeparatedList<FileDeclaration>(node.LogOn);
			}
			this.GenerateSpaceAndCollation(node.Collation);
			if (node.AttachMode != AttachMode.None)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.For);
				TokenGenerator valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<AttachMode, TokenGenerator>(SqlScriptGeneratorVisitor._attachModeGenerators, node.AttachMode);
				if (valueForEnumKey != null)
				{
					this.GenerateSpace();
					this.GenerateToken(valueForEnumKey);
				}
			}
			if (node.DatabaseSnapshot != null)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.As);
				this.GenerateSpaceAndIdentifier("SNAPSHOT");
				this.GenerateSpaceAndKeyword(TSqlTokenType.Of);
				this.GenerateSpaceAndFragmentIfNotNull(node.DatabaseSnapshot);
			}
			if (node.CopyOf != null)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.As);
				this.GenerateSpaceAndIdentifier("COPY");
				this.GenerateSpaceAndKeyword(TSqlTokenType.Of);
				this.GenerateSpaceAndFragmentIfNotNull(node.CopyOf);
			}
			if (node.Options != null && node.Options.Count > 0)
			{
				bool flag = true;
				foreach (DatabaseOption databaseOption in node.Options)
				{
					if (databaseOption.OptionKind != DatabaseOptionKind.MaxSize && databaseOption.OptionKind != DatabaseOptionKind.Edition)
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					this.NewLineAndIndent();
					this.GenerateParenthesisedCommaSeparatedList<DatabaseOption>(node.Options, true);
					return;
				}
				this.GenerateCommaSeparatedWithClause<DatabaseOption>(node.Options, true, false);
			}
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x00026A04 File Offset: 0x00024C04
		public override void ExplicitVisit(CreateDefaultStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Create);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Default);
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			if (node.Expression != null)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.As);
				this.GenerateSpaceAndFragmentIfNotNull(node.Expression);
			}
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x00026A44 File Offset: 0x00024C44
		public override void ExplicitVisit(CreateEndpointStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Create);
			this.GenerateSpaceAndIdentifier("ENDPOINT");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.GenerateOwnerIfNotNull(node.Owner);
			this.GenerateSpace();
			this.GenerateEndpointBody(node);
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x00026A80 File Offset: 0x00024C80
		public override void ExplicitVisit(CreateEventNotificationStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Create);
			this.GenerateSpaceAndIdentifier("EVENT");
			this.GenerateSpaceAndIdentifier("NOTIFICATION");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.NewLineAndIndent();
			this.GenerateKeyword(TSqlTokenType.On);
			if (node.Scope != null)
			{
				switch (node.Scope.Target)
				{
				case EventNotificationTarget.Server:
					this.GenerateSpaceAndIdentifier("SERVER");
					break;
				case EventNotificationTarget.Database:
					this.GenerateSpaceAndKeyword(TSqlTokenType.Database);
					break;
				case EventNotificationTarget.Queue:
					this.GenerateSpaceAndIdentifier("QUEUE");
					this.GenerateSpaceAndFragmentIfNotNull(node.Scope.QueueName);
					break;
				}
			}
			if (node.WithFanIn)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.With);
				this.GenerateSpaceAndIdentifier("FAN_IN");
			}
			if (node.EventTypeGroups != null && node.EventTypeGroups.Count > 0)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.For);
				this.GenerateSpace();
				this.GenerateFragmentList<EventTypeGroupContainer>(node.EventTypeGroups);
			}
			this.NewLineAndIndent();
			this.GenerateKeyword(TSqlTokenType.To);
			this.GenerateSpaceAndIdentifier("SERVICE");
			this.GenerateSpaceAndFragmentIfNotNull(node.BrokerService);
			this.GenerateSymbol(TSqlTokenType.Comma);
			this.GenerateSpaceAndFragmentIfNotNull(node.BrokerInstanceSpecifier);
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x00026BBC File Offset: 0x00024DBC
		public override void ExplicitVisit(CreateFederationStatement node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.Create);
			this.GenerateIdentifier("FEDERATION");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.GenerateSpaceAndSymbol(TSqlTokenType.LeftParenthesis);
			this.GenerateFragmentIfNotNull(node.DistributionName);
			this.GenerateSpaceAndFragmentIfNotNull(node.DataType);
			this.GenerateSpaceAndIdentifier("RANGE");
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x00026C24 File Offset: 0x00024E24
		public override void ExplicitVisit(CreateFullTextCatalogStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Create);
			this.GenerateSpaceAndIdentifier("FULLTEXT");
			this.GenerateSpaceAndIdentifier("CATALOG");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			if (node.FileGroup != null)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.On);
				this.GenerateSpaceAndIdentifier("FILEGROUP");
				this.GenerateSpaceAndFragmentIfNotNull(node.FileGroup);
			}
			if (node.Path != null)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.In);
				this.GenerateSpaceAndIdentifier("PATH");
				this.GenerateSpaceAndFragmentIfNotNull(node.Path);
			}
			this.GenerateCommaSeparatedWithClause<FullTextCatalogOption>(node.Options, true, false);
			if (node.IsDefault)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.As);
				this.GenerateSpaceAndKeyword(TSqlTokenType.Default);
			}
			this.GenerateOwnerIfNotNull(node.Owner);
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x00026CED File Offset: 0x00024EED
		public override void ExplicitVisit(OnOffFullTextCatalogOption node)
		{
			this.GenerateOptionStateWithEqualSign("ACCENT_SENSITIVITY", node.OptionState);
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x00026D00 File Offset: 0x00024F00
		public override void ExplicitVisit(CreateFullTextIndexStatement node)
		{
			this.GenerateSpaceSeparatedTokens(TSqlTokenType.Create, new string[]
			{
				"FULLTEXT"
			});
			this.GenerateSpace();
			this.GenerateSpaceSeparatedTokens(new TSqlTokenType[]
			{
				TSqlTokenType.Index,
				TSqlTokenType.On
			});
			this.GenerateSpaceAndFragmentIfNotNull(node.OnName);
			if (node.FullTextIndexColumns != null && node.FullTextIndexColumns.Count > 0)
			{
				this.NewLineAndIndent();
				this.GenerateParenthesisedCommaSeparatedList<FullTextIndexColumn>(node.FullTextIndexColumns);
			}
			this.NewLineAndIndent();
			this.GenerateKeyword(TSqlTokenType.Key);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Index);
			this.GenerateSpaceAndFragmentIfNotNull(node.KeyIndexName);
			this.GenerateFragmentIfNotNull(node.CatalogAndFileGroup);
			if (node.Options.Count > 0)
			{
				this.NewLineAndIndent();
				this.GenerateKeywordAndSpace(TSqlTokenType.With);
				this.GenerateCommaSeparatedList<FullTextIndexOption>(node.Options);
			}
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x00026DD0 File Offset: 0x00024FD0
		public override void ExplicitVisit(FullTextCatalogAndFileGroup node)
		{
			this.NewLineAndIndent();
			this.GenerateKeywordAndSpace(TSqlTokenType.On);
			if (node.FileGroupIsFirst)
			{
				this.GenerateSymbol(TSqlTokenType.LeftParenthesis);
				this.GenerateIdentifier("FILEGROUP");
				this.GenerateSpaceAndFragmentIfNotNull(node.FileGroupName);
				if (node.CatalogName != null)
				{
					this.GenerateSymbolAndSpace(TSqlTokenType.Comma);
					this.GenerateFragmentIfNotNull(node.CatalogName);
				}
				this.GenerateSymbol(TSqlTokenType.RightParenthesis);
				return;
			}
			if (node.FileGroupName != null)
			{
				this.GenerateSymbol(TSqlTokenType.LeftParenthesis);
			}
			this.GenerateFragmentIfNotNull(node.CatalogName);
			if (node.FileGroupName != null)
			{
				this.GenerateSymbolAndSpace(TSqlTokenType.Comma);
				this.GenerateIdentifier("FILEGROUP");
				this.GenerateSpaceAndFragmentIfNotNull(node.FileGroupName);
				this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			}
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x00026E94 File Offset: 0x00025094
		public override void ExplicitVisit(ChangeTrackingFullTextIndexOption node)
		{
			this.GenerateIdentifier("CHANGE_TRACKING");
			this.GenerateSpace();
			switch (node.Value)
			{
			case ChangeTrackingOption.Auto:
				this.GenerateIdentifier("AUTO");
				return;
			case ChangeTrackingOption.Manual:
				this.GenerateIdentifier("MANUAL");
				return;
			case ChangeTrackingOption.Off:
				this.GenerateKeyword(TSqlTokenType.Off);
				return;
			case ChangeTrackingOption.OffNoPopulation:
				this.GenerateKeyword(TSqlTokenType.Off);
				this.GenerateSymbol(TSqlTokenType.Comma);
				this.GenerateSpaceAndIdentifier("NO");
				this.GenerateSpaceAndIdentifier("POPULATION");
				return;
			default:
				return;
			}
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x00026F1C File Offset: 0x0002511C
		public override void ExplicitVisit(StopListFullTextIndexOption node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.StopList);
			if (node.IsOff)
			{
				this.GenerateKeyword(TSqlTokenType.Off);
				return;
			}
			this.GenerateFragmentIfNotNull(node.StopListName);
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x00026F48 File Offset: 0x00025148
		public override void ExplicitVisit(SearchPropertyListFullTextIndexOption node)
		{
			this.GenerateIdentifier("SEARCH");
			this.GenerateSpaceAndIdentifier("PROPERTY");
			this.GenerateSpaceAndIdentifier("LIST");
			this.GenerateSpaceAndKeyword(TSqlTokenType.EqualsSign);
			if (node.IsOff)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.Off);
				return;
			}
			this.GenerateSpaceAndFragmentIfNotNull(node.PropertyListName);
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x00026FA0 File Offset: 0x000251A0
		public override void ExplicitVisit(CreateFullTextStopListStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Create);
			this.GenerateSpaceAndIdentifier("FULLTEXT");
			this.GenerateSpaceAndKeyword(TSqlTokenType.StopList);
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			if (node.IsSystemStopList)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.From);
				this.GenerateSpaceAndIdentifier("SYSTEM");
				this.GenerateSpaceAndKeyword(TSqlTokenType.StopList);
			}
			else if (node.SourceStopListName != null)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.From);
				if (node.DatabaseName != null)
				{
					this.GenerateSpaceAndFragmentIfNotNull(node.DatabaseName);
					this.GenerateKeyword(TSqlTokenType.Dot);
				}
				else
				{
					this.GenerateSpace();
				}
				this.GenerateFragmentIfNotNull(node.SourceStopListName);
			}
			this.GenerateOwnerIfNotNull(node.Owner);
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x0002704E File Offset: 0x0002524E
		public override void ExplicitVisit(CreateFunctionStatement node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.Create);
			this.GenerateFunctionStatementBody(node);
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x00027060 File Offset: 0x00025260
		public override void ExplicitVisit(CreateIndexStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Create);
			if (node.Unique)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.Unique);
			}
			if (node.Clustered != null)
			{
				this.GenerateSpaceAndKeyword(node.Clustered.Value ? TSqlTokenType.Clustered : TSqlTokenType.NonClustered);
			}
			this.GenerateSpaceAndKeyword(TSqlTokenType.Index);
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.NewLineAndIndent();
			this.GenerateKeyword(TSqlTokenType.On);
			this.GenerateSpaceAndFragmentIfNotNull(node.OnName);
			this.GenerateParenthesisedCommaSeparatedList<ColumnWithSortOrder>(node.Columns);
			if (node.IncludeColumns != null && node.IncludeColumns.Count > 0)
			{
				this.NewLineAndIndent();
				this.GenerateIdentifier("INCLUDE");
				this.GenerateParenthesisedCommaSeparatedList<ColumnReferenceExpression>(node.IncludeColumns);
			}
			if (node.FilterPredicate != null)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.Where);
				this.GenerateSpaceAndFragmentIfNotNull(node.FilterPredicate);
			}
			this.GenerateIndexOptions(node.IndexOptions);
			if (node.OnFileGroupOrPartitionScheme != null)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.On);
				this.GenerateSpaceAndFragmentIfNotNull(node.OnFileGroupOrPartitionScheme);
			}
			this.GenerateFileStreamOn(node);
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x00027175 File Offset: 0x00025375
		protected virtual void GenerateIndexOptions(IList<IndexOption> options)
		{
			if (options != null && options.Count > 0)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.With);
				this.GenerateSpace();
				this.GenerateParenthesisedCommaSeparatedList<IndexOption>(options);
			}
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x0002719B File Offset: 0x0002539B
		private void GenerateFileStreamOn(IFileStreamSpecifier node)
		{
			if (node.FileStreamOn != null)
			{
				this.GenerateSpaceAndIdentifier("FILESTREAM_ON");
				this.GenerateSpaceAndFragmentIfNotNull(node.FileStreamOn);
			}
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x000271BC File Offset: 0x000253BC
		public override void ExplicitVisit(CreateLoginStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Create);
			this.GenerateSpaceAndIdentifier("LOGIN");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.NewLineAndIndent();
			this.GenerateFragmentIfNotNull(node.Source);
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x000271F0 File Offset: 0x000253F0
		public override void ExplicitVisit(CreateMasterKeyStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Create);
			this.GenerateSpaceAndIdentifier("MASTER");
			this.GenerateSpaceAndKeyword(TSqlTokenType.Key);
			this.GenerateSpaceAndIdentifier("ENCRYPTION");
			this.GenerateSpaceAndKeyword(TSqlTokenType.By);
			this.GenerateSpaceAndIdentifier("PASSWORD");
			this.GenerateSymbol(TSqlTokenType.EqualsSign);
			this.GenerateSpaceAndFragmentIfNotNull(node.Password);
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x0002724D File Offset: 0x0002544D
		public override void ExplicitVisit(CreateMessageTypeStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Create);
			this.GenerateSpaceAndIdentifier("MESSAGE");
			this.GenerateSpaceAndIdentifier("TYPE");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.GenerateOwnerIfNotNull(node.Owner);
			this.GenerateValidationMethod(node);
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x0002728C File Offset: 0x0002548C
		public override void ExplicitVisit(CreatePartitionFunctionStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Create);
			this.GenerateSpaceAndIdentifier("PARTITION");
			this.GenerateSpaceAndKeyword(TSqlTokenType.Function);
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.GenerateParenthesisedFragmentIfNotNull(node.ParameterType);
			this.NewLineAndIndent();
			this.GenerateKeyword(TSqlTokenType.As);
			this.GenerateSpaceAndIdentifier("RANGE");
			switch (node.Range)
			{
			case PartitionFunctionRange.Left:
				this.GenerateSpaceAndKeyword(TSqlTokenType.Left);
				break;
			case PartitionFunctionRange.Right:
				this.GenerateSpaceAndKeyword(TSqlTokenType.Right);
				break;
			}
			this.NewLineAndIndent();
			this.GenerateKeyword(TSqlTokenType.For);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Values);
			this.GenerateSpace();
			this.GenerateParenthesisedCommaSeparatedList<ScalarExpression>(node.BoundaryValues, true);
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x0002733F File Offset: 0x0002553F
		public override void ExplicitVisit(PartitionParameterType node)
		{
			this.GenerateFragmentIfNotNull(node.DataType);
			if (node.Collation != null)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.Collate);
				this.GenerateSpaceAndFragmentIfNotNull(node.Collation);
			}
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x0002736C File Offset: 0x0002556C
		public override void ExplicitVisit(CreatePartitionSchemeStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Create);
			this.GenerateSpaceAndIdentifier("PARTITION");
			this.GenerateSpaceAndIdentifier("SCHEME");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.NewLineAndIndent();
			this.GenerateKeyword(TSqlTokenType.As);
			this.GenerateSpaceAndIdentifier("PARTITION");
			this.GenerateSpaceAndFragmentIfNotNull(node.PartitionFunction);
			this.NewLineAndIndent();
			if (node.IsAll)
			{
				this.GenerateKeyword(TSqlTokenType.All);
				this.GenerateSpace();
			}
			this.GenerateKeyword(TSqlTokenType.To);
			this.GenerateSpace();
			this.GenerateParenthesisedCommaSeparatedList<IdentifierOrValueExpression>(node.FileGroups);
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x00027400 File Offset: 0x00025600
		public override void ExplicitVisit(CreateProcedureStatement node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.Create);
			this.GenerateProcedureStatementBody(node);
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x00027414 File Offset: 0x00025614
		public override void ExplicitVisit(CreateQueueStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Create);
			this.GenerateSpaceAndIdentifier("QUEUE");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			if (node.QueueOptions != null && node.QueueOptions.Count > 0)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.With);
				this.GenerateSpace();
				this.GenerateQueueOptions(node.QueueOptions);
			}
			if (node.OnFileGroup != null)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.On);
				this.GenerateSpaceAndFragmentIfNotNull(node.OnFileGroup);
			}
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x0002749C File Offset: 0x0002569C
		public override void ExplicitVisit(CreateRemoteServiceBindingStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Create);
			this.GenerateSpaceAndIdentifier("REMOTE");
			this.GenerateSpaceAndIdentifier("SERVICE");
			this.GenerateSpaceAndIdentifier("BINDING");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.GenerateOwnerIfNotNull(node.Owner);
			this.NewLineAndIndent();
			this.GenerateKeyword(TSqlTokenType.To);
			this.GenerateSpaceAndIdentifier("SERVICE");
			this.GenerateSpaceAndFragmentIfNotNull(node.Service);
			this.GenerateBindingOptions(node.Options);
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x0002751E File Offset: 0x0002571E
		public override void ExplicitVisit(CreateResourcePoolStatement node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.Create);
			this.GenerateResourcePoolStatementBody(node);
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x0002752F File Offset: 0x0002572F
		public override void ExplicitVisit(CreateRoleStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Create);
			this.GenerateSpaceAndIdentifier("ROLE");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.GenerateOwnerIfNotNull(node.Owner);
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x0002755C File Offset: 0x0002575C
		public override void ExplicitVisit(CreateRouteStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Create);
			this.GenerateSpaceAndIdentifier("ROUTE");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.GenerateOwnerIfNotNull(node.Owner);
			this.GenerateRouteOptions(node);
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x00027590 File Offset: 0x00025790
		public override void ExplicitVisit(CreateRuleStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Create);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Rule);
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.NewLineAndIndent();
			this.GenerateKeyword(TSqlTokenType.As);
			this.GenerateSpaceAndFragmentIfNotNull(node.Expression);
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x000275CC File Offset: 0x000257CC
		public override void ExplicitVisit(CreateSchemaStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Create);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Schema);
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.GenerateOwnerIfNotNull(node.Owner);
			if (node.StatementList != null && node.StatementList.Statements != null && node.StatementList.Statements.Count > 0)
			{
				AlignmentPoint ap = new AlignmentPoint();
				this.NewLineAndIndent();
				this.MarkAndPushAlignmentPoint(ap);
				bool generateSemiColon = this._generateSemiColon;
				this._generateSemiColon = false;
				this.GenerateFragmentIfNotNull(node.StatementList);
				this._generateSemiColon = generateSemiColon;
				this.PopAlignmentPoint();
			}
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x00027668 File Offset: 0x00025868
		public override void ExplicitVisit(CreateSearchPropertyListStatement node)
		{
			this.GenerateSpaceSeparatedTokens(TSqlTokenType.Create, new string[]
			{
				"SEARCH",
				"PROPERTY",
				"LIST"
			});
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			if (node.SourceSearchPropertyList != null)
			{
				this.NewLine();
				this.GenerateKeyword(TSqlTokenType.From);
				this.GenerateSpaceAndFragmentIfNotNull(node.SourceSearchPropertyList);
			}
			this.GenerateOwnerIfNotNull(node.Owner);
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x000276D8 File Offset: 0x000258D8
		public override void ExplicitVisit(CreateSelectiveXmlIndexStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Create);
			if (!node.IsSecondary)
			{
				this.GenerateSpaceAndIdentifier("SELECTIVE");
			}
			this.GenerateSpaceAndIdentifier("XML");
			this.GenerateSpaceAndKeyword(TSqlTokenType.Index);
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.GenerateSpaceAndKeyword(TSqlTokenType.On);
			this.GenerateSpaceAndFragmentIfNotNull(node.OnName);
			this.GenerateKeyword(TSqlTokenType.LeftParenthesis);
			this.GenerateFragmentIfNotNull(node.XmlColumn);
			this.GenerateKeyword(TSqlTokenType.RightParenthesis);
			if (node.IsSecondary)
			{
				this.NewLine();
				this.GenerateIdentifier("USING");
				this.GenerateSpaceAndIdentifier("XML");
				this.GenerateSpaceAndKeyword(TSqlTokenType.Index);
				this.GenerateSpaceAndFragmentIfNotNull(node.UsingXmlIndexName);
			}
			else if (node.XmlNamespaces != null)
			{
				this.NewLine();
				this.GenerateKeyword(TSqlTokenType.With);
				this.GenerateSpaceAndFragmentIfNotNull(node.XmlNamespaces);
			}
			this.NewLine();
			this.GenerateKeyword(TSqlTokenType.For);
			this.GenerateKeyword(TSqlTokenType.LeftParenthesis);
			this.GenerateSpaceAndFragmentIfNotNull(node.PathName);
			SqlScriptGeneratorVisitor.ListGenerationOption listGenerationOption = SqlScriptGeneratorVisitor.ListGenerationOption.CreateOptionFromFormattingConfig(this._options);
			listGenerationOption.Parenthesised = false;
			listGenerationOption.AlwaysGenerateParenthesis = false;
			this.GenerateFragmentList<SelectiveXmlIndexPromotedPath>(node.PromotedPaths, listGenerationOption);
			this.NewLine();
			this.GenerateKeyword(TSqlTokenType.RightParenthesis);
			if (node.IndexOptions != null && node.IndexOptions.Count > 0)
			{
				this.NewLine();
				this.GenerateKeyword(TSqlTokenType.With);
				this.GenerateSpace();
				this.GenerateParenthesisedCommaSeparatedList<IndexOption>(node.IndexOptions);
			}
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x0002784A File Offset: 0x00025A4A
		public override void ExplicitVisit(CreateSequenceStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Create);
			this.GenerateSpaceAndIdentifier("SEQUENCE");
			this.GenerateSequenceStatementBody(node);
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x00027868 File Offset: 0x00025A68
		public override void ExplicitVisit(CreateServerRoleStatement node)
		{
			this.GenerateSpaceSeparatedTokens(TSqlTokenType.Create, new string[]
			{
				"SERVER",
				"ROLE"
			});
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.GenerateOwnerIfNotNull(node.Owner);
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x000278B0 File Offset: 0x00025AB0
		public override void ExplicitVisit(CreateServiceStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Create);
			this.GenerateSpaceAndIdentifier("SERVICE");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.GenerateOwnerIfNotNull(node.Owner);
			this.NewLineAndIndent();
			this.GenerateKeyword(TSqlTokenType.On);
			this.GenerateSpaceAndIdentifier("QUEUE");
			this.GenerateSpaceAndFragmentIfNotNull(node.QueueName);
			if (node.ServiceContracts != null && node.ServiceContracts.Count > 0)
			{
				this.NewLineAndIndent();
				this.GenerateParenthesisedCommaSeparatedList<ServiceContract>(node.ServiceContracts);
			}
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x00027938 File Offset: 0x00025B38
		public override void ExplicitVisit(CreateSpatialIndexStatement node)
		{
			AlignmentPoint ap = new AlignmentPoint();
			this.GenerateKeywordAndSpace(TSqlTokenType.Create);
			this.GenerateIdentifier("SPATIAL");
			this.GenerateSpaceAndKeyword(TSqlTokenType.Index);
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.NewLineAndIndent();
			this.MarkAndPushAlignmentPoint(ap);
			this.GenerateKeyword(TSqlTokenType.On);
			this.GenerateSpaceAndFragmentIfNotNull(node.Object);
			this.GenerateSpaceAndKeyword(TSqlTokenType.LeftParenthesis);
			this.GenerateFragmentIfNotNull(node.SpatialColumnName);
			this.GenerateKeyword(TSqlTokenType.RightParenthesis);
			this.PopAlignmentPoint();
			if (node.SpatialIndexingScheme != SpatialIndexingSchemeType.None)
			{
				this.NewLineAndIndent();
				this.MarkAndPushAlignmentPoint(ap);
				this.GenerateIdentifier("USING");
				this.GenerateSpace();
				SpatialIndexingSchemeTypeHelper.Instance.GenerateSourceForOption(this._writer, node.SpatialIndexingScheme);
				this.PopAlignmentPoint();
			}
			if (node.SpatialIndexOptions != null && node.SpatialIndexOptions.Count > 0)
			{
				this.NewLineAndIndent();
				this.MarkAndPushAlignmentPoint(ap);
				this.GenerateKeyword(TSqlTokenType.With);
				this.GenerateSpace();
				this.GenerateAlignedParenthesizedOptionsWithMultipleIndent<SpatialIndexOption>(node.SpatialIndexOptions, 2);
				this.PopAlignmentPoint();
			}
			if (node.OnFileGroup != null)
			{
				this.NewLineAndIndent();
				this.MarkAndPushAlignmentPoint(ap);
				this.GenerateKeyword(TSqlTokenType.On);
				this.GenerateSpaceAndFragmentIfNotNull(node.OnFileGroup);
				this.PopAlignmentPoint();
			}
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x00027A73 File Offset: 0x00025C73
		public override void ExplicitVisit(SpatialIndexRegularOption node)
		{
			this.GenerateFragmentIfNotNull(node.Option);
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x00027A81 File Offset: 0x00025C81
		public override void ExplicitVisit(BoundingBoxSpatialIndexOption node)
		{
			this.GenerateIdentifier("BOUNDING_BOX");
			this.GenerateSpaceAndKeyword(TSqlTokenType.EqualsSign);
			this.GenerateSpace();
			if (node.BoundingBoxParameters != null && node.BoundingBoxParameters.Count > 0)
			{
				this.GenerateParenthesisedCommaSeparatedList<BoundingBoxParameter>(node.BoundingBoxParameters);
			}
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x00027AC1 File Offset: 0x00025CC1
		public override void ExplicitVisit(BoundingBoxParameter node)
		{
			if (node.Parameter != BoundingBoxParameterType.None)
			{
				BoundingBoxParameterTypeHelper.Instance.GenerateSourceForOption(this._writer, node.Parameter);
				this.GenerateSpaceAndKeyword(TSqlTokenType.EqualsSign);
				this.GenerateSpace();
			}
			this.GenerateFragmentIfNotNull(node.Value);
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x00027AFE File Offset: 0x00025CFE
		public override void ExplicitVisit(GridsSpatialIndexOption node)
		{
			this.GenerateIdentifier("GRIDS");
			this.GenerateSpaceAndKeyword(TSqlTokenType.EqualsSign);
			this.GenerateSpace();
			if (node.GridParameters != null && node.GridParameters.Count > 0)
			{
				this.GenerateParenthesisedCommaSeparatedList<GridParameter>(node.GridParameters);
			}
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x00027B40 File Offset: 0x00025D40
		public override void ExplicitVisit(GridParameter node)
		{
			if (node.Parameter != GridParameterType.None)
			{
				GridParameterTypeHelper.Instance.GenerateSourceForOption(this._writer, node.Parameter);
				this.GenerateSpaceAndKeyword(TSqlTokenType.EqualsSign);
				this.GenerateSpace();
			}
			ImportanceParameterHelper.Instance.GenerateSourceForOption(this._writer, node.Value);
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x00027B92 File Offset: 0x00025D92
		public override void ExplicitVisit(CellsPerObjectSpatialIndexOption node)
		{
			this.GenerateIdentifier("CELLS_PER_OBJECT");
			this.GenerateSpaceAndKeyword(TSqlTokenType.EqualsSign);
			this.GenerateSpaceAndFragmentIfNotNull(node.Value);
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x00027BB8 File Offset: 0x00025DB8
		public override void ExplicitVisit(CreateStatisticsStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Create);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Statistics);
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.NewLineAndIndent();
			this.GenerateKeyword(TSqlTokenType.On);
			this.GenerateSpaceAndFragmentIfNotNull(node.OnName);
			this.GenerateParenthesisedCommaSeparatedList<ColumnReferenceExpression>(node.Columns);
			if (node.FilterPredicate != null)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.Where);
				this.GenerateSpaceAndFragmentIfNotNull(node.FilterPredicate);
			}
			if (node.StatisticsOptions != null && node.StatisticsOptions.Count > 0)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.With);
				this.GenerateSpace();
				this.GenerateCommaSeparatedList<StatisticsOption>(node.StatisticsOptions);
			}
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x00027C62 File Offset: 0x00025E62
		public override void ExplicitVisit(CreateSynonymStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Create);
			this.GenerateSpaceAndIdentifier("SYNONYM");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.GenerateSpaceAndKeyword(TSqlTokenType.For);
			this.GenerateSpaceAndFragmentIfNotNull(node.ForName);
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x00027C98 File Offset: 0x00025E98
		public override void ExplicitVisit(CreateTableStatement node)
		{
			AlignmentPoint ap = new AlignmentPoint();
			this.MarkAndPushAlignmentPoint(ap);
			this.GenerateKeyword(TSqlTokenType.Create);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Table);
			this.GenerateSpaceAndFragmentIfNotNull(node.SchemaObjectName);
			if (node.Definition != null)
			{
				List<TSqlFragment> list = new List<TSqlFragment>();
				foreach (ColumnDefinition item in node.Definition.ColumnDefinitions)
				{
					list.Add(item);
				}
				foreach (ConstraintDefinition item2 in node.Definition.TableConstraints)
				{
					list.Add(item2);
				}
				foreach (IndexDefinition item3 in node.Definition.Indexes)
				{
					list.Add(item3);
				}
				SqlScriptGeneratorVisitor.ListGenerationOption option = SqlScriptGeneratorVisitor.ListGenerationOption.CreateOptionFromFormattingConfig(this._options);
				this.GenerateFragmentList<TSqlFragment>(list, option);
			}
			if (node.AsFileTable)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.As);
				this.GenerateSpaceAndIdentifier("FILETABLE");
			}
			this.PopAlignmentPoint();
			if (node.FederationScheme != null)
			{
				this.GenerateSpaceAndIdentifier("FEDERATED");
				this.GenerateSpaceAndKeyword(TSqlTokenType.On);
				this.GenerateSpaceAndSymbol(TSqlTokenType.LeftParenthesis);
				this.GenerateFragmentIfNotNull(node.FederationScheme.DistributionName);
				this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
				this.GenerateSpaceAndFragmentIfNotNull(node.FederationScheme.ColumnName);
				this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			}
			if (node.OnFileGroupOrPartitionScheme != null)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.On);
				this.GenerateSpaceAndFragmentIfNotNull(node.OnFileGroupOrPartitionScheme);
			}
			if (node.TextImageOn != null)
			{
				this.GenerateSpaceAndIdentifier("TEXTIMAGE_ON");
				this.GenerateSpaceAndFragmentIfNotNull(node.TextImageOn);
			}
			this.GenerateFileStreamOn(node);
			this.GenerateCommaSeparatedWithClause<TableOption>(node.Options, false, true);
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x00027EA0 File Offset: 0x000260A0
		public override void ExplicitVisit(CreateTriggerStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Create);
			this.GenerateSpace();
			this.GenerateTriggerStatementBody(node);
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x00027EB8 File Offset: 0x000260B8
		public override void ExplicitVisit(CreateTypeTableStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Create);
			this.GenerateSpaceAndIdentifier("TYPE");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.GenerateSpaceAndKeyword(TSqlTokenType.As);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Table);
			this.GenerateSpaceAndSymbol(TSqlTokenType.LeftParenthesis);
			this.NewLineAndIndent();
			AlignmentPoint ap = new AlignmentPoint();
			this.MarkAndPushAlignmentPoint(ap);
			bool flag = false;
			this.GenerateColumnsConstraintsIndexes<ColumnDefinition>(node.Definition.ColumnDefinitions, ref flag);
			this.GenerateColumnsConstraintsIndexes<ConstraintDefinition>(node.Definition.TableConstraints, ref flag);
			this.GenerateColumnsConstraintsIndexes<IndexDefinition>(node.Definition.Indexes, ref flag);
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			this.GenerateCommaSeparatedWithClause<TableOption>(node.Options, false, true);
			this.PopAlignmentPoint();
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x00027F6F File Offset: 0x0002616F
		private void GenerateColumnsConstraintsIndexes<T>(IList<T> fragmentList, ref bool commaNeeded) where T : TSqlFragment
		{
			if (fragmentList != null && fragmentList.Count > 0)
			{
				if (commaNeeded)
				{
					this.GenerateSymbol(TSqlTokenType.Comma);
					this.NewLine();
				}
				this.GenerateCommaSeparatedList<T>(fragmentList, true);
				commaNeeded = true;
			}
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x00027FA0 File Offset: 0x000261A0
		public override void ExplicitVisit(CreateTypeUddtStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Create);
			this.GenerateSpaceAndIdentifier("TYPE");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.NewLineAndIndent();
			this.GenerateKeyword(TSqlTokenType.From);
			this.GenerateSpaceAndFragmentIfNotNull(node.DataType);
			this.GenerateSpaceAndFragmentIfNotNull(node.NullableConstraint);
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x00027FF4 File Offset: 0x000261F4
		public override void ExplicitVisit(CreateTypeUdtStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Create);
			this.GenerateSpaceAndIdentifier("TYPE");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.NewLineAndIndent();
			this.GenerateSpaceAndKeyword(TSqlTokenType.External);
			this.GenerateSpaceAndIdentifier("NAME");
			this.GenerateSpaceAndFragmentIfNotNull(node.AssemblyName);
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x00028048 File Offset: 0x00026248
		public override void ExplicitVisit(CreateUserStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Create);
			this.GenerateSpaceAndKeyword(TSqlTokenType.User);
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.GenerateSpaceAndFragmentIfNotNull(node.UserLoginOption);
			if (node.UserOptions != null && node.UserOptions.Count > 0)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.With);
				this.GenerateSpace();
				this.GenerateCommaSeparatedList<PrincipalOption>(node.UserOptions);
			}
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x000280B9 File Offset: 0x000262B9
		public override void ExplicitVisit(CreateViewStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Create);
			this.GenerateSpace();
			this.GenerateViewStatementBody(node);
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x000280D0 File Offset: 0x000262D0
		public override void ExplicitVisit(CreateWorkloadGroupStatement node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.Create);
			this.GenerateWorkloadGroupStatementBody(node);
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x000280E4 File Offset: 0x000262E4
		public override void ExplicitVisit(CreateXmlIndexStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Create);
			if (node.Primary)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.Primary);
			}
			this.GenerateSpaceAndIdentifier("XML");
			this.GenerateSpaceAndKeyword(TSqlTokenType.Index);
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.NewLineAndIndent();
			this.GenerateKeyword(TSqlTokenType.On);
			this.GenerateSpaceAndFragmentIfNotNull(node.OnName);
			this.GenerateParenthesisedFragmentIfNotNull(node.XmlColumn);
			if (node.SecondaryXmlIndexName != null)
			{
				this.NewLineAndIndent();
				this.GenerateIdentifier("USING");
				this.GenerateSpaceAndIdentifier("XML");
				this.GenerateSpaceAndKeyword(TSqlTokenType.Index);
				this.GenerateSpaceAndFragmentIfNotNull(node.SecondaryXmlIndexName);
				if (node.SecondaryXmlIndexType != SecondaryXmlIndexType.NotSpecified)
				{
					string valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<SecondaryXmlIndexType, string>(SqlScriptGeneratorVisitor._secondaryXmlIndexTypeNames, node.SecondaryXmlIndexType);
					this.GenerateSpaceAndKeyword(TSqlTokenType.For);
					this.GenerateSpaceAndIdentifier(valueForEnumKey);
				}
			}
			if (node.IndexOptions != null && node.IndexOptions.Count > 0)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.With);
				this.GenerateSpace();
				this.GenerateParenthesisedCommaSeparatedList<IndexOption>(node.IndexOptions);
			}
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x000281E8 File Offset: 0x000263E8
		public override void ExplicitVisit(CreateXmlSchemaCollectionStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Create);
			this.GenerateSpaceAndIdentifier("XML");
			this.GenerateSpaceAndKeyword(TSqlTokenType.Schema);
			this.GenerateSpaceAndIdentifier("COLLECTION");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.NewLineAndIndent();
			this.GenerateKeyword(TSqlTokenType.As);
			this.GenerateSpaceAndFragmentIfNotNull(node.Expression);
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x00028244 File Offset: 0x00026444
		protected void GenerateCredentialStatementBody(CredentialStatement node)
		{
			this.GenerateIdentifier("CREDENTIAL");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			if (node.Identity != null)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.With);
				this.GenerateSpace();
				this.GenerateNameEqualsValue(TSqlTokenType.Identity, node.Identity);
			}
			if (node.Secret != null)
			{
				this.GenerateSymbolAndSpace(TSqlTokenType.Comma);
				this.GenerateNameEqualsValue("SECRET", node.Secret);
			}
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x000282BC File Offset: 0x000264BC
		public override void ExplicitVisit(CreateCryptographicProviderStatement node)
		{
			AlignmentPoint ap = new AlignmentPoint();
			this.GenerateKeywordAndSpace(TSqlTokenType.Create);
			this.GenerateIdentifier("CRYPTOGRAPHIC");
			this.GenerateSpaceAndIdentifier("PROVIDER");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.CryptographicProviderFile(node.File, ap);
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x00028306 File Offset: 0x00026506
		public void CryptographicProviderFile(Literal node, AlignmentPoint ap)
		{
			this.NewLineAndIndent();
			this.MarkAndPushAlignmentPoint(ap);
			this.GenerateKeywordAndSpace(TSqlTokenType.From);
			this.GenerateNameEqualsValue(TSqlTokenType.File, node);
			this.PopAlignmentPoint();
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x0002832C File Offset: 0x0002652C
		public override void ExplicitVisit(AlterCryptographicProviderStatement node)
		{
			AlignmentPoint ap = new AlignmentPoint();
			this.GenerateKeywordAndSpace(TSqlTokenType.Alter);
			this.GenerateIdentifier("CRYPTOGRAPHIC");
			this.GenerateSpaceAndIdentifier("PROVIDER");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			if (node.Option == EnableDisableOptionType.None)
			{
				this.CryptographicProviderFile(node.File, ap);
				return;
			}
			this.NewLineAndIndent();
			this.MarkAndPushAlignmentPoint(ap);
			EnableDisableOptionTypeHelper.Instance.GenerateSourceForOption(this._writer, node.Option);
			this.PopAlignmentPoint();
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x000283A7 File Offset: 0x000265A7
		public override void ExplicitVisit(DropCryptographicProviderStatement node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.Drop);
			this.GenerateIdentifier("CRYPTOGRAPHIC");
			this.GenerateSpaceAndIdentifier("PROVIDER");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x000283D4 File Offset: 0x000265D4
		public override void ExplicitVisit(CryptoMechanism node)
		{
			switch (node.CryptoMechanismType)
			{
			case CryptoMechanismType.Certificate:
				this.GenerateIdentifier("CERTIFICATE");
				this.GenerateIdentifierWithPassword(node);
				return;
			case CryptoMechanismType.AsymmetricKey:
				this.GenerateIdentifier("ASYMMETRIC");
				this.GenerateSpaceAndKeyword(TSqlTokenType.Key);
				this.GenerateIdentifierWithPassword(node);
				return;
			case CryptoMechanismType.SymmetricKey:
				this.GenerateIdentifier("SYMMETRIC");
				this.GenerateSpaceAndKeyword(TSqlTokenType.Key);
				this.GenerateIdentifierWithPassword(node);
				return;
			case CryptoMechanismType.Password:
				this.GenerateNameEqualsValue("PASSWORD", node.PasswordOrSignature);
				return;
			default:
				return;
			}
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x0002845C File Offset: 0x0002665C
		private void GenerateIdentifierWithPassword(CryptoMechanism node)
		{
			this.GenerateSpaceAndFragmentIfNotNull(node.Identifier);
			if (node.PasswordOrSignature != null)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.With);
				string name = (node.PasswordOrSignature.LiteralType == LiteralType.Binary) ? "SIGNATURE" : "PASSWORD";
				this.GenerateSpace();
				this.GenerateNameEqualsValue(name, node.PasswordOrSignature);
			}
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x000284B6 File Offset: 0x000266B6
		public SqlScriptGeneratorVisitor(SqlScriptGeneratorOptions options, ScriptWriter writer)
		{
			this._options = options;
			this._writer = writer;
			this._alignmentPointsForFragments = new Dictionary<TSqlFragment, Dictionary<string, AlignmentPoint>>();
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x000284DE File Offset: 0x000266DE
		protected void NewLineAndIndent()
		{
			this.NewLine();
			this.Indent();
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x000284EC File Offset: 0x000266EC
		protected void Indent()
		{
			this.Indent(this._options.IndentationSize);
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x000284FF File Offset: 0x000266FF
		protected void NewLineAndIndent(int indentSize)
		{
			this.NewLine();
			this.Indent(indentSize);
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x0002850E File Offset: 0x0002670E
		protected void Indent(int indentSize)
		{
			this._writer.Indent(indentSize);
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x0002851C File Offset: 0x0002671C
		protected void Mark(AlignmentPoint ap)
		{
			this._writer.Mark(ap);
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x0002852A File Offset: 0x0002672A
		protected void NewLine()
		{
			this._writer.NewLine();
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x00028537 File Offset: 0x00026737
		protected void PushAlignmentPoint(AlignmentPoint ap)
		{
			this._writer.PushNewLineAlignmentPoint(ap);
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x00028545 File Offset: 0x00026745
		protected void PopAlignmentPoint()
		{
			this._writer.PopNewLineAlignmentPoint();
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x00028552 File Offset: 0x00026752
		protected void MarkAndPushAlignmentPoint(AlignmentPoint ap)
		{
			this.Mark(ap);
			this.PushAlignmentPoint(ap);
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x00028562 File Offset: 0x00026762
		protected AlignmentPoint FindOrCreateAlignmentPointByName(string apName)
		{
			return this._writer.FindOrCreateAlignmentPoint(apName);
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x00028570 File Offset: 0x00026770
		protected void AddAlignmentPointForFragment(TSqlFragment node, AlignmentPoint ap)
		{
			if (node != null && ap != null && !string.IsNullOrEmpty(ap.Name))
			{
				Dictionary<string, AlignmentPoint> dictionary;
				if (!this._alignmentPointsForFragments.TryGetValue(node, out dictionary))
				{
					dictionary = new Dictionary<string, AlignmentPoint>();
					this._alignmentPointsForFragments.Add(node, dictionary);
				}
				if (!string.IsNullOrEmpty(ap.Name) && !dictionary.ContainsKey(ap.Name))
				{
					dictionary.Add(ap.Name, ap);
				}
			}
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x000285DC File Offset: 0x000267DC
		protected AlignmentPoint GetAlignmentPointForFragment(TSqlFragment node, string name)
		{
			AlignmentPoint result = null;
			Dictionary<string, AlignmentPoint> dictionary;
			if (node != null && !string.IsNullOrEmpty(name) && this._alignmentPointsForFragments.TryGetValue(node, out dictionary) && !dictionary.TryGetValue(name, out result))
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x00028614 File Offset: 0x00026814
		protected void ClearAlignmentPointsForFragment(TSqlFragment node)
		{
			if (node != null)
			{
				this._alignmentPointsForFragments.Remove(node);
			}
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x00028626 File Offset: 0x00026826
		public override void ExplicitVisit(CursorDefaultDatabaseOption node)
		{
			this.GenerateIdentifier("CURSOR_DEFAULT");
			this.GenerateSpaceAndIdentifier(node.IsLocal ? "LOCAL" : "GLOBAL");
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x00028650 File Offset: 0x00026850
		public override void ExplicitVisit(CursorDefinition node)
		{
			AlignmentPoint ap = new AlignmentPoint();
			this.GenerateKeyword(TSqlTokenType.Cursor);
			foreach (CursorOption cursorOption in node.Options)
			{
				if (cursorOption.OptionKind != CursorOptionKind.Insensitive)
				{
					this.GenerateFragmentIfNotNull(cursorOption);
				}
			}
			this.NewLineAndIndent();
			this.GenerateKeyword(TSqlTokenType.For);
			this.GenerateSpace();
			this.MarkAndPushAlignmentPoint(ap);
			bool generateSemiColon = this._generateSemiColon;
			this._generateSemiColon = false;
			this.GenerateFragmentIfNotNull(node.Select);
			this._generateSemiColon = generateSemiColon;
			this.PopAlignmentPoint();
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x000286F8 File Offset: 0x000268F8
		public override void ExplicitVisit(CursorOption node)
		{
			string valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<CursorOptionKind, string>(SqlScriptGeneratorVisitor._cursorOptionsNames, node.OptionKind);
			this.GenerateSpaceAndIdentifier(valueForEnumKey);
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x0002871D File Offset: 0x0002691D
		public override void ExplicitVisit(CursorId node)
		{
			if (node.IsGlobal)
			{
				this.GenerateIdentifier("GLOBAL");
				this.GenerateSpace();
			}
			this.GenerateFragmentIfNotNull(node.Name);
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x00028744 File Offset: 0x00026944
		public override void ExplicitVisit(DatabaseAuditAction node)
		{
			TokenGenerator valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<DatabaseAuditActionKind, TokenGenerator>(SqlScriptGeneratorVisitor._databaseAuditActionName, node.ActionKind);
			this.GenerateToken(valueForEnumKey);
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x00028769 File Offset: 0x00026969
		public override void ExplicitVisit(AlterDatabaseAuditSpecificationStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Alter);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Database);
			this.GenerateSpace();
			this.GenerateAuditSpecificationStatement(node);
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x00028787 File Offset: 0x00026987
		public override void ExplicitVisit(CreateDatabaseAuditSpecificationStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Create);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Database);
			this.GenerateSpace();
			this.GenerateAuditSpecificationStatement(node);
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x000287A6 File Offset: 0x000269A6
		public override void ExplicitVisit(DropDatabaseAuditSpecificationStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Drop);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Database);
			this.GenerateSpaceAndIdentifier("AUDIT");
			this.GenerateSpaceAndIdentifier("SPECIFICATION");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x000287DA File Offset: 0x000269DA
		public override void ExplicitVisit(AlterDatabaseEncryptionKeyStatement node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.Alter);
			this.GenerateDatabaseEncryptionKeyHeader();
			if (node.Regenerate)
			{
				this.GenerateSpaceAndIdentifier("REGENERATE");
			}
			this.GenerateSpace();
			this.GenerateDatabaseEncryptionKeyStatementBody(node);
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x00028809 File Offset: 0x00026A09
		public override void ExplicitVisit(CreateDatabaseEncryptionKeyStatement node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.Create);
			this.GenerateDatabaseEncryptionKeyHeader();
			this.GenerateSpace();
			this.GenerateDatabaseEncryptionKeyStatementBody(node);
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x00028826 File Offset: 0x00026A26
		public override void ExplicitVisit(DropDatabaseEncryptionKeyStatement node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.Drop);
			this.GenerateDatabaseEncryptionKeyHeader();
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x00028836 File Offset: 0x00026A36
		private void GenerateDatabaseEncryptionKeyHeader()
		{
			this.GenerateKeyword(TSqlTokenType.Database);
			this.GenerateSpaceAndIdentifier("ENCRYPTION");
			this.GenerateSpaceAndKeyword(TSqlTokenType.Key);
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x00028854 File Offset: 0x00026A54
		protected void GenerateDatabaseEncryptionKeyStatementBody(DatabaseEncryptionKeyStatement node)
		{
			if (node.Algorithm != DatabaseEncryptionKeyAlgorithm.None)
			{
				this.GenerateKeyword(TSqlTokenType.With);
				this.GenerateSpaceAndIdentifier("ALGORITHM");
				this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
				this.GenerateSpace();
				DatabaseEncryptionKeyAlgorithmHelper.Instance.GenerateSourceForOption(this._writer, node.Algorithm);
			}
			if (node.Encryptor != null)
			{
				this.NewLineAndIndent();
				this.GenerateIdentifier("ENCRYPTION");
				this.GenerateSpaceAndKeyword(TSqlTokenType.By);
				this.GenerateSpaceAndIdentifier("SERVER");
				this.GenerateSpace();
				this.GenerateFragmentIfNotNull(node.Encryptor);
			}
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x000288E4 File Offset: 0x00026AE4
		public override void ExplicitVisit(DatabaseOption node)
		{
			SimpleDbOptionsHelper.Instance.GenerateSourceForOption(this._writer, node.OptionKind);
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x000288FC File Offset: 0x00026AFC
		public override void ExplicitVisit(DataCompressionOption node)
		{
			this.GenerateTokenAndEqualSign("DATA_COMPRESSION");
			this.GenerateSpace();
			DataCompressionLevelHelper.Instance.GenerateSourceForOption(this._writer, node.CompressionLevel);
			if (node.PartitionRanges.Count > 0)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.On);
				this.GenerateSpaceAndIdentifier("PARTITIONS");
				this.GenerateSpace();
				this.GenerateParenthesisedCommaSeparatedList<CompressionPartitionRange>(node.PartitionRanges);
			}
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x00028963 File Offset: 0x00026B63
		public override void ExplicitVisit(DataModificationTableReference node)
		{
			this.GenerateSymbol(TSqlTokenType.LeftParenthesis);
			this.GenerateFragmentIfNotNull(node.DataModificationSpecification);
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			this.GenerateTableAndColumnAliases(node);
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x0002898E File Offset: 0x00026B8E
		public override void ExplicitVisit(DbccNamedLiteral node)
		{
			if (node.Name != null)
			{
				this.GenerateNameEqualsValue(node.Name, node.Value);
				return;
			}
			this.GenerateFragmentIfNotNull(node.Value);
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x000289B8 File Offset: 0x00026BB8
		public override void ExplicitVisit(DbccStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Dbcc);
			if (node.Command == DbccCommand.Free)
			{
				this.GenerateSpace();
				this.GenerateIdentifierWithoutCasing(node.DllName);
			}
			else
			{
				string valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<DbccCommand, string>(SqlScriptGeneratorVisitor._dbccCommandNames, node.Command);
				if (valueForEnumKey != null)
				{
					this.GenerateSpaceAndIdentifier(valueForEnumKey);
				}
			}
			if (node.ParenthesisRequired || node.Literals.Count > 0)
			{
				this.GenerateSpaceAndSymbol(TSqlTokenType.LeftParenthesis);
				this.GenerateCommaSeparatedList<DbccNamedLiteral>(node.Literals);
				this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			}
			if (node.Options != null && node.Options.Count > 0)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.With);
				this.GenerateSpace();
				if (node.OptionsUseJoin)
				{
					this.GenerateJoinSeparatedList<DbccOption>(node.Options);
					return;
				}
				this.GenerateCommaSeparatedList<DbccOption>(node.Options);
			}
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x00028A8C File Offset: 0x00026C8C
		public override void ExplicitVisit(DbccOption node)
		{
			TokenGenerator valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<DbccOptionKind, TokenGenerator>(SqlScriptGeneratorVisitor._dbccOptionsGenerators, node.OptionKind);
			this.GenerateToken(valueForEnumKey);
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x00028AC7 File Offset: 0x00026CC7
		protected void GenerateJoinSeparatedList<T>(IList<T> list) where T : TSqlFragment
		{
			this.GenerateList<T>(list, delegate
			{
				this.GenerateSpace();
				this.GenerateSymbol(TSqlTokenType.Join);
				this.GenerateSpace();
			});
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x00028ADC File Offset: 0x00026CDC
		public override void ExplicitVisit(DeallocateCursorStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Deallocate);
			this.GenerateSpaceAndFragmentIfNotNull(node.Cursor);
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x00028AF4 File Offset: 0x00026CF4
		public override void ExplicitVisit(DeclareCursorStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Declare);
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			if (node.CursorDefinition != null && node.CursorDefinition.Options != null)
			{
				foreach (CursorOption cursorOption in node.CursorDefinition.Options)
				{
					if (cursorOption.OptionKind == CursorOptionKind.Insensitive)
					{
						this.GenerateFragmentIfNotNull(cursorOption);
					}
				}
			}
			this.GenerateSpaceAndFragmentIfNotNull(node.CursorDefinition);
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x00028B84 File Offset: 0x00026D84
		public override void ExplicitVisit(DeclareTableVariableStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Declare);
			this.GenerateSpaceAndFragmentIfNotNull(node.Body);
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x00028B9C File Offset: 0x00026D9C
		public override void ExplicitVisit(DeclareTableVariableBody node)
		{
			this.GenerateFragmentIfNotNull(node.VariableName);
			if (node.AsDefined)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.As);
			}
			this.GenerateSpaceAndKeyword(TSqlTokenType.Table);
			this.GenerateSpaceAndSymbol(TSqlTokenType.LeftParenthesis);
			this.NewLineAndIndent();
			AlignmentPoint ap = new AlignmentPoint();
			this.MarkAndPushAlignmentPoint(ap);
			this.GenerateCommaSeparatedList<ColumnDefinition>(node.Definition.ColumnDefinitions, true);
			if (node.Definition.ColumnDefinitions != null && node.Definition.ColumnDefinitions.Count > 0 && node.Definition.TableConstraints != null && node.Definition.TableConstraints.Count > 0)
			{
				this.GenerateSymbol(TSqlTokenType.Comma);
				this.NewLine();
			}
			this.GenerateCommaSeparatedList<ConstraintDefinition>(node.Definition.TableConstraints, true);
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			this.PopAlignmentPoint();
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x00028C74 File Offset: 0x00026E74
		public override void ExplicitVisit(DeclareVariableElement node)
		{
			this.GenerateFragmentIfNotNull(node.VariableName);
			this.GenerateSpaceAndKeyword(TSqlTokenType.As);
			this.GenerateSpaceAndFragmentIfNotNull(node.DataType);
			this.GenerateSpaceAndFragmentIfNotNull(node.Nullable);
			if (node.Value != null)
			{
				this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
				this.GenerateSpaceAndFragmentIfNotNull(node.Value);
			}
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x00028CCC File Offset: 0x00026ECC
		public override void ExplicitVisit(DeclareVariableStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Declare);
			this.GenerateSpace();
			this.GenerateCommaSeparatedList<DeclareVariableElement>(node.Declarations);
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x00028CE8 File Offset: 0x00026EE8
		public override void ExplicitVisit(DefaultConstraintDefinition node)
		{
			this.GenerateConstraintHead(node);
			this.GenerateKeywordAndSpace(TSqlTokenType.Default);
			this.GenerateFragmentIfNotNull(node.Expression);
			if (node.Column != null)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.For);
				this.GenerateSpaceAndFragmentIfNotNull(node.Column);
			}
			if (node.WithValues)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.With);
				this.GenerateSpaceAndKeyword(TSqlTokenType.Values);
			}
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x00028D4A File Offset: 0x00026F4A
		public override void ExplicitVisit(DelayedDurabilityDatabaseOption node)
		{
			this.GenerateIdentifier("DELAYED_DURABILITY");
			this.GenerateSpace();
			this.GenerateSymbol(TSqlTokenType.EqualsSign);
			this.GenerateSpace();
			DelayedDurabilityOptionKindHelper.Instance.GenerateSourceForOption(this._writer, node.Value);
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x00028D84 File Offset: 0x00026F84
		public override void ExplicitVisit(DeleteStatement node)
		{
			AlignmentPoint ap = new AlignmentPoint();
			AlignmentPoint ap2 = new AlignmentPoint("ClauseBody");
			this.MarkAndPushAlignmentPoint(ap);
			if (node.WithCtesAndXmlNamespaces != null)
			{
				this.GenerateFragmentWithAlignmentPointIfNotNull(node.WithCtesAndXmlNamespaces, ap2);
				this.NewLine();
			}
			this.GenerateFragmentIfNotNull(node.DeleteSpecification);
			this.GenerateOptimizerHints(node.OptimizerHints);
			this.PopAlignmentPoint();
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x00028DE4 File Offset: 0x00026FE4
		public override void ExplicitVisit(DeleteSpecification node)
		{
			AlignmentPoint alignmentPoint = new AlignmentPoint("ClauseBody");
			this.GenerateKeyword(TSqlTokenType.Delete);
			if (node.TopRowFilter != null)
			{
				this.MarkClauseBodyAlignmentWhenNecessary(true, alignmentPoint);
				this.GenerateSpaceAndFragmentIfNotNull(node.TopRowFilter);
				this.NewLine();
			}
			this.MarkClauseBodyAlignmentWhenNecessary(true, alignmentPoint);
			this.GenerateSpaceAndFragmentIfNotNull(node.Target);
			if (node.OutputIntoClause != null)
			{
				this.GenerateSeparatorForOutputClause();
				this.GenerateFragmentWithAlignmentPointIfNotNull(node.OutputIntoClause, alignmentPoint);
			}
			if (node.OutputClause != null)
			{
				this.GenerateSeparatorForOutputClause();
				this.GenerateFragmentWithAlignmentPointIfNotNull(node.OutputClause, alignmentPoint);
			}
			this.GenerateFromClause(node.FromClause, alignmentPoint);
			if (node.WhereClause != null)
			{
				this.GenerateSeparatorForWhereClause();
				this.GenerateFragmentWithAlignmentPointIfNotNull(node.WhereClause, alignmentPoint);
			}
		}

		// Token: 0x06000DDE RID: 3550 RVA: 0x00028E98 File Offset: 0x00027098
		public override void ExplicitVisit(DenyStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Deny);
			this.GenerateSpace();
			this.GeneratePermissionOnToClauses(node);
			if (node.CascadeOption)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.Cascade);
			}
			this.GenerateAsClause(node);
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x00028EC8 File Offset: 0x000270C8
		public override void ExplicitVisit(DenyStatement80 node)
		{
			this.GenerateKeyword(TSqlTokenType.Deny);
			this.GenerateSpaceAndFragmentIfNotNull(node.SecurityElement80);
			this.NewLineAndIndent();
			this.GenerateKeyword(TSqlTokenType.To);
			this.GenerateSpaceAndFragmentIfNotNull(node.SecurityUserClause80);
			if (node.CascadeOption)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.Cascade);
			}
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x00028F1C File Offset: 0x0002711C
		public override void ExplicitVisit(QueryDerivedTable node)
		{
			this.GenerateQueryExpressionInParentheses(node.QueryExpression);
			this.GenerateTableAndColumnAliases(node);
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x00028F31 File Offset: 0x00027131
		public override void ExplicitVisit(InlineDerivedTable node)
		{
			this.GenerateSymbol(TSqlTokenType.LeftParenthesis);
			this.GenerateSymbolAndSpace(TSqlTokenType.Values);
			this.GenerateCommaSeparatedList<RowValue>(node.RowValues);
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			this.GenerateTableAndColumnAliases(node);
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x00028F68 File Offset: 0x00027168
		public override void ExplicitVisit(DeviceInfo node)
		{
			if (node.LogicalDevice != null)
			{
				this.GenerateFragmentIfNotNull(node.LogicalDevice);
				return;
			}
			TokenGenerator valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<DeviceType, TokenGenerator>(SqlScriptGeneratorVisitor._deviceTypeGenerators, node.DeviceType);
			if (valueForEnumKey != null)
			{
				this.GenerateNameEqualsValue(valueForEnumKey, node.PhysicalDevice);
			}
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x00028FAB File Offset: 0x000271AB
		public override void ExplicitVisit(MirrorToClause node)
		{
			this.GenerateIdentifier("MIRROR");
			this.GenerateSpaceAndKeyword(TSqlTokenType.To);
			this.GenerateSpace();
			this.GenerateCommaSeparatedList<DeviceInfo>(node.Devices);
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x00028FD8 File Offset: 0x000271D8
		public override void ExplicitVisit(DiskStatement node)
		{
			this.GenerateIdentifier("DISK");
			switch (node.DiskStatementType)
			{
			case DiskStatementType.Init:
				this.GenerateSpaceAndIdentifier("INIT");
				break;
			case DiskStatementType.Resize:
				this.GenerateSpaceAndIdentifier("RESIZE");
				break;
			}
			this.GenerateSpace();
			this.GenerateCommaSeparatedList<DiskStatementOption>(node.Options);
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x00029031 File Offset: 0x00027231
		public override void ExplicitVisit(DiskStatementOption node)
		{
			DiskStatementOptionsHelper.Instance.GenerateSourceForOption(this._writer, node.OptionKind);
			this.GenerateSpace();
			this.GenerateSymbol(TSqlTokenType.EqualsSign);
			this.GenerateSpaceAndFragmentIfNotNull(node.Value);
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x00029066 File Offset: 0x00027266
		public override void ExplicitVisit(DropAggregateStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Drop);
			this.GenerateSpaceAndIdentifier("AGGREGATE");
			this.GenerateSpace();
			this.GenerateCommaSeparatedList<SchemaObjectName>(node.Objects);
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x0002908D File Offset: 0x0002728D
		public override void ExplicitVisit(DropApplicationRoleStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Drop);
			this.GenerateSpaceAndIdentifier("APPLICATION");
			this.GenerateSpaceAndIdentifier("ROLE");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x000290BC File Offset: 0x000272BC
		public override void ExplicitVisit(DropAssemblyStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Drop);
			this.GenerateSpaceAndIdentifier("ASSEMBLY");
			this.GenerateSpace();
			this.GenerateCommaSeparatedList<SchemaObjectName>(node.Objects);
			if (node.WithNoDependents)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.With);
				this.GenerateSpaceAndIdentifier("NO");
				this.GenerateSpaceAndIdentifier("DEPENDENTS");
			}
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x0002911D File Offset: 0x0002731D
		public override void ExplicitVisit(DropAvailabilityGroupStatement node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.Drop);
			this.GenerateIdentifier("AVAILABILITY");
			this.GenerateSpaceAndKeyword(TSqlTokenType.Group);
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x00029146 File Offset: 0x00027346
		public override void ExplicitVisit(DropBrokerPriorityStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Drop);
			this.GenerateSpaceAndIdentifier("BROKER");
			this.GenerateSpaceAndIdentifier("PRIORITY");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x00029172 File Offset: 0x00027372
		public override void ExplicitVisit(DropCertificateStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Drop);
			this.GenerateSpaceAndIdentifier("CERTIFICATE");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x00029194 File Offset: 0x00027394
		protected void GenerateOptionHeader(DropClusteredConstraintOption node)
		{
			List<TokenGenerator> valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<DropClusteredConstraintOptionKind, List<TokenGenerator>>(SqlScriptGeneratorVisitor._dropClusteredConstraintOptionTypeGenerators, node.OptionKind);
			if (valueForEnumKey != null)
			{
				this.GenerateTokenList(valueForEnumKey);
			}
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x000291BC File Offset: 0x000273BC
		public override void ExplicitVisit(DropClusteredConstraintValueOption node)
		{
			this.GenerateOptionHeader(node);
			this.GenerateSpaceAndFragmentIfNotNull(node.OptionValue);
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x000291D1 File Offset: 0x000273D1
		public override void ExplicitVisit(DropClusteredConstraintMoveOption node)
		{
			this.GenerateOptionHeader(node);
			this.GenerateSpaceAndFragmentIfNotNull(node.OptionValue);
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x000291E6 File Offset: 0x000273E6
		public override void ExplicitVisit(DropClusteredConstraintStateOption node)
		{
			this.GenerateOptionHeader(node);
			this.GenerateSpace();
			this.GenerateOptionStateOnOff(node.OptionState);
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x00029201 File Offset: 0x00027401
		public override void ExplicitVisit(DropContractStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Drop);
			this.GenerateSpaceAndIdentifier("CONTRACT");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x00029222 File Offset: 0x00027422
		public override void ExplicitVisit(DropCredentialStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Drop);
			this.GenerateSpaceAndIdentifier("CREDENTIAL");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x00029243 File Offset: 0x00027443
		public override void ExplicitVisit(DropDatabaseStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Drop);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Database);
			this.GenerateSpace();
			this.GenerateCommaSeparatedList<Identifier>(node.Databases);
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x00029267 File Offset: 0x00027467
		public override void ExplicitVisit(DropDefaultStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Drop);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Default);
			this.GenerateSpace();
			this.GenerateCommaSeparatedList<SchemaObjectName>(node.Objects);
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x0002928B File Offset: 0x0002748B
		public override void ExplicitVisit(DropEndpointStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Drop);
			this.GenerateSpaceAndIdentifier("ENDPOINT");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x000292AC File Offset: 0x000274AC
		public override void ExplicitVisit(DropEventNotificationStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Drop);
			this.GenerateSpaceAndIdentifier("EVENT");
			this.GenerateSpaceAndIdentifier("NOTIFICATION");
			this.GenerateSpace();
			this.GenerateCommaSeparatedList<Identifier>(node.Notifications);
			this.NewLineAndIndent();
			this.GenerateKeyword(TSqlTokenType.On);
			this.GenerateSpaceAndFragmentIfNotNull(node.Scope);
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x00029303 File Offset: 0x00027503
		public override void ExplicitVisit(DropFederationStatement node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.Drop);
			this.GenerateIdentifier("FEDERATION");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x00029324 File Offset: 0x00027524
		public override void ExplicitVisit(DropFullTextCatalogStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Drop);
			this.GenerateSpaceAndIdentifier("FULLTEXT");
			this.GenerateSpaceAndIdentifier("CATALOG");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x00029350 File Offset: 0x00027550
		public override void ExplicitVisit(DropFullTextIndexStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Drop);
			this.GenerateSpaceAndIdentifier("FULLTEXT");
			this.GenerateSpaceAndKeyword(TSqlTokenType.Index);
			this.GenerateSpaceAndKeyword(TSqlTokenType.On);
			this.GenerateSpaceAndFragmentIfNotNull(node.TableName);
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x00029381 File Offset: 0x00027581
		public override void ExplicitVisit(DropFullTextStopListStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Drop);
			this.GenerateSpaceAndIdentifier("FULLTEXT");
			this.GenerateSpaceAndKeyword(TSqlTokenType.StopList);
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x000293AD File Offset: 0x000275AD
		public override void ExplicitVisit(DropFunctionStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Drop);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Function);
			this.GenerateSpace();
			this.GenerateCommaSeparatedList<SchemaObjectName>(node.Objects);
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x000293D1 File Offset: 0x000275D1
		public override void ExplicitVisit(DropIndexClause node)
		{
			this.GenerateFragmentIfNotNull(node.Index);
			this.NewLineAndIndent();
			this.GenerateKeyword(TSqlTokenType.On);
			this.GenerateSpaceAndFragmentIfNotNull(node.Object);
			this.GenerateCommaSeparatedWithClause<IndexOption>(node.Options, true, true);
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x00029407 File Offset: 0x00027607
		public override void ExplicitVisit(MoveToDropIndexOption node)
		{
			this.GenerateIdentifier("MOVE");
			this.GenerateSpaceAndKeyword(TSqlTokenType.To);
			this.GenerateSpaceAndFragmentIfNotNull(node.MoveTo);
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x0002942B File Offset: 0x0002762B
		public override void ExplicitVisit(FileStreamOnDropIndexOption node)
		{
			this.GenerateIdentifier("FILESTREAM_ON");
			this.GenerateSpaceAndFragmentIfNotNull(node.FileStreamOn);
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x00029444 File Offset: 0x00027644
		public override void ExplicitVisit(DropIndexStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Drop);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Index);
			this.GenerateSpace();
			this.GenerateCommaSeparatedList<DropIndexClauseBase>(node.DropIndexClauses);
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x00029468 File Offset: 0x00027668
		public override void ExplicitVisit(DropLoginStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Drop);
			this.GenerateSpaceAndIdentifier("LOGIN");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x00029489 File Offset: 0x00027689
		public override void ExplicitVisit(DropMasterKeyStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Drop);
			this.GenerateSpaceAndIdentifier("MASTER");
			this.GenerateSpaceAndKeyword(TSqlTokenType.Key);
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x000294A6 File Offset: 0x000276A6
		public override void ExplicitVisit(DropMessageTypeStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Drop);
			this.GenerateSpaceAndIdentifier("MESSAGE");
			this.GenerateSpaceAndIdentifier("TYPE");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x000294D2 File Offset: 0x000276D2
		public override void ExplicitVisit(DropPartitionFunctionStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Drop);
			this.GenerateSpaceAndIdentifier("PARTITION");
			this.GenerateSpaceAndKeyword(TSqlTokenType.Function);
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x000294FB File Offset: 0x000276FB
		public override void ExplicitVisit(DropPartitionSchemeStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Drop);
			this.GenerateSpaceAndIdentifier("PARTITION");
			this.GenerateSpaceAndIdentifier("SCHEME");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x00029527 File Offset: 0x00027727
		public override void ExplicitVisit(DropProcedureStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Drop);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Procedure);
			this.GenerateSpace();
			this.GenerateCommaSeparatedList<SchemaObjectName>(node.Objects);
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x0002954B File Offset: 0x0002774B
		public override void ExplicitVisit(DropQueueStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Drop);
			this.GenerateSpaceAndIdentifier("QUEUE");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x0002956C File Offset: 0x0002776C
		public override void ExplicitVisit(DropRemoteServiceBindingStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Drop);
			this.GenerateSpaceAndIdentifier("REMOTE");
			this.GenerateSpaceAndIdentifier("SERVICE");
			this.GenerateSpaceAndIdentifier("BINDING");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x000295A3 File Offset: 0x000277A3
		public override void ExplicitVisit(DropResourcePoolStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Drop);
			this.GenerateSpaceAndIdentifier("RESOURCE");
			this.GenerateSpaceAndIdentifier("POOL");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x000295CF File Offset: 0x000277CF
		public override void ExplicitVisit(DropRoleStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Drop);
			this.GenerateSpaceAndIdentifier("ROLE");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x000295F0 File Offset: 0x000277F0
		public override void ExplicitVisit(DropRouteStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Drop);
			this.GenerateSpaceAndIdentifier("ROUTE");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x00029611 File Offset: 0x00027811
		public override void ExplicitVisit(DropRuleStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Drop);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Rule);
			this.GenerateSpace();
			this.GenerateCommaSeparatedList<SchemaObjectName>(node.Objects);
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x00029638 File Offset: 0x00027838
		public override void ExplicitVisit(DropSchemaStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Drop);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Schema);
			this.GenerateSpaceAndFragmentIfNotNull(node.Schema);
			if (node.DropBehavior == DropSchemaBehavior.Cascade)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.Cascade);
				return;
			}
			if (node.DropBehavior == DropSchemaBehavior.Restrict)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.Restrict);
			}
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x0002968C File Offset: 0x0002788C
		public override void ExplicitVisit(DropSearchPropertyListStatement node)
		{
			this.GenerateSpaceSeparatedTokens(TSqlTokenType.Drop, new string[]
			{
				"SEARCH",
				"PROPERTY",
				"LIST"
			});
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x000296CD File Offset: 0x000278CD
		public override void ExplicitVisit(DropSequenceStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Drop);
			this.GenerateSpaceAndIdentifier("SEQUENCE");
			this.GenerateSpace();
			this.GenerateCommaSeparatedList<SchemaObjectName>(node.Objects);
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x000296F4 File Offset: 0x000278F4
		public override void ExplicitVisit(DropServerRoleStatement node)
		{
			this.GenerateSpaceSeparatedTokens(TSqlTokenType.Drop, new string[]
			{
				"SERVER",
				"ROLE"
			});
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x0002972D File Offset: 0x0002792D
		public override void ExplicitVisit(DropServiceStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Drop);
			this.GenerateSpaceAndIdentifier("SERVICE");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x0002974E File Offset: 0x0002794E
		public override void ExplicitVisit(DropSignatureStatement node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.Drop);
			this.GenerateCounterSignature(node);
			this.GenerateSpaceAndKeyword(TSqlTokenType.From);
			this.GenerateSpace();
			this.GenerateModule(node);
			this.NewLineAndIndent();
			this.GenerateCryptos(node);
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x00029781 File Offset: 0x00027981
		public override void ExplicitVisit(DropStatisticsStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Drop);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Statistics);
			this.GenerateSpace();
			this.GenerateCommaSeparatedList<ChildObjectName>(node.Objects);
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x000297A8 File Offset: 0x000279A8
		public override void ExplicitVisit(DropSynonymStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Drop);
			this.GenerateSpaceAndIdentifier("SYNONYM");
			this.GenerateSpace();
			this.GenerateCommaSeparatedList<SchemaObjectName>(node.Objects);
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x000297CF File Offset: 0x000279CF
		public override void ExplicitVisit(DropTableStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Drop);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Table);
			this.GenerateSpace();
			this.GenerateCommaSeparatedList<SchemaObjectName>(node.Objects);
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x000297F8 File Offset: 0x000279F8
		public override void ExplicitVisit(DropTriggerStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Drop);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Trigger);
			this.GenerateSpace();
			this.GenerateCommaSeparatedList<SchemaObjectName>(node.Objects);
			switch (node.TriggerScope)
			{
			case TriggerScope.Normal:
				break;
			case TriggerScope.Database:
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.On);
				this.GenerateSpaceAndKeyword(TSqlTokenType.Database);
				return;
			case TriggerScope.AllServer:
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.On);
				this.GenerateSpaceAndKeyword(TSqlTokenType.All);
				this.GenerateSpaceAndIdentifier("SERVER");
				break;
			default:
				return;
			}
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x0002987B File Offset: 0x00027A7B
		public override void ExplicitVisit(DropTypeStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Drop);
			this.GenerateSpaceAndIdentifier("TYPE");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x0002989C File Offset: 0x00027A9C
		public override void ExplicitVisit(DropUserStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Drop);
			this.GenerateSpaceAndKeyword(TSqlTokenType.User);
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x000298BD File Offset: 0x00027ABD
		public override void ExplicitVisit(DropViewStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Drop);
			this.GenerateSpaceAndKeyword(TSqlTokenType.View);
			this.GenerateSpace();
			this.GenerateCommaSeparatedList<SchemaObjectName>(node.Objects);
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x000298E4 File Offset: 0x00027AE4
		public override void ExplicitVisit(DropWorkloadGroupStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Drop);
			this.GenerateSpaceAndIdentifier("WORKLOAD");
			this.GenerateSpaceAndKeyword(TSqlTokenType.Group);
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x0002990D File Offset: 0x00027B0D
		public override void ExplicitVisit(DropXmlSchemaCollectionStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Drop);
			this.GenerateSpaceAndIdentifier("XML");
			this.GenerateSpaceAndKeyword(TSqlTokenType.Schema);
			this.GenerateSpaceAndIdentifier("COLLECTION");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x00029944 File Offset: 0x00027B44
		public override void ExplicitVisit(DurabilityTableOption node)
		{
			this.GenerateTokenAndEqualSign("DURABILITY");
			switch (node.DurabilityTableOptionKind)
			{
			case DurabilityTableOptionKind.SchemaOnly:
				this.GenerateSpaceAndIdentifier("SCHEMA_ONLY");
				return;
			case DurabilityTableOptionKind.SchemaAndData:
				this.GenerateSpaceAndIdentifier("SCHEMA_AND_DATA");
				return;
			default:
				return;
			}
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x0002998C File Offset: 0x00027B8C
		public override void ExplicitVisit(EnabledDisabledPayloadOption node)
		{
			TokenGenerator valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<PayloadOptionKinds, TokenGenerator>(SqlScriptGeneratorVisitor._payloadOptionKindsGenerators, node.Kind);
			if (valueForEnumKey != null)
			{
				this.GenerateNameEqualsValue(valueForEnumKey, node.IsEnabled ? "ENABLED" : "DISABLED");
			}
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x000299C8 File Offset: 0x00027BC8
		public override void ExplicitVisit(EnableDisableTriggerStatement node)
		{
			this.GenerateTriggerEnforcement(node.TriggerEnforcement);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Trigger);
			this.GenerateSpace();
			if (node.All)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.All);
			}
			else
			{
				this.GenerateCommaSeparatedList<SchemaObjectName>(node.TriggerNames);
			}
			this.NewLineAndIndent();
			this.GenerateKeyword(TSqlTokenType.On);
			this.GenerateSpaceAndFragmentIfNotNull(node.TriggerObject);
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x00029A2C File Offset: 0x00027C2C
		public override void ExplicitVisit(EncryptionPayloadOption node)
		{
			this.GenerateTokenAndEqualSign("ENCRYPTION");
			TokenGenerator valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<EndpointEncryptionSupport, TokenGenerator>(SqlScriptGeneratorVisitor._endpointEncryptionSupportGenerators, node.EncryptionSupport);
			if (valueForEnumKey != null)
			{
				this.GenerateSpace();
				this.GenerateToken(valueForEnumKey);
			}
			if (node.EncryptionSupport != EndpointEncryptionSupport.Disabled && node.EncryptionSupport != EndpointEncryptionSupport.NotSpecified)
			{
				if (node.AlgorithmPartOne != EncryptionAlgorithmPreference.NotSpecified || node.AlgorithmPartTwo != EncryptionAlgorithmPreference.NotSpecified)
				{
					this.GenerateSpaceAndIdentifier("ALGORITHM");
				}
				this.GenerateSpaceAndAlgorithm(node.AlgorithmPartOne);
				this.GenerateSpaceAndAlgorithm(node.AlgorithmPartTwo);
			}
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x00029AAC File Offset: 0x00027CAC
		private void GenerateSpaceAndAlgorithm(EncryptionAlgorithmPreference alg)
		{
			switch (alg)
			{
			case EncryptionAlgorithmPreference.NotSpecified:
				break;
			case EncryptionAlgorithmPreference.Aes:
				this.GenerateSpaceAndIdentifier("AES");
				return;
			case EncryptionAlgorithmPreference.Rc4:
				this.GenerateSpaceAndIdentifier("RC4");
				break;
			default:
				return;
			}
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x00029AE5 File Offset: 0x00027CE5
		public override void ExplicitVisit(AssemblyEncryptionSource node)
		{
			this.GenerateIdentifier("ASSEMBLY");
			this.GenerateSpaceAndFragmentIfNotNull(node.Assembly);
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x00029AFE File Offset: 0x00027CFE
		public override void ExplicitVisit(FileEncryptionSource node)
		{
			if (node.IsExecutable)
			{
				this.GenerateIdentifier("EXECUTABLE");
				this.GenerateSpace();
			}
			this.GenerateNameEqualsValue(TSqlTokenType.File, node.File);
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x00029B28 File Offset: 0x00027D28
		public override void ExplicitVisit(ProviderEncryptionSource node)
		{
			this.GenerateIdentifier("PROVIDER");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			if (node.KeyOptions.Count > 0)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.With);
				this.GenerateSpace();
				this.GenerateCommaSeparatedList<KeyOption>(node.KeyOptions);
			}
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x00029B78 File Offset: 0x00027D78
		public override void ExplicitVisit(EndConversationStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.End);
			this.GenerateSpaceAndIdentifier("CONVERSATION");
			this.GenerateSpaceAndFragmentIfNotNull(node.Conversation);
			if (node.WithCleanup)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.With);
				this.GenerateSpaceAndIdentifier("CLEANUP");
				return;
			}
			if (node.ErrorCode != null && node.ErrorDescription != null)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.With);
				this.GenerateSpace();
				this.GenerateNameEqualsValue("ERROR", node.ErrorCode);
				this.GenerateSpace();
				this.GenerateNameEqualsValue("DESCRIPTION", node.ErrorDescription);
			}
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x00029C18 File Offset: 0x00027E18
		public override void ExplicitVisit(EndpointAffinity node)
		{
			switch (node.Kind)
			{
			case AffinityKind.None:
				this.GenerateNameEqualsValue("AFFINITY", "NONE");
				return;
			case AffinityKind.Integer:
				this.GenerateNameEqualsValue("AFFINITY", node.Value);
				return;
			case AffinityKind.Admin:
				this.GenerateNameEqualsValue("AFFINITY", "ADMIN");
				return;
			default:
				return;
			}
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x00029C74 File Offset: 0x00027E74
		public override void ExplicitVisit(EventGroupContainer node)
		{
			if (!AuditEventGroupHelper.Instance.TryGenerateSourceForOption(this._writer, node.EventGroup))
			{
				TriggerEventGroupHelper.Instance.GenerateSourceForOption(this._writer, node.EventGroup);
			}
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x00029CA4 File Offset: 0x00027EA4
		public override void ExplicitVisit(EventNotificationObjectScope node)
		{
			switch (node.Target)
			{
			case EventNotificationTarget.Server:
				this.GenerateIdentifier("SERVER");
				return;
			case EventNotificationTarget.Database:
				this.GenerateKeyword(TSqlTokenType.Database);
				return;
			case EventNotificationTarget.Queue:
				this.GenerateIdentifier("QUEUE");
				this.GenerateSpaceAndFragmentIfNotNull(node.QueueName);
				return;
			default:
				return;
			}
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x00029CF9 File Offset: 0x00027EF9
		public override void ExplicitVisit(CreateEventSessionStatement node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.Create);
			this.GenerateEventSessionParameters(node);
			this.GenerateEventDeclarations(node);
			this.GenerateTargetDeclarations(node);
			this.GenerateEventSessionOptions(node);
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x00029D1F File Offset: 0x00027F1F
		public void GenerateEventSessionParameters(EventSessionStatement node)
		{
			this.GenerateIdentifier("EVENT");
			this.GenerateSpaceAndIdentifier("SESSION");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.GenerateSpaceAndKeyword(TSqlTokenType.On);
			this.GenerateSpaceAndIdentifier("SERVER");
			this.GenerateSpace();
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x00029D5C File Offset: 0x00027F5C
		public void GenerateEventDeclarations(EventSessionStatement node)
		{
			if (node.EventDeclarations != null && node.EventDeclarations.Count > 0)
			{
				this.GenerateCommaSeparatedList<EventDeclaration>(node.EventDeclarations);
			}
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x00029D80 File Offset: 0x00027F80
		public void GenerateTargetDeclarations(EventSessionStatement node)
		{
			if (node.TargetDeclarations != null && node.TargetDeclarations.Count > 0)
			{
				if (node is CreateEventSessionStatement)
				{
					this.GenerateSpace();
				}
				this.GenerateCommaSeparatedList<TargetDeclaration>(node.TargetDeclarations);
			}
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x00029DB2 File Offset: 0x00027FB2
		public void GenerateEventSessionOptions(EventSessionStatement node)
		{
			if (node.SessionOptions != null && node.SessionOptions.Count > 0)
			{
				this.NewLine();
				this.GenerateKeywordAndSpace(TSqlTokenType.With);
				this.GenerateAlignedParenthesizedOptionsWithMultipleIndent<SessionOption>(node.SessionOptions, 2);
			}
		}

		// Token: 0x06000E2B RID: 3627 RVA: 0x00029DE8 File Offset: 0x00027FE8
		public override void ExplicitVisit(EventDeclaration node)
		{
			this.NewLine();
			this.GenerateKeywordAndSpace(TSqlTokenType.Add);
			this.GenerateIdentifier("EVENT");
			this.GenerateSpaceAndFragmentIfNotNull(node.ObjectName);
			if (node.EventDeclarationSetParameters.Count > 0 || node.EventDeclarationActionParameters.Count > 0 || node.EventDeclarationPredicateParameter != null)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.LeftParenthesis);
			}
			if (node.EventDeclarationSetParameters != null && node.EventDeclarationSetParameters.Count > 0)
			{
				this.NewLineAndIndent();
				this.GenerateKeywordAndSpace(TSqlTokenType.Set);
				this.GenerateFragmentList<EventDeclarationSetParameter>(node.EventDeclarationSetParameters, SqlScriptGeneratorVisitor.ListGenerationOption.MultipleLineSelectElementOption);
			}
			if (node.EventDeclarationActionParameters != null && node.EventDeclarationActionParameters.Count > 0)
			{
				this.NewLineAndIndent();
				this.GenerateIdentifier("ACTION");
				this.GenerateSpaceAndKeyword(TSqlTokenType.LeftParenthesis);
				this.GenerateFragmentList<EventSessionObjectName>(node.EventDeclarationActionParameters, SqlScriptGeneratorVisitor.ListGenerationOption.MultipleLineSelectElementOption);
				this.GenerateKeyword(TSqlTokenType.RightParenthesis);
			}
			if (node.EventDeclarationPredicateParameter != null)
			{
				this.NewLineAndIndent();
				this.GenerateKeywordAndSpace(TSqlTokenType.Where);
				this.GenerateFragmentIfNotNull(node.EventDeclarationPredicateParameter);
			}
			if (node.EventDeclarationSetParameters.Count > 0 || node.EventDeclarationActionParameters.Count > 0 || node.EventDeclarationPredicateParameter != null)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.RightParenthesis);
			}
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x00029F2E File Offset: 0x0002812E
		public override void ExplicitVisit(EventDeclarationSetParameter node)
		{
			this.GenerateFragmentIfNotNull(node.EventField);
			this.GenerateSpace();
			this.GenerateKeywordAndSpace(TSqlTokenType.EqualsSign);
			this.GenerateFragmentIfNotNull(node.EventValue);
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x00029F59 File Offset: 0x00028159
		public override void ExplicitVisit(EventSessionObjectName node)
		{
			this.GenerateFragmentIfNotNull(node.MultiPartIdentifier);
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x00029F68 File Offset: 0x00028168
		public override void ExplicitVisit(EventDeclarationCompareFunctionParameter node)
		{
			this.GenerateFragmentIfNotNull(node.Name);
			this.GenerateSpaceAndKeyword(TSqlTokenType.LeftParenthesis);
			this.GenerateFragmentIfNotNull(node.SourceDeclaration);
			this.GenerateKeyword(TSqlTokenType.Comma);
			this.GenerateSpaceAndFragmentIfNotNull(node.EventValue);
			this.GenerateKeyword(TSqlTokenType.RightParenthesis);
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x00029FBC File Offset: 0x000281BC
		public override void ExplicitVisit(TargetDeclaration node)
		{
			this.NewLine();
			this.GenerateKeywordAndSpace(TSqlTokenType.Add);
			this.GenerateIdentifier("TARGET");
			this.GenerateSpaceAndFragmentIfNotNull(node.ObjectName);
			if (node.TargetDeclarationParameters != null && node.TargetDeclarationParameters.Count > 0)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.LeftParenthesis);
				this.NewLineAndIndent();
				this.GenerateKeywordAndSpace(TSqlTokenType.Set);
				this.GenerateFragmentList<EventDeclarationSetParameter>(node.TargetDeclarationParameters, SqlScriptGeneratorVisitor.ListGenerationOption.MultipleLineSelectElementOption);
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.RightParenthesis);
			}
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x0002A048 File Offset: 0x00028248
		public override void ExplicitVisit(LiteralSessionOption node)
		{
			switch (node.OptionKind)
			{
			case SessionOptionKind.MaxMemory:
				this.GenerateIdentifier("MAX_MEMORY");
				break;
			case SessionOptionKind.MaxEventSize:
				this.GenerateIdentifier("MAX_EVENT_SIZE");
				break;
			}
			this.GenerateIntegerValueSessionOption(node);
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x0002A090 File Offset: 0x00028290
		public override void ExplicitVisit(MaxDispatchLatencySessionOption node)
		{
			this.GenerateIdentifier("MAX_DISPATCH_LATENCY");
			this.GenerateSpaceAndKeyword(TSqlTokenType.EqualsSign);
			this.GenerateSpace();
			if (node.IsInfinite)
			{
				this.GenerateIdentifier("INFINITE");
				return;
			}
			this.GenerateFragmentIfNotNull(node.Value);
			this.GenerateSpace();
			this.GenerateIdentifier("SECONDS");
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x0002A0EA File Offset: 0x000282EA
		public void GenerateIntegerValueSessionOption(LiteralSessionOption node)
		{
			this.GenerateSpaceAndKeyword(TSqlTokenType.EqualsSign);
			this.GenerateSpace();
			this.GenerateFragmentIfNotNull(node.Value);
			this.GenerateSpace();
			SessionOptionUnitHelper.Instance.GenerateSourceForOption(this._writer, node.Unit);
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x0002A128 File Offset: 0x00028328
		public override void ExplicitVisit(OnOffSessionOption node)
		{
			switch (node.OptionKind)
			{
			case SessionOptionKind.TrackCausality:
				this.GenerateOptionState("TRACK_CAUSALITY", node.OptionState, true);
				return;
			case SessionOptionKind.StartUpState:
				this.GenerateOptionState("STARTUP_STATE", node.OptionState, true);
				return;
			default:
				return;
			}
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x0002A172 File Offset: 0x00028372
		public override void ExplicitVisit(EventRetentionSessionOption node)
		{
			this.GenerateIdentifier("EVENT_RETENTION_MODE");
			this.GenerateSpaceAndKeyword(TSqlTokenType.EqualsSign);
			this.GenerateSpace();
			EventSessionEventRetentionModeTypeHelper.Instance.GenerateSourceForOption(this._writer, node.Value);
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x0002A1A6 File Offset: 0x000283A6
		public override void ExplicitVisit(MemoryPartitionSessionOption node)
		{
			this.GenerateIdentifier("MEMORY_PARTITION_MODE");
			this.GenerateSpaceAndKeyword(TSqlTokenType.EqualsSign);
			this.GenerateSpace();
			EventSessionMemoryPartitionModeTypeHelper.Instance.GenerateSourceForOption(this._writer, node.Value);
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x0002A1DC File Offset: 0x000283DC
		public override void ExplicitVisit(AlterEventSessionStatement node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.Alter);
			this.GenerateEventSessionParameters(node);
			switch (node.StatementType)
			{
			case AlterEventSessionStatementType.AddEventDeclarationOptionalSessionOptions:
				this.GenerateEventDeclarations(node);
				this.GenerateEventSessionOptions(node);
				return;
			case AlterEventSessionStatementType.DropEventSpecificationOptionalSessionOptions:
				this.GenerateCommaSeparatedDropDeclarations<EventSessionObjectName>(node.DropEventDeclarations, "EVENT");
				this.GenerateEventSessionOptions(node);
				return;
			case AlterEventSessionStatementType.AddTargetDeclarationOptionalSessionOptions:
				this.GenerateTargetDeclarations(node);
				this.GenerateEventSessionOptions(node);
				return;
			case AlterEventSessionStatementType.DropTargetSpecificationOptionalSessionOptions:
				this.GenerateCommaSeparatedDropDeclarations<EventSessionObjectName>(node.DropTargetDeclarations, "TARGET");
				this.GenerateEventSessionOptions(node);
				return;
			case AlterEventSessionStatementType.RequiredSessionOptions:
				this.GenerateEventSessionOptions(node);
				return;
			case AlterEventSessionStatementType.AlterStateIsStart:
				this.NewLine();
				this.GenerateNameEqualsValue("STATE", "START");
				return;
			case AlterEventSessionStatementType.AlterStateIsStop:
				this.NewLine();
				this.GenerateNameEqualsValue("STATE", "STOP");
				return;
			default:
				return;
			}
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x0002A2A8 File Offset: 0x000284A8
		public override void ExplicitVisit(DropEventSessionStatement node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.Drop);
			this.GenerateIdentifier("EVENT");
			this.GenerateSpaceAndIdentifier("SESSION");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.GenerateSpaceAndKeyword(TSqlTokenType.On);
			this.GenerateSpaceAndIdentifier("SERVER");
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x0002A2E8 File Offset: 0x000284E8
		public void GenerateCommaSeparatedDropDeclarations<T>(IList<T> list, string declaration) where T : TSqlFragment
		{
			if (list != null)
			{
				bool flag = true;
				foreach (T t in list)
				{
					if (flag)
					{
						this.NewLine();
						this.GenerateKeywordAndSpace(TSqlTokenType.Drop);
						this.GenerateIdentifier(declaration);
						flag = false;
					}
					else
					{
						this.GenerateKeyword(TSqlTokenType.Comma);
						this.NewLine();
						this.GenerateKeywordAndSpace(TSqlTokenType.Drop);
						this.GenerateIdentifier(declaration);
					}
					this.GenerateSpaceAndFragmentIfNotNull(t);
				}
			}
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x0002A378 File Offset: 0x00028578
		public override void ExplicitVisit(EventTypeContainer node)
		{
			if (!AuditEventTypeHelper.Instance.TryGenerateSourceForOption(this._writer, node.EventType))
			{
				TriggerEventTypeHelper.Instance.GenerateSourceForOption(this._writer, node.EventType);
			}
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x0002A3A8 File Offset: 0x000285A8
		protected void GenerateParameters(ExecutableEntity node)
		{
			this.GenerateCommaSeparatedList<ExecuteParameter>(node.Parameters);
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x0002A3B6 File Offset: 0x000285B6
		public override void ExplicitVisit(ExecutableProcedureReference node)
		{
			if (node.AdHocDataSource != null)
			{
				this.GenerateFragmentIfNotNull(node.AdHocDataSource);
				this.GenerateSymbol(TSqlTokenType.Dot);
			}
			this.GenerateFragmentIfNotNull(node.ProcedureReference);
			this.GenerateSpace();
			this.GenerateParameters(node);
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x0002A3F0 File Offset: 0x000285F0
		public override void ExplicitVisit(ExecutableStringList node)
		{
			this.GenerateSymbol(TSqlTokenType.LeftParenthesis);
			for (int i = 0; i < node.Strings.Count; i++)
			{
				if (i > 0)
				{
					this.GenerateSpaceAndSymbol(TSqlTokenType.Plus);
					this.GenerateSpace();
				}
				this.GenerateFragmentIfNotNull(node.Strings[i]);
			}
			if (node.Parameters.Count > 0)
			{
				this.GenerateSymbolAndSpace(TSqlTokenType.Comma);
				this.GenerateParameters(node);
			}
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x0002A470 File Offset: 0x00028670
		public override void ExplicitVisit(ExecuteAsClause node)
		{
			this.GenerateKeyword(TSqlTokenType.Execute);
			this.GenerateSpaceAndKeyword(TSqlTokenType.As);
			switch (node.ExecuteAsOption)
			{
			case ExecuteAsOption.Caller:
				this.GenerateSpaceAndIdentifier("CALLER");
				return;
			case ExecuteAsOption.Self:
				this.GenerateSpaceAndIdentifier("SELF");
				return;
			case ExecuteAsOption.Owner:
				this.GenerateSpaceAndIdentifier("OWNER");
				return;
			case ExecuteAsOption.String:
			case ExecuteAsOption.Login:
			case ExecuteAsOption.User:
				this.GenerateSpaceAndFragmentIfNotNull(node.Literal);
				return;
			default:
				return;
			}
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x0002A4E4 File Offset: 0x000286E4
		public override void ExplicitVisit(ExecuteAsStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Execute);
			this.GenerateSpaceAndFragmentIfNotNull(node.ExecuteContext);
			if (node.WithNoRevert)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.With);
				this.GenerateSpaceAndIdentifier("NO");
				this.GenerateSpaceAndKeyword(TSqlTokenType.Revert);
				return;
			}
			if (node.Cookie != null)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.With);
				this.GenerateSpaceAndIdentifier("COOKIE");
				this.GenerateSpaceAndKeyword(TSqlTokenType.Into);
				this.GenerateSpaceAndFragmentIfNotNull(node.Cookie);
			}
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x0002A570 File Offset: 0x00028770
		public override void ExplicitVisit(ExecuteContext node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.As);
			TokenGenerator valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<ExecuteAsOption, TokenGenerator>(SqlScriptGeneratorVisitor._executeAsOptionGenerators, node.Kind);
			if (node.Principal != null)
			{
				this.GenerateNameEqualsValue(valueForEnumKey, node.Principal);
				return;
			}
			this.GenerateToken(valueForEnumKey);
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x0002A5B4 File Offset: 0x000287B4
		public override void ExplicitVisit(ExecuteParameter node)
		{
			if (node.Variable != null)
			{
				this.GenerateFragmentIfNotNull(node.Variable);
				this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
				this.GenerateSpace();
			}
			if (node.ParameterValue != null)
			{
				this.GenerateFragmentIfNotNull(node.ParameterValue);
			}
			if (node.IsOutput)
			{
				this.GenerateSpaceAndIdentifier("OUTPUT");
			}
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x0002A60D File Offset: 0x0002880D
		public override void ExplicitVisit(ExecuteStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Execute);
			this.GenerateExecuteSpecificationBody(node.ExecuteSpecification);
			this.GenerateCommaSeparatedWithClause<ExecuteOption>(node.Options, true, false);
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x0002A631 File Offset: 0x00028831
		public override void ExplicitVisit(ExecuteSpecification node)
		{
			this.GenerateKeyword(TSqlTokenType.Execute);
			this.GenerateExecuteSpecificationBody(node);
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x0002A644 File Offset: 0x00028844
		private void GenerateExecuteSpecificationBody(ExecuteSpecification node)
		{
			if (node != null)
			{
				if (node.Variable != null)
				{
					this.GenerateSpaceAndFragmentIfNotNull(node.Variable);
					this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
				}
				this.GenerateSpaceAndFragmentIfNotNull(node.ExecutableEntity);
				this.GenerateSpaceAndFragmentIfNotNull(node.ExecuteContext);
				if (node.LinkedServer != null)
				{
					this.GenerateSpaceAndIdentifier("AT");
					this.GenerateSpaceAndFragmentIfNotNull(node.LinkedServer);
				}
			}
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x0002A6AA File Offset: 0x000288AA
		public override void ExplicitVisit(ExecuteOption node)
		{
			this.GenerateIdentifier("RECOMPILE");
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x0002A6B7 File Offset: 0x000288B7
		public override void ExplicitVisit(ExistsPredicate node)
		{
			this.GenerateKeyword(TSqlTokenType.Exists);
			this.GenerateSpaceAndFragmentIfNotNull(node.Subquery);
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x0002A6D0 File Offset: 0x000288D0
		public override void ExplicitVisit(ExpressionWithSortOrder node)
		{
			this.GenerateFragmentIfNotNull(node.Expression);
			TokenGenerator valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<SortOrder, TokenGenerator>(SqlScriptGeneratorVisitor._sortOrderGenerators, node.SortOrder);
			if (valueForEnumKey != null && node.SortOrder != SortOrder.NotSpecified)
			{
				this.GenerateSpace();
				this.GenerateToken(valueForEnumKey);
			}
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x0002A712 File Offset: 0x00028912
		public override void ExplicitVisit(ExtractFromExpression node)
		{
			this.GenerateSpaceAndFragmentIfNotNull(node.ExtractedElement);
			this.GenerateSpaceAndKeyword(TSqlTokenType.From);
			this.GenerateSpaceAndFragmentIfNotNull(node.Expression);
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x0002A734 File Offset: 0x00028934
		public override void ExplicitVisit(FetchCursorStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Fetch);
			if (node.FetchType != null)
			{
				this.GenerateSpaceAndFragmentIfNotNull(node.FetchType);
				this.GenerateSpaceAndKeyword(TSqlTokenType.From);
			}
			this.GenerateSpaceAndFragmentIfNotNull(node.Cursor);
			if (node.IntoVariables.Count > 0)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.Into);
				this.GenerateSpace();
				this.GenerateCommaSeparatedList<VariableReference>(node.IntoVariables);
			}
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x0002A79C File Offset: 0x0002899C
		public override void ExplicitVisit(FetchType node)
		{
			if (node.Orientation != FetchOrientation.None)
			{
				string valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<FetchOrientation, string>(SqlScriptGeneratorVisitor._fetchOrientationNames, node.Orientation);
				if (valueForEnumKey != null)
				{
					this.GenerateIdentifier(valueForEnumKey);
					if (node.Orientation == FetchOrientation.Absolute || node.Orientation == FetchOrientation.Relative)
					{
						this.GenerateSpaceAndFragmentIfNotNull(node.RowOffset);
					}
				}
			}
		}

		// Token: 0x06000E4A RID: 3658 RVA: 0x0002A7EA File Offset: 0x000289EA
		public override void ExplicitVisit(FileDeclaration node)
		{
			if (node.IsPrimary)
			{
				this.GenerateKeyword(TSqlTokenType.Primary);
			}
			this.GenerateParenthesisedCommaSeparatedList<FileDeclarationOption>(node.Options);
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x0002A808 File Offset: 0x00028A08
		public override void ExplicitVisit(NameFileDeclarationOption node)
		{
			string name = node.IsNewName ? "NEWNAME" : "NAME";
			this.GenerateNameEqualsValue(name, node.LogicalFileName);
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x0002A837 File Offset: 0x00028A37
		public override void ExplicitVisit(FileNameFileDeclarationOption node)
		{
			this.GenerateNameEqualsValue("FILENAME", node.OSFileName);
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x0002A84A File Offset: 0x00028A4A
		public override void ExplicitVisit(SizeFileDeclarationOption node)
		{
			this.GenerateNameEqualsValue("SIZE", node.Size);
			this.GenerateSpaceAndMemoryUnit(node.Units);
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x0002A869 File Offset: 0x00028A69
		public override void ExplicitVisit(MaxSizeFileDeclarationOption node)
		{
			if (node.MaxSize != null)
			{
				this.GenerateNameEqualsValue("MAXSIZE", node.MaxSize);
				this.GenerateSpaceAndMemoryUnit(node.Units);
			}
			if (node.Unlimited)
			{
				this.GenerateNameEqualsValue("MAXSIZE", "UNLIMITED");
			}
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x0002A8A8 File Offset: 0x00028AA8
		public override void ExplicitVisit(FileGrowthFileDeclarationOption node)
		{
			this.GenerateNameEqualsValue("FILEGROWTH", node.GrowthIncrement);
			this.GenerateSpaceAndMemoryUnit(node.Units);
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x0002A8C8 File Offset: 0x00028AC8
		public override void ExplicitVisit(FileDeclarationOption node)
		{
			FileDeclarationOptionKind optionKind = node.OptionKind;
			if (optionKind != FileDeclarationOptionKind.Offline)
			{
				return;
			}
			this.GenerateIdentifier("OFFLINE");
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x0002A8EC File Offset: 0x00028AEC
		public override void ExplicitVisit(FileGroupDefinition node)
		{
			this.NewLineAndIndent();
			if (node.Name != null)
			{
				this.GenerateIdentifier("FILEGROUP");
				this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			}
			if (node.ContainsFileStream)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.Contains);
				this.GenerateSpaceAndIdentifier("FILESTREAM");
			}
			if (node.ContainsMemoryOptimizedData)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.Contains);
				this.GenerateSpaceAndIdentifier("MEMORY_OPTIMIZED_DATA");
			}
			if (node.IsDefault)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.Default);
			}
			this.GenerateCommaSeparatedList<FileDeclaration>(node.FileDeclarations);
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x0002A970 File Offset: 0x00028B70
		public override void ExplicitVisit(FileGroupOrPartitionScheme node)
		{
			this.GenerateFragmentIfNotNull(node.Name);
			if (node.PartitionSchemeColumns.Count > 0)
			{
				this.GenerateSpace();
				this.GenerateParenthesisedCommaSeparatedList<Identifier>(node.PartitionSchemeColumns);
			}
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x0002A9A0 File Offset: 0x00028BA0
		public override void ExplicitVisit(FileStreamDatabaseOption node)
		{
			this.GenerateIdentifier("FILESTREAM");
			this.GenerateSymbol(TSqlTokenType.LeftParenthesis);
			if (node.NonTransactedAccess != null)
			{
				string valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<NonTransactedFileStreamAccess, string>(SqlScriptGeneratorVisitor._nonTransactedFileStreamAccessNames, node.NonTransactedAccess.Value);
				this.GenerateNameEqualsValue("NON_TRANSACTED_ACCESS", valueForEnumKey);
			}
			if (node.NonTransactedAccess != null && node.DirectoryName != null)
			{
				this.GenerateSymbol(TSqlTokenType.Comma);
				this.GenerateSpace();
			}
			if (node.DirectoryName != null)
			{
				this.GenerateNameEqualsValue("DIRECTORY_NAME", node.DirectoryName);
			}
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x0002AA45 File Offset: 0x00028C45
		public override void ExplicitVisit(FileStreamOnTableOption node)
		{
			this.GenerateIdentifier("FILESTREAM_ON");
			this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
			this.GenerateSpaceAndFragmentIfNotNull(node.Value);
		}

		// Token: 0x06000E55 RID: 3669 RVA: 0x0002AA69 File Offset: 0x00028C69
		public override void ExplicitVisit(FileTableCollateFileNameTableOption node)
		{
			this.GenerateNameEqualsValue("FILETABLE_COLLATE_FILENAME", node.Value);
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x0002AA7C File Offset: 0x00028C7C
		public override void ExplicitVisit(FileTableConstraintNameTableOption node)
		{
			switch (node.OptionKind)
			{
			case TableOptionKind.FileTablePrimaryKeyConstraintName:
				this.GenerateNameEqualsValue("FILETABLE_PRIMARY_KEY_CONSTRAINT_NAME", node.Value);
				return;
			case TableOptionKind.FileTableStreamIdUniqueConstraintName:
				this.GenerateNameEqualsValue("FILETABLE_STREAMID_UNIQUE_CONSTRAINT_NAME", node.Value);
				return;
			case TableOptionKind.FileTableFullPathUniqueConstraintName:
				this.GenerateNameEqualsValue("FILETABLE_FULLPATH_UNIQUE_CONSTRAINT_NAME", node.Value);
				return;
			default:
				return;
			}
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x0002AADA File Offset: 0x00028CDA
		public override void ExplicitVisit(FileTableDirectoryTableOption node)
		{
			this.GenerateNameEqualsValue("FILETABLE_DIRECTORY", node.Value);
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x0002AAF0 File Offset: 0x00028CF0
		public override void ExplicitVisit(ForeignKeyConstraintDefinition node)
		{
			this.GenerateConstraintHead(node);
			this.GenerateKeyword(TSqlTokenType.Foreign);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Key);
			if (node.Columns.Count > 0)
			{
				this.GenerateSpace();
				this.GenerateParenthesisedCommaSeparatedList<Identifier>(node.Columns);
			}
			this.GenerateSpaceAndKeyword(TSqlTokenType.References);
			this.GenerateSpaceAndFragmentIfNotNull(node.ReferenceTableName);
			if (node.ReferencedTableColumns.Count > 0)
			{
				this.GenerateSpace();
				this.GenerateParenthesisedCommaSeparatedList<Identifier>(node.ReferencedTableColumns);
			}
			if (node.DeleteAction != DeleteUpdateAction.NotSpecified)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.On);
				this.GenerateSpaceAndKeyword(TSqlTokenType.Delete);
				this.GenerateSpace();
				this.GenerateDeleteUpdateAction(node.DeleteAction);
			}
			if (node.UpdateAction != DeleteUpdateAction.NotSpecified)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.On);
				this.GenerateSpaceAndKeyword(TSqlTokenType.Update);
				this.GenerateSpace();
				this.GenerateDeleteUpdateAction(node.UpdateAction);
			}
			if (node.NotForReplication)
			{
				this.GenerateSpace();
				this.GenerateNotForReplication();
			}
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x0002ABD3 File Offset: 0x00028DD3
		public override void ExplicitVisit(FromClause node)
		{
			this.GenerateFromClause(node, null);
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x0002ABE0 File Offset: 0x00028DE0
		protected void GenerateFromClause(FromClause fromClause, AlignmentPoint clauseBody)
		{
			if (fromClause != null)
			{
				IList<TableReference> tableReferences = fromClause.TableReferences;
				if (tableReferences.Count > 0)
				{
					this.GenerateSeparatorForFromClause();
					AlignmentPoint ap = new AlignmentPoint();
					this.MarkAndPushAlignmentPoint(ap);
					this.GenerateKeyword(TSqlTokenType.From);
					this.MarkClauseBodyAlignmentWhenNecessary(this._options.NewLineBeforeFromClause, clauseBody);
					this.GenerateSpace();
					AlignmentPoint ap2 = new AlignmentPoint();
					this.MarkAndPushAlignmentPoint(ap2);
					this.GenerateCommaSeparatedList<TableReference>(tableReferences);
					this.PopAlignmentPoint();
					this.PopAlignmentPoint();
				}
			}
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x0002AC54 File Offset: 0x00028E54
		public override void ExplicitVisit(FullTextIndexColumn node)
		{
			this.GenerateFragmentIfNotNull(node.Name);
			if (node.TypeColumn != null)
			{
				this.GenerateSpaceAndIdentifier("TYPE");
				this.GenerateSpaceAndKeyword(TSqlTokenType.Column);
				this.GenerateSpaceAndFragmentIfNotNull(node.TypeColumn);
			}
			if (node.LanguageTerm != null)
			{
				this.GenerateSpaceAndIdentifier("LANGUAGE");
				this.GenerateSpaceAndFragmentIfNotNull(node.LanguageTerm);
			}
			if (node.StatisticalSemantics)
			{
				this.GenerateSpaceAndIdentifier("STATISTICAL_SEMANTICS");
			}
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x0002ACC8 File Offset: 0x00028EC8
		public override void ExplicitVisit(FullTextPredicate node)
		{
			if (node.FullTextFunctionType != FullTextFunctionType.None)
			{
				TokenGenerator valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<FullTextFunctionType, TokenGenerator>(SqlScriptGeneratorVisitor._fulltextFunctionTypeGenerators, node.FullTextFunctionType);
				if (valueForEnumKey != null)
				{
					this.GenerateToken(valueForEnumKey);
				}
			}
			this.GenerateSpaceAndSymbol(TSqlTokenType.LeftParenthesis);
			if (node.PropertyName != null)
			{
				this.GenerateIdentifier("PROPERTY");
				this.GenerateSymbol(TSqlTokenType.LeftParenthesis);
				this.GenerateCommaSeparatedList<ColumnReferenceExpression>(node.Columns);
				this.GenerateSymbol(TSqlTokenType.Comma);
				this.GenerateSpaceAndFragmentIfNotNull(node.PropertyName);
				this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			}
			else
			{
				this.GenerateParenthesisedCommaSeparatedList<ColumnReferenceExpression>(node.Columns);
			}
			this.GenerateSymbolAndSpace(TSqlTokenType.Comma);
			this.GenerateFragmentIfNotNull(node.Value);
			if (node.LanguageTerm != null)
			{
				this.GenerateSymbolAndSpace(TSqlTokenType.Comma);
				this.GenerateIdentifier("LANGUAGE");
				this.GenerateSpaceAndFragmentIfNotNull(node.LanguageTerm);
			}
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x0002ADAC File Offset: 0x00028FAC
		public override void ExplicitVisit(FullTextStopListAction node)
		{
			if (node.IsAdd)
			{
				this.GenerateKeyword(TSqlTokenType.Add);
			}
			else
			{
				this.GenerateKeyword(TSqlTokenType.Drop);
			}
			if (!node.IsAll)
			{
				this.GenerateSpaceAndFragmentIfNotNull(node.StopWord);
			}
			else
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.All);
			}
			if (node.LanguageTerm != null)
			{
				this.GenerateSpaceAndIdentifier("LANGUAGE");
				this.GenerateSpaceAndFragmentIfNotNull(node.LanguageTerm);
			}
		}

		// Token: 0x06000E5E RID: 3678 RVA: 0x0002AE10 File Offset: 0x00029010
		public override void ExplicitVisit(FullTextTableReference node)
		{
			AlignmentPoint ap = new AlignmentPoint();
			this.MarkAndPushAlignmentPoint(ap);
			switch (node.FullTextFunctionType)
			{
			case FullTextFunctionType.Contains:
				this.GenerateKeyword(TSqlTokenType.ContainsTable);
				break;
			case FullTextFunctionType.FreeText:
				this.GenerateKeyword(TSqlTokenType.FreeTextTable);
				break;
			}
			this.GenerateSpaceAndSymbol(TSqlTokenType.LeftParenthesis);
			this.GenerateFragmentIfNotNull(node.TableName);
			this.GenerateSymbolAndSpace(TSqlTokenType.Comma);
			if (node.PropertyName != null)
			{
				this.GenerateIdentifier("PROPERTY");
				this.GenerateSymbol(TSqlTokenType.LeftParenthesis);
				this.GenerateCommaSeparatedList<ColumnReferenceExpression>(node.Columns);
				this.GenerateSymbol(TSqlTokenType.Comma);
				this.GenerateSpaceAndFragmentIfNotNull(node.PropertyName);
				this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			}
			else
			{
				int count = node.Columns.Count;
				if (count == 1)
				{
					this.GenerateFragmentIfNotNull(node.Columns[0]);
				}
				else
				{
					this.GenerateParenthesisedCommaSeparatedList<ColumnReferenceExpression>(node.Columns);
				}
			}
			this.GenerateSymbol(TSqlTokenType.Comma);
			this.GenerateSpaceAndFragmentIfNotNull(node.SearchCondition);
			if (node.Language != null)
			{
				this.GenerateSymbol(TSqlTokenType.Comma);
				this.GenerateSpaceAndIdentifier("LANGUAGE");
				this.GenerateSpaceAndFragmentIfNotNull(node.Language);
			}
			if (node.TopN != null)
			{
				this.GenerateSymbol(TSqlTokenType.Comma);
				this.GenerateSpaceAndFragmentIfNotNull(node.TopN);
			}
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			this.GenerateSpaceAndAlias(node.Alias);
			this.PopAlignmentPoint();
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x0002AF72 File Offset: 0x00029172
		public override void ExplicitVisit(LeftFunctionCall node)
		{
			this.GenerateKeyword(TSqlTokenType.Left);
			this.GenerateParenthesisedCommaSeparatedList<ScalarExpression>(node.Parameters, true);
			this.GenerateSpaceAndCollation(node.Collation);
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x0002AF95 File Offset: 0x00029195
		public override void ExplicitVisit(RightFunctionCall node)
		{
			this.GenerateKeyword(TSqlTokenType.Right);
			this.GenerateParenthesisedCommaSeparatedList<ScalarExpression>(node.Parameters, true);
			this.GenerateSpaceAndCollation(node.Collation);
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x0002AFBC File Offset: 0x000291BC
		public override void ExplicitVisit(FunctionCall node)
		{
			this.GenerateFragmentIfNotNull(node.CallTarget);
			this.GenerateFragmentIfNotNull(node.FunctionName);
			this.GenerateSymbol(TSqlTokenType.LeftParenthesis);
			this.GenerateUniqueRowFilter(node.UniqueRowFilter, false);
			if (node.UniqueRowFilter != UniqueRowFilter.NotSpecified && node.Parameters.Count > 0)
			{
				this.GenerateSpace();
			}
			this.GenerateCommaSeparatedList<ScalarExpression>(node.Parameters);
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			this.GenerateSpaceAndFragmentIfNotNull(node.WithinGroupClause);
			this.GenerateSpaceAndFragmentIfNotNull(node.OverClause);
			this.GenerateSpaceAndCollation(node.Collation);
		}

		// Token: 0x06000E62 RID: 3682 RVA: 0x0002B050 File Offset: 0x00029250
		protected void GenerateFunctionStatementBody(FunctionStatementBody node)
		{
			this.GenerateKeyword(TSqlTokenType.Function);
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.NewLine();
			this.GenerateParenthesisedCommaSeparatedList<ProcedureParameter>(node.Parameters);
			if (node.Parameters == null || node.Parameters.Count == 0)
			{
				this.GenerateSymbol(TSqlTokenType.LeftParenthesis);
				this.GenerateSpaceAndSymbol(TSqlTokenType.RightParenthesis);
			}
			this.NewLine();
			this.GenerateIdentifier("RETURNS");
			this.GenerateSpace();
			SelectFunctionReturnType selectFunctionReturnType = node.ReturnType as SelectFunctionReturnType;
			if (selectFunctionReturnType != null)
			{
				this.GenerateKeywordAndSpace(TSqlTokenType.Table);
			}
			else
			{
				this.GenerateFragmentIfNotNull(node.ReturnType);
			}
			this.GenerateCommaSeparatedWithClause<FunctionOption>(node.Options, false, false);
			if (node.OrderHint != null)
			{
				this.NewLine();
				this.GenerateFragmentIfNotNull(node.OrderHint);
			}
			this.NewLine();
			this.GenerateKeyword(TSqlTokenType.As);
			this.NewLine();
			if (selectFunctionReturnType != null)
			{
				this.GenerateKeywordAndSpace(TSqlTokenType.Return);
				this.GenerateFragmentIfNotNull(selectFunctionReturnType);
				return;
			}
			if (node.MethodSpecifier != null)
			{
				this.GenerateSpaceAndFragmentIfNotNull(node.MethodSpecifier);
				return;
			}
			if (node.StatementList != null)
			{
				this.GenerateFragmentIfNotNull(node.StatementList);
			}
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x0002B168 File Offset: 0x00029368
		public override void ExplicitVisit(FunctionOption node)
		{
			List<TokenGenerator> valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<FunctionOptionKind, List<TokenGenerator>>(SqlScriptGeneratorVisitor._functionOptionsGenerators, node.OptionKind);
			if (valueForEnumKey != null)
			{
				this.GenerateTokenList(valueForEnumKey);
			}
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x0002B190 File Offset: 0x00029390
		public override void ExplicitVisit(ExecuteAsFunctionOption node)
		{
			this.GenerateFragmentIfNotNull(node.ExecuteAs);
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x0002B1A0 File Offset: 0x000293A0
		public override void ExplicitVisit(GeneralSetCommand node)
		{
			TokenGenerator valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<GeneralSetCommandType, TokenGenerator>(SqlScriptGeneratorVisitor._generalSetCommandTypeGenerators, node.CommandType);
			if (valueForEnumKey != null)
			{
				this.GenerateToken(valueForEnumKey);
			}
			this.GenerateSpaceAndFragmentIfNotNull(node.Parameter);
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x0002B1D4 File Offset: 0x000293D4
		public override void ExplicitVisit(GetConversationGroupStatement node)
		{
			this.GenerateIdentifier("GET");
			this.GenerateSpaceAndIdentifier("CONVERSATION");
			this.GenerateSpaceAndKeyword(TSqlTokenType.Group);
			this.GenerateSpaceAndFragmentIfNotNull(node.GroupId);
			this.GenerateSpaceAndKeyword(TSqlTokenType.From);
			this.GenerateSpaceAndFragmentIfNotNull(node.Queue);
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x0002B214 File Offset: 0x00029414
		public override void ExplicitVisit(GoToStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.GoTo);
			this.GenerateSpaceAndFragmentIfNotNull(node.LabelName);
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x0002B22C File Offset: 0x0002942C
		public override void ExplicitVisit(GrantStatement node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.Grant);
			this.GeneratePermissionOnToClauses(node);
			if (node.WithGrantOption)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.With);
				this.GenerateSpaceAndKeyword(TSqlTokenType.Grant);
				this.GenerateSpaceAndKeyword(TSqlTokenType.Option);
			}
			this.GenerateAsClause(node);
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x0002B278 File Offset: 0x00029478
		public override void ExplicitVisit(GrantStatement80 node)
		{
			this.GenerateKeyword(TSqlTokenType.Grant);
			this.GenerateSpaceAndFragmentIfNotNull(node.SecurityElement80);
			this.GenerateSpaceAndKeyword(TSqlTokenType.To);
			this.GenerateSpaceAndFragmentIfNotNull(node.SecurityUserClause80);
			if (node.WithGrantOption)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.With);
				this.GenerateSpaceAndKeyword(TSqlTokenType.Grant);
				this.GenerateSpaceAndKeyword(TSqlTokenType.Option);
			}
			if (node.AsClause != null)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.As);
				this.GenerateSpaceAndFragmentIfNotNull(node.AsClause);
			}
		}

		// Token: 0x06000E6A RID: 3690 RVA: 0x0002B2F8 File Offset: 0x000294F8
		public override void ExplicitVisit(GroupByClause node)
		{
			AlignmentPoint ap = new AlignmentPoint();
			this.MarkAndPushAlignmentPoint(ap);
			this.GenerateKeyword(TSqlTokenType.Group);
			this.GenerateSpaceAndKeyword(TSqlTokenType.By);
			if (node.All)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.All);
			}
			AlignmentPoint alignmentPointForFragment = this.GetAlignmentPointForFragment(node, "ClauseBody");
			this.MarkClauseBodyAlignmentWhenNecessary(this._options.NewLineBeforeGroupByClause, alignmentPointForFragment);
			this.GenerateSpace();
			this.GenerateCommaSeparatedList<GroupingSpecification>(node.GroupingSpecifications);
			if (node.GroupByOption != GroupByOption.None)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.With);
				this.GenerateSpace();
				GroupByOptionHelper.Instance.GenerateSourceForOption(this._writer, node.GroupByOption);
			}
			this.PopAlignmentPoint();
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x0002B397 File Offset: 0x00029597
		public override void ExplicitVisit(ExpressionGroupingSpecification node)
		{
			this.GenerateFragmentIfNotNull(node.Expression);
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x0002B3A5 File Offset: 0x000295A5
		public override void ExplicitVisit(CompositeGroupingSpecification node)
		{
			this.GenerateParenthesisedCommaSeparatedList<GroupingSpecification>(node.Items);
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x0002B3B3 File Offset: 0x000295B3
		public override void ExplicitVisit(CubeGroupingSpecification node)
		{
			this.GenerateIdentifier("CUBE");
			this.GenerateParenthesisedCommaSeparatedList<GroupingSpecification>(node.Arguments);
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x0002B3CC File Offset: 0x000295CC
		public override void ExplicitVisit(RollupGroupingSpecification node)
		{
			this.GenerateIdentifier("ROLLUP");
			this.GenerateParenthesisedCommaSeparatedList<GroupingSpecification>(node.Arguments);
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x0002B3E5 File Offset: 0x000295E5
		public override void ExplicitVisit(GrandTotalGroupingSpecification node)
		{
			this.GenerateSymbol(TSqlTokenType.LeftParenthesis);
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x0002B3FD File Offset: 0x000295FD
		public override void ExplicitVisit(GroupingSetsGroupingSpecification node)
		{
			this.GenerateIdentifier("GROUPING");
			this.GenerateSpaceAndIdentifier("SETS");
			this.GenerateParenthesisedCommaSeparatedList<GroupingSpecification>(node.Sets);
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x0002B424 File Offset: 0x00029624
		public override void ExplicitVisit(HadrDatabaseOption node)
		{
			this.GenerateIdentifier("HADR");
			switch (node.HadrOption)
			{
			case HadrDatabaseOptionKind.Suspend:
				this.GenerateSpaceAndIdentifier("SUSPEND");
				return;
			case HadrDatabaseOptionKind.Resume:
				this.GenerateSpaceAndIdentifier("RESUME");
				return;
			case HadrDatabaseOptionKind.Off:
				this.GenerateSpaceAndKeyword(TSqlTokenType.Off);
				return;
			default:
				return;
			}
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x0002B476 File Offset: 0x00029676
		public override void ExplicitVisit(HadrAvailabilityGroupDatabaseOption node)
		{
			this.GenerateIdentifier("HADR");
			this.GenerateSpaceAndIdentifier("AVAILABILITY");
			this.GenerateSpaceAndKeyword(TSqlTokenType.Group);
			this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
			this.GenerateSpaceAndFragmentIfNotNull(node.GroupName);
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x0002B4B0 File Offset: 0x000296B0
		public override void ExplicitVisit(HavingClause node)
		{
			AlignmentPoint ap = new AlignmentPoint();
			this.MarkAndPushAlignmentPoint(ap);
			this.GenerateKeyword(TSqlTokenType.Having);
			AlignmentPoint alignmentPointForFragment = this.GetAlignmentPointForFragment(node, "ClauseBody");
			this.MarkClauseBodyAlignmentWhenNecessary(this._options.NewLineBeforeHavingClause, alignmentPointForFragment);
			this.GenerateSpaceAndFragmentIfNotNull(node.SearchCondition);
			this.PopAlignmentPoint();
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x0002B503 File Offset: 0x00029703
		public override void ExplicitVisit(Identifier node)
		{
			if (node.Value != null)
			{
				if (node.QuoteType == QuoteType.NotQuoted)
				{
					this.GenerateIdentifierWithoutCheck(node.Value);
					return;
				}
				this.GenerateQuotedIdentifier(node.Value, node.QuoteType);
			}
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x0002B534 File Offset: 0x00029734
		private void GenerateQuotedIdentifier(string identifier, QuoteType quoteType)
		{
			this.GenerateIdentifierWithoutCheck(Identifier.EncodeIdentifier(identifier, quoteType));
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x0002B543 File Offset: 0x00029743
		public override void ExplicitVisit(IdentifierDatabaseOption node)
		{
			DatabaseOptionKindHelper.Instance.GenerateSourceForOption(this._writer, node.OptionKind);
			this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
			this.GenerateSpaceAndFragmentIfNotNull(node.Value);
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x0002B572 File Offset: 0x00029772
		public override void ExplicitVisit(PrincipalOption node)
		{
			this.GenerateIdentifier("NO");
			this.GenerateSpaceAndIdentifier("CREDENTIAL");
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x0002B58C File Offset: 0x0002978C
		public override void ExplicitVisit(IdentifierPrincipalOption node)
		{
			string valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<PrincipalOptionKind, string>(SqlScriptGeneratorVisitor._loginOptionsNames, node.OptionKind);
			this.GenerateNameEqualsValue(valueForEnumKey, node.Identifier);
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x0002B5B8 File Offset: 0x000297B8
		public override void ExplicitVisit(IdentityFunctionCall node)
		{
			this.GenerateKeyword(TSqlTokenType.Identity);
			this.GenerateSpaceAndSymbol(TSqlTokenType.LeftParenthesis);
			this.GenerateFragmentIfNotNull(node.DataType);
			if (node.Seed != null)
			{
				this.GenerateSymbol(TSqlTokenType.Comma);
				this.GenerateSpaceAndFragmentIfNotNull(node.Seed);
				this.GenerateSymbol(TSqlTokenType.Comma);
				this.GenerateSpaceAndFragmentIfNotNull(node.Increment);
			}
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x0002B628 File Offset: 0x00029828
		public override void ExplicitVisit(IfStatement node)
		{
			AlignmentPoint ap = new AlignmentPoint();
			this.GenerateKeyword(TSqlTokenType.If);
			this.GenerateSpaceAndFragmentIfNotNull(node.Predicate);
			this.NewLineAndIndent();
			this.MarkAndPushAlignmentPoint(ap);
			this.GenerateFragmentIfNotNull(node.ThenStatement);
			this.GenerateSemiColonWhenNecessary(node.ThenStatement);
			this.PopAlignmentPoint();
			if (node.ElseStatement != null)
			{
				this.NewLine();
				this.GenerateKeyword(TSqlTokenType.Else);
				this.NewLineAndIndent();
				this.MarkAndPushAlignmentPoint(ap);
				this.GenerateFragmentIfNotNull(node.ElseStatement);
				this.GenerateSemiColonWhenNecessary(node.ElseStatement);
				this.PopAlignmentPoint();
			}
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x0002B6BC File Offset: 0x000298BC
		public override void ExplicitVisit(IIfCall node)
		{
			this.GenerateIdentifier("IIF");
			this.GenerateSpaceAndSymbol(TSqlTokenType.LeftParenthesis);
			this.GenerateFragmentIfNotNull(node.Predicate);
			this.GenerateSymbolAndSpace(TSqlTokenType.Comma);
			this.GenerateFragmentIfNotNull(node.ThenExpression);
			this.GenerateSymbolAndSpace(TSqlTokenType.Comma);
			this.GenerateFragmentIfNotNull(node.ElseExpression);
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			this.GenerateSpaceAndCollation(node.Collation);
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x0002B730 File Offset: 0x00029930
		public override void ExplicitVisit(IndexDefinition node)
		{
			this.GenerateKeyword(TSqlTokenType.Index);
			if (node.Name != null)
			{
				this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			}
			if (node.IndexType != null)
			{
                IndexTypeKind? indexTypeKind = node.IndexType.IndexTypeKind;
                ref IndexTypeKind? local = ref indexTypeKind;
                IndexTypeKind valueOrDefault = local.GetValueOrDefault();
				if (local.HasValue)
				{
					switch (valueOrDefault)
					{
					case IndexTypeKind.Clustered:
						this.GenerateSpaceAndKeyword(TSqlTokenType.Clustered);
						break;
					case IndexTypeKind.NonClustered:
						this.GenerateSpaceAndKeyword(TSqlTokenType.NonClustered);
						break;
					case IndexTypeKind.NonClusteredHash:
						this.GenerateSpaceAndKeyword(TSqlTokenType.NonClustered);
						this.GenerateSpaceAndIdentifier("HASH");
						break;
					}
				}
			}
			if (node.Columns.Count > 0)
			{
				this.GenerateSpace();
				this.GenerateParenthesisedCommaSeparatedList<ColumnWithSortOrder>(node.Columns);
			}
			if (node.IndexOptions.Count > 0)
			{
				this.GenerateIndexOptions(node.IndexOptions);
			}
			if (node.OnFileGroupOrPartitionScheme != null)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.On);
				this.GenerateSpaceAndFragmentIfNotNull(node.OnFileGroupOrPartitionScheme);
			}
			this.GenerateFileStreamOn(node);
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x0002B81B File Offset: 0x00029A1B
		public override void ExplicitVisit(IndexExpressionOption node)
		{
			IndexOptionHelper.Instance.GenerateSourceForOption(this._writer, node.OptionKind);
			this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
			this.GenerateSpaceAndFragmentIfNotNull(node.Expression);
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x0002B84A File Offset: 0x00029A4A
		public override void ExplicitVisit(IndexStateOption node)
		{
			IndexOptionHelper.Instance.GenerateSourceForOption(this._writer, node.OptionKind);
			this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
			this.GenerateSpace();
			this.GenerateOptionStateOnOff(node.OptionState);
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x0002B880 File Offset: 0x00029A80
		public override void ExplicitVisit(InPredicate node)
		{
			this.GenerateFragmentIfNotNull(node.Expression);
			if (node.NotDefined)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.Not);
			}
			this.GenerateSpaceAndKeyword(TSqlTokenType.In);
			if (node.Values.Count > 0)
			{
				this.GenerateSpace();
				this.GenerateParenthesisedCommaSeparatedList<ScalarExpression>(node.Values);
			}
			this.GenerateSpaceAndFragmentIfNotNull(node.Subquery);
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x0002B8E0 File Offset: 0x00029AE0
		public override void ExplicitVisit(InsertBulkColumnDefinition node)
		{
			this.GenerateFragmentIfNotNull(node.Column);
			switch (node.NullNotNull)
			{
			case NullNotNull.NotSpecified:
				break;
			case NullNotNull.Null:
				this.GenerateSpaceAndKeyword(TSqlTokenType.Null);
				return;
			case NullNotNull.NotNull:
				this.GenerateSpaceAndKeyword(TSqlTokenType.Not);
				this.GenerateSpaceAndKeyword(TSqlTokenType.Null);
				break;
			default:
				return;
			}
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x0002B92C File Offset: 0x00029B2C
		public override void ExplicitVisit(InsertBulkStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Insert);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Bulk);
			this.GenerateSpaceAndFragmentIfNotNull(node.To);
			if (node.ColumnDefinitions.Count > 0)
			{
				this.GenerateSpace();
				this.GenerateParenthesisedCommaSeparatedList<InsertBulkColumnDefinition>(node.ColumnDefinitions);
			}
			this.GenerateOption(node);
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x0002B97C File Offset: 0x00029B7C
		public override void ExplicitVisit(InsertStatement node)
		{
			AlignmentPoint ap = new AlignmentPoint();
			AlignmentPoint ap2 = new AlignmentPoint("ClauseBody");
			this.MarkAndPushAlignmentPoint(ap);
			if (node.WithCtesAndXmlNamespaces != null)
			{
				this.GenerateFragmentWithAlignmentPointIfNotNull(node.WithCtesAndXmlNamespaces, ap2);
				this.NewLine();
			}
			this.GenerateFragmentIfNotNull(node.InsertSpecification);
			this.GenerateOptimizerHints(node.OptimizerHints);
			this.PopAlignmentPoint();
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x0002B9DC File Offset: 0x00029BDC
		public override void ExplicitVisit(InsertSpecification node)
		{
			AlignmentPoint ap = new AlignmentPoint("ClauseBody");
			AlignmentPoint ap2 = new AlignmentPoint("InsertColumns");
			this.GenerateKeyword(TSqlTokenType.Insert);
			this.MarkClauseBodyAlignmentWhenNecessary(true, ap);
			if (node.TopRowFilter != null)
			{
				this.GenerateSpaceAndFragmentIfNotNull(node.TopRowFilter);
			}
			this.GenerateSpaceAndInsertOption(node.InsertOption);
			if (node.Target != null)
			{
				this.GenerateSpace();
				this.GenerateFragmentWithAlignmentPointIfNotNull(node.Target, ap2);
				if (node.Columns.Count > 0)
				{
					this.MarkInsertColumnsAlignmentPointWhenNecessary(ap2);
					this.GenerateSpace();
					this.GenerateParenthesisedCommaSeparatedList<ColumnReferenceExpression>(node.Columns);
				}
			}
			if (node.OutputIntoClause != null)
			{
				this.GenerateSeparatorForOutputClause();
				this.GenerateFragmentWithAlignmentPointIfNotNull(node.OutputIntoClause, ap);
			}
			if (node.OutputClause != null)
			{
				this.GenerateSeparatorForOutputClause();
				this.GenerateFragmentWithAlignmentPointIfNotNull(node.OutputClause, ap);
			}
			this.NewLine();
			if (node.InsertSource != null)
			{
				this.AddAlignmentPointForFragment(node.InsertSource, ap);
				this.AddAlignmentPointForFragment(node.InsertSource, ap2);
				bool generateSemiColon = this._generateSemiColon;
				this._generateSemiColon = false;
				this.GenerateFragmentIfNotNull(node.InsertSource);
				this._generateSemiColon = generateSemiColon;
				this.ClearAlignmentPointsForFragment(node.InsertSource);
			}
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x0002BAFC File Offset: 0x00029CFC
		private void GenerateSpaceAndInsertOption(InsertOption insertOption)
		{
			if (insertOption != InsertOption.None)
			{
				TokenGenerator valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<InsertOption, TokenGenerator>(SqlScriptGeneratorVisitor._insertOptionGenerators, insertOption);
				if (valueForEnumKey != null)
				{
					this.GenerateSpace();
					this.GenerateToken(valueForEnumKey);
				}
			}
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x0002BB28 File Offset: 0x00029D28
		public override void ExplicitVisit(InternalOpenRowset node)
		{
			this.GenerateKeyword(TSqlTokenType.OpenRowSet);
			this.GenerateSpaceAndSymbol(TSqlTokenType.LeftParenthesis);
			this.GenerateFragmentIfNotNull(node.Identifier);
			if (node.VarArgs.Count > 0)
			{
				this.GenerateSymbolAndSpace(TSqlTokenType.Comma);
			}
			this.GenerateCommaSeparatedList<ScalarExpression>(node.VarArgs);
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			this.GenerateSpaceAndAlias(node.Alias);
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x0002BB90 File Offset: 0x00029D90
		public override void ExplicitVisit(ScalarExpressionSnippet node)
		{
			if (node.Script != null)
			{
				this.GenerateIdentifierWithoutCheck(node.Script);
			}
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x0002BBA6 File Offset: 0x00029DA6
		public override void ExplicitVisit(BooleanExpressionSnippet node)
		{
			if (node.Script != null)
			{
				this.GenerateIdentifierWithoutCheck(node.Script);
			}
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x0002BBBC File Offset: 0x00029DBC
		public override void ExplicitVisit(IdentifierSnippet node)
		{
			if (node.Script != null)
			{
				this.GenerateIdentifierWithoutCheck(node.Script);
			}
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x0002BBD2 File Offset: 0x00029DD2
		public override void ExplicitVisit(SchemaObjectNameSnippet node)
		{
			if (node.Script != null)
			{
				this.GenerateIdentifierWithoutCheck(node.Script);
			}
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x0002BBE8 File Offset: 0x00029DE8
		public override void ExplicitVisit(SelectStatementSnippet node)
		{
			if (node.Script != null)
			{
				this.GenerateIdentifierWithoutCheck(node.Script);
			}
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x0002BBFE File Offset: 0x00029DFE
		public override void ExplicitVisit(StatementListSnippet node)
		{
			if (node.Script != null)
			{
				this.GenerateIdentifierWithoutCheck(node.Script);
			}
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x0002BC14 File Offset: 0x00029E14
		public override void ExplicitVisit(TSqlFragmentSnippet node)
		{
			if (node.Script != null)
			{
				this.GenerateIdentifierWithoutCheck(node.Script);
			}
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x0002BC2A File Offset: 0x00029E2A
		public override void ExplicitVisit(TSqlStatementSnippet node)
		{
			if (node.Script != null)
			{
				this.GenerateIdentifierWithoutCheck(node.Script);
			}
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x0002BC40 File Offset: 0x00029E40
		public override void ExplicitVisit(IPv4 node)
		{
			this.GenerateFragmentIfNotNull(node.OctetOne);
			this.GenerateSymbol(TSqlTokenType.Dot);
			this.GenerateFragmentIfNotNull(node.OctetTwo);
			this.GenerateSymbol(TSqlTokenType.Dot);
			this.GenerateFragmentIfNotNull(node.OctetThree);
			this.GenerateSymbol(TSqlTokenType.Dot);
			this.GenerateFragmentIfNotNull(node.OctetFour);
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x0002BCA0 File Offset: 0x00029EA0
		public override void ExplicitVisit(JoinParenthesisTableReference node)
		{
			this.GenerateSymbol(TSqlTokenType.LeftParenthesis);
			AlignmentPoint ap = new AlignmentPoint();
			this.MarkAndPushAlignmentPoint(ap);
			this.GenerateFragmentIfNotNull(node.Join);
			this.PopAlignmentPoint();
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x0002BCE4 File Offset: 0x00029EE4
		public override void ExplicitVisit(KillQueryNotificationSubscriptionStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Kill);
			this.GenerateSpaceAndIdentifier("QUERY");
			this.GenerateSpaceAndIdentifier("NOTIFICATION");
			this.GenerateSpaceAndIdentifier("SUBSCRIPTION");
			if (node.All)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.All);
				return;
			}
			this.GenerateSpaceAndFragmentIfNotNull(node.SubscriptionId);
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x0002BD36 File Offset: 0x00029F36
		public override void ExplicitVisit(KillStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Kill);
			this.GenerateSpaceAndFragmentIfNotNull(node.Parameter);
			if (node.WithStatusOnly)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.With);
				this.GenerateSpaceAndIdentifier("STATUSONLY");
			}
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x0002BD70 File Offset: 0x00029F70
		public override void ExplicitVisit(KillStatsJobStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Kill);
			this.GenerateSpaceAndIdentifier("STATS");
			this.GenerateSpaceAndIdentifier("JOB");
			this.GenerateSpaceAndFragmentIfNotNull(node.JobId);
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x0002BD9C File Offset: 0x00029F9C
		public override void ExplicitVisit(LabelStatement node)
		{
			this.GenerateIdentifierWithoutCasing(node.Value);
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x0002BDAC File Offset: 0x00029FAC
		public override void ExplicitVisit(LikePredicate node)
		{
			this.GenerateFragmentIfNotNull(node.FirstExpression);
			if (node.NotDefined)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.Not);
			}
			this.GenerateSpaceAndKeyword(TSqlTokenType.Like);
			this.GenerateSpaceAndFragmentIfNotNull(node.SecondExpression);
			if (node.EscapeExpression != null)
			{
				this.GenerateSpace();
				if (node.OdbcEscape)
				{
					this.GenerateSymbol(TSqlTokenType.LeftCurly);
				}
				this.GenerateKeyword(TSqlTokenType.Escape);
				this.GenerateSpaceAndFragmentIfNotNull(node.EscapeExpression);
				if (node.OdbcEscape)
				{
					this.GenerateSpaceAndSymbol(TSqlTokenType.RightCurly);
				}
			}
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x0002BE31 File Offset: 0x0002A031
		public override void ExplicitVisit(LineNoStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.LineNo);
			this.GenerateSpaceAndFragmentIfNotNull(node.LineNo);
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x0002BE48 File Offset: 0x0002A048
		public override void ExplicitVisit(ListenerIPEndpointProtocolOption node)
		{
			this.GenerateIdentifier("LISTENER_IP");
			this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
			this.GenerateSpace();
			if (node.IsAll)
			{
				this.GenerateKeyword(TSqlTokenType.All);
				return;
			}
			this.GenerateSymbol(TSqlTokenType.LeftParenthesis);
			if (node.IPv6 != null)
			{
				this.GenerateFragmentIfNotNull(node.IPv6);
			}
			else
			{
				this.GenerateFragmentIfNotNull(node.IPv4PartOne);
				if (node.IPv4PartTwo != null)
				{
					this.GenerateSymbol(TSqlTokenType.Colon);
					this.GenerateFragmentIfNotNull(node.IPv4PartTwo);
				}
			}
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x0002BED8 File Offset: 0x0002A0D8
		public override void ExplicitVisit(IntegerLiteral node)
		{
			this.GenerateToken(TSqlTokenType.Integer, node.Value);
			this.GenerateSpaceAndCollation(node.Collation);
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x0002BEF7 File Offset: 0x0002A0F7
		public override void ExplicitVisit(NumericLiteral node)
		{
			this.GenerateToken(TSqlTokenType.Numeric, node.Value);
			this.GenerateSpaceAndCollation(node.Collation);
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x0002BF18 File Offset: 0x0002A118
		public override void ExplicitVisit(StringLiteral node)
		{
			if (!node.IsNational)
			{
				string text = "'" + node.Value.Replace("'", "''") + "'";
				this.GenerateToken(TSqlTokenType.AsciiStringLiteral, text);
			}
			else
			{
				string text2 = "N'" + node.Value.Replace("'", "''") + "'";
				this.GenerateToken(TSqlTokenType.UnicodeStringLiteral, text2);
			}
			this.GenerateSpaceAndCollation(node.Collation);
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x0002BF9D File Offset: 0x0002A19D
		public override void ExplicitVisit(BinaryLiteral node)
		{
			this.GenerateToken(TSqlTokenType.HexLiteral, node.Value);
			this.GenerateSpaceAndCollation(node.Collation);
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x0002BFBC File Offset: 0x0002A1BC
		public override void ExplicitVisit(DefaultLiteral node)
		{
			this.GenerateKeyword(TSqlTokenType.Default);
			this.GenerateSpaceAndCollation(node.Collation);
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x0002BFD2 File Offset: 0x0002A1D2
		public override void ExplicitVisit(MaxLiteral node)
		{
			this.GenerateIdentifier("MAX");
			this.GenerateSpaceAndCollation(node.Collation);
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x0002BFEB File Offset: 0x0002A1EB
		public override void ExplicitVisit(MoneyLiteral node)
		{
			this.GenerateToken(TSqlTokenType.Money, node.Value);
			this.GenerateSpaceAndCollation(node.Collation);
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x0002C00A File Offset: 0x0002A20A
		public override void ExplicitVisit(NullLiteral node)
		{
			this.GenerateKeyword(TSqlTokenType.Null);
			this.GenerateSpaceAndCollation(node.Collation);
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x0002C020 File Offset: 0x0002A220
		public override void ExplicitVisit(RealLiteral node)
		{
			this.GenerateToken(TSqlTokenType.Real, node.Value);
			this.GenerateSpaceAndCollation(node.Collation);
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x0002C03F File Offset: 0x0002A23F
		public override void ExplicitVisit(IdentifierLiteral node)
		{
			if (node.QuoteType == QuoteType.NotQuoted)
			{
				this.GenerateIdentifierWithoutCheck(node.Value);
			}
			else
			{
				this.GenerateQuotedIdentifier(node.Value, node.QuoteType);
			}
			this.GenerateSpaceAndCollation(node.Collation);
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x0002C075 File Offset: 0x0002A275
		public override void ExplicitVisit(VariableReference node)
		{
			this.GenerateToken(TSqlTokenType.Variable, node.Name);
			this.GenerateSpaceAndCollation(node.Collation);
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x0002C094 File Offset: 0x0002A294
		public override void ExplicitVisit(GlobalVariableExpression node)
		{
			this.GenerateToken(TSqlTokenType.Variable, node.Name);
			this.GenerateSpaceAndCollation(node.Collation);
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x0002C0B4 File Offset: 0x0002A2B4
		public override void ExplicitVisit(OdbcLiteral node)
		{
			this.GenerateOdbcLiteralPrefix(node);
			if (!node.IsNational)
			{
				string text = "'" + node.Value.Replace("'", "''") + "'";
				this.GenerateToken(TSqlTokenType.AsciiStringLiteral, text);
			}
			else
			{
				string text2 = "N'" + node.Value.Replace("'", "''") + "'";
				this.GenerateToken(TSqlTokenType.UnicodeStringLiteral, text2);
			}
			this.GenerateSpaceAndSymbol(TSqlTokenType.RightCurly);
			this.GenerateSpaceAndCollation(node.Collation);
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x0002C14C File Offset: 0x0002A34C
		private void GenerateOdbcLiteralPrefix(OdbcLiteral node)
		{
			this.GenerateSymbolAndSpace(TSqlTokenType.LeftCurly);
			switch (node.OdbcLiteralType)
			{
			case OdbcLiteralType.Time:
				this.GenerateIdentifier("T");
				break;
			case OdbcLiteralType.Date:
				this.GenerateIdentifier("D");
				break;
			case OdbcLiteralType.Timestamp:
				this.GenerateIdentifier("TS");
				break;
			case OdbcLiteralType.Guid:
				this.GenerateIdentifier("GUID");
				break;
			}
			this.GenerateSpace();
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x0002C1BC File Offset: 0x0002A3BC
		public override void ExplicitVisit(LiteralEndpointProtocolOption node)
		{
			string valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<EndpointProtocolOptions, string>(SqlScriptGeneratorVisitor._endpointProtocolOptionsNames, node.Kind);
			if (valueForEnumKey != null)
			{
				if (node.Value != null)
				{
					this.GenerateNameEqualsValue(valueForEnumKey, node.Value);
					return;
				}
				this.GenerateNameEqualsValue(valueForEnumKey, "NONE");
			}
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x0002C200 File Offset: 0x0002A400
		public override void ExplicitVisit(LiteralPayloadOption node)
		{
			TokenGenerator valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<PayloadOptionKinds, TokenGenerator>(SqlScriptGeneratorVisitor._payloadOptionKindsGenerators, node.Kind);
			if (valueForEnumKey != null)
			{
				this.GenerateNameEqualsValue(valueForEnumKey, node.Value);
			}
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x0002C22E File Offset: 0x0002A42E
		public override void ExplicitVisit(LockEscalationTableOption node)
		{
			this.GenerateIdentifier("LOCK_ESCALATION");
			this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
			this.GenerateSpace();
			LockEscalationMethodHelper.Instance.GenerateSourceForOption(this._writer, node.Value);
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x0002C262 File Offset: 0x0002A462
		public override void ExplicitVisit(LoginTypePayloadOption node)
		{
			this.GenerateNameEqualsValue("LOGIN_TYPE", node.IsWindows ? "WINDOWS" : "MIXED");
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x0002C284 File Offset: 0x0002A484
		internal void GenerateLowPriorityWaitOptions(IList<LowPriorityLockWaitOption> options)
		{
			if (options != null && options.Count > 0)
			{
				LowPriorityLockWaitMaxDurationOption lowPriorityLockWaitMaxDurationOption = null;
				LowPriorityLockWaitAbortAfterWaitOption fragment = null;
				foreach (LowPriorityLockWaitOption lowPriorityLockWaitOption in options)
				{
					if (lowPriorityLockWaitOption.OptionKind == LowPriorityLockWaitOptionKind.MaxDuration)
					{
						lowPriorityLockWaitMaxDurationOption = (lowPriorityLockWaitOption as LowPriorityLockWaitMaxDurationOption);
					}
					else if (lowPriorityLockWaitOption.OptionKind == LowPriorityLockWaitOptionKind.AbortAfterWait)
					{
						fragment = (lowPriorityLockWaitOption as LowPriorityLockWaitAbortAfterWaitOption);
					}
				}
				this.GenerateIdentifier("WAIT_AT_LOW_PRIORITY");
				this.GenerateSpaceAndSymbol(TSqlTokenType.LeftParenthesis);
				this.GenerateFragmentIfNotNull(lowPriorityLockWaitMaxDurationOption);
				if (lowPriorityLockWaitMaxDurationOption != null)
				{
					this.GenerateSymbol(TSqlTokenType.Comma);
					this.GenerateSpace();
				}
				this.GenerateFragmentIfNotNull(fragment);
				this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			}
		}

		// Token: 0x06000EAA RID: 3754 RVA: 0x0002C340 File Offset: 0x0002A540
		public override void ExplicitVisit(LowPriorityLockWaitMaxDurationOption node)
		{
			this.GenerateTokenAndEqualSign("MAX_DURATION");
			this.GenerateSpaceAndFragmentIfNotNull(node.MaxDuration);
			if (node.Unit != null)
			{
				this.GenerateSpace();
				LowPriorityLockWaitMaxDurationTimeUnitHelper.Instance.GenerateSourceForOption(this._writer, node.Unit.Value);
			}
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x0002C398 File Offset: 0x0002A598
		public override void ExplicitVisit(LowPriorityLockWaitAbortAfterWaitOption node)
		{
			this.GenerateTokenAndEqualSign("ABORT_AFTER_WAIT");
			this.GenerateSpace();
			AbortAfterWaitTypeHelper.Instance.GenerateSourceForOption(this._writer, node.AbortAfterWait);
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x0002C3C1 File Offset: 0x0002A5C1
		public override void ExplicitVisit(LowPriorityLockWaitTableSwitchOption node)
		{
			this.GenerateLowPriorityWaitOptions(node.Options);
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x0002C3CF File Offset: 0x0002A5CF
		public override void ExplicitVisit(MaxSizeDatabaseOption node)
		{
			this.GenerateNameEqualsValue("MAXSIZE", node.MaxSize);
			this.GenerateSpaceAndMemoryUnit(node.Units);
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x0002C3EE File Offset: 0x0002A5EE
		public override void ExplicitVisit(MemoryOptimizedTableOption node)
		{
			this.GenerateOptionStateWithEqualSign("MEMORY_OPTIMIZED", node.OptionState);
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x0002C404 File Offset: 0x0002A604
		public override void ExplicitVisit(MergeActionClause node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.When);
			switch (node.Condition)
			{
			case MergeCondition.Matched:
				this.GenerateIdentifier("MATCHED");
				break;
			case MergeCondition.NotMatched:
				this.GenerateKeyword(TSqlTokenType.Not);
				this.GenerateSpaceAndIdentifier("MATCHED");
				break;
			case MergeCondition.NotMatchedByTarget:
				this.GenerateKeyword(TSqlTokenType.Not);
				this.GenerateSpaceAndIdentifier("MATCHED");
				this.GenerateSpaceAndKeyword(TSqlTokenType.By);
				this.GenerateSpaceAndIdentifier("TARGET");
				break;
			case MergeCondition.NotMatchedBySource:
				this.GenerateKeyword(TSqlTokenType.Not);
				this.GenerateSpaceAndIdentifier("MATCHED");
				this.GenerateSpaceAndKeyword(TSqlTokenType.By);
				this.GenerateSpaceAndIdentifier("SOURCE");
				break;
			}
			if (node.SearchCondition != null)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.And);
				this.GenerateSpaceAndFragmentIfNotNull(node.SearchCondition);
			}
			this.GenerateSpaceAndKeyword(TSqlTokenType.Then);
			this.GenerateSpaceAndFragmentIfNotNull(node.Action);
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x0002C4E4 File Offset: 0x0002A6E4
		public override void ExplicitVisit(MergeStatement node)
		{
			AlignmentPoint ap = new AlignmentPoint();
			AlignmentPoint ap2 = new AlignmentPoint("ClauseBody");
			this.MarkAndPushAlignmentPoint(ap);
			if (node.WithCtesAndXmlNamespaces != null)
			{
				this.GenerateFragmentWithAlignmentPointIfNotNull(node.WithCtesAndXmlNamespaces, ap2);
				this.NewLine();
			}
			this.GenerateFragmentIfNotNull(node.MergeSpecification);
			this.GenerateOptimizerHints(node.OptimizerHints);
			this.PopAlignmentPoint();
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x0002C54C File Offset: 0x0002A74C
		public override void ExplicitVisit(MergeSpecification node)
		{
			AlignmentPoint ap = new AlignmentPoint("ClauseBody");
			this.GenerateKeyword(TSqlTokenType.Merge);
			this.MarkClauseBodyAlignmentWhenNecessary(false, ap);
			if (node.TopRowFilter != null)
			{
				this.GenerateSpaceAndFragmentIfNotNull(node.TopRowFilter);
			}
			this.GenerateSpace();
			this.GenerateKeyword(TSqlTokenType.Into);
			if (node.Target != null)
			{
				this.GenerateSpace();
				this.GenerateFragmentIfNotNull(node.Target);
				this.NewLine();
			}
			if (node.TableAlias != null)
			{
				this.GenerateSpace();
				this.GenerateKeyword(TSqlTokenType.As);
				this.GenerateSpace();
				this.GenerateFragmentIfNotNull(node.TableAlias);
			}
			this.NewLine();
			this.GenerateIdentifier("USING");
			this.GenerateSpace();
			this.GenerateFragmentIfNotNull(node.TableReference);
			this.GenerateSpace();
			this.GenerateKeyword(TSqlTokenType.On);
			this.GenerateSpace();
			this.GenerateFragmentIfNotNull(node.SearchCondition);
			this.NewLine();
			if (node.ActionClauses != null)
			{
				this.GenerateList<MergeActionClause>(node.ActionClauses, delegate
				{
					this.NewLine();
				});
			}
			if (node.OutputIntoClause != null)
			{
				this.GenerateSeparatorForOutputClause();
				this.GenerateFragmentWithAlignmentPointIfNotNull(node.OutputIntoClause, ap);
			}
			if (node.OutputClause != null)
			{
				this.AddAlignmentPointForFragment(node.OutputClause, ap);
				this.GenerateSpace();
				this.GenerateFragmentIfNotNull(node.OutputClause);
			}
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x0002C68C File Offset: 0x0002A88C
		public override void ExplicitVisit(UpdateMergeAction node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.Update);
			AlignmentPoint alignmentPoint = new AlignmentPoint("ClauseBody");
			this.GenerateSetClauses(node.SetClauses, alignmentPoint);
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x0002C6BC File Offset: 0x0002A8BC
		public override void ExplicitVisit(DeleteMergeAction node)
		{
			this.GenerateKeyword(TSqlTokenType.Delete);
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x0002C6C8 File Offset: 0x0002A8C8
		public override void ExplicitVisit(InsertMergeAction node)
		{
			AlignmentPoint ap = new AlignmentPoint("InsertColumns");
			this.GenerateKeyword(TSqlTokenType.Insert);
			AlignmentPoint ap2 = new AlignmentPoint("ClauseBody");
			this.AddAlignmentPointForFragment(node.Source, ap2);
			if (node.Columns.Count > 0)
			{
				this.GenerateSpace();
				this.GenerateParenthesisedCommaSeparatedList<ColumnReferenceExpression>(node.Columns);
			}
			if (node.Source != null)
			{
				this.GenerateSpace();
				this.GenerateFragmentWithAlignmentPointIfNotNull(node.Source, ap);
			}
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x0002C73C File Offset: 0x0002A93C
		protected void GenerateValidationMethod(MessageTypeStatementBase node)
		{
			if (node.ValidationMethod != MessageValidationMethod.NotSpecified)
			{
				string valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<MessageValidationMethod, string>(SqlScriptGeneratorVisitor._MessageValidationMethodNames, node.ValidationMethod);
				this.NewLineAndIndent();
				this.GenerateNameEqualsValue("VALIDATION", valueForEnumKey);
				if (node.ValidationMethod == MessageValidationMethod.ValidXml && node.XmlSchemaCollectionName != null)
				{
					this.GenerateSpaceAndKeyword(TSqlTokenType.With);
					this.GenerateSpaceAndKeyword(TSqlTokenType.Schema);
					this.GenerateSpaceAndIdentifier("COLLECTION");
					this.GenerateSpaceAndFragmentIfNotNull(node.XmlSchemaCollectionName);
				}
			}
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x0002C7B4 File Offset: 0x0002A9B4
		public override void ExplicitVisit(MethodSpecifier node)
		{
			this.GenerateKeyword(TSqlTokenType.External);
			this.GenerateSpaceAndIdentifier("NAME");
			this.GenerateSpaceAndFragmentIfNotNull(node.AssemblyName);
			this.GenerateSymbol(TSqlTokenType.Dot);
			this.GenerateFragmentIfNotNull(node.ClassName);
			this.GenerateSymbol(TSqlTokenType.Dot);
			this.GenerateFragmentIfNotNull(node.MethodName);
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x0002C814 File Offset: 0x0002AA14
		protected void GenerateBulkColumnTimestamp(TextModificationStatement node)
		{
			if (node.Bulk)
			{
				this.GenerateKeywordAndSpace(TSqlTokenType.Bulk);
			}
			this.GenerateFragmentIfNotNull(node.Column);
			this.GenerateSpaceAndFragmentIfNotNull(node.TextId);
			if (node.Timestamp != null)
			{
				this.GenerateSpace();
				this.GenerateNameEqualsValue("TIMESTAMP", node.Timestamp);
			}
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x0002C868 File Offset: 0x0002AA68
		public override void ExplicitVisit(MoveConversationStatement node)
		{
			this.GenerateIdentifier("MOVE");
			this.GenerateSpaceAndIdentifier("CONVERSATION");
			this.GenerateSpaceAndFragmentIfNotNull(node.Conversation);
			this.GenerateSpaceAndKeyword(TSqlTokenType.To);
			this.GenerateSpaceAndFragmentIfNotNull(node.Group);
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x0002C8A3 File Offset: 0x0002AAA3
		public override void ExplicitVisit(MoveRestoreOption node)
		{
			this.GenerateIdentifier("MOVE");
			this.GenerateSpaceAndFragmentIfNotNull(node.LogicalFileName);
			this.GenerateSpaceAndKeyword(TSqlTokenType.To);
			this.GenerateSpaceAndFragmentIfNotNull(node.OSFileName);
		}

		// Token: 0x06000EBA RID: 3770 RVA: 0x0002C8D3 File Offset: 0x0002AAD3
		public override void ExplicitVisit(MultiPartIdentifier node)
		{
			this.GenerateDotSeparatedList<Identifier>(node.Identifiers);
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x0002C8E1 File Offset: 0x0002AAE1
		public override void ExplicitVisit(NamedTableReference node)
		{
			this.GenerateFragmentIfNotNull(node.SchemaObject);
			this.GenerateSpaceAndAlias(node.Alias);
			this.GenerateSpaceAndFragmentIfNotNull(node.TableSampleClause);
			this.GenerateWithTableHints(node.TableHints);
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x0002C913 File Offset: 0x0002AB13
		public override void ExplicitVisit(SchemaObjectFunctionTableReference node)
		{
			this.GenerateFragmentIfNotNull(node.SchemaObject);
			this.GenerateParenthesisedCommaSeparatedList<ScalarExpression>(node.Parameters, true);
			this.GenerateTableAndColumnAliases(node);
		}

		// Token: 0x06000EBD RID: 3773 RVA: 0x0002C938 File Offset: 0x0002AB38
		public override void ExplicitVisit(NextValueForExpression node)
		{
			this.GenerateSpaceAndIdentifier("NEXT");
			this.GenerateSpaceAndIdentifier("VALUE");
			this.GenerateSpaceAndKeyword(TSqlTokenType.For);
			this.GenerateSpaceAndFragmentIfNotNull(node.SequenceName);
			if (node.OverClause != null)
			{
				this.GenerateSpace();
				this.ExplicitVisit(node.OverClause);
			}
		}

		// Token: 0x06000EBE RID: 3774 RVA: 0x0002C989 File Offset: 0x0002AB89
		public override void ExplicitVisit(NullableConstraintDefinition node)
		{
			this.GenerateConstraintHead(node);
			if (!node.Nullable)
			{
				this.GenerateKeywordAndSpace(TSqlTokenType.Not);
			}
			this.GenerateKeyword(TSqlTokenType.Null);
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x0002C9AC File Offset: 0x0002ABAC
		public override void ExplicitVisit(NullIfExpression node)
		{
			this.GenerateKeyword(TSqlTokenType.NullIf);
			this.GenerateSpaceAndSymbol(TSqlTokenType.LeftParenthesis);
			this.GenerateFragmentIfNotNull(node.FirstExpression);
			this.GenerateSymbolAndSpace(TSqlTokenType.Comma);
			this.GenerateFragmentIfNotNull(node.SecondExpression);
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			this.GenerateSpaceAndCollation(node.Collation);
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x0002CA06 File Offset: 0x0002AC06
		public override void ExplicitVisit(OdbcConvertSpecification node)
		{
			this.GenerateFragmentIfNotNull(node.Identifier);
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x0002CA14 File Offset: 0x0002AC14
		public override void ExplicitVisit(OdbcFunctionCall node)
		{
			this.GenerateSymbol(TSqlTokenType.LeftCurly);
			this.GenerateSpaceAndIdentifier("FN");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			if (node.ParametersUsed)
			{
				this.GenerateSpace();
				this.GenerateParenthesisedCommaSeparatedList<ScalarExpression>(node.Parameters, true);
			}
			this.GenerateSpaceAndSymbol(TSqlTokenType.RightCurly);
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x0002CA69 File Offset: 0x0002AC69
		public override void ExplicitVisit(OdbcQualifiedJoinTableReference node)
		{
			this.GenerateSymbol(TSqlTokenType.LeftCurly);
			this.GenerateSpaceAndIdentifier("OJ");
			this.GenerateSpaceAndFragmentIfNotNull(node.TableReference);
			this.GenerateSpaceAndSymbol(TSqlTokenType.RightCurly);
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x0002CA98 File Offset: 0x0002AC98
		public override void ExplicitVisit(OffsetClause node)
		{
			AlignmentPoint ap = new AlignmentPoint();
			this.MarkAndPushAlignmentPoint(ap);
			this.GenerateIdentifier("OFFSET");
			this.GenerateSpaceAndFragmentIfNotNull(node.OffsetExpression);
			this.GenerateSpaceAndIdentifier("ROWS");
			if (node.FetchExpression != null)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.Fetch);
				this.GenerateSpaceAndIdentifier("NEXT");
				this.GenerateSpaceAndFragmentIfNotNull(node.FetchExpression);
				this.GenerateSpaceAndIdentifier("ROWS");
				this.GenerateSpaceAndIdentifier("ONLY");
			}
			this.PopAlignmentPoint();
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x0002CB17 File Offset: 0x0002AD17
		public override void ExplicitVisit(OnlineIndexLowPriorityLockWaitOption node)
		{
			this.GenerateLowPriorityWaitOptions(node.Options);
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x0002CB28 File Offset: 0x0002AD28
		public override void ExplicitVisit(OnlineIndexOption node)
		{
			IndexOptionHelper.Instance.GenerateSourceForOption(this._writer, node.OptionKind);
			this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
			this.GenerateSpace();
			this.GenerateOptionStateOnOff(node.OptionState);
			if (this._options.SqlVersion >= SqlVersion.Sql120 && node.OptionState == OptionState.On && node.LowPriorityLockWaitOption != null)
			{
				this.GenerateSpace();
				this.GenerateSymbol(TSqlTokenType.LeftParenthesis);
				this.GenerateFragmentIfNotNull(node.LowPriorityLockWaitOption);
				this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			}
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x0002CBB0 File Offset: 0x0002ADB0
		public override void ExplicitVisit(OnOffDatabaseOption node)
		{
			OnOffSimpleDbOptionsHelper.Instance.GenerateSourceForOption(this._writer, node.OptionKind);
			this.GenerateSpace();
			if (OnOffSimpleDbOptionsHelper.Instance.RequiresEqualsSign(node.OptionKind))
			{
				this.GenerateKeywordAndSpace(TSqlTokenType.EqualsSign);
			}
			this.GenerateOptionStateOnOff(node.OptionState);
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x0002CC02 File Offset: 0x0002AE02
		public override void ExplicitVisit(OpenCursorStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Open);
			this.GenerateSpaceAndFragmentIfNotNull(node.Cursor);
		}

		// Token: 0x06000EC8 RID: 3784 RVA: 0x0002CC18 File Offset: 0x0002AE18
		public override void ExplicitVisit(OpenMasterKeyStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Open);
			this.GenerateSpaceAndIdentifier("MASTER");
			this.GenerateSpaceAndKeyword(TSqlTokenType.Key);
			this.GenerateSpace();
			this.GenerateDecryptionByPassword(node.Password);
		}

		// Token: 0x06000EC9 RID: 3785 RVA: 0x0002CC48 File Offset: 0x0002AE48
		public override void ExplicitVisit(OpenQueryTableReference node)
		{
			this.GenerateKeyword(TSqlTokenType.OpenQuery);
			this.GenerateSpaceAndSymbol(TSqlTokenType.LeftParenthesis);
			this.GenerateFragmentIfNotNull(node.LinkedServer);
			this.GenerateSymbol(TSqlTokenType.Comma);
			this.GenerateSpaceAndFragmentIfNotNull(node.Query);
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			this.GenerateSpaceAndAlias(node.Alias);
		}

		// Token: 0x06000ECA RID: 3786 RVA: 0x0002CCA4 File Offset: 0x0002AEA4
		public override void ExplicitVisit(OpenRowsetTableReference node)
		{
			this.GenerateKeyword(TSqlTokenType.OpenRowSet);
			this.GenerateSpaceAndSymbol(TSqlTokenType.LeftParenthesis);
			this.GenerateFragmentIfNotNull(node.ProviderName);
			this.GenerateSymbol(TSqlTokenType.Comma);
			if (node.ProviderString != null)
			{
				this.GenerateSpaceAndFragmentIfNotNull(node.ProviderString);
			}
			else
			{
				this.GenerateSpaceAndFragmentIfNotNull(node.DataSource);
				this.GenerateSymbol(TSqlTokenType.Semicolon);
				this.GenerateSpaceAndFragmentIfNotNull(node.UserId);
				this.GenerateSymbol(TSqlTokenType.Semicolon);
				this.GenerateSpaceAndFragmentIfNotNull(node.Password);
			}
			this.GenerateSymbol(TSqlTokenType.Comma);
			if (node.Query != null)
			{
				this.GenerateSpaceAndFragmentIfNotNull(node.Query);
			}
			else
			{
				this.GenerateSpaceAndFragmentIfNotNull(node.Object);
			}
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			this.GenerateSpaceAndAlias(node.Alias);
		}

		// Token: 0x06000ECB RID: 3787 RVA: 0x0002CD70 File Offset: 0x0002AF70
		public override void ExplicitVisit(OpenSymmetricKeyStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Open);
			this.GenerateSpaceAndIdentifier("SYMMETRIC");
			this.GenerateSpaceAndKeyword(TSqlTokenType.Key);
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.GenerateSpaceAndIdentifier("DECRYPTION");
			this.GenerateSpaceAndKeyword(TSqlTokenType.By);
			this.GenerateSpaceAndFragmentIfNotNull(node.DecryptionMechanism);
		}

		// Token: 0x06000ECC RID: 3788 RVA: 0x0002CDC4 File Offset: 0x0002AFC4
		public override void ExplicitVisit(OpenXmlTableReference node)
		{
			this.GenerateKeyword(TSqlTokenType.OpenXml);
			this.GenerateSpaceAndSymbol(TSqlTokenType.LeftParenthesis);
			this.GenerateFragmentIfNotNull(node.Variable);
			this.GenerateSymbol(TSqlTokenType.Comma);
			this.GenerateSpaceAndFragmentIfNotNull(node.RowPattern);
			if (node.Flags != null)
			{
				this.GenerateSymbol(TSqlTokenType.Comma);
				this.GenerateSpaceAndFragmentIfNotNull(node.Flags);
			}
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			if (node.TableName != null)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.With);
				this.GenerateSpaceAndFragmentIfNotNull(node.TableName);
			}
			else if (node.SchemaDeclarationItems.Count > 0)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.With);
				this.GenerateSpace();
				this.GenerateParenthesisedCommaSeparatedList<SchemaDeclarationItem>(node.SchemaDeclarationItems);
			}
			this.GenerateSpaceAndAlias(node.Alias);
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x0002CE8C File Offset: 0x0002B08C
		public override void ExplicitVisit(LiteralOptimizerHint node)
		{
			if (node.HintKind == OptimizerHintKind.UsePlan)
			{
				if (node.Value != null && node.Value.LiteralType == LiteralType.Integer)
				{
					this.GenerateIdentifier("USEPLAN");
				}
				else
				{
					this.GenerateKeyword(TSqlTokenType.Use);
					this.GenerateSpaceAndKeyword(TSqlTokenType.Plan);
				}
			}
			else
			{
				List<TokenGenerator> valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<OptimizerHintKind, List<TokenGenerator>>(SqlScriptGeneratorVisitor._optimizerHintKindsGenerators, node.HintKind);
				if (valueForEnumKey != null)
				{
					this.GenerateTokenList(valueForEnumKey);
				}
			}
			this.GenerateSpaceAndFragmentIfNotNull(node.Value);
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x0002CF04 File Offset: 0x0002B104
		public override void ExplicitVisit(OptimizerHint node)
		{
			List<TokenGenerator> valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<OptimizerHintKind, List<TokenGenerator>>(SqlScriptGeneratorVisitor._optimizerHintKindsGenerators, node.HintKind);
			if (valueForEnumKey != null)
			{
				this.GenerateTokenList(valueForEnumKey);
			}
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x0002CF2C File Offset: 0x0002B12C
		protected void GenerateOptimizerHints(IList<OptimizerHint> hints)
		{
			if (hints != null && hints.Count > 0)
			{
				this.NewLine();
				AlignmentPoint ap = new AlignmentPoint();
				this.MarkAndPushAlignmentPoint(ap);
				this.GenerateKeywordAndSpace(TSqlTokenType.Option);
				this.GenerateParenthesisedCommaSeparatedList<OptimizerHint>(hints);
				this.PopAlignmentPoint();
			}
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x0002CF6D File Offset: 0x0002B16D
		public override void ExplicitVisit(OptimizeForOptimizerHint node)
		{
			this.GenerateIdentifier("OPTIMIZE");
			this.GenerateSpaceAndKeyword(TSqlTokenType.For);
			if (node.IsForUnknown)
			{
				this.GenerateSpaceAndIdentifier("UNKNOWN");
				return;
			}
			this.GenerateSpace();
			this.GenerateParenthesisedCommaSeparatedList<VariableValuePair>(node.Pairs);
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x0002CFA8 File Offset: 0x0002B1A8
		public override void ExplicitVisit(TableHintsOptimizerHint node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.Table);
			this.GenerateIdentifier("HINT");
			this.GenerateSymbol(TSqlTokenType.LeftParenthesis);
			this.GenerateFragmentIfNotNull(node.ObjectName);
			if (node.TableHints.Count > 0)
			{
				this.GenerateSymbolAndSpace(TSqlTokenType.Comma);
				this.GenerateCommaSeparatedList<TableHint>(node.TableHints);
			}
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x0002D012 File Offset: 0x0002B212
		public override void ExplicitVisit(VariableValuePair node)
		{
			this.GenerateFragmentIfNotNull(node.Variable);
			if (node.IsForUnknown)
			{
				this.GenerateSpaceAndIdentifier("UNKNOWN");
				return;
			}
			this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
			this.GenerateSpaceAndFragmentIfNotNull(node.Value);
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x0002D04B File Offset: 0x0002B24B
		public override void ExplicitVisit(OnOffOptionValue node)
		{
			if (node.OptionState == OptionState.On)
			{
				this.GenerateKeyword(TSqlTokenType.On);
				return;
			}
			if (node.OptionState == OptionState.Off)
			{
				this.GenerateKeyword(TSqlTokenType.Off);
			}
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x0002D070 File Offset: 0x0002B270
		public override void ExplicitVisit(LiteralOptionValue node)
		{
			this.GenerateFragmentIfNotNull(node.Value);
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x0002D080 File Offset: 0x0002B280
		public override void ExplicitVisit(OrderByClause node)
		{
			AlignmentPoint ap = new AlignmentPoint();
			this.MarkAndPushAlignmentPoint(ap);
			this.GenerateKeyword(TSqlTokenType.Order);
			this.GenerateSpaceAndKeyword(TSqlTokenType.By);
			AlignmentPoint alignmentPointForFragment = this.GetAlignmentPointForFragment(node, "ClauseBody");
			this.MarkClauseBodyAlignmentWhenNecessary(this._options.NewLineBeforeOrderByClause, alignmentPointForFragment);
			this.GenerateSpace();
			this.GenerateCommaSeparatedList<ExpressionWithSortOrder>(node.OrderByElements);
			this.PopAlignmentPoint();
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x0002D0E4 File Offset: 0x0002B2E4
		public override void ExplicitVisit(OutputClause node)
		{
			AlignmentPoint ap = new AlignmentPoint();
			this.MarkAndPushAlignmentPoint(ap);
			this.GenerateIdentifier("OUTPUT");
			AlignmentPoint alignmentPointForFragment = this.GetAlignmentPointForFragment(node, "ClauseBody");
			this.MarkClauseBodyAlignmentWhenNecessary(true, alignmentPointForFragment);
			this.GenerateSpace();
			this.GenerateCommaSeparatedList<SelectElement>(node.SelectColumns);
			this.PopAlignmentPoint();
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x0002D138 File Offset: 0x0002B338
		public override void ExplicitVisit(OutputIntoClause node)
		{
			AlignmentPoint ap = new AlignmentPoint();
			this.MarkAndPushAlignmentPoint(ap);
			this.GenerateIdentifier("OUTPUT");
			AlignmentPoint alignmentPointForFragment = this.GetAlignmentPointForFragment(node, "ClauseBody");
			this.MarkClauseBodyAlignmentWhenNecessary(true, alignmentPointForFragment);
			this.GenerateSpace();
			this.GenerateCommaSeparatedList<SelectElement>(node.SelectColumns);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Into);
			this.GenerateSpaceAndFragmentIfNotNull(node.IntoTable);
			if (node.IntoTableColumns.Count > 0)
			{
				this.GenerateSpace();
				this.GenerateParenthesisedCommaSeparatedList<ColumnReferenceExpression>(node.IntoTableColumns);
			}
			this.PopAlignmentPoint();
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x0002D1C0 File Offset: 0x0002B3C0
		public override void ExplicitVisit(OverClause node)
		{
			this.GenerateKeyword(TSqlTokenType.Over);
			this.GenerateSpaceAndSymbol(TSqlTokenType.LeftParenthesis);
			bool flag = node.Partitions.Count > 0;
			if (flag)
			{
				this.GenerateIdentifier("PARTITION");
				this.GenerateSpaceAndKeyword(TSqlTokenType.By);
				this.GenerateSpace();
				this.GenerateCommaSeparatedList<ScalarExpression>(node.Partitions);
			}
			if (node.OrderByClause != null)
			{
				if (flag)
				{
					this.GenerateSpace();
				}
				AlignmentPoint ap = new AlignmentPoint("ClauseBody");
				this.GenerateFragmentWithAlignmentPointIfNotNull(node.OrderByClause, ap);
				this.GenerateSpaceAndFragmentIfNotNull(node.WindowFrameClause);
			}
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x0002D258 File Offset: 0x0002B458
		public override void ExplicitVisit(PageVerifyDatabaseOption node)
		{
			this.GenerateIdentifier("PAGE_VERIFY");
			string valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<PageVerifyDatabaseOptionKind, string>(SqlScriptGeneratorVisitor._pageVerifyDatabaseOptionKindNames, node.Value);
			if (valueForEnumKey != null)
			{
				this.GenerateSpaceAndIdentifier(valueForEnumKey);
			}
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x0002D28B File Offset: 0x0002B48B
		public override void ExplicitVisit(ParameterizationDatabaseOption node)
		{
			this.GenerateIdentifier("PARAMETERIZATION");
			this.GenerateSpaceAndIdentifier(node.IsSimple ? "SIMPLE" : "FORCED");
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x0002D2B4 File Offset: 0x0002B4B4
		public override void ExplicitVisit(ParameterlessCall node)
		{
			TokenGenerator valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<ParameterlessCallType, TokenGenerator>(SqlScriptGeneratorVisitor._parameterlessCallTypeGenerators, node.ParameterlessCallType);
			if (valueForEnumKey != null)
			{
				this.GenerateToken(valueForEnumKey);
			}
			this.GenerateSpaceAndCollation(node.Collation);
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x0002D2E8 File Offset: 0x0002B4E8
		public override void ExplicitVisit(ParenthesisExpression node)
		{
			this.GenerateSymbol(TSqlTokenType.LeftParenthesis);
			this.GenerateFragmentIfNotNull(node.Expression);
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			this.GenerateSpaceAndCollation(node.Collation);
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x0002D318 File Offset: 0x0002B518
		public override void ExplicitVisit(ParseCall node)
		{
			this.GenerateIdentifier("PARSE");
			this.GenerateSpaceAndSymbol(TSqlTokenType.LeftParenthesis);
			this.GenerateFragmentIfNotNull(node.StringValue);
			this.GenerateSpaceAndKeyword(TSqlTokenType.As);
			this.GenerateSpaceAndFragmentIfNotNull(node.DataType);
			if (node.Culture != null)
			{
				this.GenerateSpace();
				this.GenerateIdentifier("USING");
				this.GenerateSpaceAndFragmentIfNotNull(node.Culture);
			}
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			this.GenerateSpaceAndCollation(node.Collation);
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x0002D398 File Offset: 0x0002B598
		public override void ExplicitVisit(PartitionFunctionCall node)
		{
			if (node.DatabaseName != null)
			{
				this.GenerateFragmentIfNotNull(node.DatabaseName);
				this.GenerateSymbol(TSqlTokenType.Dot);
			}
			this.GenerateIdentifier("$PARTITION");
			this.GenerateSymbol(TSqlTokenType.Dot);
			this.GenerateFragmentIfNotNull(node.FunctionName);
			this.GenerateSpace();
			this.GenerateParenthesisedCommaSeparatedList<ScalarExpression>(node.Parameters);
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x0002D3F8 File Offset: 0x0002B5F8
		public override void ExplicitVisit(PartitionSpecifier node)
		{
			this.GenerateIdentifier("PARTITION");
			this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
			this.GenerateSpace();
			if (node.All)
			{
				this.GenerateKeyword(TSqlTokenType.All);
				return;
			}
			this.GenerateFragmentIfNotNull(node.Number);
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x0002D434 File Offset: 0x0002B634
		public override void ExplicitVisit(PartnerDatabaseOption node)
		{
			this.GenerateIdentifier("PARTNER");
			this.GenerateSpace();
			if (node.PartnerServer != null)
			{
				this.GenerateSymbol(TSqlTokenType.EqualsSign);
				this.GenerateSpaceAndFragmentIfNotNull(node.PartnerServer);
			}
			else if (node.PartnerOption == PartnerDatabaseOptionKind.SafetyFull)
			{
				this.GenerateIdentifier("SAFETY");
				this.GenerateSpaceAndKeyword(TSqlTokenType.Full);
			}
			else if (node.PartnerOption == PartnerDatabaseOptionKind.SafetyOff)
			{
				this.GenerateIdentifier("SAFETY");
				this.GenerateSpaceAndKeyword(TSqlTokenType.Off);
			}
			else
			{
				PartnerDbOptionsHelper.Instance.GenerateSourceForOption(this._writer, node.PartnerOption);
			}
			if (node.PartnerOption == PartnerDatabaseOptionKind.Timeout && node.Timeout != null)
			{
				this.GenerateSpaceAndFragmentIfNotNull(node.Timeout);
			}
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x0002D4E4 File Offset: 0x0002B6E4
		public override void ExplicitVisit(PasswordAlterPrincipalOption node)
		{
			this.GenerateNameEqualsValue("PASSWORD", node.Password);
			if (node.OldPassword != null)
			{
				this.GenerateSpace();
				this.GenerateNameEqualsValue("OLD_PASSWORD", node.OldPassword);
				return;
			}
			if (node.MustChange)
			{
				this.GenerateSpaceAndIdentifier("MUST_CHANGE");
			}
			if (node.Hashed)
			{
				this.GenerateSpaceAndIdentifier("HASHED");
			}
			if (node.Unlock)
			{
				this.GenerateSpaceAndIdentifier("UNLOCK");
			}
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x0002D55C File Offset: 0x0002B75C
		public override void ExplicitVisit(PasswordCreateLoginSource node)
		{
			this.GenerateKeyword(TSqlTokenType.With);
			this.GenerateSpace();
			this.GenerateNameEqualsValue("PASSWORD", node.Password);
			if (node.Hashed)
			{
				this.GenerateSpaceAndIdentifier("HASHED");
			}
			if (node.MustChange)
			{
				this.GenerateSpaceAndIdentifier("MUST_CHANGE");
			}
			if (node.Options != null && node.Options.Count > 0)
			{
				this.GenerateSymbolAndSpace(TSqlTokenType.Comma);
				this.GenerateFragmentList<PrincipalOption>(node.Options);
			}
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x0002D5DE File Offset: 0x0002B7DE
		public override void ExplicitVisit(Permission node)
		{
			this.GenerateSpaceSeparatedList<Identifier>(node.Identifiers);
			if (node.Columns != null && node.Columns.Count > 0)
			{
				this.GenerateSpace();
				this.GenerateParenthesisedCommaSeparatedList<Identifier>(node.Columns);
			}
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x0002D614 File Offset: 0x0002B814
		public override void ExplicitVisit(PivotedTableReference node)
		{
			this.GenerateFragmentIfNotNull(node.TableReference);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Pivot);
			this.GenerateSpaceAndSymbol(TSqlTokenType.LeftParenthesis);
			this.GenerateFragmentIfNotNull(node.AggregateFunctionIdentifier);
			this.GenerateSpaceAndSymbol(TSqlTokenType.LeftParenthesis);
			this.GenerateCommaSeparatedList<ColumnReferenceExpression>(node.ValueColumns);
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			this.GenerateSpaceAndKeyword(TSqlTokenType.For);
			this.GenerateSpaceAndFragmentIfNotNull(node.PivotColumn);
			this.GenerateSpaceAndKeyword(TSqlTokenType.In);
			this.GenerateSpace();
			this.GenerateParenthesisedCommaSeparatedList<Identifier>(node.InColumns, true);
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			this.GenerateSpaceAndAlias(node.Alias);
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x0002D6B7 File Offset: 0x0002B8B7
		public override void ExplicitVisit(PortsEndpointProtocolOption node)
		{
			this.GenerateIdentifier("PORTS");
			this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
			this.GenerateSpaceAndSymbol(TSqlTokenType.LeftParenthesis);
			this.GenerateCommaSeparatedFlagOpitons<PortTypes>(SqlScriptGeneratorVisitor._portTypesGenerators, node.PortTypes);
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x0002D6F6 File Offset: 0x0002B8F6
		public override void ExplicitVisit(PredicateSetStatement node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.Set);
			this.GenerateCommaSeparatedFlagOpitons<SetOptions>(SqlScriptGeneratorVisitor._setOptionsGenerators, node.Options);
			this.GenerateSpaceAndKeyword(node.IsOn ? TSqlTokenType.On : TSqlTokenType.Off);
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x0002D728 File Offset: 0x0002B928
		public override void ExplicitVisit(PrintStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Print);
			this.GenerateSpaceAndFragmentIfNotNull(node.Expression);
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x0002D740 File Offset: 0x0002B940
		public override void ExplicitVisit(Privilege80 node)
		{
			TokenGenerator valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<PrivilegeType80, TokenGenerator>(SqlScriptGeneratorVisitor._privilegeType80Generators, node.PrivilegeType80);
			if (valueForEnumKey != null)
			{
				this.GenerateToken(valueForEnumKey);
			}
			if (node.Columns != null && node.Columns.Count > 0)
			{
				this.GenerateSpace();
				this.GenerateParenthesisedCommaSeparatedList<Identifier>(node.Columns);
			}
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x0002D790 File Offset: 0x0002B990
		public override void ExplicitVisit(PrivilegeSecurityElement80 node)
		{
			if (node.Privileges != null && node.Privileges.Count > 0)
			{
				this.GenerateCommaSeparatedList<Privilege80>(node.Privileges);
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.On);
				this.GenerateSpaceAndFragmentIfNotNull(node.SchemaObjectName);
				if (node.Columns != null && node.Columns.Count > 0)
				{
					this.GenerateSpace();
					this.GenerateParenthesisedCommaSeparatedList<Identifier>(node.Columns);
				}
			}
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x0002D804 File Offset: 0x0002BA04
		public override void ExplicitVisit(ProcedureParameter node)
		{
			this.GenerateFragmentIfNotNull(node.VariableName);
			this.GenerateSpaceAndFragmentIfNotNull(node.DataType);
			if (node.IsVarying)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.Varying);
			}
			this.GenerateSpaceAndFragmentIfNotNull(node.Nullable);
			if (node.Value != null)
			{
				this.GenerateSymbol(TSqlTokenType.EqualsSign);
				this.GenerateFragmentIfNotNull(node.Value);
			}
			switch (node.Modifier)
			{
			case ParameterModifier.None:
				break;
			case ParameterModifier.Output:
				this.GenerateSpaceAndIdentifier("OUTPUT");
				return;
			case ParameterModifier.ReadOnly:
				this.GenerateSpaceAndIdentifier("READONLY");
				break;
			default:
				return;
			}
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x0002D898 File Offset: 0x0002BA98
		public override void ExplicitVisit(ProcedureReference node)
		{
			this.GenerateFragmentIfNotNull(node.Name);
			if (node.Number != null)
			{
				this.GenerateToken(TSqlTokenType.ProcNameSemicolon, ";");
				this.GenerateFragmentIfNotNull(node.Number);
			}
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x0002D8CC File Offset: 0x0002BACC
		protected void GenerateProcedureStatementBody(ProcedureStatementBody node)
		{
			this.GenerateKeyword(TSqlTokenType.Procedure);
			this.GenerateSpaceAndFragmentIfNotNull(node.ProcedureReference);
			if (node.Parameters != null && node.Parameters.Count > 0)
			{
				this.NewLine();
				this.GenerateCommaSeparatedList<ProcedureParameter>(node.Parameters);
			}
			this.GenerateCommaSeparatedWithClause<ProcedureOption>(node.Options, false, false);
			if (node.IsForReplication)
			{
				this.NewLine();
				this.GenerateKeyword(TSqlTokenType.For);
				this.GenerateSpaceAndKeyword(TSqlTokenType.Replication);
			}
			this.NewLine();
			this.GenerateKeyword(TSqlTokenType.As);
			if (node.StatementList != null)
			{
				this.NewLine();
				this.GenerateFragmentIfNotNull(node.StatementList);
			}
			this.GenerateSpaceAndFragmentIfNotNull(node.MethodSpecifier);
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x0002D978 File Offset: 0x0002BB78
		public override void ExplicitVisit(ProcedureOption node)
		{
			switch (node.OptionKind)
			{
			case ProcedureOptionKind.Encryption:
				this.GenerateIdentifier("ENCRYPTION");
				return;
			case ProcedureOptionKind.Recompile:
				this.GenerateIdentifier("RECOMPILE");
				return;
			case ProcedureOptionKind.ExecuteAs:
				break;
			case ProcedureOptionKind.NativeCompilation:
				this.GenerateIdentifier("NATIVE_COMPILATION");
				return;
			case ProcedureOptionKind.SchemaBinding:
				this.GenerateIdentifier("SCHEMABINDING");
				break;
			default:
				return;
			}
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x0002D9D6 File Offset: 0x0002BBD6
		public override void ExplicitVisit(ExecuteAsProcedureOption node)
		{
			this.GenerateFragmentIfNotNull(node.ExecuteAs);
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x0002D9E4 File Offset: 0x0002BBE4
		public override void ExplicitVisit(QualifiedJoin node)
		{
			this.GenerateFragmentIfNotNull(node.FirstTableReference);
			this.GenerateNewLineOrSpace(this._options.NewLineBeforeJoinClause);
			this.GenerateQualifiedJoinType(node.QualifiedJoinType);
			if (node.JoinHint != JoinHint.None)
			{
				this.GenerateSpace();
				JoinHintHelper.Instance.GenerateSourceForOption(this._writer, node.JoinHint);
			}
			this.GenerateSpaceAndKeyword(TSqlTokenType.Join);
			this.NewLine();
			this.GenerateFragmentIfNotNull(node.SecondTableReference);
			this.NewLine();
			this.GenerateKeyword(TSqlTokenType.On);
			this.GenerateSpaceAndFragmentIfNotNull(node.SearchCondition);
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x0002DA74 File Offset: 0x0002BC74
		private void GenerateQualifiedJoinType(QualifiedJoinType qualifiedJoinType)
		{
			List<TokenGenerator> valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<QualifiedJoinType, List<TokenGenerator>>(SqlScriptGeneratorVisitor._qualifiedJoinTypeGenerators, qualifiedJoinType);
			if (valueForEnumKey != null)
			{
				this.GenerateTokenList(valueForEnumKey);
			}
		}

		// Token: 0x06000EF1 RID: 3825 RVA: 0x0002DA98 File Offset: 0x0002BC98
		public override void ExplicitVisit(QueryParenthesisExpression node)
		{
			AlignmentPoint alignmentPointForFragment = this.GetAlignmentPointForFragment(node, "ClauseBody");
			this.GenerateQueryParenthesisExpression(node, alignmentPointForFragment, null);
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x0002DABC File Offset: 0x0002BCBC
		public void GenerateQueryParenthesisExpression(QueryParenthesisExpression node, AlignmentPoint clauseBody, SchemaObjectName intoClause)
		{
			this.GenerateSymbol(TSqlTokenType.LeftParenthesis);
			this.GenerateQueryExpression(node.QueryExpression, clauseBody, intoClause);
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			if (node.OrderByClause != null)
			{
				this.GenerateSeparatorForOrderBy();
				this.GenerateFragmentWithAlignmentPointIfNotNull(node.OrderByClause, clauseBody);
			}
			if (node.OffsetClause != null)
			{
				this.GenerateSeparatorForOffsetClause();
				this.GenerateFragmentWithAlignmentPointIfNotNull(node.OffsetClause, clauseBody);
			}
			if (node.ForClause != null)
			{
				this.NewLine();
				this.GenerateKeyword(TSqlTokenType.For);
				this.MarkClauseBodyAlignmentWhenNecessary(true, clauseBody);
				this.GenerateSpace();
				AlignmentPoint ap = new AlignmentPoint();
				this.MarkAndPushAlignmentPoint(ap);
				this.GenerateFragmentIfNotNull(node.ForClause);
				this.PopAlignmentPoint();
			}
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x0002DB68 File Offset: 0x0002BD68
		public override void ExplicitVisit(QuerySpecification node)
		{
			AlignmentPoint alignmentPointForFragment = this.GetAlignmentPointForFragment(node, "ClauseBody");
			this.GenerateQuerySpecification(node, alignmentPointForFragment, null);
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x0002DB8C File Offset: 0x0002BD8C
		protected void GenerateQuerySpecification(QuerySpecification node, AlignmentPoint clauseBody, SchemaObjectName intoClause)
		{
			AlignmentPoint ap = new AlignmentPoint();
			this.MarkAndPushAlignmentPoint(ap);
			this.GenerateKeyword(TSqlTokenType.Select);
			this.MarkClauseBodyAlignmentWhenNecessary(true, clauseBody);
			this.GenerateUniqueRowFilter(node.UniqueRowFilter, true);
			this.GenerateSpaceAndFragmentIfNotNull(node.TopRowFilter);
			this.GenerateSpace();
			this.GenerateSelectElementsList(node.SelectElements);
			if (intoClause != null)
			{
				this.NewLine();
				this.GenerateKeyword(TSqlTokenType.Into);
				this.MarkClauseBodyAlignmentWhenNecessary(true, clauseBody);
				this.GenerateSpaceAndFragmentIfNotNull(intoClause);
			}
			this.GenerateFromClause(node.FromClause, clauseBody);
			if (node.WhereClause != null)
			{
				this.GenerateSeparatorForWhereClause();
				this.GenerateFragmentWithAlignmentPointIfNotNull(node.WhereClause, clauseBody);
			}
			if (node.GroupByClause != null)
			{
				this.GenerateSeparatorForGroupByClause();
				this.GenerateFragmentWithAlignmentPointIfNotNull(node.GroupByClause, clauseBody);
			}
			if (node.HavingClause != null)
			{
				this.GenerateSeparatorForHavingClause();
				this.GenerateFragmentWithAlignmentPointIfNotNull(node.HavingClause, clauseBody);
			}
			if (node.OrderByClause != null)
			{
				this.GenerateSeparatorForOrderBy();
				this.GenerateFragmentWithAlignmentPointIfNotNull(node.OrderByClause, clauseBody);
			}
			if (node.OffsetClause != null)
			{
				this.GenerateSeparatorForOffsetClause();
				this.GenerateFragmentWithAlignmentPointIfNotNull(node.OffsetClause, clauseBody);
			}
			if (node.ForClause != null)
			{
				this.NewLine();
				this.GenerateKeyword(TSqlTokenType.For);
				this.MarkClauseBodyAlignmentWhenNecessary(true, clauseBody);
				this.GenerateSpace();
				AlignmentPoint ap2 = new AlignmentPoint();
				this.MarkAndPushAlignmentPoint(ap2);
				this.GenerateFragmentIfNotNull(node.ForClause);
				this.PopAlignmentPoint();
			}
			this.PopAlignmentPoint();
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x0002DCE4 File Offset: 0x0002BEE4
		public override void ExplicitVisit(QueueStateOption node)
		{
			if (node.OptionKind == QueueOptionKind.PoisonMessageHandlingStatus)
			{
				this.GenerateIdentifier("POISON_MESSAGE_HANDLING");
				this.GenerateSymbol(TSqlTokenType.LeftParenthesis);
				this.GenerateOptionStateWithEqualSign("STATUS", node.OptionState);
				this.GenerateSymbol(TSqlTokenType.RightParenthesis);
				return;
			}
			string valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<QueueOptionKind, string>(SqlScriptGeneratorVisitor._queueOptionTypeNames, node.OptionKind);
			if (valueForEnumKey != null)
			{
				this.GenerateOptionStateWithEqualSign(valueForEnumKey, node.OptionState);
			}
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x0002DD50 File Offset: 0x0002BF50
		protected void GenerateQueueOptions(IList<QueueOption> queueOptions)
		{
			List<QueueOption> list = new List<QueueOption>();
			List<QueueOption> list2 = new List<QueueOption>();
			foreach (QueueOption queueOption in queueOptions)
			{
				switch (queueOption.OptionKind)
				{
				case QueueOptionKind.Status:
				case QueueOptionKind.Retention:
				case QueueOptionKind.PoisonMessageHandlingStatus:
					list.Add(queueOption);
					break;
				case QueueOptionKind.ActivationStatus:
				case QueueOptionKind.ActivationProcedureName:
				case QueueOptionKind.ActivationMaxQueueReaders:
				case QueueOptionKind.ActivationExecuteAs:
				case QueueOptionKind.ActivationDrop:
					list2.Add(queueOption);
					break;
				}
			}
			this.GenerateCommaSeparatedList<QueueOption>(list);
			if (list.Count > 0 && list2.Count > 0)
			{
				this.GenerateSymbolAndSpace(TSqlTokenType.Comma);
			}
			if (list2.Count > 0)
			{
				this.GenerateIdentifier("ACTIVATION");
				this.GenerateSpace();
				this.GenerateParenthesisedCommaSeparatedList<QueueOption>(list2);
			}
		}

		// Token: 0x06000EF7 RID: 3831 RVA: 0x0002DE24 File Offset: 0x0002C024
		public override void ExplicitVisit(QueueOption node)
		{
			if (node.OptionKind == QueueOptionKind.ActivationDrop)
			{
				this.GenerateKeyword(TSqlTokenType.Drop);
			}
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x0002DE38 File Offset: 0x0002C038
		public override void ExplicitVisit(QueueProcedureOption node)
		{
			string valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<QueueOptionKind, string>(SqlScriptGeneratorVisitor._queueOptionTypeNames, node.OptionKind);
			if (valueForEnumKey != null)
			{
				this.GenerateNameEqualsValue(valueForEnumKey, node.OptionValue);
			}
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x0002DE68 File Offset: 0x0002C068
		public override void ExplicitVisit(QueueValueOption node)
		{
			string valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<QueueOptionKind, string>(SqlScriptGeneratorVisitor._queueOptionTypeNames, node.OptionKind);
			if (valueForEnumKey != null)
			{
				this.GenerateNameEqualsValue(valueForEnumKey, node.OptionValue);
			}
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x0002DE96 File Offset: 0x0002C096
		public override void ExplicitVisit(QueueExecuteAsOption node)
		{
			this.GenerateFragmentIfNotNull(node.OptionValue);
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x0002DEA4 File Offset: 0x0002C0A4
		public override void ExplicitVisit(RaiseErrorLegacyStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Raiserror);
			this.GenerateSpaceAndFragmentIfNotNull(node.FirstParameter);
			this.GenerateSpaceAndFragmentIfNotNull(node.SecondParameter);
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x0002DEC8 File Offset: 0x0002C0C8
		public override void ExplicitVisit(RaiseErrorStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Raiserror);
			this.GenerateSpace();
			this.GenerateSymbol(TSqlTokenType.LeftParenthesis);
			this.GenerateFragmentIfNotNull(node.FirstParameter);
			this.GenerateSymbol(TSqlTokenType.Comma);
			this.GenerateSpaceAndFragmentIfNotNull(node.SecondParameter);
			this.GenerateSymbol(TSqlTokenType.Comma);
			this.GenerateSpaceAndFragmentIfNotNull(node.ThirdParameter);
			if (node.OptionalParameters.Count > 0)
			{
				this.GenerateSymbolAndSpace(TSqlTokenType.Comma);
				this.GenerateCommaSeparatedList<ScalarExpression>(node.OptionalParameters);
			}
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			if (node.RaiseErrorOptions != RaiseErrorOptions.None)
			{
				this.NewLineAndIndent();
				this.GenerateKeywordAndSpace(TSqlTokenType.With);
				this.GenerateCommaSeparatedFlagOpitons<RaiseErrorOptions>(SqlScriptGeneratorVisitor._raiseErrorOptionsGenerators, node.RaiseErrorOptions);
			}
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x0002DF82 File Offset: 0x0002C182
		public override void ExplicitVisit(ReadOnlyForClause node)
		{
			this.GenerateKeyword(TSqlTokenType.Read);
			this.GenerateSpaceAndIdentifier("ONLY");
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x0002DF98 File Offset: 0x0002C198
		public override void ExplicitVisit(ReadTextStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.ReadText);
			this.GenerateSpaceAndFragmentIfNotNull(node.Column);
			this.GenerateSpaceAndFragmentIfNotNull(node.TextPointer);
			this.GenerateSpaceAndFragmentIfNotNull(node.Offset);
			this.GenerateSpaceAndFragmentIfNotNull(node.Size);
			if (node.HoldLock)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.HoldLock);
			}
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x0002DFF0 File Offset: 0x0002C1F0
		public override void ExplicitVisit(ReceiveStatement node)
		{
			this.GenerateIdentifier("RECEIVE");
			if (node.Top != null)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.Top);
				this.GenerateSpace();
				this.GenerateParenthesisedFragmentIfNotNull(node.Top);
			}
			this.GenerateSpace();
			this.GenerateCommaSeparatedList<SelectElement>(node.SelectElements);
			this.GenerateSpaceAndKeyword(TSqlTokenType.From);
			this.GenerateSpaceAndFragmentIfNotNull(node.Queue);
			if (node.Into != null)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.Into);
				this.GenerateSpaceAndFragmentIfNotNull(node.Into);
			}
			if (node.Where != null)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.Where);
				this.GenerateSpace();
				this.GenerateNameEqualsValue(node.IsConversationGroupIdWhere ? "CONVERSATION_GROUP_ID" : "CONVERSATION_HANDLE", node.Where);
			}
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x0002E0A8 File Offset: 0x0002C2A8
		public override void ExplicitVisit(ReconfigureStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Reconfigure);
			if (node.WithOverride)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.With);
				this.GenerateSpaceAndIdentifier("OVERRIDE");
			}
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x0002E0D8 File Offset: 0x0002C2D8
		public override void ExplicitVisit(RecoveryDatabaseOption node)
		{
			this.GenerateIdentifier("RECOVERY");
			this.GenerateSpace();
			TokenGenerator valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<RecoveryDatabaseOptionKind, TokenGenerator>(SqlScriptGeneratorVisitor._recoveryDatabaseOptionKindNames, node.Value);
			if (valueForEnumKey != null)
			{
				this.GenerateToken(valueForEnumKey);
			}
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x0002E111 File Offset: 0x0002C311
		protected void GenerateBindingOptions(IList<RemoteServiceBindingOption> options)
		{
			if (options != null && options.Count > 0)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.With);
				this.GenerateSpace();
				this.GenerateCommaSeparatedList<RemoteServiceBindingOption>(options);
			}
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x0002E13D File Offset: 0x0002C33D
		public override void ExplicitVisit(UserRemoteServiceBindingOption node)
		{
			if (node.User != null)
			{
				this.GenerateNameEqualsValue(TSqlTokenType.User, node.User);
			}
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x0002E158 File Offset: 0x0002C358
		public override void ExplicitVisit(OnOffRemoteServiceBindingOption node)
		{
			this.GenerateOptionStateWithEqualSign("ANONYMOUS", node.OptionState);
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x0002E16C File Offset: 0x0002C36C
		public override void ExplicitVisit(ResourcePoolParameter node)
		{
			ResourcePoolParameterHelper.Instance.GenerateSourceForOption(this._writer, node.ParameterType);
			if (node.ParameterType != ResourcePoolParameterType.Affinity)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.EqualsSign);
				this.GenerateSpaceAndFragmentIfNotNull(node.ParameterValue);
				return;
			}
			this.GenerateSpaceAndFragmentIfNotNull(node.AffinitySpecification);
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x0002E1C0 File Offset: 0x0002C3C0
		public override void ExplicitVisit(ResourcePoolAffinitySpecification node)
		{
			ResourcePoolAffinityHelper.Instance.GenerateSourceForOption(this._writer, node.AffinityType);
			this.GenerateSpaceAndKeyword(TSqlTokenType.EqualsSign);
			this.GenerateSpace();
			if (node.IsAuto)
			{
				this.GenerateIdentifier("AUTO");
				return;
			}
			if (node.PoolAffinityRanges != null && node.PoolAffinityRanges.Count > 0)
			{
				this.GenerateParenthesisedCommaSeparatedList<LiteralRange>(node.PoolAffinityRanges);
			}
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x0002E22A File Offset: 0x0002C42A
		public override void ExplicitVisit(LiteralRange node)
		{
			this.GenerateFragmentIfNotNull(node.From);
			if (node.To != null)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.To);
				this.GenerateSpaceAndFragmentIfNotNull(node.To);
			}
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x0002E258 File Offset: 0x0002C458
		protected void GenerateResourcePoolStatementBody(ResourcePoolStatement node)
		{
			AlignmentPoint ap = new AlignmentPoint();
			this.GenerateIdentifier("RESOURCE");
			this.GenerateSpaceAndIdentifier("POOL");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			if (node.ResourcePoolParameters != null && node.ResourcePoolParameters.Count > 0)
			{
				this.NewLineAndIndent();
				this.MarkAndPushAlignmentPoint(ap);
				this.GenerateKeyword(TSqlTokenType.With);
				this.GenerateSpace();
				this.GenerateAlignedParenthesizedOptionsWithMultipleIndent<ResourcePoolParameter>(node.ResourcePoolParameters, 2);
				this.PopAlignmentPoint();
			}
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x0002E2D4 File Offset: 0x0002C4D4
		public override void ExplicitVisit(RestoreMasterKeyStatement node)
		{
			this.GenerateCommonRestorePart(node, false);
			this.GenerateSpace();
			this.GenerateEncryptionByPassword(node.EncryptionPassword);
			if (node.IsForce)
			{
				this.GenerateSpaceAndIdentifier("FORCE");
			}
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x0002E304 File Offset: 0x0002C504
		public override void ExplicitVisit(RestoreOption node)
		{
			TokenGenerator valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<RestoreOptionKind, TokenGenerator>(SqlScriptGeneratorVisitor._restoreOptionKindGenerators, node.OptionKind);
			if (valueForEnumKey == null)
			{
				return;
			}
			this.GenerateToken(valueForEnumKey);
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x0002E330 File Offset: 0x0002C530
		public override void ExplicitVisit(ScalarExpressionRestoreOption node)
		{
			TokenGenerator valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<RestoreOptionKind, TokenGenerator>(SqlScriptGeneratorVisitor._restoreOptionKindGenerators, node.OptionKind);
			if (valueForEnumKey == null)
			{
				return;
			}
			if (node.Value != null)
			{
				this.GenerateNameEqualsValue(valueForEnumKey, node.Value);
			}
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x0002E367 File Offset: 0x0002C567
		public override void ExplicitVisit(RestoreServiceMasterKeyStatement node)
		{
			this.GenerateCommonRestorePart(node, true);
			if (node.IsForce)
			{
				this.GenerateSpaceAndIdentifier("FORCE");
			}
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x0002E384 File Offset: 0x0002C584
		public override void ExplicitVisit(RestoreStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Restore);
			if (node.Kind == RestoreStatementKind.TransactionLog)
			{
				this.GenerateSpaceAndIdentifier("LOG");
				this.GenerateSpaceAndFragmentIfNotNull(node.DatabaseName);
			}
			else if (node.Kind == RestoreStatementKind.Database)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.Database);
				this.GenerateSpaceAndFragmentIfNotNull(node.DatabaseName);
			}
			else
			{
				TokenGenerator valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<RestoreStatementKind, TokenGenerator>(SqlScriptGeneratorVisitor._restoreStatementKindGenerators, node.Kind);
				if (valueForEnumKey != null)
				{
					this.GenerateSpace();
					this.GenerateToken(valueForEnumKey);
				}
			}
			if (node.Files.Count > 0)
			{
				this.GenerateSpace();
				this.GenerateCommaSeparatedList<BackupRestoreFileInfo>(node.Files);
			}
			if (node.Devices.Count > 0)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.From);
				this.GenerateSpace();
				this.GenerateCommaSeparatedList<DeviceInfo>(node.Devices);
			}
			if (node.Options.Count > 0)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.With);
				this.GenerateSpace();
				this.GenerateCommaSeparatedList<RestoreOption>(node.Options);
			}
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x0002E478 File Offset: 0x0002C678
		public override void ExplicitVisit(ResultSetsExecuteOption node)
		{
			this.GenerateIdentifier("RESULT");
			this.GenerateSpaceAndIdentifier("SETS");
			switch (node.ResultSetsOptionKind)
			{
			case ResultSetsOptionKind.Undefined:
				this.GenerateSpaceAndIdentifier("UNDEFINED");
				return;
			case ResultSetsOptionKind.None:
				this.GenerateSpaceAndIdentifier("NONE");
				return;
			case ResultSetsOptionKind.ResultSetsDefined:
				this.GenerateAlignedParenthesizedOptionsWithMultipleIndent<ResultSetDefinition>(node.Definitions, 2);
				return;
			default:
				return;
			}
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x0002E4DA File Offset: 0x0002C6DA
		public override void ExplicitVisit(ResultSetDefinition node)
		{
			this.GenerateSpaceAndKeyword(TSqlTokenType.As);
			this.GenerateSpaceAndKeyword(TSqlTokenType.For);
			this.GenerateSpaceAndIdentifier("XML");
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x0002E4F8 File Offset: 0x0002C6F8
		public override void ExplicitVisit(SchemaObjectResultSetDefinition node)
		{
			this.GenerateSpaceAndKeyword(TSqlTokenType.As);
			switch (node.ResultSetType)
			{
			case ResultSetType.Object:
				this.GenerateSpaceAndIdentifier("OBJECT");
				break;
			case ResultSetType.Type:
				this.GenerateSpaceAndIdentifier("TYPE");
				break;
			}
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x0002E54A File Offset: 0x0002C74A
		public override void ExplicitVisit(InlineResultSetDefinition node)
		{
			this.GenerateParenthesisedCommaSeparatedList<ResultColumnDefinition>(node.ResultColumnDefinitions);
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x0002E558 File Offset: 0x0002C758
		public override void ExplicitVisit(ResultColumnDefinition node)
		{
			this.GenerateFragmentIfNotNull(node.ColumnDefinition);
			this.GenerateSpaceAndFragmentIfNotNull(node.Nullable);
		}

		// Token: 0x06000F13 RID: 3859 RVA: 0x0002E572 File Offset: 0x0002C772
		public override void ExplicitVisit(ReturnStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Return);
			if (node.Expression != null)
			{
				this.GenerateSpaceAndFragmentIfNotNull(node.Expression);
			}
		}

		// Token: 0x06000F14 RID: 3860 RVA: 0x0002E593 File Offset: 0x0002C793
		public override void ExplicitVisit(RevertStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Revert);
			if (node.Cookie != null)
			{
				this.NewLineAndIndent();
				this.GenerateKeywordAndSpace(TSqlTokenType.With);
				this.GenerateNameEqualsValue("COOKIE", node.Cookie);
			}
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x0002E5CC File Offset: 0x0002C7CC
		public override void ExplicitVisit(RevokeStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Revoke);
			if (node.GrantOptionFor)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.Grant);
				this.GenerateSpaceAndKeyword(TSqlTokenType.Option);
				this.GenerateSpaceAndKeyword(TSqlTokenType.For);
			}
			this.GenerateSpace();
			this.GeneratePermissionOnToClauses(node);
			if (node.CascadeOption)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.Cascade);
			}
			this.GenerateAsClause(node);
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x0002E628 File Offset: 0x0002C828
		public override void ExplicitVisit(RevokeStatement80 node)
		{
			this.GenerateKeyword(TSqlTokenType.Revoke);
			if (node.GrantOptionFor)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.Grant);
				this.GenerateSpaceAndKeyword(TSqlTokenType.Option);
				this.GenerateSpaceAndKeyword(TSqlTokenType.For);
			}
			this.GenerateSpaceAndFragmentIfNotNull(node.SecurityElement80);
			this.GenerateSpaceAndKeyword(TSqlTokenType.From);
			this.GenerateSpaceAndFragmentIfNotNull(node.SecurityUserClause80);
			if (node.CascadeOption)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.Cascade);
			}
			if (node.AsClause != null)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.As);
				this.GenerateSpaceAndFragmentIfNotNull(node.AsClause);
			}
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x0002E6AC File Offset: 0x0002C8AC
		public override void ExplicitVisit(RolePayloadOption node)
		{
			this.GenerateTokenAndEqualSign("ROLE");
			TokenGenerator valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<DatabaseMirroringEndpointRole, TokenGenerator>(SqlScriptGeneratorVisitor._databaseMirroringEndpointRoleGenerators, node.Role);
			if (valueForEnumKey != null)
			{
				this.GenerateSpace();
				this.GenerateToken(valueForEnumKey);
			}
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x0002E6E5 File Offset: 0x0002C8E5
		public override void ExplicitVisit(RollbackTransactionStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Rollback);
			if (node.Name != null)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.Transaction);
				this.GenerateSpace();
				this.GenerateTransactionName(node.Name);
			}
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x0002E718 File Offset: 0x0002C918
		public override void ExplicitVisit(RouteOption node)
		{
			string valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<RouteOptionKind, string>(SqlScriptGeneratorVisitor._RouteOptionTypeNames, node.OptionKind);
			this.GenerateNameEqualsValue(valueForEnumKey, node.Literal);
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x0002E743 File Offset: 0x0002C943
		protected void GenerateRouteOptions(RouteStatement node)
		{
			this.NewLineAndIndent();
			this.GenerateKeyword(TSqlTokenType.With);
			this.GenerateSpace();
			this.GenerateCommaSeparatedList<RouteOption>(node.RouteOptions);
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x0002E768 File Offset: 0x0002C968
		public override void ExplicitVisit(SaveTransactionStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Save);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Transaction);
			this.GenerateSpace();
			this.GenerateTransactionName(node.Name);
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x0002E792 File Offset: 0x0002C992
		public override void ExplicitVisit(ScalarFunctionReturnType node)
		{
			this.GenerateFragmentIfNotNull(node.DataType);
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x0002E7A0 File Offset: 0x0002C9A0
		public override void ExplicitVisit(ScalarSubquery node)
		{
			this.GenerateQueryExpressionInParentheses(node.QueryExpression);
			this.GenerateSpaceAndCollation(node.Collation);
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x0002E7BA File Offset: 0x0002C9BA
		public override void ExplicitVisit(SchemaDeclarationItem node)
		{
			this.GenerateFragmentIfNotNull(node.ColumnDefinition);
			this.GenerateSpaceAndFragmentIfNotNull(node.Mapping);
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x0002E7D4 File Offset: 0x0002C9D4
		public override void ExplicitVisit(SchemaObjectName node)
		{
			this.GenerateDotSeparatedList<Identifier>(node.Identifiers);
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x0002E7E2 File Offset: 0x0002C9E2
		public override void ExplicitVisit(SchemaPayloadOption node)
		{
			this.GenerateNameEqualsValue(TSqlTokenType.Schema, node.IsStandard ? "STANDARD" : "NONE");
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x0002E804 File Offset: 0x0002CA04
		public override void ExplicitVisit(AddSearchPropertyListAction node)
		{
			this.GenerateKeyword(TSqlTokenType.Add);
			this.GenerateSpaceAndFragmentIfNotNull(node.PropertyName);
			this.GenerateSpaceAndKeyword(TSqlTokenType.With);
			this.GenerateSpaceAndKeyword(TSqlTokenType.LeftParenthesis);
			this.GenerateSpaceAndIdentifier("PROPERTY_SET_GUID");
			this.GenerateSpaceAndKeyword(TSqlTokenType.EqualsSign);
			this.GenerateSpaceAndFragmentIfNotNull(node.Guid);
			this.GenerateKeyword(TSqlTokenType.Comma);
			this.GenerateSpaceAndIdentifier("PROPERTY_INT_ID");
			this.GenerateSpaceAndKeyword(TSqlTokenType.EqualsSign);
			this.GenerateSpaceAndFragmentIfNotNull(node.Id);
			if (node.Description != null)
			{
				this.GenerateKeyword(TSqlTokenType.Comma);
				this.GenerateSpaceAndIdentifier("PROPERTY_DESCRIPTION");
				this.GenerateSpaceAndKeyword(TSqlTokenType.EqualsSign);
				this.GenerateSpaceAndFragmentIfNotNull(node.Description);
			}
			this.GenerateSpaceAndKeyword(TSqlTokenType.RightParenthesis);
		}

		// Token: 0x06000F22 RID: 3874 RVA: 0x0002E8C9 File Offset: 0x0002CAC9
		public override void ExplicitVisit(DropSearchPropertyListAction node)
		{
			this.GenerateKeyword(TSqlTokenType.Drop);
			this.GenerateSpaceAndFragmentIfNotNull(node.PropertyName);
		}

		// Token: 0x06000F23 RID: 3875 RVA: 0x0002E8E0 File Offset: 0x0002CAE0
		public override void ExplicitVisit(OnOffPrincipalOption node)
		{
			string optionName = string.Empty;
			switch (node.OptionKind)
			{
			case PrincipalOptionKind.CheckExpiration:
				optionName = "CHECK_EXPIRATION";
				break;
			case PrincipalOptionKind.CheckPolicy:
				optionName = "CHECK_POLICY";
				break;
			}
			this.GenerateOptionStateWithEqualSign(optionName, node.OptionState);
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x0002E928 File Offset: 0x0002CB28
		public override void ExplicitVisit(SecurityPrincipal node)
		{
			switch (node.PrincipalType)
			{
			case PrincipalType.Null:
				this.GenerateKeyword(TSqlTokenType.Null);
				return;
			case PrincipalType.Public:
				this.GenerateKeyword(TSqlTokenType.Public);
				return;
			case PrincipalType.Identifier:
				this.GenerateFragmentIfNotNull(node.Identifier);
				return;
			default:
				return;
			}
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x0002E970 File Offset: 0x0002CB70
		protected void GeneratePermissionOnToClauses(SecurityStatement node)
		{
			this.GenerateCommaSeparatedList<Permission>(node.Permissions);
			if (node.SecurityTargetObject != null)
			{
				this.NewLineAndIndent();
				this.GenerateFragmentIfNotNull(node.SecurityTargetObject);
			}
			this.GenerateSpaceAndKeyword(TSqlTokenType.To);
			this.GenerateSpace();
			this.GenerateCommaSeparatedList<SecurityPrincipal>(node.Principals);
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x0002E9C0 File Offset: 0x0002CBC0
		protected void GenerateAsClause(SecurityStatement node)
		{
			if (node.AsClause != null)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.As);
				this.GenerateSpaceAndFragmentIfNotNull(node.AsClause);
			}
		}

		// Token: 0x06000F27 RID: 3879 RVA: 0x0002E9E4 File Offset: 0x0002CBE4
		public override void ExplicitVisit(SecurityTargetObject node)
		{
			this.GenerateKeyword(TSqlTokenType.On);
			this.GenerateSpace();
			if (node.ObjectKind != SecurityObjectKind.NotSpecified)
			{
				this.GenerateSourceForSecurityObjectKind(node.ObjectKind);
			}
			this.GenerateFragmentIfNotNull(node.ObjectName);
			if (node.Columns != null && node.Columns.Count > 0)
			{
				this.GenerateSpace();
				this.GenerateParenthesisedCommaSeparatedList<Identifier>(node.Columns);
			}
		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x0002EA48 File Offset: 0x0002CC48
		protected void GenerateSourceForSecurityObjectKind(SecurityObjectKind type)
		{
			List<TokenGenerator> valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<SecurityObjectKind, List<TokenGenerator>>(SqlScriptGeneratorVisitor._securityObjectKindGenerators, type);
			if (valueForEnumKey != null)
			{
				this.GenerateTokenList(valueForEnumKey);
			}
			this.GenerateSymbol(TSqlTokenType.DoubleColon);
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x0002EA76 File Offset: 0x0002CC76
		public override void ExplicitVisit(SecurityTargetObjectName node)
		{
			this.GenerateFragmentIfNotNull(node.MultiPartIdentifier);
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x0002EA84 File Offset: 0x0002CC84
		public override void ExplicitVisit(SecurityUserClause80 node)
		{
			switch (node.UserType80)
			{
			case UserType80.Null:
				this.GenerateKeyword(TSqlTokenType.Null);
				return;
			case UserType80.Public:
				this.GenerateKeyword(TSqlTokenType.Public);
				return;
			case UserType80.Users:
				if (node.Users != null && node.Users.Count > 0)
				{
					this.GenerateCommaSeparatedList<Identifier>(node.Users);
				}
				return;
			default:
				return;
			}
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x0002EADF File Offset: 0x0002CCDF
		public override void ExplicitVisit(SelectFunctionReturnType node)
		{
			if (node.SelectStatement != null)
			{
				this.NewLineAndIndent();
				this.GenerateFragmentIfNotNull(node.SelectStatement);
				this.NewLine();
			}
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x0002EB04 File Offset: 0x0002CD04
		public override void ExplicitVisit(SelectInsertSource node)
		{
			AlignmentPoint ap = new AlignmentPoint("ClauseBody");
			this.GenerateFragmentWithAlignmentPointIfNotNull(node.Select, ap);
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x0002EB2C File Offset: 0x0002CD2C
		public override void ExplicitVisit(SelectiveXmlIndexPromotedPath node)
		{
			this.GenerateNameEqualsValue(node.Name.Value, node.Path);
			if (node.XQueryDataType != null || node.MaxLength != null || node.IsSingleton || node.SQLDataType != null)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.As);
				if ((node.XQueryDataType != null || node.MaxLength != null || node.IsSingleton) && node.SQLDataType == null)
				{
					this.GenerateSpaceAndIdentifier("XQUERY");
					this.GenerateSpaceAndFragmentIfNotNull(node.XQueryDataType);
					if (node.MaxLength != null)
					{
						this.GenerateSpaceAndIdentifier("MAXLENGTH");
						this.GenerateKeyword(TSqlTokenType.LeftParenthesis);
						this.GenerateFragmentIfNotNull(node.MaxLength);
						this.GenerateKeyword(TSqlTokenType.RightParenthesis);
					}
				}
				else if (node.SQLDataType != null)
				{
					this.GenerateSpaceAndIdentifier("SQL");
					this.GenerateSpaceAndFragmentIfNotNull(node.SQLDataType);
				}
				if (node.IsSingleton)
				{
					this.GenerateSpaceAndIdentifier("SINGLETON");
				}
			}
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x0002EC1B File Offset: 0x0002CE1B
		public override void ExplicitVisit(SelectScalarExpression node)
		{
			this.GenerateFragmentIfNotNull(node.Expression);
			if (node.ColumnName != null)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.As);
				this.GenerateSpaceAndFragmentIfNotNull(node.ColumnName);
			}
		}

		// Token: 0x06000F2F RID: 3887 RVA: 0x0002EC48 File Offset: 0x0002CE48
		public override void ExplicitVisit(SelectSetVariable node)
		{
			this.GenerateFragmentIfNotNull(node.Variable);
			TSqlTokenType valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<AssignmentKind, TSqlTokenType>(SqlScriptGeneratorVisitor._assignmentKindSymbols, node.AssignmentKind);
			this.GenerateSpaceAndSymbol(valueForEnumKey);
			this.GenerateSpaceAndFragmentIfNotNull(node.Expression);
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x0002EC85 File Offset: 0x0002CE85
		public override void ExplicitVisit(SelectStarExpression node)
		{
			this.GenerateFragmentIfNotNull(node.Qualifier);
			if (node.Qualifier != null && node.Qualifier.Count > 0)
			{
				this.GenerateSymbol(TSqlTokenType.Dot);
			}
			this.GenerateSymbol(TSqlTokenType.Star);
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x0002ECC0 File Offset: 0x0002CEC0
		public override void ExplicitVisit(SelectStatement node)
		{
			AlignmentPoint ap = new AlignmentPoint();
			AlignmentPoint alignmentPoint = new AlignmentPoint("ClauseBody");
			this.MarkAndPushAlignmentPoint(ap);
			if (node.WithCtesAndXmlNamespaces != null)
			{
				this.GenerateFragmentWithAlignmentPointIfNotNull(node.WithCtesAndXmlNamespaces, alignmentPoint);
				this.NewLine();
			}
			this.GenerateQueryExpression(node.QueryExpression, alignmentPoint, node.Into);
			foreach (ComputeClause node2 in node.ComputeClauses)
			{
				this.NewLine();
				this.GenerateFragmentWithAlignmentPointIfNotNull(node2, alignmentPoint);
			}
			this.GenerateOptimizerHints(node.OptimizerHints);
			this.PopAlignmentPoint();
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x0002ED6C File Offset: 0x0002CF6C
		private void GenerateQueryExpression(QueryExpression queryExpression, AlignmentPoint clauseBody, SchemaObjectName intoClause)
		{
			QuerySpecification querySpecification = queryExpression as QuerySpecification;
			if (querySpecification != null)
			{
				this.GenerateQuerySpecification(querySpecification, clauseBody, intoClause);
				return;
			}
			BinaryQueryExpression binaryQueryExpression = queryExpression as BinaryQueryExpression;
			if (binaryQueryExpression != null)
			{
				this.GenerateBinaryQueryExpression(binaryQueryExpression, clauseBody, intoClause);
				return;
			}
			QueryParenthesisExpression queryParenthesisExpression = queryExpression as QueryParenthesisExpression;
			if (queryParenthesisExpression != null)
			{
				this.GenerateQueryParenthesisExpression(queryParenthesisExpression, clauseBody, intoClause);
			}
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x0002EDB4 File Offset: 0x0002CFB4
		public override void ExplicitVisit(SemanticTableReference node)
		{
			AlignmentPoint ap = new AlignmentPoint();
			this.MarkAndPushAlignmentPoint(ap);
			switch (node.SemanticFunctionType)
			{
			case SemanticFunctionType.SemanticKeyPhraseTable:
				this.GenerateKeyword(TSqlTokenType.SemanticKeyPhraseTable);
				break;
			case SemanticFunctionType.SemanticSimilarityTable:
				this.GenerateKeyword(TSqlTokenType.SemanticSimilarityTable);
				break;
			case SemanticFunctionType.SemanticSimilarityDetailsTable:
				this.GenerateKeyword(TSqlTokenType.SemanticSimilarityDetailsTable);
				break;
			}
			this.GenerateSpaceAndSymbol(TSqlTokenType.LeftParenthesis);
			this.GenerateFragmentIfNotNull(node.TableName);
			this.GenerateSymbolAndSpace(TSqlTokenType.Comma);
			int count = node.Columns.Count;
			if (count == 1)
			{
				this.GenerateFragmentIfNotNull(node.Columns[0]);
			}
			else
			{
				this.GenerateParenthesisedCommaSeparatedList<ColumnReferenceExpression>(node.Columns);
			}
			if (node.SourceKey != null)
			{
				this.GenerateSymbol(TSqlTokenType.Comma);
				this.GenerateSpaceAndFragmentIfNotNull(node.SourceKey);
			}
			if (node.MatchedColumn != null)
			{
				this.GenerateSymbol(TSqlTokenType.Comma);
				this.GenerateSpaceAndFragmentIfNotNull(node.MatchedColumn);
			}
			if (node.MatchedKey != null)
			{
				this.GenerateSymbol(TSqlTokenType.Comma);
				this.GenerateSpaceAndFragmentIfNotNull(node.MatchedKey);
			}
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			this.GenerateSpaceAndAlias(node.Alias);
			this.PopAlignmentPoint();
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x0002EEDC File Offset: 0x0002D0DC
		public override void ExplicitVisit(SendStatement node)
		{
			this.GenerateIdentifier("SEND");
			this.GenerateSpaceAndKeyword(TSqlTokenType.On);
			this.GenerateSpaceAndIdentifier("CONVERSATION");
			this.GenerateSpace();
			if (this._options.SqlVersion >= SqlVersion.Sql110)
			{
				this.GenerateParenthesisedCommaSeparatedList<ScalarExpression>(node.ConversationHandles);
			}
			else
			{
				this.GenerateCommaSeparatedList<ScalarExpression>(node.ConversationHandles);
			}
			if (node.MessageTypeName != null)
			{
				this.GenerateSpaceAndIdentifier("MESSAGE");
				this.GenerateSpaceAndIdentifier("TYPE");
				this.GenerateSpaceAndFragmentIfNotNull(node.MessageTypeName);
			}
			if (node.MessageBody != null)
			{
				this.GenerateSpace();
				this.GenerateParenthesisedFragmentIfNotNull(node.MessageBody);
			}
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x0002EF7C File Offset: 0x0002D17C
		public void GenerateSequenceStatementBody(SequenceStatement node)
		{
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			foreach (SequenceOption fragment in node.SequenceOptions)
			{
				this.GenerateFragmentIfNotNull(fragment);
			}
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x0002EFD8 File Offset: 0x0002D1D8
		public override void ExplicitVisit(DataTypeSequenceOption node)
		{
			this.NewLineAndIndent();
			this.GenerateKeyword(TSqlTokenType.As);
			this.GenerateSpaceAndFragmentIfNotNull(node.DataType);
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x0002EFF4 File Offset: 0x0002D1F4
		public override void ExplicitVisit(SequenceOption node)
		{
			this.NewLineAndIndent();
			if (node.NoValue)
			{
				this.GenerateIdentifier("NO");
				this.GenerateSpace();
			}
			switch (node.OptionKind)
			{
			case SequenceOptionKind.MinValue:
				this.GenerateIdentifier("MINVALUE");
				return;
			case SequenceOptionKind.MaxValue:
				this.GenerateIdentifier("MAXVALUE");
				return;
			case SequenceOptionKind.Cache:
				this.GenerateIdentifier("CACHE");
				return;
			case SequenceOptionKind.Cycle:
				this.GenerateIdentifier("Cycle");
				return;
			default:
				return;
			}
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x0002F070 File Offset: 0x0002D270
		public override void ExplicitVisit(ScalarExpressionSequenceOption node)
		{
			this.NewLineAndIndent();
			switch (node.OptionKind)
			{
			case SequenceOptionKind.MinValue:
				this.GenerateIdentifier("MINVALUE");
				break;
			case SequenceOptionKind.MaxValue:
				this.GenerateIdentifier("MAXVALUE");
				break;
			case SequenceOptionKind.Cache:
				this.GenerateIdentifier("CACHE");
				break;
			case SequenceOptionKind.Start:
				this.GenerateIdentifier("START");
				this.GenerateSpaceAndKeyword(TSqlTokenType.With);
				break;
			case SequenceOptionKind.Increment:
				this.GenerateIdentifier("INCREMENT");
				this.GenerateSpaceAndKeyword(TSqlTokenType.By);
				break;
			case SequenceOptionKind.Restart:
				this.GenerateIdentifier("RESTART");
				if (node.OptionValue != null)
				{
					this.GenerateSpaceAndKeyword(TSqlTokenType.With);
				}
				break;
			}
			this.GenerateSpaceAndFragmentIfNotNull(node.OptionValue);
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x0002F12E File Offset: 0x0002D32E
		public override void ExplicitVisit(AlterServerAuditSpecificationStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Alter);
			this.GenerateSpaceAndIdentifier("SERVER");
			this.GenerateSpace();
			this.GenerateAuditSpecificationStatement(node);
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x0002F14F File Offset: 0x0002D34F
		public override void ExplicitVisit(CreateServerAuditSpecificationStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Create);
			this.GenerateSpaceAndIdentifier("SERVER");
			this.GenerateSpace();
			this.GenerateAuditSpecificationStatement(node);
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x0002F171 File Offset: 0x0002D371
		public override void ExplicitVisit(DropServerAuditSpecificationStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Drop);
			this.GenerateSpaceAndIdentifier("SERVER");
			this.GenerateSpaceAndIdentifier("AUDIT");
			this.GenerateSpaceAndIdentifier("SPECIFICATION");
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x0002F1A8 File Offset: 0x0002D3A8
		public override void ExplicitVisit(QueueDelayAuditOption node)
		{
			this.GenerateNameEqualsValue("QUEUE_DELAY", node.Delay);
		}

		// Token: 0x06000F3D RID: 3901 RVA: 0x0002F1BB File Offset: 0x0002D3BB
		public override void ExplicitVisit(AuditGuidAuditOption node)
		{
			this.GenerateNameEqualsValue("AUDIT_GUID", node.Guid);
		}

		// Token: 0x06000F3E RID: 3902 RVA: 0x0002F1D0 File Offset: 0x0002D3D0
		public override void ExplicitVisit(OnFailureAuditOption node)
		{
			this.GenerateTokenAndEqualSign("ON_FAILURE");
			switch (node.OnFailureAction)
			{
			case AuditFailureActionType.Continue:
				this.GenerateSpaceAndKeyword(TSqlTokenType.Continue);
				return;
			case AuditFailureActionType.Shutdown:
				this.GenerateSpaceAndKeyword(TSqlTokenType.Shutdown);
				return;
			case AuditFailureActionType.FailOperation:
				this.GenerateSpaceAndIdentifier("FAIL_OPERATION");
				return;
			default:
				return;
			}
		}

		// Token: 0x06000F3F RID: 3903 RVA: 0x0002F222 File Offset: 0x0002D422
		public override void ExplicitVisit(StateAuditOption node)
		{
			this.GenerateOptionStateWithEqualSign("STATE", node.Value);
		}

		// Token: 0x06000F40 RID: 3904 RVA: 0x0002F238 File Offset: 0x0002D438
		public override void ExplicitVisit(CreateServerAuditStatement node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.Create);
			this.GenerateServerAuditName(node.AuditName);
			this.GenerateSpaceAndFragmentIfNotNull(node.AuditTarget);
			this.GenerateServerAuditOptions(node);
			if (node.PredicateExpression != null)
			{
				this.NewLineAndIndent();
				this.GenerateKeywordAndSpace(TSqlTokenType.Where);
				this.GenerateFragmentIfNotNull(node.PredicateExpression);
			}
		}

		// Token: 0x06000F41 RID: 3905 RVA: 0x0002F294 File Offset: 0x0002D494
		public override void ExplicitVisit(AlterServerAuditStatement node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.Alter);
			this.GenerateServerAuditName(node.AuditName);
			if (node.NewName != null)
			{
				this.GenerateSpaceAndIdentifier("MODIFY");
				this.GenerateSpace();
				this.GenerateNameEqualsValue("NAME", node.NewName);
				return;
			}
			if (node.RemoveWhere)
			{
				this.GenerateSpaceAndIdentifier("REMOVE");
				this.GenerateSpaceAndKeyword(TSqlTokenType.Where);
				return;
			}
			this.GenerateSpaceAndFragmentIfNotNull(node.AuditTarget);
			this.GenerateServerAuditOptions(node);
			if (node.PredicateExpression != null)
			{
				this.NewLineAndIndent();
				this.GenerateKeywordAndSpace(TSqlTokenType.Where);
				this.GenerateFragmentIfNotNull(node.PredicateExpression);
			}
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x0002F336 File Offset: 0x0002D536
		public override void ExplicitVisit(DropServerAuditStatement node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.Drop);
			this.GenerateServerAuditName(node.Name);
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x0002F34C File Offset: 0x0002D54C
		private void GenerateServerAuditName(Identifier name)
		{
			this.GenerateIdentifier("SERVER");
			this.GenerateSpaceAndIdentifier("AUDIT");
			this.GenerateSpaceAndFragmentIfNotNull(name);
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x0002F36B File Offset: 0x0002D56B
		private void GenerateServerAuditOptions(ServerAuditStatement node)
		{
			if (node.Options.Count > 0)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.With);
				this.GenerateSpace();
				this.GenerateParenthesisedCommaSeparatedList<AuditOption>(node.Options);
			}
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x0002F398 File Offset: 0x0002D598
		public override void ExplicitVisit(ServiceContract node)
		{
			switch (node.Action)
			{
			case AlterAction.Add:
				this.GenerateKeyword(TSqlTokenType.Add);
				this.GenerateSpaceAndIdentifier("CONTRACT");
				this.GenerateSpace();
				break;
			case AlterAction.Drop:
				this.GenerateKeyword(TSqlTokenType.Drop);
				this.GenerateSpaceAndIdentifier("CONTRACT");
				this.GenerateSpace();
				break;
			}
			this.GenerateFragmentIfNotNull(node.Name);
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x0002F3FF File Offset: 0x0002D5FF
		public override void ExplicitVisit(SessionTimeoutPayloadOption node)
		{
			if (node.IsNever)
			{
				this.GenerateNameEqualsValue("SESSION_TIMEOUT", "NEVER");
				return;
			}
			this.GenerateNameEqualsValue("SESSION_TIMEOUT", node.Timeout);
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x0002F42C File Offset: 0x0002D62C
		protected void GenerateSetClauses(IList<SetClause> setClauses, AlignmentPoint alignmentPoint)
		{
			this.NewLine();
			if (this._options.IndentSetClause)
			{
				this.Indent();
			}
			this.GenerateKeyword(TSqlTokenType.Set);
			this.MarkClauseBodyAlignmentWhenNecessary(true, alignmentPoint);
			this.GenerateSpace();
			AlignmentPoint ap = new AlignmentPoint();
			this.MarkAndPushAlignmentPoint(ap);
			this.GenerateCommaSeparatedList<SetClause>(setClauses, this._options.MultilineSetClauseItems);
			this.PopAlignmentPoint();
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x0002F490 File Offset: 0x0002D690
		public override void ExplicitVisit(FunctionCallSetClause node)
		{
			this.AlignWhenNecessary("SetClauseItemFirstEqualSign");
			this.GenerateFragmentIfNotNull(node.MutatorFunction);
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x0002F4AC File Offset: 0x0002D6AC
		public override void ExplicitVisit(AssignmentSetClause node)
		{
			if (node.Variable != null)
			{
				this.GenerateFragmentIfNotNull(node.Variable);
				this.AlignWhenNecessary("SetClauseItemFirstEqualSign");
			}
			if (node.Column != null && node.Variable != null)
			{
				this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
				this.GenerateSpace();
			}
			this.GenerateFragmentIfNotNull(node.Column);
			if (node.Column != null || node.Variable != null)
			{
				this.AlignWhenNecessary("SetClauseItemSecondEqualSign");
				TSqlTokenType valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<AssignmentKind, TSqlTokenType>(SqlScriptGeneratorVisitor._assignmentKindSymbols, node.AssignmentKind);
				this.GenerateSpaceAndSymbol(valueForEnumKey);
			}
			this.GenerateSpaceAndFragmentIfNotNull(node.NewValue);
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x0002F544 File Offset: 0x0002D744
		private void AlignWhenNecessary(string apName)
		{
			if (this._options.MultilineSetClauseItems && this._options.AlignSetClauseItem)
			{
				AlignmentPoint ap = this.FindOrCreateAlignmentPointByName(apName);
				this.Mark(ap);
			}
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x0002F57A File Offset: 0x0002D77A
		public override void ExplicitVisit(SetCommandStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Set);
			this.GenerateSpace();
			this.GenerateCommaSeparatedList<SetCommand>(node.Commands);
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x0002F599 File Offset: 0x0002D799
		public override void ExplicitVisit(SetErrorLevelStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Set);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Errlvl);
			this.GenerateSpaceAndFragmentIfNotNull(node.Level);
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x0002F5BA File Offset: 0x0002D7BA
		public override void ExplicitVisit(SetFipsFlaggerCommand node)
		{
			this.GenerateIdentifier("FIPS_FLAGGER");
			this.GenerateSpace();
			FipsComplianceLevelHelper.Instance.GenerateSourceForOption(this._writer, node.ComplianceLevel);
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x0002F5E3 File Offset: 0x0002D7E3
		public override void ExplicitVisit(SetIdentityInsertStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Set);
			this.GenerateSpaceAndKeyword(TSqlTokenType.IdentityInsert);
			this.GenerateSpaceAndFragmentIfNotNull(node.Table);
			this.GenerateSpaceAndKeyword(node.IsOn ? TSqlTokenType.On : TSqlTokenType.Off);
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x0002F618 File Offset: 0x0002D818
		public override void ExplicitVisit(SetOffsetsStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Set);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Offsets);
			this.GenerateSpace();
			this.GenerateCommaSeparatedFlagOpitons<SetOffsets>(SqlScriptGeneratorVisitor._setOffsetsGenerators, node.Options);
			this.GenerateSpaceAndKeyword(node.IsOn ? TSqlTokenType.On : TSqlTokenType.Off);
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x0002F658 File Offset: 0x0002D858
		public override void ExplicitVisit(SetRowCountStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Set);
			this.GenerateSpaceAndKeyword(TSqlTokenType.RowCount);
			this.GenerateSpaceAndFragmentIfNotNull(node.NumberRows);
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x0002F67C File Offset: 0x0002D87C
		public override void ExplicitVisit(SetStatisticsStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Set);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Statistics);
			this.GenerateSpace();
			SetStatisticsOptionsHelper.Instance.GenerateCommaSeparatedFlagOptions(this._writer, node.Options);
			this.GenerateSpace();
			this.GenerateKeyword(node.IsOn ? TSqlTokenType.On : TSqlTokenType.Off);
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x0002F6D5 File Offset: 0x0002D8D5
		public override void ExplicitVisit(SetTextSizeStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Set);
			this.GenerateSpaceAndKeyword(TSqlTokenType.TextSize);
			this.GenerateSpaceAndFragmentIfNotNull(node.TextSize);
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x0002F6FC File Offset: 0x0002D8FC
		public override void ExplicitVisit(SetTransactionIsolationLevelStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Set);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Transaction);
			this.GenerateSpaceAndIdentifier("ISOLATION");
			this.GenerateSpaceAndIdentifier("LEVEL");
			List<TokenGenerator> valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<IsolationLevel, List<TokenGenerator>>(SqlScriptGeneratorVisitor._isolationLevelGenerators, node.Level);
			if (valueForEnumKey != null)
			{
				this.GenerateSpace();
				this.GenerateTokenList(valueForEnumKey);
			}
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x0002F756 File Offset: 0x0002D956
		public override void ExplicitVisit(SetUserStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.SetUser);
			this.GenerateSpaceAndFragmentIfNotNull(node.UserName);
			if (node.WithNoReset)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.With);
				this.GenerateSpaceAndIdentifier("NORESET");
			}
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x0002F794 File Offset: 0x0002D994
		public override void ExplicitVisit(SetVariableStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Set);
			this.GenerateSpaceAndFragmentIfNotNull(node.Variable);
			if (node.SeparatorType != SeparatorType.NotSpecified)
			{
				switch (node.SeparatorType)
				{
				case SeparatorType.Dot:
					this.GenerateSymbol(TSqlTokenType.Dot);
					break;
				case SeparatorType.DoubleColon:
					this.GenerateSymbol(TSqlTokenType.DoubleColon);
					break;
				}
				this.GenerateFragmentIfNotNull(node.Identifier);
				if (node.FunctionCallExists)
				{
					this.GenerateSpace();
					this.GenerateSymbol(TSqlTokenType.LeftParenthesis);
					this.GenerateCommaSeparatedList<ScalarExpression>(node.Parameters);
					this.GenerateSymbol(TSqlTokenType.RightParenthesis);
				}
			}
			if (node.Expression != null)
			{
				TSqlTokenType valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<AssignmentKind, TSqlTokenType>(SqlScriptGeneratorVisitor._assignmentKindSymbols, node.AssignmentKind);
				this.GenerateSpaceAndSymbol(valueForEnumKey);
				this.GenerateSpaceAndFragmentIfNotNull(node.Expression);
			}
			if (node.CursorDefinition != null)
			{
				this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
				this.GenerateSpaceAndFragmentIfNotNull(node.CursorDefinition);
			}
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x0002F87A File Offset: 0x0002DA7A
		public override void ExplicitVisit(ShutdownStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Shutdown);
			if (node.WithNoWait)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.With);
				this.GenerateSpaceAndIdentifier("NOWAIT");
			}
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x0002F8AC File Offset: 0x0002DAAC
		public override void ExplicitVisit(LiteralPrincipalOption node)
		{
			string valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<PrincipalOptionKind, string>(SqlScriptGeneratorVisitor._loginOptionsNames, node.OptionKind);
			this.GenerateNameEqualsValue(valueForEnumKey, node.Value);
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x0002F8D7 File Offset: 0x0002DAD7
		protected void GenerateCounterSignature(SignatureStatementBase node)
		{
			if (node.IsCounter)
			{
				this.GenerateIdentifier("COUNTER");
				this.GenerateSpace();
			}
			this.GenerateIdentifier("SIGNATURE");
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x0002F900 File Offset: 0x0002DB00
		protected void GenerateModule(SignatureStatementBase node)
		{
			switch (node.ElementKind)
			{
			case SignableElementKind.Object:
				this.GenerateIdentifier("OBJECT");
				this.GenerateSymbol(TSqlTokenType.DoubleColon);
				break;
			case SignableElementKind.Assembly:
				this.GenerateIdentifier("ASSEMBLY");
				this.GenerateSymbol(TSqlTokenType.DoubleColon);
				break;
			case SignableElementKind.Database:
				this.GenerateKeyword(TSqlTokenType.Database);
				this.GenerateSymbol(TSqlTokenType.DoubleColon);
				break;
			}
			this.GenerateFragmentIfNotNull(node.Element);
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x0002F97B File Offset: 0x0002DB7B
		protected void GenerateCryptos(SignatureStatementBase node)
		{
			this.GenerateKeyword(TSqlTokenType.By);
			this.GenerateSpace();
			this.GenerateCommaSeparatedList<CryptoMechanism>(node.Cryptos);
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x0002F997 File Offset: 0x0002DB97
		protected void GenerateSpaceAndAlias(Identifier alias)
		{
			if (alias != null)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.As);
				this.GenerateSpaceAndFragmentIfNotNull(alias);
			}
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x0002F9AB File Offset: 0x0002DBAB
		protected void GenerateTableAndColumnAliases(TableReferenceWithAliasAndColumns node)
		{
			this.GenerateSpaceAndAlias(node.Alias);
			this.GenerateParenthesisedCommaSeparatedList<Identifier>(node.Columns);
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x0002F9C8 File Offset: 0x0002DBC8
		public override void ExplicitVisit(SoapMethod node)
		{
			TokenGenerator valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<SoapMethodAction, TokenGenerator>(SqlScriptGeneratorVisitor._soapMethodActionGenerators, node.Action);
			if (valueForEnumKey != null)
			{
				this.GenerateToken(valueForEnumKey);
			}
			this.GenerateSpaceAndIdentifier("WEBMETHOD");
			if (node.Namespace != null)
			{
				this.GenerateSpaceAndFragmentIfNotNull(node.Namespace);
				this.GenerateSymbol(TSqlTokenType.Dot);
			}
			else
			{
				this.GenerateSpace();
			}
			this.GenerateFragmentIfNotNull(node.Alias);
			if (node.Action != SoapMethodAction.Drop)
			{
				this.GenerateSymbol(TSqlTokenType.LeftParenthesis);
				if (node.Name != null)
				{
					this.GenerateNameEqualsValue("NAME", node.Name);
				}
				if (node.Schema != SoapMethodSchemas.NotSpecified)
				{
					this.GenerateSymbolAndSpace(TSqlTokenType.Comma);
					this.GenerateTokenAndEqualSign(TSqlTokenType.Schema);
					TokenGenerator valueForEnumKey2 = SqlScriptGeneratorVisitor.GetValueForEnumKey<SoapMethodSchemas, TokenGenerator>(SqlScriptGeneratorVisitor._soapMethodSchemasGenerators, node.Schema);
					if (valueForEnumKey2 != null)
					{
						this.GenerateSpace();
						this.GenerateToken(valueForEnumKey2);
					}
				}
				if (node.Format != SoapMethodFormat.NotSpecified)
				{
					this.GenerateSymbolAndSpace(TSqlTokenType.Comma);
					string valueForEnumKey3 = SqlScriptGeneratorVisitor.GetValueForEnumKey<SoapMethodFormat, string>(SqlScriptGeneratorVisitor._soapMethodFormatNames, node.Format);
					if (valueForEnumKey3 != null)
					{
						this.GenerateNameEqualsValue("FORMAT", valueForEnumKey3);
					}
				}
				this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			}
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x0002FADC File Offset: 0x0002DCDC
		public override void ExplicitVisit(SqlDataTypeReference node)
		{
			TokenGenerator valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<SqlDataTypeOption, TokenGenerator>(SqlScriptGeneratorVisitor._sqlDataTypeOptionGenerators, node.SqlDataTypeOption);
			if (valueForEnumKey != null)
			{
				this.GenerateToken(valueForEnumKey);
			}
			this.GenerateParameters(node);
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x0002FB0C File Offset: 0x0002DD0C
		public override void ExplicitVisit(StatementList node)
		{
			if (node.Statements != null)
			{
				bool flag = true;
				foreach (TSqlStatement tsqlStatement in node.Statements)
				{
					if (flag)
					{
						flag = false;
					}
					else
					{
						this.NewLine();
					}
					this.GenerateFragmentIfNotNull(tsqlStatement);
					this.GenerateSemiColonWhenNecessary(tsqlStatement);
				}
			}
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x0002FB78 File Offset: 0x0002DD78
		public override void ExplicitVisit(StatisticsOption node)
		{
			switch (node.OptionKind)
			{
			case StatisticsOptionKind.FullScan:
				this.GenerateIdentifier("FULLSCAN");
				return;
			case StatisticsOptionKind.SamplePercent:
			case StatisticsOptionKind.SampleRows:
			case StatisticsOptionKind.StatsStream:
			case StatisticsOptionKind.RowCount:
			case StatisticsOptionKind.PageCount:
				break;
			case StatisticsOptionKind.NoRecompute:
				this.GenerateIdentifier("NORECOMPUTE");
				return;
			case StatisticsOptionKind.Resample:
				this.GenerateIdentifier("RESAMPLE");
				return;
			case StatisticsOptionKind.All:
				this.GenerateKeyword(TSqlTokenType.All);
				return;
			case StatisticsOptionKind.Columns:
				this.GenerateIdentifier("COLUMNS");
				return;
			case StatisticsOptionKind.Index:
				this.GenerateKeyword(TSqlTokenType.Index);
				return;
			case StatisticsOptionKind.Rows:
				this.GenerateIdentifier("ROWS");
				break;
			default:
				return;
			}
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x0002FC10 File Offset: 0x0002DE10
		public override void ExplicitVisit(LiteralStatisticsOption node)
		{
			switch (node.OptionKind)
			{
			case StatisticsOptionKind.SamplePercent:
				this.GenerateIdentifier("SAMPLE");
				this.GenerateSpaceAndFragmentIfNotNull(node.Literal);
				this.GenerateSpaceAndKeyword(TSqlTokenType.Percent);
				return;
			case StatisticsOptionKind.SampleRows:
				this.GenerateIdentifier("SAMPLE");
				this.GenerateSpaceAndFragmentIfNotNull(node.Literal);
				this.GenerateSpaceAndIdentifier("ROWS");
				return;
			case StatisticsOptionKind.StatsStream:
				this.GenerateNameEqualsValue("STATS_STREAM", node.Literal);
				return;
			case StatisticsOptionKind.NoRecompute:
			case StatisticsOptionKind.Resample:
				break;
			case StatisticsOptionKind.RowCount:
				this.GenerateNameEqualsValue(TSqlTokenType.RowCount, node.Literal);
				return;
			case StatisticsOptionKind.PageCount:
				this.GenerateNameEqualsValue("PAGECOUNT", node.Literal);
				break;
			default:
				return;
			}
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x0002FCC4 File Offset: 0x0002DEC4
		public override void ExplicitVisit(OnOffStatisticsOption node)
		{
			string optionName = string.Empty;
			StatisticsOptionKind optionKind = node.OptionKind;
			if (optionKind == StatisticsOptionKind.Incremental)
			{
				optionName = "INCREMENTAL";
			}
			this.GenerateOptionStateWithEqualSign(optionName, node.OptionState);
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x0002FCF8 File Offset: 0x0002DEF8
		public override void ExplicitVisit(ResampleStatisticsOption node)
		{
			string text = string.Empty;
			StatisticsOptionKind optionKind = node.OptionKind;
			if (optionKind == StatisticsOptionKind.Resample)
			{
				text = "RESAMPLE";
			}
			this.GenerateIdentifier(text);
			if (node.Partitions.Count > 0)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.On);
				this.GenerateSpaceAndIdentifier("PARTITIONS");
				this.GenerateSpace();
				this.GenerateParenthesisedCommaSeparatedList<StatisticsPartitionRange>(node.Partitions);
			}
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x0002FD56 File Offset: 0x0002DF56
		public override void ExplicitVisit(StatisticsPartitionRange node)
		{
			this.GenerateFragmentIfNotNull(node.From);
			if (node.To != null)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.To);
				this.GenerateSpaceAndFragmentIfNotNull(node.To);
			}
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x0002FD84 File Offset: 0x0002DF84
		public override void ExplicitVisit(StopRestoreOption node)
		{
			this.GenerateNameEqualsValue(node.IsStopAt ? "STOPATMARK" : "STOPBEFOREMARK", node.Mark);
			if (node.After != null)
			{
				this.GenerateSpaceAndIdentifier("AFTER");
				this.GenerateSpaceAndFragmentIfNotNull(node.After);
			}
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x0002FDD0 File Offset: 0x0002DFD0
		public override void ExplicitVisit(SubqueryComparisonPredicate node)
		{
			AlignmentPoint ap = new AlignmentPoint();
			this.MarkAndPushAlignmentPoint(ap);
			this.GenerateFragmentIfNotNull(node.Expression);
			this.PopAlignmentPoint();
			this.GenerateSpace();
			this.GenerateBinaryOperator(node.ComparisonType);
			if (node.SubqueryComparisonPredicateType != SubqueryComparisonPredicateType.None)
			{
				TokenGenerator valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<SubqueryComparisonPredicateType, TokenGenerator>(SqlScriptGeneratorVisitor._subqueryComparisonPredicateTypeGenerators, node.SubqueryComparisonPredicateType);
				if (valueForEnumKey != null)
				{
					this.GenerateSpace();
					this.GenerateToken(valueForEnumKey);
				}
			}
			AlignmentPoint ap2 = new AlignmentPoint();
			this.MarkAndPushAlignmentPoint(ap2);
			this.GenerateSpaceAndFragmentIfNotNull(node.Subquery);
			this.PopAlignmentPoint();
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x0002FE58 File Offset: 0x0002E058
		public override void ExplicitVisit(CreateSymmetricKeyStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Create);
			this.GenerateSymmetricKeyName(node.Name);
			this.GenerateOwnerIfNotNull(node.Owner);
			if (node.Provider != null)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.From);
				this.GenerateSpaceAndIdentifier("PROVIDER");
				this.GenerateSpaceAndFragmentIfNotNull(node.Provider);
			}
			if (node.KeyOptions.Count > 0)
			{
				this.NewLineAndIndent();
				this.GenerateKeywordAndSpace(TSqlTokenType.With);
				this.GenerateCommaSeparatedList<KeyOption>(node.KeyOptions);
			}
			if (node.EncryptingMechanisms.Count > 0)
			{
				this.NewLineAndIndent();
				this.GenerateIdentifier("ENCRYPTION");
				this.GenerateSpaceAndKeyword(TSqlTokenType.By);
				this.GenerateSpace();
				this.GenerateCommaSeparatedList<CryptoMechanism>(node.EncryptingMechanisms);
			}
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x0002FF10 File Offset: 0x0002E110
		public override void ExplicitVisit(AlterSymmetricKeyStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Alter);
			this.GenerateSymmetricKeyName(node.Name);
			this.GenerateSpaceAndKeyword(node.IsAdd ? TSqlTokenType.Add : TSqlTokenType.Drop);
			this.GenerateSpaceAndIdentifier("ENCRYPTION");
			this.GenerateSpaceAndKeyword(TSqlTokenType.By);
			this.GenerateSpace();
			this.GenerateCommaSeparatedList<CryptoMechanism>(node.EncryptingMechanisms);
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x0002FF68 File Offset: 0x0002E168
		public override void ExplicitVisit(DropSymmetricKeyStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Drop);
			this.GenerateSymmetricKeyName(node.Name);
			this.GenerateRemoveProviderKeyOpt(node.RemoveProviderKey);
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x0002FF8A File Offset: 0x0002E18A
		public override void ExplicitVisit(AlgorithmKeyOption node)
		{
			this.GenerateTokenAndEqualSign("ALGORITHM");
			this.GenerateSpace();
			EncryptionAlgorithmsHelper.Instance.GenerateSourceForOption(this._writer, node.Algorithm);
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x0002FFB3 File Offset: 0x0002E1B3
		public override void ExplicitVisit(IdentityValueKeyOption node)
		{
			this.GenerateNameEqualsValue("IDENTITY_VALUE", node.IdentityPhrase);
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x0002FFC6 File Offset: 0x0002E1C6
		public override void ExplicitVisit(KeySourceKeyOption node)
		{
			this.GenerateNameEqualsValue("KEY_SOURCE", node.PassPhrase);
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x0002FFD9 File Offset: 0x0002E1D9
		public override void ExplicitVisit(ProviderKeyNameKeyOption node)
		{
			this.GenerateNameEqualsValue("PROVIDER_KEY_NAME", node.KeyName);
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x0002FFEC File Offset: 0x0002E1EC
		public override void ExplicitVisit(CreationDispositionKeyOption node)
		{
			this.GenerateTokenAndEqualSign("CREATION_DISPOSITION");
			this.GenerateSpaceAndIdentifier(node.IsCreateNew ? "CREATE_NEW" : "OPEN_EXISTING");
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x00030013 File Offset: 0x0002E213
		private void GenerateSymmetricKeyName(Identifier name)
		{
			this.GenerateSpaceAndIdentifier("SYMMETRIC");
			this.GenerateSpaceAndKeyword(TSqlTokenType.Key);
			this.GenerateSpaceAndFragmentIfNotNull(name);
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x0003002F File Offset: 0x0002E22F
		protected void GenerateWithTableHints(IList<TableHint> tableHints)
		{
			if (tableHints.Count > 0)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.With);
				this.GenerateSpace();
				this.GenerateParenthesisedCommaSeparatedList<TableHint>(tableHints);
			}
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x00030052 File Offset: 0x0002E252
		public override void ExplicitVisit(TableHint node)
		{
			TableHintOptionsHelper.Instance.GenerateSourceForOption(this._writer, node.HintKind);
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x0003006A File Offset: 0x0002E26A
		public override void ExplicitVisit(IndexTableHint node)
		{
			this.GenerateKeywordAndSpace(TSqlTokenType.Index);
			this.GenerateParenthesisedCommaSeparatedList<IdentifierOrValueExpression>(node.IndexValues);
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x00030080 File Offset: 0x0002E280
		public override void ExplicitVisit(LiteralTableHint node)
		{
			this.GenerateNameEqualsValue("SPATIAL_WINDOW_MAX_CELLS", node.Value);
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x00030094 File Offset: 0x0002E294
		public override void ExplicitVisit(ForceSeekTableHint node)
		{
			this.GenerateIdentifier("FORCESEEK");
			if (node.IndexValue != null)
			{
				this.GenerateSpace();
				this.GenerateSymbol(TSqlTokenType.LeftParenthesis);
				this.GenerateFragmentIfNotNull(node.IndexValue);
				this.GenerateSpace();
				this.GenerateParenthesisedCommaSeparatedList<ColumnReferenceExpression>(node.ColumnValues);
				this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			}
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x000300F0 File Offset: 0x0002E2F0
		public override void ExplicitVisit(TableSampleClause node)
		{
			this.GenerateKeyword(TSqlTokenType.TableSample);
			if (node.System)
			{
				this.GenerateSpaceAndIdentifier("SYSTEM");
			}
			this.GenerateSpaceAndSymbol(TSqlTokenType.LeftParenthesis);
			this.GenerateFragmentIfNotNull(node.SampleNumber);
			TokenGenerator valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<TableSampleClauseOption, TokenGenerator>(SqlScriptGeneratorVisitor._tableSampleClauseOptionGenerators, node.TableSampleClauseOption);
			if (valueForEnumKey != null && node.TableSampleClauseOption != TableSampleClauseOption.NotSpecified)
			{
				this.GenerateSpace();
				this.GenerateToken(valueForEnumKey);
			}
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			if (node.RepeatSeed != null)
			{
				this.GenerateSpaceAndIdentifier("REPEATABLE");
				this.GenerateSpace();
				this.GenerateParenthesisedFragmentIfNotNull(node.RepeatSeed);
			}
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x0003018C File Offset: 0x0002E38C
		public override void ExplicitVisit(TableValuedFunctionReturnType node)
		{
			this.NewLineAndIndent();
			AlignmentPoint ap = new AlignmentPoint();
			this.MarkAndPushAlignmentPoint(ap);
			this.GenerateFragmentIfNotNull(node.DeclareTableVariableBody);
			this.PopAlignmentPoint();
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x000301C0 File Offset: 0x0002E3C0
		public override void ExplicitVisit(TargetRecoveryTimeDatabaseOption node)
		{
			this.GenerateIdentifier("TARGET_RECOVERY_TIME");
			this.GenerateSpace();
			this.GenerateSymbolAndSpace(TSqlTokenType.EqualsSign);
			this.GenerateFragmentIfNotNull(node.RecoveryTime);
			this.GenerateSpace();
			TargetRecoveryTimeUnitHelper.Instance.GenerateSourceForOption(this._writer, node.Unit);
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x00030214 File Offset: 0x0002E414
		public override void ExplicitVisit(ThrowStatement node)
		{
			this.GenerateIdentifier("THROW");
			this.GenerateSpaceAndFragmentIfNotNull(node.ErrorNumber);
			if (node.ErrorNumber != null && node.Message != null)
			{
				this.GenerateKeyword(TSqlTokenType.Comma);
			}
			this.GenerateSpaceAndFragmentIfNotNull(node.Message);
			if (node.Message != null && node.State != null)
			{
				this.GenerateKeyword(TSqlTokenType.Comma);
			}
			this.GenerateSpaceAndFragmentIfNotNull(node.State);
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x00030288 File Offset: 0x0002E488
		public override void ExplicitVisit(TopRowFilter node)
		{
			this.GenerateKeyword(TSqlTokenType.Top);
			this.GenerateSpaceAndFragmentIfNotNull(node.Expression);
			if (node.Percent)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.Percent);
			}
			if (node.WithTies)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.With);
				this.GenerateSpaceAndIdentifier("TIES");
			}
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x000302DC File Offset: 0x0002E4DC
		protected void GenerateTransactionName(object node)
		{
			string text = node as string;
			if (text != null)
			{
				this.GenerateIdentifierWithoutCasing(text);
				return;
			}
			TSqlFragment tsqlFragment = node as TSqlFragment;
			if (tsqlFragment != null)
			{
				this.GenerateFragmentIfNotNull(tsqlFragment);
			}
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x0003030C File Offset: 0x0002E50C
		public override void ExplicitVisit(TriggerAction node)
		{
			switch (node.TriggerActionType)
			{
			case TriggerActionType.Delete:
				this.GenerateKeyword(TSqlTokenType.Delete);
				return;
			case TriggerActionType.Insert:
				this.GenerateKeyword(TSqlTokenType.Insert);
				return;
			case TriggerActionType.Update:
				this.GenerateKeyword(TSqlTokenType.Update);
				return;
			case TriggerActionType.Event:
				this.GenerateFragmentIfNotNull(node.EventTypeGroup);
				return;
			case TriggerActionType.LogOn:
				this.GenerateIdentifier("LOGON");
				return;
			default:
				return;
			}
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x00030374 File Offset: 0x0002E574
		public override void ExplicitVisit(TriggerObject node)
		{
			switch (node.TriggerScope)
			{
			case TriggerScope.Normal:
				this.GenerateFragmentIfNotNull(node.Name);
				return;
			case TriggerScope.Database:
				this.GenerateKeyword(TSqlTokenType.Database);
				return;
			case TriggerScope.AllServer:
				this.GenerateKeyword(TSqlTokenType.All);
				this.GenerateSpaceAndIdentifier("SERVER");
				return;
			default:
				return;
			}
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x000303C4 File Offset: 0x0002E5C4
		public override void ExplicitVisit(TriggerOption node)
		{
			TriggerOptionKind optionKind = node.OptionKind;
			if (optionKind != TriggerOptionKind.Encryption)
			{
				return;
			}
			this.GenerateIdentifier("ENCRYPTION");
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x000303E8 File Offset: 0x0002E5E8
		public override void ExplicitVisit(ExecuteAsTriggerOption node)
		{
			this.GenerateFragmentIfNotNull(node.ExecuteAsClause);
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x000303F8 File Offset: 0x0002E5F8
		protected void GenerateTriggerStatementBody(TriggerStatementBody node)
		{
			this.GenerateKeyword(TSqlTokenType.Trigger);
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			this.NewLineAndIndent();
			this.GenerateKeyword(TSqlTokenType.On);
			this.GenerateSpaceAndFragmentIfNotNull(node.TriggerObject);
			this.GenerateCommaSeparatedWithClause<TriggerOption>(node.Options, true, false);
			List<TokenGenerator> valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<TriggerType, List<TokenGenerator>>(SqlScriptGeneratorVisitor._triggerTypeGenerators, node.TriggerType);
			if (valueForEnumKey != null)
			{
				this.NewLineAndIndent();
				this.GenerateTokenList(valueForEnumKey);
			}
			if (node.TriggerActions != null && node.TriggerActions.Count > 0)
			{
				this.GenerateSpace();
				this.GenerateCommaSeparatedList<TriggerAction>(node.TriggerActions);
			}
			if (node.WithAppend)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.With);
				this.GenerateSpaceAndIdentifier("APPEND");
			}
			if (node.IsNotForReplication)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.Not);
				this.GenerateSpaceAndKeyword(TSqlTokenType.For);
				this.GenerateSpaceAndKeyword(TSqlTokenType.Replication);
			}
			this.NewLineAndIndent();
			this.GenerateKeyword(TSqlTokenType.As);
			this.GenerateSpace();
			AlignmentPoint ap = new AlignmentPoint();
			this.MarkAndPushAlignmentPoint(ap);
			this.GenerateFragmentIfNotNull(node.StatementList);
			this.PopAlignmentPoint();
			this.GenerateSpaceAndFragmentIfNotNull(node.MethodSpecifier);
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x00030519 File Offset: 0x0002E719
		public override void ExplicitVisit(TruncateTableStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Truncate);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Table);
			this.GenerateSpaceAndFragmentIfNotNull(node.TableName);
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x00030540 File Offset: 0x0002E740
		public override void ExplicitVisit(TryCastCall node)
		{
			this.GenerateIdentifier("TRY_CAST");
			this.GenerateSpaceAndSymbol(TSqlTokenType.LeftParenthesis);
			this.GenerateFragmentIfNotNull(node.Parameter);
			this.GenerateSpaceAndKeyword(TSqlTokenType.As);
			this.GenerateSpaceAndFragmentIfNotNull(node.DataType);
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			this.GenerateSpaceAndCollation(node.Collation);
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x0003059C File Offset: 0x0002E79C
		public override void ExplicitVisit(TryCatchStatement node)
		{
			AlignmentPoint ap = new AlignmentPoint();
			this.GenerateKeyword(TSqlTokenType.Begin);
			this.GenerateSpaceAndIdentifier("TRY");
			if (node.TryStatements.Statements.Count > 0)
			{
				this.NewLineAndIndent();
				this.MarkAndPushAlignmentPoint(ap);
				this.GenerateFragmentIfNotNull(node.TryStatements);
				this.PopAlignmentPoint();
			}
			this.NewLine();
			this.GenerateKeyword(TSqlTokenType.End);
			this.GenerateSpaceAndIdentifier("TRY");
			this.NewLine();
			this.GenerateKeyword(TSqlTokenType.Begin);
			this.GenerateSpaceAndIdentifier("CATCH");
			if (node.CatchStatements.Statements.Count > 0)
			{
				this.NewLineAndIndent();
				this.MarkAndPushAlignmentPoint(ap);
				this.GenerateFragmentIfNotNull(node.CatchStatements);
				this.PopAlignmentPoint();
			}
			this.NewLine();
			this.GenerateKeyword(TSqlTokenType.End);
			this.GenerateSpaceAndIdentifier("CATCH");
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x00030674 File Offset: 0x0002E874
		public override void ExplicitVisit(TryConvertCall node)
		{
			this.GenerateKeyword(TSqlTokenType.TryConvert);
			this.GenerateSpaceAndSymbol(TSqlTokenType.LeftParenthesis);
			this.GenerateFragmentIfNotNull(node.DataType);
			this.GenerateSymbol(TSqlTokenType.Comma);
			this.GenerateSpaceAndFragmentIfNotNull(node.Parameter);
			if (node.Style != null)
			{
				this.GenerateSymbol(TSqlTokenType.Comma);
				this.GenerateSpaceAndFragmentIfNotNull(node.Style);
			}
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			this.GenerateSpaceAndCollation(node.Collation);
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x000306F0 File Offset: 0x0002E8F0
		public override void ExplicitVisit(TryParseCall node)
		{
			this.GenerateIdentifier("TRY_PARSE");
			this.GenerateSpaceAndSymbol(TSqlTokenType.LeftParenthesis);
			this.GenerateFragmentIfNotNull(node.StringValue);
			this.GenerateSpaceAndKeyword(TSqlTokenType.As);
			this.GenerateSpaceAndFragmentIfNotNull(node.DataType);
			if (node.Culture != null)
			{
				this.GenerateSpace();
				this.GenerateIdentifier("USING");
				this.GenerateSpaceAndFragmentIfNotNull(node.Culture);
			}
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			this.GenerateSpaceAndCollation(node.Collation);
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x00030770 File Offset: 0x0002E970
		public override void ExplicitVisit(TSEqualCall node)
		{
			this.GenerateKeyword(TSqlTokenType.TSEqual);
			this.GenerateSpaceAndSymbol(TSqlTokenType.LeftParenthesis);
			this.GenerateFragmentIfNotNull(node.FirstExpression);
			this.GenerateSymbol(TSqlTokenType.Comma);
			this.GenerateSpaceAndFragmentIfNotNull(node.SecondExpression);
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x000307C4 File Offset: 0x0002E9C4
		public override void ExplicitVisit(TSqlBatch node)
		{
			foreach (TSqlStatement tsqlStatement in node.Statements)
			{
				this.GenerateFragmentIfNotNull(tsqlStatement);
				this.GenerateSemiColonWhenNecessary(tsqlStatement);
				if (!(tsqlStatement is TSqlStatementSnippet))
				{
					this.NewLine();
					this.NewLine();
				}
			}
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x0003082C File Offset: 0x0002EA2C
		public override void ExplicitVisit(TSqlScript node)
		{
			bool flag = true;
			foreach (TSqlBatch fragment in node.Batches)
			{
				if (flag)
				{
					flag = false;
				}
				else
				{
					this.NewLine();
					this.GenerateKeyword(TSqlTokenType.Go);
					this.NewLine();
				}
				this.GenerateFragmentIfNotNull(fragment);
			}
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x0003089C File Offset: 0x0002EA9C
		public override void ExplicitVisit(UnaryExpression node)
		{
			List<TokenGenerator> valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<UnaryExpressionType, List<TokenGenerator>>(SqlScriptGeneratorVisitor._unaryExpressionTypeGenerators, node.UnaryExpressionType);
			if (valueForEnumKey != null)
			{
				this.GenerateTokenList(valueForEnumKey);
			}
			if (node.Expression is UnaryExpression && node.UnaryExpressionType == UnaryExpressionType.Negative && (node.Expression as UnaryExpression).UnaryExpressionType == UnaryExpressionType.Negative)
			{
				this.GenerateSpace();
			}
			this.GenerateFragmentIfNotNull(node.Expression);
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x00030900 File Offset: 0x0002EB00
		public override void ExplicitVisit(UniqueConstraintDefinition node)
		{
			this.GenerateConstraintHead(node);
			if (node.IsPrimaryKey)
			{
				this.GenerateKeyword(TSqlTokenType.Primary);
				this.GenerateSpaceAndKeyword(TSqlTokenType.Key);
			}
			else
			{
				this.GenerateKeyword(TSqlTokenType.Unique);
			}
			if (node.Clustered != null && node.IndexType == null)
			{
				this.GenerateSpaceAndKeyword(node.Clustered.Value ? TSqlTokenType.Clustered : TSqlTokenType.NonClustered);
			}
			if (node.IndexType != null)
			{
                IndexTypeKind? indexTypeKind = node.IndexType.IndexTypeKind;
                ref IndexTypeKind? local = ref indexTypeKind;
                IndexTypeKind valueOrDefault = local.GetValueOrDefault();
                if (local.HasValue)
				{
					switch (valueOrDefault)
					{
					case IndexTypeKind.Clustered:
						this.GenerateSpaceAndKeyword(TSqlTokenType.Clustered);
						break;
					case IndexTypeKind.NonClustered:
						this.GenerateSpaceAndKeyword(TSqlTokenType.NonClustered);
						break;
					case IndexTypeKind.NonClusteredHash:
						this.GenerateSpaceAndKeyword(TSqlTokenType.NonClustered);
						this.GenerateSpaceAndIdentifier("HASH");
						break;
					}
				}
			}
			if (node.Columns.Count > 0)
			{
				this.GenerateSpace();
				this.GenerateParenthesisedCommaSeparatedList<ColumnWithSortOrder>(node.Columns);
			}
			if (node.IndexOptions.Count > 0)
			{
				this.GenerateIndexOptions(node.IndexOptions);
			}
			if (node.OnFileGroupOrPartitionScheme != null)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.On);
				this.GenerateSpaceAndFragmentIfNotNull(node.OnFileGroupOrPartitionScheme);
			}
			this.GenerateFileStreamOn(node);
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x00030A2C File Offset: 0x0002EC2C
		public override void ExplicitVisit(UnpivotedTableReference node)
		{
			this.GenerateFragmentIfNotNull(node.TableReference);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Unpivot);
			this.GenerateSpaceAndSymbol(TSqlTokenType.LeftParenthesis);
			this.GenerateFragmentIfNotNull(node.ValueColumn);
			this.GenerateSpaceAndKeyword(TSqlTokenType.For);
			this.GenerateSpaceAndFragmentIfNotNull(node.PivotColumn);
			this.GenerateSpaceAndKeyword(TSqlTokenType.In);
			this.GenerateSpace();
			this.GenerateParenthesisedCommaSeparatedList<ColumnReferenceExpression>(node.InColumns, true);
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			this.GenerateSpaceAndAlias(node.Alias);
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x00030AB0 File Offset: 0x0002ECB0
		public override void ExplicitVisit(UnqualifiedJoin node)
		{
			this.GenerateFragmentIfNotNull(node.FirstTableReference);
			List<TokenGenerator> valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<UnqualifiedJoinType, List<TokenGenerator>>(SqlScriptGeneratorVisitor._unqualifiedJoinTypeGenerators, node.UnqualifiedJoinType);
			if (valueForEnumKey != null)
			{
				this.GenerateSpace();
				this.GenerateTokenList(valueForEnumKey);
			}
			this.GenerateSpaceAndFragmentIfNotNull(node.SecondTableReference);
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x00030AF6 File Offset: 0x0002ECF6
		public override void ExplicitVisit(UpdateCall node)
		{
			this.GenerateKeyword(TSqlTokenType.Update);
			this.GenerateSpace();
			this.GenerateParenthesisedFragmentIfNotNull(node.Identifier);
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x00030B15 File Offset: 0x0002ED15
		public override void ExplicitVisit(UpdateForClause node)
		{
			this.GenerateKeyword(TSqlTokenType.Update);
			if (node.Columns.Count > 0)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.Of);
				this.GenerateSpace();
			}
			this.GenerateCommaSeparatedList<ColumnReferenceExpression>(node.Columns);
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x00030B4C File Offset: 0x0002ED4C
		public override void ExplicitVisit(UpdateStatement node)
		{
			AlignmentPoint ap = new AlignmentPoint();
			AlignmentPoint ap2 = new AlignmentPoint("ClauseBody");
			this.MarkAndPushAlignmentPoint(ap);
			if (node.WithCtesAndXmlNamespaces != null)
			{
				this.GenerateFragmentWithAlignmentPointIfNotNull(node.WithCtesAndXmlNamespaces, ap2);
				this.NewLine();
			}
			this.GenerateFragmentIfNotNull(node.UpdateSpecification);
			this.GenerateOptimizerHints(node.OptimizerHints);
			this.PopAlignmentPoint();
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x00030BAC File Offset: 0x0002EDAC
		public override void ExplicitVisit(UpdateSpecification node)
		{
			AlignmentPoint alignmentPoint = new AlignmentPoint("ClauseBody");
			this.GenerateKeyword(TSqlTokenType.Update);
			this.MarkClauseBodyAlignmentWhenNecessary(true, alignmentPoint);
			if (node.TopRowFilter != null)
			{
				this.GenerateSpaceAndFragmentIfNotNull(node.TopRowFilter);
				this.NewLine();
			}
			this.GenerateSpaceAndFragmentIfNotNull(node.Target);
			this.GenerateSetClauses(node.SetClauses, alignmentPoint);
			if (node.OutputIntoClause != null)
			{
				this.GenerateSeparatorForOutputClause();
				this.GenerateFragmentWithAlignmentPointIfNotNull(node.OutputIntoClause, alignmentPoint);
			}
			if (node.OutputClause != null)
			{
				this.GenerateSeparatorForOutputClause();
				this.GenerateFragmentWithAlignmentPointIfNotNull(node.OutputClause, alignmentPoint);
			}
			this.GenerateFromClause(node.FromClause, alignmentPoint);
			if (node.WhereClause != null)
			{
				this.GenerateSeparatorForWhereClause();
				this.GenerateFragmentWithAlignmentPointIfNotNull(node.WhereClause, alignmentPoint);
			}
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x00030C68 File Offset: 0x0002EE68
		public override void ExplicitVisit(UpdateStatisticsStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Update);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Statistics);
			this.GenerateSpaceAndFragmentIfNotNull(node.SchemaObjectName);
			if (node.SubElements.Count > 0)
			{
				this.GenerateSpace();
				this.GenerateParenthesisedCommaSeparatedList<Identifier>(node.SubElements);
			}
			if (node.StatisticsOptions.Count > 0)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.With);
				this.GenerateSpace();
				this.GenerateCommaSeparatedList<StatisticsOption>(node.StatisticsOptions);
			}
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x00030CE8 File Offset: 0x0002EEE8
		public override void ExplicitVisit(UpdateTextStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.UpdateText);
			this.GenerateSpace();
			this.GenerateBulkColumnTimestamp(node);
			this.GenerateSpaceAndFragmentIfNotNull(node.InsertOffset);
			this.GenerateSpaceAndFragmentIfNotNull(node.DeleteLength);
			this.NewLine();
			this.GenerateKeyword(TSqlTokenType.With);
			this.GenerateSpaceAndIdentifier("LOG");
			if (node.SourceColumn != null)
			{
				this.GenerateSpaceAndFragmentIfNotNull(node.SourceColumn);
			}
			this.GenerateSpaceAndFragmentIfNotNull(node.SourceParameter);
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x00030D64 File Offset: 0x0002EF64
		public override void ExplicitVisit(UseFederationStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Use);
			this.GenerateSpaceAndIdentifier("FEDERATION");
			if (node.FederationName == null)
			{
				this.GenerateSpaceAndIdentifier("ROOT");
				this.GenerateSpaceAndKeyword(TSqlTokenType.With);
			}
			else
			{
				this.GenerateSpaceAndFragmentIfNotNull(node.FederationName);
				this.GenerateSpaceAndSymbol(TSqlTokenType.LeftParenthesis);
				this.GenerateFragmentIfNotNull(node.DistributionName);
				this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
				this.GenerateSpaceAndFragmentIfNotNull(node.Value);
				this.GenerateSymbol(TSqlTokenType.RightParenthesis);
				this.GenerateSpaceAndKeyword(TSqlTokenType.With);
				this.GenerateSpaceAndIdentifier("FILTERING");
				this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
				if (node.Filtering)
				{
					this.GenerateSpaceAndKeyword(TSqlTokenType.On);
				}
				else
				{
					this.GenerateSpaceAndKeyword(TSqlTokenType.Off);
				}
				this.GenerateSymbol(TSqlTokenType.Comma);
			}
			this.GenerateSpaceAndIdentifier("RESET");
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x00030E40 File Offset: 0x0002F040
		public override void ExplicitVisit(UserDataTypeReference node)
		{
			this.GenerateFragmentIfNotNull(node.Name);
			this.GenerateParameters(node);
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x00030E55 File Offset: 0x0002F055
		public override void ExplicitVisit(UserDefinedTypePropertyAccess node)
		{
			this.GenerateFragmentIfNotNull(node.CallTarget);
			this.GenerateFragmentIfNotNull(node.PropertyName);
			this.GenerateSpaceAndCollation(node.Collation);
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x00030E7C File Offset: 0x0002F07C
		public override void ExplicitVisit(UserLoginOption node)
		{
			switch (node.UserLoginOptionType)
			{
			case UserLoginOptionType.Login:
				this.GenerateKeyword(TSqlTokenType.For);
				this.GenerateSpaceAndIdentifier("LOGIN");
				this.GenerateSpaceAndFragmentIfNotNull(node.Identifier);
				return;
			case UserLoginOptionType.Certificate:
				this.GenerateKeyword(TSqlTokenType.For);
				this.GenerateSpaceAndIdentifier("CERTIFICATE");
				this.GenerateSpaceAndFragmentIfNotNull(node.Identifier);
				return;
			case UserLoginOptionType.AsymmetricKey:
				this.GenerateKeyword(TSqlTokenType.For);
				this.GenerateSpaceAndIdentifier("ASYMMETRIC");
				this.GenerateSpaceAndKeyword(TSqlTokenType.Key);
				this.GenerateSpaceAndFragmentIfNotNull(node.Identifier);
				return;
			case UserLoginOptionType.WithoutLogin:
				this.GenerateIdentifier("WITHOUT");
				this.GenerateSpaceAndIdentifier("LOGIN");
				return;
			default:
				return;
			}
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x00030F25 File Offset: 0x0002F125
		public override void ExplicitVisit(UseStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.Use);
			this.GenerateSpaceAndFragmentIfNotNull(node.DatabaseName);
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x00030F40 File Offset: 0x0002F140
		public static TValue GetValueForEnumKey<TKey, TValue>(Dictionary<TKey, TValue> dict, TKey key) where TKey : struct, IConvertible
		{
			TValue result = default(TValue);
			dict.TryGetValue(key, out result);
			return result;
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x00030F60 File Offset: 0x0002F160
		protected void GenerateFragmentList<T>(IList<T> fragmentList) where T : TSqlFragment
		{
			bool flag = true;
			foreach (T t in fragmentList)
			{
				TSqlFragment fragment = t;
				if (flag)
				{
					flag = false;
				}
				else
				{
					this.GenerateSymbolAndSpace(TSqlTokenType.Comma);
				}
				this.GenerateFragmentIfNotNull(fragment);
			}
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x00030FC4 File Offset: 0x0002F1C4
		protected void GenerateOptionStateWithEqualSign(string optionName, OptionState optionState)
		{
			this.GenerateOptionState(optionName, optionState, true);
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x00030FCF File Offset: 0x0002F1CF
		protected void GenerateOptionState(string optionName, OptionState optionState)
		{
			this.GenerateOptionState(optionName, optionState, false);
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x00030FDA File Offset: 0x0002F1DA
		protected void GenerateOptionState(string optionName, OptionState optionState, bool generateEqualSign)
		{
			if (optionState != OptionState.NotSet)
			{
				this.GenerateIdentifier(optionName);
				if (generateEqualSign)
				{
					this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
				}
				this.GenerateSpace();
				this.GenerateOptionStateOnOff(optionState);
			}
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x00031001 File Offset: 0x0002F201
		protected void GenerateOptionStateOnOff(OptionState optionState)
		{
			if (optionState == OptionState.On)
			{
				this.GenerateKeyword(TSqlTokenType.On);
				return;
			}
			if (optionState == OptionState.Off)
			{
				this.GenerateKeyword(TSqlTokenType.Off);
			}
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x0003101C File Offset: 0x0002F21C
		protected void GenerateOptionStateInSql80Style(string optionName, OptionState optionState)
		{
			if (optionState == OptionState.On)
			{
				this.GenerateIdentifier(optionName);
			}
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x00031029 File Offset: 0x0002F229
		protected void GenerateNameEqualsValue(string name, TSqlFragment value)
		{
			this.GenerateTokenAndEqualSign(name);
			this.GenerateSpaceAndFragmentIfNotNull(value);
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x00031039 File Offset: 0x0002F239
		protected void GenerateNameEqualsValue(string name, string value)
		{
			this.GenerateTokenAndEqualSign(name);
			this.GenerateSpaceAndIdentifier(value);
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x00031049 File Offset: 0x0002F249
		protected void GenerateNameEqualsValue(TSqlTokenType keywordId, TSqlFragment value)
		{
			this.GenerateTokenAndEqualSign(keywordId);
			this.GenerateSpaceAndFragmentIfNotNull(value);
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x00031059 File Offset: 0x0002F259
		protected void GenerateNameEqualsValue(TSqlTokenType keywordId, string value)
		{
			this.GenerateTokenAndEqualSign(keywordId);
			this.GenerateSpaceAndIdentifier(value);
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x00031069 File Offset: 0x0002F269
		protected void GenerateNameEqualsValue(TokenGenerator generator, TSqlFragment value)
		{
			this.GenerateToken(generator);
			this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
			this.GenerateSpaceAndFragmentIfNotNull(value);
		}

		// Token: 0x06000FA3 RID: 4003 RVA: 0x00031084 File Offset: 0x0002F284
		protected void GenerateNameEqualsValue(TokenGenerator generator, string value)
		{
			this.GenerateToken(generator);
			this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
			this.GenerateSpaceAndIdentifier(value);
		}

		// Token: 0x06000FA4 RID: 4004 RVA: 0x0003109F File Offset: 0x0002F29F
		protected void GenerateTokenAndEqualSign(string idText)
		{
			this.GenerateIdentifierWithoutCasing(idText);
			this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x000310B3 File Offset: 0x0002F2B3
		protected void GenerateTokenAndEqualSign(TSqlTokenType keywordId)
		{
			this.GenerateKeyword(keywordId);
			this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x000310C7 File Offset: 0x0002F2C7
		protected void GenerateFragmentIfNotNull(TSqlFragment fragment)
		{
			if (fragment != null)
			{
				fragment.Accept(this);
			}
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x000310D3 File Offset: 0x0002F2D3
		protected void GenerateSpaceAndFragmentIfNotNull(TSqlFragment fragment)
		{
			if (fragment != null)
			{
				this.GenerateSpace();
				this.GenerateFragmentIfNotNull(fragment);
			}
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x000310E5 File Offset: 0x0002F2E5
		protected void GenerateParenthesisedFragmentIfNotNull(TSqlFragment fragment)
		{
			if (fragment != null)
			{
				this.GenerateSymbol(TSqlTokenType.LeftParenthesis);
				this.GenerateFragmentIfNotNull(fragment);
				this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			}
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x00031107 File Offset: 0x0002F307
		protected void GenerateCommaSeparatedList<T>(IList<T> list) where T : TSqlFragment
		{
			this.GenerateCommaSeparatedList<T>(list, false);
		}

		// Token: 0x06000FAA RID: 4010 RVA: 0x0003114C File Offset: 0x0002F34C
		protected void GenerateCommaSeparatedList<T>(IList<T> list, bool insertNewLine) where T : TSqlFragment
		{
			this.GenerateList<T>(list, delegate
			{
				this.GenerateSymbol(TSqlTokenType.Comma);
				if (insertNewLine)
				{
					this.NewLine();
					return;
				}
				this.GenerateSpace();
			});
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x0003118D File Offset: 0x0002F38D
		protected void GenerateDotSeparatedList<T>(IList<T> list) where T : TSqlFragment
		{
			this.GenerateList<T>(list, delegate
			{
				this.GenerateSymbol(TSqlTokenType.Dot);
			});
		}

		// Token: 0x06000FAC RID: 4012 RVA: 0x000311AA File Offset: 0x0002F3AA
		protected void GenerateSpaceSeparatedList<T>(IList<T> list) where T : TSqlFragment
		{
			this.GenerateList<T>(list, delegate
			{
				this.GenerateSpace();
			});
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x000311C0 File Offset: 0x0002F3C0
		private void GenerateList<T>(IList<T> list, Action gen) where T : TSqlFragment
		{
			if (list != null)
			{
				bool flag = true;
				foreach (T t in list)
				{
					if (flag)
					{
						flag = false;
					}
					else
					{
						gen();
					}
					this.GenerateFragmentIfNotNull(t);
				}
			}
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x00031220 File Offset: 0x0002F420
		protected void GenerateParenthesisedCommaSeparatedList<T>(IList<T> list) where T : TSqlFragment
		{
			this.GenerateParenthesisedCommaSeparatedList<T>(list, false);
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x0003122C File Offset: 0x0002F42C
		protected void GenerateParenthesisedCommaSeparatedList<T>(IList<T> list, bool alwaysGenerateParenthses) where T : TSqlFragment
		{
			if (list != null && list.Count > 0)
			{
				this.GenerateSymbol(TSqlTokenType.LeftParenthesis);
				this.GenerateCommaSeparatedList<T>(list);
				this.GenerateSymbol(TSqlTokenType.RightParenthesis);
				return;
			}
			if (alwaysGenerateParenthses)
			{
				this.GenerateSymbol(TSqlTokenType.LeftParenthesis);
				this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			}
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x0003127C File Offset: 0x0002F47C
		protected void GenerateFragmentList<T>(IList<T> list, SqlScriptGeneratorVisitor.ListGenerationOption option) where T : TSqlFragment
		{
			AlignmentPoint ap = new AlignmentPoint();
			AlignmentPoint ap2 = new AlignmentPoint();
			bool flag = option.AlwaysGenerateParenthesis || (list.Count > 0 && option.Parenthesised);
			if (flag)
			{
				if (option.NewLineBeforeOpenParenthesis)
				{
					this.NewLine();
				}
				else
				{
					this.GenerateSpace();
				}
				if (option.IndentParentheses)
				{
					this.Indent();
				}
				this.Mark(ap);
				this.GenerateSymbol(TSqlTokenType.LeftParenthesis);
				if (option.NewLineAfterOpenParenthesis)
				{
					this.NewLine();
				}
			}
			bool flag2 = true;
			foreach (T t in list)
			{
				if (flag2)
				{
					if (option.NewLineBeforeFirstItem && !option.NewLineAfterOpenParenthesis)
					{
						this.NewLine();
					}
					flag2 = false;
				}
				else
				{
					this.GenerateSeparator(option);
					if (option.NewLineBeforeItems)
					{
						this.NewLine();
					}
				}
				for (int i = 0; i < option.MultipleIndentItems; i++)
				{
					this.Indent();
				}
				if (option.NewLineBeforeItems)
				{
					this.Mark(ap2);
				}
				this.GenerateFragmentIfNotNull(t);
			}
			if (flag)
			{
				if (option.NewLineBeforeCloseParenthesis)
				{
					this.NewLine();
					if (option.AlignParentheses)
					{
						this.Mark(ap);
					}
				}
				this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			}
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x000313CC File Offset: 0x0002F5CC
		protected void GenerateAlignedParenthesizedOptionsWithMultipleIndent<T>(IList<T> list, int indentValue) where T : TSqlFragment
		{
			SqlScriptGeneratorVisitor.ListGenerationOption listGenerationOption = SqlScriptGeneratorVisitor.ListGenerationOption.CreateOptionFromFormattingConfig(this._options);
			listGenerationOption.AlignParentheses = true;
			listGenerationOption.MultipleIndentItems = indentValue;
			if (list.Count > 0)
			{
				this.GenerateFragmentList<T>(list, listGenerationOption);
				return;
			}
			this.GenerateParenthesisedCommaSeparatedList<T>(list, true);
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x0003140D File Offset: 0x0002F60D
		protected void GenerateAlignedParenthesizedOptions<T>(IList<T> list) where T : TSqlFragment
		{
			this.GenerateAlignedParenthesizedOptionsWithMultipleIndent<T>(list, 0);
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x00031418 File Offset: 0x0002F618
		private void GenerateSeparator(SqlScriptGeneratorVisitor.ListGenerationOption option)
		{
			switch (option.Separator)
			{
			case SqlScriptGeneratorVisitor.ListGenerationOption.SeparatorType.Comma:
				this.GenerateSymbol(TSqlTokenType.Comma);
				if (!option.NewLineBeforeItems)
				{
					this.GenerateSpace();
					return;
				}
				break;
			case SqlScriptGeneratorVisitor.ListGenerationOption.SeparatorType.Dot:
				this.GenerateSymbol(TSqlTokenType.Dot);
				return;
			case SqlScriptGeneratorVisitor.ListGenerationOption.SeparatorType.Space:
				this.GenerateSpace();
				break;
			default:
				return;
			}
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x0003146B File Offset: 0x0002F66B
		protected void GenerateSpace()
		{
			this._writer.AddToken(ScriptGeneratorSupporter.CreateWhitespaceToken(1));
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x0003147E File Offset: 0x0002F67E
		protected void GenerateKeyword(TSqlTokenType keywordId)
		{
			this._writer.AddKeyword(keywordId);
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x0003148C File Offset: 0x0002F68C
		protected void GenerateKeywordAndSpace(TSqlTokenType keywordId)
		{
			this.GenerateKeyword(keywordId);
			this.GenerateSpace();
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x0003149B File Offset: 0x0002F69B
		protected void GenerateSpaceAndKeyword(TSqlTokenType keywordId)
		{
			this.GenerateSpace();
			this.GenerateKeyword(keywordId);
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x000314AA File Offset: 0x0002F6AA
		protected void GenerateSymbol(TSqlTokenType symbolId)
		{
			this.GenerateKeyword(symbolId);
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x000314B4 File Offset: 0x0002F6B4
		protected void GenerateToken(TSqlTokenType tokenType, string text)
		{
			TSqlParserToken token = new TSqlParserToken(tokenType, text);
			this._writer.AddToken(token);
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x000314D5 File Offset: 0x0002F6D5
		protected void GenerateSpaceAndSymbol(TSqlTokenType symbolId)
		{
			this.GenerateSpace();
			this.GenerateSymbol(symbolId);
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x000314E4 File Offset: 0x0002F6E4
		protected void GenerateSymbolAndSpace(TSqlTokenType symbolId)
		{
			this.GenerateSymbol(symbolId);
			this.GenerateSpace();
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x000314F3 File Offset: 0x0002F6F3
		protected void GenerateIdentifier(string text)
		{
			this._writer.AddIdentifierWithCasing(text);
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x00031501 File Offset: 0x0002F701
		protected void GenerateIdentifierWithoutCheck(string text)
		{
			this._writer.AddIdentifierWithoutCasing(text);
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x0003150F File Offset: 0x0002F70F
		protected void GenerateIdentifierWithoutCasing(string text)
		{
			this._writer.AddIdentifierWithoutCasing(text);
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x0003151D File Offset: 0x0002F71D
		protected void GenerateSpaceAndIdentifier(string idText)
		{
			this.GenerateSpace();
			this.GenerateIdentifier(idText);
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x0003152C File Offset: 0x0002F72C
		protected void GenerateToken(TSqlTokenType tokenType, string text, bool applyCasing)
		{
			if (applyCasing)
			{
				text = ScriptGeneratorSupporter.GetCasedString(text, this._options.KeywordCasing);
			}
			TSqlParserToken token = new TSqlParserToken(tokenType, text);
			this._writer.AddToken(token);
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x00031564 File Offset: 0x0002F764
		protected void GenerateCommaSeparatedFlagOpitons<TKey>(Dictionary<TKey, TokenGenerator> optionsGenerators, TKey options) where TKey : struct, IConvertible
		{
			bool flag = true;
			ulong num = Convert.ToUInt64(options, CultureInfo.InvariantCulture);
			foreach (TKey tkey in optionsGenerators.Keys)
			{
				ulong num2 = Convert.ToUInt64(tkey, CultureInfo.InvariantCulture);
				if ((num2 & num) == num2)
				{
					TokenGenerator valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<TKey, TokenGenerator>(optionsGenerators, tkey);
					if (valueForEnumKey != null)
					{
						if (flag)
						{
							flag = false;
						}
						else
						{
							this.GenerateSymbolAndSpace(TSqlTokenType.Comma);
						}
						this.GenerateToken(valueForEnumKey);
					}
				}
			}
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x00031604 File Offset: 0x0002F804
		protected void GenerateToken(TokenGenerator generator)
		{
			generator.Generate(this._writer);
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x00031614 File Offset: 0x0002F814
		protected void GenerateTokenList(List<TokenGenerator> generatorList)
		{
			foreach (TokenGenerator tokenGenerator in generatorList)
			{
				tokenGenerator.Generate(this._writer);
			}
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x00031668 File Offset: 0x0002F868
		protected void GenerateSpaceSeparatedTokens(TSqlTokenType keywordId, params string[] identifiers)
		{
			this.GenerateKeyword(keywordId);
			foreach (string idText in identifiers)
			{
				this.GenerateSpaceAndIdentifier(idText);
			}
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x00031698 File Offset: 0x0002F898
		protected void GenerateSpaceSeparatedTokens(params TSqlTokenType[] keywords)
		{
			bool flag = true;
			foreach (TSqlTokenType keywordId in keywords)
			{
				if (flag)
				{
					flag = false;
				}
				else
				{
					this.GenerateSpace();
				}
				this.GenerateKeyword(keywordId);
			}
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x000316D0 File Offset: 0x0002F8D0
		protected void GenerateSpaceSeparatedTokens(params string[] identifiers)
		{
			bool flag = true;
			foreach (string text in identifiers)
			{
				if (flag)
				{
					flag = false;
				}
				else
				{
					this.GenerateSpace();
				}
				this.GenerateIdentifier(text);
			}
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x00031707 File Offset: 0x0002F907
		protected void GenerateFragmentWithAlignmentPointIfNotNull(TSqlFragment node, AlignmentPoint ap)
		{
			if (node != null && ap != null)
			{
				this.AddAlignmentPointForFragment(node, ap);
				this.GenerateFragmentIfNotNull(node);
				this.ClearAlignmentPointsForFragment(node);
			}
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x00031725 File Offset: 0x0002F925
		public override void ExplicitVisit(LiteralDatabaseOption node)
		{
			DatabaseOptionKindHelper.Instance.GenerateSourceForOption(this._writer, node.OptionKind);
			this.GenerateSpaceAndSymbol(TSqlTokenType.EqualsSign);
			this.GenerateSpaceAndFragmentIfNotNull(node.Value);
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x00031754 File Offset: 0x0002F954
		public override void ExplicitVisit(ValuesInsertSource node)
		{
			AlignmentPoint ap = new AlignmentPoint();
			this.MarkAndPushAlignmentPoint(ap);
			AlignmentPoint alignmentPointForFragment = this.GetAlignmentPointForFragment(node, "ClauseBody");
			if (node.IsDefaultValues)
			{
				this.GenerateKeyword(TSqlTokenType.Default);
				this.MarkClauseBodyAlignmentWhenNecessary(true, alignmentPointForFragment);
				this.GenerateSpaceAndKeyword(TSqlTokenType.Values);
			}
			else
			{
				this.GenerateKeywordAndSpace(TSqlTokenType.Values);
				this.MarkClauseBodyAlignmentWhenNecessary(true, alignmentPointForFragment);
				AlignmentPoint alignmentPointForFragment2 = this.GetAlignmentPointForFragment(node, "InsertColumns");
				this.MarkInsertColumnsAlignmentPointWhenNecessary(alignmentPointForFragment2);
				this.GenerateCommaSeparatedList<RowValue>(node.RowValues, true);
			}
			this.PopAlignmentPoint();
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x000317DA File Offset: 0x0002F9DA
		public override void ExplicitVisit(RowValue node)
		{
			this.GenerateParenthesisedCommaSeparatedList<ScalarExpression>(node.ColumnValues);
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x000317E8 File Offset: 0x0002F9E8
		public override void ExplicitVisit(VariableTableReference node)
		{
			this.GenerateFragmentIfNotNull(node.Variable);
			this.GenerateSpaceAndAlias(node.Alias);
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x00031802 File Offset: 0x0002FA02
		public override void ExplicitVisit(VariableMethodCallTableReference node)
		{
			this.GenerateFragmentIfNotNull(node.Variable);
			this.GenerateSymbol(TSqlTokenType.Dot);
			this.GenerateFragmentIfNotNull(node.MethodName);
			this.GenerateParenthesisedCommaSeparatedList<ScalarExpression>(node.Parameters, true);
			this.GenerateTableAndColumnAliases(node);
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x0003183C File Offset: 0x0002FA3C
		public override void ExplicitVisit(ViewOption node)
		{
			string valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<ViewOptionKind, string>(SqlScriptGeneratorVisitor._viewOptionTypeNames, node.OptionKind);
			if (valueForEnumKey != null)
			{
				this.GenerateIdentifier(valueForEnumKey);
			}
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x00031864 File Offset: 0x0002FA64
		protected void GenerateViewStatementBody(ViewStatementBody node)
		{
			this.GenerateKeyword(TSqlTokenType.View);
			this.GenerateSpaceAndFragmentIfNotNull(node.SchemaObjectName);
			if (node.Columns.Count > 0)
			{
				if (this._options.MultilineViewColumnsList)
				{
					SqlScriptGeneratorVisitor.ListGenerationOption option = SqlScriptGeneratorVisitor.ListGenerationOption.CreateOptionFromFormattingConfig(this._options);
					this.GenerateFragmentList<Identifier>(node.Columns, option);
				}
				else
				{
					this.GenerateSpace();
					this.GenerateParenthesisedCommaSeparatedList<Identifier>(node.Columns);
				}
			}
			if (node.ViewOptions.Count > 0)
			{
				this.NewLine();
				this.GenerateKeyword(TSqlTokenType.With);
				this.GenerateSpace();
				this.GenerateCommaSeparatedList<ViewOption>(node.ViewOptions);
			}
			this.GenerateNewLineOrSpace(this._options.AsKeywordOnOwnLine);
			this.GenerateKeyword(TSqlTokenType.As);
			this.NewLine();
			if (this._options.IndentViewBody)
			{
				this.Indent();
			}
			AlignmentPoint ap = new AlignmentPoint();
			this.MarkAndPushAlignmentPoint(ap);
			bool generateSemiColon = this._generateSemiColon;
			this._generateSemiColon = false;
			this.GenerateFragmentIfNotNull(node.SelectStatement);
			this._generateSemiColon = generateSemiColon;
			this.PopAlignmentPoint();
			if (node.WithCheckOption)
			{
				this.NewLine();
				this.GenerateKeyword(TSqlTokenType.With);
				this.GenerateSpaceAndKeyword(TSqlTokenType.Check);
				this.GenerateSpaceAndKeyword(TSqlTokenType.Option);
			}
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x00031990 File Offset: 0x0002FB90
		public override void ExplicitVisit(WaitForStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.WaitFor);
			if (node.WaitForOption == WaitForOption.Statement)
			{
				this.GenerateSpace();
				bool generateSemiColon = this._generateSemiColon;
				this._generateSemiColon = false;
				this.GenerateParenthesisedFragmentIfNotNull(node.Statement);
				this._generateSemiColon = generateSemiColon;
				if (node.Timeout != null)
				{
					this.GenerateSymbolAndSpace(TSqlTokenType.Comma);
					this.GenerateSpaceAndIdentifier("TIMEOUT");
					this.GenerateSpaceAndFragmentIfNotNull(node.Timeout);
					return;
				}
			}
			else
			{
				TokenGenerator valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<WaitForOption, TokenGenerator>(SqlScriptGeneratorVisitor._waitForOptionGenerators, node.WaitForOption);
				if (valueForEnumKey != null)
				{
					this.GenerateSpace();
					this.GenerateToken(valueForEnumKey);
				}
				this.GenerateSpaceAndFragmentIfNotNull(node.Parameter);
			}
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x00031A30 File Offset: 0x0002FC30
		public override void ExplicitVisit(SimpleWhenClause node)
		{
			this.GenerateKeyword(TSqlTokenType.When);
			this.GenerateSpaceAndFragmentIfNotNull(node.WhenExpression);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Then);
			this.GenerateSpaceAndFragmentIfNotNull(node.ThenExpression);
		}

		// Token: 0x06000FD1 RID: 4049 RVA: 0x00031A60 File Offset: 0x0002FC60
		public override void ExplicitVisit(SearchedWhenClause node)
		{
			this.GenerateKeyword(TSqlTokenType.When);
			this.GenerateSpaceAndFragmentIfNotNull(node.WhenExpression);
			this.GenerateSpaceAndKeyword(TSqlTokenType.Then);
			this.GenerateSpaceAndFragmentIfNotNull(node.ThenExpression);
		}

		// Token: 0x06000FD2 RID: 4050 RVA: 0x00031A90 File Offset: 0x0002FC90
		public override void ExplicitVisit(WhereClause node)
		{
			AlignmentPoint ap = new AlignmentPoint();
			this.MarkAndPushAlignmentPoint(ap);
			this.GenerateKeyword(TSqlTokenType.Where);
			AlignmentPoint alignmentPointForFragment = this.GetAlignmentPointForFragment(node, "ClauseBody");
			this.MarkClauseBodyAlignmentWhenNecessary(this._options.NewLineBeforeWhereClause, alignmentPointForFragment);
			if (node.SearchCondition != null)
			{
				this.GenerateSpaceAndFragmentIfNotNull(node.SearchCondition);
			}
			else
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.Current);
				this.GenerateSpaceAndKeyword(TSqlTokenType.Of);
				this.GenerateSpaceAndFragmentIfNotNull(node.Cursor);
			}
			this.PopAlignmentPoint();
		}

		// Token: 0x06000FD3 RID: 4051 RVA: 0x00031B0C File Offset: 0x0002FD0C
		public override void ExplicitVisit(WhileStatement node)
		{
			AlignmentPoint ap = new AlignmentPoint();
			this.GenerateKeyword(TSqlTokenType.While);
			this.GenerateSpaceAndFragmentIfNotNull(node.Predicate);
			this.NewLineAndIndent();
			this.MarkAndPushAlignmentPoint(ap);
			this.GenerateFragmentIfNotNull(node.Statement);
			this.GenerateSemiColonWhenNecessary(node.Statement);
			this.PopAlignmentPoint();
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x00031B64 File Offset: 0x0002FD64
		public override void ExplicitVisit(WindowFrameClause node)
		{
			switch (node.WindowFrameType)
			{
			case WindowFrameType.Rows:
				this.GenerateIdentifier("ROWS");
				break;
			case WindowFrameType.Range:
				this.GenerateIdentifier("RANGE");
				break;
			}
			if (node.Bottom != null)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.Between);
				this.GenerateSpaceAndFragmentIfNotNull(node.Top);
				this.GenerateSpaceAndKeyword(TSqlTokenType.And);
				this.GenerateSpaceAndFragmentIfNotNull(node.Bottom);
				return;
			}
			this.GenerateSpaceAndFragmentIfNotNull(node.Top);
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x00031BDC File Offset: 0x0002FDDC
		public override void ExplicitVisit(WindowDelimiter node)
		{
			switch (node.WindowDelimiterType)
			{
			case WindowDelimiterType.UnboundedPreceding:
				this.GenerateIdentifier("UNBOUNDED");
				this.GenerateSpaceAndIdentifier("PRECEDING");
				return;
			case WindowDelimiterType.ValuePreceding:
				this.GenerateFragmentIfNotNull(node.OffsetValue);
				this.GenerateSpaceAndIdentifier("PRECEDING");
				return;
			case WindowDelimiterType.CurrentRow:
				this.GenerateKeyword(TSqlTokenType.Current);
				this.GenerateSpaceAndIdentifier("ROW");
				return;
			case WindowDelimiterType.ValueFollowing:
				this.GenerateFragmentIfNotNull(node.OffsetValue);
				this.GenerateSpaceAndIdentifier("FOLLOWING");
				return;
			case WindowDelimiterType.UnboundedFollowing:
				this.GenerateIdentifier("UNBOUNDED");
				this.GenerateSpaceAndIdentifier("FOLLOWING");
				return;
			default:
				return;
			}
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x00031C7C File Offset: 0x0002FE7C
		public override void ExplicitVisit(WindowsCreateLoginSource node)
		{
			this.GenerateKeyword(TSqlTokenType.From);
			this.GenerateSpaceAndIdentifier("WINDOWS");
			if (node.Options != null && node.Options.Count > 0)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.With);
				this.GenerateSpace();
				this.GenerateCommaSeparatedList<PrincipalOption>(node.Options);
			}
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x00031CD0 File Offset: 0x0002FED0
		public override void ExplicitVisit(WithCtesAndXmlNamespaces node)
		{
			AlignmentPoint ap = new AlignmentPoint();
			this.MarkAndPushAlignmentPoint(ap);
			AlignmentPoint alignmentPointForFragment = this.GetAlignmentPointForFragment(node, "ClauseBody");
			this.GenerateKeyword(TSqlTokenType.With);
			if (node.ChangeTrackingContext != null)
			{
				this.GenerateSpaceAndIdentifier("CHANGE_TRACKING_CONTEXT");
				this.GenerateSpaceAndKeyword(TSqlTokenType.LeftParenthesis);
				this.GenerateFragmentIfNotNull(node.ChangeTrackingContext);
				this.GenerateKeyword(TSqlTokenType.RightParenthesis);
				if (node.CommonTableExpressions.Count > 0)
				{
					this.GenerateKeyword(TSqlTokenType.Comma);
				}
			}
			if (node.XmlNamespaces != null)
			{
				this.MarkClauseBodyAlignmentWhenNecessary(true, alignmentPointForFragment);
				this.GenerateSpaceAndFragmentIfNotNull(node.XmlNamespaces);
			}
			if (node.CommonTableExpressions.Count > 0)
			{
				if (node.XmlNamespaces != null)
				{
					this.GenerateSymbol(TSqlTokenType.Comma);
					this.NewLine();
				}
				foreach (CommonTableExpression node2 in node.CommonTableExpressions)
				{
					this.AddAlignmentPointForFragment(node2, alignmentPointForFragment);
				}
				this.GenerateCommaSeparatedList<CommonTableExpression>(node.CommonTableExpressions, true);
				foreach (CommonTableExpression node3 in node.CommonTableExpressions)
				{
					this.ClearAlignmentPointsForFragment(node3);
				}
			}
			this.PopAlignmentPoint();
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x00031E30 File Offset: 0x00030030
		public override void ExplicitVisit(WithinGroupClause node)
		{
			this.GenerateIdentifier("WITHIN");
			this.GenerateSpaceAndKeyword(TSqlTokenType.Group);
			this.GenerateSpaceAndSymbol(TSqlTokenType.LeftParenthesis);
			AlignmentPoint ap = new AlignmentPoint("ClauseBody");
			this.GenerateFragmentWithAlignmentPointIfNotNull(node.OrderByClause, ap);
			this.GenerateSymbol(TSqlTokenType.RightParenthesis);
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x00031E80 File Offset: 0x00030080
		public override void ExplicitVisit(WitnessDatabaseOption node)
		{
			this.GenerateIdentifier("WITNESS");
			this.GenerateSpace();
			if (node.WitnessServer != null)
			{
				this.GenerateSymbol(TSqlTokenType.EqualsSign);
				this.GenerateSpaceAndFragmentIfNotNull(node.WitnessServer);
				return;
			}
			if (node.IsOff)
			{
				this.GenerateSpaceAndKeyword(TSqlTokenType.Off);
			}
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x00031ED0 File Offset: 0x000300D0
		protected void GenerateWorkloadGroupStatementBody(WorkloadGroupStatement node)
		{
			AlignmentPoint ap = new AlignmentPoint();
			this.GenerateIdentifier("WORKLOAD");
			this.GenerateSpaceAndKeyword(TSqlTokenType.Group);
			this.GenerateSpaceAndFragmentIfNotNull(node.Name);
			if (node.WorkloadGroupParameters != null && node.WorkloadGroupParameters.Count > 0)
			{
				this.NewLineAndIndent();
				this.MarkAndPushAlignmentPoint(ap);
				this.GenerateKeyword(TSqlTokenType.With);
				this.GenerateSpace();
				this.GenerateAlignedParenthesizedOptionsWithMultipleIndent<WorkloadGroupParameter>(node.WorkloadGroupParameters, 2);
				this.PopAlignmentPoint();
			}
			if (node.PoolName != null)
			{
				this.NewLineAndIndent();
				this.MarkAndPushAlignmentPoint(ap);
				this.GenerateIdentifier("USING");
				this.GenerateSpaceAndFragmentIfNotNull(node.PoolName);
				this.PopAlignmentPoint();
			}
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x00031F7B File Offset: 0x0003017B
		public override void ExplicitVisit(WorkloadGroupResourceParameter node)
		{
			WorkloadGroupResourceParameterHelper.Instance.GenerateSourceForOption(this._writer, node.ParameterType);
			this.GenerateSpaceAndKeyword(TSqlTokenType.EqualsSign);
			this.GenerateSpaceAndFragmentIfNotNull(node.ParameterValue);
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x00031FAA File Offset: 0x000301AA
		public override void ExplicitVisit(WorkloadGroupImportanceParameter node)
		{
			this.GenerateIdentifier("IMPORTANCE");
			this.GenerateSpaceAndKeyword(TSqlTokenType.EqualsSign);
			this.GenerateSpace();
			ImportanceParameterHelper.Instance.GenerateSourceForOption(this._writer, node.ParameterValue);
		}

		// Token: 0x06000FDD RID: 4061 RVA: 0x00031FE0 File Offset: 0x000301E0
		public override void ExplicitVisit(WriteTextStatement node)
		{
			this.GenerateKeyword(TSqlTokenType.WriteText);
			this.GenerateSpace();
			this.GenerateBulkColumnTimestamp(node);
			if (node.WithLog)
			{
				this.NewLineAndIndent();
				this.GenerateKeyword(TSqlTokenType.With);
				this.GenerateSpaceAndIdentifier("LOG");
			}
			this.GenerateSpaceAndFragmentIfNotNull(node.SourceParameter);
		}

		// Token: 0x06000FDE RID: 4062 RVA: 0x00032035 File Offset: 0x00030235
		public override void ExplicitVisit(WsdlPayloadOption node)
		{
			if (node.IsNone)
			{
				this.GenerateNameEqualsValue("WSDL", "NONE");
				return;
			}
			this.GenerateNameEqualsValue("WSDL", node.Value);
		}

		// Token: 0x06000FDF RID: 4063 RVA: 0x00032064 File Offset: 0x00030264
		public override void ExplicitVisit(XmlDataTypeReference node)
		{
			this.GenerateIdentifier("XML");
			if (node.XmlSchemaCollection != null)
			{
				this.GenerateSymbol(TSqlTokenType.LeftParenthesis);
				TokenGenerator valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<XmlDataTypeOption, TokenGenerator>(SqlScriptGeneratorVisitor._xmlDataTypeOptionGenerators, node.XmlDataTypeOption);
				if (valueForEnumKey != null)
				{
					this.GenerateToken(valueForEnumKey);
				}
				this.GenerateSpaceAndFragmentIfNotNull(node.XmlSchemaCollection);
				this.GenerateSymbol(TSqlTokenType.RightParenthesis);
			}
		}

		// Token: 0x06000FE0 RID: 4064 RVA: 0x000320C1 File Offset: 0x000302C1
		public override void ExplicitVisit(XmlForClause node)
		{
			this.GenerateIdentifier("XML");
			this.GenerateSpace();
			this.GenerateCommaSeparatedList<XmlForClauseOption>(node.Options);
		}

		// Token: 0x06000FE1 RID: 4065 RVA: 0x000320E0 File Offset: 0x000302E0
		public override void ExplicitVisit(XmlForClauseOption node)
		{
			List<TokenGenerator> valueForEnumKey = SqlScriptGeneratorVisitor.GetValueForEnumKey<XmlForClauseOptions, List<TokenGenerator>>(SqlScriptGeneratorVisitor._xmlForClauseOptionsGenerators, node.OptionKind);
			if (valueForEnumKey != null)
			{
				this.GenerateTokenList(valueForEnumKey);
			}
			if (node.Value != null)
			{
				this.GenerateSpace();
				this.GenerateParenthesisedFragmentIfNotNull(node.Value);
			}
		}

		// Token: 0x06000FE2 RID: 4066 RVA: 0x00032122 File Offset: 0x00030322
		public override void ExplicitVisit(XmlNamespaces node)
		{
			this.GenerateIdentifier("XMLNAMESPACES");
			this.GenerateSpace();
			this.GenerateParenthesisedCommaSeparatedList<XmlNamespacesElement>(node.XmlNamespacesElements);
		}

		// Token: 0x06000FE3 RID: 4067 RVA: 0x00032141 File Offset: 0x00030341
		public override void ExplicitVisit(XmlNamespacesAliasElement node)
		{
			this.GenerateFragmentIfNotNull(node.String);
			this.GenerateSpaceAndKeyword(TSqlTokenType.As);
			this.GenerateSpaceAndFragmentIfNotNull(node.Identifier);
		}

		// Token: 0x06000FE4 RID: 4068 RVA: 0x00032163 File Offset: 0x00030363
		public override void ExplicitVisit(XmlNamespacesDefaultElement node)
		{
			this.GenerateKeyword(TSqlTokenType.Default);
			this.GenerateSpaceAndFragmentIfNotNull(node.String);
		}

		// Token: 0x04000FE9 RID: 4073
		protected const string ClauseBody = "ClauseBody";

		// Token: 0x04000FEA RID: 4074
		protected const string SetClauseItemFirstEqualSign = "SetClauseItemFirstEqualSign";

		// Token: 0x04000FEB RID: 4075
		protected const string SetClauseItemSecondEqualSign = "SetClauseItemSecondEqualSign";

		// Token: 0x04000FEC RID: 4076
		protected const string InsertColumns = "InsertColumns";

		// Token: 0x04000FED RID: 4077
		protected static Dictionary<EndpointState, string> _endpointStateNames = new Dictionary<EndpointState, string>
		{
			{
				EndpointState.Disabled,
				"DISABLED"
			},
			{
				EndpointState.Started,
				"STARTED"
			},
			{
				EndpointState.Stopped,
				"STOPPED"
			}
		};

		// Token: 0x04000FEE RID: 4078
		protected static Dictionary<EndpointProtocol, string> _endpointProtocolNames = new Dictionary<EndpointProtocol, string>
		{
			{
				EndpointProtocol.Http,
				"HTTP"
			},
			{
				EndpointProtocol.Tcp,
				"TCP"
			}
		};

		// Token: 0x04000FEF RID: 4079
		protected static Dictionary<EndpointType, string> _endpointTypeNames = new Dictionary<EndpointType, string>
		{
			{
				EndpointType.DatabaseMirroring,
				"DATABASE_MIRRORING"
			},
			{
				EndpointType.ServiceBroker,
				"SERVICE_BROKER"
			},
			{
				EndpointType.Soap,
				"SOAP"
			},
			{
				EndpointType.TSql,
				"TSQL"
			}
		};

		// Token: 0x04000FF0 RID: 4080
		protected static Dictionary<PayloadOptionKinds, TokenGenerator> _payloadOptionKindsGenerators = new Dictionary<PayloadOptionKinds, TokenGenerator>
		{
			{
				PayloadOptionKinds.Authentication,
				new IdentifierGenerator("AUTHENTICATION")
			},
			{
				PayloadOptionKinds.Batches,
				new IdentifierGenerator("BATCHES")
			},
			{
				PayloadOptionKinds.CharacterSet,
				new IdentifierGenerator("CHARACTER_SET")
			},
			{
				PayloadOptionKinds.Database,
				new KeywordGenerator(TSqlTokenType.Database)
			},
			{
				PayloadOptionKinds.Encryption,
				new IdentifierGenerator("ENCRYPTION")
			},
			{
				PayloadOptionKinds.HeaderLimit,
				new IdentifierGenerator("HEADER_LIMIT")
			},
			{
				PayloadOptionKinds.LoginType,
				new IdentifierGenerator("LOGIN_TYPE")
			},
			{
				PayloadOptionKinds.MessageForwardSize,
				new IdentifierGenerator("MESSAGE_FORWARD_SIZE")
			},
			{
				PayloadOptionKinds.MessageForwarding,
				new IdentifierGenerator("MESSAGE_FORWARDING")
			},
			{
				PayloadOptionKinds.Namespace,
				new IdentifierGenerator("NAMESPACE")
			},
			{
				PayloadOptionKinds.None,
				new EmptyGenerator()
			},
			{
				PayloadOptionKinds.Role,
				new IdentifierGenerator("ROLE")
			},
			{
				PayloadOptionKinds.Schema,
				new KeywordGenerator(TSqlTokenType.Schema)
			},
			{
				PayloadOptionKinds.SessionTimeout,
				new IdentifierGenerator("SESSION_TIMEOUT")
			},
			{
				PayloadOptionKinds.Sessions,
				new IdentifierGenerator("SESSIONS")
			},
			{
				PayloadOptionKinds.WebMethod,
				new IdentifierGenerator("WEBMETHOD")
			},
			{
				PayloadOptionKinds.Wsdl,
				new IdentifierGenerator("WSDL")
			}
		};

		// Token: 0x04000FF1 RID: 4081
		protected static Dictionary<SimpleAlterFullTextIndexActionKind, List<TokenGenerator>> _simpleAlterFulltextIndexActionKindActions = new Dictionary<SimpleAlterFullTextIndexActionKind, List<TokenGenerator>>
		{
			{
				SimpleAlterFullTextIndexActionKind.Disable,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("DISABLE")
				}
			},
			{
				SimpleAlterFullTextIndexActionKind.Enable,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("ENABLE")
				}
			},
			{
				SimpleAlterFullTextIndexActionKind.PausePopulation,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("PAUSE", true),
					new IdentifierGenerator("POPULATION")
				}
			},
			{
				SimpleAlterFullTextIndexActionKind.ResumePopulation,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("RESUME", true),
					new IdentifierGenerator("POPULATION")
				}
			},
			{
				SimpleAlterFullTextIndexActionKind.StopPopulation,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("STOP", true),
					new IdentifierGenerator("POPULATION")
				}
			},
			{
				SimpleAlterFullTextIndexActionKind.SetChangeTrackingAuto,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.Set, true),
					new IdentifierGenerator("CHANGE_TRACKING", true),
					new IdentifierGenerator("AUTO")
				}
			},
			{
				SimpleAlterFullTextIndexActionKind.SetChangeTrackingManual,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.Set, true),
					new IdentifierGenerator("CHANGE_TRACKING", true),
					new IdentifierGenerator("MANUAL")
				}
			},
			{
				SimpleAlterFullTextIndexActionKind.SetChangeTrackingOff,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.Set, true),
					new IdentifierGenerator("CHANGE_TRACKING", true),
					new KeywordGenerator(TSqlTokenType.Off)
				}
			},
			{
				SimpleAlterFullTextIndexActionKind.StartFullPopulation,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("START", true),
					new KeywordGenerator(TSqlTokenType.Full, true),
					new IdentifierGenerator("POPULATION")
				}
			},
			{
				SimpleAlterFullTextIndexActionKind.StartIncrementalPopulation,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("START", true),
					new IdentifierGenerator("INCREMENTAL", true),
					new IdentifierGenerator("POPULATION")
				}
			},
			{
				SimpleAlterFullTextIndexActionKind.StartUpdatePopulation,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("START", true),
					new KeywordGenerator(TSqlTokenType.Update, true),
					new IdentifierGenerator("POPULATION")
				}
			}
		};

		// Token: 0x04000FF2 RID: 4082
		private static Dictionary<AlterTableAlterColumnOption, List<TokenGenerator>> _alterTableAlterColumnOptionNames = new Dictionary<AlterTableAlterColumnOption, List<TokenGenerator>>
		{
			{
				AlterTableAlterColumnOption.AddRowGuidCol,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.Add, true),
					new KeywordGenerator(TSqlTokenType.RowGuidColumn)
				}
			},
			{
				AlterTableAlterColumnOption.DropRowGuidCol,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.Drop, true),
					new KeywordGenerator(TSqlTokenType.RowGuidColumn)
				}
			},
			{
				AlterTableAlterColumnOption.AddPersisted,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.Add, true),
					new IdentifierGenerator("PERSISTED")
				}
			},
			{
				AlterTableAlterColumnOption.DropPersisted,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.Drop, true),
					new IdentifierGenerator("PERSISTED")
				}
			},
			{
				AlterTableAlterColumnOption.AddNotForReplication,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.Add, true),
					new KeywordGenerator(TSqlTokenType.Not, true),
					new KeywordGenerator(TSqlTokenType.For, true),
					new KeywordGenerator(TSqlTokenType.Replication)
				}
			},
			{
				AlterTableAlterColumnOption.DropNotForReplication,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.Drop, true),
					new KeywordGenerator(TSqlTokenType.Not, true),
					new KeywordGenerator(TSqlTokenType.For, true),
					new KeywordGenerator(TSqlTokenType.Replication)
				}
			},
			{
				AlterTableAlterColumnOption.AddSparse,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.Add, true),
					new IdentifierGenerator("SPARSE")
				}
			},
			{
				AlterTableAlterColumnOption.DropSparse,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.Drop, true),
					new IdentifierGenerator("SPARSE")
				}
			}
		};

		// Token: 0x04000FF3 RID: 4083
		protected static Dictionary<TableElementType, TokenGenerator> _tableElementTypeGenerators = new Dictionary<TableElementType, TokenGenerator>
		{
			{
				TableElementType.Column,
				new KeywordGenerator(TSqlTokenType.Column)
			},
			{
				TableElementType.Constraint,
				new KeywordGenerator(TSqlTokenType.Constraint)
			},
			{
				TableElementType.NotSpecified,
				new EmptyGenerator()
			}
		};

		// Token: 0x04000FF4 RID: 4084
		protected static Dictionary<AuthenticationTypes, TokenGenerator> _authenticationTypesGenerators = new Dictionary<AuthenticationTypes, TokenGenerator>
		{
			{
				AuthenticationTypes.Basic,
				new IdentifierGenerator("BASIC")
			},
			{
				AuthenticationTypes.Digest,
				new IdentifierGenerator("DIGEST")
			},
			{
				AuthenticationTypes.Integrated,
				new IdentifierGenerator("INTEGRATED")
			},
			{
				AuthenticationTypes.Kerberos,
				new IdentifierGenerator("KERBEROS")
			},
			{
				AuthenticationTypes.Ntlm,
				new IdentifierGenerator("NTLM")
			}
		};

		// Token: 0x04000FF5 RID: 4085
		protected static Dictionary<AuthenticationProtocol, string> _authenticationProtocolNames = new Dictionary<AuthenticationProtocol, string>
		{
			{
				AuthenticationProtocol.Windows,
				"WINDOWS"
			},
			{
				AuthenticationProtocol.WindowsKerberos,
				"KERBEROS"
			},
			{
				AuthenticationProtocol.WindowsNegotiate,
				"NEGOTIATE"
			},
			{
				AuthenticationProtocol.WindowsNtlm,
				"NTLM"
			}
		};

		// Token: 0x04000FF6 RID: 4086
		protected static Dictionary<DialogOptionKind, string> _dialogOptionNames = new Dictionary<DialogOptionKind, string>
		{
			{
				DialogOptionKind.Lifetime,
				"LIFETIME"
			},
			{
				DialogOptionKind.RelatedConversation,
				"RELATED_CONVERSATION"
			},
			{
				DialogOptionKind.RelatedConversationGroup,
				"RELATED_CONVERSATION_GROUP"
			}
		};

		// Token: 0x04000FF7 RID: 4087
		protected static Dictionary<BinaryQueryExpressionType, TokenGenerator> _binaryQueryExpressionTypeGenerators = new Dictionary<BinaryQueryExpressionType, TokenGenerator>
		{
			{
				BinaryQueryExpressionType.Except,
				new KeywordGenerator(TSqlTokenType.Except)
			},
			{
				BinaryQueryExpressionType.Intersect,
				new KeywordGenerator(TSqlTokenType.Intersect)
			},
			{
				BinaryQueryExpressionType.Union,
				new KeywordGenerator(TSqlTokenType.Union)
			}
		};

		// Token: 0x04000FF8 RID: 4088
		protected static Dictionary<BooleanTernaryExpressionType, List<TokenGenerator>> _ternaryExpressionTypeGenerators = new Dictionary<BooleanTernaryExpressionType, List<TokenGenerator>>
		{
			{
				BooleanTernaryExpressionType.Between,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.Between)
				}
			},
			{
				BooleanTernaryExpressionType.NotBetween,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.Not, true),
					new KeywordGenerator(TSqlTokenType.Between)
				}
			}
		};

		// Token: 0x04000FF9 RID: 4089
		private static Dictionary<CertificateOptionKinds, string> _certificateOptionNames = new Dictionary<CertificateOptionKinds, string>
		{
			{
				CertificateOptionKinds.Subject,
				"SUBJECT"
			},
			{
				CertificateOptionKinds.StartDate,
				"START_DATE"
			},
			{
				CertificateOptionKinds.ExpiryDate,
				"EXPIRY_DATE"
			}
		};

		// Token: 0x04000FFA RID: 4090
		private static readonly Array _commandOptions = Enum.GetValues(typeof(CommandOptions));

		// Token: 0x04000FFB RID: 4091
		protected static Dictionary<BinaryExpressionType, List<TokenGenerator>> _binaryExpressionTypeGenerators = new Dictionary<BinaryExpressionType, List<TokenGenerator>>
		{
			{
				BinaryExpressionType.Add,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.Plus)
				}
			},
			{
				BinaryExpressionType.Subtract,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.Minus)
				}
			},
			{
				BinaryExpressionType.Multiply,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.Star)
				}
			},
			{
				BinaryExpressionType.Divide,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.Divide)
				}
			},
			{
				BinaryExpressionType.Modulo,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.PercentSign)
				}
			},
			{
				BinaryExpressionType.BitwiseAnd,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.Ampersand)
				}
			},
			{
				BinaryExpressionType.BitwiseOr,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.VerticalLine)
				}
			},
			{
				BinaryExpressionType.BitwiseXor,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.Circumflex)
				}
			}
		};

		// Token: 0x04000FFC RID: 4092
		protected static Dictionary<BooleanComparisonType, List<TokenGenerator>> _booleanComparisonTypeGenerators = new Dictionary<BooleanComparisonType, List<TokenGenerator>>
		{
			{
				BooleanComparisonType.Equals,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.EqualsSign)
				}
			},
			{
				BooleanComparisonType.GreaterThan,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.GreaterThan)
				}
			},
			{
				BooleanComparisonType.LessThan,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.LessThan)
				}
			},
			{
				BooleanComparisonType.GreaterThanOrEqualTo,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.GreaterThan),
					new KeywordGenerator(TSqlTokenType.EqualsSign)
				}
			},
			{
				BooleanComparisonType.LessThanOrEqualTo,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.LessThan),
					new KeywordGenerator(TSqlTokenType.EqualsSign)
				}
			},
			{
				BooleanComparisonType.NotEqualToBrackets,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.LessThan),
					new KeywordGenerator(TSqlTokenType.GreaterThan)
				}
			},
			{
				BooleanComparisonType.NotEqualToExclamation,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.Bang),
					new KeywordGenerator(TSqlTokenType.EqualsSign)
				}
			},
			{
				BooleanComparisonType.NotLessThan,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.Bang),
					new KeywordGenerator(TSqlTokenType.LessThan)
				}
			},
			{
				BooleanComparisonType.NotGreaterThan,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.Bang),
					new KeywordGenerator(TSqlTokenType.GreaterThan)
				}
			},
			{
				BooleanComparisonType.LeftOuterJoin,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.MultiplyEquals)
				}
			},
			{
				BooleanComparisonType.RightOuterJoin,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.RightOuterJoin)
				}
			}
		};

		// Token: 0x04000FFD RID: 4093
		protected static Dictionary<BooleanBinaryExpressionType, List<TokenGenerator>> _booleanBinaryExpressionTypeGenerators = new Dictionary<BooleanBinaryExpressionType, List<TokenGenerator>>
		{
			{
				BooleanBinaryExpressionType.And,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.And)
				}
			},
			{
				BooleanBinaryExpressionType.Or,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.Or)
				}
			}
		};

		// Token: 0x04000FFE RID: 4094
		protected bool _generateSemiColon = true;

		// Token: 0x04000FFF RID: 4095
		private static Dictionary<DeleteUpdateAction, List<TokenGenerator>> _deleteUpdateActionGenerators = new Dictionary<DeleteUpdateAction, List<TokenGenerator>>
		{
			{
				DeleteUpdateAction.Cascade,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.Cascade)
				}
			},
			{
				DeleteUpdateAction.NoAction,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("NO", true),
					new IdentifierGenerator("ACTION")
				}
			},
			{
				DeleteUpdateAction.SetDefault,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.Set, true),
					new KeywordGenerator(TSqlTokenType.Default)
				}
			},
			{
				DeleteUpdateAction.SetNull,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.Set, true),
					new KeywordGenerator(TSqlTokenType.Null)
				}
			}
		};

		// Token: 0x04001000 RID: 4096
		protected static Dictionary<MessageSender, TokenGenerator> _messageSenderGenerators = new Dictionary<MessageSender, TokenGenerator>
		{
			{
				MessageSender.None,
				new EmptyGenerator()
			},
			{
				MessageSender.Any,
				new KeywordGenerator(TSqlTokenType.Any)
			},
			{
				MessageSender.Initiator,
				new IdentifierGenerator("INITIATOR")
			},
			{
				MessageSender.Target,
				new IdentifierGenerator("TARGET")
			}
		};

		// Token: 0x04001001 RID: 4097
		protected static Dictionary<PermissionSetOption, string> _permissionSetOptionNames = new Dictionary<PermissionSetOption, string>
		{
			{
				PermissionSetOption.ExternalAccess,
				"EXTERNAL_ACCESS"
			},
			{
				PermissionSetOption.Safe,
				"SAFE"
			},
			{
				PermissionSetOption.Unsafe,
				"UNSAFE"
			}
		};

		// Token: 0x04001002 RID: 4098
		private static Dictionary<AttachMode, TokenGenerator> _attachModeGenerators = new Dictionary<AttachMode, TokenGenerator>
		{
			{
				AttachMode.Attach,
				new IdentifierGenerator("ATTACH")
			},
			{
				AttachMode.AttachForceRebuildLog,
				new IdentifierGenerator("ATTACH_FORCE_REBUILD_LOG")
			},
			{
				AttachMode.AttachRebuildLog,
				new IdentifierGenerator("ATTACH_REBUILD_LOG")
			},
			{
				AttachMode.Load,
				new KeywordGenerator(TSqlTokenType.Load)
			}
		};

		// Token: 0x04001003 RID: 4099
		private static Dictionary<SecondaryXmlIndexType, string> _secondaryXmlIndexTypeNames = new Dictionary<SecondaryXmlIndexType, string>
		{
			{
				SecondaryXmlIndexType.Path,
				"PATH"
			},
			{
				SecondaryXmlIndexType.Property,
				"PROPERTY"
			},
			{
				SecondaryXmlIndexType.Value,
				"VALUE"
			}
		};

		// Token: 0x04001004 RID: 4100
		protected SqlScriptGeneratorOptions _options;

		// Token: 0x04001005 RID: 4101
		protected ScriptWriter _writer;

		// Token: 0x04001006 RID: 4102
		private Dictionary<TSqlFragment, Dictionary<string, AlignmentPoint>> _alignmentPointsForFragments;

		// Token: 0x04001007 RID: 4103
		private static Dictionary<CursorOptionKind, string> _cursorOptionsNames = new Dictionary<CursorOptionKind, string>
		{
			{
				CursorOptionKind.Local,
				"LOCAL"
			},
			{
				CursorOptionKind.Global,
				"GLOBAL"
			},
			{
				CursorOptionKind.Scroll,
				"SCROLL"
			},
			{
				CursorOptionKind.ForwardOnly,
				"FORWARD_ONLY"
			},
			{
				CursorOptionKind.Insensitive,
				"INSENSITIVE"
			},
			{
				CursorOptionKind.Keyset,
				"KEYSET"
			},
			{
				CursorOptionKind.Dynamic,
				"DYNAMIC"
			},
			{
				CursorOptionKind.FastForward,
				"FAST_FORWARD"
			},
			{
				CursorOptionKind.ScrollLocks,
				"SCROLL_LOCKS"
			},
			{
				CursorOptionKind.Optimistic,
				"OPTIMISTIC"
			},
			{
				CursorOptionKind.ReadOnly,
				"READ_ONLY"
			},
			{
				CursorOptionKind.Static,
				"STATIC"
			},
			{
				CursorOptionKind.TypeWarning,
				"TYPE_WARNING"
			}
		};

		// Token: 0x04001008 RID: 4104
		private static Dictionary<DatabaseAuditActionKind, TokenGenerator> _databaseAuditActionName = new Dictionary<DatabaseAuditActionKind, TokenGenerator>
		{
			{
				DatabaseAuditActionKind.Select,
				new KeywordGenerator(TSqlTokenType.Select)
			},
			{
				DatabaseAuditActionKind.Update,
				new KeywordGenerator(TSqlTokenType.Update)
			},
			{
				DatabaseAuditActionKind.Insert,
				new KeywordGenerator(TSqlTokenType.Insert)
			},
			{
				DatabaseAuditActionKind.Delete,
				new KeywordGenerator(TSqlTokenType.Delete)
			},
			{
				DatabaseAuditActionKind.Execute,
				new KeywordGenerator(TSqlTokenType.Execute)
			},
			{
				DatabaseAuditActionKind.Receive,
				new IdentifierGenerator("RECEIVE")
			},
			{
				DatabaseAuditActionKind.References,
				new KeywordGenerator(TSqlTokenType.References)
			}
		};

		// Token: 0x04001009 RID: 4105
		private static Dictionary<DbccCommand, string> _dbccCommandNames = new Dictionary<DbccCommand, string>
		{
			{
				DbccCommand.ActiveCursors,
				"ACTIVECURSORS"
			},
			{
				DbccCommand.AddExtendedProc,
				"ADDEXTENDEDPROC"
			},
			{
				DbccCommand.AddInstance,
				"ADDINSTANCE"
			},
			{
				DbccCommand.AuditEvent,
				"AUDITEVENT"
			},
			{
				DbccCommand.AutoPilot,
				"AUTOPILOT"
			},
			{
				DbccCommand.Buffer,
				"BUFFER"
			},
			{
				DbccCommand.Bytes,
				"BYTES"
			},
			{
				DbccCommand.CacheProfile,
				"CACHEPROFILE"
			},
			{
				DbccCommand.CacheStats,
				"CACHESTATS"
			},
			{
				DbccCommand.CallFullText,
				"CALLFULLTEXT"
			},
			{
				DbccCommand.CheckAlloc,
				"CHECKALLOC"
			},
			{
				DbccCommand.CheckCatalog,
				"CHECKCATALOG"
			},
			{
				DbccCommand.CheckConstraints,
				"CHECKCONSTRAINTS"
			},
			{
				DbccCommand.CheckDB,
				"CHECKDB"
			},
			{
				DbccCommand.CheckFileGroup,
				"CHECKFILEGROUP"
			},
			{
				DbccCommand.CheckIdent,
				"CHECKIDENT"
			},
			{
				DbccCommand.CheckPrimaryFile,
				"CHECKPRIMARYFILE"
			},
			{
				DbccCommand.CheckTable,
				"CHECKTABLE"
			},
			{
				DbccCommand.CleanTable,
				"CLEANTABLE"
			},
			{
				DbccCommand.ClearSpaceCaches,
				"CLEARSPACECACHES"
			},
			{
				DbccCommand.CollectStats,
				"COLLECTSTATS"
			},
			{
				DbccCommand.ConcurrencyViolation,
				"CONCURRENCYVIOLATION"
			},
			{
				DbccCommand.CursorStats,
				"CURSORSTATS"
			},
			{
				DbccCommand.DBRecover,
				"DBRECOVER"
			},
			{
				DbccCommand.DBReindex,
				"DBREINDEX"
			},
			{
				DbccCommand.DBReindexAll,
				"DBREINDEXALL"
			},
			{
				DbccCommand.DBRepair,
				"DBREPAIR"
			},
			{
				DbccCommand.DebugBreak,
				"DEBUGBREAK"
			},
			{
				DbccCommand.DeleteInstance,
				"DELETEINSTANCE"
			},
			{
				DbccCommand.DetachDB,
				"DETACHDB"
			},
			{
				DbccCommand.DropCleanBuffers,
				"DROPCLEANBUFFERS"
			},
			{
				DbccCommand.DropExtendedProc,
				"DROPEXTENDEDPROC"
			},
			{
				DbccCommand.DumpConfig,
				"CONFIG"
			},
			{
				DbccCommand.DumpDBInfo,
				"DBINFO"
			},
			{
				DbccCommand.DumpDBTable,
				"DBTABLE"
			},
			{
				DbccCommand.DumpLock,
				"LOCK"
			},
			{
				DbccCommand.DumpLog,
				"LOG"
			},
			{
				DbccCommand.DumpPage,
				"PAGE"
			},
			{
				DbccCommand.DumpResource,
				"RESOURCE"
			},
			{
				DbccCommand.DumpTrigger,
				"DUMPTRIGGER"
			},
			{
				DbccCommand.ErrorLog,
				"ERRORLOG"
			},
			{
				DbccCommand.ExtentInfo,
				"EXTENTINFO"
			},
			{
				DbccCommand.FileHeader,
				"FILEHEADER"
			},
			{
				DbccCommand.FixAllocation,
				"FIXALLOCATION"
			},
			{
				DbccCommand.Flush,
				"FLUSH"
			},
			{
				DbccCommand.FlushProcInDB,
				"FLUSHPROCINDB"
			},
			{
				DbccCommand.ForceGhostCleanup,
				"FORCEGHOSTCLEANUP"
			},
			{
				DbccCommand.Free,
				"FREE"
			},
			{
				DbccCommand.FreeProcCache,
				"FREEPROCCACHE"
			},
			{
				DbccCommand.FreeSessionCache,
				"FREESESSIONCACHE"
			},
			{
				DbccCommand.FreeSystemCache,
				"FREESYSTEMCACHE"
			},
			{
				DbccCommand.FreezeIO,
				"FREEZE_IO"
			},
			{
				DbccCommand.Help,
				"HELP"
			},
			{
				DbccCommand.IcecapQuery,
				"ICECAPQUERY"
			},
			{
				DbccCommand.IncrementInstance,
				"INCREMENTINSTANCE"
			},
			{
				DbccCommand.Ind,
				"IND"
			},
			{
				DbccCommand.IndexDefrag,
				"INDEXDEFRAG"
			},
			{
				DbccCommand.InputBuffer,
				"INPUTBUFFER"
			},
			{
				DbccCommand.InvalidateTextptr,
				"INVALIDATE_TEXTPTR"
			},
			{
				DbccCommand.InvalidateTextptrObjid,
				"INVALIDATE_TEXTPTR_OBJID"
			},
			{
				DbccCommand.Latch,
				"LATCH"
			},
			{
				DbccCommand.LogInfo,
				"LOGINFO"
			},
			{
				DbccCommand.MapAllocUnit,
				"MAPALLOCUNIT"
			},
			{
				DbccCommand.MemObjList,
				"MEMOBJLIST"
			},
			{
				DbccCommand.MemoryMap,
				"MEMORYMAP"
			},
			{
				DbccCommand.MemoryStatus,
				"MEMORYSTATUS"
			},
			{
				DbccCommand.Metadata,
				"METADATA"
			},
			{
				DbccCommand.MovePage,
				"MOVEPAGE"
			},
			{
				DbccCommand.NoTextptr,
				"NO_TEXTPTR"
			},
			{
				DbccCommand.OpenTran,
				"OPENTRAN"
			},
			{
				DbccCommand.OptimizerWhatIf,
				"OPTIMIZER_WHATIF"
			},
			{
				DbccCommand.OutputBuffer,
				"OUTPUTBUFFER"
			},
			{
				DbccCommand.PerfMonStats,
				"PERFMON"
			},
			{
				DbccCommand.PersistStackHash,
				"PERSISTSTACKHASH"
			},
			{
				DbccCommand.PinTable,
				"PINTABLE"
			},
			{
				DbccCommand.ProcCache,
				"PROCCACHE"
			},
			{
				DbccCommand.PrtiPage,
				"PRTIPAGE"
			},
			{
				DbccCommand.ReadPage,
				"READPAGE"
			},
			{
				DbccCommand.RenameColumn,
				"RENAMECOLUMN"
			},
			{
				DbccCommand.RuleOff,
				"RULEOFF"
			},
			{
				DbccCommand.RuleOn,
				"RULEON"
			},
			{
				DbccCommand.SeMetadata,
				"SEMETADATA"
			},
			{
				DbccCommand.SetCpuWeight,
				"SETCPUWEIGHT"
			},
			{
				DbccCommand.SetInstance,
				"SETINSTANCE"
			},
			{
				DbccCommand.SetIOWeight,
				"SETIOWEIGHT"
			},
			{
				DbccCommand.ShowStatistics,
				"SHOW_STATISTICS"
			},
			{
				DbccCommand.ShowContig,
				"SHOWCONTIG"
			},
			{
				DbccCommand.ShowDBAffinity,
				"SHOWDBAFFINITY"
			},
			{
				DbccCommand.ShowFileStats,
				"SHOWFILESTATS"
			},
			{
				DbccCommand.ShowOffRules,
				"SHOWOFFRULES"
			},
			{
				DbccCommand.ShowOnRules,
				"SHOWONRULES"
			},
			{
				DbccCommand.ShowTableAffinity,
				"SHOWTABLEAFFINITY"
			},
			{
				DbccCommand.ShowText,
				"SHOWTEXT"
			},
			{
				DbccCommand.ShowWeights,
				"SHOWWEIGHTS"
			},
			{
				DbccCommand.ShrinkDatabase,
				"SHRINKDATABASE"
			},
			{
				DbccCommand.ShrinkFile,
				"SHRINKFILE"
			},
			{
				DbccCommand.SqlMgrStats,
				"SQLMGRSTATS"
			},
			{
				DbccCommand.SqlPerf,
				"SQLPERF"
			},
			{
				DbccCommand.StackDump,
				"STACKDUMP"
			},
			{
				DbccCommand.Tec,
				"TEC"
			},
			{
				DbccCommand.ThawIO,
				"THAW_IO"
			},
			{
				DbccCommand.TraceOff,
				"TRACEOFF"
			},
			{
				DbccCommand.TraceOn,
				"TRACEON"
			},
			{
				DbccCommand.TraceStatus,
				"TRACESTATUS"
			},
			{
				DbccCommand.UnpinTable,
				"UNPINTABLE"
			},
			{
				DbccCommand.UpdateUsage,
				"UPDATEUSAGE"
			},
			{
				DbccCommand.UsePlan,
				"USEPLAN"
			},
			{
				DbccCommand.UserOptions,
				"USEROPTIONS"
			},
			{
				DbccCommand.WritePage,
				"WRITEPAGE"
			}
		};

		// Token: 0x0400100A RID: 4106
		private static Dictionary<DbccOptionKind, TokenGenerator> _dbccOptionsGenerators = new Dictionary<DbccOptionKind, TokenGenerator>
		{
			{
				DbccOptionKind.AllErrorMessages,
				new IdentifierGenerator("ALL_ERRORMSGS")
			},
			{
				DbccOptionKind.CountRows,
				new IdentifierGenerator("COUNT_ROWS")
			},
			{
				DbccOptionKind.NoInfoMessages,
				new IdentifierGenerator("NO_INFOMSGS")
			},
			{
				DbccOptionKind.TableResults,
				new IdentifierGenerator("TABLERESULTS")
			},
			{
				DbccOptionKind.TabLock,
				new IdentifierGenerator("TABLOCK")
			},
			{
				DbccOptionKind.StatHeader,
				new IdentifierGenerator("STAT_HEADER")
			},
			{
				DbccOptionKind.DensityVector,
				new IdentifierGenerator("DENSITY_VECTOR")
			},
			{
				DbccOptionKind.HistogramSteps,
				new IdentifierGenerator("HISTOGRAM_STEPS")
			},
			{
				DbccOptionKind.EstimateOnly,
				new IdentifierGenerator("ESTIMATEONLY")
			},
			{
				DbccOptionKind.Fast,
				new IdentifierGenerator("FAST")
			},
			{
				DbccOptionKind.AllLevels,
				new IdentifierGenerator("ALL_LEVELS")
			},
			{
				DbccOptionKind.AllIndexes,
				new IdentifierGenerator("ALL_INDEXES")
			},
			{
				DbccOptionKind.PhysicalOnly,
				new IdentifierGenerator("PHYSICAL_ONLY")
			},
			{
				DbccOptionKind.AllConstraints,
				new IdentifierGenerator("ALL_CONSTRAINTS")
			},
			{
				DbccOptionKind.StatsStream,
				new IdentifierGenerator("STATS_STREAM")
			},
			{
				DbccOptionKind.Histogram,
				new IdentifierGenerator("HISTOGRAM")
			},
			{
				DbccOptionKind.DataPurity,
				new IdentifierGenerator("DATA_PURITY")
			},
			{
				DbccOptionKind.MarkInUseForRemoval,
				new IdentifierGenerator("MARK_IN_USE_FOR_REMOVAL")
			},
			{
				DbccOptionKind.ExtendedLogicalChecks,
				new IdentifierGenerator("EXTENDED_LOGICAL_CHECKS")
			}
		};

		// Token: 0x0400100B RID: 4107
		private static Dictionary<DeviceType, TokenGenerator> _deviceTypeGenerators = new Dictionary<DeviceType, TokenGenerator>
		{
			{
				DeviceType.DatabaseSnapshot,
				new IdentifierGenerator("DATABASE_SNAPSHOT")
			},
			{
				DeviceType.Disk,
				new KeywordGenerator(TSqlTokenType.Disk)
			},
			{
				DeviceType.Tape,
				new IdentifierGenerator("TAPE")
			},
			{
				DeviceType.VirtualDevice,
				new IdentifierGenerator("VIRTUAL_DEVICE")
			}
		};

		// Token: 0x0400100C RID: 4108
		protected static Dictionary<DropClusteredConstraintOptionKind, List<TokenGenerator>> _dropClusteredConstraintOptionTypeGenerators = new Dictionary<DropClusteredConstraintOptionKind, List<TokenGenerator>>
		{
			{
				DropClusteredConstraintOptionKind.MaxDop,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("MAXDOP", true),
					new KeywordGenerator(TSqlTokenType.EqualsSign)
				}
			},
			{
				DropClusteredConstraintOptionKind.MoveTo,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("MOVE", true),
					new KeywordGenerator(TSqlTokenType.To)
				}
			},
			{
				DropClusteredConstraintOptionKind.Online,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("ONLINE", true),
					new KeywordGenerator(TSqlTokenType.EqualsSign)
				}
			}
		};

		// Token: 0x0400100D RID: 4109
		protected static Dictionary<EndpointEncryptionSupport, TokenGenerator> _endpointEncryptionSupportGenerators = new Dictionary<EndpointEncryptionSupport, TokenGenerator>
		{
			{
				EndpointEncryptionSupport.Disabled,
				new IdentifierGenerator("DISABLED")
			},
			{
				EndpointEncryptionSupport.NotSpecified,
				new EmptyGenerator()
			},
			{
				EndpointEncryptionSupport.Required,
				new IdentifierGenerator("REQUIRED")
			},
			{
				EndpointEncryptionSupport.Supported,
				new IdentifierGenerator("SUPPORTED")
			}
		};

		// Token: 0x0400100E RID: 4110
		private static Dictionary<ExecuteAsOption, TokenGenerator> _executeAsOptionGenerators = new Dictionary<ExecuteAsOption, TokenGenerator>
		{
			{
				ExecuteAsOption.Caller,
				new IdentifierGenerator("CALLER")
			},
			{
				ExecuteAsOption.Login,
				new IdentifierGenerator("LOGIN")
			},
			{
				ExecuteAsOption.Owner,
				new IdentifierGenerator("OWNER")
			},
			{
				ExecuteAsOption.Self,
				new IdentifierGenerator("SELF")
			},
			{
				ExecuteAsOption.User,
				new KeywordGenerator(TSqlTokenType.User)
			}
		};

		// Token: 0x0400100F RID: 4111
		protected static Dictionary<SortOrder, TokenGenerator> _sortOrderGenerators = new Dictionary<SortOrder, TokenGenerator>
		{
			{
				SortOrder.Ascending,
				new KeywordGenerator(TSqlTokenType.Asc)
			},
			{
				SortOrder.Descending,
				new KeywordGenerator(TSqlTokenType.Desc)
			},
			{
				SortOrder.NotSpecified,
				new EmptyGenerator()
			}
		};

		// Token: 0x04001010 RID: 4112
		private static Dictionary<FetchOrientation, string> _fetchOrientationNames = new Dictionary<FetchOrientation, string>
		{
			{
				FetchOrientation.Absolute,
				"ABSOLUTE"
			},
			{
				FetchOrientation.First,
				"FIRST"
			},
			{
				FetchOrientation.Last,
				"LAST"
			},
			{
				FetchOrientation.Next,
				"NEXT"
			},
			{
				FetchOrientation.Prior,
				"PRIOR"
			},
			{
				FetchOrientation.Relative,
				"RELATIVE"
			}
		};

		// Token: 0x04001011 RID: 4113
		protected static Dictionary<NonTransactedFileStreamAccess, string> _nonTransactedFileStreamAccessNames = new Dictionary<NonTransactedFileStreamAccess, string>
		{
			{
				NonTransactedFileStreamAccess.Full,
				"FULL"
			},
			{
				NonTransactedFileStreamAccess.Off,
				"OFF"
			},
			{
				NonTransactedFileStreamAccess.ReadOnly,
				"READ_ONLY"
			}
		};

		// Token: 0x04001012 RID: 4114
		protected static Dictionary<FullTextFunctionType, TokenGenerator> _fulltextFunctionTypeGenerators = new Dictionary<FullTextFunctionType, TokenGenerator>
		{
			{
				FullTextFunctionType.Contains,
				new KeywordGenerator(TSqlTokenType.Contains)
			},
			{
				FullTextFunctionType.FreeText,
				new KeywordGenerator(TSqlTokenType.FreeText)
			}
		};

		// Token: 0x04001013 RID: 4115
		protected static Dictionary<FunctionOptionKind, List<TokenGenerator>> _functionOptionsGenerators = new Dictionary<FunctionOptionKind, List<TokenGenerator>>
		{
			{
				FunctionOptionKind.CalledOnNullInput,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("CALLED", true),
					new KeywordGenerator(TSqlTokenType.On, true),
					new KeywordGenerator(TSqlTokenType.Null, true),
					new IdentifierGenerator("INPUT")
				}
			},
			{
				FunctionOptionKind.Encryption,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("ENCRYPTION")
				}
			},
			{
				FunctionOptionKind.ReturnsNullOnNullInput,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("RETURNS", true),
					new KeywordGenerator(TSqlTokenType.Null, true),
					new KeywordGenerator(TSqlTokenType.On, true),
					new KeywordGenerator(TSqlTokenType.Null, true),
					new IdentifierGenerator("INPUT")
				}
			},
			{
				FunctionOptionKind.SchemaBinding,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("SCHEMABINDING")
				}
			}
		};

		// Token: 0x04001014 RID: 4116
		protected static Dictionary<GeneralSetCommandType, TokenGenerator> _generalSetCommandTypeGenerators = new Dictionary<GeneralSetCommandType, TokenGenerator>
		{
			{
				GeneralSetCommandType.ContextInfo,
				new IdentifierGenerator("CONTEXT_INFO")
			},
			{
				GeneralSetCommandType.DateFirst,
				new IdentifierGenerator("DATEFIRST")
			},
			{
				GeneralSetCommandType.DateFormat,
				new IdentifierGenerator("DATEFORMAT")
			},
			{
				GeneralSetCommandType.DeadlockPriority,
				new IdentifierGenerator("DEADLOCK_PRIORITY")
			},
			{
				GeneralSetCommandType.Language,
				new IdentifierGenerator("LANGUAGE")
			},
			{
				GeneralSetCommandType.LockTimeout,
				new IdentifierGenerator("LOCK_TIMEOUT")
			},
			{
				GeneralSetCommandType.None,
				new EmptyGenerator()
			},
			{
				GeneralSetCommandType.QueryGovernorCostLimit,
				new IdentifierGenerator("QUERY_GOVERNOR_COST_LIMIT")
			}
		};

		// Token: 0x04001015 RID: 4117
		private static Dictionary<PrincipalOptionKind, string> _loginOptionsNames = new Dictionary<PrincipalOptionKind, string>
		{
			{
				PrincipalOptionKind.CheckExpiration,
				"CHECK_EXPIRATION"
			},
			{
				PrincipalOptionKind.CheckPolicy,
				"CHECK_POLICY"
			},
			{
				PrincipalOptionKind.Credential,
				"CREDENTIAL"
			},
			{
				PrincipalOptionKind.DefaultDatabase,
				"DEFAULT_DATABASE"
			},
			{
				PrincipalOptionKind.DefaultLanguage,
				"DEFAULT_LANGUAGE"
			},
			{
				PrincipalOptionKind.Name,
				"NAME"
			},
			{
				PrincipalOptionKind.Password,
				"PASSWORD"
			},
			{
				PrincipalOptionKind.Sid,
				"SID"
			},
			{
				PrincipalOptionKind.DefaultSchema,
				"DEFAULT_SCHEMA"
			},
			{
				PrincipalOptionKind.Login,
				"LOGIN"
			}
		};

		// Token: 0x04001016 RID: 4118
		protected static Dictionary<InsertOption, TokenGenerator> _insertOptionGenerators = new Dictionary<InsertOption, TokenGenerator>
		{
			{
				InsertOption.Into,
				new KeywordGenerator(TSqlTokenType.Into)
			},
			{
				InsertOption.None,
				new KeywordGenerator(TSqlTokenType.Into)
			},
			{
				InsertOption.Over,
				new KeywordGenerator(TSqlTokenType.Over)
			}
		};

		// Token: 0x04001017 RID: 4119
		protected static Dictionary<EndpointProtocolOptions, string> _endpointProtocolOptionsNames = new Dictionary<EndpointProtocolOptions, string>
		{
			{
				EndpointProtocolOptions.HttpAuthenticationRealm,
				"AUTH_REALM"
			},
			{
				EndpointProtocolOptions.HttpClearPort,
				"CLEAR_PORT"
			},
			{
				EndpointProtocolOptions.HttpDefaultLogonDomain,
				"DEFAULT_LOGON_DOMAIN"
			},
			{
				EndpointProtocolOptions.HttpPath,
				"PATH"
			},
			{
				EndpointProtocolOptions.HttpSite,
				"SITE"
			},
			{
				EndpointProtocolOptions.HttpSslPort,
				"SSL_PORT"
			},
			{
				EndpointProtocolOptions.TcpListenerPort,
				"LISTENER_PORT"
			}
		};

		// Token: 0x04001018 RID: 4120
		private static Dictionary<MessageValidationMethod, string> _MessageValidationMethodNames = new Dictionary<MessageValidationMethod, string>
		{
			{
				MessageValidationMethod.Empty,
				"EMPTY"
			},
			{
				MessageValidationMethod.None,
				"NONE"
			},
			{
				MessageValidationMethod.ValidXml,
				"VALID_XML"
			},
			{
				MessageValidationMethod.WellFormedXml,
				"WELL_FORMED_XML"
			}
		};

		// Token: 0x04001019 RID: 4121
		protected static Dictionary<OptimizerHintKind, List<TokenGenerator>> _optimizerHintKindsGenerators = new Dictionary<OptimizerHintKind, List<TokenGenerator>>
		{
			{
				OptimizerHintKind.AlterColumnPlan,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("ALTERCOLUMN", true),
					new KeywordGenerator(TSqlTokenType.Plan)
				}
			},
			{
				OptimizerHintKind.BypassOptimizerQueue,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("BYPASS", true),
					new IdentifierGenerator("OPTIMIZER_QUEUE")
				}
			},
			{
				OptimizerHintKind.ConcatUnion,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("CONCAT", true),
					new KeywordGenerator(TSqlTokenType.Union)
				}
			},
			{
				OptimizerHintKind.ExpandViews,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("EXPAND", true),
					new IdentifierGenerator("VIEWS")
				}
			},
			{
				OptimizerHintKind.ForceOrder,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("FORCE", true),
					new KeywordGenerator(TSqlTokenType.Order)
				}
			},
			{
				OptimizerHintKind.HashGroup,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("HASH", true),
					new KeywordGenerator(TSqlTokenType.Group)
				}
			},
			{
				OptimizerHintKind.HashJoin,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("HASH", true),
					new KeywordGenerator(TSqlTokenType.Join)
				}
			},
			{
				OptimizerHintKind.HashUnion,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("HASH", true),
					new KeywordGenerator(TSqlTokenType.Union)
				}
			},
			{
				OptimizerHintKind.KeepFixedPlan,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("KEEPFIXED", true),
					new KeywordGenerator(TSqlTokenType.Plan)
				}
			},
			{
				OptimizerHintKind.KeepPlan,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("KEEP", true),
					new KeywordGenerator(TSqlTokenType.Plan)
				}
			},
			{
				OptimizerHintKind.KeepUnion,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("KEEP", true),
					new KeywordGenerator(TSqlTokenType.Union)
				}
			},
			{
				OptimizerHintKind.LoopJoin,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("LOOP", true),
					new KeywordGenerator(TSqlTokenType.Join)
				}
			},
			{
				OptimizerHintKind.MergeJoin,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("MERGE", true),
					new KeywordGenerator(TSqlTokenType.Join)
				}
			},
			{
				OptimizerHintKind.MergeUnion,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("MERGE", true),
					new KeywordGenerator(TSqlTokenType.Union)
				}
			},
			{
				OptimizerHintKind.OrderGroup,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.Order, true),
					new KeywordGenerator(TSqlTokenType.Group)
				}
			},
			{
				OptimizerHintKind.RobustPlan,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("ROBUST", true),
					new KeywordGenerator(TSqlTokenType.Plan)
				}
			},
			{
				OptimizerHintKind.ShrinkDBPlan,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("SHRINKDB", true),
					new KeywordGenerator(TSqlTokenType.Plan)
				}
			},
			{
				OptimizerHintKind.ParameterizationSimple,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("PARAMETERIZATION", true),
					new IdentifierGenerator("SIMPLE")
				}
			},
			{
				OptimizerHintKind.ParameterizationForced,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("PARAMETERIZATION", true),
					new IdentifierGenerator("FORCED")
				}
			},
			{
				OptimizerHintKind.OptimizeCorrelatedUnionAll,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("OPTIMIZE", true),
					new IdentifierGenerator("CORRELATED", true),
					new KeywordGenerator(TSqlTokenType.Union, true),
					new KeywordGenerator(TSqlTokenType.All)
				}
			},
			{
				OptimizerHintKind.Recompile,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("RECOMPILE")
				}
			},
			{
				OptimizerHintKind.Fast,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("FAST")
				}
			},
			{
				OptimizerHintKind.CheckConstraintsPlan,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("CHECKCONSTRAINTS", true),
					new KeywordGenerator(TSqlTokenType.Plan)
				}
			},
			{
				OptimizerHintKind.MaxRecursion,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("MAXRECURSION")
				}
			},
			{
				OptimizerHintKind.MaxDop,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("MAXDOP")
				}
			},
			{
				OptimizerHintKind.IgnoreNonClusteredColumnStoreIndex,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("IGNORE_NONCLUSTERED_COLUMNSTORE_INDEX")
				}
			},
			{
				OptimizerHintKind.QueryTraceOn,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("QUERYTRACEON")
				}
			}
		};

		// Token: 0x0400101A RID: 4122
		private static Dictionary<PageVerifyDatabaseOptionKind, string> _pageVerifyDatabaseOptionKindNames = new Dictionary<PageVerifyDatabaseOptionKind, string>
		{
			{
				PageVerifyDatabaseOptionKind.Checksum,
				"CHECKSUM"
			},
			{
				PageVerifyDatabaseOptionKind.None,
				"NONE"
			},
			{
				PageVerifyDatabaseOptionKind.TornPageDetection,
				"TORN_PAGE_DETECTION"
			}
		};

		// Token: 0x0400101B RID: 4123
		protected static Dictionary<ParameterlessCallType, TokenGenerator> _parameterlessCallTypeGenerators = new Dictionary<ParameterlessCallType, TokenGenerator>
		{
			{
				ParameterlessCallType.CurrentTimestamp,
				new KeywordGenerator(TSqlTokenType.CurrentTimestamp)
			},
			{
				ParameterlessCallType.CurrentUser,
				new KeywordGenerator(TSqlTokenType.CurrentUser)
			},
			{
				ParameterlessCallType.SessionUser,
				new KeywordGenerator(TSqlTokenType.SessionUser)
			},
			{
				ParameterlessCallType.SystemUser,
				new KeywordGenerator(TSqlTokenType.SystemUser)
			},
			{
				ParameterlessCallType.User,
				new KeywordGenerator(TSqlTokenType.User)
			}
		};

		// Token: 0x0400101C RID: 4124
		protected static Dictionary<PortTypes, TokenGenerator> _portTypesGenerators = new Dictionary<PortTypes, TokenGenerator>
		{
			{
				PortTypes.Clear,
				new IdentifierGenerator("CLEAR")
			},
			{
				PortTypes.Ssl,
				new IdentifierGenerator("SSL")
			}
		};

		// Token: 0x0400101D RID: 4125
		protected static Dictionary<SetOptions, TokenGenerator> _setOptionsGenerators = new Dictionary<SetOptions, TokenGenerator>
		{
			{
				SetOptions.AnsiDefaults,
				new IdentifierGenerator("ANSI_DEFAULTS")
			},
			{
				SetOptions.AnsiNullDfltOff,
				new IdentifierGenerator("ANSI_NULL_DFLT_OFF")
			},
			{
				SetOptions.AnsiNullDfltOn,
				new IdentifierGenerator("ANSI_NULL_DFLT_ON")
			},
			{
				SetOptions.AnsiNulls,
				new IdentifierGenerator("ANSI_NULLS")
			},
			{
				SetOptions.AnsiPadding,
				new IdentifierGenerator("ANSI_PADDING")
			},
			{
				SetOptions.AnsiWarnings,
				new IdentifierGenerator("ANSI_WARNINGS")
			},
			{
				SetOptions.ArithAbort,
				new IdentifierGenerator("ARITHABORT")
			},
			{
				SetOptions.ArithIgnore,
				new IdentifierGenerator("ARITHIGNORE")
			},
			{
				SetOptions.ConcatNullYieldsNull,
				new IdentifierGenerator("CONCAT_NULL_YIELDS_NULL")
			},
			{
				SetOptions.CursorCloseOnCommit,
				new IdentifierGenerator("CURSOR_CLOSE_ON_COMMIT")
			},
			{
				SetOptions.DisableDefCnstChk,
				new IdentifierGenerator("DISABLE_DEF_CNST_CHK")
			},
			{
				SetOptions.FmtOnly,
				new IdentifierGenerator("FMTONLY")
			},
			{
				SetOptions.ForcePlan,
				new IdentifierGenerator("FORCEPLAN")
			},
			{
				SetOptions.ImplicitTransactions,
				new IdentifierGenerator("IMPLICIT_TRANSACTIONS")
			},
			{
				SetOptions.NoCount,
				new IdentifierGenerator("NOCOUNT")
			},
			{
				SetOptions.NoExec,
				new IdentifierGenerator("NOEXEC")
			},
			{
				SetOptions.NumericRoundAbort,
				new IdentifierGenerator("NUMERIC_ROUNDABORT")
			},
			{
				SetOptions.ParseOnly,
				new IdentifierGenerator("PARSEONLY")
			},
			{
				SetOptions.QuotedIdentifier,
				new IdentifierGenerator("QUOTED_IDENTIFIER")
			},
			{
				SetOptions.RemoteProcTransactions,
				new IdentifierGenerator("REMOTE_PROC_TRANSACTIONS")
			},
			{
				SetOptions.ShowPlanAll,
				new IdentifierGenerator("SHOWPLAN_ALL")
			},
			{
				SetOptions.ShowPlanText,
				new IdentifierGenerator("SHOWPLAN_TEXT")
			},
			{
				SetOptions.ShowPlanXml,
				new IdentifierGenerator("SHOWPLAN_XML")
			},
			{
				SetOptions.XactAbort,
				new IdentifierGenerator("XACT_ABORT")
			},
			{
				SetOptions.NoBrowsetable,
				new IdentifierGenerator("NO_BROWSETABLE")
			}
		};

		// Token: 0x0400101E RID: 4126
		private static Dictionary<PrivilegeType80, TokenGenerator> _privilegeType80Generators = new Dictionary<PrivilegeType80, TokenGenerator>
		{
			{
				PrivilegeType80.All,
				new KeywordGenerator(TSqlTokenType.All)
			},
			{
				PrivilegeType80.Delete,
				new KeywordGenerator(TSqlTokenType.Delete)
			},
			{
				PrivilegeType80.Execute,
				new KeywordGenerator(TSqlTokenType.Execute)
			},
			{
				PrivilegeType80.Insert,
				new KeywordGenerator(TSqlTokenType.Insert)
			},
			{
				PrivilegeType80.References,
				new KeywordGenerator(TSqlTokenType.References)
			},
			{
				PrivilegeType80.Select,
				new KeywordGenerator(TSqlTokenType.Select)
			},
			{
				PrivilegeType80.Update,
				new KeywordGenerator(TSqlTokenType.Update)
			}
		};

		// Token: 0x0400101F RID: 4127
		protected static Dictionary<QualifiedJoinType, List<TokenGenerator>> _qualifiedJoinTypeGenerators = new Dictionary<QualifiedJoinType, List<TokenGenerator>>
		{
			{
				QualifiedJoinType.FullOuter,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.Full, true),
					new KeywordGenerator(TSqlTokenType.Outer)
				}
			},
			{
				QualifiedJoinType.Inner,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.Inner)
				}
			},
			{
				QualifiedJoinType.LeftOuter,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.Left, true),
					new KeywordGenerator(TSqlTokenType.Outer)
				}
			},
			{
				QualifiedJoinType.RightOuter,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.Right, true),
					new KeywordGenerator(TSqlTokenType.Outer)
				}
			}
		};

		// Token: 0x04001020 RID: 4128
		private static Dictionary<QueueOptionKind, string> _queueOptionTypeNames = new Dictionary<QueueOptionKind, string>
		{
			{
				QueueOptionKind.ActivationDrop,
				"DROP"
			},
			{
				QueueOptionKind.ActivationMaxQueueReaders,
				"MAX_QUEUE_READERS"
			},
			{
				QueueOptionKind.ActivationProcedureName,
				"PROCEDURE_NAME"
			},
			{
				QueueOptionKind.ActivationStatus,
				"STATUS"
			},
			{
				QueueOptionKind.Retention,
				"RETENTION"
			},
			{
				QueueOptionKind.Status,
				"STATUS"
			}
		};

		// Token: 0x04001021 RID: 4129
		protected static Dictionary<RaiseErrorOptions, TokenGenerator> _raiseErrorOptionsGenerators = new Dictionary<RaiseErrorOptions, TokenGenerator>
		{
			{
				RaiseErrorOptions.Log,
				new IdentifierGenerator("LOG")
			},
			{
				RaiseErrorOptions.NoWait,
				new IdentifierGenerator("NOWAIT")
			},
			{
				RaiseErrorOptions.SetError,
				new IdentifierGenerator("SETERROR")
			}
		};

		// Token: 0x04001022 RID: 4130
		private static Dictionary<RecoveryDatabaseOptionKind, TokenGenerator> _recoveryDatabaseOptionKindNames = new Dictionary<RecoveryDatabaseOptionKind, TokenGenerator>
		{
			{
				RecoveryDatabaseOptionKind.Full,
				new KeywordGenerator(TSqlTokenType.Full)
			},
			{
				RecoveryDatabaseOptionKind.BulkLogged,
				new IdentifierGenerator("BULK_LOGGED")
			},
			{
				RecoveryDatabaseOptionKind.Simple,
				new IdentifierGenerator("SIMPLE")
			}
		};

		// Token: 0x04001023 RID: 4131
		protected static Dictionary<RestoreOptionKind, TokenGenerator> _restoreOptionKindGenerators = new Dictionary<RestoreOptionKind, TokenGenerator>
		{
			{
				RestoreOptionKind.BlockSize,
				new IdentifierGenerator("BLOCKSIZE")
			},
			{
				RestoreOptionKind.BufferCount,
				new IdentifierGenerator("BUFFERCOUNT")
			},
			{
				RestoreOptionKind.Checksum,
				new IdentifierGenerator("CHECKSUM")
			},
			{
				RestoreOptionKind.CommitDifferentialBase,
				new IdentifierGenerator("COMMIT_DIFFERENTIAL_BASE")
			},
			{
				RestoreOptionKind.ContinueAfterError,
				new IdentifierGenerator("CONTINUE_AFTER_ERROR")
			},
			{
				RestoreOptionKind.DboOnly,
				new IdentifierGenerator("DBO_ONLY")
			},
			{
				RestoreOptionKind.EnableBroker,
				new IdentifierGenerator("ENABLE_BROKER")
			},
			{
				RestoreOptionKind.EnhancedIntegrity,
				new IdentifierGenerator("ENHANCEDINTEGRITY")
			},
			{
				RestoreOptionKind.ErrorBrokerConversations,
				new IdentifierGenerator("ERROR_BROKER_CONVERSATIONS")
			},
			{
				RestoreOptionKind.File,
				new KeywordGenerator(TSqlTokenType.File)
			},
			{
				RestoreOptionKind.KeepReplication,
				new IdentifierGenerator("KEEP_REPLICATION")
			},
			{
				RestoreOptionKind.LoadHistory,
				new IdentifierGenerator("LOADHISTORY")
			},
			{
				RestoreOptionKind.MaxTransferSize,
				new IdentifierGenerator("MAXTRANSFERSIZE")
			},
			{
				RestoreOptionKind.MediaName,
				new IdentifierGenerator("MEDIANAME")
			},
			{
				RestoreOptionKind.MediaPassword,
				new IdentifierGenerator("MEDIAPASSWORD")
			},
			{
				RestoreOptionKind.NewBroker,
				new IdentifierGenerator("NEW_BROKER")
			},
			{
				RestoreOptionKind.NoChecksum,
				new IdentifierGenerator("NO_CHECKSUM")
			},
			{
				RestoreOptionKind.NoLog,
				new IdentifierGenerator("NO_LOG")
			},
			{
				RestoreOptionKind.NoRecovery,
				new IdentifierGenerator("NORECOVERY")
			},
			{
				RestoreOptionKind.NoRewind,
				new IdentifierGenerator("NOREWIND")
			},
			{
				RestoreOptionKind.NoUnload,
				new IdentifierGenerator("NOUNLOAD")
			},
			{
				RestoreOptionKind.Online,
				new IdentifierGenerator("ONLINE")
			},
			{
				RestoreOptionKind.Partial,
				new IdentifierGenerator("PARTIAL")
			},
			{
				RestoreOptionKind.Password,
				new IdentifierGenerator("PASSWORD")
			},
			{
				RestoreOptionKind.Recovery,
				new IdentifierGenerator("RECOVERY")
			},
			{
				RestoreOptionKind.Replace,
				new IdentifierGenerator("REPLACE")
			},
			{
				RestoreOptionKind.Restart,
				new IdentifierGenerator("RESTART")
			},
			{
				RestoreOptionKind.RestrictedUser,
				new IdentifierGenerator("RESTRICTED_USER")
			},
			{
				RestoreOptionKind.Rewind,
				new IdentifierGenerator("REWIND")
			},
			{
				RestoreOptionKind.Snapshot,
				new IdentifierGenerator("SNAPSHOT")
			},
			{
				RestoreOptionKind.SnapshotImport,
				new IdentifierGenerator("SNAPSHOT_IMPORT")
			},
			{
				RestoreOptionKind.SnapshotRestorePhase,
				new IdentifierGenerator("SNAPSHOTRESTOREPHASE")
			},
			{
				RestoreOptionKind.Standby,
				new IdentifierGenerator("STANDBY")
			},
			{
				RestoreOptionKind.Stats,
				new IdentifierGenerator("STATS")
			},
			{
				RestoreOptionKind.StopAt,
				new IdentifierGenerator("STOPAT")
			},
			{
				RestoreOptionKind.StopOnError,
				new IdentifierGenerator("STOP_ON_ERROR")
			},
			{
				RestoreOptionKind.Unload,
				new IdentifierGenerator("UNLOAD")
			},
			{
				RestoreOptionKind.Verbose,
				new IdentifierGenerator("VERBOSE")
			}
		};

		// Token: 0x04001024 RID: 4132
		private static Dictionary<RestoreStatementKind, TokenGenerator> _restoreStatementKindGenerators = new Dictionary<RestoreStatementKind, TokenGenerator>
		{
			{
				RestoreStatementKind.None,
				new EmptyGenerator()
			},
			{
				RestoreStatementKind.FileListOnly,
				new IdentifierGenerator("FILELISTONLY")
			},
			{
				RestoreStatementKind.HeaderOnly,
				new IdentifierGenerator("HEADERONLY")
			},
			{
				RestoreStatementKind.LabelOnly,
				new IdentifierGenerator("LABELONLY")
			},
			{
				RestoreStatementKind.RewindOnly,
				new IdentifierGenerator("REWINDONLY")
			},
			{
				RestoreStatementKind.VerifyOnly,
				new IdentifierGenerator("VERIFYONLY")
			}
		};

		// Token: 0x04001025 RID: 4133
		protected static Dictionary<DatabaseMirroringEndpointRole, TokenGenerator> _databaseMirroringEndpointRoleGenerators = new Dictionary<DatabaseMirroringEndpointRole, TokenGenerator>
		{
			{
				DatabaseMirroringEndpointRole.NotSpecified,
				new EmptyGenerator()
			},
			{
				DatabaseMirroringEndpointRole.All,
				new KeywordGenerator(TSqlTokenType.All)
			},
			{
				DatabaseMirroringEndpointRole.Partner,
				new IdentifierGenerator("PARTNER")
			},
			{
				DatabaseMirroringEndpointRole.Witness,
				new IdentifierGenerator("WITNESS")
			}
		};

		// Token: 0x04001026 RID: 4134
		private static Dictionary<RouteOptionKind, string> _RouteOptionTypeNames = new Dictionary<RouteOptionKind, string>
		{
			{
				RouteOptionKind.Address,
				"ADDRESS"
			},
			{
				RouteOptionKind.BrokerInstance,
				"BROKER_INSTANCE"
			},
			{
				RouteOptionKind.Lifetime,
				"LIFETIME"
			},
			{
				RouteOptionKind.MirrorAddress,
				"MIRROR_ADDRESS"
			},
			{
				RouteOptionKind.ServiceName,
				"SERVICE_NAME"
			}
		};

		// Token: 0x04001027 RID: 4135
		protected static Dictionary<SecurityObjectKind, List<TokenGenerator>> _securityObjectKindGenerators = new Dictionary<SecurityObjectKind, List<TokenGenerator>>
		{
			{
				SecurityObjectKind.AvailabilityGroup,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("AVAILABILITY", true),
					new IdentifierGenerator("GROUP")
				}
			},
			{
				SecurityObjectKind.ApplicationRole,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("APPLICATION", true),
					new IdentifierGenerator("ROLE")
				}
			},
			{
				SecurityObjectKind.Assembly,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("ASSEMBLY")
				}
			},
			{
				SecurityObjectKind.AsymmetricKey,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("ASYMMETRIC", true),
					new KeywordGenerator(TSqlTokenType.Key)
				}
			},
			{
				SecurityObjectKind.Certificate,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("CERTIFICATE")
				}
			},
			{
				SecurityObjectKind.Contract,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("CONTRACT")
				}
			},
			{
				SecurityObjectKind.Database,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.Database)
				}
			},
			{
				SecurityObjectKind.Endpoint,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("ENDPOINT")
				}
			},
			{
				SecurityObjectKind.FullTextCatalog,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("FULLTEXT", true),
					new IdentifierGenerator("CATALOG")
				}
			},
			{
				SecurityObjectKind.Login,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("LOGIN")
				}
			},
			{
				SecurityObjectKind.MessageType,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("MESSAGE", true),
					new IdentifierGenerator("TYPE")
				}
			},
			{
				SecurityObjectKind.Object,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("OBJECT")
				}
			},
			{
				SecurityObjectKind.RemoteServiceBinding,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("REMOTE", true),
					new IdentifierGenerator("SERVICE", true),
					new IdentifierGenerator("BINDING")
				}
			},
			{
				SecurityObjectKind.Role,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("ROLE")
				}
			},
			{
				SecurityObjectKind.Route,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("ROUTE")
				}
			},
			{
				SecurityObjectKind.Schema,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.Schema)
				}
			},
			{
				SecurityObjectKind.Server,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("SERVER")
				}
			},
			{
				SecurityObjectKind.ServerRole,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("SERVER", true),
					new IdentifierGenerator("ROLE")
				}
			},
			{
				SecurityObjectKind.Service,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("SERVICE")
				}
			},
			{
				SecurityObjectKind.SymmetricKey,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("SYMMETRIC", true),
					new KeywordGenerator(TSqlTokenType.Key)
				}
			},
			{
				SecurityObjectKind.Type,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("TYPE")
				}
			},
			{
				SecurityObjectKind.User,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.User)
				}
			},
			{
				SecurityObjectKind.XmlSchemaCollection,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("XML", true),
					new KeywordGenerator(TSqlTokenType.Schema, true),
					new IdentifierGenerator("COLLECTION")
				}
			},
			{
				SecurityObjectKind.FullTextStopList,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("FULLTEXT", true),
					new KeywordGenerator(TSqlTokenType.StopList)
				}
			},
			{
				SecurityObjectKind.SearchPropertyList,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("SEARCH", true),
					new IdentifierGenerator("PROPERTY", true),
					new IdentifierGenerator("LIST")
				}
			}
		};

		// Token: 0x04001028 RID: 4136
		private static Dictionary<AssignmentKind, TSqlTokenType> _assignmentKindSymbols = new Dictionary<AssignmentKind, TSqlTokenType>
		{
			{
				AssignmentKind.Equals,
				TSqlTokenType.EqualsSign
			},
			{
				AssignmentKind.AddEquals,
				TSqlTokenType.AddEquals
			},
			{
				AssignmentKind.SubtractEquals,
				TSqlTokenType.SubtractEquals
			},
			{
				AssignmentKind.MultiplyEquals,
				TSqlTokenType.MultiplyEquals
			},
			{
				AssignmentKind.DivideEquals,
				TSqlTokenType.DivideEquals
			},
			{
				AssignmentKind.ModEquals,
				TSqlTokenType.ModEquals
			},
			{
				AssignmentKind.BitwiseAndEquals,
				TSqlTokenType.BitwiseAndEquals
			},
			{
				AssignmentKind.BitwiseOrEquals,
				TSqlTokenType.BitwiseOrEquals
			},
			{
				AssignmentKind.BitwiseXorEquals,
				TSqlTokenType.BitwiseXorEquals
			}
		};

		// Token: 0x04001029 RID: 4137
		protected static Dictionary<SetOffsets, TokenGenerator> _setOffsetsGenerators = new Dictionary<SetOffsets, TokenGenerator>
		{
			{
				SetOffsets.Compute,
				new KeywordGenerator(TSqlTokenType.Compute)
			},
			{
				SetOffsets.Execute,
				new KeywordGenerator(TSqlTokenType.Execute)
			},
			{
				SetOffsets.From,
				new KeywordGenerator(TSqlTokenType.From)
			},
			{
				SetOffsets.Order,
				new KeywordGenerator(TSqlTokenType.Order)
			},
			{
				SetOffsets.Param,
				new IdentifierGenerator("PARAM")
			},
			{
				SetOffsets.Procedure,
				new KeywordGenerator(TSqlTokenType.Procedure)
			},
			{
				SetOffsets.Select,
				new KeywordGenerator(TSqlTokenType.Select)
			},
			{
				SetOffsets.Statement,
				new IdentifierGenerator("STATEMENT")
			},
			{
				SetOffsets.Table,
				new KeywordGenerator(TSqlTokenType.Table)
			}
		};

		// Token: 0x0400102A RID: 4138
		protected static Dictionary<IsolationLevel, List<TokenGenerator>> _isolationLevelGenerators = new Dictionary<IsolationLevel, List<TokenGenerator>>
		{
			{
				IsolationLevel.ReadCommitted,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.Read, true),
					new IdentifierGenerator("COMMITTED")
				}
			},
			{
				IsolationLevel.ReadUncommitted,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.Read, true),
					new IdentifierGenerator("UNCOMMITTED")
				}
			},
			{
				IsolationLevel.RepeatableRead,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("REPEATABLE", true),
					new KeywordGenerator(TSqlTokenType.Read)
				}
			},
			{
				IsolationLevel.Serializable,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("SERIALIZABLE")
				}
			},
			{
				IsolationLevel.Snapshot,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("SNAPSHOT")
				}
			}
		};

		// Token: 0x0400102B RID: 4139
		protected static Dictionary<SoapMethodAction, TokenGenerator> _soapMethodActionGenerators = new Dictionary<SoapMethodAction, TokenGenerator>
		{
			{
				SoapMethodAction.None,
				new EmptyGenerator()
			},
			{
				SoapMethodAction.Add,
				new KeywordGenerator(TSqlTokenType.Add)
			},
			{
				SoapMethodAction.Alter,
				new KeywordGenerator(TSqlTokenType.Alter)
			},
			{
				SoapMethodAction.Drop,
				new KeywordGenerator(TSqlTokenType.Drop)
			}
		};

		// Token: 0x0400102C RID: 4140
		protected static Dictionary<SoapMethodSchemas, TokenGenerator> _soapMethodSchemasGenerators = new Dictionary<SoapMethodSchemas, TokenGenerator>
		{
			{
				SoapMethodSchemas.Default,
				new KeywordGenerator(TSqlTokenType.Default)
			},
			{
				SoapMethodSchemas.None,
				new IdentifierGenerator("NONE")
			},
			{
				SoapMethodSchemas.Standard,
				new IdentifierGenerator("STANDARD")
			}
		};

		// Token: 0x0400102D RID: 4141
		protected static Dictionary<SoapMethodFormat, string> _soapMethodFormatNames = new Dictionary<SoapMethodFormat, string>
		{
			{
				SoapMethodFormat.AllResults,
				"ALL_RESULTS"
			},
			{
				SoapMethodFormat.None,
				"NONE"
			},
			{
				SoapMethodFormat.RowsetsOnly,
				"ROWSETS_ONLY"
			}
		};

		// Token: 0x0400102E RID: 4142
		protected static Dictionary<SqlDataTypeOption, TokenGenerator> _sqlDataTypeOptionGenerators = new Dictionary<SqlDataTypeOption, TokenGenerator>
		{
			{
				SqlDataTypeOption.BigInt,
				new IdentifierGenerator("BIGINT")
			},
			{
				SqlDataTypeOption.Binary,
				new IdentifierGenerator("BINARY")
			},
			{
				SqlDataTypeOption.Bit,
				new IdentifierGenerator("BIT")
			},
			{
				SqlDataTypeOption.Char,
				new IdentifierGenerator("CHAR")
			},
			{
				SqlDataTypeOption.Cursor,
				new KeywordGenerator(TSqlTokenType.Cursor)
			},
			{
				SqlDataTypeOption.DateTime,
				new IdentifierGenerator("DATETIME")
			},
			{
				SqlDataTypeOption.Decimal,
				new IdentifierGenerator("DECIMAL")
			},
			{
				SqlDataTypeOption.Float,
				new IdentifierGenerator("FLOAT")
			},
			{
				SqlDataTypeOption.Image,
				new IdentifierGenerator("IMAGE")
			},
			{
				SqlDataTypeOption.Int,
				new IdentifierGenerator("INT")
			},
			{
				SqlDataTypeOption.Money,
				new IdentifierGenerator("MONEY")
			},
			{
				SqlDataTypeOption.NChar,
				new IdentifierGenerator("NCHAR")
			},
			{
				SqlDataTypeOption.NText,
				new IdentifierGenerator("NTEXT")
			},
			{
				SqlDataTypeOption.NVarChar,
				new IdentifierGenerator("NVARCHAR")
			},
			{
				SqlDataTypeOption.Numeric,
				new IdentifierGenerator("NUMERIC")
			},
			{
				SqlDataTypeOption.Real,
				new IdentifierGenerator("REAL")
			},
			{
				SqlDataTypeOption.SmallDateTime,
				new IdentifierGenerator("SMALLDATETIME")
			},
			{
				SqlDataTypeOption.SmallInt,
				new IdentifierGenerator("SMALLINT")
			},
			{
				SqlDataTypeOption.SmallMoney,
				new IdentifierGenerator("SMALLMONEY")
			},
			{
				SqlDataTypeOption.Sql_Variant,
				new IdentifierGenerator("SQL_VARIANT")
			},
			{
				SqlDataTypeOption.Table,
				new KeywordGenerator(TSqlTokenType.Table)
			},
			{
				SqlDataTypeOption.Text,
				new IdentifierGenerator("TEXT")
			},
			{
				SqlDataTypeOption.Timestamp,
				new IdentifierGenerator("TIMESTAMP")
			},
			{
				SqlDataTypeOption.TinyInt,
				new IdentifierGenerator("TINYINT")
			},
			{
				SqlDataTypeOption.UniqueIdentifier,
				new IdentifierGenerator("UNIQUEIDENTIFIER")
			},
			{
				SqlDataTypeOption.VarBinary,
				new IdentifierGenerator("VARBINARY")
			},
			{
				SqlDataTypeOption.VarChar,
				new IdentifierGenerator("VARCHAR")
			},
			{
				SqlDataTypeOption.Date,
				new IdentifierGenerator("DATE")
			},
			{
				SqlDataTypeOption.Time,
				new IdentifierGenerator("TIME")
			},
			{
				SqlDataTypeOption.DateTime2,
				new IdentifierGenerator("DATETIME2")
			},
			{
				SqlDataTypeOption.DateTimeOffset,
				new IdentifierGenerator("DATETIMEOFFSET")
			},
			{
				SqlDataTypeOption.Rowversion,
				new IdentifierGenerator("ROWVERSION")
			}
		};

		// Token: 0x0400102F RID: 4143
		protected static Dictionary<SubqueryComparisonPredicateType, TokenGenerator> _subqueryComparisonPredicateTypeGenerators = new Dictionary<SubqueryComparisonPredicateType, TokenGenerator>
		{
			{
				SubqueryComparisonPredicateType.All,
				new KeywordGenerator(TSqlTokenType.All)
			},
			{
				SubqueryComparisonPredicateType.Any,
				new KeywordGenerator(TSqlTokenType.Any)
			}
		};

		// Token: 0x04001030 RID: 4144
		protected static Dictionary<TableSampleClauseOption, TokenGenerator> _tableSampleClauseOptionGenerators = new Dictionary<TableSampleClauseOption, TokenGenerator>
		{
			{
				TableSampleClauseOption.NotSpecified,
				new EmptyGenerator()
			},
			{
				TableSampleClauseOption.Percent,
				new KeywordGenerator(TSqlTokenType.Percent)
			},
			{
				TableSampleClauseOption.Rows,
				new IdentifierGenerator("ROWS")
			}
		};

		// Token: 0x04001031 RID: 4145
		private static Dictionary<TriggerType, List<TokenGenerator>> _triggerTypeGenerators = new Dictionary<TriggerType, List<TokenGenerator>>
		{
			{
				TriggerType.After,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("AFTER")
				}
			},
			{
				TriggerType.For,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.For)
				}
			},
			{
				TriggerType.InsteadOf,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("INSTEAD", true),
					new KeywordGenerator(TSqlTokenType.Of)
				}
			},
			{
				TriggerType.Unknown,
				new List<TokenGenerator>
				{
					new EmptyGenerator()
				}
			}
		};

		// Token: 0x04001032 RID: 4146
		protected static Dictionary<UnaryExpressionType, List<TokenGenerator>> _unaryExpressionTypeGenerators = new Dictionary<UnaryExpressionType, List<TokenGenerator>>
		{
			{
				UnaryExpressionType.BitwiseNot,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.Tilde)
				}
			},
			{
				UnaryExpressionType.Negative,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.Minus)
				}
			},
			{
				UnaryExpressionType.Positive,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.Plus)
				}
			}
		};

		// Token: 0x04001033 RID: 4147
		protected static Dictionary<UnqualifiedJoinType, List<TokenGenerator>> _unqualifiedJoinTypeGenerators = new Dictionary<UnqualifiedJoinType, List<TokenGenerator>>
		{
			{
				UnqualifiedJoinType.CrossApply,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.Cross, true),
					new IdentifierGenerator("APPLY")
				}
			},
			{
				UnqualifiedJoinType.CrossJoin,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.Cross, true),
					new KeywordGenerator(TSqlTokenType.Join)
				}
			},
			{
				UnqualifiedJoinType.OuterApply,
				new List<TokenGenerator>
				{
					new KeywordGenerator(TSqlTokenType.Outer, true),
					new IdentifierGenerator("APPLY")
				}
			}
		};

		// Token: 0x04001034 RID: 4148
		protected static Dictionary<ViewOptionKind, string> _viewOptionTypeNames = new Dictionary<ViewOptionKind, string>
		{
			{
				ViewOptionKind.Encryption,
				"ENCRYPTION"
			},
			{
				ViewOptionKind.SchemaBinding,
				"SCHEMABINDING"
			},
			{
				ViewOptionKind.ViewMetadata,
				"VIEW_METADATA"
			}
		};

		// Token: 0x04001035 RID: 4149
		protected static Dictionary<WaitForOption, TokenGenerator> _waitForOptionGenerators = new Dictionary<WaitForOption, TokenGenerator>
		{
			{
				WaitForOption.Delay,
				new IdentifierGenerator("DELAY")
			},
			{
				WaitForOption.Time,
				new IdentifierGenerator("TIME")
			}
		};

		// Token: 0x04001036 RID: 4150
		protected static Dictionary<XmlDataTypeOption, TokenGenerator> _xmlDataTypeOptionGenerators = new Dictionary<XmlDataTypeOption, TokenGenerator>
		{
			{
				XmlDataTypeOption.Content,
				new IdentifierGenerator("CONTENT")
			},
			{
				XmlDataTypeOption.Document,
				new IdentifierGenerator("DOCUMENT")
			},
			{
				XmlDataTypeOption.None,
				new EmptyGenerator()
			}
		};

		// Token: 0x04001037 RID: 4151
		protected static Dictionary<XmlForClauseOptions, List<TokenGenerator>> _xmlForClauseOptionsGenerators = new Dictionary<XmlForClauseOptions, List<TokenGenerator>>
		{
			{
				XmlForClauseOptions.Raw,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("RAW")
				}
			},
			{
				XmlForClauseOptions.Auto,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("AUTO")
				}
			},
			{
				XmlForClauseOptions.Explicit,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("EXPLICIT")
				}
			},
			{
				XmlForClauseOptions.Path,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("PATH")
				}
			},
			{
				XmlForClauseOptions.XmlData,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("XMLDATA")
				}
			},
			{
				XmlForClauseOptions.XmlSchema,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("XMLSCHEMA")
				}
			},
			{
				XmlForClauseOptions.Elements,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("ELEMENTS")
				}
			},
			{
				XmlForClauseOptions.ElementsXsiNil,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("ELEMENTS", true),
					new IdentifierGenerator("XSINIL")
				}
			},
			{
				XmlForClauseOptions.ElementsAbsent,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("ELEMENTS", true),
					new IdentifierGenerator("ABSENT")
				}
			},
			{
				XmlForClauseOptions.BinaryBase64,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("BINARY", true),
					new IdentifierGenerator("BASE64")
				}
			},
			{
				XmlForClauseOptions.Type,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("TYPE")
				}
			},
			{
				XmlForClauseOptions.Root,
				new List<TokenGenerator>
				{
					new IdentifierGenerator("ROOT")
				}
			}
		};

		// Token: 0x020001A2 RID: 418
		internal class ListGenerationOption
		{
			// Token: 0x1700005F RID: 95
			// (get) Token: 0x06000FEB RID: 4075 RVA: 0x000359AC File Offset: 0x00033BAC
			// (set) Token: 0x06000FEC RID: 4076 RVA: 0x000359B4 File Offset: 0x00033BB4
			public bool Parenthesised { get; set; }

			// Token: 0x17000060 RID: 96
			// (get) Token: 0x06000FED RID: 4077 RVA: 0x000359BD File Offset: 0x00033BBD
			// (set) Token: 0x06000FEE RID: 4078 RVA: 0x000359C5 File Offset: 0x00033BC5
			public bool AlwaysGenerateParenthesis { get; set; }

			// Token: 0x17000061 RID: 97
			// (get) Token: 0x06000FEF RID: 4079 RVA: 0x000359CE File Offset: 0x00033BCE
			// (set) Token: 0x06000FF0 RID: 4080 RVA: 0x000359D6 File Offset: 0x00033BD6
			public bool IndentParentheses { get; set; }

			// Token: 0x17000062 RID: 98
			// (get) Token: 0x06000FF1 RID: 4081 RVA: 0x000359DF File Offset: 0x00033BDF
			// (set) Token: 0x06000FF2 RID: 4082 RVA: 0x000359E7 File Offset: 0x00033BE7
			public bool AlignParentheses { get; set; }

			// Token: 0x17000063 RID: 99
			// (get) Token: 0x06000FF3 RID: 4083 RVA: 0x000359F0 File Offset: 0x00033BF0
			// (set) Token: 0x06000FF4 RID: 4084 RVA: 0x000359F8 File Offset: 0x00033BF8
			public bool NewLineBeforeOpenParenthesis { get; set; }

			// Token: 0x17000064 RID: 100
			// (get) Token: 0x06000FF5 RID: 4085 RVA: 0x00035A01 File Offset: 0x00033C01
			// (set) Token: 0x06000FF6 RID: 4086 RVA: 0x00035A09 File Offset: 0x00033C09
			public bool NewLineAfterOpenParenthesis { get; set; }

			// Token: 0x17000065 RID: 101
			// (get) Token: 0x06000FF7 RID: 4087 RVA: 0x00035A12 File Offset: 0x00033C12
			// (set) Token: 0x06000FF8 RID: 4088 RVA: 0x00035A1A File Offset: 0x00033C1A
			public bool NewLineBeforeCloseParenthesis { get; set; }

			// Token: 0x17000066 RID: 102
			// (get) Token: 0x06000FF9 RID: 4089 RVA: 0x00035A23 File Offset: 0x00033C23
			// (set) Token: 0x06000FFA RID: 4090 RVA: 0x00035A2B File Offset: 0x00033C2B
			public SqlScriptGeneratorVisitor.ListGenerationOption.SeparatorType Separator { get; set; }

			// Token: 0x17000067 RID: 103
			// (get) Token: 0x06000FFB RID: 4091 RVA: 0x00035A34 File Offset: 0x00033C34
			// (set) Token: 0x06000FFC RID: 4092 RVA: 0x00035A3C File Offset: 0x00033C3C
			public bool NewLineBeforeFirstItem { get; set; }

			// Token: 0x17000068 RID: 104
			// (get) Token: 0x06000FFD RID: 4093 RVA: 0x00035A45 File Offset: 0x00033C45
			// (set) Token: 0x06000FFE RID: 4094 RVA: 0x00035A4D File Offset: 0x00033C4D
			public bool NewLineBeforeItems { get; set; }

			// Token: 0x17000069 RID: 105
			// (get) Token: 0x06000FFF RID: 4095 RVA: 0x00035A56 File Offset: 0x00033C56
			// (set) Token: 0x06001000 RID: 4096 RVA: 0x00035A5E File Offset: 0x00033C5E
			public int MultipleIndentItems { get; set; }

			// Token: 0x06001001 RID: 4097 RVA: 0x00035A68 File Offset: 0x00033C68
			public static SqlScriptGeneratorVisitor.ListGenerationOption CreateOptionFromFormattingConfig(SqlScriptGeneratorOptions formatting)
			{
				return new SqlScriptGeneratorVisitor.ListGenerationOption
				{
					Parenthesised = true,
					AlwaysGenerateParenthesis = true,
					NewLineBeforeOpenParenthesis = formatting.NewLineBeforeOpenParenthesisInMultilineList,
					NewLineAfterOpenParenthesis = true,
					IndentParentheses = false,
					NewLineBeforeCloseParenthesis = formatting.NewLineBeforeCloseParenthesisInMultilineList,
					AlignParentheses = false,
					NewLineBeforeItems = true,
					NewLineBeforeFirstItem = false,
					MultipleIndentItems = 1,
					Separator = SqlScriptGeneratorVisitor.ListGenerationOption.SeparatorType.Comma
				};
			}

			// Token: 0x04001038 RID: 4152
			public static SqlScriptGeneratorVisitor.ListGenerationOption MultipleLineSelectElementOption = new SqlScriptGeneratorVisitor.ListGenerationOption
			{
				Parenthesised = false,
				AlwaysGenerateParenthesis = false,
				IndentParentheses = false,
				AlignParentheses = false,
				Separator = SqlScriptGeneratorVisitor.ListGenerationOption.SeparatorType.Comma,
				NewLineBeforeFirstItem = false,
				NewLineBeforeItems = true,
				MultipleIndentItems = 0
			};

			// Token: 0x020001A3 RID: 419
			internal enum SeparatorType
			{
				// Token: 0x04001045 RID: 4165
				Comma,
				// Token: 0x04001046 RID: 4166
				Dot,
				// Token: 0x04001047 RID: 4167
				Space
			}
		}
	}
}
