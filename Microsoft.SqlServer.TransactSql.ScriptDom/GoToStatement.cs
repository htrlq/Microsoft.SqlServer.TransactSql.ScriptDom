using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000252 RID: 594
	[Serializable]
	public class GoToStatement : TSqlStatement
	{
		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06002C82 RID: 11394 RVA: 0x001CB129 File Offset: 0x001C9329
		// (set) Token: 0x06002C83 RID: 11395 RVA: 0x001CB131 File Offset: 0x001C9331
		public Identifier LabelName
		{
			get
			{
				return this._labelName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._labelName = value;
			}
		}

		// Token: 0x06002C84 RID: 11396 RVA: 0x001CB141 File Offset: 0x001C9341
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002C85 RID: 11397 RVA: 0x001CB14D File Offset: 0x001C934D
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.LabelName != null)
			{
				this.LabelName.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E2C RID: 7724
		private Identifier _labelName;
	}
}
