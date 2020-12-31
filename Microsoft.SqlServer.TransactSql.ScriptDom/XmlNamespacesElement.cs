using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001E8 RID: 488
	[Serializable]
	public abstract class XmlNamespacesElement : TSqlFragment
	{
		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06002A01 RID: 10753 RVA: 0x001C8279 File Offset: 0x001C6479
		// (set) Token: 0x06002A02 RID: 10754 RVA: 0x001C8281 File Offset: 0x001C6481
		public StringLiteral String
		{
			get
			{
				return this._string;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._string = value;
			}
		}

		// Token: 0x06002A03 RID: 10755 RVA: 0x001C8291 File Offset: 0x001C6491
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.String != null)
			{
				this.String.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001D71 RID: 7537
		private StringLiteral _string;
	}
}
