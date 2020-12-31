using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000205 RID: 517
	[Serializable]
	public class ExistsPredicate : BooleanExpression
	{
		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06002A93 RID: 10899 RVA: 0x001C8CA5 File Offset: 0x001C6EA5
		// (set) Token: 0x06002A94 RID: 10900 RVA: 0x001C8CAD File Offset: 0x001C6EAD
		public ScalarSubquery Subquery
		{
			get
			{
				return this._subquery;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._subquery = value;
			}
		}

		// Token: 0x06002A95 RID: 10901 RVA: 0x001C8CBD File Offset: 0x001C6EBD
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002A96 RID: 10902 RVA: 0x001C8CC9 File Offset: 0x001C6EC9
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Subquery != null)
			{
				this.Subquery.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001D98 RID: 7576
		private ScalarSubquery _subquery;
	}
}
