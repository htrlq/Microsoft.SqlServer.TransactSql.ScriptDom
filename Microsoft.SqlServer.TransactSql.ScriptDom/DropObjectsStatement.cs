using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000295 RID: 661
	[Serializable]
	public abstract class DropObjectsStatement : TSqlStatement
	{
		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06002E16 RID: 11798 RVA: 0x001CCBEC File Offset: 0x001CADEC
		public IList<SchemaObjectName> Objects
		{
			get
			{
				return this._objects;
			}
		}

		// Token: 0x06002E17 RID: 11799 RVA: 0x001CCBF4 File Offset: 0x001CADF4
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

		// Token: 0x04001E9E RID: 7838
		private List<SchemaObjectName> _objects = new List<SchemaObjectName>();
	}
}
