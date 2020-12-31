using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002EA RID: 746
	[Serializable]
	public class EventNotificationObjectScope : TSqlFragment
	{
		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06003025 RID: 12325 RVA: 0x001CF025 File Offset: 0x001CD225
		// (set) Token: 0x06003026 RID: 12326 RVA: 0x001CF02D File Offset: 0x001CD22D
		public EventNotificationTarget Target
		{
			get
			{
				return this._target;
			}
			set
			{
				this._target = value;
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06003027 RID: 12327 RVA: 0x001CF036 File Offset: 0x001CD236
		// (set) Token: 0x06003028 RID: 12328 RVA: 0x001CF03E File Offset: 0x001CD23E
		public SchemaObjectName QueueName
		{
			get
			{
				return this._queueName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._queueName = value;
			}
		}

		// Token: 0x06003029 RID: 12329 RVA: 0x001CF04E File Offset: 0x001CD24E
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600302A RID: 12330 RVA: 0x001CF05A File Offset: 0x001CD25A
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.QueueName != null)
			{
				this.QueueName.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F3B RID: 7995
		private EventNotificationTarget _target;

		// Token: 0x04001F3C RID: 7996
		private SchemaObjectName _queueName;
	}
}
