using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000353 RID: 851
	[Serializable]
	public class AlterDatabaseRemoveFileStatement : AlterDatabaseStatement
	{
		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x0600326A RID: 12906 RVA: 0x001D134D File Offset: 0x001CF54D
		// (set) Token: 0x0600326B RID: 12907 RVA: 0x001D1355 File Offset: 0x001CF555
		public Identifier File
		{
			get
			{
				return this._file;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._file = value;
			}
		}

		// Token: 0x0600326C RID: 12908 RVA: 0x001D1365 File Offset: 0x001CF565
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600326D RID: 12909 RVA: 0x001D1371 File Offset: 0x001CF571
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.File != null)
			{
				this.File.Accept(visitor);
			}
		}

		// Token: 0x04001FD1 RID: 8145
		private Identifier _file;
	}
}
