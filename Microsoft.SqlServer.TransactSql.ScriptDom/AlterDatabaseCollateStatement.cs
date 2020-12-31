using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200034E RID: 846
	[Serializable]
	public class AlterDatabaseCollateStatement : AlterDatabaseStatement, ICollationSetter
	{
		// Token: 0x1700039A RID: 922
		// (get) Token: 0x0600324A RID: 12874 RVA: 0x001D1163 File Offset: 0x001CF363
		// (set) Token: 0x0600324B RID: 12875 RVA: 0x001D116B File Offset: 0x001CF36B
		public Identifier Collation
		{
			get
			{
				return this._collation;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._collation = value;
			}
		}

		// Token: 0x0600324C RID: 12876 RVA: 0x001D117B File Offset: 0x001CF37B
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600324D RID: 12877 RVA: 0x001D1187 File Offset: 0x001CF387
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Collation != null)
			{
				this.Collation.Accept(visitor);
			}
		}

		// Token: 0x04001FC8 RID: 8136
		private Identifier _collation;
	}
}
