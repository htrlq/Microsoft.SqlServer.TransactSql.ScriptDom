using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000365 RID: 869
	[Serializable]
	public class WitnessDatabaseOption : DatabaseOption
	{
		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x060032D9 RID: 13017 RVA: 0x001D18CD File Offset: 0x001CFACD
		// (set) Token: 0x060032DA RID: 13018 RVA: 0x001D18D5 File Offset: 0x001CFAD5
		public Literal WitnessServer
		{
			get
			{
				return this._witnessServer;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._witnessServer = value;
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x060032DB RID: 13019 RVA: 0x001D18E5 File Offset: 0x001CFAE5
		// (set) Token: 0x060032DC RID: 13020 RVA: 0x001D18ED File Offset: 0x001CFAED
		public bool IsOff
		{
			get
			{
				return this._isOff;
			}
			set
			{
				this._isOff = value;
			}
		}

		// Token: 0x060032DD RID: 13021 RVA: 0x001D18F6 File Offset: 0x001CFAF6
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060032DE RID: 13022 RVA: 0x001D1902 File Offset: 0x001CFB02
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.WitnessServer != null)
			{
				this.WitnessServer.Accept(visitor);
			}
		}

		// Token: 0x04001FEE RID: 8174
		private Literal _witnessServer;

		// Token: 0x04001FEF RID: 8175
		private bool _isOff;
	}
}
