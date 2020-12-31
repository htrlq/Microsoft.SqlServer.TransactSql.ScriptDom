using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000488 RID: 1160
	[Serializable]
	public class LiteralAuditTargetOption : AuditTargetOption
	{
		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x060039DA RID: 14810 RVA: 0x001D8B90 File Offset: 0x001D6D90
		// (set) Token: 0x060039DB RID: 14811 RVA: 0x001D8B98 File Offset: 0x001D6D98
		public Literal Value
		{
			get
			{
				return this._value;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._value = value;
			}
		}

		// Token: 0x060039DC RID: 14812 RVA: 0x001D8BA8 File Offset: 0x001D6DA8
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060039DD RID: 14813 RVA: 0x001D8BB4 File Offset: 0x001D6DB4
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Value != null)
			{
				this.Value.Accept(visitor);
			}
		}

		// Token: 0x040021F2 RID: 8690
		private Literal _value;
	}
}
