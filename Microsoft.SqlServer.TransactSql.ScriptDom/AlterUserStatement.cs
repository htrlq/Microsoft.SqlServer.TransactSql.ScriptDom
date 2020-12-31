using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000300 RID: 768
	[Serializable]
	public class AlterUserStatement : UserStatement
	{
		// Token: 0x06003087 RID: 12423 RVA: 0x001CF5DF File Offset: 0x001CD7DF
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003088 RID: 12424 RVA: 0x001CF5EB File Offset: 0x001CD7EB
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
