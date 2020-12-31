using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001DF RID: 479
	[Serializable]
	public class CreateProcedureStatement : ProcedureStatementBody
	{
		// Token: 0x060029CD RID: 10701 RVA: 0x001C7E71 File Offset: 0x001C6071
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060029CE RID: 10702 RVA: 0x001C7E80 File Offset: 0x001C6080
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
