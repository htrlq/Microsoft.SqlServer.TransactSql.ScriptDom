using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000451 RID: 1105
	[Serializable]
	public class AlterServiceMasterKeyStatement : TSqlStatement
	{
		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x060038B5 RID: 14517 RVA: 0x001D7A9C File Offset: 0x001D5C9C
		// (set) Token: 0x060038B6 RID: 14518 RVA: 0x001D7AA4 File Offset: 0x001D5CA4
		public Literal Account
		{
			get
			{
				return this._account;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._account = value;
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x060038B7 RID: 14519 RVA: 0x001D7AB4 File Offset: 0x001D5CB4
		// (set) Token: 0x060038B8 RID: 14520 RVA: 0x001D7ABC File Offset: 0x001D5CBC
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

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x060038B9 RID: 14521 RVA: 0x001D7ACC File Offset: 0x001D5CCC
		// (set) Token: 0x060038BA RID: 14522 RVA: 0x001D7AD4 File Offset: 0x001D5CD4
		public AlterServiceMasterKeyOption Kind
		{
			get
			{
				return this._kind;
			}
			set
			{
				this._kind = value;
			}
		}

		// Token: 0x060038BB RID: 14523 RVA: 0x001D7ADD File Offset: 0x001D5CDD
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060038BC RID: 14524 RVA: 0x001D7AE9 File Offset: 0x001D5CE9
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Account != null)
			{
				this.Account.Accept(visitor);
			}
			if (this.Password != null)
			{
				this.Password.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x040021A8 RID: 8616
		private Literal _account;

		// Token: 0x040021A9 RID: 8617
		private Literal _password;

		// Token: 0x040021AA RID: 8618
		private AlterServiceMasterKeyOption _kind;
	}
}
