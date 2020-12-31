using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000395 RID: 917
	[Serializable]
	public class DbccOption : TSqlFragment
	{
		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06003433 RID: 13363 RVA: 0x001D3032 File Offset: 0x001D1232
		// (set) Token: 0x06003434 RID: 13364 RVA: 0x001D303A File Offset: 0x001D123A
		public DbccOptionKind OptionKind
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

		// Token: 0x06003435 RID: 13365 RVA: 0x001D3043 File Offset: 0x001D1243
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003436 RID: 13366 RVA: 0x001D304F File Offset: 0x001D124F
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002060 RID: 8288
		private DbccOptionKind _optionKind;
	}
}
