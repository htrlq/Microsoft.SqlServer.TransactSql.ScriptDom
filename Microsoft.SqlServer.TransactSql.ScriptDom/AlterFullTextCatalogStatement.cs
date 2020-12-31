using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003D6 RID: 982
	[Serializable]
	public class AlterFullTextCatalogStatement : FullTextCatalogStatement
	{
		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x060035D7 RID: 13783 RVA: 0x001D4B3F File Offset: 0x001D2D3F
		// (set) Token: 0x060035D8 RID: 13784 RVA: 0x001D4B47 File Offset: 0x001D2D47
		public AlterFullTextCatalogAction Action
		{
			get
			{
				return this._action;
			}
			set
			{
				this._action = value;
			}
		}

		// Token: 0x060035D9 RID: 13785 RVA: 0x001D4B50 File Offset: 0x001D2D50
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060035DA RID: 13786 RVA: 0x001D4B5C File Offset: 0x001D2D5C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (base.Name != null)
			{
				base.Name.Accept(visitor);
			}
			int i = 0;
			int count = base.Options.Count;
			while (i < count)
			{
				base.Options[i].Accept(visitor);
				i++;
			}
		}

		// Token: 0x040020DD RID: 8413
		private AlterFullTextCatalogAction _action;
	}
}
