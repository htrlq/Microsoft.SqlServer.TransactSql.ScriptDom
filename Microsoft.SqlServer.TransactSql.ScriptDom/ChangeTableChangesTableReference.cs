using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000403 RID: 1027
	[Serializable]
	public class ChangeTableChangesTableReference : TableReferenceWithAliasAndColumns
	{
		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x060036F1 RID: 14065 RVA: 0x001D5F97 File Offset: 0x001D4197
		// (set) Token: 0x060036F2 RID: 14066 RVA: 0x001D5F9F File Offset: 0x001D419F
		public SchemaObjectName Target
		{
			get
			{
				return this._target;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._target = value;
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x060036F3 RID: 14067 RVA: 0x001D5FAF File Offset: 0x001D41AF
		// (set) Token: 0x060036F4 RID: 14068 RVA: 0x001D5FB7 File Offset: 0x001D41B7
		public ValueExpression SinceVersion
		{
			get
			{
				return this._sinceVersion;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._sinceVersion = value;
			}
		}

		// Token: 0x060036F5 RID: 14069 RVA: 0x001D5FC7 File Offset: 0x001D41C7
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060036F6 RID: 14070 RVA: 0x001D5FD3 File Offset: 0x001D41D3
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Target != null)
			{
				this.Target.Accept(visitor);
			}
			if (this.SinceVersion != null)
			{
				this.SinceVersion.Accept(visitor);
			}
		}

		// Token: 0x04002132 RID: 8498
		private SchemaObjectName _target;

		// Token: 0x04002133 RID: 8499
		private ValueExpression _sinceVersion;
	}
}
