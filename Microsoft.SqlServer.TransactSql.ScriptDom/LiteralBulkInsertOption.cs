using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000391 RID: 913
	[Serializable]
	public class LiteralBulkInsertOption : BulkInsertOption
	{
		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06003414 RID: 13332 RVA: 0x001D2E2F File Offset: 0x001D102F
		// (set) Token: 0x06003415 RID: 13333 RVA: 0x001D2E37 File Offset: 0x001D1037
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

		// Token: 0x06003416 RID: 13334 RVA: 0x001D2E47 File Offset: 0x001D1047
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003417 RID: 13335 RVA: 0x001D2E53 File Offset: 0x001D1053
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Value != null)
			{
				this.Value.Accept(visitor);
			}
		}

		// Token: 0x04002055 RID: 8277
		private Literal _value;
	}
}
