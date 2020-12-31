using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000385 RID: 901
	[Serializable]
	public class MoveRestoreOption : RestoreOption
	{
		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x060033CB RID: 13259 RVA: 0x001D2945 File Offset: 0x001D0B45
		// (set) Token: 0x060033CC RID: 13260 RVA: 0x001D294D File Offset: 0x001D0B4D
		public ValueExpression LogicalFileName
		{
			get
			{
				return this._logicalFileName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._logicalFileName = value;
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x060033CD RID: 13261 RVA: 0x001D295D File Offset: 0x001D0B5D
		// (set) Token: 0x060033CE RID: 13262 RVA: 0x001D2965 File Offset: 0x001D0B65
		public ValueExpression OSFileName
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

		// Token: 0x060033CF RID: 13263 RVA: 0x001D2975 File Offset: 0x001D0B75
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060033D0 RID: 13264 RVA: 0x001D2981 File Offset: 0x001D0B81
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.LogicalFileName != null)
			{
				this.LogicalFileName.Accept(visitor);
			}
			if (this.OSFileName != null)
			{
				this.OSFileName.Accept(visitor);
			}
		}

		// Token: 0x04002040 RID: 8256
		private ValueExpression _logicalFileName;

		// Token: 0x04002041 RID: 8257
		private ValueExpression _oSFileName;
	}
}
