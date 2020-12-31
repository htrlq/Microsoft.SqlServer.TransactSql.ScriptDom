using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200037E RID: 894
	[Serializable]
	public class UniqueConstraintDefinition : ConstraintDefinition, IFileStreamSpecifier
	{
		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x0600339A RID: 13210 RVA: 0x001D24F0 File Offset: 0x001D06F0
		// (set) Token: 0x0600339B RID: 13211 RVA: 0x001D24F8 File Offset: 0x001D06F8
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

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x0600339C RID: 13212 RVA: 0x001D2501 File Offset: 0x001D0701
		// (set) Token: 0x0600339D RID: 13213 RVA: 0x001D2509 File Offset: 0x001D0709
		public bool IsPrimaryKey
		{
			get
			{
				return this._isPrimaryKey;
			}
			set
			{
				this._isPrimaryKey = value;
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x0600339E RID: 13214 RVA: 0x001D2512 File Offset: 0x001D0712
		public IList<ColumnWithSortOrder> Columns
		{
			get
			{
				return this._columns;
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x0600339F RID: 13215 RVA: 0x001D251A File Offset: 0x001D071A
		public IList<IndexOption> IndexOptions
		{
			get
			{
				return this._indexOptions;
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x060033A0 RID: 13216 RVA: 0x001D2522 File Offset: 0x001D0722
		// (set) Token: 0x060033A1 RID: 13217 RVA: 0x001D252A File Offset: 0x001D072A
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

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x060033A2 RID: 13218 RVA: 0x001D253A File Offset: 0x001D073A
		// (set) Token: 0x060033A3 RID: 13219 RVA: 0x001D2542 File Offset: 0x001D0742
		public IndexType IndexType
		{
			get
			{
				return this._indexType;
			}
			set
			{
				this._indexType = value;
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x060033A4 RID: 13220 RVA: 0x001D254B File Offset: 0x001D074B
		// (set) Token: 0x060033A5 RID: 13221 RVA: 0x001D2553 File Offset: 0x001D0753
		public IdentifierOrValueExpression FileStreamOn
		{
			get
			{
				return this._fileStreamOn;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._fileStreamOn = value;
			}
		}

		// Token: 0x060033A6 RID: 13222 RVA: 0x001D2563 File Offset: 0x001D0763
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060033A7 RID: 13223 RVA: 0x001D2570 File Offset: 0x001D0770
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
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
			if (this.FileStreamOn != null)
			{
				this.FileStreamOn.Accept(visitor);
			}
		}

		// Token: 0x0400202D RID: 8237
		private bool? _clustered;

		// Token: 0x0400202E RID: 8238
		private bool _isPrimaryKey;

		// Token: 0x0400202F RID: 8239
		private List<ColumnWithSortOrder> _columns = new List<ColumnWithSortOrder>();

		// Token: 0x04002030 RID: 8240
		private List<IndexOption> _indexOptions = new List<IndexOption>();

		// Token: 0x04002031 RID: 8241
		private FileGroupOrPartitionScheme _onFileGroupOrPartitionScheme;

		// Token: 0x04002032 RID: 8242
		private IndexType _indexType;

		// Token: 0x04002033 RID: 8243
		private IdentifierOrValueExpression _fileStreamOn;
	}
}
