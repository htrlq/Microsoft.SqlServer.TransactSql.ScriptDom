using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000413 RID: 1043
	[Serializable]
	public class DropFullTextIndexStatement : TSqlStatement
	{
		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06003750 RID: 14160 RVA: 0x001D654D File Offset: 0x001D474D
		// (set) Token: 0x06003751 RID: 14161 RVA: 0x001D6555 File Offset: 0x001D4755
		public SchemaObjectName TableName
		{
			get
			{
				return this._tableName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._tableName = value;
			}
		}

		// Token: 0x06003752 RID: 14162 RVA: 0x001D6565 File Offset: 0x001D4765
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003753 RID: 14163 RVA: 0x001D6571 File Offset: 0x001D4771
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.TableName != null)
			{
				this.TableName.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400214B RID: 8523
		private SchemaObjectName _tableName;
	}
}
