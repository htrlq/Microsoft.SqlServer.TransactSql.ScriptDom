using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200029F RID: 671
	[Serializable]
	public class AlterXmlSchemaCollectionStatement : TSqlStatement
	{
		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06002E4B RID: 11851 RVA: 0x001CD006 File Offset: 0x001CB206
		// (set) Token: 0x06002E4C RID: 11852 RVA: 0x001CD00E File Offset: 0x001CB20E
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

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06002E4D RID: 11853 RVA: 0x001CD01E File Offset: 0x001CB21E
		// (set) Token: 0x06002E4E RID: 11854 RVA: 0x001CD026 File Offset: 0x001CB226
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

		// Token: 0x06002E4F RID: 11855 RVA: 0x001CD036 File Offset: 0x001CB236
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002E50 RID: 11856 RVA: 0x001CD042 File Offset: 0x001CB242
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

		// Token: 0x04001EAD RID: 7853
		private SchemaObjectName _name;

		// Token: 0x04001EAE RID: 7854
		private ScalarExpression _expression;
	}
}
