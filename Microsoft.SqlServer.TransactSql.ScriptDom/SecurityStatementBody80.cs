using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000270 RID: 624
	[Serializable]
	public abstract class SecurityStatementBody80 : TSqlStatement
	{
		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06002D50 RID: 11600 RVA: 0x001CC050 File Offset: 0x001CA250
		// (set) Token: 0x06002D51 RID: 11601 RVA: 0x001CC058 File Offset: 0x001CA258
		public SecurityElement80 SecurityElement80
		{
			get
			{
				return this._securityElement80;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._securityElement80 = value;
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06002D52 RID: 11602 RVA: 0x001CC068 File Offset: 0x001CA268
		// (set) Token: 0x06002D53 RID: 11603 RVA: 0x001CC070 File Offset: 0x001CA270
		public SecurityUserClause80 SecurityUserClause80
		{
			get
			{
				return this._securityUserClause80;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._securityUserClause80 = value;
			}
		}

		// Token: 0x06002D54 RID: 11604 RVA: 0x001CC080 File Offset: 0x001CA280
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.SecurityElement80 != null)
			{
				this.SecurityElement80.Accept(visitor);
			}
			if (this.SecurityUserClause80 != null)
			{
				this.SecurityUserClause80.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E6C RID: 7788
		private SecurityElement80 _securityElement80;

		// Token: 0x04001E6D RID: 7789
		private SecurityUserClause80 _securityUserClause80;
	}
}
