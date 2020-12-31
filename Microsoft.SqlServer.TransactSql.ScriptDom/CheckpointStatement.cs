using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000332 RID: 818
	[Serializable]
	public class CheckpointStatement : TSqlStatement
	{
		// Token: 0x1700036A RID: 874
		// (get) Token: 0x0600319F RID: 12703 RVA: 0x001D07D2 File Offset: 0x001CE9D2
		// (set) Token: 0x060031A0 RID: 12704 RVA: 0x001D07DA File Offset: 0x001CE9DA
		public Literal Duration
		{
			get
			{
				return this._duration;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._duration = value;
			}
		}

		// Token: 0x060031A1 RID: 12705 RVA: 0x001D07EA File Offset: 0x001CE9EA
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060031A2 RID: 12706 RVA: 0x001D07F6 File Offset: 0x001CE9F6
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Duration != null)
			{
				this.Duration.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F98 RID: 8088
		private Literal _duration;
	}
}
