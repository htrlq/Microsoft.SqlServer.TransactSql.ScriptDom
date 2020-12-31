using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200037A RID: 890
	[Serializable]
	public class CheckConstraintDefinition : ConstraintDefinition
	{
		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06003378 RID: 13176 RVA: 0x001D22DE File Offset: 0x001D04DE
		// (set) Token: 0x06003379 RID: 13177 RVA: 0x001D22E6 File Offset: 0x001D04E6
		public BooleanExpression CheckCondition
		{
			get
			{
				return this._checkCondition;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._checkCondition = value;
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x0600337A RID: 13178 RVA: 0x001D22F6 File Offset: 0x001D04F6
		// (set) Token: 0x0600337B RID: 13179 RVA: 0x001D22FE File Offset: 0x001D04FE
		public bool NotForReplication
		{
			get
			{
				return this._notForReplication;
			}
			set
			{
				this._notForReplication = value;
			}
		}

		// Token: 0x0600337C RID: 13180 RVA: 0x001D2307 File Offset: 0x001D0507
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600337D RID: 13181 RVA: 0x001D2313 File Offset: 0x001D0513
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.CheckCondition != null)
			{
				this.CheckCondition.Accept(visitor);
			}
		}

		// Token: 0x04002021 RID: 8225
		private BooleanExpression _checkCondition;

		// Token: 0x04002022 RID: 8226
		private bool _notForReplication;
	}
}
