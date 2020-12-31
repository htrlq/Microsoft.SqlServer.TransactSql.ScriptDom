using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200007F RID: 127
	internal static class CodeGenerationSupporter
	{
		// Token: 0x0400025E RID: 606
		internal const string KB = "KB";

		// Token: 0x0400025F RID: 607
		internal const string MB = "MB";

		// Token: 0x04000260 RID: 608
		internal const string GB = "GB";

		// Token: 0x04000261 RID: 609
		internal const string TB = "TB";

		// Token: 0x04000262 RID: 610
		internal const string ACP = "ACP";

		// Token: 0x04000263 RID: 611
		internal const string OEM = "OEM";

		// Token: 0x04000264 RID: 612
		internal const string Tcp = "TCP";

		// Token: 0x04000265 RID: 613
		internal const string Http = "HTTP";

		// Token: 0x04000266 RID: 614
		internal const string Days = "DAYS";

		// Token: 0x04000267 RID: 615
		internal const string Hours = "HOURS";

		// Token: 0x04000268 RID: 616
		internal const string Minutes = "MINUTES";

		// Token: 0x04000269 RID: 617
		internal const string RC2 = "RC2";

		// Token: 0x0400026A RID: 618
		internal const string RC4 = "RC4";

		// Token: 0x0400026B RID: 619
		internal const string RC4_128 = "RC4_128";

		// Token: 0x0400026C RID: 620
		internal const string Des = "DES";

		// Token: 0x0400026D RID: 621
		internal const string TripleDes = "TRIPLE_DES";

		// Token: 0x0400026E RID: 622
		internal const string TripleDes3Key = "TRIPLE_DES_3KEY";

		// Token: 0x0400026F RID: 623
		internal const string DesX = "DESX";

		// Token: 0x04000270 RID: 624
		internal const string Aes = "AES";

		// Token: 0x04000271 RID: 625
		internal const string Aes128 = "AES_128";

		// Token: 0x04000272 RID: 626
		internal const string Aes192 = "AES_192";

		// Token: 0x04000273 RID: 627
		internal const string Aes256 = "AES_256";

		// Token: 0x04000274 RID: 628
		internal const string Rsa512 = "RSA_512";

		// Token: 0x04000275 RID: 629
		internal const string Rsa1024 = "RSA_1024";

		// Token: 0x04000276 RID: 630
		internal const string Rsa2048 = "RSA_2048";

		// Token: 0x04000277 RID: 631
		internal const string QuotedIdentifier = "QUOTED_IDENTIFIER";

		// Token: 0x04000278 RID: 632
		internal const string ConcatNullYieldsNull = "CONCAT_NULL_YIELDS_NULL";

		// Token: 0x04000279 RID: 633
		internal const string ArithAbort = "ARITHABORT";

		// Token: 0x0400027A RID: 634
		internal const string ArithIgnore = "ARITHIGNORE";

		// Token: 0x0400027B RID: 635
		internal const string FmtOnly = "FMTONLY";

		// Token: 0x0400027C RID: 636
		internal const string NoCompression = "NO_COMPRESSION";

		// Token: 0x0400027D RID: 637
		internal const string NoCount = "NOCOUNT";

		// Token: 0x0400027E RID: 638
		internal const string NoExec = "NOEXEC";

		// Token: 0x0400027F RID: 639
		internal const string NumericRoundAbort = "NUMERIC_ROUNDABORT";

		// Token: 0x04000280 RID: 640
		internal const string ParseOnly = "PARSEONLY";

		// Token: 0x04000281 RID: 641
		internal const string AnsiDefaults = "ANSI_DEFAULTS";

		// Token: 0x04000282 RID: 642
		internal const string AnsiNullDfltOff = "ANSI_NULL_DFLT_OFF";

		// Token: 0x04000283 RID: 643
		internal const string AnsiNullDfltOn = "ANSI_NULL_DFLT_ON";

		// Token: 0x04000284 RID: 644
		internal const string AnsiNulls = "ANSI_NULLS";

		// Token: 0x04000285 RID: 645
		internal const string AnsiPadding = "ANSI_PADDING";

		// Token: 0x04000286 RID: 646
		internal const string AnsiWarnings = "ANSI_WARNINGS";

		// Token: 0x04000287 RID: 647
		internal const string ForcePlan = "FORCEPLAN";

		// Token: 0x04000288 RID: 648
		internal const string ShowPlanAll = "SHOWPLAN_ALL";

		// Token: 0x04000289 RID: 649
		internal const string ShowPlanText = "SHOWPLAN_TEXT";

		// Token: 0x0400028A RID: 650
		internal const string IO = "IO";

		// Token: 0x0400028B RID: 651
		internal const string Profile = "PROFILE";

		// Token: 0x0400028C RID: 652
		internal const string ImplicitTransactions = "IMPLICIT_TRANSACTIONS";

		// Token: 0x0400028D RID: 653
		internal const string RemoteProcTransactions = "REMOTE_PROC_TRANSACTIONS";

		// Token: 0x0400028E RID: 654
		internal const string XactAbort = "XACT_ABORT";

		// Token: 0x0400028F RID: 655
		internal const string AbortAfterWait = "ABORT_AFTER_WAIT";

		// Token: 0x04000290 RID: 656
		internal const string Absent = "ABSENT";

		// Token: 0x04000291 RID: 657
		internal const string Absolute = "ABSOLUTE";

		// Token: 0x04000292 RID: 658
		internal const string AccentSensitivity = "ACCENT_SENSITIVITY";

		// Token: 0x04000293 RID: 659
		internal const string Action = "ACTION";

		// Token: 0x04000294 RID: 660
		internal const string Active = "ACTIVE";

		// Token: 0x04000295 RID: 661
		internal const string Activation = "ACTIVATION";

		// Token: 0x04000296 RID: 662
		internal const string Add = "ADD";

		// Token: 0x04000297 RID: 663
		internal const string Address = "ADDRESS";

		// Token: 0x04000298 RID: 664
		internal const string Admin = "ADMIN";

		// Token: 0x04000299 RID: 665
		internal const string Affinity = "AFFINITY";

		// Token: 0x0400029A RID: 666
		internal const string After = "AFTER";

		// Token: 0x0400029B RID: 667
		internal const string Aggregate = "AGGREGATE";

		// Token: 0x0400029C RID: 668
		internal const string Algorithm = "ALGORITHM";

		// Token: 0x0400029D RID: 669
		internal const string AlterColumn = "ALTERCOLUMN";

		// Token: 0x0400029E RID: 670
		internal const string All = "ALL";

		// Token: 0x0400029F RID: 671
		internal const string AllConstraints = "ALL_CONSTRAINTS";

		// Token: 0x040002A0 RID: 672
		internal const string AllErrorMessages = "ALL_ERRORMSGS";

		// Token: 0x040002A1 RID: 673
		internal const string AllIndexes = "ALL_INDEXES";

		// Token: 0x040002A2 RID: 674
		internal const string AllLevels = "ALL_LEVELS";

		// Token: 0x040002A3 RID: 675
		internal const string AllowConnections = "ALLOW_CONNECTIONS";

		// Token: 0x040002A4 RID: 676
		internal const string Allowed = "ALLOWED";

		// Token: 0x040002A5 RID: 677
		internal const string AllowMultipleEventLoss = "ALLOW_MULTIPLE_EVENT_LOSS";

		// Token: 0x040002A6 RID: 678
		internal const string AllowSingleEventLoss = "ALLOW_SINGLE_EVENT_LOSS";

		// Token: 0x040002A7 RID: 679
		internal const string AllowSnapshotIsolation = "ALLOW_SNAPSHOT_ISOLATION";

		// Token: 0x040002A8 RID: 680
		internal const string AllowPageLocks = "ALLOW_PAGE_LOCKS";

		// Token: 0x040002A9 RID: 681
		internal const string AllowRowLocks = "ALLOW_ROW_LOCKS";

		// Token: 0x040002AA RID: 682
		internal const string AllResults = "ALL_RESULTS";

		// Token: 0x040002AB RID: 683
		internal const string AllSparseColumns = "ALL_SPARSE_COLUMNS";

		// Token: 0x040002AC RID: 684
		internal const string Anonymous = "ANONYMOUS";

		// Token: 0x040002AD RID: 685
		internal const string AnsiNullDefault = "ANSI_NULL_DEFAULT";

		// Token: 0x040002AE RID: 686
		internal const string Application = "APPLICATION";

		// Token: 0x040002AF RID: 687
		internal const string ApplicationLog = "APPLICATION_LOG";

		// Token: 0x040002B0 RID: 688
		internal const string Apply = "APPLY";

		// Token: 0x040002B1 RID: 689
		internal const string ApplyDelay = "APPLY_DELAY";

		// Token: 0x040002B2 RID: 690
		internal const string Assembly = "ASSEMBLY";

		// Token: 0x040002B3 RID: 691
		internal const string Asymmetric = "ASYMMETRIC";

		// Token: 0x040002B4 RID: 692
		internal const string AsynchronousCommit = "ASYNCHRONOUS_COMMIT";

		// Token: 0x040002B5 RID: 693
		internal const string At = "AT";

		// Token: 0x040002B6 RID: 694
		internal const string Attach = "ATTACH";

		// Token: 0x040002B7 RID: 695
		internal const string AttachRebuildLog = "ATTACH_REBUILD_LOG";

		// Token: 0x040002B8 RID: 696
		internal const string AttachForceRebuildLog = "ATTACH_FORCE_REBUILD_LOG";

		// Token: 0x040002B9 RID: 697
		internal const string Atomic = "ATOMIC";

		// Token: 0x040002BA RID: 698
		internal const string Append = "APPEND";

		// Token: 0x040002BB RID: 699
		internal const string Avg = "AVG";

		// Token: 0x040002BC RID: 700
		internal const string Attested = "ATTESTED";

		// Token: 0x040002BD RID: 701
		internal const string AuditGuid = "AUDIT_GUID";

		// Token: 0x040002BE RID: 702
		internal const string Authentication = "AUTHENTICATION";

		// Token: 0x040002BF RID: 703
		internal const string AuthRealm = "AUTH_REALM";

		// Token: 0x040002C0 RID: 704
		internal const string Auto = "AUTO";

		// Token: 0x040002C1 RID: 705
		internal const string AutoCleanup = "AUTO_CLEANUP";

		// Token: 0x040002C2 RID: 706
		internal const string AutoClose = "AUTO_CLOSE";

		// Token: 0x040002C3 RID: 707
		internal const string AutoCreateStatistics = "AUTO_CREATE_STATISTICS";

		// Token: 0x040002C4 RID: 708
		internal const string Automatic = "AUTOMATIC";

		// Token: 0x040002C5 RID: 709
		internal const string AutoShrink = "AUTO_SHRINK";

		// Token: 0x040002C6 RID: 710
		internal const string AutoUpdateStatistics = "AUTO_UPDATE_STATISTICS";

		// Token: 0x040002C7 RID: 711
		internal const string AutoUpdateStatisticsAsync = "AUTO_UPDATE_STATISTICS_ASYNC";

		// Token: 0x040002C8 RID: 712
		internal const string Availability = "AVAILABILITY";

		// Token: 0x040002C9 RID: 713
		internal const string AvailabilityMode = "AVAILABILITY_MODE";

		// Token: 0x040002CA RID: 714
		internal const string Base64 = "BASE64";

		// Token: 0x040002CB RID: 715
		internal const string Basic = "BASIC";

		// Token: 0x040002CC RID: 716
		internal const string Batches = "BATCHES";

		// Token: 0x040002CD RID: 717
		internal const string BatchSize = "BATCHSIZE";

		// Token: 0x040002CE RID: 718
		internal const string BeginDialog = "BEGIN_DIALOG";

		// Token: 0x040002CF RID: 719
		internal const string BigInt = "BIGINT";

		// Token: 0x040002D0 RID: 720
		internal const string Binding = "BINDING";

		// Token: 0x040002D1 RID: 721
		internal const string Binary = "BINARY";

		// Token: 0x040002D2 RID: 722
		internal const string Bit = "BIT";

		// Token: 0x040002D3 RID: 723
		internal const string Blockers = "BLOCKERS";

		// Token: 0x040002D4 RID: 724
		internal const string BlockSize = "BLOCKSIZE";

		// Token: 0x040002D5 RID: 725
		internal const string BoundingBox = "BOUNDING_BOX";

		// Token: 0x040002D6 RID: 726
		internal const string Broker = "BROKER";

		// Token: 0x040002D7 RID: 727
		internal const string BrokerInstance = "BROKER_INSTANCE";

		// Token: 0x040002D8 RID: 728
		internal const string BufferCount = "BUFFERCOUNT";

		// Token: 0x040002D9 RID: 729
		internal const string BucketCount = "BUCKET_COUNT";

		// Token: 0x040002DA RID: 730
		internal const string BulkLogged = "BULK_LOGGED";

		// Token: 0x040002DB RID: 731
		internal const string Bypass = "BYPASS";

		// Token: 0x040002DC RID: 732
		internal const string Cache = "CACHE";

		// Token: 0x040002DD RID: 733
		internal const string Called = "CALLED";

		// Token: 0x040002DE RID: 734
		internal const string Caller = "CALLER";

		// Token: 0x040002DF RID: 735
		internal const string CapCpuPercent = "CAP_CPU_PERCENT";

		// Token: 0x040002E0 RID: 736
		internal const string CapIoPercent = "CAP_IO_PERCENT";

		// Token: 0x040002E1 RID: 737
		internal const string CardinalityTunerLimit = "CARDINALITY_TUNER_LIMIT";

		// Token: 0x040002E2 RID: 738
		internal const string Cast = "CAST";

		// Token: 0x040002E3 RID: 739
		internal const string Catalog = "CATALOG";

		// Token: 0x040002E4 RID: 740
		internal const string Catch = "CATCH";

		// Token: 0x040002E5 RID: 741
		internal const string CellsPerObject = "CELLS_PER_OBJECT";

		// Token: 0x040002E6 RID: 742
		internal const string Certificate = "CERTIFICATE";

		// Token: 0x040002E7 RID: 743
		internal const string Credential = "CREDENTIAL";

		// Token: 0x040002E8 RID: 744
		internal const string ChangeRetention = "CHANGE_RETENTION";

		// Token: 0x040002E9 RID: 745
		internal const string Changes = "CHANGES";

		// Token: 0x040002EA RID: 746
		internal const string ChangeTable = "CHANGETABLE";

		// Token: 0x040002EB RID: 747
		internal const string ChangeTracking = "CHANGE_TRACKING";

		// Token: 0x040002EC RID: 748
		internal const string ChangeTrackingContext = "CHANGE_TRACKING_CONTEXT";

		// Token: 0x040002ED RID: 749
		internal const string Char = "CHAR";

		// Token: 0x040002EE RID: 750
		internal const string CharacterSet = "CHARACTER_SET";

		// Token: 0x040002EF RID: 751
		internal const string CheckConstraints = "CHECK_CONSTRAINTS";

		// Token: 0x040002F0 RID: 752
		internal const string CheckConstraintsHint = "CHECKCONSTRAINTS";

		// Token: 0x040002F1 RID: 753
		internal const string CheckExpiration = "CHECK_EXPIRATION";

		// Token: 0x040002F2 RID: 754
		internal const string CheckPolicy = "CHECK_POLICY";

		// Token: 0x040002F3 RID: 755
		internal const string Checksum = "CHECKSUM";

		// Token: 0x040002F4 RID: 756
		internal const string ChecksumAgg = "CHECKSUM_AGG";

		// Token: 0x040002F5 RID: 757
		internal const string ClassifierFunction = "CLASSIFIER_FUNCTION";

		// Token: 0x040002F6 RID: 758
		internal const string Cleanup = "CLEANUP";

		// Token: 0x040002F7 RID: 759
		internal const string Clear = "CLEAR";

		// Token: 0x040002F8 RID: 760
		internal const string Cluster = "CLUSTER";

		// Token: 0x040002F9 RID: 761
		internal const string ClearPort = "CLEAR_PORT";

		// Token: 0x040002FA RID: 762
		internal const string CodePage = "CODEPAGE";

		// Token: 0x040002FB RID: 763
		internal const string Collection = "COLLECTION";

		// Token: 0x040002FC RID: 764
		internal const string Columns = "COLUMNS";

		// Token: 0x040002FD RID: 765
		internal const string ColumnSet = "COLUMN_SET";

		// Token: 0x040002FE RID: 766
		internal const string ColumnStore = "COLUMNSTORE";

		// Token: 0x040002FF RID: 767
		internal const string ColumnStoreArchive = "COLUMNSTORE_ARCHIVE";

		// Token: 0x04000300 RID: 768
		internal const string CommitDifferentialBase = "COMMIT_DIFFERENTIAL_BASE";

		// Token: 0x04000301 RID: 769
		internal const string Committed = "COMMITTED";

		// Token: 0x04000302 RID: 770
		internal const string CompatibilityLevel = "COMPATIBILITY_LEVEL";

		// Token: 0x04000303 RID: 771
		internal const string Compression = "COMPRESSION";

		// Token: 0x04000304 RID: 772
		internal const string Concat = "CONCAT";

		// Token: 0x04000305 RID: 773
		internal const string Configuration = "CONFIGURATION";

		// Token: 0x04000306 RID: 774
		internal const string Containment = "CONTAINMENT";

		// Token: 0x04000307 RID: 775
		internal const string Content = "CONTENT";

		// Token: 0x04000308 RID: 776
		internal const string Context = "CONTEXT";

		// Token: 0x04000309 RID: 777
		internal const string ContextInfo = "CONTEXT_INFO";

		// Token: 0x0400030A RID: 778
		internal const string ContinueAfterError = "CONTINUE_AFTER_ERROR";

		// Token: 0x0400030B RID: 779
		internal const string Contract = "CONTRACT";

		// Token: 0x0400030C RID: 780
		internal const string ContractName = "CONTRACT_NAME";

		// Token: 0x0400030D RID: 781
		internal const string Conversation = "CONVERSATION";

		// Token: 0x0400030E RID: 782
		internal const string ConversationGroupId = "CONVERSATION_GROUP_ID";

		// Token: 0x0400030F RID: 783
		internal const string ConversationHandle = "CONVERSATION_HANDLE";

		// Token: 0x04000310 RID: 784
		internal const string Cookie = "COOKIE";

		// Token: 0x04000311 RID: 785
		internal const string Copy = "COPY";

		// Token: 0x04000312 RID: 786
		internal const string CopyOnly = "COPY_ONLY";

		// Token: 0x04000313 RID: 787
		internal const string Correlated = "CORRELATED";

		// Token: 0x04000314 RID: 788
		internal const string Count = "COUNT";

		// Token: 0x04000315 RID: 789
		internal const string CountBig = "COUNT_BIG";

		// Token: 0x04000316 RID: 790
		internal const string Counter = "COUNTER";

		// Token: 0x04000317 RID: 791
		internal const string CountRows = "COUNT_ROWS";

		// Token: 0x04000318 RID: 792
		internal const string Cpu = "CPU";

		// Token: 0x04000319 RID: 793
		internal const string CreateNew = "CREATE_NEW";

		// Token: 0x0400031A RID: 794
		internal const string CreationDisposition = "CREATION_DISPOSITION";

		// Token: 0x0400031B RID: 795
		internal const string Cryptographic = "CRYPTOGRAPHIC";

		// Token: 0x0400031C RID: 796
		internal const string Cube = "CUBE";

		// Token: 0x0400031D RID: 797
		internal const string Cuid = "CUID";

		// Token: 0x0400031E RID: 798
		internal const string CursorCloseOnCommit = "CURSOR_CLOSE_ON_COMMIT";

		// Token: 0x0400031F RID: 799
		internal const string CursorDefault = "CURSOR_DEFAULT";

		// Token: 0x04000320 RID: 800
		internal const string Cycle = "Cycle";

		// Token: 0x04000321 RID: 801
		internal const string D = "D";

		// Token: 0x04000322 RID: 802
		internal const string Data = "DATA";

		// Token: 0x04000323 RID: 803
		internal const string Database = "DATABASE";

		// Token: 0x04000324 RID: 804
		internal const string DatabaseMirroring = "DATABASE_MIRRORING";

		// Token: 0x04000325 RID: 805
		internal const string DataCompression = "DATA_COMPRESSION";

		// Token: 0x04000326 RID: 806
		internal const string DataMirroring = "DATA_MIRRORING";

		// Token: 0x04000327 RID: 807
		internal const string DataFileType = "DATAFILETYPE";

		// Token: 0x04000328 RID: 808
		internal const string Date = "DATE";

		// Token: 0x04000329 RID: 809
		internal const string DateCorrelationOptimization = "DATE_CORRELATION_OPTIMIZATION";

		// Token: 0x0400032A RID: 810
		internal const string DateFirst = "DATEFIRST";

		// Token: 0x0400032B RID: 811
		internal const string DateFormat = "DATEFORMAT";

		// Token: 0x0400032C RID: 812
		internal const string DateTime = "DATETIME";

		// Token: 0x0400032D RID: 813
		internal const string DateTime2 = "DATETIME2";

		// Token: 0x0400032E RID: 814
		internal const string DateTimeOffset = "DATETIMEOFFSET";

		// Token: 0x0400032F RID: 815
		internal const string DatabaseSnapshot = "DATABASE_SNAPSHOT";

		// Token: 0x04000330 RID: 816
		internal const string DataPurity = "DATA_PURITY";

		// Token: 0x04000331 RID: 817
		internal const string DboOnly = "DBO_ONLY";

		// Token: 0x04000332 RID: 818
		internal const string DbChaining = "DB_CHAINING";

		// Token: 0x04000333 RID: 819
		internal const string DeadlockPriority = "DEADLOCK_PRIORITY";

		// Token: 0x04000334 RID: 820
		internal const string Decimal = "DECIMAL";

		// Token: 0x04000335 RID: 821
		internal const string Decryption = "DECRYPTION";

		// Token: 0x04000336 RID: 822
		internal const string Default = "DEFAULT";

		// Token: 0x04000337 RID: 823
		internal const string DefaultDatabase = "DEFAULT_DATABASE";

		// Token: 0x04000338 RID: 824
		internal const string DefaultFullTextLanguage = "DEFAULT_FULLTEXT_LANGUAGE";

		// Token: 0x04000339 RID: 825
		internal const string DefaultLanguage = "DEFAULT_LANGUAGE";

		// Token: 0x0400033A RID: 826
		internal const string DefaultSchema = "DEFAULT_SCHEMA";

		// Token: 0x0400033B RID: 827
		internal const string DefaultLogonDomain = "DEFAULT_LOGON_DOMAIN";

		// Token: 0x0400033C RID: 828
		internal const string DensityVector = "DENSITY_VECTOR";

		// Token: 0x0400033D RID: 829
		internal const string Dependents = "DEPENDENTS";

		// Token: 0x0400033E RID: 830
		internal const string Description = "DESCRIPTION";

		// Token: 0x0400033F RID: 831
		internal const string Delay = "DELAY";

		// Token: 0x04000340 RID: 832
		internal const string DelayedDurability = "DELAYED_DURABILITY";

		// Token: 0x04000341 RID: 833
		internal const string Diagnostics = "DIAGNOSTICS";

		// Token: 0x04000342 RID: 834
		internal const string Dialog = "DIALOG";

		// Token: 0x04000343 RID: 835
		internal const string Differential = "DIFFERENTIAL";

		// Token: 0x04000344 RID: 836
		internal const string Digest = "DIGEST";

		// Token: 0x04000345 RID: 837
		internal const string DirectoryName = "DIRECTORY_NAME";

		// Token: 0x04000346 RID: 838
		internal const string Disable = "DISABLE";

		// Token: 0x04000347 RID: 839
		internal const string Disabled = "DISABLED";

		// Token: 0x04000348 RID: 840
		internal const string DisableBroker = "DISABLE_BROKER";

		// Token: 0x04000349 RID: 841
		internal const string DisableDefCnstChk = "DISABLE_DEF_CNST_CHK";

		// Token: 0x0400034A RID: 842
		internal const string Disk = "DISK";

		// Token: 0x0400034B RID: 843
		internal const string Document = "DOCUMENT";

		// Token: 0x0400034C RID: 844
		internal const string DollarSign = "$";

		// Token: 0x0400034D RID: 845
		internal const string DollarPartition = "$PARTITION";

		// Token: 0x0400034E RID: 846
		internal const string Drop = "DROP";

		// Token: 0x0400034F RID: 847
		internal const string DropExisting = "DROP_EXISTING";

		// Token: 0x04000350 RID: 848
		internal const string DTSBuffers = "DTS_BUFFERS";

		// Token: 0x04000351 RID: 849
		internal const string Durability = "DURABILITY";

		// Token: 0x04000352 RID: 850
		internal const string Dynamic = "DYNAMIC";

		// Token: 0x04000353 RID: 851
		internal const string Edition = "EDITION";

		// Token: 0x04000354 RID: 852
		internal const string Elements = "ELEMENTS";

		// Token: 0x04000355 RID: 853
		internal const string Emergency = "EMERGENCY";

		// Token: 0x04000356 RID: 854
		internal const string Empty = "EMPTY";

		// Token: 0x04000357 RID: 855
		internal const string Enable = "ENABLE";

		// Token: 0x04000358 RID: 856
		internal const string Enabled = "ENABLED";

		// Token: 0x04000359 RID: 857
		internal const string EnableBroker = "ENABLE_BROKER";

		// Token: 0x0400035A RID: 858
		internal const string Encryption = "ENCRYPTION";

		// Token: 0x0400035B RID: 859
		internal const string EnhancedIntegrity = "ENHANCEDINTEGRITY";

		// Token: 0x0400035C RID: 860
		internal const string Endpoint = "ENDPOINT";

		// Token: 0x0400035D RID: 861
		internal const string EndpointUrl = "ENDPOINT_URL";

		// Token: 0x0400035E RID: 862
		internal const string Entry = "ENTRY";

		// Token: 0x0400035F RID: 863
		internal const string Equal = "=";

		// Token: 0x04000360 RID: 864
		internal const string Error = "ERROR";

		// Token: 0x04000361 RID: 865
		internal const string ErrorBrokerConversations = "ERROR_BROKER_CONVERSATIONS";

		// Token: 0x04000362 RID: 866
		internal const string ErrorFile = "ERRORFILE";

		// Token: 0x04000363 RID: 867
		internal const string EstimateOnly = "ESTIMATEONLY";

		// Token: 0x04000364 RID: 868
		internal const string Event = "EVENT";

		// Token: 0x04000365 RID: 869
		internal const string EventRetentionMode = "EVENT_RETENTION_MODE";

		// Token: 0x04000366 RID: 870
		internal const string Exclamation = "!";

		// Token: 0x04000367 RID: 871
		internal const string Executable = "EXECUTABLE";

		// Token: 0x04000368 RID: 872
		internal const string Explicit = "EXPLICIT";

		// Token: 0x04000369 RID: 873
		internal const string Expand = "EXPAND";

		// Token: 0x0400036A RID: 874
		internal const string ExpireDate = "EXPIREDATE";

		// Token: 0x0400036B RID: 875
		internal const string ExpiryDate = "EXPIRY_DATE";

		// Token: 0x0400036C RID: 876
		internal const string ExtendedLogicalChecks = "EXTENDED_LOGICAL_CHECKS";

		// Token: 0x0400036D RID: 877
		internal const string Extension = "EXTENSION";

		// Token: 0x0400036E RID: 878
		internal const string External = "EXTERNAL";

		// Token: 0x0400036F RID: 879
		internal const string ExternalAccess = "EXTERNAL_ACCESS";

		// Token: 0x04000370 RID: 880
		internal const string Extract = "EXTRACT";

		// Token: 0x04000371 RID: 881
		internal const string FailOperation = "FAIL_OPERATION";

		// Token: 0x04000372 RID: 882
		internal const string Failover = "FAILOVER";

		// Token: 0x04000373 RID: 883
		internal const string FailoverMode = "FAILOVER_MODE";

		// Token: 0x04000374 RID: 884
		internal const string FailureConditionLevel = "FailureConditionLevel";

		// Token: 0x04000375 RID: 885
		internal const string FanIn = "FAN_IN";

		// Token: 0x04000376 RID: 886
		internal const string Fast = "FAST";

		// Token: 0x04000377 RID: 887
		internal const string FastForward = "FAST_FORWARD";

		// Token: 0x04000378 RID: 888
		internal const string FastFirstRow = "FASTFIRSTROW";

		// Token: 0x04000379 RID: 889
		internal const string Federated = "FEDERATED";

		// Token: 0x0400037A RID: 890
		internal const string Federation = "FEDERATION";

		// Token: 0x0400037B RID: 891
		internal const string File = "FILE";

		// Token: 0x0400037C RID: 892
		internal const string Filegroup = "FILEGROUP";

		// Token: 0x0400037D RID: 893
		internal const string FileGrowth = "FILEGROWTH";

		// Token: 0x0400037E RID: 894
		internal const string FileListOnly = "FILELISTONLY";

		// Token: 0x0400037F RID: 895
		internal const string FileName = "FILENAME";

		// Token: 0x04000380 RID: 896
		internal const string FilePath = "FILEPATH";

		// Token: 0x04000381 RID: 897
		internal const string FileStream = "FILESTREAM";

		// Token: 0x04000382 RID: 898
		internal const string FileStreamOn = "FILESTREAM_ON";

		// Token: 0x04000383 RID: 899
		internal const string FileTable = "FILETABLE";

		// Token: 0x04000384 RID: 900
		internal const string FileTableCollateFileName = "FILETABLE_COLLATE_FILENAME";

		// Token: 0x04000385 RID: 901
		internal const string FileTableDirectory = "FILETABLE_DIRECTORY";

		// Token: 0x04000386 RID: 902
		internal const string FileTableFullPathUniqueConstraintName = "FILETABLE_FULLPATH_UNIQUE_CONSTRAINT_NAME";

		// Token: 0x04000387 RID: 903
		internal const string FileTableNamespace = "FILETABLE_NAMESPACE";

		// Token: 0x04000388 RID: 904
		internal const string FileTablePrimaryKeyConstraintName = "FILETABLE_PRIMARY_KEY_CONSTRAINT_NAME";

		// Token: 0x04000389 RID: 905
		internal const string FileTableStreamIdUniqueConstraintName = "FILETABLE_STREAMID_UNIQUE_CONSTRAINT_NAME";

		// Token: 0x0400038A RID: 906
		internal const string FillFactor = "FILLFACTOR";

		// Token: 0x0400038B RID: 907
		internal const string Filtering = "FILTERING";

		// Token: 0x0400038C RID: 908
		internal const string FireTriggers = "FIRE_TRIGGERS";

		// Token: 0x0400038D RID: 909
		internal const string FirstRow = "FIRSTROW";

		// Token: 0x0400038E RID: 910
		internal const string FieldTerminator = "FIELDTERMINATOR";

		// Token: 0x0400038F RID: 911
		internal const string FipsFlagger = "FIPS_FLAGGER";

		// Token: 0x04000390 RID: 912
		internal const string First = "FIRST";

		// Token: 0x04000391 RID: 913
		internal const string Fn = "FN";

		// Token: 0x04000392 RID: 914
		internal const string Float = "FLOAT";

		// Token: 0x04000393 RID: 915
		internal const string ForceFailoverAllowDataLoss = "FORCE_FAILOVER_ALLOW_DATA_LOSS";

		// Token: 0x04000394 RID: 916
		internal const string ForceScan = "FORCESCAN";

		// Token: 0x04000395 RID: 917
		internal const string ForceSeek = "FORCESEEK";

		// Token: 0x04000396 RID: 918
		internal const string ForceServiceAllowDataLoss = "FORCE_SERVICE_ALLOW_DATA_LOSS";

		// Token: 0x04000397 RID: 919
		internal const string ForwardOnly = "FORWARD_ONLY";

		// Token: 0x04000398 RID: 920
		internal const string Force = "FORCE";

		// Token: 0x04000399 RID: 921
		internal const string Forced = "FORCED";

		// Token: 0x0400039A RID: 922
		internal const string Format = "FORMAT";

		// Token: 0x0400039B RID: 923
		internal const string FormatFile = "FORMATFILE";

		// Token: 0x0400039C RID: 924
		internal const string Full = "FULL";

		// Token: 0x0400039D RID: 925
		internal const string FullScan = "FULLSCAN";

		// Token: 0x0400039E RID: 926
		internal const string Fulltext = "FULLTEXT";

		// Token: 0x0400039F RID: 927
		internal const string General = "GENERAL";

		// Token: 0x040003A0 RID: 928
		internal const string GeographyAutoGrid = "GEOGRAPHY_AUTO_GRID";

		// Token: 0x040003A1 RID: 929
		internal const string GeographyGrid = "GEOGRAPHY_GRID";

		// Token: 0x040003A2 RID: 930
		internal const string GeometryAutoGrid = "GEOMETRY_AUTO_GRID";

		// Token: 0x040003A3 RID: 931
		internal const string GeometryGrid = "GEOMETRY_GRID";

		// Token: 0x040003A4 RID: 932
		internal const string Get = "GET";

		// Token: 0x040003A5 RID: 933
		internal const string Global = "GLOBAL";

		// Token: 0x040003A6 RID: 934
		internal const string Governor = "GOVERNOR";

		// Token: 0x040003A7 RID: 935
		internal const string Grids = "GRIDS";

		// Token: 0x040003A8 RID: 936
		internal const string Group = "GROUP";

		// Token: 0x040003A9 RID: 937
		internal const string Grouping = "GROUPING";

		// Token: 0x040003AA RID: 938
		internal const string GroupMaxRequests = "GROUP_MAX_REQUESTS";

		// Token: 0x040003AB RID: 939
		internal const string GroupMinMemoryPercent = "GROUP_MIN_MEMORY_PERCENT";

		// Token: 0x040003AC RID: 940
		internal const string Guid = "GUID";

		// Token: 0x040003AD RID: 941
		internal const string Hadr = "HADR";

		// Token: 0x040003AE RID: 942
		internal const string Hash = "HASH";

		// Token: 0x040003AF RID: 943
		internal const string Hashed = "HASHED";

		// Token: 0x040003B0 RID: 944
		internal const string HeaderLimit = "HEADER_LIMIT";

		// Token: 0x040003B1 RID: 945
		internal const string HeaderOnly = "HEADERONLY";

		// Token: 0x040003B2 RID: 946
		internal const string HealthCheckTimeout = "HealthCheckTimeout";

		// Token: 0x040003B3 RID: 947
		internal const string High = "HIGH";

		// Token: 0x040003B4 RID: 948
		internal const string Hint = "HINT";

		// Token: 0x040003B5 RID: 949
		internal const string Histogram = "HISTOGRAM";

		// Token: 0x040003B6 RID: 950
		internal const string HistogramSteps = "HISTOGRAM_STEPS";

		// Token: 0x040003B7 RID: 951
		internal const string HonorBrokerPriority = "HONOR_BROKER_PRIORITY";

		// Token: 0x040003B8 RID: 952
		internal const string Identity = "IDENTITY";

		// Token: 0x040003B9 RID: 953
		internal const string IdentityValue = "IDENTITY_VALUE";

		// Token: 0x040003BA RID: 954
		internal const string IgnoreConstraints = "IGNORE_CONSTRAINTS";

		// Token: 0x040003BB RID: 955
		internal const string IgnoreDupKey = "IGNORE_DUP_KEY";

		// Token: 0x040003BC RID: 956
		internal const string IgnoreNonClusteredColumnStoreIndex = "IGNORE_NONCLUSTERED_COLUMNSTORE_INDEX";

		// Token: 0x040003BD RID: 957
		internal const string IgnoreTriggers = "IGNORE_TRIGGERS";

		// Token: 0x040003BE RID: 958
		internal const string IIf = "IIF";

		// Token: 0x040003BF RID: 959
		internal const string Image = "IMAGE";

		// Token: 0x040003C0 RID: 960
		internal const string Immediate = "IMMEDIATE";

		// Token: 0x040003C1 RID: 961
		internal const string Importance = "IMPORTANCE";

		// Token: 0x040003C2 RID: 962
		internal const string Include = "INCLUDE";

		// Token: 0x040003C3 RID: 963
		internal const string Increment = "INCREMENT";

		// Token: 0x040003C4 RID: 964
		internal const string Incremental = "INCREMENTAL";

		// Token: 0x040003C5 RID: 965
		internal const string Infinite = "INFINITE";

		// Token: 0x040003C6 RID: 966
		internal const string Init = "INIT";

		// Token: 0x040003C7 RID: 967
		internal const string Initiator = "INITIATOR";

		// Token: 0x040003C8 RID: 968
		internal const string Input = "INPUT";

		// Token: 0x040003C9 RID: 969
		internal const string Instead = "INSTEAD";

		// Token: 0x040003CA RID: 970
		internal const string Int = "INT";

		// Token: 0x040003CB RID: 971
		internal const string Integrated = "INTEGRATED";

		// Token: 0x040003CC RID: 972
		internal const string Intermediate = "INTERMEDIATE";

		// Token: 0x040003CD RID: 973
		internal const string Insensitive = "INSENSITIVE";

		// Token: 0x040003CE RID: 974
		internal const string IRowset = "IROWSET";

		// Token: 0x040003CF RID: 975
		internal const string Isolation = "ISOLATION";

		// Token: 0x040003D0 RID: 976
		internal const string Job = "JOB";

		// Token: 0x040003D1 RID: 977
		internal const string Keep = "KEEP";

		// Token: 0x040003D2 RID: 978
		internal const string KeepDefaults = "KEEPDEFAULTS";

		// Token: 0x040003D3 RID: 979
		internal const string KeepFixed = "KEEPFIXED";

		// Token: 0x040003D4 RID: 980
		internal const string KeepIdentity = "KEEPIDENTITY";

		// Token: 0x040003D5 RID: 981
		internal const string KeepNulls = "KEEPNULLS";

		// Token: 0x040003D6 RID: 982
		internal const string KeepReplication = "KEEP_REPLICATION";

		// Token: 0x040003D7 RID: 983
		internal const string Kerberos = "KERBEROS";

		// Token: 0x040003D8 RID: 984
		internal const string Key = "KEY";

		// Token: 0x040003D9 RID: 985
		internal const string Keys = "KEYS";

		// Token: 0x040003DA RID: 986
		internal const string Keyset = "KEYSET";

		// Token: 0x040003DB RID: 987
		internal const string KeySource = "KEY_SOURCE";

		// Token: 0x040003DC RID: 988
		internal const string KilobytesPerBatch = "KILOBYTES_PER_BATCH";

		// Token: 0x040003DD RID: 989
		internal const string LabelOnly = "LABELONLY";

		// Token: 0x040003DE RID: 990
		internal const string Language = "LANGUAGE";

		// Token: 0x040003DF RID: 991
		internal const string Last = "LAST";

		// Token: 0x040003E0 RID: 992
		internal const string LastRow = "LASTROW";

		// Token: 0x040003E1 RID: 993
		internal const string Level = "LEVEL";

		// Token: 0x040003E2 RID: 994
		internal const string Level1 = "LEVEL_1";

		// Token: 0x040003E3 RID: 995
		internal const string Level2 = "LEVEL_2";

		// Token: 0x040003E4 RID: 996
		internal const string Level3 = "LEVEL_3";

		// Token: 0x040003E5 RID: 997
		internal const string Level4 = "LEVEL_4";

		// Token: 0x040003E6 RID: 998
		internal const string LifeTime = "LIFETIME";

		// Token: 0x040003E7 RID: 999
		internal const string List = "LIST";

		// Token: 0x040003E8 RID: 1000
		internal const string ListenerIP = "LISTENER_IP";

		// Token: 0x040003E9 RID: 1001
		internal const string ListenerPort = "LISTENER_PORT";

		// Token: 0x040003EA RID: 1002
		internal const string Load = "LOAD";

		// Token: 0x040003EB RID: 1003
		internal const string LoadHistory = "LOADHISTORY";

		// Token: 0x040003EC RID: 1004
		internal const string LobCompaction = "LOB_COMPACTION";

		// Token: 0x040003ED RID: 1005
		internal const string Local = "LOCAL";

		// Token: 0x040003EE RID: 1006
		internal const string LocalServiceName = "LOCAL_SERVICE_NAME";

		// Token: 0x040003EF RID: 1007
		internal const string LockTimeout = "LOCK_TIMEOUT";

		// Token: 0x040003F0 RID: 1008
		internal const string Log = "LOG";

		// Token: 0x040003F1 RID: 1009
		internal const string Login = "LOGIN";

		// Token: 0x040003F2 RID: 1010
		internal const string LoginType = "LOGIN_TYPE";

		// Token: 0x040003F3 RID: 1011
		internal const string Logon = "LOGON";

		// Token: 0x040003F4 RID: 1012
		internal const string Loop = "LOOP";

		// Token: 0x040003F5 RID: 1013
		internal const string Low = "LOW";

		// Token: 0x040003F6 RID: 1014
		internal const string LSquareParen = "[";

		// Token: 0x040003F7 RID: 1015
		internal const string Manual = "MANUAL";

		// Token: 0x040003F8 RID: 1016
		internal const string Mark = "MARK";

		// Token: 0x040003F9 RID: 1017
		internal const string MarkInUseForRemoval = "MARK_IN_USE_FOR_REMOVAL";

		// Token: 0x040003FA RID: 1018
		internal const string Master = "MASTER";

		// Token: 0x040003FB RID: 1019
		internal const string Matched = "MATCHED";

		// Token: 0x040003FC RID: 1020
		internal const string Max = "MAX";

		// Token: 0x040003FD RID: 1021
		internal const string MaxCpuPercent = "MAX_CPU_PERCENT";

		// Token: 0x040003FE RID: 1022
		internal const string MaxDispatchLatency = "MAX_DISPATCH_LATENCY";

		// Token: 0x040003FF RID: 1023
		internal const string MaxDop = "MAXDOP";

		// Token: 0x04000400 RID: 1024
		internal const string Max_Dop = "MAX_DOP";

		// Token: 0x04000401 RID: 1025
		internal const string MaxDuration = "MAX_DURATION";

		// Token: 0x04000402 RID: 1026
		internal const string MaxErrors = "MAXERRORS";

		// Token: 0x04000403 RID: 1027
		internal const string MaxEventSize = "MAX_EVENT_SIZE";

		// Token: 0x04000404 RID: 1028
		internal const string MaxFiles = "MAX_FILES";

		// Token: 0x04000405 RID: 1029
		internal const string MaxLength = "MAXLENGTH";

		// Token: 0x04000406 RID: 1030
		internal const string MaxIoPercent = "MAX_IO_PERCENT";

		// Token: 0x04000407 RID: 1031
		internal const string MaxIopsPerVolume = "MAX_IOPS_PER_VOLUME";

		// Token: 0x04000408 RID: 1032
		internal const string MaxMemory = "MAX_MEMORY";

		// Token: 0x04000409 RID: 1033
		internal const string MaxMemoryPercent = "MAX_MEMORY_PERCENT";

		// Token: 0x0400040A RID: 1034
		internal const string MaxQueueReaders = "MAX_QUEUE_READERS";

		// Token: 0x0400040B RID: 1035
		internal const string MaxRecursion = "MAXRECURSION";

		// Token: 0x0400040C RID: 1036
		internal const string MaxRolloverFiles = "MAX_ROLLOVER_FILES";

		// Token: 0x0400040D RID: 1037
		internal const string MaxUnderscoreSize = "MAX_SIZE";

		// Token: 0x0400040E RID: 1038
		internal const string MaxSize = "MAXSIZE";

		// Token: 0x0400040F RID: 1039
		internal const string MaxTransferSize = "MAXTRANSFERSIZE";

		// Token: 0x04000410 RID: 1040
		internal const string MaxValue = "MAXVALUE";

		// Token: 0x04000411 RID: 1041
		internal const string MediaDescription = "MEDIADESCRIPTION";

		// Token: 0x04000412 RID: 1042
		internal const string MediaName = "MEDIANAME";

		// Token: 0x04000413 RID: 1043
		internal const string MediaPassword = "MEDIAPASSWORD";

		// Token: 0x04000414 RID: 1044
		internal const string Medium = "MEDIUM";

		// Token: 0x04000415 RID: 1045
		internal const string Member = "MEMBER";

		// Token: 0x04000416 RID: 1046
		internal const string MemoryOptimized = "MEMORY_OPTIMIZED";

		// Token: 0x04000417 RID: 1047
		internal const string MemoryOptimizedData = "MEMORY_OPTIMIZED_DATA";

		// Token: 0x04000418 RID: 1048
		internal const string MemoryOptimizedElevateToSnapshot = "MEMORY_OPTIMIZED_ELEVATE_TO_SNAPSHOT";

		// Token: 0x04000419 RID: 1049
		internal const string MemoryPartitionMode = "MEMORY_PARTITION_MODE";

		// Token: 0x0400041A RID: 1050
		internal const string Merge = "MERGE";

		// Token: 0x0400041B RID: 1051
		internal const string Message = "MESSAGE";

		// Token: 0x0400041C RID: 1052
		internal const string MessageForwarding = "MESSAGE_FORWARDING";

		// Token: 0x0400041D RID: 1053
		internal const string MessageForwardSize = "MESSAGE_FORWARD_SIZE";

		// Token: 0x0400041E RID: 1054
		internal const string Min = "MIN";

		// Token: 0x0400041F RID: 1055
		internal const string MinCpuPercent = "MIN_CPU_PERCENT";

		// Token: 0x04000420 RID: 1056
		internal const string MinIoPercent = "MIN_IO_PERCENT";

		// Token: 0x04000421 RID: 1057
		internal const string MinIopsPerVolume = "MIN_IOPS_PER_VOLUME";

		// Token: 0x04000422 RID: 1058
		internal const string MinMemoryPercent = "MIN_MEMORY_PERCENT";

		// Token: 0x04000423 RID: 1059
		internal const string MinValue = "MINVALUE";

		// Token: 0x04000424 RID: 1060
		internal const string MirrorAddress = "MIRROR_ADDRESS";

		// Token: 0x04000425 RID: 1061
		internal const string Mirror = "MIRROR";

		// Token: 0x04000426 RID: 1062
		internal const string Mixed = "MIXED";

		// Token: 0x04000427 RID: 1063
		internal const string Modify = "MODIFY";

		// Token: 0x04000428 RID: 1064
		internal const string Money = "MONEY";

		// Token: 0x04000429 RID: 1065
		internal const string Move = "MOVE";

		// Token: 0x0400042A RID: 1066
		internal const string MultiUser = "MULTI_USER";

		// Token: 0x0400042B RID: 1067
		internal const string MustChange = "MUST_CHANGE";

		// Token: 0x0400042C RID: 1068
		internal const string Name = "NAME";

		// Token: 0x0400042D RID: 1069
		internal const string Namespace = "NAMESPACE";

		// Token: 0x0400042E RID: 1070
		internal const string Native = "NATIVE";

		// Token: 0x0400042F RID: 1071
		internal const string NativeCompilation = "NATIVE_COMPILATION";

		// Token: 0x04000430 RID: 1072
		internal const string NChar = "NCHAR";

		// Token: 0x04000431 RID: 1073
		internal const string Negotiate = "NEGOTIATE";

		// Token: 0x04000432 RID: 1074
		internal const string Never = "NEVER";

		// Token: 0x04000433 RID: 1075
		internal const string NestedTriggers = "NESTED_TRIGGERS";

		// Token: 0x04000434 RID: 1076
		internal const string NewAccount = "NEW_ACCOUNT";

		// Token: 0x04000435 RID: 1077
		internal const string NewName = "NEWNAME";

		// Token: 0x04000436 RID: 1078
		internal const string NewBroker = "NEW_BROKER";

		// Token: 0x04000437 RID: 1079
		internal const string NewPassword = "NEW_PASSWORD";

		// Token: 0x04000438 RID: 1080
		internal const string Next = "NEXT";

		// Token: 0x04000439 RID: 1081
		internal const string No = "NO";

		// Token: 0x0400043A RID: 1082
		internal const string NoChecksum = "NO_CHECKSUM";

		// Token: 0x0400043B RID: 1083
		internal const string NoEventLoss = "NO_EVENT_LOSS";

		// Token: 0x0400043C RID: 1084
		internal const string NoExpand = "NOEXPAND";

		// Token: 0x0400043D RID: 1085
		internal const string NoFormat = "NOFORMAT";

		// Token: 0x0400043E RID: 1086
		internal const string NoInfoMessages = "NO_INFOMSGS";

		// Token: 0x0400043F RID: 1087
		internal const string NoInit = "NOINIT";

		// Token: 0x04000440 RID: 1088
		internal const string NoLock = "NOLOCK";

		// Token: 0x04000441 RID: 1089
		internal const string NoLog = "NO_LOG";

		// Token: 0x04000442 RID: 1090
		internal const string NoBrowsetable = "NO_BROWSETABLE";

		// Token: 0x04000443 RID: 1091
		internal const string NonTransactedAccess = "NON_TRANSACTED_ACCESS";

		// Token: 0x04000444 RID: 1092
		internal const string NoRecompute = "NORECOMPUTE";

		// Token: 0x04000445 RID: 1093
		internal const string NoRecovery = "NORECOVERY";

		// Token: 0x04000446 RID: 1094
		internal const string NoReset = "NORESET";

		// Token: 0x04000447 RID: 1095
		internal const string NoRewind = "NOREWIND";

		// Token: 0x04000448 RID: 1096
		internal const string None = "NONE";

		// Token: 0x04000449 RID: 1097
		internal const string NoSkip = "NOSKIP";

		// Token: 0x0400044A RID: 1098
		internal const string NoTriggers = "NO_TRIGGERS";

		// Token: 0x0400044B RID: 1099
		internal const string NoTruncate = "NO_TRUNCATE";

		// Token: 0x0400044C RID: 1100
		internal const string Notification = "NOTIFICATION";

		// Token: 0x0400044D RID: 1101
		internal const string NoWait = "NOWAIT";

		// Token: 0x0400044E RID: 1102
		internal const string NoUnload = "NOUNLOAD";

		// Token: 0x0400044F RID: 1103
		internal const string NoWaitAlterDb = "NO_WAIT";

		// Token: 0x04000450 RID: 1104
		internal const string NText = "NTEXT";

		// Token: 0x04000451 RID: 1105
		internal const string Ntlm = "NTLM";

		// Token: 0x04000452 RID: 1106
		internal const string NumaNode = "NUMANODE";

		// Token: 0x04000453 RID: 1107
		internal const string Numeric = "NUMERIC";

		// Token: 0x04000454 RID: 1108
		internal const string NVarChar = "NVARCHAR";

		// Token: 0x04000455 RID: 1109
		internal const string Object = "OBJECT";

		// Token: 0x04000456 RID: 1110
		internal const string Off = "OFF";

		// Token: 0x04000457 RID: 1111
		internal const string Offline = "OFFLINE";

		// Token: 0x04000458 RID: 1112
		internal const string Offset = "OFFSET";

		// Token: 0x04000459 RID: 1113
		internal const string Oj = "OJ";

		// Token: 0x0400045A RID: 1114
		internal const string OldAccount = "OLD_ACCOUNT";

		// Token: 0x0400045B RID: 1115
		internal const string OldPassword = "OLD_PASSWORD";

		// Token: 0x0400045C RID: 1116
		internal const string OnFailure = "ON_FAILURE";

		// Token: 0x0400045D RID: 1117
		internal const string Online = "ONLINE";

		// Token: 0x0400045E RID: 1118
		internal const string Only = "ONLY";

		// Token: 0x0400045F RID: 1119
		internal const string OpenExisting = "OPEN_EXISTING";

		// Token: 0x04000460 RID: 1120
		internal const string Optimistic = "OPTIMISTIC";

		// Token: 0x04000461 RID: 1121
		internal const string Optimize = "OPTIMIZE";

		// Token: 0x04000462 RID: 1122
		internal const string OptimizerQueue = "OPTIMIZER_QUEUE";

		// Token: 0x04000463 RID: 1123
		internal const string Out = "OUT";

		// Token: 0x04000464 RID: 1124
		internal const string Output = "OUTPUT";

		// Token: 0x04000465 RID: 1125
		internal const string Override = "OVERRIDE";

		// Token: 0x04000466 RID: 1126
		internal const string Owner = "OWNER";

		// Token: 0x04000467 RID: 1127
		internal const string PadIndex = "PAD_INDEX";

		// Token: 0x04000468 RID: 1128
		internal const string Page = "PAGE";

		// Token: 0x04000469 RID: 1129
		internal const string PageCount = "PAGECOUNT";

		// Token: 0x0400046A RID: 1130
		internal const string PageVerify = "PAGE_VERIFY";

		// Token: 0x0400046B RID: 1131
		internal const string PagLock = "PAGLOCK";

		// Token: 0x0400046C RID: 1132
		internal const string Param = "PARAM";

		// Token: 0x0400046D RID: 1133
		internal const string Parameter = "PARAMETER";

		// Token: 0x0400046E RID: 1134
		internal const string Parameterization = "PARAMETERIZATION";

		// Token: 0x0400046F RID: 1135
		internal const string Parse = "PARSE";

		// Token: 0x04000470 RID: 1136
		internal const string Partition = "PARTITION";

		// Token: 0x04000471 RID: 1137
		internal const string Partitions = "PARTITIONS";

		// Token: 0x04000472 RID: 1138
		internal const string Partner = "PARTNER";

		// Token: 0x04000473 RID: 1139
		internal const string Password = "PASSWORD";

		// Token: 0x04000474 RID: 1140
		internal const string Path = "PATH";

		// Token: 0x04000475 RID: 1141
		internal const string Partial = "PARTIAL";

		// Token: 0x04000476 RID: 1142
		internal const string Pause = "PAUSE";

		// Token: 0x04000477 RID: 1143
		internal const string PerCpu = "PER_CPU";

		// Token: 0x04000478 RID: 1144
		internal const string PermissionSet = "PERMISSION_SET";

		// Token: 0x04000479 RID: 1145
		internal const string PerNode = "PER_NODE";

		// Token: 0x0400047A RID: 1146
		internal const string Persisted = "PERSISTED";

		// Token: 0x0400047B RID: 1147
		internal const string PhysicalOnly = "PHYSICAL_ONLY";

		// Token: 0x0400047C RID: 1148
		internal const string PhysName = "PHYSNAME";

		// Token: 0x0400047D RID: 1149
		internal const string Pivot = "PIVOT";

		// Token: 0x0400047E RID: 1150
		internal const string PoisonMessageHandling = "POISON_MESSAGE_HANDLING";

		// Token: 0x0400047F RID: 1151
		internal const string Pool = "POOL";

		// Token: 0x04000480 RID: 1152
		internal const string Population = "POPULATION";

		// Token: 0x04000481 RID: 1153
		internal const string Ports = "PORTS";

		// Token: 0x04000482 RID: 1154
		internal const string Precision = "PRECISION";

		// Token: 0x04000483 RID: 1155
		internal const string PrimaryRole = "PRIMARY_ROLE";

		// Token: 0x04000484 RID: 1156
		internal const string Prior = "PRIOR";

		// Token: 0x04000485 RID: 1157
		internal const string Priority = "PRIORITY";

		// Token: 0x04000486 RID: 1158
		internal const string PriorityLevel = "PRIORITY_LEVEL";

		// Token: 0x04000487 RID: 1159
		internal const string Private = "PRIVATE";

		// Token: 0x04000488 RID: 1160
		internal const string Privileges = "PRIVILEGES";

		// Token: 0x04000489 RID: 1161
		internal const string Process = "PROCESS";

		// Token: 0x0400048A RID: 1162
		internal const string PropertySetGuid = "PROPERTY_SET_GUID";

		// Token: 0x0400048B RID: 1163
		internal const string PropertyIntId = "PROPERTY_INT_ID";

		// Token: 0x0400048C RID: 1164
		internal const string PropertyDescription = "PROPERTY_DESCRIPTION";

		// Token: 0x0400048D RID: 1165
		internal const string Provider = "PROVIDER";

		// Token: 0x0400048E RID: 1166
		internal const string ProviderKeyName = "PROVIDER_KEY_NAME";

		// Token: 0x0400048F RID: 1167
		internal const string Procedure = "PROCEDURE";

		// Token: 0x04000490 RID: 1168
		internal const string ProcedureName = "PROCEDURE_NAME";

		// Token: 0x04000491 RID: 1169
		internal const string Property = "PROPERTY";

		// Token: 0x04000492 RID: 1170
		internal const string Queue = "QUEUE";

		// Token: 0x04000493 RID: 1171
		internal const string QueueDelay = "QUEUE_DELAY";

		// Token: 0x04000494 RID: 1172
		internal const string Query = "QUERY";

		// Token: 0x04000495 RID: 1173
		internal const string QueryGovernorCostLimit = "QUERY_GOVERNOR_COST_LIMIT";

		// Token: 0x04000496 RID: 1174
		internal const string QueryTraceOn = "QUERYTRACEON";

		// Token: 0x04000497 RID: 1175
		internal const string Range = "RANGE";

		// Token: 0x04000498 RID: 1176
		internal const string Raw = "RAW";

		// Token: 0x04000499 RID: 1177
		internal const string ReadCommitted = "READCOMMITTED";

		// Token: 0x0400049A RID: 1178
		internal const string ReadCommittedLock = "READCOMMITTEDLOCK";

		// Token: 0x0400049B RID: 1179
		internal const string ReadCommittedSnapshot = "READ_COMMITTED_SNAPSHOT";

		// Token: 0x0400049C RID: 1180
		internal const string Read = "READ";

		// Token: 0x0400049D RID: 1181
		internal const string ReadPast = "READPAST";

		// Token: 0x0400049E RID: 1182
		internal const string ReadOnlyOld = "READONLY";

		// Token: 0x0400049F RID: 1183
		internal const string ReadOnly = "READ_ONLY";

		// Token: 0x040004A0 RID: 1184
		internal const string ReadUncommitted = "READUNCOMMITTED";

		// Token: 0x040004A1 RID: 1185
		internal const string ReadWrite = "READ_WRITE";

		// Token: 0x040004A2 RID: 1186
		internal const string ReadWriteFilegroups = "READ_WRITE_FILEGROUPS";

		// Token: 0x040004A3 RID: 1187
		internal const string ReadWriteOld = "READWRITE";

		// Token: 0x040004A4 RID: 1188
		internal const string Real = "REAL";

		// Token: 0x040004A5 RID: 1189
		internal const string Rebuild = "REBUILD";

		// Token: 0x040004A6 RID: 1190
		internal const string Receive = "RECEIVE";

		// Token: 0x040004A7 RID: 1191
		internal const string Recompile = "RECOMPILE";

		// Token: 0x040004A8 RID: 1192
		internal const string RecursiveTriggers = "RECURSIVE_TRIGGERS";

		// Token: 0x040004A9 RID: 1193
		internal const string Recovery = "RECOVERY";

		// Token: 0x040004AA RID: 1194
		internal const string Regenerate = "REGENERATE";

		// Token: 0x040004AB RID: 1195
		internal const string RelatedConversation = "RELATED_CONVERSATION";

		// Token: 0x040004AC RID: 1196
		internal const string RelatedConversationGroup = "RELATED_CONVERSATION_GROUP";

		// Token: 0x040004AD RID: 1197
		internal const string Relative = "RELATIVE";

		// Token: 0x040004AE RID: 1198
		internal const string Remote = "REMOTE";

		// Token: 0x040004AF RID: 1199
		internal const string RemoteServiceName = "REMOTE_SERVICE_NAME";

		// Token: 0x040004B0 RID: 1200
		internal const string Remove = "REMOVE";

		// Token: 0x040004B1 RID: 1201
		internal const string Reorganize = "REORGANIZE";

		// Token: 0x040004B2 RID: 1202
		internal const string Repeatable = "REPEATABLE";

		// Token: 0x040004B3 RID: 1203
		internal const string RepeatableRead = "REPEATABLEREAD";

		// Token: 0x040004B4 RID: 1204
		internal const string Replace = "REPLACE";

		// Token: 0x040004B5 RID: 1205
		internal const string Replica = "REPLICA";

		// Token: 0x040004B6 RID: 1206
		internal const string Required = "REQUIRED";

		// Token: 0x040004B7 RID: 1207
		internal const string ReserveDiskSpace = "RESERVE_DISK_SPACE";

		// Token: 0x040004B8 RID: 1208
		internal const string Reset = "RESET";

		// Token: 0x040004B9 RID: 1209
		internal const string Resize = "RESIZE";

		// Token: 0x040004BA RID: 1210
		internal const string Resource = "RESOURCE";

		// Token: 0x040004BB RID: 1211
		internal const string RestrictedUser = "RESTRICTED_USER";

		// Token: 0x040004BC RID: 1212
		internal const string Resume = "RESUME";

		// Token: 0x040004BD RID: 1213
		internal const string Result = "RESULT";

		// Token: 0x040004BE RID: 1214
		internal const string RetainDays = "RETAINDAYS";

		// Token: 0x040004BF RID: 1215
		internal const string Retention = "RETENTION";

		// Token: 0x040004C0 RID: 1216
		internal const string Returns = "RETURNS";

		// Token: 0x040004C1 RID: 1217
		internal const string RequestMaxCpuTimeSec = "REQUEST_MAX_CPU_TIME_SEC";

		// Token: 0x040004C2 RID: 1218
		internal const string RequestMaxMemoryGrantPercent = "REQUEST_MAX_MEMORY_GRANT_PERCENT";

		// Token: 0x040004C3 RID: 1219
		internal const string RequestMemoryGrantTimeoutSec = "REQUEST_MEMORY_GRANT_TIMEOUT_SEC";

		// Token: 0x040004C4 RID: 1220
		internal const string RequiredCopiesToCommit = "REQUIRED_COPIES_TO_COMMIT";

		// Token: 0x040004C5 RID: 1221
		internal const string Resample = "RESAMPLE";

		// Token: 0x040004C6 RID: 1222
		internal const string Revert = "REVERT";

		// Token: 0x040004C7 RID: 1223
		internal const string Restart = "RESTART";

		// Token: 0x040004C8 RID: 1224
		internal const string Rewind = "REWIND";

		// Token: 0x040004C9 RID: 1225
		internal const string RewindOnly = "REWINDONLY";

		// Token: 0x040004CA RID: 1226
		internal const string Robust = "ROBUST";

		// Token: 0x040004CB RID: 1227
		internal const string Role = "ROLE";

		// Token: 0x040004CC RID: 1228
		internal const string Rollup = "ROLLUP";

		// Token: 0x040004CD RID: 1229
		internal const string Root = "ROOT";

		// Token: 0x040004CE RID: 1230
		internal const string Route = "ROUTE";

		// Token: 0x040004CF RID: 1231
		internal const string Row = "ROW";

		// Token: 0x040004D0 RID: 1232
		internal const string Rowguid = "ROWGUID";

		// Token: 0x040004D1 RID: 1233
		internal const string RowLock = "ROWLOCK";

		// Token: 0x040004D2 RID: 1234
		internal const string Rows = "ROWS";

		// Token: 0x040004D3 RID: 1235
		internal const string RowsetsOnly = "ROWSETS_ONLY";

		// Token: 0x040004D4 RID: 1236
		internal const string RowsPerBatch = "ROWS_PER_BATCH";

		// Token: 0x040004D5 RID: 1237
		internal const string RowTerminator = "ROWTERMINATOR";

		// Token: 0x040004D6 RID: 1238
		internal const string Rowversion = "ROWVERSION";

		// Token: 0x040004D7 RID: 1239
		internal const string RSquareParen = "]";

		// Token: 0x040004D8 RID: 1240
		internal const string Rule = "RULE";

		// Token: 0x040004D9 RID: 1241
		internal const string Safe = "SAFE";

		// Token: 0x040004DA RID: 1242
		internal const string Safety = "SAFETY";

		// Token: 0x040004DB RID: 1243
		internal const string Sample = "SAMPLE";

		// Token: 0x040004DC RID: 1244
		internal const string Scheduler = "SCHEDULER";

		// Token: 0x040004DD RID: 1245
		internal const string SchemaBinding = "SCHEMABINDING";

		// Token: 0x040004DE RID: 1246
		internal const string Schema = "SCHEMA";

		// Token: 0x040004DF RID: 1247
		internal const string SchemaAndData = "SCHEMA_AND_DATA";

		// Token: 0x040004E0 RID: 1248
		internal const string SchemaOnly = "SCHEMA_ONLY";

		// Token: 0x040004E1 RID: 1249
		internal const string Scheme = "SCHEME";

		// Token: 0x040004E2 RID: 1250
		internal const string Scroll = "SCROLL";

		// Token: 0x040004E3 RID: 1251
		internal const string ScrollLocks = "SCROLL_LOCKS";

		// Token: 0x040004E4 RID: 1252
		internal const string Search = "SEARCH";

		// Token: 0x040004E5 RID: 1253
		internal const string SecondaryRole = "SECONDARY_ROLE";

		// Token: 0x040004E6 RID: 1254
		internal const string Seconds = "SECONDS";

		// Token: 0x040004E7 RID: 1255
		internal const string Secret = "SECRET";

		// Token: 0x040004E8 RID: 1256
		internal const string SecurityLog = "SECURITY_LOG";

		// Token: 0x040004E9 RID: 1257
		internal const string Selective = "SELECTIVE";

		// Token: 0x040004EA RID: 1258
		internal const string Self = "SELF";

		// Token: 0x040004EB RID: 1259
		internal const string SemiColon = ";";

		// Token: 0x040004EC RID: 1260
		internal const string Send = "SEND";

		// Token: 0x040004ED RID: 1261
		internal const string Sent = "SENT";

		// Token: 0x040004EE RID: 1262
		internal const string Sequence = "SEQUENCE";

		// Token: 0x040004EF RID: 1263
		internal const string Serializable = "SERIALIZABLE";

		// Token: 0x040004F0 RID: 1264
		internal const string Server = "SERVER";

		// Token: 0x040004F1 RID: 1265
		internal const string Service = "SERVICE";

		// Token: 0x040004F2 RID: 1266
		internal const string ServiceBroker = "SERVICE_BROKER";

		// Token: 0x040004F3 RID: 1267
		internal const string ServiceName = "SERVICE_NAME";

		// Token: 0x040004F4 RID: 1268
		internal const string Session = "SESSION";

		// Token: 0x040004F5 RID: 1269
		internal const string Sessions = "SESSIONS";

		// Token: 0x040004F6 RID: 1270
		internal const string SessionTimeout = "SESSION_TIMEOUT";

		// Token: 0x040004F7 RID: 1271
		internal const string SetError = "SETERROR";

		// Token: 0x040004F8 RID: 1272
		internal const string Sets = "SETS";

		// Token: 0x040004F9 RID: 1273
		internal const string ShrinkDb = "SHRINKDB";

		// Token: 0x040004FA RID: 1274
		internal const string Sid = "SID";

		// Token: 0x040004FB RID: 1275
		internal const string Signature = "SIGNATURE";

		// Token: 0x040004FC RID: 1276
		internal const string Simple = "SIMPLE";

		// Token: 0x040004FD RID: 1277
		internal const string SingleBlob = "SINGLE_BLOB";

		// Token: 0x040004FE RID: 1278
		internal const string SingleClob = "SINGLE_CLOB";

		// Token: 0x040004FF RID: 1279
		internal const string SingleNClob = "SINGLE_NCLOB";

		// Token: 0x04000500 RID: 1280
		internal const string SingleSpace = " ";

		// Token: 0x04000501 RID: 1281
		internal const string SingleUser = "SINGLE_USER";

		// Token: 0x04000502 RID: 1282
		internal const string Singleton = "SINGLETON";

		// Token: 0x04000503 RID: 1283
		internal const string Site = "SITE";

		// Token: 0x04000504 RID: 1284
		internal const string Size = "SIZE";

		// Token: 0x04000505 RID: 1285
		internal const string Skip = "SKIP";

		// Token: 0x04000506 RID: 1286
		internal const string Soap = "SOAP";

		// Token: 0x04000507 RID: 1287
		internal const string SortedData = "SORTED_DATA";

		// Token: 0x04000508 RID: 1288
		internal const string SortedDataReorg = "SORTED_DATA_REORG";

		// Token: 0x04000509 RID: 1289
		internal const string SortInTempDb = "SORT_IN_TEMPDB";

		// Token: 0x0400050A RID: 1290
		internal const string Source = "SOURCE";

		// Token: 0x0400050B RID: 1291
		internal const string SmallDateTime = "SMALLDATETIME";

		// Token: 0x0400050C RID: 1292
		internal const string SmallInt = "SMALLINT";

		// Token: 0x0400050D RID: 1293
		internal const string SmallMoney = "SMALLMONEY";

		// Token: 0x0400050E RID: 1294
		internal const string Snapshot = "SNAPSHOT";

		// Token: 0x0400050F RID: 1295
		internal const string SnapshotImport = "SNAPSHOT_IMPORT";

		// Token: 0x04000510 RID: 1296
		internal const string SnapshotRestorePhase = "SNAPSHOTRESTOREPHASE";

		// Token: 0x04000511 RID: 1297
		internal const string Spatial = "SPATIAL";

		// Token: 0x04000512 RID: 1298
		internal const string SpatialWindowMaxCells = "SPATIAL_WINDOW_MAX_CELLS";

		// Token: 0x04000513 RID: 1299
		internal const string Specification = "SPECIFICATION";

		// Token: 0x04000514 RID: 1300
		internal const string Split = "SPLIT";

		// Token: 0x04000515 RID: 1301
		internal const string Sql = "SQL";

		// Token: 0x04000516 RID: 1302
		internal const string SqlDumperDumpFlags = "SqlDumperDumpFlags";

		// Token: 0x04000517 RID: 1303
		internal const string SqlDumperDumpPath = "SqlDumperDumpPath";

		// Token: 0x04000518 RID: 1304
		internal const string SqlDumperDumpTimeout = "SqlDumperDumpTimeout";

		// Token: 0x04000519 RID: 1305
		internal const string Ssl = "SSL";

		// Token: 0x0400051A RID: 1306
		internal const string SslPort = "SSL_PORT";

		// Token: 0x0400051B RID: 1307
		internal const string SupplementalLogging = "SUPPLEMENTAL_LOGGING";

		// Token: 0x0400051C RID: 1308
		internal const string Standard = "STANDARD";

		// Token: 0x0400051D RID: 1309
		internal const string Standby = "STANDBY";

		// Token: 0x0400051E RID: 1310
		internal const string Start = "START";

		// Token: 0x0400051F RID: 1311
		internal const string StartDate = "START_DATE";

		// Token: 0x04000520 RID: 1312
		internal const string Started = "STARTED";

		// Token: 0x04000521 RID: 1313
		internal const string StartupState = "STARTUP_STATE";

		// Token: 0x04000522 RID: 1314
		internal const string Statement = "STATEMENT";

		// Token: 0x04000523 RID: 1315
		internal const string State = "STATE";

		// Token: 0x04000524 RID: 1316
		internal const string Static = "STATIC";

		// Token: 0x04000525 RID: 1317
		internal const string Stats = "STATS";

		// Token: 0x04000526 RID: 1318
		internal const string StatsStream = "STATS_STREAM";

		// Token: 0x04000527 RID: 1319
		internal const string Stop = "STOP";

		// Token: 0x04000528 RID: 1320
		internal const string StopAtMark = "STOPATMARK";

		// Token: 0x04000529 RID: 1321
		internal const string StopBeforeMark = "STOPBEFOREMARK";

		// Token: 0x0400052A RID: 1322
		internal const string StatHeader = "STAT_HEADER";

		// Token: 0x0400052B RID: 1323
		internal const string StatisticalSemantics = "STATISTICAL_SEMANTICS";

		// Token: 0x0400052C RID: 1324
		internal const string StatisticsIncremental = "STATISTICS_INCREMENTAL";

		// Token: 0x0400052D RID: 1325
		internal const string StatisticsNoRecompute = "STATISTICS_NORECOMPUTE";

		// Token: 0x0400052E RID: 1326
		internal const string Status = "STATUS";

		// Token: 0x0400052F RID: 1327
		internal const string StatusOnly = "STATUSONLY";

		// Token: 0x04000530 RID: 1328
		internal const string Stdev = "STDEV";

		// Token: 0x04000531 RID: 1329
		internal const string Stdevp = "STDEVP";

		// Token: 0x04000532 RID: 1330
		internal const string StopAt = "STOPAT";

		// Token: 0x04000533 RID: 1331
		internal const string StopList = "STOPLIST";

		// Token: 0x04000534 RID: 1332
		internal const string Stopped = "STOPPED";

		// Token: 0x04000535 RID: 1333
		internal const string StopOnError = "STOP_ON_ERROR";

		// Token: 0x04000536 RID: 1334
		internal const string Style = "STYLE";

		// Token: 0x04000537 RID: 1335
		internal const string Subject = "SUBJECT";

		// Token: 0x04000538 RID: 1336
		internal const string Subscription = "SUBSCRIPTION";

		// Token: 0x04000539 RID: 1337
		internal const string Sum = "SUM";

		// Token: 0x0400053A RID: 1338
		internal const string Supported = "SUPPORTED";

		// Token: 0x0400053B RID: 1339
		internal const string Suspend = "SUSPEND";

		// Token: 0x0400053C RID: 1340
		internal const string Sql_Variant = "SQL_VARIANT";

		// Token: 0x0400053D RID: 1341
		internal const string Switch = "SWITCH";

		// Token: 0x0400053E RID: 1342
		internal const string Symmetric = "SYMMETRIC";

		// Token: 0x0400053F RID: 1343
		internal const string SynchronousCommit = "SYNCHRONOUS_COMMIT";

		// Token: 0x04000540 RID: 1344
		internal const string Synonym = "SYNONYM";

		// Token: 0x04000541 RID: 1345
		internal const string Sys = "SYS";

		// Token: 0x04000542 RID: 1346
		internal const string System = "SYSTEM";

		// Token: 0x04000543 RID: 1347
		internal const string T = "T";

		// Token: 0x04000544 RID: 1348
		internal const string Tab = "\t";

		// Token: 0x04000545 RID: 1349
		internal const string TableResults = "TABLERESULTS";

		// Token: 0x04000546 RID: 1350
		internal const string TableSample = "TABLESAMPLE";

		// Token: 0x04000547 RID: 1351
		internal const string TabLock = "TABLOCK";

		// Token: 0x04000548 RID: 1352
		internal const string TabLockX = "TABLOCKX";

		// Token: 0x04000549 RID: 1353
		internal const string Tape = "TAPE";

		// Token: 0x0400054A RID: 1354
		internal const string Target = "TARGET";

		// Token: 0x0400054B RID: 1355
		internal const string TargetMemoryPercent = "TARGET_MEMORY_PERCENT";

		// Token: 0x0400054C RID: 1356
		internal const string TargetRecoveryTime = "TARGET_RECOVERY_TIME";

		// Token: 0x0400054D RID: 1357
		internal const string Text = "TEXT";

		// Token: 0x0400054E RID: 1358
		internal const string TextImageOn = "TEXTIMAGE_ON";

		// Token: 0x0400054F RID: 1359
		internal const string Throw = "THROW";

		// Token: 0x04000550 RID: 1360
		internal const string Ties = "TIES";

		// Token: 0x04000551 RID: 1361
		internal const string Time = "TIME";

		// Token: 0x04000552 RID: 1362
		internal const string Timeout = "TIMEOUT";

		// Token: 0x04000553 RID: 1363
		internal const string Timer = "TIMER";

		// Token: 0x04000554 RID: 1364
		internal const string TimeStamp = "TIMESTAMP";

		// Token: 0x04000555 RID: 1365
		internal const string TinyInt = "TINYINT";

		// Token: 0x04000556 RID: 1366
		internal const string TornPageDetection = "TORN_PAGE_DETECTION";

		// Token: 0x04000557 RID: 1367
		internal const string TrackCausality = "TRACK_CAUSALITY";

		// Token: 0x04000558 RID: 1368
		internal const string TrackColumnsUpdated = "TRACK_COLUMNS_UPDATED";

		// Token: 0x04000559 RID: 1369
		internal const string Transaction = "TRANSACTION";

		// Token: 0x0400055A RID: 1370
		internal const string TransactionIsolationLevel = "TRANSACTION ISOLATION LEVEL";

		// Token: 0x0400055B RID: 1371
		internal const string Transfer = "TRANSFER";

		// Token: 0x0400055C RID: 1372
		internal const string TransformNoiseWords = "TRANSFORM_NOISE_WORDS";

		// Token: 0x0400055D RID: 1373
		internal const string Trigger = "TRIGGER";

		// Token: 0x0400055E RID: 1374
		internal const string TruncateOnly = "TRUNCATE_ONLY";

		// Token: 0x0400055F RID: 1375
		internal const string Trustworthy = "TRUSTWORTHY";

		// Token: 0x04000560 RID: 1376
		internal const string Try = "TRY";

		// Token: 0x04000561 RID: 1377
		internal const string TryCast = "TRY_CAST";

		// Token: 0x04000562 RID: 1378
		internal const string TryParse = "TRY_PARSE";

		// Token: 0x04000563 RID: 1379
		internal const string TS = "TS";

		// Token: 0x04000564 RID: 1380
		internal const string TSql = "TSQL";

		// Token: 0x04000565 RID: 1381
		internal const string TwoDigitYearCutoff = "TWO_DIGIT_YEAR_CUTOFF";

		// Token: 0x04000566 RID: 1382
		internal const string Type = "TYPE";

		// Token: 0x04000567 RID: 1383
		internal const string TypeWarning = "TYPE_WARNING";

		// Token: 0x04000568 RID: 1384
		internal const string Unchecked = "UNCHECKED";

		// Token: 0x04000569 RID: 1385
		internal const string Uncommitted = "UNCOMMITTED";

		// Token: 0x0400056A RID: 1386
		internal const string Undefined = "UNDEFINED";

		// Token: 0x0400056B RID: 1387
		internal const string UniqueIdentifier = "UNIQUEIDENTIFIER";

		// Token: 0x0400056C RID: 1388
		internal const string Unknown = "UNKNOWN";

		// Token: 0x0400056D RID: 1389
		internal const string Unlimited = "UNLIMITED";

		// Token: 0x0400056E RID: 1390
		internal const string Unload = "UNLOAD";

		// Token: 0x0400056F RID: 1391
		internal const string Unlock = "UNLOCK";

		// Token: 0x04000570 RID: 1392
		internal const string Unsafe = "UNSAFE";

		// Token: 0x04000571 RID: 1393
		internal const string Unpivot = "UNPIVOT";

		// Token: 0x04000572 RID: 1394
		internal const string UpdLock = "UPDLOCK";

		// Token: 0x04000573 RID: 1395
		internal const string Used = "USED";

		// Token: 0x04000574 RID: 1396
		internal const string UsePlan = "USEPLAN";

		// Token: 0x04000575 RID: 1397
		internal const string User = "USER";

		// Token: 0x04000576 RID: 1398
		internal const string Using = "USING";

		// Token: 0x04000577 RID: 1399
		internal const string Validation = "VALIDATION";

		// Token: 0x04000578 RID: 1400
		internal const string ValidXml = "VALID_XML";

		// Token: 0x04000579 RID: 1401
		internal const string Value = "VALUE";

		// Token: 0x0400057A RID: 1402
		internal const string Var = "VAR";

		// Token: 0x0400057B RID: 1403
		internal const string VarBinary = "VARBINARY";

		// Token: 0x0400057C RID: 1404
		internal const string VarChar = "VARCHAR";

		// Token: 0x0400057D RID: 1405
		internal const string VardecimalStorageFormat = "VARDECIMAL_STORAGE_FORMAT";

		// Token: 0x0400057E RID: 1406
		internal const string Varp = "VARP";

		// Token: 0x0400057F RID: 1407
		internal const string VDevNo = "VDEVNO";

		// Token: 0x04000580 RID: 1408
		internal const string Verbose = "VERBOSE";

		// Token: 0x04000581 RID: 1409
		internal const string VerboseLogging = "VerboseLogging";

		// Token: 0x04000582 RID: 1410
		internal const string VerifyOnly = "VERIFYONLY";

		// Token: 0x04000583 RID: 1411
		internal const string Version = "VERSION";

		// Token: 0x04000584 RID: 1412
		internal const string Views = "VIEWS";

		// Token: 0x04000585 RID: 1413
		internal const string ViewMetadata = "VIEW_METADATA";

		// Token: 0x04000586 RID: 1414
		internal const string Visibility = "VISIBILITY";

		// Token: 0x04000587 RID: 1415
		internal const string VirtualDevice = "VIRTUAL_DEVICE";

		// Token: 0x04000588 RID: 1416
		internal const string VStart = "VSTART";

		// Token: 0x04000589 RID: 1417
		internal const string WaitAtLowPriority = "WAIT_AT_LOW_PRIORITY";

		// Token: 0x0400058A RID: 1418
		internal const string WebMethod = "WEBMETHOD";

		// Token: 0x0400058B RID: 1419
		internal const string WellFormedXml = "WELL_FORMED_XML";

		// Token: 0x0400058C RID: 1420
		internal const string WideChar = "WIDECHAR";

		// Token: 0x0400058D RID: 1421
		internal const string WideCharAnsi = "WIDECHAR_ANSI";

		// Token: 0x0400058E RID: 1422
		internal const string WideNative = "WIDENATIVE";

		// Token: 0x0400058F RID: 1423
		internal const string Windows = "WINDOWS";

		// Token: 0x04000590 RID: 1424
		internal const string Without = "WITHOUT";

		// Token: 0x04000591 RID: 1425
		internal const string Witness = "WITNESS";

		// Token: 0x04000592 RID: 1426
		internal const string Work = "WORK";

		// Token: 0x04000593 RID: 1427
		internal const string Workload = "WORKLOAD";

		// Token: 0x04000594 RID: 1428
		internal const string Wsdl = "WSDL";

		// Token: 0x04000595 RID: 1429
		internal const string XLock = "XLOCK";

		// Token: 0x04000596 RID: 1430
		internal const string XMax = "XMAX";

		// Token: 0x04000597 RID: 1431
		internal const string XMin = "XMIN";

		// Token: 0x04000598 RID: 1432
		internal const string Xml = "XML";

		// Token: 0x04000599 RID: 1433
		internal const string XmlData = "XMLDATA";

		// Token: 0x0400059A RID: 1434
		internal const string XmlNamespaces = "XMLNAMESPACES";

		// Token: 0x0400059B RID: 1435
		internal const string XmlSchema = "XMLSCHEMA";

		// Token: 0x0400059C RID: 1436
		internal const string XsiNil = "XSINIL";

		// Token: 0x0400059D RID: 1437
		internal const string XQuery = "XQUERY";

		// Token: 0x0400059E RID: 1438
		internal const string YMax = "YMAX";

		// Token: 0x0400059F RID: 1439
		internal const string YMin = "YMIN";

		// Token: 0x040005A0 RID: 1440
		internal const string Unbounded = "UNBOUNDED";

		// Token: 0x040005A1 RID: 1441
		internal const string Preceding = "PRECEDING";

		// Token: 0x040005A2 RID: 1442
		internal const string Following = "FOLLOWING";

		// Token: 0x040005A3 RID: 1443
		internal const string Within = "WITHIN";

		// Token: 0x040005A4 RID: 1444
		internal const string ActiveCursors = "ACTIVECURSORS";

		// Token: 0x040005A5 RID: 1445
		internal const string AddExtendedProc = "ADDEXTENDEDPROC";

		// Token: 0x040005A6 RID: 1446
		internal const string AddInstance = "ADDINSTANCE";

		// Token: 0x040005A7 RID: 1447
		internal const string Audit = "AUDIT";

		// Token: 0x040005A8 RID: 1448
		internal const string AuditEvent = "AUDITEVENT";

		// Token: 0x040005A9 RID: 1449
		internal const string AutoPilot = "AUTOPILOT";

		// Token: 0x040005AA RID: 1450
		internal const string Buffer = "BUFFER";

		// Token: 0x040005AB RID: 1451
		internal const string Bytes = "BYTES";

		// Token: 0x040005AC RID: 1452
		internal const string CacheProfile = "CACHEPROFILE";

		// Token: 0x040005AD RID: 1453
		internal const string CacheStats = "CACHESTATS";

		// Token: 0x040005AE RID: 1454
		internal const string CallFulltext = "CALLFULLTEXT";

		// Token: 0x040005AF RID: 1455
		internal const string CheckAlloc = "CHECKALLOC";

		// Token: 0x040005B0 RID: 1456
		internal const string CheckCatalog = "CHECKCATALOG";

		// Token: 0x040005B1 RID: 1457
		internal const string CheckDb = "CHECKDB";

		// Token: 0x040005B2 RID: 1458
		internal const string CheckFilegroup = "CHECKFILEGROUP";

		// Token: 0x040005B3 RID: 1459
		internal const string CheckIdent = "CHECKIDENT";

		// Token: 0x040005B4 RID: 1460
		internal const string CheckPrimaryFile = "CHECKPRIMARYFILE";

		// Token: 0x040005B5 RID: 1461
		internal const string CheckTable = "CHECKTABLE";

		// Token: 0x040005B6 RID: 1462
		internal const string CleanTable = "CLEANTABLE";

		// Token: 0x040005B7 RID: 1463
		internal const string ClearSpaceCaches = "CLEARSPACECACHES";

		// Token: 0x040005B8 RID: 1464
		internal const string CollectStats = "COLLECTSTATS";

		// Token: 0x040005B9 RID: 1465
		internal const string ConcurrencyViolation = "CONCURRENCYVIOLATION";

		// Token: 0x040005BA RID: 1466
		internal const string CursorStats = "CURSORSTATS";

		// Token: 0x040005BB RID: 1467
		internal const string DbRecover = "DBRECOVER";

		// Token: 0x040005BC RID: 1468
		internal const string DbReindex = "DBREINDEX";

		// Token: 0x040005BD RID: 1469
		internal const string DbReindexAll = "DBREINDEXALL";

		// Token: 0x040005BE RID: 1470
		internal const string DbRepair = "DBREPAIR";

		// Token: 0x040005BF RID: 1471
		internal const string DebugBreak = "DEBUGBREAK";

		// Token: 0x040005C0 RID: 1472
		internal const string DeleteInstance = "DELETEINSTANCE";

		// Token: 0x040005C1 RID: 1473
		internal const string DetachDb = "DETACHDB";

		// Token: 0x040005C2 RID: 1474
		internal const string DropCleanBuffers = "DROPCLEANBUFFERS";

		// Token: 0x040005C3 RID: 1475
		internal const string DropExtendedProc = "DROPEXTENDEDPROC";

		// Token: 0x040005C4 RID: 1476
		internal const string DumpConfig = "CONFIG";

		// Token: 0x040005C5 RID: 1477
		internal const string DumpDbInfo = "DBINFO";

		// Token: 0x040005C6 RID: 1478
		internal const string DumpDbTable = "DBTABLE";

		// Token: 0x040005C7 RID: 1479
		internal const string DumpLock = "LOCK";

		// Token: 0x040005C8 RID: 1480
		internal const string DumpLog = "LOG";

		// Token: 0x040005C9 RID: 1481
		internal const string DumpPage = "PAGE";

		// Token: 0x040005CA RID: 1482
		internal const string DumpResource = "RESOURCE";

		// Token: 0x040005CB RID: 1483
		internal const string DumpTrigger = "DUMPTRIGGER";

		// Token: 0x040005CC RID: 1484
		internal const string ExtentInfo = "EXTENTINFO";

		// Token: 0x040005CD RID: 1485
		internal const string FileHeader = "FILEHEADER";

		// Token: 0x040005CE RID: 1486
		internal const string FixAllocation = "FIXALLOCATION";

		// Token: 0x040005CF RID: 1487
		internal const string Flush = "FLUSH";

		// Token: 0x040005D0 RID: 1488
		internal const string FlushProcInDb = "FLUSHPROCINDB";

		// Token: 0x040005D1 RID: 1489
		internal const string ForceGhostCleanup = "FORCEGHOSTCLEANUP";

		// Token: 0x040005D2 RID: 1490
		internal const string Free = "FREE";

		// Token: 0x040005D3 RID: 1491
		internal const string FreeProcCache = "FREEPROCCACHE";

		// Token: 0x040005D4 RID: 1492
		internal const string FreeSessionCache = "FREESESSIONCACHE";

		// Token: 0x040005D5 RID: 1493
		internal const string FreeSystemCache = "FREESYSTEMCACHE";

		// Token: 0x040005D6 RID: 1494
		internal const string FreezeIo = "FREEZE_IO";

		// Token: 0x040005D7 RID: 1495
		internal const string Help = "HELP";

		// Token: 0x040005D8 RID: 1496
		internal const string IceCapQuery = "ICECAPQUERY";

		// Token: 0x040005D9 RID: 1497
		internal const string IncrementInstance = "INCREMENTINSTANCE";

		// Token: 0x040005DA RID: 1498
		internal const string Ind = "IND";

		// Token: 0x040005DB RID: 1499
		internal const string IndexDefrag = "INDEXDEFRAG";

		// Token: 0x040005DC RID: 1500
		internal const string InputBuffer = "INPUTBUFFER";

		// Token: 0x040005DD RID: 1501
		internal const string InvalidateTextptr = "INVALIDATE_TEXTPTR";

		// Token: 0x040005DE RID: 1502
		internal const string InvalidateTextptrObjid = "INVALIDATE_TEXTPTR_OBJID";

		// Token: 0x040005DF RID: 1503
		internal const string Latch = "LATCH";

		// Token: 0x040005E0 RID: 1504
		internal const string LogInfo = "LOGINFO";

		// Token: 0x040005E1 RID: 1505
		internal const string MapAllocUnit = "MAPALLOCUNIT";

		// Token: 0x040005E2 RID: 1506
		internal const string MemObjList = "MEMOBJLIST";

		// Token: 0x040005E3 RID: 1507
		internal const string MemoryMap = "MEMORYMAP";

		// Token: 0x040005E4 RID: 1508
		internal const string MemoryStatus = "MEMORYSTATUS";

		// Token: 0x040005E5 RID: 1509
		internal const string Metadata = "METADATA";

		// Token: 0x040005E6 RID: 1510
		internal const string MovePage = "MOVEPAGE";

		// Token: 0x040005E7 RID: 1511
		internal const string NoTextptr = "NO_TEXTPTR";

		// Token: 0x040005E8 RID: 1512
		internal const string OpenTran = "OPENTRAN";

		// Token: 0x040005E9 RID: 1513
		internal const string OptimizerWhatIf = "OPTIMIZER_WHATIF";

		// Token: 0x040005EA RID: 1514
		internal const string OutputBuffer = "OUTPUTBUFFER";

		// Token: 0x040005EB RID: 1515
		internal const string PerfMonStats = "PERFMON";

		// Token: 0x040005EC RID: 1516
		internal const string PersistStackHash = "PERSISTSTACKHASH";

		// Token: 0x040005ED RID: 1517
		internal const string PinTable = "PINTABLE";

		// Token: 0x040005EE RID: 1518
		internal const string ProcCache = "PROCCACHE";

		// Token: 0x040005EF RID: 1519
		internal const string PrtiPage = "PRTIPAGE";

		// Token: 0x040005F0 RID: 1520
		internal const string ReadPage = "READPAGE";

		// Token: 0x040005F1 RID: 1521
		internal const string RenameColumn = "RENAMECOLUMN";

		// Token: 0x040005F2 RID: 1522
		internal const string RuleOff = "RULEOFF";

		// Token: 0x040005F3 RID: 1523
		internal const string RuleOn = "RULEON";

		// Token: 0x040005F4 RID: 1524
		internal const string SeMetadata = "SEMETADATA";

		// Token: 0x040005F5 RID: 1525
		internal const string SetCpuWeight = "SETCPUWEIGHT";

		// Token: 0x040005F6 RID: 1526
		internal const string SetInstance = "SETINSTANCE";

		// Token: 0x040005F7 RID: 1527
		internal const string SetIoWeight = "SETIOWEIGHT";

		// Token: 0x040005F8 RID: 1528
		internal const string ShowStatistics = "SHOW_STATISTICS";

		// Token: 0x040005F9 RID: 1529
		internal const string ShowContig = "SHOWCONTIG";

		// Token: 0x040005FA RID: 1530
		internal const string ShowDbAffinity = "SHOWDBAFFINITY";

		// Token: 0x040005FB RID: 1531
		internal const string ShowFileStats = "SHOWFILESTATS";

		// Token: 0x040005FC RID: 1532
		internal const string ShowOffRules = "SHOWOFFRULES";

		// Token: 0x040005FD RID: 1533
		internal const string ShowOnRules = "SHOWONRULES";

		// Token: 0x040005FE RID: 1534
		internal const string ShowTableAffinity = "SHOWTABLEAFFINITY";

		// Token: 0x040005FF RID: 1535
		internal const string ShowText = "SHOWTEXT";

		// Token: 0x04000600 RID: 1536
		internal const string ShowWeights = "SHOWWEIGHTS";

		// Token: 0x04000601 RID: 1537
		internal const string ShrinkDatabase = "SHRINKDATABASE";

		// Token: 0x04000602 RID: 1538
		internal const string ShrinkFile = "SHRINKFILE";

		// Token: 0x04000603 RID: 1539
		internal const string Sparse = "SPARSE";

		// Token: 0x04000604 RID: 1540
		internal const string SqlMgrStats = "SQLMGRSTATS";

		// Token: 0x04000605 RID: 1541
		internal const string SqlPerf = "SQLPERF";

		// Token: 0x04000606 RID: 1542
		internal const string StackDump = "STACKDUMP";

		// Token: 0x04000607 RID: 1543
		internal const string Tec = "TEC";

		// Token: 0x04000608 RID: 1544
		internal const string ThawIo = "THAW_IO";

		// Token: 0x04000609 RID: 1545
		internal const string TraceOff = "TRACEOFF";

		// Token: 0x0400060A RID: 1546
		internal const string TraceOn = "TRACEON";

		// Token: 0x0400060B RID: 1547
		internal const string TraceStatus = "TRACESTATUS";

		// Token: 0x0400060C RID: 1548
		internal const string UnpinTable = "UNPINTABLE";

		// Token: 0x0400060D RID: 1549
		internal const string UpdateUsage = "UPDATEUSAGE";

		// Token: 0x0400060E RID: 1550
		internal const string UserOptions = "USEROPTIONS";

		// Token: 0x0400060F RID: 1551
		internal const string WritePage = "WRITEPAGE";

		// Token: 0x04000610 RID: 1552
		internal const string ChineseMacauSar = "CHINESE (MACAU SAR)";

		// Token: 0x04000611 RID: 1553
		internal const string ChineseSingapore = "CHINESE (SINGAPORE)";

		// Token: 0x04000612 RID: 1554
		internal const string SerbianCyrillic = "SERBIAN (CYRILLIC)";

		// Token: 0x04000613 RID: 1555
		internal const string Spanish = "SPANISH";

		// Token: 0x04000614 RID: 1556
		internal const string ChineseHongKong = "CHINESE (HONG KONG SAR, PRC)";

		// Token: 0x04000615 RID: 1557
		internal const string SerbianLatin = "SERBIAN (LATIN)";

		// Token: 0x04000616 RID: 1558
		internal const string Portuegese = "PORTUGUESE";

		// Token: 0x04000617 RID: 1559
		internal const string BritishEnglish = "BRITISH ENGLISH";

		// Token: 0x04000618 RID: 1560
		internal const string SimplifiedChinese = "SIMPLIFIED CHINESE";

		// Token: 0x04000619 RID: 1561
		internal const string Marathi = "MARATHI";

		// Token: 0x0400061A RID: 1562
		internal const string Malayalam = "MALAYALAM";

		// Token: 0x0400061B RID: 1563
		internal const string Kannada = "KANNADA";

		// Token: 0x0400061C RID: 1564
		internal const string Telugu = "TELUGU";

		// Token: 0x0400061D RID: 1565
		internal const string Tamil = "TAMIL";

		// Token: 0x0400061E RID: 1566
		internal const string Gujarati = "GUJARATI";

		// Token: 0x0400061F RID: 1567
		internal const string Punjabi = "PUNJABI";

		// Token: 0x04000620 RID: 1568
		internal const string BengaliIndia = "BENGALI (INDIA)";

		// Token: 0x04000621 RID: 1569
		internal const string MalayMalaysia = "MALAY - MALAYSIA";

		// Token: 0x04000622 RID: 1570
		internal const string Hindi = "HINDI";

		// Token: 0x04000623 RID: 1571
		internal const string Vietnamese = "VIETNAMESE";

		// Token: 0x04000624 RID: 1572
		internal const string Lithuanian = "LITHUANIAN";

		// Token: 0x04000625 RID: 1573
		internal const string Latvian = "LATVIAN";

		// Token: 0x04000626 RID: 1574
		internal const string Slovenian = "SLOVENIAN";

		// Token: 0x04000627 RID: 1575
		internal const string Ukrainian = "UKRAINIAN";

		// Token: 0x04000628 RID: 1576
		internal const string Indonesian = "INDONESIAN";

		// Token: 0x04000629 RID: 1577
		internal const string Urdu = "URDU";

		// Token: 0x0400062A RID: 1578
		internal const string Thai = "THAI";

		// Token: 0x0400062B RID: 1579
		internal const string Swedish = "SWEDISH";

		// Token: 0x0400062C RID: 1580
		internal const string Slovak = "SLOVAK";

		// Token: 0x0400062D RID: 1581
		internal const string Croatian = "CROATIAN";

		// Token: 0x0400062E RID: 1582
		internal const string Russian = "RUSSIAN";

		// Token: 0x0400062F RID: 1583
		internal const string Romanian = "ROMANIAN";

		// Token: 0x04000630 RID: 1584
		internal const string Brazilian = "BRAZILIAN";

		// Token: 0x04000631 RID: 1585
		internal const string NorwegianBokmal = "NORWEGIAN (BOKMÅL)";

		// Token: 0x04000632 RID: 1586
		internal const string Dutch = "DUTCH";

		// Token: 0x04000633 RID: 1587
		internal const string Korean = "KOREAN";

		// Token: 0x04000634 RID: 1588
		internal const string Japanese = "JAPANESE";

		// Token: 0x04000635 RID: 1589
		internal const string Italian = "ITALIAN";

		// Token: 0x04000636 RID: 1590
		internal const string Icelandic = "ICELANDIC";

		// Token: 0x04000637 RID: 1591
		internal const string Hebrew = "HEBREW";

		// Token: 0x04000638 RID: 1592
		internal const string French = "FRENCH";

		// Token: 0x04000639 RID: 1593
		internal const string English = "ENGLISH";

		// Token: 0x0400063A RID: 1594
		internal const string German = "GERMAN";

		// Token: 0x0400063B RID: 1595
		internal const string TraditionalChinese = "TRADITIONAL CHINESE";

		// Token: 0x0400063C RID: 1596
		internal const string Catalan = "CATALAN";

		// Token: 0x0400063D RID: 1597
		internal const string Bulgarian = "BULGARIAN";

		// Token: 0x0400063E RID: 1598
		internal const string Arabic = "ARABIC";

		// Token: 0x0400063F RID: 1599
		internal const string Neutral = "NEUTRAL";

		// Token: 0x04000640 RID: 1600
		internal const string AddSignature = "ADD_SIGNATURE";

		// Token: 0x04000641 RID: 1601
		internal const string AddSignatureSchemaObject = "ADD_SIGNATURE_SCHEMA_OBJECT";

		// Token: 0x04000642 RID: 1602
		internal const string AlterAsymmetricKey = "ALTER_ASYMMETRIC_KEY";

		// Token: 0x04000643 RID: 1603
		internal const string AlterBrokerPriority = "ALTER_BROKER_PRIORITY";

		// Token: 0x04000644 RID: 1604
		internal const string AlterDatabaseAudit = "ALTER_AUDIT";

		// Token: 0x04000645 RID: 1605
		internal const string AlterDatabaseAuditSpecification = "ALTER_DATABASE_AUDIT_SPECIFICATION";

		// Token: 0x04000646 RID: 1606
		internal const string AlterDatabaseEncryptionKey = "ALTER_DATABASE_ENCRYPTION_KEY";

		// Token: 0x04000647 RID: 1607
		internal const string AlterExtendedProperty = "ALTER_EXTENDED_PROPERTY";

		// Token: 0x04000648 RID: 1608
		internal const string AlterFullTextCatalog = "ALTER_FULLTEXT_CATALOG";

		// Token: 0x04000649 RID: 1609
		internal const string AlterFullTextIndex = "ALTER_FULLTEXT_INDEX";

		// Token: 0x0400064A RID: 1610
		internal const string AlterFullTextStopList = "ALTER_FULLTEXT_STOPLIST";

		// Token: 0x0400064B RID: 1611
		internal const string AlterMasterKey = "ALTER_MASTER_KEY";

		// Token: 0x0400064C RID: 1612
		internal const string AlterPlanGuide = "ALTER_PLAN_GUIDE";

		// Token: 0x0400064D RID: 1613
		internal const string AlterSearchPropertyList = "ALTER_SEARCH_PROPERTY_LIST";

		// Token: 0x0400064E RID: 1614
		internal const string AlterSequence = "ALTER_SEQUENCE";

		// Token: 0x0400064F RID: 1615
		internal const string AlterAvailabilityGroup = "ALTER_AVAILABILITY_GROUP";

		// Token: 0x04000650 RID: 1616
		internal const string AlterServerConfiguration = "ALTER_SERVER_CONFIGURATION";

		// Token: 0x04000651 RID: 1617
		internal const string AlterServerRole = "ALTER_SERVER_ROLE";

		// Token: 0x04000652 RID: 1618
		internal const string AlterSymmetricKey = "ALTER_SYMMETRIC_KEY";

		// Token: 0x04000653 RID: 1619
		internal const string BindDefault = "BIND_DEFAULT";

		// Token: 0x04000654 RID: 1620
		internal const string BindRule = "BIND_RULE";

		// Token: 0x04000655 RID: 1621
		internal const string CreateAsymmetricKey = "CREATE_ASYMMETRIC_KEY";

		// Token: 0x04000656 RID: 1622
		internal const string CreateBrokerPriority = "CREATE_BROKER_PRIORITY";

		// Token: 0x04000657 RID: 1623
		internal const string CreateDatabaseAudit = "CREATE_AUDIT";

		// Token: 0x04000658 RID: 1624
		internal const string CreateDatabaseAuditSpecification = "CREATE_DATABASE_AUDIT_SPECIFICATION";

		// Token: 0x04000659 RID: 1625
		internal const string CreateDatabaseEncryptionKey = "CREATE_DATABASE_ENCRYPTION_KEY";

		// Token: 0x0400065A RID: 1626
		internal const string CreateDefault = "CREATE_DEFAULT";

		// Token: 0x0400065B RID: 1627
		internal const string CreateExtendedProperty = "CREATE_EXTENDED_PROPERTY";

		// Token: 0x0400065C RID: 1628
		internal const string CreateFullTextCatalog = "CREATE_FULLTEXT_CATALOG";

		// Token: 0x0400065D RID: 1629
		internal const string CreateFullTextIndex = "CREATE_FULLTEXT_INDEX";

		// Token: 0x0400065E RID: 1630
		internal const string CreateFullTextStopList = "CREATE_FULLTEXT_STOPLIST";

		// Token: 0x0400065F RID: 1631
		internal const string CreateMasterKey = "CREATE_MASTER_KEY";

		// Token: 0x04000660 RID: 1632
		internal const string CreatePlanGuide = "CREATE_PLAN_GUIDE";

		// Token: 0x04000661 RID: 1633
		internal const string CreateRule = "CREATE_RULE";

		// Token: 0x04000662 RID: 1634
		internal const string CreateSearchPropertyList = "CREATE_SEARCH_PROPERTY_LIST";

		// Token: 0x04000663 RID: 1635
		internal const string CreateSequence = "CREATE_SEQUENCE";

		// Token: 0x04000664 RID: 1636
		internal const string CreateAvailabilityGroup = "CREATE_AVAILABILITY_GROUP";

		// Token: 0x04000665 RID: 1637
		internal const string CreateServerRole = "CREATE_SERVER_ROLE";

		// Token: 0x04000666 RID: 1638
		internal const string CreateSpatialIndex = "CREATE_SPATIAL_INDEX";

		// Token: 0x04000667 RID: 1639
		internal const string CreateSymmetricKey = "CREATE_SYMMETRIC_KEY";

		// Token: 0x04000668 RID: 1640
		internal const string DropAsymmetricKey = "DROP_ASYMMETRIC_KEY";

		// Token: 0x04000669 RID: 1641
		internal const string DropBrokerPriority = "DROP_BROKER_PRIORITY";

		// Token: 0x0400066A RID: 1642
		internal const string DropDatabaseAudit = "DROP_AUDIT";

		// Token: 0x0400066B RID: 1643
		internal const string DropDatabaseAuditSpecification = "DROP_DATABASE_AUDIT_SPECIFICATION";

		// Token: 0x0400066C RID: 1644
		internal const string DropDatabaseEncryptionKey = "DROP_DATABASE_ENCRYPTION_KEY";

		// Token: 0x0400066D RID: 1645
		internal const string DropDefault = "DROP_DEFAULT";

		// Token: 0x0400066E RID: 1646
		internal const string DropExtendedProperty = "DROP_EXTENDED_PROPERTY";

		// Token: 0x0400066F RID: 1647
		internal const string DropFullTextCatalog = "DROP_FULLTEXT_CATALOG";

		// Token: 0x04000670 RID: 1648
		internal const string DropFullTextIndex = "DROP_FULLTEXT_INDEX";

		// Token: 0x04000671 RID: 1649
		internal const string DropFullTextStopList = "DROP_FULLTEXT_STOPLIST";

		// Token: 0x04000672 RID: 1650
		internal const string DropMasterKey = "DROP_MASTER_KEY";

		// Token: 0x04000673 RID: 1651
		internal const string DropPlanGuide = "DROP_PLAN_GUIDE";

		// Token: 0x04000674 RID: 1652
		internal const string DropRule = "DROP_RULE";

		// Token: 0x04000675 RID: 1653
		internal const string DropSearchPropertyList = "DROP_SEARCH_PROPERTY_LIST";

		// Token: 0x04000676 RID: 1654
		internal const string DropSequence = "DROP_SEQUENCE";

		// Token: 0x04000677 RID: 1655
		internal const string DropAvailabilityGroup = "DROP_AVAILABILITY_GROUP";

		// Token: 0x04000678 RID: 1656
		internal const string DropServerRole = "DROP_SERVER_ROLE";

		// Token: 0x04000679 RID: 1657
		internal const string DropSignature = "DROP_SIGNATURE";

		// Token: 0x0400067A RID: 1658
		internal const string DropSignatureSchemaObject = "DROP_SIGNATURE_SCHEMA_OBJECT";

		// Token: 0x0400067B RID: 1659
		internal const string DropSymmetricKey = "DROP_SYMMETRIC_KEY";

		// Token: 0x0400067C RID: 1660
		internal const string Rename = "RENAME";

		// Token: 0x0400067D RID: 1661
		internal const string UnbindDefault = "UNBIND_DEFAULT";

		// Token: 0x0400067E RID: 1662
		internal const string UnbindRule = "UNBIND_RULE";

		// Token: 0x0400067F RID: 1663
		internal const string AlterCredential = "ALTER_CREDENTIAL";

		// Token: 0x04000680 RID: 1664
		internal const string AlterCryptographicProvider = "ALTER_CRYPTOGRAPHIC_PROVIDER";

		// Token: 0x04000681 RID: 1665
		internal const string AlterEventSession = "ALTER_EVENT_SESSION";

		// Token: 0x04000682 RID: 1666
		internal const string AlterInstance = "ALTER_INSTANCE";

		// Token: 0x04000683 RID: 1667
		internal const string AlterLinkedServer = "ALTER_LINKED_SERVER";

		// Token: 0x04000684 RID: 1668
		internal const string AlterMessage = "ALTER_MESSAGE";

		// Token: 0x04000685 RID: 1669
		internal const string AlterRemoteServer = "ALTER_REMOTE_SERVER";

		// Token: 0x04000686 RID: 1670
		internal const string AlterResourceGovernorConfig = "ALTER_RESOURCE_GOVERNOR_CONFIG";

		// Token: 0x04000687 RID: 1671
		internal const string AlterResourcePool = "ALTER_RESOURCE_POOL";

		// Token: 0x04000688 RID: 1672
		internal const string AlterServerAudit = "ALTER_SERVER_AUDIT";

		// Token: 0x04000689 RID: 1673
		internal const string AlterServerAuditSpecification = "ALTER_SERVER_AUDIT_SPECIFICATION";

		// Token: 0x0400068A RID: 1674
		internal const string AlterServiceMasterKey = "ALTER_SERVICE_MASTER_KEY";

		// Token: 0x0400068B RID: 1675
		internal const string AlterWorkloadGroup = "ALTER_WORKLOAD_GROUP";

		// Token: 0x0400068C RID: 1676
		internal const string CreateCredential = "CREATE_CREDENTIAL";

		// Token: 0x0400068D RID: 1677
		internal const string CreateCryptographicProvider = "CREATE_CRYPTOGRAPHIC_PROVIDER";

		// Token: 0x0400068E RID: 1678
		internal const string CreateEventSession = "CREATE_EVENT_SESSION";

		// Token: 0x0400068F RID: 1679
		internal const string CreateExtendedProcedure = "CREATE_EXTENDED_PROCEDURE";

		// Token: 0x04000690 RID: 1680
		internal const string CreateLinkedServer = "CREATE_LINKED_SERVER";

		// Token: 0x04000691 RID: 1681
		internal const string CreateLinkedServerLogin = "CREATE_LINKED_SERVER_LOGIN";

		// Token: 0x04000692 RID: 1682
		internal const string CreateMessage = "CREATE_MESSAGE";

		// Token: 0x04000693 RID: 1683
		internal const string CreateRemoteServer = "CREATE_REMOTE_SERVER";

		// Token: 0x04000694 RID: 1684
		internal const string CreateResourcePool = "CREATE_RESOURCE_POOL";

		// Token: 0x04000695 RID: 1685
		internal const string CreateServerAudit = "CREATE_SERVER_AUDIT";

		// Token: 0x04000696 RID: 1686
		internal const string CreateServerAuditSpecification = "CREATE_SERVER_AUDIT_SPECIFICATION";

		// Token: 0x04000697 RID: 1687
		internal const string CreateWorkloadGroup = "CREATE_WORKLOAD_GROUP";

		// Token: 0x04000698 RID: 1688
		internal const string DropCredential = "DROP_CREDENTIAL";

		// Token: 0x04000699 RID: 1689
		internal const string DropCryptographicProvider = "DROP_CRYPTOGRAPHIC_PROVIDER";

		// Token: 0x0400069A RID: 1690
		internal const string DropEventSession = "DROP_EVENT_SESSION";

		// Token: 0x0400069B RID: 1691
		internal const string DropExtendedProcedure = "DROP_EXTENDED_PROCEDURE";

		// Token: 0x0400069C RID: 1692
		internal const string DropLinkedServer = "DROP_LINKED_SERVER";

		// Token: 0x0400069D RID: 1693
		internal const string DropLinkedServerLogin = "DROP_LINKED_SERVER_LOGIN";

		// Token: 0x0400069E RID: 1694
		internal const string DropMessage = "DROP_MESSAGE";

		// Token: 0x0400069F RID: 1695
		internal const string DropRemoteServer = "DROP_REMOTE_SERVER";

		// Token: 0x040006A0 RID: 1696
		internal const string DropResourcePool = "DROP_RESOURCE_POOL";

		// Token: 0x040006A1 RID: 1697
		internal const string DropServerAudit = "DROP_SERVER_AUDIT";

		// Token: 0x040006A2 RID: 1698
		internal const string DropServerAuditSpecification = "DROP_SERVER_AUDIT_SPECIFICATION";

		// Token: 0x040006A3 RID: 1699
		internal const string DropWorkloadGroup = "DROP_WORKLOAD_GROUP";

		// Token: 0x040006A4 RID: 1700
		internal const string CreateApplicationRole = "CREATE_APPLICATION_ROLE";

		// Token: 0x040006A5 RID: 1701
		internal const string AlterApplicationRole = "ALTER_APPLICATION_ROLE";

		// Token: 0x040006A6 RID: 1702
		internal const string DropApplicationRole = "DROP_APPLICATION_ROLE";

		// Token: 0x040006A7 RID: 1703
		internal const string CreateAssembly = "CREATE_ASSEMBLY";

		// Token: 0x040006A8 RID: 1704
		internal const string AlterAssembly = "ALTER_ASSEMBLY";

		// Token: 0x040006A9 RID: 1705
		internal const string DropAssembly = "DROP_ASSEMBLY";

		// Token: 0x040006AA RID: 1706
		internal const string AlterAuthorizationDatabase = "ALTER_AUTHORIZATION_DATABASE";

		// Token: 0x040006AB RID: 1707
		internal const string CreateCertificate = "CREATE_CERTIFICATE";

		// Token: 0x040006AC RID: 1708
		internal const string AlterCertificate = "ALTER_CERTIFICATE";

		// Token: 0x040006AD RID: 1709
		internal const string DropCertificate = "DROP_CERTIFICATE";

		// Token: 0x040006AE RID: 1710
		internal const string CreateContract = "CREATE_CONTRACT";

		// Token: 0x040006AF RID: 1711
		internal const string DropContract = "DROP_CONTRACT";

		// Token: 0x040006B0 RID: 1712
		internal const string GrantDatabase = "GRANT_DATABASE";

		// Token: 0x040006B1 RID: 1713
		internal const string DenyDatabase = "DENY_DATABASE";

		// Token: 0x040006B2 RID: 1714
		internal const string RevokeDatabase = "REVOKE_DATABASE";

		// Token: 0x040006B3 RID: 1715
		internal const string CreateEventNotification = "CREATE_EVENT_NOTIFICATION";

		// Token: 0x040006B4 RID: 1716
		internal const string DropEventNotification = "DROP_EVENT_NOTIFICATION";

		// Token: 0x040006B5 RID: 1717
		internal const string CreateFunction = "CREATE_FUNCTION";

		// Token: 0x040006B6 RID: 1718
		internal const string AlterFunction = "ALTER_FUNCTION";

		// Token: 0x040006B7 RID: 1719
		internal const string DropFunction = "DROP_FUNCTION";

		// Token: 0x040006B8 RID: 1720
		internal const string CreateIndex = "CREATE_INDEX";

		// Token: 0x040006B9 RID: 1721
		internal const string AlterIndex = "ALTER_INDEX";

		// Token: 0x040006BA RID: 1722
		internal const string DropIndex = "DROP_INDEX";

		// Token: 0x040006BB RID: 1723
		internal const string CreateMessageType = "CREATE_MESSAGE_TYPE";

		// Token: 0x040006BC RID: 1724
		internal const string AlterMessageType = "ALTER_MESSAGE_TYPE";

		// Token: 0x040006BD RID: 1725
		internal const string DropMessageType = "DROP_MESSAGE_TYPE";

		// Token: 0x040006BE RID: 1726
		internal const string CreatePartitionFunction = "CREATE_PARTITION_FUNCTION";

		// Token: 0x040006BF RID: 1727
		internal const string AlterPartitionFunction = "ALTER_PARTITION_FUNCTION";

		// Token: 0x040006C0 RID: 1728
		internal const string DropPartitionFunction = "DROP_PARTITION_FUNCTION";

		// Token: 0x040006C1 RID: 1729
		internal const string CreatePartitionScheme = "CREATE_PARTITION_SCHEME";

		// Token: 0x040006C2 RID: 1730
		internal const string AlterPartitionScheme = "ALTER_PARTITION_SCHEME";

		// Token: 0x040006C3 RID: 1731
		internal const string DropPartitionScheme = "DROP_PARTITION_SCHEME";

		// Token: 0x040006C4 RID: 1732
		internal const string CreateProcedure = "CREATE_PROCEDURE";

		// Token: 0x040006C5 RID: 1733
		internal const string AlterProcedure = "ALTER_PROCEDURE";

		// Token: 0x040006C6 RID: 1734
		internal const string DropProcedure = "DROP_PROCEDURE";

		// Token: 0x040006C7 RID: 1735
		internal const string CreateQueue = "CREATE_QUEUE";

		// Token: 0x040006C8 RID: 1736
		internal const string AlterQueue = "ALTER_QUEUE";

		// Token: 0x040006C9 RID: 1737
		internal const string DropQueue = "DROP_QUEUE";

		// Token: 0x040006CA RID: 1738
		internal const string CreateRemoteServiceBinding = "CREATE_REMOTE_SERVICE_BINDING";

		// Token: 0x040006CB RID: 1739
		internal const string AlterRemoteServiceBinding = "ALTER_REMOTE_SERVICE_BINDING";

		// Token: 0x040006CC RID: 1740
		internal const string DropRemoteServiceBinding = "DROP_REMOTE_SERVICE_BINDING";

		// Token: 0x040006CD RID: 1741
		internal const string CreateRole = "CREATE_ROLE";

		// Token: 0x040006CE RID: 1742
		internal const string AlterRole = "ALTER_ROLE";

		// Token: 0x040006CF RID: 1743
		internal const string DropRole = "DROP_ROLE";

		// Token: 0x040006D0 RID: 1744
		internal const string CreateRoute = "CREATE_ROUTE";

		// Token: 0x040006D1 RID: 1745
		internal const string AlterRoute = "ALTER_ROUTE";

		// Token: 0x040006D2 RID: 1746
		internal const string DropRoute = "DROP_ROUTE";

		// Token: 0x040006D3 RID: 1747
		internal const string CreateSchema = "CREATE_SCHEMA";

		// Token: 0x040006D4 RID: 1748
		internal const string AlterSchema = "ALTER_SCHEMA";

		// Token: 0x040006D5 RID: 1749
		internal const string DropSchema = "DROP_SCHEMA";

		// Token: 0x040006D6 RID: 1750
		internal const string CreateService = "CREATE_SERVICE";

		// Token: 0x040006D7 RID: 1751
		internal const string AlterService = "ALTER_SERVICE";

		// Token: 0x040006D8 RID: 1752
		internal const string DropService = "DROP_SERVICE";

		// Token: 0x040006D9 RID: 1753
		internal const string CreateStatistics = "CREATE_STATISTICS";

		// Token: 0x040006DA RID: 1754
		internal const string DropStatistics = "DROP_STATISTICS";

		// Token: 0x040006DB RID: 1755
		internal const string UpdateStatistics = "UPDATE_STATISTICS";

		// Token: 0x040006DC RID: 1756
		internal const string CreateSynonym = "CREATE_SYNONYM";

		// Token: 0x040006DD RID: 1757
		internal const string DropSynonym = "DROP_SYNONYM";

		// Token: 0x040006DE RID: 1758
		internal const string CreateTable = "CREATE_TABLE";

		// Token: 0x040006DF RID: 1759
		internal const string AlterTable = "ALTER_TABLE";

		// Token: 0x040006E0 RID: 1760
		internal const string DropTable = "DROP_TABLE";

		// Token: 0x040006E1 RID: 1761
		internal const string CreateTrigger = "CREATE_TRIGGER";

		// Token: 0x040006E2 RID: 1762
		internal const string AlterTrigger = "ALTER_TRIGGER";

		// Token: 0x040006E3 RID: 1763
		internal const string DropTrigger = "DROP_TRIGGER";

		// Token: 0x040006E4 RID: 1764
		internal const string CreateType = "CREATE_TYPE";

		// Token: 0x040006E5 RID: 1765
		internal const string DropType = "DROP_TYPE";

		// Token: 0x040006E6 RID: 1766
		internal const string CreateUser = "CREATE_USER";

		// Token: 0x040006E7 RID: 1767
		internal const string AlterUser = "ALTER_USER";

		// Token: 0x040006E8 RID: 1768
		internal const string DropUser = "DROP_USER";

		// Token: 0x040006E9 RID: 1769
		internal const string CreateView = "CREATE_VIEW";

		// Token: 0x040006EA RID: 1770
		internal const string AlterView = "ALTER_VIEW";

		// Token: 0x040006EB RID: 1771
		internal const string DropView = "DROP_VIEW";

		// Token: 0x040006EC RID: 1772
		internal const string CreateXmlSchemaCollection = "CREATE_XML_SCHEMA_COLLECTION";

		// Token: 0x040006ED RID: 1773
		internal const string AlterXmlSchemaCollection = "ALTER_XML_SCHEMA_COLLECTION";

		// Token: 0x040006EE RID: 1774
		internal const string DropXmlSchemaCollection = "DROP_XML_SCHEMA_COLLECTION";

		// Token: 0x040006EF RID: 1775
		internal const string AlterAuthorizationServer = "ALTER_AUTHORIZATION_SERVER";

		// Token: 0x040006F0 RID: 1776
		internal const string CreateDatabase = "CREATE_DATABASE";

		// Token: 0x040006F1 RID: 1777
		internal const string AlterDatabase = "ALTER_DATABASE";

		// Token: 0x040006F2 RID: 1778
		internal const string DropDatabase = "DROP_DATABASE";

		// Token: 0x040006F3 RID: 1779
		internal const string CreateLogin = "CREATE_LOGIN";

		// Token: 0x040006F4 RID: 1780
		internal const string AlterLogin = "ALTER_LOGIN";

		// Token: 0x040006F5 RID: 1781
		internal const string CreateEndpoint = "CREATE_ENDPOINT";

		// Token: 0x040006F6 RID: 1782
		internal const string DropEndpoint = "DROP_ENDPOINT";

		// Token: 0x040006F7 RID: 1783
		internal const string DropLogin = "DROP_LOGIN";

		// Token: 0x040006F8 RID: 1784
		internal const string GrantServer = "GRANT_SERVER";

		// Token: 0x040006F9 RID: 1785
		internal const string DenyServer = "DENY_SERVER";

		// Token: 0x040006FA RID: 1786
		internal const string RevokeServer = "REVOKE_SERVER";

		// Token: 0x040006FB RID: 1787
		internal const string AddRoleMember = "ADD_ROLE_MEMBER";

		// Token: 0x040006FC RID: 1788
		internal const string AddServerRoleMember = "ADD_SERVER_ROLE_MEMBER";

		// Token: 0x040006FD RID: 1789
		internal const string DropRoleMember = "DROP_ROLE_MEMBER";

		// Token: 0x040006FE RID: 1790
		internal const string DropServerRoleMember = "DROP_SERVER_ROLE_MEMBER";

		// Token: 0x040006FF RID: 1791
		internal const string AlterEndpoint = "ALTER_ENDPOINT";

		// Token: 0x04000700 RID: 1792
		internal const string CreateXmlIndex = "CREATE_XML_INDEX";

		// Token: 0x04000701 RID: 1793
		internal const string QueueActivation = "QUEUE_ACTIVATION";

		// Token: 0x04000702 RID: 1794
		internal const string BrokerQueueDisabled = "BROKER_QUEUE_DISABLED";

		// Token: 0x04000703 RID: 1795
		internal const string AssemblyLoad = "ASSEMBLY_LOAD";

		// Token: 0x04000704 RID: 1796
		internal const string AuditAddDbUserEvent = "AUDIT_ADD_DB_USER_EVENT";

		// Token: 0x04000705 RID: 1797
		internal const string AuditAddLoginEvent = "AUDIT_ADDLOGIN_EVENT";

		// Token: 0x04000706 RID: 1798
		internal const string AuditAddLoginToServerRoleEvent = "AUDIT_ADD_LOGIN_TO_SERVER_ROLE_EVENT";

		// Token: 0x04000707 RID: 1799
		internal const string AuditAddMemberToDbRoleEvent = "AUDIT_ADD_MEMBER_TO_DB_ROLE_EVENT";

		// Token: 0x04000708 RID: 1800
		internal const string AuditAddRoleEvent = "AUDIT_ADD_ROLE_EVENT";

		// Token: 0x04000709 RID: 1801
		internal const string AuditAppRoleChangePasswordEvent = "AUDIT_APP_ROLE_CHANGE_PASSWORD_EVENT";

		// Token: 0x0400070A RID: 1802
		internal const string AuditBackupRestoreEvent = "AUDIT_BACKUP_RESTORE_EVENT";

		// Token: 0x0400070B RID: 1803
		internal const string AuditChangeAuditEvent = "AUDIT_CHANGE_AUDIT_EVENT";

		// Token: 0x0400070C RID: 1804
		internal const string AuditChangeDatabaseOwner = "AUDIT_CHANGE_DATABASE_OWNER";

		// Token: 0x0400070D RID: 1805
		internal const string AuditDatabaseManagementEvent = "AUDIT_DATABASE_MANAGEMENT_EVENT";

		// Token: 0x0400070E RID: 1806
		internal const string AuditDatabaseObjectAccessEvent = "AUDIT_DATABASE_OBJECT_ACCESS_EVENT";

		// Token: 0x0400070F RID: 1807
		internal const string AuditDatabaseObjectGdrEvent = "AUDIT_DATABASE_OBJECT_GDR_EVENT";

		// Token: 0x04000710 RID: 1808
		internal const string AuditDatabaseObjectManagementEvent = "AUDIT_DATABASE_OBJECT_MANAGEMENT_EVENT";

		// Token: 0x04000711 RID: 1809
		internal const string AuditDatabaseObjectTakeOwnershipEvent = "AUDIT_DATABASE_OBJECT_TAKE_OWNERSHIP_EVENT";

		// Token: 0x04000712 RID: 1810
		internal const string AuditDatabaseOperationEvent = "AUDIT_DATABASE_OPERATION_EVENT";

		// Token: 0x04000713 RID: 1811
		internal const string AuditDatabasePrincipalImpersonationEvent = "AUDIT_DATABASE_PRINCIPAL_IMPERSONATION_EVENT";

		// Token: 0x04000714 RID: 1812
		internal const string AuditDatabasePrincipalManagementEvent = "AUDIT_DATABASE_PRINCIPAL_MANAGEMENT_EVENT";

		// Token: 0x04000715 RID: 1813
		internal const string AuditDatabaseScopeGdrEvent = "AUDIT_DATABASE_SCOPE_GDR_EVENT";

		// Token: 0x04000716 RID: 1814
		internal const string AuditDbccEvent = "AUDIT_DBCC_EVENT";

		// Token: 0x04000717 RID: 1815
		internal const string AuditLogin = "AUDIT_LOGIN";

		// Token: 0x04000718 RID: 1816
		internal const string AuditLoginChangePasswordEvent = "AUDIT_LOGIN_CHANGE_PASSWORD_EVENT";

		// Token: 0x04000719 RID: 1817
		internal const string AuditLoginChangePropertyEvent = "AUDIT_LOGIN_CHANGE_PROPERTY_EVENT";

		// Token: 0x0400071A RID: 1818
		internal const string AuditLoginFailed = "AUDIT_LOGIN_FAILED";

		// Token: 0x0400071B RID: 1819
		internal const string AuditLoginGdrEvent = "AUDIT_LOGIN_GDR_EVENT";

		// Token: 0x0400071C RID: 1820
		internal const string AuditLogout = "AUDIT_LOGOUT";

		// Token: 0x0400071D RID: 1821
		internal const string AuditSchemaObjectAccessEvent = "AUDIT_SCHEMA_OBJECT_ACCESS_EVENT";

		// Token: 0x0400071E RID: 1822
		internal const string AuditSchemaObjectGdrEvent = "AUDIT_SCHEMA_OBJECT_GDR_EVENT";

		// Token: 0x0400071F RID: 1823
		internal const string AuditSchemaObjectManagementEvent = "AUDIT_SCHEMA_OBJECT_MANAGEMENT_EVENT";

		// Token: 0x04000720 RID: 1824
		internal const string AuditSchemaObjectTakeOwnershipEvent = "AUDIT_SCHEMA_OBJECT_TAKE_OWNERSHIP_EVENT";

		// Token: 0x04000721 RID: 1825
		internal const string AuditServerAlterTraceEvent = "AUDIT_SERVER_ALTER_TRACE_EVENT";

		// Token: 0x04000722 RID: 1826
		internal const string AuditServerObjectGdrEvent = "AUDIT_SERVER_OBJECT_GDR_EVENT";

		// Token: 0x04000723 RID: 1827
		internal const string AuditServerObjectManagementEvent = "AUDIT_SERVER_OBJECT_MANAGEMENT_EVENT";

		// Token: 0x04000724 RID: 1828
		internal const string AuditServerObjectTakeOwnershipEvent = "AUDIT_SERVER_OBJECT_TAKE_OWNERSHIP_EVENT";

		// Token: 0x04000725 RID: 1829
		internal const string AuditServerOperationEvent = "AUDIT_SERVER_OPERATION_EVENT";

		// Token: 0x04000726 RID: 1830
		internal const string AuditServerPrincipalImpersonationEvent = "AUDIT_SERVER_PRINCIPAL_IMPERSONATION_EVENT";

		// Token: 0x04000727 RID: 1831
		internal const string AuditServerPrincipalManagementEvent = "AUDIT_SERVER_PRINCIPAL_MANAGEMENT_EVENT";

		// Token: 0x04000728 RID: 1832
		internal const string AuditServerScopeGdrEvent = "AUDIT_SERVER_SCOPE_GDR_EVENT";

		// Token: 0x04000729 RID: 1833
		internal const string BlockedProcessReport = "BLOCKED_PROCESS_REPORT";

		// Token: 0x0400072A RID: 1834
		internal const string DataFileAutoGrow = "DATA_FILE_AUTO_GROW";

		// Token: 0x0400072B RID: 1835
		internal const string DataFileAutoShrink = "DATA_FILE_AUTO_SHRINK";

		// Token: 0x0400072C RID: 1836
		internal const string DatabaseMirroringStateChange = "DATABASE_MIRRORING_STATE_CHANGE";

		// Token: 0x0400072D RID: 1837
		internal const string DeadlockGraph = "DEADLOCK_GRAPH";

		// Token: 0x0400072E RID: 1838
		internal const string DeprecationAnnouncement = "DEPRECATION_ANNOUNCEMENT";

		// Token: 0x0400072F RID: 1839
		internal const string DeprecationFinalSupport = "DEPRECATION_FINAL_SUPPORT";

		// Token: 0x04000730 RID: 1840
		internal const string ErrorLog = "ERRORLOG";

		// Token: 0x04000731 RID: 1841
		internal const string EventLog = "EVENTLOG";

		// Token: 0x04000732 RID: 1842
		internal const string Exception = "EXCEPTION";

		// Token: 0x04000733 RID: 1843
		internal const string ExchangeSpillEvent = "EXCHANGE_SPILL_EVENT";

		// Token: 0x04000734 RID: 1844
		internal const string ExecutionWarnings = "EXECUTION_WARNINGS";

		// Token: 0x04000735 RID: 1845
		internal const string FtCrawlAborted = "FT_CRAWL_ABORTED";

		// Token: 0x04000736 RID: 1846
		internal const string FtCrawlStarted = "FT_CRAWL_STARTED";

		// Token: 0x04000737 RID: 1847
		internal const string FtCrawlStopped = "FT_CRAWL_STOPPED";

		// Token: 0x04000738 RID: 1848
		internal const string HashWarning = "HASH_WARNING";

		// Token: 0x04000739 RID: 1849
		internal const string LockDeadlock = "LOCK_DEADLOCK";

		// Token: 0x0400073A RID: 1850
		internal const string LockDeadlockChain = "LOCK_DEADLOCK_CHAIN";

		// Token: 0x0400073B RID: 1851
		internal const string LockEscalation = "LOCK_ESCALATION";

		// Token: 0x0400073C RID: 1852
		internal const string LogFileAutoGrow = "LOG_FILE_AUTO_GROW";

		// Token: 0x0400073D RID: 1853
		internal const string LogFileAutoShrink = "LOG_FILE_AUTO_SHRINK";

		// Token: 0x0400073E RID: 1854
		internal const string MissingColumnStatistics = "MISSING_COLUMN_STATISTICS";

		// Token: 0x0400073F RID: 1855
		internal const string MissingJoinPredicate = "MISSING_JOIN_PREDICATE";

		// Token: 0x04000740 RID: 1856
		internal const string MountTape = "MOUNT_TAPE";

		// Token: 0x04000741 RID: 1857
		internal const string ObjectAltered = "OBJECT_ALTERED";

		// Token: 0x04000742 RID: 1858
		internal const string ObjectCreated = "OBJECT_CREATED";

		// Token: 0x04000743 RID: 1859
		internal const string ObjectDeleted = "OBJECT_DELETED";

		// Token: 0x04000744 RID: 1860
		internal const string OledbCallEvent = "OLEDB_CALL_EVENT";

		// Token: 0x04000745 RID: 1861
		internal const string OledbDataReadEvent = "OLEDB_DATAREAD_EVENT";

		// Token: 0x04000746 RID: 1862
		internal const string OledbErrors = "OLEDB_ERRORS";

		// Token: 0x04000747 RID: 1863
		internal const string OledbProviderInformation = "OLEDB_PROVIDER_INFORMATION";

		// Token: 0x04000748 RID: 1864
		internal const string OledbQueryInterfaceEvent = "OLEDB_QUERYINTERFACE_EVENT";

		// Token: 0x04000749 RID: 1865
		internal const string QnDynamics = "QN__DYNAMICS";

		// Token: 0x0400074A RID: 1866
		internal const string QnParameterTable = "QN__PARAMETER_TABLE";

		// Token: 0x0400074B RID: 1867
		internal const string QnSubscription = "QN__SUBSCRIPTION";

		// Token: 0x0400074C RID: 1868
		internal const string QnTemplate = "QN__TEMPLATE";

		// Token: 0x0400074D RID: 1869
		internal const string ServerMemoryChange = "SERVER_MEMORY_CHANGE";

		// Token: 0x0400074E RID: 1870
		internal const string ShowPlanAllForQueryCompile = "SHOWPLAN_ALL_FOR_QUERY_COMPILE";

		// Token: 0x0400074F RID: 1871
		internal const string ShowPlanXmlForQueryCompile = "SHOWPLAN_XML_FOR_QUERY_COMPILE";

		// Token: 0x04000750 RID: 1872
		internal const string ShowPlanXml = "SHOWPLAN_XML";

		// Token: 0x04000751 RID: 1873
		internal const string ShowPlanXmlStatisticsProfile = "SHOWPLAN_XML_STATISTICS_PROFILE";

		// Token: 0x04000752 RID: 1874
		internal const string SortWarnings = "SORT_WARNINGS";

		// Token: 0x04000753 RID: 1875
		internal const string SpCacheInsert = "SP_CACHEINSERT";

		// Token: 0x04000754 RID: 1876
		internal const string SpCacheMiss = "SP_CACHEMISS";

		// Token: 0x04000755 RID: 1877
		internal const string SpCacheRemove = "SP_CACHEREMOVE";

		// Token: 0x04000756 RID: 1878
		internal const string SpRecompile = "SP_RECOMPILE";

		// Token: 0x04000757 RID: 1879
		internal const string SqlStmtRecompile = "SQL_STMTRECOMPILE";

		// Token: 0x04000758 RID: 1880
		internal const string TraceFileClose = "TRACE_FILE_CLOSE";

		// Token: 0x04000759 RID: 1881
		internal const string UserErrorMessage = "USER_ERROR_MESSAGE";

		// Token: 0x0400075A RID: 1882
		internal const string UserConfigurable0 = "USERCONFIGURABLE_0";

		// Token: 0x0400075B RID: 1883
		internal const string UserConfigurable1 = "USERCONFIGURABLE_1";

		// Token: 0x0400075C RID: 1884
		internal const string UserConfigurable2 = "USERCONFIGURABLE_2";

		// Token: 0x0400075D RID: 1885
		internal const string UserConfigurable3 = "USERCONFIGURABLE_3";

		// Token: 0x0400075E RID: 1886
		internal const string UserConfigurable4 = "USERCONFIGURABLE_4";

		// Token: 0x0400075F RID: 1887
		internal const string UserConfigurable5 = "USERCONFIGURABLE_5";

		// Token: 0x04000760 RID: 1888
		internal const string UserConfigurable6 = "USERCONFIGURABLE_6";

		// Token: 0x04000761 RID: 1889
		internal const string UserConfigurable7 = "USERCONFIGURABLE_7";

		// Token: 0x04000762 RID: 1890
		internal const string UserConfigurable8 = "USERCONFIGURABLE_8";

		// Token: 0x04000763 RID: 1891
		internal const string UserConfigurable9 = "USERCONFIGURABLE_9";

		// Token: 0x04000764 RID: 1892
		internal const string XQueryStaticType = "XQUERY_STATIC_TYPE";

		// Token: 0x04000765 RID: 1893
		internal const string AuditFullText = "AUDIT_FULLTEXT";

		// Token: 0x04000766 RID: 1894
		internal const string BitmapWarning = "BITMAP_WARNING";

		// Token: 0x04000767 RID: 1895
		internal const string CpuThresholdExceeded = "CPU_THRESHOLD_EXCEEDED";

		// Token: 0x04000768 RID: 1896
		internal const string DatabaseSuspectDataPage = "DATABASE_SUSPECT_DATA_PAGE";

		// Token: 0x04000769 RID: 1897
		internal const string DdlAsymmetricKeyEvents = "DDL_ASYMMETRIC_KEY_EVENTS";

		// Token: 0x0400076A RID: 1898
		internal const string DdlBrokerPriorityEvents = "DDL_BROKER_PRIORITY_EVENTS";

		// Token: 0x0400076B RID: 1899
		internal const string DdlCryptoSignatureEvents = "DDL_CRYPTO_SIGNATURE_EVENTS";

		// Token: 0x0400076C RID: 1900
		internal const string DdlDatabaseAuditSpecificationEvents = "DDL_DATABASE_AUDIT_SPECIFICATION_EVENTS";

		// Token: 0x0400076D RID: 1901
		internal const string DdlDatabaseEncryptionKeyEvents = "DDL_DATABASE_ENCRYPTION_KEY_EVENTS";

		// Token: 0x0400076E RID: 1902
		internal const string DdlDefaultEvents = "DDL_DEFAULT_EVENTS";

		// Token: 0x0400076F RID: 1903
		internal const string DdlExtendedPropertyEvents = "DDL_EXTENDED_PROPERTY_EVENTS";

		// Token: 0x04000770 RID: 1904
		internal const string DdlFullTextCatalogEvents = "DDL_FULLTEXT_CATALOG_EVENTS";

		// Token: 0x04000771 RID: 1905
		internal const string DdlFullTextStopListEvents = "DDL_FULLTEXT_STOPLIST_EVENTS";

		// Token: 0x04000772 RID: 1906
		internal const string DdlMasterKeyEvents = "DDL_MASTER_KEY_EVENTS";

		// Token: 0x04000773 RID: 1907
		internal const string DdlPlanGuideEvents = "DDL_PLAN_GUIDE_EVENTS";

		// Token: 0x04000774 RID: 1908
		internal const string DdlRuleEvents = "DDL_RULE_EVENTS";

		// Token: 0x04000775 RID: 1909
		internal const string DdlSymmetricKeyEvents = "DDL_SYMMETRIC_KEY_EVENTS";

		// Token: 0x04000776 RID: 1910
		internal const string DdlCredentialEvents = "DDL_CREDENTIAL_EVENTS";

		// Token: 0x04000777 RID: 1911
		internal const string DdlDatabaseEvents = "DDL_DATABASE_EVENTS";

		// Token: 0x04000778 RID: 1912
		internal const string DdlCryptographicProviderEvents = "DDL_CRYPTOGRAPHIC_PROVIDER_EVENTS";

		// Token: 0x04000779 RID: 1913
		internal const string DdlEventSessionEvents = "DDL_EVENT_SESSION_EVENTS";

		// Token: 0x0400077A RID: 1914
		internal const string DdlExtendedProcedureEvents = "DDL_EXTENDED_PROCEDURE_EVENTS";

		// Token: 0x0400077B RID: 1915
		internal const string DdlLinkedServerEvents = "DDL_LINKED_SERVER_EVENTS";

		// Token: 0x0400077C RID: 1916
		internal const string DdlLinkedServerLoginEvents = "DDL_LINKED_SERVER_LOGIN_EVENTS";

		// Token: 0x0400077D RID: 1917
		internal const string DdlMessageEvents = "DDL_MESSAGE_EVENTS";

		// Token: 0x0400077E RID: 1918
		internal const string DdlRemoteServerEvents = "DDL_REMOTE_SERVER_EVENTS";

		// Token: 0x0400077F RID: 1919
		internal const string DdlResourceGovernorEvents = "DDL_RESOURCE_GOVERNOR_EVENTS";

		// Token: 0x04000780 RID: 1920
		internal const string DdlResourcePool = "DDL_RESOURCE_POOL";

		// Token: 0x04000781 RID: 1921
		internal const string DdlSearchPropertyListEvents = "DDL_SEARCH_PROPERTY_LIST_EVENTS";

		// Token: 0x04000782 RID: 1922
		internal const string DdlSequenceEvents = "DDL_SEQUENCE_EVENTS";

		// Token: 0x04000783 RID: 1923
		internal const string DdlAvailabilityGroupEvents = "DDL_AVAILABILITY_GROUP_EVENTS";

		// Token: 0x04000784 RID: 1924
		internal const string DdlDatabaseAuditEvents = "DDL_DATABASE_AUDIT_EVENTS";

		// Token: 0x04000785 RID: 1925
		internal const string DdlServerAuditEvents = "DDL_SERVER_AUDIT_EVENTS";

		// Token: 0x04000786 RID: 1926
		internal const string DdlServerAuditSpecificationEvents = "DDL_SERVER_AUDIT_SPECIFICATION_EVENTS";

		// Token: 0x04000787 RID: 1927
		internal const string DdlServiceMasterKeyEvents = "DDL_SERVICE_MASTER_KEY_EVENTS";

		// Token: 0x04000788 RID: 1928
		internal const string DdlWorkloadGroup = "DDL_WORKLOAD_GROUP";

		// Token: 0x04000789 RID: 1929
		internal const string DdlEvents = "DDL_EVENTS";

		// Token: 0x0400078A RID: 1930
		internal const string DdlApplicationRoleEvents = "DDL_APPLICATION_ROLE_EVENTS";

		// Token: 0x0400078B RID: 1931
		internal const string DdlAssemblyEvents = "DDL_ASSEMBLY_EVENTS";

		// Token: 0x0400078C RID: 1932
		internal const string DdlAuthorizationDatabaseEvents = "DDL_AUTHORIZATION_DATABASE_EVENTS";

		// Token: 0x0400078D RID: 1933
		internal const string DdlAuthorizationServerEvents = "DDL_AUTHORIZATION_SERVER_EVENTS";

		// Token: 0x0400078E RID: 1934
		internal const string DdlCertificateEvents = "DDL_CERTIFICATE_EVENTS";

		// Token: 0x0400078F RID: 1935
		internal const string DdlContractEvents = "DDL_CONTRACT_EVENTS";

		// Token: 0x04000790 RID: 1936
		internal const string DdlDatabaseLevelEvents = "DDL_DATABASE_LEVEL_EVENTS";

		// Token: 0x04000791 RID: 1937
		internal const string DdlDatabaseSecurityEvents = "DDL_DATABASE_SECURITY_EVENTS";

		// Token: 0x04000792 RID: 1938
		internal const string DdlEndpointEvents = "DDL_ENDPOINT_EVENTS";

		// Token: 0x04000793 RID: 1939
		internal const string DdlEventNotificationEvents = "DDL_EVENT_NOTIFICATION_EVENTS";

		// Token: 0x04000794 RID: 1940
		internal const string DdlFunctionEvents = "DDL_FUNCTION_EVENTS";

		// Token: 0x04000795 RID: 1941
		internal const string DdlGdrDatabaseEvents = "DDL_GDR_DATABASE_EVENTS";

		// Token: 0x04000796 RID: 1942
		internal const string DdlGdrServerEvents = "DDL_GDR_SERVER_EVENTS";

		// Token: 0x04000797 RID: 1943
		internal const string DdlIndexEvents = "DDL_INDEX_EVENTS";

		// Token: 0x04000798 RID: 1944
		internal const string DdlLoginEvents = "DDL_LOGIN_EVENTS";

		// Token: 0x04000799 RID: 1945
		internal const string DdlMessageTypeEvents = "DDL_MESSAGE_TYPE_EVENTS";

		// Token: 0x0400079A RID: 1946
		internal const string DdlPartitionEvents = "DDL_PARTITION_EVENTS";

		// Token: 0x0400079B RID: 1947
		internal const string DdlPartitionFunctionEvents = "DDL_PARTITION_FUNCTION_EVENTS";

		// Token: 0x0400079C RID: 1948
		internal const string DdlPartitionSchemeEvents = "DDL_PARTITION_SCHEME_EVENTS";

		// Token: 0x0400079D RID: 1949
		internal const string DdlProcedureEvents = "DDL_PROCEDURE_EVENTS";

		// Token: 0x0400079E RID: 1950
		internal const string DdlQueueEvents = "DDL_QUEUE_EVENTS";

		// Token: 0x0400079F RID: 1951
		internal const string DdlRemoteServiceBindingEvents = "DDL_REMOTE_SERVICE_BINDING_EVENTS";

		// Token: 0x040007A0 RID: 1952
		internal const string DdlRoleEvents = "DDL_ROLE_EVENTS";

		// Token: 0x040007A1 RID: 1953
		internal const string DdlRouteEvents = "DDL_ROUTE_EVENTS";

		// Token: 0x040007A2 RID: 1954
		internal const string DdlSchemaEvents = "DDL_SCHEMA_EVENTS";

		// Token: 0x040007A3 RID: 1955
		internal const string DdlServerLevelEvents = "DDL_SERVER_LEVEL_EVENTS";

		// Token: 0x040007A4 RID: 1956
		internal const string DdlServerSecurityEvents = "DDL_SERVER_SECURITY_EVENTS";

		// Token: 0x040007A5 RID: 1957
		internal const string DdlServiceEvents = "DDL_SERVICE_EVENTS";

		// Token: 0x040007A6 RID: 1958
		internal const string DdlSsbEvents = "DDL_SSB_EVENTS";

		// Token: 0x040007A7 RID: 1959
		internal const string DdlStatisticsEvents = "DDL_STATISTICS_EVENTS";

		// Token: 0x040007A8 RID: 1960
		internal const string DdlSynonymEvents = "DDL_SYNONYM_EVENTS";

		// Token: 0x040007A9 RID: 1961
		internal const string DdlTableEvents = "DDL_TABLE_EVENTS";

		// Token: 0x040007AA RID: 1962
		internal const string DdlTableViewEvents = "DDL_TABLE_VIEW_EVENTS";

		// Token: 0x040007AB RID: 1963
		internal const string DdlTriggerEvents = "DDL_TRIGGER_EVENTS";

		// Token: 0x040007AC RID: 1964
		internal const string DdlTypeEvents = "DDL_TYPE_EVENTS";

		// Token: 0x040007AD RID: 1965
		internal const string DdlUserEvents = "DDL_USER_EVENTS";

		// Token: 0x040007AE RID: 1966
		internal const string DdlViewEvents = "DDL_VIEW_EVENTS";

		// Token: 0x040007AF RID: 1967
		internal const string DdlXmlSchemaCollectionEvents = "DDL_XML_SCHEMA_COLLECTION_EVENTS";

		// Token: 0x040007B0 RID: 1968
		internal const string TrcClr = "TRC_CLR";

		// Token: 0x040007B1 RID: 1969
		internal const string TrcDatabase = "TRC_DATABASE";

		// Token: 0x040007B2 RID: 1970
		internal const string TrcDeprecation = "TRC_DEPRECATION";

		// Token: 0x040007B3 RID: 1971
		internal const string TrcErrorsAndWarnings = "TRC_ERRORS_AND_WARNINGS";

		// Token: 0x040007B4 RID: 1972
		internal const string TrcFullText = "TRC_FULL_TEXT";

		// Token: 0x040007B5 RID: 1973
		internal const string TrcLocks = "TRC_LOCKS";

		// Token: 0x040007B6 RID: 1974
		internal const string TrcObjects = "TRC_OBJECTS";

		// Token: 0x040007B7 RID: 1975
		internal const string TrcOledb = "TRC_OLEDB";

		// Token: 0x040007B8 RID: 1976
		internal const string TrcPerformance = "TRC_PERFORMANCE";

		// Token: 0x040007B9 RID: 1977
		internal const string TrcQueryNotifications = "TRC_QUERY_NOTIFICATIONS";

		// Token: 0x040007BA RID: 1978
		internal const string TrcSecurityAudit = "TRC_SECURITY_AUDIT";

		// Token: 0x040007BB RID: 1979
		internal const string TrcServer = "TRC_SERVER";

		// Token: 0x040007BC RID: 1980
		internal const string TrcStoredProcedures = "TRC_STORED_PROCEDURES";

		// Token: 0x040007BD RID: 1981
		internal const string TrcTsql = "TRC_TSQL";

		// Token: 0x040007BE RID: 1982
		internal const string TrcUserConfigurable = "TRC_USER_CONFIGURABLE";

		// Token: 0x040007BF RID: 1983
		internal const string TrcAllEvents = "TRC_ALL_EVENTS";

		// Token: 0x040007C0 RID: 1984
		internal const string SuccessfulLoginGroup = "SUCCESSFUL_LOGIN_GROUP";

		// Token: 0x040007C1 RID: 1985
		internal const string LogoutGroup = "LOGOUT_GROUP";

		// Token: 0x040007C2 RID: 1986
		internal const string ServerStateChangeGroup = "SERVER_STATE_CHANGE_GROUP";

		// Token: 0x040007C3 RID: 1987
		internal const string FailedLoginGroup = "FAILED_LOGIN_GROUP";

		// Token: 0x040007C4 RID: 1988
		internal const string LoginChangePasswordGroup = "LOGIN_CHANGE_PASSWORD_GROUP";

		// Token: 0x040007C5 RID: 1989
		internal const string ServerRoleMemberChangeGroup = "SERVER_ROLE_MEMBER_CHANGE_GROUP";

		// Token: 0x040007C6 RID: 1990
		internal const string ServerPrincipalImpersonationGroup = "SERVER_PRINCIPAL_IMPERSONATION_GROUP";

		// Token: 0x040007C7 RID: 1991
		internal const string ServerObjectOwnershipChangeGroup = "SERVER_OBJECT_OWNERSHIP_CHANGE_GROUP";

		// Token: 0x040007C8 RID: 1992
		internal const string DatabaseMirroringLoginGroup = "DATABASE_MIRRORING_LOGIN_GROUP";

		// Token: 0x040007C9 RID: 1993
		internal const string BrokerLoginGroup = "BROKER_LOGIN_GROUP";

		// Token: 0x040007CA RID: 1994
		internal const string ServerPermissionChangeGroup = "SERVER_PERMISSION_CHANGE_GROUP";

		// Token: 0x040007CB RID: 1995
		internal const string ServerObjectPermissionChangeGroup = "SERVER_OBJECT_PERMISSION_CHANGE_GROUP";

		// Token: 0x040007CC RID: 1996
		internal const string ServerOperationGroup = "SERVER_OPERATION_GROUP";

		// Token: 0x040007CD RID: 1997
		internal const string TraceChangeGroup = "TRACE_CHANGE_GROUP";

		// Token: 0x040007CE RID: 1998
		internal const string ServerObjectChangeGroup = "SERVER_OBJECT_CHANGE_GROUP";

		// Token: 0x040007CF RID: 1999
		internal const string ServerPrincipalChangeGroup = "SERVER_PRINCIPAL_CHANGE_GROUP";

		// Token: 0x040007D0 RID: 2000
		internal const string DatabasePermissionChangeGroup = "DATABASE_PERMISSION_CHANGE_GROUP";

		// Token: 0x040007D1 RID: 2001
		internal const string SchemaObjectPermissionChangeGroup = "SCHEMA_OBJECT_PERMISSION_CHANGE_GROUP";

		// Token: 0x040007D2 RID: 2002
		internal const string DatabaseRoleMemberChangeGroup = "DATABASE_ROLE_MEMBER_CHANGE_GROUP";

		// Token: 0x040007D3 RID: 2003
		internal const string ApplicationRoleChangePasswordGroup = "APPLICATION_ROLE_CHANGE_PASSWORD_GROUP";

		// Token: 0x040007D4 RID: 2004
		internal const string SchemaObjectAccessGroup = "SCHEMA_OBJECT_ACCESS_GROUP";

		// Token: 0x040007D5 RID: 2005
		internal const string BackupRestoreGroup = "BACKUP_RESTORE_GROUP";

		// Token: 0x040007D6 RID: 2006
		internal const string DbccGroup = "DBCC_GROUP";

		// Token: 0x040007D7 RID: 2007
		internal const string AuditChangeGroup = "AUDIT_CHANGE_GROUP";

		// Token: 0x040007D8 RID: 2008
		internal const string DatabaseChangeGroup = "DATABASE_CHANGE_GROUP";

		// Token: 0x040007D9 RID: 2009
		internal const string DatabaseObjectChangeGroup = "DATABASE_OBJECT_CHANGE_GROUP";

		// Token: 0x040007DA RID: 2010
		internal const string DatabasePrincipalChangeGroup = "DATABASE_PRINCIPAL_CHANGE_GROUP";

		// Token: 0x040007DB RID: 2011
		internal const string SchemaObjectChangeGroup = "SCHEMA_OBJECT_CHANGE_GROUP";

		// Token: 0x040007DC RID: 2012
		internal const string DatabasePrincipalImpersonationGroup = "DATABASE_PRINCIPAL_IMPERSONATION_GROUP";

		// Token: 0x040007DD RID: 2013
		internal const string DatabaseObjectOwnershipChangeGroup = "DATABASE_OBJECT_OWNERSHIP_CHANGE_GROUP";

		// Token: 0x040007DE RID: 2014
		internal const string DatabaseOwnershipChangeGroup = "DATABASE_OWNERSHIP_CHANGE_GROUP";

		// Token: 0x040007DF RID: 2015
		internal const string SchemaObjectOwnershipChangeGroup = "SCHEMA_OBJECT_OWNERSHIP_CHANGE_GROUP";

		// Token: 0x040007E0 RID: 2016
		internal const string DatabaseObjectPermissionChangeGroup = "DATABASE_OBJECT_PERMISSION_CHANGE_GROUP";

		// Token: 0x040007E1 RID: 2017
		internal const string DatabaseOperationGroup = "DATABASE_OPERATION_GROUP";

		// Token: 0x040007E2 RID: 2018
		internal const string DatabaseObjectAccessGroup = "DATABASE_OBJECT_ACCESS_GROUP";

		// Token: 0x040007E3 RID: 2019
		internal const string SuccessfulDatabaseAuthenticationGroup = "SUCCESSFUL_DATABASE_AUTHENTICATION_GROUP";

		// Token: 0x040007E4 RID: 2020
		internal const string FailedDatabaseAuthenticationGroup = "FAILED_DATABASE_AUTHENTICATION_GROUP";

		// Token: 0x040007E5 RID: 2021
		internal const string DatabaseLogoutGroup = "DATABASE_LOGOUT_GROUP";

		// Token: 0x040007E6 RID: 2022
		internal const string UserChangePasswordGroup = "USER_CHANGE_PASSWORD_GROUP";

		// Token: 0x040007E7 RID: 2023
		internal const string UserDefinedAuditGroup = "USER_DEFINED_AUDIT_GROUP";
	}
}
