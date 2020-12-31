using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001CE RID: 462
	[Serializable]
	public class ExecutableProcedureReference : ExecutableEntity
	{
		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06002965 RID: 10597 RVA: 0x001C76DA File Offset: 0x001C58DA
		// (set) Token: 0x06002966 RID: 10598 RVA: 0x001C76E2 File Offset: 0x001C58E2
		public ProcedureReferenceName ProcedureReference
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

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06002967 RID: 10599 RVA: 0x001C76F2 File Offset: 0x001C58F2
		// (set) Token: 0x06002968 RID: 10600 RVA: 0x001C76FA File Offset: 0x001C58FA
		public AdHocDataSource AdHocDataSource
		{
			get
			{
				return this._adHocDataSource;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._adHocDataSource = value;
			}
		}

		// Token: 0x06002969 RID: 10601 RVA: 0x001C770A File Offset: 0x001C590A
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600296A RID: 10602 RVA: 0x001C7716 File Offset: 0x001C5916
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.ProcedureReference != null)
			{
				this.ProcedureReference.Accept(visitor);
			}
			if (this.AdHocDataSource != null)
			{
				this.AdHocDataSource.Accept(visitor);
			}
		}

		// Token: 0x04001D43 RID: 7491
		private ProcedureReferenceName _procedureReference;

		// Token: 0x04001D44 RID: 7492
		private AdHocDataSource _adHocDataSource;
	}
}
