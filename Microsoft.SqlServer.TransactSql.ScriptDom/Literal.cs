using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020000D7 RID: 215
	[Serializable]
	public abstract class Literal : ValueExpression
	{
		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000259 RID: 601
		public abstract LiteralType LiteralType { get; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600025A RID: 602 RVA: 0x00008494 File Offset: 0x00006694
		// (set) Token: 0x0600025B RID: 603 RVA: 0x0000849C File Offset: 0x0000669C
		public string Value
		{
			get
			{
				return this._value;
			}
			set
			{
				this._value = value;
			}
		}

		// Token: 0x0600025C RID: 604 RVA: 0x000084A5 File Offset: 0x000066A5
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04000B68 RID: 2920
		private string _value;
	}
}
