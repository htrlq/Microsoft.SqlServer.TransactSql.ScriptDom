using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000431 RID: 1073
	[Serializable]
	public class OnOffPrincipalOption : PrincipalOption
	{
		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x060037F2 RID: 14322 RVA: 0x001D6E73 File Offset: 0x001D5073
		// (set) Token: 0x060037F3 RID: 14323 RVA: 0x001D6E7B File Offset: 0x001D507B
		public OptionState OptionState
		{
			get
			{
				return this._optionState;
			}
			set
			{
				this._optionState = value;
			}
		}

		// Token: 0x060037F4 RID: 14324 RVA: 0x001D6E84 File Offset: 0x001D5084
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060037F5 RID: 14325 RVA: 0x001D6E90 File Offset: 0x001D5090
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002172 RID: 8562
		private OptionState _optionState;
	}
}
