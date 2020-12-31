using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003A9 RID: 937
	[Serializable]
	public class CreateContractStatement : TSqlStatement, IAuthorization
	{
		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x060034BA RID: 13498 RVA: 0x001D3990 File Offset: 0x001D1B90
		// (set) Token: 0x060034BB RID: 13499 RVA: 0x001D3998 File Offset: 0x001D1B98
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

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x060034BC RID: 13500 RVA: 0x001D39A8 File Offset: 0x001D1BA8
		public IList<ContractMessage> Messages
		{
			get
			{
				return this._messages;
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x060034BD RID: 13501 RVA: 0x001D39B0 File Offset: 0x001D1BB0
		// (set) Token: 0x060034BE RID: 13502 RVA: 0x001D39B8 File Offset: 0x001D1BB8
		public Identifier Owner
		{
			get
			{
				return this._owner;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._owner = value;
			}
		}

		// Token: 0x060034BF RID: 13503 RVA: 0x001D39C8 File Offset: 0x001D1BC8
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060034C0 RID: 13504 RVA: 0x001D39D4 File Offset: 0x001D1BD4
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			int i = 0;
			int count = this.Messages.Count;
			while (i < count)
			{
				this.Messages[i].Accept(visitor);
				i++;
			}
			if (this.Owner != null)
			{
				this.Owner.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400208A RID: 8330
		private Identifier _name;

		// Token: 0x0400208B RID: 8331
		private List<ContractMessage> _messages = new List<ContractMessage>();

		// Token: 0x0400208C RID: 8332
		private Identifier _owner;
	}
}
