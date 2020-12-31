using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003D0 RID: 976
	[Serializable]
	public class CreationDispositionKeyOption : KeyOption
	{
		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x060035B4 RID: 13748 RVA: 0x001D48D3 File Offset: 0x001D2AD3
		// (set) Token: 0x060035B5 RID: 13749 RVA: 0x001D48DB File Offset: 0x001D2ADB
		public bool IsCreateNew
		{
			get
			{
				return this._isCreateNew;
			}
			set
			{
				this._isCreateNew = value;
			}
		}

		// Token: 0x060035B6 RID: 13750 RVA: 0x001D48E4 File Offset: 0x001D2AE4
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060035B7 RID: 13751 RVA: 0x001D48F0 File Offset: 0x001D2AF0
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x040020D3 RID: 8403
		private bool _isCreateNew;
	}
}
