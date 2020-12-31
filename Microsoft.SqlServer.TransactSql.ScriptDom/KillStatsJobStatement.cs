using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000331 RID: 817
	[Serializable]
	public class KillStatsJobStatement : TSqlStatement
	{
		// Token: 0x17000369 RID: 873
		// (get) Token: 0x0600319A RID: 12698 RVA: 0x001D0789 File Offset: 0x001CE989
		// (set) Token: 0x0600319B RID: 12699 RVA: 0x001D0791 File Offset: 0x001CE991
		public ScalarExpression JobId
		{
			get
			{
				return this._jobId;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._jobId = value;
			}
		}

		// Token: 0x0600319C RID: 12700 RVA: 0x001D07A1 File Offset: 0x001CE9A1
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600319D RID: 12701 RVA: 0x001D07AD File Offset: 0x001CE9AD
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.JobId != null)
			{
				this.JobId.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F97 RID: 8087
		private ScalarExpression _jobId;
	}
}
