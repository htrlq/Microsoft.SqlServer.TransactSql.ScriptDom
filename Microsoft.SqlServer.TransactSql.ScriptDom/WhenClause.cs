using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000218 RID: 536
	[Serializable]
	public abstract class WhenClause : TSqlFragment
	{
		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06002B0B RID: 11019 RVA: 0x001C954F File Offset: 0x001C774F
		// (set) Token: 0x06002B0C RID: 11020 RVA: 0x001C9557 File Offset: 0x001C7757
		public ScalarExpression ThenExpression
		{
			get
			{
				return this._thenExpression;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._thenExpression = value;
			}
		}

		// Token: 0x06002B0D RID: 11021 RVA: 0x001C9567 File Offset: 0x001C7767
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.ThenExpression != null)
			{
				this.ThenExpression.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001DBD RID: 7613
		private ScalarExpression _thenExpression;
	}
}
