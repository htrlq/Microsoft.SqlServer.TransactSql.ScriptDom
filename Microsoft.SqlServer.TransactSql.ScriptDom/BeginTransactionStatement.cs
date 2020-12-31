using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000246 RID: 582
	[Serializable]
	public class BeginTransactionStatement : TransactionStatement
	{
		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06002C41 RID: 11329 RVA: 0x001CACBD File Offset: 0x001C8EBD
		// (set) Token: 0x06002C42 RID: 11330 RVA: 0x001CACC5 File Offset: 0x001C8EC5
		public bool Distributed
		{
			get
			{
				return this._distributed;
			}
			set
			{
				this._distributed = value;
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06002C43 RID: 11331 RVA: 0x001CACCE File Offset: 0x001C8ECE
		// (set) Token: 0x06002C44 RID: 11332 RVA: 0x001CACD6 File Offset: 0x001C8ED6
		public bool MarkDefined
		{
			get
			{
				return this._markDefined;
			}
			set
			{
				this._markDefined = value;
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06002C45 RID: 11333 RVA: 0x001CACDF File Offset: 0x001C8EDF
		// (set) Token: 0x06002C46 RID: 11334 RVA: 0x001CACE7 File Offset: 0x001C8EE7
		public ValueExpression MarkDescription
		{
			get
			{
				return this._markDescription;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._markDescription = value;
			}
		}

		// Token: 0x06002C47 RID: 11335 RVA: 0x001CACF7 File Offset: 0x001C8EF7
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002C48 RID: 11336 RVA: 0x001CAD03 File Offset: 0x001C8F03
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.MarkDescription != null)
			{
				this.MarkDescription.Accept(visitor);
			}
		}

		// Token: 0x04001E1D RID: 7709
		private bool _distributed;

		// Token: 0x04001E1E RID: 7710
		private bool _markDefined;

		// Token: 0x04001E1F RID: 7711
		private ValueExpression _markDescription;
	}
}
