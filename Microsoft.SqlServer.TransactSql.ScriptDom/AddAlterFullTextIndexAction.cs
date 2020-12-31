using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000425 RID: 1061
	[Serializable]
	public class AddAlterFullTextIndexAction : AlterFullTextIndexAction
	{
		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x060037A8 RID: 14248 RVA: 0x001D69C5 File Offset: 0x001D4BC5
		public IList<FullTextIndexColumn> Columns
		{
			get
			{
				return this._columns;
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x060037A9 RID: 14249 RVA: 0x001D69CD File Offset: 0x001D4BCD
		// (set) Token: 0x060037AA RID: 14250 RVA: 0x001D69D5 File Offset: 0x001D4BD5
		public bool WithNoPopulation
		{
			get
			{
				return this._withNoPopulation;
			}
			set
			{
				this._withNoPopulation = value;
			}
		}

		// Token: 0x060037AB RID: 14251 RVA: 0x001D69DE File Offset: 0x001D4BDE
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060037AC RID: 14252 RVA: 0x001D69EC File Offset: 0x001D4BEC
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

		// Token: 0x0400215D RID: 8541
		private List<FullTextIndexColumn> _columns = new List<FullTextIndexColumn>();

		// Token: 0x0400215E RID: 8542
		private bool _withNoPopulation;
	}
}
