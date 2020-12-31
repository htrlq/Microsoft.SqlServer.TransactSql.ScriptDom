using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000265 RID: 613
	[Serializable]
	public class WriteTextStatement : TextModificationStatement
	{
		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06002D0B RID: 11531 RVA: 0x001CBA40 File Offset: 0x001C9C40
		// (set) Token: 0x06002D0C RID: 11532 RVA: 0x001CBA48 File Offset: 0x001C9C48
		public ValueExpression SourceParameter
		{
			get
			{
				return this._sourceParameter;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._sourceParameter = value;
			}
		}

		// Token: 0x06002D0D RID: 11533 RVA: 0x001CBA58 File Offset: 0x001C9C58
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002D0E RID: 11534 RVA: 0x001CBA64 File Offset: 0x001C9C64
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.SourceParameter != null)
			{
				this.SourceParameter.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E57 RID: 7767
		private ValueExpression _sourceParameter;
	}
}
