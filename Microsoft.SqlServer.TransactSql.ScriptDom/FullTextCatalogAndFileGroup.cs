using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002E5 RID: 741
	[Serializable]
	public class FullTextCatalogAndFileGroup : TSqlFragment
	{
		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06003002 RID: 12290 RVA: 0x001CEE0A File Offset: 0x001CD00A
		// (set) Token: 0x06003003 RID: 12291 RVA: 0x001CEE12 File Offset: 0x001CD012
		public Identifier CatalogName
		{
			get
			{
				return this._catalogName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._catalogName = value;
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06003004 RID: 12292 RVA: 0x001CEE22 File Offset: 0x001CD022
		// (set) Token: 0x06003005 RID: 12293 RVA: 0x001CEE2A File Offset: 0x001CD02A
		public Identifier FileGroupName
		{
			get
			{
				return this._fileGroupName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._fileGroupName = value;
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06003006 RID: 12294 RVA: 0x001CEE3A File Offset: 0x001CD03A
		// (set) Token: 0x06003007 RID: 12295 RVA: 0x001CEE42 File Offset: 0x001CD042
		public bool FileGroupIsFirst
		{
			get
			{
				return this._fileGroupIsFirst;
			}
			set
			{
				this._fileGroupIsFirst = value;
			}
		}

		// Token: 0x06003008 RID: 12296 RVA: 0x001CEE4B File Offset: 0x001CD04B
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003009 RID: 12297 RVA: 0x001CEE57 File Offset: 0x001CD057
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.CatalogName != null)
			{
				this.CatalogName.Accept(visitor);
			}
			if (this.FileGroupName != null)
			{
				this.FileGroupName.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F30 RID: 7984
		private Identifier _catalogName;

		// Token: 0x04001F31 RID: 7985
		private Identifier _fileGroupName;

		// Token: 0x04001F32 RID: 7986
		private bool _fileGroupIsFirst;
	}
}
