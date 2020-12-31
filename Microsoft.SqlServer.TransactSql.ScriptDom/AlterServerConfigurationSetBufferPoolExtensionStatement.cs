using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004C2 RID: 1218
	[Serializable]
	public class AlterServerConfigurationSetBufferPoolExtensionStatement : TSqlStatement
	{
		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06003B20 RID: 15136 RVA: 0x001D9F9E File Offset: 0x001D819E
		public IList<AlterServerConfigurationBufferPoolExtensionOption> Options
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x06003B21 RID: 15137 RVA: 0x001D9FA6 File Offset: 0x001D81A6
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003B22 RID: 15138 RVA: 0x001D9FB4 File Offset: 0x001D81B4
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

		// Token: 0x04002249 RID: 8777
		private List<AlterServerConfigurationBufferPoolExtensionOption> _options = new List<AlterServerConfigurationBufferPoolExtensionOption>();
	}
}
