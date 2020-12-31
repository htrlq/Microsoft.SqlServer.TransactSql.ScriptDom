using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002A8 RID: 680
	[Serializable]
	public class LockEscalationTableOption : TableOption
	{
		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06002E7C RID: 11900 RVA: 0x001CD334 File Offset: 0x001CB534
		// (set) Token: 0x06002E7D RID: 11901 RVA: 0x001CD33C File Offset: 0x001CB53C
		public LockEscalationMethod Value
		{
			get
			{
				return this._value;
			}
			set
			{
				this._value = value;
			}
		}

		// Token: 0x06002E7E RID: 11902 RVA: 0x001CD345 File Offset: 0x001CB545
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002E7F RID: 11903 RVA: 0x001CD351 File Offset: 0x001CB551
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001EBA RID: 7866
		private LockEscalationMethod _value;
	}
}
