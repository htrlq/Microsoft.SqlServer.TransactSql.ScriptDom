using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001F0 RID: 496
	[Serializable]
	public abstract class ParameterizedDataTypeReference : DataTypeReference
	{
		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06002A28 RID: 10792 RVA: 0x001C8530 File Offset: 0x001C6730
		public IList<Literal> Parameters
		{
			get
			{
				return this._parameters;
			}
		}

		// Token: 0x06002A29 RID: 10793 RVA: 0x001C8538 File Offset: 0x001C6738
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

		// Token: 0x04001D7B RID: 7547
		private List<Literal> _parameters = new List<Literal>();
	}
}
