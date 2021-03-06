﻿using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200005A RID: 90
	internal class AuditEventTypeHelper : OptionsHelper<EventNotificationEventType>
	{
		// Token: 0x060001C9 RID: 457 RVA: 0x00006198 File Offset: 0x00004398
		private AuditEventTypeHelper()
		{
			base.AddOptionMapping(EventNotificationEventType.AssemblyLoad, "ASSEMBLY_LOAD", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.AuditAddDBUserEvent, "AUDIT_ADD_DB_USER_EVENT", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.AuditAddLoginEvent, "AUDIT_ADDLOGIN_EVENT", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.AuditAddLoginToServerRoleEvent, "AUDIT_ADD_LOGIN_TO_SERVER_ROLE_EVENT", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.AuditAddMemberToDBRoleEvent, "AUDIT_ADD_MEMBER_TO_DB_ROLE_EVENT", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.AuditAddRoleEvent, "AUDIT_ADD_ROLE_EVENT", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.AuditAppRoleChangePasswordEvent, "AUDIT_APP_ROLE_CHANGE_PASSWORD_EVENT", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.AuditBackupRestoreEvent, "AUDIT_BACKUP_RESTORE_EVENT", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.AuditChangeAuditEvent, "AUDIT_CHANGE_AUDIT_EVENT", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.AuditChangeDatabaseOwner, "AUDIT_CHANGE_DATABASE_OWNER", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.AuditDatabaseManagementEvent, "AUDIT_DATABASE_MANAGEMENT_EVENT", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.AuditDatabaseObjectAccessEvent, "AUDIT_DATABASE_OBJECT_ACCESS_EVENT", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.AuditDatabaseObjectGdrEvent, "AUDIT_DATABASE_OBJECT_GDR_EVENT", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.AuditDatabaseObjectManagementEvent, "AUDIT_DATABASE_OBJECT_MANAGEMENT_EVENT", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.AuditDatabaseObjectTakeOwnershipEvent, "AUDIT_DATABASE_OBJECT_TAKE_OWNERSHIP_EVENT", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.AuditDatabaseOperationEvent, "AUDIT_DATABASE_OPERATION_EVENT", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.AuditDatabasePrincipalImpersonationEvent, "AUDIT_DATABASE_PRINCIPAL_IMPERSONATION_EVENT", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.AuditDatabasePrincipalManagementEvent, "AUDIT_DATABASE_PRINCIPAL_MANAGEMENT_EVENT", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.AuditDatabaseScopeGdrEvent, "AUDIT_DATABASE_SCOPE_GDR_EVENT", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.AuditDbccEvent, "AUDIT_DBCC_EVENT", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.AuditLogin, "AUDIT_LOGIN", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.AuditLoginChangePasswordEvent, "AUDIT_LOGIN_CHANGE_PASSWORD_EVENT", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.AuditLoginChangePropertyEvent, "AUDIT_LOGIN_CHANGE_PROPERTY_EVENT", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.AuditLoginFailed, "AUDIT_LOGIN_FAILED", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.AuditLoginGdrEvent, "AUDIT_LOGIN_GDR_EVENT", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.AuditLogout, "AUDIT_LOGOUT", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.AuditSchemaObjectAccessEvent, "AUDIT_SCHEMA_OBJECT_ACCESS_EVENT", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.AuditSchemaObjectGdrEvent, "AUDIT_SCHEMA_OBJECT_GDR_EVENT", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.AuditSchemaObjectManagementEvent, "AUDIT_SCHEMA_OBJECT_MANAGEMENT_EVENT", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.AuditSchemaObjectTakeOwnershipEvent, "AUDIT_SCHEMA_OBJECT_TAKE_OWNERSHIP_EVENT", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.AuditServerAlterTraceEvent, "AUDIT_SERVER_ALTER_TRACE_EVENT", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.AuditServerObjectGdrEvent, "AUDIT_SERVER_OBJECT_GDR_EVENT", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.AuditServerObjectManagementEvent, "AUDIT_SERVER_OBJECT_MANAGEMENT_EVENT", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.AuditServerObjectTakeOwnershipEvent, "AUDIT_SERVER_OBJECT_TAKE_OWNERSHIP_EVENT", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.AuditServerOperationEvent, "AUDIT_SERVER_OPERATION_EVENT", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.AuditServerPrincipalImpersonationEvent, "AUDIT_SERVER_PRINCIPAL_IMPERSONATION_EVENT", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.AuditServerPrincipalManagementEvent, "AUDIT_SERVER_PRINCIPAL_MANAGEMENT_EVENT", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.AuditServerScopeGdrEvent, "AUDIT_SERVER_SCOPE_GDR_EVENT", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.BlockedProcessReport, "BLOCKED_PROCESS_REPORT", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.BrokerQueueDisabled, "BROKER_QUEUE_DISABLED", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.DataFileAutoGrow, "DATA_FILE_AUTO_GROW", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.DataFileAutoShrink, "DATA_FILE_AUTO_SHRINK", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.DatabaseMirroringStateChange, "DATABASE_MIRRORING_STATE_CHANGE", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.DeadlockGraph, "DEADLOCK_GRAPH", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.DeprecationAnnouncement, "DEPRECATION_ANNOUNCEMENT", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.DeprecationFinalSupport, "DEPRECATION_FINAL_SUPPORT", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.ErrorLog, "ERRORLOG", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.EventLog, "EVENTLOG", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.Exception, "EXCEPTION", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.ExchangeSpillEvent, "EXCHANGE_SPILL_EVENT", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.ExecutionWarnings, "EXECUTION_WARNINGS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.FtCrawlAborted, "FT_CRAWL_ABORTED", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.FtCrawlStarted, "FT_CRAWL_STARTED", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.FtCrawlStopped, "FT_CRAWL_STOPPED", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.HashWarning, "HASH_WARNING", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.LockDeadlock, "LOCK_DEADLOCK", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.LockDeadlockChain, "LOCK_DEADLOCK_CHAIN", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.LockEscalation, "LOCK_ESCALATION", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.LogFileAutoGrow, "LOG_FILE_AUTO_GROW", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.LogFileAutoShrink, "LOG_FILE_AUTO_SHRINK", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.MissingColumnStatistics, "MISSING_COLUMN_STATISTICS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.MissingJoinPredicate, "MISSING_JOIN_PREDICATE", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.MountTape, "MOUNT_TAPE", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.ObjectAltered, "OBJECT_ALTERED", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.ObjectCreated, "OBJECT_CREATED", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.ObjectDeleted, "OBJECT_DELETED", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.OledbCallEvent, "OLEDB_CALL_EVENT", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.OledbDataReadEvent, "OLEDB_DATAREAD_EVENT", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.OledbErrors, "OLEDB_ERRORS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.OledbProviderInformation, "OLEDB_PROVIDER_INFORMATION", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.OledbQueryInterfaceEvent, "OLEDB_QUERYINTERFACE_EVENT", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.QnDynamics, "QN__DYNAMICS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.QnParameterTable, "QN__PARAMETER_TABLE", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.QnSubscription, "QN__SUBSCRIPTION", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.QnTemplate, "QN__TEMPLATE", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.QueueActivation, "QUEUE_ACTIVATION", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.ServerMemoryChange, "SERVER_MEMORY_CHANGE", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.ShowPlanAllForQueryCompile, "SHOWPLAN_ALL_FOR_QUERY_COMPILE", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.ShowPlanXmlForQueryCompile, "SHOWPLAN_XML_FOR_QUERY_COMPILE", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.ShowPlanXml, "SHOWPLAN_XML", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.ShowPlanXmlStatisticsProfile, "SHOWPLAN_XML_STATISTICS_PROFILE", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.SortWarnings, "SORT_WARNINGS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.SpCacheInsert, "SP_CACHEINSERT", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.SpCacheMiss, "SP_CACHEMISS", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.SpCacheRemove, "SP_CACHEREMOVE", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.SpRecompile, "SP_RECOMPILE", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.SqlStmtRecompile, "SQL_STMTRECOMPILE", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.TraceFileClose, "TRACE_FILE_CLOSE", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.UserErrorMessage, "USER_ERROR_MESSAGE", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.UserConfigurable0, "USERCONFIGURABLE_0", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.UserConfigurable1, "USERCONFIGURABLE_1", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.UserConfigurable2, "USERCONFIGURABLE_2", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.UserConfigurable3, "USERCONFIGURABLE_3", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.UserConfigurable4, "USERCONFIGURABLE_4", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.UserConfigurable5, "USERCONFIGURABLE_5", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.UserConfigurable6, "USERCONFIGURABLE_6", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.UserConfigurable7, "USERCONFIGURABLE_7", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.UserConfigurable8, "USERCONFIGURABLE_8", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.UserConfigurable9, "USERCONFIGURABLE_9", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.XQueryStaticType, "XQUERY_STATIC_TYPE", SqlVersionFlags.TSql90AndAbove);
			base.AddOptionMapping(EventNotificationEventType.AuditFullText, "AUDIT_FULLTEXT", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(EventNotificationEventType.BitmapWarning, "BITMAP_WARNING", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(EventNotificationEventType.CpuThresholdExceeded, "CPU_THRESHOLD_EXCEEDED", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(EventNotificationEventType.DatabaseSuspectDataPage, "DATABASE_SUSPECT_DATA_PAGE", SqlVersionFlags.TSql100AndAbove);
		}

		// Token: 0x04000196 RID: 406
		internal static readonly AuditEventTypeHelper Instance = new AuditEventTypeHelper();
	}
}
