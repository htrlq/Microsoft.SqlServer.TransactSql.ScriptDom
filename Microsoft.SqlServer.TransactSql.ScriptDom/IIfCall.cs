using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000220 RID: 544
	[Serializable]
	public class IIfCall : PrimaryExpression
	{
		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06002B32 RID: 11058 RVA: 0x001C9831 File Offset: 0x001C7A31
		// (set) Token: 0x06002B33 RID: 11059 RVA: 0x001C9839 File Offset: 0x001C7A39
		public BooleanExpression Predicate
		{
			get
			{
				return this._predicate;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._predicate = value;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06002B34 RID: 11060 RVA: 0x001C9849 File Offset: 0x001C7A49
		// (set) Token: 0x06002B35 RID: 11061 RVA: 0x001C9851 File Offset: 0x001C7A51
		public ScalarExpression ThenExpression
		{
			get
			{
				return this._thenExpression;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._thenExpression = value;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06002B36 RID: 11062 RVA: 0x001C9861 File Offset: 0x001C7A61
		// (set) Token: 0x06002B37 RID: 11063 RVA: 0x001C9869 File Offset: 0x001C7A69
		public ScalarExpression ElseExpression
		{
			get
			{
				return this._elseExpression;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._elseExpression = value;
			}
		}

		// Token: 0x06002B38 RID: 11064 RVA: 0x001C9879 File Offset: 0x001C7A79
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002B39 RID: 11065 RVA: 0x001C9888 File Offset: 0x001C7A88
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Predicate != null)
			{
				this.Predicate.Accept(visitor);
			}
			if (this.ThenExpression != null)
			{
				this.ThenExpression.Accept(visitor);
			}
			if (this.ElseExpression != null)
			{
				this.ElseExpression.Accept(visitor);
			}
		}

		// Token: 0x04001DC7 RID: 7623
		private BooleanExpression _predicate;

		// Token: 0x04001DC8 RID: 7624
		private ScalarExpression _thenExpression;

		// Token: 0x04001DC9 RID: 7625
		private ScalarExpression _elseExpression;
	}
}
