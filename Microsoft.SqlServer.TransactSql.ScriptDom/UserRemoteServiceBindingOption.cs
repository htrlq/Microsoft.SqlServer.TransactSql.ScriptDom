using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200039E RID: 926
	[Serializable]
	public class UserRemoteServiceBindingOption : RemoteServiceBindingOption
	{
		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06003475 RID: 13429 RVA: 0x001D3491 File Offset: 0x001D1691
		// (set) Token: 0x06003476 RID: 13430 RVA: 0x001D3499 File Offset: 0x001D1699
		public Identifier User
		{
			get
			{
				return this._user;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._user = value;
			}
		}

		// Token: 0x06003477 RID: 13431 RVA: 0x001D34A9 File Offset: 0x001D16A9
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003478 RID: 13432 RVA: 0x001D34B5 File Offset: 0x001D16B5
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.User != null)
			{
				this.User.Accept(visitor);
			}
		}

		// Token: 0x04002076 RID: 8310
		private Identifier _user;
	}
}
