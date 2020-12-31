using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001D7 RID: 471
	[Serializable]
	public class ExecuteAsTriggerOption : TriggerOption
	{
		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06002998 RID: 10648 RVA: 0x001C7A1C File Offset: 0x001C5C1C
		// (set) Token: 0x06002999 RID: 10649 RVA: 0x001C7A24 File Offset: 0x001C5C24
		public ExecuteAsClause ExecuteAsClause
		{
			get
			{
				return this._executeAsClause;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._executeAsClause = value;
			}
		}

		// Token: 0x0600299A RID: 10650 RVA: 0x001C7A34 File Offset: 0x001C5C34
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600299B RID: 10651 RVA: 0x001C7A40 File Offset: 0x001C5C40
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.ExecuteAsClause != null)
			{
				this.ExecuteAsClause.Accept(visitor);
			}
		}

		// Token: 0x04001D51 RID: 7505
		private ExecuteAsClause _executeAsClause;
	}
}
