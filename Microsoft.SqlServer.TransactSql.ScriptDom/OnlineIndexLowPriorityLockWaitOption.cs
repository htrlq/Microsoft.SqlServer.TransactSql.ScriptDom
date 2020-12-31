using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002DB RID: 731
	[Serializable]
	public class OnlineIndexLowPriorityLockWaitOption : TSqlFragment
	{
		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06002FC1 RID: 12225 RVA: 0x001CEA12 File Offset: 0x001CCC12
		public IList<LowPriorityLockWaitOption> Options
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x06002FC2 RID: 12226 RVA: 0x001CEA1A File Offset: 0x001CCC1A
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002FC3 RID: 12227 RVA: 0x001CEA28 File Offset: 0x001CCC28
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.Options.Count;
			while (i < count)
			{
				this.Options[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F1C RID: 7964
		private List<LowPriorityLockWaitOption> _options = new List<LowPriorityLockWaitOption>();
	}
}
