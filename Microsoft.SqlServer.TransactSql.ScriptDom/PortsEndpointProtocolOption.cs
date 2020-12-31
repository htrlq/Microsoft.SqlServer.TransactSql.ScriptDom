using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003B9 RID: 953
	[Serializable]
	public class PortsEndpointProtocolOption : EndpointProtocolOption
	{
		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x0600351E RID: 13598 RVA: 0x001D4095 File Offset: 0x001D2295
		// (set) Token: 0x0600351F RID: 13599 RVA: 0x001D409D File Offset: 0x001D229D
		public PortTypes PortTypes
		{
			get
			{
				return this._portTypes;
			}
			set
			{
				this._portTypes = value;
			}
		}

		// Token: 0x06003520 RID: 13600 RVA: 0x001D40A6 File Offset: 0x001D22A6
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003521 RID: 13601 RVA: 0x001D40B2 File Offset: 0x001D22B2
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x040020A8 RID: 8360
		private PortTypes _portTypes;
	}
}
