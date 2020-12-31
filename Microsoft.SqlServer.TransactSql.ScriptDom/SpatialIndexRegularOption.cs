using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004BA RID: 1210
	[Serializable]
	public class SpatialIndexRegularOption : SpatialIndexOption
	{
		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06003AF7 RID: 15095 RVA: 0x001D9D12 File Offset: 0x001D7F12
		// (set) Token: 0x06003AF8 RID: 15096 RVA: 0x001D9D1A File Offset: 0x001D7F1A
		public IndexOption Option
		{
			get
			{
				return this._option;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._option = value;
			}
		}

		// Token: 0x06003AF9 RID: 15097 RVA: 0x001D9D2A File Offset: 0x001D7F2A
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003AFA RID: 15098 RVA: 0x001D9D36 File Offset: 0x001D7F36
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Option != null)
			{
				this.Option.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400223F RID: 8767
		private IndexOption _option;
	}
}
