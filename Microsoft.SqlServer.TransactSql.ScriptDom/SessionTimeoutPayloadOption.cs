using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003C3 RID: 963
	[Serializable]
	public class SessionTimeoutPayloadOption : PayloadOption
	{
		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06003567 RID: 13671 RVA: 0x001D448B File Offset: 0x001D268B
		// (set) Token: 0x06003568 RID: 13672 RVA: 0x001D4493 File Offset: 0x001D2693
		public bool IsNever
		{
			get
			{
				return this._isNever;
			}
			set
			{
				this._isNever = value;
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06003569 RID: 13673 RVA: 0x001D449C File Offset: 0x001D269C
		// (set) Token: 0x0600356A RID: 13674 RVA: 0x001D44A4 File Offset: 0x001D26A4
		public Literal Timeout
		{
			get
			{
				return this._timeout;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._timeout = value;
			}
		}

		// Token: 0x0600356B RID: 13675 RVA: 0x001D44B4 File Offset: 0x001D26B4
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600356C RID: 13676 RVA: 0x001D44C0 File Offset: 0x001D26C0
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Timeout != null)
			{
				this.Timeout.Accept(visitor);
			}
		}

		// Token: 0x040020BE RID: 8382
		private bool _isNever;

		// Token: 0x040020BF RID: 8383
		private Literal _timeout;
	}
}
