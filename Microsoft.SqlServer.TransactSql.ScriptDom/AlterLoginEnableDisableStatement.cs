using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200043A RID: 1082
	[Serializable]
	public class AlterLoginEnableDisableStatement : AlterLoginStatement
	{
		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06003828 RID: 14376 RVA: 0x001D71CD File Offset: 0x001D53CD
		// (set) Token: 0x06003829 RID: 14377 RVA: 0x001D71D5 File Offset: 0x001D53D5
		public bool IsEnable
		{
			get
			{
				return this._isEnable;
			}
			set
			{
				this._isEnable = value;
			}
		}

		// Token: 0x0600382A RID: 14378 RVA: 0x001D71DE File Offset: 0x001D53DE
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600382B RID: 14379 RVA: 0x001D71EA File Offset: 0x001D53EA
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002181 RID: 8577
		private bool _isEnable;
	}
}
