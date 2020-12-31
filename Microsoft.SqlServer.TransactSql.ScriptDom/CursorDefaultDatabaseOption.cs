using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000360 RID: 864
	[Serializable]
	public class CursorDefaultDatabaseOption : DatabaseOption
	{
		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x060032BA RID: 12986 RVA: 0x001D1763 File Offset: 0x001CF963
		// (set) Token: 0x060032BB RID: 12987 RVA: 0x001D176B File Offset: 0x001CF96B
		public bool IsLocal
		{
			get
			{
				return this._isLocal;
			}
			set
			{
				this._isLocal = value;
			}
		}

		// Token: 0x060032BC RID: 12988 RVA: 0x001D1774 File Offset: 0x001CF974
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060032BD RID: 12989 RVA: 0x001D1780 File Offset: 0x001CF980
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001FE6 RID: 8166
		private bool _isLocal;
	}
}
