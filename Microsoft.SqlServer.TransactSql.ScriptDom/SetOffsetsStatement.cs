using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200033B RID: 827
	[Serializable]
	public class SetOffsetsStatement : SetOnOffStatement
	{
		// Token: 0x17000374 RID: 884
		// (get) Token: 0x060031CD RID: 12749 RVA: 0x001D09E1 File Offset: 0x001CEBE1
		// (set) Token: 0x060031CE RID: 12750 RVA: 0x001D09E9 File Offset: 0x001CEBE9
		public SetOffsets Options
		{
			get
			{
				return this._options;
			}
			set
			{
				this._options = value;
			}
		}

		// Token: 0x060031CF RID: 12751 RVA: 0x001D09F2 File Offset: 0x001CEBF2
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060031D0 RID: 12752 RVA: 0x001D09FE File Offset: 0x001CEBFE
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001FA2 RID: 8098
		private SetOffsets _options;
	}
}
