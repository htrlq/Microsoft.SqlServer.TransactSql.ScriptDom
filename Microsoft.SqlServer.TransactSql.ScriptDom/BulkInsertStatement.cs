using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200038E RID: 910
	[Serializable]
	public class BulkInsertStatement : BulkInsertBase
	{
		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06003406 RID: 13318 RVA: 0x001D2D0D File Offset: 0x001D0F0D
		// (set) Token: 0x06003407 RID: 13319 RVA: 0x001D2D15 File Offset: 0x001D0F15
		public IdentifierOrValueExpression From
		{
			get
			{
				return this._from;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._from = value;
			}
		}

		// Token: 0x06003408 RID: 13320 RVA: 0x001D2D25 File Offset: 0x001D0F25
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003409 RID: 13321 RVA: 0x001D2D34 File Offset: 0x001D0F34
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (base.To != null)
			{
				base.To.Accept(visitor);
			}
			if (this.From != null)
			{
				this.From.Accept(visitor);
			}
			int i = 0;
			int count = base.Options.Count;
			while (i < count)
			{
				base.Options[i].Accept(visitor);
				i++;
			}
		}

		// Token: 0x04002052 RID: 8274
		private IdentifierOrValueExpression _from;
	}
}
