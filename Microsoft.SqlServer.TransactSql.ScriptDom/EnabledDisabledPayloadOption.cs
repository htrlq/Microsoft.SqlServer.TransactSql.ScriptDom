using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003BF RID: 959
	[Serializable]
	public class EnabledDisabledPayloadOption : PayloadOption
	{
		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06003551 RID: 13649 RVA: 0x001D438C File Offset: 0x001D258C
		// (set) Token: 0x06003552 RID: 13650 RVA: 0x001D4394 File Offset: 0x001D2594
		public bool IsEnabled
		{
			get
			{
				return this._isEnabled;
			}
			set
			{
				this._isEnabled = value;
			}
		}

		// Token: 0x06003553 RID: 13651 RVA: 0x001D439D File Offset: 0x001D259D
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003554 RID: 13652 RVA: 0x001D43A9 File Offset: 0x001D25A9
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x040020B9 RID: 8377
		private bool _isEnabled;
	}
}
