using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000419 RID: 1049
	[Serializable]
	public class DropSymmetricKeyStatement : DropUnownedObjectStatement
	{
		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06003766 RID: 14182 RVA: 0x001D6653 File Offset: 0x001D4853
		// (set) Token: 0x06003767 RID: 14183 RVA: 0x001D665B File Offset: 0x001D485B
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

		// Token: 0x06003768 RID: 14184 RVA: 0x001D6664 File Offset: 0x001D4864
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003769 RID: 14185 RVA: 0x001D6670 File Offset: 0x001D4870
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400214D RID: 8525
		private bool _removeProviderKey;
	}
}
