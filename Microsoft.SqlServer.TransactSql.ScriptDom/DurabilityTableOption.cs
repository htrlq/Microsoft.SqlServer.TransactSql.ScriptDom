using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002AE RID: 686
	[Serializable]
	public class DurabilityTableOption : TableOption
	{
		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06002E9A RID: 11930 RVA: 0x001CD4B4 File Offset: 0x001CB6B4
		// (set) Token: 0x06002E9B RID: 11931 RVA: 0x001CD4BC File Offset: 0x001CB6BC
		public DurabilityTableOptionKind DurabilityTableOptionKind
		{
			get
			{
				return this._durabilityTableOptionKind;
			}
			set
			{
				this._durabilityTableOptionKind = value;
			}
		}

		// Token: 0x06002E9C RID: 11932 RVA: 0x001CD4C5 File Offset: 0x001CB6C5
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002E9D RID: 11933 RVA: 0x001CD4D1 File Offset: 0x001CB6D1
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001EC0 RID: 7872
		private DurabilityTableOptionKind _durabilityTableOptionKind;
	}
}
