using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003B6 RID: 950
	[Serializable]
	public abstract class EndpointProtocolOption : TSqlFragment
	{
		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06003510 RID: 13584 RVA: 0x001D3FFC File Offset: 0x001D21FC
		// (set) Token: 0x06003511 RID: 13585 RVA: 0x001D4004 File Offset: 0x001D2204
		public EndpointProtocolOptions Kind
		{
			get
			{
				return this._kind;
			}
			set
			{
				this._kind = value;
			}
		}

		// Token: 0x06003512 RID: 13586 RVA: 0x001D400D File Offset: 0x001D220D
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x040020A5 RID: 8357
		private EndpointProtocolOptions _kind;
	}
}
