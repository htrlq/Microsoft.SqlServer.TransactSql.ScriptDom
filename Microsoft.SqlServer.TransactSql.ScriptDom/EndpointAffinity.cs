using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003B5 RID: 949
	[Serializable]
	public class EndpointAffinity : TSqlFragment
	{
		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06003509 RID: 13577 RVA: 0x001D3FA2 File Offset: 0x001D21A2
		// (set) Token: 0x0600350A RID: 13578 RVA: 0x001D3FAA File Offset: 0x001D21AA
		public AffinityKind Kind
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

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x0600350B RID: 13579 RVA: 0x001D3FB3 File Offset: 0x001D21B3
		// (set) Token: 0x0600350C RID: 13580 RVA: 0x001D3FBB File Offset: 0x001D21BB
		public Literal Value
		{
			get
			{
				return this._value;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._value = value;
			}
		}

		// Token: 0x0600350D RID: 13581 RVA: 0x001D3FCB File Offset: 0x001D21CB
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600350E RID: 13582 RVA: 0x001D3FD7 File Offset: 0x001D21D7
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Value != null)
			{
				this.Value.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x040020A3 RID: 8355
		private AffinityKind _kind;

		// Token: 0x040020A4 RID: 8356
		private Literal _value;
	}
}
