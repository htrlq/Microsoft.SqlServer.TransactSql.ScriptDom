using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001FF RID: 511
	[Serializable]
	public class IndexTableHint : TableHint
	{
		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06002A74 RID: 10868 RVA: 0x001C8A9F File Offset: 0x001C6C9F
		public IList<IdentifierOrValueExpression> IndexValues
		{
			get
			{
				return this._indexValues;
			}
		}

		// Token: 0x06002A75 RID: 10869 RVA: 0x001C8AA7 File Offset: 0x001C6CA7
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002A76 RID: 10870 RVA: 0x001C8AB4 File Offset: 0x001C6CB4
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			int i = 0;
			int count = this.IndexValues.Count;
			while (i < count)
			{
				this.IndexValues[i].Accept(visitor);
				i++;
			}
		}

		// Token: 0x04001D90 RID: 7568
		private List<IdentifierOrValueExpression> _indexValues = new List<IdentifierOrValueExpression>();
	}
}
