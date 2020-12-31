using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000466 RID: 1126
	[Serializable]
	public class TSqlBatch : TSqlFragment
	{
		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x0600392C RID: 14636 RVA: 0x001D80CD File Offset: 0x001D62CD
		public IList<TSqlStatement> Statements
		{
			get
			{
				return this._statements;
			}
		}

		// Token: 0x0600392D RID: 14637 RVA: 0x001D80D5 File Offset: 0x001D62D5
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600392E RID: 14638 RVA: 0x001D80E4 File Offset: 0x001D62E4
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.Statements.Count;
			while (i < count)
			{
				this.Statements[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x040021C6 RID: 8646
		private List<TSqlStatement> _statements = new List<TSqlStatement>();
	}
}
