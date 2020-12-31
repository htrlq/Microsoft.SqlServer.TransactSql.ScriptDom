using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001C7 RID: 455
	[Serializable]
	public class ResultColumnDefinition : TSqlFragment
	{
		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06002934 RID: 10548 RVA: 0x001C7395 File Offset: 0x001C5595
		// (set) Token: 0x06002935 RID: 10549 RVA: 0x001C739D File Offset: 0x001C559D
		public ColumnDefinitionBase ColumnDefinition
		{
			get
			{
				return this._columnDefinition;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._columnDefinition = value;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06002936 RID: 10550 RVA: 0x001C73AD File Offset: 0x001C55AD
		// (set) Token: 0x06002937 RID: 10551 RVA: 0x001C73B5 File Offset: 0x001C55B5
		public NullableConstraintDefinition Nullable
		{
			get
			{
				return this._nullable;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._nullable = value;
			}
		}

		// Token: 0x06002938 RID: 10552 RVA: 0x001C73C5 File Offset: 0x001C55C5
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002939 RID: 10553 RVA: 0x001C73D1 File Offset: 0x001C55D1
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.ColumnDefinition != null)
			{
				this.ColumnDefinition.Accept(visitor);
			}
			if (this.Nullable != null)
			{
				this.Nullable.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001D34 RID: 7476
		private ColumnDefinitionBase _columnDefinition;

		// Token: 0x04001D35 RID: 7477
		private NullableConstraintDefinition _nullable;
	}
}
