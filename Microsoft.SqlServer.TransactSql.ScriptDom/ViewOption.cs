using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001D1 RID: 465
	[Serializable]
	public class ViewOption : TSqlFragment
	{
		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06002977 RID: 10615 RVA: 0x001C782A File Offset: 0x001C5A2A
		// (set) Token: 0x06002978 RID: 10616 RVA: 0x001C7832 File Offset: 0x001C5A32
		public ViewOptionKind OptionKind
		{
			get
			{
				return this._optionKind;
			}
			set
			{
				this._optionKind = value;
			}
		}

		// Token: 0x06002979 RID: 10617 RVA: 0x001C783B File Offset: 0x001C5A3B
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600297A RID: 10618 RVA: 0x001C7847 File Offset: 0x001C5A47
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001D48 RID: 7496
		private ViewOptionKind _optionKind;
	}
}
