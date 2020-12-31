using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003BB RID: 955
	[Serializable]
	public class ListenerIPEndpointProtocolOption : EndpointProtocolOption
	{
		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06003528 RID: 13608 RVA: 0x001D40F1 File Offset: 0x001D22F1
		// (set) Token: 0x06003529 RID: 13609 RVA: 0x001D40F9 File Offset: 0x001D22F9
		public bool IsAll
		{
			get
			{
				return this._isAll;
			}
			set
			{
				this._isAll = value;
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x0600352A RID: 13610 RVA: 0x001D4102 File Offset: 0x001D2302
		// (set) Token: 0x0600352B RID: 13611 RVA: 0x001D410A File Offset: 0x001D230A
		public Literal IPv6
		{
			get
			{
				return this._iPv6;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._iPv6 = value;
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x0600352C RID: 13612 RVA: 0x001D411A File Offset: 0x001D231A
		// (set) Token: 0x0600352D RID: 13613 RVA: 0x001D4122 File Offset: 0x001D2322
		public IPv4 IPv4PartOne
		{
			get
			{
				return this._iPv4PartOne;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._iPv4PartOne = value;
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x0600352E RID: 13614 RVA: 0x001D4132 File Offset: 0x001D2332
		// (set) Token: 0x0600352F RID: 13615 RVA: 0x001D413A File Offset: 0x001D233A
		public IPv4 IPv4PartTwo
		{
			get
			{
				return this._iPv4PartTwo;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._iPv4PartTwo = value;
			}
		}

		// Token: 0x06003530 RID: 13616 RVA: 0x001D414A File Offset: 0x001D234A
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003531 RID: 13617 RVA: 0x001D4158 File Offset: 0x001D2358
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.IPv6 != null)
			{
				this.IPv6.Accept(visitor);
			}
			if (this.IPv4PartOne != null)
			{
				this.IPv4PartOne.Accept(visitor);
			}
			if (this.IPv4PartTwo != null)
			{
				this.IPv4PartTwo.Accept(visitor);
			}
		}

		// Token: 0x040020AA RID: 8362
		private bool _isAll;

		// Token: 0x040020AB RID: 8363
		private Literal _iPv6;

		// Token: 0x040020AC RID: 8364
		private IPv4 _iPv4PartOne;

		// Token: 0x040020AD RID: 8365
		private IPv4 _iPv4PartTwo;
	}
}
