using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001D6 RID: 470
	[Serializable]
	public class TriggerOption : TSqlFragment
	{
		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06002993 RID: 10643 RVA: 0x001C79EE File Offset: 0x001C5BEE
		// (set) Token: 0x06002994 RID: 10644 RVA: 0x001C79F6 File Offset: 0x001C5BF6
		public TriggerOptionKind OptionKind
		{
			get
			{
				return this._optionKind;
			}
			set
			{
				this._optionKind = value;
			}
		}

		// Token: 0x06002995 RID: 10645 RVA: 0x001C79FF File Offset: 0x001C5BFF
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002996 RID: 10646 RVA: 0x001C7A0B File Offset: 0x001C5C0B
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001D50 RID: 7504
		private TriggerOptionKind _optionKind;
	}
}
