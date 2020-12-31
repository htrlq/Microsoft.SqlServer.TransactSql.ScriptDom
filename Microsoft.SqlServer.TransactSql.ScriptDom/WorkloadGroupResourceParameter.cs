using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000496 RID: 1174
	[Serializable]
	public class WorkloadGroupResourceParameter : WorkloadGroupParameter
	{
		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06003A22 RID: 14882 RVA: 0x001D8FB7 File Offset: 0x001D71B7
		// (set) Token: 0x06003A23 RID: 14883 RVA: 0x001D8FBF File Offset: 0x001D71BF
		public Literal ParameterValue
		{
			get
			{
				return this._parameterValue;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._parameterValue = value;
			}
		}

		// Token: 0x06003A24 RID: 14884 RVA: 0x001D8FCF File Offset: 0x001D71CF
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003A25 RID: 14885 RVA: 0x001D8FDB File Offset: 0x001D71DB
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.ParameterValue != null)
			{
				this.ParameterValue.Accept(visitor);
			}
		}

		// Token: 0x04002204 RID: 8708
		private Literal _parameterValue;
	}
}
