using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000458 RID: 1112
	[Serializable]
	public abstract class BackupRestoreMasterKeyStatementBase : TSqlStatement
	{
		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x060038E8 RID: 14568 RVA: 0x001D7DCB File Offset: 0x001D5FCB
		// (set) Token: 0x060038E9 RID: 14569 RVA: 0x001D7DD3 File Offset: 0x001D5FD3
		public Literal File
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

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x060038EA RID: 14570 RVA: 0x001D7DE3 File Offset: 0x001D5FE3
		// (set) Token: 0x060038EB RID: 14571 RVA: 0x001D7DEB File Offset: 0x001D5FEB
		public Literal Password
		{
			get
			{
				return this._password;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._password = value;
			}
		}

		// Token: 0x060038EC RID: 14572 RVA: 0x001D7DFB File Offset: 0x001D5FFB
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.File != null)
			{
				this.File.Accept(visitor);
			}
			if (this.Password != null)
			{
				this.Password.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x040021B8 RID: 8632
		private Literal _file;

		// Token: 0x040021B9 RID: 8633
		private Literal _password;
	}
}
