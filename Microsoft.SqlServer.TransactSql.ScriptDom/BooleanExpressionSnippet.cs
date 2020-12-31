using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200045E RID: 1118
	[Serializable]
	public class BooleanExpressionSnippet : BooleanExpression
	{
		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06003905 RID: 14597 RVA: 0x001D7F24 File Offset: 0x001D6124
		// (set) Token: 0x06003906 RID: 14598 RVA: 0x001D7F2C File Offset: 0x001D612C
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

		// Token: 0x06003907 RID: 14599 RVA: 0x001D7F35 File Offset: 0x001D6135
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003908 RID: 14600 RVA: 0x001D7F41 File Offset: 0x001D6141
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x040021BE RID: 8638
		private string _script;
	}
}
