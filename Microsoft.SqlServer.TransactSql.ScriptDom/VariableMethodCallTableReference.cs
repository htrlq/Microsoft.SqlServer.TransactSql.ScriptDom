using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200040B RID: 1035
	[Serializable]
	public class VariableMethodCallTableReference : TableReferenceWithAliasAndColumns
	{
		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06003731 RID: 14129 RVA: 0x001D63B2 File Offset: 0x001D45B2
		// (set) Token: 0x06003732 RID: 14130 RVA: 0x001D63BA File Offset: 0x001D45BA
		public VariableReference Variable
		{
			get
			{
				return this._variable;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._variable = value;
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06003733 RID: 14131 RVA: 0x001D63CA File Offset: 0x001D45CA
		// (set) Token: 0x06003734 RID: 14132 RVA: 0x001D63D2 File Offset: 0x001D45D2
		public Identifier MethodName
		{
			get
			{
				return this._methodName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._methodName = value;
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06003735 RID: 14133 RVA: 0x001D63E2 File Offset: 0x001D45E2
		public IList<ScalarExpression> Parameters
		{
			get
			{
				return this._parameters;
			}
		}

		// Token: 0x06003736 RID: 14134 RVA: 0x001D63EA File Offset: 0x001D45EA
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003737 RID: 14135 RVA: 0x001D63F8 File Offset: 0x001D45F8
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Variable != null)
			{
				this.Variable.Accept(visitor);
			}
			if (this.MethodName != null)
			{
				this.MethodName.Accept(visitor);
			}
			int i = 0;
			int count = this.Parameters.Count;
			while (i < count)
			{
				this.Parameters[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002147 RID: 8519
		private VariableReference _variable;

		// Token: 0x04002148 RID: 8520
		private Identifier _methodName;

		// Token: 0x04002149 RID: 8521
		private List<ScalarExpression> _parameters = new List<ScalarExpression>();
	}
}
