using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200034A RID: 842
	[Serializable]
	public class MaxSizeFileDeclarationOption : FileDeclarationOption
	{
		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06003228 RID: 12840 RVA: 0x001D0F8C File Offset: 0x001CF18C
		// (set) Token: 0x06003229 RID: 12841 RVA: 0x001D0F94 File Offset: 0x001CF194
		public Literal MaxSize
		{
			get
			{
				return this._maxSize;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._maxSize = value;
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x0600322A RID: 12842 RVA: 0x001D0FA4 File Offset: 0x001CF1A4
		// (set) Token: 0x0600322B RID: 12843 RVA: 0x001D0FAC File Offset: 0x001CF1AC
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

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x0600322C RID: 12844 RVA: 0x001D0FB5 File Offset: 0x001CF1B5
		// (set) Token: 0x0600322D RID: 12845 RVA: 0x001D0FBD File Offset: 0x001CF1BD
		public bool Unlimited
		{
			get
			{
				return this._unlimited;
			}
			set
			{
				this._unlimited = value;
			}
		}

		// Token: 0x0600322E RID: 12846 RVA: 0x001D0FC6 File Offset: 0x001CF1C6
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600322F RID: 12847 RVA: 0x001D0FD2 File Offset: 0x001CF1D2
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.MaxSize != null)
			{
				this.MaxSize.Accept(visitor);
			}
		}

		// Token: 0x04001FBC RID: 8124
		private Literal _maxSize;

		// Token: 0x04001FBD RID: 8125
		private MemoryUnit _units;

		// Token: 0x04001FBE RID: 8126
		private bool _unlimited;
	}
}
