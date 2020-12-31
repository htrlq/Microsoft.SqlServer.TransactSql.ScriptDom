using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001CB RID: 459
	[Serializable]
	public class ExecuteParameter : TSqlFragment
	{
		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06002952 RID: 10578 RVA: 0x001C7586 File Offset: 0x001C5786
		// (set) Token: 0x06002953 RID: 10579 RVA: 0x001C758E File Offset: 0x001C578E
		public VariableReference Variable
		{
			get
			{
				return this._variable;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._variable = value;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06002954 RID: 10580 RVA: 0x001C759E File Offset: 0x001C579E
		// (set) Token: 0x06002955 RID: 10581 RVA: 0x001C75A6 File Offset: 0x001C57A6
		public ScalarExpression ParameterValue
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

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06002956 RID: 10582 RVA: 0x001C75B6 File Offset: 0x001C57B6
		// (set) Token: 0x06002957 RID: 10583 RVA: 0x001C75BE File Offset: 0x001C57BE
		public bool IsOutput
		{
			get
			{
				return this._isOutput;
			}
			set
			{
				this._isOutput = value;
			}
		}

		// Token: 0x06002958 RID: 10584 RVA: 0x001C75C7 File Offset: 0x001C57C7
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002959 RID: 10585 RVA: 0x001C75D3 File Offset: 0x001C57D3
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Variable != null)
			{
				this.Variable.Accept(visitor);
			}
			if (this.ParameterValue != null)
			{
				this.ParameterValue.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001D3D RID: 7485
		private VariableReference _variable;

		// Token: 0x04001D3E RID: 7486
		private ScalarExpression _parameterValue;

		// Token: 0x04001D3F RID: 7487
		private bool _isOutput;
	}
}
