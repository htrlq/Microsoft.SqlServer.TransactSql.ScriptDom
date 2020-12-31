using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000213 RID: 531
	[Serializable]
	public class LiteralOptimizerHint : OptimizerHint
	{
		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06002AEB RID: 10987 RVA: 0x001C92E3 File Offset: 0x001C74E3
		// (set) Token: 0x06002AEC RID: 10988 RVA: 0x001C92EB File Offset: 0x001C74EB
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

		// Token: 0x06002AED RID: 10989 RVA: 0x001C92FB File Offset: 0x001C74FB
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002AEE RID: 10990 RVA: 0x001C9307 File Offset: 0x001C7507
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Value != null)
			{
				this.Value.Accept(visitor);
			}
		}

		// Token: 0x04001DB3 RID: 7603
		private Literal _value;
	}
}
