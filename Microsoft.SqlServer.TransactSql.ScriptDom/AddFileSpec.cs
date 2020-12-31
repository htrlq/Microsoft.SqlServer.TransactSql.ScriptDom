using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200029D RID: 669
	[Serializable]
	public class AddFileSpec : TSqlFragment
	{
		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06002E3D RID: 11837 RVA: 0x001CCF1C File Offset: 0x001CB11C
		// (set) Token: 0x06002E3E RID: 11838 RVA: 0x001CCF24 File Offset: 0x001CB124
		public ScalarExpression File
		{
			get
			{
				return this._file;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._file = value;
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06002E3F RID: 11839 RVA: 0x001CCF34 File Offset: 0x001CB134
		// (set) Token: 0x06002E40 RID: 11840 RVA: 0x001CCF3C File Offset: 0x001CB13C
		public Literal FileName
		{
			get
			{
				return this._fileName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._fileName = value;
			}
		}

		// Token: 0x06002E41 RID: 11841 RVA: 0x001CCF4C File Offset: 0x001CB14C
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002E42 RID: 11842 RVA: 0x001CCF58 File Offset: 0x001CB158
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.File != null)
			{
				this.File.Accept(visitor);
			}
			if (this.FileName != null)
			{
				this.FileName.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001EA9 RID: 7849
		private ScalarExpression _file;

		// Token: 0x04001EAA RID: 7850
		private Literal _fileName;
	}
}
