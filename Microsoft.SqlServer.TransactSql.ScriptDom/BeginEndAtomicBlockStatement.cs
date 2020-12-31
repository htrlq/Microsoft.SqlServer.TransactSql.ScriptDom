using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000240 RID: 576
	[Serializable]
	public class BeginEndAtomicBlockStatement : BeginEndBlockStatement
	{
		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06002C26 RID: 11302 RVA: 0x001CAB52 File Offset: 0x001C8D52
		public IList<AtomicBlockOption> Options
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x06002C27 RID: 11303 RVA: 0x001CAB5A File Offset: 0x001C8D5A
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002C28 RID: 11304 RVA: 0x001CAB68 File Offset: 0x001C8D68
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			int i = 0;
			int count = this.Options.Count;
			while (i < count)
			{
				this.Options[i].Accept(visitor);
				i++;
			}
		}

		// Token: 0x04001E17 RID: 7703
		private List<AtomicBlockOption> _options = new List<AtomicBlockOption>();
	}
}
