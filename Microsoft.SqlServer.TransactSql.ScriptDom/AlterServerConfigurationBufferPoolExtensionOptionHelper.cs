using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000046 RID: 70
	internal class AlterServerConfigurationBufferPoolExtensionOptionHelper : OptionsHelper<AlterServerConfigurationBufferPoolExtensionOptionKind>
	{
		// Token: 0x060001B9 RID: 441 RVA: 0x00005E7C File Offset: 0x0000407C
		private AlterServerConfigurationBufferPoolExtensionOptionHelper()
		{
			base.AddOptionMapping(AlterServerConfigurationBufferPoolExtensionOptionKind.FileName, "FILENAME");
			base.AddOptionMapping(AlterServerConfigurationBufferPoolExtensionOptionKind.Size, "SIZE");
		}

		// Token: 0x0400011D RID: 285
		internal static readonly AlterServerConfigurationBufferPoolExtensionOptionHelper Instance = new AlterServerConfigurationBufferPoolExtensionOptionHelper();
	}
}
