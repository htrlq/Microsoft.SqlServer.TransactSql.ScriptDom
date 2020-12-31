using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000439 RID: 1081
	[Serializable]
	public class AlterLoginOptionsStatement : AlterLoginStatement
	{
		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06003824 RID: 14372 RVA: 0x001D7168 File Offset: 0x001D5368
		public IList<PrincipalOption> Options
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x06003825 RID: 14373 RVA: 0x001D7170 File Offset: 0x001D5370
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003826 RID: 14374 RVA: 0x001D717C File Offset: 0x001D537C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			int i = 0;
			int count = this.Options.Count;
			while (i < count)
			{
				this.Options[i].Accept(visitor);
				i++;
			}
		}

		// Token: 0x04002180 RID: 8576
		private List<PrincipalOption> _options = new List<PrincipalOption>();
	}
}
