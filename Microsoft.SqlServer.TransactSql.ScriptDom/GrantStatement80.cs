using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000271 RID: 625
	[Serializable]
	public class GrantStatement80 : SecurityStatementBody80
	{
		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06002D56 RID: 11606 RVA: 0x001CC0B9 File Offset: 0x001CA2B9
		// (set) Token: 0x06002D57 RID: 11607 RVA: 0x001CC0C1 File Offset: 0x001CA2C1
		public bool WithGrantOption
		{
			get
			{
				return this._withGrantOption;
			}
			set
			{
				this._withGrantOption = value;
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06002D58 RID: 11608 RVA: 0x001CC0CA File Offset: 0x001CA2CA
		// (set) Token: 0x06002D59 RID: 11609 RVA: 0x001CC0D2 File Offset: 0x001CA2D2
		public Identifier AsClause
		{
			get
			{
				return this._asClause;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._asClause = value;
			}
		}

		// Token: 0x06002D5A RID: 11610 RVA: 0x001CC0E2 File Offset: 0x001CA2E2
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002D5B RID: 11611 RVA: 0x001CC0EE File Offset: 0x001CA2EE
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.AsClause != null)
			{
				this.AsClause.Accept(visitor);
			}
		}

		// Token: 0x04001E6E RID: 7790
		private bool _withGrantOption;

		// Token: 0x04001E6F RID: 7791
		private Identifier _asClause;
	}
}
