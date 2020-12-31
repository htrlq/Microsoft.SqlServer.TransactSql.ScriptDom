using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000343 RID: 835
	[Serializable]
	public class SetErrorLevelStatement : TSqlStatement
	{
		// Token: 0x1700037C RID: 892
		// (get) Token: 0x060031F3 RID: 12787 RVA: 0x001D0BCD File Offset: 0x001CEDCD
		// (set) Token: 0x060031F4 RID: 12788 RVA: 0x001D0BD5 File Offset: 0x001CEDD5
		public ScalarExpression Level
		{
			get
			{
				return this._level;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._level = value;
			}
		}

		// Token: 0x060031F5 RID: 12789 RVA: 0x001D0BE5 File Offset: 0x001CEDE5
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060031F6 RID: 12790 RVA: 0x001D0BF1 File Offset: 0x001CEDF1
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Level != null)
			{
				this.Level.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001FAA RID: 8106
		private ScalarExpression _level;
	}
}
