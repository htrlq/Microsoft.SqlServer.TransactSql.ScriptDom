using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000490 RID: 1168
	[Serializable]
	public class ResourcePoolAffinitySpecification : TSqlFragment
	{
		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06003A04 RID: 14852 RVA: 0x001D8DD7 File Offset: 0x001D6FD7
		// (set) Token: 0x06003A05 RID: 14853 RVA: 0x001D8DDF File Offset: 0x001D6FDF
		public ResourcePoolAffinityType AffinityType
		{
			get
			{
				return this._affinityType;
			}
			set
			{
				this._affinityType = value;
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06003A06 RID: 14854 RVA: 0x001D8DE8 File Offset: 0x001D6FE8
		// (set) Token: 0x06003A07 RID: 14855 RVA: 0x001D8DF0 File Offset: 0x001D6FF0
		public Literal ParameterValue
		{
			get
			{
				return this._parameterValue;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._parameterValue = value;
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06003A08 RID: 14856 RVA: 0x001D8E00 File Offset: 0x001D7000
		// (set) Token: 0x06003A09 RID: 14857 RVA: 0x001D8E08 File Offset: 0x001D7008
		public bool IsAuto
		{
			get
			{
				return this._isAuto;
			}
			set
			{
				this._isAuto = value;
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06003A0A RID: 14858 RVA: 0x001D8E11 File Offset: 0x001D7011
		public IList<LiteralRange> PoolAffinityRanges
		{
			get
			{
				return this._poolAffinityRanges;
			}
		}

		// Token: 0x06003A0B RID: 14859 RVA: 0x001D8E19 File Offset: 0x001D7019
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003A0C RID: 14860 RVA: 0x001D8E28 File Offset: 0x001D7028
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.ParameterValue != null)
			{
				this.ParameterValue.Accept(visitor);
			}
			int i = 0;
			int count = this.PoolAffinityRanges.Count;
			while (i < count)
			{
				this.PoolAffinityRanges[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x040021FC RID: 8700
		private ResourcePoolAffinityType _affinityType;

		// Token: 0x040021FD RID: 8701
		private Literal _parameterValue;

		// Token: 0x040021FE RID: 8702
		private bool _isAuto;

		// Token: 0x040021FF RID: 8703
		private List<LiteralRange> _poolAffinityRanges = new List<LiteralRange>();
	}
}
