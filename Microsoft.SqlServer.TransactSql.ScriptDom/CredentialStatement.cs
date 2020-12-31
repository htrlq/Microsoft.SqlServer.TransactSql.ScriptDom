using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003AB RID: 939
	[Serializable]
	public abstract class CredentialStatement : TSqlStatement
	{
		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x060034C9 RID: 13513 RVA: 0x001D3AA7 File Offset: 0x001D1CA7
		// (set) Token: 0x060034CA RID: 13514 RVA: 0x001D3AAF File Offset: 0x001D1CAF
		public Identifier Name
		{
			get
			{
				return this._name;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._name = value;
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x060034CB RID: 13515 RVA: 0x001D3ABF File Offset: 0x001D1CBF
		// (set) Token: 0x060034CC RID: 13516 RVA: 0x001D3AC7 File Offset: 0x001D1CC7
		public Literal Identity
		{
			get
			{
				return this._identity;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._identity = value;
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x060034CD RID: 13517 RVA: 0x001D3AD7 File Offset: 0x001D1CD7
		// (set) Token: 0x060034CE RID: 13518 RVA: 0x001D3ADF File Offset: 0x001D1CDF
		public Literal Secret
		{
			get
			{
				return this._secret;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._secret = value;
			}
		}

		// Token: 0x060034CF RID: 13519 RVA: 0x001D3AF0 File Offset: 0x001D1CF0
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			if (this.Identity != null)
			{
				this.Identity.Accept(visitor);
			}
			if (this.Secret != null)
			{
				this.Secret.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400208F RID: 8335
		private Identifier _name;

		// Token: 0x04002090 RID: 8336
		private Literal _identity;

		// Token: 0x04002091 RID: 8337
		private Literal _secret;
	}
}
