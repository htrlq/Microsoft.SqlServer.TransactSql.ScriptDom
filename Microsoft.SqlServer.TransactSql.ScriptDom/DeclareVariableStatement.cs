using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000251 RID: 593
	[Serializable]
	public class DeclareVariableStatement : TSqlStatement
	{
		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06002C7E RID: 11390 RVA: 0x001CB0C4 File Offset: 0x001C92C4
		public IList<DeclareVariableElement> Declarations
		{
			get
			{
				return this._declarations;
			}
		}

		// Token: 0x06002C7F RID: 11391 RVA: 0x001CB0CC File Offset: 0x001C92CC
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002C80 RID: 11392 RVA: 0x001CB0D8 File Offset: 0x001C92D8
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.Declarations.Count;
			while (i < count)
			{
				this.Declarations[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E2B RID: 7723
		private List<DeclareVariableElement> _declarations = new List<DeclareVariableElement>();
	}
}
