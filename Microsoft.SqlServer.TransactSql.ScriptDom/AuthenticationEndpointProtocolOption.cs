using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003B8 RID: 952
	[Serializable]
	public class AuthenticationEndpointProtocolOption : EndpointProtocolOption
	{
		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06003519 RID: 13593 RVA: 0x001D4067 File Offset: 0x001D2267
		// (set) Token: 0x0600351A RID: 13594 RVA: 0x001D406F File Offset: 0x001D226F
		public AuthenticationTypes AuthenticationTypes
		{
			get
			{
				return this._authenticationTypes;
			}
			set
			{
				this._authenticationTypes = value;
			}
		}

		// Token: 0x0600351B RID: 13595 RVA: 0x001D4078 File Offset: 0x001D2278
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600351C RID: 13596 RVA: 0x001D4084 File Offset: 0x001D2284
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x040020A7 RID: 8359
		private AuthenticationTypes _authenticationTypes;
	}
}
