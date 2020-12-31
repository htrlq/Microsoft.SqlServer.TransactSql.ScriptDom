using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000253 RID: 595
	[Serializable]
	public class IfStatement : TSqlStatement
	{
		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06002C87 RID: 11399 RVA: 0x001CB172 File Offset: 0x001C9372
		// (set) Token: 0x06002C88 RID: 11400 RVA: 0x001CB17A File Offset: 0x001C937A
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

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06002C89 RID: 11401 RVA: 0x001CB18A File Offset: 0x001C938A
		// (set) Token: 0x06002C8A RID: 11402 RVA: 0x001CB192 File Offset: 0x001C9392
		public TSqlStatement ThenStatement
		{
			get
			{
				return this._thenStatement;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._thenStatement = value;
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06002C8B RID: 11403 RVA: 0x001CB1A2 File Offset: 0x001C93A2
		// (set) Token: 0x06002C8C RID: 11404 RVA: 0x001CB1AA File Offset: 0x001C93AA
		public TSqlStatement ElseStatement
		{
			get
			{
				return this._elseStatement;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._elseStatement = value;
			}
		}

		// Token: 0x06002C8D RID: 11405 RVA: 0x001CB1BA File Offset: 0x001C93BA
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002C8E RID: 11406 RVA: 0x001CB1C8 File Offset: 0x001C93C8
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Predicate != null)
			{
				this.Predicate.Accept(visitor);
			}
			if (this.ThenStatement != null)
			{
				this.ThenStatement.Accept(visitor);
			}
			if (this.ElseStatement != null)
			{
				this.ElseStatement.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E2D RID: 7725
		private BooleanExpression _predicate;

		// Token: 0x04001E2E RID: 7726
		private TSqlStatement _thenStatement;

		// Token: 0x04001E2F RID: 7727
		private TSqlStatement _elseStatement;
	}
}
