using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200023B RID: 571
	[Serializable]
	public class OdbcFunctionCall : PrimaryExpression
	{
		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06002C0A RID: 11274 RVA: 0x001CA8CC File Offset: 0x001C8ACC
		// (set) Token: 0x06002C0B RID: 11275 RVA: 0x001CA8D4 File Offset: 0x001C8AD4
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

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06002C0C RID: 11276 RVA: 0x001CA8E4 File Offset: 0x001C8AE4
		// (set) Token: 0x06002C0D RID: 11277 RVA: 0x001CA8EC File Offset: 0x001C8AEC
		public bool ParametersUsed
		{
			get
			{
				return this._parametersUsed;
			}
			set
			{
				this._parametersUsed = value;
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06002C0E RID: 11278 RVA: 0x001CA8F5 File Offset: 0x001C8AF5
		public IList<ScalarExpression> Parameters
		{
			get
			{
				return this._parameters;
			}
		}

		// Token: 0x06002C0F RID: 11279 RVA: 0x001CA8FD File Offset: 0x001C8AFD
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002C10 RID: 11280 RVA: 0x001CA90C File Offset: 0x001C8B0C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			int i = 0;
			int count = this.Parameters.Count;
			while (i < count)
			{
				this.Parameters[i].Accept(visitor);
				i++;
			}
		}

		// Token: 0x04001E10 RID: 7696
		private Identifier _name;

		// Token: 0x04001E11 RID: 7697
		private bool _parametersUsed;

		// Token: 0x04001E12 RID: 7698
		private List<ScalarExpression> _parameters = new List<ScalarExpression>();
	}
}
