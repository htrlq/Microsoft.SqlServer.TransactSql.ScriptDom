using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000383 RID: 899
	[Serializable]
	public class RestoreOption : TSqlFragment
	{
		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x060033C1 RID: 13249 RVA: 0x001D28CE File Offset: 0x001D0ACE
		// (set) Token: 0x060033C2 RID: 13250 RVA: 0x001D28D6 File Offset: 0x001D0AD6
		public RestoreOptionKind OptionKind
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

		// Token: 0x060033C3 RID: 13251 RVA: 0x001D28DF File Offset: 0x001D0ADF
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060033C4 RID: 13252 RVA: 0x001D28EB File Offset: 0x001D0AEB
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400203E RID: 8254
		private RestoreOptionKind _optionKind;
	}
}
