using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200045F RID: 1119
	[Serializable]
	public class StatementListSnippet : StatementList
	{
		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x0600390A RID: 14602 RVA: 0x001D7F52 File Offset: 0x001D6152
		// (set) Token: 0x0600390B RID: 14603 RVA: 0x001D7F5A File Offset: 0x001D615A
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

		// Token: 0x0600390C RID: 14604 RVA: 0x001D7F63 File Offset: 0x001D6163
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600390D RID: 14605 RVA: 0x001D7F6F File Offset: 0x001D616F
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x040021BF RID: 8639
		private string _script;
	}
}
