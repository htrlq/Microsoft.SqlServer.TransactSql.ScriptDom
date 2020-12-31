using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000238 RID: 568
	[Serializable]
	public class OverClause : TSqlFragment
	{
		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06002BF8 RID: 11256 RVA: 0x001CA795 File Offset: 0x001C8995
		public IList<ScalarExpression> Partitions
		{
			get
			{
				return this._partitions;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06002BF9 RID: 11257 RVA: 0x001CA79D File Offset: 0x001C899D
		// (set) Token: 0x06002BFA RID: 11258 RVA: 0x001CA7A5 File Offset: 0x001C89A5
		public OrderByClause OrderByClause
		{
			get
			{
				return this._orderByClause;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._orderByClause = value;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06002BFB RID: 11259 RVA: 0x001CA7B5 File Offset: 0x001C89B5
		// (set) Token: 0x06002BFC RID: 11260 RVA: 0x001CA7BD File Offset: 0x001C89BD
		public WindowFrameClause WindowFrameClause
		{
			get
			{
				return this._windowFrameClause;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._windowFrameClause = value;
			}
		}

		// Token: 0x06002BFD RID: 11261 RVA: 0x001CA7CD File Offset: 0x001C89CD
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002BFE RID: 11262 RVA: 0x001CA7DC File Offset: 0x001C89DC
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.Partitions.Count;
			while (i < count)
			{
				this.Partitions[i].Accept(visitor);
				i++;
			}
			if (this.OrderByClause != null)
			{
				this.OrderByClause.Accept(visitor);
			}
			if (this.WindowFrameClause != null)
			{
				this.WindowFrameClause.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E0B RID: 7691
		private List<ScalarExpression> _partitions = new List<ScalarExpression>();

		// Token: 0x04001E0C RID: 7692
		private OrderByClause _orderByClause;

		// Token: 0x04001E0D RID: 7693
		private WindowFrameClause _windowFrameClause;
	}
}
