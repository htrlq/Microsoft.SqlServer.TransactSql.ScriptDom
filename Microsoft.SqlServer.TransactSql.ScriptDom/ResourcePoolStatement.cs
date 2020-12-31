using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200048E RID: 1166
	[Serializable]
	public class ResourcePoolStatement : TSqlStatement
	{
		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x060039F5 RID: 14837 RVA: 0x001D8CBD File Offset: 0x001D6EBD
		// (set) Token: 0x060039F6 RID: 14838 RVA: 0x001D8CC5 File Offset: 0x001D6EC5
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

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x060039F7 RID: 14839 RVA: 0x001D8CD5 File Offset: 0x001D6ED5
		public IList<ResourcePoolParameter> ResourcePoolParameters
		{
			get
			{
				return this._resourcePoolParameters;
			}
		}

		// Token: 0x060039F8 RID: 14840 RVA: 0x001D8CDD File Offset: 0x001D6EDD
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060039F9 RID: 14841 RVA: 0x001D8CEC File Offset: 0x001D6EEC
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			int i = 0;
			int count = this.ResourcePoolParameters.Count;
			while (i < count)
			{
				this.ResourcePoolParameters[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x040021F7 RID: 8695
		private Identifier _name;

		// Token: 0x040021F8 RID: 8696
		private List<ResourcePoolParameter> _resourcePoolParameters = new List<ResourcePoolParameter>();
	}
}
