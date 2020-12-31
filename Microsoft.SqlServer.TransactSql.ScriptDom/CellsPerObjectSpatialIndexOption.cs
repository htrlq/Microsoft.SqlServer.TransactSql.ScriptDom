using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004BF RID: 1215
	[Serializable]
	public class CellsPerObjectSpatialIndexOption : SpatialIndexOption
	{
		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06003B12 RID: 15122 RVA: 0x001D9EC0 File Offset: 0x001D80C0
		// (set) Token: 0x06003B13 RID: 15123 RVA: 0x001D9EC8 File Offset: 0x001D80C8
		public Literal Value
		{
			get
			{
				return this._value;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._value = value;
			}
		}

		// Token: 0x06003B14 RID: 15124 RVA: 0x001D9ED8 File Offset: 0x001D80D8
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003B15 RID: 15125 RVA: 0x001D9EE4 File Offset: 0x001D80E4
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Value != null)
			{
				this.Value.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002246 RID: 8774
		private Literal _value;
	}
}
