using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200024B RID: 587
	[Serializable]
	public class SaveTransactionStatement : TransactionStatement
	{
		// Token: 0x06002C5C RID: 11356 RVA: 0x001CADEA File Offset: 0x001C8FEA
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002C5D RID: 11357 RVA: 0x001CADF6 File Offset: 0x001C8FF6
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
