using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000318 RID: 792
	[Serializable]
	public class FetchCursorStatement : CursorStatement
	{
		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06003119 RID: 12569 RVA: 0x001CFF40 File Offset: 0x001CE140
		// (set) Token: 0x0600311A RID: 12570 RVA: 0x001CFF48 File Offset: 0x001CE148
		public FetchType FetchType
		{
			get
			{
				return this._fetchType;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._fetchType = value;
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x0600311B RID: 12571 RVA: 0x001CFF58 File Offset: 0x001CE158
		public IList<VariableReference> IntoVariables
		{
			get
			{
				return this._intoVariables;
			}
		}

		// Token: 0x0600311C RID: 12572 RVA: 0x001CFF60 File Offset: 0x001CE160
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x0600311D RID: 12573 RVA: 0x001CFF6C File Offset: 0x001CE16C
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.FetchType != null)
			{
				this.FetchType.Accept(visitor);
			}
			int i = 0;
			int count = this.IntoVariables.Count;
			while (i < count)
			{
				this.IntoVariables[i].Accept(visitor);
				i++;
			}
		}

		// Token: 0x04001F78 RID: 8056
		private FetchType _fetchType;

		// Token: 0x04001F79 RID: 8057
		private List<VariableReference> _intoVariables = new List<VariableReference>();
	}
}
