using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000460 RID: 1120
	[Serializable]
	public class SelectStatementSnippet : SelectStatement
	{
		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x0600390F RID: 14607 RVA: 0x001D7F80 File Offset: 0x001D6180
		// (set) Token: 0x06003910 RID: 14608 RVA: 0x001D7F88 File Offset: 0x001D6188
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

		// Token: 0x06003911 RID: 14609 RVA: 0x001D7F91 File Offset: 0x001D6191
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003912 RID: 14610 RVA: 0x001D7F9D File Offset: 0x001D619D
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x040021C0 RID: 8640
		private string _script;
	}
}
