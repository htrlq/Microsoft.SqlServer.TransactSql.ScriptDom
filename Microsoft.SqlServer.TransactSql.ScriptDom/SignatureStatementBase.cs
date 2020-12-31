using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000444 RID: 1092
	[Serializable]
	public abstract class SignatureStatementBase : TSqlStatement
	{
		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06003850 RID: 14416 RVA: 0x001D7395 File Offset: 0x001D5595
		// (set) Token: 0x06003851 RID: 14417 RVA: 0x001D739D File Offset: 0x001D559D
		public bool IsCounter
		{
			get
			{
				return this._isCounter;
			}
			set
			{
				this._isCounter = value;
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06003852 RID: 14418 RVA: 0x001D73A6 File Offset: 0x001D55A6
		// (set) Token: 0x06003853 RID: 14419 RVA: 0x001D73AE File Offset: 0x001D55AE
		public SignableElementKind ElementKind
		{
			get
			{
				return this._elementKind;
			}
			set
			{
				this._elementKind = value;
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06003854 RID: 14420 RVA: 0x001D73B7 File Offset: 0x001D55B7
		// (set) Token: 0x06003855 RID: 14421 RVA: 0x001D73BF File Offset: 0x001D55BF
		public SchemaObjectName Element
		{
			get
			{
				return this._element;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._element = value;
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06003856 RID: 14422 RVA: 0x001D73CF File Offset: 0x001D55CF
		public IList<CryptoMechanism> Cryptos
		{
			get
			{
				return this._cryptos;
			}
		}

		// Token: 0x06003857 RID: 14423 RVA: 0x001D73D8 File Offset: 0x001D55D8
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Element != null)
			{
				this.Element.Accept(visitor);
			}
			int i = 0;
			int count = this.Cryptos.Count;
			while (i < count)
			{
				this.Cryptos[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002186 RID: 8582
		private bool _isCounter;

		// Token: 0x04002187 RID: 8583
		private SignableElementKind _elementKind;

		// Token: 0x04002188 RID: 8584
		private SchemaObjectName _element;

		// Token: 0x04002189 RID: 8585
		private List<CryptoMechanism> _cryptos = new List<CryptoMechanism>();
	}
}
