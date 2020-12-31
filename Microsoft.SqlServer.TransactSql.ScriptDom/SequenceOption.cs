using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000290 RID: 656
	[Serializable]
	public class SequenceOption : TSqlFragment
	{
		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06002DFF RID: 11775 RVA: 0x001CCAE1 File Offset: 0x001CACE1
		// (set) Token: 0x06002E00 RID: 11776 RVA: 0x001CCAE9 File Offset: 0x001CACE9
		public SequenceOptionKind OptionKind
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

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06002E01 RID: 11777 RVA: 0x001CCAF2 File Offset: 0x001CACF2
		// (set) Token: 0x06002E02 RID: 11778 RVA: 0x001CCAFA File Offset: 0x001CACFA
		public bool NoValue
		{
			get
			{
				return this._noValue;
			}
			set
			{
				this._noValue = value;
			}
		}

		// Token: 0x06002E03 RID: 11779 RVA: 0x001CCB03 File Offset: 0x001CAD03
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002E04 RID: 11780 RVA: 0x001CCB0F File Offset: 0x001CAD0F
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E9A RID: 7834
		private SequenceOptionKind _optionKind;

		// Token: 0x04001E9B RID: 7835
		private bool _noValue;
	}
}
