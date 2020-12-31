using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002B3 RID: 691
	[Serializable]
	public class LowPriorityLockWaitTableSwitchOption : TableSwitchOption
	{
		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06002EBE RID: 11966 RVA: 0x001CD708 File Offset: 0x001CB908
		public IList<LowPriorityLockWaitOption> Options
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x06002EBF RID: 11967 RVA: 0x001CD710 File Offset: 0x001CB910
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002EC0 RID: 11968 RVA: 0x001CD71C File Offset: 0x001CB91C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			int i = 0;
			int count = this.Options.Count;
			while (i < count)
			{
				this.Options[i].Accept(visitor);
				i++;
			}
		}

		// Token: 0x04001ECC RID: 7884
		private List<LowPriorityLockWaitOption> _options = new List<LowPriorityLockWaitOption>();
	}
}
