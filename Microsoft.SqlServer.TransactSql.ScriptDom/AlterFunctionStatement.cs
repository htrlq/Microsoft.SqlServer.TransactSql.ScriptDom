using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200023E RID: 574
	[Serializable]
	public class AlterFunctionStatement : FunctionStatementBody
	{
		// Token: 0x06002C1E RID: 11294 RVA: 0x001CAA2F File Offset: 0x001C8C2F
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002C1F RID: 11295 RVA: 0x001CAA3C File Offset: 0x001C8C3C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (base.Name != null)
			{
				base.Name.Accept(visitor);
			}
			int i = 0;
			int count = base.Parameters.Count;
			while (i < count)
			{
				base.Parameters[i].Accept(visitor);
				i++;
			}
			if (base.ReturnType != null)
			{
				base.ReturnType.Accept(visitor);
			}
			int j = 0;
			int count2 = base.Options.Count;
			while (j < count2)
			{
				base.Options[j].Accept(visitor);
				j++;
			}
			if (base.StatementList != null)
			{
				base.StatementList.Accept(visitor);
			}
			if (base.MethodSpecifier != null)
			{
				base.MethodSpecifier.Accept(visitor);
			}
			if (base.OrderHint != null)
			{
				base.OrderHint.Accept(visitor);
			}
		}
	}
}
