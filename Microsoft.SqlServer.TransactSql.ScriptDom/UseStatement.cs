using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200032E RID: 814
	[Serializable]
	public class UseStatement : TSqlStatement
	{
		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06003187 RID: 12679 RVA: 0x001D068C File Offset: 0x001CE88C
		// (set) Token: 0x06003188 RID: 12680 RVA: 0x001D0694 File Offset: 0x001CE894
		public Identifier DatabaseName
		{
			get
			{
				return this._databaseName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._databaseName = value;
			}
		}

		// Token: 0x06003189 RID: 12681 RVA: 0x001D06A4 File Offset: 0x001CE8A4
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600318A RID: 12682 RVA: 0x001D06B0 File Offset: 0x001CE8B0
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.DatabaseName != null)
			{
				this.DatabaseName.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F92 RID: 8082
		private Identifier _databaseName;
	}
}
