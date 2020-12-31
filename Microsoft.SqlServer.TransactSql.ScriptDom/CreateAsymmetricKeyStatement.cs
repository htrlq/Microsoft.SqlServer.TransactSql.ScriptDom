using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000397 RID: 919
	[Serializable]
	public class CreateAsymmetricKeyStatement : TSqlStatement, IAuthorization
	{
		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x0600343F RID: 13375 RVA: 0x001D30BA File Offset: 0x001D12BA
		// (set) Token: 0x06003440 RID: 13376 RVA: 0x001D30C2 File Offset: 0x001D12C2
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

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06003441 RID: 13377 RVA: 0x001D30D2 File Offset: 0x001D12D2
		// (set) Token: 0x06003442 RID: 13378 RVA: 0x001D30DA File Offset: 0x001D12DA
		public EncryptionSource KeySource
		{
			get
			{
				return this._keySource;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._keySource = value;
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06003443 RID: 13379 RVA: 0x001D30EA File Offset: 0x001D12EA
		// (set) Token: 0x06003444 RID: 13380 RVA: 0x001D30F2 File Offset: 0x001D12F2
		public EncryptionAlgorithm EncryptionAlgorithm
		{
			get
			{
				return this._encryptionAlgorithm;
			}
			set
			{
				this._encryptionAlgorithm = value;
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06003445 RID: 13381 RVA: 0x001D30FB File Offset: 0x001D12FB
		// (set) Token: 0x06003446 RID: 13382 RVA: 0x001D3103 File Offset: 0x001D1303
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

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06003447 RID: 13383 RVA: 0x001D3113 File Offset: 0x001D1313
		// (set) Token: 0x06003448 RID: 13384 RVA: 0x001D311B File Offset: 0x001D131B
		public Identifier Owner
		{
			get
			{
				return this._owner;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._owner = value;
			}
		}

		// Token: 0x06003449 RID: 13385 RVA: 0x001D312B File Offset: 0x001D132B
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600344A RID: 13386 RVA: 0x001D3138 File Offset: 0x001D1338
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			if (this.KeySource != null)
			{
				this.KeySource.Accept(visitor);
			}
			if (this.Password != null)
			{
				this.Password.Accept(visitor);
			}
			if (this.Owner != null)
			{
				this.Owner.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002063 RID: 8291
		private Identifier _name;

		// Token: 0x04002064 RID: 8292
		private EncryptionSource _keySource;

		// Token: 0x04002065 RID: 8293
		private EncryptionAlgorithm _encryptionAlgorithm;

		// Token: 0x04002066 RID: 8294
		private Literal _password;

		// Token: 0x04002067 RID: 8295
		private Identifier _owner;
	}
}
