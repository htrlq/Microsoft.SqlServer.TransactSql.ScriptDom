using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000B5 RID: 181
	public enum EventNotificationEventType
	{
		// Token: 0x040009CD RID: 2509
		Unknown,
		// Token: 0x040009CE RID: 2510
		CreateTable = 21,
		// Token: 0x040009CF RID: 2511
		AlterTable,
		// Token: 0x040009D0 RID: 2512
		DropTable,
		// Token: 0x040009D1 RID: 2513
		CreateIndex,
		// Token: 0x040009D2 RID: 2514
		AlterIndex,
		// Token: 0x040009D3 RID: 2515
		DropIndex,
		// Token: 0x040009D4 RID: 2516
		CreateStatistics,
		// Token: 0x040009D5 RID: 2517
		UpdateStatistics,
		// Token: 0x040009D6 RID: 2518
		DropStatistics,
		// Token: 0x040009D7 RID: 2519
		CreateSynonym = 34,
		// Token: 0x040009D8 RID: 2520
		DropSynonym = 36,
		// Token: 0x040009D9 RID: 2521
		CreateView = 41,
		// Token: 0x040009DA RID: 2522
		AlterView,
		// Token: 0x040009DB RID: 2523
		DropView,
		// Token: 0x040009DC RID: 2524
		CreateProcedure = 51,
		// Token: 0x040009DD RID: 2525
		AlterProcedure,
		// Token: 0x040009DE RID: 2526
		DropProcedure,
		// Token: 0x040009DF RID: 2527
		CreateFunction = 61,
		// Token: 0x040009E0 RID: 2528
		AlterFunction,
		// Token: 0x040009E1 RID: 2529
		DropFunction,
		// Token: 0x040009E2 RID: 2530
		CreateTrigger = 71,
		// Token: 0x040009E3 RID: 2531
		AlterTrigger,
		// Token: 0x040009E4 RID: 2532
		DropTrigger,
		// Token: 0x040009E5 RID: 2533
		CreateEventNotification,
		// Token: 0x040009E6 RID: 2534
		DropEventNotification = 76,
		// Token: 0x040009E7 RID: 2535
		CreateType = 91,
		// Token: 0x040009E8 RID: 2536
		DropType = 93,
		// Token: 0x040009E9 RID: 2537
		CreateAssembly = 101,
		// Token: 0x040009EA RID: 2538
		AlterAssembly,
		// Token: 0x040009EB RID: 2539
		DropAssembly,
		// Token: 0x040009EC RID: 2540
		CreateUser = 131,
		// Token: 0x040009ED RID: 2541
		AlterUser,
		// Token: 0x040009EE RID: 2542
		DropUser,
		// Token: 0x040009EF RID: 2543
		CreateRole,
		// Token: 0x040009F0 RID: 2544
		AlterRole,
		// Token: 0x040009F1 RID: 2545
		DropRole,
		// Token: 0x040009F2 RID: 2546
		CreateApplicationRole,
		// Token: 0x040009F3 RID: 2547
		AlterApplicationRole,
		// Token: 0x040009F4 RID: 2548
		DropApplicationRole,
		// Token: 0x040009F5 RID: 2549
		CreateSchema = 141,
		// Token: 0x040009F6 RID: 2550
		AlterSchema,
		// Token: 0x040009F7 RID: 2551
		DropSchema,
		// Token: 0x040009F8 RID: 2552
		CreateLogin,
		// Token: 0x040009F9 RID: 2553
		AlterLogin,
		// Token: 0x040009FA RID: 2554
		DropLogin,
		// Token: 0x040009FB RID: 2555
		CreateMessageType = 151,
		// Token: 0x040009FC RID: 2556
		AlterMessageType,
		// Token: 0x040009FD RID: 2557
		DropMessageType,
		// Token: 0x040009FE RID: 2558
		CreateContract,
		// Token: 0x040009FF RID: 2559
		DropContract = 156,
		// Token: 0x04000A00 RID: 2560
		CreateQueue,
		// Token: 0x04000A01 RID: 2561
		AlterQueue,
		// Token: 0x04000A02 RID: 2562
		DropQueue,
		// Token: 0x04000A03 RID: 2563
		BrokerQueueDisabled,
		// Token: 0x04000A04 RID: 2564
		CreateService,
		// Token: 0x04000A05 RID: 2565
		AlterService,
		// Token: 0x04000A06 RID: 2566
		DropService,
		// Token: 0x04000A07 RID: 2567
		CreateRoute,
		// Token: 0x04000A08 RID: 2568
		AlterRoute,
		// Token: 0x04000A09 RID: 2569
		DropRoute,
		// Token: 0x04000A0A RID: 2570
		GrantServer,
		// Token: 0x04000A0B RID: 2571
		DenyServer,
		// Token: 0x04000A0C RID: 2572
		RevokeServer,
		// Token: 0x04000A0D RID: 2573
		GrantDatabase,
		// Token: 0x04000A0E RID: 2574
		DenyDatabase,
		// Token: 0x04000A0F RID: 2575
		RevokeDatabase,
		// Token: 0x04000A10 RID: 2576
		QueueActivation,
		// Token: 0x04000A11 RID: 2577
		CreateRemoteServiceBinding,
		// Token: 0x04000A12 RID: 2578
		AlterRemoteServiceBinding,
		// Token: 0x04000A13 RID: 2579
		DropRemoteServiceBinding,
		// Token: 0x04000A14 RID: 2580
		CreateXmlSchemaCollection,
		// Token: 0x04000A15 RID: 2581
		AlterXmlSchemaCollection,
		// Token: 0x04000A16 RID: 2582
		DropXmlSchemaCollection,
		// Token: 0x04000A17 RID: 2583
		CreateEndpoint = 181,
		// Token: 0x04000A18 RID: 2584
		AlterEndpoint,
		// Token: 0x04000A19 RID: 2585
		DropEndpoint,
		// Token: 0x04000A1A RID: 2586
		CreatePartitionFunction = 191,
		// Token: 0x04000A1B RID: 2587
		AlterPartitionFunction,
		// Token: 0x04000A1C RID: 2588
		DropPartitionFunction,
		// Token: 0x04000A1D RID: 2589
		CreatePartitionScheme,
		// Token: 0x04000A1E RID: 2590
		AlterPartitionScheme,
		// Token: 0x04000A1F RID: 2591
		DropPartitionScheme,
		// Token: 0x04000A20 RID: 2592
		CreateCertificate,
		// Token: 0x04000A21 RID: 2593
		AlterCertificate,
		// Token: 0x04000A22 RID: 2594
		DropCertificate,
		// Token: 0x04000A23 RID: 2595
		CreateDatabase = 201,
		// Token: 0x04000A24 RID: 2596
		AlterDatabase,
		// Token: 0x04000A25 RID: 2597
		DropDatabase,
		// Token: 0x04000A26 RID: 2598
		AlterAuthorizationServer,
		// Token: 0x04000A27 RID: 2599
		AlterAuthorizationDatabase,
		// Token: 0x04000A28 RID: 2600
		CreateXmlIndex,
		// Token: 0x04000A29 RID: 2601
		AddRoleMember,
		// Token: 0x04000A2A RID: 2602
		DropRoleMember,
		// Token: 0x04000A2B RID: 2603
		AddServerRoleMember,
		// Token: 0x04000A2C RID: 2604
		DropServerRoleMember,
		// Token: 0x04000A2D RID: 2605
		AlterExtendedProperty,
		// Token: 0x04000A2E RID: 2606
		AlterFullTextCatalog,
		// Token: 0x04000A2F RID: 2607
		AlterFullTextIndex,
		// Token: 0x04000A30 RID: 2608
		AlterInstance,
		// Token: 0x04000A31 RID: 2609
		AlterMessage,
		// Token: 0x04000A32 RID: 2610
		AlterPlanGuide,
		// Token: 0x04000A33 RID: 2611
		AlterRemoteServer,
		// Token: 0x04000A34 RID: 2612
		BindDefault,
		// Token: 0x04000A35 RID: 2613
		BindRule,
		// Token: 0x04000A36 RID: 2614
		CreateDefault,
		// Token: 0x04000A37 RID: 2615
		CreateExtendedProcedure,
		// Token: 0x04000A38 RID: 2616
		CreateExtendedProperty,
		// Token: 0x04000A39 RID: 2617
		CreateFullTextCatalog,
		// Token: 0x04000A3A RID: 2618
		CreateFullTextIndex,
		// Token: 0x04000A3B RID: 2619
		CreateLinkedServer,
		// Token: 0x04000A3C RID: 2620
		CreateLinkedServerLogin,
		// Token: 0x04000A3D RID: 2621
		CreateMessage,
		// Token: 0x04000A3E RID: 2622
		CreatePlanGuide,
		// Token: 0x04000A3F RID: 2623
		CreateRule,
		// Token: 0x04000A40 RID: 2624
		CreateRemoteServer,
		// Token: 0x04000A41 RID: 2625
		DropDefault,
		// Token: 0x04000A42 RID: 2626
		DropExtendedProcedure,
		// Token: 0x04000A43 RID: 2627
		DropExtendedProperty,
		// Token: 0x04000A44 RID: 2628
		DropFullTextCatalog,
		// Token: 0x04000A45 RID: 2629
		DropFullTextIndex,
		// Token: 0x04000A46 RID: 2630
		DropLinkedServerLogin,
		// Token: 0x04000A47 RID: 2631
		DropMessage,
		// Token: 0x04000A48 RID: 2632
		DropPlanGuide,
		// Token: 0x04000A49 RID: 2633
		DropRule,
		// Token: 0x04000A4A RID: 2634
		DropRemoteServer,
		// Token: 0x04000A4B RID: 2635
		Rename,
		// Token: 0x04000A4C RID: 2636
		UnbindDefault,
		// Token: 0x04000A4D RID: 2637
		UnbindRule,
		// Token: 0x04000A4E RID: 2638
		CreateSymmetricKey,
		// Token: 0x04000A4F RID: 2639
		AlterSymmetricKey,
		// Token: 0x04000A50 RID: 2640
		DropSymmetricKey,
		// Token: 0x04000A51 RID: 2641
		CreateAsymmetricKey,
		// Token: 0x04000A52 RID: 2642
		AlterAsymmetricKey,
		// Token: 0x04000A53 RID: 2643
		DropAsymmetricKey,
		// Token: 0x04000A54 RID: 2644
		AlterServiceMasterKey = 251,
		// Token: 0x04000A55 RID: 2645
		CreateMasterKey,
		// Token: 0x04000A56 RID: 2646
		AlterMasterKey,
		// Token: 0x04000A57 RID: 2647
		DropMasterKey,
		// Token: 0x04000A58 RID: 2648
		AddSignatureSchemaObject,
		// Token: 0x04000A59 RID: 2649
		DropSignatureSchemaObject,
		// Token: 0x04000A5A RID: 2650
		AddSignature,
		// Token: 0x04000A5B RID: 2651
		DropSignature,
		// Token: 0x04000A5C RID: 2652
		CreateCredential,
		// Token: 0x04000A5D RID: 2653
		AlterCredential,
		// Token: 0x04000A5E RID: 2654
		DropCredential,
		// Token: 0x04000A5F RID: 2655
		DropLinkedServer,
		// Token: 0x04000A60 RID: 2656
		AlterLinkedServer,
		// Token: 0x04000A61 RID: 2657
		CreateEventSession,
		// Token: 0x04000A62 RID: 2658
		AlterEventSession,
		// Token: 0x04000A63 RID: 2659
		DropEventSession,
		// Token: 0x04000A64 RID: 2660
		CreateResourcePool,
		// Token: 0x04000A65 RID: 2661
		AlterResourcePool,
		// Token: 0x04000A66 RID: 2662
		DropResourcePool,
		// Token: 0x04000A67 RID: 2663
		CreateWorkloadGroup,
		// Token: 0x04000A68 RID: 2664
		AlterWorkloadGroup,
		// Token: 0x04000A69 RID: 2665
		DropWorkloadGroup,
		// Token: 0x04000A6A RID: 2666
		AlterResourceGovernorConfig,
		// Token: 0x04000A6B RID: 2667
		CreateSpatialIndex,
		// Token: 0x04000A6C RID: 2668
		CreateCryptographicProvider,
		// Token: 0x04000A6D RID: 2669
		AlterCryptographicProvider,
		// Token: 0x04000A6E RID: 2670
		DropCryptographicProvider,
		// Token: 0x04000A6F RID: 2671
		CreateDatabaseEncryptionKey,
		// Token: 0x04000A70 RID: 2672
		AlterDatabaseEncryptionKey,
		// Token: 0x04000A71 RID: 2673
		DropDatabaseEncryptionKey,
		// Token: 0x04000A72 RID: 2674
		CreateBrokerPriority,
		// Token: 0x04000A73 RID: 2675
		AlterBrokerPriority,
		// Token: 0x04000A74 RID: 2676
		DropBrokerPriority,
		// Token: 0x04000A75 RID: 2677
		CreateServerAudit,
		// Token: 0x04000A76 RID: 2678
		AlterServerAudit,
		// Token: 0x04000A77 RID: 2679
		DropServerAudit,
		// Token: 0x04000A78 RID: 2680
		CreateServerAuditSpecification,
		// Token: 0x04000A79 RID: 2681
		AlterServerAuditSpecification,
		// Token: 0x04000A7A RID: 2682
		DropServerAuditSpecification,
		// Token: 0x04000A7B RID: 2683
		CreateDatabaseAuditSpecification,
		// Token: 0x04000A7C RID: 2684
		AlterDatabaseAuditSpecification,
		// Token: 0x04000A7D RID: 2685
		DropDatabaseAuditSpecification,
		// Token: 0x04000A7E RID: 2686
		CreateFullTextStopList,
		// Token: 0x04000A7F RID: 2687
		AlterFullTextStopList,
		// Token: 0x04000A80 RID: 2688
		DropFullTextStopList,
		// Token: 0x04000A81 RID: 2689
		AlterServerConfiguration,
		// Token: 0x04000A82 RID: 2690
		CreateSearchPropertyList,
		// Token: 0x04000A83 RID: 2691
		AlterSearchPropertyList,
		// Token: 0x04000A84 RID: 2692
		DropSearchPropertyList,
		// Token: 0x04000A85 RID: 2693
		CreateServerRole,
		// Token: 0x04000A86 RID: 2694
		AlterServerRole,
		// Token: 0x04000A87 RID: 2695
		DropServerRole,
		// Token: 0x04000A88 RID: 2696
		CreateSequence,
		// Token: 0x04000A89 RID: 2697
		AlterSequence,
		// Token: 0x04000A8A RID: 2698
		DropSequence,
		// Token: 0x04000A8B RID: 2699
		CreateAvailabilityGroup,
		// Token: 0x04000A8C RID: 2700
		AlterAvailabilityGroup,
		// Token: 0x04000A8D RID: 2701
		DropAvailabilityGroup,
		// Token: 0x04000A8E RID: 2702
		CreateDatabaseAudit,
		// Token: 0x04000A8F RID: 2703
		DropDatabaseAudit,
		// Token: 0x04000A90 RID: 2704
		AlterDatabaseAudit,
		// Token: 0x04000A91 RID: 2705
		AuditLogin = 1014,
		// Token: 0x04000A92 RID: 2706
		AuditLogout,
		// Token: 0x04000A93 RID: 2707
		AuditLoginFailed = 1020,
		// Token: 0x04000A94 RID: 2708
		EventLog,
		// Token: 0x04000A95 RID: 2709
		ErrorLog,
		// Token: 0x04000A96 RID: 2710
		LockDeadlock = 1025,
		// Token: 0x04000A97 RID: 2711
		Exception = 1033,
		// Token: 0x04000A98 RID: 2712
		SpCacheMiss,
		// Token: 0x04000A99 RID: 2713
		SpCacheInsert,
		// Token: 0x04000A9A RID: 2714
		SpCacheRemove,
		// Token: 0x04000A9B RID: 2715
		SpRecompile,
		// Token: 0x04000A9C RID: 2716
		ObjectCreated = 1046,
		// Token: 0x04000A9D RID: 2717
		ObjectDeleted,
		// Token: 0x04000A9E RID: 2718
		HashWarning = 1055,
		// Token: 0x04000A9F RID: 2719
		LockDeadlockChain = 1059,
		// Token: 0x04000AA0 RID: 2720
		LockEscalation,
		// Token: 0x04000AA1 RID: 2721
		OledbErrors,
		// Token: 0x04000AA2 RID: 2722
		ExecutionWarnings = 1067,
		// Token: 0x04000AA3 RID: 2723
		SortWarnings = 1069,
		// Token: 0x04000AA4 RID: 2724
		MissingColumnStatistics = 1079,
		// Token: 0x04000AA5 RID: 2725
		MissingJoinPredicate,
		// Token: 0x04000AA6 RID: 2726
		ServerMemoryChange,
		// Token: 0x04000AA7 RID: 2727
		UserConfigurable0,
		// Token: 0x04000AA8 RID: 2728
		UserConfigurable1,
		// Token: 0x04000AA9 RID: 2729
		UserConfigurable2,
		// Token: 0x04000AAA RID: 2730
		UserConfigurable3,
		// Token: 0x04000AAB RID: 2731
		UserConfigurable4,
		// Token: 0x04000AAC RID: 2732
		UserConfigurable5,
		// Token: 0x04000AAD RID: 2733
		UserConfigurable6,
		// Token: 0x04000AAE RID: 2734
		UserConfigurable7,
		// Token: 0x04000AAF RID: 2735
		UserConfigurable8,
		// Token: 0x04000AB0 RID: 2736
		UserConfigurable9,
		// Token: 0x04000AB1 RID: 2737
		DataFileAutoGrow,
		// Token: 0x04000AB2 RID: 2738
		LogFileAutoGrow,
		// Token: 0x04000AB3 RID: 2739
		DataFileAutoShrink,
		// Token: 0x04000AB4 RID: 2740
		LogFileAutoShrink,
		// Token: 0x04000AB5 RID: 2741
		AuditDatabaseScopeGdrEvent = 1102,
		// Token: 0x04000AB6 RID: 2742
		AuditSchemaObjectGdrEvent,
		// Token: 0x04000AB7 RID: 2743
		AuditAddLoginEvent,
		// Token: 0x04000AB8 RID: 2744
		AuditLoginGdrEvent,
		// Token: 0x04000AB9 RID: 2745
		AuditLoginChangePropertyEvent,
		// Token: 0x04000ABA RID: 2746
		AuditLoginChangePasswordEvent,
		// Token: 0x04000ABB RID: 2747
		AuditAddLoginToServerRoleEvent,
		// Token: 0x04000ABC RID: 2748
		AuditAddDBUserEvent,
		// Token: 0x04000ABD RID: 2749
		AuditAddMemberToDBRoleEvent,
		// Token: 0x04000ABE RID: 2750
		AuditAddRoleEvent,
		// Token: 0x04000ABF RID: 2751
		AuditAppRoleChangePasswordEvent,
		// Token: 0x04000AC0 RID: 2752
		AuditSchemaObjectAccessEvent = 1114,
		// Token: 0x04000AC1 RID: 2753
		AuditBackupRestoreEvent,
		// Token: 0x04000AC2 RID: 2754
		AuditDbccEvent,
		// Token: 0x04000AC3 RID: 2755
		AuditChangeAuditEvent,
		// Token: 0x04000AC4 RID: 2756
		OledbCallEvent = 1119,
		// Token: 0x04000AC5 RID: 2757
		OledbQueryInterfaceEvent,
		// Token: 0x04000AC6 RID: 2758
		OledbDataReadEvent,
		// Token: 0x04000AC7 RID: 2759
		ShowPlanXml,
		// Token: 0x04000AC8 RID: 2760
		DeprecationAnnouncement = 1125,
		// Token: 0x04000AC9 RID: 2761
		DeprecationFinalSupport,
		// Token: 0x04000ACA RID: 2762
		ExchangeSpillEvent,
		// Token: 0x04000ACB RID: 2763
		AuditDatabaseManagementEvent,
		// Token: 0x04000ACC RID: 2764
		AuditDatabaseObjectManagementEvent,
		// Token: 0x04000ACD RID: 2765
		AuditDatabasePrincipalManagementEvent,
		// Token: 0x04000ACE RID: 2766
		AuditSchemaObjectManagementEvent,
		// Token: 0x04000ACF RID: 2767
		AuditServerPrincipalImpersonationEvent,
		// Token: 0x04000AD0 RID: 2768
		AuditDatabasePrincipalImpersonationEvent,
		// Token: 0x04000AD1 RID: 2769
		AuditServerObjectTakeOwnershipEvent,
		// Token: 0x04000AD2 RID: 2770
		AuditDatabaseObjectTakeOwnershipEvent,
		// Token: 0x04000AD3 RID: 2771
		BlockedProcessReport = 1137,
		// Token: 0x04000AD4 RID: 2772
		ShowPlanXmlStatisticsProfile = 1146,
		// Token: 0x04000AD5 RID: 2773
		DeadlockGraph = 1148,
		// Token: 0x04000AD6 RID: 2774
		TraceFileClose = 1150,
		// Token: 0x04000AD7 RID: 2775
		AuditChangeDatabaseOwner = 1152,
		// Token: 0x04000AD8 RID: 2776
		AuditSchemaObjectTakeOwnershipEvent,
		// Token: 0x04000AD9 RID: 2777
		FtCrawlStarted = 1155,
		// Token: 0x04000ADA RID: 2778
		FtCrawlStopped,
		// Token: 0x04000ADB RID: 2779
		FtCrawlAborted,
		// Token: 0x04000ADC RID: 2780
		UserErrorMessage = 1162,
		// Token: 0x04000ADD RID: 2781
		ObjectAltered = 1164,
		// Token: 0x04000ADE RID: 2782
		SqlStmtRecompile = 1166,
		// Token: 0x04000ADF RID: 2783
		DatabaseMirroringStateChange,
		// Token: 0x04000AE0 RID: 2784
		ShowPlanXmlForQueryCompile,
		// Token: 0x04000AE1 RID: 2785
		ShowPlanAllForQueryCompile,
		// Token: 0x04000AE2 RID: 2786
		AuditServerScopeGdrEvent,
		// Token: 0x04000AE3 RID: 2787
		AuditServerObjectGdrEvent,
		// Token: 0x04000AE4 RID: 2788
		AuditDatabaseObjectGdrEvent,
		// Token: 0x04000AE5 RID: 2789
		AuditServerOperationEvent,
		// Token: 0x04000AE6 RID: 2790
		AuditServerAlterTraceEvent = 1175,
		// Token: 0x04000AE7 RID: 2791
		AuditServerObjectManagementEvent,
		// Token: 0x04000AE8 RID: 2792
		AuditServerPrincipalManagementEvent,
		// Token: 0x04000AE9 RID: 2793
		AuditDatabaseOperationEvent,
		// Token: 0x04000AEA RID: 2794
		AuditDatabaseObjectAccessEvent = 1180,
		// Token: 0x04000AEB RID: 2795
		OledbProviderInformation = 1194,
		// Token: 0x04000AEC RID: 2796
		MountTape,
		// Token: 0x04000AED RID: 2797
		AssemblyLoad,
		// Token: 0x04000AEE RID: 2798
		XQueryStaticType = 1198,
		// Token: 0x04000AEF RID: 2799
		QnSubscription,
		// Token: 0x04000AF0 RID: 2800
		QnParameterTable,
		// Token: 0x04000AF1 RID: 2801
		QnTemplate,
		// Token: 0x04000AF2 RID: 2802
		QnDynamics,
		// Token: 0x04000AF3 RID: 2803
		BitmapWarning = 1212,
		// Token: 0x04000AF4 RID: 2804
		DatabaseSuspectDataPage,
		// Token: 0x04000AF5 RID: 2805
		CpuThresholdExceeded,
		// Token: 0x04000AF6 RID: 2806
		AuditFullText = 1235
	}
}
