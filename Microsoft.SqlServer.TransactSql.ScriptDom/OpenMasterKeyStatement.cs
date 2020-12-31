using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000314 RID: 788
	[Serializable]
	public class OpenMasterKeyStatement : TSqlStatement
	{
		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06003107 RID: 12551 RVA: 0x001CFE63 File Offset: 0x001CE063
		// (set) Token: 0x06003108 RID: 12552 RVA: 0x001CFE6B File Offset: 0x001CE06B
		public Literal Password
		{
			get
			{
				return this._password;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._password = value;
			}
		}

		// Token: 0x06003109 RID: 12553 RVA: 0x001CFE7B File Offset: 0x001CE07B
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600310A RID: 12554 RVA: 0x001CFE87 File Offset: 0x001CE087
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Password != null)
			{
				this.Password.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F75 RID: 8053
		private Literal _password;
	}
}
