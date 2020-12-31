using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001E9 RID: 489
	[Serializable]
	public class XmlNamespacesDefaultElement : XmlNamespacesElement
	{
		// Token: 0x06002A05 RID: 10757 RVA: 0x001C82B6 File Offset: 0x001C64B6
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002A06 RID: 10758 RVA: 0x001C82C2 File Offset: 0x001C64C2
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
