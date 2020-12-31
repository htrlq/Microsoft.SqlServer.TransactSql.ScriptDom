using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000346 RID: 838
	[Serializable]
	public class FileDeclarationOption : TSqlFragment
	{
		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06003210 RID: 12816 RVA: 0x001D0E61 File Offset: 0x001CF061
		// (set) Token: 0x06003211 RID: 12817 RVA: 0x001D0E69 File Offset: 0x001CF069
		public FileDeclarationOptionKind OptionKind
		{
			get
			{
				return this._optionKind;
			}
			set
			{
				this._optionKind = value;
			}
		}

		// Token: 0x06003212 RID: 12818 RVA: 0x001D0E72 File Offset: 0x001CF072
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003213 RID: 12819 RVA: 0x001D0E7E File Offset: 0x001CF07E
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001FB6 RID: 8118
		private FileDeclarationOptionKind _optionKind;
	}
}
