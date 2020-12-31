using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001EC RID: 492
	[Serializable]
	public class WithCtesAndXmlNamespaces : TSqlFragment
	{
		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06002A15 RID: 10773 RVA: 0x001C83D9 File Offset: 0x001C65D9
		// (set) Token: 0x06002A16 RID: 10774 RVA: 0x001C83E1 File Offset: 0x001C65E1
		public XmlNamespaces XmlNamespaces
		{
			get
			{
				return this._xmlNamespaces;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._xmlNamespaces = value;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06002A17 RID: 10775 RVA: 0x001C83F1 File Offset: 0x001C65F1
		public IList<CommonTableExpression> CommonTableExpressions
		{
			get
			{
				return this._commonTableExpressions;
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06002A18 RID: 10776 RVA: 0x001C83F9 File Offset: 0x001C65F9
		// (set) Token: 0x06002A19 RID: 10777 RVA: 0x001C8401 File Offset: 0x001C6601
		public ValueExpression ChangeTrackingContext
		{
			get
			{
				return this._changeTrackingContext;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._changeTrackingContext = value;
			}
		}

		// Token: 0x06002A1A RID: 10778 RVA: 0x001C8411 File Offset: 0x001C6611
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002A1B RID: 10779 RVA: 0x001C8420 File Offset: 0x001C6620
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.XmlNamespaces != null)
			{
				this.XmlNamespaces.Accept(visitor);
			}
			int i = 0;
			int count = this.CommonTableExpressions.Count;
			while (i < count)
			{
				this.CommonTableExpressions[i].Accept(visitor);
				i++;
			}
			if (this.ChangeTrackingContext != null)
			{
				this.ChangeTrackingContext.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001D76 RID: 7542
		private XmlNamespaces _xmlNamespaces;

		// Token: 0x04001D77 RID: 7543
		private List<CommonTableExpression> _commonTableExpressions = new List<CommonTableExpression>();

		// Token: 0x04001D78 RID: 7544
		private ValueExpression _changeTrackingContext;
	}
}
