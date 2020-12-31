using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000486 RID: 1158
	[Serializable]
	public class MaxSizeAuditTargetOption : AuditTargetOption
	{
		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x060039CA RID: 14794 RVA: 0x001D8ACB File Offset: 0x001D6CCB
		// (set) Token: 0x060039CB RID: 14795 RVA: 0x001D8AD3 File Offset: 0x001D6CD3
		public bool IsUnlimited
		{
			get
			{
				return this._isUnlimited;
			}
			set
			{
				this._isUnlimited = value;
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x060039CC RID: 14796 RVA: 0x001D8ADC File Offset: 0x001D6CDC
		// (set) Token: 0x060039CD RID: 14797 RVA: 0x001D8AE4 File Offset: 0x001D6CE4
		public Literal Size
		{
			get
			{
				return this._size;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._size = value;
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x060039CE RID: 14798 RVA: 0x001D8AF4 File Offset: 0x001D6CF4
		// (set) Token: 0x060039CF RID: 14799 RVA: 0x001D8AFC File Offset: 0x001D6CFC
		public MemoryUnit Unit
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

		// Token: 0x060039D0 RID: 14800 RVA: 0x001D8B05 File Offset: 0x001D6D05
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060039D1 RID: 14801 RVA: 0x001D8B11 File Offset: 0x001D6D11
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Size != null)
			{
				this.Size.Accept(visitor);
			}
		}

		// Token: 0x040021ED RID: 8685
		private bool _isUnlimited;

		// Token: 0x040021EE RID: 8686
		private Literal _size;

		// Token: 0x040021EF RID: 8687
		private MemoryUnit _unit;
	}
}
