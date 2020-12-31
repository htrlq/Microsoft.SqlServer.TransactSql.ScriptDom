using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002D1 RID: 721
	[Serializable]
	public class PartitionSpecifier : TSqlFragment
	{
		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06002F6B RID: 12139 RVA: 0x001CE30F File Offset: 0x001CC50F
		// (set) Token: 0x06002F6C RID: 12140 RVA: 0x001CE317 File Offset: 0x001CC517
		public ScalarExpression Number
		{
			get
			{
				return this._number;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._number = value;
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06002F6D RID: 12141 RVA: 0x001CE327 File Offset: 0x001CC527
		// (set) Token: 0x06002F6E RID: 12142 RVA: 0x001CE32F File Offset: 0x001CC52F
		public bool All
		{
			get
			{
				return this._all;
			}
			set
			{
				this._all = value;
			}
		}

		// Token: 0x06002F6F RID: 12143 RVA: 0x001CE338 File Offset: 0x001CC538
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002F70 RID: 12144 RVA: 0x001CE344 File Offset: 0x001CC544
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Number != null)
			{
				this.Number.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001EFD RID: 7933
		private ScalarExpression _number;

		// Token: 0x04001EFE RID: 7934
		private bool _all;
	}
}
