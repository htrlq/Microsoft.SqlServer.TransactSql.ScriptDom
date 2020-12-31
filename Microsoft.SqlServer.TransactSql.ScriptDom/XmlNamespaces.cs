using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001E7 RID: 487
	[Serializable]
	public class XmlNamespaces : TSqlFragment
	{
		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060029FD RID: 10749 RVA: 0x001C8213 File Offset: 0x001C6413
		public IList<XmlNamespacesElement> XmlNamespacesElements
		{
			get
			{
				return this._xmlNamespacesElements;
			}
		}

		// Token: 0x060029FE RID: 10750 RVA: 0x001C821B File Offset: 0x001C641B
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x060029FF RID: 10751 RVA: 0x001C8228 File Offset: 0x001C6428
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.XmlNamespacesElements.Count;
			while (i < count)
			{
				this.XmlNamespacesElements[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001D70 RID: 7536
		private List<XmlNamespacesElement> _xmlNamespacesElements = new List<XmlNamespacesElement>();
	}
}
