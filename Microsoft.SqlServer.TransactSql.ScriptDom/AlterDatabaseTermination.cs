using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000357 RID: 855
	[Serializable]
	public class AlterDatabaseTermination : TSqlFragment
	{
		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06003286 RID: 12934 RVA: 0x001D14F8 File Offset: 0x001CF6F8
		// (set) Token: 0x06003287 RID: 12935 RVA: 0x001D1500 File Offset: 0x001CF700
		public bool ImmediateRollback
		{
			get
			{
				return this._immediateRollback;
			}
			set
			{
				this._immediateRollback = value;
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06003288 RID: 12936 RVA: 0x001D1509 File Offset: 0x001CF709
		// (set) Token: 0x06003289 RID: 12937 RVA: 0x001D1511 File Offset: 0x001CF711
		public Literal RollbackAfter
		{
			get
			{
				return this._rollbackAfter;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._rollbackAfter = value;
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x0600328A RID: 12938 RVA: 0x001D1521 File Offset: 0x001CF721
		// (set) Token: 0x0600328B RID: 12939 RVA: 0x001D1529 File Offset: 0x001CF729
		public bool NoWait
		{
			get
			{
				return this._noWait;
			}
			set
			{
				this._noWait = value;
			}
		}

		// Token: 0x0600328C RID: 12940 RVA: 0x001D1532 File Offset: 0x001CF732
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600328D RID: 12941 RVA: 0x001D153E File Offset: 0x001CF73E
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.RollbackAfter != null)
			{
				this.RollbackAfter.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001FD9 RID: 8153
		private bool _immediateRollback;

		// Token: 0x04001FDA RID: 8154
		private Literal _rollbackAfter;

		// Token: 0x04001FDB RID: 8155
		private bool _noWait;
	}
}
