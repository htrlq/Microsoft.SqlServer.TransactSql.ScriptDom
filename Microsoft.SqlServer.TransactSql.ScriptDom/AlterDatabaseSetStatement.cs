using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000358 RID: 856
	[Serializable]
	public class AlterDatabaseSetStatement : AlterDatabaseStatement
	{
		// Token: 0x170003AE RID: 942
		// (get) Token: 0x0600328F RID: 12943 RVA: 0x001D1563 File Offset: 0x001CF763
		// (set) Token: 0x06003290 RID: 12944 RVA: 0x001D156B File Offset: 0x001CF76B
		public AlterDatabaseTermination Termination
		{
			get
			{
				return this._termination;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._termination = value;
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06003291 RID: 12945 RVA: 0x001D157B File Offset: 0x001CF77B
		public IList<DatabaseOption> Options
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x06003292 RID: 12946 RVA: 0x001D1583 File Offset: 0x001CF783
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003293 RID: 12947 RVA: 0x001D1590 File Offset: 0x001CF790
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Termination != null)
			{
				this.Termination.Accept(visitor);
			}
			int i = 0;
			int count = this.Options.Count;
			while (i < count)
			{
				this.Options[i].Accept(visitor);
				i++;
			}
		}

		// Token: 0x04001FDC RID: 8156
		private AlterDatabaseTermination _termination;

		// Token: 0x04001FDD RID: 8157
		private List<DatabaseOption> _options = new List<DatabaseOption>();
	}
}
