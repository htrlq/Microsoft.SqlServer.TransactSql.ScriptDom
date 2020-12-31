using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001DE RID: 478
	[Serializable]
	public class AlterProcedureStatement : ProcedureStatementBody
	{
		// Token: 0x060029CA RID: 10698 RVA: 0x001C7DBD File Offset: 0x001C5FBD
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060029CB RID: 10699 RVA: 0x001C7DCC File Offset: 0x001C5FCC
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (base.ProcedureReference != null)
			{
				base.ProcedureReference.Accept(visitor);
			}
			int i = 0;
			int count = base.Parameters.Count;
			while (i < count)
			{
				base.Parameters[i].Accept(visitor);
				i++;
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
		}
	}
}
