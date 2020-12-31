using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000472 RID: 1138
	[Serializable]
	public class AuditActionSpecification : AuditSpecificationDetail
	{
		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x0600396F RID: 14703 RVA: 0x001D85D8 File Offset: 0x001D67D8
		public IList<DatabaseAuditAction> Actions
		{
			get
			{
				return this._actions;
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06003970 RID: 14704 RVA: 0x001D85E0 File Offset: 0x001D67E0
		public IList<SecurityPrincipal> Principals
		{
			get
			{
				return this._principals;
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06003971 RID: 14705 RVA: 0x001D85E8 File Offset: 0x001D67E8
		// (set) Token: 0x06003972 RID: 14706 RVA: 0x001D85F0 File Offset: 0x001D67F0
		public SecurityTargetObject TargetObject
		{
			get
			{
				return this._targetObject;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._targetObject = value;
			}
		}

		// Token: 0x06003973 RID: 14707 RVA: 0x001D8600 File Offset: 0x001D6800
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003974 RID: 14708 RVA: 0x001D860C File Offset: 0x001D680C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.Actions.Count;
			while (i < count)
			{
				this.Actions[i].Accept(visitor);
				i++;
			}
			int j = 0;
			int count2 = this.Principals.Count;
			while (j < count2)
			{
				this.Principals[j].Accept(visitor);
				j++;
			}
			if (this.TargetObject != null)
			{
				this.TargetObject.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x040021DA RID: 8666
		private List<DatabaseAuditAction> _actions = new List<DatabaseAuditAction>();

		// Token: 0x040021DB RID: 8667
		private List<SecurityPrincipal> _principals = new List<SecurityPrincipal>();

		// Token: 0x040021DC RID: 8668
		private SecurityTargetObject _targetObject;
	}
}
