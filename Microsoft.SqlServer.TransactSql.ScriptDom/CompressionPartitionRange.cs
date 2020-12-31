using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000379 RID: 889
	[Serializable]
	public class CompressionPartitionRange : TSqlFragment
	{
		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06003371 RID: 13169 RVA: 0x001D2269 File Offset: 0x001D0469
		// (set) Token: 0x06003372 RID: 13170 RVA: 0x001D2271 File Offset: 0x001D0471
		public ScalarExpression From
		{
			get
			{
				return this._from;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._from = value;
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06003373 RID: 13171 RVA: 0x001D2281 File Offset: 0x001D0481
		// (set) Token: 0x06003374 RID: 13172 RVA: 0x001D2289 File Offset: 0x001D0489
		public ScalarExpression To
		{
			get
			{
				return this._to;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._to = value;
			}
		}

		// Token: 0x06003375 RID: 13173 RVA: 0x001D2299 File Offset: 0x001D0499
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003376 RID: 13174 RVA: 0x001D22A5 File Offset: 0x001D04A5
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.From != null)
			{
				this.From.Accept(visitor);
			}
			if (this.To != null)
			{
				this.To.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400201F RID: 8223
		private ScalarExpression _from;

		// Token: 0x04002020 RID: 8224
		private ScalarExpression _to;
	}
}
