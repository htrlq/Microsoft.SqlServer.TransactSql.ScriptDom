using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002C5 RID: 709
	[Serializable]
	public class QueueValueOption : QueueOption
	{
		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06002F27 RID: 12071 RVA: 0x001CDDAB File Offset: 0x001CBFAB
		// (set) Token: 0x06002F28 RID: 12072 RVA: 0x001CDDB3 File Offset: 0x001CBFB3
		public ValueExpression OptionValue
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

		// Token: 0x06002F29 RID: 12073 RVA: 0x001CDDC3 File Offset: 0x001CBFC3
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002F2A RID: 12074 RVA: 0x001CDDCF File Offset: 0x001CBFCF
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.OptionValue != null)
			{
				this.OptionValue.Accept(visitor);
			}
		}

		// Token: 0x04001EE9 RID: 7913
		private ValueExpression _optionValue;
	}
}
