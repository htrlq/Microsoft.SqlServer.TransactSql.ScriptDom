using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000487 RID: 1159
	[Serializable]
	public class MaxRolloverFilesAuditTargetOption : AuditTargetOption
	{
		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x060039D3 RID: 14803 RVA: 0x001D8B36 File Offset: 0x001D6D36
		// (set) Token: 0x060039D4 RID: 14804 RVA: 0x001D8B3E File Offset: 0x001D6D3E
		public Literal Value
		{
			get
			{
				return this._value;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._value = value;
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x060039D5 RID: 14805 RVA: 0x001D8B4E File Offset: 0x001D6D4E
		// (set) Token: 0x060039D6 RID: 14806 RVA: 0x001D8B56 File Offset: 0x001D6D56
		public bool IsUnlimited
		{
			get
			{
				return this._isUnlimited;
			}
			set
			{
				this._isUnlimited = value;
			}
		}

		// Token: 0x060039D7 RID: 14807 RVA: 0x001D8B5F File Offset: 0x001D6D5F
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060039D8 RID: 14808 RVA: 0x001D8B6B File Offset: 0x001D6D6B
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Value != null)
			{
				this.Value.Accept(visitor);
			}
		}

		// Token: 0x040021F0 RID: 8688
		private Literal _value;

		// Token: 0x040021F1 RID: 8689
		private bool _isUnlimited;
	}
}
