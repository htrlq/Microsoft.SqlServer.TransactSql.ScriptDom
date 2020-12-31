using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000277 RID: 631
	[Serializable]
	public class Privilege80 : TSqlFragment
	{
		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06002D7B RID: 11643 RVA: 0x001CC2CA File Offset: 0x001CA4CA
		public IList<Identifier> Columns
		{
			get
			{
				return this._columns;
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06002D7C RID: 11644 RVA: 0x001CC2D2 File Offset: 0x001CA4D2
		// (set) Token: 0x06002D7D RID: 11645 RVA: 0x001CC2DA File Offset: 0x001CA4DA
		public PrivilegeType80 PrivilegeType80
		{
			get
			{
				return this._privilegeType80;
			}
			set
			{
				this._privilegeType80 = value;
			}
		}

		// Token: 0x06002D7E RID: 11646 RVA: 0x001CC2E3 File Offset: 0x001CA4E3
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002D7F RID: 11647 RVA: 0x001CC2F0 File Offset: 0x001CA4F0
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

		// Token: 0x04001E79 RID: 7801
		private List<Identifier> _columns = new List<Identifier>();

		// Token: 0x04001E7A RID: 7802
		private PrivilegeType80 _privilegeType80;
	}
}
