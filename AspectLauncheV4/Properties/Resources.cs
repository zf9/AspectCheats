using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace AspectLauncheV4.Properties
{
	// Token: 0x0200000F RID: 15
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000051 RID: 81 RVA: 0x00005BE6 File Offset: 0x00003DE6
		internal Resources()
		{
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00005BEE File Offset: 0x00003DEE
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					Resources.resourceMan = new ResourceManager("AspectLauncheV4.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00005C1A File Offset: 0x00003E1A
		// (set) Token: 0x06000054 RID: 84 RVA: 0x00005C21 File Offset: 0x00003E21
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x040002D3 RID: 723
		private static ResourceManager resourceMan;

		// Token: 0x040002D4 RID: 724
		private static CultureInfo resourceCulture;
	}
}
