using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200041A RID: 1050
	[Serializable]
	public class DropAsymmetricKeyStatement : DropUnownedObjectStatement
	{
		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x0600376B RID: 14187 RVA: 0x001D6681 File Offset: 0x001D4881
		// (set) Token: 0x0600376C RID: 14188 RVA: 0x001D6689 File Offset: 0x001D4889
		public bool RemoveProviderKey
		{
			get
			{
				return this._removeProviderKey;
			}
			set
			{
				this._removeProviderKey = value;
			}
		}

		// Token: 0x0600376D RID: 14189 RVA: 0x001D6692 File Offset: 0x001D4892
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600376E RID: 14190 RVA: 0x001D669E File Offset: 0x001D489E
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400214E RID: 8526
		private bool _removeProviderKey;
	}
}
