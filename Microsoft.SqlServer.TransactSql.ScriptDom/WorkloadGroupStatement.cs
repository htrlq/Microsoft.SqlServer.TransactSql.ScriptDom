using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000494 RID: 1172
	[Serializable]
	public abstract class WorkloadGroupStatement : TSqlStatement
	{
		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06003A17 RID: 14871 RVA: 0x001D8EE4 File Offset: 0x001D70E4
		// (set) Token: 0x06003A18 RID: 14872 RVA: 0x001D8EEC File Offset: 0x001D70EC
		public Identifier Name
		{
			get
			{
				return this._name;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._name = value;
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06003A19 RID: 14873 RVA: 0x001D8EFC File Offset: 0x001D70FC
		public IList<WorkloadGroupParameter> WorkloadGroupParameters
		{
			get
			{
				return this._workloadGroupParameters;
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06003A1A RID: 14874 RVA: 0x001D8F04 File Offset: 0x001D7104
		// (set) Token: 0x06003A1B RID: 14875 RVA: 0x001D8F0C File Offset: 0x001D710C
		public Identifier PoolName
		{
			get
			{
				return this._poolName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._poolName = value;
			}
		}

		// Token: 0x06003A1C RID: 14876 RVA: 0x001D8F1C File Offset: 0x001D711C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			int i = 0;
			int count = this.WorkloadGroupParameters.Count;
			while (i < count)
			{
				this.WorkloadGroupParameters[i].Accept(visitor);
				i++;
			}
			if (this.PoolName != null)
			{
				this.PoolName.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002200 RID: 8704
		private Identifier _name;

		// Token: 0x04002201 RID: 8705
		private List<WorkloadGroupParameter> _workloadGroupParameters = new List<WorkloadGroupParameter>();

		// Token: 0x04002202 RID: 8706
		private Identifier _poolName;
	}
}
