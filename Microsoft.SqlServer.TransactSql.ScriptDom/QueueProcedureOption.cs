using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002C4 RID: 708
	[Serializable]
	public class QueueProcedureOption : QueueOption
	{
		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06002F22 RID: 12066 RVA: 0x001CDD62 File Offset: 0x001CBF62
		// (set) Token: 0x06002F23 RID: 12067 RVA: 0x001CDD6A File Offset: 0x001CBF6A
		public SchemaObjectName OptionValue
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

		// Token: 0x06002F24 RID: 12068 RVA: 0x001CDD7A File Offset: 0x001CBF7A
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002F25 RID: 12069 RVA: 0x001CDD86 File Offset: 0x001CBF86
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.OptionValue != null)
			{
				this.OptionValue.Accept(visitor);
			}
		}

		// Token: 0x04001EE8 RID: 7912
		private SchemaObjectName _optionValue;
	}
}
