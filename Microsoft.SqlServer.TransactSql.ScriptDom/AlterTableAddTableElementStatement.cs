using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002AF RID: 687
	[Serializable]
	public class AlterTableAddTableElementStatement : AlterTableStatement
	{
		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06002E9F RID: 11935 RVA: 0x001CD4E2 File Offset: 0x001CB6E2
		// (set) Token: 0x06002EA0 RID: 11936 RVA: 0x001CD4EA File Offset: 0x001CB6EA
		public ConstraintEnforcement ExistingRowsCheckEnforcement
		{
			get
			{
				return this._existingRowsCheckEnforcement;
			}
			set
			{
				this._existingRowsCheckEnforcement = value;
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06002EA1 RID: 11937 RVA: 0x001CD4F3 File Offset: 0x001CB6F3
		// (set) Token: 0x06002EA2 RID: 11938 RVA: 0x001CD4FB File Offset: 0x001CB6FB
		public TableDefinition Definition
		{
			get
			{
				return this._definition;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._definition = value;
			}
		}

		// Token: 0x06002EA3 RID: 11939 RVA: 0x001CD50B File Offset: 0x001CB70B
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002EA4 RID: 11940 RVA: 0x001CD517 File Offset: 0x001CB717
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (base.SchemaObjectName != null)
			{
				base.SchemaObjectName.Accept(visitor);
			}
			if (this.Definition != null)
			{
				this.Definition.Accept(visitor);
			}
		}

		// Token: 0x04001EC1 RID: 7873
		private ConstraintEnforcement _existingRowsCheckEnforcement;

		// Token: 0x04001EC2 RID: 7874
		private TableDefinition _definition;
	}
}
