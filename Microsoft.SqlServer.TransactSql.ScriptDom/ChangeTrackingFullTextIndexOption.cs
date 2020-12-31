using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002E2 RID: 738
	[Serializable]
	public class ChangeTrackingFullTextIndexOption : FullTextIndexOption
	{
		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06002FEF RID: 12271 RVA: 0x001CED28 File Offset: 0x001CCF28
		// (set) Token: 0x06002FF0 RID: 12272 RVA: 0x001CED30 File Offset: 0x001CCF30
		public ChangeTrackingOption Value
		{
			get
			{
				return this._value;
			}
			set
			{
				this._value = value;
			}
		}

		// Token: 0x06002FF1 RID: 12273 RVA: 0x001CED39 File Offset: 0x001CCF39
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002FF2 RID: 12274 RVA: 0x001CED45 File Offset: 0x001CCF45
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F2B RID: 7979
		private ChangeTrackingOption _value;
	}
}
