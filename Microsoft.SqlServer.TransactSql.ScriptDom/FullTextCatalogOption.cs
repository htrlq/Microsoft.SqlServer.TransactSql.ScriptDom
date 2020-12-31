using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003D3 RID: 979
	[Serializable]
	public abstract class FullTextCatalogOption : TSqlFragment
	{
		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x060035C3 RID: 13763 RVA: 0x001D49F9 File Offset: 0x001D2BF9
		// (set) Token: 0x060035C4 RID: 13764 RVA: 0x001D4A01 File Offset: 0x001D2C01
		public FullTextCatalogOptionKind OptionKind
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

		// Token: 0x060035C5 RID: 13765 RVA: 0x001D4A0A File Offset: 0x001D2C0A
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x040020D7 RID: 8407
		private FullTextCatalogOptionKind _optionKind;
	}
}
