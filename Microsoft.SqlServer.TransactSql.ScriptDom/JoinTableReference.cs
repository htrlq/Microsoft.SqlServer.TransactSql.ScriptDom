using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003E1 RID: 993
	[Serializable]
	public abstract class JoinTableReference : TableReference
	{
		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06003622 RID: 13858 RVA: 0x001D51A1 File Offset: 0x001D33A1
		// (set) Token: 0x06003623 RID: 13859 RVA: 0x001D51A9 File Offset: 0x001D33A9
		public TableReference FirstTableReference
		{
			get
			{
				return this._firstTableReference;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._firstTableReference = value;
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06003624 RID: 13860 RVA: 0x001D51B9 File Offset: 0x001D33B9
		// (set) Token: 0x06003625 RID: 13861 RVA: 0x001D51C1 File Offset: 0x001D33C1
		public TableReference SecondTableReference
		{
			get
			{
				return this._secondTableReference;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._secondTableReference = value;
			}
		}

		// Token: 0x06003626 RID: 13862 RVA: 0x001D51D1 File Offset: 0x001D33D1
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.FirstTableReference != null)
			{
				this.FirstTableReference.Accept(visitor);
			}
			if (this.SecondTableReference != null)
			{
				this.SecondTableReference.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x040020F6 RID: 8438
		private TableReference _firstTableReference;

		// Token: 0x040020F7 RID: 8439
		private TableReference _secondTableReference;
	}
}
