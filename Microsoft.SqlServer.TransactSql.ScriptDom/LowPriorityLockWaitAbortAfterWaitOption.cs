using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002DE RID: 734
	[Serializable]
	public class LowPriorityLockWaitAbortAfterWaitOption : LowPriorityLockWaitOption
	{
		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06002FD0 RID: 12240 RVA: 0x001CEAF5 File Offset: 0x001CCCF5
		// (set) Token: 0x06002FD1 RID: 12241 RVA: 0x001CEAFD File Offset: 0x001CCCFD
		public AbortAfterWaitType AbortAfterWait
		{
			get
			{
				return this._abortAfterWait;
			}
			set
			{
				this._abortAfterWait = value;
			}
		}

		// Token: 0x06002FD2 RID: 12242 RVA: 0x001CEB06 File Offset: 0x001CCD06
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002FD3 RID: 12243 RVA: 0x001CEB12 File Offset: 0x001CCD12
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F20 RID: 7968
		private AbortAfterWaitType _abortAfterWait;
	}
}
