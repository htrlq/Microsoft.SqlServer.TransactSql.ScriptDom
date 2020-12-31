using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002CE RID: 718
	[Serializable]
	public class IndexDefinition : TSqlStatement, IFileStreamSpecifier
	{
		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06002F52 RID: 12114 RVA: 0x001CE0F7 File Offset: 0x001CC2F7
		// (set) Token: 0x06002F53 RID: 12115 RVA: 0x001CE0FF File Offset: 0x001CC2FF
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

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06002F54 RID: 12116 RVA: 0x001CE10F File Offset: 0x001CC30F
		// (set) Token: 0x06002F55 RID: 12117 RVA: 0x001CE117 File Offset: 0x001CC317
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

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06002F56 RID: 12118 RVA: 0x001CE120 File Offset: 0x001CC320
		public IList<IndexOption> IndexOptions
		{
			get
			{
				return this._indexOptions;
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06002F57 RID: 12119 RVA: 0x001CE128 File Offset: 0x001CC328
		public IList<ColumnWithSortOrder> Columns
		{
			get
			{
				return this._columns;
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06002F58 RID: 12120 RVA: 0x001CE130 File Offset: 0x001CC330
		// (set) Token: 0x06002F59 RID: 12121 RVA: 0x001CE138 File Offset: 0x001CC338
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

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06002F5A RID: 12122 RVA: 0x001CE148 File Offset: 0x001CC348
		// (set) Token: 0x06002F5B RID: 12123 RVA: 0x001CE150 File Offset: 0x001CC350
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

		// Token: 0x06002F5C RID: 12124 RVA: 0x001CE160 File Offset: 0x001CC360
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002F5D RID: 12125 RVA: 0x001CE16C File Offset: 0x001CC36C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			int i = 0;
			int count = this.IndexOptions.Count;
			while (i < count)
			{
				this.IndexOptions[i].Accept(visitor);
				i++;
			}
			int j = 0;
			int count2 = this.Columns.Count;
			while (j < count2)
			{
				this.Columns[j].Accept(visitor);
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
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001EF3 RID: 7923
		private Identifier _name;

		// Token: 0x04001EF4 RID: 7924
		private IndexType _indexType;

		// Token: 0x04001EF5 RID: 7925
		private List<IndexOption> _indexOptions = new List<IndexOption>();

		// Token: 0x04001EF6 RID: 7926
		private List<ColumnWithSortOrder> _columns = new List<ColumnWithSortOrder>();

		// Token: 0x04001EF7 RID: 7927
		private FileGroupOrPartitionScheme _onFileGroupOrPartitionScheme;

		// Token: 0x04001EF8 RID: 7928
		private IdentifierOrValueExpression _fileStreamOn;
	}
}
