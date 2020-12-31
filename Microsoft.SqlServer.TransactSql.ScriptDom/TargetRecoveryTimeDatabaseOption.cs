using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000362 RID: 866
	[Serializable]
	public class TargetRecoveryTimeDatabaseOption : DatabaseOption
	{
		// Token: 0x170003BA RID: 954
		// (get) Token: 0x060032C4 RID: 12996 RVA: 0x001D17BF File Offset: 0x001CF9BF
		// (set) Token: 0x060032C5 RID: 12997 RVA: 0x001D17C7 File Offset: 0x001CF9C7
		public Literal RecoveryTime
		{
			get
			{
				return this._recoveryTime;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._recoveryTime = value;
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x060032C6 RID: 12998 RVA: 0x001D17D7 File Offset: 0x001CF9D7
		// (set) Token: 0x060032C7 RID: 12999 RVA: 0x001D17DF File Offset: 0x001CF9DF
		public TimeUnit Unit
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

		// Token: 0x060032C8 RID: 13000 RVA: 0x001D17E8 File Offset: 0x001CF9E8
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060032C9 RID: 13001 RVA: 0x001D17F4 File Offset: 0x001CF9F4
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.RecoveryTime != null)
			{
				this.RecoveryTime.Accept(visitor);
			}
		}

		// Token: 0x04001FE8 RID: 8168
		private Literal _recoveryTime;

		// Token: 0x04001FE9 RID: 8169
		private TimeUnit _unit;
	}
}
