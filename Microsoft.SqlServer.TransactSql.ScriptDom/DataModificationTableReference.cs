using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000402 RID: 1026
	[Serializable]
	public class DataModificationTableReference : TableReferenceWithAliasAndColumns
	{
		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x060036EC RID: 14060 RVA: 0x001D5F4E File Offset: 0x001D414E
		// (set) Token: 0x060036ED RID: 14061 RVA: 0x001D5F56 File Offset: 0x001D4156
		public DataModificationSpecification DataModificationSpecification
		{
			get
			{
				return this._dataModificationSpecification;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._dataModificationSpecification = value;
			}
		}

		// Token: 0x060036EE RID: 14062 RVA: 0x001D5F66 File Offset: 0x001D4166
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060036EF RID: 14063 RVA: 0x001D5F72 File Offset: 0x001D4172
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.DataModificationSpecification != null)
			{
				this.DataModificationSpecification.Accept(visitor);
			}
		}

		// Token: 0x04002131 RID: 8497
		private DataModificationSpecification _dataModificationSpecification;
	}
}
