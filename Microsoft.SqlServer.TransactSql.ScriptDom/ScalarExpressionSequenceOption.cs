using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000292 RID: 658
	[Serializable]
	public class ScalarExpressionSequenceOption : SequenceOption
	{
		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06002E0B RID: 11787 RVA: 0x001CCB69 File Offset: 0x001CAD69
		// (set) Token: 0x06002E0C RID: 11788 RVA: 0x001CCB71 File Offset: 0x001CAD71
		public ScalarExpression OptionValue
		{
			get
			{
				return this._optionValue;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._optionValue = value;
			}
		}

		// Token: 0x06002E0D RID: 11789 RVA: 0x001CCB81 File Offset: 0x001CAD81
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002E0E RID: 11790 RVA: 0x001CCB8D File Offset: 0x001CAD8D
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.OptionValue != null)
			{
				this.OptionValue.Accept(visitor);
			}
		}

		// Token: 0x04001E9D RID: 7837
		private ScalarExpression _optionValue;
	}
}
