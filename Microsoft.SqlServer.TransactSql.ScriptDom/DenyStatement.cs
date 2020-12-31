using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000269 RID: 617
	[Serializable]
	public class DenyStatement : SecurityStatement
	{
		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06002D22 RID: 11554 RVA: 0x001CBC71 File Offset: 0x001C9E71
		// (set) Token: 0x06002D23 RID: 11555 RVA: 0x001CBC79 File Offset: 0x001C9E79
		public bool CascadeOption
		{
			get
			{
				return this._cascadeOption;
			}
			set
			{
				this._cascadeOption = value;
			}
		}

		// Token: 0x06002D24 RID: 11556 RVA: 0x001CBC82 File Offset: 0x001C9E82
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002D25 RID: 11557 RVA: 0x001CBC90 File Offset: 0x001C9E90
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = base.Permissions.Count;
			while (i < count)
			{
				base.Permissions[i].Accept(visitor);
				i++;
			}
			if (base.SecurityTargetObject != null)
			{
				base.SecurityTargetObject.Accept(visitor);
			}
			int j = 0;
			int count2 = base.Principals.Count;
			while (j < count2)
			{
				base.Principals[j].Accept(visitor);
				j++;
			}
			if (base.AsClause != null)
			{
				base.AsClause.Accept(visitor);
			}
		}

		// Token: 0x04001E5E RID: 7774
		private bool _cascadeOption;
	}
}
