using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200031F RID: 799
	[Serializable]
	public class DropIndexClause : DropIndexClauseBase
	{
		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06003138 RID: 12600 RVA: 0x001D01CB File Offset: 0x001CE3CB
		// (set) Token: 0x06003139 RID: 12601 RVA: 0x001D01D3 File Offset: 0x001CE3D3
		public Identifier Index
		{
			get
			{
				return this._index;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._index = value;
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x0600313A RID: 12602 RVA: 0x001D01E3 File Offset: 0x001CE3E3
		// (set) Token: 0x0600313B RID: 12603 RVA: 0x001D01EB File Offset: 0x001CE3EB
		public SchemaObjectName Object
		{
			get
			{
				return this._object;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._object = value;
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x0600313C RID: 12604 RVA: 0x001D01FB File Offset: 0x001CE3FB
		public IList<IndexOption> Options
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x0600313D RID: 12605 RVA: 0x001D0203 File Offset: 0x001CE403
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600313E RID: 12606 RVA: 0x001D0210 File Offset: 0x001CE410
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Index != null)
			{
				this.Index.Accept(visitor);
			}
			if (this.Object != null)
			{
				this.Object.Accept(visitor);
			}
			int i = 0;
			int count = this.Options.Count;
			while (i < count)
			{
				this.Options[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F80 RID: 8064
		private Identifier _index;

		// Token: 0x04001F81 RID: 8065
		private SchemaObjectName _object;

		// Token: 0x04001F82 RID: 8066
		private List<IndexOption> _options = new List<IndexOption>();
	}
}
