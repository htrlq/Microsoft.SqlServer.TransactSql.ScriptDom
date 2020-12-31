using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200027B RID: 635
	[Serializable]
	public class AssignmentSetClause : SetClause
	{
		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06002D8C RID: 11660 RVA: 0x001CC3E7 File Offset: 0x001CA5E7
		// (set) Token: 0x06002D8D RID: 11661 RVA: 0x001CC3EF File Offset: 0x001CA5EF
		public VariableReference Variable
		{
			get
			{
				return this._variable;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._variable = value;
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06002D8E RID: 11662 RVA: 0x001CC3FF File Offset: 0x001CA5FF
		// (set) Token: 0x06002D8F RID: 11663 RVA: 0x001CC407 File Offset: 0x001CA607
		public ColumnReferenceExpression Column
		{
			get
			{
				return this._column;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._column = value;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06002D90 RID: 11664 RVA: 0x001CC417 File Offset: 0x001CA617
		// (set) Token: 0x06002D91 RID: 11665 RVA: 0x001CC41F File Offset: 0x001CA61F
		public ScalarExpression NewValue
		{
			get
			{
				return this._newValue;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._newValue = value;
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06002D92 RID: 11666 RVA: 0x001CC42F File Offset: 0x001CA62F
		// (set) Token: 0x06002D93 RID: 11667 RVA: 0x001CC437 File Offset: 0x001CA637
		public AssignmentKind AssignmentKind
		{
			get
			{
				return this._assignmentKind;
			}
			set
			{
				this._assignmentKind = value;
			}
		}

		// Token: 0x06002D94 RID: 11668 RVA: 0x001CC440 File Offset: 0x001CA640
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002D95 RID: 11669 RVA: 0x001CC44C File Offset: 0x001CA64C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Variable != null)
			{
				this.Variable.Accept(visitor);
			}
			if (this.Column != null)
			{
				this.Column.Accept(visitor);
			}
			if (this.NewValue != null)
			{
				this.NewValue.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E7D RID: 7805
		private VariableReference _variable;

		// Token: 0x04001E7E RID: 7806
		private ColumnReferenceExpression _column;

		// Token: 0x04001E7F RID: 7807
		private ScalarExpression _newValue;

		// Token: 0x04001E80 RID: 7808
		private AssignmentKind _assignmentKind;
	}
}
