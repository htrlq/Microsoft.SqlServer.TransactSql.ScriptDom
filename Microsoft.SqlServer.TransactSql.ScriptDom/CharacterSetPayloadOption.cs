using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003C5 RID: 965
	[Serializable]
	public class CharacterSetPayloadOption : PayloadOption
	{
		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06003573 RID: 13683 RVA: 0x001D4513 File Offset: 0x001D2713
		// (set) Token: 0x06003574 RID: 13684 RVA: 0x001D451B File Offset: 0x001D271B
		public bool IsSql
		{
			get
			{
				return this._isSql;
			}
			set
			{
				this._isSql = value;
			}
		}

		// Token: 0x06003575 RID: 13685 RVA: 0x001D4524 File Offset: 0x001D2724
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003576 RID: 13686 RVA: 0x001D4530 File Offset: 0x001D2730
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x040020C1 RID: 8385
		private bool _isSql;
	}
}
