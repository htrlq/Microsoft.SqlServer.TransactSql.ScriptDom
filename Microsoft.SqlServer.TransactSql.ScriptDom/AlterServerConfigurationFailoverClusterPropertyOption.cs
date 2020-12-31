using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004CA RID: 1226
	[Serializable]
	public class AlterServerConfigurationFailoverClusterPropertyOption : TSqlFragment
	{
		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06003B48 RID: 15176 RVA: 0x001DA249 File Offset: 0x001D8449
		// (set) Token: 0x06003B49 RID: 15177 RVA: 0x001DA251 File Offset: 0x001D8451
		public AlterServerConfigurationFailoverClusterPropertyOptionKind OptionKind
		{
			get
			{
				return this._optionKind;
			}
			set
			{
				this._optionKind = value;
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06003B4A RID: 15178 RVA: 0x001DA25A File Offset: 0x001D845A
		// (set) Token: 0x06003B4B RID: 15179 RVA: 0x001DA262 File Offset: 0x001D8462
		public OptionValue OptionValue
		{
			get
			{
				return this._optionValue;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._optionValue = value;
			}
		}

		// Token: 0x06003B4C RID: 15180 RVA: 0x001DA272 File Offset: 0x001D8472
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003B4D RID: 15181 RVA: 0x001DA27E File Offset: 0x001D847E
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.OptionValue != null)
			{
				this.OptionValue.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002253 RID: 8787
		private AlterServerConfigurationFailoverClusterPropertyOptionKind _optionKind;

		// Token: 0x04002254 RID: 8788
		private OptionValue _optionValue;
	}
}
