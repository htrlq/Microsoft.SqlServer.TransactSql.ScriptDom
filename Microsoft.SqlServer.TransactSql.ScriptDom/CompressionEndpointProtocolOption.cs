using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003BA RID: 954
	[Serializable]
	public class CompressionEndpointProtocolOption : EndpointProtocolOption
	{
		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06003523 RID: 13603 RVA: 0x001D40C3 File Offset: 0x001D22C3
		// (set) Token: 0x06003524 RID: 13604 RVA: 0x001D40CB File Offset: 0x001D22CB
		public bool IsEnabled
		{
			get
			{
				return this._isEnabled;
			}
			set
			{
				this._isEnabled = value;
			}
		}

		// Token: 0x06003525 RID: 13605 RVA: 0x001D40D4 File Offset: 0x001D22D4
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003526 RID: 13606 RVA: 0x001D40E0 File Offset: 0x001D22E0
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x040020A9 RID: 8361
		private bool _isEnabled;
	}
}
