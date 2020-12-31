using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200041D RID: 1053
	[Serializable]
	public class AlterPartitionFunctionStatement : TSqlStatement
	{
		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06003776 RID: 14198 RVA: 0x001D66E9 File Offset: 0x001D48E9
		// (set) Token: 0x06003777 RID: 14199 RVA: 0x001D66F1 File Offset: 0x001D48F1
		public Identifier Name
		{
			get
			{
				return this._name;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._name = value;
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06003778 RID: 14200 RVA: 0x001D6701 File Offset: 0x001D4901
		// (set) Token: 0x06003779 RID: 14201 RVA: 0x001D6709 File Offset: 0x001D4909
		public bool IsSplit
		{
			get
			{
				return this._isSplit;
			}
			set
			{
				this._isSplit = value;
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x0600377A RID: 14202 RVA: 0x001D6712 File Offset: 0x001D4912
		// (set) Token: 0x0600377B RID: 14203 RVA: 0x001D671A File Offset: 0x001D491A
		public ScalarExpression Boundary
		{
			get
			{
				return this._boundary;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._boundary = value;
			}
		}

		// Token: 0x0600377C RID: 14204 RVA: 0x001D672A File Offset: 0x001D492A
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600377D RID: 14205 RVA: 0x001D6736 File Offset: 0x001D4936
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			if (this.Boundary != null)
			{
				this.Boundary.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400214F RID: 8527
		private Identifier _name;

		// Token: 0x04002150 RID: 8528
		private bool _isSplit;

		// Token: 0x04002151 RID: 8529
		private ScalarExpression _boundary;
	}
}
