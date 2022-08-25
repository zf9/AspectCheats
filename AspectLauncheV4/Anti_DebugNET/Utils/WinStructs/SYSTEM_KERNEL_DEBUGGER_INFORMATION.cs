using System;
using System.Runtime.InteropServices;

namespace Anti_DebugNET.Utils.WinStructs
{
	// Token: 0x0200000A RID: 10
	public struct SYSTEM_KERNEL_DEBUGGER_INFORMATION
	{
		// Token: 0x04000265 RID: 613
		[MarshalAs(UnmanagedType.U1)]
		public bool KernelDebuggerEnabled;

		// Token: 0x04000266 RID: 614
		[MarshalAs(UnmanagedType.U1)]
		public bool KernelDebuggerNotPresent;
	}
}
