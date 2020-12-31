using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003D2 RID: 978
	[Serializable]
	public abstract class FullTextCatalogStatement : TSqlStatement
	{
		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x060035BE RID: 13758 RVA: 0x001D4973 File Offset: 0x001D2B73
		// (set) Token: 0x060035BF RID: 13759 RVA: 0x001D497B File Offset: 0x001D2B7B
		public Identifier Name
		{
			get
			{
				return this._name;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._name = value;
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x060035C0 RID: 13760 RVA: 0x001D498B File Offset: 0x001D2B8B
		public IList<FullTextCatalogOption> Options
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x060035C1 RID: 13761 RVA: 0x001D4994 File Offset: 0x001D2B94
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			int i = 0;
			int count = this.Options.Count;
			while (i < count)
			{
				this.Options[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x040020D5 RID: 8405
		private Identifier _name;

		// Token: 0x040020D6 RID: 8406
		private List<FullTextCatalogOption> _options = new List<FullTextCatalogOption>();
	}
}
