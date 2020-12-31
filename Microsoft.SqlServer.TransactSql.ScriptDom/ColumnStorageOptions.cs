using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000373 RID: 883
	[Serializable]
	public class ColumnStorageOptions : TSqlFragment
	{
		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06003342 RID: 13122 RVA: 0x001D1F3B File Offset: 0x001D013B
		// (set) Token: 0x06003343 RID: 13123 RVA: 0x001D1F43 File Offset: 0x001D0143
		public bool IsFileStream
		{
			get
			{
				return this._isFileStream;
			}
			set
			{
				this._isFileStream = value;
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06003344 RID: 13124 RVA: 0x001D1F4C File Offset: 0x001D014C
		// (set) Token: 0x06003345 RID: 13125 RVA: 0x001D1F54 File Offset: 0x001D0154
		public SparseColumnOption SparseOption
		{
			get
			{
				return this._sparseOption;
			}
			set
			{
				this._sparseOption = value;
			}
		}

		// Token: 0x06003346 RID: 13126 RVA: 0x001D1F5D File Offset: 0x001D015D
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003347 RID: 13127 RVA: 0x001D1F69 File Offset: 0x001D0169
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400200F RID: 8207
		private bool _isFileStream;

		// Token: 0x04002010 RID: 8208
		private SparseColumnOption _sparseOption;
	}
}
