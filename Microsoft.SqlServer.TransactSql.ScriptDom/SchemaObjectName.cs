using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200007D RID: 125
	[Serializable]
	public class SchemaObjectName : MultiPartIdentifier
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x00007059 File Offset: 0x00005259
		public virtual Identifier ServerIdentifier
		{
			get
			{
				return this.ChooseIdentifier(4);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x00007062 File Offset: 0x00005262
		public virtual Identifier DatabaseIdentifier
		{
			get
			{
				return this.ChooseIdentifier(3);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x0000706B File Offset: 0x0000526B
		public virtual Identifier SchemaIdentifier
		{
			get
			{
				return this.ChooseIdentifier(2);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00007074 File Offset: 0x00005274
		public virtual Identifier BaseIdentifier
		{
			get
			{
				return this.ChooseIdentifier(1);
			}
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00007080 File Offset: 0x00005280
		protected Identifier ChooseIdentifier(int modifier)
		{
			int num = base.Identifiers.Count - modifier;
			if (num < 0)
			{
				return null;
			}
			return base.Identifiers[num];
		}

		// Token: 0x060001FA RID: 506 RVA: 0x000070AD File Offset: 0x000052AD
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060001FB RID: 507 RVA: 0x000070B9 File Offset: 0x000052B9
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04000254 RID: 596
		private const int MaxIdentifiers = 5;

		// Token: 0x04000255 RID: 597
		private const int ServerModifier = 4;

		// Token: 0x04000256 RID: 598
		private const int DatabaseModifier = 3;

		// Token: 0x04000257 RID: 599
		private const int SchemaModifier = 2;

		// Token: 0x04000258 RID: 600
		private const int BaseModifier = 1;
	}
}
