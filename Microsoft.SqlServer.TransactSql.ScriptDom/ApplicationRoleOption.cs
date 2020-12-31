using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002EE RID: 750
	[Serializable]
	public class ApplicationRoleOption : TSqlFragment
	{
		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06003038 RID: 12344 RVA: 0x001CF107 File Offset: 0x001CD307
		// (set) Token: 0x06003039 RID: 12345 RVA: 0x001CF10F File Offset: 0x001CD30F
		public ApplicationRoleOptionKind OptionKind
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

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x0600303A RID: 12346 RVA: 0x001CF118 File Offset: 0x001CD318
		// (set) Token: 0x0600303B RID: 12347 RVA: 0x001CF120 File Offset: 0x001CD320
		public IdentifierOrValueExpression Value
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

		// Token: 0x0600303C RID: 12348 RVA: 0x001CF130 File Offset: 0x001CD330
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600303D RID: 12349 RVA: 0x001CF13C File Offset: 0x001CD33C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Value != null)
			{
				this.Value.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F3F RID: 7999
		private ApplicationRoleOptionKind _optionKind;

		// Token: 0x04001F40 RID: 8000
		private IdentifierOrValueExpression _value;
	}
}
