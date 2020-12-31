using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200030A RID: 778
	[Serializable]
	public class CursorDefinition : TSqlFragment
	{
		// Token: 0x17000332 RID: 818
		// (get) Token: 0x060030C2 RID: 12482 RVA: 0x001CFA34 File Offset: 0x001CDC34
		public IList<CursorOption> Options
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x060030C3 RID: 12483 RVA: 0x001CFA3C File Offset: 0x001CDC3C
		// (set) Token: 0x060030C4 RID: 12484 RVA: 0x001CFA44 File Offset: 0x001CDC44
		public SelectStatement Select
		{
			get
			{
				return this._select;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._select = value;
			}
		}

		// Token: 0x060030C5 RID: 12485 RVA: 0x001CFA54 File Offset: 0x001CDC54
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060030C6 RID: 12486 RVA: 0x001CFA60 File Offset: 0x001CDC60
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.Options.Count;
			while (i < count)
			{
				this.Options[i].Accept(visitor);
				i++;
			}
			if (this.Select != null)
			{
				this.Select.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F60 RID: 8032
		private List<CursorOption> _options = new List<CursorOption>();

		// Token: 0x04001F61 RID: 8033
		private SelectStatement _select;
	}
}
