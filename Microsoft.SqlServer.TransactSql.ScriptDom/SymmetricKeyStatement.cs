using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003C9 RID: 969
	[Serializable]
	public abstract class SymmetricKeyStatement : TSqlStatement
	{
		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x0600358F RID: 13711 RVA: 0x001D462A File Offset: 0x001D282A
		// (set) Token: 0x06003590 RID: 13712 RVA: 0x001D4632 File Offset: 0x001D2832
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

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06003591 RID: 13713 RVA: 0x001D4642 File Offset: 0x001D2842
		public IList<CryptoMechanism> EncryptingMechanisms
		{
			get
			{
				return this._encryptingMechanisms;
			}
		}

		// Token: 0x06003592 RID: 13714 RVA: 0x001D464C File Offset: 0x001D284C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			int i = 0;
			int count = this.EncryptingMechanisms.Count;
			while (i < count)
			{
				this.EncryptingMechanisms[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x040020C9 RID: 8393
		private Identifier _name;

		// Token: 0x040020CA RID: 8394
		private List<CryptoMechanism> _encryptingMechanisms = new List<CryptoMechanism>();
	}
}
