using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003DD RID: 989
	[Serializable]
	public class ComputeClause : TSqlFragment
	{
		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06003601 RID: 13825 RVA: 0x001D4E91 File Offset: 0x001D3091
		public IList<ComputeFunction> ComputeFunctions
		{
			get
			{
				return this._computeFunctions;
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06003602 RID: 13826 RVA: 0x001D4E99 File Offset: 0x001D3099
		public IList<ScalarExpression> ByExpressions
		{
			get
			{
				return this._byExpressions;
			}
		}

		// Token: 0x06003603 RID: 13827 RVA: 0x001D4EA1 File Offset: 0x001D30A1
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003604 RID: 13828 RVA: 0x001D4EB0 File Offset: 0x001D30B0
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.ComputeFunctions.Count;
			while (i < count)
			{
				this.ComputeFunctions[i].Accept(visitor);
				i++;
			}
			int j = 0;
			int count2 = this.ByExpressions.Count;
			while (j < count2)
			{
				this.ByExpressions[j].Accept(visitor);
				j++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x040020E9 RID: 8425
		private List<ComputeFunction> _computeFunctions = new List<ComputeFunction>();

		// Token: 0x040020EA RID: 8426
		private List<ScalarExpression> _byExpressions = new List<ScalarExpression>();
	}
}
