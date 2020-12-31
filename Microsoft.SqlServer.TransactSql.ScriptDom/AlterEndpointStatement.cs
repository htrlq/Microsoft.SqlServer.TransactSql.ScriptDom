using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003B4 RID: 948
	[Serializable]
	public class AlterEndpointStatement : AlterCreateEndpointStatementBase
	{
		// Token: 0x06003506 RID: 13574 RVA: 0x001D3F85 File Offset: 0x001D2185
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003507 RID: 13575 RVA: 0x001D3F91 File Offset: 0x001D2191
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
