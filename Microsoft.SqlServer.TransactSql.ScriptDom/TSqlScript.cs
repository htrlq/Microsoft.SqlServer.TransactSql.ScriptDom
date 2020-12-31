using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000465 RID: 1125
	[Serializable]
	public class TSqlScript : TSqlFragment
	{
		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06003928 RID: 14632 RVA: 0x001D8066 File Offset: 0x001D6266
		public IList<TSqlBatch> Batches
		{
			get
			{
				return this._batches;
			}
		}

		// Token: 0x06003929 RID: 14633 RVA: 0x001D806E File Offset: 0x001D626E
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600392A RID: 14634 RVA: 0x001D807C File Offset: 0x001D627C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.Batches.Count;
			while (i < count)
			{
				this.Batches[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x040021C5 RID: 8645
		private List<TSqlBatch> _batches = new List<TSqlBatch>();
	}
}
