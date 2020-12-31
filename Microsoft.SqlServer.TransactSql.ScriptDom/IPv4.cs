using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003BC RID: 956
	[Serializable]
	public class IPv4 : TSqlFragment
	{
		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06003533 RID: 13619 RVA: 0x001D41B0 File Offset: 0x001D23B0
		// (set) Token: 0x06003534 RID: 13620 RVA: 0x001D41B8 File Offset: 0x001D23B8
		public Literal OctetOne
		{
			get
			{
				return this._octetOne;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._octetOne = value;
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06003535 RID: 13621 RVA: 0x001D41C8 File Offset: 0x001D23C8
		// (set) Token: 0x06003536 RID: 13622 RVA: 0x001D41D0 File Offset: 0x001D23D0
		public Literal OctetTwo
		{
			get
			{
				return this._octetTwo;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._octetTwo = value;
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06003537 RID: 13623 RVA: 0x001D41E0 File Offset: 0x001D23E0
		// (set) Token: 0x06003538 RID: 13624 RVA: 0x001D41E8 File Offset: 0x001D23E8
		public Literal OctetThree
		{
			get
			{
				return this._octetThree;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._octetThree = value;
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06003539 RID: 13625 RVA: 0x001D41F8 File Offset: 0x001D23F8
		// (set) Token: 0x0600353A RID: 13626 RVA: 0x001D4200 File Offset: 0x001D2400
		public Literal OctetFour
		{
			get
			{
				return this._octetFour;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._octetFour = value;
			}
		}

		// Token: 0x0600353B RID: 13627 RVA: 0x001D4210 File Offset: 0x001D2410
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600353C RID: 13628 RVA: 0x001D421C File Offset: 0x001D241C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.OctetOne != null)
			{
				this.OctetOne.Accept(visitor);
			}
			if (this.OctetTwo != null)
			{
				this.OctetTwo.Accept(visitor);
			}
			if (this.OctetThree != null)
			{
				this.OctetThree.Accept(visitor);
			}
			if (this.OctetFour != null)
			{
				this.OctetFour.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x040020AE RID: 8366
		private Literal _octetOne;

		// Token: 0x040020AF RID: 8367
		private Literal _octetTwo;

		// Token: 0x040020B0 RID: 8368
		private Literal _octetThree;

		// Token: 0x040020B1 RID: 8369
		private Literal _octetFour;
	}
}
