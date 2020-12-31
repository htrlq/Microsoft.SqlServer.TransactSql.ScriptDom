using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000259 RID: 601
	[Serializable]
	public abstract class DataModificationSpecification : TSqlFragment
	{
		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06002CAA RID: 11434 RVA: 0x001CB35C File Offset: 0x001C955C
		// (set) Token: 0x06002CAB RID: 11435 RVA: 0x001CB364 File Offset: 0x001C9564
		public TableReference Target
		{
			get
			{
				return this._target;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._target = value;
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06002CAC RID: 11436 RVA: 0x001CB374 File Offset: 0x001C9574
		// (set) Token: 0x06002CAD RID: 11437 RVA: 0x001CB37C File Offset: 0x001C957C
		public TopRowFilter TopRowFilter
		{
			get
			{
				return this._topRowFilter;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._topRowFilter = value;
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06002CAE RID: 11438 RVA: 0x001CB38C File Offset: 0x001C958C
		// (set) Token: 0x06002CAF RID: 11439 RVA: 0x001CB394 File Offset: 0x001C9594
		public OutputIntoClause OutputIntoClause
		{
			get
			{
				return this._outputIntoClause;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._outputIntoClause = value;
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06002CB0 RID: 11440 RVA: 0x001CB3A4 File Offset: 0x001C95A4
		// (set) Token: 0x06002CB1 RID: 11441 RVA: 0x001CB3AC File Offset: 0x001C95AC
		public OutputClause OutputClause
		{
			get
			{
				return this._outputClause;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._outputClause = value;
			}
		}

		// Token: 0x06002CB2 RID: 11442 RVA: 0x001CB3BC File Offset: 0x001C95BC
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Target != null)
			{
				this.Target.Accept(visitor);
			}
			if (this.TopRowFilter != null)
			{
				this.TopRowFilter.Accept(visitor);
			}
			if (this.OutputIntoClause != null)
			{
				this.OutputIntoClause.Accept(visitor);
			}
			if (this.OutputClause != null)
			{
				this.OutputClause.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E36 RID: 7734
		private TableReference _target;

		// Token: 0x04001E37 RID: 7735
		private TopRowFilter _topRowFilter;

		// Token: 0x04001E38 RID: 7736
		private OutputIntoClause _outputIntoClause;

		// Token: 0x04001E39 RID: 7737
		private OutputClause _outputClause;
	}
}
