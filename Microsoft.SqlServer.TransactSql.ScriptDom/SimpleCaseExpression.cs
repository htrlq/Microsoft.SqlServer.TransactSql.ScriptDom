using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200021C RID: 540
	[Serializable]
	public class SimpleCaseExpression : CaseExpression
	{
		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06002B1D RID: 11037 RVA: 0x001C965B File Offset: 0x001C785B
		// (set) Token: 0x06002B1E RID: 11038 RVA: 0x001C9663 File Offset: 0x001C7863
		public ScalarExpression InputExpression
		{
			get
			{
				return this._inputExpression;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._inputExpression = value;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06002B1F RID: 11039 RVA: 0x001C9673 File Offset: 0x001C7873
		public IList<SimpleWhenClause> WhenClauses
		{
			get
			{
				return this._whenClauses;
			}
		}

		// Token: 0x06002B20 RID: 11040 RVA: 0x001C967B File Offset: 0x001C787B
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002B21 RID: 11041 RVA: 0x001C9688 File Offset: 0x001C7888
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.InputExpression != null)
			{
				this.InputExpression.Accept(visitor);
			}
			int i = 0;
			int count = this.WhenClauses.Count;
			while (i < count)
			{
				this.WhenClauses[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001DC1 RID: 7617
		private ScalarExpression _inputExpression;

		// Token: 0x04001DC2 RID: 7618
		private List<SimpleWhenClause> _whenClauses = new List<SimpleWhenClause>();
	}
}
