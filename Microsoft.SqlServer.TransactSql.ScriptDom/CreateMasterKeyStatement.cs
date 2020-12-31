using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002EC RID: 748
	[Serializable]
	public class CreateMasterKeyStatement : MasterKeyStatement
	{
		// Token: 0x06003030 RID: 12336 RVA: 0x001CF0BC File Offset: 0x001CD2BC
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003031 RID: 12337 RVA: 0x001CF0C8 File Offset: 0x001CD2C8
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
