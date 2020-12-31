using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004E7 RID: 1255
	[Serializable]
	public class SelectiveXmlIndexPromotedPath : TSqlFragment
	{
		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06003BFD RID: 15357 RVA: 0x001DAD9B File Offset: 0x001D8F9B
		// (set) Token: 0x06003BFE RID: 15358 RVA: 0x001DADA3 File Offset: 0x001D8FA3
		public Identifier Name
		{
			get
			{
				return this._name;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._name = value;
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06003BFF RID: 15359 RVA: 0x001DADB3 File Offset: 0x001D8FB3
		// (set) Token: 0x06003C00 RID: 15360 RVA: 0x001DADBB File Offset: 0x001D8FBB
		public Literal Path
		{
			get
			{
				return this._path;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._path = value;
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06003C01 RID: 15361 RVA: 0x001DADCB File Offset: 0x001D8FCB
		// (set) Token: 0x06003C02 RID: 15362 RVA: 0x001DADD3 File Offset: 0x001D8FD3
		public DataTypeReference SQLDataType
		{
			get
			{
				return this._sQLDataType;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._sQLDataType = value;
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06003C03 RID: 15363 RVA: 0x001DADE3 File Offset: 0x001D8FE3
		// (set) Token: 0x06003C04 RID: 15364 RVA: 0x001DADEB File Offset: 0x001D8FEB
		public Literal XQueryDataType
		{
			get
			{
				return this._xQueryDataType;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._xQueryDataType = value;
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06003C05 RID: 15365 RVA: 0x001DADFB File Offset: 0x001D8FFB
		// (set) Token: 0x06003C06 RID: 15366 RVA: 0x001DAE03 File Offset: 0x001D9003
		public IntegerLiteral MaxLength
		{
			get
			{
				return this._maxLength;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._maxLength = value;
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06003C07 RID: 15367 RVA: 0x001DAE13 File Offset: 0x001D9013
		// (set) Token: 0x06003C08 RID: 15368 RVA: 0x001DAE1B File Offset: 0x001D901B
		public bool IsSingleton
		{
			get
			{
				return this._isSingleton;
			}
			set
			{
				this._isSingleton = value;
			}
		}

		// Token: 0x06003C09 RID: 15369 RVA: 0x001DAE24 File Offset: 0x001D9024
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003C0A RID: 15370 RVA: 0x001DAE30 File Offset: 0x001D9030
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			if (this.Path != null)
			{
				this.Path.Accept(visitor);
			}
			if (this.SQLDataType != null)
			{
				this.SQLDataType.Accept(visitor);
			}
			if (this.XQueryDataType != null)
			{
				this.XQueryDataType.Accept(visitor);
			}
			if (this.MaxLength != null)
			{
				this.MaxLength.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002288 RID: 8840
		private Identifier _name;

		// Token: 0x04002289 RID: 8841
		private Literal _path;

		// Token: 0x0400228A RID: 8842
		private DataTypeReference _sQLDataType;

		// Token: 0x0400228B RID: 8843
		private Literal _xQueryDataType;

		// Token: 0x0400228C RID: 8844
		private IntegerLiteral _maxLength;

		// Token: 0x0400228D RID: 8845
		private bool _isSingleton;
	}
}
