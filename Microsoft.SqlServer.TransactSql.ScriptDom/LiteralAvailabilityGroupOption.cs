using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004D8 RID: 1240
	[Serializable]
	public class LiteralAvailabilityGroupOption : AvailabilityGroupOption
	{
		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06003B94 RID: 15252 RVA: 0x001DA6CA File Offset: 0x001D88CA
		// (set) Token: 0x06003B95 RID: 15253 RVA: 0x001DA6D2 File Offset: 0x001D88D2
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

		// Token: 0x06003B96 RID: 15254 RVA: 0x001DA6E2 File Offset: 0x001D88E2
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003B97 RID: 15255 RVA: 0x001DA6EE File Offset: 0x001D88EE
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Value != null)
			{
				this.Value.Accept(visitor);
			}
		}

		// Token: 0x04002268 RID: 8808
		private Literal _value;
	}
}
