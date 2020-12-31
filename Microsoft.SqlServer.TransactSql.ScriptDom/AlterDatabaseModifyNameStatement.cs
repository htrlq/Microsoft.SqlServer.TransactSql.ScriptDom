using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000354 RID: 852
	[Serializable]
	public class AlterDatabaseModifyNameStatement : AlterDatabaseStatement
	{
		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x0600326F RID: 12911 RVA: 0x001D1396 File Offset: 0x001CF596
		// (set) Token: 0x06003270 RID: 12912 RVA: 0x001D139E File Offset: 0x001CF59E
		public Identifier NewDatabaseName
		{
			get
			{
				return this._newDatabaseName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._newDatabaseName = value;
			}
		}

		// Token: 0x06003271 RID: 12913 RVA: 0x001D13AE File Offset: 0x001CF5AE
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003272 RID: 12914 RVA: 0x001D13BA File Offset: 0x001CF5BA
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.NewDatabaseName != null)
			{
				this.NewDatabaseName.Accept(visitor);
			}
		}

		// Token: 0x04001FD2 RID: 8146
		private Identifier _newDatabaseName;
	}
}
