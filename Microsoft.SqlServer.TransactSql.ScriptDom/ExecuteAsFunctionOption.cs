using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001E6 RID: 486
	[Serializable]
	public class ExecuteAsFunctionOption : FunctionOption
	{
		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060029F8 RID: 10744 RVA: 0x001C81CA File Offset: 0x001C63CA
		// (set) Token: 0x060029F9 RID: 10745 RVA: 0x001C81D2 File Offset: 0x001C63D2
		public ExecuteAsClause ExecuteAs
		{
			get
			{
				return this._executeAs;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._executeAs = value;
			}
		}

		// Token: 0x060029FA RID: 10746 RVA: 0x001C81E2 File Offset: 0x001C63E2
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060029FB RID: 10747 RVA: 0x001C81EE File Offset: 0x001C63EE
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.ExecuteAs != null)
			{
				this.ExecuteAs.Accept(visitor);
			}
		}

		// Token: 0x04001D6F RID: 7535
		private ExecuteAsClause _executeAs;
	}
}
