using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000416 RID: 1046
	[Serializable]
	public class DropTypeStatement : TSqlStatement
	{
		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x0600375B RID: 14171 RVA: 0x001D65D0 File Offset: 0x001D47D0
		// (set) Token: 0x0600375C RID: 14172 RVA: 0x001D65D8 File Offset: 0x001D47D8
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

		// Token: 0x0600375D RID: 14173 RVA: 0x001D65E8 File Offset: 0x001D47E8
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600375E RID: 14174 RVA: 0x001D65F4 File Offset: 0x001D47F4
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400214C RID: 8524
		private SchemaObjectName _name;
	}
}
