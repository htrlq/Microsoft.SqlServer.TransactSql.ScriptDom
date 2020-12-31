using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000396 RID: 918
	[Serializable]
	public class DbccNamedLiteral : TSqlFragment
	{
		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06003438 RID: 13368 RVA: 0x001D3060 File Offset: 0x001D1260
		// (set) Token: 0x06003439 RID: 13369 RVA: 0x001D3068 File Offset: 0x001D1268
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x0600343A RID: 13370 RVA: 0x001D3071 File Offset: 0x001D1271
		// (set) Token: 0x0600343B RID: 13371 RVA: 0x001D3079 File Offset: 0x001D1279
		public ScalarExpression Value
		{
			get
			{
				return this._value;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._value = value;
			}
		}

		// Token: 0x0600343C RID: 13372 RVA: 0x001D3089 File Offset: 0x001D1289
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600343D RID: 13373 RVA: 0x001D3095 File Offset: 0x001D1295
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Value != null)
			{
				this.Value.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002061 RID: 8289
		private string _name;

		// Token: 0x04002062 RID: 8290
		private ScalarExpression _value;
	}
}
