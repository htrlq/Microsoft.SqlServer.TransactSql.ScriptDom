using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000393 RID: 915
	[Serializable]
	public class InsertBulkColumnDefinition : TSqlFragment
	{
		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x0600341F RID: 13343 RVA: 0x001D2EF1 File Offset: 0x001D10F1
		// (set) Token: 0x06003420 RID: 13344 RVA: 0x001D2EF9 File Offset: 0x001D10F9
		public ColumnDefinitionBase Column
		{
			get
			{
				return this._column;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._column = value;
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06003421 RID: 13345 RVA: 0x001D2F09 File Offset: 0x001D1109
		// (set) Token: 0x06003422 RID: 13346 RVA: 0x001D2F11 File Offset: 0x001D1111
		public NullNotNull NullNotNull
		{
			get
			{
				return this._nullNotNull;
			}
			set
			{
				this._nullNotNull = value;
			}
		}

		// Token: 0x06003423 RID: 13347 RVA: 0x001D2F1A File Offset: 0x001D111A
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003424 RID: 13348 RVA: 0x001D2F26 File Offset: 0x001D1126
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Column != null)
			{
				this.Column.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002058 RID: 8280
		private ColumnDefinitionBase _column;

		// Token: 0x04002059 RID: 8281
		private NullNotNull _nullNotNull;
	}
}
