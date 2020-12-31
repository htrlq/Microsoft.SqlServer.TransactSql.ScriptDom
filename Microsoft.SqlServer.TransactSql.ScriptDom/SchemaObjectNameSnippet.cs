using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000461 RID: 1121
	[Serializable]
	public class SchemaObjectNameSnippet : SchemaObjectName
	{
		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06003914 RID: 14612 RVA: 0x001D7FAE File Offset: 0x001D61AE
		// (set) Token: 0x06003915 RID: 14613 RVA: 0x001D7FB6 File Offset: 0x001D61B6
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

		// Token: 0x06003916 RID: 14614 RVA: 0x001D7FBF File Offset: 0x001D61BF
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003917 RID: 14615 RVA: 0x001D7FCB File Offset: 0x001D61CB
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x040021C1 RID: 8641
		private string _script;
	}
}
