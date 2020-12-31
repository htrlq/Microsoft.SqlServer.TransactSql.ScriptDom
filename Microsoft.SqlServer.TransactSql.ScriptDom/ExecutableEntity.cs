using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001CC RID: 460
	[Serializable]
	public abstract class ExecutableEntity : TSqlFragment
	{
		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600295B RID: 10587 RVA: 0x001C760C File Offset: 0x001C580C
		public IList<ExecuteParameter> Parameters
		{
			get
			{
				return this._parameters;
			}
		}

		// Token: 0x0600295C RID: 10588 RVA: 0x001C7614 File Offset: 0x001C5814
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.Parameters.Count;
			while (i < count)
			{
				this.Parameters[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001D40 RID: 7488
		private List<ExecuteParameter> _parameters = new List<ExecuteParameter>();
	}
}
