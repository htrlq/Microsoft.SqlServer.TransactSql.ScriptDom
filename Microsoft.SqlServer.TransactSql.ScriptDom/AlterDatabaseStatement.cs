using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200034D RID: 845
	[Serializable]
	public abstract class AlterDatabaseStatement : TSqlStatement
	{
		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06003244 RID: 12868 RVA: 0x001D1115 File Offset: 0x001CF315
		// (set) Token: 0x06003245 RID: 12869 RVA: 0x001D111D File Offset: 0x001CF31D
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

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06003246 RID: 12870 RVA: 0x001D112D File Offset: 0x001CF32D
		// (set) Token: 0x06003247 RID: 12871 RVA: 0x001D1135 File Offset: 0x001CF335
		public bool UseCurrent
		{
			get
			{
				return this._useCurrent;
			}
			set
			{
				this._useCurrent = value;
			}
		}

		// Token: 0x06003248 RID: 12872 RVA: 0x001D113E File Offset: 0x001CF33E
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.DatabaseName != null)
			{
				this.DatabaseName.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001FC6 RID: 8134
		private Identifier _databaseName;

		// Token: 0x04001FC7 RID: 8135
		private bool _useCurrent;
	}
}
