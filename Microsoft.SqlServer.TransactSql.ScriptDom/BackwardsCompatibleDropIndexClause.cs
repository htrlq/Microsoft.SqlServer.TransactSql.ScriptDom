using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200031E RID: 798
	[Serializable]
	public class BackwardsCompatibleDropIndexClause : DropIndexClauseBase
	{
		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06003133 RID: 12595 RVA: 0x001D0182 File Offset: 0x001CE382
		// (set) Token: 0x06003134 RID: 12596 RVA: 0x001D018A File Offset: 0x001CE38A
		public ChildObjectName Index
		{
			get
			{
				return this._index;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._index = value;
			}
		}

		// Token: 0x06003135 RID: 12597 RVA: 0x001D019A File Offset: 0x001CE39A
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003136 RID: 12598 RVA: 0x001D01A6 File Offset: 0x001CE3A6
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Index != null)
			{
				this.Index.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F7F RID: 8063
		private ChildObjectName _index;
	}
}
