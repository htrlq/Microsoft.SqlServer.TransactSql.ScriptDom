using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200028A RID: 650
	[Serializable]
	public class GlobalVariableExpression : ValueExpression
	{
		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06002DDB RID: 11739 RVA: 0x001CC89F File Offset: 0x001CAA9F
		// (set) Token: 0x06002DDC RID: 11740 RVA: 0x001CC8A7 File Offset: 0x001CAAA7
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}

		// Token: 0x06002DDD RID: 11741 RVA: 0x001CC8B0 File Offset: 0x001CAAB0
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002DDE RID: 11742 RVA: 0x001CC8BC File Offset: 0x001CAABC
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E90 RID: 7824
		private string _name;
	}
}
