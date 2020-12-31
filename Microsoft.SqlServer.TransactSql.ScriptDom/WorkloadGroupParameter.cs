using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000495 RID: 1173
	[Serializable]
	public abstract class WorkloadGroupParameter : TSqlFragment
	{
		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06003A1E RID: 14878 RVA: 0x001D8F95 File Offset: 0x001D7195
		// (set) Token: 0x06003A1F RID: 14879 RVA: 0x001D8F9D File Offset: 0x001D719D
		public WorkloadGroupParameterType ParameterType
		{
			get
			{
				return this._parameterType;
			}
			set
			{
				this._parameterType = value;
			}
		}

		// Token: 0x06003A20 RID: 14880 RVA: 0x001D8FA6 File Offset: 0x001D71A6
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002203 RID: 8707
		private WorkloadGroupParameterType _parameterType;
	}
}
