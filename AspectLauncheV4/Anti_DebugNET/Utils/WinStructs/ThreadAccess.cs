using System;

namespace Anti_DebugNET.Utils.WinStructs
{
	// Token: 0x02000009 RID: 9
	[Flags]
	public enum ThreadAccess
	{
		// Token: 0x0400025C RID: 604
		TERMINATE = 1,
		// Token: 0x0400025D RID: 605
		SUSPEND_RESUME = 2,
		// Token: 0x0400025E RID: 606
		GET_CONTEXT = 8,
		// Token: 0x0400025F RID: 607
		SET_CONTEXT = 16,
		// Token: 0x04000260 RID: 608
		SET_INFORMATION = 32,
		// Token: 0x04000261 RID: 609
		QUERY_INFORMATION = 64,
		// Token: 0x04000262 RID: 610
		SET_THREAD_TOKEN = 128,
		// Token: 0x04000263 RID: 611
		IMPERSONATE = 256,
		// Token: 0x04000264 RID: 612
		DIRECT_IMPERSONATION = 512
	}
}
