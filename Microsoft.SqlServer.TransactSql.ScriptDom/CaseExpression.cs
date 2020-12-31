using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200021B RID: 539
	[Serializable]
	public abstract class CaseExpression : PrimaryExpression
	{
		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06002B19 RID: 11033 RVA: 0x001C961E File Offset: 0x001C781E
		// (set) Token: 0x06002B1A RID: 11034 RVA: 0x001C9626 File Offset: 0x001C7826
		public ScalarExpression ElseExpression
		{
			get
			{
				return this._elseExpression;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._elseExpression = value;
			}
		}

		// Token: 0x06002B1B RID: 11035 RVA: 0x001C9636 File Offset: 0x001C7836
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.ElseExpression != null)
			{
				this.ElseExpression.Accept(visitor);
			}
		}

		// Token: 0x04001DC0 RID: 7616
		private ScalarExpression _elseExpression;
	}
}
