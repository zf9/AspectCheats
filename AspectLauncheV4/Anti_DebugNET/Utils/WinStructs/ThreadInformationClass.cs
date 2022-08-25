using System;

namespace Anti_DebugNET.Utils.WinStructs
{
	// Token: 0x02000008 RID: 8
	public enum ThreadInformationClass
	{
		// Token: 0x04000234 RID: 564
		ThreadBasicInformation,
		// Token: 0x04000235 RID: 565
		ThreadTimes,
		// Token: 0x04000236 RID: 566
		ThreadPriority,
		// Token: 0x04000237 RID: 567
		ThreadBasePriority,
		// Token: 0x04000238 RID: 568
		ThreadAffinityMask,
		// Token: 0x04000239 RID: 569
		ThreadImpersonationToken,
		// Token: 0x0400023A RID: 570
		ThreadDescriptorTableEntry,
		// Token: 0x0400023B RID: 571
		ThreadEnableAlignmentFaultFixup,
		// Token: 0x0400023C RID: 572
		ThreadEventPair_Reusable,
		// Token: 0x0400023D RID: 573
		ThreadQuerySetWin32StartAddress,
		// Token: 0x0400023E RID: 574
		ThreadZeroTlsCell,
		// Token: 0x0400023F RID: 575
		ThreadPerformanceCount,
		// Token: 0x04000240 RID: 576
		ThreadAmILastThread,
		// Token: 0x04000241 RID: 577
		ThreadIdealProcessor,
		// Token: 0x04000242 RID: 578
		ThreadPriorityBoost,
		// Token: 0x04000243 RID: 579
		ThreadSetTlsArrayAddress,
		// Token: 0x04000244 RID: 580
		ThreadIsIoPending,
		// Token: 0x04000245 RID: 581
		ThreadHideFromDebugger,
		// Token: 0x04000246 RID: 582
		ThreadBreakOnTermination,
		// Token: 0x04000247 RID: 583
		ThreadSwitchLegacyState,
		// Token: 0x04000248 RID: 584
		ThreadIsTerminated,
		// Token: 0x04000249 RID: 585
		ThreadLastSystemCall,
		// Token: 0x0400024A RID: 586
		ThreadIoPriority,
		// Token: 0x0400024B RID: 587
		ThreadCycleTime,
		// Token: 0x0400024C RID: 588
		ThreadPagePriority,
		// Token: 0x0400024D RID: 589
		ThreadActualBasePriority,
		// Token: 0x0400024E RID: 590
		ThreadTebInformation,
		// Token: 0x0400024F RID: 591
		ThreadCSwitchMon,
		// Token: 0x04000250 RID: 592
		ThreadCSwitchPmu,
		// Token: 0x04000251 RID: 593
		ThreadWow64Context,
		// Token: 0x04000252 RID: 594
		ThreadGroupInformation,
		// Token: 0x04000253 RID: 595
		ThreadUmsInformation,
		// Token: 0x04000254 RID: 596
		ThreadCounterProfiling,
		// Token: 0x04000255 RID: 597
		ThreadIdealProcessorEx,
		// Token: 0x04000256 RID: 598
		ThreadCpuAccountingInformation,
		// Token: 0x04000257 RID: 599
		ThreadSuspendCount,
		// Token: 0x04000258 RID: 600
		ThreadDescription = 38,
		// Token: 0x04000259 RID: 601
		ThreadActualGroupAffinity = 41,
		// Token: 0x0400025A RID: 602
		ThreadDynamicCodePolicy
	}
}
