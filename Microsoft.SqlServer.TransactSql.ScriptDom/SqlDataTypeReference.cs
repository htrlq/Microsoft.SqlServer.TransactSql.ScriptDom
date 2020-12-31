using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001F1 RID: 497
	[Serializable]
	public class SqlDataTypeReference : ParameterizedDataTypeReference
	{
		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06002A2B RID: 10795 RVA: 0x001C8589 File Offset: 0x001C6789
		// (set) Token: 0x06002A2C RID: 10796 RVA: 0x001C8591 File Offset: 0x001C6791
		public SqlDataTypeOption SqlDataTypeOption
		{
			get
			{
				return this._sqlDataTypeOption;
			}
			set
			{
				this._sqlDataTypeOption = value;
			}
		}

		// Token: 0x06002A2D RID: 10797 RVA: 0x001C859A File Offset: 0x001C679A
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002A2E RID: 10798 RVA: 0x001C85A6 File Offset: 0x001C67A6
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001D7C RID: 7548
		private SqlDataTypeOption _sqlDataTypeOption;
	}
}
