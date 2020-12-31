using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003DA RID: 986
	[Serializable]
	public class ServiceContract : TSqlFragment
	{
		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x060035EB RID: 13803 RVA: 0x001D4D20 File Offset: 0x001D2F20
		// (set) Token: 0x060035EC RID: 13804 RVA: 0x001D4D28 File Offset: 0x001D2F28
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

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x060035ED RID: 13805 RVA: 0x001D4D38 File Offset: 0x001D2F38
		// (set) Token: 0x060035EE RID: 13806 RVA: 0x001D4D40 File Offset: 0x001D2F40
		public AlterAction Action
		{
			get
			{
				return this._action;
			}
			set
			{
				this._action = value;
			}
		}

		// Token: 0x060035EF RID: 13807 RVA: 0x001D4D49 File Offset: 0x001D2F49
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060035F0 RID: 13808 RVA: 0x001D4D55 File Offset: 0x001D2F55
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x040020E2 RID: 8418
		private Identifier _name;

		// Token: 0x040020E3 RID: 8419
		private AlterAction _action;
	}
}
