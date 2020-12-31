using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003EF RID: 1007
	[Serializable]
	public class RollupGroupingSpecification : GroupingSpecification
	{
		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06003679 RID: 13945 RVA: 0x001D56D1 File Offset: 0x001D38D1
		public IList<GroupingSpecification> Arguments
		{
			get
			{
				return this._arguments;
			}
		}

		// Token: 0x0600367A RID: 13946 RVA: 0x001D56D9 File Offset: 0x001D38D9
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600367B RID: 13947 RVA: 0x001D56E8 File Offset: 0x001D38E8
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.Arguments.Count;
			while (i < count)
			{
				this.Arguments[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400210F RID: 8463
		private List<GroupingSpecification> _arguments = new List<GroupingSpecification>();
	}
}
