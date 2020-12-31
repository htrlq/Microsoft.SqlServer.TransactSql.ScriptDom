using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000421 RID: 1057
	[Serializable]
	public class SimpleAlterFullTextIndexAction : AlterFullTextIndexAction
	{
		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x0600378F RID: 14223 RVA: 0x001D686A File Offset: 0x001D4A6A
		// (set) Token: 0x06003790 RID: 14224 RVA: 0x001D6872 File Offset: 0x001D4A72
		public SimpleAlterFullTextIndexActionKind ActionKind
		{
			get
			{
				return this._actionKind;
			}
			set
			{
				this._actionKind = value;
			}
		}

		// Token: 0x06003791 RID: 14225 RVA: 0x001D687B File Offset: 0x001D4A7B
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003792 RID: 14226 RVA: 0x001D6887 File Offset: 0x001D4A87
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002156 RID: 8534
		private SimpleAlterFullTextIndexActionKind _actionKind;
	}
}
