using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004BC RID: 1212
	[Serializable]
	public class BoundingBoxParameter : TSqlFragment
	{
		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06003B00 RID: 15104 RVA: 0x001D9DC1 File Offset: 0x001D7FC1
		// (set) Token: 0x06003B01 RID: 15105 RVA: 0x001D9DC9 File Offset: 0x001D7FC9
		public BoundingBoxParameterType Parameter
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

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06003B02 RID: 15106 RVA: 0x001D9DD2 File Offset: 0x001D7FD2
		// (set) Token: 0x06003B03 RID: 15107 RVA: 0x001D9DDA File Offset: 0x001D7FDA
		public ScalarExpression Value
		{
			get
			{
				return this._value;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._value = value;
			}
		}

		// Token: 0x06003B04 RID: 15108 RVA: 0x001D9DEA File Offset: 0x001D7FEA
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003B05 RID: 15109 RVA: 0x001D9DF6 File Offset: 0x001D7FF6
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Value != null)
			{
				this.Value.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002241 RID: 8769
		private BoundingBoxParameterType _parameter;

		// Token: 0x04002242 RID: 8770
		private ScalarExpression _value;
	}
}
