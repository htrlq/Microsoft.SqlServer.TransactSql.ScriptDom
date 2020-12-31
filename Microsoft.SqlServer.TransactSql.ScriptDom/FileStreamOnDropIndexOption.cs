using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000321 RID: 801
	[Serializable]
	public class FileStreamOnDropIndexOption : IndexOption, IFileStreamSpecifier
	{
		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06003145 RID: 12613 RVA: 0x001D02D2 File Offset: 0x001CE4D2
		// (set) Token: 0x06003146 RID: 12614 RVA: 0x001D02DA File Offset: 0x001CE4DA
		public IdentifierOrValueExpression FileStreamOn
		{
			get
			{
				return this._fileStreamOn;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._fileStreamOn = value;
			}
		}

		// Token: 0x06003147 RID: 12615 RVA: 0x001D02EA File Offset: 0x001CE4EA
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003148 RID: 12616 RVA: 0x001D02F6 File Offset: 0x001CE4F6
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.FileStreamOn != null)
			{
				this.FileStreamOn.Accept(visitor);
			}
		}

		// Token: 0x04001F84 RID: 8068
		private IdentifierOrValueExpression _fileStreamOn;
	}
}
