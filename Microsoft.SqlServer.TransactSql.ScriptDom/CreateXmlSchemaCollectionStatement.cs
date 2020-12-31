using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200029E RID: 670
	[Serializable]
	public class CreateXmlSchemaCollectionStatement : TSqlStatement
	{
		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06002E44 RID: 11844 RVA: 0x001CCF91 File Offset: 0x001CB191
		// (set) Token: 0x06002E45 RID: 11845 RVA: 0x001CCF99 File Offset: 0x001CB199
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

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06002E46 RID: 11846 RVA: 0x001CCFA9 File Offset: 0x001CB1A9
		// (set) Token: 0x06002E47 RID: 11847 RVA: 0x001CCFB1 File Offset: 0x001CB1B1
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

		// Token: 0x06002E48 RID: 11848 RVA: 0x001CCFC1 File Offset: 0x001CB1C1
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002E49 RID: 11849 RVA: 0x001CCFCD File Offset: 0x001CB1CD
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

		// Token: 0x04001EAB RID: 7851
		private SchemaObjectName _name;

		// Token: 0x04001EAC RID: 7852
		private ScalarExpression _expression;
	}
}
