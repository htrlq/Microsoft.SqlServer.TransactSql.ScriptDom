using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000267 RID: 615
	[Serializable]
	public abstract class SecurityStatement : TSqlStatement
	{
		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06002D15 RID: 11541 RVA: 0x001CBAD2 File Offset: 0x001C9CD2
		public IList<Permission> Permissions
		{
			get
			{
				return this._permissions;
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06002D16 RID: 11542 RVA: 0x001CBADA File Offset: 0x001C9CDA
		// (set) Token: 0x06002D17 RID: 11543 RVA: 0x001CBAE2 File Offset: 0x001C9CE2
		public SecurityTargetObject SecurityTargetObject
		{
			get
			{
				return this._securityTargetObject;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._securityTargetObject = value;
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06002D18 RID: 11544 RVA: 0x001CBAF2 File Offset: 0x001C9CF2
		public IList<SecurityPrincipal> Principals
		{
			get
			{
				return this._principals;
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06002D19 RID: 11545 RVA: 0x001CBAFA File Offset: 0x001C9CFA
		// (set) Token: 0x06002D1A RID: 11546 RVA: 0x001CBB02 File Offset: 0x001C9D02
		public Identifier AsClause
		{
			get
			{
				return this._asClause;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._asClause = value;
			}
		}

		// Token: 0x06002D1B RID: 11547 RVA: 0x001CBB14 File Offset: 0x001C9D14
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.Permissions.Count;
			while (i < count)
			{
				this.Permissions[i].Accept(visitor);
				i++;
			}
			if (this.SecurityTargetObject != null)
			{
				this.SecurityTargetObject.Accept(visitor);
			}
			int j = 0;
			int count2 = this.Principals.Count;
			while (j < count2)
			{
				this.Principals[j].Accept(visitor);
				j++;
			}
			if (this.AsClause != null)
			{
				this.AsClause.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E59 RID: 7769
		private List<Permission> _permissions = new List<Permission>();

		// Token: 0x04001E5A RID: 7770
		private SecurityTargetObject _securityTargetObject;

		// Token: 0x04001E5B RID: 7771
		private List<SecurityPrincipal> _principals = new List<SecurityPrincipal>();

		// Token: 0x04001E5C RID: 7772
		private Identifier _asClause;
	}
}
