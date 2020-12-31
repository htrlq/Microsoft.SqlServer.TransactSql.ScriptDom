using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200026A RID: 618
	[Serializable]
	public class RevokeStatement : SecurityStatement
	{
		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06002D27 RID: 11559 RVA: 0x001CBD21 File Offset: 0x001C9F21
		// (set) Token: 0x06002D28 RID: 11560 RVA: 0x001CBD29 File Offset: 0x001C9F29
		public bool GrantOptionFor
		{
			get
			{
				return this._grantOptionFor;
			}
			set
			{
				this._grantOptionFor = value;
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06002D29 RID: 11561 RVA: 0x001CBD32 File Offset: 0x001C9F32
		// (set) Token: 0x06002D2A RID: 11562 RVA: 0x001CBD3A File Offset: 0x001C9F3A
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

		// Token: 0x06002D2B RID: 11563 RVA: 0x001CBD43 File Offset: 0x001C9F43
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002D2C RID: 11564 RVA: 0x001CBD50 File Offset: 0x001C9F50
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

		// Token: 0x04001E5F RID: 7775
		private bool _grantOptionFor;

		// Token: 0x04001E60 RID: 7776
		private bool _cascadeOption;
	}
}
