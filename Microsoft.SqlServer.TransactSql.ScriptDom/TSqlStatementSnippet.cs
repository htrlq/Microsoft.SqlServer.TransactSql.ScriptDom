using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000463 RID: 1123
	[Serializable]
	public class TSqlStatementSnippet : TSqlStatement
	{
		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x0600391E RID: 14622 RVA: 0x001D800A File Offset: 0x001D620A
		// (set) Token: 0x0600391F RID: 14623 RVA: 0x001D8012 File Offset: 0x001D6212
		public string Script
		{
			get
			{
				return this._script;
			}
			set
			{
				this._script = value;
			}
		}

		// Token: 0x06003920 RID: 14624 RVA: 0x001D801B File Offset: 0x001D621B
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003921 RID: 14625 RVA: 0x001D8027 File Offset: 0x001D6227
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x040021C3 RID: 8643
		private string _script;
	}
}
