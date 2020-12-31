using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200025A RID: 602
	[Serializable]
	public abstract class UpdateDeleteSpecificationBase : DataModificationSpecification
	{
		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06002CB4 RID: 11444 RVA: 0x001CB428 File Offset: 0x001C9628
		// (set) Token: 0x06002CB5 RID: 11445 RVA: 0x001CB430 File Offset: 0x001C9630
		public FromClause FromClause
		{
			get
			{
				return this._fromClause;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._fromClause = value;
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06002CB6 RID: 11446 RVA: 0x001CB440 File Offset: 0x001C9640
		// (set) Token: 0x06002CB7 RID: 11447 RVA: 0x001CB448 File Offset: 0x001C9648
		public WhereClause WhereClause
		{
			get
			{
				return this._whereClause;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._whereClause = value;
			}
		}

		// Token: 0x06002CB8 RID: 11448 RVA: 0x001CB458 File Offset: 0x001C9658
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.FromClause != null)
			{
				this.FromClause.Accept(visitor);
			}
			if (this.WhereClause != null)
			{
				this.WhereClause.Accept(visitor);
			}
		}

		// Token: 0x04001E3A RID: 7738
		private FromClause _fromClause;

		// Token: 0x04001E3B RID: 7739
		private WhereClause _whereClause;
	}
}
