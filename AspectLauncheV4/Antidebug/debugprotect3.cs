using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Anti_DebugNET.Utils;
using Anti_DebugNET.Utils.WinStructs;

namespace AspectLauncheV4.Antidebug
{
	// Token: 0x02000012 RID: 18
	internal class debugprotect3
	{
		// Token: 0x0600005F RID: 95
		[DllImport("ntdll.dll")]
		internal static extern NtStatus NtSetInformationThread(IntPtr ThreadHandle, ThreadInformationClass ThreadInformationClass, IntPtr ThreadInformation, int ThreadInformationLength);

		// Token: 0x06000060 RID: 96
		[DllImport("kernel32.dll")]
		private static extern IntPtr OpenThread(ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);

		// Token: 0x06000061 RID: 97
		[DllImport("kernel32.dll")]
		private static extern uint SuspendThread(IntPtr hThread);

		// Token: 0x06000062 RID: 98
		[DllImport("kernel32.dll")]
		private static extern int ResumeThread(IntPtr hThread);

		// Token: 0x06000063 RID: 99
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool CloseHandle(IntPtr handle);

		// Token: 0x06000064 RID: 100 RVA: 0x00005EA8 File Offset: 0x000040A8
		public static void HideOSThreads()
		{
			foreach (object obj in Process.GetCurrentProcess().Threads)
			{
				ProcessThread processThread = (ProcessThread)obj;
				IntPtr intPtr = debugprotect3.OpenThread(ThreadAccess.SET_INFORMATION, false, (uint)processThread.Id);
				if (!(intPtr == IntPtr.Zero))
				{
					debugprotect3.HideFromDebugger(intPtr);
					debugprotect3.CloseHandle(intPtr);
				}
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00005F28 File Offset: 0x00004128
		public static bool HideFromDebugger(IntPtr Handle)
		{
			return debugprotect3.NtSetInformationThread(Handle, ThreadInformationClass.ThreadHideFromDebugger, IntPtr.Zero, 0) == NtStatus.Success;
		}
	}
}
