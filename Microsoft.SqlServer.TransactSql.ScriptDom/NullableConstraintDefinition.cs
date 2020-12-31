using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200037D RID: 893
	[Serializable]
	public class NullableConstraintDefinition : ConstraintDefinition
	{
		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06003395 RID: 13205 RVA: 0x001D24C2 File Offset: 0x001D06C2
		// (set) Token: 0x06003396 RID: 13206 RVA: 0x001D24CA File Offset: 0x001D06CA
		public bool Nullable
		{
			get
			{
				return this._nullable;
			}
			set
			{
				this._nullable = value;
			}
		}

		// Token: 0x06003397 RID: 13207 RVA: 0x001D24D3 File Offset: 0x001D06D3
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003398 RID: 13208 RVA: 0x001D24DF File Offset: 0x001D06DF
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400202C RID: 8236
		private bool _nullable;
	}
}
