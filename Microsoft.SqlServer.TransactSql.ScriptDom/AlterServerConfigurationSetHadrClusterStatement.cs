using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004CB RID: 1227
	[Serializable]
	public class AlterServerConfigurationSetHadrClusterStatement : TSqlStatement
	{
		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06003B4F RID: 15183 RVA: 0x001DA2A3 File Offset: 0x001D84A3
		public IList<AlterServerConfigurationHadrClusterOption> Options
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x06003B50 RID: 15184 RVA: 0x001DA2AB File Offset: 0x001D84AB
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003B51 RID: 15185 RVA: 0x001DA2B8 File Offset: 0x001D84B8
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.Options.Count;
			while (i < count)
			{
				this.Options[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002255 RID: 8789
		private List<AlterServerConfigurationHadrClusterOption> _options = new List<AlterServerConfigurationHadrClusterOption>();
	}
}
