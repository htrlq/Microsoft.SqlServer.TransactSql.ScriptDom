using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200042D RID: 1069
	[Serializable]
	public class CreateLoginStatement : TSqlStatement
	{
		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x060037DA RID: 14298 RVA: 0x001D6D0A File Offset: 0x001D4F0A
		// (set) Token: 0x060037DB RID: 14299 RVA: 0x001D6D12 File Offset: 0x001D4F12
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

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x060037DC RID: 14300 RVA: 0x001D6D22 File Offset: 0x001D4F22
		// (set) Token: 0x060037DD RID: 14301 RVA: 0x001D6D2A File Offset: 0x001D4F2A
		public CreateLoginSource Source
		{
			get
			{
				return this._source;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._source = value;
			}
		}

		// Token: 0x060037DE RID: 14302 RVA: 0x001D6D3A File Offset: 0x001D4F3A
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060037DF RID: 14303 RVA: 0x001D6D46 File Offset: 0x001D4F46
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			if (this.Source != null)
			{
				this.Source.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400216B RID: 8555
		private Identifier _name;

		// Token: 0x0400216C RID: 8556
		private CreateLoginSource _source;
	}
}
