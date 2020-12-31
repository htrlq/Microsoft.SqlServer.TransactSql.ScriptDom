using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003F7 RID: 1015
	[Serializable]
	public class OrderByClause : TSqlFragment
	{
		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x060036A2 RID: 13986 RVA: 0x001D5A35 File Offset: 0x001D3C35
		public IList<ExpressionWithSortOrder> OrderByElements
		{
			get
			{
				return this._orderByElements;
			}
		}

		// Token: 0x060036A3 RID: 13987 RVA: 0x001D5A3D File Offset: 0x001D3C3D
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060036A4 RID: 13988 RVA: 0x001D5A4C File Offset: 0x001D3C4C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.OrderByElements.Count;
			while (i < count)
			{
				this.OrderByElements[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400211A RID: 8474
		private List<ExpressionWithSortOrder> _orderByElements = new List<ExpressionWithSortOrder>();
	}
}
