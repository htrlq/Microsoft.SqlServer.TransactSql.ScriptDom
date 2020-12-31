using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200008A RID: 138
	internal class DatabaseAuditActionGroupHelper : OptionsHelper<AuditActionGroup>
	{
		// Token: 0x0600020C RID: 524 RVA: 0x000072DC File Offset: 0x000054DC
		private DatabaseAuditActionGroupHelper()
		{
			base.AddOptionMapping(AuditActionGroup.DatabasePermissionChange, "DATABASE_PERMISSION_CHANGE_GROUP", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(AuditActionGroup.SchemaObjectPermissionChange, "SCHEMA_OBJECT_PERMISSION_CHANGE_GROUP", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(AuditActionGroup.DatabaseRoleMemberChange, "DATABASE_ROLE_MEMBER_CHANGE_GROUP", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(AuditActionGroup.ApplicationRoleChangePassword, "APPLICATION_ROLE_CHANGE_PASSWORD_GROUP", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(AuditActionGroup.SchemaObjectAccess, "SCHEMA_OBJECT_ACCESS_GROUP", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(AuditActionGroup.BackupRestore, "BACKUP_RESTORE_GROUP", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(AuditActionGroup.Dbcc, "DBCC_GROUP", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(AuditActionGroup.AuditChange, "AUDIT_CHANGE_GROUP", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(AuditActionGroup.DatabaseChange, "DATABASE_CHANGE_GROUP", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(AuditActionGroup.DatabaseObjectChange, "DATABASE_OBJECT_CHANGE_GROUP", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(AuditActionGroup.DatabasePrincipalChange, "DATABASE_PRINCIPAL_CHANGE_GROUP", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(AuditActionGroup.SchemaObjectChange, "SCHEMA_OBJECT_CHANGE_GROUP", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(AuditActionGroup.DatabasePrincipalImpersonation, "DATABASE_PRINCIPAL_IMPERSONATION_GROUP", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(AuditActionGroup.DatabaseObjectOwnershipChange, "DATABASE_OBJECT_OWNERSHIP_CHANGE_GROUP", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(AuditActionGroup.DatabaseOwnershipChange, "DATABASE_OWNERSHIP_CHANGE_GROUP", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(AuditActionGroup.SchemaObjectOwnershipChange, "SCHEMA_OBJECT_OWNERSHIP_CHANGE_GROUP", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(AuditActionGroup.DatabaseObjectPermissionChange, "DATABASE_OBJECT_PERMISSION_CHANGE_GROUP", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(AuditActionGroup.DatabaseOperation, "DATABASE_OPERATION_GROUP", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(AuditActionGroup.DatabaseObjectAccess, "DATABASE_OBJECT_ACCESS_GROUP", SqlVersionFlags.TSql100AndAbove);
			base.AddOptionMapping(AuditActionGroup.SuccessfulDatabaseAuthenticationGroup, "SUCCESSFUL_DATABASE_AUTHENTICATION_GROUP", SqlVersionFlags.TSql110AndAbove);
			base.AddOptionMapping(AuditActionGroup.FailedDatabaseAuthenticationGroup, "FAILED_DATABASE_AUTHENTICATION_GROUP", SqlVersionFlags.TSql110AndAbove);
			base.AddOptionMapping(AuditActionGroup.DatabaseLogoutGroup, "DATABASE_LOGOUT_GROUP", SqlVersionFlags.TSql110AndAbove);
			base.AddOptionMapping(AuditActionGroup.UserChangePasswordGroup, "USER_CHANGE_PASSWORD_GROUP", SqlVersionFlags.TSql110AndAbove);
			base.AddOptionMapping(AuditActionGroup.UserDefinedAuditGroup, "USER_DEFINED_AUDIT_GROUP", SqlVersionFlags.TSql110AndAbove);
		}

		// Token: 0x04000826 RID: 2086
		internal static readonly DatabaseAuditActionGroupHelper Instance = new DatabaseAuditActionGroupHelper();
	}
}
