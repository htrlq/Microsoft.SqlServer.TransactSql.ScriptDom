using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004DA RID: 1242
	[Serializable]
	public class AlterAvailabilityGroupFailoverAction : AlterAvailabilityGroupAction
	{
		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06003B9E RID: 15262 RVA: 0x001DA741 File Offset: 0x001D8941
		public IList<AlterAvailabilityGroupFailoverOption> Options
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x06003B9F RID: 15263 RVA: 0x001DA749 File Offset: 0x001D8949
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003BA0 RID: 15264 RVA: 0x001DA758 File Offset: 0x001D8958
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

		// Token: 0x0400226A RID: 8810
		private List<AlterAvailabilityGroupFailoverOption> _options = new List<AlterAvailabilityGroupFailoverOption>();
	}
}
