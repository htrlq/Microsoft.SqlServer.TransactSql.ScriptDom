using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000434 RID: 1076
	[Serializable]
	public class WindowsCreateLoginSource : CreateLoginSource
	{
		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06003801 RID: 14337 RVA: 0x001D6F33 File Offset: 0x001D5133
		public IList<PrincipalOption> Options
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x06003802 RID: 14338 RVA: 0x001D6F3B File Offset: 0x001D513B
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003803 RID: 14339 RVA: 0x001D6F48 File Offset: 0x001D5148
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

		// Token: 0x04002175 RID: 8565
		private List<PrincipalOption> _options = new List<PrincipalOption>();
	}
}
