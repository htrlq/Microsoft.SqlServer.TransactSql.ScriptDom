using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003E9 RID: 1001
	[Serializable]
	public class ExpressionWithSortOrder : TSqlFragment
	{
		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x0600365B RID: 13915 RVA: 0x001D54C7 File Offset: 0x001D36C7
		// (set) Token: 0x0600365C RID: 13916 RVA: 0x001D54CF File Offset: 0x001D36CF
		public SortOrder SortOrder
		{
			get
			{
				return this._sortOrder;
			}
			set
			{
				this._sortOrder = value;
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x0600365D RID: 13917 RVA: 0x001D54D8 File Offset: 0x001D36D8
		// (set) Token: 0x0600365E RID: 13918 RVA: 0x001D54E0 File Offset: 0x001D36E0
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

		// Token: 0x0600365F RID: 13919 RVA: 0x001D54F0 File Offset: 0x001D36F0
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003660 RID: 13920 RVA: 0x001D54FC File Offset: 0x001D36FC
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Expression != null)
			{
				this.Expression.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002107 RID: 8455
		private SortOrder _sortOrder;

		// Token: 0x04002108 RID: 8456
		private ScalarExpression _expression;
	}
}
