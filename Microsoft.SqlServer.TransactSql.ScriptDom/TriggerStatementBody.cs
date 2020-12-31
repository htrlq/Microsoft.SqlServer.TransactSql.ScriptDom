using System;
using System.Collections.Generic;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
	// Token: 0x020001D9 RID: 473
	[Serializable]
	public abstract class TriggerStatementBody : TSqlStatement
	{
		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060029A4 RID: 10660 RVA: 0x001C7ABF File Offset: 0x001C5CBF
		// (set) Token: 0x060029A5 RID: 10661 RVA: 0x001C7AC7 File Offset: 0x001C5CC7
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

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060029A6 RID: 10662 RVA: 0x001C7AD7 File Offset: 0x001C5CD7
		// (set) Token: 0x060029A7 RID: 10663 RVA: 0x001C7ADF File Offset: 0x001C5CDF
		public TriggerObject TriggerObject
		{
			get
			{
				return this._triggerObject;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._triggerObject = value;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060029A8 RID: 10664 RVA: 0x001C7AEF File Offset: 0x001C5CEF
		public IList<TriggerOption> Options
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060029A9 RID: 10665 RVA: 0x001C7AF7 File Offset: 0x001C5CF7
		// (set) Token: 0x060029AA RID: 10666 RVA: 0x001C7AFF File Offset: 0x001C5CFF
		public TriggerType TriggerType
		{
			get
			{
				return this._triggerType;
			}
			set
			{
				this._triggerType = value;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060029AB RID: 10667 RVA: 0x001C7B08 File Offset: 0x001C5D08
		public IList<TriggerAction> TriggerActions
		{
			get
			{
				return this._triggerActions;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060029AC RID: 10668 RVA: 0x001C7B10 File Offset: 0x001C5D10
		// (set) Token: 0x060029AD RID: 10669 RVA: 0x001C7B18 File Offset: 0x001C5D18
		public bool WithAppend
		{
			get
			{
				return this._withAppend;
			}
			set
			{
				this._withAppend = value;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060029AE RID: 10670 RVA: 0x001C7B21 File Offset: 0x001C5D21
		// (set) Token: 0x060029AF RID: 10671 RVA: 0x001C7B29 File Offset: 0x001C5D29
		public bool IsNotForReplication
		{
			get
			{
				return this._isNotForReplication;
			}
			set
			{
				this._isNotForReplication = value;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060029B0 RID: 10672 RVA: 0x001C7B32 File Offset: 0x001C5D32
		// (set) Token: 0x060029B1 RID: 10673 RVA: 0x001C7B3A File Offset: 0x001C5D3A
		public StatementList StatementList
		{
			get
			{
				return this._statementList;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._statementList = value;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060029B2 RID: 10674 RVA: 0x001C7B4A File Offset: 0x001C5D4A
		// (set) Token: 0x060029B3 RID: 10675 RVA: 0x001C7B52 File Offset: 0x001C5D52
		public MethodSpecifier MethodSpecifier
		{
			get
			{
				return this._methodSpecifier;
			}
			set
			{
				base.UpdateTokenInfo(value);
				this._methodSpecifier = value;
			}
		}

		// Token: 0x060029B4 RID: 10676 RVA: 0x001C7B64 File Offset: 0x001C5D64
		public override void AcceptChildren(TSqlFragmentVisitor visitor)
		{
			if (this.Name != null)
			{
				this.Name.Accept(visitor);
			}
			if (this.TriggerObject != null)
			{
				this.TriggerObject.Accept(visitor);
			}
			int i = 0;
			int count = this.Options.Count;
			while (i < count)
			{
				this.Options[i].Accept(visitor);
				i++;
			}
			int j = 0;
			int count2 = this.TriggerActions.Count;
			while (j < count2)
			{
				this.TriggerActions[j].Accept(visitor);
				j++;
			}
			if (this.StatementList != null)
			{
				this.StatementList.Accept(visitor);
			}
			if (this.MethodSpecifier != null)
			{
				this.MethodSpecifier.Accept(visitor);
			}
			base.AcceptChildren(visitor);
		}

		// Token: 0x04001D54 RID: 7508
		private SchemaObjectName _name;

		// Token: 0x04001D55 RID: 7509
		private TriggerObject _triggerObject;

		// Token: 0x04001D56 RID: 7510
		private List<TriggerOption> _options = new List<TriggerOption>();

		// Token: 0x04001D57 RID: 7511
		private TriggerType _triggerType;

		// Token: 0x04001D58 RID: 7512
		private List<TriggerAction> _triggerActions = new List<TriggerAction>();

		// Token: 0x04001D59 RID: 7513
		private bool _withAppend;

		// Token: 0x04001D5A RID: 7514
		private bool _isNotForReplication;

		// Token: 0x04001D5B RID: 7515
		private StatementList _statementList;

		// Token: 0x04001D5C RID: 7516
		private MethodSpecifier _methodSpecifier;
	}
}
