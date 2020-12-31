using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000372 RID: 882
	[Serializable]
	public class IdentityOptions : TSqlFragment
	{
		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06003339 RID: 13113 RVA: 0x001D1EB5 File Offset: 0x001D00B5
		// (set) Token: 0x0600333A RID: 13114 RVA: 0x001D1EBD File Offset: 0x001D00BD
		public ScalarExpression IdentitySeed
		{
			get
			{
				return this._identitySeed;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._identitySeed = value;
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x0600333B RID: 13115 RVA: 0x001D1ECD File Offset: 0x001D00CD
		// (set) Token: 0x0600333C RID: 13116 RVA: 0x001D1ED5 File Offset: 0x001D00D5
		public ScalarExpression IdentityIncrement
		{
			get
			{
				return this._identityIncrement;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._identityIncrement = value;
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x0600333D RID: 13117 RVA: 0x001D1EE5 File Offset: 0x001D00E5
		// (set) Token: 0x0600333E RID: 13118 RVA: 0x001D1EED File Offset: 0x001D00ED
		public bool IsIdentityNotForReplication
		{
			get
			{
				return this._isIdentityNotForReplication;
			}
			set
			{
				this._isIdentityNotForReplication = value;
			}
		}

		// Token: 0x0600333F RID: 13119 RVA: 0x001D1EF6 File Offset: 0x001D00F6
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003340 RID: 13120 RVA: 0x001D1F02 File Offset: 0x001D0102
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.IdentitySeed != null)
			{
				this.IdentitySeed.Accept(visitor);
			}
			if (this.IdentityIncrement != null)
			{
				this.IdentityIncrement.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400200C RID: 8204
		private ScalarExpression _identitySeed;

		// Token: 0x0400200D RID: 8205
		private ScalarExpression _identityIncrement;

		// Token: 0x0400200E RID: 8206
		private bool _isIdentityNotForReplication;
	}
}
