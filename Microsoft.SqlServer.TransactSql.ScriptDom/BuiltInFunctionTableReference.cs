using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003DC RID: 988
	[Serializable]
	public class BuiltInFunctionTableReference : TableReferenceWithAlias
	{
		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x060035FB RID: 13819 RVA: 0x001D4E00 File Offset: 0x001D3000
		// (set) Token: 0x060035FC RID: 13820 RVA: 0x001D4E08 File Offset: 0x001D3008
		public Identifier Name
		{
			get
			{
				return this._name;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._name = value;
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x060035FD RID: 13821 RVA: 0x001D4E18 File Offset: 0x001D3018
		public IList<ScalarExpression> Parameters
		{
			get
			{
				return this._parameters;
			}
		}

		// Token: 0x060035FE RID: 13822 RVA: 0x001D4E20 File Offset: 0x001D3020
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060035FF RID: 13823 RVA: 0x001D4E2C File Offset: 0x001D302C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			int i = 0;
			int count = this.Parameters.Count;
			while (i < count)
			{
				this.Parameters[i].Accept(visitor);
				i++;
			}
		}

		// Token: 0x040020E7 RID: 8423
		private Identifier _name;

		// Token: 0x040020E8 RID: 8424
		private List<ScalarExpression> _parameters = new List<ScalarExpression>();
	}
}
