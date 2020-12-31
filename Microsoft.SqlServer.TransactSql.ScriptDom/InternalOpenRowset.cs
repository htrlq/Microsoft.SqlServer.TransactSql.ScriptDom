using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000225 RID: 549
	[Serializable]
	public class InternalOpenRowset : TableReferenceWithAlias
	{
		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06002B76 RID: 11126 RVA: 0x001C9DD4 File Offset: 0x001C7FD4
		// (set) Token: 0x06002B77 RID: 11127 RVA: 0x001C9DDC File Offset: 0x001C7FDC
		public Identifier Identifier
		{
			get
			{
				return this._identifier;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._identifier = value;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06002B78 RID: 11128 RVA: 0x001C9DEC File Offset: 0x001C7FEC
		public IList<ScalarExpression> VarArgs
		{
			get
			{
				return this._varArgs;
			}
		}

		// Token: 0x06002B79 RID: 11129 RVA: 0x001C9DF4 File Offset: 0x001C7FF4
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06002B7A RID: 11130 RVA: 0x001C9E00 File Offset: 0x001C8000
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Identifier != null)
			{
				this.Identifier.Accept(visitor);
			}
			int i = 0;
			int count = this.VarArgs.Count;
			while (i < count)
			{
				this.VarArgs[i].Accept(visitor);
				i++;
			}
		}

		// Token: 0x04001DE3 RID: 7651
		private Identifier _identifier;

		// Token: 0x04001DE4 RID: 7652
		private List<ScalarExpression> _varArgs = new List<ScalarExpression>();
	}
}
