using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004C4 RID: 1220
	[Serializable]
	public class AlterServerConfigurationBufferPoolExtensionContainerOption : AlterServerConfigurationBufferPoolExtensionOption
	{
		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06003B2B RID: 15147 RVA: 0x001DA05F File Offset: 0x001D825F
		public IList<AlterServerConfigurationBufferPoolExtensionOption> Suboptions
		{
			get
			{
				return this._suboptions;
			}
		}

		// Token: 0x06003B2C RID: 15148 RVA: 0x001DA067 File Offset: 0x001D8267
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003B2D RID: 15149 RVA: 0x001DA074 File Offset: 0x001D8274
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			int i = 0;
			int count = this.Suboptions.Count;
			while (i < count)
			{
				this.Suboptions[i].Accept(visitor);
				i++;
			}
		}

		// Token: 0x0400224C RID: 8780
		private List<AlterServerConfigurationBufferPoolExtensionOption> _suboptions = new List<AlterServerConfigurationBufferPoolExtensionOption>();
	}
}
