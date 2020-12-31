using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000427 RID: 1063
	[Serializable]
	public class CreateSearchPropertyListStatement : TSqlStatement, IAuthorization
	{
		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x060037B5 RID: 14261 RVA: 0x001D6A97 File Offset: 0x001D4C97
		// (set) Token: 0x060037B6 RID: 14262 RVA: 0x001D6A9F File Offset: 0x001D4C9F
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

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x060037B7 RID: 14263 RVA: 0x001D6AAF File Offset: 0x001D4CAF
		// (set) Token: 0x060037B8 RID: 14264 RVA: 0x001D6AB7 File Offset: 0x001D4CB7
		public MultiPartIdentifier SourceSearchPropertyList
		{
			get
			{
				return this._sourceSearchPropertyList;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._sourceSearchPropertyList = value;
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x060037B9 RID: 14265 RVA: 0x001D6AC7 File Offset: 0x001D4CC7
		// (set) Token: 0x060037BA RID: 14266 RVA: 0x001D6ACF File Offset: 0x001D4CCF
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

		// Token: 0x060037BB RID: 14267 RVA: 0x001D6ADF File Offset: 0x001D4CDF
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060037BC RID: 14268 RVA: 0x001D6AEC File Offset: 0x001D4CEC
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			if (this.SourceSearchPropertyList != null)
			{
				this.SourceSearchPropertyList.Accept(visitor);
			}
			if (this.Owner != null)
			{
				this.Owner.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002161 RID: 8545
		private Identifier _name;

		// Token: 0x04002162 RID: 8546
		private MultiPartIdentifier _sourceSearchPropertyList;

		// Token: 0x04002163 RID: 8547
		private Identifier _owner;
	}
}
