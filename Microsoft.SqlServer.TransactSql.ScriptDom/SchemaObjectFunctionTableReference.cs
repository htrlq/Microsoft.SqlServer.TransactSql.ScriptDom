using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001FD RID: 509
	[Serializable]
	public class SchemaObjectFunctionTableReference : TableReferenceWithAliasAndColumns
	{
		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06002A69 RID: 10857 RVA: 0x001C89DD File Offset: 0x001C6BDD
		// (set) Token: 0x06002A6A RID: 10858 RVA: 0x001C89E5 File Offset: 0x001C6BE5
		public SchemaObjectName SchemaObject
		{
			get
			{
				return this._schemaObject;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._schemaObject = value;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06002A6B RID: 10859 RVA: 0x001C89F5 File Offset: 0x001C6BF5
		public IList<ScalarExpression> Parameters
		{
			get
			{
				return this._parameters;
			}
		}

		// Token: 0x06002A6C RID: 10860 RVA: 0x001C89FD File Offset: 0x001C6BFD
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002A6D RID: 10861 RVA: 0x001C8A0C File Offset: 0x001C6C0C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.SchemaObject != null)
			{
				this.SchemaObject.Accept(visitor);
			}
			base.AcceptChildren(visitor);
			int i = 0;
			int count = this.Parameters.Count;
			while (i < count)
			{
				this.Parameters[i].Accept(visitor);
				i++;
			}
		}

		// Token: 0x04001D8D RID: 7565
		private SchemaObjectName _schemaObject;

		// Token: 0x04001D8E RID: 7566
		private List<ScalarExpression> _parameters = new List<ScalarExpression>();
	}
}
