using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003F3 RID: 1011
	[Serializable]
	public class OutputIntoClause : TSqlFragment
	{
		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06003688 RID: 13960 RVA: 0x001D5825 File Offset: 0x001D3A25
		public IList<SelectElement> SelectColumns
		{
			get
			{
				return this._selectColumns;
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06003689 RID: 13961 RVA: 0x001D582D File Offset: 0x001D3A2D
		// (set) Token: 0x0600368A RID: 13962 RVA: 0x001D5835 File Offset: 0x001D3A35
		public TableReference IntoTable
		{
			get
			{
				return this._intoTable;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._intoTable = value;
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x0600368B RID: 13963 RVA: 0x001D5845 File Offset: 0x001D3A45
		public IList<ColumnReferenceExpression> IntoTableColumns
		{
			get
			{
				return this._intoTableColumns;
			}
		}

		// Token: 0x0600368C RID: 13964 RVA: 0x001D584D File Offset: 0x001D3A4D
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600368D RID: 13965 RVA: 0x001D585C File Offset: 0x001D3A5C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.SelectColumns.Count;
			while (i < count)
			{
				this.SelectColumns[i].Accept(visitor);
				i++;
			}
			if (this.IntoTable != null)
			{
				this.IntoTable.Accept(visitor);
			}
			int j = 0;
			int count2 = this.IntoTableColumns.Count;
			while (j < count2)
			{
				this.IntoTableColumns[j].Accept(visitor);
				j++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002112 RID: 8466
		private List<SelectElement> _selectColumns = new List<SelectElement>();

		// Token: 0x04002113 RID: 8467
		private TableReference _intoTable;

		// Token: 0x04002114 RID: 8468
		private List<ColumnReferenceExpression> _intoTableColumns = new List<ColumnReferenceExpression>();
	}
}
