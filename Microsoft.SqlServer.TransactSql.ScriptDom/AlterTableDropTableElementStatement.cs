using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002B9 RID: 697
	[Serializable]
	public class AlterTableDropTableElementStatement : AlterTableStatement
	{
		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06002EDD RID: 11997 RVA: 0x001CD8F1 File Offset: 0x001CBAF1
		public IList<AlterTableDropTableElement> AlterTableDropTableElements
		{
			get
			{
				return this._alterTableDropTableElements;
			}
		}

		// Token: 0x06002EDE RID: 11998 RVA: 0x001CD8F9 File Offset: 0x001CBAF9
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002EDF RID: 11999 RVA: 0x001CD908 File Offset: 0x001CBB08
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (base.SchemaObjectName != null)
			{
				base.SchemaObjectName.Accept(visitor);
			}
			int i = 0;
			int count = this.AlterTableDropTableElements.Count;
			while (i < count)
			{
				this.AlterTableDropTableElements[i].Accept(visitor);
				i++;
			}
		}

		// Token: 0x04001ED4 RID: 7892
		private List<AlterTableDropTableElement> _alterTableDropTableElements = new List<AlterTableDropTableElement>();
	}
}
