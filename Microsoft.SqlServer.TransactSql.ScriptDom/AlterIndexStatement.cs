using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002D2 RID: 722
	[Serializable]
	public class AlterIndexStatement : IndexStatement
	{
		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06002F72 RID: 12146 RVA: 0x001CE369 File Offset: 0x001CC569
		// (set) Token: 0x06002F73 RID: 12147 RVA: 0x001CE371 File Offset: 0x001CC571
		public bool All
		{
			get
			{
				return this._all;
			}
			set
			{
				this._all = value;
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06002F74 RID: 12148 RVA: 0x001CE37A File Offset: 0x001CC57A
		// (set) Token: 0x06002F75 RID: 12149 RVA: 0x001CE382 File Offset: 0x001CC582
		public AlterIndexType AlterIndexType
		{
			get
			{
				return this._alterIndexType;
			}
			set
			{
				this._alterIndexType = value;
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06002F76 RID: 12150 RVA: 0x001CE38B File Offset: 0x001CC58B
		// (set) Token: 0x06002F77 RID: 12151 RVA: 0x001CE393 File Offset: 0x001CC593
		public PartitionSpecifier Partition
		{
			get
			{
				return this._partition;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._partition = value;
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06002F78 RID: 12152 RVA: 0x001CE3A3 File Offset: 0x001CC5A3
		public IList<SelectiveXmlIndexPromotedPath> PromotedPaths
		{
			get
			{
				return this._promotedPaths;
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06002F79 RID: 12153 RVA: 0x001CE3AB File Offset: 0x001CC5AB
		// (set) Token: 0x06002F7A RID: 12154 RVA: 0x001CE3B3 File Offset: 0x001CC5B3
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

		// Token: 0x06002F7B RID: 12155 RVA: 0x001CE3C3 File Offset: 0x001CC5C3
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002F7C RID: 12156 RVA: 0x001CE3D0 File Offset: 0x001CC5D0
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
			int i = 0;
			int count = base.IndexOptions.Count;
			while (i < count)
			{
				base.IndexOptions[i].Accept(visitor);
				i++;
			}
			if (this.Partition != null)
			{
				this.Partition.Accept(visitor);
			}
			int j = 0;
			int count2 = this.PromotedPaths.Count;
			while (j < count2)
			{
				this.PromotedPaths[j].Accept(visitor);
				j++;
			}
			if (this.XmlNamespaces != null)
			{
				this.XmlNamespaces.Accept(visitor);
			}
		}

		// Token: 0x04001EFF RID: 7935
		private bool _all;

		// Token: 0x04001F00 RID: 7936
		private AlterIndexType _alterIndexType;

		// Token: 0x04001F01 RID: 7937
		private PartitionSpecifier _partition;

		// Token: 0x04001F02 RID: 7938
		private List<SelectiveXmlIndexPromotedPath> _promotedPaths = new List<SelectiveXmlIndexPromotedPath>();

		// Token: 0x04001F03 RID: 7939
		private XmlNamespaces _xmlNamespaces;
	}
}
