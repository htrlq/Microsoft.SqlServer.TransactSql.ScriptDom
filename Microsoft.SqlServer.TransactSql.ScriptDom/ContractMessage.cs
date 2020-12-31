using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003AA RID: 938
	[Serializable]
	public class ContractMessage : TSqlFragment
	{
		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x060034C2 RID: 13506 RVA: 0x001D3A4D File Offset: 0x001D1C4D
		// (set) Token: 0x060034C3 RID: 13507 RVA: 0x001D3A55 File Offset: 0x001D1C55
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

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x060034C4 RID: 13508 RVA: 0x001D3A65 File Offset: 0x001D1C65
		// (set) Token: 0x060034C5 RID: 13509 RVA: 0x001D3A6D File Offset: 0x001D1C6D
		public MessageSender SentBy
		{
			get
			{
				return this._sentBy;
			}
			set
			{
				this._sentBy = value;
			}
		}

		// Token: 0x060034C6 RID: 13510 RVA: 0x001D3A76 File Offset: 0x001D1C76
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060034C7 RID: 13511 RVA: 0x001D3A82 File Offset: 0x001D1C82
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400208D RID: 8333
		private Identifier _name;

		// Token: 0x0400208E RID: 8334
		private MessageSender _sentBy;
	}
}
