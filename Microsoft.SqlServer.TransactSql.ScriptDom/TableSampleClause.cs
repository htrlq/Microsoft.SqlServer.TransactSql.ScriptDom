using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003E3 RID: 995
	[Serializable]
	public class TableSampleClause : TSqlFragment
	{
		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x0600362D RID: 13869 RVA: 0x001D5238 File Offset: 0x001D3438
		// (set) Token: 0x0600362E RID: 13870 RVA: 0x001D5240 File Offset: 0x001D3440
		public bool System
		{
			get
			{
				return this._system;
			}
			set
			{
				this._system = value;
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x0600362F RID: 13871 RVA: 0x001D5249 File Offset: 0x001D3449
		// (set) Token: 0x06003630 RID: 13872 RVA: 0x001D5251 File Offset: 0x001D3451
		public ScalarExpression SampleNumber
		{
			get
			{
				return this._sampleNumber;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._sampleNumber = value;
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06003631 RID: 13873 RVA: 0x001D5261 File Offset: 0x001D3461
		// (set) Token: 0x06003632 RID: 13874 RVA: 0x001D5269 File Offset: 0x001D3469
		public TableSampleClauseOption TableSampleClauseOption
		{
			get
			{
				return this._tableSampleClauseOption;
			}
			set
			{
				this._tableSampleClauseOption = value;
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06003633 RID: 13875 RVA: 0x001D5272 File Offset: 0x001D3472
		// (set) Token: 0x06003634 RID: 13876 RVA: 0x001D527A File Offset: 0x001D347A
		public ScalarExpression RepeatSeed
		{
			get
			{
				return this._repeatSeed;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._repeatSeed = value;
			}
		}

		// Token: 0x06003635 RID: 13877 RVA: 0x001D528A File Offset: 0x001D348A
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003636 RID: 13878 RVA: 0x001D5296 File Offset: 0x001D3496
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.SampleNumber != null)
			{
				this.SampleNumber.Accept(visitor);
			}
			if (this.RepeatSeed != null)
			{
				this.RepeatSeed.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x040020F9 RID: 8441
		private bool _system;

		// Token: 0x040020FA RID: 8442
		private ScalarExpression _sampleNumber;

		// Token: 0x040020FB RID: 8443
		private TableSampleClauseOption _tableSampleClauseOption;

		// Token: 0x040020FC RID: 8444
		private ScalarExpression _repeatSeed;
	}
}
