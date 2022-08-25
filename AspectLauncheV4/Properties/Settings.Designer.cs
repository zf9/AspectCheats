using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace AspectLauncheV4.Properties
{
	// Token: 0x02000010 RID: 16
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00005C29 File Offset: 0x00003E29
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x040002D5 RID: 725
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
