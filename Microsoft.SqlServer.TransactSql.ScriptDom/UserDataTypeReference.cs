using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001F2 RID: 498
	[Serializable]
	public class UserDataTypeReference : ParameterizedDataTypeReference
	{
		// Token: 0x06002A30 RID: 10800 RVA: 0x001C85B7 File Offset: 0x001C67B7
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002A31 RID: 10801 RVA: 0x001C85C3 File Offset: 0x001C67C3
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
