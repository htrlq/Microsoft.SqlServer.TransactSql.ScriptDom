using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200042B RID: 1067
	[Serializable]
	public class DropSearchPropertyListAction : SearchPropertyListAction
	{
		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x060037D2 RID: 14290 RVA: 0x001D6CA4 File Offset: 0x001D4EA4
		// (set) Token: 0x060037D3 RID: 14291 RVA: 0x001D6CAC File Offset: 0x001D4EAC
		public StringLiteral PropertyName
		{
			get
			{
				return this._propertyName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._propertyName = value;
			}
		}

		// Token: 0x060037D4 RID: 14292 RVA: 0x001D6CBC File Offset: 0x001D4EBC
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060037D5 RID: 14293 RVA: 0x001D6CC8 File Offset: 0x001D4EC8
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.PropertyName != null)
			{
				this.PropertyName.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400216A RID: 8554
		private StringLiteral _propertyName;
	}
}
