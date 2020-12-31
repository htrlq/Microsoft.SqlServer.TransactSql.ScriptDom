using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000426 RID: 1062
	[Serializable]
	public class AlterColumnAlterFullTextIndexAction : AlterFullTextIndexAction
	{
		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x060037AE RID: 14254 RVA: 0x001D6A3D File Offset: 0x001D4C3D
		// (set) Token: 0x060037AF RID: 14255 RVA: 0x001D6A45 File Offset: 0x001D4C45
		public FullTextIndexColumn Column
		{
			get
			{
				return this._column;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._column = value;
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x060037B0 RID: 14256 RVA: 0x001D6A55 File Offset: 0x001D4C55
		// (set) Token: 0x060037B1 RID: 14257 RVA: 0x001D6A5D File Offset: 0x001D4C5D
		public bool WithNoPopulation
		{
			get
			{
				return this._withNoPopulation;
			}
			set
			{
				this._withNoPopulation = value;
			}
		}

		// Token: 0x060037B2 RID: 14258 RVA: 0x001D6A66 File Offset: 0x001D4C66
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060037B3 RID: 14259 RVA: 0x001D6A72 File Offset: 0x001D4C72
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Column != null)
			{
				this.Column.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400215F RID: 8543
		private FullTextIndexColumn _column;

		// Token: 0x04002160 RID: 8544
		private bool _withNoPopulation;
	}
}
