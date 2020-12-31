using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000356 RID: 854
	[Serializable]
	public class AlterDatabaseModifyFileGroupStatement : AlterDatabaseStatement
	{
		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06003279 RID: 12921 RVA: 0x001D1428 File Offset: 0x001CF628
		// (set) Token: 0x0600327A RID: 12922 RVA: 0x001D1430 File Offset: 0x001CF630
		public Identifier FileGroup
		{
			get
			{
				return this._fileGroup;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._fileGroup = value;
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x0600327B RID: 12923 RVA: 0x001D1440 File Offset: 0x001CF640
		// (set) Token: 0x0600327C RID: 12924 RVA: 0x001D1448 File Offset: 0x001CF648
		public Identifier NewFileGroupName
		{
			get
			{
				return this._newFileGroupName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._newFileGroupName = value;
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x0600327D RID: 12925 RVA: 0x001D1458 File Offset: 0x001CF658
		// (set) Token: 0x0600327E RID: 12926 RVA: 0x001D1460 File Offset: 0x001CF660
		public bool MakeDefault
		{
			get
			{
				return this._makeDefault;
			}
			set
			{
				this._makeDefault = value;
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x0600327F RID: 12927 RVA: 0x001D1469 File Offset: 0x001CF669
		// (set) Token: 0x06003280 RID: 12928 RVA: 0x001D1471 File Offset: 0x001CF671
		public ModifyFileGroupOption UpdatabilityOption
		{
			get
			{
				return this._updatabilityOption;
			}
			set
			{
				this._updatabilityOption = value;
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06003281 RID: 12929 RVA: 0x001D147A File Offset: 0x001CF67A
		// (set) Token: 0x06003282 RID: 12930 RVA: 0x001D1482 File Offset: 0x001CF682
		public AlterDatabaseTermination Termination
		{
			get
			{
				return this._termination;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._termination = value;
			}
		}

		// Token: 0x06003283 RID: 12931 RVA: 0x001D1492 File Offset: 0x001CF692
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003284 RID: 12932 RVA: 0x001D14A0 File Offset: 0x001CF6A0
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.FileGroup != null)
			{
				this.FileGroup.Accept(visitor);
			}
			if (this.NewFileGroupName != null)
			{
				this.NewFileGroupName.Accept(visitor);
			}
			if (this.Termination != null)
			{
				this.Termination.Accept(visitor);
			}
		}

		// Token: 0x04001FD4 RID: 8148
		private Identifier _fileGroup;

		// Token: 0x04001FD5 RID: 8149
		private Identifier _newFileGroupName;

		// Token: 0x04001FD6 RID: 8150
		private bool _makeDefault;

		// Token: 0x04001FD7 RID: 8151
		private ModifyFileGroupOption _updatabilityOption;

		// Token: 0x04001FD8 RID: 8152
		private AlterDatabaseTermination _termination;
	}
}
