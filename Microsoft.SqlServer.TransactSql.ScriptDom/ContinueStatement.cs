using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200024C RID: 588
	[Serializable]
	public class ContinueStatement : TSqlStatement
	{
		// Token: 0x06002C5F RID: 11359 RVA: 0x001CAE07 File Offset: 0x001C9007
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002C60 RID: 11360 RVA: 0x001CAE13 File Offset: 0x001C9013
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
