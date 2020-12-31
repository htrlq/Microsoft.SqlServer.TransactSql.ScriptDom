using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000224 RID: 548
	[Serializable]
	public class OpenRowsetTableReference : TableReferenceWithAlias
	{
		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06002B65 RID: 11109 RVA: 0x001C9C75 File Offset: 0x001C7E75
		// (set) Token: 0x06002B66 RID: 11110 RVA: 0x001C9C7D File Offset: 0x001C7E7D
		public StringLiteral ProviderName
		{
			get
			{
				return this._providerName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._providerName = value;
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06002B67 RID: 11111 RVA: 0x001C9C8D File Offset: 0x001C7E8D
		// (set) Token: 0x06002B68 RID: 11112 RVA: 0x001C9C95 File Offset: 0x001C7E95
		public StringLiteral DataSource
		{
			get
			{
				return this._dataSource;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._dataSource = value;
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06002B69 RID: 11113 RVA: 0x001C9CA5 File Offset: 0x001C7EA5
		// (set) Token: 0x06002B6A RID: 11114 RVA: 0x001C9CAD File Offset: 0x001C7EAD
		public StringLiteral UserId
		{
			get
			{
				return this._userId;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._userId = value;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06002B6B RID: 11115 RVA: 0x001C9CBD File Offset: 0x001C7EBD
		// (set) Token: 0x06002B6C RID: 11116 RVA: 0x001C9CC5 File Offset: 0x001C7EC5
		public StringLiteral Password
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

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06002B6D RID: 11117 RVA: 0x001C9CD5 File Offset: 0x001C7ED5
		// (set) Token: 0x06002B6E RID: 11118 RVA: 0x001C9CDD File Offset: 0x001C7EDD
		public StringLiteral ProviderString
		{
			get
			{
				return this._providerString;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._providerString = value;
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06002B6F RID: 11119 RVA: 0x001C9CED File Offset: 0x001C7EED
		// (set) Token: 0x06002B70 RID: 11120 RVA: 0x001C9CF5 File Offset: 0x001C7EF5
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

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06002B71 RID: 11121 RVA: 0x001C9D05 File Offset: 0x001C7F05
		// (set) Token: 0x06002B72 RID: 11122 RVA: 0x001C9D0D File Offset: 0x001C7F0D
		public SchemaObjectName Object
		{
			get
			{
				return this._object;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._object = value;
			}
		}

		// Token: 0x06002B73 RID: 11123 RVA: 0x001C9D1D File Offset: 0x001C7F1D
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002B74 RID: 11124 RVA: 0x001C9D2C File Offset: 0x001C7F2C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.ProviderName != null)
			{
				this.ProviderName.Accept(visitor);
			}
			if (this.DataSource != null)
			{
				this.DataSource.Accept(visitor);
			}
			if (this.UserId != null)
			{
				this.UserId.Accept(visitor);
			}
			if (this.Password != null)
			{
				this.Password.Accept(visitor);
			}
			if (this.ProviderString != null)
			{
				this.ProviderString.Accept(visitor);
			}
			if (this.Query != null)
			{
				this.Query.Accept(visitor);
			}
			if (this.Object != null)
			{
				this.Object.Accept(visitor);
			}
		}

		// Token: 0x04001DDC RID: 7644
		private StringLiteral _providerName;

		// Token: 0x04001DDD RID: 7645
		private StringLiteral _dataSource;

		// Token: 0x04001DDE RID: 7646
		private StringLiteral _userId;

		// Token: 0x04001DDF RID: 7647
		private StringLiteral _password;

		// Token: 0x04001DE0 RID: 7648
		private StringLiteral _providerString;

		// Token: 0x04001DE1 RID: 7649
		private StringLiteral _query;

		// Token: 0x04001DE2 RID: 7650
		private SchemaObjectName _object;
	}
}
