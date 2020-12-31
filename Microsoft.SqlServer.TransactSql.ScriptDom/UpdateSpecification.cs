using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200025F RID: 607
	[Serializable]
	public class UpdateSpecification : UpdateDeleteSpecificationBase
	{
		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06002CCF RID: 11471 RVA: 0x001CB5E2 File Offset: 0x001C97E2
		public IList<SetClause> SetClauses
		{
			get
			{
				return this._setClauses;
			}
		}

		// Token: 0x06002CD0 RID: 11472 RVA: 0x001CB5EA File Offset: 0x001C97EA
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002CD1 RID: 11473 RVA: 0x001CB5F8 File Offset: 0x001C97F8
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			int i = 0;
			int count = this.SetClauses.Count;
			while (i < count)
			{
				this.SetClauses[i].Accept(visitor);
				i++;
			}
		}

		// Token: 0x04001E41 RID: 7745
		private List<SetClause> _setClauses = new List<SetClause>();
	}
}
