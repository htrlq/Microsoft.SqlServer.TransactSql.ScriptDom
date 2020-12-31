using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001D5 RID: 469
	[Serializable]
	public class TriggerObject : TSqlFragment
	{
		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600298C RID: 10636 RVA: 0x001C7994 File Offset: 0x001C5B94
		// (set) Token: 0x0600298D RID: 10637 RVA: 0x001C799C File Offset: 0x001C5B9C
		public SchemaObjectName Name
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

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600298E RID: 10638 RVA: 0x001C79AC File Offset: 0x001C5BAC
		// (set) Token: 0x0600298F RID: 10639 RVA: 0x001C79B4 File Offset: 0x001C5BB4
		public TriggerScope TriggerScope
		{
			get
			{
				return this._triggerScope;
			}
			set
			{
				this._triggerScope = value;
			}
		}

		// Token: 0x06002990 RID: 10640 RVA: 0x001C79BD File Offset: 0x001C5BBD
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002991 RID: 10641 RVA: 0x001C79C9 File Offset: 0x001C5BC9
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001D4E RID: 7502
		private SchemaObjectName _name;

		// Token: 0x04001D4F RID: 7503
		private TriggerScope _triggerScope;
	}
}
