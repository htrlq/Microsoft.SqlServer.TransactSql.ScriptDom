using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002E1 RID: 737
	[Serializable]
	public abstract class FullTextIndexOption : TSqlFragment
	{
		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06002FEB RID: 12267 RVA: 0x001CED06 File Offset: 0x001CCF06
		// (set) Token: 0x06002FEC RID: 12268 RVA: 0x001CED0E File Offset: 0x001CCF0E
		public FullTextIndexOptionKind OptionKind
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

		// Token: 0x06002FED RID: 12269 RVA: 0x001CED17 File Offset: 0x001CCF17
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F2A RID: 7978
		private FullTextIndexOptionKind _optionKind;
	}
}
