using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002F6 RID: 758
	[Serializable]
	public class RenameAlterRoleAction : AlterRoleAction
	{
		// Token: 0x17000318 RID: 792
		// (get) Token: 0x0600305A RID: 12378 RVA: 0x001CF303 File Offset: 0x001CD503
		// (set) Token: 0x0600305B RID: 12379 RVA: 0x001CF30B File Offset: 0x001CD50B
		public Identifier NewName
		{
			get
			{
				return this._newName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._newName = value;
			}
		}

		// Token: 0x0600305C RID: 12380 RVA: 0x001CF31B File Offset: 0x001CD51B
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600305D RID: 12381 RVA: 0x001CF327 File Offset: 0x001CD527
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.NewName != null)
			{
				this.NewName.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F46 RID: 8006
		private Identifier _newName;
	}
}
