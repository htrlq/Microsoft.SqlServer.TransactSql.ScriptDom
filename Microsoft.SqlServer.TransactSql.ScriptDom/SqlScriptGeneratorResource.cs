using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001B0 RID: 432
	[CompilerGenerated]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal class SqlScriptGeneratorResource
	{
		// Token: 0x0600102B RID: 4139 RVA: 0x00036354 File Offset: 0x00034554
		internal SqlScriptGeneratorResource()
		{
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600102C RID: 4140 RVA: 0x0003635C File Offset: 0x0003455C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(SqlScriptGeneratorResource.resourceMan, null))
				{
					ResourceManager resourceManager = new ResourceManager("Microsoft.SqlServer.TransactSql.ScriptDom.SqlScriptGeneratorResource", typeof(SqlScriptGeneratorResource).Assembly);
					SqlScriptGeneratorResource.resourceMan = resourceManager;
				}
				return SqlScriptGeneratorResource.resourceMan;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600102D RID: 4141 RVA: 0x0003639B File Offset: 0x0003459B
		// (set) Token: 0x0600102E RID: 4142 RVA: 0x000363A2 File Offset: 0x000345A2
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return SqlScriptGeneratorResource.resourceCulture;
			}
			set
			{
				SqlScriptGeneratorResource.resourceCulture = value;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600102F RID: 4143 RVA: 0x000363AA File Offset: 0x000345AA
		internal static string CircularAlignmentPoints
		{
			get
			{
				return SqlScriptGeneratorResource.ResourceManager.GetString("CircularAlignmentPoints", SqlScriptGeneratorResource.resourceCulture);
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06001030 RID: 4144 RVA: 0x000363C0 File Offset: 0x000345C0
		internal static string InvalidAlignmentOperation
		{
			get
			{
				return SqlScriptGeneratorResource.ResourceManager.GetString("InvalidAlignmentOperation", SqlScriptGeneratorResource.resourceCulture);
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06001031 RID: 4145 RVA: 0x000363D6 File Offset: 0x000345D6
		internal static string ScriptDomTreeTypeNotSupported
		{
			get
			{
				return SqlScriptGeneratorResource.ResourceManager.GetString("ScriptDomTreeTypeNotSupported", SqlScriptGeneratorResource.resourceCulture);
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06001032 RID: 4146 RVA: 0x000363EC File Offset: 0x000345EC
		internal static string TokenizationFailed
		{
			get
			{
				return SqlScriptGeneratorResource.ResourceManager.GetString("TokenizationFailed", SqlScriptGeneratorResource.resourceCulture);
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06001033 RID: 4147 RVA: 0x00036402 File Offset: 0x00034602
		internal static string TokenTypeDoesNotHaveStringRepresentation
		{
			get
			{
				return SqlScriptGeneratorResource.ResourceManager.GetString("TokenTypeDoesNotHaveStringRepresentation", SqlScriptGeneratorResource.resourceCulture);
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06001034 RID: 4148 RVA: 0x00036418 File Offset: 0x00034618
		internal static string UnhandledOption
		{
			get
			{
				return SqlScriptGeneratorResource.ResourceManager.GetString("UnhandledOption", SqlScriptGeneratorResource.resourceCulture);
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06001035 RID: 4149 RVA: 0x0003642E File Offset: 0x0003462E
		internal static string UnknownEnumValue
		{
			get
			{
				return SqlScriptGeneratorResource.ResourceManager.GetString("UnknownEnumValue", SqlScriptGeneratorResource.resourceCulture);
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06001036 RID: 4150 RVA: 0x00036444 File Offset: 0x00034644
		internal static string UnknownLiteralType
		{
			get
			{
				return SqlScriptGeneratorResource.ResourceManager.GetString("UnknownLiteralType", SqlScriptGeneratorResource.resourceCulture);
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06001037 RID: 4151 RVA: 0x0003645A File Offset: 0x0003465A
		internal static string UnknownQuoteType
		{
			get
			{
				return SqlScriptGeneratorResource.ResourceManager.GetString("UnknownQuoteType", SqlScriptGeneratorResource.resourceCulture);
			}
		}

		// Token: 0x04001054 RID: 4180
		private static ResourceManager resourceMan;

		// Token: 0x04001055 RID: 4181
		private static CultureInfo resourceCulture;
	}
}
