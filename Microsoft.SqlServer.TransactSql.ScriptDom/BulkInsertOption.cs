using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000390 RID: 912
	[Serializable]
	public class BulkInsertOption : TSqlFragment
	{
		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x0600340F RID: 13327 RVA: 0x001D2E01 File Offset: 0x001D1001
		// (set) Token: 0x06003410 RID: 13328 RVA: 0x001D2E09 File Offset: 0x001D1009
		public BulkInsertOptionKind OptionKind
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

		// Token: 0x06003411 RID: 13329 RVA: 0x001D2E12 File Offset: 0x001D1012
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003412 RID: 13330 RVA: 0x001D2E1E File Offset: 0x001D101E
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002054 RID: 8276
		private BulkInsertOptionKind _optionKind;
	}
}
