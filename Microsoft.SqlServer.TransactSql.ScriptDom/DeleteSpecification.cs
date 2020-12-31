using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200025B RID: 603
	[Serializable]
	public class DeleteSpecification : UpdateDeleteSpecificationBase
	{
		// Token: 0x06002CBA RID: 11450 RVA: 0x001CB491 File Offset: 0x001C9691
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002CBB RID: 11451 RVA: 0x001CB49D File Offset: 0x001C969D
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
