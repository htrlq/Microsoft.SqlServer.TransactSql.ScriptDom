using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000452 RID: 1106
	[Serializable]
	public class BeginConversationTimerStatement : TSqlStatement
	{
		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x060038BE RID: 14526 RVA: 0x001D7B22 File Offset: 0x001D5D22
		// (set) Token: 0x060038BF RID: 14527 RVA: 0x001D7B2A File Offset: 0x001D5D2A
		public ScalarExpression Handle
		{
			get
			{
				return this._handle;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._handle = value;
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x060038C0 RID: 14528 RVA: 0x001D7B3A File Offset: 0x001D5D3A
		// (set) Token: 0x060038C1 RID: 14529 RVA: 0x001D7B42 File Offset: 0x001D5D42
		public ScalarExpression Timeout
		{
			get
			{
				return this._timeout;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._timeout = value;
			}
		}

		// Token: 0x060038C2 RID: 14530 RVA: 0x001D7B52 File Offset: 0x001D5D52
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060038C3 RID: 14531 RVA: 0x001D7B5E File Offset: 0x001D5D5E
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Handle != null)
			{
				this.Handle.Accept(visitor);
			}
			if (this.Timeout != null)
			{
				this.Timeout.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x040021AB RID: 8619
		private ScalarExpression _handle;

		// Token: 0x040021AC RID: 8620
		private ScalarExpression _timeout;
	}
}
