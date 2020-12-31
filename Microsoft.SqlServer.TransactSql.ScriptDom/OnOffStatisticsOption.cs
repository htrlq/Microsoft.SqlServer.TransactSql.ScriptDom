using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000304 RID: 772
	[Serializable]
	public class OnOffStatisticsOption : StatisticsOption
	{
		// Token: 0x17000325 RID: 805
		// (get) Token: 0x0600309A RID: 12442 RVA: 0x001CF706 File Offset: 0x001CD906
		// (set) Token: 0x0600309B RID: 12443 RVA: 0x001CF70E File Offset: 0x001CD90E
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

		// Token: 0x0600309C RID: 12444 RVA: 0x001CF717 File Offset: 0x001CD917
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600309D RID: 12445 RVA: 0x001CF723 File Offset: 0x001CD923
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F53 RID: 8019
		private OptionState _optionState;
	}
}
