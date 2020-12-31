using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004A0 RID: 1184
	[Serializable]
	public class CreateFullTextStopListStatement : TSqlStatement, IAuthorization
	{
		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06003A4C RID: 14924 RVA: 0x001D91CF File Offset: 0x001D73CF
		// (set) Token: 0x06003A4D RID: 14925 RVA: 0x001D91D7 File Offset: 0x001D73D7
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

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06003A4E RID: 14926 RVA: 0x001D91E7 File Offset: 0x001D73E7
		// (set) Token: 0x06003A4F RID: 14927 RVA: 0x001D91EF File Offset: 0x001D73EF
		public bool IsSystemStopList
		{
			get
			{
				return this._isSystemStopList;
			}
			set
			{
				this._isSystemStopList = value;
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06003A50 RID: 14928 RVA: 0x001D91F8 File Offset: 0x001D73F8
		// (set) Token: 0x06003A51 RID: 14929 RVA: 0x001D9200 File Offset: 0x001D7400
		public Identifier DatabaseName
		{
			get
			{
				return this._databaseName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._databaseName = value;
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06003A52 RID: 14930 RVA: 0x001D9210 File Offset: 0x001D7410
		// (set) Token: 0x06003A53 RID: 14931 RVA: 0x001D9218 File Offset: 0x001D7418
		public Identifier SourceStopListName
		{
			get
			{
				return this._sourceStopListName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._sourceStopListName = value;
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06003A54 RID: 14932 RVA: 0x001D9228 File Offset: 0x001D7428
		// (set) Token: 0x06003A55 RID: 14933 RVA: 0x001D9230 File Offset: 0x001D7430
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

		// Token: 0x06003A56 RID: 14934 RVA: 0x001D9240 File Offset: 0x001D7440
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003A57 RID: 14935 RVA: 0x001D924C File Offset: 0x001D744C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			if (this.DatabaseName != null)
			{
				this.DatabaseName.Accept(visitor);
			}
			if (this.SourceStopListName != null)
			{
				this.SourceStopListName.Accept(visitor);
			}
			if (this.Owner != null)
			{
				this.Owner.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400220B RID: 8715
		private Identifier _name;

		// Token: 0x0400220C RID: 8716
		private bool _isSystemStopList;

		// Token: 0x0400220D RID: 8717
		private Identifier _databaseName;

		// Token: 0x0400220E RID: 8718
		private Identifier _sourceStopListName;

		// Token: 0x0400220F RID: 8719
		private Identifier _owner;
	}
}
