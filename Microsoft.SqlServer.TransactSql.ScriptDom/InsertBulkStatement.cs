using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200038F RID: 911
	[Serializable]
	public class InsertBulkStatement : BulkInsertBase
	{
		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x0600340B RID: 13323 RVA: 0x001D2D9B File Offset: 0x001D0F9B
		public IList<InsertBulkColumnDefinition> ColumnDefinitions
		{
			get
			{
				return this._columnDefinitions;
			}
		}

		// Token: 0x0600340C RID: 13324 RVA: 0x001D2DA3 File Offset: 0x001D0FA3
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600340D RID: 13325 RVA: 0x001D2DB0 File Offset: 0x001D0FB0
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			int i = 0;
			int count = this.ColumnDefinitions.Count;
			while (i < count)
			{
				this.ColumnDefinitions[i].Accept(visitor);
				i++;
			}
		}

		// Token: 0x04002053 RID: 8275
		private List<InsertBulkColumnDefinition> _columnDefinitions = new List<InsertBulkColumnDefinition>();
	}
}
