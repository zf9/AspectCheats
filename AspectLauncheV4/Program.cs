using System;
using System.Windows.Forms;

namespace AspectLauncheV4
{
	// Token: 0x0200000C RID: 12
	internal static class Program
	{
		// Token: 0x06000044 RID: 68 RVA: 0x000056E3 File Offset: 0x000038E3
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
