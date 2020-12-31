using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002FF RID: 767
	[Serializable]
	public class CreateUserStatement : UserStatement
	{
		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06003082 RID: 12418 RVA: 0x001CF551 File Offset: 0x001CD751
		// (set) Token: 0x06003083 RID: 12419 RVA: 0x001CF559 File Offset: 0x001CD759
		public UserLoginOption UserLoginOption
		{
			get
			{
				return this._userLoginOption;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._userLoginOption = value;
			}
		}

		// Token: 0x06003084 RID: 12420 RVA: 0x001CF569 File Offset: 0x001CD769
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003085 RID: 12421 RVA: 0x001CF578 File Offset: 0x001CD778
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (base.Name != null)
			{
				base.Name.Accept(visitor);
			}
			if (this.UserLoginOption != null)
			{
				this.UserLoginOption.Accept(visitor);
			}
			int i = 0;
			int count = base.UserOptions.Count;
			while (i < count)
			{
				base.UserOptions[i].Accept(visitor);
				i++;
			}
		}

		// Token: 0x04001F4E RID: 8014
		private UserLoginOption _userLoginOption;
	}
}
