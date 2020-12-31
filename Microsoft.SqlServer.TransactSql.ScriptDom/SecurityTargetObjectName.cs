using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200026E RID: 622
	[Serializable]
	public class SecurityTargetObjectName : TSqlFragment
	{
		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06002D44 RID: 11588 RVA: 0x001CBFAD File Offset: 0x001CA1AD
		// (set) Token: 0x06002D45 RID: 11589 RVA: 0x001CBFB5 File Offset: 0x001CA1B5
		public MultiPartIdentifier MultiPartIdentifier
		{
			get
			{
				return this._multiPartIdentifier;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._multiPartIdentifier = value;
			}
		}

		// Token: 0x06002D46 RID: 11590 RVA: 0x001CBFC5 File Offset: 0x001CA1C5
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002D47 RID: 11591 RVA: 0x001CBFD1 File Offset: 0x001CA1D1
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.MultiPartIdentifier != null)
			{
				this.MultiPartIdentifier.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001E69 RID: 7785
		private MultiPartIdentifier _multiPartIdentifier;
	}
}
