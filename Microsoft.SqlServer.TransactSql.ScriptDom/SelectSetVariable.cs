using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000401 RID: 1025
	[Serializable]
	public class SelectSetVariable : SelectElement
	{
		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x060036E3 RID: 14051 RVA: 0x001D5EC8 File Offset: 0x001D40C8
		// (set) Token: 0x060036E4 RID: 14052 RVA: 0x001D5ED0 File Offset: 0x001D40D0
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

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x060036E5 RID: 14053 RVA: 0x001D5EE0 File Offset: 0x001D40E0
		// (set) Token: 0x060036E6 RID: 14054 RVA: 0x001D5EE8 File Offset: 0x001D40E8
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

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x060036E7 RID: 14055 RVA: 0x001D5EF8 File Offset: 0x001D40F8
		// (set) Token: 0x060036E8 RID: 14056 RVA: 0x001D5F00 File Offset: 0x001D4100
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

		// Token: 0x060036E9 RID: 14057 RVA: 0x001D5F09 File Offset: 0x001D4109
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060036EA RID: 14058 RVA: 0x001D5F15 File Offset: 0x001D4115
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Variable != null)
			{
				this.Variable.Accept(visitor);
			}
			if (this.Expression != null)
			{
				this.Expression.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400212E RID: 8494
		private VariableReference _variable;

		// Token: 0x0400212F RID: 8495
		private ScalarExpression _expression;

		// Token: 0x04002130 RID: 8496
		private AssignmentKind _assignmentKind;
	}
}
