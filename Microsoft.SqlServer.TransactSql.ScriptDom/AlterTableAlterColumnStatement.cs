using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200036F RID: 879
	[Serializable]
	public class AlterTableAlterColumnStatement : AlterTableStatement, ICollationSetter
	{
		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06003311 RID: 13073 RVA: 0x001D1BAA File Offset: 0x001CFDAA
		// (set) Token: 0x06003312 RID: 13074 RVA: 0x001D1BB2 File Offset: 0x001CFDB2
		public Identifier ColumnIdentifier
		{
			get
			{
				return this._columnIdentifier;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._columnIdentifier = value;
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06003313 RID: 13075 RVA: 0x001D1BC2 File Offset: 0x001CFDC2
		// (set) Token: 0x06003314 RID: 13076 RVA: 0x001D1BCA File Offset: 0x001CFDCA
		public DataTypeReference DataType
		{
			get
			{
				return this._dataType;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._dataType = value;
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06003315 RID: 13077 RVA: 0x001D1BDA File Offset: 0x001CFDDA
		// (set) Token: 0x06003316 RID: 13078 RVA: 0x001D1BE2 File Offset: 0x001CFDE2
		public AlterTableAlterColumnOption AlterTableAlterColumnOption
		{
			get
			{
				return this._alterTableAlterColumnOption;
			}
			set
			{
				this._alterTableAlterColumnOption = value;
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06003317 RID: 13079 RVA: 0x001D1BEB File Offset: 0x001CFDEB
		// (set) Token: 0x06003318 RID: 13080 RVA: 0x001D1BF3 File Offset: 0x001CFDF3
		public ColumnStorageOptions StorageOptions
		{
			get
			{
				return this._storageOptions;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._storageOptions = value;
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06003319 RID: 13081 RVA: 0x001D1C03 File Offset: 0x001CFE03
		// (set) Token: 0x0600331A RID: 13082 RVA: 0x001D1C0B File Offset: 0x001CFE0B
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

		// Token: 0x0600331B RID: 13083 RVA: 0x001D1C1B File Offset: 0x001CFE1B
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600331C RID: 13084 RVA: 0x001D1C28 File Offset: 0x001CFE28
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (base.SchemaObjectName != null)
			{
				base.SchemaObjectName.Accept(visitor);
			}
			if (this.ColumnIdentifier != null)
			{
				this.ColumnIdentifier.Accept(visitor);
			}
			if (this.DataType != null)
			{
				this.DataType.Accept(visitor);
			}
			if (this.StorageOptions != null)
			{
				this.StorageOptions.Accept(visitor);
			}
			if (this.Collation != null)
			{
				this.Collation.Accept(visitor);
			}
		}

		// Token: 0x04001FFC RID: 8188
		private Identifier _columnIdentifier;

		// Token: 0x04001FFD RID: 8189
		private DataTypeReference _dataType;

		// Token: 0x04001FFE RID: 8190
		private AlterTableAlterColumnOption _alterTableAlterColumnOption;

		// Token: 0x04001FFF RID: 8191
		private ColumnStorageOptions _storageOptions;

		// Token: 0x04002000 RID: 8192
		private Identifier _collation;
	}
}
