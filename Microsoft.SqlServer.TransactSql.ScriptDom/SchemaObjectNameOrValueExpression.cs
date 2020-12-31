using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200028B RID: 651
	[Serializable]
	public class SchemaObjectNameOrValueExpression : TSqlFragment
	{
		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06002DE0 RID: 11744 RVA: 0x001CC8CD File Offset: 0x001CAACD
		// (set) Token: 0x06002DE1 RID: 11745 RVA: 0x001CC8D5 File Offset: 0x001CAAD5
		public SchemaObjectName SchemaObjectName
		{
			get
			{
				return this._schemaObjectName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._schemaObjectName = value;
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06002DE2 RID: 11746 RVA: 0x001CC8E5 File Offset: 0x001CAAE5
		// (set) Token: 0x06002DE3 RID: 11747 RVA: 0x001CC8ED File Offset: 0x001CAAED
		public ValueExpression ValueExpression
		{
			get
			{
				return this._valueExpression;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._valueExpression = value;
			}
		}

		// Token: 0x06002DE4 RID: 11748 RVA: 0x001CC8FD File Offset: 0x001CAAFD
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002DE5 RID: 11749 RVA: 0x001CC909 File Offset: 0x001CAB09
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.SchemaObjectName != null)
			{
				this.SchemaObjectName.Accept(visitor);
			}
			if (this.ValueExpression != null)
			{
				this.ValueExpression.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E91 RID: 7825
		private SchemaObjectName _schemaObjectName;

		// Token: 0x04001E92 RID: 7826
		private ValueExpression _valueExpression;
	}
}
