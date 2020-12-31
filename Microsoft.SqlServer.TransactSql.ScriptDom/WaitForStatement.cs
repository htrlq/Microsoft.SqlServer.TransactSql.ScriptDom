using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000261 RID: 609
	[Serializable]
	public class WaitForStatement : TSqlStatement
	{
		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06002CDC RID: 11484 RVA: 0x001CB6F8 File Offset: 0x001C98F8
		// (set) Token: 0x06002CDD RID: 11485 RVA: 0x001CB700 File Offset: 0x001C9900
		public WaitForOption WaitForOption
		{
			get
			{
				return this._waitForOption;
			}
			set
			{
				this._waitForOption = value;
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06002CDE RID: 11486 RVA: 0x001CB709 File Offset: 0x001C9909
		// (set) Token: 0x06002CDF RID: 11487 RVA: 0x001CB711 File Offset: 0x001C9911
		public ValueExpression Parameter
		{
			get
			{
				return this._parameter;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._parameter = value;
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06002CE0 RID: 11488 RVA: 0x001CB721 File Offset: 0x001C9921
		// (set) Token: 0x06002CE1 RID: 11489 RVA: 0x001CB729 File Offset: 0x001C9929
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

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06002CE2 RID: 11490 RVA: 0x001CB739 File Offset: 0x001C9939
		// (set) Token: 0x06002CE3 RID: 11491 RVA: 0x001CB741 File Offset: 0x001C9941
		public WaitForSupportedStatement Statement
		{
			get
			{
				return this._statement;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._statement = value;
			}
		}

		// Token: 0x06002CE4 RID: 11492 RVA: 0x001CB751 File Offset: 0x001C9951
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002CE5 RID: 11493 RVA: 0x001CB760 File Offset: 0x001C9960
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Parameter != null)
			{
				this.Parameter.Accept(visitor);
			}
			if (this.Timeout != null)
			{
				this.Timeout.Accept(visitor);
			}
			if (this.Statement != null)
			{
				this.Statement.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E45 RID: 7749
		private WaitForOption _waitForOption;

		// Token: 0x04001E46 RID: 7750
		private ValueExpression _parameter;

		// Token: 0x04001E47 RID: 7751
		private ScalarExpression _timeout;

		// Token: 0x04001E48 RID: 7752
		private WaitForSupportedStatement _statement;
	}
}
