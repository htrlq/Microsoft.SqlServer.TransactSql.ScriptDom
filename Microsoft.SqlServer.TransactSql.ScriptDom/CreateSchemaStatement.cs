using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000260 RID: 608
	[Serializable]
	public class CreateSchemaStatement : TSqlStatement, IAuthorization
	{
		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06002CD3 RID: 11475 RVA: 0x001CB649 File Offset: 0x001C9849
		// (set) Token: 0x06002CD4 RID: 11476 RVA: 0x001CB651 File Offset: 0x001C9851
		public Identifier Name
		{
			get
			{
				return this._name;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._name = value;
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06002CD5 RID: 11477 RVA: 0x001CB661 File Offset: 0x001C9861
		// (set) Token: 0x06002CD6 RID: 11478 RVA: 0x001CB669 File Offset: 0x001C9869
		public StatementList StatementList
		{
			get
			{
				return this._statementList;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._statementList = value;
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06002CD7 RID: 11479 RVA: 0x001CB679 File Offset: 0x001C9879
		// (set) Token: 0x06002CD8 RID: 11480 RVA: 0x001CB681 File Offset: 0x001C9881
		public Identifier Owner
		{
			get
			{
				return this._owner;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._owner = value;
			}
		}

		// Token: 0x06002CD9 RID: 11481 RVA: 0x001CB691 File Offset: 0x001C9891
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002CDA RID: 11482 RVA: 0x001CB6A0 File Offset: 0x001C98A0
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			if (this.StatementList != null)
			{
				this.StatementList.Accept(visitor);
			}
			if (this.Owner != null)
			{
				this.Owner.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E42 RID: 7746
		private Identifier _name;

		// Token: 0x04001E43 RID: 7747
		private StatementList _statementList;

		// Token: 0x04001E44 RID: 7748
		private Identifier _owner;
	}
}
