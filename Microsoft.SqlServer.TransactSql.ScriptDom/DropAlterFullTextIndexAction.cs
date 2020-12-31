using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000424 RID: 1060
	[Serializable]
	public class DropAlterFullTextIndexAction : AlterFullTextIndexAction
	{
		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x060037A2 RID: 14242 RVA: 0x001D694C File Offset: 0x001D4B4C
		public IList<Identifier> Columns
		{
			get
			{
				return this._columns;
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x060037A3 RID: 14243 RVA: 0x001D6954 File Offset: 0x001D4B54
		// (set) Token: 0x060037A4 RID: 14244 RVA: 0x001D695C File Offset: 0x001D4B5C
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

		// Token: 0x060037A5 RID: 14245 RVA: 0x001D6965 File Offset: 0x001D4B65
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060037A6 RID: 14246 RVA: 0x001D6974 File Offset: 0x001D4B74
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

		// Token: 0x0400215B RID: 8539
		private List<Identifier> _columns = new List<Identifier>();

		// Token: 0x0400215C RID: 8540
		private bool _withNoPopulation;
	}
}
