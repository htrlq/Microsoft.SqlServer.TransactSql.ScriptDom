using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001C5 RID: 453
	[Serializable]
	public class ResultSetDefinition : TSqlFragment
	{
		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600292B RID: 10539 RVA: 0x001C7301 File Offset: 0x001C5501
		// (set) Token: 0x0600292C RID: 10540 RVA: 0x001C7309 File Offset: 0x001C5509
		public ResultSetType ResultSetType
		{
			get
			{
				return this._resultSetType;
			}
			set
			{
				this._resultSetType = value;
			}
		}

		// Token: 0x0600292D RID: 10541 RVA: 0x001C7312 File Offset: 0x001C5512
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600292E RID: 10542 RVA: 0x001C731E File Offset: 0x001C551E
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001D32 RID: 7474
		private ResultSetType _resultSetType;
	}
}
