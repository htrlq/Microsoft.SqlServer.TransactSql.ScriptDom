using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000229 RID: 553
	[Serializable]
	public class SchemaDeclarationItem : TSqlFragment
	{
		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06002B90 RID: 11152 RVA: 0x001C9FE3 File Offset: 0x001C81E3
		// (set) Token: 0x06002B91 RID: 11153 RVA: 0x001C9FEB File Offset: 0x001C81EB
		public ColumnDefinitionBase ColumnDefinition
		{
			get
			{
				return this._columnDefinition;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._columnDefinition = value;
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06002B92 RID: 11154 RVA: 0x001C9FFB File Offset: 0x001C81FB
		// (set) Token: 0x06002B93 RID: 11155 RVA: 0x001CA003 File Offset: 0x001C8203
		public ValueExpression Mapping
		{
			get
			{
				return this._mapping;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._mapping = value;
			}
		}

		// Token: 0x06002B94 RID: 11156 RVA: 0x001CA013 File Offset: 0x001C8213
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002B95 RID: 11157 RVA: 0x001CA01F File Offset: 0x001C821F
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.ColumnDefinition != null)
			{
				this.ColumnDefinition.Accept(visitor);
			}
			if (this.Mapping != null)
			{
				this.Mapping.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001DEB RID: 7659
		private ColumnDefinitionBase _columnDefinition;

		// Token: 0x04001DEC RID: 7660
		private ValueExpression _mapping;
	}
}
