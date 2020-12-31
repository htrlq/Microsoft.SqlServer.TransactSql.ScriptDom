using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004B3 RID: 1203
	[Serializable]
	public class MaxDispatchLatencySessionOption : SessionOption
	{
		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06003ACA RID: 15050 RVA: 0x001D9A41 File Offset: 0x001D7C41
		// (set) Token: 0x06003ACB RID: 15051 RVA: 0x001D9A49 File Offset: 0x001D7C49
		public bool IsInfinite
		{
			get
			{
				return this._isInfinite;
			}
			set
			{
				this._isInfinite = value;
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06003ACC RID: 15052 RVA: 0x001D9A52 File Offset: 0x001D7C52
		// (set) Token: 0x06003ACD RID: 15053 RVA: 0x001D9A5A File Offset: 0x001D7C5A
		public Literal Value
		{
			get
			{
				return this._value;
			}
			set
			{
				this._value = value;
			}
		}

		// Token: 0x06003ACE RID: 15054 RVA: 0x001D9A63 File Offset: 0x001D7C63
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003ACF RID: 15055 RVA: 0x001D9A6F File Offset: 0x001D7C6F
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002231 RID: 8753
		private bool _isInfinite;

		// Token: 0x04002232 RID: 8754
		private Literal _value;
	}
}
