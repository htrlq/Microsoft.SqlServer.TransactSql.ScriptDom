using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200026B RID: 619
	[Serializable]
	public class AlterAuthorizationStatement : TSqlStatement
	{
		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06002D2E RID: 11566 RVA: 0x001CBDE1 File Offset: 0x001C9FE1
		// (set) Token: 0x06002D2F RID: 11567 RVA: 0x001CBDE9 File Offset: 0x001C9FE9
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

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06002D30 RID: 11568 RVA: 0x001CBDF9 File Offset: 0x001C9FF9
		// (set) Token: 0x06002D31 RID: 11569 RVA: 0x001CBE01 File Offset: 0x001CA001
		public bool ToSchemaOwner
		{
			get
			{
				return this._toSchemaOwner;
			}
			set
			{
				this._toSchemaOwner = value;
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06002D32 RID: 11570 RVA: 0x001CBE0A File Offset: 0x001CA00A
		// (set) Token: 0x06002D33 RID: 11571 RVA: 0x001CBE12 File Offset: 0x001CA012
		public Identifier PrincipalName
		{
			get
			{
				return this._principalName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._principalName = value;
			}
		}

		// Token: 0x06002D34 RID: 11572 RVA: 0x001CBE22 File Offset: 0x001CA022
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002D35 RID: 11573 RVA: 0x001CBE2E File Offset: 0x001CA02E
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.SecurityTargetObject != null)
			{
				this.SecurityTargetObject.Accept(visitor);
			}
			if (this.PrincipalName != null)
			{
				this.PrincipalName.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E61 RID: 7777
		private SecurityTargetObject _securityTargetObject;

		// Token: 0x04001E62 RID: 7778
		private bool _toSchemaOwner;

		// Token: 0x04001E63 RID: 7779
		private Identifier _principalName;
	}
}
