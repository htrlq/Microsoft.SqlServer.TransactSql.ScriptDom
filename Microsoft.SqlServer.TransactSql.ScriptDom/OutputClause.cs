using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003F2 RID: 1010
	[Serializable]
	public class OutputClause : TSqlFragment
	{
		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06003684 RID: 13956 RVA: 0x001D57BD File Offset: 0x001D39BD
		public IList<SelectElement> SelectColumns
		{
			get
			{
				return this._selectColumns;
			}
		}

		// Token: 0x06003685 RID: 13957 RVA: 0x001D57C5 File Offset: 0x001D39C5
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003686 RID: 13958 RVA: 0x001D57D4 File Offset: 0x001D39D4
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.SelectColumns.Count;
			while (i < count)
			{
				this.SelectColumns[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002111 RID: 8465
		private List<SelectElement> _selectColumns = new List<SelectElement>();
	}
}
