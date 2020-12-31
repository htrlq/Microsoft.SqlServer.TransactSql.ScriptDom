using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000236 RID: 566
	[Serializable]
	public class RightFunctionCall : PrimaryExpression
	{
		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06002BEC RID: 11244 RVA: 0x001CA66D File Offset: 0x001C886D
		public IList<ScalarExpression> Parameters
		{
			get
			{
				return this._parameters;
			}
		}

		// Token: 0x06002BED RID: 11245 RVA: 0x001CA675 File Offset: 0x001C8875
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002BEE RID: 11246 RVA: 0x001CA684 File Offset: 0x001C8884
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

		// Token: 0x04001E07 RID: 7687
		private List<ScalarExpression> _parameters = new List<ScalarExpression>();
	}
}
