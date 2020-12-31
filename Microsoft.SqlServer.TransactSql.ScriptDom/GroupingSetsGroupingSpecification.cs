using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003F1 RID: 1009
	[Serializable]
	public class GroupingSetsGroupingSpecification : GroupingSpecification
	{
		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06003680 RID: 13952 RVA: 0x001D5756 File Offset: 0x001D3956
		public IList<GroupingSpecification> Sets
		{
			get
			{
				return this._sets;
			}
		}

		// Token: 0x06003681 RID: 13953 RVA: 0x001D575E File Offset: 0x001D395E
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003682 RID: 13954 RVA: 0x001D576C File Offset: 0x001D396C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.Sets.Count;
			while (i < count)
			{
				this.Sets[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002110 RID: 8464
		private List<GroupingSpecification> _sets = new List<GroupingSpecification>();
	}
}
