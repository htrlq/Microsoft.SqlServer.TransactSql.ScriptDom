using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003B3 RID: 947
	[Serializable]
	public class CreateEndpointStatement : AlterCreateEndpointStatementBase, IAuthorization
	{
		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06003501 RID: 13569 RVA: 0x001D3EBA File Offset: 0x001D20BA
		// (set) Token: 0x06003502 RID: 13570 RVA: 0x001D3EC2 File Offset: 0x001D20C2
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

		// Token: 0x06003503 RID: 13571 RVA: 0x001D3ED2 File Offset: 0x001D20D2
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003504 RID: 13572 RVA: 0x001D3EE0 File Offset: 0x001D20E0
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (base.Name != null)
			{
				base.Name.Accept(visitor);
			}
			if (base.Affinity != null)
			{
				base.Affinity.Accept(visitor);
			}
			int i = 0;
			int count = base.ProtocolOptions.Count;
			while (i < count)
			{
				base.ProtocolOptions[i].Accept(visitor);
				i++;
			}
			int j = 0;
			int count2 = base.PayloadOptions.Count;
			while (j < count2)
			{
				base.PayloadOptions[j].Accept(visitor);
				j++;
			}
			if (this.Owner != null)
			{
				this.Owner.Accept(visitor);
			}
		}

		// Token: 0x040020A2 RID: 8354
		private Identifier _owner;
	}
}
