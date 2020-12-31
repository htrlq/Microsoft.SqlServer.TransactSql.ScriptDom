using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003F9 RID: 1017
	[Serializable]
	public class OdbcQualifiedJoinTableReference : TableReference
	{
		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x060036AF RID: 13999 RVA: 0x001D5B08 File Offset: 0x001D3D08
		// (set) Token: 0x060036B0 RID: 14000 RVA: 0x001D5B10 File Offset: 0x001D3D10
		public TableReference TableReference
		{
			get
			{
				return this._tableReference;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._tableReference = value;
			}
		}

		// Token: 0x060036B1 RID: 14001 RVA: 0x001D5B20 File Offset: 0x001D3D20
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060036B2 RID: 14002 RVA: 0x001D5B2C File Offset: 0x001D3D2C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.TableReference != null)
			{
				this.TableReference.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400211E RID: 8478
		private TableReference _tableReference;
	}
}
