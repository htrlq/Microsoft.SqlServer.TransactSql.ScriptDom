using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003A4 RID: 932
	[Serializable]
	public class ProviderEncryptionSource : EncryptionSource
	{
		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06003492 RID: 13458 RVA: 0x001D3664 File Offset: 0x001D1864
		// (set) Token: 0x06003493 RID: 13459 RVA: 0x001D366C File Offset: 0x001D186C
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

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06003494 RID: 13460 RVA: 0x001D367C File Offset: 0x001D187C
		public IList<KeyOption> KeyOptions
		{
			get
			{
				return this._keyOptions;
			}
		}

		// Token: 0x06003495 RID: 13461 RVA: 0x001D3684 File Offset: 0x001D1884
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003496 RID: 13462 RVA: 0x001D3690 File Offset: 0x001D1890
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			int i = 0;
			int count = this.KeyOptions.Count;
			while (i < count)
			{
				this.KeyOptions[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400207C RID: 8316
		private Identifier _name;

		// Token: 0x0400207D RID: 8317
		private List<KeyOption> _keyOptions = new List<KeyOption>();
	}
}
