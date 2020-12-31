using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004D2 RID: 1234
	[Serializable]
	public class LiteralReplicaOption : AvailabilityReplicaOption
	{
		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06003B77 RID: 15223 RVA: 0x001DA5A7 File Offset: 0x001D87A7
		// (set) Token: 0x06003B78 RID: 15224 RVA: 0x001DA5AF File Offset: 0x001D87AF
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

		// Token: 0x06003B79 RID: 15225 RVA: 0x001DA5BF File Offset: 0x001D87BF
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003B7A RID: 15226 RVA: 0x001DA5CB File Offset: 0x001D87CB
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Value != null)
			{
				this.Value.Accept(visitor);
			}
		}

		// Token: 0x04002262 RID: 8802
		private Literal _value;
	}
}
