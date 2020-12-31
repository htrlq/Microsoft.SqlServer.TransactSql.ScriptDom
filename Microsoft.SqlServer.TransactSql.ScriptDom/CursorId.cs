using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200030D RID: 781
	[Serializable]
	public class CursorId : TSqlFragment
	{
		// Token: 0x1700033D RID: 829
		// (get) Token: 0x060030DF RID: 12511 RVA: 0x001CFC3D File Offset: 0x001CDE3D
		// (set) Token: 0x060030E0 RID: 12512 RVA: 0x001CFC45 File Offset: 0x001CDE45
		public bool IsGlobal
		{
			get
			{
				return this._isGlobal;
			}
			set
			{
				this._isGlobal = value;
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x060030E1 RID: 12513 RVA: 0x001CFC4E File Offset: 0x001CDE4E
		// (set) Token: 0x060030E2 RID: 12514 RVA: 0x001CFC56 File Offset: 0x001CDE56
		public IdentifierOrValueExpression Name
		{
			get
			{
				return this._name;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._name = value;
			}
		}

		// Token: 0x060030E3 RID: 12515 RVA: 0x001CFC66 File Offset: 0x001CDE66
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060030E4 RID: 12516 RVA: 0x001CFC72 File Offset: 0x001CDE72
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F6B RID: 8043
		private bool _isGlobal;

		// Token: 0x04001F6C RID: 8044
		private IdentifierOrValueExpression _name;
	}
}
