using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002E3 RID: 739
	[Serializable]
	public class StopListFullTextIndexOption : FullTextIndexOption
	{
		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06002FF4 RID: 12276 RVA: 0x001CED56 File Offset: 0x001CCF56
		// (set) Token: 0x06002FF5 RID: 12277 RVA: 0x001CED5E File Offset: 0x001CCF5E
		public bool IsOff
		{
			get
			{
				return this._isOff;
			}
			set
			{
				this._isOff = value;
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06002FF6 RID: 12278 RVA: 0x001CED67 File Offset: 0x001CCF67
		// (set) Token: 0x06002FF7 RID: 12279 RVA: 0x001CED6F File Offset: 0x001CCF6F
		public Identifier StopListName
		{
			get
			{
				return this._stopListName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._stopListName = value;
			}
		}

		// Token: 0x06002FF8 RID: 12280 RVA: 0x001CED7F File Offset: 0x001CCF7F
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002FF9 RID: 12281 RVA: 0x001CED8B File Offset: 0x001CCF8B
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.StopListName != null)
			{
				this.StopListName.Accept(visitor);
			}
		}

		// Token: 0x04001F2C RID: 7980
		private bool _isOff;

		// Token: 0x04001F2D RID: 7981
		private Identifier _stopListName;
	}
}
