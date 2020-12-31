using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200024A RID: 586
	[Serializable]
	public class RollbackTransactionStatement : TransactionStatement
	{
		// Token: 0x06002C59 RID: 11353 RVA: 0x001CADCD File Offset: 0x001C8FCD
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002C5A RID: 11354 RVA: 0x001CADD9 File Offset: 0x001C8FD9
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
