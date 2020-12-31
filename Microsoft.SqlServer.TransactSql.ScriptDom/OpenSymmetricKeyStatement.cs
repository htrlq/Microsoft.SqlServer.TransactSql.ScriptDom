using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000312 RID: 786
	[Serializable]
	public class OpenSymmetricKeyStatement : TSqlStatement
	{
		// Token: 0x17000343 RID: 835
		// (get) Token: 0x060030F9 RID: 12537 RVA: 0x001CFD94 File Offset: 0x001CDF94
		// (set) Token: 0x060030FA RID: 12538 RVA: 0x001CFD9C File Offset: 0x001CDF9C
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

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x060030FB RID: 12539 RVA: 0x001CFDAC File Offset: 0x001CDFAC
		// (set) Token: 0x060030FC RID: 12540 RVA: 0x001CFDB4 File Offset: 0x001CDFB4
		public CryptoMechanism DecryptionMechanism
		{
			get
			{
				return this._decryptionMechanism;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._decryptionMechanism = value;
			}
		}

		// Token: 0x060030FD RID: 12541 RVA: 0x001CFDC4 File Offset: 0x001CDFC4
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060030FE RID: 12542 RVA: 0x001CFDD0 File Offset: 0x001CDFD0
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			if (this.DecryptionMechanism != null)
			{
				this.DecryptionMechanism.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F71 RID: 8049
		private Identifier _name;

		// Token: 0x04001F72 RID: 8050
		private CryptoMechanism _decryptionMechanism;
	}
}
