using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003C1 RID: 961
	[Serializable]
	public class LoginTypePayloadOption : PayloadOption
	{
		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x0600355D RID: 13661 RVA: 0x001D4414 File Offset: 0x001D2614
		// (set) Token: 0x0600355E RID: 13662 RVA: 0x001D441C File Offset: 0x001D261C
		public bool IsWindows
		{
			get
			{
				return this._isWindows;
			}
			set
			{
				this._isWindows = value;
			}
		}

		// Token: 0x0600355F RID: 13663 RVA: 0x001D4425 File Offset: 0x001D2625
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003560 RID: 13664 RVA: 0x001D4431 File Offset: 0x001D2631
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x040020BC RID: 8380
		private bool _isWindows;
	}
}
