using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004E3 RID: 1251
	[Serializable]
	public class CreateColumnStoreIndexStatement : TSqlStatement
	{
		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06003BDB RID: 15323 RVA: 0x001DAB3B File Offset: 0x001D8D3B
		// (set) Token: 0x06003BDC RID: 15324 RVA: 0x001DAB43 File Offset: 0x001D8D43
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

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06003BDD RID: 15325 RVA: 0x001DAB53 File Offset: 0x001D8D53
		// (set) Token: 0x06003BDE RID: 15326 RVA: 0x001DAB5B File Offset: 0x001D8D5B
		public bool? Clustered
		{
			get
			{
				return this._clustered;
			}
			set
			{
				this._clustered = value;
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06003BDF RID: 15327 RVA: 0x001DAB64 File Offset: 0x001D8D64
		// (set) Token: 0x06003BE0 RID: 15328 RVA: 0x001DAB6C File Offset: 0x001D8D6C
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

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06003BE1 RID: 15329 RVA: 0x001DAB7C File Offset: 0x001D8D7C
		public IList<ColumnReferenceExpression> Columns
		{
			get
			{
				return this._columns;
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06003BE2 RID: 15330 RVA: 0x001DAB84 File Offset: 0x001D8D84
		public IList<IndexOption> IndexOptions
		{
			get
			{
				return this._indexOptions;
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06003BE3 RID: 15331 RVA: 0x001DAB8C File Offset: 0x001D8D8C
		// (set) Token: 0x06003BE4 RID: 15332 RVA: 0x001DAB94 File Offset: 0x001D8D94
		public FileGroupOrPartitionScheme OnFileGroupOrPartitionScheme
		{
			get
			{
				return this._onFileGroupOrPartitionScheme;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._onFileGroupOrPartitionScheme = value;
			}
		}

		// Token: 0x06003BE5 RID: 15333 RVA: 0x001DABA4 File Offset: 0x001D8DA4
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003BE6 RID: 15334 RVA: 0x001DABB0 File Offset: 0x001D8DB0
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			if (this.OnName != null)
			{
				this.OnName.Accept(visitor);
			}
			int i = 0;
			int count = this.Columns.Count;
			while (i < count)
			{
				this.Columns[i].Accept(visitor);
				i++;
			}
			int j = 0;
			int count2 = this.IndexOptions.Count;
			while (j < count2)
			{
				this.IndexOptions[j].Accept(visitor);
				j++;
			}
			if (this.OnFileGroupOrPartitionScheme != null)
			{
				this.OnFileGroupOrPartitionScheme.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400227C RID: 8828
		private Identifier _name;

		// Token: 0x0400227D RID: 8829
		private bool? _clustered;

		// Token: 0x0400227E RID: 8830
		private SchemaObjectName _onName;

		// Token: 0x0400227F RID: 8831
		private List<ColumnReferenceExpression> _columns = new List<ColumnReferenceExpression>();

		// Token: 0x04002280 RID: 8832
		private List<IndexOption> _indexOptions = new List<IndexOption>();

		// Token: 0x04002281 RID: 8833
		private FileGroupOrPartitionScheme _onFileGroupOrPartitionScheme;
	}
}
