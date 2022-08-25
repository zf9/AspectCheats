using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace AspectLauncheV4.Antidebug
{
	// Token: 0x02000013 RID: 19
	internal class dumpprotect1
	{
		// Token: 0x06000067 RID: 103
		[DllImport("kernel32.dll")]
		private static extern IntPtr ZeroMemory(IntPtr addr, IntPtr size);

		// Token: 0x06000068 RID: 104
		[DllImport("kernel32.dll")]
		private static extern IntPtr VirtualProtect(IntPtr lpAddress, IntPtr dwSize, IntPtr flNewProtect, ref IntPtr lpflOldProtect);

		// Token: 0x06000069 RID: 105 RVA: 0x00005F48 File Offset: 0x00004148
		private static void EraseSection(IntPtr address, int size)
		{
			IntPtr intPtr = (IntPtr)size;
			IntPtr flNewProtect = 0;
			dumpprotect1.VirtualProtect(address, intPtr, (IntPtr)64, ref flNewProtect);
			dumpprotect1.ZeroMemory(address, intPtr);
			IntPtr intPtr2 = 0;
			dumpprotect1.VirtualProtect(address, intPtr, flNewProtect, ref intPtr2);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00005F90 File Offset: 0x00004190
		public static void AntiDump()
		{
			try
			{
				IntPtr baseAddress = Process.GetCurrentProcess().MainModule.BaseAddress;
				int num = Marshal.ReadInt32((IntPtr)(baseAddress.ToInt32() + 60));
				short num2 = Marshal.ReadInt16((IntPtr)(baseAddress.ToInt32() + num + 6));
				dumpprotect1.EraseSection(baseAddress, 30);
				for (int i = 0; i < dumpprotect1.peheaderdwords.Length; i++)
				{
					dumpprotect1.EraseSection((IntPtr)(baseAddress.ToInt32() + num + dumpprotect1.peheaderdwords[i]), 4);
				}
				for (int j = 0; j < dumpprotect1.peheaderwords.Length; j++)
				{
					dumpprotect1.EraseSection((IntPtr)(baseAddress.ToInt32() + num + dumpprotect1.peheaderwords[j]), 2);
				}
				for (int k = 0; k < dumpprotect1.peheaderbytes.Length; k++)
				{
					dumpprotect1.EraseSection((IntPtr)(baseAddress.ToInt32() + num + dumpprotect1.peheaderbytes[k]), 1);
				}
				int l = 0;
				int num3 = 0;
				while (l <= (int)num2)
				{
					if (num3 == 0)
					{
						dumpprotect1.EraseSection((IntPtr)(baseAddress.ToInt32() + num + 250 + 40 * l + 32), 2);
					}
					dumpprotect1.EraseSection((IntPtr)(baseAddress.ToInt32() + num + 250 + 40 * l + dumpprotect1.sectiontabledwords[num3]), 4);
					num3++;
					if (num3 == dumpprotect1.sectiontabledwords.Length)
					{
						l++;
						num3 = 0;
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x040002D7 RID: 727
		private static int[] sectiontabledwords = new int[]
		{
			8,
			12,
			16,
			20,
			24,
			28,
			36
		};

		// Token: 0x040002D8 RID: 728
		private static int[] peheaderbytes = new int[]
		{
			26,
			27
		};

		// Token: 0x040002D9 RID: 729
		private static int[] peheaderwords = new int[]
		{
			4,
			22,
			24,
			64,
			66,
			68,
			70,
			72,
			74,
			76,
			92,
			94
		};

		// Token: 0x040002DA RID: 730
		private static int[] peheaderdwords = new int[]
		{
			0,
			8,
			12,
			16,
			22,
			28,
			32,
			40,
			44,
			52,
			60,
			76,
			80,
			84,
			88,
			96,
			100,
			104,
			108,
			112,
			116,
			260,
			264,
			268,
			272,
			276,
			284
		};
	}
}
