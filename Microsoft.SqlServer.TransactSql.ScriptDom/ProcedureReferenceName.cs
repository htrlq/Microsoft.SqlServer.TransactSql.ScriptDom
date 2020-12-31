using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001CD RID: 461
	[Serializable]
	public class ProcedureReferenceName : TSqlFragment
	{
		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600295E RID: 10590 RVA: 0x001C7665 File Offset: 0x001C5865
		// (set) Token: 0x0600295F RID: 10591 RVA: 0x001C766D File Offset: 0x001C586D
		public ProcedureReference ProcedureReference
		{
			get
			{
				return this._procedureReference;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._procedureReference = value;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06002960 RID: 10592 RVA: 0x001C767D File Offset: 0x001C587D
		// (set) Token: 0x06002961 RID: 10593 RVA: 0x001C7685 File Offset: 0x001C5885
		public VariableReference ProcedureVariable
		{
			get
			{
				return this._procedureVariable;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._procedureVariable = value;
			}
		}

		// Token: 0x06002962 RID: 10594 RVA: 0x001C7695 File Offset: 0x001C5895
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002963 RID: 10595 RVA: 0x001C76A1 File Offset: 0x001C58A1
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.ProcedureReference != null)
			{
				this.ProcedureReference.Accept(visitor);
			}
			if (this.ProcedureVariable != null)
			{
				this.ProcedureVariable.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001D41 RID: 7489
		private ProcedureReference _procedureReference;

		// Token: 0x04001D42 RID: 7490
		private VariableReference _procedureVariable;
	}
}
