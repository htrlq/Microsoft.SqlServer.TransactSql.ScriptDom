using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002F2 RID: 754
	[Serializable]
	public abstract class RoleStatement : TSqlStatement
	{
		// Token: 0x17000315 RID: 789
		// (get) Token: 0x0600304A RID: 12362 RVA: 0x001CF223 File Offset: 0x001CD423
		// (set) Token: 0x0600304B RID: 12363 RVA: 0x001CF22B File Offset: 0x001CD42B
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

		// Token: 0x0600304C RID: 12364 RVA: 0x001CF23B File Offset: 0x001CD43B
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F43 RID: 8003
		private Identifier _name;
	}
}
