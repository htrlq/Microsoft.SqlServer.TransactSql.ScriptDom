using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000418 RID: 1048
	[Serializable]
	public class DropMasterKeyStatement : TSqlStatement
	{
		// Token: 0x06003763 RID: 14179 RVA: 0x001D6636 File Offset: 0x001D4836
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003764 RID: 14180 RVA: 0x001D6642 File Offset: 0x001D4842
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
