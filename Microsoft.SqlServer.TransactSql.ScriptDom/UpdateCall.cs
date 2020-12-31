using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000283 RID: 643
	[Serializable]
	public class UpdateCall : BooleanExpression
	{
		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06002DB7 RID: 11703 RVA: 0x001CC6B6 File Offset: 0x001CA8B6
		// (set) Token: 0x06002DB8 RID: 11704 RVA: 0x001CC6BE File Offset: 0x001CA8BE
		public Identifier Identifier
		{
			get
			{
				return this._identifier;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._identifier = value;
			}
		}

		// Token: 0x06002DB9 RID: 11705 RVA: 0x001CC6CE File Offset: 0x001CA8CE
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002DBA RID: 11706 RVA: 0x001CC6DA File Offset: 0x001CA8DA
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Identifier != null)
			{
				this.Identifier.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E88 RID: 7816
		private Identifier _identifier;
	}
}
