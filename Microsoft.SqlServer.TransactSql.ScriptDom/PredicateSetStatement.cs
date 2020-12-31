using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000338 RID: 824
	[Serializable]
	public class PredicateSetStatement : SetOnOffStatement
	{
		// Token: 0x17000371 RID: 881
		// (get) Token: 0x060031BE RID: 12734 RVA: 0x001D093C File Offset: 0x001CEB3C
		// (set) Token: 0x060031BF RID: 12735 RVA: 0x001D0944 File Offset: 0x001CEB44
		public SetOptions Options
		{
			get
			{
				return this._options;
			}
			set
			{
				this._options = value;
			}
		}

		// Token: 0x060031C0 RID: 12736 RVA: 0x001D094D File Offset: 0x001CEB4D
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060031C1 RID: 12737 RVA: 0x001D0959 File Offset: 0x001CEB59
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F9F RID: 8095
		private SetOptions _options;
	}
}
