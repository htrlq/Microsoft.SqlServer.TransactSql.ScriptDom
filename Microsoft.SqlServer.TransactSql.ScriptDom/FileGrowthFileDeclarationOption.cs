using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200034B RID: 843
	[Serializable]
	public class FileGrowthFileDeclarationOption : FileDeclarationOption
	{
		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06003231 RID: 12849 RVA: 0x001D0FF7 File Offset: 0x001CF1F7
		// (set) Token: 0x06003232 RID: 12850 RVA: 0x001D0FFF File Offset: 0x001CF1FF
		public Literal GrowthIncrement
		{
			get
			{
				return this._growthIncrement;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._growthIncrement = value;
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06003233 RID: 12851 RVA: 0x001D100F File Offset: 0x001CF20F
		// (set) Token: 0x06003234 RID: 12852 RVA: 0x001D1017 File Offset: 0x001CF217
		public MemoryUnit Units
		{
			get
			{
				return this._units;
			}
			set
			{
				this._units = value;
			}
		}

		// Token: 0x06003235 RID: 12853 RVA: 0x001D1020 File Offset: 0x001CF220
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003236 RID: 12854 RVA: 0x001D102C File Offset: 0x001CF22C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.GrowthIncrement != null)
			{
				this.GrowthIncrement.Accept(visitor);
			}
		}

		// Token: 0x04001FBF RID: 8127
		private Literal _growthIncrement;

		// Token: 0x04001FC0 RID: 8128
		private MemoryUnit _units;
	}
}
