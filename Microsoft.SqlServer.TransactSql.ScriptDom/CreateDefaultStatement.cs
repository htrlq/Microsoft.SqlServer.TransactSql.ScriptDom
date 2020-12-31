using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200024D RID: 589
	[Serializable]
	public class CreateDefaultStatement : TSqlStatement
	{
		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06002C62 RID: 11362 RVA: 0x001CAE24 File Offset: 0x001C9024
		// (set) Token: 0x06002C63 RID: 11363 RVA: 0x001CAE2C File Offset: 0x001C902C
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

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06002C64 RID: 11364 RVA: 0x001CAE3C File Offset: 0x001C903C
		// (set) Token: 0x06002C65 RID: 11365 RVA: 0x001CAE44 File Offset: 0x001C9044
		public ScalarExpression Expression
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

		// Token: 0x06002C66 RID: 11366 RVA: 0x001CAE54 File Offset: 0x001C9054
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002C67 RID: 11367 RVA: 0x001CAE60 File Offset: 0x001C9060
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

		// Token: 0x04001E23 RID: 7715
		private SchemaObjectName _name;

		// Token: 0x04001E24 RID: 7716
		private ScalarExpression _expression;
	}
}
