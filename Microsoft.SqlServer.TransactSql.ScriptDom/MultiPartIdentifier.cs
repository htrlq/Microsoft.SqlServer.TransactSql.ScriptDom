using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200007C RID: 124
	[Serializable]
	public class MultiPartIdentifier : TSqlFragment
	{
		// Token: 0x17000014 RID: 20
		public Identifier this[int index]
		{
			get
			{
				return this.Identifiers[index];
			}
			set
			{
				this.Identifiers[index] = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x00006FE5 File Offset: 0x000051E5
		public int Count
		{
			get
			{
				return this.Identifiers.Count;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x00006FF2 File Offset: 0x000051F2
		public IList<Identifier> Identifiers
		{
			get
			{
				return this._identifiers;
			}
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00006FFA File Offset: 0x000051FA
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00007008 File Offset: 0x00005208
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.Identifiers.Count;
			while (i < count)
			{
				this.Identifiers[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04000253 RID: 595
		private List<Identifier> _identifiers = new List<Identifier>();
	}
}
