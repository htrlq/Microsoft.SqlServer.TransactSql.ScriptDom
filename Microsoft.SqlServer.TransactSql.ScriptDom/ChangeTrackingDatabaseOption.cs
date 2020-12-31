using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000369 RID: 873
	[Serializable]
	public class ChangeTrackingDatabaseOption : DatabaseOption
	{
		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x060032EF RID: 13039 RVA: 0x001D19E7 File Offset: 0x001CFBE7
		// (set) Token: 0x060032F0 RID: 13040 RVA: 0x001D19EF File Offset: 0x001CFBEF
		public OptionState OptionState
		{
			get
			{
				return this._optionState;
			}
			set
			{
				this._optionState = value;
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x060032F1 RID: 13041 RVA: 0x001D19F8 File Offset: 0x001CFBF8
		public IList<ChangeTrackingOptionDetail> Details
		{
			get
			{
				return this._details;
			}
		}

		// Token: 0x060032F2 RID: 13042 RVA: 0x001D1A00 File Offset: 0x001CFC00
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060032F3 RID: 13043 RVA: 0x001D1A0C File Offset: 0x001CFC0C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			int i = 0;
			int count = this.Details.Count;
			while (i < count)
			{
				this.Details[i].Accept(visitor);
				i++;
			}
		}

		// Token: 0x04001FF3 RID: 8179
		private OptionState _optionState;

		// Token: 0x04001FF4 RID: 8180
		private List<ChangeTrackingOptionDetail> _details = new List<ChangeTrackingOptionDetail>();
	}
}
