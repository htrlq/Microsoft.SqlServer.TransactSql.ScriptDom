using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002F7 RID: 759
	[Serializable]
	public class AddMemberAlterRoleAction : AlterRoleAction
	{
		// Token: 0x17000319 RID: 793
		// (get) Token: 0x0600305F RID: 12383 RVA: 0x001CF34C File Offset: 0x001CD54C
		// (set) Token: 0x06003060 RID: 12384 RVA: 0x001CF354 File Offset: 0x001CD554
		public Identifier Member
		{
			get
			{
				return this._member;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._member = value;
			}
		}

		// Token: 0x06003061 RID: 12385 RVA: 0x001CF364 File Offset: 0x001CD564
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003062 RID: 12386 RVA: 0x001CF370 File Offset: 0x001CD570
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Member != null)
			{
				this.Member.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F47 RID: 8007
		private Identifier _member;
	}
}
