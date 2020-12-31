using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002D4 RID: 724
	[Serializable]
	public class CreateSelectiveXmlIndexStatement : IndexStatement
	{
		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06002F89 RID: 12169 RVA: 0x001CE583 File Offset: 0x001CC783
		// (set) Token: 0x06002F8A RID: 12170 RVA: 0x001CE58B File Offset: 0x001CC78B
		public bool IsSecondary
		{
			get
			{
				return this._isSecondary;
			}
			set
			{
				this._isSecondary = value;
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06002F8B RID: 12171 RVA: 0x001CE594 File Offset: 0x001CC794
		// (set) Token: 0x06002F8C RID: 12172 RVA: 0x001CE59C File Offset: 0x001CC79C
		public Identifier XmlColumn
		{
			get
			{
				return this._xmlColumn;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._xmlColumn = value;
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06002F8D RID: 12173 RVA: 0x001CE5AC File Offset: 0x001CC7AC
		public IList<SelectiveXmlIndexPromotedPath> PromotedPaths
		{
			get
			{
				return this._promotedPaths;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06002F8E RID: 12174 RVA: 0x001CE5B4 File Offset: 0x001CC7B4
		// (set) Token: 0x06002F8F RID: 12175 RVA: 0x001CE5BC File Offset: 0x001CC7BC
		public XmlNamespaces XmlNamespaces
		{
			get
			{
				return this._xmlNamespaces;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._xmlNamespaces = value;
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06002F90 RID: 12176 RVA: 0x001CE5CC File Offset: 0x001CC7CC
		// (set) Token: 0x06002F91 RID: 12177 RVA: 0x001CE5D4 File Offset: 0x001CC7D4
		public Identifier UsingXmlIndexName
		{
			get
			{
				return this._usingXmlIndexName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._usingXmlIndexName = value;
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06002F92 RID: 12178 RVA: 0x001CE5E4 File Offset: 0x001CC7E4
		// (set) Token: 0x06002F93 RID: 12179 RVA: 0x001CE5EC File Offset: 0x001CC7EC
		public Identifier PathName
		{
			get
			{
				return this._pathName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._pathName = value;
			}
		}

		// Token: 0x06002F94 RID: 12180 RVA: 0x001CE5FC File Offset: 0x001CC7FC
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002F95 RID: 12181 RVA: 0x001CE608 File Offset: 0x001CC808
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (base.Name != null)
			{
				base.Name.Accept(visitor);
			}
			if (base.OnName != null)
			{
				base.OnName.Accept(visitor);
			}
			if (this.XmlColumn != null)
			{
				this.XmlColumn.Accept(visitor);
			}
			int i = 0;
			int count = this.PromotedPaths.Count;
			while (i < count)
			{
				this.PromotedPaths[i].Accept(visitor);
				i++;
			}
			if (this.XmlNamespaces != null)
			{
				this.XmlNamespaces.Accept(visitor);
			}
			if (this.UsingXmlIndexName != null)
			{
				this.UsingXmlIndexName.Accept(visitor);
			}
			if (this.PathName != null)
			{
				this.PathName.Accept(visitor);
			}
			int j = 0;
			int count2 = base.IndexOptions.Count;
			while (j < count2)
			{
				base.IndexOptions[j].Accept(visitor);
				j++;
			}
		}

		// Token: 0x04001F08 RID: 7944
		private bool _isSecondary;

		// Token: 0x04001F09 RID: 7945
		private Identifier _xmlColumn;

		// Token: 0x04001F0A RID: 7946
		private List<SelectiveXmlIndexPromotedPath> _promotedPaths = new List<SelectiveXmlIndexPromotedPath>();

		// Token: 0x04001F0B RID: 7947
		private XmlNamespaces _xmlNamespaces;

		// Token: 0x04001F0C RID: 7948
		private Identifier _usingXmlIndexName;

		// Token: 0x04001F0D RID: 7949
		private Identifier _pathName;
	}
}
