using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200027E RID: 638
	[Serializable]
	public class ValuesInsertSource : InsertSource
	{
		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06002D9E RID: 11678 RVA: 0x001CC4FE File Offset: 0x001CA6FE
		// (set) Token: 0x06002D9F RID: 11679 RVA: 0x001CC506 File Offset: 0x001CA706
		public bool IsDefaultValues
		{
			get
			{
				return this._isDefaultValues;
			}
			set
			{
				this._isDefaultValues = value;
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06002DA0 RID: 11680 RVA: 0x001CC50F File Offset: 0x001CA70F
		public IList<RowValue> RowValues
		{
			get
			{
				return this._rowValues;
			}
		}

		// Token: 0x06002DA1 RID: 11681 RVA: 0x001CC517 File Offset: 0x001CA717
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002DA2 RID: 11682 RVA: 0x001CC524 File Offset: 0x001CA724
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.RowValues.Count;
			while (i < count)
			{
				this.RowValues[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E82 RID: 7810
		private bool _isDefaultValues;

		// Token: 0x04001E83 RID: 7811
		private List<RowValue> _rowValues = new List<RowValue>();
	}
}
