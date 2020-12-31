using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000211 RID: 529
	[Serializable]
	public class UpdateForClause : ForClause
	{
		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06002AE2 RID: 10978 RVA: 0x001C924F File Offset: 0x001C744F
		public IList<ColumnReferenceExpression> Columns
		{
			get
			{
				return this._columns;
			}
		}

		// Token: 0x06002AE3 RID: 10979 RVA: 0x001C9257 File Offset: 0x001C7457
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002AE4 RID: 10980 RVA: 0x001C9264 File Offset: 0x001C7464
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.Columns.Count;
			while (i < count)
			{
				this.Columns[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001DB1 RID: 7601
		private List<ColumnReferenceExpression> _columns = new List<ColumnReferenceExpression>();
	}
}
