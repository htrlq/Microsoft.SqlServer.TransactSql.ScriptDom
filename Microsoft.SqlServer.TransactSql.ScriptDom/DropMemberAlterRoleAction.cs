using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002F8 RID: 760
	[Serializable]
	public class DropMemberAlterRoleAction : AlterRoleAction
	{
		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06003064 RID: 12388 RVA: 0x001CF395 File Offset: 0x001CD595
		// (set) Token: 0x06003065 RID: 12389 RVA: 0x001CF39D File Offset: 0x001CD59D
		public Identifier Member
		{
			get
			{
				return this._member;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._member = value;
			}
		}

		// Token: 0x06003066 RID: 12390 RVA: 0x001CF3AD File Offset: 0x001CD5AD
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003067 RID: 12391 RVA: 0x001CF3B9 File Offset: 0x001CD5B9
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Member != null)
			{
				this.Member.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F48 RID: 8008
		private Identifier _member;
	}
}
