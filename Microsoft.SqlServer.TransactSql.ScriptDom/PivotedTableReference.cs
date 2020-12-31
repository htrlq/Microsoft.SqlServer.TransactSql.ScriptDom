using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003DF RID: 991
	[Serializable]
	public class PivotedTableReference : TableReferenceWithAlias
	{
		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x0600360D RID: 13837 RVA: 0x001D4F90 File Offset: 0x001D3190
		// (set) Token: 0x0600360E RID: 13838 RVA: 0x001D4F98 File Offset: 0x001D3198
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

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x0600360F RID: 13839 RVA: 0x001D4FA8 File Offset: 0x001D31A8
		public IList<Identifier> InColumns
		{
			get
			{
				return this._inColumns;
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06003610 RID: 13840 RVA: 0x001D4FB0 File Offset: 0x001D31B0
		// (set) Token: 0x06003611 RID: 13841 RVA: 0x001D4FB8 File Offset: 0x001D31B8
		public ColumnReferenceExpression PivotColumn
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

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06003612 RID: 13842 RVA: 0x001D4FC8 File Offset: 0x001D31C8
		public IList<ColumnReferenceExpression> ValueColumns
		{
			get
			{
				return this._valueColumns;
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06003613 RID: 13843 RVA: 0x001D4FD0 File Offset: 0x001D31D0
		// (set) Token: 0x06003614 RID: 13844 RVA: 0x001D4FD8 File Offset: 0x001D31D8
		public MultiPartIdentifier AggregateFunctionIdentifier
		{
			get
			{
				return this._aggregateFunctionIdentifier;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._aggregateFunctionIdentifier = value;
			}
		}

		// Token: 0x06003615 RID: 13845 RVA: 0x001D4FE8 File Offset: 0x001D31E8
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003616 RID: 13846 RVA: 0x001D4FF4 File Offset: 0x001D31F4
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
			int j = 0;
			int count2 = this.ValueColumns.Count;
			while (j < count2)
			{
				this.ValueColumns[j].Accept(visitor);
				j++;
			}
			if (this.AggregateFunctionIdentifier != null)
			{
				this.AggregateFunctionIdentifier.Accept(visitor);
			}
		}

		// Token: 0x040020ED RID: 8429
		private TableReference _tableReference;

		// Token: 0x040020EE RID: 8430
		private List<Identifier> _inColumns = new List<Identifier>();

		// Token: 0x040020EF RID: 8431
		private ColumnReferenceExpression _pivotColumn;

		// Token: 0x040020F0 RID: 8432
		private List<ColumnReferenceExpression> _valueColumns = new List<ColumnReferenceExpression>();

		// Token: 0x040020F1 RID: 8433
		private MultiPartIdentifier _aggregateFunctionIdentifier;
	}
}
