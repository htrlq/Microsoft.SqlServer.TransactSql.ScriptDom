using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003CA RID: 970
	[Serializable]
	public class CreateSymmetricKeyStatement : SymmetricKeyStatement, IAuthorization
	{
		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06003594 RID: 13716 RVA: 0x001D46B1 File Offset: 0x001D28B1
		public IList<KeyOption> KeyOptions
		{
			get
			{
				return this._keyOptions;
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06003595 RID: 13717 RVA: 0x001D46B9 File Offset: 0x001D28B9
		// (set) Token: 0x06003596 RID: 13718 RVA: 0x001D46C1 File Offset: 0x001D28C1
		public Identifier Provider
		{
			get
			{
				return this._provider;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._provider = value;
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06003597 RID: 13719 RVA: 0x001D46D1 File Offset: 0x001D28D1
		// (set) Token: 0x06003598 RID: 13720 RVA: 0x001D46D9 File Offset: 0x001D28D9
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

		// Token: 0x06003599 RID: 13721 RVA: 0x001D46E9 File Offset: 0x001D28E9
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600359A RID: 13722 RVA: 0x001D46F8 File Offset: 0x001D28F8
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (base.Name != null)
			{
				base.Name.Accept(visitor);
			}
			int i = 0;
			int count = this.KeyOptions.Count;
			while (i < count)
			{
				this.KeyOptions[i].Accept(visitor);
				i++;
			}
			if (this.Provider != null)
			{
				this.Provider.Accept(visitor);
			}
			int j = 0;
			int count2 = base.EncryptingMechanisms.Count;
			while (j < count2)
			{
				base.EncryptingMechanisms[j].Accept(visitor);
				j++;
			}
			if (this.Owner != null)
			{
				this.Owner.Accept(visitor);
			}
		}

		// Token: 0x040020CB RID: 8395
		private List<KeyOption> _keyOptions = new List<KeyOption>();

		// Token: 0x040020CC RID: 8396
		private Identifier _provider;

		// Token: 0x040020CD RID: 8397
		private Identifier _owner;
	}
}
