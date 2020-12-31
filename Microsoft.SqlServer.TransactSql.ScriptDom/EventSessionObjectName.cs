using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004A7 RID: 1191
	[Serializable]
	public class EventSessionObjectName : TSqlFragment
	{
		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06003A81 RID: 14977 RVA: 0x001D94F9 File Offset: 0x001D76F9
		// (set) Token: 0x06003A82 RID: 14978 RVA: 0x001D9501 File Offset: 0x001D7701
		public MultiPartIdentifier MultiPartIdentifier
		{
			get
			{
				return this._multiPartIdentifier;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._multiPartIdentifier = value;
			}
		}

		// Token: 0x06003A83 RID: 14979 RVA: 0x001D9511 File Offset: 0x001D7711
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003A84 RID: 14980 RVA: 0x001D951D File Offset: 0x001D771D
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.MultiPartIdentifier != null)
			{
				this.MultiPartIdentifier.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400221B RID: 8731
		private MultiPartIdentifier _multiPartIdentifier;
	}
}
