using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000257 RID: 599
	[Serializable]
	public abstract class DataModificationStatement : StatementWithCtesAndXmlNamespaces
	{
		// Token: 0x06002CA3 RID: 11427 RVA: 0x001CB302 File Offset: 0x001C9502
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
		}
	}
}
