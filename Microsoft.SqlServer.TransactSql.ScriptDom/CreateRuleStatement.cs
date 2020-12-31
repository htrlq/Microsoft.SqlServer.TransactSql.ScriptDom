using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200024F RID: 591
	[Serializable]
	public class CreateRuleStatement : TSqlStatement
	{
		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06002C6C RID: 11372 RVA: 0x001CAF75 File Offset: 0x001C9175
		// (set) Token: 0x06002C6D RID: 11373 RVA: 0x001CAF7D File Offset: 0x001C917D
		public SchemaObjectName Name
		{
			get
			{
				return this._name;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._name = value;
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06002C6E RID: 11374 RVA: 0x001CAF8D File Offset: 0x001C918D
		// (set) Token: 0x06002C6F RID: 11375 RVA: 0x001CAF95 File Offset: 0x001C9195
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

		// Token: 0x06002C70 RID: 11376 RVA: 0x001CAFA5 File Offset: 0x001C91A5
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002C71 RID: 11377 RVA: 0x001CAFB1 File Offset: 0x001C91B1
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			if (this.Expression != null)
			{
				this.Expression.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E25 RID: 7717
		private SchemaObjectName _name;

		// Token: 0x04001E26 RID: 7718
		private BooleanExpression _expression;
	}
}
