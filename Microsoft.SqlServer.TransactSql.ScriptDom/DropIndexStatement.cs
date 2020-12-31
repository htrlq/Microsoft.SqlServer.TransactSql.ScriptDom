using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200031C RID: 796
	[Serializable]
	public class DropIndexStatement : TSqlStatement
	{
		// Token: 0x17000350 RID: 848
		// (get) Token: 0x0600312D RID: 12589 RVA: 0x001D0109 File Offset: 0x001CE309
		public IList<DropIndexClauseBase> DropIndexClauses
		{
			get
			{
				return this._dropIndexClauses;
			}
		}

		// Token: 0x0600312E RID: 12590 RVA: 0x001D0111 File Offset: 0x001CE311
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600312F RID: 12591 RVA: 0x001D0120 File Offset: 0x001CE320
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.DropIndexClauses.Count;
			while (i < count)
			{
				this.DropIndexClauses[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F7E RID: 8062
		private List<DropIndexClauseBase> _dropIndexClauses = new List<DropIndexClauseBase>();
	}
}
