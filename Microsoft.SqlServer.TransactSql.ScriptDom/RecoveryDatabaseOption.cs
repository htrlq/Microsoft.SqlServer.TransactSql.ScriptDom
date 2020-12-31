using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000361 RID: 865
	[Serializable]
	public class RecoveryDatabaseOption : DatabaseOption
	{
		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x060032BF RID: 12991 RVA: 0x001D1791 File Offset: 0x001CF991
		// (set) Token: 0x060032C0 RID: 12992 RVA: 0x001D1799 File Offset: 0x001CF999
		public RecoveryDatabaseOptionKind Value
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

		// Token: 0x060032C1 RID: 12993 RVA: 0x001D17A2 File Offset: 0x001CF9A2
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060032C2 RID: 12994 RVA: 0x001D17AE File Offset: 0x001CF9AE
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001FE7 RID: 8167
		private RecoveryDatabaseOptionKind _value;
	}
}
