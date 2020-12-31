using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200031B RID: 795
	[Serializable]
	public abstract class DropChildObjectsStatement : TSqlStatement
	{
		// Token: 0x1700034F RID: 847
		// (get) Token: 0x0600312A RID: 12586 RVA: 0x001D00AD File Offset: 0x001CE2AD
		public IList<ChildObjectName> Objects
		{
			get
			{
				return this._objects;
			}
		}

		// Token: 0x0600312B RID: 12587 RVA: 0x001D00B8 File Offset: 0x001CE2B8
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.Objects.Count;
			while (i < count)
			{
				this.Objects[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F7D RID: 8061
		private List<ChildObjectName> _objects = new List<ChildObjectName>();
	}
}
