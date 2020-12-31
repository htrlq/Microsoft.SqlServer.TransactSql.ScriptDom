using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000392 RID: 914
	[Serializable]
	public class OrderBulkInsertOption : BulkInsertOption
	{
		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06003419 RID: 13337 RVA: 0x001D2E78 File Offset: 0x001D1078
		public IList<ColumnWithSortOrder> Columns
		{
			get
			{
				return this._columns;
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x0600341A RID: 13338 RVA: 0x001D2E80 File Offset: 0x001D1080
		// (set) Token: 0x0600341B RID: 13339 RVA: 0x001D2E88 File Offset: 0x001D1088
		public bool IsUnique
		{
			get
			{
				return this._isUnique;
			}
			set
			{
				this._isUnique = value;
			}
		}

		// Token: 0x0600341C RID: 13340 RVA: 0x001D2E91 File Offset: 0x001D1091
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600341D RID: 13341 RVA: 0x001D2EA0 File Offset: 0x001D10A0
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

		// Token: 0x04002056 RID: 8278
		private List<ColumnWithSortOrder> _columns = new List<ColumnWithSortOrder>();

		// Token: 0x04002057 RID: 8279
		private bool _isUnique;
	}
}
