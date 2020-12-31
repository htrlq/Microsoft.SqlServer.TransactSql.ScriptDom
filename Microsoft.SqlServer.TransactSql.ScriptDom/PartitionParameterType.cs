using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000399 RID: 921
	[Serializable]
	public class PartitionParameterType : TSqlFragment, ICollationSetter
	{
		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06003456 RID: 13398 RVA: 0x001D3275 File Offset: 0x001D1475
		// (set) Token: 0x06003457 RID: 13399 RVA: 0x001D327D File Offset: 0x001D147D
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

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06003458 RID: 13400 RVA: 0x001D328D File Offset: 0x001D148D
		// (set) Token: 0x06003459 RID: 13401 RVA: 0x001D3295 File Offset: 0x001D1495
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

		// Token: 0x0600345A RID: 13402 RVA: 0x001D32A5 File Offset: 0x001D14A5
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600345B RID: 13403 RVA: 0x001D32B1 File Offset: 0x001D14B1
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
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

		// Token: 0x0400206C RID: 8300
		private DataTypeReference _dataType;

		// Token: 0x0400206D RID: 8301
		private Identifier _collation;
	}
}
