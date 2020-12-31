using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000237 RID: 567
	[Serializable]
	public class PartitionFunctionCall : PrimaryExpression
	{
		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06002BF0 RID: 11248 RVA: 0x001CA6D5 File Offset: 0x001C88D5
		// (set) Token: 0x06002BF1 RID: 11249 RVA: 0x001CA6DD File Offset: 0x001C88DD
		public Identifier DatabaseName
		{
			get
			{
				return this._databaseName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._databaseName = value;
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06002BF2 RID: 11250 RVA: 0x001CA6ED File Offset: 0x001C88ED
		// (set) Token: 0x06002BF3 RID: 11251 RVA: 0x001CA6F5 File Offset: 0x001C88F5
		public Identifier FunctionName
		{
			get
			{
				return this._functionName;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._functionName = value;
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06002BF4 RID: 11252 RVA: 0x001CA705 File Offset: 0x001C8905
		public IList<ScalarExpression> Parameters
		{
			get
			{
				return this._parameters;
			}
		}

		// Token: 0x06002BF5 RID: 11253 RVA: 0x001CA70D File Offset: 0x001C890D
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002BF6 RID: 11254 RVA: 0x001CA71C File Offset: 0x001C891C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.DatabaseName != null)
			{
				this.DatabaseName.Accept(visitor);
			}
			if (this.FunctionName != null)
			{
				this.FunctionName.Accept(visitor);
			}
			int i = 0;
			int count = this.Parameters.Count;
			while (i < count)
			{
				this.Parameters[i].Accept(visitor);
				i++;
			}
		}

		// Token: 0x04001E08 RID: 7688
		private Identifier _databaseName;

		// Token: 0x04001E09 RID: 7689
		private Identifier _functionName;

		// Token: 0x04001E0A RID: 7690
		private List<ScalarExpression> _parameters = new List<ScalarExpression>();
	}
}
