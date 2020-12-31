using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000286 RID: 646
	[Serializable]
	public class VariableReference : ValueExpression
	{
		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06002DCA RID: 11722 RVA: 0x001CC7E9 File Offset: 0x001CA9E9
		// (set) Token: 0x06002DCB RID: 11723 RVA: 0x001CC7F1 File Offset: 0x001CA9F1
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

		// Token: 0x06002DCC RID: 11724 RVA: 0x001CC7FA File Offset: 0x001CA9FA
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002DCD RID: 11725 RVA: 0x001CC806 File Offset: 0x001CAA06
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E8D RID: 7821
		private string _name;
	}
}
