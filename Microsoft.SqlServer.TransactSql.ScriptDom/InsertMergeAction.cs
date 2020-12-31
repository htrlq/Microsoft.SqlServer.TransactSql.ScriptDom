using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200046D RID: 1133
	[Serializable]
	public class InsertMergeAction : MergeAction
	{
		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06003951 RID: 14673 RVA: 0x001D8382 File Offset: 0x001D6582
		public IList<ColumnReferenceExpression> Columns
		{
			get
			{
				return this._columns;
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06003952 RID: 14674 RVA: 0x001D838A File Offset: 0x001D658A
		// (set) Token: 0x06003953 RID: 14675 RVA: 0x001D8392 File Offset: 0x001D6592
		public ValuesInsertSource Source
		{
			get
			{
				return this._source;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._source = value;
			}
		}

		// Token: 0x06003954 RID: 14676 RVA: 0x001D83A2 File Offset: 0x001D65A2
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003955 RID: 14677 RVA: 0x001D83B0 File Offset: 0x001D65B0
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.Columns.Count;
			while (i < count)
			{
				this.Columns[i].Accept(visitor);
				i++;
			}
			if (this.Source != null)
			{
				this.Source.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x040021D0 RID: 8656
		private List<ColumnReferenceExpression> _columns = new List<ColumnReferenceExpression>();

		// Token: 0x040021D1 RID: 8657
		private ValuesInsertSource _source;
	}
}
