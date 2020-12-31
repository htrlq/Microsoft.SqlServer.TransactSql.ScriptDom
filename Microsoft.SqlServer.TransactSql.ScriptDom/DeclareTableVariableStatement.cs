using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001F8 RID: 504
	[Serializable]
	public class DeclareTableVariableStatement : TSqlStatement
	{
		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06002A53 RID: 10835 RVA: 0x001C882C File Offset: 0x001C6A2C
		// (set) Token: 0x06002A54 RID: 10836 RVA: 0x001C8834 File Offset: 0x001C6A34
		public DeclareTableVariableBody Body
		{
			get
			{
				return this._body;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._body = value;
			}
		}

		// Token: 0x06002A55 RID: 10837 RVA: 0x001C8844 File Offset: 0x001C6A44
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002A56 RID: 10838 RVA: 0x001C8850 File Offset: 0x001C6A50
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Body != null)
			{
				this.Body.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001D87 RID: 7559
		private DeclareTableVariableBody _body;
	}
}
