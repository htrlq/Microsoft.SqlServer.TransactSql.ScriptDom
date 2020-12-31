using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004BE RID: 1214
	[Serializable]
	public class GridParameter : TSqlFragment
	{
		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06003B0B RID: 15115 RVA: 0x001D9E81 File Offset: 0x001D8081
		// (set) Token: 0x06003B0C RID: 15116 RVA: 0x001D9E89 File Offset: 0x001D8089
		public GridParameterType Parameter
		{
			get
			{
				return this._parameter;
			}
			set
			{
				this._parameter = value;
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06003B0D RID: 15117 RVA: 0x001D9E92 File Offset: 0x001D8092
		// (set) Token: 0x06003B0E RID: 15118 RVA: 0x001D9E9A File Offset: 0x001D809A
		public ImportanceParameterType Value
		{
			get
			{
				return this._value;
			}
			set
			{
				this._value = value;
			}
		}

		// Token: 0x06003B0F RID: 15119 RVA: 0x001D9EA3 File Offset: 0x001D80A3
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003B10 RID: 15120 RVA: 0x001D9EAF File Offset: 0x001D80AF
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002244 RID: 8772
		private GridParameterType _parameter;

		// Token: 0x04002245 RID: 8773
		private ImportanceParameterType _value;
	}
}
