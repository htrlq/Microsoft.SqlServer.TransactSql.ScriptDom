using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000341 RID: 833
	[Serializable]
	public class SetTextSizeStatement : TSqlStatement
	{
		// Token: 0x1700037A RID: 890
		// (get) Token: 0x060031E9 RID: 12777 RVA: 0x001D0B3B File Offset: 0x001CED3B
		// (set) Token: 0x060031EA RID: 12778 RVA: 0x001D0B43 File Offset: 0x001CED43
		public ScalarExpression TextSize
		{
			get
			{
				return this._textSize;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._textSize = value;
			}
		}

		// Token: 0x060031EB RID: 12779 RVA: 0x001D0B53 File Offset: 0x001CED53
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060031EC RID: 12780 RVA: 0x001D0B5F File Offset: 0x001CED5F
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.TextSize != null)
			{
				this.TextSize.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001FA8 RID: 8104
		private ScalarExpression _textSize;
	}
}
