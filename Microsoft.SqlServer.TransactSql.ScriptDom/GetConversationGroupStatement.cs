using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200044C RID: 1100
	[Serializable]
	public class GetConversationGroupStatement : WaitForSupportedStatement
	{
		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06003882 RID: 14466 RVA: 0x001D76D2 File Offset: 0x001D58D2
		// (set) Token: 0x06003883 RID: 14467 RVA: 0x001D76DA File Offset: 0x001D58DA
		public VariableReference GroupId
		{
			get
			{
				return this._groupId;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._groupId = value;
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06003884 RID: 14468 RVA: 0x001D76EA File Offset: 0x001D58EA
		// (set) Token: 0x06003885 RID: 14469 RVA: 0x001D76F2 File Offset: 0x001D58F2
		public SchemaObjectName Queue
		{
			get
			{
				return this._queue;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._queue = value;
			}
		}

		// Token: 0x06003886 RID: 14470 RVA: 0x001D7702 File Offset: 0x001D5902
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003887 RID: 14471 RVA: 0x001D770E File Offset: 0x001D590E
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.GroupId != null)
			{
				this.GroupId.Accept(visitor);
			}
			if (this.Queue != null)
			{
				this.Queue.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002195 RID: 8597
		private VariableReference _groupId;

		// Token: 0x04002196 RID: 8598
		private SchemaObjectName _queue;
	}
}
