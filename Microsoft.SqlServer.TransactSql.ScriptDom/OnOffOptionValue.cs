using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000288 RID: 648
	[Serializable]
	public class OnOffOptionValue : OptionValue
	{
		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06002DD1 RID: 11729 RVA: 0x001CC828 File Offset: 0x001CAA28
		// (set) Token: 0x06002DD2 RID: 11730 RVA: 0x001CC830 File Offset: 0x001CAA30
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

		// Token: 0x06002DD3 RID: 11731 RVA: 0x001CC839 File Offset: 0x001CAA39
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002DD4 RID: 11732 RVA: 0x001CC845 File Offset: 0x001CAA45
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E8E RID: 7822
		private OptionState _optionState;
	}
}
