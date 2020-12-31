using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003B7 RID: 951
	[Serializable]
	public class LiteralEndpointProtocolOption : EndpointProtocolOption
	{
		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06003514 RID: 13588 RVA: 0x001D401E File Offset: 0x001D221E
		// (set) Token: 0x06003515 RID: 13589 RVA: 0x001D4026 File Offset: 0x001D2226
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

		// Token: 0x06003516 RID: 13590 RVA: 0x001D4036 File Offset: 0x001D2236
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003517 RID: 13591 RVA: 0x001D4042 File Offset: 0x001D2242
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Value != null)
			{
				this.Value.Accept(visitor);
			}
		}

		// Token: 0x040020A6 RID: 8358
		private Literal _value;
	}
}
