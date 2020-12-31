using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000366 RID: 870
	[Serializable]
	public class ParameterizationDatabaseOption : DatabaseOption
	{
		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x060032E0 RID: 13024 RVA: 0x001D1927 File Offset: 0x001CFB27
		// (set) Token: 0x060032E1 RID: 13025 RVA: 0x001D192F File Offset: 0x001CFB2F
		public bool IsSimple
		{
			get
			{
				return this._isSimple;
			}
			set
			{
				this._isSimple = value;
			}
		}

		// Token: 0x060032E2 RID: 13026 RVA: 0x001D1938 File Offset: 0x001CFB38
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060032E3 RID: 13027 RVA: 0x001D1944 File Offset: 0x001CFB44
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001FF0 RID: 8176
		private bool _isSimple;
	}
}
