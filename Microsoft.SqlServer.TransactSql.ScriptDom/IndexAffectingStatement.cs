using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000DC RID: 220
	internal enum IndexAffectingStatement
	{
		// Token: 0x04000B73 RID: 2931
		AlterTableAddElement,
		// Token: 0x04000B74 RID: 2932
		AlterTableRebuildOnePartition,
		// Token: 0x04000B75 RID: 2933
		AlterTableRebuildAllPartitions,
		// Token: 0x04000B76 RID: 2934
		AlterIndexSet,
		// Token: 0x04000B77 RID: 2935
		AlterIndexRebuildOnePartition,
		// Token: 0x04000B78 RID: 2936
		AlterIndexRebuildAllPartitions,
		// Token: 0x04000B79 RID: 2937
		AlterIndexReorganize,
		// Token: 0x04000B7A RID: 2938
		CreateColumnStoreIndex,
		// Token: 0x04000B7B RID: 2939
		CreateIndex,
		// Token: 0x04000B7C RID: 2940
		CreateTable,
		// Token: 0x04000B7D RID: 2941
		CreateType,
		// Token: 0x04000B7E RID: 2942
		CreateXmlIndex,
		// Token: 0x04000B7F RID: 2943
		CreateOrAlterFunction,
		// Token: 0x04000B80 RID: 2944
		DeclareTableVariable,
		// Token: 0x04000B81 RID: 2945
		CreateSpatialIndex,
		// Token: 0x04000B82 RID: 2946
		CreateTableInlineIndex
	}
}
