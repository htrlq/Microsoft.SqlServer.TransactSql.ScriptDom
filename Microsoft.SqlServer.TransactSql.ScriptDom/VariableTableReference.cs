using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200040A RID: 1034
	[Serializable]
	public class VariableTableReference : TableReferenceWithAlias
	{
		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x0600372C RID: 14124 RVA: 0x001D6369 File Offset: 0x001D4569
		// (set) Token: 0x0600372D RID: 14125 RVA: 0x001D6371 File Offset: 0x001D4571
		public VariableReference Variable
		{
			get
			{
				return this._variable;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._variable = value;
			}
		}

		// Token: 0x0600372E RID: 14126 RVA: 0x001D6381 File Offset: 0x001D4581
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600372F RID: 14127 RVA: 0x001D638D File Offset: 0x001D458D
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Variable != null)
			{
				this.Variable.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002146 RID: 8518
		private VariableReference _variable;
	}
}
