using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200027F RID: 639
	[Serializable]
	public class SelectInsertSource : InsertSource
	{
		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06002DA4 RID: 11684 RVA: 0x001CC575 File Offset: 0x001CA775
		// (set) Token: 0x06002DA5 RID: 11685 RVA: 0x001CC57D File Offset: 0x001CA77D
		public QueryExpression Select
		{
			get
			{
				return this._select;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._select = value;
			}
		}

		// Token: 0x06002DA6 RID: 11686 RVA: 0x001CC58D File Offset: 0x001CA78D
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002DA7 RID: 11687 RVA: 0x001CC599 File Offset: 0x001CA799
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Select != null)
			{
				this.Select.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E84 RID: 7812
		private QueryExpression _select;
	}
}
