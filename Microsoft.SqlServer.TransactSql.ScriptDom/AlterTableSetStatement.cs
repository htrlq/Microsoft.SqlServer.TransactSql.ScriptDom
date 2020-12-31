using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002A6 RID: 678
	[Serializable]
	public class AlterTableSetStatement : AlterTableStatement
	{
		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06002E74 RID: 11892 RVA: 0x001CD29D File Offset: 0x001CB49D
		public IList<TableOption> Options
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x06002E75 RID: 11893 RVA: 0x001CD2A5 File Offset: 0x001CB4A5
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002E76 RID: 11894 RVA: 0x001CD2B4 File Offset: 0x001CB4B4
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (base.SchemaObjectName != null)
			{
				base.SchemaObjectName.Accept(visitor);
			}
			int i = 0;
			int count = this.Options.Count;
			while (i < count)
			{
				this.Options[i].Accept(visitor);
				i++;
			}
		}

		// Token: 0x04001EB8 RID: 7864
		private List<TableOption> _options = new List<TableOption>();
	}
}
