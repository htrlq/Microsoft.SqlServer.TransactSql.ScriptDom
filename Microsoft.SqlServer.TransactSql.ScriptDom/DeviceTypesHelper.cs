using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200009C RID: 156
	internal class DeviceTypesHelper : OptionsHelper<DeviceType>
	{
		// Token: 0x0600021C RID: 540 RVA: 0x00007C77 File Offset: 0x00005E77
		private DeviceTypesHelper()
		{
			base.AddOptionMapping(DeviceType.Disk, "DISK");
			base.AddOptionMapping(DeviceType.Tape, "TAPE");
			base.AddOptionMapping(DeviceType.VirtualDevice, "VIRTUAL_DEVICE");
			base.AddOptionMapping(DeviceType.DatabaseSnapshot, "DATABASE_SNAPSHOT");
		}

		// Token: 0x04000916 RID: 2326
		internal static readonly DeviceTypesHelper Instance = new DeviceTypesHelper();
	}
}
