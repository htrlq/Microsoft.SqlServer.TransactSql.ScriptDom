using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200045D RID: 1117
	[Serializable]
	public class ScalarExpressionSnippet : ScalarExpression
	{
		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06003900 RID: 14592 RVA: 0x001D7EF6 File Offset: 0x001D60F6
		// (set) Token: 0x06003901 RID: 14593 RVA: 0x001D7EFE File Offset: 0x001D60FE
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

		// Token: 0x06003902 RID: 14594 RVA: 0x001D7F07 File Offset: 0x001D6107
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003903 RID: 14595 RVA: 0x001D7F13 File Offset: 0x001D6113
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x040021BD RID: 8637
		private string _script;
	}
}
