using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000235 RID: 565
	[Serializable]
	public class LeftFunctionCall : PrimaryExpression
	{
		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06002BE8 RID: 11240 RVA: 0x001CA605 File Offset: 0x001C8805
		public IList<ScalarExpression> Parameters
		{
			get
			{
				return this._parameters;
			}
		}

		// Token: 0x06002BE9 RID: 11241 RVA: 0x001CA60D File Offset: 0x001C880D
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002BEA RID: 11242 RVA: 0x001CA61C File Offset: 0x001C881C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			int i = 0;
			int count = this.Parameters.Count;
			while (i < count)
			{
				this.Parameters[i].Accept(visitor);
				i++;
			}
		}

		// Token: 0x04001E06 RID: 7686
		private List<ScalarExpression> _parameters = new List<ScalarExpression>();
	}
}
