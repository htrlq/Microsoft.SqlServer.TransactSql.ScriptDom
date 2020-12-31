using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200041E RID: 1054
	[Serializable]
	public class AlterPartitionSchemeStatement : TSqlStatement
	{
		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x0600377F RID: 14207 RVA: 0x001D676F File Offset: 0x001D496F
		// (set) Token: 0x06003780 RID: 14208 RVA: 0x001D6777 File Offset: 0x001D4977
		public Identifier Name
		{
			get
			{
				return this._name;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._name = value;
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06003781 RID: 14209 RVA: 0x001D6787 File Offset: 0x001D4987
		// (set) Token: 0x06003782 RID: 14210 RVA: 0x001D678F File Offset: 0x001D498F
		public IdentifierOrValueExpression FileGroup
		{
			get
			{
				return this._fileGroup;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._fileGroup = value;
			}
		}

		// Token: 0x06003783 RID: 14211 RVA: 0x001D679F File Offset: 0x001D499F
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003784 RID: 14212 RVA: 0x001D67AB File Offset: 0x001D49AB
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			if (this.FileGroup != null)
			{
				this.FileGroup.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002152 RID: 8530
		private Identifier _name;

		// Token: 0x04002153 RID: 8531
		private IdentifierOrValueExpression _fileGroup;
	}
}
