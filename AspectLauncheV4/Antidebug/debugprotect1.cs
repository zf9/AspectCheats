using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace AspectLauncheV4.Antidebug
{
	// Token: 0x02000011 RID: 17
	internal class debugprotect1
	{
		// Token: 0x06000058 RID: 88
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool CheckRemoteDebuggerPresent(IntPtr hProcess, [MarshalAs(UnmanagedType.Bool)] ref bool isDebuggerPresent);

		// Token: 0x06000059 RID: 89
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool IsDebuggerPresent();

		// Token: 0x0600005A RID: 90 RVA: 0x00005C50 File Offset: 0x00003E50
		public static int PerformChecks()
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Aspect Cheats");
			object value = registryKey.GetValue("Username");
			object value2 = registryKey.GetValue("Password");
			if (debugprotect1.CheckDebuggerManagedPresent() == 1)
			{
				string text = Registry.GetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\IDConfigDB\\Hardware Profiles\\0001", "HwProfileGuid", null).ToString();
				Form1.Webmessage("Aspect Launcher", string.Concat(new string[]
				{
					"Debugger Detected: CheckDebuggerManaged\nUsername: ",
					(value != null) ? value.ToString() : null,
					"\n Password: ",
					(value2 != null) ? value2.ToString() : null,
					"\nIP 1: ",
					Form1.GetLocaladd(),
					"\nIP 2: ",
					Form1.Getad(),
					"\n HWID:",
					text
				}), "Aspect Launcher", "15105570");
				return 1;
			}
			if (debugprotect1.CheckDebuggerUnmanagedPresent() == 1)
			{
				string text2 = Registry.GetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\IDConfigDB\\Hardware Profiles\\0001", "HwProfileGuid", null).ToString();
				Form1.Webmessage("Aspect Launcher", string.Concat(new string[]
				{
					"Debugger Detected: CheckDebuggerUnmanaged\nUsername: ",
					(value != null) ? value.ToString() : null,
					"\n Password: ",
					(value2 != null) ? value2.ToString() : null,
					"\nIP 1: ",
					Form1.GetLocaladd(),
					"\nIP 2: ",
					Form1.Getad(),
					"\n HWID:",
					text2
				}), "Aspect Launcher", "15105570");
				return 1;
			}
			if (debugprotect1.CheckRemoteDebugger() == 1)
			{
				string text3 = Registry.GetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\IDConfigDB\\Hardware Profiles\\0001", "HwProfileGuid", null).ToString();
				Form1.Webmessage("Aspect Launcher", string.Concat(new string[]
				{
					"Debugger Detected: CheckRemoteDebugger\nUsername: ",
					(value != null) ? value.ToString() : null,
					"\n Password: ",
					(value2 != null) ? value2.ToString() : null,
					"\nIP 1: ",
					Form1.GetLocaladd(),
					"\nIP 2: ",
					Form1.Getad(),
					"\n HWID:",
					text3
				}), "Aspect Launcher", "15105570");
				return 1;
			}
			return 0;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00005E60 File Offset: 0x00004060
		private static int CheckDebuggerManagedPresent()
		{
			if (Debugger.IsAttached)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00005E6C File Offset: 0x0000406C
		private static int CheckDebuggerUnmanagedPresent()
		{
			if (debugprotect1.IsDebuggerPresent())
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00005E78 File Offset: 0x00004078
		private static int CheckRemoteDebugger()
		{
			bool flag = false;
			if (debugprotect1.CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref flag) && flag)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x040002D6 RID: 726
		private bool notified1;
	}
}
