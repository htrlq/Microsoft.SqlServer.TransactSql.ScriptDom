using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002A0 RID: 672
	[Serializable]
	public class DropXmlSchemaCollectionStatement : TSqlStatement
	{
		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06002E52 RID: 11858 RVA: 0x001CD07B File Offset: 0x001CB27B
		// (set) Token: 0x06002E53 RID: 11859 RVA: 0x001CD083 File Offset: 0x001CB283
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

		// Token: 0x06002E54 RID: 11860 RVA: 0x001CD093 File Offset: 0x001CB293
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002E55 RID: 11861 RVA: 0x001CD09F File Offset: 0x001CB29F
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001EAF RID: 7855
		private SchemaObjectName _name;
	}
}
