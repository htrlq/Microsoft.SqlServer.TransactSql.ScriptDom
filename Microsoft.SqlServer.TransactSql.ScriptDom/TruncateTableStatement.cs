using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000336 RID: 822
	[Serializable]
	public class TruncateTableStatement : TSqlStatement
	{
		// Token: 0x1700036F RID: 879
		// (get) Token: 0x060031B5 RID: 12725 RVA: 0x001D08D1 File Offset: 0x001CEAD1
		// (set) Token: 0x060031B6 RID: 12726 RVA: 0x001D08D9 File Offset: 0x001CEAD9
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

		// Token: 0x060031B7 RID: 12727 RVA: 0x001D08E9 File Offset: 0x001CEAE9
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060031B8 RID: 12728 RVA: 0x001D08F5 File Offset: 0x001CEAF5
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.TableName != null)
			{
				this.TableName.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F9D RID: 8093
		private SchemaObjectName _tableName;
	}
}
