using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000273 RID: 627
	[Serializable]
	public class RevokeStatement80 : SecurityStatementBody80
	{
		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06002D62 RID: 11618 RVA: 0x001CC141 File Offset: 0x001CA341
		// (set) Token: 0x06002D63 RID: 11619 RVA: 0x001CC149 File Offset: 0x001CA349
		public bool GrantOptionFor
		{
			get
			{
				return this._grantOptionFor;
			}
			set
			{
				this._grantOptionFor = value;
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06002D64 RID: 11620 RVA: 0x001CC152 File Offset: 0x001CA352
		// (set) Token: 0x06002D65 RID: 11621 RVA: 0x001CC15A File Offset: 0x001CA35A
		public bool CascadeOption
		{
			get
			{
				return this._cascadeOption;
			}
			set
			{
				this._cascadeOption = value;
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06002D66 RID: 11622 RVA: 0x001CC163 File Offset: 0x001CA363
		// (set) Token: 0x06002D67 RID: 11623 RVA: 0x001CC16B File Offset: 0x001CA36B
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

		// Token: 0x06002D68 RID: 11624 RVA: 0x001CC17B File Offset: 0x001CA37B
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002D69 RID: 11625 RVA: 0x001CC187 File Offset: 0x001CA387
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.AsClause != null)
			{
				this.AsClause.Accept(visitor);
			}
		}

		// Token: 0x04001E71 RID: 7793
		private bool _grantOptionFor;

		// Token: 0x04001E72 RID: 7794
		private bool _cascadeOption;

		// Token: 0x04001E73 RID: 7795
		private Identifier _asClause;
	}
}
