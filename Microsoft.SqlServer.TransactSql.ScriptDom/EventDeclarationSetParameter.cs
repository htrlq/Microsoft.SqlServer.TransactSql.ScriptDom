using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004AB RID: 1195
	[Serializable]
	public class EventDeclarationSetParameter : TSqlFragment
	{
		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06003A9A RID: 15002 RVA: 0x001D976E File Offset: 0x001D796E
		// (set) Token: 0x06003A9B RID: 15003 RVA: 0x001D9776 File Offset: 0x001D7976
		public Identifier EventField
		{
			get
			{
				return this._eventField;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._eventField = value;
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06003A9C RID: 15004 RVA: 0x001D9786 File Offset: 0x001D7986
		// (set) Token: 0x06003A9D RID: 15005 RVA: 0x001D978E File Offset: 0x001D798E
		public ScalarExpression EventValue
		{
			get
			{
				return this._eventValue;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._eventValue = value;
			}
		}

		// Token: 0x06003A9E RID: 15006 RVA: 0x001D979E File Offset: 0x001D799E
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003A9F RID: 15007 RVA: 0x001D97AA File Offset: 0x001D79AA
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.EventField != null)
			{
				this.EventField.Accept(visitor);
			}
			if (this.EventValue != null)
			{
				this.EventValue.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002224 RID: 8740
		private Identifier _eventField;

		// Token: 0x04002225 RID: 8741
		private ScalarExpression _eventValue;
	}
}
