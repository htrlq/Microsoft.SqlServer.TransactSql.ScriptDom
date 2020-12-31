using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200044E RID: 1102
	[Serializable]
	public class SendStatement : TSqlStatement
	{
		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06003897 RID: 14487 RVA: 0x001D786D File Offset: 0x001D5A6D
		public IList<ScalarExpression> ConversationHandles
		{
			get
			{
				return this._conversationHandles;
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06003898 RID: 14488 RVA: 0x001D7875 File Offset: 0x001D5A75
		// (set) Token: 0x06003899 RID: 14489 RVA: 0x001D787D File Offset: 0x001D5A7D
		public IdentifierOrValueExpression MessageTypeName
		{
			get
			{
				return this._messageTypeName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._messageTypeName = value;
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x0600389A RID: 14490 RVA: 0x001D788D File Offset: 0x001D5A8D
		// (set) Token: 0x0600389B RID: 14491 RVA: 0x001D7895 File Offset: 0x001D5A95
		public ScalarExpression MessageBody
		{
			get
			{
				return this._messageBody;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._messageBody = value;
			}
		}

		// Token: 0x0600389C RID: 14492 RVA: 0x001D78A5 File Offset: 0x001D5AA5
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600389D RID: 14493 RVA: 0x001D78B4 File Offset: 0x001D5AB4
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.ConversationHandles.Count;
			while (i < count)
			{
				this.ConversationHandles[i].Accept(visitor);
				i++;
			}
			if (this.MessageTypeName != null)
			{
				this.MessageTypeName.Accept(visitor);
			}
			if (this.MessageBody != null)
			{
				this.MessageBody.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400219D RID: 8605
		private List<ScalarExpression> _conversationHandles = new List<ScalarExpression>();

		// Token: 0x0400219E RID: 8606
		private IdentifierOrValueExpression _messageTypeName;

		// Token: 0x0400219F RID: 8607
		private ScalarExpression _messageBody;
	}
}
