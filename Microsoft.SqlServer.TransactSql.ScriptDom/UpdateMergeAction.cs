using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200046B RID: 1131
	[Serializable]
	public class UpdateMergeAction : MergeAction
	{
		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x0600394A RID: 14666 RVA: 0x001D8300 File Offset: 0x001D6500
		public IList<SetClause> SetClauses
		{
			get
			{
				return this._setClauses;
			}
		}

		// Token: 0x0600394B RID: 14667 RVA: 0x001D8308 File Offset: 0x001D6508
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600394C RID: 14668 RVA: 0x001D8314 File Offset: 0x001D6514
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.SetClauses.Count;
			while (i < count)
			{
				this.SetClauses[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x040021CF RID: 8655
		private List<SetClause> _setClauses = new List<SetClause>();
	}
}
