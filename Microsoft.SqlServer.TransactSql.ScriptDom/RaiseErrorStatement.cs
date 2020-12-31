using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x0200032C RID: 812
	[Serializable]
	public class RaiseErrorStatement : TSqlStatement
	{
		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06003172 RID: 12658 RVA: 0x001D04E3 File Offset: 0x001CE6E3
		// (set) Token: 0x06003173 RID: 12659 RVA: 0x001D04EB File Offset: 0x001CE6EB
		public ScalarExpression FirstParameter
		{
			get
			{
				return this._firstParameter;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._firstParameter = value;
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06003174 RID: 12660 RVA: 0x001D04FB File Offset: 0x001CE6FB
		// (set) Token: 0x06003175 RID: 12661 RVA: 0x001D0503 File Offset: 0x001CE703
		public ScalarExpression SecondParameter
		{
			get
			{
				return this._secondParameter;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._secondParameter = value;
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06003176 RID: 12662 RVA: 0x001D0513 File Offset: 0x001CE713
		// (set) Token: 0x06003177 RID: 12663 RVA: 0x001D051B File Offset: 0x001CE71B
		public ScalarExpression ThirdParameter
		{
			get
			{
				return this._thirdParameter;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._thirdParameter = value;
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06003178 RID: 12664 RVA: 0x001D052B File Offset: 0x001CE72B
		public IList<ScalarExpression> OptionalParameters
		{
			get
			{
				return this._optionalParameters;
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06003179 RID: 12665 RVA: 0x001D0533 File Offset: 0x001CE733
		// (set) Token: 0x0600317A RID: 12666 RVA: 0x001D053B File Offset: 0x001CE73B
		public RaiseErrorOptions RaiseErrorOptions
		{
			get
			{
				return this._raiseErrorOptions;
			}
			set
			{
				this._raiseErrorOptions = value;
			}
		}

		// Token: 0x0600317B RID: 12667 RVA: 0x001D0544 File Offset: 0x001CE744
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600317C RID: 12668 RVA: 0x001D0550 File Offset: 0x001CE750
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.FirstParameter != null)
			{
				this.FirstParameter.Accept(visitor);
			}
			if (this.SecondParameter != null)
			{
				this.SecondParameter.Accept(visitor);
			}
			if (this.ThirdParameter != null)
			{
				this.ThirdParameter.Accept(visitor);
			}
			int i = 0;
			int count = this.OptionalParameters.Count;
			while (i < count)
			{
				this.OptionalParameters[i].Accept(visitor);
				i++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001F8A RID: 8074
		private ScalarExpression _firstParameter;

		// Token: 0x04001F8B RID: 8075
		private ScalarExpression _secondParameter;

		// Token: 0x04001F8C RID: 8076
		private ScalarExpression _thirdParameter;

		// Token: 0x04001F8D RID: 8077
		private List<ScalarExpression> _optionalParameters = new List<ScalarExpression>();

		// Token: 0x04001F8E RID: 8078
		private RaiseErrorOptions _raiseErrorOptions;
	}
}
