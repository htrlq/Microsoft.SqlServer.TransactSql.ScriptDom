using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004DB RID: 1243
	[Serializable]
	public class AlterAvailabilityGroupFailoverOption : TSqlFragment
	{
		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06003BA2 RID: 15266 RVA: 0x001DA7A9 File Offset: 0x001D89A9
		// (set) Token: 0x06003BA3 RID: 15267 RVA: 0x001DA7B1 File Offset: 0x001D89B1
		public FailoverActionOptionKind OptionKind
		{
			get
			{
				return this._optionKind;
			}
			set
			{
				this._optionKind = value;
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06003BA4 RID: 15268 RVA: 0x001DA7BA File Offset: 0x001D89BA
		// (set) Token: 0x06003BA5 RID: 15269 RVA: 0x001DA7C2 File Offset: 0x001D89C2
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

		// Token: 0x06003BA6 RID: 15270 RVA: 0x001DA7D2 File Offset: 0x001D89D2
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003BA7 RID: 15271 RVA: 0x001DA7DE File Offset: 0x001D89DE
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Value != null)
			{
				this.Value.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400226B RID: 8811
		private FailoverActionOptionKind _optionKind;

		// Token: 0x0400226C RID: 8812
		private Literal _value;
	}
}
