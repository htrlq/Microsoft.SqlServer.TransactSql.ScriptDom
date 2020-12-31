using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000333 RID: 819
	[Serializable]
	public class ReconfigureStatement : TSqlStatement
	{
		// Token: 0x1700036B RID: 875
		// (get) Token: 0x060031A4 RID: 12708 RVA: 0x001D081B File Offset: 0x001CEA1B
		// (set) Token: 0x060031A5 RID: 12709 RVA: 0x001D0823 File Offset: 0x001CEA23
		public bool WithOverride
		{
			get
			{
				return this._withOverride;
			}
			set
			{
				this._withOverride = value;
			}
		}

		// Token: 0x060031A6 RID: 12710 RVA: 0x001D082C File Offset: 0x001CEA2C
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060031A7 RID: 12711 RVA: 0x001D0838 File Offset: 0x001CEA38
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F99 RID: 8089
		private bool _withOverride;
	}
}
