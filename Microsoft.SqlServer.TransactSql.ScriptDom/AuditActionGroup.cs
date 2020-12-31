using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000058 RID: 88
	public enum AuditActionGroup
	{
		// Token: 0x0400016C RID: 364
		None,
		// Token: 0x0400016D RID: 365
		SuccessfulLogin,
		// Token: 0x0400016E RID: 366
		Logout,
		// Token: 0x0400016F RID: 367
		ServerStateChange,
		// Token: 0x04000170 RID: 368
		FailedLogin,
		// Token: 0x04000171 RID: 369
		LoginChangePassword,
		// Token: 0x04000172 RID: 370
		ServerRoleMemberChange,
		// Token: 0x04000173 RID: 371
		ServerPrincipalImpersonation,
		// Token: 0x04000174 RID: 372
		ServerObjectOwnershipChange,
		// Token: 0x04000175 RID: 373
		DatabaseMirroringLogin,
		// Token: 0x04000176 RID: 374
		BrokerLogin,
		// Token: 0x04000177 RID: 375
		ServerPermissionChange,
		// Token: 0x04000178 RID: 376
		ServerObjectPermissionChange,
		// Token: 0x04000179 RID: 377
		ServerOperation,
		// Token: 0x0400017A RID: 378
		TraceChange,
		// Token: 0x0400017B RID: 379
		ServerObjectChange,
		// Token: 0x0400017C RID: 380
		ServerPrincipalChange,
		// Token: 0x0400017D RID: 381
		DatabasePermissionChange,
		// Token: 0x0400017E RID: 382
		SchemaObjectPermissionChange,
		// Token: 0x0400017F RID: 383
		DatabaseRoleMemberChange,
		// Token: 0x04000180 RID: 384
		ApplicationRoleChangePassword,
		// Token: 0x04000181 RID: 385
		SchemaObjectAccess,
		// Token: 0x04000182 RID: 386
		BackupRestore,
		// Token: 0x04000183 RID: 387
		Dbcc,
		// Token: 0x04000184 RID: 388
		AuditChange,
		// Token: 0x04000185 RID: 389
		DatabaseChange,
		// Token: 0x04000186 RID: 390
		DatabaseObjectChange,
		// Token: 0x04000187 RID: 391
		DatabasePrincipalChange,
		// Token: 0x04000188 RID: 392
		SchemaObjectChange,
		// Token: 0x04000189 RID: 393
		DatabasePrincipalImpersonation,
		// Token: 0x0400018A RID: 394
		DatabaseObjectOwnershipChange,
		// Token: 0x0400018B RID: 395
		DatabaseOwnershipChange,
		// Token: 0x0400018C RID: 396
		SchemaObjectOwnershipChange,
		// Token: 0x0400018D RID: 397
		DatabaseObjectPermissionChange,
		// Token: 0x0400018E RID: 398
		DatabaseOperation,
		// Token: 0x0400018F RID: 399
		DatabaseObjectAccess,
		// Token: 0x04000190 RID: 400
		SuccessfulDatabaseAuthenticationGroup,
		// Token: 0x04000191 RID: 401
		FailedDatabaseAuthenticationGroup,
		// Token: 0x04000192 RID: 402
		DatabaseLogoutGroup,
		// Token: 0x04000193 RID: 403
		UserChangePasswordGroup,
		// Token: 0x04000194 RID: 404
		UserDefinedAuditGroup
	}
}
