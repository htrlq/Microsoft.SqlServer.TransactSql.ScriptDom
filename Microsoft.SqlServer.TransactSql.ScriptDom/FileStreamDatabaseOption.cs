using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200036D RID: 877
	[Serializable]
	public class FileStreamDatabaseOption : DatabaseOption
	{
		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06003303 RID: 13059 RVA: 0x001D1AF6 File Offset: 0x001CFCF6
		// (set) Token: 0x06003304 RID: 13060 RVA: 0x001D1AFE File Offset: 0x001CFCFE
		public NonTransactedFileStreamAccess? NonTransactedAccess
		{
			get
			{
				return this._nonTransactedAccess;
			}
			set
			{
				this._nonTransactedAccess = value;
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06003305 RID: 13061 RVA: 0x001D1B07 File Offset: 0x001CFD07
		// (set) Token: 0x06003306 RID: 13062 RVA: 0x001D1B0F File Offset: 0x001CFD0F
		public Literal DirectoryName
		{
			get
			{
				return this._directoryName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._directoryName = value;
			}
		}

		// Token: 0x06003307 RID: 13063 RVA: 0x001D1B1F File Offset: 0x001CFD1F
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003308 RID: 13064 RVA: 0x001D1B2B File Offset: 0x001CFD2B
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.DirectoryName != null)
			{
				this.DirectoryName.Accept(visitor);
			}
		}

		// Token: 0x04001FF8 RID: 8184
		private NonTransactedFileStreamAccess? _nonTransactedAccess;

		// Token: 0x04001FF9 RID: 8185
		private Literal _directoryName;
	}
}
