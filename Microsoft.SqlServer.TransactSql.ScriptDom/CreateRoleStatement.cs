using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002F3 RID: 755
	[Serializable]
	public class CreateRoleStatement : RoleStatement, IAuthorization
	{
		// Token: 0x17000316 RID: 790
		// (get) Token: 0x0600304E RID: 12366 RVA: 0x001CF260 File Offset: 0x001CD460
		// (set) Token: 0x0600304F RID: 12367 RVA: 0x001CF268 File Offset: 0x001CD468
		public Identifier Owner
		{
			get
			{
				return this._owner;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._owner = value;
			}
		}

		// Token: 0x06003050 RID: 12368 RVA: 0x001CF278 File Offset: 0x001CD478
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003051 RID: 12369 RVA: 0x001CF284 File Offset: 0x001CD484
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Owner != null)
			{
				this.Owner.Accept(visitor);
			}
		}

		// Token: 0x04001F44 RID: 8004
		private Identifier _owner;
	}
}
