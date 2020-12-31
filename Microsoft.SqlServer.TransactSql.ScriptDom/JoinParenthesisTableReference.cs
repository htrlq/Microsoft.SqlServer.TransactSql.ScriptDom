using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003F6 RID: 1014
	[Serializable]
	public class JoinParenthesisTableReference : TableReference
	{
		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x0600369D RID: 13981 RVA: 0x001D59EC File Offset: 0x001D3BEC
		// (set) Token: 0x0600369E RID: 13982 RVA: 0x001D59F4 File Offset: 0x001D3BF4
		public TableReference Join
		{
			get
			{
				return this._join;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._join = value;
			}
		}

		// Token: 0x0600369F RID: 13983 RVA: 0x001D5A04 File Offset: 0x001D3C04
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060036A0 RID: 13984 RVA: 0x001D5A10 File Offset: 0x001D3C10
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Join != null)
			{
				this.Join.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002119 RID: 8473
		private TableReference _join;
	}
}
