using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200021D RID: 541
	[Serializable]
	public class SearchedCaseExpression : CaseExpression
	{
		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06002B23 RID: 11043 RVA: 0x001C96ED File Offset: 0x001C78ED
		public IList<SearchedWhenClause> WhenClauses
		{
			get
			{
				return this._whenClauses;
			}
		}

		// Token: 0x06002B24 RID: 11044 RVA: 0x001C96F5 File Offset: 0x001C78F5
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002B25 RID: 11045 RVA: 0x001C9704 File Offset: 0x001C7904
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.WhenClauses.Count;
			while (i < count)
			{
				this.WhenClauses[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001DC3 RID: 7619
		private List<SearchedWhenClause> _whenClauses = new List<SearchedWhenClause>();
	}
}
