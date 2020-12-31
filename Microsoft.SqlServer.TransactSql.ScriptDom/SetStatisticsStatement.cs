using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000339 RID: 825
	[Serializable]
	public class SetStatisticsStatement : SetOnOffStatement
	{
		// Token: 0x17000372 RID: 882
		// (get) Token: 0x060031C3 RID: 12739 RVA: 0x001D096A File Offset: 0x001CEB6A
		// (set) Token: 0x060031C4 RID: 12740 RVA: 0x001D0972 File Offset: 0x001CEB72
		public SetStatisticsOptions Options
		{
			get
			{
				return this._options;
			}
			set
			{
				this._options = value;
			}
		}

		// Token: 0x060031C5 RID: 12741 RVA: 0x001D097B File Offset: 0x001CEB7B
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060031C6 RID: 12742 RVA: 0x001D0987 File Offset: 0x001CEB87
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001FA0 RID: 8096
		private SetStatisticsOptions _options;
	}
}
