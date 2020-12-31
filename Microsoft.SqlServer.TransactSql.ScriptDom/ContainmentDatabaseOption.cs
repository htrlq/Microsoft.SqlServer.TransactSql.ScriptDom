using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200035C RID: 860
	[Serializable]
	public class ContainmentDatabaseOption : DatabaseOption
	{
		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x060032A6 RID: 12966 RVA: 0x001D1690 File Offset: 0x001CF890
		// (set) Token: 0x060032A7 RID: 12967 RVA: 0x001D1698 File Offset: 0x001CF898
		public ContainmentOptionKind Value
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

		// Token: 0x060032A8 RID: 12968 RVA: 0x001D16A1 File Offset: 0x001CF8A1
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060032A9 RID: 12969 RVA: 0x001D16AD File Offset: 0x001CF8AD
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001FE2 RID: 8162
		private ContainmentOptionKind _value;
	}
}
