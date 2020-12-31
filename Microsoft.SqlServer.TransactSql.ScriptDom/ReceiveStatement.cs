using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200044D RID: 1101
	[Serializable]
	public class ReceiveStatement : WaitForSupportedStatement
	{
		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06003889 RID: 14473 RVA: 0x001D7747 File Offset: 0x001D5947
		// (set) Token: 0x0600388A RID: 14474 RVA: 0x001D774F File Offset: 0x001D594F
		public ScalarExpression Top
		{
			get
			{
				return this._top;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._top = value;
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x0600388B RID: 14475 RVA: 0x001D775F File Offset: 0x001D595F
		public IList<SelectElement> SelectElements
		{
			get
			{
				return this._selectElements;
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x0600388C RID: 14476 RVA: 0x001D7767 File Offset: 0x001D5967
		// (set) Token: 0x0600388D RID: 14477 RVA: 0x001D776F File Offset: 0x001D596F
		public SchemaObjectName Queue
		{
			get
			{
				return this._queue;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._queue = value;
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x0600388E RID: 14478 RVA: 0x001D777F File Offset: 0x001D597F
		// (set) Token: 0x0600388F RID: 14479 RVA: 0x001D7787 File Offset: 0x001D5987
		public VariableTableReference Into
		{
			get
			{
				return this._into;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._into = value;
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06003890 RID: 14480 RVA: 0x001D7797 File Offset: 0x001D5997
		// (set) Token: 0x06003891 RID: 14481 RVA: 0x001D779F File Offset: 0x001D599F
		public ValueExpression Where
		{
			get
			{
				return this._where;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._where = value;
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06003892 RID: 14482 RVA: 0x001D77AF File Offset: 0x001D59AF
		// (set) Token: 0x06003893 RID: 14483 RVA: 0x001D77B7 File Offset: 0x001D59B7
		public bool IsConversationGroupIdWhere
		{
			get
			{
				return this._isConversationGroupIdWhere;
			}
			set
			{
				this._isConversationGroupIdWhere = value;
			}
		}

		// Token: 0x06003894 RID: 14484 RVA: 0x001D77C0 File Offset: 0x001D59C0
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003895 RID: 14485 RVA: 0x001D77CC File Offset: 0x001D59CC
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Top != null)
			{
				this.Top.Accept(visitor);
			}
			int i = 0;
			int count = this.SelectElements.Count;
			while (i < count)
			{
				this.SelectElements[i].Accept(visitor);
				i++;
			}
			if (this.Queue != null)
			{
				this.Queue.Accept(visitor);
			}
			if (this.Into != null)
			{
				this.Into.Accept(visitor);
			}
			if (this.Where != null)
			{
				this.Where.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04002197 RID: 8599
		private ScalarExpression _top;

		// Token: 0x04002198 RID: 8600
		private List<SelectElement> _selectElements = new List<SelectElement>();

		// Token: 0x04002199 RID: 8601
		private SchemaObjectName _queue;

		// Token: 0x0400219A RID: 8602
		private VariableTableReference _into;

		// Token: 0x0400219B RID: 8603
		private ValueExpression _where;

		// Token: 0x0400219C RID: 8604
		private bool _isConversationGroupIdWhere;
	}
}
