using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001E2 RID: 482
	[Serializable]
	public abstract class FunctionStatementBody : ProcedureStatementBodyBase
	{
		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060029E0 RID: 10720 RVA: 0x001C8048 File Offset: 0x001C6248
		// (set) Token: 0x060029E1 RID: 10721 RVA: 0x001C8050 File Offset: 0x001C6250
		public SchemaObjectName Name
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

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060029E2 RID: 10722 RVA: 0x001C8060 File Offset: 0x001C6260
		// (set) Token: 0x060029E3 RID: 10723 RVA: 0x001C8068 File Offset: 0x001C6268
		public FunctionReturnType ReturnType
		{
			get
			{
				return this._returnType;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._returnType = value;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060029E4 RID: 10724 RVA: 0x001C8078 File Offset: 0x001C6278
		public IList<FunctionOption> Options
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060029E5 RID: 10725 RVA: 0x001C8080 File Offset: 0x001C6280
		// (set) Token: 0x060029E6 RID: 10726 RVA: 0x001C8088 File Offset: 0x001C6288
		public OrderBulkInsertOption OrderHint
		{
			get
			{
				return this._orderHint;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._orderHint = value;
			}
		}

		// Token: 0x060029E7 RID: 10727 RVA: 0x001C8098 File Offset: 0x001C6298
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			base.AcceptChildren(visitor);
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			if (this.ReturnType != null)
			{
				this.ReturnType.Accept(visitor);
			}
			int i = 0;
			int count = this.Options.Count;
			while (i < count)
			{
				this.Options[i].Accept(visitor);
				i++;
			}
			if (this.OrderHint != null)
			{
				this.OrderHint.Accept(visitor);
			}
		}

		// Token: 0x04001D68 RID: 7528
		private SchemaObjectName _name;

		// Token: 0x04001D69 RID: 7529
		private FunctionReturnType _returnType;

		// Token: 0x04001D6A RID: 7530
		private List<FunctionOption> _options = new List<FunctionOption>();

		// Token: 0x04001D6B RID: 7531
		private OrderBulkInsertOption _orderHint;
	}
}
