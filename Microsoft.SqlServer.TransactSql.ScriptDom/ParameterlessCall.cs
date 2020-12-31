using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000239 RID: 569
	[Serializable]
	public class ParameterlessCall : PrimaryExpression
	{
		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06002C00 RID: 11264 RVA: 0x001CA855 File Offset: 0x001C8A55
		// (set) Token: 0x06002C01 RID: 11265 RVA: 0x001CA85D File Offset: 0x001C8A5D
		public ParameterlessCallType ParameterlessCallType
		{
			get
			{
				return this._parameterlessCallType;
			}
			set
			{
				this._parameterlessCallType = value;
			}
		}

		// Token: 0x06002C02 RID: 11266 RVA: 0x001CA866 File Offset: 0x001C8A66
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002C03 RID: 11267 RVA: 0x001CA872 File Offset: 0x001C8A72
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E0E RID: 7694
		private ParameterlessCallType _parameterlessCallType;
	}
}
