using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000340 RID: 832
	[Serializable]
	public class SetTransactionIsolationLevelStatement : TSqlStatement
	{
		// Token: 0x17000379 RID: 889
		// (get) Token: 0x060031E4 RID: 12772 RVA: 0x001D0B0D File Offset: 0x001CED0D
		// (set) Token: 0x060031E5 RID: 12773 RVA: 0x001D0B15 File Offset: 0x001CED15
		public IsolationLevel Level
		{
			get
			{
				return this._level;
			}
			set
			{
				this._level = value;
			}
		}

		// Token: 0x060031E6 RID: 12774 RVA: 0x001D0B1E File Offset: 0x001CED1E
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060031E7 RID: 12775 RVA: 0x001D0B2A File Offset: 0x001CED2A
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001FA7 RID: 8103
		private IsolationLevel _level;
	}
}
