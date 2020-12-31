using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200025C RID: 604
	[Serializable]
	public class InsertStatement : DataModificationStatement
	{
		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06002CBD RID: 11453 RVA: 0x001CB4AE File Offset: 0x001C96AE
		// (set) Token: 0x06002CBE RID: 11454 RVA: 0x001CB4B6 File Offset: 0x001C96B6
		public InsertSpecification InsertSpecification
		{
			get
			{
				return this._insertSpecification;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._insertSpecification = value;
			}
		}

		// Token: 0x06002CBF RID: 11455 RVA: 0x001CB4C6 File Offset: 0x001C96C6
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002CC0 RID: 11456 RVA: 0x001CB4D2 File Offset: 0x001C96D2
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.InsertSpecification != null)
			{
				this.InsertSpecification.Accept(visitor);
			}
		}

		// Token: 0x04001E3C RID: 7740
		private InsertSpecification _insertSpecification;
	}
}
