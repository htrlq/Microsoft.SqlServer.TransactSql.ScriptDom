using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004BD RID: 1213
	[Serializable]
	public class GridsSpatialIndexOption : SpatialIndexOption
	{
		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06003B07 RID: 15111 RVA: 0x001D9E1B File Offset: 0x001D801B
		public IList<GridParameter> GridParameters
		{
			get
			{
				return this._gridParameters;
			}
		}

		// Token: 0x06003B08 RID: 15112 RVA: 0x001D9E23 File Offset: 0x001D8023
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003B09 RID: 15113 RVA: 0x001D9E30 File Offset: 0x001D8030
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.GridParameters.Count;
			while (i < count)
			{
				this.GridParameters[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002243 RID: 8771
		private List<GridParameter> _gridParameters = new List<GridParameter>();
	}
}
