using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004C9 RID: 1225
	[Serializable]
	public class AlterServerConfigurationSetFailoverClusterPropertyStatement : TSqlStatement
	{
		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06003B44 RID: 15172 RVA: 0x001DA1E1 File Offset: 0x001D83E1
		public IList<AlterServerConfigurationFailoverClusterPropertyOption> Options
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x06003B45 RID: 15173 RVA: 0x001DA1E9 File Offset: 0x001D83E9
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003B46 RID: 15174 RVA: 0x001DA1F8 File Offset: 0x001D83F8
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

		// Token: 0x04002252 RID: 8786
		private List<AlterServerConfigurationFailoverClusterPropertyOption> _options = new List<AlterServerConfigurationFailoverClusterPropertyOption>();
	}
}
