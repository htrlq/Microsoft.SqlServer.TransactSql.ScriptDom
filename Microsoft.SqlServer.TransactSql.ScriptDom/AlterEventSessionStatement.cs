using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020004B5 RID: 1205
	[Serializable]
	public class AlterEventSessionStatement : EventSessionStatement
	{
		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06003AD6 RID: 15062 RVA: 0x001D9AAE File Offset: 0x001D7CAE
		// (set) Token: 0x06003AD7 RID: 15063 RVA: 0x001D9AB6 File Offset: 0x001D7CB6
		public AlterEventSessionStatementType StatementType
		{
			get
			{
				return this._statementType;
			}
			set
			{
				this._statementType = value;
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06003AD8 RID: 15064 RVA: 0x001D9ABF File Offset: 0x001D7CBF
		public IList<EventSessionObjectName> DropEventDeclarations
		{
			get
			{
				return this._dropEventDeclarations;
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06003AD9 RID: 15065 RVA: 0x001D9AC7 File Offset: 0x001D7CC7
		public IList<EventSessionObjectName> DropTargetDeclarations
		{
			get
			{
				return this._dropTargetDeclarations;
			}
		}

		// Token: 0x06003ADA RID: 15066 RVA: 0x001D9ACF File Offset: 0x001D7CCF
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003ADB RID: 15067 RVA: 0x001D9ADC File Offset: 0x001D7CDC
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			int i = 0;
			int count = this.DropEventDeclarations.Count;
			while (i < count)
			{
				this.DropEventDeclarations[i].Accept(visitor);
				i++;
			}
			int j = 0;
			int count2 = this.DropTargetDeclarations.Count;
			while (j < count2)
			{
				this.DropTargetDeclarations[j].Accept(visitor);
				j++;
			}
		}

		// Token: 0x04002234 RID: 8756
		private AlterEventSessionStatementType _statementType;

		// Token: 0x04002235 RID: 8757
		private List<EventSessionObjectName> _dropEventDeclarations = new List<EventSessionObjectName>();

		// Token: 0x04002236 RID: 8758
		private List<EventSessionObjectName> _dropTargetDeclarations = new List<EventSessionObjectName>();
	}
}
