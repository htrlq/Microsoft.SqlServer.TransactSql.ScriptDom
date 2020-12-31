using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002C6 RID: 710
	[Serializable]
	public class QueueExecuteAsOption : QueueOption
	{
		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06002F2C RID: 12076 RVA: 0x001CDDF4 File Offset: 0x001CBFF4
		// (set) Token: 0x06002F2D RID: 12077 RVA: 0x001CDDFC File Offset: 0x001CBFFC
		public ExecuteAsClause OptionValue
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

		// Token: 0x06002F2E RID: 12078 RVA: 0x001CDE0C File Offset: 0x001CC00C
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002F2F RID: 12079 RVA: 0x001CDE18 File Offset: 0x001CC018
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.OptionValue != null)
			{
				this.OptionValue.Accept(visitor);
			}
		}

		// Token: 0x04001EEA RID: 7914
		private ExecuteAsClause _optionValue;
	}
}
