using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000057 RID: 87
	internal class AttachModeHelper : OptionsHelper<AttachMode>
	{
		// Token: 0x060001C5 RID: 453 RVA: 0x00006011 File Offset: 0x00004211
		private AttachModeHelper()
		{
			base.AddOptionMapping(AttachMode.Attach, "ATTACH");
			base.AddOptionMapping(AttachMode.AttachRebuildLog, "ATTACH_REBUILD_LOG");
			base.AddOptionMapping(AttachMode.AttachForceRebuildLog, "ATTACH_FORCE_REBUILD_LOG");
			base.AddOptionMapping(AttachMode.Load, "LOAD");
		}

		// Token: 0x0400016A RID: 362
		internal static readonly AttachModeHelper Instance = new AttachModeHelper();
	}
}
