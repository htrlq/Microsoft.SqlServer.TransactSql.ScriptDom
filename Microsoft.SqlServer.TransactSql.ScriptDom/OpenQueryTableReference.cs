using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000227 RID: 551
	[Serializable]
	public class OpenQueryTableReference : TableReferenceWithAlias
	{
		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06002B82 RID: 11138 RVA: 0x001C9EF9 File Offset: 0x001C80F9
		// (set) Token: 0x06002B83 RID: 11139 RVA: 0x001C9F01 File Offset: 0x001C8101
		public Identifier LinkedServer
		{
			get
			{
				return this._linkedServer;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._linkedServer = value;
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06002B84 RID: 11140 RVA: 0x001C9F11 File Offset: 0x001C8111
		// (set) Token: 0x06002B85 RID: 11141 RVA: 0x001C9F19 File Offset: 0x001C8119
		public StringLiteral Query
		{
			get
			{
				return this._query;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._query = value;
			}
		}

		// Token: 0x06002B86 RID: 11142 RVA: 0x001C9F29 File Offset: 0x001C8129
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002B87 RID: 11143 RVA: 0x001C9F35 File Offset: 0x001C8135
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.LinkedServer != null)
			{
				this.LinkedServer.Accept(visitor);
			}
			if (this.Query != null)
			{
				this.Query.Accept(visitor);
			}
		}

		// Token: 0x04001DE7 RID: 7655
		private Identifier _linkedServer;

		// Token: 0x04001DE8 RID: 7656
		private StringLiteral _query;
	}
}
