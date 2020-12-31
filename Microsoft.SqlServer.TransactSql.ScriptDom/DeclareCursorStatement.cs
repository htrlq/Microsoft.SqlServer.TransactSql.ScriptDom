using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000309 RID: 777
	[Serializable]
	public class DeclareCursorStatement : TSqlStatement
	{
		// Token: 0x17000330 RID: 816
		// (get) Token: 0x060030BB RID: 12475 RVA: 0x001CF9BF File Offset: 0x001CDBBF
		// (set) Token: 0x060030BC RID: 12476 RVA: 0x001CF9C7 File Offset: 0x001CDBC7
		public Identifier Name
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

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x060030BD RID: 12477 RVA: 0x001CF9D7 File Offset: 0x001CDBD7
		// (set) Token: 0x060030BE RID: 12478 RVA: 0x001CF9DF File Offset: 0x001CDBDF
		public CursorDefinition CursorDefinition
		{
			get
			{
				return this._cursorDefinition;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._cursorDefinition = value;
			}
		}

		// Token: 0x060030BF RID: 12479 RVA: 0x001CF9EF File Offset: 0x001CDBEF
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060030C0 RID: 12480 RVA: 0x001CF9FB File Offset: 0x001CDBFB
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			if (this.CursorDefinition != null)
			{
				this.CursorDefinition.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F5E RID: 8030
		private Identifier _name;

		// Token: 0x04001F5F RID: 8031
		private CursorDefinition _cursorDefinition;
	}
}
