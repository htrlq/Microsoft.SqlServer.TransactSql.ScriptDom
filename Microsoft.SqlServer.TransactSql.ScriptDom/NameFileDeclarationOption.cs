using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000347 RID: 839
	[Serializable]
	public class NameFileDeclarationOption : FileDeclarationOption
	{
		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06003215 RID: 12821 RVA: 0x001D0E8F File Offset: 0x001CF08F
		// (set) Token: 0x06003216 RID: 12822 RVA: 0x001D0E97 File Offset: 0x001CF097
		public IdentifierOrValueExpression LogicalFileName
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

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06003217 RID: 12823 RVA: 0x001D0EA7 File Offset: 0x001CF0A7
		// (set) Token: 0x06003218 RID: 12824 RVA: 0x001D0EAF File Offset: 0x001CF0AF
		public bool IsNewName
		{
			get
			{
				return this._isNewName;
			}
			set
			{
				this._isNewName = value;
			}
		}

		// Token: 0x06003219 RID: 12825 RVA: 0x001D0EB8 File Offset: 0x001CF0B8
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600321A RID: 12826 RVA: 0x001D0EC4 File Offset: 0x001CF0C4
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.LogicalFileName != null)
			{
				this.LogicalFileName.Accept(visitor);
			}
		}

		// Token: 0x04001FB7 RID: 8119
		private IdentifierOrValueExpression _logicalFileName;

		// Token: 0x04001FB8 RID: 8120
		private bool _isNewName;
	}
}
