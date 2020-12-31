using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004AC RID: 1196
	[Serializable]
	public class SourceDeclaration : ScalarExpression
	{
		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06003AA1 RID: 15009 RVA: 0x001D97E3 File Offset: 0x001D79E3
		// (set) Token: 0x06003AA2 RID: 15010 RVA: 0x001D97EB File Offset: 0x001D79EB
		public EventSessionObjectName Value
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

		// Token: 0x06003AA3 RID: 15011 RVA: 0x001D97FB File Offset: 0x001D79FB
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003AA4 RID: 15012 RVA: 0x001D9807 File Offset: 0x001D7A07
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Value != null)
			{
				this.Value.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002226 RID: 8742
		private EventSessionObjectName _value;
	}
}
