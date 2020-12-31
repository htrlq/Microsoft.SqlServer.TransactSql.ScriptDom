using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200046E RID: 1134
	[Serializable]
	public class CreateTypeTableStatement : CreateTypeStatement
	{
		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06003957 RID: 14679 RVA: 0x001D8415 File Offset: 0x001D6615
		// (set) Token: 0x06003958 RID: 14680 RVA: 0x001D841D File Offset: 0x001D661D
		public TableDefinition Definition
		{
			get
			{
				return this._definition;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._definition = value;
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06003959 RID: 14681 RVA: 0x001D842D File Offset: 0x001D662D
		public IList<TableOption> Options
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x0600395A RID: 14682 RVA: 0x001D8435 File Offset: 0x001D6635
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600395B RID: 14683 RVA: 0x001D8444 File Offset: 0x001D6644
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Definition != null)
			{
				this.Definition.Accept(visitor);
			}
			int i = 0;
			int count = this.Options.Count;
			while (i < count)
			{
				this.Options[i].Accept(visitor);
				i++;
			}
		}

		// Token: 0x040021D2 RID: 8658
		private TableDefinition _definition;

		// Token: 0x040021D3 RID: 8659
		private List<TableOption> _options = new List<TableOption>();
	}
}
