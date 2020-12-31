using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004C6 RID: 1222
	[Serializable]
	public class AlterServerConfigurationSetDiagnosticsLogStatement : TSqlStatement
	{
		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06003B34 RID: 15156 RVA: 0x001DA0F3 File Offset: 0x001D82F3
		public IList<AlterServerConfigurationDiagnosticsLogOption> Options
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x06003B35 RID: 15157 RVA: 0x001DA0FB File Offset: 0x001D82FB
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003B36 RID: 15158 RVA: 0x001DA108 File Offset: 0x001D8308
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

		// Token: 0x0400224E RID: 8782
		private List<AlterServerConfigurationDiagnosticsLogOption> _options = new List<AlterServerConfigurationDiagnosticsLogOption>();
	}
}
