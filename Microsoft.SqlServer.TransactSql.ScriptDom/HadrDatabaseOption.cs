using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200035D RID: 861
	[Serializable]
	public class HadrDatabaseOption : DatabaseOption
	{
		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x060032AB RID: 12971 RVA: 0x001D16BE File Offset: 0x001CF8BE
		// (set) Token: 0x060032AC RID: 12972 RVA: 0x001D16C6 File Offset: 0x001CF8C6
		public HadrDatabaseOptionKind HadrOption
		{
			get
			{
				return this._hadrOption;
			}
			set
			{
				this._hadrOption = value;
			}
		}

		// Token: 0x060032AD RID: 12973 RVA: 0x001D16CF File Offset: 0x001CF8CF
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060032AE RID: 12974 RVA: 0x001D16DB File Offset: 0x001CF8DB
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001FE3 RID: 8163
		private HadrDatabaseOptionKind _hadrOption;
	}
}
