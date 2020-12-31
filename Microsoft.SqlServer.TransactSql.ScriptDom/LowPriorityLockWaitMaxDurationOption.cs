using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002DD RID: 733
	[Serializable]
	public class LowPriorityLockWaitMaxDurationOption : LowPriorityLockWaitOption
	{
		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06002FC9 RID: 12233 RVA: 0x001CEA9B File Offset: 0x001CCC9B
		// (set) Token: 0x06002FCA RID: 12234 RVA: 0x001CEAA3 File Offset: 0x001CCCA3
		public Literal MaxDuration
		{
			get
			{
				return this._maxDuration;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._maxDuration = value;
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06002FCB RID: 12235 RVA: 0x001CEAB3 File Offset: 0x001CCCB3
		// (set) Token: 0x06002FCC RID: 12236 RVA: 0x001CEABB File Offset: 0x001CCCBB
		public TimeUnit? Unit
		{
			get
			{
				return this._unit;
			}
			set
			{
				this._unit = value;
			}
		}

		// Token: 0x06002FCD RID: 12237 RVA: 0x001CEAC4 File Offset: 0x001CCCC4
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002FCE RID: 12238 RVA: 0x001CEAD0 File Offset: 0x001CCCD0
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.MaxDuration != null)
			{
				this.MaxDuration.Accept(visitor);
			}
		}

		// Token: 0x04001F1E RID: 7966
		private Literal _maxDuration;

		// Token: 0x04001F1F RID: 7967
		private TimeUnit? _unit;
	}
}
