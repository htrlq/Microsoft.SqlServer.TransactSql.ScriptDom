using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000337 RID: 823
	[Serializable]
	public abstract class SetOnOffStatement : TSqlStatement
	{
		// Token: 0x17000370 RID: 880
		// (get) Token: 0x060031BA RID: 12730 RVA: 0x001D091A File Offset: 0x001CEB1A
		// (set) Token: 0x060031BB RID: 12731 RVA: 0x001D0922 File Offset: 0x001CEB22
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

		// Token: 0x060031BC RID: 12732 RVA: 0x001D092B File Offset: 0x001CEB2B
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F9E RID: 8094
		private bool _isOn;
	}
}
