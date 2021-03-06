﻿using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200015F RID: 351
	internal class TriggerEventGroupHelper : OptionsHelper<EventNotificationEventGroup>
	{
		// Token: 0x06000302 RID: 770 RVA: 0x00009CF4 File Offset: 0x00007EF4
		private TriggerEventGroupHelper()
		{
			base.AddOptionMapping(EventNotificationEventGroup.DdlApplicationRoleEvents, "DDL_APPLICATION_ROLE_EVENTS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlAssemblyEvents, "DDL_ASSEMBLY_EVENTS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlAuthorizationDatabaseEvents, "DDL_AUTHORIZATION_DATABASE_EVENTS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlCertificateEvents, "DDL_CERTIFICATE_EVENTS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlContractEvents, "DDL_CONTRACT_EVENTS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlDatabaseLevelEvents, "DDL_DATABASE_LEVEL_EVENTS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlDatabaseSecurityEvents, "DDL_DATABASE_SECURITY_EVENTS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlEventNotificationEvents, "DDL_EVENT_NOTIFICATION_EVENTS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlFunctionEvents, "DDL_FUNCTION_EVENTS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlGdrDatabaseEvents, "DDL_GDR_DATABASE_EVENTS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlIndexEvents, "DDL_INDEX_EVENTS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlMessageTypeEvents, "DDL_MESSAGE_TYPE_EVENTS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlPartitionEvents, "DDL_PARTITION_EVENTS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlPartitionFunctionEvents, "DDL_PARTITION_FUNCTION_EVENTS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlPartitionSchemeEvents, "DDL_PARTITION_SCHEME_EVENTS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlProcedureEvents, "DDL_PROCEDURE_EVENTS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlQueueEvents, "DDL_QUEUE_EVENTS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlRemoteServiceBindingEvents, "DDL_REMOTE_SERVICE_BINDING_EVENTS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlRoleEvents, "DDL_ROLE_EVENTS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlRouteEvents, "DDL_ROUTE_EVENTS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlSchemaEvents, "DDL_SCHEMA_EVENTS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlServiceEvents, "DDL_SERVICE_EVENTS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlSsbEvents, "DDL_SSB_EVENTS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlStatisticsEvents, "DDL_STATISTICS_EVENTS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlSynonymEvents, "DDL_SYNONYM_EVENTS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlTableEvents, "DDL_TABLE_EVENTS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlTableViewEvents, "DDL_TABLE_VIEW_EVENTS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlTriggerEvents, "DDL_TRIGGER_EVENTS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlTypeEvents, "DDL_TYPE_EVENTS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlUserEvents, "DDL_USER_EVENTS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlViewEvents, "DDL_VIEW_EVENTS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlXmlSchemaCollectionEvents, "DDL_XML_SCHEMA_COLLECTION_EVENTS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlAuthorizationServerEvents, "DDL_AUTHORIZATION_SERVER_EVENTS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlEndpointEvents, "DDL_ENDPOINT_EVENTS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlEvents, "DDL_EVENTS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlGdrServerEvents, "DDL_GDR_SERVER_EVENTS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlLoginEvents, "DDL_LOGIN_EVENTS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlServerLevelEvents, "DDL_SERVER_LEVEL_EVENTS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlServerSecurityEvents, "DDL_SERVER_SECURITY_EVENTS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlAsymmetricKeyEvents, "DDL_ASYMMETRIC_KEY_EVENTS", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlBrokerPriorityEvents, "DDL_BROKER_PRIORITY_EVENTS", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlCryptoSignatureEvents, "DDL_CRYPTO_SIGNATURE_EVENTS", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlDatabaseAuditSpecificationEvents, "DDL_DATABASE_AUDIT_SPECIFICATION_EVENTS", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlDatabaseEncryptionKeyEvents, "DDL_DATABASE_ENCRYPTION_KEY_EVENTS", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlDefaultEvents, "DDL_DEFAULT_EVENTS", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlExtendedPropertyEvents, "DDL_EXTENDED_PROPERTY_EVENTS", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlFullTextCatalogEvents, "DDL_FULLTEXT_CATALOG_EVENTS", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlFullTextStopListEvents, "DDL_FULLTEXT_STOPLIST_EVENTS", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlMasterKeyEvents, "DDL_MASTER_KEY_EVENTS", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlPlanGuideEvents, "DDL_PLAN_GUIDE_EVENTS", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlRuleEvents, "DDL_RULE_EVENTS", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlSymmetricKeyEvents, "DDL_SYMMETRIC_KEY_EVENTS", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlCredentialEvents, "DDL_CREDENTIAL_EVENTS", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlDatabaseEvents, "DDL_DATABASE_EVENTS", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlCryptographicProviderEvents, "DDL_CRYPTOGRAPHIC_PROVIDER_EVENTS", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlEventSessionEvents, "DDL_EVENT_SESSION_EVENTS", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlExtendedProcedureEvents, "DDL_EXTENDED_PROCEDURE_EVENTS", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlLinkedServerEvents, "DDL_LINKED_SERVER_EVENTS", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlLinkedServerLoginEvents, "DDL_LINKED_SERVER_LOGIN_EVENTS", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlMessageEvents, "DDL_MESSAGE_EVENTS", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlRemoteServerEvents, "DDL_REMOTE_SERVER_EVENTS", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlResourceGovernorEvents, "DDL_RESOURCE_GOVERNOR_EVENTS", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlResourcePool, "DDL_RESOURCE_POOL", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlServerAuditEvents, "DDL_SERVER_AUDIT_EVENTS", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlServerAuditSpecificationEvents, "DDL_SERVER_AUDIT_SPECIFICATION_EVENTS", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlServiceMasterKeyEvents, "DDL_SERVICE_MASTER_KEY_EVENTS", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlWorkloadGroup, "DDL_WORKLOAD_GROUP", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlSearchPropertyListEvents, "DDL_SEARCH_PROPERTY_LIST_EVENTS", SqlVersionFlags.TSql110AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlSequenceEvents, "DDL_SEQUENCE_EVENTS", SqlVersionFlags.TSql110AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlAvailabilityGroupEvents, "DDL_AVAILABILITY_GROUP_EVENTS", SqlVersionFlags.TSql110AndAbove);
			base.AddOptionMapping(EventNotificationEventGroup.DdlDatabaseAuditEvents, "DDL_DATABASE_AUDIT_EVENTS", SqlVersionFlags.TSql120);
		}

		// Token: 0x04000E3D RID: 3645
		internal static readonly TriggerEventGroupHelper Instance = new TriggerEventGroupHelper();
	}
}
