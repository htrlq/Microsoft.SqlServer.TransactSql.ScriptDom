using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000204 RID: 516
	[Serializable]
	public class SubqueryComparisonPredicate : BooleanExpression
	{
		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06002A88 RID: 10888 RVA: 0x001C8C0E File Offset: 0x001C6E0E
		// (set) Token: 0x06002A89 RID: 10889 RVA: 0x001C8C16 File Offset: 0x001C6E16
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

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06002A8A RID: 10890 RVA: 0x001C8C26 File Offset: 0x001C6E26
		// (set) Token: 0x06002A8B RID: 10891 RVA: 0x001C8C2E File Offset: 0x001C6E2E
		public BooleanComparisonType ComparisonType
		{
			get
			{
				return this._comparisonType;
			}
			set
			{
				this._comparisonType = value;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06002A8C RID: 10892 RVA: 0x001C8C37 File Offset: 0x001C6E37
		// (set) Token: 0x06002A8D RID: 10893 RVA: 0x001C8C3F File Offset: 0x001C6E3F
		public ScalarSubquery Subquery
		{
			get
			{
				return this._subquery;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._subquery = value;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06002A8E RID: 10894 RVA: 0x001C8C4F File Offset: 0x001C6E4F
		// (set) Token: 0x06002A8F RID: 10895 RVA: 0x001C8C57 File Offset: 0x001C6E57
		public SubqueryComparisonPredicateType SubqueryComparisonPredicateType
		{
			get
			{
				return this._subqueryComparisonPredicateType;
			}
			set
			{
				this._subqueryComparisonPredicateType = value;
			}
		}

		// Token: 0x06002A90 RID: 10896 RVA: 0x001C8C60 File Offset: 0x001C6E60
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002A91 RID: 10897 RVA: 0x001C8C6C File Offset: 0x001C6E6C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Expression != null)
			{
				this.Expression.Accept(visitor);
			}
			if (this.Subquery != null)
			{
				this.Subquery.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001D94 RID: 7572
		private ScalarExpression _expression;

		// Token: 0x04001D95 RID: 7573
		private BooleanComparisonType _comparisonType;

		// Token: 0x04001D96 RID: 7574
		private ScalarSubquery _subquery;

		// Token: 0x04001D97 RID: 7575
		private SubqueryComparisonPredicateType _subqueryComparisonPredicateType;
	}
}
