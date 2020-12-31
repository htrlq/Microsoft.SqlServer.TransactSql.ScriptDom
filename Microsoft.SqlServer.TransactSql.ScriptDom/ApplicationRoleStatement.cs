using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002EF RID: 751
	[Serializable]
	public abstract class ApplicationRoleStatement : TSqlStatement
	{
		// Token: 0x17000313 RID: 787
		// (get) Token: 0x0600303F RID: 12351 RVA: 0x001CF161 File Offset: 0x001CD361
		// (set) Token: 0x06003040 RID: 12352 RVA: 0x001CF169 File Offset: 0x001CD369
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

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06003041 RID: 12353 RVA: 0x001CF179 File Offset: 0x001CD379
		public IList<ApplicationRoleOption> ApplicationRoleOptions
		{
			get
			{
				return this._applicationRoleOptions;
			}
		}

		// Token: 0x06003042 RID: 12354 RVA: 0x001CF184 File Offset: 0x001CD384
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			int i = 0;
			int count = this.ApplicationRoleOptions.Count;
			while (i < count)
			{
				this.ApplicationRoleOptions[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F41 RID: 8001
		private Identifier _name;

		// Token: 0x04001F42 RID: 8002
		private List<ApplicationRoleOption> _applicationRoleOptions = new List<ApplicationRoleOption>();
	}
}
