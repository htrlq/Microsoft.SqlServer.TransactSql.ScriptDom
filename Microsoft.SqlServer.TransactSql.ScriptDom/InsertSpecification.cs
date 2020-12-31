using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200025D RID: 605
	[Serializable]
	public class InsertSpecification : DataModificationSpecification
	{
		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06002CC2 RID: 11458 RVA: 0x001CB4F7 File Offset: 0x001C96F7
		// (set) Token: 0x06002CC3 RID: 11459 RVA: 0x001CB4FF File Offset: 0x001C96FF
		public InsertOption InsertOption
		{
			get
			{
				return this._insertOption;
			}
			set
			{
				this._insertOption = value;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06002CC4 RID: 11460 RVA: 0x001CB508 File Offset: 0x001C9708
		// (set) Token: 0x06002CC5 RID: 11461 RVA: 0x001CB510 File Offset: 0x001C9710
		public InsertSource InsertSource
		{
			get
			{
				return this._insertSource;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._insertSource = value;
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06002CC6 RID: 11462 RVA: 0x001CB520 File Offset: 0x001C9720
		public IList<ColumnReferenceExpression> Columns
		{
			get
			{
				return this._columns;
			}
		}

		// Token: 0x06002CC7 RID: 11463 RVA: 0x001CB528 File Offset: 0x001C9728
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002CC8 RID: 11464 RVA: 0x001CB534 File Offset: 0x001C9734
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.InsertSource != null)
			{
				this.InsertSource.Accept(visitor);
			}
			int i = 0;
			int count = this.Columns.Count;
			while (i < count)
			{
				this.Columns[i].Accept(visitor);
				i++;
			}
		}

		// Token: 0x04001E3D RID: 7741
		private InsertOption _insertOption;

		// Token: 0x04001E3E RID: 7742
		private InsertSource _insertSource;

		// Token: 0x04001E3F RID: 7743
		private List<ColumnReferenceExpression> _columns = new List<ColumnReferenceExpression>();
	}
}
