using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002E4 RID: 740
	[Serializable]
	public class SearchPropertyListFullTextIndexOption : FullTextIndexOption
	{
		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06002FFB RID: 12283 RVA: 0x001CEDB0 File Offset: 0x001CCFB0
		// (set) Token: 0x06002FFC RID: 12284 RVA: 0x001CEDB8 File Offset: 0x001CCFB8
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

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06002FFD RID: 12285 RVA: 0x001CEDC1 File Offset: 0x001CCFC1
		// (set) Token: 0x06002FFE RID: 12286 RVA: 0x001CEDC9 File Offset: 0x001CCFC9
		public Identifier PropertyListName
		{
			get
			{
				return this._propertyListName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._propertyListName = value;
			}
		}

		// Token: 0x06002FFF RID: 12287 RVA: 0x001CEDD9 File Offset: 0x001CCFD9
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003000 RID: 12288 RVA: 0x001CEDE5 File Offset: 0x001CCFE5
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.PropertyListName != null)
			{
				this.PropertyListName.Accept(visitor);
			}
		}

		// Token: 0x04001F2E RID: 7982
		private bool _isOff;

		// Token: 0x04001F2F RID: 7983
		private Identifier _propertyListName;
	}
}
