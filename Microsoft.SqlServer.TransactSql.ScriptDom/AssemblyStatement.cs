using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000297 RID: 663
	[Serializable]
	public abstract class AssemblyStatement : TSqlStatement
	{
		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06002E1C RID: 11804 RVA: 0x001CCC62 File Offset: 0x001CAE62
		// (set) Token: 0x06002E1D RID: 11805 RVA: 0x001CCC6A File Offset: 0x001CAE6A
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

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06002E1E RID: 11806 RVA: 0x001CCC7A File Offset: 0x001CAE7A
		public IList<ScalarExpression> Parameters
		{
			get
			{
				return this._parameters;
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06002E1F RID: 11807 RVA: 0x001CCC82 File Offset: 0x001CAE82
		public IList<AssemblyOption> Options
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x06002E20 RID: 11808 RVA: 0x001CCC8C File Offset: 0x001CAE8C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
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
			int j = 0;
			int count2 = this.Options.Count;
			while (j < count2)
			{
				this.Options[j].Accept(visitor);
				j++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E9F RID: 7839
		private Identifier _name;

		// Token: 0x04001EA0 RID: 7840
		private List<ScalarExpression> _parameters = new List<ScalarExpression>();

		// Token: 0x04001EA1 RID: 7841
		private List<AssemblyOption> _options = new List<AssemblyOption>();
	}
}
