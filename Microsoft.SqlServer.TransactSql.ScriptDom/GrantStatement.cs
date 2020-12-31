using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000268 RID: 616
	[Serializable]
	public class GrantStatement : SecurityStatement
	{
		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06002D1D RID: 11549 RVA: 0x001CBBC2 File Offset: 0x001C9DC2
		// (set) Token: 0x06002D1E RID: 11550 RVA: 0x001CBBCA File Offset: 0x001C9DCA
		public bool WithGrantOption
		{
			get
			{
				return this._withGrantOption;
			}
			set
			{
				this._withGrantOption = value;
			}
		}

		// Token: 0x06002D1F RID: 11551 RVA: 0x001CBBD3 File Offset: 0x001C9DD3
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002D20 RID: 11552 RVA: 0x001CBBE0 File Offset: 0x001C9DE0
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

		// Token: 0x04001E5D RID: 7773
		private bool _withGrantOption;
	}
}
