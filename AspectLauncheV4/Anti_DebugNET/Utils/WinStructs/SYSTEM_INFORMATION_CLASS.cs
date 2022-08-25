using System;

namespace Anti_DebugNET.Utils.WinStructs
{
	// Token: 0x02000007 RID: 7
	public enum SYSTEM_INFORMATION_CLASS
	{
		// Token: 0x04000195 RID: 405
		SystemBasicInformation,
		// Token: 0x04000196 RID: 406
		SystemProcessorInformation,
		// Token: 0x04000197 RID: 407
		SystemPerformanceInformation,
		// Token: 0x04000198 RID: 408
		SystemTimeOfDayInformation,
		// Token: 0x04000199 RID: 409
		SystemPathInformation,
		// Token: 0x0400019A RID: 410
		SystemProcessInformation,
		// Token: 0x0400019B RID: 411
		SystemCallCountInformation,
		// Token: 0x0400019C RID: 412
		SystemDeviceInformation,
		// Token: 0x0400019D RID: 413
		SystemProcessorPerformanceInformation,
		// Token: 0x0400019E RID: 414
		SystemFlagsInformation,
		// Token: 0x0400019F RID: 415
		SystemCallTimeInformation,
		// Token: 0x040001A0 RID: 416
		SystemModuleInformation,
		// Token: 0x040001A1 RID: 417
		SystemLocksInformation,
		// Token: 0x040001A2 RID: 418
		SystemStackTraceInformation,
		// Token: 0x040001A3 RID: 419
		SystemPagedPoolInformation,
		// Token: 0x040001A4 RID: 420
		SystemNonPagedPoolInformation,
		// Token: 0x040001A5 RID: 421
		SystemHandleInformation,
		// Token: 0x040001A6 RID: 422
		SystemObjectInformation,
		// Token: 0x040001A7 RID: 423
		SystemPageFileInformation,
		// Token: 0x040001A8 RID: 424
		SystemVdmInstemulInformation,
		// Token: 0x040001A9 RID: 425
		SystemVdmBopInformation,
		// Token: 0x040001AA RID: 426
		SystemFileCacheInformation,
		// Token: 0x040001AB RID: 427
		SystemPoolTagInformation,
		// Token: 0x040001AC RID: 428
		SystemInterruptInformation,
		// Token: 0x040001AD RID: 429
		SystemDpcBehaviorInformation,
		// Token: 0x040001AE RID: 430
		SystemFullMemoryInformation,
		// Token: 0x040001AF RID: 431
		SystemLoadGdiDriverInformation,
		// Token: 0x040001B0 RID: 432
		SystemUnloadGdiDriverInformation,
		// Token: 0x040001B1 RID: 433
		SystemTimeAdjustmentInformation,
		// Token: 0x040001B2 RID: 434
		SystemSummaryMemoryInformation,
		// Token: 0x040001B3 RID: 435
		SystemMirrorMemoryInformation,
		// Token: 0x040001B4 RID: 436
		SystemPerformanceTraceInformation,
		// Token: 0x040001B5 RID: 437
		SystemObsolete0,
		// Token: 0x040001B6 RID: 438
		SystemExceptionInformation,
		// Token: 0x040001B7 RID: 439
		SystemCrashDumpStateInformation,
		// Token: 0x040001B8 RID: 440
		SystemKernelDebuggerInformation,
		// Token: 0x040001B9 RID: 441
		SystemContextSwitchInformation,
		// Token: 0x040001BA RID: 442
		SystemRegistryQuotaInformation,
		// Token: 0x040001BB RID: 443
		SystemExtendServiceTableInformation,
		// Token: 0x040001BC RID: 444
		SystemPrioritySeperation,
		// Token: 0x040001BD RID: 445
		SystemVerifierAddDriverInformation,
		// Token: 0x040001BE RID: 446
		SystemVerifierRemoveDriverInformation,
		// Token: 0x040001BF RID: 447
		SystemProcessorIdleInformation,
		// Token: 0x040001C0 RID: 448
		SystemLegacyDriverInformation,
		// Token: 0x040001C1 RID: 449
		SystemCurrentTimeZoneInformation,
		// Token: 0x040001C2 RID: 450
		SystemLookasideInformation,
		// Token: 0x040001C3 RID: 451
		SystemTimeSlipNotification,
		// Token: 0x040001C4 RID: 452
		SystemSessionCreate,
		// Token: 0x040001C5 RID: 453
		SystemSessionDetach,
		// Token: 0x040001C6 RID: 454
		SystemSessionInformation,
		// Token: 0x040001C7 RID: 455
		SystemRangeStartInformation,
		// Token: 0x040001C8 RID: 456
		SystemVerifierInformation,
		// Token: 0x040001C9 RID: 457
		SystemVerifierThunkExtend,
		// Token: 0x040001CA RID: 458
		SystemSessionProcessInformation,
		// Token: 0x040001CB RID: 459
		SystemLoadGdiDriverInSystemSpace,
		// Token: 0x040001CC RID: 460
		SystemNumaProcessorMap,
		// Token: 0x040001CD RID: 461
		SystemPrefetcherInformation,
		// Token: 0x040001CE RID: 462
		SystemExtendedProcessInformation,
		// Token: 0x040001CF RID: 463
		SystemRecommendedSharedDataAlignment,
		// Token: 0x040001D0 RID: 464
		SystemComPlusPackage,
		// Token: 0x040001D1 RID: 465
		SystemNumaAvailableMemory,
		// Token: 0x040001D2 RID: 466
		SystemProcessorPowerInformation,
		// Token: 0x040001D3 RID: 467
		SystemEmulationBasicInformation,
		// Token: 0x040001D4 RID: 468
		SystemEmulationProcessorInformation,
		// Token: 0x040001D5 RID: 469
		SystemExtendedHandleInformation,
		// Token: 0x040001D6 RID: 470
		SystemLostDelayedWriteInformation,
		// Token: 0x040001D7 RID: 471
		SystemBigPoolInformation,
		// Token: 0x040001D8 RID: 472
		SystemSessionPoolTagInformation,
		// Token: 0x040001D9 RID: 473
		SystemSessionMappedViewInformation,
		// Token: 0x040001DA RID: 474
		SystemHotpatchInformation,
		// Token: 0x040001DB RID: 475
		SystemObjectSecurityMode,
		// Token: 0x040001DC RID: 476
		SystemWatchdogTimerHandler,
		// Token: 0x040001DD RID: 477
		SystemWatchdogTimerInformation,
		// Token: 0x040001DE RID: 478
		SystemLogicalProcessorInformation,
		// Token: 0x040001DF RID: 479
		SystemWow64SharedInformationObsolete,
		// Token: 0x040001E0 RID: 480
		SystemRegisterFirmwareTableInformationHandler,
		// Token: 0x040001E1 RID: 481
		SystemFirmwareTableInformation,
		// Token: 0x040001E2 RID: 482
		SystemModuleInformationEx,
		// Token: 0x040001E3 RID: 483
		SystemVerifierTriageInformation,
		// Token: 0x040001E4 RID: 484
		SystemSuperfetchInformation,
		// Token: 0x040001E5 RID: 485
		SystemMemoryListInformation,
		// Token: 0x040001E6 RID: 486
		SystemFileCacheInformationEx,
		// Token: 0x040001E7 RID: 487
		SystemThreadPriorityClientIdInformation,
		// Token: 0x040001E8 RID: 488
		SystemProcessorIdleCycleTimeInformation,
		// Token: 0x040001E9 RID: 489
		SystemVerifierCancellationInformation,
		// Token: 0x040001EA RID: 490
		SystemProcessorPowerInformationEx,
		// Token: 0x040001EB RID: 491
		SystemRefTraceInformation,
		// Token: 0x040001EC RID: 492
		SystemSpecialPoolInformation,
		// Token: 0x040001ED RID: 493
		SystemProcessIdInformation,
		// Token: 0x040001EE RID: 494
		SystemErrorPortInformation,
		// Token: 0x040001EF RID: 495
		SystemBootEnvironmentInformation,
		// Token: 0x040001F0 RID: 496
		SystemHypervisorInformation,
		// Token: 0x040001F1 RID: 497
		SystemVerifierInformationEx,
		// Token: 0x040001F2 RID: 498
		SystemTimeZoneInformation,
		// Token: 0x040001F3 RID: 499
		SystemImageFileExecutionOptionsInformation,
		// Token: 0x040001F4 RID: 500
		SystemCoverageInformation,
		// Token: 0x040001F5 RID: 501
		SystemPrefetchPatchInformation,
		// Token: 0x040001F6 RID: 502
		SystemVerifierFaultsInformation,
		// Token: 0x040001F7 RID: 503
		SystemSystemPartitionInformation,
		// Token: 0x040001F8 RID: 504
		SystemSystemDiskInformation,
		// Token: 0x040001F9 RID: 505
		SystemProcessorPerformanceDistribution,
		// Token: 0x040001FA RID: 506
		SystemNumaProximityNodeInformation,
		// Token: 0x040001FB RID: 507
		SystemDynamicTimeZoneInformation,
		// Token: 0x040001FC RID: 508
		SystemCodeIntegrityInformation,
		// Token: 0x040001FD RID: 509
		SystemProcessorMicrocodeUpdateInformation,
		// Token: 0x040001FE RID: 510
		SystemProcessorBrandString,
		// Token: 0x040001FF RID: 511
		SystemVirtualAddressInformation,
		// Token: 0x04000200 RID: 512
		SystemLogicalProcessorAndGroupInformation,
		// Token: 0x04000201 RID: 513
		SystemProcessorCycleTimeInformation,
		// Token: 0x04000202 RID: 514
		SystemStoreInformation,
		// Token: 0x04000203 RID: 515
		SystemRegistryAppendString,
		// Token: 0x04000204 RID: 516
		SystemAitSamplingValue,
		// Token: 0x04000205 RID: 517
		SystemVhdBootInformation,
		// Token: 0x04000206 RID: 518
		SystemCpuQuotaInformation,
		// Token: 0x04000207 RID: 519
		SystemNativeBasicInformation,
		// Token: 0x04000208 RID: 520
		SystemSpare1,
		// Token: 0x04000209 RID: 521
		SystemLowPriorityIoInformation,
		// Token: 0x0400020A RID: 522
		SystemTpmBootEntropyInformation,
		// Token: 0x0400020B RID: 523
		SystemVerifierCountersInformation,
		// Token: 0x0400020C RID: 524
		SystemPagedPoolInformationEx,
		// Token: 0x0400020D RID: 525
		SystemSystemPtesInformationEx,
		// Token: 0x0400020E RID: 526
		SystemNodeDistanceInformation,
		// Token: 0x0400020F RID: 527
		SystemAcpiAuditInformation,
		// Token: 0x04000210 RID: 528
		SystemBasicPerformanceInformation,
		// Token: 0x04000211 RID: 529
		SystemQueryPerformanceCounterInformation,
		// Token: 0x04000212 RID: 530
		SystemSessionBigPoolInformation,
		// Token: 0x04000213 RID: 531
		SystemBootGraphicsInformation,
		// Token: 0x04000214 RID: 532
		SystemScrubPhysicalMemoryInformation,
		// Token: 0x04000215 RID: 533
		SystemBadPageInformation,
		// Token: 0x04000216 RID: 534
		SystemProcessorProfileControlArea,
		// Token: 0x04000217 RID: 535
		SystemCombinePhysicalMemoryInformation,
		// Token: 0x04000218 RID: 536
		SystemEntropyInterruptTimingCallback,
		// Token: 0x04000219 RID: 537
		SystemConsoleInformation,
		// Token: 0x0400021A RID: 538
		SystemPlatformBinaryInformation,
		// Token: 0x0400021B RID: 539
		SystemThrottleNotificationInformation,
		// Token: 0x0400021C RID: 540
		SystemHypervisorProcessorCountInformation,
		// Token: 0x0400021D RID: 541
		SystemDeviceDataInformation,
		// Token: 0x0400021E RID: 542
		SystemDeviceDataEnumerationInformation,
		// Token: 0x0400021F RID: 543
		SystemMemoryTopologyInformation,
		// Token: 0x04000220 RID: 544
		SystemMemoryChannelInformation,
		// Token: 0x04000221 RID: 545
		SystemBootLogoInformation,
		// Token: 0x04000222 RID: 546
		SystemProcessorPerformanceInformationEx,
		// Token: 0x04000223 RID: 547
		SystemSpare0,
		// Token: 0x04000224 RID: 548
		SystemSecureBootPolicyInformation,
		// Token: 0x04000225 RID: 549
		SystemPageFileInformationEx,
		// Token: 0x04000226 RID: 550
		SystemSecureBootInformation,
		// Token: 0x04000227 RID: 551
		SystemEntropyInterruptTimingRawInformation,
		// Token: 0x04000228 RID: 552
		SystemPortableWorkspaceEfiLauncherInformation,
		// Token: 0x04000229 RID: 553
		SystemFullProcessInformation,
		// Token: 0x0400022A RID: 554
		SystemKernelDebuggerInformationEx,
		// Token: 0x0400022B RID: 555
		SystemBootMetadataInformation,
		// Token: 0x0400022C RID: 556
		SystemSoftRebootInformation,
		// Token: 0x0400022D RID: 557
		SystemElamCertificateInformation,
		// Token: 0x0400022E RID: 558
		SystemOfflineDumpConfigInformation,
		// Token: 0x0400022F RID: 559
		SystemProcessorFeaturesInformation,
		// Token: 0x04000230 RID: 560
		SystemRegistryReconciliationInformation,
		// Token: 0x04000231 RID: 561
		SystemEdidInformation,
		// Token: 0x04000232 RID: 562
		MaxSystemInfoClass
	}
}
