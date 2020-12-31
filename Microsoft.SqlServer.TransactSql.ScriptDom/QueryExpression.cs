using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003FA RID: 1018
	[Serializable]
	public abstract class QueryExpression : TSqlFragment
	{
		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x060036B4 RID: 14004 RVA: 0x001D5B51 File Offset: 0x001D3D51
		// (set) Token: 0x060036B5 RID: 14005 RVA: 0x001D5B59 File Offset: 0x001D3D59
		public OrderByClause OrderByClause
		{
			get
			{
				return this._orderByClause;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._orderByClause = value;
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x060036B6 RID: 14006 RVA: 0x001D5B69 File Offset: 0x001D3D69
		// (set) Token: 0x060036B7 RID: 14007 RVA: 0x001D5B71 File Offset: 0x001D3D71
		public OffsetClause OffsetClause
		{
			get
			{
				return this._offsetClause;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._offsetClause = value;
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x060036B8 RID: 14008 RVA: 0x001D5B81 File Offset: 0x001D3D81
		// (set) Token: 0x060036B9 RID: 14009 RVA: 0x001D5B89 File Offset: 0x001D3D89
		public ForClause ForClause
		{
			get
			{
				return this._forClause;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._forClause = value;
			}
		}

		// Token: 0x060036BA RID: 14010 RVA: 0x001D5B9C File Offset: 0x001D3D9C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.OrderByClause != null)
			{
				this.OrderByClause.Accept(visitor);
			}
			if (this.OffsetClause != null)
			{
				this.OffsetClause.Accept(visitor);
			}
			if (this.ForClause != null)
			{
				this.ForClause.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400211F RID: 8479
		private OrderByClause _orderByClause;

		// Token: 0x04002120 RID: 8480
		private OffsetClause _offsetClause;

		// Token: 0x04002121 RID: 8481
		private ForClause _forClause;
	}
}
