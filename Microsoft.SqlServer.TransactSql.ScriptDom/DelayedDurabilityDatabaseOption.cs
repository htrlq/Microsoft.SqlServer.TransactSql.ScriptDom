using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200035F RID: 863
	[Serializable]
	public class DelayedDurabilityDatabaseOption : DatabaseOption
	{
		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x060032B5 RID: 12981 RVA: 0x001D1735 File Offset: 0x001CF935
		// (set) Token: 0x060032B6 RID: 12982 RVA: 0x001D173D File Offset: 0x001CF93D
		public DelayedDurabilityOptionKind Value
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

		// Token: 0x060032B7 RID: 12983 RVA: 0x001D1746 File Offset: 0x001CF946
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060032B8 RID: 12984 RVA: 0x001D1752 File Offset: 0x001CF952
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001FE5 RID: 8165
		private DelayedDurabilityOptionKind _value;
	}
}
