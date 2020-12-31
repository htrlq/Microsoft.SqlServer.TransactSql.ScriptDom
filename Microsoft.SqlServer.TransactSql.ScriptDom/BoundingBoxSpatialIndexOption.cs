using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004BB RID: 1211
	[Serializable]
	public class BoundingBoxSpatialIndexOption : SpatialIndexOption
	{
		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06003AFC RID: 15100 RVA: 0x001D9D5B File Offset: 0x001D7F5B
		public IList<BoundingBoxParameter> BoundingBoxParameters
		{
			get
			{
				return this._boundingBoxParameters;
			}
		}

		// Token: 0x06003AFD RID: 15101 RVA: 0x001D9D63 File Offset: 0x001D7F63
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003AFE RID: 15102 RVA: 0x001D9D70 File Offset: 0x001D7F70
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.BoundingBoxParameters.Count;
			while (i < count)
			{
				this.BoundingBoxParameters[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002240 RID: 8768
		private List<BoundingBoxParameter> _boundingBoxParameters = new List<BoundingBoxParameter>();
	}
}
