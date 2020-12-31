using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000334 RID: 820
	[Serializable]
	public class ShutdownStatement : TSqlStatement
	{
		// Token: 0x1700036C RID: 876
		// (get) Token: 0x060031A9 RID: 12713 RVA: 0x001D0849 File Offset: 0x001CEA49
		// (set) Token: 0x060031AA RID: 12714 RVA: 0x001D0851 File Offset: 0x001CEA51
		public bool WithNoWait
		{
			get
			{
				return this._withNoWait;
			}
			set
			{
				this._withNoWait = value;
			}
		}

		// Token: 0x060031AB RID: 12715 RVA: 0x001D085A File Offset: 0x001CEA5A
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060031AC RID: 12716 RVA: 0x001D0866 File Offset: 0x001CEA66
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F9A RID: 8090
		private bool _withNoWait;
	}
}
