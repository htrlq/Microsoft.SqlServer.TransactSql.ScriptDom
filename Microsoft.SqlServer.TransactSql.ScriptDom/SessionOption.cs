using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004AF RID: 1199
	[Serializable]
	public abstract class SessionOption : TSqlFragment
	{
		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06003AB5 RID: 15029 RVA: 0x001D9969 File Offset: 0x001D7B69
		// (set) Token: 0x06003AB6 RID: 15030 RVA: 0x001D9971 File Offset: 0x001D7B71
		public SessionOptionKind OptionKind
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

		// Token: 0x06003AB7 RID: 15031 RVA: 0x001D997A File Offset: 0x001D7B7A
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400222C RID: 8748
		private SessionOptionKind _optionKind;
	}
}
