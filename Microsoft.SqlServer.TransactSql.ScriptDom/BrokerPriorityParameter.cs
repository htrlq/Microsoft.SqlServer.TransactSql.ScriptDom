using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200049C RID: 1180
	[Serializable]
	public class BrokerPriorityParameter : TSqlFragment
	{
		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06003A3A RID: 14906 RVA: 0x001D910D File Offset: 0x001D730D
		// (set) Token: 0x06003A3B RID: 14907 RVA: 0x001D9115 File Offset: 0x001D7315
		public BrokerPriorityParameterSpecialType IsDefaultOrAny
		{
			get
			{
				return this._isDefaultOrAny;
			}
			set
			{
				this._isDefaultOrAny = value;
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06003A3C RID: 14908 RVA: 0x001D911E File Offset: 0x001D731E
		// (set) Token: 0x06003A3D RID: 14909 RVA: 0x001D9126 File Offset: 0x001D7326
		public BrokerPriorityParameterType ParameterType
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

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06003A3E RID: 14910 RVA: 0x001D912F File Offset: 0x001D732F
		// (set) Token: 0x06003A3F RID: 14911 RVA: 0x001D9137 File Offset: 0x001D7337
		public IdentifierOrValueExpression ParameterValue
		{
			get
			{
				return this._parameterValue;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._parameterValue = value;
			}
		}

		// Token: 0x06003A40 RID: 14912 RVA: 0x001D9147 File Offset: 0x001D7347
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003A41 RID: 14913 RVA: 0x001D9153 File Offset: 0x001D7353
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.ParameterValue != null)
			{
				this.ParameterValue.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002208 RID: 8712
		private BrokerPriorityParameterSpecialType _isDefaultOrAny;

		// Token: 0x04002209 RID: 8713
		private BrokerPriorityParameterType _parameterType;

		// Token: 0x0400220A RID: 8714
		private IdentifierOrValueExpression _parameterValue;
	}
}
