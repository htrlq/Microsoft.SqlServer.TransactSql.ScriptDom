using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200048C RID: 1164
	[Serializable]
	public class AlterDatabaseEncryptionKeyStatement : DatabaseEncryptionKeyStatement
	{
		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x060039ED RID: 14829 RVA: 0x001D8C72 File Offset: 0x001D6E72
		// (set) Token: 0x060039EE RID: 14830 RVA: 0x001D8C7A File Offset: 0x001D6E7A
		public bool Regenerate
		{
			get
			{
				return this._regenerate;
			}
			set
			{
				this._regenerate = value;
			}
		}

		// Token: 0x060039EF RID: 14831 RVA: 0x001D8C83 File Offset: 0x001D6E83
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060039F0 RID: 14832 RVA: 0x001D8C8F File Offset: 0x001D6E8F
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x040021F6 RID: 8694
		private bool _regenerate;
	}
}
