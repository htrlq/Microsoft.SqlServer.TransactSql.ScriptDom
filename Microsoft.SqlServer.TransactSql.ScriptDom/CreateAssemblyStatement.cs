using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000298 RID: 664
	[Serializable]
	public class CreateAssemblyStatement : AssemblyStatement, IAuthorization
	{
		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06002E22 RID: 11810 RVA: 0x001CCD26 File Offset: 0x001CAF26
		// (set) Token: 0x06002E23 RID: 11811 RVA: 0x001CCD2E File Offset: 0x001CAF2E
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

		// Token: 0x06002E24 RID: 11812 RVA: 0x001CCD3E File Offset: 0x001CAF3E
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002E25 RID: 11813 RVA: 0x001CCD4C File Offset: 0x001CAF4C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (base.Name != null)
			{
				base.Name.Accept(visitor);
			}
			int i = 0;
			int count = base.Parameters.Count;
			while (i < count)
			{
				base.Parameters[i].Accept(visitor);
				i++;
			}
			int j = 0;
			int count2 = base.Options.Count;
			while (j < count2)
			{
				base.Options[j].Accept(visitor);
				j++;
			}
			if (this.Owner != null)
			{
				this.Owner.Accept(visitor);
			}
		}

		// Token: 0x04001EA2 RID: 7842
		private Identifier _owner;
	}
}
