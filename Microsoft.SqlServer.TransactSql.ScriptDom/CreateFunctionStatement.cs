using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200024E RID: 590
	[Serializable]
	public class CreateFunctionStatement : FunctionStatementBody
	{
		// Token: 0x06002C69 RID: 11369 RVA: 0x001CAE99 File Offset: 0x001C9099
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002C6A RID: 11370 RVA: 0x001CAEA8 File Offset: 0x001C90A8
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
