using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200044A RID: 1098
	[Serializable]
	public class MoveConversationStatement : TSqlStatement
	{
		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06003879 RID: 14457 RVA: 0x001D764C File Offset: 0x001D584C
		// (set) Token: 0x0600387A RID: 14458 RVA: 0x001D7654 File Offset: 0x001D5854
		public ScalarExpression Conversation
		{
			get
			{
				return this._conversation;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._conversation = value;
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x0600387B RID: 14459 RVA: 0x001D7664 File Offset: 0x001D5864
		// (set) Token: 0x0600387C RID: 14460 RVA: 0x001D766C File Offset: 0x001D586C
		public ScalarExpression Group
		{
			get
			{
				return this._group;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._group = value;
			}
		}

		// Token: 0x0600387D RID: 14461 RVA: 0x001D767C File Offset: 0x001D587C
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600387E RID: 14462 RVA: 0x001D7688 File Offset: 0x001D5888
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Conversation != null)
			{
				this.Conversation.Accept(visitor);
			}
			if (this.Group != null)
			{
				this.Group.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002193 RID: 8595
		private ScalarExpression _conversation;

		// Token: 0x04002194 RID: 8596
		private ScalarExpression _group;
	}
}
