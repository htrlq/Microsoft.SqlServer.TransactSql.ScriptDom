using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002DA RID: 730
	[Serializable]
	public class OnlineIndexOption : IndexStateOption
	{
		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06002FBC RID: 12220 RVA: 0x001CE9C9 File Offset: 0x001CCBC9
		// (set) Token: 0x06002FBD RID: 12221 RVA: 0x001CE9D1 File Offset: 0x001CCBD1
		public OnlineIndexLowPriorityLockWaitOption LowPriorityLockWaitOption
		{
			get
			{
				return this._lowPriorityLockWaitOption;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._lowPriorityLockWaitOption = value;
			}
		}

		// Token: 0x06002FBE RID: 12222 RVA: 0x001CE9E1 File Offset: 0x001CCBE1
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002FBF RID: 12223 RVA: 0x001CE9ED File Offset: 0x001CCBED
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.LowPriorityLockWaitOption != null)
			{
				this.LowPriorityLockWaitOption.Accept(visitor);
			}
		}

		// Token: 0x04001F1B RID: 7963
		private OnlineIndexLowPriorityLockWaitOption _lowPriorityLockWaitOption;
	}
}
