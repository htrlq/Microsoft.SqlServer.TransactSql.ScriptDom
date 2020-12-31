using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000359 RID: 857
	[Serializable]
	public class DatabaseOption : TSqlFragment
	{
		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06003295 RID: 12949 RVA: 0x001D15F5 File Offset: 0x001CF7F5
		// (set) Token: 0x06003296 RID: 12950 RVA: 0x001D15FD File Offset: 0x001CF7FD
		public DatabaseOptionKind OptionKind
		{
			get
			{
				return this._optionKind;
			}
			set
			{
				this._optionKind = value;
			}
		}

		// Token: 0x06003297 RID: 12951 RVA: 0x001D1606 File Offset: 0x001CF806
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003298 RID: 12952 RVA: 0x001D1612 File Offset: 0x001CF812
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001FDE RID: 8158
		private DatabaseOptionKind _optionKind;
	}
}
