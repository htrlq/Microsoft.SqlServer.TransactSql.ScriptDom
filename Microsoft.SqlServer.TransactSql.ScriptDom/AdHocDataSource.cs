using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001D0 RID: 464
	[Serializable]
	public class AdHocDataSource : TSqlFragment
	{
		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06002970 RID: 10608 RVA: 0x001C77B5 File Offset: 0x001C59B5
		// (set) Token: 0x06002971 RID: 10609 RVA: 0x001C77BD File Offset: 0x001C59BD
		public StringLiteral ProviderName
		{
			get
			{
				return this._providerName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._providerName = value;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06002972 RID: 10610 RVA: 0x001C77CD File Offset: 0x001C59CD
		// (set) Token: 0x06002973 RID: 10611 RVA: 0x001C77D5 File Offset: 0x001C59D5
		public StringLiteral InitString
		{
			get
			{
				return this._initString;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._initString = value;
			}
		}

		// Token: 0x06002974 RID: 10612 RVA: 0x001C77E5 File Offset: 0x001C59E5
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002975 RID: 10613 RVA: 0x001C77F1 File Offset: 0x001C59F1
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.ProviderName != null)
			{
				this.ProviderName.Accept(visitor);
			}
			if (this.InitString != null)
			{
				this.InitString.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001D46 RID: 7494
		private StringLiteral _providerName;

		// Token: 0x04001D47 RID: 7495
		private StringLiteral _initString;
	}
}
