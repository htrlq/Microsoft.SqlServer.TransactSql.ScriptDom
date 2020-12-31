using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002E0 RID: 736
	[Serializable]
	public class CreateFullTextIndexStatement : TSqlStatement
	{
		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06002FE0 RID: 12256 RVA: 0x001CEBE0 File Offset: 0x001CCDE0
		// (set) Token: 0x06002FE1 RID: 12257 RVA: 0x001CEBE8 File Offset: 0x001CCDE8
		public SchemaObjectName OnName
		{
			get
			{
				return this._onName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._onName = value;
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06002FE2 RID: 12258 RVA: 0x001CEBF8 File Offset: 0x001CCDF8
		public IList<FullTextIndexColumn> FullTextIndexColumns
		{
			get
			{
				return this._fullTextIndexColumns;
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06002FE3 RID: 12259 RVA: 0x001CEC00 File Offset: 0x001CCE00
		// (set) Token: 0x06002FE4 RID: 12260 RVA: 0x001CEC08 File Offset: 0x001CCE08
		public Identifier KeyIndexName
		{
			get
			{
				return this._keyIndexName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._keyIndexName = value;
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06002FE5 RID: 12261 RVA: 0x001CEC18 File Offset: 0x001CCE18
		// (set) Token: 0x06002FE6 RID: 12262 RVA: 0x001CEC20 File Offset: 0x001CCE20
		public FullTextCatalogAndFileGroup CatalogAndFileGroup
		{
			get
			{
				return this._catalogAndFileGroup;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._catalogAndFileGroup = value;
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06002FE7 RID: 12263 RVA: 0x001CEC30 File Offset: 0x001CCE30
		public IList<FullTextIndexOption> Options
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x06002FE8 RID: 12264 RVA: 0x001CEC38 File Offset: 0x001CCE38
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002FE9 RID: 12265 RVA: 0x001CEC44 File Offset: 0x001CCE44
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.OnName != null)
			{
				this.OnName.Accept(visitor);
			}
			int i = 0;
			int count = this.FullTextIndexColumns.Count;
			while (i < count)
			{
				this.FullTextIndexColumns[i].Accept(visitor);
				i++;
			}
			if (this.KeyIndexName != null)
			{
				this.KeyIndexName.Accept(visitor);
			}
			if (this.CatalogAndFileGroup != null)
			{
				this.CatalogAndFileGroup.Accept(visitor);
			}
			int j = 0;
			int count2 = this.Options.Count;
			while (j < count2)
			{
				this.Options[j].Accept(visitor);
				j++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F25 RID: 7973
		private SchemaObjectName _onName;

		// Token: 0x04001F26 RID: 7974
		private List<FullTextIndexColumn> _fullTextIndexColumns = new List<FullTextIndexColumn>();

		// Token: 0x04001F27 RID: 7975
		private Identifier _keyIndexName;

		// Token: 0x04001F28 RID: 7976
		private FullTextCatalogAndFileGroup _catalogAndFileGroup;

		// Token: 0x04001F29 RID: 7977
		private List<FullTextIndexOption> _options = new List<FullTextIndexOption>();
	}
}
