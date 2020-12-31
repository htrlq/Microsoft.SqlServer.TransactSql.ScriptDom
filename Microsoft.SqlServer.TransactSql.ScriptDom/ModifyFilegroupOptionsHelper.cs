using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000FC RID: 252
	internal class ModifyFilegroupOptionsHelper : OptionsHelper<ModifyFileGroupOption>
	{
		// Token: 0x060002B0 RID: 688 RVA: 0x00008A6F File Offset: 0x00006C6F
		private ModifyFilegroupOptionsHelper()
		{
			base.AddOptionMapping(ModifyFileGroupOption.ReadOnly, "READ_ONLY");
			base.AddOptionMapping(ModifyFileGroupOption.ReadOnlyOld, "READONLY");
			base.AddOptionMapping(ModifyFileGroupOption.ReadWrite, "READ_WRITE");
			base.AddOptionMapping(ModifyFileGroupOption.ReadWriteOld, "READWRITE");
		}

		// Token: 0x04000BEF RID: 3055
		internal static readonly ModifyFilegroupOptionsHelper Instance = new ModifyFilegroupOptionsHelper();
	}
}
