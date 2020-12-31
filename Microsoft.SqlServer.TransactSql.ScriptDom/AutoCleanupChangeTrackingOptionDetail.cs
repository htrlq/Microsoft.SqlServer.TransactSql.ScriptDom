using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200036B RID: 875
	[Serializable]
	public class AutoCleanupChangeTrackingOptionDetail : ChangeTrackingOptionDetail
	{
		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x060032F7 RID: 13047 RVA: 0x001D1A6E File Offset: 0x001CFC6E
		// (set) Token: 0x060032F8 RID: 13048 RVA: 0x001D1A76 File Offset: 0x001CFC76
		public bool IsOn
		{
			get
			{
				return this._isOn;
			}
			set
			{
				this._isOn = value;
			}
		}

		// Token: 0x060032F9 RID: 13049 RVA: 0x001D1A7F File Offset: 0x001CFC7F
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060032FA RID: 13050 RVA: 0x001D1A8B File Offset: 0x001CFC8B
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001FF5 RID: 8181
		private bool _isOn;
	}
}
