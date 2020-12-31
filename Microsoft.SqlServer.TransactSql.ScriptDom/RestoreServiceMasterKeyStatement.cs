using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200045A RID: 1114
	[Serializable]
	public class RestoreServiceMasterKeyStatement : BackupRestoreMasterKeyStatementBase
	{
		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x060038F1 RID: 14577 RVA: 0x001D7E51 File Offset: 0x001D6051
		// (set) Token: 0x060038F2 RID: 14578 RVA: 0x001D7E59 File Offset: 0x001D6059
		public bool IsForce
		{
			get
			{
				return this._isForce;
			}
			set
			{
				this._isForce = value;
			}
		}

		// Token: 0x060038F3 RID: 14579 RVA: 0x001D7E62 File Offset: 0x001D6062
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060038F4 RID: 14580 RVA: 0x001D7E6E File Offset: 0x001D606E
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x040021BA RID: 8634
		private bool _isForce;
	}
}
