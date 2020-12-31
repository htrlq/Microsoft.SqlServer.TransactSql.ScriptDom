using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000281 RID: 641
	[Serializable]
	public class RowValue : TSqlFragment
	{
		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06002DAE RID: 11694 RVA: 0x001CC607 File Offset: 0x001CA807
		public IList<ScalarExpression> ColumnValues
		{
			get
			{
				return this._columnValues;
			}
		}

		// Token: 0x06002DAF RID: 11695 RVA: 0x001CC60F File Offset: 0x001CA80F
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002DB0 RID: 11696 RVA: 0x001CC61C File Offset: 0x001CA81C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.ColumnValues.Count;
			while (i < count)
			{
				this.ColumnValues[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E86 RID: 7814
		private List<ScalarExpression> _columnValues = new List<ScalarExpression>();
	}
}
