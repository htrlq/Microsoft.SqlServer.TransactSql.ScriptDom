using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003D4 RID: 980
	[Serializable]
	public class OnOffFullTextCatalogOption : FullTextCatalogOption
	{
		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x060035C7 RID: 13767 RVA: 0x001D4A1B File Offset: 0x001D2C1B
		// (set) Token: 0x060035C8 RID: 13768 RVA: 0x001D4A23 File Offset: 0x001D2C23
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

		// Token: 0x060035C9 RID: 13769 RVA: 0x001D4A2C File Offset: 0x001D2C2C
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060035CA RID: 13770 RVA: 0x001D4A38 File Offset: 0x001D2C38
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x040020D8 RID: 8408
		private OptionState _optionState;
	}
}
