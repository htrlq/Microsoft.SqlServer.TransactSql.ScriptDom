using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000303 RID: 771
	[Serializable]
	public class StatisticsPartitionRange : TSqlFragment
	{
		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06003093 RID: 12435 RVA: 0x001CF691 File Offset: 0x001CD891
		// (set) Token: 0x06003094 RID: 12436 RVA: 0x001CF699 File Offset: 0x001CD899
		public IntegerLiteral From
		{
			get
			{
				return this._from;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._from = value;
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06003095 RID: 12437 RVA: 0x001CF6A9 File Offset: 0x001CD8A9
		// (set) Token: 0x06003096 RID: 12438 RVA: 0x001CF6B1 File Offset: 0x001CD8B1
		public IntegerLiteral To
		{
			get
			{
				return this._to;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._to = value;
			}
		}

		// Token: 0x06003097 RID: 12439 RVA: 0x001CF6C1 File Offset: 0x001CD8C1
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003098 RID: 12440 RVA: 0x001CF6CD File Offset: 0x001CD8CD
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.From != null)
			{
				this.From.Accept(visitor);
			}
			if (this.To != null)
			{
				this.To.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F51 RID: 8017
		private IntegerLiteral _from;

		// Token: 0x04001F52 RID: 8018
		private IntegerLiteral _to;
	}
}
