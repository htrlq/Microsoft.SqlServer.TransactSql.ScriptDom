using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002D6 RID: 726
	[Serializable]
	public class CreateIndexStatement : IndexStatement, IFileStreamSpecifier
	{
		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06002F9D RID: 12189 RVA: 0x001CE785 File Offset: 0x001CC985
		// (set) Token: 0x06002F9E RID: 12190 RVA: 0x001CE78D File Offset: 0x001CC98D
		public bool Translated80SyntaxTo90
		{
			get
			{
				return this._translated80SyntaxTo90;
			}
			set
			{
				this._translated80SyntaxTo90 = value;
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06002F9F RID: 12191 RVA: 0x001CE796 File Offset: 0x001CC996
		// (set) Token: 0x06002FA0 RID: 12192 RVA: 0x001CE79E File Offset: 0x001CC99E
		public bool Unique
		{
			get
			{
				return this._unique;
			}
			set
			{
				this._unique = value;
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06002FA1 RID: 12193 RVA: 0x001CE7A7 File Offset: 0x001CC9A7
		// (set) Token: 0x06002FA2 RID: 12194 RVA: 0x001CE7AF File Offset: 0x001CC9AF
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

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06002FA3 RID: 12195 RVA: 0x001CE7B8 File Offset: 0x001CC9B8
		public IList<ColumnWithSortOrder> Columns
		{
			get
			{
				return this._columns;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06002FA4 RID: 12196 RVA: 0x001CE7C0 File Offset: 0x001CC9C0
		public IList<ColumnReferenceExpression> IncludeColumns
		{
			get
			{
				return this._includeColumns;
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06002FA5 RID: 12197 RVA: 0x001CE7C8 File Offset: 0x001CC9C8
		// (set) Token: 0x06002FA6 RID: 12198 RVA: 0x001CE7D0 File Offset: 0x001CC9D0
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

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06002FA7 RID: 12199 RVA: 0x001CE7E0 File Offset: 0x001CC9E0
		// (set) Token: 0x06002FA8 RID: 12200 RVA: 0x001CE7E8 File Offset: 0x001CC9E8
		public BooleanExpression FilterPredicate
		{
			get
			{
				return this._filterPredicate;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._filterPredicate = value;
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06002FA9 RID: 12201 RVA: 0x001CE7F8 File Offset: 0x001CC9F8
		// (set) Token: 0x06002FAA RID: 12202 RVA: 0x001CE800 File Offset: 0x001CCA00
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

		// Token: 0x06002FAB RID: 12203 RVA: 0x001CE810 File Offset: 0x001CCA10
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002FAC RID: 12204 RVA: 0x001CE81C File Offset: 0x001CCA1C
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
			int count = this.Columns.Count;
			while (i < count)
			{
				this.Columns[i].Accept(visitor);
				i++;
			}
			int j = 0;
			int count2 = this.IncludeColumns.Count;
			while (j < count2)
			{
				this.IncludeColumns[j].Accept(visitor);
				j++;
			}
			int k = 0;
			int count3 = base.IndexOptions.Count;
			while (k < count3)
			{
				base.IndexOptions[k].Accept(visitor);
				k++;
			}
			if (this.OnFileGroupOrPartitionScheme != null)
			{
				this.OnFileGroupOrPartitionScheme.Accept(visitor);
			}
			if (this.FilterPredicate != null)
			{
				this.FilterPredicate.Accept(visitor);
			}
			if (this.FileStreamOn != null)
			{
				this.FileStreamOn.Accept(visitor);
			}
		}

		// Token: 0x04001F10 RID: 7952
		private bool _translated80SyntaxTo90;

		// Token: 0x04001F11 RID: 7953
		private bool _unique;

		// Token: 0x04001F12 RID: 7954
		private bool? _clustered;

		// Token: 0x04001F13 RID: 7955
		private List<ColumnWithSortOrder> _columns = new List<ColumnWithSortOrder>();

		// Token: 0x04001F14 RID: 7956
		private List<ColumnReferenceExpression> _includeColumns = new List<ColumnReferenceExpression>();

		// Token: 0x04001F15 RID: 7957
		private FileGroupOrPartitionScheme _onFileGroupOrPartitionScheme;

		// Token: 0x04001F16 RID: 7958
		private BooleanExpression _filterPredicate;

		// Token: 0x04001F17 RID: 7959
		private IdentifierOrValueExpression _fileStreamOn;
	}
}
