using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200048F RID: 1167
	[Serializable]
	public class ResourcePoolParameter : TSqlFragment
	{
		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x060039FB RID: 14843 RVA: 0x001D8D51 File Offset: 0x001D6F51
		// (set) Token: 0x060039FC RID: 14844 RVA: 0x001D8D59 File Offset: 0x001D6F59
		public ResourcePoolParameterType ParameterType
		{
			get
			{
				return this._parameterType;
			}
			set
			{
				this._parameterType = value;
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x060039FD RID: 14845 RVA: 0x001D8D62 File Offset: 0x001D6F62
		// (set) Token: 0x060039FE RID: 14846 RVA: 0x001D8D6A File Offset: 0x001D6F6A
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

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x060039FF RID: 14847 RVA: 0x001D8D7A File Offset: 0x001D6F7A
		// (set) Token: 0x06003A00 RID: 14848 RVA: 0x001D8D82 File Offset: 0x001D6F82
		public ResourcePoolAffinitySpecification AffinitySpecification
		{
			get
			{
				return this._affinitySpecification;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._affinitySpecification = value;
			}
		}

		// Token: 0x06003A01 RID: 14849 RVA: 0x001D8D92 File Offset: 0x001D6F92
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003A02 RID: 14850 RVA: 0x001D8D9E File Offset: 0x001D6F9E
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.ParameterValue != null)
			{
				this.ParameterValue.Accept(visitor);
			}
			if (this.AffinitySpecification != null)
			{
				this.AffinitySpecification.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x040021F9 RID: 8697
		private ResourcePoolParameterType _parameterType;

		// Token: 0x040021FA RID: 8698
		private Literal _parameterValue;

		// Token: 0x040021FB RID: 8699
		private ResourcePoolAffinitySpecification _affinitySpecification;
	}
}
