using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000266 RID: 614
	[Serializable]
	public class LineNoStatement : TSqlStatement
	{
		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06002D10 RID: 11536 RVA: 0x001CBA89 File Offset: 0x001C9C89
		// (set) Token: 0x06002D11 RID: 11537 RVA: 0x001CBA91 File Offset: 0x001C9C91
		public IntegerLiteral LineNo
		{
			get
			{
				return this._lineNo;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._lineNo = value;
			}
		}

		// Token: 0x06002D12 RID: 11538 RVA: 0x001CBAA1 File Offset: 0x001C9CA1
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002D13 RID: 11539 RVA: 0x001CBAAD File Offset: 0x001C9CAD
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.LineNo != null)
			{
				this.LineNo.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E58 RID: 7768
		private IntegerLiteral _lineNo;
	}
}
