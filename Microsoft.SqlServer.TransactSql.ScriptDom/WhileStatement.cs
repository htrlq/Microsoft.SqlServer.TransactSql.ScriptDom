using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000256 RID: 598
	[Serializable]
	public class WhileStatement : TSqlStatement
	{
		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06002C9C RID: 11420 RVA: 0x001CB28D File Offset: 0x001C948D
		// (set) Token: 0x06002C9D RID: 11421 RVA: 0x001CB295 File Offset: 0x001C9495
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

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06002C9E RID: 11422 RVA: 0x001CB2A5 File Offset: 0x001C94A5
		// (set) Token: 0x06002C9F RID: 11423 RVA: 0x001CB2AD File Offset: 0x001C94AD
		public TSqlStatement Statement
		{
			get
			{
				return this._statement;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._statement = value;
			}
		}

		// Token: 0x06002CA0 RID: 11424 RVA: 0x001CB2BD File Offset: 0x001C94BD
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002CA1 RID: 11425 RVA: 0x001CB2C9 File Offset: 0x001C94C9
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Predicate != null)
			{
				this.Predicate.Accept(visitor);
			}
			if (this.Statement != null)
			{
				this.Statement.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E33 RID: 7731
		private BooleanExpression _predicate;

		// Token: 0x04001E34 RID: 7732
		private TSqlStatement _statement;
	}
}
