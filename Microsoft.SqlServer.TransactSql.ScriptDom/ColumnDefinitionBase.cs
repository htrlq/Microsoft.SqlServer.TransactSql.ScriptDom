using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000370 RID: 880
	[Serializable]
	public class ColumnDefinitionBase : TSqlFragment, ICollationSetter
	{
		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x0600331E RID: 13086 RVA: 0x001D1CA1 File Offset: 0x001CFEA1
		// (set) Token: 0x0600331F RID: 13087 RVA: 0x001D1CA9 File Offset: 0x001CFEA9
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

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06003320 RID: 13088 RVA: 0x001D1CB9 File Offset: 0x001CFEB9
		// (set) Token: 0x06003321 RID: 13089 RVA: 0x001D1CC1 File Offset: 0x001CFEC1
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

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06003322 RID: 13090 RVA: 0x001D1CD1 File Offset: 0x001CFED1
		// (set) Token: 0x06003323 RID: 13091 RVA: 0x001D1CD9 File Offset: 0x001CFED9
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

		// Token: 0x06003324 RID: 13092 RVA: 0x001D1CE9 File Offset: 0x001CFEE9
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003325 RID: 13093 RVA: 0x001D1CF8 File Offset: 0x001CFEF8
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.ColumnIdentifier != null)
			{
				this.ColumnIdentifier.Accept(visitor);
			}
			if (this.DataType != null)
			{
				this.DataType.Accept(visitor);
			}
			if (this.Collation != null)
			{
				this.Collation.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002001 RID: 8193
		private Identifier _columnIdentifier;

		// Token: 0x04002002 RID: 8194
		private DataTypeReference _dataType;

		// Token: 0x04002003 RID: 8195
		private Identifier _collation;
	}
}
