using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001FC RID: 508
	[Serializable]
	public abstract class TableReferenceWithAliasAndColumns : TableReferenceWithAlias
	{
		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06002A66 RID: 10854 RVA: 0x001C8981 File Offset: 0x001C6B81
		public IList<Identifier> Columns
		{
			get
			{
				return this._columns;
			}
		}

		// Token: 0x06002A67 RID: 10855 RVA: 0x001C898C File Offset: 0x001C6B8C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			int i = 0;
			int count = this.Columns.Count;
			while (i < count)
			{
				this.Columns[i].Accept(visitor);
				i++;
			}
		}

		// Token: 0x04001D8C RID: 7564
		private List<Identifier> _columns = new List<Identifier>();
	}
}
