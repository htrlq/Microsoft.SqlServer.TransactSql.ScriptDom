using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000349 RID: 841
	[Serializable]
	public class SizeFileDeclarationOption : FileDeclarationOption
	{
		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06003221 RID: 12833 RVA: 0x001D0F32 File Offset: 0x001CF132
		// (set) Token: 0x06003222 RID: 12834 RVA: 0x001D0F3A File Offset: 0x001CF13A
		public Literal Size
		{
			get
			{
				return this._size;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._size = value;
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06003223 RID: 12835 RVA: 0x001D0F4A File Offset: 0x001CF14A
		// (set) Token: 0x06003224 RID: 12836 RVA: 0x001D0F52 File Offset: 0x001CF152
		public MemoryUnit Units
		{
			get
			{
				return this._units;
			}
			set
			{
				this._units = value;
			}
		}

		// Token: 0x06003225 RID: 12837 RVA: 0x001D0F5B File Offset: 0x001CF15B
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003226 RID: 12838 RVA: 0x001D0F67 File Offset: 0x001CF167
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Size != null)
			{
				this.Size.Accept(visitor);
			}
		}

		// Token: 0x04001FBA RID: 8122
		private Literal _size;

		// Token: 0x04001FBB RID: 8123
		private MemoryUnit _units;
	}
}
