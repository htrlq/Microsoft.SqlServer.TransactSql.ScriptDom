using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003E0 RID: 992
	[Serializable]
	public class UnpivotedTableReference : TableReferenceWithAlias
	{
		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06003618 RID: 13848 RVA: 0x001D50B6 File Offset: 0x001D32B6
		// (set) Token: 0x06003619 RID: 13849 RVA: 0x001D50BE File Offset: 0x001D32BE
		public TableReference TableReference
		{
			get
			{
				return this._tableReference;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._tableReference = value;
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x0600361A RID: 13850 RVA: 0x001D50CE File Offset: 0x001D32CE
		public IList<ColumnReferenceExpression> InColumns
		{
			get
			{
				return this._inColumns;
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x0600361B RID: 13851 RVA: 0x001D50D6 File Offset: 0x001D32D6
		// (set) Token: 0x0600361C RID: 13852 RVA: 0x001D50DE File Offset: 0x001D32DE
		public Identifier PivotColumn
		{
			get
			{
				return this._pivotColumn;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._pivotColumn = value;
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x0600361D RID: 13853 RVA: 0x001D50EE File Offset: 0x001D32EE
		// (set) Token: 0x0600361E RID: 13854 RVA: 0x001D50F6 File Offset: 0x001D32F6
		public Identifier ValueColumn
		{
			get
			{
				return this._valueColumn;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._valueColumn = value;
			}
		}

		// Token: 0x0600361F RID: 13855 RVA: 0x001D5106 File Offset: 0x001D3306
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003620 RID: 13856 RVA: 0x001D5114 File Offset: 0x001D3314
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.TableReference != null)
			{
				this.TableReference.Accept(visitor);
			}
			int i = 0;
			int count = this.InColumns.Count;
			while (i < count)
			{
				this.InColumns[i].Accept(visitor);
				i++;
			}
			if (this.PivotColumn != null)
			{
				this.PivotColumn.Accept(visitor);
			}
			if (this.ValueColumn != null)
			{
				this.ValueColumn.Accept(visitor);
			}
		}

		// Token: 0x040020F2 RID: 8434
		private TableReference _tableReference;

		// Token: 0x040020F3 RID: 8435
		private List<ColumnReferenceExpression> _inColumns = new List<ColumnReferenceExpression>();

		// Token: 0x040020F4 RID: 8436
		private Identifier _pivotColumn;

		// Token: 0x040020F5 RID: 8437
		private Identifier _valueColumn;
	}
}
