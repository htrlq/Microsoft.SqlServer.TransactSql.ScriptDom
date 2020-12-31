using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000311 RID: 785
	[Serializable]
	public class CryptoMechanism : TSqlFragment
	{
		// Token: 0x17000340 RID: 832
		// (get) Token: 0x060030F0 RID: 12528 RVA: 0x001CFD0E File Offset: 0x001CDF0E
		// (set) Token: 0x060030F1 RID: 12529 RVA: 0x001CFD16 File Offset: 0x001CDF16
		public CryptoMechanismType CryptoMechanismType
		{
			get
			{
				return this._cryptoMechanismType;
			}
			set
			{
				this._cryptoMechanismType = value;
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x060030F2 RID: 12530 RVA: 0x001CFD1F File Offset: 0x001CDF1F
		// (set) Token: 0x060030F3 RID: 12531 RVA: 0x001CFD27 File Offset: 0x001CDF27
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

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x060030F4 RID: 12532 RVA: 0x001CFD37 File Offset: 0x001CDF37
		// (set) Token: 0x060030F5 RID: 12533 RVA: 0x001CFD3F File Offset: 0x001CDF3F
		public Literal PasswordOrSignature
		{
			get
			{
				return this._passwordOrSignature;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._passwordOrSignature = value;
			}
		}

		// Token: 0x060030F6 RID: 12534 RVA: 0x001CFD4F File Offset: 0x001CDF4F
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060030F7 RID: 12535 RVA: 0x001CFD5B File Offset: 0x001CDF5B
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Identifier != null)
			{
				this.Identifier.Accept(visitor);
			}
			if (this.PasswordOrSignature != null)
			{
				this.PasswordOrSignature.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F6E RID: 8046
		private CryptoMechanismType _cryptoMechanismType;

		// Token: 0x04001F6F RID: 8047
		private Identifier _identifier;

		// Token: 0x04001F70 RID: 8048
		private Literal _passwordOrSignature;
	}
}
