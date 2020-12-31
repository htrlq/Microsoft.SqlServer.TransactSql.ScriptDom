using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001CA RID: 458
	[Serializable]
	public class ExecuteContext : TSqlFragment
	{
		// Token: 0x1700010D RID: 269
		// (get) Token: 0x0600294B RID: 10571 RVA: 0x001C752C File Offset: 0x001C572C
		// (set) Token: 0x0600294C RID: 10572 RVA: 0x001C7534 File Offset: 0x001C5734
		public ScalarExpression Principal
		{
			get
			{
				return this._principal;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._principal = value;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x0600294D RID: 10573 RVA: 0x001C7544 File Offset: 0x001C5744
		// (set) Token: 0x0600294E RID: 10574 RVA: 0x001C754C File Offset: 0x001C574C
		public ExecuteAsOption Kind
		{
			get
			{
				return this._kind;
			}
			set
			{
				this._kind = value;
			}
		}

		// Token: 0x0600294F RID: 10575 RVA: 0x001C7555 File Offset: 0x001C5755
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002950 RID: 10576 RVA: 0x001C7561 File Offset: 0x001C5761
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Principal != null)
			{
				this.Principal.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001D3B RID: 7483
		private ScalarExpression _principal;

		// Token: 0x04001D3C RID: 7484
		private ExecuteAsOption _kind;
	}
}
