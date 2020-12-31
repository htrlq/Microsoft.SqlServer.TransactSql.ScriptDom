using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000363 RID: 867
	[Serializable]
	public class PageVerifyDatabaseOption : DatabaseOption
	{
		// Token: 0x170003BC RID: 956
		// (get) Token: 0x060032CB RID: 13003 RVA: 0x001D1819 File Offset: 0x001CFA19
		// (set) Token: 0x060032CC RID: 13004 RVA: 0x001D1821 File Offset: 0x001CFA21
		public PageVerifyDatabaseOptionKind Value
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

		// Token: 0x060032CD RID: 13005 RVA: 0x001D182A File Offset: 0x001CFA2A
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060032CE RID: 13006 RVA: 0x001D1836 File Offset: 0x001CFA36
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001FEA RID: 8170
		private PageVerifyDatabaseOptionKind _value;
	}
}
