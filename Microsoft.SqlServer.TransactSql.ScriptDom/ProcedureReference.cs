using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001E0 RID: 480
	[Serializable]
	public class ProcedureReference : TSqlFragment
	{
		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060029D0 RID: 10704 RVA: 0x001C7F25 File Offset: 0x001C6125
		// (set) Token: 0x060029D1 RID: 10705 RVA: 0x001C7F2D File Offset: 0x001C612D
		public SchemaObjectName Name
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

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060029D2 RID: 10706 RVA: 0x001C7F3D File Offset: 0x001C613D
		// (set) Token: 0x060029D3 RID: 10707 RVA: 0x001C7F45 File Offset: 0x001C6145
		public Literal Number
		{
			get
			{
				return this._number;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._number = value;
			}
		}

		// Token: 0x060029D4 RID: 10708 RVA: 0x001C7F55 File Offset: 0x001C6155
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060029D5 RID: 10709 RVA: 0x001C7F61 File Offset: 0x001C6161
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			if (this.Number != null)
			{
				this.Number.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001D63 RID: 7523
		private SchemaObjectName _name;

		// Token: 0x04001D64 RID: 7524
		private Literal _number;
	}
}
