using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200021F RID: 543
	[Serializable]
	public class CoalesceExpression : PrimaryExpression
	{
		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06002B2E RID: 11054 RVA: 0x001C97CA File Offset: 0x001C79CA
		public IList<ScalarExpression> Expressions
		{
			get
			{
				return this._expressions;
			}
		}

		// Token: 0x06002B2F RID: 11055 RVA: 0x001C97D2 File Offset: 0x001C79D2
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002B30 RID: 11056 RVA: 0x001C97E0 File Offset: 0x001C79E0
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			int i = 0;
			int count = this.Expressions.Count;
			while (i < count)
			{
				this.Expressions[i].Accept(visitor);
				i++;
			}
		}

		// Token: 0x04001DC6 RID: 7622
		private List<ScalarExpression> _expressions = new List<ScalarExpression>();
	}
}
