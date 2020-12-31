using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200039B RID: 923
	[Serializable]
	public abstract class RemoteServiceBindingStatementBase : TSqlStatement
	{
		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06003467 RID: 13415 RVA: 0x001D33B9 File Offset: 0x001D15B9
		// (set) Token: 0x06003468 RID: 13416 RVA: 0x001D33C1 File Offset: 0x001D15C1
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

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06003469 RID: 13417 RVA: 0x001D33D1 File Offset: 0x001D15D1
		public IList<RemoteServiceBindingOption> Options
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x0600346A RID: 13418 RVA: 0x001D33DC File Offset: 0x001D15DC
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

		// Token: 0x04002072 RID: 8306
		private Identifier _name;

		// Token: 0x04002073 RID: 8307
		private List<RemoteServiceBindingOption> _options = new List<RemoteServiceBindingOption>();
	}
}
