using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200031A RID: 794
	[Serializable]
	public class DropDatabaseStatement : TSqlStatement
	{
		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06003126 RID: 12582 RVA: 0x001D0046 File Offset: 0x001CE246
		public IList<Identifier> Databases
		{
			get
			{
				return this._databases;
			}
		}

		// Token: 0x06003127 RID: 12583 RVA: 0x001D004E File Offset: 0x001CE24E
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003128 RID: 12584 RVA: 0x001D005C File Offset: 0x001CE25C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.Databases.Count;
			while (i < count)
			{
				this.Databases[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F7C RID: 8060
		private List<Identifier> _databases = new List<Identifier>();
	}
}
