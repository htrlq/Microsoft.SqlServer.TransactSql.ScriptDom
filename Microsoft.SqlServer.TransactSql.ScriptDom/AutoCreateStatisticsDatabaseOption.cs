using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200035B RID: 859
	[Serializable]
	public class AutoCreateStatisticsDatabaseOption : OnOffDatabaseOption
	{
		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x0600329F RID: 12959 RVA: 0x001D1651 File Offset: 0x001CF851
		// (set) Token: 0x060032A0 RID: 12960 RVA: 0x001D1659 File Offset: 0x001CF859
		public bool HasIncremental
		{
			get
			{
				return this._hasIncremental;
			}
			set
			{
				this._hasIncremental = value;
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x060032A1 RID: 12961 RVA: 0x001D1662 File Offset: 0x001CF862
		// (set) Token: 0x060032A2 RID: 12962 RVA: 0x001D166A File Offset: 0x001CF86A
		public OptionState IncrementalState
		{
			get
			{
				return this._incrementalState;
			}
			set
			{
				this._incrementalState = value;
			}
		}

		// Token: 0x060032A3 RID: 12963 RVA: 0x001D1673 File Offset: 0x001CF873
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060032A4 RID: 12964 RVA: 0x001D167F File Offset: 0x001CF87F
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001FE0 RID: 8160
		private bool _hasIncremental;

		// Token: 0x04001FE1 RID: 8161
		private OptionState _incrementalState;
	}
}
