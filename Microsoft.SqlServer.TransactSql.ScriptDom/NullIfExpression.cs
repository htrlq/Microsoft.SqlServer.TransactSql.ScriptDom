using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200021E RID: 542
	[Serializable]
	public class NullIfExpression : PrimaryExpression
	{
		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06002B27 RID: 11047 RVA: 0x001C9755 File Offset: 0x001C7955
		// (set) Token: 0x06002B28 RID: 11048 RVA: 0x001C975D File Offset: 0x001C795D
		public ScalarExpression FirstExpression
		{
			get
			{
				return this._firstExpression;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._firstExpression = value;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06002B29 RID: 11049 RVA: 0x001C976D File Offset: 0x001C796D
		// (set) Token: 0x06002B2A RID: 11050 RVA: 0x001C9775 File Offset: 0x001C7975
		public ScalarExpression SecondExpression
		{
			get
			{
				return this._secondExpression;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._secondExpression = value;
			}
		}

		// Token: 0x06002B2B RID: 11051 RVA: 0x001C9785 File Offset: 0x001C7985
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002B2C RID: 11052 RVA: 0x001C9791 File Offset: 0x001C7991
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.FirstExpression != null)
			{
				this.FirstExpression.Accept(visitor);
			}
			if (this.SecondExpression != null)
			{
				this.SecondExpression.Accept(visitor);
			}
		}

		// Token: 0x04001DC4 RID: 7620
		private ScalarExpression _firstExpression;

		// Token: 0x04001DC5 RID: 7621
		private ScalarExpression _secondExpression;
	}
}
