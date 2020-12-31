using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001E3 RID: 483
	[Serializable]
	public class ProcedureOption : TSqlFragment
	{
		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060029E9 RID: 10729 RVA: 0x001C8125 File Offset: 0x001C6325
		// (set) Token: 0x060029EA RID: 10730 RVA: 0x001C812D File Offset: 0x001C632D
		public ProcedureOptionKind OptionKind
		{
			get
			{
				return this._optionKind;
			}
			set
			{
				this._optionKind = value;
			}
		}

		// Token: 0x060029EB RID: 10731 RVA: 0x001C8136 File Offset: 0x001C6336
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060029EC RID: 10732 RVA: 0x001C8142 File Offset: 0x001C6342
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001D6C RID: 7532
		private ProcedureOptionKind _optionKind;
	}
}
