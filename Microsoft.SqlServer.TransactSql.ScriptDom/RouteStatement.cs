using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002C8 RID: 712
	[Serializable]
	public abstract class RouteStatement : TSqlStatement
	{
		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06002F38 RID: 12088 RVA: 0x001CDE97 File Offset: 0x001CC097
		// (set) Token: 0x06002F39 RID: 12089 RVA: 0x001CDE9F File Offset: 0x001CC09F
		public Identifier Name
		{
			get
			{
				return this._name;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._name = value;
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06002F3A RID: 12090 RVA: 0x001CDEAF File Offset: 0x001CC0AF
		public IList<RouteOption> RouteOptions
		{
			get
			{
				return this._routeOptions;
			}
		}

		// Token: 0x06002F3B RID: 12091 RVA: 0x001CDEB8 File Offset: 0x001CC0B8
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			int i = 0;
			int count = this.RouteOptions.Count;
			while (i < count)
			{
				this.RouteOptions[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001EED RID: 7917
		private Identifier _name;

		// Token: 0x04001EEE RID: 7918
		private List<RouteOption> _routeOptions = new List<RouteOption>();
	}
}
