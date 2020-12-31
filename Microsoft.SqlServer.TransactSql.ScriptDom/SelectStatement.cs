using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200020B RID: 523
	[Serializable]
	public class SelectStatement : StatementWithCtesAndXmlNamespaces
	{
		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06002AC7 RID: 10951 RVA: 0x001C9085 File Offset: 0x001C7285
		// (set) Token: 0x06002AC8 RID: 10952 RVA: 0x001C908D File Offset: 0x001C728D
		public QueryExpression QueryExpression
		{
			get
			{
				return this._queryExpression;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._queryExpression = value;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06002AC9 RID: 10953 RVA: 0x001C909D File Offset: 0x001C729D
		// (set) Token: 0x06002ACA RID: 10954 RVA: 0x001C90A5 File Offset: 0x001C72A5
		public SchemaObjectName Into
		{
			get
			{
				return this._into;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._into = value;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06002ACB RID: 10955 RVA: 0x001C90B5 File Offset: 0x001C72B5
		public IList<ComputeClause> ComputeClauses
		{
			get
			{
				return this._computeClauses;
			}
		}

		// Token: 0x06002ACC RID: 10956 RVA: 0x001C90BD File Offset: 0x001C72BD
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002ACD RID: 10957 RVA: 0x001C90CC File Offset: 0x001C72CC
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.QueryExpression != null)
			{
				this.QueryExpression.Accept(visitor);
			}
			if (this.Into != null)
			{
				this.Into.Accept(visitor);
			}
			int i = 0;
			int count = this.ComputeClauses.Count;
			while (i < count)
			{
				this.ComputeClauses[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001DAB RID: 7595
		private QueryExpression _queryExpression;

		// Token: 0x04001DAC RID: 7596
		private SchemaObjectName _into;

		// Token: 0x04001DAD RID: 7597
		private List<ComputeClause> _computeClauses = new List<ComputeClause>();
	}
}
