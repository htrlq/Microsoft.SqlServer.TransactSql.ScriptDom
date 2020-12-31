using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003EE RID: 1006
	[Serializable]
	public class CubeGroupingSpecification : GroupingSpecification
	{
		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06003675 RID: 13941 RVA: 0x001D5669 File Offset: 0x001D3869
		public IList<GroupingSpecification> Arguments
		{
			get
			{
				return this._arguments;
			}
		}

		// Token: 0x06003676 RID: 13942 RVA: 0x001D5671 File Offset: 0x001D3871
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003677 RID: 13943 RVA: 0x001D5680 File Offset: 0x001D3880
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

		// Token: 0x0400210E RID: 8462
		private List<GroupingSpecification> _arguments = new List<GroupingSpecification>();
	}
}
