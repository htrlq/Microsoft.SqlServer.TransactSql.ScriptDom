using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003E2 RID: 994
	[Serializable]
	public class UnqualifiedJoin : JoinTableReference
	{
		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06003628 RID: 13864 RVA: 0x001D520A File Offset: 0x001D340A
		// (set) Token: 0x06003629 RID: 13865 RVA: 0x001D5212 File Offset: 0x001D3412
		public UnqualifiedJoinType UnqualifiedJoinType
		{
			get
			{
				return this._unqualifiedJoinType;
			}
			set
			{
				this._unqualifiedJoinType = value;
			}
		}

		// Token: 0x0600362A RID: 13866 RVA: 0x001D521B File Offset: 0x001D341B
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600362B RID: 13867 RVA: 0x001D5227 File Offset: 0x001D3427
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x040020F8 RID: 8440
		private UnqualifiedJoinType _unqualifiedJoinType;
	}
}
