using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003C6 RID: 966
	[Serializable]
	public class RolePayloadOption : PayloadOption
	{
		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06003578 RID: 13688 RVA: 0x001D4541 File Offset: 0x001D2741
		// (set) Token: 0x06003579 RID: 13689 RVA: 0x001D4549 File Offset: 0x001D2749
		public DatabaseMirroringEndpointRole Role
		{
			get
			{
				return this._role;
			}
			set
			{
				this._role = value;
			}
		}

		// Token: 0x0600357A RID: 13690 RVA: 0x001D4552 File Offset: 0x001D2752
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600357B RID: 13691 RVA: 0x001D455E File Offset: 0x001D275E
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x040020C2 RID: 8386
		private DatabaseMirroringEndpointRole _role;
	}
}
