using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001C0 RID: 448
	[Serializable]
	public class StatementList : TSqlFragment
	{
		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06002914 RID: 10516 RVA: 0x001C7153 File Offset: 0x001C5353
		public IList<TSqlStatement> Statements
		{
			get
			{
				return this._statements;
			}
		}

		// Token: 0x06002915 RID: 10517 RVA: 0x001C715B File Offset: 0x001C535B
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002916 RID: 10518 RVA: 0x001C7168 File Offset: 0x001C5368
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

		// Token: 0x04001D2C RID: 7468
		private List<TSqlStatement> _statements = new List<TSqlStatement>();
	}
}
