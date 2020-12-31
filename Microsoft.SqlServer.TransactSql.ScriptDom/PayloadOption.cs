using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003BD RID: 957
	[Serializable]
	public abstract class PayloadOption : TSqlFragment
	{
		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x0600353E RID: 13630 RVA: 0x001D4288 File Offset: 0x001D2488
		// (set) Token: 0x0600353F RID: 13631 RVA: 0x001D4290 File Offset: 0x001D2490
		public PayloadOptionKinds Kind
		{
			get
			{
				return this._kind;
			}
			set
			{
				this._kind = value;
			}
		}

		// Token: 0x06003540 RID: 13632 RVA: 0x001D4299 File Offset: 0x001D2499
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x040020B2 RID: 8370
		private PayloadOptionKinds _kind;
	}
}
