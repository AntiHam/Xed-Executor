using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace FUCK_GAH.Properties
{
	// Token: 0x02000005 RID: 5
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000011 RID: 17 RVA: 0x00002F92 File Offset: 0x00001192
		internal Resources()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002F9C File Offset: 0x0000119C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("FUCK_GAH.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00002FE4 File Offset: 0x000011E4
		// (set) Token: 0x06000014 RID: 20 RVA: 0x00002FFB File Offset: 0x000011FB
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

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00003004 File Offset: 0x00001204
		internal static Bitmap _9868e56a_4c76_44f5_a6d6_3f54f9cab8b2
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("9868e56a-4c76-44f5-a6d6-3f54f9cab8b2", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00003034 File Offset: 0x00001234
		internal static Bitmap coollogo_com_2800838
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("coollogo_com-2800838", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x04000012 RID: 18
		private static ResourceManager resourceMan;

		// Token: 0x04000013 RID: 19
		private static CultureInfo resourceCulture;
	}
}
