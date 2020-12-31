using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000278 RID: 632
	[Serializable]
	public class SecurityUserClause80 : TSqlFragment
	{
		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06002D81 RID: 11649 RVA: 0x001CC341 File Offset: 0x001CA541
		public IList<Identifier> Users
		{
			get
			{
				return this._users;
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06002D82 RID: 11650 RVA: 0x001CC349 File Offset: 0x001CA549
		// (set) Token: 0x06002D83 RID: 11651 RVA: 0x001CC351 File Offset: 0x001CA551
		public UserType80 UserType80
		{
			get
			{
				return this._userType80;
			}
			set
			{
				this._userType80 = value;
			}
		}

		// Token: 0x06002D84 RID: 11652 RVA: 0x001CC35A File Offset: 0x001CA55A
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002D85 RID: 11653 RVA: 0x001CC368 File Offset: 0x001CA568
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.Users.Count;
			while (i < count)
			{
				this.Users[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E7B RID: 7803
		private List<Identifier> _users = new List<Identifier>();

		// Token: 0x04001E7C RID: 7804
		private UserType80 _userType80;
	}
}
