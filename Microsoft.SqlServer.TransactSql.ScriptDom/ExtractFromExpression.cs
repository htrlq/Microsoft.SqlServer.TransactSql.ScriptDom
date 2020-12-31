using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200023C RID: 572
	[Serializable]
	public class ExtractFromExpression : ScalarExpression
	{
		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06002C12 RID: 11282 RVA: 0x001CA971 File Offset: 0x001C8B71
		// (set) Token: 0x06002C13 RID: 11283 RVA: 0x001CA979 File Offset: 0x001C8B79
		public ScalarExpression Expression
		{
			get
			{
				return this._expression;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._expression = value;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06002C14 RID: 11284 RVA: 0x001CA989 File Offset: 0x001C8B89
		// (set) Token: 0x06002C15 RID: 11285 RVA: 0x001CA991 File Offset: 0x001C8B91
		public Identifier ExtractedElement
		{
			get
			{
				return this._extractedElement;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._extractedElement = value;
			}
		}

		// Token: 0x06002C16 RID: 11286 RVA: 0x001CA9A1 File Offset: 0x001C8BA1
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002C17 RID: 11287 RVA: 0x001CA9AD File Offset: 0x001C8BAD
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Expression != null)
			{
				this.Expression.Accept(visitor);
			}
			if (this.ExtractedElement != null)
			{
				this.ExtractedElement.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E13 RID: 7699
		private ScalarExpression _expression;

		// Token: 0x04001E14 RID: 7700
		private Identifier _extractedElement;
	}
}
