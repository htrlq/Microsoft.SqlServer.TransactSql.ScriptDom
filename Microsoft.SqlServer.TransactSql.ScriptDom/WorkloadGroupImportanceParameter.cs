using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000497 RID: 1175
	[Serializable]
	public class WorkloadGroupImportanceParameter : WorkloadGroupParameter
	{
		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06003A27 RID: 14887 RVA: 0x001D9000 File Offset: 0x001D7200
		// (set) Token: 0x06003A28 RID: 14888 RVA: 0x001D9008 File Offset: 0x001D7208
		public ImportanceParameterType ParameterValue
		{
			get
			{
				return this._parameterValue;
			}
			set
			{
				this._parameterValue = value;
			}
		}

		// Token: 0x06003A29 RID: 14889 RVA: 0x001D9011 File Offset: 0x001D7211
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003A2A RID: 14890 RVA: 0x001D901D File Offset: 0x001D721D
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002205 RID: 8709
		private ImportanceParameterType _parameterValue;
	}
}
