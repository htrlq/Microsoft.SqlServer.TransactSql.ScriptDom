using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000313 RID: 787
	[Serializable]
	public class CloseSymmetricKeyStatement : TSqlStatement
	{
		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06003100 RID: 12544 RVA: 0x001CFE09 File Offset: 0x001CE009
		// (set) Token: 0x06003101 RID: 12545 RVA: 0x001CFE11 File Offset: 0x001CE011
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

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06003102 RID: 12546 RVA: 0x001CFE21 File Offset: 0x001CE021
		// (set) Token: 0x06003103 RID: 12547 RVA: 0x001CFE29 File Offset: 0x001CE029
		public bool All
		{
			get
			{
				return this._all;
			}
			set
			{
				this._all = value;
			}
		}

		// Token: 0x06003104 RID: 12548 RVA: 0x001CFE32 File Offset: 0x001CE032
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003105 RID: 12549 RVA: 0x001CFE3E File Offset: 0x001CE03E
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F73 RID: 8051
		private Identifier _name;

		// Token: 0x04001F74 RID: 8052
		private bool _all;
	}
}
