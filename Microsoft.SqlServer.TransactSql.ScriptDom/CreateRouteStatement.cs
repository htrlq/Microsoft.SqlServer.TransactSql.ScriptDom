using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002CA RID: 714
	[Serializable]
	public class CreateRouteStatement : RouteStatement, IAuthorization
	{
		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06002F40 RID: 12096 RVA: 0x001CDF3A File Offset: 0x001CC13A
		// (set) Token: 0x06002F41 RID: 12097 RVA: 0x001CDF42 File Offset: 0x001CC142
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

		// Token: 0x06002F42 RID: 12098 RVA: 0x001CDF52 File Offset: 0x001CC152
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002F43 RID: 12099 RVA: 0x001CDF60 File Offset: 0x001CC160
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (base.Name != null)
			{
				base.Name.Accept(visitor);
			}
			int i = 0;
			int count = base.RouteOptions.Count;
			while (i < count)
			{
				base.RouteOptions[i].Accept(visitor);
				i++;
			}
			if (this.Owner != null)
			{
				this.Owner.Accept(visitor);
			}
		}

		// Token: 0x04001EEF RID: 7919
		private Identifier _owner;
	}
}
