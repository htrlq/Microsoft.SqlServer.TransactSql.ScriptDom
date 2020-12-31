using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200007E RID: 126
	[Serializable]
	public class ChildObjectName : SchemaObjectName
	{
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060001FD RID: 509 RVA: 0x000070CA File Offset: 0x000052CA
		public override Identifier BaseIdentifier
		{
			get
			{
				return base.ChooseIdentifier(2);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060001FE RID: 510 RVA: 0x000070D3 File Offset: 0x000052D3
		public override Identifier DatabaseIdentifier
		{
			get
			{
				return base.ChooseIdentifier(4);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060001FF RID: 511 RVA: 0x000070DC File Offset: 0x000052DC
		public override Identifier SchemaIdentifier
		{
			get
			{
				return base.ChooseIdentifier(3);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000200 RID: 512 RVA: 0x000070E5 File Offset: 0x000052E5
		public override Identifier ServerIdentifier
		{
			get
			{
				return base.ChooseIdentifier(5);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000201 RID: 513 RVA: 0x000070EE File Offset: 0x000052EE
		public virtual Identifier ChildIdentifier
		{
			get
			{
				return base.ChooseIdentifier(1);
			}
		}

		// Token: 0x06000202 RID: 514 RVA: 0x000070F7 File Offset: 0x000052F7
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00007103 File Offset: 0x00005303
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}

		// Token: 0x04000259 RID: 601
		private const int ServerModifierNumber = 5;

		// Token: 0x0400025A RID: 602
		private const int DatabaseModifierNumber = 4;

		// Token: 0x0400025B RID: 603
		private const int SchemaModifierNumber = 3;

		// Token: 0x0400025C RID: 604
		private const int BaseModifierNumber = 2;

		// Token: 0x0400025D RID: 605
		private const int ChildModifierNumber = 1;
	}
}
