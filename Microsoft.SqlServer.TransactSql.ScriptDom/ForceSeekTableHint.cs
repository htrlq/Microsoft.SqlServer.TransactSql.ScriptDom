using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000215 RID: 533
	[Serializable]
	public class ForceSeekTableHint : TableHint
	{
		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06002AF6 RID: 10998 RVA: 0x001C93BD File Offset: 0x001C75BD
		// (set) Token: 0x06002AF7 RID: 10999 RVA: 0x001C93C5 File Offset: 0x001C75C5
		public IdentifierOrValueExpression IndexValue
		{
			get
			{
				return this._indexValue;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._indexValue = value;
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06002AF8 RID: 11000 RVA: 0x001C93D5 File Offset: 0x001C75D5
		public IList<ColumnReferenceExpression> ColumnValues
		{
			get
			{
				return this._columnValues;
			}
		}

		// Token: 0x06002AF9 RID: 11001 RVA: 0x001C93DD File Offset: 0x001C75DD
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002AFA RID: 11002 RVA: 0x001C93EC File Offset: 0x001C75EC
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.IndexValue != null)
			{
				this.IndexValue.Accept(visitor);
			}
			int i = 0;
			int count = this.ColumnValues.Count;
			while (i < count)
			{
				this.ColumnValues[i].Accept(visitor);
				i++;
			}
		}

		// Token: 0x04001DB6 RID: 7606
		private IdentifierOrValueExpression _indexValue;

		// Token: 0x04001DB7 RID: 7607
		private List<ColumnReferenceExpression> _columnValues = new List<ColumnReferenceExpression>();
	}
}
