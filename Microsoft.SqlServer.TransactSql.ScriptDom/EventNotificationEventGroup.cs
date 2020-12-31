using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000B4 RID: 180
	public enum EventNotificationEventGroup
	{
		// Token: 0x04000974 RID: 2420
		Unknown,
		// Token: 0x04000975 RID: 2421
		DdlEvents = 10001,
		// Token: 0x04000976 RID: 2422
		DdlServerLevelEvents,
		// Token: 0x04000977 RID: 2423
		DdlEndpointEvents,
		// Token: 0x04000978 RID: 2424
		DdlDatabaseEvents,
		// Token: 0x04000979 RID: 2425
		DdlServerSecurityEvents,
		// Token: 0x0400097A RID: 2426
		DdlLoginEvents,
		// Token: 0x0400097B RID: 2427
		DdlGdrServerEvents,
		// Token: 0x0400097C RID: 2428
		DdlAuthorizationServerEvents,
		// Token: 0x0400097D RID: 2429
		DdlCredentialEvents,
		// Token: 0x0400097E RID: 2430
		DdlServiceMasterKeyEvents,
		// Token: 0x0400097F RID: 2431
		DdlExtendedProcedureEvents,
		// Token: 0x04000980 RID: 2432
		DdlLinkedServerEvents,
		// Token: 0x04000981 RID: 2433
		DdlLinkedServerLoginEvents,
		// Token: 0x04000982 RID: 2434
		DdlMessageEvents,
		// Token: 0x04000983 RID: 2435
		DdlRemoteServerEvents,
		// Token: 0x04000984 RID: 2436
		DdlDatabaseLevelEvents,
		// Token: 0x04000985 RID: 2437
		DdlTableViewEvents,
		// Token: 0x04000986 RID: 2438
		DdlTableEvents,
		// Token: 0x04000987 RID: 2439
		DdlViewEvents,
		// Token: 0x04000988 RID: 2440
		DdlIndexEvents,
		// Token: 0x04000989 RID: 2441
		DdlStatisticsEvents,
		// Token: 0x0400098A RID: 2442
		DdlSynonymEvents,
		// Token: 0x0400098B RID: 2443
		DdlFunctionEvents,
		// Token: 0x0400098C RID: 2444
		DdlProcedureEvents,
		// Token: 0x0400098D RID: 2445
		DdlTriggerEvents,
		// Token: 0x0400098E RID: 2446
		DdlEventNotificationEvents,
		// Token: 0x0400098F RID: 2447
		DdlAssemblyEvents,
		// Token: 0x04000990 RID: 2448
		DdlTypeEvents,
		// Token: 0x04000991 RID: 2449
		DdlDatabaseSecurityEvents,
		// Token: 0x04000992 RID: 2450
		DdlCertificateEvents,
		// Token: 0x04000993 RID: 2451
		DdlUserEvents,
		// Token: 0x04000994 RID: 2452
		DdlRoleEvents,
		// Token: 0x04000995 RID: 2453
		DdlApplicationRoleEvents,
		// Token: 0x04000996 RID: 2454
		DdlSchemaEvents,
		// Token: 0x04000997 RID: 2455
		DdlGdrDatabaseEvents,
		// Token: 0x04000998 RID: 2456
		DdlAuthorizationDatabaseEvents,
		// Token: 0x04000999 RID: 2457
		DdlSymmetricKeyEvents,
		// Token: 0x0400099A RID: 2458
		DdlAsymmetricKeyEvents,
		// Token: 0x0400099B RID: 2459
		DdlCryptoSignatureEvents,
		// Token: 0x0400099C RID: 2460
		DdlMasterKeyEvents,
		// Token: 0x0400099D RID: 2461
		DdlSsbEvents,
		// Token: 0x0400099E RID: 2462
		DdlMessageTypeEvents,
		// Token: 0x0400099F RID: 2463
		DdlContractEvents,
		// Token: 0x040009A0 RID: 2464
		DdlQueueEvents,
		// Token: 0x040009A1 RID: 2465
		DdlServiceEvents,
		// Token: 0x040009A2 RID: 2466
		DdlRouteEvents,
		// Token: 0x040009A3 RID: 2467
		DdlRemoteServiceBindingEvents,
		// Token: 0x040009A4 RID: 2468
		DdlXmlSchemaCollectionEvents,
		// Token: 0x040009A5 RID: 2469
		DdlPartitionEvents,
		// Token: 0x040009A6 RID: 2470
		DdlPartitionFunctionEvents,
		// Token: 0x040009A7 RID: 2471
		DdlPartitionSchemeEvents,
		// Token: 0x040009A8 RID: 2472
		DdlDefaultEvents,
		// Token: 0x040009A9 RID: 2473
		DdlExtendedPropertyEvents,
		// Token: 0x040009AA RID: 2474
		DdlFullTextCatalogEvents,
		// Token: 0x040009AB RID: 2475
		DdlPlanGuideEvents,
		// Token: 0x040009AC RID: 2476
		DdlRuleEvents,
		// Token: 0x040009AD RID: 2477
		DdlEventSessionEvents,
		// Token: 0x040009AE RID: 2478
		DdlResourceGovernorEvents,
		// Token: 0x040009AF RID: 2479
		DdlResourcePool,
		// Token: 0x040009B0 RID: 2480
		DdlWorkloadGroup,
		// Token: 0x040009B1 RID: 2481
		DdlCryptographicProviderEvents,
		// Token: 0x040009B2 RID: 2482
		DdlDatabaseEncryptionKeyEvents,
		// Token: 0x040009B3 RID: 2483
		DdlBrokerPriorityEvents,
		// Token: 0x040009B4 RID: 2484
		DdlServerAuditEvents,
		// Token: 0x040009B5 RID: 2485
		DdlServerAuditSpecificationEvents,
		// Token: 0x040009B6 RID: 2486
		DdlDatabaseAuditSpecificationEvents,
		// Token: 0x040009B7 RID: 2487
		DdlFullTextStopListEvents,
		// Token: 0x040009B8 RID: 2488
		DdlSearchPropertyListEvents = 10069,
		// Token: 0x040009B9 RID: 2489
		DdlSequenceEvents,
		// Token: 0x040009BA RID: 2490
		DdlAvailabilityGroupEvents,
		// Token: 0x040009BB RID: 2491
		DdlDatabaseAuditEvents,
		// Token: 0x040009BC RID: 2492
		TrcAllEvents = 11000,
		// Token: 0x040009BD RID: 2493
		TrcDatabase = 11002,
		// Token: 0x040009BE RID: 2494
		TrcErrorsAndWarnings,
		// Token: 0x040009BF RID: 2495
		TrcLocks,
		// Token: 0x040009C0 RID: 2496
		TrcObjects,
		// Token: 0x040009C1 RID: 2497
		TrcPerformance,
		// Token: 0x040009C2 RID: 2498
		TrcSecurityAudit = 11008,
		// Token: 0x040009C3 RID: 2499
		TrcServer,
		// Token: 0x040009C4 RID: 2500
		TrcStoredProcedures = 11011,
		// Token: 0x040009C5 RID: 2501
		TrcTSql = 11013,
		// Token: 0x040009C6 RID: 2502
		TrcUserConfigurable,
		// Token: 0x040009C7 RID: 2503
		TrcOledb,
		// Token: 0x040009C8 RID: 2504
		TrcFullText = 11017,
		// Token: 0x040009C9 RID: 2505
		TrcDeprecation,
		// Token: 0x040009CA RID: 2506
		TrcClr = 11020,
		// Token: 0x040009CB RID: 2507
		TrcQueryNotifications
	}
}
