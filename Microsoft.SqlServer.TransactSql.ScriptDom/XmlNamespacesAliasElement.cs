using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001EA RID: 490
	[Serializable]
	public class XmlNamespacesAliasElement : XmlNamespacesElement
	{
		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06002A08 RID: 10760 RVA: 0x001C82D3 File Offset: 0x001C64D3
		// (set) Token: 0x06002A09 RID: 10761 RVA: 0x001C82DB File Offset: 0x001C64DB
		public Identifier Identifier
		{
			get
			{
				return this._identifier;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._identifier = value;
			}
		}

		// Token: 0x06002A0A RID: 10762 RVA: 0x001C82EB File Offset: 0x001C64EB
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002A0B RID: 10763 RVA: 0x001C82F7 File Offset: 0x001C64F7
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Identifier != null)
			{
				this.Identifier.Accept(visitor);
			}
		}

		// Token: 0x04001D72 RID: 7538
		private Identifier _identifier;
	}
}
