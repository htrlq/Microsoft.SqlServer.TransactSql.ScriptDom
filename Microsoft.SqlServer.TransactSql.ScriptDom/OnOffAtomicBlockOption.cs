using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000244 RID: 580
	[Serializable]
	public class OnOffAtomicBlockOption : AtomicBlockOption
	{
		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06002C38 RID: 11320 RVA: 0x001CAC52 File Offset: 0x001C8E52
		// (set) Token: 0x06002C39 RID: 11321 RVA: 0x001CAC5A File Offset: 0x001C8E5A
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

		// Token: 0x06002C3A RID: 11322 RVA: 0x001CAC63 File Offset: 0x001C8E63
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002C3B RID: 11323 RVA: 0x001CAC6F File Offset: 0x001C8E6F
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E1B RID: 7707
		private OptionState _optionState;
	}
}
