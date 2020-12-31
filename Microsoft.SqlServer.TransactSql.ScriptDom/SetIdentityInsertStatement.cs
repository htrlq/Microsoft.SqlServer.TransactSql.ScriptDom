using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000342 RID: 834
	[Serializable]
	public class SetIdentityInsertStatement : SetOnOffStatement
	{
		// Token: 0x1700037B RID: 891
		// (get) Token: 0x060031EE RID: 12782 RVA: 0x001D0B84 File Offset: 0x001CED84
		// (set) Token: 0x060031EF RID: 12783 RVA: 0x001D0B8C File Offset: 0x001CED8C
		public SchemaObjectName Table
		{
			get
			{
				return this._table;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._table = value;
			}
		}

		// Token: 0x060031F0 RID: 12784 RVA: 0x001D0B9C File Offset: 0x001CED9C
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060031F1 RID: 12785 RVA: 0x001D0BA8 File Offset: 0x001CEDA8
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Table != null)
			{
				this.Table.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001FA9 RID: 8105
		private SchemaObjectName _table;
	}
}
