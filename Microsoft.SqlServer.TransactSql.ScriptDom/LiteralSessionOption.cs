using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004B2 RID: 1202
	[Serializable]
	public class LiteralSessionOption : SessionOption
	{
		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06003AC3 RID: 15043 RVA: 0x001D99E7 File Offset: 0x001D7BE7
		// (set) Token: 0x06003AC4 RID: 15044 RVA: 0x001D99EF File Offset: 0x001D7BEF
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

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06003AC5 RID: 15045 RVA: 0x001D99FF File Offset: 0x001D7BFF
		// (set) Token: 0x06003AC6 RID: 15046 RVA: 0x001D9A07 File Offset: 0x001D7C07
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

		// Token: 0x06003AC7 RID: 15047 RVA: 0x001D9A10 File Offset: 0x001D7C10
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003AC8 RID: 15048 RVA: 0x001D9A1C File Offset: 0x001D7C1C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Value != null)
			{
				this.Value.Accept(visitor);
			}
		}

		// Token: 0x0400222F RID: 8751
		private Literal _value;

		// Token: 0x04002230 RID: 8752
		private MemoryUnit _unit;
	}
}
