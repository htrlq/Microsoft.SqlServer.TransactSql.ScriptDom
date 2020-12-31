using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000272 RID: 626
	[Serializable]
	public class DenyStatement80 : SecurityStatementBody80
	{
		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06002D5D RID: 11613 RVA: 0x001CC113 File Offset: 0x001CA313
		// (set) Token: 0x06002D5E RID: 11614 RVA: 0x001CC11B File Offset: 0x001CA31B
		public bool CascadeOption
		{
			get
			{
				return this._cascadeOption;
			}
			set
			{
				this._cascadeOption = value;
			}
		}

		// Token: 0x06002D5F RID: 11615 RVA: 0x001CC124 File Offset: 0x001CA324
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002D60 RID: 11616 RVA: 0x001CC130 File Offset: 0x001CA330
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E70 RID: 7792
		private bool _cascadeOption;
	}
}
