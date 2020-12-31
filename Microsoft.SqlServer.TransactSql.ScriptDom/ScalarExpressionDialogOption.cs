using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000455 RID: 1109
	[Serializable]
	public class ScalarExpressionDialogOption : DialogOption
	{
		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x060038D9 RID: 14553 RVA: 0x001D7D0B File Offset: 0x001D5F0B
		// (set) Token: 0x060038DA RID: 14554 RVA: 0x001D7D13 File Offset: 0x001D5F13
		public ScalarExpression Value
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

		// Token: 0x060038DB RID: 14555 RVA: 0x001D7D23 File Offset: 0x001D5F23
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060038DC RID: 14556 RVA: 0x001D7D2F File Offset: 0x001D5F2F
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Value != null)
			{
				this.Value.Accept(visitor);
			}
		}

		// Token: 0x040021B5 RID: 8629
		private ScalarExpression _value;
	}
}
