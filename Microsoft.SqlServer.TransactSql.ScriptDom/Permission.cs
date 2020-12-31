using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200026C RID: 620
	[Serializable]
	public class Permission : TSqlFragment
	{
		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06002D37 RID: 11575 RVA: 0x001CBE67 File Offset: 0x001CA067
		public IList<Identifier> Identifiers
		{
			get
			{
				return this._identifiers;
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06002D38 RID: 11576 RVA: 0x001CBE6F File Offset: 0x001CA06F
		public IList<Identifier> Columns
		{
			get
			{
				return this._columns;
			}
		}

		// Token: 0x06002D39 RID: 11577 RVA: 0x001CBE77 File Offset: 0x001CA077
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002D3A RID: 11578 RVA: 0x001CBE84 File Offset: 0x001CA084
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.Identifiers.Count;
			while (i < count)
			{
				this.Identifiers[i].Accept(visitor);
				i++;
			}
			int j = 0;
			int count2 = this.Columns.Count;
			while (j < count2)
			{
				this.Columns[j].Accept(visitor);
				j++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E64 RID: 7780
		private List<Identifier> _identifiers = new List<Identifier>();

		// Token: 0x04001E65 RID: 7781
		private List<Identifier> _columns = new List<Identifier>();
	}
}
