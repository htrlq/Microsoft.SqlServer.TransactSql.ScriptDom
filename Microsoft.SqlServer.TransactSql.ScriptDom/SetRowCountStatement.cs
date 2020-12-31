using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200033A RID: 826
	[Serializable]
	public class SetRowCountStatement : TSqlStatement
	{
		// Token: 0x17000373 RID: 883
		// (get) Token: 0x060031C8 RID: 12744 RVA: 0x001D0998 File Offset: 0x001CEB98
		// (set) Token: 0x060031C9 RID: 12745 RVA: 0x001D09A0 File Offset: 0x001CEBA0
		public ValueExpression NumberRows
		{
			get
			{
				return this._numberRows;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._numberRows = value;
			}
		}

		// Token: 0x060031CA RID: 12746 RVA: 0x001D09B0 File Offset: 0x001CEBB0
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060031CB RID: 12747 RVA: 0x001D09BC File Offset: 0x001CEBBC
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.NumberRows != null)
			{
				this.NumberRows.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001FA1 RID: 8097
		private ValueExpression _numberRows;
	}
}
