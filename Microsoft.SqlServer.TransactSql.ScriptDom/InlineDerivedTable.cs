using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000202 RID: 514
	[Serializable]
	public class InlineDerivedTable : TableReferenceWithAliasAndColumns
	{
		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06002A82 RID: 10882 RVA: 0x001C8B97 File Offset: 0x001C6D97
		public IList<RowValue> RowValues
		{
			get
			{
				return this._rowValues;
			}
		}

		// Token: 0x06002A83 RID: 10883 RVA: 0x001C8B9F File Offset: 0x001C6D9F
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002A84 RID: 10884 RVA: 0x001C8BAC File Offset: 0x001C6DAC
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			int i = 0;
			int count = this.RowValues.Count;
			while (i < count)
			{
				this.RowValues[i].Accept(visitor);
				i++;
			}
		}

		// Token: 0x04001D93 RID: 7571
		private List<RowValue> _rowValues = new List<RowValue>();
	}
}
