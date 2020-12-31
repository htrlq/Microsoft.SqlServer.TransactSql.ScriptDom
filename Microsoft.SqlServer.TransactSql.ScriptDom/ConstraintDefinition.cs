using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000374 RID: 884
	[Serializable]
	public abstract class ConstraintDefinition : TSqlFragment
	{
		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06003349 RID: 13129 RVA: 0x001D1F7A File Offset: 0x001D017A
		// (set) Token: 0x0600334A RID: 13130 RVA: 0x001D1F82 File Offset: 0x001D0182
		public Identifier ConstraintIdentifier
		{
			get
			{
				return this._constraintIdentifier;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._constraintIdentifier = value;
			}
		}

		// Token: 0x0600334B RID: 13131 RVA: 0x001D1F92 File Offset: 0x001D0192
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.ConstraintIdentifier != null)
			{
				this.ConstraintIdentifier.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002011 RID: 8209
		private Identifier _constraintIdentifier;
	}
}
