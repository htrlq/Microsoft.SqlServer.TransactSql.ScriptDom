using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000230 RID: 560
	[Serializable]
	public class FunctionCall : PrimaryExpression
	{
		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06002BC9 RID: 11209 RVA: 0x001CA3F2 File Offset: 0x001C85F2
		// (set) Token: 0x06002BCA RID: 11210 RVA: 0x001CA3FA File Offset: 0x001C85FA
		public CallTarget CallTarget
		{
			get
			{
				return this._callTarget;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._callTarget = value;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06002BCB RID: 11211 RVA: 0x001CA40A File Offset: 0x001C860A
		// (set) Token: 0x06002BCC RID: 11212 RVA: 0x001CA412 File Offset: 0x001C8612
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

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06002BCD RID: 11213 RVA: 0x001CA422 File Offset: 0x001C8622
		public IList<ScalarExpression> Parameters
		{
			get
			{
				return this._parameters;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06002BCE RID: 11214 RVA: 0x001CA42A File Offset: 0x001C862A
		// (set) Token: 0x06002BCF RID: 11215 RVA: 0x001CA432 File Offset: 0x001C8632
		public UniqueRowFilter UniqueRowFilter
		{
			get
			{
				return this._uniqueRowFilter;
			}
			set
			{
				this._uniqueRowFilter = value;
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06002BD0 RID: 11216 RVA: 0x001CA43B File Offset: 0x001C863B
		// (set) Token: 0x06002BD1 RID: 11217 RVA: 0x001CA443 File Offset: 0x001C8643
		public OverClause OverClause
		{
			get
			{
				return this._overClause;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._overClause = value;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06002BD2 RID: 11218 RVA: 0x001CA453 File Offset: 0x001C8653
		// (set) Token: 0x06002BD3 RID: 11219 RVA: 0x001CA45B File Offset: 0x001C865B
		public WithinGroupClause WithinGroupClause
		{
			get
			{
				return this._withinGroupClause;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._withinGroupClause = value;
			}
		}

		// Token: 0x06002BD4 RID: 11220 RVA: 0x001CA46B File Offset: 0x001C866B
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002BD5 RID: 11221 RVA: 0x001CA478 File Offset: 0x001C8678
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.CallTarget != null)
			{
				this.CallTarget.Accept(visitor);
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
			if (this.OverClause != null)
			{
				this.OverClause.Accept(visitor);
			}
			if (this.WithinGroupClause != null)
			{
				this.WithinGroupClause.Accept(visitor);
			}
		}

		// Token: 0x04001DFD RID: 7677
		private CallTarget _callTarget;

		// Token: 0x04001DFE RID: 7678
		private Identifier _functionName;

		// Token: 0x04001DFF RID: 7679
		private List<ScalarExpression> _parameters = new List<ScalarExpression>();

		// Token: 0x04001E00 RID: 7680
		private UniqueRowFilter _uniqueRowFilter;

		// Token: 0x04001E01 RID: 7681
		private OverClause _overClause;

		// Token: 0x04001E02 RID: 7682
		private WithinGroupClause _withinGroupClause;
	}
}
