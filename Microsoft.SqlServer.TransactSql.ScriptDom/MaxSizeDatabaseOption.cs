using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200036E RID: 878
	[Serializable]
	public class MaxSizeDatabaseOption : DatabaseOption
	{
		// Token: 0x170003CC RID: 972
		// (get) Token: 0x0600330A RID: 13066 RVA: 0x001D1B50 File Offset: 0x001CFD50
		// (set) Token: 0x0600330B RID: 13067 RVA: 0x001D1B58 File Offset: 0x001CFD58
		public Literal MaxSize
		{
			get
			{
				return this._maxSize;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._maxSize = value;
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x0600330C RID: 13068 RVA: 0x001D1B68 File Offset: 0x001CFD68
		// (set) Token: 0x0600330D RID: 13069 RVA: 0x001D1B70 File Offset: 0x001CFD70
		public MemoryUnit Units
		{
			get
			{
				return this._units;
			}
			set
			{
				this._units = value;
			}
		}

		// Token: 0x0600330E RID: 13070 RVA: 0x001D1B79 File Offset: 0x001CFD79
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600330F RID: 13071 RVA: 0x001D1B85 File Offset: 0x001CFD85
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.MaxSize != null)
			{
				this.MaxSize.Accept(visitor);
			}
		}

		// Token: 0x04001FFA RID: 8186
		private Literal _maxSize;

		// Token: 0x04001FFB RID: 8187
		private MemoryUnit _units;
	}
}
