using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200003F RID: 63
	[Serializable]
	public enum AlterEventSessionStatementType
	{
		// Token: 0x040000F6 RID: 246
		Unknown,
		// Token: 0x040000F7 RID: 247
		AddEventDeclarationOptionalSessionOptions,
		// Token: 0x040000F8 RID: 248
		DropEventSpecificationOptionalSessionOptions,
		// Token: 0x040000F9 RID: 249
		AddTargetDeclarationOptionalSessionOptions,
		// Token: 0x040000FA RID: 250
		DropTargetSpecificationOptionalSessionOptions,
		// Token: 0x040000FB RID: 251
		RequiredSessionOptions,
		// Token: 0x040000FC RID: 252
		AlterStateIsStart,
		// Token: 0x040000FD RID: 253
		AlterStateIsStop
	}
}
