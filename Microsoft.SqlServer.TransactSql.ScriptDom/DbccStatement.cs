using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x02000394 RID: 916
	[Serializable]
	public class DbccStatement : TSqlStatement
	{
		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06003426 RID: 13350 RVA: 0x001D2F4B File Offset: 0x001D114B
		// (set) Token: 0x06003427 RID: 13351 RVA: 0x001D2F53 File Offset: 0x001D1153
		public string DllName
		{
			get
			{
				return this._dllName;
			}
			set
			{
				this._dllName = value;
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06003428 RID: 13352 RVA: 0x001D2F5C File Offset: 0x001D115C
		// (set) Token: 0x06003429 RID: 13353 RVA: 0x001D2F64 File Offset: 0x001D1164
		public DbccCommand Command
		{
			get
			{
				return this._command;
			}
			set
			{
				this._command = value;
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x0600342A RID: 13354 RVA: 0x001D2F6D File Offset: 0x001D116D
		// (set) Token: 0x0600342B RID: 13355 RVA: 0x001D2F75 File Offset: 0x001D1175
		public bool ParenthesisRequired
		{
			get
			{
				return this._parenthesisRequired;
			}
			set
			{
				this._parenthesisRequired = value;
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x0600342C RID: 13356 RVA: 0x001D2F7E File Offset: 0x001D117E
		public IList<DbccNamedLiteral> Literals
		{
			get
			{
				return this._literals;
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x0600342D RID: 13357 RVA: 0x001D2F86 File Offset: 0x001D1186
		public IList<DbccOption> Options
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x0600342E RID: 13358 RVA: 0x001D2F8E File Offset: 0x001D118E
		// (set) Token: 0x0600342F RID: 13359 RVA: 0x001D2F96 File Offset: 0x001D1196
		public bool OptionsUseJoin
		{
			get
			{
				return this._optionsUseJoin;
			}
			set
			{
				this._optionsUseJoin = value;
			}
		}

		// Token: 0x06003430 RID: 13360 RVA: 0x001D2F9F File Offset: 0x001D119F
		public override void Accept(TSqlFragmentVisitor visitor)
		{
			if (visitor != null)
			{
				visitor.ExplicitVisit(this);
			}
		}

		// Token: 0x06003431 RID: 13361 RVA: 0x001D2FAC File Offset: 0x001D11AC
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			int i = 0;
			int count = this.Literals.Count;
			while (i < count)
			{
				this.Literals[i].Accept(visitor);
				i++;
			}
			int j = 0;
			int count2 = this.Options.Count;
			while (j < count2)
			{
				this.Options[j].Accept(visitor);
				j++;
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x0400205A RID: 8282
		private string _dllName;

		// Token: 0x0400205B RID: 8283
		private DbccCommand _command;

		// Token: 0x0400205C RID: 8284
		private bool _parenthesisRequired;

		// Token: 0x0400205D RID: 8285
		private List<DbccNamedLiteral> _literals = new List<DbccNamedLiteral>();

		// Token: 0x0400205E RID: 8286
		private List<DbccOption> _options = new List<DbccOption>();

		// Token: 0x0400205F RID: 8287
		private bool _optionsUseJoin;
	}
}
