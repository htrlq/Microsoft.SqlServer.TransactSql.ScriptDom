using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000207 RID: 519
	[Serializable]
	public class InPredicate : BooleanExpression
	{
		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06002AA5 RID: 10917 RVA: 0x001C8DBC File Offset: 0x001C6FBC
		// (set) Token: 0x06002AA6 RID: 10918 RVA: 0x001C8DC4 File Offset: 0x001C6FC4
		public ScalarExpression Expression
		{
			get
			{
				return this._expression;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._expression = value;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06002AA7 RID: 10919 RVA: 0x001C8DD4 File Offset: 0x001C6FD4
		// (set) Token: 0x06002AA8 RID: 10920 RVA: 0x001C8DDC File Offset: 0x001C6FDC
		public ScalarSubquery Subquery
		{
			get
			{
				return this._subquery;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._subquery = value;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06002AA9 RID: 10921 RVA: 0x001C8DEC File Offset: 0x001C6FEC
		// (set) Token: 0x06002AAA RID: 10922 RVA: 0x001C8DF4 File Offset: 0x001C6FF4
		public bool NotDefined
		{
			get
			{
				return this._notDefined;
			}
			set
			{
				this._notDefined = value;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06002AAB RID: 10923 RVA: 0x001C8DFD File Offset: 0x001C6FFD
		public IList<ScalarExpression> Values
		{
			get
			{
				return this._values;
			}
		}

		// Token: 0x06002AAC RID: 10924 RVA: 0x001C8E05 File Offset: 0x001C7005
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002AAD RID: 10925 RVA: 0x001C8E14 File Offset: 0x001C7014
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Expression != null)
			{
				this.Expression.Accept(visitor);
			}
			if (this.Subquery != null)
			{
				this.Subquery.Accept(visitor);
			}
			int i = 0;
			int count = this.Values.Count;
			while (i < count)
			{
				this.Values[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001D9E RID: 7582
		private ScalarExpression _expression;

		// Token: 0x04001D9F RID: 7583
		private ScalarSubquery _subquery;

		// Token: 0x04001DA0 RID: 7584
		private bool _notDefined;

		// Token: 0x04001DA1 RID: 7585
		private List<ScalarExpression> _values = new List<ScalarExpression>();
	}
}
