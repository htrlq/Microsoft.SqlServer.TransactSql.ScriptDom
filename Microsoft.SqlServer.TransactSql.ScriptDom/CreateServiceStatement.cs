using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003D8 RID: 984
	[Serializable]
	public class CreateServiceStatement : AlterCreateServiceStatementBase, IAuthorization
	{
		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x060035E3 RID: 13795 RVA: 0x001D4C61 File Offset: 0x001D2E61
		// (set) Token: 0x060035E4 RID: 13796 RVA: 0x001D4C69 File Offset: 0x001D2E69
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

		// Token: 0x060035E5 RID: 13797 RVA: 0x001D4C79 File Offset: 0x001D2E79
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060035E6 RID: 13798 RVA: 0x001D4C88 File Offset: 0x001D2E88
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (base.Name != null)
			{
				base.Name.Accept(visitor);
			}
			if (base.QueueName != null)
			{
				base.QueueName.Accept(visitor);
			}
			int i = 0;
			int count = base.ServiceContracts.Count;
			while (i < count)
			{
				base.ServiceContracts[i].Accept(visitor);
				i++;
			}
			if (this.Owner != null)
			{
				this.Owner.Accept(visitor);
			}
		}

		// Token: 0x040020E1 RID: 8417
		private Identifier _owner;
	}
}
