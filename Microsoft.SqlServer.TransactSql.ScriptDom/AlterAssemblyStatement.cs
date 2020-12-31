using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000299 RID: 665
	[Serializable]
	public class AlterAssemblyStatement : AssemblyStatement
	{
		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06002E27 RID: 11815 RVA: 0x001CCDDD File Offset: 0x001CAFDD
		public IList<Literal> DropFiles
		{
			get
			{
				return this._dropFiles;
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06002E28 RID: 11816 RVA: 0x001CCDE5 File Offset: 0x001CAFE5
		// (set) Token: 0x06002E29 RID: 11817 RVA: 0x001CCDED File Offset: 0x001CAFED
		public bool IsDropAll
		{
			get
			{
				return this._isDropAll;
			}
			set
			{
				this._isDropAll = value;
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06002E2A RID: 11818 RVA: 0x001CCDF6 File Offset: 0x001CAFF6
		public IList<AddFileSpec> AddFiles
		{
			get
			{
				return this._addFiles;
			}
		}

		// Token: 0x06002E2B RID: 11819 RVA: 0x001CCDFE File Offset: 0x001CAFFE
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002E2C RID: 11820 RVA: 0x001CCE0C File Offset: 0x001CB00C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			int i = 0;
			int count = this.DropFiles.Count;
			while (i < count)
			{
				this.DropFiles[i].Accept(visitor);
				i++;
			}
			int j = 0;
			int count2 = this.AddFiles.Count;
			while (j < count2)
			{
				this.AddFiles[j].Accept(visitor);
				j++;
			}
		}

		// Token: 0x04001EA3 RID: 7843
		private List<Literal> _dropFiles = new List<Literal>();

		// Token: 0x04001EA4 RID: 7844
		private bool _isDropAll;

		// Token: 0x04001EA5 RID: 7845
		private List<AddFileSpec> _addFiles = new List<AddFileSpec>();
	}
}
