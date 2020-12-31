using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000384 RID: 900
	[Serializable]
	public class ScalarExpressionRestoreOption : RestoreOption
	{
		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x060033C6 RID: 13254 RVA: 0x001D28FC File Offset: 0x001D0AFC
		// (set) Token: 0x060033C7 RID: 13255 RVA: 0x001D2904 File Offset: 0x001D0B04
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

		// Token: 0x060033C8 RID: 13256 RVA: 0x001D2914 File Offset: 0x001D0B14
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060033C9 RID: 13257 RVA: 0x001D2920 File Offset: 0x001D0B20
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Value != null)
			{
				this.Value.Accept(visitor);
			}
		}

		// Token: 0x0400203F RID: 8255
		private ScalarExpression _value;
	}
}
