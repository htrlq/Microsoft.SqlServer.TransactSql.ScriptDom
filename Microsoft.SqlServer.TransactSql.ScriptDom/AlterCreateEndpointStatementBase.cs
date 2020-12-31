using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003B2 RID: 946
	[Serializable]
	public abstract class AlterCreateEndpointStatementBase : TSqlStatement
	{
		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x060034F3 RID: 13555 RVA: 0x001D3D99 File Offset: 0x001D1F99
		// (set) Token: 0x060034F4 RID: 13556 RVA: 0x001D3DA1 File Offset: 0x001D1FA1
		public Identifier Name
		{
			get
			{
				return this._name;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._name = value;
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x060034F5 RID: 13557 RVA: 0x001D3DB1 File Offset: 0x001D1FB1
		// (set) Token: 0x060034F6 RID: 13558 RVA: 0x001D3DB9 File Offset: 0x001D1FB9
		public EndpointState State
		{
			get
			{
				return this._state;
			}
			set
			{
				this._state = value;
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x060034F7 RID: 13559 RVA: 0x001D3DC2 File Offset: 0x001D1FC2
		// (set) Token: 0x060034F8 RID: 13560 RVA: 0x001D3DCA File Offset: 0x001D1FCA
		public EndpointAffinity Affinity
		{
			get
			{
				return this._affinity;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._affinity = value;
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x060034F9 RID: 13561 RVA: 0x001D3DDA File Offset: 0x001D1FDA
		// (set) Token: 0x060034FA RID: 13562 RVA: 0x001D3DE2 File Offset: 0x001D1FE2
		public EndpointProtocol Protocol
		{
			get
			{
				return this._protocol;
			}
			set
			{
				this._protocol = value;
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x060034FB RID: 13563 RVA: 0x001D3DEB File Offset: 0x001D1FEB
		public IList<EndpointProtocolOption> ProtocolOptions
		{
			get
			{
				return this._protocolOptions;
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x060034FC RID: 13564 RVA: 0x001D3DF3 File Offset: 0x001D1FF3
		// (set) Token: 0x060034FD RID: 13565 RVA: 0x001D3DFB File Offset: 0x001D1FFB
		public EndpointType EndpointType
		{
			get
			{
				return this._endpointType;
			}
			set
			{
				this._endpointType = value;
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x060034FE RID: 13566 RVA: 0x001D3E04 File Offset: 0x001D2004
		public IList<PayloadOption> PayloadOptions
		{
			get
			{
				return this._payloadOptions;
			}
		}

		// Token: 0x060034FF RID: 13567 RVA: 0x001D3E0C File Offset: 0x001D200C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			if (this.Affinity != null)
			{
				this.Affinity.Accept(visitor);
			}
			int i = 0;
			int count = this.ProtocolOptions.Count;
			while (i < count)
			{
				this.ProtocolOptions[i].Accept(visitor);
				i++;
			}
			int j = 0;
			int count2 = this.PayloadOptions.Count;
			while (j < count2)
			{
				this.PayloadOptions[j].Accept(visitor);
				j++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400209B RID: 8347
		private Identifier _name;

		// Token: 0x0400209C RID: 8348
		private EndpointState _state;

		// Token: 0x0400209D RID: 8349
		private EndpointAffinity _affinity;

		// Token: 0x0400209E RID: 8350
		private EndpointProtocol _protocol;

		// Token: 0x0400209F RID: 8351
		private List<EndpointProtocolOption> _protocolOptions = new List<EndpointProtocolOption>();

		// Token: 0x040020A0 RID: 8352
		private EndpointType _endpointType;

		// Token: 0x040020A1 RID: 8353
		private List<PayloadOption> _payloadOptions = new List<PayloadOption>();
	}
}
