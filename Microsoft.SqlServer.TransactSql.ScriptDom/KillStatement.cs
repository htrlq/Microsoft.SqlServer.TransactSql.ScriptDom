using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200032F RID: 815
	[Serializable]
	public class KillStatement : TSqlStatement
	{
		// Token: 0x17000365 RID: 869
		// (get) Token: 0x0600318C RID: 12684 RVA: 0x001D06D5 File Offset: 0x001CE8D5
		// (set) Token: 0x0600318D RID: 12685 RVA: 0x001D06DD File Offset: 0x001CE8DD
		public ScalarExpression Parameter
		{
			get
			{
				return this._parameter;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._parameter = value;
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x0600318E RID: 12686 RVA: 0x001D06ED File Offset: 0x001CE8ED
		// (set) Token: 0x0600318F RID: 12687 RVA: 0x001D06F5 File Offset: 0x001CE8F5
		public bool WithStatusOnly
		{
			get
			{
				return this._withStatusOnly;
			}
			set
			{
				this._withStatusOnly = value;
			}
		}

		// Token: 0x06003190 RID: 12688 RVA: 0x001D06FE File Offset: 0x001CE8FE
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003191 RID: 12689 RVA: 0x001D070A File Offset: 0x001CE90A
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Parameter != null)
			{
				this.Parameter.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F93 RID: 8083
		private ScalarExpression _parameter;

		// Token: 0x04001F94 RID: 8084
		private bool _withStatusOnly;
	}
}
