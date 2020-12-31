using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020002C7 RID: 711
	[Serializable]
	public class RouteOption : TSqlFragment
	{
		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06002F31 RID: 12081 RVA: 0x001CDE3D File Offset: 0x001CC03D
		// (set) Token: 0x06002F32 RID: 12082 RVA: 0x001CDE45 File Offset: 0x001CC045
		public RouteOptionKind OptionKind
		{
			get
			{
				return this._optionKind;
			}
			set
			{
				this._optionKind = value;
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06002F33 RID: 12083 RVA: 0x001CDE4E File Offset: 0x001CC04E
		// (set) Token: 0x06002F34 RID: 12084 RVA: 0x001CDE56 File Offset: 0x001CC056
		public Literal Literal
		{
			get
			{
				return this._literal;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._literal = value;
			}
		}

		// Token: 0x06002F35 RID: 12085 RVA: 0x001CDE66 File Offset: 0x001CC066
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002F36 RID: 12086 RVA: 0x001CDE72 File Offset: 0x001CC072
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Literal != null)
			{
				this.Literal.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001EEB RID: 7915
		private RouteOptionKind _optionKind;

		// Token: 0x04001EEC RID: 7916
		private Literal _literal;
	}
}
