using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000219 RID: 537
	[Serializable]
	public class SimpleWhenClause : WhenClause
	{
		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06002B0F RID: 11023 RVA: 0x001C958C File Offset: 0x001C778C
		// (set) Token: 0x06002B10 RID: 11024 RVA: 0x001C9594 File Offset: 0x001C7794
		public ScalarExpression WhenExpression
		{
			get
			{
				return this._whenExpression;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._whenExpression = value;
			}
		}

		// Token: 0x06002B11 RID: 11025 RVA: 0x001C95A4 File Offset: 0x001C77A4
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002B12 RID: 11026 RVA: 0x001C95B0 File Offset: 0x001C77B0
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.WhenExpression != null)
			{
				this.WhenExpression.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001DBE RID: 7614
		private ScalarExpression _whenExpression;
	}
}
