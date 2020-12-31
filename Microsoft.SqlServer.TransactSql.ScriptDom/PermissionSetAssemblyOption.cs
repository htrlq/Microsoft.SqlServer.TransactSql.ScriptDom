using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200029C RID: 668
	[Serializable]
	public class PermissionSetAssemblyOption : AssemblyOption
	{
		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06002E38 RID: 11832 RVA: 0x001CCEEE File Offset: 0x001CB0EE
		// (set) Token: 0x06002E39 RID: 11833 RVA: 0x001CCEF6 File Offset: 0x001CB0F6
		public PermissionSetOption PermissionSetOption
		{
			get
			{
				return this._permissionSetOption;
			}
			set
			{
				this._permissionSetOption = value;
			}
		}

		// Token: 0x06002E3A RID: 11834 RVA: 0x001CCEFF File Offset: 0x001CB0FF
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002E3B RID: 11835 RVA: 0x001CCF0B File Offset: 0x001CB10B
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001EA8 RID: 7848
		private PermissionSetOption _permissionSetOption;
	}
}
