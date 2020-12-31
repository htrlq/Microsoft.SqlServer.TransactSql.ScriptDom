using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003EA RID: 1002
	[Serializable]
	public class GroupByClause : TSqlFragment
	{
		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06003662 RID: 13922 RVA: 0x001D5521 File Offset: 0x001D3721
		// (set) Token: 0x06003663 RID: 13923 RVA: 0x001D5529 File Offset: 0x001D3729
		public GroupByOption GroupByOption
		{
			get
			{
				return this._groupByOption;
			}
			set
			{
				this._groupByOption = value;
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06003664 RID: 13924 RVA: 0x001D5532 File Offset: 0x001D3732
		// (set) Token: 0x06003665 RID: 13925 RVA: 0x001D553A File Offset: 0x001D373A
		public bool All
		{
			get
			{
				return this._all;
			}
			set
			{
				this._all = value;
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06003666 RID: 13926 RVA: 0x001D5543 File Offset: 0x001D3743
		public IList<GroupingSpecification> GroupingSpecifications
		{
			get
			{
				return this._groupingSpecifications;
			}
		}

		// Token: 0x06003667 RID: 13927 RVA: 0x001D554B File Offset: 0x001D374B
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003668 RID: 13928 RVA: 0x001D5558 File Offset: 0x001D3758
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.GroupingSpecifications.Count;
			while (i < count)
			{
				this.GroupingSpecifications[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002109 RID: 8457
		private GroupByOption _groupByOption;

		// Token: 0x0400210A RID: 8458
		private bool _all;

		// Token: 0x0400210B RID: 8459
		private List<GroupingSpecification> _groupingSpecifications = new List<GroupingSpecification>();
	}
}
