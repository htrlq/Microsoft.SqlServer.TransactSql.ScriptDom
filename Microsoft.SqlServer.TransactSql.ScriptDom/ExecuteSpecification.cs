using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001C9 RID: 457
	[Serializable]
	public class ExecuteSpecification : TSqlFragment
	{
		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06002940 RID: 10560 RVA: 0x001C7453 File Offset: 0x001C5653
		// (set) Token: 0x06002941 RID: 10561 RVA: 0x001C745B File Offset: 0x001C565B
		public VariableReference Variable
		{
			get
			{
				return this._variable;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._variable = value;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06002942 RID: 10562 RVA: 0x001C746B File Offset: 0x001C566B
		// (set) Token: 0x06002943 RID: 10563 RVA: 0x001C7473 File Offset: 0x001C5673
		public Identifier LinkedServer
		{
			get
			{
				return this._linkedServer;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._linkedServer = value;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06002944 RID: 10564 RVA: 0x001C7483 File Offset: 0x001C5683
		// (set) Token: 0x06002945 RID: 10565 RVA: 0x001C748B File Offset: 0x001C568B
		public ExecuteContext ExecuteContext
		{
			get
			{
				return this._executeContext;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._executeContext = value;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06002946 RID: 10566 RVA: 0x001C749B File Offset: 0x001C569B
		// (set) Token: 0x06002947 RID: 10567 RVA: 0x001C74A3 File Offset: 0x001C56A3
		public ExecutableEntity ExecutableEntity
		{
			get
			{
				return this._executableEntity;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._executableEntity = value;
			}
		}

		// Token: 0x06002948 RID: 10568 RVA: 0x001C74B3 File Offset: 0x001C56B3
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002949 RID: 10569 RVA: 0x001C74C0 File Offset: 0x001C56C0
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Variable != null)
			{
				this.Variable.Accept(visitor);
			}
			if (this.LinkedServer != null)
			{
				this.LinkedServer.Accept(visitor);
			}
			if (this.ExecuteContext != null)
			{
				this.ExecuteContext.Accept(visitor);
			}
			if (this.ExecutableEntity != null)
			{
				this.ExecutableEntity.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001D37 RID: 7479
		private VariableReference _variable;

		// Token: 0x04001D38 RID: 7480
		private Identifier _linkedServer;

		// Token: 0x04001D39 RID: 7481
		private ExecuteContext _executeContext;

		// Token: 0x04001D3A RID: 7482
		private ExecutableEntity _executableEntity;
	}
}
