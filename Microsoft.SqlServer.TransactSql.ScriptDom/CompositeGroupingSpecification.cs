using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003ED RID: 1005
	[Serializable]
	public class CompositeGroupingSpecification : GroupingSpecification
	{
		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06003671 RID: 13937 RVA: 0x001D5603 File Offset: 0x001D3803
		public IList<GroupingSpecification> Items
		{
			get
			{
				return this._items;
			}
		}

		// Token: 0x06003672 RID: 13938 RVA: 0x001D560B File Offset: 0x001D380B
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003673 RID: 13939 RVA: 0x001D5618 File Offset: 0x001D3818
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.Items.Count;
			while (i < count)
			{
				this.Items[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400210D RID: 8461
		private List<GroupingSpecification> _items = new List<GroupingSpecification>();
	}
}
