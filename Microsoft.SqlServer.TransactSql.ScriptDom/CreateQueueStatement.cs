using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002CD RID: 717
	[Serializable]
	public class CreateQueueStatement : QueueStatement
	{
		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06002F4D RID: 12109 RVA: 0x001CE06A File Offset: 0x001CC26A
		// (set) Token: 0x06002F4E RID: 12110 RVA: 0x001CE072 File Offset: 0x001CC272
		public IdentifierOrValueExpression OnFileGroup
		{
			get
			{
				return this._onFileGroup;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._onFileGroup = value;
			}
		}

		// Token: 0x06002F4F RID: 12111 RVA: 0x001CE082 File Offset: 0x001CC282
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002F50 RID: 12112 RVA: 0x001CE090 File Offset: 0x001CC290
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (base.Name != null)
			{
				base.Name.Accept(visitor);
			}
			int i = 0;
			int count = base.QueueOptions.Count;
			while (i < count)
			{
				base.QueueOptions[i].Accept(visitor);
				i++;
			}
			if (this.OnFileGroup != null)
			{
				this.OnFileGroup.Accept(visitor);
			}
		}

		// Token: 0x04001EF2 RID: 7922
		private IdentifierOrValueExpression _onFileGroup;
	}
}
