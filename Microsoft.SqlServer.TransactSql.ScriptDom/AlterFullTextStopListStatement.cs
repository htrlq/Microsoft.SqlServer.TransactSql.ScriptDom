using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004A1 RID: 1185
	[Serializable]
	public class AlterFullTextStopListStatement : TSqlStatement
	{
		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06003A59 RID: 14937 RVA: 0x001D92B8 File Offset: 0x001D74B8
		// (set) Token: 0x06003A5A RID: 14938 RVA: 0x001D92C0 File Offset: 0x001D74C0
		public Identifier Name
		{
			get
			{
				return this._name;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._name = value;
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06003A5B RID: 14939 RVA: 0x001D92D0 File Offset: 0x001D74D0
		// (set) Token: 0x06003A5C RID: 14940 RVA: 0x001D92D8 File Offset: 0x001D74D8
		public FullTextStopListAction Action
		{
			get
			{
				return this._action;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._action = value;
			}
		}

		// Token: 0x06003A5D RID: 14941 RVA: 0x001D92E8 File Offset: 0x001D74E8
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003A5E RID: 14942 RVA: 0x001D92F4 File Offset: 0x001D74F4
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			if (this.Action != null)
			{
				this.Action.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002210 RID: 8720
		private Identifier _name;

		// Token: 0x04002211 RID: 8721
		private FullTextStopListAction _action;
	}
}
