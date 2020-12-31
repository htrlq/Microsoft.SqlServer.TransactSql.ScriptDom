using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020003D1 RID: 977
	[Serializable]
	public class AlterSymmetricKeyStatement : SymmetricKeyStatement
	{
		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x060035B9 RID: 13753 RVA: 0x001D4901 File Offset: 0x001D2B01
		// (set) Token: 0x060035BA RID: 13754 RVA: 0x001D4909 File Offset: 0x001D2B09
		public bool IsAdd
		{
			get
			{
				return this._isAdd;
			}
			set
			{
				this._isAdd = value;
			}
		}

		// Token: 0x060035BB RID: 13755 RVA: 0x001D4912 File Offset: 0x001D2B12
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060035BC RID: 13756 RVA: 0x001D4920 File Offset: 0x001D2B20
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (base.Name != null)
			{
				base.Name.Accept(visitor);
			}
			int i = 0;
			int count = base.EncryptingMechanisms.Count;
			while (i < count)
			{
				base.EncryptingMechanisms[i].Accept(visitor);
				i++;
			}
		}

		// Token: 0x040020D4 RID: 8404
		private bool _isAdd;
	}
}
