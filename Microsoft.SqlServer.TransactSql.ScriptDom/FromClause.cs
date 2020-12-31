using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003FD RID: 1021
	[Serializable]
	public class FromClause : TSqlFragment
	{
		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x060036D1 RID: 14033 RVA: 0x001D5D91 File Offset: 0x001D3F91
		public IList<TableReference> TableReferences
		{
			get
			{
				return this._tableReferences;
			}
		}

		// Token: 0x060036D2 RID: 14034 RVA: 0x001D5D99 File Offset: 0x001D3F99
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060036D3 RID: 14035 RVA: 0x001D5DA8 File Offset: 0x001D3FA8
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.TableReferences.Count;
			while (i < count)
			{
				this.TableReferences[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400212A RID: 8490
		private List<TableReference> _tableReferences = new List<TableReference>();
	}
}
