using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000D5 RID: 213
	[Serializable]
	public abstract class PrimaryExpression : ScalarExpression, ICollationSetter
	{
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000253 RID: 595 RVA: 0x00008446 File Offset: 0x00006646
		// (set) Token: 0x06000254 RID: 596 RVA: 0x0000844E File Offset: 0x0000664E
		public Identifier Collation
		{
			get
			{
				return this._collation;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._collation = value;
			}
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000845E File Offset: 0x0000665E
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Collation != null)
			{
				this.Collation.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04000B67 RID: 2919
		private Identifier _collation;
	}
}
