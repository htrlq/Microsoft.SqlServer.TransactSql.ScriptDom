using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000462 RID: 1122
	[Serializable]
	public class TSqlFragmentSnippet : TSqlFragment
	{
		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06003919 RID: 14617 RVA: 0x001D7FDC File Offset: 0x001D61DC
		// (set) Token: 0x0600391A RID: 14618 RVA: 0x001D7FE4 File Offset: 0x001D61E4
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

		// Token: 0x0600391B RID: 14619 RVA: 0x001D7FED File Offset: 0x001D61ED
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600391C RID: 14620 RVA: 0x001D7FF9 File Offset: 0x001D61F9
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x040021C2 RID: 8642
		private string _script;
	}
}
