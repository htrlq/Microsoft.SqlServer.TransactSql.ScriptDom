using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000449 RID: 1097
	[Serializable]
	public class EndConversationStatement : TSqlStatement
	{
		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x0600386E RID: 14446 RVA: 0x001D758F File Offset: 0x001D578F
		// (set) Token: 0x0600386F RID: 14447 RVA: 0x001D7597 File Offset: 0x001D5797
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

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06003870 RID: 14448 RVA: 0x001D75A7 File Offset: 0x001D57A7
		// (set) Token: 0x06003871 RID: 14449 RVA: 0x001D75AF File Offset: 0x001D57AF
		public bool WithCleanup
		{
			get
			{
				return this._withCleanup;
			}
			set
			{
				this._withCleanup = value;
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06003872 RID: 14450 RVA: 0x001D75B8 File Offset: 0x001D57B8
		// (set) Token: 0x06003873 RID: 14451 RVA: 0x001D75C0 File Offset: 0x001D57C0
		public ValueExpression ErrorCode
		{
			get
			{
				return this._errorCode;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._errorCode = value;
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06003874 RID: 14452 RVA: 0x001D75D0 File Offset: 0x001D57D0
		// (set) Token: 0x06003875 RID: 14453 RVA: 0x001D75D8 File Offset: 0x001D57D8
		public ValueExpression ErrorDescription
		{
			get
			{
				return this._errorDescription;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._errorDescription = value;
			}
		}

		// Token: 0x06003876 RID: 14454 RVA: 0x001D75E8 File Offset: 0x001D57E8
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003877 RID: 14455 RVA: 0x001D75F4 File Offset: 0x001D57F4
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Conversation != null)
			{
				this.Conversation.Accept(visitor);
			}
			if (this.ErrorCode != null)
			{
				this.ErrorCode.Accept(visitor);
			}
			if (this.ErrorDescription != null)
			{
				this.ErrorDescription.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400218F RID: 8591
		private ScalarExpression _conversation;

		// Token: 0x04002190 RID: 8592
		private bool _withCleanup;

		// Token: 0x04002191 RID: 8593
		private ValueExpression _errorCode;

		// Token: 0x04002192 RID: 8594
		private ValueExpression _errorDescription;
	}
}
