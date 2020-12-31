using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002F4 RID: 756
	[Serializable]
	public class AlterRoleStatement : RoleStatement
	{
		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06003053 RID: 12371 RVA: 0x001CF2A9 File Offset: 0x001CD4A9
		// (set) Token: 0x06003054 RID: 12372 RVA: 0x001CF2B1 File Offset: 0x001CD4B1
		public AlterRoleAction Action
		{
			get
			{
				return this._action;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._action = value;
			}
		}

		// Token: 0x06003055 RID: 12373 RVA: 0x001CF2C1 File Offset: 0x001CD4C1
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003056 RID: 12374 RVA: 0x001CF2CD File Offset: 0x001CD4CD
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Action != null)
			{
				this.Action.Accept(visitor);
			}
		}

		// Token: 0x04001F45 RID: 8005
		private AlterRoleAction _action;
	}
}
