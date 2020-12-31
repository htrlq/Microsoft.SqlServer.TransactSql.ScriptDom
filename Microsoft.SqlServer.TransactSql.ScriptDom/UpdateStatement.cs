using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200025E RID: 606
	[Serializable]
	public class UpdateStatement : DataModificationStatement
	{
		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06002CCA RID: 11466 RVA: 0x001CB599 File Offset: 0x001C9799
		// (set) Token: 0x06002CCB RID: 11467 RVA: 0x001CB5A1 File Offset: 0x001C97A1
		public UpdateSpecification UpdateSpecification
		{
			get
			{
				return this._updateSpecification;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._updateSpecification = value;
			}
		}

		// Token: 0x06002CCC RID: 11468 RVA: 0x001CB5B1 File Offset: 0x001C97B1
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002CCD RID: 11469 RVA: 0x001CB5BD File Offset: 0x001C97BD
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.UpdateSpecification != null)
			{
				this.UpdateSpecification.Accept(visitor);
			}
		}

		// Token: 0x04001E40 RID: 7744
		private UpdateSpecification _updateSpecification;
	}
}
