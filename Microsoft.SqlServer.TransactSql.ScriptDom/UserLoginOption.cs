using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002FD RID: 765
	[Serializable]
	public class UserLoginOption : TSqlFragment
	{
		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06003076 RID: 12406 RVA: 0x001CF472 File Offset: 0x001CD672
		// (set) Token: 0x06003077 RID: 12407 RVA: 0x001CF47A File Offset: 0x001CD67A
		public UserLoginOptionType UserLoginOptionType
		{
			get
			{
				return this._userLoginOptionType;
			}
			set
			{
				this._userLoginOptionType = value;
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06003078 RID: 12408 RVA: 0x001CF483 File Offset: 0x001CD683
		// (set) Token: 0x06003079 RID: 12409 RVA: 0x001CF48B File Offset: 0x001CD68B
		public Identifier Identifier
		{
			get
			{
				return this._identifier;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._identifier = value;
			}
		}

		// Token: 0x0600307A RID: 12410 RVA: 0x001CF49B File Offset: 0x001CD69B
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600307B RID: 12411 RVA: 0x001CF4A7 File Offset: 0x001CD6A7
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Identifier != null)
			{
				this.Identifier.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F4A RID: 8010
		private UserLoginOptionType _userLoginOptionType;

		// Token: 0x04001F4B RID: 8011
		private Identifier _identifier;
	}
}
