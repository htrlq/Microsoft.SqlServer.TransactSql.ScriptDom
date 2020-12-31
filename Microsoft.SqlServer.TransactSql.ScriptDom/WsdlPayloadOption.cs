using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003C0 RID: 960
	[Serializable]
	public class WsdlPayloadOption : PayloadOption
	{
		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06003556 RID: 13654 RVA: 0x001D43BA File Offset: 0x001D25BA
		// (set) Token: 0x06003557 RID: 13655 RVA: 0x001D43C2 File Offset: 0x001D25C2
		public bool IsNone
		{
			get
			{
				return this._isNone;
			}
			set
			{
				this._isNone = value;
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06003558 RID: 13656 RVA: 0x001D43CB File Offset: 0x001D25CB
		// (set) Token: 0x06003559 RID: 13657 RVA: 0x001D43D3 File Offset: 0x001D25D3
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

		// Token: 0x0600355A RID: 13658 RVA: 0x001D43E3 File Offset: 0x001D25E3
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600355B RID: 13659 RVA: 0x001D43EF File Offset: 0x001D25EF
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Value != null)
			{
				this.Value.Accept(visitor);
			}
		}

		// Token: 0x040020BA RID: 8378
		private bool _isNone;

		// Token: 0x040020BB RID: 8379
		private Literal _value;
	}
}
