using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001F5 RID: 501
	[Serializable]
	public class SelectFunctionReturnType : FunctionReturnType
	{
		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06002A3F RID: 10815 RVA: 0x001C8677 File Offset: 0x001C6877
		// (set) Token: 0x06002A40 RID: 10816 RVA: 0x001C867F File Offset: 0x001C687F
		public SelectStatement SelectStatement
		{
			get
			{
				return this._selectStatement;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._selectStatement = value;
			}
		}

		// Token: 0x06002A41 RID: 10817 RVA: 0x001C868F File Offset: 0x001C688F
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002A42 RID: 10818 RVA: 0x001C869B File Offset: 0x001C689B
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.SelectStatement != null)
			{
				this.SelectStatement.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001D80 RID: 7552
		private SelectStatement _selectStatement;
	}
}
