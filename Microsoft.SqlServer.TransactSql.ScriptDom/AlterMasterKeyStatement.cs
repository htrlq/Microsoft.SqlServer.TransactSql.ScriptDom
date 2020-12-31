using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002ED RID: 749
	[Serializable]
	public class AlterMasterKeyStatement : MasterKeyStatement
	{
		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06003033 RID: 12339 RVA: 0x001CF0D9 File Offset: 0x001CD2D9
		// (set) Token: 0x06003034 RID: 12340 RVA: 0x001CF0E1 File Offset: 0x001CD2E1
		public AlterMasterKeyOption Option
		{
			get
			{
				return this._option;
			}
			set
			{
				this._option = value;
			}
		}

		// Token: 0x06003035 RID: 12341 RVA: 0x001CF0EA File Offset: 0x001CD2EA
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003036 RID: 12342 RVA: 0x001CF0F6 File Offset: 0x001CD2F6
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F3E RID: 7998
		private AlterMasterKeyOption _option;
	}
}
