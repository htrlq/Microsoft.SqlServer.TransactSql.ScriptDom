using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000228 RID: 552
	[Serializable]
	public class AdHocTableReference : TableReferenceWithAlias
	{
		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06002B89 RID: 11145 RVA: 0x001C9F6E File Offset: 0x001C816E
		// (set) Token: 0x06002B8A RID: 11146 RVA: 0x001C9F76 File Offset: 0x001C8176
		public AdHocDataSource DataSource
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

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06002B8B RID: 11147 RVA: 0x001C9F86 File Offset: 0x001C8186
		// (set) Token: 0x06002B8C RID: 11148 RVA: 0x001C9F8E File Offset: 0x001C818E
		public SchemaObjectNameOrValueExpression Object
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

		// Token: 0x06002B8D RID: 11149 RVA: 0x001C9F9E File Offset: 0x001C819E
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002B8E RID: 11150 RVA: 0x001C9FAA File Offset: 0x001C81AA
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.DataSource != null)
			{
				this.DataSource.Accept(visitor);
			}
			if (this.Object != null)
			{
				this.Object.Accept(visitor);
			}
		}

		// Token: 0x04001DE9 RID: 7657
		private AdHocDataSource _dataSource;

		// Token: 0x04001DEA RID: 7658
		private SchemaObjectNameOrValueExpression _object;
	}
}
