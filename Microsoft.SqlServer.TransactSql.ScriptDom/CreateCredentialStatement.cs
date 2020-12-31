using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003AC RID: 940
	[Serializable]
	public class CreateCredentialStatement : CredentialStatement
	{
		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x060034D1 RID: 13521 RVA: 0x001D3B48 File Offset: 0x001D1D48
		// (set) Token: 0x060034D2 RID: 13522 RVA: 0x001D3B50 File Offset: 0x001D1D50
		public Identifier CryptographicProviderName
		{
			get
			{
				return this._cryptographicProviderName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._cryptographicProviderName = value;
			}
		}

		// Token: 0x060034D3 RID: 13523 RVA: 0x001D3B60 File Offset: 0x001D1D60
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060034D4 RID: 13524 RVA: 0x001D3B6C File Offset: 0x001D1D6C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.CryptographicProviderName != null)
			{
				this.CryptographicProviderName.Accept(visitor);
			}
		}

		// Token: 0x04002092 RID: 8338
		private Identifier _cryptographicProviderName;
	}
}
