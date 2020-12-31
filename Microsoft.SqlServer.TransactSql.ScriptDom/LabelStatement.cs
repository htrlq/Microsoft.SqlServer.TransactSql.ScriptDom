using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000254 RID: 596
	[Serializable]
	public class LabelStatement : TSqlStatement
	{
		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06002C90 RID: 11408 RVA: 0x001CB220 File Offset: 0x001C9420
		// (set) Token: 0x06002C91 RID: 11409 RVA: 0x001CB228 File Offset: 0x001C9428
		public string Value
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

		// Token: 0x06002C92 RID: 11410 RVA: 0x001CB231 File Offset: 0x001C9431
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002C93 RID: 11411 RVA: 0x001CB23D File Offset: 0x001C943D
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E30 RID: 7728
		private string _value;
	}
}
