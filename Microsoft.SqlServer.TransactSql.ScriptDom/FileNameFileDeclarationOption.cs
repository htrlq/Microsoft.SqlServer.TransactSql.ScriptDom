using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000348 RID: 840
	[Serializable]
	public class FileNameFileDeclarationOption : FileDeclarationOption
	{
		// Token: 0x1700038B RID: 907
		// (get) Token: 0x0600321C RID: 12828 RVA: 0x001D0EE9 File Offset: 0x001CF0E9
		// (set) Token: 0x0600321D RID: 12829 RVA: 0x001D0EF1 File Offset: 0x001CF0F1
		public Literal OSFileName
		{
			get
			{
				return this._oSFileName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._oSFileName = value;
			}
		}

		// Token: 0x0600321E RID: 12830 RVA: 0x001D0F01 File Offset: 0x001CF101
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600321F RID: 12831 RVA: 0x001D0F0D File Offset: 0x001CF10D
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.OSFileName != null)
			{
				this.OSFileName.Accept(visitor);
			}
		}

		// Token: 0x04001FB9 RID: 8121
		private Literal _oSFileName;
	}
}
