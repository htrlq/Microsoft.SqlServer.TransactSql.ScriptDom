using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003E4 RID: 996
	[Serializable]
	public class BooleanNotExpression : BooleanExpression
	{
		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06003638 RID: 13880 RVA: 0x001D52CF File Offset: 0x001D34CF
		// (set) Token: 0x06003639 RID: 13881 RVA: 0x001D52D7 File Offset: 0x001D34D7
		public BooleanExpression Expression
		{
			get
			{
				return this._expression;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._expression = value;
			}
		}

		// Token: 0x0600363A RID: 13882 RVA: 0x001D52E7 File Offset: 0x001D34E7
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600363B RID: 13883 RVA: 0x001D52F3 File Offset: 0x001D34F3
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Expression != null)
			{
				this.Expression.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x040020FD RID: 8445
		private BooleanExpression _expression;
	}
}
